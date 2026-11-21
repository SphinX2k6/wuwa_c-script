using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.Elevator
{
	// Token: 0x020062BB RID: 25275
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ElevatorMoveStrategyBase : IElevatorMoveStrategy
	{
		// Token: 0x0603D079 RID: 249977
		public abstract void InitFromConfig(LiftComponent config, ElevatorContext ctx, float initLocationX, float initLocationY, float initLocationZ);

		// Token: 0x0603D07A RID: 249978
		public abstract void OnInit();

		// Token: 0x0603D07B RID: 249979
		public abstract void OnStart(Action tryStartAutoRun);

		// Token: 0x0603D07C RID: 249980
		public abstract void TickMove(float deltaSeconds);

		// Token: 0x0603D07D RID: 249981
		public abstract void CheckAndFinishMove(Action onMoveArrived);

		// Token: 0x0603D07E RID: 249982
		public abstract int GetFloorCount();

		// Token: 0x0603D07F RID: 249983
		public abstract float GetMoveDuration();

		// Token: 0x0603D080 RID: 249984 RVA: 0x0118D989 File Offset: 0x0118BB89
		public virtual void OnEnterMovePhase()
		{
		}

		// Token: 0x0603D081 RID: 249985 RVA: 0x0118D98B File Offset: 0x0118BB8B
		public virtual void PrepareMoveToFloor(Action onReady)
		{
			onReady();
		}

		// Token: 0x0603D082 RID: 249986 RVA: 0x0118D993 File Offset: 0x0118BB93
		public virtual bool OnBeforeEnterMoving()
		{
			return true;
		}

		// Token: 0x0603D083 RID: 249987 RVA: 0x0118D996 File Offset: 0x0118BB96
		public virtual void OnClear()
		{
		}

		// Token: 0x040205D6 RID: 132566
		protected ElevatorContext Ctx;
	}
}
