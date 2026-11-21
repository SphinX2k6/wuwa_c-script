using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000966 RID: 2406
public class ActivityRegressRoleCultivateSubView : ActivityRegressTaskSubViewBase
{
	// Token: 0x060069B5 RID: 27061 RVA: 0x0020F7C0 File Offset: 0x0020D9C0
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

	// Token: 0x060069B6 RID: 27062 RVA: 0x0020F825 File Offset: 0x0020DA25
	protected override void OnStart()
	{
		this.LoopScrollView = new LoopScrollView<ActivityRegressCultivateTaskSubViewLoopItem, IActivityRegressRoleCultivateSubViewLoopData>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<ActivityRegressCultivateTaskSubViewLoopItem>(this.CreateLoopItem), false);
	}

	// Token: 0x060069B7 RID: 27063 RVA: 0x0020F857 File Offset: 0x0020DA57
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x060069B8 RID: 27064 RVA: 0x0020F85F File Offset: 0x0020DA5F
	protected override void OnUpdate()
	{
		this.RefreshView();
	}

	// Token: 0x060069B9 RID: 27065 RVA: 0x0020F868 File Offset: 0x0020DA68
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

	// Token: 0x060069BA RID: 27066 RVA: 0x0020F8E7 File Offset: 0x0020DAE7
	protected override void OnBeforeDestroy()
	{
		LoopScrollView<ActivityRegressCultivateTaskSubViewLoopItem, IActivityRegressRoleCultivateSubViewLoopData> loopScrollView = this.LoopScrollView;
		if (loopScrollView == null)
		{
			return;
		}
		loopScrollView.ClearGridProxies();
	}

	// Token: 0x060069BB RID: 27067 RVA: 0x0020F8F9 File Offset: 0x0020DAF9
	[NullableContext(1)]
	private ActivityRegressCultivateTaskSubViewLoopItem CreateLoopItem()
	{
		return new ActivityRegressCultivateTaskSubViewLoopItem();
	}

	// Token: 0x040042E8 RID: 17128
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ActivityRegressCultivateTaskSubViewLoopItem, IActivityRegressRoleCultivateSubViewLoopData> LoopScrollView;

	// Token: 0x02006C70 RID: 27760
	private class EActivityRegressRoleCultivateSubViewComponents
	{
		// Token: 0x04023A12 RID: 145938
		public const int TxtNum = 0;

		// Token: 0x04023A13 RID: 145939
		public const int SVLoop = 1;

		// Token: 0x04023A14 RID: 145940
		public const int MissionItem = 2;
	}
}
