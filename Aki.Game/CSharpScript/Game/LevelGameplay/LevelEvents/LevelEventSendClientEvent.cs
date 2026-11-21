using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CE2 RID: 23778
	public class LevelEventSendClientEvent : LevelEventBase
	{
		// Token: 0x0603A367 RID: 238439 RVA: 0x0106FE5E File Offset: 0x0106E05E
		public LevelEventSendClientEvent(int id) : base(id)
		{
		}

		// Token: 0x0603A368 RID: 238440 RVA: 0x0106FE68 File Offset: 0x0106E068
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SendClientEvent sendClientEvent = inParams as SendClientEvent;
			EClientEventTarget type = sendClientEvent.Target.Type;
			int entityId = 0;
			if (type != EClientEventTarget.Self)
			{
				if (type == EClientEventTarget.Ui)
				{
					IClientUiEvent clientUiEvent = sendClientEvent.Target as IClientUiEvent;
					EClientEventUiType type2 = clientUiEvent.Ui.Type;
					if (type2 != EClientEventUiType.PlayPiano)
					{
						if (type2 != EClientEventUiType.FlyingFlower)
						{
							return;
						}
						IClientEventUiFlyingFlower clientEventUiFlyingFlower = clientUiEvent.Ui as IClientEventUiFlyingFlower;
						if (clientEventUiFlyingFlower != null)
						{
							IClientEventFlyingFlowerUpdateSubtitle eventType = clientEventUiFlyingFlower.EventType;
							EventSystem.Instance.Emit<IClientEventFlyingFlowerUpdateSubtitle>(EEventName.OnFlyingFlowerUpdateSubtitle, eventType);
						}
					}
					else
					{
						IClientEventUiPlayPiano clientEventUiPlayPiano = clientUiEvent.Ui as IClientEventUiPlayPiano;
						if (clientEventUiPlayPiano != null)
						{
							IClientEventPianoUpdateSubtitle p = clientEventUiPlayPiano.EventType as IClientEventPianoUpdateSubtitle;
							EventSystem.Instance.Emit<IClientEventPianoUpdateSubtitle>(EEventName.OnPianoGameplayUpdateSubtitle, p);
							return;
						}
					}
					return;
				}
			}
			else
			{
				EGeneralContextType? type3 = context.Type;
				if (type3 != null)
				{
					EGeneralContextType valueOrDefault = type3.GetValueOrDefault();
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
