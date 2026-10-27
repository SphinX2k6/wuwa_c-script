using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B6B RID: 27499
	public class LevelEventSendGameplayEventToPlayer : LevelEventBase
	{
		// Token: 0x06044217 RID: 279063 RVA: 0x010C6378 File Offset: 0x010C4578
		public LevelEventSendGameplayEventToPlayer(int id) : base(id)
		{
		}

		// Token: 0x06044218 RID: 279064 RVA: 0x010C6384 File Offset: 0x010C4584
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
