using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x0200369F RID: 13983
	[NullableContext(1)]
	[Nullable(0)]
	public class GameplayEntityLinkService : IGameplayEntityLinkService
	{
		// Token: 0x060244A6 RID: 148646 RVA: 0x00A43371 File Offset: 0x00A41571
		public GameplayEntityLinkService(WuWaGoGameData gameData)
		{
		}

		// Token: 0x060244A7 RID: 148647 RVA: 0x00A4338B File Offset: 0x00A4158B
		public IReadOnlyList<int> GetLinkedGroupPbDataIds(int sourcePbDataId)
		{
			return this.<gameData>P.GetLinkedGameplayEntityGroupPbDataIds(sourcePbDataId);
		}

		// Token: 0x060244A8 RID: 148648 RVA: 0x00A43399 File Offset: 0x00A41599
		public int GetLinkedGroupRootPbDataId(int sourcePbDataId)
		{
			return this.<gameData>P.GetLinkedGameplayEntityGroupRootPbDataId(sourcePbDataId);
		}

		// Token: 0x060244A9 RID: 148649 RVA: 0x00A433A7 File Offset: 0x00A415A7
		public IReadOnlyList<ActionInfo> FilterLinkedActionList(int sourcePbDataId, IReadOnlyList<ActionInfo> actionList)
		{
			return this.<gameData>P.FilterLinkedGameplayEntityActionList(sourcePbDataId, actionList);
		}

		// Token: 0x060244AA RID: 148650 RVA: 0x00A433B8 File Offset: 0x00A415B8
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

		// Token: 0x060244AB RID: 148651 RVA: 0x00A43448 File Offset: 0x00A41648
		public void OnRollbackRestore()
		{
			this.RebuildPressureTriggerGroupPressedState();
		}

		// Token: 0x060244AC RID: 148652 RVA: 0x00A43450 File Offset: 0x00A41650
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

		// Token: 0x060244AD RID: 148653 RVA: 0x00A43538 File Offset: 0x00A41738
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

		// Token: 0x060244AE RID: 148654 RVA: 0x00A43640 File Offset: 0x00A41840
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

		// Token: 0x0401434A RID: 82762
		[CompilerGenerated]
		private WuWaGoGameData <gameData>P = gameData;

		// Token: 0x0401434B RID: 82763
		private readonly Dictionary<int, bool> PressureTriggerGroupPressedState = new Dictionary<int, bool>();
	}
}
