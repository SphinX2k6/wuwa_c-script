using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02001A7B RID: 6779
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class DeadEyeModeModel : ModelBase
{
	// Token: 0x1700105B RID: 4187
	// (get) Token: 0x0600C798 RID: 51096 RVA: 0x002D7879 File Offset: 0x002D5A79
	public EDeadEyeModeType Type
	{
		get
		{
			return this.InnerType;
		}
	}

	// Token: 0x1700105C RID: 4188
	// (get) Token: 0x0600C799 RID: 51097 RVA: 0x002D7881 File Offset: 0x002D5A81
	public EDeadEyeModeStage CurDeadEyeModeStage
	{
		get
		{
			return this.DeadEyeModeStage;
		}
	}

	// Token: 0x1700105D RID: 4189
	// (get) Token: 0x0600C79A RID: 51098 RVA: 0x002D7889 File Offset: 0x002D5A89
	public bool IsInDeadEyeMode
	{
		get
		{
			return this.CurDeadEyeModeStage == EDeadEyeModeStage.JumpCamp || this.CurDeadEyeModeStage == EDeadEyeModeStage.AimInput;
		}
	}

	// Token: 0x1700105E RID: 4190
	// (get) Token: 0x0600C79B RID: 51099 RVA: 0x002D789F File Offset: 0x002D5A9F
	public int MaxEnergy
	{
		get
		{
			return this.InnerMaxEnergy;
		}
	}

	// Token: 0x1700105F RID: 4191
	// (get) Token: 0x0600C79C RID: 51100 RVA: 0x002D78A7 File Offset: 0x002D5AA7
	public int BulletConsumption
	{
		get
		{
			return this.EnergyConfig.BulletConsumption;
		}
	}

	// Token: 0x17001060 RID: 4192
	// (get) Token: 0x0600C79D RID: 51101 RVA: 0x002D78B4 File Offset: 0x002D5AB4
	public int TimeConsumption
	{
		get
		{
			return this.EnergyConfig.TimeConsumption;
		}
	}

	// Token: 0x17001061 RID: 4193
	// (get) Token: 0x0600C79E RID: 51102 RVA: 0x002D78C1 File Offset: 0x002D5AC1
	public int SubCameraTag
	{
		get
		{
			return this.InnerSubCameraTag;
		}
	}

	// Token: 0x17001062 RID: 4194
	// (get) Token: 0x0600C79F RID: 51103 RVA: 0x002D78C9 File Offset: 0x002D5AC9
	public float TimeScale
	{
		get
		{
			return this.InnerTimeScale;
		}
	}

	// Token: 0x0600C7A0 RID: 51104 RVA: 0x002D78D1 File Offset: 0x002D5AD1
	protected override bool OnLeaveLevel()
	{
		this.HighlightDataLockedAsset = null;
		return true;
	}

	// Token: 0x0600C7A1 RID: 51105 RVA: 0x002D78DC File Offset: 0x002D5ADC
	[NullableContext(2)]
	public void StartDeadEyeMode(EDeadEyeModeType type, [Nullable(1)] IDeadeyeEnergyConfig energyConfig, int maxEnergy, float lookAtTransitionTime, long triggerEntityCreatureDataId, float timeScale, int? subCameraTag = null, IDeadEyeEffectConfig effectConfig = null, string finishSendSelfEvent = null)
	{
		this.InnerType = type;
		this.EnergyConfig = energyConfig;
		this.InnerTimeScale = timeScale;
		this.InnerSubCameraTag = subCameraTag.GetValueOrDefault();
		this.InnerMaxEnergy = maxEnergy;
		this.CurrentEnergy = (float)this.MaxEnergy;
		this.TimeScaleTransitionTime = lookAtTransitionTime;
		this.TriggerEntityCreatureDataId = triggerEntityCreatureDataId;
		this.FilterEffectPath = ((effectConfig != null) ? effectConfig.FilterEffect : null);
		this.TargerNotLockDaPath = ((effectConfig != null) ? effectConfig.TargetIdleMaterialDa : null);
		this.TargerLockedDaPath = ((effectConfig != null) ? effectConfig.TargetLockedMaterialDa : null);
		this.FinishEvent = finishSendSelfEvent;
		this.LerpElapsedTime = 0f;
		this.ViewStartSequenceFinish = false;
		this.RevertMaterialComponentsMaps.Clear();
		this.CharRenderingComponents.Clear();
	}

	// Token: 0x0600C7A2 RID: 51106 RVA: 0x002D799C File Offset: 0x002D5B9C
	public void EnterNextStage()
	{
		this.DeadEyeModeStage++;
		EventSystem.Instance.Emit(EEventName.OnDeadEyeModeStageChange);
	}

	// Token: 0x0600C7A3 RID: 51107 RVA: 0x002D79BC File Offset: 0x002D5BBC
	public void EndDeadEyeMode()
	{
		this.DeadEyeModeStage = EDeadEyeModeStage.None;
		this.EntityFocusOnList.Clear();
		this.EntityLockedList.Clear();
		this.TargetLocationList.Clear();
	}

	// Token: 0x0600C7A4 RID: 51108 RVA: 0x002D79E6 File Offset: 0x002D5BE6
	public void AddFocusEntity(EntityHandle entityHandle)
	{
		this.EntityFocusOnList.Add(entityHandle);
	}

	// Token: 0x0600C7A5 RID: 51109 RVA: 0x002D79F4 File Offset: 0x002D5BF4
	public List<EntityHandle> GetFocusEntities()
	{
		return this.EntityFocusOnList;
	}

	// Token: 0x0600C7A6 RID: 51110 RVA: 0x002D79FC File Offset: 0x002D5BFC
	public void AddTargetLocation(Vector location)
	{
		this.TargetLocationList.Add(location);
	}

	// Token: 0x0600C7A7 RID: 51111 RVA: 0x002D7A0A File Offset: 0x002D5C0A
	public List<Vector> GetTargetLocations()
	{
		return this.TargetLocationList;
	}

	// Token: 0x0600C7A8 RID: 51112 RVA: 0x002D7A12 File Offset: 0x002D5C12
	public bool CheckEnergyEnoughLockTarget()
	{
		return this.CurrentEnergy >= (float)this.BulletConsumption;
	}

	// Token: 0x0600C7A9 RID: 51113 RVA: 0x002D7A26 File Offset: 0x002D5C26
	public void RecordLockedTarget(EntityHandle targetEntity)
	{
		this.EntityLockedList.Add(targetEntity);
	}

	// Token: 0x0600C7AA RID: 51114 RVA: 0x002D7A34 File Offset: 0x002D5C34
	public List<EntityHandle> GetLockedEntities()
	{
		return this.EntityLockedList;
	}

	// Token: 0x17001063 RID: 4195
	// (get) Token: 0x0600C7AB RID: 51115 RVA: 0x002D7A3C File Offset: 0x002D5C3C
	public static DeadEyeModeModel Instance
	{
		get
		{
			return DeadEyeModeModel._Instance;
		}
	}

	// Token: 0x0600C7AC RID: 51116 RVA: 0x002D7A43 File Offset: 0x002D5C43
	public static DeadEyeModeModel GetOrCreateInstance()
	{
		if (DeadEyeModeModel._Instance == null)
		{
			DeadEyeModeModel.CreateInstance();
		}
		return DeadEyeModeModel._Instance;
	}

	// Token: 0x0600C7AD RID: 51117 RVA: 0x002D7A57 File Offset: 0x002D5C57
	public static bool CreateInstance()
	{
		if (DeadEyeModeModel._Instance != null)
		{
			return true;
		}
		DeadEyeModeModel._Instance = new DeadEyeModeModel();
		return true;
	}

	// Token: 0x0600C7AE RID: 51118 RVA: 0x002D7A6D File Offset: 0x002D5C6D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C7AF RID: 51119 RVA: 0x002D7A6F File Offset: 0x002D5C6F
	public static void ResetStaticDefaultValue()
	{
		DeadEyeModeModel._Instance = null;
	}

	// Token: 0x0600C7B0 RID: 51120 RVA: 0x002D7A77 File Offset: 0x002D5C77
	static DeadEyeModeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DeadEyeModeModel.CreateStaticDefaultValue), new Action(DeadEyeModeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005C1F RID: 23583
	private EDeadEyeModeType InnerType;

	// Token: 0x04005C20 RID: 23584
	[Nullable(2)]
	private IDeadeyeEnergyConfig EnergyConfig;

	// Token: 0x04005C21 RID: 23585
	private readonly List<EntityHandle> EntityFocusOnList = new List<EntityHandle>();

	// Token: 0x04005C22 RID: 23586
	private readonly List<Vector> TargetLocationList = new List<Vector>();

	// Token: 0x04005C23 RID: 23587
	private readonly List<EntityHandle> EntityLockedList = new List<EntityHandle>();

	// Token: 0x04005C24 RID: 23588
	public readonly Dictionary<UStaticMeshComponent, Dictionary<int, UMaterialInterface>> RevertMaterialComponentsMaps = new Dictionary<UStaticMeshComponent, Dictionary<int, UMaterialInterface>>();

	// Token: 0x04005C25 RID: 23589
	public readonly Dictionary<CharRenderingComponent, int> CharRenderingComponents = new Dictionary<CharRenderingComponent, int>();

	// Token: 0x04005C26 RID: 23590
	private EDeadEyeModeStage DeadEyeModeStage;

	// Token: 0x04005C27 RID: 23591
	private float InnerTimeScale = 0.02f;

	// Token: 0x04005C28 RID: 23592
	private int InnerMaxEnergy;

	// Token: 0x04005C29 RID: 23593
	private int InnerSubCameraTag;

	// Token: 0x04005C2A RID: 23594
	public float CurrentEnergy;

	// Token: 0x04005C2B RID: 23595
	public float TimeScaleTransitionTime;

	// Token: 0x04005C2C RID: 23596
	public long TriggerEntityCreatureDataId;

	// Token: 0x04005C2D RID: 23597
	[Nullable(2)]
	public string FilterEffectPath;

	// Token: 0x04005C2E RID: 23598
	[Nullable(2)]
	public string TargerNotLockDaPath;

	// Token: 0x04005C2F RID: 23599
	[Nullable(2)]
	public string TargerLockedDaPath;

	// Token: 0x04005C30 RID: 23600
	[Nullable(2)]
	public string FinishEvent;

	// Token: 0x04005C31 RID: 23601
	public bool HideFollowShooterWhenFinish = true;

	// Token: 0x04005C32 RID: 23602
	public float LerpElapsedTime;

	// Token: 0x04005C33 RID: 23603
	public bool ViewStartSequenceFinish;

	// Token: 0x04005C34 RID: 23604
	[Nullable(2)]
	public UPrimaryDataAsset DeadEyeFollowShooterConfig;

	// Token: 0x04005C35 RID: 23605
	[Nullable(2)]
	public PD_CharacterControllerData_C HighlightDataLockedAsset;

	// Token: 0x04005C36 RID: 23606
	[Nullable(2)]
	public PD_CharacterControllerData_C HighlightDataNotLockAsset;

	// Token: 0x04005C37 RID: 23607
	[Nullable(2)]
	private static DeadEyeModeModel _Instance;
}
