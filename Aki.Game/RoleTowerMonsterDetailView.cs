using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CD7 RID: 7383
public class RoleTowerMonsterDetailView : UiViewBase
{
	// Token: 0x06012482 RID: 74882 RVA: 0x00564074 File Offset: 0x00562274
	[NullableContext(1)]
	public RoleTowerMonsterDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001B6F RID: 7023
	// (get) Token: 0x06012483 RID: 74883 RVA: 0x0056407D File Offset: 0x0056227D
	[Nullable(2)]
	private new RoleTowerMonsterDetailViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as RoleTowerMonsterDetailViewParams;
		}
	}

	// Token: 0x06012484 RID: 74884 RVA: 0x0056408A File Offset: 0x0056228A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06012485 RID: 74885 RVA: 0x005640C3 File Offset: 0x005622C3
	protected override void OnStart()
	{
		this.GroupList = new GenericScrollViewNew<RoleTowerMonsterGroupItem, RoleTowerMonsterFloorData>(base.GetScrollViewWithScrollbar(0), () => new RoleTowerMonsterGroupItem(), null, false, null);
	}

	// Token: 0x06012486 RID: 74886 RVA: 0x005640F9 File Offset: 0x005622F9
	protected override void OnBeforeShow()
	{
		this.RefreshGroupList();
	}

	// Token: 0x06012487 RID: 74887 RVA: 0x00564104 File Offset: 0x00562304
	private void RefreshGroupList()
	{
		RoleTowerMonsterDetailViewParams openParam = this.OpenParam;
		int num = (openParam != null) ? openParam.StageId : 0;
		if (num <= 0)
		{
			Log.Instance.Info(ELogModule.Temp, ELogAuthor.LJQ, "RoleTower.MonsterDetail 打开参数缺少 StageId", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int curSelectLevel = RoleTowerModel.Instance.CurSelectLevel;
		int stageSeqById = RoleTowerModel.Instance.GetStageSeqById(num);
		List<RoleTowerFloor> list = new List<RoleTowerFloor>(RoleTowerModel.Instance.GetFloorCfgListByStage(curSelectLevel, stageSeqById));
		list.Sort(delegate(RoleTowerFloor a, RoleTowerFloor b)
		{
			if (a.FloorIndex == b.FloorIndex)
			{
				return a.Branch - b.Branch;
			}
			return a.FloorIndex - b.FloorIndex;
		});
		List<RoleTowerMonsterFloorData> list2 = new List<RoleTowerMonsterFloorData>();
		int num2 = int.MinValue;
		foreach (RoleTowerFloor roleTowerFloor in list)
		{
			bool showFloorTitle = roleTowerFloor.FloorIndex != num2;
			num2 = roleTowerFloor.FloorIndex;
			list2.Add(new RoleTowerMonsterFloorData
			{
				FloorId = roleTowerFloor.Id,
				BranchId = roleTowerFloor.Branch,
				ShowFloorTitle = showFloorTitle
			});
		}
		GenericScrollViewNew<RoleTowerMonsterGroupItem, RoleTowerMonsterFloorData> groupList = this.GroupList;
		if (groupList == null)
		{
			return;
		}
		groupList.RefreshByData(list2, null, false);
	}

	// Token: 0x04009F96 RID: 40854
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerMonsterGroupItem, RoleTowerMonsterFloorData> GroupList;

	// Token: 0x02007FD2 RID: 32722
	private static class EChildType
	{
		// Token: 0x0402959E RID: 169374
		public const int MonsterScroll = 0;

		// Token: 0x0402959F RID: 169375
		public const int PnlMonsterGroup = 1;
	}
}
