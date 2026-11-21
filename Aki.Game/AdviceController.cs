using System;
using System.Collections.Generic;
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

// Token: 0x02000B74 RID: 2932
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class AdviceController : ControllerBase
{
	// Token: 0x060079FF RID: 31231 RVA: 0x0025C76D File Offset: 0x0025A96D
	protected override bool OnInit()
	{
		this.OnAddEvents();
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x06007A00 RID: 31232 RVA: 0x0025C77C File Offset: 0x0025A97C
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x06007A01 RID: 31233 RVA: 0x0025C78C File Offset: 0x0025A98C
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnGetFriendInitData, new Action(this.RequestAdviceData));
		EventSystem.Instance.Add(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Add(EEventName.OriginWorldLevelUp, new Action(this.OnWorldLevelUp));
		EventSystem.Instance.Add(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x06007A02 RID: 31234 RVA: 0x0025C828 File Offset: 0x0025AA28
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnGetFriendInitData, new Action(this.RequestAdviceData));
		EventSystem.Instance.Remove(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Remove(EEventName.OriginWorldLevelUp, new Action(this.OnWorldLevelUp));
		EventSystem.Instance.Remove(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x06007A03 RID: 31235 RVA: 0x0025C8C4 File Offset: 0x0025AAC4
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.AdviceContentUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAdviceContentUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.AdviceVoteUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAdviceVoteUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.AdviceUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAdviceUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.AdviceSettingNotify, new Action<IMessage, Net.CallbackStatus>(this.OnAdviceSettingNotify));
	}

	// Token: 0x06007A04 RID: 31236 RVA: 0x0025C944 File Offset: 0x0025AB44
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.AdviceContentUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AdviceVoteUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AdviceSettingNotify);
		Net.Instance.UnRegister(ENotifyMessageId.AdviceUpdateNotify);
	}

	// Token: 0x06007A05 RID: 31237 RVA: 0x0025C991 File Offset: 0x0025AB91
	private void OnWorldLevelUp()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.AdviceInfoView))
		{
			UiManager.Instance.CloseView(EUiViewName.AdviceInfoView, null);
		}
	}

	// Token: 0x06007A06 RID: 31238 RVA: 0x0025C9B4 File Offset: 0x0025ABB4
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.AdviceInfoView))
		{
			UiManager.Instance.CloseView(EUiViewName.AdviceInfoView, null);
		}
	}

	// Token: 0x06007A07 RID: 31239 RVA: 0x0025C9D8 File Offset: 0x0025ABD8
	private void OnItemUse(int configId, int useCount)
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(configId);
		int num;
		if (itemConfig != null && itemConfig.Value.Parameters() != null && itemConfig.Value.Parameters().Count > 0 && itemConfig.Value.Parameters().TryGetValue(20, out num) && num != 0)
		{
			this.OpenAdviceCreateView();
		}
	}

	// Token: 0x06007A08 RID: 31240 RVA: 0x0025CA45 File Offset: 0x0025AC45
	private void OnCrossDay()
	{
		AdviceModel.Instance.ResetVoteIds();
	}

	// Token: 0x06007A09 RID: 31241 RVA: 0x0025CA51 File Offset: 0x0025AC51
	public void OpenAdviceConjunctionSelectView()
	{
		AdviceModel instance = AdviceModel.Instance;
		instance.CurrentChangeWordType = EChangeWordType.Conjunction;
		instance.CurrentSelectWordId = instance.CurrentConjunctionId;
		UiManager.Instance.OpenView(EUiViewName.AdviceWordView, null, null);
	}

	// Token: 0x06007A0A RID: 31242 RVA: 0x0025CA7C File Offset: 0x0025AC7C
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

	// Token: 0x06007A0B RID: 31243 RVA: 0x0025CB18 File Offset: 0x0025AD18
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

	// Token: 0x06007A0C RID: 31244 RVA: 0x0025CB7A File Offset: 0x0025AD7A
	public void OpenAdviceExpressionView()
	{
		UiManager.Instance.OpenView(EUiViewName.AdviceExpressionView, null, null);
	}

	// Token: 0x06007A0D RID: 31245 RVA: 0x0025CB90 File Offset: 0x0025AD90
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

	// Token: 0x06007A0E RID: 31246 RVA: 0x0025CBE0 File Offset: 0x0025ADE0
	public void OpenAdviceView()
	{
		AdviceModel.Instance.AdviceViewShowId = null;
		UiManager.Instance.OpenView(EUiViewName.AdviceView, null, null);
	}

	// Token: 0x06007A0F RID: 31247 RVA: 0x0025CC04 File Offset: 0x0025AE04
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

	// Token: 0x06007A10 RID: 31248 RVA: 0x0025CC50 File Offset: 0x0025AE50
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

	// Token: 0x06007A11 RID: 31249 RVA: 0x0025CCB8 File Offset: 0x0025AEB8
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

	// Token: 0x06007A12 RID: 31250 RVA: 0x0025CD2C File Offset: 0x0025AF2C
	private void RequestAdviceData()
	{
		AdviceRequest message = AdviceRequest.Create();
		Net.Instance.Call(ERequestMessageId.AdviceRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AdviceResponse adviceResponse = (AdviceResponse)msg;
			if (adviceResponse == null || adviceResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(adviceResponse.ErrorCode, 28955, null, true, true);
				return;
			}
			if (adviceResponse != null)
			{
				AdviceModel.Instance.PhraseAdviceData(adviceResponse);
			}
		}, 0);
	}

	// Token: 0x06007A13 RID: 31251 RVA: 0x0025CD70 File Offset: 0x0025AF70
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(adviceCreateResponse.ErrorCode, 19764, null, true, true);
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

	// Token: 0x06007A14 RID: 31252 RVA: 0x0025CE48 File Offset: 0x0025B048
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(adviceModifyResponse.ErrorCode, 18162, null, true, true);
				return;
			}
			AdviceModel.Instance.OnModifyAdvice(id, adviceContent);
		}, 0);
	}

	// Token: 0x06007A15 RID: 31253 RVA: 0x0025CED4 File Offset: 0x0025B0D4
	public void RequestDeleteAdvice(long id)
	{
		AdviceDeleteRequest adviceDeleteRequest = AdviceDeleteRequest.Create();
		adviceDeleteRequest.Id = id;
		Net.Instance.Call(ERequestMessageId.AdviceDeleteRequest, adviceDeleteRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AdviceDeleteResponse adviceDeleteResponse = (AdviceDeleteResponse)msg;
			if (adviceDeleteResponse == null || adviceDeleteResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(adviceDeleteResponse.ErrorCode, 28966, null, true, true);
				return;
			}
			AdviceModel.Instance.OnDeleteAdvice(id);
		}, 0);
	}

	// Token: 0x06007A16 RID: 31254 RVA: 0x0025CF20 File Offset: 0x0025B120
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(adviceVoteResponse.ErrorCode, 18076, null, true, true);
				EventSystem.Instance.Emit(EEventName.OnAdviceVoteNotify);
				return;
			}
			AdviceModel.Instance.OnRequestVote(adviceId, type);
		}, 0);
	}

	// Token: 0x06007A17 RID: 31255 RVA: 0x0025CF78 File Offset: 0x0025B178
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
			adviceInfo.PhraseContent(new List<PbAdviceContent>(adviceContentUpdateNotify.Contents));
		}
	}

	// Token: 0x06007A18 RID: 31256 RVA: 0x0025CFD4 File Offset: 0x0025B1D4
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

	// Token: 0x06007A19 RID: 31257 RVA: 0x0025D084 File Offset: 0x0025B284
	[NullableContext(2)]
	private void OnAdviceUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		AdviceUpdateNotify response = (AdviceUpdateNotify)msg;
		AdviceModel.Instance.OnAdviceUpdateNotify(response);
	}

	// Token: 0x06007A1A RID: 31258 RVA: 0x0025D0A4 File Offset: 0x0025B2A4
	[NullableContext(2)]
	private void OnAdviceSettingNotify(IMessage msg, Net.CallbackStatus status)
	{
		AdviceSettingNotify adviceSettingNotify = (AdviceSettingNotify)msg;
		AdviceModel.Instance.SetAdviceShowSetting(adviceSettingNotify.IsShow);
	}

	// Token: 0x06007A1B RID: 31259 RVA: 0x0025D0C8 File Offset: 0x0025B2C8
	public void RequestSetAdviceShowState(bool state)
	{
		AdviceSetRequest message = AdviceSetRequest.Create();
		message.IsShow = state;
		Net.Instance.Call(ERequestMessageId.AdviceSetRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AdviceSetResponse adviceSetResponse = (AdviceSetResponse)msg;
			if (adviceSetResponse == null || adviceSetResponse.ErrorCode > Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(adviceSetResponse.ErrorCode, 20925, null, true, true);
				return;
			}
			AdviceModel.Instance.SetAdviceShowSetting(message.IsShow);
		}, 0);
	}

	// Token: 0x06007A1C RID: 31260 RVA: 0x0025D114 File Offset: 0x0025B314
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

	// Token: 0x06007A1D RID: 31261 RVA: 0x0025D19C File Offset: 0x0025B39C
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

	// Token: 0x06007A1E RID: 31262 RVA: 0x0025D2B8 File Offset: 0x0025B4B8
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

	// Token: 0x06007A1F RID: 31263 RVA: 0x0025D454 File Offset: 0x0025B654
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

	// Token: 0x17000E0B RID: 3595
	// (get) Token: 0x06007A20 RID: 31264 RVA: 0x0025D4C0 File Offset: 0x0025B6C0
	public static AdviceController Instance
	{
		get
		{
			return AdviceController._Instance;
		}
	}

	// Token: 0x06007A21 RID: 31265 RVA: 0x0025D4C7 File Offset: 0x0025B6C7
	public static AdviceController GetOrCreateInstance()
	{
		if (AdviceController._Instance == null)
		{
			AdviceController.CreateInstance();
		}
		return AdviceController._Instance;
	}

	// Token: 0x06007A22 RID: 31266 RVA: 0x0025D4DB File Offset: 0x0025B6DB
	public static bool CreateInstance()
	{
		if (AdviceController._Instance != null)
		{
			return true;
		}
		AdviceController._Instance = new AdviceController();
		return true;
	}

	// Token: 0x06007A23 RID: 31267 RVA: 0x0025D4F1 File Offset: 0x0025B6F1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007A24 RID: 31268 RVA: 0x0025D4F3 File Offset: 0x0025B6F3
	public static void ResetStaticDefaultValue()
	{
		AdviceController._Instance = null;
	}

	// Token: 0x06007A25 RID: 31269 RVA: 0x0025D4FB File Offset: 0x0025B6FB
	static AdviceController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AdviceController.CreateStaticDefaultValue), new Action(AdviceController.ResetStaticDefaultValue));
	}

	// Token: 0x04004BA7 RID: 19367
	public const int INFO_ADVICE_ITEM_TYPE = 20;

	// Token: 0x04004BA8 RID: 19368
	private const string PROFILE_KEY = "Advice";

	// Token: 0x04004BA9 RID: 19369
	[Nullable(2)]
	private static AdviceController _Instance;
}
