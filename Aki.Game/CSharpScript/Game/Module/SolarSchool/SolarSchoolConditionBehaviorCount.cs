using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005893 RID: 22675
	public class SolarSchoolConditionBehaviorCount : ActivityConditionProgressBase, ISolarSchoolProgressCondition
	{
		// Token: 0x17006B39 RID: 27449
		// (get) Token: 0x06037DE6 RID: 228838 RVA: 0x00F9FFAA File Offset: 0x00F9E1AA
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037DE7 RID: 228839 RVA: 0x00F9FFAD File Offset: 0x00F9E1AD
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.BehaviorIds = p.GetIntList("BehaviorId").ToArray();
			this.OnlySuccess = p.GetBool("OnlySuccess", false);
			this.TargetCount = p.GetInt("Count", 0);
			return true;
		}

		// Token: 0x06037DE8 RID: 228840 RVA: 0x00F9FFEC File Offset: 0x00F9E1EC
		public override int GetCurrent()
		{
			int rawCurrent = this.GetRawCurrent();
			if (!this.UseLocalProgress)
			{
				return rawCurrent;
			}
			return Math.Max(rawCurrent - this.ProgressBaseline, 0);
		}

		// Token: 0x06037DE9 RID: 228841 RVA: 0x00FA0018 File Offset: 0x00F9E218
		public override int GetTarget()
		{
			return this.TargetCount;
		}

		// Token: 0x06037DEA RID: 228842 RVA: 0x00FA0020 File Offset: 0x00F9E220
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int, bool>(EEventName.SolarSchoolBehaviorSettled, new Action<int, bool>(this.OnBehaviorSettled));
		}

		// Token: 0x06037DEB RID: 228843 RVA: 0x00FA003E File Offset: 0x00F9E23E
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int, bool>(EEventName.SolarSchoolBehaviorSettled, new Action<int, bool>(this.OnBehaviorSettled));
		}

		// Token: 0x06037DEC RID: 228844 RVA: 0x00FA005C File Offset: 0x00F9E25C
		protected override void OnClear()
		{
			this.BehaviorIds = Array.Empty<int>();
			this.OnlySuccess = false;
			this.TargetCount = 0;
			this.UseLocalProgress = false;
			this.ProgressBaseline = 0;
		}

		// Token: 0x06037DED RID: 228845 RVA: 0x00FA0088 File Offset: 0x00F9E288
		public void RestoreProgress(int progress)
		{
			this.UseLocalProgress = true;
			int rawCurrent = this.GetRawCurrent();
			this.ProgressBaseline = Math.Max(rawCurrent - progress, 0);
		}

		// Token: 0x06037DEE RID: 228846 RVA: 0x00FA00B2 File Offset: 0x00F9E2B2
		public int GetSaveProgress()
		{
			return Math.Clamp(this.GetCurrent(), 0, this.GetTarget());
		}

		// Token: 0x06037DEF RID: 228847 RVA: 0x00FA00C8 File Offset: 0x00F9E2C8
		private int GetRawCurrent()
		{
			long num = 0L;
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			foreach (int behaviorId in this.BehaviorIds)
			{
				num += (long)(this.OnlySuccess ? playerData.GetSuccessCount(behaviorId) : playerData.GetCompletedCount(behaviorId));
			}
			return (int)Math.Min(num, 2147483647L);
		}

		// Token: 0x06037DF0 RID: 228848 RVA: 0x00FA0128 File Offset: 0x00F9E328
		private void OnBehaviorSettled(int behaviorId, bool success)
		{
			if (Array.IndexOf<int>(this.BehaviorIds, behaviorId) < 0 || (this.OnlySuccess && !success))
			{
				return;
			}
			base.FinishExecute();
		}

		// Token: 0x0401D7C8 RID: 120776
		[Nullable(1)]
		private int[] BehaviorIds = Array.Empty<int>();

		// Token: 0x0401D7C9 RID: 120777
		private bool OnlySuccess;

		// Token: 0x0401D7CA RID: 120778
		private int TargetCount;

		// Token: 0x0401D7CB RID: 120779
		private bool UseLocalProgress;

		// Token: 0x0401D7CC RID: 120780
		private int ProgressBaseline;
	}
}
