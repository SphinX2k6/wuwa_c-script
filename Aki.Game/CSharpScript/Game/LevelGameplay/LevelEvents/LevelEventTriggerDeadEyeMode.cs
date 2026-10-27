using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BAC RID: 27564
	public class LevelEventTriggerDeadEyeMode : LevelEventBase
	{
		// Token: 0x06044311 RID: 279313 RVA: 0x010CE900 File Offset: 0x010CCB00
		public LevelEventTriggerDeadEyeMode(int id) : base(id)
		{
		}

		// Token: 0x06044312 RID: 279314 RVA: 0x010CE90C File Offset: 0x010CCB0C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			TriggerDeadeyeMode triggerDeadeyeMode = inParams as TriggerDeadeyeMode;
			if (triggerDeadeyeMode == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "执行行为LevelEventTriggerDeadEyeMode失败，参数错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "执行行为LevelEventTriggerDeadEyeMode失败，CurrentEntity为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			CharacterDriveVehicleComponent component = getCurrentEntity.Entity.GetComponent<CharacterDriveVehicleComponent>();
			if (component == null || !component.IsDriver)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "执行行为LevelEventTriggerDeadEyeMode失败，不在驾驶状态", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (context.Type.GetValueOrDefault() == EGeneralContextType.Trigger)
			{
				TriggerContext triggerContext = context as TriggerContext;
				if (triggerContext != null && triggerContext.TriggerEntityId != null)
				{
					Entity entity = EntitySystem.Instance.Get(triggerContext.TriggerEntityId.Value);
					if (entity == null)
					{
						global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "执行行为LevelEventTriggerDeadEyeMode失败，触发器实体不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
					CreatureDataComponent component2 = entity.GetComponent<CreatureDataComponent>();
					DeadEyeModeController.Instance.EnterDeadEyeJumpPlatform(triggerDeadeyeMode, component2.GetCreatureDataId());
					return;
				}
			}
			global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "执行行为LevelEventTriggerDeadEyeMode失败，上下文参数不对", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}
}
