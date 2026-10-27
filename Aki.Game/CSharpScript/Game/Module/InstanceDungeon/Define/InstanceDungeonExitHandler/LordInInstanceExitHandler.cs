using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058F3 RID: 22771
	public class LordInInstanceExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D22 RID: 236834 RVA: 0x00DBBEB4 File Offset: 0x00DBA0B4
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

		// Token: 0x06039D23 RID: 236835 RVA: 0x00DBBF10 File Offset: 0x00DBA110
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

		// Token: 0x0401E2D9 RID: 123609
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
