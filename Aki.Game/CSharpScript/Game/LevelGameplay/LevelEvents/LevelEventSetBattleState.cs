using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Common.Component;
using Google.Protobuf;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B71 RID: 27505
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventSetBattleState : LevelEventBase
	{
		// Token: 0x0604422F RID: 279087 RVA: 0x010C8010 File Offset: 0x010C6210
		public LevelEventSetBattleState(int id) : base(id)
		{
		}

		// Token: 0x06044230 RID: 279088 RVA: 0x010C8024 File Offset: 0x010C6224
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06044231 RID: 279089 RVA: 0x010C8030 File Offset: 0x010C6230
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SetBattleState setBattleState = inParams as SetBattleState;
			if (setBattleState == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.ZS, "LevelEventSetBattleState 参数不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			this.StateOption = setBattleState.StateOption;
			ISendBattleStateType stateOption = this.StateOption;
			ISetBattleTag setBattleTag = stateOption as ISetBattleTag;
			if (setBattleTag == null)
			{
				INotifyMonsterPerception notifyMonsterPerception = stateOption as INotifyMonsterPerception;
				if (notifyMonsterPerception != null)
				{
					this.NotifyMonsterPerception(notifyMonsterPerception);
					return;
				}
				INotifyMonsterPlayStandbyTags notifyMonsterPlayStandbyTags = stateOption as INotifyMonsterPlayStandbyTags;
				if (notifyMonsterPlayStandbyTags == null)
				{
					return;
				}
				this.NotifyMonsterStandByTags(notifyMonsterPlayStandbyTags, context);
				return;
			}
			else
			{
				if (setBattleTag.SetTags == null || setBattleTag.SetTags.Count == 0)
				{
					global::Log.Instance.Error(ELogModule.Event, ELogAuthor.ZS, "LevelEventSetBattleState 未配置具体操作对象", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.FinishExecute(false, false, true);
					return;
				}
				List<int> list = new List<int>();
				foreach (ISetEntityTag setEntityTag in setBattleTag.SetTags)
				{
					list.Add(setEntityTag.EntityId);
					EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(setEntityTag.EntityId);
					if (setEntityTag.BeforeHide.GetValueOrDefault() && entityByPbDataId != null)
					{
						WorldEntity entity = entityByPbDataId.Entity;
						if (entity != null)
						{
							BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
							if (component != null)
							{
								component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["怪物.common.关卡.无音区专用.怪物首次出场"]));
							}
						}
					}
				}
				base.CreateWaitEntityTask(list);
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.ZS;
				string message = "LevelEventSetBattleState CreateWaitEntityTask";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityIds", list);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
		}

		// Token: 0x06044232 RID: 279090 RVA: 0x010C81DC File Offset: 0x010C63DC
		protected override void ExecuteWhenEntitiesReady()
		{
			ESetBattleStateType type = this.StateOption.Type;
			if (type == ESetBattleStateType.SetBattleTag)
			{
				this.SetBattleTag();
				return;
			}
			if (type != ESetBattleStateType.NotifyMonsterPerception)
			{
				return;
			}
			this.NotifyGatherToEntity(this.NotifyData);
		}

		// Token: 0x06044233 RID: 279091 RVA: 0x010C8210 File Offset: 0x010C6410
		private void SetBattleTag()
		{
			ISetBattleTag setBattleTag = this.StateOption as ISetBattleTag;
			this.TotalTaskNum = setBattleTag.SetTags.Count;
			using (List<ISetEntityTag>.Enumerator enumerator = setBattleTag.SetTags.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ISetEntityTag entityTag = enumerator.Current;
					EntityHandle handle = CreatureModel.Instance.GetEntityByPbDataId(entityTag.EntityId);
					EntityHandle handle2 = handle;
					if (handle2 == null || !handle2.IsInit)
					{
						this.FinishTaskNum++;
					}
					else
					{
						string tagName = entityTag.GameplayTag;
						float? delayTime = entityTag.DelayTime;
						ESetEntityTagType setType = entityTag.SetType;
						if (setType != ESetEntityTagType.Add)
						{
							if (setType == ESetEntityTagType.Remove)
							{
								if (delayTime != null)
								{
									float? num = delayTime;
									float num2 = 0f;
									if (num.GetValueOrDefault() > num2 & num != null)
									{
										this.DelayTaskIds.Add(TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
										{
											this.RemoveTag(entityTag.EntityId, handle, tagName);
										}, delayTime.Value * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f));
										continue;
									}
								}
								this.RemoveTag(entityTag.EntityId, handle, tagName);
							}
						}
						else
						{
							if (delayTime != null)
							{
								float? num = delayTime;
								float num2 = 0f;
								if (num.GetValueOrDefault() > num2 & num != null)
								{
									this.DelayTaskIds.Add(TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
									{
										this.AddTag(entityTag.EntityId, handle, tagName);
									}, delayTime.Value * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f));
									continue;
								}
							}
							this.AddTag(entityTag.EntityId, handle, tagName);
						}
					}
				}
			}
			if (this.FinishTaskNum >= this.TotalTaskNum)
			{
				base.FinishExecute(true, false, true);
			}
		}

		// Token: 0x06044234 RID: 279092 RVA: 0x010C8444 File Offset: 0x010C6644
		private unsafe void AddTag(int pbDataId, EntityHandle handle, string tagName)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Event;
			ELogAuthor author = ELogAuthor.ZS;
			string message = "LevelEventSetBattleState AddTag";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", pbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TagName", tagName);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			BaseTagComponent component = handle.Entity.GetComponent<BaseTagComponent>();
			if (component != null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Event;
				ELogAuthor author2 = ELogAuthor.ZS;
				string message2 = "LevelEventSetBattleState AddTagByName";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", pbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("TagName", tagName);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				component.AddTag(new int?(GameplayTagUtils.GetTagIdByName(tagName)));
				this.FinishTaskNum++;
				if (this.FinishTaskNum >= this.TotalTaskNum)
				{
					base.FinishExecute(true, false, true);
					return;
				}
			}
			else
			{
				base.FinishExecute(false, false, true);
			}
		}

		// Token: 0x06044235 RID: 279093 RVA: 0x010C8554 File Offset: 0x010C6754
		private unsafe void RemoveTag(int pbDataId, EntityHandle handle, string tagName)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Event;
			ELogAuthor author = ELogAuthor.ZS;
			string message = "LevelEventSetBattleState RemoveTag";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", pbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TagName", tagName);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			BaseTagComponent component = handle.Entity.GetComponent<BaseTagComponent>();
			if (component != null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Event;
				ELogAuthor author2 = ELogAuthor.ZS;
				string message2 = "LevelEventSetBattleState RemoveTagByName";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", pbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("TagName", tagName);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				component.RemoveTag(new int?(GameplayTagUtils.GetTagIdByName(tagName)));
				this.FinishTaskNum++;
				if (this.FinishTaskNum >= this.TotalTaskNum)
				{
					base.FinishExecute(true, false, true);
					return;
				}
			}
			else
			{
				base.FinishExecute(false, false, true);
			}
		}

		// Token: 0x06044236 RID: 279094 RVA: 0x010C8664 File Offset: 0x010C6864
		private void NotifyMonsterPerception(INotifyMonsterPerception stateOption)
		{
			List<AiController> list = new List<AiController>();
			List<int> list2 = new List<int>();
			foreach (int num in stateOption.EntityIds)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num);
				if (entityByPbDataId == null || !entityByPbDataId.Valid)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Event;
					ELogAuthor author = ELogAuthor.CH;
					string message = "被通知Entity不合法";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ID", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					base.FinishExecute(false, false, true);
					return;
				}
				CharacterAiComponent component = entityByPbDataId.Entity.GetComponent<CharacterAiComponent>();
				if (component == null || !component.Valid)
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.Event;
					ELogAuthor author2 = ELogAuthor.CH;
					string message2 = "被通知Entity没有AIComponent";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ID", num);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					base.FinishExecute(false, false, true);
					return;
				}
				list.Add(component.AiController);
				list2.Add(num);
			}
			this.NotifyData = new NotifyData();
			this.NotifyData.Entities = list;
			IBattleStatePerceptionBehaviorType perceptionBehaviorOption = stateOption.PerceptionBehaviorOption;
			IPerceptionNotifyGatherToEntity perceptionNotifyGatherToEntity = perceptionBehaviorOption as IPerceptionNotifyGatherToEntity;
			if (perceptionNotifyGatherToEntity == null)
			{
				if (!(perceptionBehaviorOption is IPerceptionNotifyGatherToPlayer))
				{
					return;
				}
				this.NotifyData.Target = Global.BaseCharacter.CharacterActorComponent;
				base.CreateWaitEntityTask(list2);
			}
			else
			{
				EntityHandle entityByPbDataId2 = CreatureModel.Instance.GetEntityByPbDataId(perceptionNotifyGatherToEntity.EntityId);
				if (entityByPbDataId2 == null || !entityByPbDataId2.Valid)
				{
					global::Log instance3 = global::Log.Instance;
					ELogModule module3 = ELogModule.Event;
					ELogAuthor author3 = ELogAuthor.ZS;
					string message3 = "中心实体不合法";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("ID", perceptionNotifyGatherToEntity.EntityId);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					base.FinishExecute(false, false, true);
					return;
				}
				BaseActorComponent component2 = entityByPbDataId2.Entity.GetComponent<BaseActorComponent>();
				if (component2 == null || !component2.Valid)
				{
					global::Log instance4 = global::Log.Instance;
					ELogModule module4 = ELogModule.Event;
					ELogAuthor author4 = ELogAuthor.ZS;
					string message4 = "未能获取到该实体对应的有效Actor";
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("entityId", perceptionNotifyGatherToEntity.EntityId);
					instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					base.FinishExecute(false, false, true);
					return;
				}
				this.NotifyData.Target = component2;
				list2.Add(perceptionNotifyGatherToEntity.EntityId);
				base.CreateWaitEntityTask(list2);
				return;
			}
		}

		// Token: 0x06044237 RID: 279095 RVA: 0x010C88C8 File Offset: 0x010C6AC8
		private void NotifyGatherToEntity(NotifyData data)
		{
			using (List<AiController>.Enumerator enumerator = data.Entities.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.CharActorComp.Entity.IsInit)
					{
						return;
					}
				}
			}
			int? intConfig = ConfigCommonParamById.GetIntConfig("qianxing_notify_interval");
			CharacterActorComponent actorComp = Global.BaseCharacter.CharacterActorComponent;
			CharacterActorComponent actorComp2 = actorComp;
			if (actorComp2 == null || !actorComp2.Valid)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CH, "[NotifyGatherToEntity] 获取不到BaseCharacter的CharacterActorComponent，无法通知怪物靠近", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				data.Entities.Sort(delegate(AiController a, AiController b)
				{
					double num = global::Vector.DistSquared(actorComp.ActorLocationProxy, a.CharActorComp.ActorLocationProxy);
					double num2 = global::Vector.DistSquared(actorComp.ActorLocationProxy, b.CharActorComp.ActorLocationProxy);
					return (int)(num - num2);
				});
			}
			int currentIndex = 0;
			if (data.Entities.Count == 1)
			{
				this.TimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					List<AiController> entities = data.Entities;
					int currentIndex = currentIndex;
					currentIndex++;
					entities[currentIndex].AiPerceptionEvents.ForceTriggerSceneItemDestroyEvent(data.Target.Owner);
				}, (float)intConfig.Value, null, null, true, 1f);
				return;
			}
			this.TimerId = TimerSystem.GameplayTimeInstance.Loop(delegate(float _)
			{
				List<AiController> entities = data.Entities;
				int currentIndex = currentIndex;
				currentIndex++;
				entities[currentIndex].AiPerceptionEvents.ForceTriggerSceneItemDestroyEvent(data.Target.Owner);
			}, (float)intConfig.Value, data.Entities.Count, 1f, null, null, true);
		}

		// Token: 0x06044238 RID: 279096 RVA: 0x010C8A2C File Offset: 0x010C6C2C
		private unsafe void NotifyMonsterStandByTags(INotifyMonsterPlayStandbyTags config, GeneralContext context)
		{
			EntityContext entityContext = context as EntityContext;
			if (entityContext == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			Entity entity = EntitySystem.Instance.Get(entityContext.EntityId.Value);
			if (entity == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			CharacterAiComponent component = entity.GetComponent<CharacterAiComponent>();
			bool flag;
			if (component == null)
			{
				flag = (null != null);
			}
			else
			{
				AiController aiController = component.AiController;
				flag = (((aiController != null) ? aiController.AiPatrol : null) != null);
			}
			if (!flag)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			BaseActorComponent actorComp = entity.GetComponent<BaseActorComponent>();
			CharacterPatrolComponent component2 = entity.GetComponent<CharacterPatrolComponent>();
			if (component2 == null || component2.GetLastPointRawIndex() == -1)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YJX, "[NotifyMonsterStandByTags] 获取不到巡逻组件，无法通知怪物切换表演状态", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(true, false, true);
				return;
			}
			if (config.StandbyConfigs == null || config.StandbyConfigs.Count == 0)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YJX, "[NotifyMonsterStandByTags] 无对应待机表演配置，无法通知怪物切换表演状态", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(true, false, true);
				return;
			}
			if (config.StandbyConfigs != null)
			{
				foreach (IMonsterStandByConfig monsterStandByConfig in config.StandbyConfigs)
				{
					if (monsterStandByConfig.EmotionId != null)
					{
						int? emotionId = monsterStandByConfig.EmotionId;
						int num = 0;
						if (!(emotionId.GetValueOrDefault() == num & emotionId != null))
						{
							CharacterEmotionBubbleComponent component3 = entity.GetComponent<CharacterEmotionBubbleComponent>();
							if (component3 != null)
							{
								component3.PlayEmotionBubbleById(monsterStandByConfig.EmotionId.Value, true);
							}
						}
					}
				}
			}
			EntityPatrolAddTagRequest request = EntityPatrolAddTagRequest.Create();
			request.EntityId = actorComp.CreatureData.GetCreatureDataId();
			request.SplineEntityConfigId = component2.GetCurrentPatrolSplineId();
			request.Index = component2.GetLastPointRawIndex();
			request.TagId = 0;
			Net.Instance.Call(ERequestMessageId.EntityPatrolAddTagRequest, request, delegate(IMessage msg, Net.CallbackStatus _)
			{
				EntityPatrolAddTagResponse entityPatrolAddTagResponse = (EntityPatrolAddTagResponse)msg;
				if (entityPatrolAddTagResponse == null)
				{
					return;
				}
				if (entityPatrolAddTagResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.AI;
					ELogAuthor author = ELogAuthor.YJX;
					string message = "请求状态机切换生态表演失败";
					<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureId", request.EntityId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", actorComp.CreatureData.GetPbDataId());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SplineId", request.SplineEntityConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Index", request.Index);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Tag", request.TagId);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				}
			}, 0);
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06044239 RID: 279097 RVA: 0x010C8C44 File Offset: 0x010C6E44
		protected override void OnReset()
		{
			foreach (TimerHandle handle in this.DelayTaskIds)
			{
				if (TimerSystem.GameplayTimeInstance.Has(handle))
				{
					TimerSystem.GameplayTimeInstance.Remove(handle);
				}
			}
			if (this.TimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			}
			this.DelayTaskIds.Clear();
			this.TotalTaskNum = 0;
			this.FinishTaskNum = 0;
		}

		// Token: 0x0402394C RID: 145740
		private readonly List<TimerHandle> DelayTaskIds = new List<TimerHandle>();

		// Token: 0x0402394D RID: 145741
		private int TotalTaskNum;

		// Token: 0x0402394E RID: 145742
		private int FinishTaskNum;

		// Token: 0x0402394F RID: 145743
		[Nullable(2)]
		private ISendBattleStateType StateOption;

		// Token: 0x04023950 RID: 145744
		[Nullable(2)]
		private NotifyData NotifyData;

		// Token: 0x04023951 RID: 145745
		[Nullable(2)]
		private TimerHandle TimerId;
	}
}
