using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.Elevator
{
	// Token: 0x020062BA RID: 25274
	[NullableContext(1)]
	public interface IElevatorMoveStrategy
	{
		// Token: 0x0603D06E RID: 249966
		void InitFromConfig(LiftComponent config, ElevatorContext ctx, float initLocationX, float initLocationY, float initLocationZ);

		// Token: 0x0603D06F RID: 249967
		void OnInit();

		// Token: 0x0603D070 RID: 249968
		void OnStart(Action tryStartAutoRun);

		// Token: 0x0603D071 RID: 249969
		void OnClear();

		// Token: 0x0603D072 RID: 249970
		void OnEnterMovePhase();

		// Token: 0x0603D073 RID: 249971
		void TickMove(float deltaSeconds);

		// Token: 0x0603D074 RID: 249972
		void CheckAndFinishMove(Action onMoveArrived);

		// Token: 0x0603D075 RID: 249973
		void PrepareMoveToFloor(Action onReady);

		// Token: 0x0603D076 RID: 249974
		bool OnBeforeEnterMoving();

		// Token: 0x0603D077 RID: 249975
		int GetFloorCount();

		// Token: 0x0603D078 RID: 249976
		float GetMoveDuration();
	}
}
