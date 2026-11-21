using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.NewWorld.Pawn.Component;
using Google.Protobuf;

// Token: 0x02002A5C RID: 10844
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class TimeController : ControllerBase
{
	// Token: 0x0601B7E9 RID: 112617 RVA: 0x00878640 File Offset: 0x00876840
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

	// Token: 0x0601B7EA RID: 112618 RVA: 0x00878695 File Offset: 0x00876895
	protected override void OnTick(float delta)
	{
	}

	// Token: 0x0601B7EB RID: 112619 RVA: 0x00878698 File Offset: 0x00876898
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

	// Token: 0x0601B7EC RID: 112620 RVA: 0x00878710 File Offset: 0x00876910
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

	// Token: 0x0601B7ED RID: 112621 RVA: 0x00878768 File Offset: 0x00876968
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

	// Token: 0x0601B7EE RID: 112622 RVA: 0x008788D0 File Offset: 0x00876AD0
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

	// Token: 0x0601B7EF RID: 112623 RVA: 0x00878914 File Offset: 0x00876B14
	public void TimeCheckRequest()
	{
		if (!Net.Instance.IsServerConnected())
		{
			return;
		}
		TimeCheckRequest timeCheckRequest = new TimeCheckRequest();
		timeCheckRequest.ClientTime = (long)Time.Instance.WorldTime;
		timeCheckRequest.Dilation = Time.Instance.TimeDilation;
		timeCheckRequest.RDilation = Time.Instance.FlowTimeDilation;
		Net.Instance.Call(ERequestMessageId.TimeCheckRequest, timeCheckRequest, new Action<IMessage, Net.CallbackStatus>(this.<TimeCheckRequest>g__Response|14_0), 0);
	}

	// Token: 0x0601B7F0 RID: 112624 RVA: 0x00878982 File Offset: 0x00876B82
	private static float NormalizeTimeScale(float timeScale)
	{
		if (timeScale <= 0f)
		{
			return 0f;
		}
		return MathUtils.Instance.Clamp(timeScale, 0f, 1f);
	}

	// Token: 0x0601B7F1 RID: 112625 RVA: 0x008789A8 File Offset: 0x00876BA8
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

	// Token: 0x0601B7F2 RID: 112626 RVA: 0x00878A24 File Offset: 0x00876C24
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

	// Token: 0x0601B7F3 RID: 112627 RVA: 0x00878AAE File Offset: 0x00876CAE
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

	// Token: 0x0601B7F4 RID: 112628 RVA: 0x00878AF0 File Offset: 0x00876CF0
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

	// Token: 0x0601B7F5 RID: 112629 RVA: 0x00878C24 File Offset: 0x00876E24
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

	// Token: 0x0601B7F6 RID: 112630 RVA: 0x00878C84 File Offset: 0x00876E84
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

	// Token: 0x0601B7F7 RID: 112631 RVA: 0x00878DD4 File Offset: 0x00876FD4
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

	// Token: 0x0601B7F8 RID: 112632 RVA: 0x00878E18 File Offset: 0x00877018
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

	// Token: 0x0601B7F9 RID: 112633 RVA: 0x00878F04 File Offset: 0x00877104
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

	// Token: 0x0601B7FA RID: 112634 RVA: 0x00878F8C File Offset: 0x0087718C
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

	// Token: 0x0601B7FB RID: 112635 RVA: 0x00878FC0 File Offset: 0x008771C0
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

	// Token: 0x0601B7FC RID: 112636 RVA: 0x00878FF4 File Offset: 0x008771F4
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

	// Token: 0x0601B7FD RID: 112637 RVA: 0x00879034 File Offset: 0x00877234
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

	// Token: 0x0601B7FE RID: 112638 RVA: 0x008790BE File Offset: 0x008772BE
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

	// Token: 0x0601B7FF RID: 112639 RVA: 0x00879100 File Offset: 0x00877300
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

	// Token: 0x0601B800 RID: 112640 RVA: 0x00879150 File Offset: 0x00877350
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

	// Token: 0x0601B801 RID: 112641 RVA: 0x00879244 File Offset: 0x00877444
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

	// Token: 0x17002C85 RID: 11397
	// (get) Token: 0x0601B802 RID: 112642 RVA: 0x008792F8 File Offset: 0x008774F8
	public static TimeController Instance
	{
		get
		{
			return TimeController._Instance;
		}
	}

	// Token: 0x0601B803 RID: 112643 RVA: 0x008792FF File Offset: 0x008774FF
	public static TimeController GetOrCreateInstance()
	{
		if (TimeController._Instance == null)
		{
			TimeController.CreateInstance();
		}
		return TimeController._Instance;
	}

	// Token: 0x0601B804 RID: 112644 RVA: 0x00879313 File Offset: 0x00877513
	public static bool CreateInstance()
	{
		if (TimeController._Instance != null)
		{
			return true;
		}
		TimeController._Instance = new TimeController();
		return true;
	}

	// Token: 0x0601B805 RID: 112645 RVA: 0x00879329 File Offset: 0x00877529
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B806 RID: 112646 RVA: 0x0087932B File Offset: 0x0087752B
	public static void ResetStaticDefaultValue()
	{
		TimeController._Instance = null;
	}

	// Token: 0x0601B807 RID: 112647 RVA: 0x00879333 File Offset: 0x00877533
	static TimeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimeController.CreateStaticDefaultValue), new Action(TimeController.ResetStaticDefaultValue));
	}

	// Token: 0x0601B809 RID: 112649 RVA: 0x008793B0 File Offset: 0x008775B0
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

	// Token: 0x0400ED93 RID: 60819
	private const int TIME_STOP_DISTANCE = 20000;

	// Token: 0x0400ED94 RID: 60820
	private const string ABSOLUTE_TIME_STOP_TARGET_LOCK = "ANS AbsoluteTimeStop Other";

	// Token: 0x0400ED95 RID: 60821
	private const string ABSOLUTE_TIME_STOP_SELF_LOCK = "ANS AbsoluteTimeStop Self";

	// Token: 0x0400ED96 RID: 60822
	private const string ABSOLUTE_TIME_STOP_TARGET_SCALE_LOCK = "ANS AbsoluteTimeStop Other Scale";

	// Token: 0x0400ED97 RID: 60823
	private const string TIME_STOP_REQUEST_SELF_LOCK = "TIME_STOP_REQUEST_SELF_LOCK";

	// Token: 0x0400ED98 RID: 60824
	private double _predictedServerCombatTimeOffset;

	// Token: 0x0400ED99 RID: 60825
	private double _predictedServerStopTimeOffset;

	// Token: 0x0400ED9A RID: 60826
	[Nullable(2)]
	private TimerHandle _timeCheckTimerId;

	// Token: 0x0400ED9B RID: 60827
	private Dictionary<int, TimeStopInfo> _instigatorList = new Dictionary<int, TimeStopInfo>();

	// Token: 0x0400ED9C RID: 60828
	private HashSet<EntityHandle> _timeStopAnimEntitySet = new HashSet<EntityHandle>();

	// Token: 0x0400ED9D RID: 60829
	private Dictionary<int, Dictionary<int, int>> _timeStopBulletScaleHandleMap = new Dictionary<int, Dictionary<int, int>>();

	// Token: 0x0400ED9E RID: 60830
	private bool _stopState;

	// Token: 0x0400ED9F RID: 60831
	private bool _lastAppliedStopMove = true;

	// Token: 0x0400EDA0 RID: 60832
	private float _lastAppliedStopScale;

	// Token: 0x0400EDA1 RID: 60833
	private HashSet<EntityHandle> _timeStopBuffEntitySet = new HashSet<EntityHandle>();

	// Token: 0x0400EDA2 RID: 60834
	private Dictionary<int, TimeStopInfo> _timeStopRequestInstigatorMap = new Dictionary<int, TimeStopInfo>();

	// Token: 0x0400EDA3 RID: 60835
	private float _lastAppliedRequestScale = 1f;

	// Token: 0x0400EDA4 RID: 60836
	[Nullable(2)]
	private static TimeController _Instance;

	// Token: 0x02008BB8 RID: 35768
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402C43D RID: 181309
		[Nullable(0)]
		public static Action <0>__OnWorldDone;
	}
}
