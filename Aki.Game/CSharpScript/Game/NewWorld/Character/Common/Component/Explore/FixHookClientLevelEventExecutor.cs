using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Character.Custom.Components;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x02006348 RID: 25416
	public class FixHookClientLevelEventExecutor
	{
		// Token: 0x0603D96D RID: 252269 RVA: 0x011D6788 File Offset: 0x011D4988
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private static List<ActionInfo> GetActions(FixHookClientLevelEventExecutor.EHookPointStage stage, IHookInteractType hookInteractConfig = null)
		{
			switch (stage)
			{
			case FixHookClientLevelEventExecutor.EHookPointStage.ClientHook:
			{
				if (hookInteractConfig == null)
				{
					return null;
				}
				IClientHookActionConfig clientHookActionConfig = hookInteractConfig.ClientHookActionConfig;
				if (clientHookActionConfig == null)
				{
					return null;
				}
				return clientHookActionConfig.HookActions;
			}
			case FixHookClientLevelEventExecutor.EHookPointStage.ClientMidway:
			{
				if (hookInteractConfig == null)
				{
					return null;
				}
				IClientHookActionConfig clientHookActionConfig2 = hookInteractConfig.ClientHookActionConfig;
				if (clientHookActionConfig2 == null)
				{
					return null;
				}
				return clientHookActionConfig2.ExitHookActions;
			}
			case FixHookClientLevelEventExecutor.EHookPointStage.ClientEndpoint:
			{
				if (hookInteractConfig == null)
				{
					return null;
				}
				IClientHookActionConfig clientHookActionConfig3 = hookInteractConfig.ClientHookActionConfig;
				if (clientHookActionConfig3 == null)
				{
					return null;
				}
				return clientHookActionConfig3.FinishActions;
			}
			default:
				return null;
			}
		}

		// Token: 0x0603D96E RID: 252270 RVA: 0x011D67F0 File Offset: 0x011D49F0
		[NullableContext(1)]
		public static void ExecuteHookActions(FixHookClientLevelEventExecutor.EHookPointStage stage, GrapplingHookPointComponent grapplingHookPointComponent)
		{
			IHookInteractType hookInteractConfig = grapplingHookPointComponent.GetHookInteractConfig();
			List<ActionInfo> actions = FixHookClientLevelEventExecutor.GetActions(stage, hookInteractConfig);
			if (actions == null || actions.Count == 0)
			{
				return;
			}
			int id = grapplingHookPointComponent.Entity.Id;
			LevelGeneralController.Instance.ExecuteActionsNew(actions, EntityContext.Create(id, null), null);
		}

		// Token: 0x0200BB4C RID: 47948
		public enum EHookPointStage
		{
			// Token: 0x04039999 RID: 235929
			ClientHook,
			// Token: 0x0403999A RID: 235930
			ClientMidway,
			// Token: 0x0403999B RID: 235931
			ClientEndpoint
		}
	}
}
