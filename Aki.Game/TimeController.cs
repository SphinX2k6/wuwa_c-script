using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.NewWorld.Pawn.Component;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020034E8 RID: 13544
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class TimeController : ControllerBase
{
	// Token: 0x0601DADB RID: 121563 RVA: 0x008502C8 File Offset: 0x0084E4C8
	protected override bool OnInit()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.WorldDone;
		Action handle;
		if ((handle = TimeController.<>O.<0>__OnWorldDone) == null)
		{
			handle = (TimeController.<>O.<0>__OnWorldDone = new Action(TimeController.OnWorldDone));
		}
		instance.Add(name, handle);
		EventSystem.Instance.Add(EEventName.CharBornFinished, new Action<int>(this.OnCharBornFinished));
		return true;
	}

	// Token: 0x0601DADC RID: 121564 RVA: 0x0085031D File Offset: 0x0084E51D
	protected override void OnTick(float delta)
	{
	}

	// Token: 0x0601DADD RID: 121565 RVA: 0x00850320 File Offset: 0x0084E520
	protected override bool OnClear()
	{
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.WorldDone;
		Action handle;
		if ((handle = TimeController.<>O.<0>__OnWorldDone) == null)
		{
			handle = (TimeController.<>O.<0>__OnWorldDone = new Action(TimeController.OnWorldDone));
		}
		instance.Remove(name, handle);
		EventSystem.Instance.Remove(EEventName.CharBornFinished, new Action<int>(this.OnCharBornFinished));
		if (this._timeCheckTimerId != null)
		{
			TimerSystem.Instance.Remove(this._timeCheckTimerId);
			this._timeCheckTimerId = null;
		}
		return true;
	}

	// Token: 0x0601DADE RID: 121566 RVA: 0x00850398 File Offset: 0x0084E598
	private static void OnWorldDone()
	{
		TimeController instance = TimeController.Instance;
		if (instance._timeCheckTimerId == null)
		{
			instance._timeCheckTimerId = TimerSystem.Instance.Forever(delegate(float _)
			{
				TimeController.Instance.TimeCheckRequest();
			}, 3000f, 1f, null, null, true);
		}
	}

	// Token: 0x0601DADF RID: 121567 RVA: 0x008503F0 File Offset: 0x0084E5F0
	public unsafe void TimeCheck(long lastClientTime, long serverTime, long serverStopTime, long flowTime, long combatTime)
	{
		double predictedServerCombatTimeOffset = this._predictedServerCombatTimeOffset;
		double predictedServerStopTimeOffset = this._predictedServerStopTimeOffset;
		this._predictedServerCombatTimeOffset = (double)combatTime - Time.Instance.FlowTime;
		this._predictedServerStopTimeOffset = (double)serverStopTime - Time.Instance.WorldTime;
		Time.Instance.SyncTime((double)serverTime, (double)flowTime, this._predictedServerCombatTimeOffset, this._predictedServerStopTimeOffset);
		EventSystem.Instance.Emit<double, double, double, double>(EEventName.TsSyncTime, (double)serverTime, (double)flowTime, this._predictedServerCombatTimeOffset, this._predictedServerStopTimeOffset);
		if (this._predictedServerStopTimeOffset - predictedServerStopTimeOffset > 3000.0 || this._predictedServerCombatTimeOffset - predictedServerCombatTimeOffset > 3000.0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "对时通知";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("clientTime", lastClientTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("serverTime", serverTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("serverStopTime", serverStopTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("PredictedServerCombatTimeOffset", this._predictedServerCombatTimeOffset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("PredictedServerStopTimeOffset", this._predictedServerStopTimeOffset);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}
	}

	// Token: 0x0601DAE0 RID: 121568 RVA: 0x00850558 File Offset: 0x0084E758
	[NullableContext(2)]
	public void TimeCheckNotify(IMessage msg, Net.CallbackStatus status)
	{
		TimeCheckNotify timeCheckNotify = (TimeCheckNotify)msg;
		long clientTime = timeCheckNotify.ClientTime;
		long serverTime = timeCheckNotify.ServerTime;
		long sceneStopTime = timeCheckNotify.SceneStopTime;
		long flowTime = timeCheckNotify.FlowTime;
		long serverStopTime = timeCheckNotify.ServerStopTime;
		this.TimeCheck(clientTime, serverTime, sceneStopTime, flowTime, serverStopTime);
	}

	// Token: 0x0601DAE1 RID: 121569 RVA: 0x0085059C File Offset: 0x0084E79C
	public void TimeCheckRequest()
	{
		if (!Net.Instance.IsServerConnected())
		{
			return;
		}
		TimeCheckRequest timeCheckRequest = new TimeCheckRequest();
		timeCheckRequest.ClientTime = (long)Time.Instance.WorldTime;
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			timeCheckRequest.Dilation = Time.Instance.TimeDilation * UGameplayStatics.GetGlobalTimeDilation(GlobalData.World);
		}
		else
		{
			timeCheckRequest.Dilation = Time.Instance.TimeDilation;
		}
		timeCheckRequest.RDilation = Time.Instance.FlowTimeDilation;
		Net.Instance.Call(ERequestMessageId.TimeCheckRequest, timeCheckRequest, new Action<IMessage, Net.CallbackStatus>(this.<TimeCheckRequest>g__Response|14_0), 0);
	}

	// Token: 0x0601DAE2 RID: 121570 RVA: 0x00850633 File Offset: 0x0084E833
	private static float NormalizeTimeScale(float timeScale)
	{
		if (timeScale <= 0f)
		{
			return 0f;
		}
		return MathUtils.Instance.Clamp(timeScale, 0f, 1f);
	}

	// Token: 0x0601DAE3 RID: 121571 RVA: 0x00850658 File Offset: 0x0084E858
	private static float CalcFinalTimeScale(IEnumerable<TimeStopInfo> list)
	{
		float num = 1f;
		bool flag = false;
		foreach (TimeStopInfo timeStopInfo in list)
		{
			flag = true;
			if (timeStopInfo.TimeScale <= 0f)
			{
				return 0f;
			}
			num = Math.Min(num, timeStopInfo.TimeScale);
		}
		if (!flag)
		{
			return 1f;
		}
		return num;
	}

	// Token: 0x0601DAE4 RID: 121572 RVA: 0x008506D4 File Offset: 0x0084E8D4
	public bool AddLock(int instigatorId, bool stopMove, float timeScale = 0f)
	{
		if (this._instigatorList.ContainsKey(instigatorId))
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Skill, (long)instigatorId, "同一实体重复添加时停，将不被处理", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this._instigatorList[instigatorId] = new TimeStopInfo
		{
			StopMove = stopMove,
			TimeScale = TimeController.NormalizeTimeScale(timeScale)
		};
		Entity entity = EntitySystem.Instance.Get(instigatorId);
		if (entity != null)
		{
			PawnTimeScaleComponent component = entity.GetComponent<PawnTimeScaleComponent>();
			if (component != null)
			{
				component.AddNormalizeTimeScaleLock("ANS AbsoluteTimeStop Self", false);
			}
		}
		this.RefreshStopState();
		return true;
	}

	// Token: 0x0601DAE5 RID: 121573 RVA: 0x0085075E File Offset: 0x0084E95E
	public bool RemoveLock(int instigatorId)
	{
		if (!this._instigatorList.Remove(instigatorId))
		{
			return false;
		}
		Entity entity = EntitySystem.Instance.Get(instigatorId);
		if (entity != null)
		{
			PawnTimeScaleComponent component = entity.GetComponent<PawnTimeScaleComponent>();
			if (component != null)
			{
				component.RemoveNormalizeTimeScaleLock("ANS AbsoluteTimeStop Self", false);
			}
		}
		this.RefreshStopState();
		return true;
	}

	// Token: 0x0601DAE6 RID: 121574 RVA: 0x008507A0 File Offset: 0x0084E9A0
	private void RefreshStopState()
	{
		if (GameModeModel.Instance.IsMulti)
		{
			this._instigatorList.Clear();
		}
		List<int> list = new List<int>();
		foreach (int num in this._instigatorList.Keys)
		{
			Entity entity = EntitySystem.Instance.Get(num);
			if (entity == null || !entity.Valid)
			{
				list.Add(num);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			int key = list[i];
			this._instigatorList.Remove(key);
		}
		bool flag = this._instigatorList.Count > 0;
		bool flag2 = this.IsFinalStopMove();
		float num2 = TimeController.CalcFinalTimeScale(this._instigatorList.Values);
		if (this._stopState == flag && !flag && this._lastAppliedStopMove == flag2 && this._lastAppliedStopScale == num2)
		{
			return;
		}
		this._stopState = flag;
		this._lastAppliedStopMove = flag2;
		this._lastAppliedStopScale = num2;
		if (this._stopState)
		{
			this.StopInner(flag2, num2);
			return;
		}
		this.RecoverInner();
	}

	// Token: 0x0601DAE7 RID: 121575 RVA: 0x008508D4 File Offset: 0x0084EAD4
	private bool IsFinalStopMove()
	{
		bool result = true;
		using (Dictionary<int, TimeStopInfo>.ValueCollection.Enumerator enumerator = this._instigatorList.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.StopMove)
				{
					result = false;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x0601DAE8 RID: 121576 RVA: 0x00850934 File Offset: 0x0084EB34
	private void StopInner(bool stopMove, float stopScale)
	{
		List<EntityHandle> list = new List<EntityHandle>();
		CreatureModel.Instance.GetEntitiesInRange(20000f, EEntityTypeQuery.Character, list, true, true);
		for (int i = 0; i < list.Count; i++)
		{
			EntityHandle entityHandle = list[i];
			if (entityHandle.IsInit)
			{
				if (this._instigatorList.ContainsKey(entityHandle.Id))
				{
					this.RecoverEntityInner(entityHandle);
				}
				else
				{
					EntityHandle entityHandle2 = entityHandle;
					CreatureModel instance = CreatureModel.Instance;
					WorldEntity entity = entityHandle2.Entity;
					long? num;
					if (entity == null)
					{
						num = null;
					}
					else
					{
						CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
						num = ((component != null) ? new long?(component.GetSummonerId()) : null);
					}
					long? num2 = num;
					EntityHandle entity2 = instance.GetEntity(num2.GetValueOrDefault(-1L));
					bool flag = false;
					while (entity2 != null && entity2 != entityHandle2)
					{
						if (this._instigatorList.ContainsKey(entity2.Id))
						{
							flag = true;
							break;
						}
						entityHandle2 = entity2;
						CreatureModel instance2 = CreatureModel.Instance;
						WorldEntity entity3 = entity2.Entity;
						long? num3;
						if (entity3 == null)
						{
							num3 = null;
						}
						else
						{
							CreatureDataComponent component2 = entity3.GetComponent<CreatureDataComponent>();
							num3 = ((component2 != null) ? new long?(component2.GetSummonerId()) : null);
						}
						num2 = num3;
						entity2 = instance2.GetEntity(num2.GetValueOrDefault(-1L));
					}
					if (flag)
					{
						this.RecoverEntityInner(entityHandle);
					}
					else
					{
						this.StopEntityInner(entityHandle, stopMove, stopScale);
					}
				}
			}
		}
	}

	// Token: 0x0601DAE9 RID: 121577 RVA: 0x00850A84 File Offset: 0x0084EC84
	private void RecoverInner()
	{
		List<EntityHandle> list = new List<EntityHandle>(this._timeStopAnimEntitySet);
		for (int i = 0; i < list.Count; i++)
		{
			EntityHandle entityHandle = list[i];
			if (entityHandle.Valid)
			{
				this.RecoverEntityInner(entityHandle);
			}
		}
	}

	// Token: 0x0601DAEA RID: 121578 RVA: 0x00850AC8 File Offset: 0x0084ECC8
	private void StopEntityInner(EntityHandle handle, bool stopMove, float stopScale)
	{
		this._timeStopAnimEntitySet.Add(handle);
		WorldEntity entity = handle.Entity;
		PawnTimeScaleComponent pawnTimeScaleComponent = (entity != null) ? entity.GetComponent<PawnTimeScaleComponent>() : null;
		WorldEntity entity2 = handle.Entity;
		BaseMoveComponent baseMoveComponent = (entity2 != null) ? entity2.GetComponent<BaseMoveComponent>() : null;
		if (pawnTimeScaleComponent != null)
		{
			pawnTimeScaleComponent.RemoveForceTimeScale("ANS AbsoluteTimeStop Other Scale", false);
		}
		if (pawnTimeScaleComponent != null)
		{
			pawnTimeScaleComponent.RemovePauseLock("ANS AbsoluteTimeStop Other");
		}
		if (baseMoveComponent != null)
		{
			baseMoveComponent.RemovePauseLock("ANS AbsoluteTimeStop Other");
		}
		this.RemoveCharacterBulletTimeScale(handle.Id);
		if (stopScale <= 0f)
		{
			if (pawnTimeScaleComponent != null)
			{
				pawnTimeScaleComponent.AddPauseLock("ANS AbsoluteTimeStop Other");
			}
			if (stopMove && baseMoveComponent != null)
			{
				baseMoveComponent.AddPauseLock("ANS AbsoluteTimeStop Other");
			}
			BulletUtil.FrozenCharacterBullet(handle.Id, null, 0f);
			return;
		}
		if (pawnTimeScaleComponent != null)
		{
			pawnTimeScaleComponent.AddForceTimeScale(stopScale, "ANS AbsoluteTimeStop Other Scale", false, ETimeScaleSourceType.InnerPauseLock);
		}
		BulletUtil.UnFrozenCharacterBullet(handle.Id, null);
		Dictionary<int, int> orCreateBulletScaleHandleMap = this.GetOrCreateBulletScaleHandleMap(handle.Id);
		BulletUtil.SetCharacterBulletTimeScale(handle.Id, stopScale, orCreateBulletScaleHandleMap, ETimeScaleSourceType.InnerPauseLock);
	}

	// Token: 0x0601DAEB RID: 121579 RVA: 0x00850BB4 File Offset: 0x0084EDB4
	private void RecoverEntityInner(EntityHandle handle)
	{
		this._timeStopAnimEntitySet.Remove(handle);
		WorldEntity entity = handle.Entity;
		PawnTimeScaleComponent pawnTimeScaleComponent = (entity != null) ? entity.GetComponent<PawnTimeScaleComponent>() : null;
		if (pawnTimeScaleComponent != null)
		{
			pawnTimeScaleComponent.RemoveForceTimeScale("ANS AbsoluteTimeStop Other Scale", false);
		}
		if (pawnTimeScaleComponent != null)
		{
			pawnTimeScaleComponent.RemovePauseLock("ANS AbsoluteTimeStop Other");
		}
		WorldEntity entity2 = handle.Entity;
		BaseMoveComponent baseMoveComponent = (entity2 != null) ? entity2.GetComponent<BaseMoveComponent>() : null;
		if (baseMoveComponent != null)
		{
			baseMoveComponent.RemovePauseLock("ANS AbsoluteTimeStop Other");
		}
		BulletUtil.UnFrozenCharacterBullet(handle.Id, null);
		this.RemoveCharacterBulletTimeScale(handle.Id);
	}

	// Token: 0x0601DAEC RID: 121580 RVA: 0x00850C3C File Offset: 0x0084EE3C
	private Dictionary<int, int> GetOrCreateBulletScaleHandleMap(int entityId)
	{
		Dictionary<int, int> dictionary;
		if (!this._timeStopBulletScaleHandleMap.TryGetValue(entityId, out dictionary))
		{
			dictionary = new Dictionary<int, int>();
			this._timeStopBulletScaleHandleMap[entityId] = dictionary;
		}
		return dictionary;
	}

	// Token: 0x0601DAED RID: 121581 RVA: 0x00850C70 File Offset: 0x0084EE70
	private void RemoveCharacterBulletTimeScale(int entityId)
	{
		Dictionary<int, int> handleMap;
		if (!this._timeStopBulletScaleHandleMap.TryGetValue(entityId, out handleMap))
		{
			return;
		}
		BulletUtil.RemoveCharacterBulletTimeScale(entityId, handleMap);
		this._timeStopBulletScaleHandleMap.Remove(entityId);
	}

	// Token: 0x0601DAEE RID: 121582 RVA: 0x00850CA4 File Offset: 0x0084EEA4
	private void OnCharBornFinished(int entityId)
	{
		if (this._stopState)
		{
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
			if (entityById != null && entityById.Valid)
			{
				this.StopEntityInner(entityById, this._lastAppliedStopMove, this._lastAppliedStopScale);
			}
		}
	}

	// Token: 0x0601DAEF RID: 121583 RVA: 0x00850CE4 File Offset: 0x0084EEE4
	public bool AddTimeStopRequestLock(int instigatorId, float timeScale = 0f)
	{
		if (this._timeStopRequestInstigatorMap.ContainsKey(instigatorId))
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Skill, (long)instigatorId, "同一实体重复添加副本时停请求，将不被处理", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this._timeStopRequestInstigatorMap[instigatorId] = new TimeStopInfo
		{
			StopMove = false,
			TimeScale = TimeController.NormalizeTimeScale(timeScale)
		};
		Entity entity = EntitySystem.Instance.Get(instigatorId);
		if (entity != null)
		{
			PawnTimeScaleComponent component = entity.GetComponent<PawnTimeScaleComponent>();
			if (component != null)
			{
				component.AddNormalizeTimeScaleLock("TIME_STOP_REQUEST_SELF_LOCK", false);
			}
		}
		this.RefreshTimeStopRequestState();
		return true;
	}

	// Token: 0x0601DAF0 RID: 121584 RVA: 0x00850D6E File Offset: 0x0084EF6E
	public bool RemoveTimeStopRequestLock(int instigatorId)
	{
		if (!this._timeStopRequestInstigatorMap.Remove(instigatorId))
		{
			return false;
		}
		Entity entity = EntitySystem.Instance.Get(instigatorId);
		if (entity != null)
		{
			PawnTimeScaleComponent component = entity.GetComponent<PawnTimeScaleComponent>();
			if (component != null)
			{
				component.RemoveNormalizeTimeScaleLock("TIME_STOP_REQUEST_SELF_LOCK", false);
			}
		}
		this.RefreshTimeStopRequestState();
		return true;
	}

	// Token: 0x0601DAF1 RID: 121585 RVA: 0x00850DB0 File Offset: 0x0084EFB0
	private void RefreshTimeStopRequestState()
	{
		float num = TimeController.CalcFinalTimeScale(this._timeStopRequestInstigatorMap.Values);
		if (this._timeStopRequestInstigatorMap.Count == 0)
		{
			this.StopTimeStopRequest();
			return;
		}
		if (this._timeStopRequestInstigatorMap.Count == 1 || this._lastAppliedRequestScale != num)
		{
			this.StartTimeStopRequest(num);
		}
	}

	// Token: 0x0601DAF2 RID: 121586 RVA: 0x00850E00 File Offset: 0x0084F000
	private void StartTimeStopRequest(float timeScale)
	{
		this._lastAppliedRequestScale = timeScale;
		float inverseSelfCenteredTimeDilation = CharacterModel.Instance.InverseSelfCenteredTimeDilation;
		float num = MathUtils.Instance.Clamp(timeScale, 0f, 1f);
		float flowTimeDilation = (timeScale <= 0f) ? 0f : (inverseSelfCenteredTimeDilation * num);
		Time.Instance.SetFlowTimeDilation(flowTimeDilation);
		foreach (EntityHandle entityHandle in CreatureModel.Instance.GetAllEntities())
		{
			if (entityHandle.IsInit)
			{
				WorldEntity entity = entityHandle.Entity;
				CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
				if (characterBuffComponent != null)
				{
					characterBuffComponent.AddPauseLock("ANS AbsoluteTimeStop", timeScale);
				}
				this._timeStopBuffEntitySet.Add(entityHandle);
			}
		}
		FormationAttributeController.Instance.AddPauseLock("ANS AbsoluteTimeStop", timeScale);
		SkillCdController.Instance.Pause(ESkillCdPauseReason.AnsAbsoluteTimeStop, timeScale <= 0f);
	}

	// Token: 0x0601DAF3 RID: 121587 RVA: 0x00850EF4 File Offset: 0x0084F0F4
	private void StopTimeStopRequest()
	{
		this._lastAppliedRequestScale = 1f;
		Time.Instance.SetFlowTimeDilation(CharacterModel.Instance.InverseSelfCenteredTimeDilation);
		foreach (EntityHandle entityHandle in this._timeStopBuffEntitySet)
		{
			WorldEntity entity = entityHandle.Entity;
			CharacterBuffComponent characterBuffComponent = (entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null;
			if (characterBuffComponent != null)
			{
				characterBuffComponent.RemovePauseLock("ANS AbsoluteTimeStop");
			}
		}
		this._timeStopBuffEntitySet.Clear();
		FormationAttributeController.Instance.RemovePauseLock("ANS AbsoluteTimeStop");
		SkillCdController.Instance.Pause(ESkillCdPauseReason.AnsAbsoluteTimeStop, false);
	}

	// Token: 0x170028ED RID: 10477
	// (get) Token: 0x0601DAF4 RID: 121588 RVA: 0x00850FA8 File Offset: 0x0084F1A8
	public static TimeController Instance
	{
		get
		{
			return TimeController._Instance;
		}
	}

	// Token: 0x0601DAF5 RID: 121589 RVA: 0x00850FAF File Offset: 0x0084F1AF
	public static TimeController GetOrCreateInstance()
	{
		if (TimeController._Instance == null)
		{
			TimeController.CreateInstance();
		}
		return TimeController._Instance;
	}

	// Token: 0x0601DAF6 RID: 121590 RVA: 0x00850FC3 File Offset: 0x0084F1C3
	public static bool CreateInstance()
	{
		if (TimeController._Instance != null)
		{
			return true;
		}
		TimeController._Instance = new TimeController();
		return true;
	}

	// Token: 0x0601DAF7 RID: 121591 RVA: 0x00850FD9 File Offset: 0x0084F1D9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DAF8 RID: 121592 RVA: 0x00850FDB File Offset: 0x0084F1DB
	public static void ResetStaticDefaultValue()
	{
		TimeController._Instance = null;
	}

	// Token: 0x0601DAF9 RID: 121593 RVA: 0x00850FE3 File Offset: 0x0084F1E3
	static TimeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeController.CreateStaticDefaultValue), new Action(TimeController.ResetStaticDefaultValue));
	}

	// Token: 0x0601DAFB RID: 121595 RVA: 0x00851060 File Offset: 0x0084F260
	[NullableContext(2)]
	[CompilerGenerated]
	private void <TimeCheckRequest>g__Response|14_0(IMessage msg, Net.CallbackStatus callbackStatus)
	{
		TimeCheckResponse timeCheckResponse = (TimeCheckResponse)msg;
		if (timeCheckResponse == null)
		{
			return;
		}
		long clientTime = timeCheckResponse.ClientTime;
		long serverTime = timeCheckResponse.ServerTime;
		long sceneStopTime = timeCheckResponse.SceneStopTime;
		long flowTime = timeCheckResponse.FlowTime;
		long serverStopTime = timeCheckResponse.ServerStopTime;
		this.TimeCheck(clientTime, serverTime, sceneStopTime, flowTime, serverStopTime);
	}

	// Token: 0x0400E8DC RID: 59612
	private const int TIME_STOP_DISTANCE = 20000;

	// Token: 0x0400E8DD RID: 59613
	private const string ABSOLUTE_TIME_STOP_TARGET_LOCK = "ANS AbsoluteTimeStop Other";

	// Token: 0x0400E8DE RID: 59614
	private const string ABSOLUTE_TIME_STOP_SELF_LOCK = "ANS AbsoluteTimeStop Self";

	// Token: 0x0400E8DF RID: 59615
	private const string ABSOLUTE_TIME_STOP_TARGET_SCALE_LOCK = "ANS AbsoluteTimeStop Other Scale";

	// Token: 0x0400E8E0 RID: 59616
	private const string TIME_STOP_REQUEST_SELF_LOCK = "TIME_STOP_REQUEST_SELF_LOCK";

	// Token: 0x0400E8E1 RID: 59617
	private double _predictedServerCombatTimeOffset;

	// Token: 0x0400E8E2 RID: 59618
	private double _predictedServerStopTimeOffset;

	// Token: 0x0400E8E3 RID: 59619
	[Nullable(2)]
	private TimerHandle _timeCheckTimerId;

	// Token: 0x0400E8E4 RID: 59620
	private Dictionary<int, TimeStopInfo> _instigatorList = new Dictionary<int, TimeStopInfo>();

	// Token: 0x0400E8E5 RID: 59621
	private HashSet<EntityHandle> _timeStopAnimEntitySet = new HashSet<EntityHandle>();

	// Token: 0x0400E8E6 RID: 59622
	private Dictionary<int, Dictionary<int, int>> _timeStopBulletScaleHandleMap = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x0400E8E7 RID: 59623
	private bool _stopState;

	// Token: 0x0400E8E8 RID: 59624
	private bool _lastAppliedStopMove = true;

	// Token: 0x0400E8E9 RID: 59625
	private float _lastAppliedStopScale;

	// Token: 0x0400E8EA RID: 59626
	private HashSet<EntityHandle> _timeStopBuffEntitySet = new HashSet<EntityHandle>();

	// Token: 0x0400E8EB RID: 59627
	private Dictionary<int, TimeStopInfo> _timeStopRequestInstigatorMap = new Dictionary<int, TimeStopInfo>();

	// Token: 0x0400E8EC RID: 59628
	private float _lastAppliedRequestScale = 1f;

	// Token: 0x0400E8ED RID: 59629
	[Nullable(2)]
	private static TimeController _Instance;

	// Token: 0x0200999E RID: 39326
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04030DBA RID: 200122
		[Nullable(0)]
		public static Action <0>__OnWorldDone;
	}
}
