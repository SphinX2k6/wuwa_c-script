using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x02004774 RID: 18292
	[NullableContext(1)]
	[Nullable(0)]
	public class PressureTriggerController : GameplayEntityControllerBase
	{
		// Token: 0x0602FD2E RID: 195886 RVA: 0x00B14EDC File Offset: 0x00B130DC
		public PressureTriggerController(WuWaGoGameplayEntityBase entity, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(entity, gameData, gameMode)
		{
		}

		// Token: 0x1700776E RID: 30574
		// (get) Token: 0x0602FD2F RID: 195887 RVA: 0x00B14EE7 File Offset: 0x00B130E7
		private WuWaGoPressureTriggerEntity PressureTrigger
		{
			get
			{
				return this.Entity as WuWaGoPressureTriggerEntity;
			}
		}

		// Token: 0x0602FD30 RID: 195888 RVA: 0x00B14EF4 File Offset: 0x00B130F4
		protected override bool OnCreate()
		{
			if (!base.OnCreate())
			{
				return false;
			}
			base.RegisterAttachedGridMoveParticipant();
			return true;
		}

		// Token: 0x0602FD31 RID: 195889 RVA: 0x00B14F07 File Offset: 0x00B13107
		protected override void OnDestroy()
		{
			base.OnDestroy();
			base.UnregisterAttachedGridMoveParticipant();
		}

		// Token: 0x0602FD32 RID: 195890 RVA: 0x00B14F18 File Offset: 0x00B13118
		protected override UniTask OnExecuteAction()
		{
			PressureTriggerController.<OnExecuteAction>d__5 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>4__this = this;
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<PressureTriggerController.<OnExecuteAction>d__5>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD33 RID: 195891 RVA: 0x00B14F5B File Offset: 0x00B1315B
		protected override void OnAfterExecuteAction()
		{
			this.ExecuteDirtyChange().Forget();
		}

		// Token: 0x0602FD34 RID: 195892 RVA: 0x00B14F68 File Offset: 0x00B13168
		private UniTask ExecuteDirtyChange()
		{
			PressureTriggerController.<ExecuteDirtyChange>d__7 <ExecuteDirtyChange>d__;
			<ExecuteDirtyChange>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteDirtyChange>d__.<>4__this = this;
			<ExecuteDirtyChange>d__.<>1__state = -1;
			<ExecuteDirtyChange>d__.<>t__builder.Start<PressureTriggerController.<ExecuteDirtyChange>d__7>(ref <ExecuteDirtyChange>d__);
			return <ExecuteDirtyChange>d__.<>t__builder.Task;
		}
	}
}
