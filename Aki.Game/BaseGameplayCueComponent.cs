using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Utils;

// Token: 0x020023CB RID: 9163
[NullableContext(1)]
[Nullable(0)]
public class BaseGameplayCueComponent : EntityComponent
{
	// Token: 0x06016FA0 RID: 94112 RVA: 0x006B66D8 File Offset: 0x006B48D8
	protected override bool OnStart()
	{
		return true;
	}

	// Token: 0x06016FA1 RID: 94113 RVA: 0x006B66DC File Offset: 0x006B48DC
	protected override bool OnEnd()
	{
		long[] array = new long[this.CueContainer.Count];
		this.CueContainer.Keys.CopyTo(array, 0);
		foreach (long cueHandleId in array)
		{
			this.RemoveCueByHandle(cueHandleId);
		}
		return true;
	}

	// Token: 0x06016FA2 RID: 94114 RVA: 0x006B6728 File Offset: 0x006B4928
	protected override void OnTick(float delta)
	{
		float delta2 = delta * (float)TimeUtil.Instance.Millisecond;
		foreach (GameplayCueBase gameplayCueBase in this.GetAllCurrentCueRef())
		{
			gameplayCueBase.Tick(delta2);
		}
	}

	// Token: 0x06016FA3 RID: 94115 RVA: 0x006B6784 File Offset: 0x006B4984
	protected override void OnAfterTick(float delta)
	{
		float delta2 = delta * (float)TimeUtil.Instance.Millisecond;
		foreach (GameplayCueBase gameplayCueBase in this.GetAllCurrentCueRef())
		{
			gameplayCueBase.AfterTick(delta2);
		}
	}

	// Token: 0x06016FA4 RID: 94116 RVA: 0x006B67E0 File Offset: 0x006B49E0
	public int AddCue(long cueId, GameplayCueParam? cueParam = null)
	{
		GameplayCueBase gameplayCueBase = this.CreateGameplayCueInner(cueId, cueParam);
		if (gameplayCueBase == null)
		{
			return 0;
		}
		if (cueParam != null && cueParam.GetValueOrDefault().Instant)
		{
			return -1;
		}
		int num = GameplayCueController.GenerateHandle();
		GameplayCueBase gameplayCueBase2 = gameplayCueBase;
		long cueHandleId = (long)num;
		int? num2;
		if (cueParam == null)
		{
			num2 = null;
		}
		else
		{
			IActiveBuff buff = cueParam.GetValueOrDefault().Buff;
			num2 = ((buff != null) ? new int?(buff.Handle) : null);
		}
		int? num3 = num2;
		gameplayCueBase2.Add(cueHandleId, num3.GetValueOrDefault());
		this.CueContainer[(long)num] = gameplayCueBase;
		return num;
	}

	// Token: 0x06016FA5 RID: 94117 RVA: 0x006B6878 File Offset: 0x006B4A78
	public void RemoveCue(long cueId)
	{
		foreach (long cueHandleId in this.GetCueHandlesByCueId(cueId))
		{
			this.RemoveCueByHandle(cueHandleId);
		}
	}

	// Token: 0x06016FA6 RID: 94118 RVA: 0x006B68CC File Offset: 0x006B4ACC
	public void RemoveCueByHandle(long cueHandleId)
	{
		GameplayCueBase gameplayCueBase;
		if (!this.CueContainer.TryGetValue(cueHandleId, out gameplayCueBase))
		{
			return;
		}
		gameplayCueBase.Remove(cueHandleId);
		if (gameplayCueBase.CueHandleIds.Count == 0)
		{
			gameplayCueBase.Destroy();
			this.RemoveFromPriorityGroup(gameplayCueBase);
		}
		this.CueContainer.Remove(cueHandleId);
	}

	// Token: 0x06016FA7 RID: 94119 RVA: 0x006B6918 File Offset: 0x006B4B18
	public virtual void AddCueEffectToSet(int effectViewHandle, ETimeScaleType timeScaleType, ECueHideRule hideRule)
	{
	}

	// Token: 0x06016FA8 RID: 94120 RVA: 0x006B691A File Offset: 0x006B4B1A
	[NullableContext(2)]
	protected virtual EntityHandle GetEntityHandle()
	{
		return null;
	}

	// Token: 0x06016FA9 RID: 94121 RVA: 0x006B691D File Offset: 0x006B4B1D
	public IEnumerable<GameplayCueBase> GetAllCurrentCueRef()
	{
		BaseGameplayCueComponent.<GetAllCurrentCueRef>d__10 <GetAllCurrentCueRef>d__ = new BaseGameplayCueComponent.<GetAllCurrentCueRef>d__10(-2);
		<GetAllCurrentCueRef>d__.<>4__this = this;
		return <GetAllCurrentCueRef>d__;
	}

	// Token: 0x06016FAA RID: 94122 RVA: 0x006B692D File Offset: 0x006B4B2D
	[NullableContext(2)]
	public GameplayCueBase GetCueByHandle(long cueHandleId)
	{
		return this.CueContainer.GetValueOrDefault(cueHandleId);
	}

	// Token: 0x06016FAB RID: 94123 RVA: 0x006B693C File Offset: 0x006B4B3C
	[NullableContext(2)]
	public GameplayCueBase GetCueByCueId(long cueId)
	{
		foreach (GameplayCueBase gameplayCueBase in this.CueContainer.Values)
		{
			if (gameplayCueBase.CueConfig.Id == cueId)
			{
				return gameplayCueBase;
			}
		}
		return null;
	}

	// Token: 0x06016FAC RID: 94124 RVA: 0x006B69A4 File Offset: 0x006B4BA4
	public void ChangeBuffHandle(long cueHandleId, IActiveBuff newBuff)
	{
		GameplayCueBase gameplayCueBase;
		if (this.CueContainer.TryGetValue(cueHandleId, out gameplayCueBase))
		{
			gameplayCueBase.ChangeBuffHandle(newBuff.Handle);
		}
	}

	// Token: 0x06016FAD RID: 94125 RVA: 0x006B69D0 File Offset: 0x006B4BD0
	private void GameplayCueRequest(long cueId)
	{
		GameplayCuePush gameplayCuePush = GameplayCuePush.Create();
		gameplayCuePush.CueConfigId = cueId;
		CombatNet.Instance.Send(EPushMessageId.GameplayCuePush, this.GetEntityHandle().Entity, gameplayCuePush, null, null, null);
	}

	// Token: 0x06016FAE RID: 94126 RVA: 0x006B6A24 File Offset: 0x006B4C24
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.GameplayCueNotify, true, false)]
	public static void GameplayCueNotify(Entity entity, [Nullable(1)] GameplayCueNotify data, CombatCommon combatCommon = null)
	{
		object obj = (entity != null) ? entity.GetComponent<CharacterGameplayCueComponent>() : null;
		long cueConfigId = data.CueConfigId;
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.AddCue(cueConfigId, new GameplayCueParam?(new GameplayCueParam
		{
			Instant = true
		}));
	}

	// Token: 0x06016FAF RID: 94127 RVA: 0x006B6A68 File Offset: 0x006B4C68
	private List<long> GetCueHandlesByCueId(long cueId)
	{
		List<long> list = new List<long>();
		foreach (KeyValuePair<long, GameplayCueBase> keyValuePair in this.CueContainer)
		{
			long num;
			GameplayCueBase gameplayCueBase;
			keyValuePair.Deconstruct(out num, out gameplayCueBase);
			long item = num;
			if (gameplayCueBase.CueConfig.Id == cueId)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06016FB0 RID: 94128 RVA: 0x006B6AE0 File Offset: 0x006B4CE0
	[NullableContext(2)]
	private unsafe GameplayCueBase CreateGameplayCueInner(long cueId, GameplayCueParam? cueParam = null)
	{
		GameplayCue? configById = GameplayCueController.GetConfigById(cueId);
		if (configById == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Cue;
			Entity entity = base.Entity;
			string message = "Cue特效表不存在CueId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CueId", cueId);
			instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		GameplayCue valueOrDefault = configById.GetValueOrDefault();
		if (!this.IsPriorityGroupSatisfied(valueOrDefault))
		{
			return null;
		}
		IActiveBuff buff = (cueParam != null) ? cueParam.GetValueOrDefault().Buff : null;
		bool flag2 = cueParam != null && cueParam.GetValueOrDefault().Instant;
		ValueTuple<Func<GameplayCueBase>, bool>? gameplayCueClass = BaseGameplayCueComponent.GetGameplayCueClass(valueOrDefault, flag2);
		if (gameplayCueClass != null)
		{
			ValueTuple<Func<GameplayCueBase>, bool> valueOrDefault2 = gameplayCueClass.GetValueOrDefault();
			GameplayCueBase gameplayCueBase = this.GetCueByCueId(cueId);
			if (gameplayCueBase == null || !valueOrDefault2.Item2)
			{
				Func<GameplayCueBase> item = valueOrDefault2.Item1;
				GameplayCueParam gameplayCueParam = default(GameplayCueParam);
				gameplayCueParam.CueConfig = valueOrDefault;
				gameplayCueParam.EntityHandle = this.GetEntityHandle();
				gameplayCueParam.CueComp = this;
				gameplayCueParam.Buff = buff;
				gameplayCueParam.Instant = flag2;
				gameplayCueParam.BeginCallback = ((cueParam != null) ? cueParam.GetValueOrDefault().BeginCallback : null);
				gameplayCueParam.EndCallback = ((cueParam != null) ? cueParam.GetValueOrDefault().EndCallback : null);
				gameplayCueParam.Instigator = ((cueParam != null) ? cueParam.GetValueOrDefault().Instigator : null);
				gameplayCueParam.SocketNameOverride = ((cueParam != null) ? cueParam.GetValueOrDefault().SocketNameOverride : null);
				gameplayCueParam.RelativePositionOverride = ((cueParam != null) ? cueParam.GetValueOrDefault().RelativePositionOverride : null);
				gameplayCueParam.RelativeRotationOverride = ((cueParam != null) ? cueParam.GetValueOrDefault().RelativeRotationOverride : null);
				gameplayCueParam.ScaleOverride = ((cueParam != null) ? cueParam.GetValueOrDefault().ScaleOverride : null);
				gameplayCueBase = GameplayCueBase.Spawn(item, gameplayCueParam);
				this.AddToPriorityGroup(valueOrDefault);
			}
			bool flag3;
			if (cueParam == null)
			{
				flag3 = false;
			}
			else
			{
				GameplayCueParam gameplayCueParam = cueParam.GetValueOrDefault();
				flag3 = gameplayCueParam.Sync.GetValueOrDefault();
			}
			if (flag3)
			{
				this.GameplayCueRequest(cueId);
			}
			return gameplayCueBase;
		}
		CombatLog instance2 = CombatLog.Instance;
		CombatLog.EDebugModule flag4 = CombatLog.EDebugModule.Cue;
		Entity entity2 = base.Entity;
		string message2 = "不存在这种Cue特效类型";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", cueId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Cue类型", valueOrDefault.CueType);
		instance2.Error(flag4, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return null;
	}

	// Token: 0x06016FB1 RID: 94129 RVA: 0x006B6D80 File Offset: 0x006B4F80
	private bool IsPriorityGroupSatisfied(GameplayCue cueConfig)
	{
		if (cueConfig.Group <= 0)
		{
			return true;
		}
		long cueId;
		if (!this.CuePriorityGroup.TryGetValue(cueConfig.Group, out cueId))
		{
			return true;
		}
		GameplayCueBase cueByCueId = this.GetCueByCueId(cueId);
		return cueByCueId == null || cueByCueId.CueConfig.Priority <= cueConfig.Priority;
	}

	// Token: 0x06016FB2 RID: 94130 RVA: 0x006B6DD8 File Offset: 0x006B4FD8
	private void AddToPriorityGroup(GameplayCue cueConfig)
	{
		if (cueConfig.Group <= 0)
		{
			return;
		}
		long num;
		if (this.CuePriorityGroup.TryGetValue(cueConfig.Group, out num))
		{
			if (num == cueConfig.Id)
			{
				return;
			}
			GameplayCueBase cueByCueId = this.GetCueByCueId(num);
			if (cueByCueId != null && cueByCueId.CueConfig.Priority > cueConfig.Priority)
			{
				return;
			}
			this.RemoveCue(num);
		}
		this.CuePriorityGroup[cueConfig.Group] = cueConfig.Id;
	}

	// Token: 0x06016FB3 RID: 94131 RVA: 0x006B6E51 File Offset: 0x006B5051
	[NullableContext(2)]
	private void RemoveFromPriorityGroup(GameplayCueBase cueRef = null)
	{
		if (cueRef != null && cueRef.CueConfig.Group > 0)
		{
			this.CuePriorityGroup.Remove(cueRef.CueConfig.Group);
		}
	}

	// Token: 0x06016FB4 RID: 94132 RVA: 0x006B6E7C File Offset: 0x006B507C
	[return: TupleElementNames(new string[]
	{
		"SpawnArgs",
		"IsSingleInstance"
	})]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private static ValueTuple<Func<GameplayCueBase>, bool>? GetGameplayCueClass(in GameplayCue cueConfig, bool isInstant)
	{
		GameplayCue gameplayCue = cueConfig;
		switch (gameplayCue.CueType)
		{
		case 0:
			gameplayCue = cueConfig;
			if (gameplayCue.BSoftFollow)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueFollow(), GameplayCueBase.IsSingleInstance()));
			}
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueEffect(), GameplayCueBase.IsSingleInstance()));
		case 1:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueMaterial(), GameplayCueBase.IsSingleInstance()));
		case 2:
		case 4:
		case 14:
		case 20:
		case 22:
		case 24:
		case 37:
		case 38:
		case 39:
			if (!isInstant)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueUIEffect(), GameplayCueUIEffect.IsSingleInstance()));
			}
			return null;
		case 3:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueMoveSpline(), GameplayCueBase.IsSingleInstance()));
		case 5:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueUIEffect(), GameplayCueUIEffect.IsSingleInstance()));
		case 6:
			if (!isInstant)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueBeam(), GameplayCueBeam.IsSingleInstance()));
			}
			return null;
		case 7:
			if (!isInstant)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueHookUp(), GameplayCueBase.IsSingleInstance()));
			}
			return null;
		case 8:
			if (!isInstant)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueFixHook(), GameplayCueBase.IsSingleInstance()));
			}
			return null;
		case 9:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueCameraEffect(), GameplayCueBase.IsSingleInstance()));
		case 10:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueFromSummoned(), GameplayCueBase.IsSingleInstance()));
		case 11:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueHideMesh(), GameplayCueBase.IsSingleInstance()));
		case 12:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueHideBone(), GameplayCueBase.IsSingleInstance()));
		case 13:
			if (!isInstant)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueManipulateInteract(), GameplayCueBase.IsSingleInstance()));
			}
			return null;
		case 15:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueHitEffect(), GameplayCueBase.IsSingleInstance()));
		case 16:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueSkillTargetBeam(), GameplayCueBase.IsSingleInstance()));
		case 17:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueAnimBeam(), GameplayCueBase.IsSingleInstance()));
		case 18:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueTraceRay(), GameplayCueBase.IsSingleInstance()));
		case 19:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueSkinDamage(), GameplayCueBase.IsSingleInstance()));
		case 21:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueAudioEvent(), GameplayCueBase.IsSingleInstance()));
		case 23:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GamePlayCueEffectNiagara(), GameplayCueBase.IsSingleInstance()));
		case 25:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueCharacterAudioEvent(), GameplayCueBase.IsSingleInstance()));
		case 26:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueGhost(), GameplayCueBase.IsSingleInstance()));
		case 27:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueReference(), GameplayCueBase.IsSingleInstance()));
		case 28:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueRtpc(), GameplayCueBase.IsSingleInstance()));
		case 29:
			if (!isInstant)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueMotorcycleFixHook(), GameplayCueBase.IsSingleInstance()));
			}
			return null;
		case 30:
			if (!isInstant)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueMotorcyclePullCollection(), GameplayCueBase.IsSingleInstance()));
			}
			return null;
		case 31:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueAdjacent(), GameplayCueBase.IsSingleInstance()));
		case 32:
			if (!isInstant)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueRopeVerletPhysics(), GameplayCueRopeVerletPhysics.IsSingleInstance()));
			}
			return null;
		case 33:
			if (!isInstant)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueRopeEffectComponent(), GameplayCueRopeEffectComponent.IsSingleInstance()));
			}
			return null;
		case 34:
			if (!isInstant)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueMonsterBeam(), GameplayCueBeam.IsSingleInstance()));
			}
			return null;
		case 35:
			if (!isInstant)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueMotorcycleAssemble(), GameplayCueBase.IsSingleInstance()));
			}
			return null;
		case 36:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueTargetEffect(), GameplayCueBase.IsSingleInstance()));
		case 40:
			if (!isInstant)
			{
				return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueArcRope(), GameplayCueArcRope.IsSingleInstance()));
			}
			return null;
		case 41:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueFall(), GameplayCueBase.IsSingleInstance()));
		case 42:
			return new ValueTuple<Func<GameplayCueBase>, bool>?(new ValueTuple<Func<GameplayCueBase>, bool>(() => new GameplayCueTrailChain(), GameplayCueBase.IsSingleInstance()));
		default:
			return null;
		}
	}

	// Token: 0x06016FB5 RID: 94133 RVA: 0x006B76A0 File Offset: 0x006B58A0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseGameplayCueComponent baseGameplayCueComponent = (BaseGameplayCueComponent)componentTemplate;
		return (baseGameplayCueComponent.CueContainer == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.CueContainer), "CueContainer")) && (baseGameplayCueComponent.CuePriorityGroup == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.CuePriorityGroup), "CuePriorityGroup"));
	}

	// Token: 0x17002379 RID: 9081
	// (get) Token: 0x06016FB6 RID: 94134 RVA: 0x006B7704 File Offset: 0x006B5904
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700237A RID: 9082
	// (get) Token: 0x06016FB7 RID: 94135 RVA: 0x006B7707 File Offset: 0x006B5907
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700237B RID: 9083
	// (get) Token: 0x06016FB8 RID: 94136 RVA: 0x006B770A File Offset: 0x006B590A
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700237C RID: 9084
	// (get) Token: 0x06016FB9 RID: 94137 RVA: 0x006B770D File Offset: 0x006B590D
	public override bool NeedAfterTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C0BE RID: 49342
	private readonly Dictionary<long, GameplayCueBase> CueContainer = new Dictionary<long, GameplayCueBase>();

	// Token: 0x0400C0BF RID: 49343
	private readonly Dictionary<int, long> CuePriorityGroup = new Dictionary<int, long>();
}
