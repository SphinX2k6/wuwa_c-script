using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FD8 RID: 16344
	public class IQuestFailedConditionT
	{
		// Token: 0x170072A3 RID: 29347
		// (get) Token: 0x0601781F RID: 96287 RVA: 0x0036444C File Offset: 0x0036264C
		// (set) Token: 0x06017820 RID: 96288 RVA: 0x00364454 File Offset: 0x00362654
		public ITimerConfigT Timer { get; set; }

		// Token: 0x170072A4 RID: 29348
		// (get) Token: 0x06017821 RID: 96289 RVA: 0x0036445D File Offset: 0x0036265D
		// (set) Token: 0x06017822 RID: 96290 RVA: 0x00364465 File Offset: 0x00362665
		public ITimeRangeT TimeRange { get; set; }

		// Token: 0x170072A5 RID: 29349
		// (get) Token: 0x06017823 RID: 96291 RVA: 0x0036446E File Offset: 0x0036266E
		// (set) Token: 0x06017824 RID: 96292 RVA: 0x00364476 File Offset: 0x00362676
		public bool CanGiveUp { get; set; }

		// Token: 0x170072A6 RID: 29350
		// (get) Token: 0x06017825 RID: 96293 RVA: 0x0036447F File Offset: 0x0036267F
		// (set) Token: 0x06017826 RID: 96294 RVA: 0x00364487 File Offset: 0x00362687
		public string TidGiveUpText { get; set; }

		// Token: 0x170072A7 RID: 29351
		// (get) Token: 0x06017827 RID: 96295 RVA: 0x00364490 File Offset: 0x00362690
		// (set) Token: 0x06017828 RID: 96296 RVA: 0x00364498 File Offset: 0x00362698
		public bool IsTransferFailure { get; set; }

		// Token: 0x170072A8 RID: 29352
		// (get) Token: 0x06017829 RID: 96297 RVA: 0x003644A1 File Offset: 0x003626A1
		// (set) Token: 0x0601782A RID: 96298 RVA: 0x003644A9 File Offset: 0x003626A9
		public bool IsTeamDeathFailure { get; set; }

		// Token: 0x170072A9 RID: 29353
		// (get) Token: 0x0601782B RID: 96299 RVA: 0x003644B2 File Offset: 0x003626B2
		// (set) Token: 0x0601782C RID: 96300 RVA: 0x003644BA File Offset: 0x003626BA
		public bool IsNonAiTeamDeathFailure { get; set; }

		// Token: 0x170072AA RID: 29354
		// (get) Token: 0x0601782D RID: 96301 RVA: 0x003644C3 File Offset: 0x003626C3
		// (set) Token: 0x0601782E RID: 96302 RVA: 0x003644CB File Offset: 0x003626CB
		public bool IsLeaveDungeonFailure { get; set; }

		// Token: 0x170072AB RID: 29355
		// (get) Token: 0x0601782F RID: 96303 RVA: 0x003644D4 File Offset: 0x003626D4
		// (set) Token: 0x06017830 RID: 96304 RVA: 0x003644DC File Offset: 0x003626DC
		public List<int> CheckDungeonFailure { get; set; }

		// Token: 0x170072AC RID: 29356
		// (get) Token: 0x06017831 RID: 96305 RVA: 0x003644E5 File Offset: 0x003626E5
		// (set) Token: 0x06017832 RID: 96306 RVA: 0x003644ED File Offset: 0x003626ED
		public IRangeLimitingConditionT RangeLimiting { get; set; }

		// Token: 0x170072AD RID: 29357
		// (get) Token: 0x06017833 RID: 96307 RVA: 0x003644F6 File Offset: 0x003626F6
		// (set) Token: 0x06017834 RID: 96308 RVA: 0x003644FE File Offset: 0x003626FE
		public IEntityDistanceLimitingConditionT EntityDistanceLimiting { get; set; }

		// Token: 0x170072AE RID: 29358
		// (get) Token: 0x06017835 RID: 96309 RVA: 0x00364507 File Offset: 0x00362707
		// (set) Token: 0x06017836 RID: 96310 RVA: 0x0036450F File Offset: 0x0036270F
		public IQuestFailedConditionEntityAlertT EntityAlert { get; set; }

		// Token: 0x170072AF RID: 29359
		// (get) Token: 0x06017837 RID: 96311 RVA: 0x00364518 File Offset: 0x00362718
		// (set) Token: 0x06017838 RID: 96312 RVA: 0x00364520 File Offset: 0x00362720
		public IQuestFailedConditionEntityDeathT EntityDeathCondition { get; set; }

		// Token: 0x170072B0 RID: 29360
		// (get) Token: 0x06017839 RID: 96313 RVA: 0x00364529 File Offset: 0x00362729
		// (set) Token: 0x0601783A RID: 96314 RVA: 0x00364531 File Offset: 0x00362731
		public IQuestFailedConditionEntityStateT EntityStateCondition { get; set; }

		// Token: 0x170072B1 RID: 29361
		// (get) Token: 0x0601783B RID: 96315 RVA: 0x0036453A File Offset: 0x0036273A
		// (set) Token: 0x0601783C RID: 96316 RVA: 0x00364542 File Offset: 0x00362742
		public ISneakPlayConditionT SneakPlayCondition { get; set; }

		// Token: 0x170072B2 RID: 29362
		// (get) Token: 0x0601783D RID: 96317 RVA: 0x0036454B File Offset: 0x0036274B
		// (set) Token: 0x0601783E RID: 96318 RVA: 0x00364553 File Offset: 0x00362753
		public IQuestFailedConditionPlayerMotionStateT PlayerMotionStateCondition { get; set; }

		// Token: 0x170072B3 RID: 29363
		// (get) Token: 0x0601783F RID: 96319 RVA: 0x0036455C File Offset: 0x0036275C
		// (set) Token: 0x06017840 RID: 96320 RVA: 0x00364564 File Offset: 0x00362764
		public IQuestFailedConditionPlayerMovementModeT PlayerMovementModeCondition { get; set; }

		// Token: 0x170072B4 RID: 29364
		// (get) Token: 0x06017841 RID: 96321 RVA: 0x0036456D File Offset: 0x0036276D
		// (set) Token: 0x06017842 RID: 96322 RVA: 0x00364575 File Offset: 0x00362775
		public ICheckDataLayerT CheckDataLayer { get; set; }

		// Token: 0x170072B5 RID: 29365
		// (get) Token: 0x06017843 RID: 96323 RVA: 0x0036457E File Offset: 0x0036277E
		// (set) Token: 0x06017844 RID: 96324 RVA: 0x00364586 File Offset: 0x00362786
		public IFailedTeleportT FailedTeleport { get; set; }

		// Token: 0x170072B6 RID: 29366
		// (get) Token: 0x06017845 RID: 96325 RVA: 0x0036458F File Offset: 0x0036278F
		// (set) Token: 0x06017846 RID: 96326 RVA: 0x00364597 File Offset: 0x00362797
		public IAddTimeConfigT AddTimeConfig { get; set; }

		// Token: 0x170072B7 RID: 29367
		// (get) Token: 0x06017847 RID: 96327 RVA: 0x003645A0 File Offset: 0x003627A0
		// (set) Token: 0x06017848 RID: 96328 RVA: 0x003645A8 File Offset: 0x003627A8
		public ICompareVarConditionInQuestFailedT CompareVar { get; set; }

		// Token: 0x170072B8 RID: 29368
		// (get) Token: 0x06017849 RID: 96329 RVA: 0x003645B1 File Offset: 0x003627B1
		// (set) Token: 0x0601784A RID: 96330 RVA: 0x003645B9 File Offset: 0x003627B9
		public IRecallFishingBoatT RecallVehicle { get; set; }

		// Token: 0x170072B9 RID: 29369
		// (get) Token: 0x0601784B RID: 96331 RVA: 0x003645C2 File Offset: 0x003627C2
		// (set) Token: 0x0601784C RID: 96332 RVA: 0x003645CA File Offset: 0x003627CA
		public bool SwitchGameDifficulty { get; set; }

		// Token: 0x170072BA RID: 29370
		// (get) Token: 0x0601784D RID: 96333 RVA: 0x003645D3 File Offset: 0x003627D3
		// (set) Token: 0x0601784E RID: 96334 RVA: 0x003645DB File Offset: 0x003627DB
		public byte NullMask { get; set; }

		// Token: 0x0601784F RID: 96335 RVA: 0x003645E4 File Offset: 0x003627E4
		public IQuestFailedConditionT()
		{
			this.Timer = null;
			this.TimeRange = null;
			this.CanGiveUp = false;
			this.TidGiveUpText = null;
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
