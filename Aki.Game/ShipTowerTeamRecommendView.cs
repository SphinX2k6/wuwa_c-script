using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029DC RID: 10716
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerTeamRecommendView : UiViewBase
{
	// Token: 0x06016340 RID: 90944 RVA: 0x0059DB30 File Offset: 0x0059BD30
	public ShipTowerTeamRecommendView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016341 RID: 90945 RVA: 0x0059DB3C File Offset: 0x0059BD3C
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

	// Token: 0x06016342 RID: 90946 RVA: 0x0059DBA5 File Offset: 0x0059BDA5
	private void InitDataParam()
	{
		object openParam = this.OpenParam;
	}

	// Token: 0x06016343 RID: 90947 RVA: 0x0059DBB0 File Offset: 0x0059BDB0
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerTeamRecommendView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerTeamRecommendView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016344 RID: 90948 RVA: 0x0059DBF3 File Offset: 0x0059BDF3
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06016345 RID: 90949 RVA: 0x0059DBFB File Offset: 0x0059BDFB
	private ShipTowerTeamRecommendItem CreateRecommendItem()
	{
		return new ShipTowerTeamRecommendItem
		{
			ClickCallBack = new Action<ShipTowerTeamRecommendItemData>(this.UseTeamRecommend)
		};
	}

	// Token: 0x06016346 RID: 90950 RVA: 0x0059DC14 File Offset: 0x0059BE14
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

	// Token: 0x06016347 RID: 90951 RVA: 0x0059DC80 File Offset: 0x0059BE80
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

	// Token: 0x0400A54A RID: 42314
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ShipTowerTeamRecommendItem, ShipTowerTeamRecommendItemData> ScrollTeam;

	// Token: 0x02009009 RID: 36873
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402EA35 RID: 191029
		public const int ScrollBarRoot = 0;

		// Token: 0x0402EA36 RID: 191030
		public const int TxtNo = 1;
	}
}
