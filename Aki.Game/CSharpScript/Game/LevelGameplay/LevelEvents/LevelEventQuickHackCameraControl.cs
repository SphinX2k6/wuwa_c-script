using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.QuickHack;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B5C RID: 27484
	public class LevelEventQuickHackCameraControl : LevelEventBase
	{
		// Token: 0x060441E2 RID: 279010 RVA: 0x010C47D3 File Offset: 0x010C29D3
		public LevelEventQuickHackCameraControl(int id) : base(id)
		{
		}

		// Token: 0x060441E3 RID: 279011 RVA: 0x010C47DC File Offset: 0x010C29DC
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
