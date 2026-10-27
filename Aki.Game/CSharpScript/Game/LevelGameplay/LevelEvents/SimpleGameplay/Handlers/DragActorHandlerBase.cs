using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay.Handlers
{
	// Token: 0x02006BC0 RID: 27584
	public class DragActorHandlerBase
	{
		// Token: 0x06044358 RID: 279384 RVA: 0x010D02FC File Offset: 0x010CE4FC
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

		// Token: 0x04023986 RID: 145798
		private const int SELF_ENTITY_PB_DATA_ID = -10000;
	}
}
