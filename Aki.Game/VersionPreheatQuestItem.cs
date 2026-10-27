using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001570 RID: 5488
[NullableContext(1)]
[Nullable(0)]
internal class VersionPreheatQuestItem : UiPanelBase
{
	// Token: 0x06009CF5 RID: 40181 RVA: 0x0021F2D0 File Offset: 0x0021D4D0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.HandleOnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009CF6 RID: 40182 RVA: 0x0021F41C File Offset: 0x0021D61C
	protected override UniTask OnBeforeStartAsync()
	{
		VersionPreheatQuestItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VersionPreheatQuestItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009CF7 RID: 40183 RVA: 0x0021F460 File Offset: 0x0021D660
	public UniTask RefreshExternalAsync(VersionPreheatQuestData data)
	{
		VersionPreheatQuestItem.<RefreshExternalAsync>d__5 <RefreshExternalAsync>d__;
		<RefreshExternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshExternalAsync>d__.<>4__this = this;
		<RefreshExternalAsync>d__.data = data;
		<RefreshExternalAsync>d__.<>1__state = -1;
		<RefreshExternalAsync>d__.<>t__builder.Start<VersionPreheatQuestItem.<RefreshExternalAsync>d__5>(ref <RefreshExternalAsync>d__);
		return <RefreshExternalAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009CF8 RID: 40184 RVA: 0x0021F4AC File Offset: 0x0021D6AC
	private void RefreshWhenUnlock(VersionPreheatQuestData data)
	{
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(!VersionPreheatModel.Instance.IsQuestClickedById(data.Id));
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.NumberTextId, new <>z__ReadOnlySingleElementList<object>(data.NumberTextArg));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.TitleTextId, Array.Empty<object>());
		UUIItem item3 = base.GetItem(5);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(data.State == EVersionPreheatQuestState.QuestCompleted);
	}

	// Token: 0x06009CF9 RID: 40185 RVA: 0x0021F549 File Offset: 0x0021D749
	private void HandleOnClick()
	{
		this.HandleOnClickInternalAsync();
	}

	// Token: 0x06009CFA RID: 40186 RVA: 0x0021F554 File Offset: 0x0021D754
	private UniTask HandleOnClickInternalAsync()
	{
		VersionPreheatQuestItem.<HandleOnClickInternalAsync>d__8 <HandleOnClickInternalAsync>d__;
		<HandleOnClickInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleOnClickInternalAsync>d__.<>4__this = this;
		<HandleOnClickInternalAsync>d__.<>1__state = -1;
		<HandleOnClickInternalAsync>d__.<>t__builder.Start<VersionPreheatQuestItem.<HandleOnClickInternalAsync>d__8>(ref <HandleOnClickInternalAsync>d__);
		return <HandleOnClickInternalAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040044E5 RID: 17637
	private VersionPreheatQuestData PassData;

	// Token: 0x040044E6 RID: 17638
	private UiSequencePlayer Player;

	// Token: 0x02007B9B RID: 31643
	[NullableContext(0)]
	internal class EItemComponent
	{
		// Token: 0x04028A18 RID: 166424
		public const int Root = 0;

		// Token: 0x04028A19 RID: 166425
		public const int LockItem = 1;

		// Token: 0x04028A1A RID: 166426
		public const int ContentRoot = 2;

		// Token: 0x04028A1B RID: 166427
		public const int ContentNumText = 3;

		// Token: 0x04028A1C RID: 166428
		public const int ContentTitleText = 4;

		// Token: 0x04028A1D RID: 166429
		public const int ContentDoneMarkItem = 5;

		// Token: 0x04028A1E RID: 166430
		public const int RedDotItem = 6;
	}
}
