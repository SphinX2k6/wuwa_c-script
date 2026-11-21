using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AA0 RID: 6816
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoDropDownItem : FightPhotoSetupBase
{
	// Token: 0x06010DFF RID: 69119 RVA: 0x004F32B4 File Offset: 0x004F14B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06010E00 RID: 69120 RVA: 0x004F3310 File Offset: 0x004F1510
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoDropDownItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoDropDownItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010E01 RID: 69121 RVA: 0x004F3353 File Offset: 0x004F1553
	protected override void OnBeforeDestroy()
	{
		if (EventSystem.Instance.Has(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChange)))
		{
			EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChange));
		}
	}

	// Token: 0x06010E02 RID: 69122 RVA: 0x004F3388 File Offset: 0x004F1588
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

	// Token: 0x06010E03 RID: 69123 RVA: 0x004F33D8 File Offset: 0x004F15D8
	private int GetSelectedDropDownId()
	{
		int? fightPhotoSetupOption = FightPhotoModel.Instance.GetFightPhotoSetupOption((EFightPhotoSetupOptionType)this.SetupConfig.Value.Id);
		if (fightPhotoSetupOption == null)
		{
			return this.SetupConfig.Value.DefaultDropDownIndex;
		}
		return fightPhotoSetupOption.GetValueOrDefault();
	}

	// Token: 0x06010E04 RID: 69124 RVA: 0x004F3428 File Offset: 0x004F1628
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

	// Token: 0x06010E05 RID: 69125 RVA: 0x004F34E0 File Offset: 0x004F16E0
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

	// Token: 0x06010E06 RID: 69126 RVA: 0x004F35C1 File Offset: 0x004F17C1
	private TableTextArgNew GetDropDownTextId(PhotoDropDown data)
	{
		return new TableTextArgNew(data.TextId, Array.Empty<object>());
	}

	// Token: 0x06010E07 RID: 69127 RVA: 0x004F35D4 File Offset: 0x004F17D4
	private void OnSelectChange(int index, PhotoDropDown data)
	{
		base.OnSetupValueChange(data.Id);
		this.RefreshResolutionText();
	}

	// Token: 0x06010E08 RID: 69128 RVA: 0x004F35E9 File Offset: 0x004F17E9
	private void OnViewPortSizeChange()
	{
		if (this.SetupConfig == null)
		{
			return;
		}
		this.RefreshResolutionText();
	}

	// Token: 0x06010E09 RID: 69129 RVA: 0x004F35FF File Offset: 0x004F17FF
	private OneTextDropDownItem CreateDropDownItem(UUIItem uiItem, PhotoDropDown data)
	{
		return new OneTextDropDownItem(uiItem);
	}

	// Token: 0x06010E0A RID: 69130 RVA: 0x004F3607 File Offset: 0x004F1807
	private OneTextTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new OneTextTitleItem(uiItem);
	}

	// Token: 0x04009514 RID: 38164
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, PhotoDropDown> DropDown;

	// Token: 0x02007D41 RID: 32065
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040288BB RID: 166075
		ItemDropDown,
		// Token: 0x040288BC RID: 166076
		TxtTitle,
		// Token: 0x040288BD RID: 166077
		TextResolution
	}
}
