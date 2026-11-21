using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Controller.GameMode;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x020036A5 RID: 13989
	[NullableContext(1)]
	[Nullable(0)]
	public class PressureTriggerController : GameplayEntityControllerBase
	{
		// Token: 0x060244F8 RID: 148728 RVA: 0x00A44F3C File Offset: 0x00A4313C
		public PressureTriggerController(WuWaGoGameplayEntityBase entity, WuWaGoGameData gameData, WuWaGoGameModeBase gameMode) : base(entity, gameData, gameMode)
		{
		}

		// Token: 0x17004A2A RID: 18986
		// (get) Token: 0x060244F9 RID: 148729 RVA: 0x00A44F47 File Offset: 0x00A43147
		private WuWaGoPressureTriggerEntity PressureTrigger
		{
			get
			{
				return this.Entity as WuWaGoPressureTriggerEntity;
			}
		}

		// Token: 0x060244FA RID: 148730 RVA: 0x00A44F54 File Offset: 0x00A43154
		protected override bool OnCreate()
		{
			if (!base.OnCreate())
			{
				return false;
			}
			base.RegisterAttachedGridMoveParticipant();
			return true;
		}

		// Token: 0x060244FB RID: 148731 RVA: 0x00A44F67 File Offset: 0x00A43167
		protected override void OnDestroy()
		{
			base.OnDestroy();
			base.UnregisterAttachedGridMoveParticipant();
		}

		// Token: 0x060244FC RID: 148732 RVA: 0x00A44F78 File Offset: 0x00A43178
		protected override UniTask OnExecuteAction()
		{
			PressureTriggerController.<OnExecuteAction>d__5 <OnExecuteAction>d__;
			<OnExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExecuteAction>d__.<>4__this = this;
			<OnExecuteAction>d__.<>1__state = -1;
			<OnExecuteAction>d__.<>t__builder.Start<PressureTriggerController.<OnExecuteAction>d__5>(ref <OnExecuteAction>d__);
			return <OnExecuteAction>d__.<>t__builder.Task;
		}

		// Token: 0x060244FD RID: 148733 RVA: 0x00A44FBB File Offset: 0x00A431BB
		protected override void OnAfterExecuteAction()
		{
			this.ExecuteDirtyChange().Forget();
		}

		// Token: 0x060244FE RID: 148734 RVA: 0x00A44FC8 File Offset: 0x00A431C8
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
