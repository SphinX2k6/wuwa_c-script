using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000EA3 RID: 3747
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ControlScreenModel : ModelBase
{
	// Token: 0x060095D0 RID: 38352 RVA: 0x002C7024 File Offset: 0x002C5224
	protected override bool OnInit()
	{
		this.MinTouchMoveDifference = (float)ConfigCommonParamById.GetIntConfig("MinTouchMoveDifference").Value;
		this.MaxTouchMoveDifference = (float)ConfigCommonParamById.GetIntConfig("MaxTouchMoveDifference").Value;
		this.MaxTouchMoveValue = ConfigCommonParamById.GetFloatConfig("MaxTouchMoveValue").Value;
		this.MinTouchMoveValue = ConfigCommonParamById.GetFloatConfig("MinTouchMoveValue").Value;
		this.CommonRotationScreenRateInternal = ConfigCommonParamById.GetFloatConfig("CommonRotationRate").Value;
		this.ArmRotationScreenRateInternal = ConfigCommonParamById.GetFloatConfig("ArmRotationRate").Value;
		this.DoubleTouchTime = ConfigCommonParamById.GetIntConfig("DoubleTouchTime").Value;
		return true;
	}

	// Token: 0x060095D1 RID: 38353 RVA: 0x002C70E1 File Offset: 0x002C52E1
	public void SetCurrentTouchTimeStamp(Number timeStamp)
	{
		this.CurrentTouchTimeStamp = timeStamp;
	}

	// Token: 0x060095D2 RID: 38354 RVA: 0x002C70EA File Offset: 0x002C52EA
	public void SetCurrentTouchId(int touchId)
	{
		this.CurrentTouchId = touchId;
	}

	// Token: 0x060095D3 RID: 38355 RVA: 0x002C70F3 File Offset: 0x002C52F3
	public void SetCurrentEnterComponent(USceneComponent enterComponent)
	{
		this.CurrentEnterComponent = enterComponent;
	}

	// Token: 0x060095D4 RID: 38356 RVA: 0x002C70FC File Offset: 0x002C52FC
	public void SetCurrentPressComponent(USceneComponent pressComponent)
	{
		this.CurrentPressComponent = pressComponent;
	}

	// Token: 0x060095D5 RID: 38357 RVA: 0x002C7105 File Offset: 0x002C5305
	public bool IsDoubleTouch(int touchId)
	{
		return this.GetTouchEmptyFingerDataCount() == 1 && touchId == this.CurrentTouchId && TimeUtil.Instance.GetServerTimeStamp() - this.CurrentTouchTimeStamp <= this.DoubleTouchTime;
	}

	// Token: 0x060095D6 RID: 38358 RVA: 0x002C7144 File Offset: 0x002C5344
	public bool IsDoubleTouchResetCameraComponent(TouchFingerData touchFingerData, FName componentTag)
	{
		return this.CurrentEnterComponent != null && this.CurrentEnterComponent.IsValid() && this.CurrentPressComponent != null && this.CurrentPressComponent.IsValid() && (this.CurrentEnterComponent.ComponentHasTag(componentTag) || this.CurrentPressComponent.ComponentHasTag(componentTag)) && touchFingerData.IsTouchComponentContainTag(componentTag);
	}

	// Token: 0x060095D7 RID: 38359 RVA: 0x002C71A4 File Offset: 0x002C53A4
	public void AddTouchEmptyFingerData(TouchFingerData touchFingerData)
	{
		EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
		this.TouchEmptyFingerDataMap[fingerIndex] = touchFingerData;
	}

	// Token: 0x060095D8 RID: 38360 RVA: 0x002C71C8 File Offset: 0x002C53C8
	public void RemoveTouchEmptyFingerData(TouchFingerData touchFingerData)
	{
		EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
		this.TouchEmptyFingerDataMap.Remove(fingerIndex);
	}

	// Token: 0x060095D9 RID: 38361 RVA: 0x002C71E9 File Offset: 0x002C53E9
	public int GetTouchEmptyFingerDataCount()
	{
		return this.TouchEmptyFingerDataMap.Count;
	}

	// Token: 0x17001055 RID: 4181
	// (get) Token: 0x060095DA RID: 38362 RVA: 0x002C71F6 File Offset: 0x002C53F6
	public bool IsTouching
	{
		get
		{
			return this.TouchEmptyFingerDataMap.Count > 0;
		}
	}

	// Token: 0x060095DB RID: 38363 RVA: 0x002C7206 File Offset: 0x002C5406
	public bool IsTouchEmpty(EFingerIndex fingerIndex)
	{
		return this.TouchEmptyFingerDataMap.ContainsKey(fingerIndex);
	}

	// Token: 0x060095DC RID: 38364 RVA: 0x002C7214 File Offset: 0x002C5414
	public TouchFingerData[] GetTouchEmptyFingerDataByCount(int count)
	{
		List<TouchFingerData> list = new List<TouchFingerData>();
		foreach (TouchFingerData item in this.TouchEmptyFingerDataMap.Values)
		{
			if (list.Count >= count)
			{
				break;
			}
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x060095DD RID: 38365 RVA: 0x002C7284 File Offset: 0x002C5484
	public void SetCommonRotationScreenRate(float rate)
	{
		this.CommonRotationScreenRateInternal = rate;
	}

	// Token: 0x060095DE RID: 38366 RVA: 0x002C728D File Offset: 0x002C548D
	public void SetArmRotationScreenRate(float rate)
	{
		this.ArmRotationScreenRateInternal = rate;
	}

	// Token: 0x060095DF RID: 38367 RVA: 0x002C7298 File Offset: 0x002C5498
	public void RefreshRotationScreenRate()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null)
		{
			this.RotationScreenRateInternal = this.CommonRotationScreenRateInternal;
			return;
		}
		CharacterUnifiedStateComponent component = getCurrentEntity.Entity.GetComponent<CharacterUnifiedStateComponent>();
		if (component == null)
		{
			this.RotationScreenRateInternal = this.CommonRotationScreenRateInternal;
			return;
		}
		if (component.DirectionState == ECharDirectionState.AimDirection)
		{
			this.RotationScreenRateInternal = this.ArmRotationScreenRateInternal;
			return;
		}
		this.RotationScreenRateInternal = this.CommonRotationScreenRateInternal;
	}

	// Token: 0x060095E0 RID: 38368 RVA: 0x002C72FE File Offset: 0x002C54FE
	public float GetRotationScreenRate()
	{
		return this.RotationScreenRateInternal;
	}

	// Token: 0x17001056 RID: 4182
	// (get) Token: 0x060095E1 RID: 38369 RVA: 0x002C7306 File Offset: 0x002C5506
	public static ControlScreenModel Instance
	{
		get
		{
			return ControlScreenModel._Instance;
		}
	}

	// Token: 0x060095E2 RID: 38370 RVA: 0x002C730D File Offset: 0x002C550D
	public static ControlScreenModel GetOrCreateInstance()
	{
		if (ControlScreenModel._Instance == null)
		{
			ControlScreenModel.CreateInstance();
		}
		return ControlScreenModel._Instance;
	}

	// Token: 0x060095E3 RID: 38371 RVA: 0x002C7321 File Offset: 0x002C5521
	public static bool CreateInstance()
	{
		if (ControlScreenModel._Instance != null)
		{
			return true;
		}
		ControlScreenModel._Instance = new ControlScreenModel();
		return true;
	}

	// Token: 0x060095E4 RID: 38372 RVA: 0x002C7337 File Offset: 0x002C5537
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060095E5 RID: 38373 RVA: 0x002C7339 File Offset: 0x002C5539
	public static void ResetStaticDefaultValue()
	{
		ControlScreenModel._Instance = null;
	}

	// Token: 0x060095E6 RID: 38374 RVA: 0x002C7341 File Offset: 0x002C5541
	static ControlScreenModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ControlScreenModel.CreateStaticDefaultValue), new Action(ControlScreenModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005A11 RID: 23057
	private float CommonRotationScreenRateInternal = 0.3f;

	// Token: 0x04005A12 RID: 23058
	private float ArmRotationScreenRateInternal = 0.3f;

	// Token: 0x04005A13 RID: 23059
	private float RotationScreenRateInternal = 0.3f;

	// Token: 0x04005A14 RID: 23060
	public float MinTouchMoveDifference;

	// Token: 0x04005A15 RID: 23061
	public float MaxTouchMoveDifference;

	// Token: 0x04005A16 RID: 23062
	public float MaxTouchMoveValue;

	// Token: 0x04005A17 RID: 23063
	public float MinTouchMoveValue;

	// Token: 0x04005A18 RID: 23064
	private Number CurrentTouchTimeStamp = 0;

	// Token: 0x04005A19 RID: 23065
	private int CurrentTouchId;

	// Token: 0x04005A1A RID: 23066
	private Number DoubleTouchTime = 0;

	// Token: 0x04005A1B RID: 23067
	private readonly Dictionary<EFingerIndex, TouchFingerData> TouchEmptyFingerDataMap = new Dictionary<EFingerIndex, TouchFingerData>();

	// Token: 0x04005A1C RID: 23068
	[Nullable(2)]
	private USceneComponent CurrentEnterComponent;

	// Token: 0x04005A1D RID: 23069
	[Nullable(2)]
	private USceneComponent CurrentPressComponent;

	// Token: 0x04005A1E RID: 23070
	[Nullable(2)]
	private static ControlScreenModel _Instance;
}
