using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SceneActorRef
{
	// Token: 0x02006BC2 RID: 27586
	public class LevelEventModifyActorMaterialParamBySplineProgress : LevelEventBase
	{
		// Token: 0x0604435D RID: 279389 RVA: 0x010D0553 File Offset: 0x010CE753
		public LevelEventModifyActorMaterialParamBySplineProgress(int id) : base(id)
		{
		}

		// Token: 0x0604435E RID: 279390 RVA: 0x010D055C File Offset: 0x010CE75C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			EntityHandle entityHandle = LevelGamePlayUtils.GetEntityHandle(null, context);
			SceneItemReferenceComponent sceneItemReferenceComponent;
			if (entityHandle == null)
			{
				sceneItemReferenceComponent = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				sceneItemReferenceComponent = ((entity != null) ? entity.CheckGetComponent<SceneItemReferenceComponent>() : null);
			}
			SceneItemReferenceComponent sceneItemReferenceComponent2 = sceneItemReferenceComponent;
			if (sceneItemReferenceComponent2 == null)
			{
				return;
			}
			sceneItemReferenceComponent2.HandleModifyActorMaterialParamBySplineProgress((ModifyActorMaterialParamBySplineProgress)inParams);
		}
	}
}
