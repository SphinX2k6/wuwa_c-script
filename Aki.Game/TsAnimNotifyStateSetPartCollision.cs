using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200016E RID: 366
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetPartCollision.TsAnimNotifyStateSetPartCollision_C")]
public class TsAnimNotifyStateSetPartCollision : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003DE RID: 990
	// (get) Token: 0x06001770 RID: 6000 RVA: 0x00081773 File Offset: 0x0007F973
	// (set) Token: 0x06001771 RID: 6001 RVA: 0x00081787 File Offset: 0x0007F987
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string CompName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateSetPartCollision.__PropertyOffset_CompName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateSetPartCollision.__PropertyOffset_CompName)), value);
		}
	}

	// Token: 0x170003DF RID: 991
	// (get) Token: 0x06001772 RID: 6002 RVA: 0x0008179C File Offset: 0x0007F99C
	// (set) Token: 0x06001773 RID: 6003 RVA: 0x000817D5 File Offset: 0x0007F9D5
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> CompNames
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._CompNames) == null)
			{
				result = (this._CompNames = new TArray<string>(base.NativePtr + (IntPtr)TsAnimNotifyStateSetPartCollision.__PropertyOffset_CompNames, this));
			}
			return result;
		}
		set
		{
			this.CompNames.CopyAssign(value);
		}
	}

	// Token: 0x170003E0 RID: 992
	// (get) Token: 0x06001774 RID: 6004 RVA: 0x000817E3 File Offset: 0x0007F9E3
	// (set) Token: 0x06001775 RID: 6005 RVA: 0x000817F3 File Offset: 0x0007F9F3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsBlockPawn
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetPartCollision.__PropertyOffset_IsBlockPawn) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetPartCollision.__PropertyOffset_IsBlockPawn) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003E1 RID: 993
	// (get) Token: 0x06001776 RID: 6006 RVA: 0x00081804 File Offset: 0x0007FA04
	// (set) Token: 0x06001777 RID: 6007 RVA: 0x00081814 File Offset: 0x0007FA14
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsBulletDetect
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetPartCollision.__PropertyOffset_IsBulletDetect) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetPartCollision.__PropertyOffset_IsBulletDetect) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003E2 RID: 994
	// (get) Token: 0x06001778 RID: 6008 RVA: 0x00081825 File Offset: 0x0007FA25
	// (set) Token: 0x06001779 RID: 6009 RVA: 0x00081835 File Offset: 0x0007FA35
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsBlockCamera
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetPartCollision.__PropertyOffset_IsBlockCamera) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetPartCollision.__PropertyOffset_IsBlockCamera) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003E3 RID: 995
	// (get) Token: 0x0600177A RID: 6010 RVA: 0x00081846 File Offset: 0x0007FA46
	// (set) Token: 0x0600177B RID: 6011 RVA: 0x00081856 File Offset: 0x0007FA56
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsActiveOcclusionDither
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetPartCollision.__PropertyOffset_IsActiveOcclusionDither) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetPartCollision.__PropertyOffset_IsActiveOcclusionDither) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x00081868 File Offset: 0x0007FA68
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetPartCollision) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSetPartCollision.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x00081928 File Offset: 0x0007FB28
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			if (!string.IsNullOrEmpty(this.CompName))
			{
				this.SetPartCollisionSwitch(owner as TsBaseCharacter, this.CompName, this.IsBlockPawn, this.IsBulletDetect, this.IsBlockCamera, this.IsActiveOcclusionDither, false);
			}
			for (int i = 0; i < this.CompNames.Num(); i++)
			{
				string text = this.CompNames.Get(i);
				if (text.Length > 0)
				{
					this.SetPartCollisionSwitch(owner as TsBaseCharacter, text.ToString(), this.IsBlockPawn, this.IsBulletDetect, this.IsBlockCamera, this.IsActiveOcclusionDither, false);
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600177E RID: 6014 RVA: 0x000819DC File Offset: 0x0007FBDC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetPartCollision) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSetPartCollision.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x00081A94 File Offset: 0x0007FC94
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			SPartHitEffect partConf = (owner as TsBaseCharacter).CharacterActorComponent.GetPartConf(this.CompName);
			if (partConf != null)
			{
				this.SetPartCollisionSwitch(owner as TsBaseCharacter, this.CompName, partConf.IsBlockPawn, partConf.IsBulletDetect, partConf.IsBlockCamera, partConf.IsActiveOcclusionDither, partConf.IsIgnoreAllChannel);
			}
			for (int i = 0; i < this.CompNames.Num(); i++)
			{
				string text = this.CompNames.Get(i);
				SPartHitEffect partConf2 = (owner as TsBaseCharacter).CharacterActorComponent.GetPartConf(text.ToString());
				if (partConf2 != null)
				{
					this.SetPartCollisionSwitch(owner as TsBaseCharacter, text.ToString(), partConf2.IsBlockPawn, partConf2.IsBulletDetect, partConf2.IsBlockCamera, partConf2.IsActiveOcclusionDither, false);
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x00081B7C File Offset: 0x0007FD7C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetPartCollision) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSetPartCollision.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001781 RID: 6017 RVA: 0x00081C0C File Offset: 0x0007FE0C
	protected override string GetNotifyName_Implementation()
	{
		return "设置部位碰撞";
	}

	// Token: 0x06001782 RID: 6018 RVA: 0x00081C13 File Offset: 0x0007FE13
	private void SetPartCollisionSwitch(TsBaseCharacter owner, string compName, bool isBlockPawn, bool isBulletDetect, bool isBlockCamera, bool isActiveOcclusionDither, bool isIgnoreAllChannel = false)
	{
		owner.CharacterActorComponent.SetPartCollisionSwitch(compName, isBlockPawn, isBulletDetect, isBlockCamera, isActiveOcclusionDither, isIgnoreAllChannel);
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x00081C2A File Offset: 0x0007FE2A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetPartCollision._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetPartCollision.TsAnimNotifyStateSetPartCollision_C");
		}
		return TsAnimNotifyStateSetPartCollision._ClassPtr;
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x00081C50 File Offset: 0x0007FE50
	public TsAnimNotifyStateSetPartCollision() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetPartCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x00081C78 File Offset: 0x0007FE78
	public TsAnimNotifyStateSetPartCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetPartCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001786 RID: 6022 RVA: 0x00081CAB File Offset: 0x0007FEAB
	protected TsAnimNotifyStateSetPartCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x00081CB4 File Offset: 0x0007FEB4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001788 RID: 6024 RVA: 0x00081CF0 File Offset: 0x0007FEF0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001789 RID: 6025 RVA: 0x00081D23 File Offset: 0x0007FF23
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FF7 RID: 4087
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetPartCollision.TsAnimNotifyStateSetPartCollision_C";

	// Token: 0x04000FF8 RID: 4088
	private static IntPtr _ClassPtr;

	// Token: 0x04000FF9 RID: 4089
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FFA RID: 4090
	private static int __PropertyOffset_CompName;

	// Token: 0x04000FFB RID: 4091
	private static int __PropertyOffset_CompNames;

	// Token: 0x04000FFC RID: 4092
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _CompNames;

	// Token: 0x04000FFD RID: 4093
	private static int __PropertyOffset_IsBlockPawn;

	// Token: 0x04000FFE RID: 4094
	private static int __PropertyOffset_IsBulletDetect;

	// Token: 0x04000FFF RID: 4095
	private static int __PropertyOffset_IsBlockCamera;

	// Token: 0x04001000 RID: 4096
	private static int __PropertyOffset_IsActiveOcclusionDither;
}
