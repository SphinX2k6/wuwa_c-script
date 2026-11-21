using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D2F RID: 19759
	public class MonsterNpcAttackMachine
	{
		// Token: 0x060319A6 RID: 203174 RVA: 0x00DDE63C File Offset: 0x00DDC83C
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

		// Token: 0x060319A7 RID: 203175 RVA: 0x00DDE6CC File Offset: 0x00DDC8CC
		public void SetTargetPercent(float percent, float lerpTime)
		{
			this.TargetPercent = percent;
			this.Duration = lerpTime;
		}

		// Token: 0x060319A8 RID: 203176 RVA: 0x00DDE6DC File Offset: 0x00DDC8DC
		public bool HasUpdate()
		{
			return this.State == MonsterNpcAttackMachine.EState.Updated;
		}

		// Token: 0x0401A41A RID: 107546
		public float TargetPercent;

		// Token: 0x0401A41B RID: 107547
		public float CurrentPercent;

		// Token: 0x0401A41C RID: 107548
		public float Duration;

		// Token: 0x0401A41D RID: 107549
		private MonsterNpcAttackMachine.EState State;

		// Token: 0x0200A9F6 RID: 43510
		private enum EState
		{
			// Token: 0x04034890 RID: 215184
			NoUpdate,
			// Token: 0x04034891 RID: 215185
			Updated
		}
	}
}
