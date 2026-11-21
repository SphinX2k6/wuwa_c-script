using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.UnopenedArea;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

// Token: 0x02002A8C RID: 10892
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class EnvironmentalPerceptionController : ControllerBase
{
	// Token: 0x0601B9CC RID: 113100 RVA: 0x00882085 File Offset: 0x00880285
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		this.CheckIsPlayerInMapPolygonStat = Stat.Create("CheckIsPlayerInMapPolygon", "", "");
		return true;
	}

	// Token: 0x0601B9CD RID: 113101 RVA: 0x008820C0 File Offset: 0x008802C0
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		if (this.TagComp != null)
		{
			this.TagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"], new BaseTagComponent.TTagSwitchedCallback(this.OnPlayerEnterFight));
		}
		this.TagComp = null;
		this.MoveComp = null;
		return true;
	}

	// Token: 0x0601B9CE RID: 113102 RVA: 0x00882126 File Offset: 0x00880326
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x0601B9CF RID: 113103 RVA: 0x0088212C File Offset: 0x0088032C
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		if (this.TagComp != null)
		{
			this.TagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"], new BaseTagComponent.TTagSwitchedCallback(this.OnPlayerEnterFight));
		}
		this.MoveComp = EntitySystem.Instance.GetComponent<CharacterMoveComponent>(newEntity.Id);
		this.TagComp = EntitySystem.Instance.GetComponent<BaseTagComponent>(newEntity.Id);
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp == null)
		{
			return;
		}
		tagComp.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"], new BaseTagComponent.TTagSwitchedCallback(this.OnPlayerEnterFight), null);
	}

	// Token: 0x0601B9D0 RID: 113104 RVA: 0x008821BF File Offset: 0x008803BF
	private void OnPlayerEnterFight(int tagId, bool tagExist)
	{
		this.IsPlayerInFight = tagExist;
	}

	// Token: 0x0601B9D1 RID: 113105 RVA: 0x008821C8 File Offset: 0x008803C8
	protected override void OnTick(float deltaTime)
	{
		this.TickRemain -= (int)(deltaTime * CharacterModel.Instance.InverseSelfCenteredTimeDilation);
		if (Global.BaseCharacter == null || this.MoveComp == null || this.MoveComp.CharacterMovement == null)
		{
			return;
		}
		if (this.MoveComp.IsMoving)
		{
			if (this.IsPlayerInFight)
			{
				this.TickRemain -= (int)(deltaTime * 16f);
			}
			else
			{
				this.TickRemain -= (int)(deltaTime * 80f);
			}
		}
		if (this.MoveComp.GetLastUpdateVelocity().Size() > 850f)
		{
			this.TickRemain = -1;
		}
		if (this.TickRemain < 0)
		{
			this.TickRemain = 8000;
			SimpleNpcController.Instance.UpdateDistanceLogic();
			this.CheckIsPlayerInMapPolygon();
		}
	}

	// Token: 0x0601B9D2 RID: 113106 RVA: 0x00882294 File Offset: 0x00880494
	private void CheckIsPlayerInMapPolygon()
	{
		if (PlotModel.Instance.IsInPlot)
		{
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter == null)
		{
			return;
		}
		CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
		if (characterActorComponent == null)
		{
			return;
		}
		if (!MapModel.Instance.IsInMapPolygon(characterActorComponent.ActorLocationProxy))
		{
			UnopenedAreaController.Instance.OnEnterUnopenedArea();
			return;
		}
		UnopenedAreaController.Instance.OnExitUnopenedArea();
	}

	// Token: 0x0601B9D3 RID: 113107 RVA: 0x008822EC File Offset: 0x008804EC
	public void InitializeEnvironment()
	{
		ushort gridWidth = 3000;
		ushort gridHeight = 3000;
		TMap<FName, uint> tmap = new TMap<FName, uint>();
		for (int i = 0; i < CreatureModel.globalEntityTypePerceptionType.Length; i++)
		{
			tmap.Add(EntityHelperConstants.GlobalEntityTypeQueryName[i], (uint)CreatureModel.globalEntityTypePerceptionType[i]);
		}
		tmap.Add(new FName("CustomStabilizeLow"), 2U);
		tmap.Add(new FName("AlwaysTickHotFix"), 7U);
		UKuroPerceptionInterface.InitializeEnvironment(gridWidth, gridHeight, tmap, true, true);
	}

	// Token: 0x0601B9D4 RID: 113108 RVA: 0x00882362 File Offset: 0x00880562
	private static PlayerPerceptionEvent PerceptionEventCreator()
	{
		return new PlayerPerceptionEvent();
	}

	// Token: 0x0601B9D5 RID: 113109 RVA: 0x0088236C File Offset: 0x0088056C
	public PlayerPerceptionEvent CreatePlayerPerceptionEvent()
	{
		PlayerPerceptionEvent playerPerceptionEvent = this.PerceptionEventPool.Get();
		if (playerPerceptionEvent == null)
		{
			return this.PerceptionEventPool.Create();
		}
		return playerPerceptionEvent;
	}

	// Token: 0x0601B9D6 RID: 113110 RVA: 0x00882395 File Offset: 0x00880595
	[NullableContext(2)]
	public void DestroyPlayerPerceptionEvent(PlayerPerceptionEvent @event)
	{
		if (@event == null)
		{
			return;
		}
		@event.Clear();
		this.PerceptionEventPool.Put(@event);
	}

	// Token: 0x0601B9D7 RID: 113111 RVA: 0x008823AE File Offset: 0x008805AE
	private static PerceptionRange PerceptionRangeCreator()
	{
		return new PerceptionRange();
	}

	// Token: 0x0601B9D8 RID: 113112 RVA: 0x008823B8 File Offset: 0x008805B8
	public PerceptionRange CreatePerceptionRange()
	{
		PerceptionRange perceptionRange = this.PerceptionRangePool.Get();
		if (perceptionRange == null)
		{
			return this.PerceptionRangePool.Create();
		}
		return perceptionRange;
	}

	// Token: 0x0601B9D9 RID: 113113 RVA: 0x008823E1 File Offset: 0x008805E1
	[NullableContext(2)]
	public void DestroyPerceptionRange(PerceptionRange range)
	{
		if (range == null)
		{
			return;
		}
		range.Clear();
		this.PerceptionRangePool.Put(range);
	}

	// Token: 0x17002CA7 RID: 11431
	// (get) Token: 0x0601B9DA RID: 113114 RVA: 0x008823FA File Offset: 0x008805FA
	public static EnvironmentalPerceptionController Instance
	{
		get
		{
			return EnvironmentalPerceptionController._Instance;
		}
	}

	// Token: 0x0601B9DB RID: 113115 RVA: 0x00882401 File Offset: 0x00880601
	public static EnvironmentalPerceptionController GetOrCreateInstance()
	{
		if (EnvironmentalPerceptionController._Instance == null)
		{
			EnvironmentalPerceptionController.CreateInstance();
		}
		return EnvironmentalPerceptionController._Instance;
	}

	// Token: 0x0601B9DC RID: 113116 RVA: 0x00882415 File Offset: 0x00880615
	public static bool CreateInstance()
	{
		if (EnvironmentalPerceptionController._Instance != null)
		{
			return true;
		}
		EnvironmentalPerceptionController._Instance = new EnvironmentalPerceptionController();
		return true;
	}

	// Token: 0x0601B9DD RID: 113117 RVA: 0x0088242B File Offset: 0x0088062B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B9DE RID: 113118 RVA: 0x0088242D File Offset: 0x0088062D
	public static void ResetStaticDefaultValue()
	{
		EnvironmentalPerceptionController._Instance = null;
	}

	// Token: 0x0601B9DF RID: 113119 RVA: 0x00882435 File Offset: 0x00880635
	static EnvironmentalPerceptionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EnvironmentalPerceptionController.CreateStaticDefaultValue), new Action(EnvironmentalPerceptionController.ResetStaticDefaultValue));
	}

	// Token: 0x0601B9E0 RID: 113120 RVA: 0x00882454 File Offset: 0x00880654
	public EnvironmentalPerceptionController()
	{
		int capacity = 32;
		Func<PlayerPerceptionEvent> creator;
		if ((creator = EnvironmentalPerceptionController.<>O.<0>__PerceptionEventCreator) == null)
		{
			creator = (EnvironmentalPerceptionController.<>O.<0>__PerceptionEventCreator = new Func<PlayerPerceptionEvent>(EnvironmentalPerceptionController.PerceptionEventCreator));
		}
		this.PerceptionEventPool = new Pool<PlayerPerceptionEvent>(capacity, creator, null);
		int capacity2 = 32;
		Func<PerceptionRange> creator2;
		if ((creator2 = EnvironmentalPerceptionController.<>O.<1>__PerceptionRangeCreator) == null)
		{
			creator2 = (EnvironmentalPerceptionController.<>O.<1>__PerceptionRangeCreator = new Func<PerceptionRange>(EnvironmentalPerceptionController.PerceptionRangeCreator));
		}
		this.PerceptionRangePool = new Pool<PerceptionRange>(capacity2, creator2, null);
		base..ctor();
	}

	// Token: 0x0400EE96 RID: 61078
	private const int TICK_INTERNVAL = 8000;

	// Token: 0x0400EE97 RID: 61079
	private const int TICK_DAMPING_RATIO = 80;

	// Token: 0x0400EE98 RID: 61080
	private const int TICK_DAMPING_RATIO_INFIGHT = 16;

	// Token: 0x0400EE99 RID: 61081
	private const int FORCE_UPDATE_SPEED = 850;

	// Token: 0x0400EE9A RID: 61082
	private const int PERCEPTION_EVENT_POOL_CAPACITY = 32;

	// Token: 0x0400EE9B RID: 61083
	private int TickRemain = 8000;

	// Token: 0x0400EE9C RID: 61084
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400EE9D RID: 61085
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400EE9E RID: 61086
	[Nullable(2)]
	private Stat CheckIsPlayerInMapPolygonStat;

	// Token: 0x0400EE9F RID: 61087
	private bool IsPlayerInFight;

	// Token: 0x0400EEA0 RID: 61088
	private readonly Pool<PlayerPerceptionEvent> PerceptionEventPool;

	// Token: 0x0400EEA1 RID: 61089
	private readonly Pool<PerceptionRange> PerceptionRangePool;

	// Token: 0x0400EEA2 RID: 61090
	[Nullable(2)]
	private static EnvironmentalPerceptionController _Instance;

	// Token: 0x02008BD3 RID: 35795
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402C492 RID: 181394
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<PlayerPerceptionEvent> <0>__PerceptionEventCreator;

		// Token: 0x0402C493 RID: 181395
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<PerceptionRange> <1>__PerceptionRangeCreator;
	}
}
