using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CE1 RID: 23777
	public class LevelEventSendAiEvent : LevelEventBase
	{
		// Token: 0x0603A361 RID: 238433 RVA: 0x0106FA11 File Offset: 0x0106DC11
		public LevelEventSendAiEvent(int id) : base(id)
		{
		}

		// Token: 0x0603A362 RID: 238434 RVA: 0x0106FA1C File Offset: 0x0106DC1C
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

		// Token: 0x0603A363 RID: 238435 RVA: 0x0106FACC File Offset: 0x0106DCCC
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

		// Token: 0x0603A364 RID: 238436 RVA: 0x0106FC04 File Offset: 0x0106DE04
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

		// Token: 0x0603A365 RID: 238437 RVA: 0x0106FCF8 File Offset: 0x0106DEF8
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

		// Token: 0x0603A366 RID: 238438 RVA: 0x0106FDB8 File Offset: 0x0106DFB8
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
