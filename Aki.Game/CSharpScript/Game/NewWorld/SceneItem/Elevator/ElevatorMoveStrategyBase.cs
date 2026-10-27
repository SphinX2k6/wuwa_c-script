using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.Elevator
{
	// Token: 0x02007206 RID: 29190
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ElevatorMoveStrategyBase : IElevatorMoveStrategy
	{
		// Token: 0x06047768 RID: 292712
		public abstract void InitFromConfig(LiftComponent config, ElevatorContext ctx, float initLocationX, float initLocationY, float initLocationZ);

		// Token: 0x06047769 RID: 292713
		public abstract void OnInit();

		// Token: 0x0604776A RID: 292714
		public abstract void OnStart(Action tryStartAutoRun);

		// Token: 0x0604776B RID: 292715
		public abstract void TickMove(float deltaSeconds);

		// Token: 0x0604776C RID: 292716
		public abstract void CheckAndFinishMove(Action onMoveArrived);

		// Token: 0x0604776D RID: 292717
		public abstract int GetFloorCount();

		// Token: 0x0604776E RID: 292718
		public abstract float GetMoveDuration();

		// Token: 0x0604776F RID: 292719 RVA: 0x01233EFA File Offset: 0x012320FA
		public virtual void OnEnterMovePhase()
		{
		}

		// Token: 0x06047770 RID: 292720 RVA: 0x01233EFC File Offset: 0x012320FC
		public virtual void PrepareMoveToFloor(Action onReady)
		{
			onReady();
		}

		// Token: 0x06047771 RID: 292721 RVA: 0x01233F04 File Offset: 0x01232104
		public virtual bool OnBeforeEnterMoving()
		{
			return true;
		}

		// Token: 0x06047772 RID: 292722 RVA: 0x01233F07 File Offset: 0x01232107
		public virtual void OnClear()
		{
		}

		// Token: 0x04025967 RID: 153959
		protected ElevatorContext Ctx;
	}
}
