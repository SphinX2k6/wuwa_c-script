using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02001468 RID: 5224
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class InstanceGameplayModeController : ControllerBase
{
	// Token: 0x0600CFEF RID: 53231 RVA: 0x003DC8C0 File Offset: 0x003DAAC0
	protected override bool OnInit()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		return true;
	}

	// Token: 0x0600CFF0 RID: 53232 RVA: 0x003DC8DF File Offset: 0x003DAADF
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		return true;
	}

	// Token: 0x0600CFF1 RID: 53233 RVA: 0x003DC8FE File Offset: 0x003DAAFE
	protected override bool OnChangeMode()
	{
		this.ResetAll();
		return true;
	}

	// Token: 0x0600CFF2 RID: 53234 RVA: 0x003DC907 File Offset: 0x003DAB07
	protected override bool OnLeaveLevel()
	{
		this.ResetAll();
		return true;
	}

	// Token: 0x0600CFF3 RID: 53235 RVA: 0x003DC910 File Offset: 0x003DAB10
	private void ResetAll()
	{
		if (InstanceGameplayModeModel.Instance.DefaultCameraMode == EDefaultCameraMode.FreeCamera)
		{
			this.ExitFreeCameraMode();
		}
		InstanceGameplayModeModel.Instance.DefaultCameraMode = EDefaultCameraMode.FightCamera;
		if (EventSystem.Instance.Has<CreatureDataComponent, EntityHandle>(EEventName.CreateEntity, new Action<CreatureDataComponent, EntityHandle>(this.OnCreateEntity)))
		{
			EventSystem.Instance.Remove(EEventName.CreateEntity, new Action<CreatureDataComponent, EntityHandle>(this.OnCreateEntity));
		}
		if (EventSystem.Instance.Has<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
		{
			EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}
	}

	// Token: 0x0600CFF4 RID: 53236 RVA: 0x003DC9B0 File Offset: 0x003DABB0
	private void OnWorldDone()
	{
		InstanceDungeon? instanceDungeon;
		int num = (GameModeModel.Instance.InstanceDungeon != null) ? instanceDungeon.GetValueOrDefault().GameplayMode : 0;
		if (num <= 0)
		{
			return;
		}
		InstanceGameplayMode? gameplayModeConfig = InstanceDungeonConfig.Instance.GetGameplayModeConfig(num);
		if (gameplayModeConfig == null)
		{
			return;
		}
		if (gameplayModeConfig.Value.DisableAllPlayerRole)
		{
			this.DisableAllPlayerRole();
		}
		this.UpdateDefaultCameraMode((EDefaultCameraMode)gameplayModeConfig.Value.DefaultCameraMode, gameplayModeConfig.Value.GetCameraParamsArray());
	}

	// Token: 0x0600CFF5 RID: 53237 RVA: 0x003DCA3D File Offset: 0x003DAC3D
	private void UpdateDefaultCameraMode(EDefaultCameraMode mode, int[] @params)
	{
		InstanceGameplayModeModel.Instance.DefaultCameraMode = mode;
		if (mode == EDefaultCameraMode.FightCamera)
		{
			return;
		}
		if (mode == EDefaultCameraMode.FreeCamera)
		{
			this.EnterFreeCameraMode(@params);
		}
	}

	// Token: 0x0600CFF6 RID: 53238 RVA: 0x003DCA5C File Offset: 0x003DAC5C
	private void EnterFreeCameraMode(int[] configIdList)
	{
		CameraModel.Instance.MainModel.CreateFreeCamera();
		CameraModel.Instance.MainModel.FreeCamera.LogicComponent.InitConfig(InstanceGameplayModeController.ToFloatArray(configIdList));
		CameraController.Instance.EnterCameraMode(ECustomCameraMode.Free, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, false, "MainCamera", null);
	}

	// Token: 0x0600CFF7 RID: 53239 RVA: 0x003DCAB7 File Offset: 0x003DACB7
	private void ExitFreeCameraMode()
	{
		CameraController.Instance.ExitCameraMode(ECustomCameraMode.Free, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
		CameraModel.Instance.MainModel.DestroyFreeCamera();
	}

	// Token: 0x0600CFF8 RID: 53240 RVA: 0x003DCAE8 File Offset: 0x003DACE8
	public void DisableAllPlayerRole()
	{
		IReadOnlyList<EntityHandle> allEntities = CreatureModel.Instance.GetAllEntities();
		if (allEntities != null)
		{
			foreach (EntityHandle entityHandle in allEntities)
			{
				if (entityHandle.Valid && entityHandle.EntityType == 0)
				{
					WorldEntity entity = entityHandle.Entity;
					if (entity != null)
					{
						long creatureDataId = entityHandle.CreatureDataId;
						entity.DisableByKey(EEntityDisableKey.GameplayMode, true);
						InstanceGameplayModeModel.Instance.DisabledCreatureSet.Add(creatureDataId);
					}
				}
			}
		}
		if (!EventSystem.Instance.Has<CreatureDataComponent, EntityHandle>(EEventName.CreateEntity, new Action<CreatureDataComponent, EntityHandle>(this.OnCreateEntity)))
		{
			EventSystem.Instance.Add<CreatureDataComponent, EntityHandle>(EEventName.CreateEntity, new Action<CreatureDataComponent, EntityHandle>(this.OnCreateEntity));
		}
		if (!EventSystem.Instance.Has<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
		{
			EventSystem.Instance.Add<ERemoveEntityType, EntityHandle>(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}
	}

	// Token: 0x0600CFF9 RID: 53241 RVA: 0x003DCBE8 File Offset: 0x003DADE8
	private void OnCreateEntity(CreatureDataComponent creatureData, EntityHandle entityHandle)
	{
		if (entityHandle.EntityType == 0)
		{
			WorldEntity entity = entityHandle.Entity;
			if (entity != null && entity.Valid)
			{
				entity.DisableByKey(EEntityDisableKey.GameplayMode, true);
				InstanceGameplayModeModel.Instance.DisabledCreatureSet.Add(entityHandle.CreatureDataId);
			}
		}
	}

	// Token: 0x0600CFFA RID: 53242 RVA: 0x003DCC2D File Offset: 0x003DAE2D
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle entityHandle)
	{
		if (entityHandle.EntityType == 0)
		{
			InstanceGameplayModeModel.Instance.DisabledCreatureSet.Remove(entityHandle.CreatureDataId);
		}
	}

	// Token: 0x0600CFFB RID: 53243 RVA: 0x003DCC50 File Offset: 0x003DAE50
	private static float[] ToFloatArray(int[] intArray)
	{
		float[] array = new float[intArray.Length];
		for (int i = 0; i < intArray.Length; i++)
		{
			array[i] = (float)intArray[i];
		}
		return array;
	}

	// Token: 0x17001375 RID: 4981
	// (get) Token: 0x0600CFFC RID: 53244 RVA: 0x003DCC7C File Offset: 0x003DAE7C
	public static InstanceGameplayModeController Instance
	{
		get
		{
			return InstanceGameplayModeController._Instance;
		}
	}

	// Token: 0x0600CFFD RID: 53245 RVA: 0x003DCC83 File Offset: 0x003DAE83
	public static InstanceGameplayModeController GetOrCreateInstance()
	{
		if (InstanceGameplayModeController._Instance == null)
		{
			InstanceGameplayModeController.CreateInstance();
		}
		return InstanceGameplayModeController._Instance;
	}

	// Token: 0x0600CFFE RID: 53246 RVA: 0x003DCC97 File Offset: 0x003DAE97
	public static bool CreateInstance()
	{
		if (InstanceGameplayModeController._Instance != null)
		{
			return true;
		}
		InstanceGameplayModeController._Instance = new InstanceGameplayModeController();
		return true;
	}

	// Token: 0x0600CFFF RID: 53247 RVA: 0x003DCCAD File Offset: 0x003DAEAD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D000 RID: 53248 RVA: 0x003DCCAF File Offset: 0x003DAEAF
	public static void ResetStaticDefaultValue()
	{
		InstanceGameplayModeController._Instance = null;
	}

	// Token: 0x0600D001 RID: 53249 RVA: 0x003DCCB7 File Offset: 0x003DAEB7
	static InstanceGameplayModeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InstanceGameplayModeController.CreateStaticDefaultValue), new Action(InstanceGameplayModeController.ResetStaticDefaultValue));
	}

	// Token: 0x040075FE RID: 30206
	[Nullable(2)]
	private static InstanceGameplayModeController _Instance;
}
