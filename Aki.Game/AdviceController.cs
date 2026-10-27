using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.CreatureTools;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.NewWorld.SceneItem.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020016BC RID: 5820
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AdviceController : ControllerBase
{
	// Token: 0x0600A61F RID: 42527 RVA: 0x0025235D File Offset: 0x0025055D
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600A620 RID: 42528 RVA: 0x0025236C File Offset: 0x0025056C
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x0600A621 RID: 42529 RVA: 0x0025237C File Offset: 0x0025057C
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnGetFriendInitData, new Action(this.RequestAdviceData));
		EventSystem.Instance.Add(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Add(EEventName.OriginWorldLevelUp, new Action(this.OnWorldLevelUp));
		EventSystem.Instance.Add(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x0600A622 RID: 42530 RVA: 0x00252418 File Offset: 0x00250618
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnGetFriendInitData, new Action(this.RequestAdviceData));
		EventSystem.Instance.Remove(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Remove(EEventName.OriginWorldLevelUp, new Action(this.OnWorldLevelUp));
		EventSystem.Instance.Remove(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x0600A623 RID: 42531 RVA: 0x002524B4 File Offset: 0x002506B4
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.AdviceContentUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAdviceContentUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.AdviceVoteUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAdviceVoteUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.AdviceUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAdviceUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.AdviceSettingNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAdviceSettingNotify));
	}

	// Token: 0x0600A624 RID: 42532 RVA: 0x00252534 File Offset: 0x00250734
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.AdviceContentUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AdviceVoteUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AdviceSettingNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AdviceUpdateNotify);
	}

	// Token: 0x0600A625 RID: 42533 RVA: 0x00252581 File Offset: 0x00250781
	private void OnWorldLevelUp()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.AdviceInfoView))
		{
			UiManager.Instance.CloseView(EUiViewName.AdviceInfoView, null);
		}
	}

	// Token: 0x0600A626 RID: 42534 RVA: 0x002525A4 File Offset: 0x002507A4
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.AdviceInfoView))
		{
			UiManager.Instance.CloseView(EUiViewName.AdviceInfoView, null);
		}
	}

	// Token: 0x0600A627 RID: 42535 RVA: 0x002525C8 File Offset: 0x002507C8
	private void OnItemUse(int configId, int useCount)
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(configId);
		int num;
		if (itemConfig != null && itemConfig.Value.Parameters() != null && itemConfig.Value.Parameters().Count > 0 && itemConfig.Value.Parameters().TryGetValue(20, out num) && num != 0)
		{
			this.OpenAdviceCreateView();
		}
	}

	// Token: 0x0600A628 RID: 42536 RVA: 0x00252635 File Offset: 0x00250835
	private void OnCrossDay()
	{
		AdviceModel.Instance.ResetVoteIds();
	}

	// Token: 0x0600A629 RID: 42537 RVA: 0x00252641 File Offset: 0x00250841
	public void OpenAdviceConjunctionSelectView()
	{
		AdviceModel instance = AdviceModel.Instance;
		instance.CurrentChangeWordType = EChangeWordType.Conjunction;
		instance.CurrentSelectWordId = instance.CurrentConjunctionId;
		UiManager.Instance.OpenView(EUiViewName.AdviceWordView, null, null);
	}

	// Token: 0x0600A62A RID: 42538 RVA: 0x0025266C File Offset: 0x0025086C
	public void OpenAdviceWordSelectView(int wordIndex)
	{
		AdviceModel instance = AdviceModel.Instance;
		int num;
		if (instance.CurrentWordMap.TryGetValue(wordIndex, out num) && num > 0)
		{
			instance.CurrentSelectSortTypeId = AdviceConfig.Instance.GetAdviceWordType(num).GetValueOrDefault();
			instance.CurrentSelectSortWordId = num;
		}
		else
		{
			IReadOnlyList<AdviceWordType> adviceWordTypeConfigs = AdviceConfig.Instance.GetAdviceWordTypeConfigs();
			int currentSelectSortTypeId = (adviceWordTypeConfigs != null && adviceWordTypeConfigs.Count > 0) ? adviceWordTypeConfigs[0].Id : 0;
			instance.CurrentSelectSortTypeId = currentSelectSortTypeId;
			instance.CurrentSelectSortWordId = -1;
		}
		instance.CurrentSelectWordIndex = wordIndex;
		UiManager.Instance.OpenView(EUiViewName.AdviceSortWordView, null, null);
	}

	// Token: 0x0600A62B RID: 42539 RVA: 0x00252708 File Offset: 0x00250908
	public void OpenAdviceSentenceSelectView()
	{
		AdviceModel instance = AdviceModel.Instance;
		if (instance.CurrentLineModel == ELineMode.SingleLine)
		{
			instance.CurrentChangeWordType = EChangeWordType.Sentence;
			int currentSelectWordId;
			instance.CurrentSentenceWordMap.TryGetValue(0, out currentSelectWordId);
			instance.CurrentSelectWordId = currentSelectWordId;
			instance.CurrentPreSelectSentenceIndex = 0;
			UiManager.Instance.OpenView(EUiViewName.AdviceWordView, null, null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.AdviceMutiSentenceSelectView, null, null);
	}

	// Token: 0x0600A62C RID: 42540 RVA: 0x0025276A File Offset: 0x0025096A
	public void OpenAdviceExpressionView()
	{
		UiManager.Instance.OpenView(EUiViewName.AdviceExpressionView, null, null);
	}

	// Token: 0x0600A62D RID: 42541 RVA: 0x00252780 File Offset: 0x00250980
	public void OpenAdviceCreateView()
	{
		if (AdviceModel.Instance.GetCreateAdvicePreConditionState())
		{
			AdviceModel.Instance.ResetWordData();
			UiManager.Instance.OpenView(EUiViewName.AdviceCreateView, null, null);
			return;
		}
		string createPreConditionFailText = AdviceModel.Instance.GetCreatePreConditionFailText();
		GenericPromptController.Instance.ShowPromptByCode(createPreConditionFailText, Array.Empty<object>());
	}

	// Token: 0x0600A62E RID: 42542 RVA: 0x002527D0 File Offset: 0x002509D0
	public void OpenAdviceView()
	{
		AdviceModel.Instance.AdviceViewShowId = null;
		UiManager.Instance.OpenView(EUiViewName.AdviceView, null, null);
	}

	// Token: 0x0600A62F RID: 42543 RVA: 0x002527F4 File Offset: 0x002509F4
	[NullableContext(0)]
	public UniTask<bool> OpenAdviceInfoView(int entityId)
	{
		AdviceController.<OpenAdviceInfoView>d__18 <OpenAdviceInfoView>d__;
		<OpenAdviceInfoView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenAdviceInfoView>d__.<>4__this = this;
		<OpenAdviceInfoView>d__.entityId = entityId;
		<OpenAdviceInfoView>d__.<>1__state = -1;
		<OpenAdviceInfoView>d__.<>t__builder.Start<AdviceController.<OpenAdviceInfoView>d__18>(ref <OpenAdviceInfoView>d__);
		return <OpenAdviceInfoView>d__.<>t__builder.Task;
	}

	// Token: 0x0600A630 RID: 42544 RVA: 0x00252840 File Offset: 0x00250A40
	private bool CheckEntityIfInBattle()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity != null && getCurrentEntity.Valid)
		{
			WorldEntity entity = getCurrentEntity.Entity;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null && baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
			{
				GenericPromptController.Instance.ShowPromptByCode("BattleCannotOpenAdvice", Array.Empty<object>());
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600A631 RID: 42545 RVA: 0x002528A8 File Offset: 0x00250AA8
	private void PlayMotionAnimation(int entityId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null)
		{
			return;
		}
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		bool flag;
		if (component == null)
		{
			flag = (null != null);
		}
		else
		{
			AdviceEntityData adviceInfo = component.GetAdviceInfo();
			flag = (((adviceInfo != null) ? adviceInfo.GetAdviceData() : null) != null);
		}
		if (flag && component.GetAdviceInfo().GetAdviceData().GetAdviceMotionId() > 0L)
		{
			AdviceModel.Instance.GetAdviceMotionActor(entityId).PlayMotion(entityId);
		}
		SceneItemAdviceComponent component2 = entity.GetComponent<SceneItemAdviceComponent>();
		if (component2 == null)
		{
			return;
		}
		component2.DoInteract();
	}

	// Token: 0x0600A632 RID: 42546 RVA: 0x0025291C File Offset: 0x00250B1C
	private void RequestAdviceData()
	{
		AdviceRequest message = AdviceRequest.Create();
		Net.Instance.Call(ERequestMessageId.AdviceRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AdviceResponse adviceResponse = (AdviceResponse)msg;
			if (adviceResponse == null || adviceResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(adviceResponse.ErrorCode, 17200, null, true, true);
				return;
			}
			if (adviceResponse != null)
			{
				AdviceModel.Instance.PhraseAdviceData(adviceResponse);
			}
		}, 0);
	}

	// Token: 0x0600A633 RID: 42547 RVA: 0x00252960 File Offset: 0x00250B60
	public void RequestCreateAdvice(global::Vector position, global::Rotator rotator, AdviceContentData[] adviceContent, Action callback)
	{
		AdviceCreateRequest adviceCreateRequest = AdviceCreateRequest.Create();
		adviceCreateRequest.Pos = new Aki.Protocol.Vector
		{
			X = (float)position.X,
			Y = (float)position.Y,
			Z = (float)position.Z
		};
		adviceCreateRequest.Rot = new Aki.Protocol.Rotator
		{
			Pitch = rotator.Pitch,
			Yaw = rotator.Yaw,
			Roll = rotator.Roll
		};
		adviceCreateRequest.Contents.Add(new List<PbAdviceContent>());
		foreach (AdviceContentData adviceContentData in adviceContent)
		{
			adviceCreateRequest.Contents.Add(adviceContentData.ConvertToPb());
		}
		Net.Instance.Call(ERequestMessageId.AdviceCreateRequest, adviceCreateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AdviceCreateResponse adviceCreateResponse = (AdviceCreateResponse)msg;
			if (adviceCreateResponse == null || adviceCreateResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(adviceCreateResponse.ErrorCode, 19595, null, true, true);
				return;
			}
			Action callback2 = callback;
			if (callback2 != null)
			{
				callback2();
			}
			GenericPromptController.Instance.ShowPromptByCode("HasPublishAdvice", Array.Empty<object>());
			if (adviceCreateResponse != null)
			{
				AdviceModel.Instance.PhraseAdviceCreateData(adviceCreateResponse);
			}
		}, 0);
	}

	// Token: 0x0600A634 RID: 42548 RVA: 0x00252A38 File Offset: 0x00250C38
	public void RequestModifyAdvice(long id, AdviceContentData[] adviceContent)
	{
		AdviceModifyRequest adviceModifyRequest = AdviceModifyRequest.Create();
		adviceModifyRequest.Id = id;
		adviceModifyRequest.Contents.Add(new List<PbAdviceContent>());
		foreach (AdviceContentData adviceContentData in adviceContent)
		{
			adviceModifyRequest.Contents.Add(adviceContentData.ConvertToPb());
		}
		Net.Instance.Call(ERequestMessageId.AdviceModifyRequest, adviceModifyRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AdviceModifyResponse adviceModifyResponse = (AdviceModifyResponse)msg;
			if (adviceModifyResponse == null || adviceModifyResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(adviceModifyResponse.ErrorCode, 25965, null, true, true);
				return;
			}
			AdviceModel.Instance.OnModifyAdvice(id, adviceContent);
		}, 0);
	}

	// Token: 0x0600A635 RID: 42549 RVA: 0x00252AC4 File Offset: 0x00250CC4
	public void RequestDeleteAdvice(long id)
	{
		AdviceDeleteRequest adviceDeleteRequest = AdviceDeleteRequest.Create();
		adviceDeleteRequest.Id = id;
		Net.Instance.Call(ERequestMessageId.AdviceDeleteRequest, adviceDeleteRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AdviceDeleteResponse adviceDeleteResponse = (AdviceDeleteResponse)msg;
			if (adviceDeleteResponse == null || adviceDeleteResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(adviceDeleteResponse.ErrorCode, 28461, null, true, true);
				return;
			}
			AdviceModel.Instance.OnDeleteAdvice(id);
		}, 0);
	}

	// Token: 0x0600A636 RID: 42550 RVA: 0x00252B10 File Offset: 0x00250D10
	public void RequestVote(long entityId, long adviceId, PbAdviceVoteType type)
	{
		AdviceVoteRequest adviceVoteRequest = AdviceVoteRequest.Create();
		adviceVoteRequest.Id = entityId;
		adviceVoteRequest.Type = type;
		Net.Instance.Call(ERequestMessageId.AdviceVoteRequest, adviceVoteRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AdviceVoteResponse adviceVoteResponse = (AdviceVoteResponse)msg;
			if (adviceVoteResponse == null || adviceVoteResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(adviceVoteResponse.ErrorCode, 25631, null, true, true);
				EventSystem.Instance.Emit(EEventName.OnAdviceVoteNotify);
				return;
			}
			AdviceModel.Instance.OnRequestVote(adviceId, type);
		}, 0);
	}

	// Token: 0x0600A637 RID: 42551 RVA: 0x00252B68 File Offset: 0x00250D68
	[NullableContext(2)]
	private void OnAdviceContentUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		AdviceContentUpdateNotify adviceContentUpdateNotify = (AdviceContentUpdateNotify)msg;
		int id = (int)MathUtils.Instance.LongToBigInt(adviceContentUpdateNotify.Id);
		Entity entity = EntitySystem.Instance.Get(id);
		if (entity != null)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component == null)
			{
				return;
			}
			AdviceEntityData adviceInfo = component.GetAdviceInfo();
			if (adviceInfo == null)
			{
				return;
			}
			adviceInfo.PhraseContent(adviceContentUpdateNotify.Contents.ToList<PbAdviceContent>());
		}
	}

	// Token: 0x0600A638 RID: 42552 RVA: 0x00252BC4 File Offset: 0x00250DC4
	[NullableContext(2)]
	private void OnAdviceVoteUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		AdviceVoteUpdateNotify adviceVoteUpdateNotify = (AdviceVoteUpdateNotify)msg;
		long creatureDataId = MathUtils.Instance.LongToNumber(adviceVoteUpdateNotify.Id);
		EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
		if (entity != null && entity.Valid && entity.Entity != null)
		{
			CreatureDataComponent component = entity.Entity.GetComponent<CreatureDataComponent>();
			if (((component != null) ? component.GetAdviceInfo() : null) != null)
			{
				component.GetAdviceInfo().PhraseVote((long)adviceVoteUpdateNotify.UpVote);
				AdviceData adviceData = component.GetAdviceInfo().GetAdviceData();
				if (adviceData != null && adviceData.GetAdviceBigId() != null)
				{
					AdviceModel.Instance.OnAdviceVoteUpdate(adviceData.GetAdviceBigId().Value, adviceVoteUpdateNotify);
				}
			}
		}
	}

	// Token: 0x0600A639 RID: 42553 RVA: 0x00252C74 File Offset: 0x00250E74
	[NullableContext(2)]
	private void OnAdviceUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		AdviceUpdateNotify response = (AdviceUpdateNotify)msg;
		AdviceModel.Instance.OnAdviceUpdateNotify(response);
	}

	// Token: 0x0600A63A RID: 42554 RVA: 0x00252C94 File Offset: 0x00250E94
	[NullableContext(2)]
	private void OnAdviceSettingNotify(IMessage msg, Net.CallbackStatus status)
	{
		AdviceSettingNotify adviceSettingNotify = (AdviceSettingNotify)msg;
		AdviceModel.Instance.SetAdviceShowSetting(adviceSettingNotify.IsShow);
	}

	// Token: 0x0600A63B RID: 42555 RVA: 0x00252CB8 File Offset: 0x00250EB8
	public void RequestSetAdviceShowState(bool state)
	{
		AdviceSetRequest message = AdviceSetRequest.Create();
		message.IsShow = state;
		Net.Instance.Call(ERequestMessageId.AdviceSetRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AdviceSetResponse adviceSetResponse = (AdviceSetResponse)msg;
			if (adviceSetResponse == null || adviceSetResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(adviceSetResponse.ErrorCode, 27439, null, true, true);
				return;
			}
			AdviceModel.Instance.SetAdviceShowSetting(message.IsShow);
		}, 0);
	}

	// Token: 0x0600A63C RID: 42556 RVA: 0x00252D04 File Offset: 0x00250F04
	public bool CheckInInValidArea()
	{
		IReadOnlyList<int> adviceCannotPutArea = AdviceConfig.Instance.GetAdviceCannotPutArea();
		Area? area;
		int num = (AreaModel.Instance.AreaInfo != null) ? area.GetValueOrDefault().AreaId : 0;
		if (adviceCannotPutArea != null)
		{
			using (IEnumerator<int> enumerator = adviceCannotPutArea.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == num)
					{
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x0600A63D RID: 42557 RVA: 0x00252D8C File Offset: 0x00250F8C
	public bool CheckBehindAdviceActor()
	{
		IReadOnlyList<EntityHandle> allEntities = CreatureModel.Instance.GetAllEntities();
		int playerId = FunctionModel.Instance.PlayerId;
		int adviceCannotPutDistance = AdviceConfig.Instance.GetAdviceCannotPutDistance();
		if (allEntities == null)
		{
			return false;
		}
		foreach (EntityHandle entityHandle in allEntities)
		{
			if (((entityHandle != null) ? entityHandle.Entity : null) != null)
			{
				CreatureDataComponent component = entityHandle.Entity.GetComponent<CreatureDataComponent>();
				bool flag;
				if (component == null)
				{
					flag = false;
				}
				else
				{
					AdviceEntityData adviceInfo = component.GetAdviceInfo();
					long? num = (adviceInfo != null) ? new long?(adviceInfo.GetPlayerId()) : null;
					long num2 = (long)playerId;
					flag = (num.GetValueOrDefault() == num2 & num != null);
				}
				if (flag)
				{
					TsBaseCharacter baseCharacter = Global.BaseCharacter;
					BaseActorComponent component2 = entityHandle.Entity.GetComponent<BaseActorComponent>();
					AActor aactor = (component2 != null) ? component2.Owner : null;
					if (baseCharacter != null && aactor != null)
					{
						FVectorDouble v = aactor.D_K2_GetActorLocation();
						FVectorDouble v2 = baseCharacter.D_K2_GetActorLocation();
						if (UKismetMathLibrary.D_Vector_Distance(v, v2) <= (double)adviceCannotPutDistance)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600A63E RID: 42558 RVA: 0x00252EA8 File Offset: 0x002510A8
	public bool CheckIfStandAndInValidActor()
	{
		global::Vector vector = global::Vector.Create();
		global::Vector vector2 = global::Vector.Create();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
		if (characterActorComponent == null)
		{
			return false;
		}
		global::Vector actorLocationProxy = characterActorComponent.ActorLocationProxy;
		vector.DeepCopy(actorLocationProxy);
		vector.Z += (double)characterActorComponent.DefaultHalfHeight;
		vector2.DeepCopy(actorLocationProxy);
		vector2.Z -= (double)(characterActorComponent.DefaultHalfHeight + 300f);
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		if (actorTrace == null)
		{
			return false;
		}
		actorTrace.WorldContextObject = characterActorComponent.Actor;
		actorTrace.Radius = characterActorComponent.DefaultRadius;
		TraceElementCommon.Instance.SetStartLocation(actorTrace, vector);
		TraceElementCommon.Instance.SetEndLocation(actorTrace, vector2);
		actorTrace.ActorsToIgnore.Empty(true);
		if (!TraceElementCommon.Instance.ShapeTrace(characterActorComponent.Actor.CapsuleComponent, actorTrace, "Advice", "Advice"))
		{
			TraceElementModel.Instance.ClearActorTrace();
			return false;
		}
		UKuroHitResult hitResult = actorTrace.HitResult;
		int num = (hitResult != null) ? hitResult.GetHitCount() : 0;
		for (int i = 0; i < num; i++)
		{
			UKuroHitResult hitResult2 = actorTrace.HitResult;
			TWeakObjectPtr<AActor>? tweakObjectPtr;
			if (hitResult2 == null)
			{
				tweakObjectPtr = null;
			}
			else
			{
				TArray<TWeakObjectPtr<AActor>> actors = hitResult2.Actors;
				tweakObjectPtr = ((actors != null) ? new TWeakObjectPtr<AActor>?(actors.Get(i)) : null);
			}
			TWeakObjectPtr<AActor>? tweakObjectPtr2 = tweakObjectPtr;
			if (tweakObjectPtr2 != null)
			{
				TWeakObjectPtr<AActor>? tweakObjectPtr3 = tweakObjectPtr2;
				if (!this.GetActorIfValidForAdvice((tweakObjectPtr3 != null) ? tweakObjectPtr3.GetValueOrDefault() : null))
				{
					TraceElementModel.Instance.ClearActorTrace();
					return false;
				}
			}
		}
		TraceElementModel.Instance.ClearActorTrace();
		return true;
	}

	// Token: 0x0600A63F RID: 42559 RVA: 0x00253044 File Offset: 0x00251244
	private bool GetActorIfValidForAdvice(AActor hitActor)
	{
		if (hitActor != null && hitActor is IBPI_CreatureInterface_C)
		{
			IBPI_CreatureInterface_C ibpi_CreatureInterface_C = hitActor as IBPI_CreatureInterface_C;
			int id = (ibpi_CreatureInterface_C != null) ? ibpi_CreatureInterface_C.GetEntityId() : 0;
			Entity entity = EntitySystem.Instance.Get(id);
			return entity == null || !entity.Valid;
		}
		SceneInteractionModel instance = SceneInteractionModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetEntityByActor(hitActor, false) : null;
		return entityHandle == null || !entityHandle.Valid;
	}

	// Token: 0x17000DEA RID: 3562
	// (get) Token: 0x0600A640 RID: 42560 RVA: 0x002530B0 File Offset: 0x002512B0
	public static AdviceController Instance
	{
		get
		{
			return AdviceController._Instance;
		}
	}

	// Token: 0x0600A641 RID: 42561 RVA: 0x002530B7 File Offset: 0x002512B7
	public static AdviceController GetOrCreateInstance()
	{
		if (AdviceController._Instance == null)
		{
			AdviceController.CreateInstance();
		}
		return AdviceController._Instance;
	}

	// Token: 0x0600A642 RID: 42562 RVA: 0x002530CB File Offset: 0x002512CB
	public static bool CreateInstance()
	{
		if (AdviceController._Instance != null)
		{
			return true;
		}
		AdviceController._Instance = new AdviceController();
		return true;
	}

	// Token: 0x0600A643 RID: 42563 RVA: 0x002530E1 File Offset: 0x002512E1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A644 RID: 42564 RVA: 0x002530E3 File Offset: 0x002512E3
	public static void ResetStaticDefaultValue()
	{
		AdviceController._Instance = null;
	}

	// Token: 0x0600A645 RID: 42565 RVA: 0x002530EB File Offset: 0x002512EB
	static AdviceController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AdviceController.CreateStaticDefaultValue), new Action(AdviceController.ResetStaticDefaultValue));
	}

	// Token: 0x04004B00 RID: 19200
	public const int INFO_ADVICE_ITEM_TYPE = 20;

	// Token: 0x04004B01 RID: 19201
	private const string PROFILE_KEY = "Advice";

	// Token: 0x04004B02 RID: 19202
	[Nullable(2)]
	private static AdviceController _Instance;
}
