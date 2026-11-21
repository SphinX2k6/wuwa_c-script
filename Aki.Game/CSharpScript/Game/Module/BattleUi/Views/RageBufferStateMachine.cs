using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D31 RID: 19761
	public class RageBufferStateMachine
	{
		// Token: 0x060319B1 RID: 203185 RVA: 0x00DDE8AC File Offset: 0x00DDCAAC
		public RageBufferStateMachine()
		{
			this.ConfigHitDelayTimes = ConfigCommonParamById.GetIntConfig("HitDelayTime").Value;
			this.HitRefreshTimes = ConfigCommonParamById.GetIntConfig("HitRefreshTime").Value;
			this.HitBufferDisappearTime = ConfigCommonParamById.GetIntConfig("HitBufferDisappearTime").Value;
			this.HitLargePercent = (float)ConfigCommonParamById.GetIntConfig("HitLargePercent").Value / 10000f;
			this.CurrentTime = (float)this.HitBufferDisappearTime;
		}

		// Token: 0x060319B2 RID: 203186 RVA: 0x00DDE933 File Offset: 0x00DDCB33
		[NullableContext(1)]
		public void SetUpdateCallback(RageBufferStateMachine.OnUpdateLittleReduce updateLittleReduce, RageBufferStateMachine.OnUpdateLargeReduce updateLargeReduce, Action notifyEmpty)
		{
			this.UpdateLittleReduce = updateLittleReduce;
			this.UpdateLargeReduce = updateLargeReduce;
			this.NotifyEmpty = notifyEmpty;
		}

		// Token: 0x060319B3 RID: 203187 RVA: 0x00DDE94C File Offset: 0x00DDCB4C
		public void Update(float delta)
		{
			if (this.CurrentEmptyState == RageBufferStateMachine.EState.Animation)
			{
				this.CurrentEmptyState = RageBufferStateMachine.EState.Origin;
				Action notifyEmpty = this.NotifyEmpty;
				if (notifyEmpty != null)
				{
					notifyEmpty();
				}
			}
			if (this.CurrentLittleState == RageBufferStateMachine.EState.Animation)
			{
				float num = (this.CurrentPercent - this.TargetPercent) / this.CurrentTime;
				this.CurrentPercent -= delta * num;
				this.CurrentTime -= delta;
				if (this.CurrentTime <= 0f)
				{
					this.CurrentLittleState = RageBufferStateMachine.EState.Origin;
					this.CurrentPercent = this.TargetPercent;
				}
				RageBufferStateMachine.OnUpdateLittleReduce updateLittleReduce = this.UpdateLittleReduce;
				if (updateLittleReduce != null)
				{
					updateLittleReduce(this.CurrentPercent, this.TargetPercent, this.IsNewLittleHit);
				}
			}
			else if (this.CurrentLittleState == RageBufferStateMachine.EState.Hit)
			{
				this.BufferCountDown += delta;
				if (this.BufferCountDown > (float)this.ConfigHitDelayTimes)
				{
					this.CurrentLittleState = RageBufferStateMachine.EState.Animation;
				}
				RageBufferStateMachine.OnUpdateLittleReduce updateLittleReduce2 = this.UpdateLittleReduce;
				if (updateLittleReduce2 != null)
				{
					updateLittleReduce2(this.CurrentPercent, this.TargetPercent, this.IsNewLittleHit);
				}
			}
			this.IsNewLittleHit = false;
			if (this.CurrentLargeState == RageBufferStateMachine.EState.Animation)
			{
				this.CurrentLargeTime -= delta;
				if (this.CurrentLargeTime <= 0f)
				{
					this.CurrentLargeState = RageBufferStateMachine.EState.Origin;
					this.CurrentLargePercent = this.TargetLargePercent;
					RageBufferStateMachine.OnUpdateLargeReduce updateLargeReduce = this.UpdateLargeReduce;
					if (updateLargeReduce == null)
					{
						return;
					}
					updateLargeReduce(this.CurrentLargePercent, this.TargetLargePercent);
					return;
				}
			}
			else if (this.CurrentLargeState == RageBufferStateMachine.EState.Hit)
			{
				this.CurrentLargeState = RageBufferStateMachine.EState.Animation;
				this.CurrentLargeTime = 1000f;
				RageBufferStateMachine.OnUpdateLargeReduce updateLargeReduce2 = this.UpdateLargeReduce;
				if (updateLargeReduce2 == null)
				{
					return;
				}
				updateLargeReduce2(this.CurrentLargePercent, this.TargetLargePercent);
			}
		}

		// Token: 0x060319B4 RID: 203188 RVA: 0x00DDEAE0 File Offset: 0x00DDCCE0
		public void GetHit(float curPercent, float oldPercent)
		{
			if (oldPercent < curPercent)
			{
				return;
			}
			if (oldPercent > 0f && curPercent <= 0f)
			{
				this.CurrentEmptyState = RageBufferStateMachine.EState.Animation;
			}
			if (oldPercent - curPercent >= this.HitLargePercent)
			{
				this.CurrentLargeState = RageBufferStateMachine.EState.Hit;
				if (this.CurrentLittleState == RageBufferStateMachine.EState.Hit || this.CurrentLittleState == RageBufferStateMachine.EState.Animation)
				{
					this.CurrentLittleState = RageBufferStateMachine.EState.Animation;
					this.CurrentTime = 0f;
					this.CurrentPercent = curPercent;
					this.TargetPercent = curPercent;
				}
				this.CurrentLargePercent = oldPercent;
				this.TargetLargePercent = curPercent;
				return;
			}
			if (this.CurrentLittleState == RageBufferStateMachine.EState.Origin)
			{
				this.CurrentLittleState = RageBufferStateMachine.EState.Hit;
				this.HitTimes = 1;
				this.BufferCountDown = 0f;
				this.CurrentPercent = oldPercent;
				this.TargetPercent = curPercent;
				this.CurrentTime = (float)this.HitBufferDisappearTime;
			}
			else if (this.CurrentLittleState == RageBufferStateMachine.EState.Hit)
			{
				this.HitTimes++;
				if (this.HitTimes > this.HitRefreshTimes)
				{
					this.CurrentLittleState = RageBufferStateMachine.EState.Animation;
				}
				this.BufferCountDown = 0f;
				this.TargetPercent = curPercent;
			}
			else if (this.CurrentLittleState == RageBufferStateMachine.EState.Animation)
			{
				this.TargetPercent = curPercent;
			}
			this.IsNewLittleHit = true;
		}

		// Token: 0x060319B5 RID: 203189 RVA: 0x00DDEBF6 File Offset: 0x00DDCDF6
		public void Reset()
		{
			this.CurrentLittleState = RageBufferStateMachine.EState.Origin;
			this.CurrentLargeState = RageBufferStateMachine.EState.Origin;
			this.CurrentEmptyState = RageBufferStateMachine.EState.Origin;
		}

		// Token: 0x0401A41F RID: 107551
		private const float LARGE_TIME = 1000f;

		// Token: 0x0401A420 RID: 107552
		private RageBufferStateMachine.EState CurrentLittleState;

		// Token: 0x0401A421 RID: 107553
		private RageBufferStateMachine.EState CurrentLargeState;

		// Token: 0x0401A422 RID: 107554
		private RageBufferStateMachine.EState CurrentEmptyState;

		// Token: 0x0401A423 RID: 107555
		private float BufferCountDown;

		// Token: 0x0401A424 RID: 107556
		private int HitTimes;

		// Token: 0x0401A425 RID: 107557
		public float TargetPercent;

		// Token: 0x0401A426 RID: 107558
		public float CurrentPercent;

		// Token: 0x0401A427 RID: 107559
		private float CurrentTime;

		// Token: 0x0401A428 RID: 107560
		private float TargetLargePercent;

		// Token: 0x0401A429 RID: 107561
		private float CurrentLargePercent;

		// Token: 0x0401A42A RID: 107562
		private float CurrentLargeTime;

		// Token: 0x0401A42B RID: 107563
		private bool IsNewLittleHit;

		// Token: 0x0401A42C RID: 107564
		private readonly int ConfigHitDelayTimes;

		// Token: 0x0401A42D RID: 107565
		private readonly int HitRefreshTimes;

		// Token: 0x0401A42E RID: 107566
		private readonly int HitBufferDisappearTime;

		// Token: 0x0401A42F RID: 107567
		private readonly float HitLargePercent;

		// Token: 0x0401A430 RID: 107568
		[Nullable(2)]
		private RageBufferStateMachine.OnUpdateLittleReduce UpdateLittleReduce;

		// Token: 0x0401A431 RID: 107569
		[Nullable(2)]
		private RageBufferStateMachine.OnUpdateLargeReduce UpdateLargeReduce;

		// Token: 0x0401A432 RID: 107570
		[Nullable(2)]
		private Action NotifyEmpty;

		// Token: 0x0200A9F8 RID: 43512
		// (Invoke) Token: 0x060467C3 RID: 288707
		public delegate void OnUpdateLittleReduce(float curPercent, float targetPercent, bool isNewHit);

		// Token: 0x0200A9F9 RID: 43513
		// (Invoke) Token: 0x060467C7 RID: 288711
		public delegate void OnUpdateLargeReduce(float curPercent, float targetPercent);

		// Token: 0x0200A9FA RID: 43514
		private enum EState
		{
			// Token: 0x04034896 RID: 215190
			Origin,
			// Token: 0x04034897 RID: 215191
			Hit,
			// Token: 0x04034898 RID: 215192
			Animation
		}
	}
}
