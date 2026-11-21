using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058C9 RID: 22729
	public class SolarSchoolBehaviorData
	{
		// Token: 0x06037F94 RID: 229268 RVA: 0x00FA5ABB File Offset: 0x00FA3CBB
		public SolarSchoolBehaviorData(int behaviorId)
		{
			this.BehaviorId = behaviorId;
		}

		// Token: 0x17006B5A RID: 27482
		// (get) Token: 0x06037F95 RID: 229269 RVA: 0x00FA5ACA File Offset: 0x00FA3CCA
		public int BehaviorId { get; }

		// Token: 0x17006B5B RID: 27483
		// (get) Token: 0x06037F96 RID: 229270 RVA: 0x00FA5AD2 File Offset: 0x00FA3CD2
		// (set) Token: 0x06037F97 RID: 229271 RVA: 0x00FA5ADA File Offset: 0x00FA3CDA
		public int CompletedCount { get; private set; }

		// Token: 0x17006B5C RID: 27484
		// (get) Token: 0x06037F98 RID: 229272 RVA: 0x00FA5AE3 File Offset: 0x00FA3CE3
		// (set) Token: 0x06037F99 RID: 229273 RVA: 0x00FA5AEB File Offset: 0x00FA3CEB
		public int SuccessCount { get; private set; }

		// Token: 0x17006B5D RID: 27485
		// (get) Token: 0x06037F9A RID: 229274 RVA: 0x00FA5AF4 File Offset: 0x00FA3CF4
		// (set) Token: 0x06037F9B RID: 229275 RVA: 0x00FA5AFC File Offset: 0x00FA3CFC
		public ESolarSchoolSpecialState SpecialState { get; private set; }

		// Token: 0x17006B5E RID: 27486
		// (get) Token: 0x06037F9C RID: 229276 RVA: 0x00FA5B05 File Offset: 0x00FA3D05
		// (set) Token: 0x06037F9D RID: 229277 RVA: 0x00FA5B0D File Offset: 0x00FA3D0D
		public bool SpecialTalkViewed { get; private set; }

		// Token: 0x06037F9E RID: 229278 RVA: 0x00FA5B16 File Offset: 0x00FA3D16
		public void MarkSpecialTalkViewed()
		{
			this.SpecialTalkViewed = true;
		}

		// Token: 0x06037F9F RID: 229279 RVA: 0x00FA5B20 File Offset: 0x00FA3D20
		public void OnExecuted(bool success)
		{
			int num = this.CompletedCount;
			this.CompletedCount = num + 1;
			if (success)
			{
				num = this.SuccessCount;
				this.SuccessCount = num + 1;
			}
		}

		// Token: 0x06037FA0 RID: 229280 RVA: 0x00FA5B50 File Offset: 0x00FA3D50
		public void AddCount(int delta)
		{
			this.CompletedCount = Math.Max(this.CompletedCount + delta, 0);
			this.SuccessCount = Math.Max(this.SuccessCount + delta, 0);
		}

		// Token: 0x06037FA1 RID: 229281 RVA: 0x00FA5B7A File Offset: 0x00FA3D7A
		public bool SetSpecialState(ESolarSchoolSpecialState state)
		{
			if (this.SpecialState == state)
			{
				return false;
			}
			this.SpecialState = state;
			return true;
		}

		// Token: 0x06037FA2 RID: 229282 RVA: 0x00FA5B8F File Offset: 0x00FA3D8F
		public void RestoreFromSave(int completedCount, int successCount, ESolarSchoolSpecialState specialState)
		{
			this.CompletedCount = completedCount;
			this.SuccessCount = successCount;
			this.SpecialState = specialState;
			this.SpecialTalkViewed = (specialState >= ESolarSchoolSpecialState.Accepted);
		}
	}
}
