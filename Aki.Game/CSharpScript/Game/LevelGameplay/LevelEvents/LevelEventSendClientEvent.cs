using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B6A RID: 27498
	public class LevelEventSendClientEvent : LevelEventBase
	{
		// Token: 0x06044215 RID: 279061 RVA: 0x010C628E File Offset: 0x010C448E
		public LevelEventSendClientEvent(int id) : base(id)
		{
		}

		// Token: 0x06044216 RID: 279062 RVA: 0x010C6298 File Offset: 0x010C4498
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SendClientEvent sendClientEvent = inParams as SendClientEvent;
			bool type = sendClientEvent.Target.Type != EClientEventTarget.Self;
			int entityId = 0;
			if (!type)
			{
				EGeneralContextType? type2 = context.Type;
				if (type2 != null)
				{
					EGeneralContextType valueOrDefault = type2.GetValueOrDefault();
					if (valueOrDefault != EGeneralContextType.Entity)
					{
						if (valueOrDefault == EGeneralContextType.Trigger)
						{
							TriggerContext triggerContext = context as TriggerContext;
							if (triggerContext == null || triggerContext.TriggerEntityId == null)
							{
								return;
							}
							entityId = triggerContext.TriggerEntityId.Value;
						}
					}
					else
					{
						EntityContext entityContext = context as EntityContext;
						if (entityContext == null || entityContext.EntityId == null)
						{
							return;
						}
						entityId = entityContext.EntityId.Value;
					}
				}
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (entityById != null && entityById.Valid && entityById.Entity != null)
			{
				EventSystem.Instance.EmitWithTarget<FGameplayTag>(entityById.Entity, EEventName.CheckClientEvent, GameplayTagUtils.GetGameplayTagByName(sendClientEvent.EventName).Value);
			}
		}
	}
}
