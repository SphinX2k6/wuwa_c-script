using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020003C2 RID: 962
[NullableContext(1)]
[Nullable(0)]
public class FormationDataModel : ModelBase
{
	// Token: 0x0600348F RID: 13455 RVA: 0x00137443 File Offset: 0x00135643
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06003490 RID: 13456 RVA: 0x00137446 File Offset: 0x00135646
	protected override bool OnClear()
	{
		this.PlayerAggroSet.Clear();
		this.OnLandPositionQueue.Clear();
		return true;
	}

	// Token: 0x06003491 RID: 13457 RVA: 0x0013745F File Offset: 0x0013565F
	protected override bool OnLeaveLevel()
	{
		this.OnLandPositionQueue.Clear();
		return true;
	}

	// Token: 0x06003492 RID: 13458 RVA: 0x00137470 File Offset: 0x00135670
	public void RefreshOnLandPosition()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		if (worldEntity == null)
		{
			return;
		}
		CharacterUnifiedStateComponent component = worldEntity.GetComponent<CharacterUnifiedStateComponent>();
		ECharPositionState? echarPositionState = (component != null) ? new ECharPositionState?(component.PositionState) : null;
		ECharPositionSubState? echarPositionSubState = (component != null) ? new ECharPositionSubState?(component.PositionSubState) : null;
		ECharPositionState? echarPositionState2 = echarPositionState;
		ECharPositionState echarPositionState3 = ECharPositionState.Ground;
		if (!(echarPositionState2.GetValueOrDefault() == echarPositionState3 & echarPositionState2 != null))
		{
			return;
		}
		if (echarPositionSubState.GetValueOrDefault() == ECharPositionSubState.WaterSurface || echarPositionSubState.GetValueOrDefault() == ECharPositionSubState.WalkOnAir)
		{
			return;
		}
		BaseActorComponent component2 = worldEntity.GetComponent<BaseActorComponent>();
		AActor aactor = (component2 != null) ? component2.Owner : null;
		if (aactor == null || aactor.bHidden)
		{
			return;
		}
		Vector actorLocationProxy = component2.ActorLocationProxy;
		if (actorLocationProxy == null)
		{
			return;
		}
		Vector vector = null;
		if (this.OnLandPositionQueue.Size >= 15)
		{
			vector = this.OnLandPositionQueue.Pop();
		}
		if (vector == null)
		{
			vector = Vector.Create();
		}
		if (vector != null)
		{
			vector.DeepCopy(actorLocationProxy);
		}
		this.OnLandPositionQueue.Push(vector);
	}

	// Token: 0x06003493 RID: 13459 RVA: 0x0013757A File Offset: 0x0013577A
	[NullableContext(2)]
	public Vector GetLastPositionOnLand()
	{
		return this.OnLandPositionQueue.Front;
	}

	// Token: 0x170007B3 RID: 1971
	// (get) Token: 0x06003494 RID: 13460 RVA: 0x00137587 File Offset: 0x00135787
	public static FormationDataModel Instance
	{
		get
		{
			return FormationDataModel._Instance;
		}
	}

	// Token: 0x06003495 RID: 13461 RVA: 0x0013758E File Offset: 0x0013578E
	public static FormationDataModel GetOrCreateInstance()
	{
		if (FormationDataModel._Instance == null)
		{
			FormationDataModel.CreateInstance();
		}
		return FormationDataModel._Instance;
	}

	// Token: 0x06003496 RID: 13462 RVA: 0x001375A2 File Offset: 0x001357A2
	public static bool CreateInstance()
	{
		if (FormationDataModel._Instance != null)
		{
			return true;
		}
		FormationDataModel._Instance = new FormationDataModel();
		return true;
	}

	// Token: 0x06003497 RID: 13463 RVA: 0x001375B8 File Offset: 0x001357B8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06003498 RID: 13464 RVA: 0x001375BA File Offset: 0x001357BA
	public static void ResetStaticDefaultValue()
	{
		FormationDataModel._Instance = null;
	}

	// Token: 0x06003499 RID: 13465 RVA: 0x001375C2 File Offset: 0x001357C2
	static FormationDataModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationDataModel.CreateStaticDefaultValue), new Action(FormationDataModel.ResetStaticDefaultValue));
	}

	// Token: 0x04002CCD RID: 11469
	private const int CACHE_ON_LAND_SIZE = 15;

	// Token: 0x04002CCE RID: 11470
	public readonly HashSet<int> PlayerAggroSet = new HashSet<int>();

	// Token: 0x04002CCF RID: 11471
	public Queue<Vector> OnLandPositionQueue = new Queue<Vector>(15);

	// Token: 0x04002CD0 RID: 11472
	public ELockEnemyMode KeyboardLockEnemyMode;

	// Token: 0x04002CD1 RID: 11473
	public ELockEnemyMode GamepadLockEnemyMode;

	// Token: 0x04002CD2 RID: 11474
	[Nullable(2)]
	private static FormationDataModel _Instance;
}
