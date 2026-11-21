using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.QuickHack;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CD4 RID: 23764
	public class LevelEventQuickHackCameraControl : LevelEventBase
	{
		// Token: 0x0603A334 RID: 238388 RVA: 0x0106E3A0 File Offset: 0x0106C5A0
		public LevelEventQuickHackCameraControl(int id) : base(id)
		{
		}

		// Token: 0x0603A335 RID: 238389 RVA: 0x0106E3AC File Offset: 0x0106C5AC
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			OpenQuickHackSystem openQuickHackSystem = inParams as OpenQuickHackSystem;
			if (openQuickHackSystem == null)
			{
				return;
			}
			if (openQuickHackSystem.CameraConfig == null || openQuickHackSystem.Entities == null)
			{
				EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
				if (getCurrentEntity != null && getCurrentEntity.Valid)
				{
					QuickHackController.Instance.CloseQuickHack();
					QuickHackController.Instance.OpenQuickHack(openQuickHackSystem.DeviceId, getCurrentEntity.Id, true, null, null);
				}
				return;
			}
			EntityContext entityContext = context as EntityContext;
			if (entityContext == null)
			{
				return;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityContext.EntityId.GetValueOrDefault());
			if (entityById == null || !entityById.Valid)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "QuickHackCameraControl 实体不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", entityContext.EntityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			QuickHackController.Instance.OpenQuickHackCameraControl(entityById.Entity.GetComponent<CreatureDataComponent>().GetPbDataId(), openQuickHackSystem);
		}
	}
}
