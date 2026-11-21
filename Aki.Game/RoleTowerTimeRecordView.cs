using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D05 RID: 7429
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerTimeRecordView : UiViewBase
{
	// Token: 0x06012640 RID: 75328 RVA: 0x0056EFEB File Offset: 0x0056D1EB
	[NullableContext(1)]
	public RoleTowerTimeRecordView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001B75 RID: 7029
	// (get) Token: 0x06012641 RID: 75329 RVA: 0x0056EFF4 File Offset: 0x0056D1F4
	private new RoleTowerTimeRecordViewParams OpenParam
	{
		get
		{
			return this.OpenParam as RoleTowerTimeRecordViewParams;
		}
	}

	// Token: 0x06012642 RID: 75330 RVA: 0x0056F004 File Offset: 0x0056D204
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06012643 RID: 75331 RVA: 0x0056F060 File Offset: 0x0056D260
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerTimeRecordView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerTimeRecordView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012644 RID: 75332 RVA: 0x0056F0A3 File Offset: 0x0056D2A3
	protected override void OnStart()
	{
		this.StageList = new GenericScrollViewNew<RoleTowerRecordStageItem, RoleTowerStageRecordData>(base.GetScrollViewWithScrollbar(1), () => new RoleTowerRecordStageItem(), null, false, null);
	}

	// Token: 0x06012645 RID: 75333 RVA: 0x0056F0DC File Offset: 0x0056D2DC
	protected override void OnBeforeShow()
	{
		RoleTowerTimeRecordViewParams openParam = this.OpenParam;
		this.CurLevelId = ((openParam != null) ? openParam.LevelId : 0);
		RoleTowerModel instance = RoleTowerModel.Instance;
		int curLevelId = this.CurLevelId;
		RoleTowerTimeRecordViewParams openParam2 = this.OpenParam;
		List<RoleTowerStageRecordData> stageRecordsForView = instance.GetStageRecordsForView(curLevelId, openParam2 != null && openParam2.IsCurrentRecord);
		GenericScrollViewNew<RoleTowerRecordStageItem, RoleTowerStageRecordData> stageList = this.StageList;
		if (stageList == null)
		{
			return;
		}
		stageList.RefreshByData(stageRecordsForView, null, false);
	}

	// Token: 0x0400A040 RID: 41024
	private PopupCaptionItem Caption;

	// Token: 0x0400A041 RID: 41025
	private int CurLevelId;

	// Token: 0x0400A042 RID: 41026
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerRecordStageItem, RoleTowerStageRecordData> StageList;

	// Token: 0x02008030 RID: 32816
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040297AF RID: 169903
		public const int UiItemCaption = 0;

		// Token: 0x040297B0 RID: 169904
		public const int TimeRecordItemScroll = 1;

		// Token: 0x040297B1 RID: 169905
		public const int UiItemBattleTimeDetail = 2;
	}
}
