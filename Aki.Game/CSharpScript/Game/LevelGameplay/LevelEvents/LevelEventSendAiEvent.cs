using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B69 RID: 27497
	public class LevelEventSendAiEvent : LevelEventBase
	{
		// Token: 0x0604420F RID: 279055 RVA: 0x010C5E41 File Offset: 0x010C4041
		public LevelEventSendAiEvent(int id) : base(id)
		{
		}

		// Token: 0x06044210 RID: 279056 RVA: 0x010C5E4C File Offset: 0x010C404C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SendAiEvent sendAiEvent = inParams as SendAiEvent;
			if (sendAiEvent == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CJH, "参数不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EntityContext entityContext = context as EntityContext;
			if (entityContext == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CJH, "上下文不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			switch (sendAiEvent.EventType)
			{
			case EAiEventType.CatAndDogPlayFlow:
			case EAiEventType.AnimalRandomAction:
				this.OnPetRandomAction(entityContext.EntityId.Value);
				return;
			case EAiEventType.AnimalStandUp:
				this.OnPetStandUp(entityContext.EntityId.Value);
				return;
			case EAiEventType.AnimalSitDown:
				this.OnPetSitDown(entityContext.EntityId.Value);
				return;
			default:
				return;
			}
		}

		// Token: 0x06044211 RID: 279057 RVA: 0x010C5EFC File Offset: 0x010C40FC
		private void OnPetStandUp(int entityId)
		{
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (entityById == null || !entityById.Valid)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CJH, "对象Entity不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (entityById.Entity.GetComponent<CharacterAiComponent>() == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CJH, "Entity不合法，缺少CharacterAiComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			BaseTagComponent component = entityById.Entity.GetComponent<BaseTagComponent>();
			bool flag = component != null && component.HasTag(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.坐下"]);
			bool flag2 = component != null && component.HasTag(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.趴下"]);
			this.RemoveAiEventTag(component);
			if (flag)
			{
				if (component != null)
				{
					component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.站起"]));
				}
			}
			else if (flag2)
			{
				if (component != null)
				{
					component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.趴下起身"]));
				}
			}
			else if (component != null)
			{
				component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.站起"]));
			}
			if (component != null)
			{
				component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.通知标识.交互"]));
			}
		}

		// Token: 0x06044212 RID: 279058 RVA: 0x010C6034 File Offset: 0x010C4234
		private void OnPetSitDown(int entityId)
		{
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (entityById == null || !entityById.Valid)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CJH, "对象Entity不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (entityById.Entity.GetComponent<CharacterAiComponent>() == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CJH, "Entity不合法，缺少CharacterAiComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			BaseTagComponent component = entityById.Entity.GetComponent<BaseTagComponent>();
			this.RemoveAiEventTag(component);
			if (new Random().NextDouble() < 0.5)
			{
				if (component != null)
				{
					component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.坐下"]));
				}
			}
			else if (component != null)
			{
				component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.趴下"]));
			}
			if (component != null)
			{
				component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.通知标识.交互"]));
			}
		}

		// Token: 0x06044213 RID: 279059 RVA: 0x010C6128 File Offset: 0x010C4328
		private void OnPetRandomAction(int entityId)
		{
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (entityById == null || !entityById.Valid)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CJH, "对象Entity不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (entityById.Entity.GetComponent<CharacterAiComponent>() == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CJH, "Entity不合法，缺少CharacterAiComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			BaseTagComponent component = entityById.Entity.GetComponent<BaseTagComponent>();
			this.RemoveAiEventTag(component);
			if (component != null)
			{
				component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.随机表演"]));
			}
			if (component != null)
			{
				component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.通知标识.交互"]));
			}
		}

		// Token: 0x06044214 RID: 279060 RVA: 0x010C61E8 File Offset: 0x010C43E8
		[NullableContext(2)]
		private void RemoveAiEventTag(BaseTagComponent gameplayTagComponent)
		{
			if (gameplayTagComponent == null || !gameplayTagComponent.Valid)
			{
				return;
			}
			gameplayTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.随机表演"]));
			gameplayTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.坐下"]));
			gameplayTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.趴下"]));
			gameplayTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.站起"]));
			gameplayTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.趴下起身"]));
		}
	}
}
