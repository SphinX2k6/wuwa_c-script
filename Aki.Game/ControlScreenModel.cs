using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019E4 RID: 6628
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ControlScreenModel : ModelBase
{
	// Token: 0x0600C1C3 RID: 49603 RVA: 0x002BC04C File Offset: 0x002BA24C
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

	// Token: 0x0600C1C4 RID: 49604 RVA: 0x002BC109 File Offset: 0x002BA309
	public void SetCurrentTouchTimeStamp(Number timeStamp)
	{
		this.CurrentTouchTimeStamp = timeStamp;
	}

	// Token: 0x0600C1C5 RID: 49605 RVA: 0x002BC112 File Offset: 0x002BA312
	public void SetCurrentTouchId(int touchId)
	{
		this.CurrentTouchId = touchId;
	}

	// Token: 0x0600C1C6 RID: 49606 RVA: 0x002BC11B File Offset: 0x002BA31B
	public void SetCurrentEnterComponent(USceneComponent enterComponent)
	{
		this.CurrentEnterComponent = enterComponent;
	}

	// Token: 0x0600C1C7 RID: 49607 RVA: 0x002BC124 File Offset: 0x002BA324
	public void SetCurrentPressComponent(USceneComponent pressComponent)
	{
		this.CurrentPressComponent = pressComponent;
	}

	// Token: 0x0600C1C8 RID: 49608 RVA: 0x002BC12D File Offset: 0x002BA32D
	public bool IsDoubleTouch(int touchId)
	{
		return this.GetTouchEmptyFingerDataCount() == 1 && touchId == this.CurrentTouchId && TimeUtil.Instance.GetServerTimeStamp() - this.CurrentTouchTimeStamp <= this.DoubleTouchTime;
	}

	// Token: 0x0600C1C9 RID: 49609 RVA: 0x002BC16C File Offset: 0x002BA36C
	public bool IsDoubleTouchResetCameraComponent(TouchFingerData touchFingerData, FName componentTag)
	{
		return this.CurrentEnterComponent != null && this.CurrentEnterComponent.IsValid() && this.CurrentPressComponent != null && this.CurrentPressComponent.IsValid() && (this.CurrentEnterComponent.ComponentHasTag(componentTag) || this.CurrentPressComponent.ComponentHasTag(componentTag)) && touchFingerData.IsTouchComponentContainTag(componentTag);
	}

	// Token: 0x0600C1CA RID: 49610 RVA: 0x002BC1CC File Offset: 0x002BA3CC
	public void AddTouchEmptyFingerData(TouchFingerData touchFingerData)
	{
		EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
		this.TouchEmptyFingerDataMap[fingerIndex] = touchFingerData;
	}

	// Token: 0x0600C1CB RID: 49611 RVA: 0x002BC1F0 File Offset: 0x002BA3F0
	public void RemoveTouchEmptyFingerData(TouchFingerData touchFingerData)
	{
		EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
		this.TouchEmptyFingerDataMap.Remove(fingerIndex);
	}

	// Token: 0x0600C1CC RID: 49612 RVA: 0x002BC211 File Offset: 0x002BA411
	public int GetTouchEmptyFingerDataCount()
	{
		return this.TouchEmptyFingerDataMap.Count;
	}

	// Token: 0x17001030 RID: 4144
	// (get) Token: 0x0600C1CD RID: 49613 RVA: 0x002BC21E File Offset: 0x002BA41E
	public bool IsTouching
	{
		get
		{
			return this.TouchEmptyFingerDataMap.Count > 0;
		}
	}

	// Token: 0x0600C1CE RID: 49614 RVA: 0x002BC22E File Offset: 0x002BA42E
	public bool IsTouchEmpty(EFingerIndex fingerIndex)
	{
		return this.TouchEmptyFingerDataMap.ContainsKey(fingerIndex);
	}

	// Token: 0x0600C1CF RID: 49615 RVA: 0x002BC23C File Offset: 0x002BA43C
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

	// Token: 0x0600C1D0 RID: 49616 RVA: 0x002BC2AC File Offset: 0x002BA4AC
	public void SetCommonRotationScreenRate(float rate)
	{
		this.CommonRotationScreenRateInternal = rate;
	}

	// Token: 0x0600C1D1 RID: 49617 RVA: 0x002BC2B5 File Offset: 0x002BA4B5
	public void SetArmRotationScreenRate(float rate)
	{
		this.ArmRotationScreenRateInternal = rate;
	}

	// Token: 0x0600C1D2 RID: 49618 RVA: 0x002BC2C0 File Offset: 0x002BA4C0
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

	// Token: 0x0600C1D3 RID: 49619 RVA: 0x002BC326 File Offset: 0x002BA526
	public float GetRotationScreenRate()
	{
		return this.RotationScreenRateInternal;
	}

	// Token: 0x17001031 RID: 4145
	// (get) Token: 0x0600C1D4 RID: 49620 RVA: 0x002BC32E File Offset: 0x002BA52E
	public static ControlScreenModel Instance
	{
		get
		{
			return ControlScreenModel._Instance;
		}
	}

	// Token: 0x0600C1D5 RID: 49621 RVA: 0x002BC335 File Offset: 0x002BA535
	public static ControlScreenModel GetOrCreateInstance()
	{
		if (ControlScreenModel._Instance == null)
		{
			ControlScreenModel.CreateInstance();
		}
		return ControlScreenModel._Instance;
	}

	// Token: 0x0600C1D6 RID: 49622 RVA: 0x002BC349 File Offset: 0x002BA549
	public static bool CreateInstance()
	{
		if (ControlScreenModel._Instance != null)
		{
			return true;
		}
		ControlScreenModel._Instance = new ControlScreenModel();
		return true;
	}

	// Token: 0x0600C1D7 RID: 49623 RVA: 0x002BC35F File Offset: 0x002BA55F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C1D8 RID: 49624 RVA: 0x002BC361 File Offset: 0x002BA561
	public static void ResetStaticDefaultValue()
	{
		ControlScreenModel._Instance = null;
	}

	// Token: 0x0600C1D9 RID: 49625 RVA: 0x002BC369 File Offset: 0x002BA569
	static ControlScreenModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ControlScreenModel.CreateStaticDefaultValue), new Action(ControlScreenModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005942 RID: 22850
	private float CommonRotationScreenRateInternal = 0.3f;

	// Token: 0x04005943 RID: 22851
	private float ArmRotationScreenRateInternal = 0.3f;

	// Token: 0x04005944 RID: 22852
	private float RotationScreenRateInternal = 0.3f;

	// Token: 0x04005945 RID: 22853
	public float MinTouchMoveDifference;

	// Token: 0x04005946 RID: 22854
	public float MaxTouchMoveDifference;

	// Token: 0x04005947 RID: 22855
	public float MaxTouchMoveValue;

	// Token: 0x04005948 RID: 22856
	public float MinTouchMoveValue;

	// Token: 0x04005949 RID: 22857
	private Number CurrentTouchTimeStamp = 0;

	// Token: 0x0400594A RID: 22858
	private int CurrentTouchId;

	// Token: 0x0400594B RID: 22859
	private Number DoubleTouchTime = 0;

	// Token: 0x0400594C RID: 22860
	private readonly Dictionary<EFingerIndex, TouchFingerData> TouchEmptyFingerDataMap = new Dictionary<EFingerIndex, TouchFingerData>();

	// Token: 0x0400594D RID: 22861
	[Nullable(2)]
	private USceneComponent CurrentEnterComponent;

	// Token: 0x0400594E RID: 22862
	[Nullable(2)]
	private USceneComponent CurrentPressComponent;

	// Token: 0x0400594F RID: 22863
	[Nullable(2)]
	private static ControlScreenModel _Instance;
}
