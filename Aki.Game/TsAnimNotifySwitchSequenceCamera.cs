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

// Token: 0x020001DE RID: 478
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySwitchSequenceCamera.TsAnimNotifySwitchSequenceCamera_C")]
public class TsAnimNotifySwitchSequenceCamera : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004C2 RID: 1218
	// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x0009598F File Offset: 0x00093B8F
	// (set) Token: 0x06001DBA RID: 7610 RVA: 0x0009599F File Offset: 0x00093B9F
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

	// Token: 0x170004C3 RID: 1219
	// (get) Token: 0x06001DBB RID: 7611 RVA: 0x000959B0 File Offset: 0x00093BB0
	// (set) Token: 0x06001DBC RID: 7612 RVA: 0x000959E9 File Offset: 0x00093BE9
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

	// Token: 0x170004C4 RID: 1220
	// (get) Token: 0x06001DBD RID: 7613 RVA: 0x00095A11 File Offset: 0x00093C11
	// (set) Token: 0x06001DBE RID: 7614 RVA: 0x00095A21 File Offset: 0x00093C21
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

	// Token: 0x170004C5 RID: 1221
	// (get) Token: 0x06001DBF RID: 7615 RVA: 0x00095A32 File Offset: 0x00093C32
	// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x00095A46 File Offset: 0x00093C46
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

	// Token: 0x170004C6 RID: 1222
	// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x00095A5B File Offset: 0x00093C5B
	// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x00095A6F File Offset: 0x00093C6F
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

	// Token: 0x170004C7 RID: 1223
	// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x00095A84 File Offset: 0x00093C84
	// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x00095A98 File Offset: 0x00093C98
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

	// Token: 0x170004C8 RID: 1224
	// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00095AAD File Offset: 0x00093CAD
	// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x00095ABD File Offset: 0x00093CBD
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

	// Token: 0x170004C9 RID: 1225
	// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x00095ACE File Offset: 0x00093CCE
	// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x00095ADE File Offset: 0x00093CDE
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

	// Token: 0x170004CA RID: 1226
	// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x00095AEF File Offset: 0x00093CEF
	// (set) Token: 0x06001DCA RID: 7626 RVA: 0x00095B03 File Offset: 0x00093D03
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

	// Token: 0x170004CB RID: 1227
	// (get) Token: 0x06001DCB RID: 7627 RVA: 0x00095B18 File Offset: 0x00093D18
	// (set) Token: 0x06001DCC RID: 7628 RVA: 0x00095B28 File Offset: 0x00093D28
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

	// Token: 0x170004CC RID: 1228
	// (get) Token: 0x06001DCD RID: 7629 RVA: 0x00095B39 File Offset: 0x00093D39
	// (set) Token: 0x06001DCE RID: 7630 RVA: 0x00095B49 File Offset: 0x00093D49
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

	// Token: 0x170004CD RID: 1229
	// (get) Token: 0x06001DCF RID: 7631 RVA: 0x00095B5A File Offset: 0x00093D5A
	// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x00095B6A File Offset: 0x00093D6A
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

	// Token: 0x170004CE RID: 1230
	// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x00095B7B File Offset: 0x00093D7B
	// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x00095B8B File Offset: 0x00093D8B
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

	// Token: 0x170004CF RID: 1231
	// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x00095B9C File Offset: 0x00093D9C
	// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x00095BAC File Offset: 0x00093DAC
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

	// Token: 0x170004D0 RID: 1232
	// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x00095BBD File Offset: 0x00093DBD
	// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x00095BCD File Offset: 0x00093DCD
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

	// Token: 0x170004D1 RID: 1233
	// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00095BE0 File Offset: 0x00093DE0
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

	// Token: 0x170004D2 RID: 1234
	// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00095C19 File Offset: 0x00093E19
	// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x00095C29 File Offset: 0x00093E29
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

	// Token: 0x170004D3 RID: 1235
	// (get) Token: 0x06001DDA RID: 7642 RVA: 0x00095C3A File Offset: 0x00093E3A
	// (set) Token: 0x06001DDB RID: 7643 RVA: 0x00095C4A File Offset: 0x00093E4A
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

	// Token: 0x06001DDC RID: 7644 RVA: 0x00095C5C File Offset: 0x00093E5C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001DDD RID: 7645 RVA: 0x00095CFC File Offset: 0x00093EFC
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

	// Token: 0x06001DDE RID: 7646 RVA: 0x00095F78 File Offset: 0x00094178
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x06001DDF RID: 7647 RVA: 0x00095FF3 File Offset: 0x000941F3
	protected override string GetNotifyName_Implementation()
	{
		return "特写镜头";
	}

	// Token: 0x06001DE0 RID: 7648 RVA: 0x00095FFC File Offset: 0x000941FC
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

	// Token: 0x06001DE1 RID: 7649 RVA: 0x0009607D File Offset: 0x0009427D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySwitchSequenceCamera._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySwitchSequenceCamera.TsAnimNotifySwitchSequenceCamera_C");
		}
		return TsAnimNotifySwitchSequenceCamera._ClassPtr;
	}

	// Token: 0x06001DE2 RID: 7650 RVA: 0x000960A4 File Offset: 0x000942A4
	public TsAnimNotifySwitchSequenceCamera() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySwitchSequenceCamera.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001DE3 RID: 7651 RVA: 0x000960CC File Offset: 0x000942CC
	public TsAnimNotifySwitchSequenceCamera(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySwitchSequenceCamera.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001DE4 RID: 7652 RVA: 0x000960FF File Offset: 0x000942FF
	protected TsAnimNotifySwitchSequenceCamera(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001DE5 RID: 7653 RVA: 0x00096108 File Offset: 0x00094308
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001DE6 RID: 7654 RVA: 0x0009613B File Offset: 0x0009433B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400126D RID: 4717
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySwitchSequenceCamera.TsAnimNotifySwitchSequenceCamera_C";

	// Token: 0x0400126E RID: 4718
	private static IntPtr _ClassPtr;

	// Token: 0x0400126F RID: 4719
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001270 RID: 4720
	private static int __PropertyOffset_生效客户端;

	// Token: 0x04001271 RID: 4721
	private static int __PropertyOffset_特写镜头配置;

	// Token: 0x04001272 RID: 4722
	[Nullable(2)]
	private SSequenceCamera_Settings _特写镜头配置;

	// Token: 0x04001273 RID: 4723
	private static int __PropertyOffset_bResetLockOnCamera;

	// Token: 0x04001274 RID: 4724
	private static int __PropertyOffset_AdditiveRotation;

	// Token: 0x04001275 RID: 4725
	private static int __PropertyOffset_CameraAttachSocket;

	// Token: 0x04001276 RID: 4726
	private static int __PropertyOffset_CameraDetectSocket;

	// Token: 0x04001277 RID: 4727
	private static int __PropertyOffset_强制播放Sequence;

	// Token: 0x04001278 RID: 4728
	private static int __PropertyOffset_ExtraDetectSphereRadius;

	// Token: 0x04001279 RID: 4729
	private static int __PropertyOffset_ExtraSphereLocation;

	// Token: 0x0400127A RID: 4730
	private static int __PropertyOffset_IsShowExtraSphere;

	// Token: 0x0400127B RID: 4731
	private static int __PropertyOffset_IsIgnoreCharacterCollision;

	// Token: 0x0400127C RID: 4732
	private static int __PropertyOffset_DisableMovementInput;

	// Token: 0x0400127D RID: 4733
	private static int __PropertyOffset_DisableLookAtInput;

	// Token: 0x0400127E RID: 4734
	private static int __PropertyOffset_DisableMotionBlur;

	// Token: 0x0400127F RID: 4735
	private static int __PropertyOffset_启用特定功能下的镜头配置;

	// Token: 0x04001280 RID: 4736
	private static int __PropertyOffset_特定功能下的镜头配置;

	// Token: 0x04001281 RID: 4737
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<SSequenceCamera_SpecificConfig> _特定功能下的镜头配置;

	// Token: 0x04001282 RID: 4738
	private static int __PropertyOffset_ShotBeforePlaying;

	// Token: 0x04001283 RID: 4739
	private static int __PropertyOffset_ShotDuration;
}
