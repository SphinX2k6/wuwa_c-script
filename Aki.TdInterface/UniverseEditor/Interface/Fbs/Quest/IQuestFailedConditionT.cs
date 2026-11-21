using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004419 RID: 17433
	public class IQuestFailedConditionT
	{
		// Token: 0x170078A4 RID: 30884
		// (get) Token: 0x06018EB6 RID: 102070 RVA: 0x0038E214 File Offset: 0x0038C414
		// (set) Token: 0x06018EB7 RID: 102071 RVA: 0x0038E21C File Offset: 0x0038C41C
		public ITimerConfigT Timer { get; set; }

		// Token: 0x170078A5 RID: 30885
		// (get) Token: 0x06018EB8 RID: 102072 RVA: 0x0038E225 File Offset: 0x0038C425
		// (set) Token: 0x06018EB9 RID: 102073 RVA: 0x0038E22D File Offset: 0x0038C42D
		public ITimeRangeT TimeRange { get; set; }

		// Token: 0x170078A6 RID: 30886
		// (get) Token: 0x06018EBA RID: 102074 RVA: 0x0038E236 File Offset: 0x0038C436
		// (set) Token: 0x06018EBB RID: 102075 RVA: 0x0038E23E File Offset: 0x0038C43E
		public bool CanGiveUp { get; set; }

		// Token: 0x170078A7 RID: 30887
		// (get) Token: 0x06018EBC RID: 102076 RVA: 0x0038E247 File Offset: 0x0038C447
		// (set) Token: 0x06018EBD RID: 102077 RVA: 0x0038E24F File Offset: 0x0038C44F
		public string TidGiveUpText { get; set; }

		// Token: 0x170078A8 RID: 30888
		// (get) Token: 0x06018EBE RID: 102078 RVA: 0x0038E258 File Offset: 0x0038C458
		// (set) Token: 0x06018EBF RID: 102079 RVA: 0x0038E260 File Offset: 0x0038C460
		public string TidGiveUpConfirmText { get; set; }

		// Token: 0x170078A9 RID: 30889
		// (get) Token: 0x06018EC0 RID: 102080 RVA: 0x0038E269 File Offset: 0x0038C469
		// (set) Token: 0x06018EC1 RID: 102081 RVA: 0x0038E271 File Offset: 0x0038C471
		public bool IsTransferFailure { get; set; }

		// Token: 0x170078AA RID: 30890
		// (get) Token: 0x06018EC2 RID: 102082 RVA: 0x0038E27A File Offset: 0x0038C47A
		// (set) Token: 0x06018EC3 RID: 102083 RVA: 0x0038E282 File Offset: 0x0038C482
		public bool IsTeamDeathFailure { get; set; }

		// Token: 0x170078AB RID: 30891
		// (get) Token: 0x06018EC4 RID: 102084 RVA: 0x0038E28B File Offset: 0x0038C48B
		// (set) Token: 0x06018EC5 RID: 102085 RVA: 0x0038E293 File Offset: 0x0038C493
		public bool IsNonAiTeamDeathFailure { get; set; }

		// Token: 0x170078AC RID: 30892
		// (get) Token: 0x06018EC6 RID: 102086 RVA: 0x0038E29C File Offset: 0x0038C49C
		// (set) Token: 0x06018EC7 RID: 102087 RVA: 0x0038E2A4 File Offset: 0x0038C4A4
		public bool IsLeaveDungeonFailure { get; set; }

		// Token: 0x170078AD RID: 30893
		// (get) Token: 0x06018EC8 RID: 102088 RVA: 0x0038E2AD File Offset: 0x0038C4AD
		// (set) Token: 0x06018EC9 RID: 102089 RVA: 0x0038E2B5 File Offset: 0x0038C4B5
		public List<int> CheckDungeonFailure { get; set; }

		// Token: 0x170078AE RID: 30894
		// (get) Token: 0x06018ECA RID: 102090 RVA: 0x0038E2BE File Offset: 0x0038C4BE
		// (set) Token: 0x06018ECB RID: 102091 RVA: 0x0038E2C6 File Offset: 0x0038C4C6
		public IRangeLimitingConditionT RangeLimiting { get; set; }

		// Token: 0x170078AF RID: 30895
		// (get) Token: 0x06018ECC RID: 102092 RVA: 0x0038E2CF File Offset: 0x0038C4CF
		// (set) Token: 0x06018ECD RID: 102093 RVA: 0x0038E2D7 File Offset: 0x0038C4D7
		public IEntityDistanceLimitingConditionT EntityDistanceLimiting { get; set; }

		// Token: 0x170078B0 RID: 30896
		// (get) Token: 0x06018ECE RID: 102094 RVA: 0x0038E2E0 File Offset: 0x0038C4E0
		// (set) Token: 0x06018ECF RID: 102095 RVA: 0x0038E2E8 File Offset: 0x0038C4E8
		public IQuestFailedConditionEntityAlertT EntityAlert { get; set; }

		// Token: 0x170078B1 RID: 30897
		// (get) Token: 0x06018ED0 RID: 102096 RVA: 0x0038E2F1 File Offset: 0x0038C4F1
		// (set) Token: 0x06018ED1 RID: 102097 RVA: 0x0038E2F9 File Offset: 0x0038C4F9
		public IQuestFailedConditionEntityDeathT EntityDeathCondition { get; set; }

		// Token: 0x170078B2 RID: 30898
		// (get) Token: 0x06018ED2 RID: 102098 RVA: 0x0038E302 File Offset: 0x0038C502
		// (set) Token: 0x06018ED3 RID: 102099 RVA: 0x0038E30A File Offset: 0x0038C50A
		public IQuestFailedConditionEntityStateT EntityStateCondition { get; set; }

		// Token: 0x170078B3 RID: 30899
		// (get) Token: 0x06018ED4 RID: 102100 RVA: 0x0038E313 File Offset: 0x0038C513
		// (set) Token: 0x06018ED5 RID: 102101 RVA: 0x0038E31B File Offset: 0x0038C51B
		public ISneakPlayConditionT SneakPlayCondition { get; set; }

		// Token: 0x170078B4 RID: 30900
		// (get) Token: 0x06018ED6 RID: 102102 RVA: 0x0038E324 File Offset: 0x0038C524
		// (set) Token: 0x06018ED7 RID: 102103 RVA: 0x0038E32C File Offset: 0x0038C52C
		public IQuestFailedConditionPlayerMotionStateT PlayerMotionStateCondition { get; set; }

		// Token: 0x170078B5 RID: 30901
		// (get) Token: 0x06018ED8 RID: 102104 RVA: 0x0038E335 File Offset: 0x0038C535
		// (set) Token: 0x06018ED9 RID: 102105 RVA: 0x0038E33D File Offset: 0x0038C53D
		public IQuestFailedConditionPlayerMovementModeT PlayerMovementModeCondition { get; set; }

		// Token: 0x170078B6 RID: 30902
		// (get) Token: 0x06018EDA RID: 102106 RVA: 0x0038E346 File Offset: 0x0038C546
		// (set) Token: 0x06018EDB RID: 102107 RVA: 0x0038E34E File Offset: 0x0038C54E
		public ICheckDataLayerT CheckDataLayer { get; set; }

		// Token: 0x170078B7 RID: 30903
		// (get) Token: 0x06018EDC RID: 102108 RVA: 0x0038E357 File Offset: 0x0038C557
		// (set) Token: 0x06018EDD RID: 102109 RVA: 0x0038E35F File Offset: 0x0038C55F
		public IFailedTeleportT FailedTeleport { get; set; }

		// Token: 0x170078B8 RID: 30904
		// (get) Token: 0x06018EDE RID: 102110 RVA: 0x0038E368 File Offset: 0x0038C568
		// (set) Token: 0x06018EDF RID: 102111 RVA: 0x0038E370 File Offset: 0x0038C570
		public IAddTimeConfigT AddTimeConfig { get; set; }

		// Token: 0x170078B9 RID: 30905
		// (get) Token: 0x06018EE0 RID: 102112 RVA: 0x0038E379 File Offset: 0x0038C579
		// (set) Token: 0x06018EE1 RID: 102113 RVA: 0x0038E381 File Offset: 0x0038C581
		public ICompareVarConditionInQuestFailedT CompareVar { get; set; }

		// Token: 0x170078BA RID: 30906
		// (get) Token: 0x06018EE2 RID: 102114 RVA: 0x0038E38A File Offset: 0x0038C58A
		// (set) Token: 0x06018EE3 RID: 102115 RVA: 0x0038E392 File Offset: 0x0038C592
		public IRecallFishingBoatT RecallVehicle { get; set; }

		// Token: 0x170078BB RID: 30907
		// (get) Token: 0x06018EE4 RID: 102116 RVA: 0x0038E39B File Offset: 0x0038C59B
		// (set) Token: 0x06018EE5 RID: 102117 RVA: 0x0038E3A3 File Offset: 0x0038C5A3
		public bool SwitchGameDifficulty { get; set; }

		// Token: 0x170078BC RID: 30908
		// (get) Token: 0x06018EE6 RID: 102118 RVA: 0x0038E3AC File Offset: 0x0038C5AC
		// (set) Token: 0x06018EE7 RID: 102119 RVA: 0x0038E3B4 File Offset: 0x0038C5B4
		public byte NullMask { get; set; }

		// Token: 0x06018EE8 RID: 102120 RVA: 0x0038E3C0 File Offset: 0x0038C5C0
		public IQuestFailedConditionT()
		{
			this.Timer = null;
			this.TimeRange = null;
			this.CanGiveUp = false;
			this.TidGiveUpText = null;
			this.TidGiveUpConfirmText = null;
			this.IsTransferFailure = false;
			this.IsTeamDeathFailure = false;
			this.IsNonAiTeamDeathFailure = false;
			this.IsLeaveDungeonFailure = false;
			this.CheckDungeonFailure = null;
			this.RangeLimiting = null;
			this.EntityDistanceLimiting = null;
			this.EntityAlert = null;
			this.EntityDeathCondition = null;
			this.EntityStateCondition = null;
			this.SneakPlayCondition = null;
			this.PlayerMotionStateCondition = null;
			this.PlayerMovementModeCondition = null;
			this.CheckDataLayer = null;
			this.FailedTeleport = null;
			this.AddTimeConfig = null;
			this.CompareVar = null;
			this.RecallVehicle = null;
			this.SwitchGameDifficulty = false;
			this.NullMask = 0;
		}
	}
}
