using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F57 RID: 8023
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerTeamRecommendView : UiViewBase
{
	// Token: 0x06013D46 RID: 81222 RVA: 0x005C8AE8 File Offset: 0x005C6CE8
	public ShipTowerTeamRecommendView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013D47 RID: 81223 RVA: 0x005C8AF4 File Offset: 0x005C6CF4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06013D48 RID: 81224 RVA: 0x005C8B5D File Offset: 0x005C6D5D
	private void InitDataParam()
	{
		object openParam = this.OpenParam;
	}

	// Token: 0x06013D49 RID: 81225 RVA: 0x005C8B68 File Offset: 0x005C6D68
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerTeamRecommendView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerTeamRecommendView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013D4A RID: 81226 RVA: 0x005C8BAB File Offset: 0x005C6DAB
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06013D4B RID: 81227 RVA: 0x005C8BB3 File Offset: 0x005C6DB3
	private ShipTowerTeamRecommendItem CreateRecommendItem()
	{
		return new ShipTowerTeamRecommendItem
		{
			ClickCallBack = new Action<ShipTowerTeamRecommendItemData>(this.UseTeamRecommend)
		};
	}

	// Token: 0x06013D4C RID: 81228 RVA: 0x005C8BCC File Offset: 0x005C6DCC
	public void UpdateData()
	{
		ShipTowerTeamRecommendViewParams shipTowerTeamRecommendViewParams = this.OpenParam as ShipTowerTeamRecommendViewParams;
		ShipTowerStageData shipTowerStageData = (shipTowerTeamRecommendViewParams != null) ? shipTowerTeamRecommendViewParams.StageData : null;
		List<ShipTowerTeamRecommendItemData> list = ((shipTowerStageData != null) ? shipTowerStageData.TeamRecommendList : null) ?? new List<ShipTowerTeamRecommendItemData>();
		GenericScrollViewNew<ShipTowerTeamRecommendItem, ShipTowerTeamRecommendItemData> scrollTeam = this.ScrollTeam;
		if (scrollTeam != null)
		{
			scrollTeam.RefreshByData(list, null, false);
		}
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(list.Count <= 0);
	}

	// Token: 0x06013D4D RID: 81229 RVA: 0x005C8C38 File Offset: 0x005C6E38
	private void UseTeamRecommend(ShipTowerTeamRecommendItemData data)
	{
		ShipTowerTeamRecommendViewParams shipTowerTeamRecommendViewParams = this.OpenParam as ShipTowerTeamRecommendViewParams;
		ShipTowerStageData shipTowerStageData = (shipTowerTeamRecommendViewParams != null) ? shipTowerTeamRecommendViewParams.StageData : null;
		if (shipTowerStageData == null || !shipTowerStageData.IsCanApplyTeamRecommend(data))
		{
			return;
		}
		if (shipTowerStageData == null || !shipTowerStageData.UseTeamRecommend(data))
		{
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("GhostShipTeamUsed_Text", Array.Empty<object>());
		base.CloseMe(null);
	}

	// Token: 0x0400A934 RID: 43316
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ShipTowerTeamRecommendItem, ShipTowerTeamRecommendItemData> ScrollTeam;

	// Token: 0x02008250 RID: 33360
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A12D RID: 172333
		public const int ScrollBarRoot = 0;

		// Token: 0x0402A12E RID: 172334
		public const int TxtNo = 1;
	}
}
