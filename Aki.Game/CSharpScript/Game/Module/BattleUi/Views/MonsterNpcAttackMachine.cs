using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D4D RID: 23885
	public class MonsterNpcAttackMachine
	{
		// Token: 0x0603CA4D RID: 248397 RVA: 0x00E8DE88 File Offset: 0x00E8C088
		public float UpdatePercent(float delta)
		{
			if (this.CurrentPercent == this.TargetPercent)
			{
				this.State = MonsterNpcAttackMachine.EState.NoUpdate;
				return this.CurrentPercent;
			}
			if (this.Duration <= 0f)
			{
				this.CurrentPercent = this.TargetPercent;
				this.State = MonsterNpcAttackMachine.EState.Updated;
				return this.CurrentPercent;
			}
			float num = (this.TargetPercent - this.CurrentPercent) / this.Duration;
			this.CurrentPercent += num * delta;
			this.Duration -= delta;
			this.State = MonsterNpcAttackMachine.EState.Updated;
			return this.CurrentPercent;
		}

		// Token: 0x0603CA4E RID: 248398 RVA: 0x00E8DF18 File Offset: 0x00E8C118
		public void SetTargetPercent(float percent, float lerpTime)
		{
			this.TargetPercent = percent;
			this.Duration = lerpTime;
		}

		// Token: 0x0603CA4F RID: 248399 RVA: 0x00E8DF28 File Offset: 0x00E8C128
		public bool HasUpdate()
		{
			return this.State == MonsterNpcAttackMachine.EState.Updated;
		}

		// Token: 0x0401F961 RID: 129377
		public float TargetPercent;

		// Token: 0x0401F962 RID: 129378
		public float CurrentPercent;

		// Token: 0x0401F963 RID: 129379
		public float Duration;

		// Token: 0x0401F964 RID: 129380
		private MonsterNpcAttackMachine.EState State;

		// Token: 0x0200BFF0 RID: 49136
		private enum EState
		{
			// Token: 0x04039ECE RID: 237262
			NoUpdate,
			// Token: 0x04039ECF RID: 237263
			Updated
		}
	}
}
