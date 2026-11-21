using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F8F RID: 3983
public class MapPlayPointDetailView : UiViewBase
{
	// Token: 0x06009FB7 RID: 40887 RVA: 0x002F2DB0 File Offset: 0x002F0FB0
	[NullableContext(1)]
	public MapPlayPointDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009FB8 RID: 40888 RVA: 0x002F2DBC File Offset: 0x002F0FBC
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

	// Token: 0x06009FB9 RID: 40889 RVA: 0x002F2F10 File Offset: 0x002F1110
	protected override UniTask OnBeforeStartAsync()
	{
		MapPlayPointDetailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MapPlayPointDetailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009FBA RID: 40890 RVA: 0x002F2F54 File Offset: 0x002F1154
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

	// Token: 0x04005E79 RID: 24185
	[Nullable(2)]
	private MapExplorePlayProgressPanel PlayProgressPanel;

	// Token: 0x04005E7A RID: 24186
	[Nullable(2)]
	private MapPlayPointDetailViewParams DataParam;

	// Token: 0x020071BF RID: 29119
	private enum EChildType
	{
		// Token: 0x040250DE RID: 151774
		ItemProgressPanel,
		// Token: 0x040250DF RID: 151775
		TxtProgressTotal,
		// Token: 0x040250E0 RID: 151776
		TxtCompleted,
		// Token: 0x040250E1 RID: 151777
		TxtToBeCompleted,
		// Token: 0x040250E2 RID: 151778
		TxtLocked,
		// Token: 0x040250E3 RID: 151779
		TxtTitle,
		// Token: 0x040250E4 RID: 151780
		TxtNormalDesc,
		// Token: 0x040250E5 RID: 151781
		TxtSpecialDesc,
		// Token: 0x040250E6 RID: 151782
		ItemSpecialRoot
	}
}
