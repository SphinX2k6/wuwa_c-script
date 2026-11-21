using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Framework;
using UnrealEngine;

// Token: 0x020010E7 RID: 4327
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class FreezeOnSightController : ControllerBase
{
	// Token: 0x0600ACBA RID: 44218 RVA: 0x0032E43C File Offset: 0x0032C63C
	protected override bool OnInit()
	{
		base.InitTickOptimize(-1, 1);
		GlobalConfigFromCsv? config = ConfigGlobalConfigFromCsvByName.GetConfig("FreezeOnSight.SearchRange", true);
		float value;
		if (config != null && float.TryParse(config.Value.Value, out value))
		{
			this.SearchRange = new float?(value);
		}
		GlobalConfigFromCsv? config2 = ConfigGlobalConfigFromCsvByName.GetConfig("FreezeOnSight.AddBuffDist", true);
		float value2;
		if (config2 != null && float.TryParse(config2.Value.Value, out value2))
		{
			this.AddBuffDist = new float?(value2);
		}
		base.PauseTick();
		return true;
	}

	// Token: 0x0600ACBB RID: 44219 RVA: 0x0032E4CC File Offset: 0x0032C6CC
	protected override void OnTick(float delta)
	{
		if (this.SearchRange == null)
		{
			return;
		}
		this.QueryMonsterResultCache.Clear();
		CreatureModel.Instance.GetEntitiesInRange(this.SearchRange.Value, EEntityTypeQuery.PasserbyNPC, this.QueryMonsterResultCache, true, false);
		double num = 3.402823466E+38;
		bool flag = false;
		float viewAngleDeg = 0f;
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		if (worldEntity == null)
		{
			Log.Instance.Error(ELogModule.World, ELogAuthor.CH, "[FreezeOnSightController] 玩家不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		CharacterActorComponent component = worldEntity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return;
		}
		global::Vector vector = new global::Vector();
		vector.DeepCopy(component.ActorLocationProxy);
		foreach (EntityHandle entityHandle in this.QueryMonsterResultCache)
		{
			WorldEntity entity = entityHandle.Entity;
			if (entity != null)
			{
				CreatureDataComponent component2 = entity.GetComponent<CreatureDataComponent>();
				if (component2 != null && component2.GetTemplateId() == 947850000)
				{
					BaseTagComponent component3 = entity.GetComponent<BaseTagComponent>();
					if (component3 != null && component3.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
					{
						CharacterActorComponent component4 = entity.GetComponent<CharacterActorComponent>();
						if (component4 != null)
						{
							global::Vector vector2 = new global::Vector();
							vector2.DeepCopy(component4.ActorLocationProxy);
							double num2 = global::Vector.Distance(vector, vector2);
							if (num2 < num)
							{
								num = num2;
								flag = this.IsBlock(component4, component);
								if (!flag)
								{
									viewAngleDeg = this.GetPlayerToMonsterViewAngleDeg(component, component4);
								}
							}
						}
					}
				}
			}
		}
		bool flag2 = this.HasTarget(num);
		bool flag3 = this.HasTarget(this.LastDistance);
		if (flag2 != flag3 || flag2)
		{
			this.ProcessAudioEvent(flag2, flag3, flag, num, viewAngleDeg);
		}
		this.LastDistance = num;
	}

	// Token: 0x0600ACBC RID: 44220 RVA: 0x0032E69C File Offset: 0x0032C89C
	private bool HasTarget(double dist)
	{
		return dist != 3.402823466E+38;
	}

	// Token: 0x0600ACBD RID: 44221 RVA: 0x0032E6B0 File Offset: 0x0032C8B0
	private void ProcessAudioEvent(bool hasTarget, bool lastHasTarget, bool isBlock, double distance, float viewAngleDeg)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		if (worldEntity != null)
		{
			BaseBuffComponent component = worldEntity.GetComponent<BaseBuffComponent>();
			float valueOrDefault = this.AddBuffDist.GetValueOrDefault(500f);
			if (hasTarget && distance < (double)valueOrDefault)
			{
				if (!component.HasBuff(640031030L, false))
				{
					Log.Instance.Info(ELogModule.World, ELogAuthor.CH, "[FreezeOnSightController] 发现目标", default(ReadOnlySpan<ValueTuple<string, object>>));
					if (component != null)
					{
						component.AddBuff(640031030L, new AddBuffParam
						{
							InstigatorId = component.CreatureDataId,
							Reason = "ActorAssistant.ControlBindingEntity"
						});
					}
				}
			}
			else if (component.HasBuff(640031030L, false))
			{
				Log.Instance.Info(ELogModule.World, ELogAuthor.CH, "[FreezeOnSightController] 失去目标", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (component != null)
				{
					component.RemoveBuff(640031030L, -1, "ActorAssistant.ControlBindingEntity", null, null, null);
				}
			}
		}
		if (hasTarget)
		{
			AudioSystem.Instance.SetRtpcValue("woodman_heartbeat", (float)Math.Min(distance, 1500.0), null);
			AudioSystem.Instance.SetRtpcValue("woodman_block", isBlock > false, null);
			AudioSystem.Instance.SetRtpcValue("woodman_azimuth", viewAngleDeg, null);
			return;
		}
		AudioSystem.Instance.SetRtpcValue("woodman_heartbeat", 1500f, null);
		AudioSystem.Instance.SetRtpcValue("woodman_block", 0f, null);
		AudioSystem.Instance.SetRtpcValue("woodman_azimuth", 0f, null);
	}

	// Token: 0x0600ACBE RID: 44222 RVA: 0x0032E878 File Offset: 0x0032CA78
	private float GetPlayerToMonsterViewAngleDeg(CharacterActorComponent playerActorComponent, CharacterActorComponent monsterActorComponent)
	{
		global::Vector inB = global::Vector.Create(playerActorComponent.ActorLocationProxy);
		global::Vector.Create(monsterActorComponent.ActorLocationProxy).Subtraction(inB, this.TmpToMonsterDir);
		this.TmpToMonsterDir.Z = 0.0;
		if (this.TmpToMonsterDir.Size() < 0.0001)
		{
			return 0f;
		}
		this.TmpToMonsterDir.Normalize(9.99999993922529E-09);
		float num = (float)MathUtils.Instance.GetAngleByVector2D(this.TmpToMonsterDir);
		float yaw = playerActorComponent.ActorRotationProxy.Yaw;
		return MathUtils.Instance.WrapAngle(num - yaw);
	}

	// Token: 0x0600ACBF RID: 44223 RVA: 0x0032E91C File Offset: 0x0032CB1C
	public void OpenFreezeOnSightGameplay()
	{
		base.ResumeTick();
		AudioSystem.Instance.PostEvent("play_gp_woodman_heartbeat_loop");
		Log.Instance.Info(ELogModule.World, ELogAuthor.CH, "开启木头人玩法", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600ACC0 RID: 44224 RVA: 0x0032E95C File Offset: 0x0032CB5C
	public void CloseFreezeOnSightGameplay()
	{
		base.PauseTick();
		AudioSystem.Instance.PostEvent("stop_gp_woodman_heartbeat_loop");
		Log.Instance.Info(ELogModule.World, ELogAuthor.CH, "关闭木头人玩法", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600ACC1 RID: 44225 RVA: 0x0032E99C File Offset: 0x0032CB9C
	public bool IsBlock(CharacterActorComponent monsterActorComponent, CharacterActorComponent playerActorComponent)
	{
		global::Vector vector = global::Vector.Create(monsterActorComponent.ActorLocationProxy);
		float halfHeight = monsterActorComponent.HalfHeight;
		vector.Z += (double)halfHeight;
		global::Vector vector2 = global::Vector.Create(playerActorComponent.ActorLocationProxy);
		float halfHeight2 = playerActorComponent.HalfHeight;
		vector2.Z += (double)halfHeight2;
		UTraceLineElement traceElement = this.GetTraceElement();
		traceElement.ActorsToIgnore.Empty(true);
		traceElement.ActorsToIgnore.Add(monsterActorComponent.Owner);
		traceElement.ActorsToIgnore.Add(playerActorComponent.Owner);
		TraceElementCommon.Instance.SetStartLocation(traceElement, vector2);
		TraceElementCommon.Instance.SetEndLocation(traceElement, vector);
		return TraceElementCommon.Instance.LineTrace(traceElement, "FreezeOnSightController.IsBlock");
	}

	// Token: 0x0600ACC2 RID: 44226 RVA: 0x0032EA54 File Offset: 0x0032CC54
	private UTraceLineElement GetTraceElement()
	{
		if (this.TraceElement != null)
		{
			return this.TraceElement;
		}
		this.TraceElement = new UTraceLineElement();
		this.TraceElement.bTraceComplex = true;
		this.TraceElement.bIgnoreSelf = true;
		this.TraceElement.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
		this.TraceElement.WorldContextObject = GlobalData.World;
		return this.TraceElement;
	}

	// Token: 0x170011DD RID: 4573
	// (get) Token: 0x0600ACC3 RID: 44227 RVA: 0x0032EAB9 File Offset: 0x0032CCB9
	public static FreezeOnSightController Instance
	{
		get
		{
			return FreezeOnSightController._Instance;
		}
	}

	// Token: 0x0600ACC4 RID: 44228 RVA: 0x0032EAC0 File Offset: 0x0032CCC0
	public static FreezeOnSightController GetOrCreateInstance()
	{
		if (FreezeOnSightController._Instance == null)
		{
			FreezeOnSightController.CreateInstance();
		}
		return FreezeOnSightController._Instance;
	}

	// Token: 0x0600ACC5 RID: 44229 RVA: 0x0032EAD4 File Offset: 0x0032CCD4
	public static bool CreateInstance()
	{
		if (FreezeOnSightController._Instance != null)
		{
			return true;
		}
		FreezeOnSightController._Instance = new FreezeOnSightController();
		return true;
	}

	// Token: 0x0600ACC6 RID: 44230 RVA: 0x0032EAEA File Offset: 0x0032CCEA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600ACC7 RID: 44231 RVA: 0x0032EAEC File Offset: 0x0032CCEC
	public static void ResetStaticDefaultValue()
	{
		FreezeOnSightController._Instance = null;
	}

	// Token: 0x0600ACC8 RID: 44232 RVA: 0x0032EAF4 File Offset: 0x0032CCF4
	static FreezeOnSightController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FreezeOnSightController.CreateStaticDefaultValue), new Action(FreezeOnSightController.ResetStaticDefaultValue));
	}

	// Token: 0x04006389 RID: 25481
	private const int FREEZE_ON_SIGHT_MONSTER_TEMPLATE_ID = 947850000;

	// Token: 0x0400638A RID: 25482
	private const int SCENE_EFFECT_BUFF_ID = 640031030;

	// Token: 0x0400638B RID: 25483
	private const string START_HEART_BEAT_AUDIO_EVENT = "play_gp_woodman_heartbeat_loop";

	// Token: 0x0400638C RID: 25484
	private const string STOP_HEART_BEAT_AUDIO_EVENT = "stop_gp_woodman_heartbeat_loop";

	// Token: 0x0400638D RID: 25485
	private const string HERAT_BEAT_DISTANCE_RTPC_EVENT = "woodman_heartbeat";

	// Token: 0x0400638E RID: 25486
	private const string HERAT_BEAT_BLOCK_RTPC_EVENT = "woodman_block";

	// Token: 0x0400638F RID: 25487
	private const string HERAT_BEAT_AZIMUTH_RTPC_EVENT = "woodman_azimuth";

	// Token: 0x04006390 RID: 25488
	private const float MAX_DISTANCE_RTPC_VALUE = 1500f;

	// Token: 0x04006391 RID: 25489
	private const float MAX_DISTANCE_ADD_BUFF = 500f;

	// Token: 0x04006392 RID: 25490
	private float? SearchRange;

	// Token: 0x04006393 RID: 25491
	private float? AddBuffDist;

	// Token: 0x04006394 RID: 25492
	private readonly List<EntityHandle> QueryMonsterResultCache = new List<EntityHandle>();

	// Token: 0x04006395 RID: 25493
	private double LastDistance = 3.402823466E+38;

	// Token: 0x04006396 RID: 25494
	[Nullable(2)]
	private UTraceLineElement TraceElement;

	// Token: 0x04006397 RID: 25495
	private global::Vector TmpToMonsterDir = global::Vector.Create();

	// Token: 0x04006398 RID: 25496
	[Nullable(2)]
	private static FreezeOnSightController _Instance;
}
