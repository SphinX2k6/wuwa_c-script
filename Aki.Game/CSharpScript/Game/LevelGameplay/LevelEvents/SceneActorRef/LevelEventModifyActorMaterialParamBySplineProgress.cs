using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SceneActorRef
{
	// Token: 0x02005D3B RID: 23867
	public class LevelEventModifyActorMaterialParamBySplineProgress : LevelEventBase
	{
		// Token: 0x0603A4B5 RID: 238773 RVA: 0x0107A4A7 File Offset: 0x010786A7
		public LevelEventModifyActorMaterialParamBySplineProgress(int id) : base(id)
		{
		}

		// Token: 0x0603A4B6 RID: 238774 RVA: 0x0107A4B0 File Offset: 0x010786B0
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
