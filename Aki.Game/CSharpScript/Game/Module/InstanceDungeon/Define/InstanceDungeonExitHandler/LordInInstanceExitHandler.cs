using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048CB RID: 18635
	public class LordInInstanceExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC45 RID: 191557 RVA: 0x00D0AE18 File Offset: 0x00D09018
		public override bool Checker()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && LordInInstanceExitHandler.CheckSubTypes.Contains((EDungeonSubType)config.Value.InstSubType);
		}

		// Token: 0x0602EC46 RID: 191558 RVA: 0x00D0AE74 File Offset: 0x00D09074
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			LordInInstanceExitHandler.<>c__DisplayClass2_0 CS$<>8__locals1 = new LordInInstanceExitHandler.<>c__DisplayClass2_0();
			CS$<>8__locals1.data = data;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleTrialLeaveInstanceConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			Dictionary<int, Action> functionMap = confirmBoxDataNew.FunctionMap;
			int key = 0;
			InstanceDungeonExitHandlerData data2 = CS$<>8__locals1.data;
			functionMap[key] = ((data2 != null) ? data2.CancelBack : null);
			confirmBoxDataNew.FunctionMap[1] = new Action(CS$<>8__locals1.<HandleExit>g__ReChallenge|1);
			confirmBoxDataNew.FunctionMap[2] = new Action(CS$<>8__locals1.<HandleExit>g__Leave|0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x04018D76 RID: 101750
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly HashSet<EDungeonSubType> CheckSubTypes = new HashSet<EDungeonSubType>
		{
			EDungeonSubType.LordInInstance,
			EDungeonSubType.Boss,
			EDungeonSubType.PlayInstShare,
			EDungeonSubType.MonsterSettlementInstShare,
			EDungeonSubType.NightmareLordInstShare,
			EDungeonSubType.LordInstShare,
			EDungeonSubType.SilentAreaInstShare
		};
	}
}
