using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Battle;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E2 RID: 482
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySwitchSequenceCamera.TsAnimNotifySwitchSequenceCamera_C")]
public class TsAnimNotifySwitchSequenceCamera : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x06001E56 RID: 7766 RVA: 0x0009C94B File Offset: 0x0009AB4B
	// (set) Token: 0x06001E57 RID: 7767 RVA: 0x0009C95B File Offset: 0x0009AB5B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ESequenceCameraAnsEffectiveClientType 生效客户端
	{
		get
		{
			return (ESequenceCameraAnsEffectiveClientType)(*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_生效客户端));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_生效客户端) = (byte)value;
		}
	}

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x06001E58 RID: 7768 RVA: 0x0009C96C File Offset: 0x0009AB6C
	// (set) Token: 0x06001E59 RID: 7769 RVA: 0x0009C9A5 File Offset: 0x0009ABA5
	[UProperty(EPropertyFlags.CPF_None)]
	public SSequenceCamera_Settings 特写镜头配置
	{
		get
		{
			base.FastCheckIsValid();
			SSequenceCamera_Settings result;
			if ((result = this._特写镜头配置) == null)
			{
				result = (this._特写镜头配置 = new SSequenceCamera_Settings(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_特写镜头配置, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SSequenceCamera_Settings.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_特写镜头配置, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170004E6 RID: 1254
	// (get) Token: 0x06001E5A RID: 7770 RVA: 0x0009C9CD File Offset: 0x0009ABCD
	// (set) Token: 0x06001E5B RID: 7771 RVA: 0x0009C9DD File Offset: 0x0009ABDD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool bResetLockOnCamera
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_bResetLockOnCamera) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_bResetLockOnCamera) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004E7 RID: 1255
	// (get) Token: 0x06001E5C RID: 7772 RVA: 0x0009C9EE File Offset: 0x0009ABEE
	// (set) Token: 0x06001E5D RID: 7773 RVA: 0x0009CA02 File Offset: 0x0009AC02
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FRotator AdditiveRotation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_AdditiveRotation);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_AdditiveRotation) = value;
		}
	}

	// Token: 0x170004E8 RID: 1256
	// (get) Token: 0x06001E5E RID: 7774 RVA: 0x0009CA17 File Offset: 0x0009AC17
	// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0009CA2B File Offset: 0x0009AC2B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string CameraAttachSocket
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_CameraAttachSocket)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_CameraAttachSocket)), value);
		}
	}

	// Token: 0x170004E9 RID: 1257
	// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0009CA40 File Offset: 0x0009AC40
	// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0009CA54 File Offset: 0x0009AC54
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string CameraDetectSocket
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_CameraDetectSocket)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_CameraDetectSocket)), value);
		}
	}

	// Token: 0x170004EA RID: 1258
	// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0009CA69 File Offset: 0x0009AC69
	// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0009CA79 File Offset: 0x0009AC79
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 强制播放Sequence
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_强制播放Sequence) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_强制播放Sequence) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004EB RID: 1259
	// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0009CA8A File Offset: 0x0009AC8A
	// (set) Token: 0x06001E65 RID: 7781 RVA: 0x0009CA9A File Offset: 0x0009AC9A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ExtraDetectSphereRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_ExtraDetectSphereRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_ExtraDetectSphereRadius) = value;
		}
	}

	// Token: 0x170004EC RID: 1260
	// (get) Token: 0x06001E66 RID: 7782 RVA: 0x0009CAAB File Offset: 0x0009ACAB
	// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0009CABF File Offset: 0x0009ACBF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector ExtraSphereLocation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_ExtraSphereLocation);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_ExtraSphereLocation) = value;
		}
	}

	// Token: 0x170004ED RID: 1261
	// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0009CAD4 File Offset: 0x0009ACD4
	// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0009CAE4 File Offset: 0x0009ACE4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsShowExtraSphere
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_IsShowExtraSphere) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_IsShowExtraSphere) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004EE RID: 1262
	// (get) Token: 0x06001E6A RID: 7786 RVA: 0x0009CAF5 File Offset: 0x0009ACF5
	// (set) Token: 0x06001E6B RID: 7787 RVA: 0x0009CB05 File Offset: 0x0009AD05
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsIgnoreCharacterCollision
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_IsIgnoreCharacterCollision) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_IsIgnoreCharacterCollision) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004EF RID: 1263
	// (get) Token: 0x06001E6C RID: 7788 RVA: 0x0009CB16 File Offset: 0x0009AD16
	// (set) Token: 0x06001E6D RID: 7789 RVA: 0x0009CB26 File Offset: 0x0009AD26
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DisableMovementInput
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_DisableMovementInput) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_DisableMovementInput) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004F0 RID: 1264
	// (get) Token: 0x06001E6E RID: 7790 RVA: 0x0009CB37 File Offset: 0x0009AD37
	// (set) Token: 0x06001E6F RID: 7791 RVA: 0x0009CB47 File Offset: 0x0009AD47
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DisableLookAtInput
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_DisableLookAtInput) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_DisableLookAtInput) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004F1 RID: 1265
	// (get) Token: 0x06001E70 RID: 7792 RVA: 0x0009CB58 File Offset: 0x0009AD58
	// (set) Token: 0x06001E71 RID: 7793 RVA: 0x0009CB68 File Offset: 0x0009AD68
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DisableMotionBlur
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_DisableMotionBlur) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_DisableMotionBlur) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004F2 RID: 1266
	// (get) Token: 0x06001E72 RID: 7794 RVA: 0x0009CB79 File Offset: 0x0009AD79
	// (set) Token: 0x06001E73 RID: 7795 RVA: 0x0009CB89 File Offset: 0x0009AD89
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 启用特定功能下的镜头配置
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_启用特定功能下的镜头配置) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_启用特定功能下的镜头配置) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004F3 RID: 1267
	// (get) Token: 0x06001E74 RID: 7796 RVA: 0x0009CB9C File Offset: 0x0009AD9C
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<SSequenceCamera_SpecificConfig> 特定功能下的镜头配置
	{
		get
		{
			base.FastCheckIsValid();
			TArray<SSequenceCamera_SpecificConfig> result;
			if ((result = this._特定功能下的镜头配置) == null)
			{
				result = (this._特定功能下的镜头配置 = new TArray<SSequenceCamera_SpecificConfig>(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_特定功能下的镜头配置, this));
			}
			return result;
		}
	}

	// Token: 0x170004F4 RID: 1268
	// (get) Token: 0x06001E75 RID: 7797 RVA: 0x0009CBD5 File Offset: 0x0009ADD5
	// (set) Token: 0x06001E76 RID: 7798 RVA: 0x0009CBE5 File Offset: 0x0009ADE5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ShotBeforePlaying
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_ShotBeforePlaying) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_ShotBeforePlaying) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004F5 RID: 1269
	// (get) Token: 0x06001E77 RID: 7799 RVA: 0x0009CBF6 File Offset: 0x0009ADF6
	// (set) Token: 0x06001E78 RID: 7800 RVA: 0x0009CC06 File Offset: 0x0009AE06
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ShotDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_ShotDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySwitchSequenceCamera.__PropertyOffset_ShotDuration) = value;
		}
	}

	// Token: 0x06001E79 RID: 7801 RVA: 0x0009CC18 File Offset: 0x0009AE18
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySwitchSequenceCamera) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifySwitchSequenceCamera.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001E7A RID: 7802 RVA: 0x0009CCD0 File Offset: 0x0009AED0
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsAnimNotifySwitchSequenceCamera.<>c__DisplayClass54_0 CS$<>8__locals1 = new TsAnimNotifySwitchSequenceCamera.<>c__DisplayClass54_0();
		CS$<>8__locals1.<>4__this = this;
		AActor owner = meshComp.GetOwner();
		CS$<>8__locals1.tsBaseCharacter = (owner as TsBaseCharacter);
		if (CS$<>8__locals1.tsBaseCharacter == null)
		{
			return false;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(CS$<>8__locals1.tsBaseCharacter.EntityId);
		if (entityById == null || !entityById.Valid)
		{
			return false;
		}
		if (!CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(entityById))
		{
			return false;
		}
		CS$<>8__locals1.specificConfig = null;
		ESequenceCameraAnsEffectiveClientType sequenceCameraAnsEffectiveClientType = this.生效客户端;
		if (this.启用特定功能下的镜头配置)
		{
			CS$<>8__locals1.specificConfig = this.GetSpecificConfig();
			if (CS$<>8__locals1.specificConfig != null)
			{
				sequenceCameraAnsEffectiveClientType = CS$<>8__locals1.specificConfig.OverrideCondition;
			}
		}
		if (!CameraUtility.CheckCameraSequenceCondition(CS$<>8__locals1.tsBaseCharacter, sequenceCameraAnsEffectiveClientType))
		{
			return false;
		}
		WorldEntity entity = entityById.Entity;
		BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
		Skill skill = (baseSkillComponent != null) ? baseSkillComponent.CurrentSkill : null;
		CS$<>8__locals1.skillEntityId = ((skill != null) ? new int?(CS$<>8__locals1.tsBaseCharacter.EntityId) : null);
		TsAnimNotifySwitchSequenceCamera.<>c__DisplayClass54_0 CS$<>8__locals2 = CS$<>8__locals1;
		int? num = (skill != null) ? new int?(skill.SkillId) : null;
		CS$<>8__locals2.skillId = ((num != null) ? new long?((long)num.GetValueOrDefault()) : null);
		if (this.ShotBeforePlaying)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.GetSceneColorShotBeforeTonemapNow 1", null);
			TimerSystem.Instance.Next(delegate(float _)
			{
				CameraController.Instance.MainModel.SequenceCamera.PlayerComponent.PlayCameraSequence(CS$<>8__locals1.<>4__this.特写镜头配置, CS$<>8__locals1.<>4__this.bResetLockOnCamera, CS$<>8__locals1.<>4__this.AdditiveRotation, CS$<>8__locals1.tsBaseCharacter, StringUtils.IsEmpty(CS$<>8__locals1.<>4__this.CameraAttachSocket) ? FNameUtil.EMPTY : FNameUtil.GetDynamicFName(CS$<>8__locals1.<>4__this.CameraAttachSocket).Value, StringUtils.IsEmpty(CS$<>8__locals1.<>4__this.CameraDetectSocket) ? FNameUtil.EMPTY : FNameUtil.GetDynamicFName(CS$<>8__locals1.<>4__this.CameraDetectSocket).Value, CS$<>8__locals1.<>4__this.ExtraSphereLocation, CS$<>8__locals1.<>4__this.ExtraDetectSphereRadius, CS$<>8__locals1.<>4__this.IsShowExtraSphere, CS$<>8__locals1.<>4__this.IsIgnoreCharacterCollision, CS$<>8__locals1.<>4__this.DisableMovementInput, CS$<>8__locals1.<>4__this.DisableLookAtInput, CS$<>8__locals1.<>4__this.DisableMotionBlur, CS$<>8__locals1.<>4__this.强制播放Sequence, CS$<>8__locals1.specificConfig, CS$<>8__locals1.skillEntityId, CS$<>8__locals1.skillId);
			}, null, null);
			TimerSystem.Instance.Delay(delegate(float _)
			{
				UKuroRenderingRuntimeBPPluginBPLibrary.ReleaseGetSceneColorShotBefore();
			}, this.ShotDuration, null, null, true, 1f);
		}
		else
		{
			CameraController.Instance.MainModel.SequenceCamera.PlayerComponent.PlayCameraSequence(this.特写镜头配置, this.bResetLockOnCamera, this.AdditiveRotation, CS$<>8__locals1.tsBaseCharacter, StringUtils.IsEmpty(this.CameraAttachSocket) ? FNameUtil.EMPTY : FNameUtil.GetDynamicFName(this.CameraAttachSocket).Value, StringUtils.IsEmpty(this.CameraDetectSocket) ? FNameUtil.EMPTY : FNameUtil.GetDynamicFName(this.CameraDetectSocket).Value, this.ExtraSphereLocation, this.ExtraDetectSphereRadius, this.IsShowExtraSphere, this.IsIgnoreCharacterCollision, this.DisableMovementInput, this.DisableLookAtInput, this.DisableMotionBlur, this.强制播放Sequence, CS$<>8__locals1.specificConfig, CS$<>8__locals1.skillEntityId, CS$<>8__locals1.skillId);
		}
		return true;
	}

	// Token: 0x06001E7B RID: 7803 RVA: 0x0009CF4C File Offset: 0x0009B14C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySwitchSequenceCamera) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifySwitchSequenceCamera.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001E7C RID: 7804 RVA: 0x0009CFDC File Offset: 0x0009B1DC
	protected override string GetNotifyName_Implementation()
	{
		return "特写镜头";
	}

	// Token: 0x06001E7D RID: 7805 RVA: 0x0009CFE4 File Offset: 0x0009B1E4
	[NullableContext(2)]
	private SSequenceCamera_SpecificConfig GetSpecificConfig()
	{
		if (this.特定功能下的镜头配置 == null)
		{
			return null;
		}
		int num = this.特定功能下的镜头配置.Num();
		for (int i = 0; i < num; i++)
		{
			SSequenceCamera_SpecificConfig ssequenceCamera_SpecificConfig = this.特定功能下的镜头配置.Get(i);
			if (!(ssequenceCamera_SpecificConfig == null) && !(ssequenceCamera_SpecificConfig.SpecificType == ESequenceCameraSpecificType.无) && ssequenceCamera_SpecificConfig.SpecificType == ESequenceCameraSpecificType.梦境链接)
			{
				BattleLinkModel instance = BattleLinkModel.Instance;
				if (instance != null && instance.CheckInDreamLink())
				{
					return ssequenceCamera_SpecificConfig;
				}
			}
		}
		return null;
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x0009D065 File Offset: 0x0009B265
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySwitchSequenceCamera._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySwitchSequenceCamera.TsAnimNotifySwitchSequenceCamera_C");
		}
		return TsAnimNotifySwitchSequenceCamera._ClassPtr;
	}

	// Token: 0x06001E7F RID: 7807 RVA: 0x0009D08C File Offset: 0x0009B28C
	public TsAnimNotifySwitchSequenceCamera() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySwitchSequenceCamera.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E80 RID: 7808 RVA: 0x0009D0B4 File Offset: 0x0009B2B4
	public TsAnimNotifySwitchSequenceCamera(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySwitchSequenceCamera.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E81 RID: 7809 RVA: 0x0009D0E7 File Offset: 0x0009B2E7
	protected TsAnimNotifySwitchSequenceCamera(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E82 RID: 7810 RVA: 0x0009D0F0 File Offset: 0x0009B2F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001E83 RID: 7811 RVA: 0x0009D123 File Offset: 0x0009B323
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040012B0 RID: 4784
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySwitchSequenceCamera.TsAnimNotifySwitchSequenceCamera_C";

	// Token: 0x040012B1 RID: 4785
	private static IntPtr _ClassPtr;

	// Token: 0x040012B2 RID: 4786
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012B3 RID: 4787
	private static int __PropertyOffset_生效客户端;

	// Token: 0x040012B4 RID: 4788
	private static int __PropertyOffset_特写镜头配置;

	// Token: 0x040012B5 RID: 4789
	[Nullable(2)]
	private SSequenceCamera_Settings _特写镜头配置;

	// Token: 0x040012B6 RID: 4790
	private static int __PropertyOffset_bResetLockOnCamera;

	// Token: 0x040012B7 RID: 4791
	private static int __PropertyOffset_AdditiveRotation;

	// Token: 0x040012B8 RID: 4792
	private static int __PropertyOffset_CameraAttachSocket;

	// Token: 0x040012B9 RID: 4793
	private static int __PropertyOffset_CameraDetectSocket;

	// Token: 0x040012BA RID: 4794
	private static int __PropertyOffset_强制播放Sequence;

	// Token: 0x040012BB RID: 4795
	private static int __PropertyOffset_ExtraDetectSphereRadius;

	// Token: 0x040012BC RID: 4796
	private static int __PropertyOffset_ExtraSphereLocation;

	// Token: 0x040012BD RID: 4797
	private static int __PropertyOffset_IsShowExtraSphere;

	// Token: 0x040012BE RID: 4798
	private static int __PropertyOffset_IsIgnoreCharacterCollision;

	// Token: 0x040012BF RID: 4799
	private static int __PropertyOffset_DisableMovementInput;

	// Token: 0x040012C0 RID: 4800
	private static int __PropertyOffset_DisableLookAtInput;

	// Token: 0x040012C1 RID: 4801
	private static int __PropertyOffset_DisableMotionBlur;

	// Token: 0x040012C2 RID: 4802
	private static int __PropertyOffset_启用特定功能下的镜头配置;

	// Token: 0x040012C3 RID: 4803
	private static int __PropertyOffset_特定功能下的镜头配置;

	// Token: 0x040012C4 RID: 4804
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SSequenceCamera_SpecificConfig> _特定功能下的镜头配置;

	// Token: 0x040012C5 RID: 4805
	private static int __PropertyOffset_ShotBeforePlaying;

	// Token: 0x040012C6 RID: 4806
	private static int __PropertyOffset_ShotDuration;
}
