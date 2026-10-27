using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D4F RID: 23887
	public class RageBufferStateMachine
	{
		// Token: 0x0603CA58 RID: 248408 RVA: 0x00E8E0F8 File Offset: 0x00E8C2F8
		public RageBufferStateMachine()
		{
			this.ConfigHitDelayTimes = ConfigCommonParamById.GetIntConfig("HitDelayTime").Value;
			this.HitRefreshTimes = ConfigCommonParamById.GetIntConfig("HitRefreshTime").Value;
			this.HitBufferDisappearTime = ConfigCommonParamById.GetIntConfig("HitBufferDisappearTime").Value;
			this.HitLargePercent = (float)ConfigCommonParamById.GetIntConfig("HitLargePercent").Value / 10000f;
			this.CurrentTime = (float)this.HitBufferDisappearTime;
		}

		// Token: 0x0603CA59 RID: 248409 RVA: 0x00E8E17F File Offset: 0x00E8C37F
		[NullableContext(1)]
		public void SetUpdateCallback(RageBufferStateMachine.OnUpdateLittleReduce updateLittleReduce, RageBufferStateMachine.OnUpdateLargeReduce updateLargeReduce, Action notifyEmpty)
		{
			this.UpdateLittleReduce = updateLittleReduce;
			this.UpdateLargeReduce = updateLargeReduce;
			this.NotifyEmpty = notifyEmpty;
		}

		// Token: 0x0603CA5A RID: 248410 RVA: 0x00E8E198 File Offset: 0x00E8C398
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

		// Token: 0x0603CA5B RID: 248411 RVA: 0x00E8E32C File Offset: 0x00E8C52C
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

		// Token: 0x0603CA5C RID: 248412 RVA: 0x00E8E442 File Offset: 0x00E8C642
		public void Reset()
		{
			this.CurrentLittleState = RageBufferStateMachine.EState.Origin;
			this.CurrentLargeState = RageBufferStateMachine.EState.Origin;
			this.CurrentEmptyState = RageBufferStateMachine.EState.Origin;
		}

		// Token: 0x0401F966 RID: 129382
		private const float LARGE_TIME = 1000f;

		// Token: 0x0401F967 RID: 129383
		private RageBufferStateMachine.EState CurrentLittleState;

		// Token: 0x0401F968 RID: 129384
		private RageBufferStateMachine.EState CurrentLargeState;

		// Token: 0x0401F969 RID: 129385
		private RageBufferStateMachine.EState CurrentEmptyState;

		// Token: 0x0401F96A RID: 129386
		private float BufferCountDown;

		// Token: 0x0401F96B RID: 129387
		private int HitTimes;

		// Token: 0x0401F96C RID: 129388
		public float TargetPercent;

		// Token: 0x0401F96D RID: 129389
		public float CurrentPercent;

		// Token: 0x0401F96E RID: 129390
		private float CurrentTime;

		// Token: 0x0401F96F RID: 129391
		private float TargetLargePercent;

		// Token: 0x0401F970 RID: 129392
		private float CurrentLargePercent;

		// Token: 0x0401F971 RID: 129393
		private float CurrentLargeTime;

		// Token: 0x0401F972 RID: 129394
		private bool IsNewLittleHit;

		// Token: 0x0401F973 RID: 129395
		private readonly int ConfigHitDelayTimes;

		// Token: 0x0401F974 RID: 129396
		private readonly int HitRefreshTimes;

		// Token: 0x0401F975 RID: 129397
		private readonly int HitBufferDisappearTime;

		// Token: 0x0401F976 RID: 129398
		private readonly float HitLargePercent;

		// Token: 0x0401F977 RID: 129399
		[Nullable(2)]
		private RageBufferStateMachine.OnUpdateLittleReduce UpdateLittleReduce;

		// Token: 0x0401F978 RID: 129400
		[Nullable(2)]
		private RageBufferStateMachine.OnUpdateLargeReduce UpdateLargeReduce;

		// Token: 0x0401F979 RID: 129401
		[Nullable(2)]
		private Action NotifyEmpty;

		// Token: 0x0200BFF2 RID: 49138
		// (Invoke) Token: 0x06050280 RID: 328320
		public delegate void OnUpdateLittleReduce(float curPercent, float targetPercent, bool isNewHit);

		// Token: 0x0200BFF3 RID: 49139
		// (Invoke) Token: 0x06050284 RID: 328324
		public delegate void OnUpdateLargeReduce(float curPercent, float targetPercent);

		// Token: 0x0200BFF4 RID: 49140
		private enum EState
		{
			// Token: 0x04039ED4 RID: 237268
			Origin,
			// Token: 0x04039ED5 RID: 237269
			Hit,
			// Token: 0x04039ED6 RID: 237270
			Animation
		}
	}
}
