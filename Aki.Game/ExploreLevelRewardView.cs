using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F55 RID: 3925
public class ExploreLevelRewardView : UiViewBase
{
	// Token: 0x06009D14 RID: 40212 RVA: 0x002E8C67 File Offset: 0x002E6E67
	[NullableContext(1)]
	public ExploreLevelRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009D15 RID: 40213 RVA: 0x002E8C70 File Offset: 0x002E6E70
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickCloseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009D16 RID: 40214 RVA: 0x002E8D9C File Offset: 0x002E6F9C
	protected override UniTask OnBeforeStartAsync()
	{
		ExploreLevelRewardView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ExploreLevelRewardView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009D17 RID: 40215 RVA: 0x002E8DDF File Offset: 0x002E6FDF
	protected override void OnBeforeDestroy()
	{
		this.RewardItemList = null;
	}

	// Token: 0x06009D18 RID: 40216 RVA: 0x002E8DE8 File Offset: 0x002E6FE8
	protected override void OnAfterDestroy()
	{
		EventSystem.Instance.Emit(EEventName.OnExploreRewardShowEnd);
	}

	// Token: 0x06009D19 RID: 40217 RVA: 0x002E8DFA File Offset: 0x002E6FFA
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.ExploreLevelRewardView, null);
	}

	// Token: 0x04005D5E RID: 23902
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private RewardData<IExploreLevelRewardInfo> RewardData;

	// Token: 0x04005D5F RID: 23903
	[Nullable(2)]
	private RewardItemList RewardItemList;

	// Token: 0x02007185 RID: 29061
	private enum EChildType
	{
		// Token: 0x04024FAB RID: 151467
		ExploreLevelTexture,
		// Token: 0x04024FAC RID: 151468
		ExploreLevelNameText,
		// Token: 0x04024FAD RID: 151469
		RewardListItem,
		// Token: 0x04024FAE RID: 151470
		CloseButton,
		// Token: 0x04024FAF RID: 151471
		CurrentLevelText,
		// Token: 0x04024FB0 RID: 151472
		TargetLevelText
	}
}
