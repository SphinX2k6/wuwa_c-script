using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200589A RID: 22682
	public class SolarSchoolConditionGiftCount : ActivityConditionProgressBase, ISolarSchoolProgressCondition
	{
		// Token: 0x17006B3F RID: 27455
		// (get) Token: 0x06037E1F RID: 228895 RVA: 0x00FA0671 File Offset: 0x00F9E871
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E20 RID: 228896 RVA: 0x00FA0674 File Offset: 0x00F9E874
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.RoleIds = p.GetIntList("RoleId").ToArray();
			this.TargetCount = p.GetInt("Count", 0);
			return true;
		}

		// Token: 0x06037E21 RID: 228897 RVA: 0x00FA06A0 File Offset: 0x00F9E8A0
		public override int GetCurrent()
		{
			int rawCurrent = this.GetRawCurrent();
			if (!this.UseLocalProgress)
			{
				return rawCurrent;
			}
			return Math.Max(rawCurrent - this.ProgressBaseline, 0);
		}

		// Token: 0x06037E22 RID: 228898 RVA: 0x00FA06CC File Offset: 0x00F9E8CC
		private int GetRawCurrent()
		{
			long num = 0L;
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			foreach (int roleId in this.RoleIds)
			{
				num += (long)instance.GetConditionGiftReceivedCount(roleId);
			}
			return (int)Math.Min(num, 2147483647L);
		}

		// Token: 0x06037E23 RID: 228899 RVA: 0x00FA0715 File Offset: 0x00F9E915
		public override int GetTarget()
		{
			return this.TargetCount;
		}

		// Token: 0x06037E24 RID: 228900 RVA: 0x00FA071D File Offset: 0x00F9E91D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolGiftCountChanged, new Action<int>(this.OnGiftCountChanged));
		}

		// Token: 0x06037E25 RID: 228901 RVA: 0x00FA073B File Offset: 0x00F9E93B
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolGiftCountChanged, new Action<int>(this.OnGiftCountChanged));
		}

		// Token: 0x06037E26 RID: 228902 RVA: 0x00FA0759 File Offset: 0x00F9E959
		protected override void OnClear()
		{
			this.RoleIds = Array.Empty<int>();
			this.TargetCount = 0;
			this.UseLocalProgress = false;
			this.ProgressBaseline = 0;
		}

		// Token: 0x06037E27 RID: 228903 RVA: 0x00FA077B File Offset: 0x00F9E97B
		public void RestoreProgress(int progress)
		{
			this.UseLocalProgress = true;
			this.ProgressBaseline = Math.Max(this.GetRawCurrent() - progress, 0);
		}

		// Token: 0x06037E28 RID: 228904 RVA: 0x00FA0798 File Offset: 0x00F9E998
		public int GetSaveProgress()
		{
			return Math.Clamp(this.GetCurrent(), 0, this.GetTarget());
		}

		// Token: 0x06037E29 RID: 228905 RVA: 0x00FA07AC File Offset: 0x00F9E9AC
		private void OnGiftCountChanged(int roleId)
		{
			if (Array.IndexOf<int>(this.RoleIds, roleId) >= 0)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401D7D8 RID: 120792
		[Nullable(1)]
		private int[] RoleIds = Array.Empty<int>();

		// Token: 0x0401D7D9 RID: 120793
		private int TargetCount;

		// Token: 0x0401D7DA RID: 120794
		private bool UseLocalProgress;

		// Token: 0x0401D7DB RID: 120795
		private int ProgressBaseline;
	}
}
