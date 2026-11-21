using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058A7 RID: 22695
	public class SolarSchoolConditionSpecialState : ActivityConditionBase, ISolarSchoolProgressCondition
	{
		// Token: 0x17006B4C RID: 27468
		// (get) Token: 0x06037E95 RID: 229013 RVA: 0x00FA12E1 File Offset: 0x00F9F4E1
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E96 RID: 229014 RVA: 0x00FA12E4 File Offset: 0x00F9F4E4
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.BehaviorId = p.GetInt("BehaviorId", 0);
			this.ExpectedState = p.GetEnum<ESolarSchoolSpecialState>("State");
			return true;
		}

		// Token: 0x06037E97 RID: 229015 RVA: 0x00FA130A File Offset: 0x00F9F50A
		protected override bool OnCheck()
		{
			if (!this.UseLocalProgress)
			{
				return this.IsRawReached();
			}
			return this.LocalReached;
		}

		// Token: 0x06037E98 RID: 229016 RVA: 0x00FA1321 File Offset: 0x00F9F521
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolSpecialStateChanged, new Action<int>(this.OnSpecialStateChanged));
		}

		// Token: 0x06037E99 RID: 229017 RVA: 0x00FA133F File Offset: 0x00F9F53F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolSpecialStateChanged, new Action<int>(this.OnSpecialStateChanged));
		}

		// Token: 0x06037E9A RID: 229018 RVA: 0x00FA135D File Offset: 0x00F9F55D
		protected override void OnClear()
		{
			this.BehaviorId = 0;
			this.ExpectedState = ESolarSchoolSpecialState.None;
			this.UseLocalProgress = false;
			this.LocalReached = false;
		}

		// Token: 0x06037E9B RID: 229019 RVA: 0x00FA137B File Offset: 0x00F9F57B
		public void RestoreProgress(int progress)
		{
			this.UseLocalProgress = true;
			this.LocalReached = (progress > 0);
		}

		// Token: 0x06037E9C RID: 229020 RVA: 0x00FA138E File Offset: 0x00F9F58E
		public int GetSaveProgress()
		{
			if (!this.UseLocalProgress || !this.LocalReached)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06037E9D RID: 229021 RVA: 0x00FA13A3 File Offset: 0x00F9F5A3
		private bool IsRawReached()
		{
			return SolarSchoolGamePlayModel.Instance.PlayerData.GetSpecialState(this.BehaviorId) == this.ExpectedState;
		}

		// Token: 0x06037E9E RID: 229022 RVA: 0x00FA13C2 File Offset: 0x00F9F5C2
		private void OnSpecialStateChanged(int behaviorId)
		{
			if (behaviorId != this.BehaviorId)
			{
				return;
			}
			if (this.UseLocalProgress)
			{
				this.LocalReached |= this.IsRawReached();
			}
			base.FinishExecute();
		}

		// Token: 0x0401D7FA RID: 120826
		private int BehaviorId;

		// Token: 0x0401D7FB RID: 120827
		private ESolarSchoolSpecialState ExpectedState;

		// Token: 0x0401D7FC RID: 120828
		private bool UseLocalProgress;

		// Token: 0x0401D7FD RID: 120829
		private bool LocalReached;
	}
}
