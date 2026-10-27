using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x0200476E RID: 18286
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayEntityLinkService : IGameplayEntityLinkService
	{
		// Token: 0x0602FCDC RID: 195804 RVA: 0x00B133B1 File Offset: 0x00B115B1
		public GameplayEntityLinkService(WuWaGoGameData gameData)
		{
		}

		// Token: 0x0602FCDD RID: 195805 RVA: 0x00B133CB File Offset: 0x00B115CB
		public IReadOnlyList<int> GetLinkedGroupPbDataIds(int sourcePbDataId)
		{
			return this.<gameData>P.GetLinkedGameplayEntityGroupPbDataIds(sourcePbDataId);
		}

		// Token: 0x0602FCDE RID: 195806 RVA: 0x00B133D9 File Offset: 0x00B115D9
		public int GetLinkedGroupRootPbDataId(int sourcePbDataId)
		{
			return this.<gameData>P.GetLinkedGameplayEntityGroupRootPbDataId(sourcePbDataId);
		}

		// Token: 0x0602FCDF RID: 195807 RVA: 0x00B133E7 File Offset: 0x00B115E7
		public IReadOnlyList<ActionInfo> FilterLinkedActionList(int sourcePbDataId, IReadOnlyList<ActionInfo> actionList)
		{
			return this.<gameData>P.FilterLinkedGameplayEntityActionList(sourcePbDataId, actionList);
		}

		// Token: 0x0602FCE0 RID: 195808 RVA: 0x00B133F8 File Offset: 0x00B115F8
		public void SyncLinkedEntityState(int sourcePbDataId, EGameplayEntityState targetState)
		{
			foreach (int num in this.GetLinkedGroupPbDataIds(sourcePbDataId))
			{
				WuWaGoGameplayEntityBase gameplayEntityByPbDataId = this.<gameData>P.GetGameplayEntityByPbDataId(num);
				if (gameplayEntityByPbDataId == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.WuWaGo;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "联通机关同步失败，目标实体不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", num);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					gameplayEntityByPbDataId.SetState(targetState);
				}
			}
		}

		// Token: 0x0602FCE1 RID: 195809 RVA: 0x00B13488 File Offset: 0x00B11688
		public void OnRollbackRestore()
		{
			this.RebuildPressureTriggerGroupPressedState();
		}

		// Token: 0x0602FCE2 RID: 195810 RVA: 0x00B13490 File Offset: 0x00B11690
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<bool, IReadOnlyList<ActionInfo>>? ConsumePressureTriggerGroupChange(int sourcePbDataId)
		{
			WuWaGoPressureTriggerEntity wuWaGoPressureTriggerEntity = this.<gameData>P.GetGameplayEntityByPbDataId(sourcePbDataId) as WuWaGoPressureTriggerEntity;
			if (wuWaGoPressureTriggerEntity == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.WuWaGo;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "联通压力板结算失败，源实体类型不正确";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", sourcePbDataId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			int linkedGroupRootPbDataId = this.GetLinkedGroupRootPbDataId(sourcePbDataId);
			bool flag2;
			bool flag = this.PressureTriggerGroupPressedState.TryGetValue(linkedGroupRootPbDataId, out flag2) && flag2;
			bool flag3 = this.IsPressureTriggerGroupPressed(sourcePbDataId);
			this.PressureTriggerGroupPressedState[linkedGroupRootPbDataId] = flag3;
			this.SyncLinkedEntityState(sourcePbDataId, flag3 ? EGameplayEntityState.Activated : EGameplayEntityState.Normal);
			if (!flag && flag3)
			{
				return new ValueTuple<bool, IReadOnlyList<ActionInfo>>?(new ValueTuple<bool, IReadOnlyList<ActionInfo>>(true, this.FilterLinkedActionList(sourcePbDataId, wuWaGoPressureTriggerEntity.EnterActionList)));
			}
			if (flag && !flag3)
			{
				return new ValueTuple<bool, IReadOnlyList<ActionInfo>>?(new ValueTuple<bool, IReadOnlyList<ActionInfo>>(false, this.FilterLinkedActionList(sourcePbDataId, wuWaGoPressureTriggerEntity.ExitActionList)));
			}
			return null;
		}

		// Token: 0x0602FCE3 RID: 195811 RVA: 0x00B13578 File Offset: 0x00B11778
		private void RebuildPressureTriggerGroupPressedState()
		{
			this.PressureTriggerGroupPressedState.Clear();
			IReadOnlyList<WuWaGoGameplayEntityBase> gameplayEntitiesByType = this.<gameData>P.GetGameplayEntitiesByType(EWuWaGoEntityType.PressureTrigger);
			HashSet<int> hashSet = new HashSet<int>();
			foreach (WuWaGoGameplayEntityBase wuWaGoGameplayEntityBase in gameplayEntitiesByType)
			{
				WuWaGoPressureTriggerEntity wuWaGoPressureTriggerEntity = wuWaGoGameplayEntityBase as WuWaGoPressureTriggerEntity;
				if (wuWaGoPressureTriggerEntity != null && wuWaGoPressureTriggerEntity.Dirty)
				{
					hashSet.Add(this.GetLinkedGroupRootPbDataId(wuWaGoPressureTriggerEntity.EntityPbDataId));
				}
			}
			foreach (WuWaGoGameplayEntityBase wuWaGoGameplayEntityBase2 in gameplayEntitiesByType)
			{
				if (wuWaGoGameplayEntityBase2 is WuWaGoPressureTriggerEntity)
				{
					int linkedGroupRootPbDataId = this.GetLinkedGroupRootPbDataId(wuWaGoGameplayEntityBase2.EntityPbDataId);
					bool flag;
					if (!hashSet.Contains(linkedGroupRootPbDataId) && (!this.PressureTriggerGroupPressedState.TryGetValue(linkedGroupRootPbDataId, out flag) || !flag))
					{
						bool value = this.IsPressureTriggerGroupPressed(wuWaGoGameplayEntityBase2.EntityPbDataId);
						this.PressureTriggerGroupPressedState[linkedGroupRootPbDataId] = value;
					}
				}
			}
		}

		// Token: 0x0602FCE4 RID: 195812 RVA: 0x00B13680 File Offset: 0x00B11880
		private bool IsPressureTriggerGroupPressed(int sourcePbDataId)
		{
			foreach (int pbDataId in this.GetLinkedGroupPbDataIds(sourcePbDataId))
			{
				WuWaGoPressureTriggerEntity wuWaGoPressureTriggerEntity = this.<gameData>P.GetGameplayEntityByPbDataId(pbDataId) as WuWaGoPressureTriggerEntity;
				if (wuWaGoPressureTriggerEntity != null && wuWaGoPressureTriggerEntity.IsOccupied)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04019C9A RID: 105626
		[CompilerGenerated]
		private WuWaGoGameData <gameData>P = gameData;

		// Token: 0x04019C9B RID: 105627
		private readonly Dictionary<int, bool> PressureTriggerGroupPressedState = new Dictionary<int, bool>();
	}
}
