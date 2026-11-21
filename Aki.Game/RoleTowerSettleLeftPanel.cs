using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CCF RID: 7375
public class RoleTowerSettleLeftPanel : UiPanelBase
{
	// Token: 0x06012438 RID: 74808 RVA: 0x00562338 File Offset: 0x00560538
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06012439 RID: 74809 RVA: 0x005623A8 File Offset: 0x005605A8
	protected override void OnStart()
	{
		this.TimeList = new GenericScrollViewNew<RoleTowerSettleTimeItem, RoleTowerWaveRecordData>(base.GetScrollViewWithScrollbar(2), () => new RoleTowerSettleTimeItem(), null, false, null);
		AUIBaseActor auibaseActor = base.GetScrollViewWithScrollbar(2).Content.Get();
		this.TimeListAnim = (((auibaseActor != null) ? auibaseActor.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController);
	}

	// Token: 0x0601243A RID: 74810 RVA: 0x00562420 File Offset: 0x00560620
	public void Refresh()
	{
		RoleTowerSettleData lastSettle = RoleTowerModel.Instance.GetLastSettle();
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(RoleTowerTimeUtil.Format((lastSettle != null) ? lastSettle.RemainTime : 0L), true);
		}
		List<RoleTowerWaveRecordData> list = new List<RoleTowerWaveRecordData>(RoleTowerModel.Instance.GetBattleWaveRecords());
		list.Sort(delegate(RoleTowerWaveRecordData a, RoleTowerWaveRecordData b)
		{
			RoleTowerFloor? floorById = RoleTowerConfig.Instance.GetFloorById(a.FloorId);
			int num2 = (floorById != null) ? floorById.GetValueOrDefault().FloorIndex : 0;
			floorById = RoleTowerConfig.Instance.GetFloorById(b.FloorId);
			int num3 = (floorById != null) ? floorById.GetValueOrDefault().FloorIndex : 0;
			return num2 - num3;
		});
		long num = 0L;
		foreach (RoleTowerWaveRecordData roleTowerWaveRecordData in list)
		{
			num += roleTowerWaveRecordData.CostTime;
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			UUIItem uuiitem = text2;
			bool bUseChangeColor = num > 0L;
			FColor? fcolor = new FColor?(text2.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			text2.SetText(RoleTowerTimeUtil.FormatDeltaHud(num), true);
		}
		GenericScrollViewNew<RoleTowerSettleTimeItem, RoleTowerWaveRecordData> timeList = this.TimeList;
		if (timeList != null)
		{
			timeList.RefreshByData(list, null, false);
		}
		UUIInturnAnimController timeListAnim = this.TimeListAnim;
		if (timeListAnim == null)
		{
			return;
		}
		timeListAnim.Play("", -1, false);
	}

	// Token: 0x04009F7C RID: 40828
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerSettleTimeItem, RoleTowerWaveRecordData> TimeList;

	// Token: 0x04009F7D RID: 40829
	[Nullable(2)]
	private UUIInturnAnimController TimeListAnim;

	// Token: 0x02007FC0 RID: 32704
	private static class EChildType
	{
		// Token: 0x04029546 RID: 169286
		public const int TxtRemainTime = 0;

		// Token: 0x04029547 RID: 169287
		public const int TxtUseTime = 1;

		// Token: 0x04029548 RID: 169288
		public const int ItemScroll = 2;

		// Token: 0x04029549 RID: 169289
		public const int UiItemMonsterBattleTime = 3;
	}
}
