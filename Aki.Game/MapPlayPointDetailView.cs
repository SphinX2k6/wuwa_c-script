using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AD0 RID: 6864
public class MapPlayPointDetailView : UiViewBase
{
	// Token: 0x0600CBA6 RID: 52134 RVA: 0x002E7C5C File Offset: 0x002E5E5C
	[NullableContext(1)]
	public MapPlayPointDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CBA7 RID: 52135 RVA: 0x002E7C68 File Offset: 0x002E5E68
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CBA8 RID: 52136 RVA: 0x002E7DBC File Offset: 0x002E5FBC
	protected override UniTask OnBeforeStartAsync()
	{
		MapPlayPointDetailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MapPlayPointDetailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CBA9 RID: 52137 RVA: 0x002E7E00 File Offset: 0x002E6000
	protected override void OnBeforeShow()
	{
		MapPlayPointDetailViewParams dataParam = this.DataParam;
		ExploreAreaItemData exploreAreaItemData = (dataParam != null) ? dataParam.ExploreAreaItemData : null;
		if (exploreAreaItemData == null)
		{
			return;
		}
		this.PlayProgressPanel.UpdateData(exploreAreaItemData.PlayProgressDataList, null);
		int playPointTotalCount = exploreAreaItemData.PlayPointTotalCount;
		int playPointCompletedCount = exploreAreaItemData.PlayPointCompletedCount;
		int playPointToBeCompletedCount = exploreAreaItemData.PlayPointToBeCompletedCount;
		int playPointLockedCount = exploreAreaItemData.PlayPointLockedCount;
		base.GetText(1).SetText(playPointTotalCount.ToString(), true);
		base.GetText(2).SetText(playPointCompletedCount.ToString(), true);
		base.GetText(3).SetText(playPointToBeCompletedCount.ToString(), true);
		base.GetText(4).SetText(playPointLockedCount.ToString(), true);
		base.GetText(5).SetText(exploreAreaItemData.GetPlayDetailTitle(), true);
		base.GetText(6).ShowTextNew(exploreAreaItemData.GetNameId());
		bool flag = exploreAreaItemData.HasSpecialPlayPoint();
		base.GetItem(8).SetUIActive(flag);
		if (flag)
		{
			base.GetText(7).ShowTextNew(exploreAreaItemData.SpecialPlayerDesc);
		}
	}

	// Token: 0x04005DAA RID: 23978
	[Nullable(2)]
	private MapExplorePlayProgressPanel PlayProgressPanel;

	// Token: 0x04005DAB RID: 23979
	[Nullable(2)]
	private MapPlayPointDetailViewParams DataParam;

	// Token: 0x02008031 RID: 32817
	private enum EChildType
	{
		// Token: 0x04029DAA RID: 171434
		ItemProgressPanel,
		// Token: 0x04029DAB RID: 171435
		TxtProgressTotal,
		// Token: 0x04029DAC RID: 171436
		TxtCompleted,
		// Token: 0x04029DAD RID: 171437
		TxtToBeCompleted,
		// Token: 0x04029DAE RID: 171438
		TxtLocked,
		// Token: 0x04029DAF RID: 171439
		TxtTitle,
		// Token: 0x04029DB0 RID: 171440
		TxtNormalDesc,
		// Token: 0x04029DB1 RID: 171441
		TxtSpecialDesc,
		// Token: 0x04029DB2 RID: 171442
		ItemSpecialRoot
	}
}
