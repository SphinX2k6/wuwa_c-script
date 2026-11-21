using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay.Handlers
{
	// Token: 0x02005D39 RID: 23865
	public class DragActorHandlerBase
	{
		// Token: 0x0603A4B0 RID: 238768 RVA: 0x0107A250 File Offset: 0x01078450
		[NullableContext(1)]
		[return: Nullable(2)]
		protected Entity GetTargetEntity(int targetEntityId, GeneralContext context)
		{
			EntityContext entityContext = context as EntityContext;
			if (entityContext == null || entityContext.Type.GetValueOrDefault() != EGeneralContextType.Entity)
			{
				Log.Instance.Error(ELogModule.SceneGameplay, ELogAuthor.XDW, "DragActorHandlerBase.GetTargetEntity: context is not EntityContext", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			if (targetEntityId == -10000)
			{
				return EntitySystem.Instance.Get(entityContext.EntityId.Value);
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(targetEntityId);
			if (entityByPbDataId == null)
			{
				return null;
			}
			return entityByPbDataId.Entity;
		}

		// Token: 0x0401EC28 RID: 125992
		private const int SELF_ENTITY_PB_DATA_ID = -10000;
	}
}
