using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020025C7 RID: 9671
[NullableContext(1)]
[Nullable(0)]
public class PhotographDropDownSetup : PhotographSetupBase
{
	// Token: 0x060139E0 RID: 80352 RVA: 0x004E83BC File Offset: 0x004E65BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060139E1 RID: 80353 RVA: 0x004E8448 File Offset: 0x004E6648
	protected override UniTask OnBeforeStartAsync()
	{
		PhotographDropDownSetup.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotographDropDownSetup.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060139E2 RID: 80354 RVA: 0x004E848B File Offset: 0x004E668B
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x060139E3 RID: 80355 RVA: 0x004E84A0 File Offset: 0x004E66A0
	protected override void OnBeforeShow()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
	}

	// Token: 0x060139E4 RID: 80356 RVA: 0x004E84CD File Offset: 0x004E66CD
	public override void Initialize(EPhotoSetupValueType setupValueType)
	{
		this.SetupValueType = setupValueType;
		this.Refresh();
		this.RefreshRedDot();
	}

	// Token: 0x060139E5 RID: 80357 RVA: 0x004E84E2 File Offset: 0x004E66E2
	public override void InitializeById(int setupId)
	{
		base.InitializeById(setupId);
		this.RefreshRedDot();
	}

	// Token: 0x060139E6 RID: 80358 RVA: 0x004E84F4 File Offset: 0x004E66F4
	private void RefreshRedDot()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(base.IsPhotoSetupRedDotVisible());
	}

	// Token: 0x060139E7 RID: 80359 RVA: 0x004E851C File Offset: 0x004E671C
	public override void Refresh()
	{
		if (this.SetupConfig == null || this.SetupConfig.Value.Type != 2)
		{
			return;
		}
		string name = this.SetupConfig.Value.Name;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, name, Array.Empty<object>());
		this.RefreshDropDown();
	}

	// Token: 0x060139E8 RID: 80360 RVA: 0x004E8580 File Offset: 0x004E6780
	private void RefreshDropDown()
	{
		IReadOnlyList<PhotoDropDown> photoDropDownDataList = PhotographConfig.Instance.GetPhotoDropDownDataList(this.SetupValueType);
		List<PhotoDropDown> list = new List<PhotoDropDown>();
		for (int i = 0; i < photoDropDownDataList.Count; i++)
		{
			PhotoDropDown item = photoDropDownDataList[i];
			if (item.IsShowInLowDevice || !Info.Instance.IsLowMemoryDevice)
			{
				list.Add(item);
			}
		}
		float? photographOption = PhotographModel.Instance.GetPhotographOption(this.SetupValueType);
		int defaultIndex = -1;
		for (int j = 0; j < list.Count; j++)
		{
			float num = (float)list[j].Id;
			float? num2 = photographOption;
			if (num == num2.GetValueOrDefault() & num2 != null)
			{
				defaultIndex = j;
			}
		}
		this.DropDown.InitScroll(list, new Func<PhotoDropDown, TableTextArgNew>(this.GetDropDownTextId), defaultIndex, true);
	}

	// Token: 0x060139E9 RID: 80361 RVA: 0x004E864D File Offset: 0x004E684D
	private TableTextArgNew GetDropDownTextId(PhotoDropDown data)
	{
		return new TableTextArgNew(data.TextId, Array.Empty<object>());
	}

	// Token: 0x060139EA RID: 80362 RVA: 0x004E8660 File Offset: 0x004E6860
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer = null;
	}

	// Token: 0x060139EB RID: 80363 RVA: 0x004E8669 File Offset: 0x004E6869
	private void OnDropDownOpen()
	{
		base.MarkPhotoSetupRedDotAsRead(delegate
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		});
	}

	// Token: 0x060139EC RID: 80364 RVA: 0x004E8680 File Offset: 0x004E6880
	private void OnSelectChange(int index, PhotoDropDown data)
	{
		if (this.SetupValueType == EPhotoSetupValueType.ImageQuality)
		{
			PhotographController.Instance.SetPhotographOption((EPhotoSetupValueType)this.SetupConfig.Value.ValueType, (float)data.Id, false, true);
		}
		if (this.SetupConfig.Value.IsLocalStorage)
		{
			Dictionary<int, int> dictionary = LocalStorage.GetGlobal<Dictionary<int, int>>(ELocalStorageGlobalKey.PhotographSetupOption, null) ?? new Dictionary<int, int>();
			dictionary[(int)this.SetupValueType] = data.Id;
			LocalStorage.SetGlobal<Dictionary<int, int>>(ELocalStorageGlobalKey.PhotographSetupOption, dictionary);
		}
	}

	// Token: 0x060139ED RID: 80365 RVA: 0x004E8706 File Offset: 0x004E6906
	private OneTextDropDownItem CreateDropDownItem(UUIItem uiItem, PhotoDropDown data)
	{
		return new OneTextDropDownItem(uiItem);
	}

	// Token: 0x060139EE RID: 80366 RVA: 0x004E870E File Offset: 0x004E690E
	private OneTextTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new OneTextTitleItem(uiItem);
	}

	// Token: 0x040093F4 RID: 37876
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040093F5 RID: 37877
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, PhotoDropDown> DropDown;

	// Token: 0x02008BDA RID: 35802
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402D665 RID: 185957
		public const int OptionNameText = 0;

		// Token: 0x0402D666 RID: 185958
		public const int ItemDropDown = 1;

		// Token: 0x0402D667 RID: 185959
		public const int ItemRedDot = 2;
	}
}
