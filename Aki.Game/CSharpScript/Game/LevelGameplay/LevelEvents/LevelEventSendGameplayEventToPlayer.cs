using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CE3 RID: 23779
	public class LevelEventSendGameplayEventToPlayer : LevelEventBase
	{
		// Token: 0x0603A369 RID: 238441 RVA: 0x0106FFEE File Offset: 0x0106E1EE
		public LevelEventSendGameplayEventToPlayer(int id) : base(id)
		{
		}

		// Token: 0x0603A36A RID: 238442 RVA: 0x0106FFF8 File Offset: 0x0106E1F8
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ActionSendGameplayEvent actionSendGameplayEvent = inParams as ActionSendGameplayEvent;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return;
			}
			CharacterAbilityComponent component = baseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterAbilityComponent>();
			if (component != null && actionSendGameplayEvent.Tag != null)
			{
				component.SendGameplayEventToActor(actionSendGameplayEvent.Tag.Value, null);
			}
			if (!actionSendGameplayEvent.Both)
			{
				return;
			}
			if (context.Type.GetValueOrDefault() != EGeneralContextType.Entity)
			{
				return;
			}
			EntityContext entityContext = context as EntityContext;
			Entity entity = EntitySystem.Instance.Get(entityContext.EntityId.Value);
			if (entity == null || !entity.Valid)
			{
				return;
			}
			CharacterAbilityComponent component2 = entity.GetComponent<CharacterAbilityComponent>();
			if (component2 == null || !component2.Valid)
			{
				return;
			}
			component2.SendGameplayEventToActor(actionSendGameplayEvent.Tag.Value, null);
		}
	}
}
