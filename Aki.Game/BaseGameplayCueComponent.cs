using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Utils;

// Token: 0x02002E79 RID: 11897
[NullableContext(1)]
[Nullable(0)]
public class BaseGameplayCueComponent : EntityComponent
{
	// Token: 0x060196D0 RID: 104144 RVA: 0x006902E1 File Offset: 0x0068E4E1
	protected override bool OnStart()
	{
		return true;
	}

	// Token: 0x060196D1 RID: 104145 RVA: 0x006902E4 File Offset: 0x0068E4E4
	protected override bool OnEnd()
	{
		foreach (long cueHandleId in this.CueContainer.Keys.ToArray<long>())
		{
			this.RemoveCueByHandle(cueHandleId);
		}
		return true;
	}

	// Token: 0x060196D2 RID: 104146 RVA: 0x0069031C File Offset: 0x0068E51C
	protected override void OnTick(float delta)
	{
		float delta2 = delta * (float)TimeUtil.Instance.Millisecond;
		foreach (GameplayCueBase gameplayCueBase in this.GetAllCurrentCueRef())
		{
			gameplayCueBase.Tick(delta2);
		}
	}

	// Token: 0x060196D3 RID: 104147 RVA: 0x00690378 File Offset: 0x0068E578
	protected override void OnAfterTick(float delta)
	{
		float delta2 = delta * (float)TimeUtil.Instance.Millisecond;
		foreach (GameplayCueBase gameplayCueBase in this.GetAllCurrentCueRef())
		{
			gameplayCueBase.AfterTick(delta2);
		}
	}

	// Token: 0x060196D4 RID: 104148 RVA: 0x006903D4 File Offset: 0x0068E5D4
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

	// Token: 0x060196D5 RID: 104149 RVA: 0x0069046C File Offset: 0x0068E66C
	public void RemoveCue(long cueId)
	{
		foreach (long cueHandleId in this.GetCueHandlesByCueId(cueId))
		{
			this.RemoveCueByHandle(cueHandleId);
		}
	}

	// Token: 0x060196D6 RID: 104150 RVA: 0x006904C0 File Offset: 0x0068E6C0
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

	// Token: 0x060196D7 RID: 104151 RVA: 0x0069050C File Offset: 0x0068E70C
	public virtual void AddCueEffectToSet(int effectViewHandle, ETimeScaleType timeScaleType, ECueHideRule hideRule)
	{
	}

	// Token: 0x060196D8 RID: 104152 RVA: 0x0069050E File Offset: 0x0068E70E
	[NullableContext(2)]
	protected virtual EntityHandle GetEntityHandle()
	{
		return null;
	}

	// Token: 0x060196D9 RID: 104153 RVA: 0x00690511 File Offset: 0x0068E711
	public IEnumerable<GameplayCueBase> GetAllCurrentCueRef()
	{
		BaseGameplayCueComponent.<GetAllCurrentCueRef>d__10 <GetAllCurrentCueRef>d__ = new BaseGameplayCueComponent.<GetAllCurrentCueRef>d__10(-2);
		<GetAllCurrentCueRef>d__.<>4__this = this;
		return <GetAllCurrentCueRef>d__;
	}

	// Token: 0x060196DA RID: 104154 RVA: 0x00690521 File Offset: 0x0068E721
	[NullableContext(2)]
	public GameplayCueBase GetCueByHandle(long cueHandleId)
	{
		return this.CueContainer.GetValueOrDefault(cueHandleId);
	}

	// Token: 0x060196DB RID: 104155 RVA: 0x00690530 File Offset: 0x0068E730
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

	// Token: 0x060196DC RID: 104156 RVA: 0x00690598 File Offset: 0x0068E798
	public void ChangeBuffHandle(long cueHandleId, IActiveBuff newBuff)
	{
		GameplayCueBase gameplayCueBase;
		if (this.CueContainer.TryGetValue(cueHandleId, out gameplayCueBase))
		{
			gameplayCueBase.ChangeBuffHandle(newBuff.Handle);
		}
	}

	// Token: 0x060196DD RID: 104157 RVA: 0x006905C4 File Offset: 0x0068E7C4
	private void GameplayCueRequest(long cueId)
	{
		GameplayCuePush gameplayCuePush = GameplayCuePush.Create();
		gameplayCuePush.CueConfigId = cueId;
		CombatNet.Instance.Send(EPushMessageId.GameplayCuePush, this.GetEntityHandle().Entity, gameplayCuePush, null, null, null);
	}

	// Token: 0x060196DE RID: 104158 RVA: 0x00690618 File Offset: 0x0068E818
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

	// Token: 0x060196DF RID: 104159 RVA: 0x0069065C File Offset: 0x0068E85C
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

	// Token: 0x060196E0 RID: 104160 RVA: 0x006906D4 File Offset: 0x0068E8D4
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

	// Token: 0x060196E1 RID: 104161 RVA: 0x00690974 File Offset: 0x0068EB74
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

	// Token: 0x060196E2 RID: 104162 RVA: 0x006909CC File Offset: 0x0068EBCC
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

	// Token: 0x060196E3 RID: 104163 RVA: 0x00690A45 File Offset: 0x0068EC45
	[NullableContext(2)]
	private void RemoveFromPriorityGroup(GameplayCueBase cueRef = null)
	{
		if (cueRef != null && cueRef.CueConfig.Group > 0)
		{
			this.CuePriorityGroup.Remove(cueRef.CueConfig.Group);
		}
	}

	// Token: 0x060196E4 RID: 104164 RVA: 0x00690A70 File Offset: 0x0068EC70
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
		default:
			return null;
		}
	}

	// Token: 0x060196E5 RID: 104165 RVA: 0x00691264 File Offset: 0x0068F464
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseGameplayCueComponent baseGameplayCueComponent = (BaseGameplayCueComponent)componentTemplate;
		return (!base.CanResetComponentProperty("CueContainer") || baseGameplayCueComponent.CueContainer == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<long, GameplayCueBase>>(this.CueContainer), "CueContainer")) && (!base.CanResetComponentProperty("CuePriorityGroup") || baseGameplayCueComponent.CuePriorityGroup == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, long>>(this.CuePriorityGroup), "CuePriorityGroup"));
	}

	// Token: 0x0400BD27 RID: 48423
	private readonly Dictionary<long, GameplayCueBase> CueContainer = new Dictionary<long, GameplayCueBase>();

	// Token: 0x0400BD28 RID: 48424
	private readonly Dictionary<int, long> CuePriorityGroup = new Dictionary<int, long>();
}
