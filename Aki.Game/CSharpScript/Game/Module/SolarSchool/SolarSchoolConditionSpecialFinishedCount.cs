using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058A6 RID: 22694
	public class SolarSchoolConditionSpecialFinishedCount : ActivityConditionProgressBase, ISolarSchoolProgressCondition
	{
		// Token: 0x17006B4B RID: 27467
		// (get) Token: 0x06037E89 RID: 229001 RVA: 0x00FA11EF File Offset: 0x00F9F3EF
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E8A RID: 229002 RVA: 0x00FA11F2 File Offset: 0x00F9F3F2
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.TargetCount = p.GetInt("Count", 0);
			return true;
		}

		// Token: 0x06037E8B RID: 229003 RVA: 0x00FA1208 File Offset: 0x00F9F408
		public override int GetCurrent()
		{
			int rawCurrent = this.GetRawCurrent();
			if (!this.UseLocalProgress)
			{
				return rawCurrent;
			}
			return Math.Max(rawCurrent - this.ProgressBaseline, 0);
		}

		// Token: 0x06037E8C RID: 229004 RVA: 0x00FA1234 File Offset: 0x00F9F434
		public override int GetTarget()
		{
			return this.TargetCount;
		}

		// Token: 0x06037E8D RID: 229005 RVA: 0x00FA123C File Offset: 0x00F9F43C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolSpecialStateChanged, new Action<int>(this.OnSpecialStateChanged));
		}

		// Token: 0x06037E8E RID: 229006 RVA: 0x00FA125A File Offset: 0x00F9F45A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolSpecialStateChanged, new Action<int>(this.OnSpecialStateChanged));
		}

		// Token: 0x06037E8F RID: 229007 RVA: 0x00FA1278 File Offset: 0x00F9F478
		protected override void OnClear()
		{
			this.TargetCount = 0;
			this.UseLocalProgress = false;
			this.ProgressBaseline = 0;
		}

		// Token: 0x06037E90 RID: 229008 RVA: 0x00FA128F File Offset: 0x00F9F48F
		public void RestoreProgress(int progress)
		{
			this.UseLocalProgress = true;
			this.ProgressBaseline = Math.Max(this.GetRawCurrent() - progress, 0);
		}

		// Token: 0x06037E91 RID: 229009 RVA: 0x00FA12AC File Offset: 0x00F9F4AC
		public int GetSaveProgress()
		{
			return Math.Clamp(this.GetCurrent(), 0, this.GetTarget());
		}

		// Token: 0x06037E92 RID: 229010 RVA: 0x00FA12C0 File Offset: 0x00F9F4C0
		private int GetRawCurrent()
		{
			return SolarSchoolGamePlayModel.Instance.PlayerData.GetFinishedSpecialCount();
		}

		// Token: 0x06037E93 RID: 229011 RVA: 0x00FA12D1 File Offset: 0x00F9F4D1
		private void OnSpecialStateChanged(int behaviorId)
		{
			base.FinishExecute();
		}

		// Token: 0x0401D7F7 RID: 120823
		private int TargetCount;

		// Token: 0x0401D7F8 RID: 120824
		private bool UseLocalProgress;

		// Token: 0x0401D7F9 RID: 120825
		private int ProgressBaseline;
	}
}
