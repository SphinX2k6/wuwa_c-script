using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000F0D RID: 3853
[NullableContext(1)]
[Nullable(0)]
public class FormationDataModel : ModelBase
{
	// Token: 0x060060F7 RID: 24823 RVA: 0x0012EB1F File Offset: 0x0012CD1F
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x060060F8 RID: 24824 RVA: 0x0012EB22 File Offset: 0x0012CD22
	protected override bool OnClear()
	{
		this.PlayerAggroSet.Clear();
		this.OnLandPositionQueue.Clear();
		return true;
	}

	// Token: 0x060060F9 RID: 24825 RVA: 0x0012EB3B File Offset: 0x0012CD3B
	protected override bool OnLeaveLevel()
	{
		this.OnLandPositionQueue.Clear();
		return true;
	}

	// Token: 0x060060FA RID: 24826 RVA: 0x0012EB4C File Offset: 0x0012CD4C
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

	// Token: 0x060060FB RID: 24827 RVA: 0x0012EC56 File Offset: 0x0012CE56
	[NullableContext(2)]
	public Vector GetLastPositionOnLand()
	{
		return this.OnLandPositionQueue.Front;
	}

	// Token: 0x17000791 RID: 1937
	// (get) Token: 0x060060FC RID: 24828 RVA: 0x0012EC63 File Offset: 0x0012CE63
	public static FormationDataModel Instance
	{
		get
		{
			return FormationDataModel._Instance;
		}
	}

	// Token: 0x060060FD RID: 24829 RVA: 0x0012EC6A File Offset: 0x0012CE6A
	public static FormationDataModel GetOrCreateInstance()
	{
		if (FormationDataModel._Instance == null)
		{
			FormationDataModel.CreateInstance();
		}
		return FormationDataModel._Instance;
	}

	// Token: 0x060060FE RID: 24830 RVA: 0x0012EC7E File Offset: 0x0012CE7E
	public static bool CreateInstance()
	{
		if (FormationDataModel._Instance != null)
		{
			return true;
		}
		FormationDataModel._Instance = new FormationDataModel();
		return true;
	}

	// Token: 0x060060FF RID: 24831 RVA: 0x0012EC94 File Offset: 0x0012CE94
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006100 RID: 24832 RVA: 0x0012EC96 File Offset: 0x0012CE96
	public static void ResetStaticDefaultValue()
	{
		FormationDataModel._Instance = null;
	}

	// Token: 0x06006101 RID: 24833 RVA: 0x0012EC9E File Offset: 0x0012CE9E
	static FormationDataModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationDataModel.CreateStaticDefaultValue), new Action(FormationDataModel.ResetStaticDefaultValue));
	}

	// Token: 0x04002C34 RID: 11316
	private const int CACHE_ON_LAND_SIZE = 15;

	// Token: 0x04002C35 RID: 11317
	public readonly HashSet<int> PlayerAggroSet = new HashSet<int>();

	// Token: 0x04002C36 RID: 11318
	public Queue<Vector> OnLandPositionQueue = new Queue<Vector>(15);

	// Token: 0x04002C37 RID: 11319
	public ELockEnemyMode KeyboardLockEnemyMode;

	// Token: 0x04002C38 RID: 11320
	public ELockEnemyMode GamepadLockEnemyMode;

	// Token: 0x04002C39 RID: 11321
	[Nullable(2)]
	private static FormationDataModel _Instance;
}
