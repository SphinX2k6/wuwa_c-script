using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Teleport;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020040A4 RID: 16548
	public class FlowActionSetPlayerPos : FlowActionServerAction
	{
		// Token: 0x06029E33 RID: 171571 RVA: 0x00BD81EA File Offset: 0x00BD63EA
		protected override void OnExecute()
		{
			base.RequestServerAction(false, new Action<ErrorCode>(this.OnFallback));
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		}

		// Token: 0x06029E34 RID: 171572 RVA: 0x00BD821B File Offset: 0x00BD641B
		private void OnFallback(ErrorCode code)
		{
			if (code == ErrorCode.ErrPlayerIsTeleportCanNotDoTeleport)
			{
				FlowController.Instance.BackgroundFlow("传送失败结束剧情", true, false, false);
			}
		}

		// Token: 0x06029E35 RID: 171573 RVA: 0x00BD8238 File Offset: 0x00BD6438
		[NullableContext(2)]
		private void OnTeleportComplete(TeleportContext teleportContext)
		{
			GeneralContext generalContext = LevelGeneralContextUtil.CreateByServerContext((teleportContext != null) ? teleportContext.GameCtx : null);
			if (generalContext == null || generalContext.Type.GetValueOrDefault() != EGeneralContextType.FlowAction)
			{
				return;
			}
			if (((FlowActionContext)generalContext).FlowActionId != this.Context.CurActionId && ((FlowActionContext)generalContext).FlowActionId != this.Context.CurSubActionId)
			{
				return;
			}
			this.FinishTeleport();
		}

		// Token: 0x06029E36 RID: 171574 RVA: 0x00BD82A1 File Offset: 0x00BD64A1
		protected override void OnBackgroundExecute()
		{
			if (AutoRunModel.Instance.IsInLogicTreeGmMode())
			{
				base.FinishExecute(true, true);
				return;
			}
			this.OnExecute();
		}

		// Token: 0x06029E37 RID: 171575 RVA: 0x00BD82BE File Offset: 0x00BD64BE
		protected override void OnInterruptExecute()
		{
			if (EventSystem.Instance.Has<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete)))
			{
				this.FinishTeleport();
			}
		}

		// Token: 0x06029E38 RID: 171576 RVA: 0x00BD82E4 File Offset: 0x00BD64E4
		private void FinishTeleport()
		{
			PlotModel instance = PlotModel.Instance;
			PosAndRot posAndRot = new PosAndRot();
			CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
			double? num = (characterActorComponent != null) ? new double?(characterActorComponent.ActorLocationProxy.X) : null;
			posAndRot.X = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			CharacterActorComponent characterActorComponent2 = Global.BaseCharacter.CharacterActorComponent;
			num = ((characterActorComponent2 != null) ? new double?(characterActorComponent2.ActorLocationProxy.Y) : null);
			posAndRot.Y = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			CharacterActorComponent characterActorComponent3 = Global.BaseCharacter.CharacterActorComponent;
			num = ((characterActorComponent3 != null) ? new double?(characterActorComponent3.ActorLocationProxy.Z) : null);
			posAndRot.Z = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			CharacterActorComponent characterActorComponent4 = Global.BaseCharacter.CharacterActorComponent;
			posAndRot.A = ((characterActorComponent4 != null) ? new float?(characterActorComponent4.ActorRotationProxy.Yaw) : null);
			CharacterActorComponent characterActorComponent5 = Global.BaseCharacter.CharacterActorComponent;
			posAndRot.Roll = ((characterActorComponent5 != null) ? new float?(characterActorComponent5.ActorRotationProxy.Roll) : null);
			CharacterActorComponent characterActorComponent6 = Global.BaseCharacter.CharacterActorComponent;
			posAndRot.Pitch = ((characterActorComponent6 != null) ? new float?(characterActorComponent6.ActorRotationProxy.Pitch) : null);
			instance.SetTemplatePlayerTransform(posAndRot);
			if (EventSystem.Instance.Has<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete)))
			{
				EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			}
			base.FinishExecute(true, true);
		}
	}
}
