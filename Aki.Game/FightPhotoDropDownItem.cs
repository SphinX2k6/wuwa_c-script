using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020025B5 RID: 9653
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoDropDownItem : FightPhotoSetupBase
{
	// Token: 0x0601391F RID: 80159 RVA: 0x004E46B4 File Offset: 0x004E28B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06013920 RID: 80160 RVA: 0x004E4710 File Offset: 0x004E2910
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoDropDownItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoDropDownItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013921 RID: 80161 RVA: 0x004E4753 File Offset: 0x004E2953
	protected override void OnBeforeDestroy()
	{
		if (EventSystem.Instance.Has(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChange)))
		{
			EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChange));
		}
	}

	// Token: 0x06013922 RID: 80162 RVA: 0x004E4788 File Offset: 0x004E2988
	public override void Refresh()
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.SetupConfig.Value.Name, Array.Empty<object>());
		this.RefreshDropDown();
		this.RefreshResolutionText();
	}

	// Token: 0x06013923 RID: 80163 RVA: 0x004E47D8 File Offset: 0x004E29D8
	private int GetSelectedDropDownId()
	{
		int? fightPhotoSetupOption = FightPhotoModel.Instance.GetFightPhotoSetupOption((EFightPhotoSetupOptionType)this.SetupConfig.Value.Id);
		if (fightPhotoSetupOption == null)
		{
			return this.SetupConfig.Value.DefaultDropDownIndex;
		}
		return fightPhotoSetupOption.GetValueOrDefault();
	}

	// Token: 0x06013924 RID: 80164 RVA: 0x004E4828 File Offset: 0x004E2A28
	private void RefreshDropDown()
	{
		int[] dropDownListArray = this.SetupConfig.Value.GetDropDownListArray();
		List<PhotoDropDown> list = new List<PhotoDropDown>();
		int[] array = dropDownListArray;
		for (int i = 0; i < array.Length; i++)
		{
			PhotoDropDown? config = ConfigPhotoDropDownById.GetConfig(array[i], true);
			if (config != null && (config.Value.IsShowInLowDevice || !Info.Instance.IsLowMemoryDevice))
			{
				list.Add(config.Value);
			}
		}
		int selectedId = this.GetSelectedDropDownId();
		this.DropDown.InitScroll(list, new Func<PhotoDropDown, TableTextArgNew>(this.GetDropDownTextId), list.FindIndex((PhotoDropDown d) => d.Id == selectedId), true);
	}

	// Token: 0x06013925 RID: 80165 RVA: 0x004E48E0 File Offset: 0x004E2AE0
	private void RefreshResolutionText()
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		if (this.SetupConfig.Value.Id != 1)
		{
			text.SetUIActive(false);
			return;
		}
		PhotoDropDown? config = ConfigPhotoDropDownById.GetConfig(this.GetSelectedDropDownId(), true);
		if (config == null)
		{
			text.SetUIActive(false);
			return;
		}
		float num = float.Parse(config.Value.Param()[0]);
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		int value = (int)Math.Round((double)(viewportSize.X * num));
		int value2 = (int)Math.Round((double)(viewportSize.Y * num));
		text.SetUIActive(true);
		LguiUtil instance = LguiUtil.Instance;
		UUIText uiText = text;
		string textStringId = "FightPhoto_CurrentResolutionText";
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		defaultInterpolatedStringHandler.AppendLiteral("×");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
		instance.SetLocalTextNew(uiText, textStringId, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
	}

	// Token: 0x06013926 RID: 80166 RVA: 0x004E49C1 File Offset: 0x004E2BC1
	private TableTextArgNew GetDropDownTextId(PhotoDropDown data)
	{
		return new TableTextArgNew(data.TextId, Array.Empty<object>());
	}

	// Token: 0x06013927 RID: 80167 RVA: 0x004E49D4 File Offset: 0x004E2BD4
	private void OnSelectChange(int index, PhotoDropDown data)
	{
		base.OnSetupValueChange(data.Id);
		this.RefreshResolutionText();
	}

	// Token: 0x06013928 RID: 80168 RVA: 0x004E49E9 File Offset: 0x004E2BE9
	private void OnViewPortSizeChange()
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		this.RefreshResolutionText();
	}

	// Token: 0x06013929 RID: 80169 RVA: 0x004E49FF File Offset: 0x004E2BFF
	private OneTextDropDownItem CreateDropDownItem(UUIItem uiItem, PhotoDropDown data)
	{
		return new OneTextDropDownItem(uiItem);
	}

	// Token: 0x0601392A RID: 80170 RVA: 0x004E4A07 File Offset: 0x004E2C07
	private OneTextTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new OneTextTitleItem(uiItem);
	}

	// Token: 0x040093BE RID: 37822
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, PhotoDropDown> DropDown;

	// Token: 0x02008BB9 RID: 35769
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D5A6 RID: 185766
		ItemDropDown,
		// Token: 0x0402D5A7 RID: 185767
		TxtTitle,
		// Token: 0x0402D5A8 RID: 185768
		TextResolution
	}
}
