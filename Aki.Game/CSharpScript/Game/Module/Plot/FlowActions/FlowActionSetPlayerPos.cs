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
	// Token: 0x020050D4 RID: 20692
	public class FlowActionSetPlayerPos : FlowActionServerAction
	{
		// Token: 0x06034F3A RID: 216890 RVA: 0x00C8AF02 File Offset: 0x00C89102
		protected override void OnExecute()
		{
			base.RequestServerAction(false, new Action<ErrorCode>(this.OnFallback));
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		}

		// Token: 0x06034F3B RID: 216891 RVA: 0x00C8AF33 File Offset: 0x00C89133
		private void OnFallback(ErrorCode code)
		{
			if (code == ErrorCode.ErrPlayerIsTeleportCanNotDoTeleport)
			{
				FlowController.Instance.BackgroundFlow("传送失败结束剧情", true, false, false);
			}
		}

		// Token: 0x06034F3C RID: 216892 RVA: 0x00C8AF50 File Offset: 0x00C89150
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

		// Token: 0x06034F3D RID: 216893 RVA: 0x00C8AFB9 File Offset: 0x00C891B9
		protected override void OnBackgroundExecute()
		{
			if (AutoRunModel.Instance.IsInLogicTreeGmMode())
			{
				base.FinishExecute(true, true);
				return;
			}
			this.OnExecute();
		}

		// Token: 0x06034F3E RID: 216894 RVA: 0x00C8AFD6 File Offset: 0x00C891D6
		protected override void OnInterruptExecute()
		{
			if (EventSystem.Instance.Has<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete)))
			{
				this.FinishTeleport();
			}
		}

		// Token: 0x06034F3F RID: 216895 RVA: 0x00C8AFFC File Offset: 0x00C891FC
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
