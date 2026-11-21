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

// Token: 0x02001AB2 RID: 6834
[NullableContext(1)]
[Nullable(0)]
public class PhotographDropDownSetup : PhotographSetupBase
{
	// Token: 0x06010EC0 RID: 69312 RVA: 0x004F6FBC File Offset: 0x004F51BC
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

	// Token: 0x06010EC1 RID: 69313 RVA: 0x004F7048 File Offset: 0x004F5248
	protected override UniTask OnBeforeStartAsync()
	{
		PhotographDropDownSetup.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotographDropDownSetup.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010EC2 RID: 69314 RVA: 0x004F708B File Offset: 0x004F528B
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06010EC3 RID: 69315 RVA: 0x004F70A0 File Offset: 0x004F52A0
	protected override void OnBeforeShow()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
	}

	// Token: 0x06010EC4 RID: 69316 RVA: 0x004F70CD File Offset: 0x004F52CD
	public override void Initialize(EPhotoSetupValueType setupValueType)
	{
		this.SetupValueType = setupValueType;
		this.Refresh();
		this.RefreshRedDot();
	}

	// Token: 0x06010EC5 RID: 69317 RVA: 0x004F70E2 File Offset: 0x004F52E2
	public override void InitializeById(int setupId)
	{
		base.InitializeById(setupId);
		this.RefreshRedDot();
	}

	// Token: 0x06010EC6 RID: 69318 RVA: 0x004F70F4 File Offset: 0x004F52F4
	private void RefreshRedDot()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(base.IsPhotoSetupRedDotVisible());
	}

	// Token: 0x06010EC7 RID: 69319 RVA: 0x004F711C File Offset: 0x004F531C
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

	// Token: 0x06010EC8 RID: 69320 RVA: 0x004F7180 File Offset: 0x004F5380
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

	// Token: 0x06010EC9 RID: 69321 RVA: 0x004F724D File Offset: 0x004F544D
	private TableTextArgNew GetDropDownTextId(PhotoDropDown data)
	{
		return new TableTextArgNew(data.TextId, Array.Empty<object>());
	}

	// Token: 0x06010ECA RID: 69322 RVA: 0x004F7260 File Offset: 0x004F5460
	protected override void OnBeforeDestroy()
	{
		this.LevelSequencePlayer = null;
	}

	// Token: 0x06010ECB RID: 69323 RVA: 0x004F7269 File Offset: 0x004F5469
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

	// Token: 0x06010ECC RID: 69324 RVA: 0x004F7280 File Offset: 0x004F5480
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

	// Token: 0x06010ECD RID: 69325 RVA: 0x004F7306 File Offset: 0x004F5506
	private OneTextDropDownItem CreateDropDownItem(UUIItem uiItem, PhotoDropDown data)
	{
		return new OneTextDropDownItem(uiItem);
	}

	// Token: 0x06010ECE RID: 69326 RVA: 0x004F730E File Offset: 0x004F550E
	private OneTextTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new OneTextTitleItem(uiItem);
	}

	// Token: 0x0400954A RID: 38218
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400954B RID: 38219
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, PhotoDropDown> DropDown;

	// Token: 0x02007D62 RID: 32098
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402897A RID: 166266
		public const int OptionNameText = 0;

		// Token: 0x0402897B RID: 166267
		public const int ItemDropDown = 1;

		// Token: 0x0402897C RID: 166268
		public const int ItemRedDot = 2;
	}
}
