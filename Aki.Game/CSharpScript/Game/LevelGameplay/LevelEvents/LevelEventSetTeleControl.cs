using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B7E RID: 27518
	public class LevelEventSetTeleControl : LevelEventBase
	{
		// Token: 0x06044262 RID: 279138 RVA: 0x010CA3DE File Offset: 0x010C85DE
		public LevelEventSetTeleControl(int id) : base(id)
		{
		}

		// Token: 0x06044263 RID: 279139 RVA: 0x010CA3E8 File Offset: 0x010C85E8
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SetTeleControl setTeleControl = inParams as SetTeleControl;
			if (setTeleControl.Config.Type != ESetTeleControlType.OpenGravity)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			CreatureModel instance = CreatureModel.Instance;
			EntityHandle entityHandle = (instance != null) ? instance.GetEntityByPbDataId(setTeleControl.Config.EntityId) : null;
			SceneItemManipulatableComponent sceneItemManipulatableComponent;
			if (entityHandle == null)
			{
				sceneItemManipulatableComponent = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				sceneItemManipulatableComponent = ((entity != null) ? entity.GetComponent<SceneItemManipulatableComponent>() : null);
			}
			SceneItemManipulatableComponent sceneItemManipulatableComponent2 = sceneItemManipulatableComponent;
			if (entityHandle == null || !entityHandle.Valid || sceneItemManipulatableComponent2 == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.ZYL, "[LevelEventSetTeleControl] 找不到对应的实体组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			if (sceneItemManipulatableComponent2.GetState() == SceneItemManipulatableComponent.EManipulatableState.BeDropping)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			if (sceneItemManipulatableComponent2.GetState() != SceneItemManipulatableComponent.EManipulatableState.Reset)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.ZYL, "[LevelEventSetTeleControl] 被控物不处于Reset状态", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			sceneItemManipulatableComponent2.SetState(SceneItemManipulatableComponent.EManipulatableState.BeDropping, "LevelEventSetTeleControl Execute");
			base.FinishExecute(true, false, true);
		}
	}
}
