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

// Token: 0x02001A96 RID: 6806
public class ExploreLevelRewardView : UiViewBase
{
	// Token: 0x0600C903 RID: 51459 RVA: 0x002DDB1A File Offset: 0x002DBD1A
	[NullableContext(1)]
	public ExploreLevelRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C904 RID: 51460 RVA: 0x002DDB24 File Offset: 0x002DBD24
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

	// Token: 0x0600C905 RID: 51461 RVA: 0x002DDC50 File Offset: 0x002DBE50
	protected override UniTask OnBeforeStartAsync()
	{
		ExploreLevelRewardView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ExploreLevelRewardView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C906 RID: 51462 RVA: 0x002DDC93 File Offset: 0x002DBE93
	protected override void OnBeforeDestroy()
	{
		this.RewardItemList = null;
	}

	// Token: 0x0600C907 RID: 51463 RVA: 0x002DDC9C File Offset: 0x002DBE9C
	protected override void OnAfterDestroy()
	{
		EventSystem.Instance.Emit(EEventName.OnExploreRewardShowEnd);
	}

	// Token: 0x0600C908 RID: 51464 RVA: 0x002DDCAE File Offset: 0x002DBEAE
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.ExploreLevelRewardView, null);
	}

	// Token: 0x04005C8F RID: 23695
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private RewardData<IExploreLevelRewardInfo> RewardData;

	// Token: 0x04005C90 RID: 23696
	[Nullable(2)]
	private RewardItemList RewardItemList;

	// Token: 0x02007FF6 RID: 32758
	private enum EChildType
	{
		// Token: 0x04029C71 RID: 171121
		ExploreLevelTexture,
		// Token: 0x04029C72 RID: 171122
		ExploreLevelNameText,
		// Token: 0x04029C73 RID: 171123
		RewardListItem,
		// Token: 0x04029C74 RID: 171124
		CloseButton,
		// Token: 0x04029C75 RID: 171125
		CurrentLevelText,
		// Token: 0x04029C76 RID: 171126
		TargetLevelText
	}
}
