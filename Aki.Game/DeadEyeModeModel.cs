using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02000F3A RID: 3898
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class DeadEyeModeModel : ModelBase
{
	// Token: 0x17001080 RID: 4224
	// (get) Token: 0x06009BA8 RID: 39848 RVA: 0x002E2995 File Offset: 0x002E0B95
	public EDeadEyeModeType Type
	{
		get
		{
			return this.InnerType;
		}
	}

	// Token: 0x17001081 RID: 4225
	// (get) Token: 0x06009BA9 RID: 39849 RVA: 0x002E299D File Offset: 0x002E0B9D
	public EDeadEyeModeStage CurDeadEyeModeStage
	{
		get
		{
			return this.DeadEyeModeStage;
		}
	}

	// Token: 0x17001082 RID: 4226
	// (get) Token: 0x06009BAA RID: 39850 RVA: 0x002E29A5 File Offset: 0x002E0BA5
	public bool IsInDeadEyeMode
	{
		get
		{
			return this.CurDeadEyeModeStage == EDeadEyeModeStage.JumpCamp || this.CurDeadEyeModeStage == EDeadEyeModeStage.AimInput;
		}
	}

	// Token: 0x17001083 RID: 4227
	// (get) Token: 0x06009BAB RID: 39851 RVA: 0x002E29BB File Offset: 0x002E0BBB
	public int MaxEnergy
	{
		get
		{
			return this.InnerMaxEnergy;
		}
	}

	// Token: 0x17001084 RID: 4228
	// (get) Token: 0x06009BAC RID: 39852 RVA: 0x002E29C3 File Offset: 0x002E0BC3
	public int BulletConsumption
	{
		get
		{
			return this.EnergyConfig.BulletConsumption;
		}
	}

	// Token: 0x17001085 RID: 4229
	// (get) Token: 0x06009BAD RID: 39853 RVA: 0x002E29D0 File Offset: 0x002E0BD0
	public int TimeConsumption
	{
		get
		{
			return this.EnergyConfig.TimeConsumption;
		}
	}

	// Token: 0x17001086 RID: 4230
	// (get) Token: 0x06009BAE RID: 39854 RVA: 0x002E29DD File Offset: 0x002E0BDD
	public int SubCameraTag
	{
		get
		{
			return this.InnerSubCameraTag;
		}
	}

	// Token: 0x17001087 RID: 4231
	// (get) Token: 0x06009BAF RID: 39855 RVA: 0x002E29E5 File Offset: 0x002E0BE5
	public float TimeScale
	{
		get
		{
			return this.InnerTimeScale;
		}
	}

	// Token: 0x06009BB0 RID: 39856 RVA: 0x002E29ED File Offset: 0x002E0BED
	protected override bool OnLeaveLevel()
	{
		this.HighlightDataLockedAsset = null;
		return true;
	}

	// Token: 0x06009BB1 RID: 39857 RVA: 0x002E29F8 File Offset: 0x002E0BF8
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

	// Token: 0x06009BB2 RID: 39858 RVA: 0x002E2AB8 File Offset: 0x002E0CB8
	public void EnterNextStage()
	{
		this.DeadEyeModeStage++;
		EventSystem.Instance.Emit(EEventName.OnDeadEyeModeStageChange);
	}

	// Token: 0x06009BB3 RID: 39859 RVA: 0x002E2AD8 File Offset: 0x002E0CD8
	public void EndDeadEyeMode()
	{
		this.DeadEyeModeStage = EDeadEyeModeStage.None;
		this.EntityFocusOnList.Clear();
		this.EntityLockedList.Clear();
		this.TargetLocationList.Clear();
	}

	// Token: 0x06009BB4 RID: 39860 RVA: 0x002E2B02 File Offset: 0x002E0D02
	public void AddFocusEntity(EntityHandle entityHandle)
	{
		this.EntityFocusOnList.Add(entityHandle);
	}

	// Token: 0x06009BB5 RID: 39861 RVA: 0x002E2B10 File Offset: 0x002E0D10
	public List<EntityHandle> GetFocusEntities()
	{
		return this.EntityFocusOnList;
	}

	// Token: 0x06009BB6 RID: 39862 RVA: 0x002E2B18 File Offset: 0x002E0D18
	public void AddTargetLocation(Vector location)
	{
		this.TargetLocationList.Add(location);
	}

	// Token: 0x06009BB7 RID: 39863 RVA: 0x002E2B26 File Offset: 0x002E0D26
	public List<Vector> GetTargetLocations()
	{
		return this.TargetLocationList;
	}

	// Token: 0x06009BB8 RID: 39864 RVA: 0x002E2B2E File Offset: 0x002E0D2E
	public bool CheckEnergyEnoughLockTarget()
	{
		return this.CurrentEnergy >= (float)this.BulletConsumption;
	}

	// Token: 0x06009BB9 RID: 39865 RVA: 0x002E2B42 File Offset: 0x002E0D42
	public void RecordLockedTarget(EntityHandle targetEntity)
	{
		this.EntityLockedList.Add(targetEntity);
	}

	// Token: 0x06009BBA RID: 39866 RVA: 0x002E2B50 File Offset: 0x002E0D50
	public List<EntityHandle> GetLockedEntities()
	{
		return this.EntityLockedList;
	}

	// Token: 0x17001088 RID: 4232
	// (get) Token: 0x06009BBB RID: 39867 RVA: 0x002E2B58 File Offset: 0x002E0D58
	public static DeadEyeModeModel Instance
	{
		get
		{
			return DeadEyeModeModel._Instance;
		}
	}

	// Token: 0x06009BBC RID: 39868 RVA: 0x002E2B5F File Offset: 0x002E0D5F
	public static DeadEyeModeModel GetOrCreateInstance()
	{
		if (DeadEyeModeModel._Instance == null)
		{
			DeadEyeModeModel.CreateInstance();
		}
		return DeadEyeModeModel._Instance;
	}

	// Token: 0x06009BBD RID: 39869 RVA: 0x002E2B73 File Offset: 0x002E0D73
	public static bool CreateInstance()
	{
		if (DeadEyeModeModel._Instance != null)
		{
			return true;
		}
		DeadEyeModeModel._Instance = new DeadEyeModeModel();
		return true;
	}

	// Token: 0x06009BBE RID: 39870 RVA: 0x002E2B89 File Offset: 0x002E0D89
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009BBF RID: 39871 RVA: 0x002E2B8B File Offset: 0x002E0D8B
	public static void ResetStaticDefaultValue()
	{
		DeadEyeModeModel._Instance = null;
	}

	// Token: 0x06009BC0 RID: 39872 RVA: 0x002E2B93 File Offset: 0x002E0D93
	static DeadEyeModeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DeadEyeModeModel.CreateStaticDefaultValue), new Action(DeadEyeModeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005CEE RID: 23790
	private EDeadEyeModeType InnerType;

	// Token: 0x04005CEF RID: 23791
	[Nullable(2)]
	private IDeadeyeEnergyConfig EnergyConfig;

	// Token: 0x04005CF0 RID: 23792
	private readonly List<EntityHandle> EntityFocusOnList = new List<EntityHandle>();

	// Token: 0x04005CF1 RID: 23793
	private readonly List<Vector> TargetLocationList = new List<Vector>();

	// Token: 0x04005CF2 RID: 23794
	private readonly List<EntityHandle> EntityLockedList = new List<EntityHandle>();

	// Token: 0x04005CF3 RID: 23795
	public readonly Dictionary<UStaticMeshComponent, Dictionary<int, UMaterialInterface>> RevertMaterialComponentsMaps = new Dictionary<UStaticMeshComponent, Dictionary<int, UMaterialInterface>>();

	// Token: 0x04005CF4 RID: 23796
	public readonly Dictionary<CharRenderingComponent, int> CharRenderingComponents = new Dictionary<CharRenderingComponent, int>();

	// Token: 0x04005CF5 RID: 23797
	private EDeadEyeModeStage DeadEyeModeStage;

	// Token: 0x04005CF6 RID: 23798
	private float InnerTimeScale = 0.02f;

	// Token: 0x04005CF7 RID: 23799
	private int InnerMaxEnergy;

	// Token: 0x04005CF8 RID: 23800
	private int InnerSubCameraTag;

	// Token: 0x04005CF9 RID: 23801
	public float CurrentEnergy;

	// Token: 0x04005CFA RID: 23802
	public float TimeScaleTransitionTime;

	// Token: 0x04005CFB RID: 23803
	public long TriggerEntityCreatureDataId;

	// Token: 0x04005CFC RID: 23804
	[Nullable(2)]
	public string FilterEffectPath;

	// Token: 0x04005CFD RID: 23805
	[Nullable(2)]
	public string TargerNotLockDaPath;

	// Token: 0x04005CFE RID: 23806
	[Nullable(2)]
	public string TargerLockedDaPath;

	// Token: 0x04005CFF RID: 23807
	[Nullable(2)]
	public string FinishEvent;

	// Token: 0x04005D00 RID: 23808
	public bool HideFollowShooterWhenFinish = true;

	// Token: 0x04005D01 RID: 23809
	public float LerpElapsedTime;

	// Token: 0x04005D02 RID: 23810
	public bool ViewStartSequenceFinish;

	// Token: 0x04005D03 RID: 23811
	[Nullable(2)]
	public UPrimaryDataAsset DeadEyeFollowShooterConfig;

	// Token: 0x04005D04 RID: 23812
	[Nullable(2)]
	public PD_CharacterControllerData_C HighlightDataLockedAsset;

	// Token: 0x04005D05 RID: 23813
	[Nullable(2)]
	public PD_CharacterControllerData_C HighlightDataNotLockAsset;

	// Token: 0x04005D06 RID: 23814
	[Nullable(2)]
	private static DeadEyeModeModel _Instance;
}
