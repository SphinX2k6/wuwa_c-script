using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000A28 RID: 2600
[NullableContext(1)]
[Nullable(0)]
internal class VersionPreheatQuestItem : UiPanelBase
{
	// Token: 0x060070D3 RID: 28883 RVA: 0x00229080 File Offset: 0x00227280
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

	// Token: 0x060070D4 RID: 28884 RVA: 0x002291CC File Offset: 0x002273CC
	protected override UniTask OnBeforeStartAsync()
	{
		VersionPreheatQuestItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VersionPreheatQuestItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060070D5 RID: 28885 RVA: 0x00229210 File Offset: 0x00227410
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

	// Token: 0x060070D6 RID: 28886 RVA: 0x0022925C File Offset: 0x0022745C
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

	// Token: 0x060070D7 RID: 28887 RVA: 0x002292F9 File Offset: 0x002274F9
	private void HandleOnClick()
	{
		this.HandleOnClickInternalAsync();
	}

	// Token: 0x060070D8 RID: 28888 RVA: 0x00229304 File Offset: 0x00227504
	private UniTask HandleOnClickInternalAsync()
	{
		VersionPreheatQuestItem.<HandleOnClickInternalAsync>d__8 <HandleOnClickInternalAsync>d__;
		<HandleOnClickInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleOnClickInternalAsync>d__.<>4__this = this;
		<HandleOnClickInternalAsync>d__.<>1__state = -1;
		<HandleOnClickInternalAsync>d__.<>t__builder.Start<VersionPreheatQuestItem.<HandleOnClickInternalAsync>d__8>(ref <HandleOnClickInternalAsync>d__);
		return <HandleOnClickInternalAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400458B RID: 17803
	private VersionPreheatQuestData PassData;

	// Token: 0x0400458C RID: 17804
	private UiSequencePlayer Player;

	// Token: 0x02006D26 RID: 27942
	[NullableContext(0)]
	internal class EItemComponent
	{
		// Token: 0x04023D53 RID: 146771
		public const int Root = 0;

		// Token: 0x04023D54 RID: 146772
		public const int LockItem = 1;

		// Token: 0x04023D55 RID: 146773
		public const int ContentRoot = 2;

		// Token: 0x04023D56 RID: 146774
		public const int ContentNumText = 3;

		// Token: 0x04023D57 RID: 146775
		public const int ContentTitleText = 4;

		// Token: 0x04023D58 RID: 146776
		public const int ContentDoneMarkItem = 5;

		// Token: 0x04023D59 RID: 146777
		public const int RedDotItem = 6;
	}
}
