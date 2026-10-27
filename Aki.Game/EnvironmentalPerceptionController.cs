using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.UnopenedArea;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

// Token: 0x02003517 RID: 13591
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class EnvironmentalPerceptionController : ControllerBase
{
	// Token: 0x0601DCB2 RID: 122034 RVA: 0x00859ADD File Offset: 0x00857CDD
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		this.CheckIsPlayerInMapPolygonStat = Stat.Create("CheckIsPlayerInMapPolygon", "", "");
		return true;
	}

	// Token: 0x0601DCB3 RID: 122035 RVA: 0x00859B18 File Offset: 0x00857D18
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

	// Token: 0x0601DCB4 RID: 122036 RVA: 0x00859B7E File Offset: 0x00857D7E
	protected override bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x0601DCB5 RID: 122037 RVA: 0x00859B84 File Offset: 0x00857D84
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

	// Token: 0x0601DCB6 RID: 122038 RVA: 0x00859C17 File Offset: 0x00857E17
	private void OnPlayerEnterFight(int tagId, bool tagExist)
	{
		this.IsPlayerInFight = tagExist;
	}

	// Token: 0x0601DCB7 RID: 122039 RVA: 0x00859C20 File Offset: 0x00857E20
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

	// Token: 0x0601DCB8 RID: 122040 RVA: 0x00859CEC File Offset: 0x00857EEC
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

	// Token: 0x0601DCB9 RID: 122041 RVA: 0x00859D44 File Offset: 0x00857F44
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

	// Token: 0x0601DCBA RID: 122042 RVA: 0x00859DBA File Offset: 0x00857FBA
	private static PlayerPerceptionEvent PerceptionEventCreator()
	{
		return new PlayerPerceptionEvent();
	}

	// Token: 0x0601DCBB RID: 122043 RVA: 0x00859DC4 File Offset: 0x00857FC4
	public PlayerPerceptionEvent CreatePlayerPerceptionEvent()
	{
		PlayerPerceptionEvent playerPerceptionEvent = this.PerceptionEventPool.Get();
		if (playerPerceptionEvent == null)
		{
			return this.PerceptionEventPool.Create();
		}
		return playerPerceptionEvent;
	}

	// Token: 0x0601DCBC RID: 122044 RVA: 0x00859DED File Offset: 0x00857FED
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

	// Token: 0x0601DCBD RID: 122045 RVA: 0x00859E06 File Offset: 0x00858006
	private static PerceptionRange PerceptionRangeCreator()
	{
		return new PerceptionRange();
	}

	// Token: 0x0601DCBE RID: 122046 RVA: 0x00859E10 File Offset: 0x00858010
	public PerceptionRange CreatePerceptionRange()
	{
		PerceptionRange perceptionRange = this.PerceptionRangePool.Get();
		if (perceptionRange == null)
		{
			return this.PerceptionRangePool.Create();
		}
		return perceptionRange;
	}

	// Token: 0x0601DCBF RID: 122047 RVA: 0x00859E39 File Offset: 0x00858039
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

	// Token: 0x1700290E RID: 10510
	// (get) Token: 0x0601DCC0 RID: 122048 RVA: 0x00859E52 File Offset: 0x00858052
	public static EnvironmentalPerceptionController Instance
	{
		get
		{
			return EnvironmentalPerceptionController._Instance;
		}
	}

	// Token: 0x0601DCC1 RID: 122049 RVA: 0x00859E59 File Offset: 0x00858059
	public static EnvironmentalPerceptionController GetOrCreateInstance()
	{
		if (EnvironmentalPerceptionController._Instance == null)
		{
			EnvironmentalPerceptionController.CreateInstance();
		}
		return EnvironmentalPerceptionController._Instance;
	}

	// Token: 0x0601DCC2 RID: 122050 RVA: 0x00859E6D File Offset: 0x0085806D
	public static bool CreateInstance()
	{
		if (EnvironmentalPerceptionController._Instance != null)
		{
			return true;
		}
		EnvironmentalPerceptionController._Instance = new EnvironmentalPerceptionController();
		return true;
	}

	// Token: 0x0601DCC3 RID: 122051 RVA: 0x00859E83 File Offset: 0x00858083
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DCC4 RID: 122052 RVA: 0x00859E85 File Offset: 0x00858085
	public static void ResetStaticDefaultValue()
	{
		EnvironmentalPerceptionController._Instance = null;
	}

	// Token: 0x0601DCC5 RID: 122053 RVA: 0x00859E8D File Offset: 0x0085808D
	static EnvironmentalPerceptionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EnvironmentalPerceptionController.CreateStaticDefaultValue), new Action(EnvironmentalPerceptionController.ResetStaticDefaultValue));
	}

	// Token: 0x0601DCC6 RID: 122054 RVA: 0x00859EAC File Offset: 0x008580AC
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

	// Token: 0x0400E9DB RID: 59867
	private const int TICK_INTERNVAL = 8000;

	// Token: 0x0400E9DC RID: 59868
	private const int TICK_DAMPING_RATIO = 80;

	// Token: 0x0400E9DD RID: 59869
	private const int TICK_DAMPING_RATIO_INFIGHT = 16;

	// Token: 0x0400E9DE RID: 59870
	private const int FORCE_UPDATE_SPEED = 850;

	// Token: 0x0400E9DF RID: 59871
	private const int PERCEPTION_EVENT_POOL_CAPACITY = 32;

	// Token: 0x0400E9E0 RID: 59872
	private int TickRemain = 8000;

	// Token: 0x0400E9E1 RID: 59873
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400E9E2 RID: 59874
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400E9E3 RID: 59875
	[Nullable(2)]
	private Stat CheckIsPlayerInMapPolygonStat;

	// Token: 0x0400E9E4 RID: 59876
	private bool IsPlayerInFight;

	// Token: 0x0400E9E5 RID: 59877
	private readonly Pool<PlayerPerceptionEvent> PerceptionEventPool;

	// Token: 0x0400E9E6 RID: 59878
	private readonly Pool<PerceptionRange> PerceptionRangePool;

	// Token: 0x0400E9E7 RID: 59879
	[Nullable(2)]
	private static EnvironmentalPerceptionController _Instance;

	// Token: 0x020099B9 RID: 39353
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04030E0F RID: 200207
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<PlayerPerceptionEvent> <0>__PerceptionEventCreator;

		// Token: 0x04030E10 RID: 200208
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<PerceptionRange> <1>__PerceptionRangeCreator;
	}
}
