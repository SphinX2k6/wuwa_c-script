using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020014B2 RID: 5298
public class ActivityRegressRoleCultivateSubView : ActivityRegressTaskSubViewBase
{
	// Token: 0x06009620 RID: 38432 RVA: 0x00206854 File Offset: 0x00204A54
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x06009621 RID: 38433 RVA: 0x002068B9 File Offset: 0x00204AB9
	protected override void OnStart()
	{
		this.LoopScrollView = new LoopScrollView<ActivityRegressCultivateTaskSubViewLoopItem, IActivityRegressRoleCultivateSubViewLoopData>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<ActivityRegressCultivateTaskSubViewLoopItem>(this.CreateLoopItem), false);
	}

	// Token: 0x06009622 RID: 38434 RVA: 0x002068EB File Offset: 0x00204AEB
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x06009623 RID: 38435 RVA: 0x002068F3 File Offset: 0x00204AF3
	protected override void OnUpdate()
	{
		this.RefreshView();
	}

	// Token: 0x06009624 RID: 38436 RVA: 0x002068FC File Offset: 0x00204AFC
	private void RefreshView()
	{
		List<IActivityRegressRoleCultivateSubViewLoopData> regressCultivateLoopSvDataList = ActivityRegressModel.Instance.GetRegressCultivateLoopSvDataList();
		this.LoopScrollView.RefreshByData(regressCultivateLoopSvDataList, false, null, true);
		int value = ActivityRegressModel.Instance.CalculateRegressCultivateReachTaskCount(regressCultivateLoopSvDataList);
		LguiUtil instance = LguiUtil.Instance;
		UUIText text = base.GetText(0);
		string textStringId = "PrefabTextItem_4217661232_Text";
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(regressCultivateLoopSvDataList.Count);
		instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
	}

	// Token: 0x06009625 RID: 38437 RVA: 0x0020697B File Offset: 0x00204B7B
	protected override void OnBeforeDestroy()
	{
		LoopScrollView<ActivityRegressCultivateTaskSubViewLoopItem, IActivityRegressRoleCultivateSubViewLoopData> loopScrollView = this.LoopScrollView;
		if (loopScrollView == null)
		{
			return;
		}
		loopScrollView.ClearGridProxies();
	}

	// Token: 0x06009626 RID: 38438 RVA: 0x0020698D File Offset: 0x00204B8D
	[NullableContext(1)]
	private ActivityRegressCultivateTaskSubViewLoopItem CreateLoopItem()
	{
		return new ActivityRegressCultivateTaskSubViewLoopItem();
	}

	// Token: 0x04004250 RID: 16976
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ActivityRegressCultivateTaskSubViewLoopItem, IActivityRegressRoleCultivateSubViewLoopData> LoopScrollView;

	// Token: 0x02007AEC RID: 31468
	private class EActivityRegressRoleCultivateSubViewComponents
	{
		// Token: 0x040286F8 RID: 165624
		public const int TxtNum = 0;

		// Token: 0x040286F9 RID: 165625
		public const int SVLoop = 1;

		// Token: 0x040286FA RID: 165626
		public const int MissionItem = 2;
	}
}
