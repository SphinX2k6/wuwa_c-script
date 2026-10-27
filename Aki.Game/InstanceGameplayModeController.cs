using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02001FA6 RID: 8102
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class InstanceGameplayModeController : ControllerBase
{
	// Token: 0x0600FBCD RID: 64461 RVA: 0x003D0C44 File Offset: 0x003CEE44
	protected override bool OnInit()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		return true;
	}

	// Token: 0x0600FBCE RID: 64462 RVA: 0x003D0C63 File Offset: 0x003CEE63
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		return true;
	}

	// Token: 0x0600FBCF RID: 64463 RVA: 0x003D0C82 File Offset: 0x003CEE82
	protected override bool OnChangeMode()
	{
		this.ResetAll();
		return true;
	}

	// Token: 0x0600FBD0 RID: 64464 RVA: 0x003D0C8B File Offset: 0x003CEE8B
	protected override bool OnLeaveLevel()
	{
		this.ResetAll();
		return true;
	}

	// Token: 0x0600FBD1 RID: 64465 RVA: 0x003D0C94 File Offset: 0x003CEE94
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

	// Token: 0x0600FBD2 RID: 64466 RVA: 0x003D0D34 File Offset: 0x003CEF34
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

	// Token: 0x0600FBD3 RID: 64467 RVA: 0x003D0DC1 File Offset: 0x003CEFC1
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

	// Token: 0x0600FBD4 RID: 64468 RVA: 0x003D0DE0 File Offset: 0x003CEFE0
	private void EnterFreeCameraMode(int[] configIdList)
	{
		CameraModel.Instance.MainModel.CreateFreeCamera();
		CameraModel.Instance.MainModel.FreeCamera.LogicComponent.InitConfig(InstanceGameplayModeController.ToFloatArray(configIdList));
		CameraController.Instance.EnterCameraMode(ECustomCameraMode.Free, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, false, "MainCamera", null);
	}

	// Token: 0x0600FBD5 RID: 64469 RVA: 0x003D0E3B File Offset: 0x003CF03B
	private void ExitFreeCameraMode()
	{
		CameraController.Instance.ExitCameraMode(ECustomCameraMode.Free, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
		CameraModel.Instance.MainModel.DestroyFreeCamera();
	}

	// Token: 0x0600FBD6 RID: 64470 RVA: 0x003D0E6C File Offset: 0x003CF06C
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

	// Token: 0x0600FBD7 RID: 64471 RVA: 0x003D0F6C File Offset: 0x003CF16C
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

	// Token: 0x0600FBD8 RID: 64472 RVA: 0x003D0FB1 File Offset: 0x003CF1B1
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle entityHandle)
	{
		if (entityHandle.EntityType == 0)
		{
			InstanceGameplayModeModel.Instance.DisabledCreatureSet.Remove(entityHandle.CreatureDataId);
		}
	}

	// Token: 0x0600FBD9 RID: 64473 RVA: 0x003D0FD4 File Offset: 0x003CF1D4
	private static float[] ToFloatArray(int[] intArray)
	{
		float[] array = new float[intArray.Length];
		for (int i = 0; i < intArray.Length; i++)
		{
			array[i] = (float)intArray[i];
		}
		return array;
	}

	// Token: 0x1700134B RID: 4939
	// (get) Token: 0x0600FBDA RID: 64474 RVA: 0x003D1000 File Offset: 0x003CF200
	public static InstanceGameplayModeController Instance
	{
		get
		{
			return InstanceGameplayModeController._Instance;
		}
	}

	// Token: 0x0600FBDB RID: 64475 RVA: 0x003D1007 File Offset: 0x003CF207
	public static InstanceGameplayModeController GetOrCreateInstance()
	{
		if (InstanceGameplayModeController._Instance == null)
		{
			InstanceGameplayModeController.CreateInstance();
		}
		return InstanceGameplayModeController._Instance;
	}

	// Token: 0x0600FBDC RID: 64476 RVA: 0x003D101B File Offset: 0x003CF21B
	public static bool CreateInstance()
	{
		if (InstanceGameplayModeController._Instance != null)
		{
			return true;
		}
		InstanceGameplayModeController._Instance = new InstanceGameplayModeController();
		return true;
	}

	// Token: 0x0600FBDD RID: 64477 RVA: 0x003D1031 File Offset: 0x003CF231
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FBDE RID: 64478 RVA: 0x003D1033 File Offset: 0x003CF233
	public static void ResetStaticDefaultValue()
	{
		InstanceGameplayModeController._Instance = null;
	}

	// Token: 0x0600FBDF RID: 64479 RVA: 0x003D103B File Offset: 0x003CF23B
	static InstanceGameplayModeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InstanceGameplayModeController.CreateStaticDefaultValue), new Action(InstanceGameplayModeController.ResetStaticDefaultValue));
	}

	// Token: 0x0400751B RID: 29979
	[Nullable(2)]
	private static InstanceGameplayModeController _Instance;
}
