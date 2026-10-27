using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.Elevator
{
	// Token: 0x02007205 RID: 29189
	[NullableContext(1)]
	public interface IElevatorMoveStrategy
	{
		// Token: 0x0604775D RID: 292701
		void InitFromConfig(LiftComponent config, ElevatorContext ctx, float initLocationX, float initLocationY, float initLocationZ);

		// Token: 0x0604775E RID: 292702
		void OnInit();

		// Token: 0x0604775F RID: 292703
		void OnStart(Action tryStartAutoRun);

		// Token: 0x06047760 RID: 292704
		void OnClear();

		// Token: 0x06047761 RID: 292705
		void OnEnterMovePhase();

		// Token: 0x06047762 RID: 292706
		void TickMove(float deltaSeconds);

		// Token: 0x06047763 RID: 292707
		void CheckAndFinishMove(Action onMoveArrived);

		// Token: 0x06047764 RID: 292708
		void PrepareMoveToFloor(Action onReady);

		// Token: 0x06047765 RID: 292709
		bool OnBeforeEnterMoving();

		// Token: 0x06047766 RID: 292710
		int GetFloorCount();

		// Token: 0x06047767 RID: 292711
		float GetMoveDuration();
	}
}
