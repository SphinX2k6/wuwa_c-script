using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200016A RID: 362
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetPartCollision.TsAnimNotifyStateSetPartCollision_C")]
public class TsAnimNotifyStateSetPartCollision : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003BC RID: 956
	// (get) Token: 0x060016D3 RID: 5843 RVA: 0x0007BC8F File Offset: 0x00079E8F
	// (set) Token: 0x060016D4 RID: 5844 RVA: 0x0007BCA3 File Offset: 0x00079EA3
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

	// Token: 0x170003BD RID: 957
	// (get) Token: 0x060016D5 RID: 5845 RVA: 0x0007BCB8 File Offset: 0x00079EB8
	// (set) Token: 0x060016D6 RID: 5846 RVA: 0x0007BCF1 File Offset: 0x00079EF1
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

	// Token: 0x170003BE RID: 958
	// (get) Token: 0x060016D7 RID: 5847 RVA: 0x0007BCFF File Offset: 0x00079EFF
	// (set) Token: 0x060016D8 RID: 5848 RVA: 0x0007BD0F File Offset: 0x00079F0F
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

	// Token: 0x170003BF RID: 959
	// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0007BD20 File Offset: 0x00079F20
	// (set) Token: 0x060016DA RID: 5850 RVA: 0x0007BD30 File Offset: 0x00079F30
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

	// Token: 0x170003C0 RID: 960
	// (get) Token: 0x060016DB RID: 5851 RVA: 0x0007BD41 File Offset: 0x00079F41
	// (set) Token: 0x060016DC RID: 5852 RVA: 0x0007BD51 File Offset: 0x00079F51
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

	// Token: 0x170003C1 RID: 961
	// (get) Token: 0x060016DD RID: 5853 RVA: 0x0007BD62 File Offset: 0x00079F62
	// (set) Token: 0x060016DE RID: 5854 RVA: 0x0007BD72 File Offset: 0x00079F72
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

	// Token: 0x060016DF RID: 5855 RVA: 0x0007BD84 File Offset: 0x00079F84
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x0007BE2C File Offset: 0x0007A02C
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

	// Token: 0x060016E1 RID: 5857 RVA: 0x0007BEE0 File Offset: 0x0007A0E0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
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

	// Token: 0x060016E2 RID: 5858 RVA: 0x0007BF80 File Offset: 0x0007A180
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

	// Token: 0x060016E3 RID: 5859 RVA: 0x0007C068 File Offset: 0x0007A268
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x060016E4 RID: 5860 RVA: 0x0007C0E3 File Offset: 0x0007A2E3
	protected override string GetNotifyName_Implementation()
	{
		return "设置部位碰撞";
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x0007C0EA File Offset: 0x0007A2EA
	private void SetPartCollisionSwitch(TsBaseCharacter owner, string compName, bool isBlockPawn, bool isBulletDetect, bool isBlockCamera, bool isActiveOcclusionDither, bool isIgnoreAllChannel = false)
	{
		owner.CharacterActorComponent.SetPartCollisionSwitch(compName, isBlockPawn, isBulletDetect, isBlockCamera, isActiveOcclusionDither, isIgnoreAllChannel);
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x0007C101 File Offset: 0x0007A301
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetPartCollision._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetPartCollision.TsAnimNotifyStateSetPartCollision_C");
		}
		return TsAnimNotifyStateSetPartCollision._ClassPtr;
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x0007C128 File Offset: 0x0007A328
	public TsAnimNotifyStateSetPartCollision() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetPartCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060016E8 RID: 5864 RVA: 0x0007C150 File Offset: 0x0007A350
	public TsAnimNotifyStateSetPartCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetPartCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x0007C183 File Offset: 0x0007A383
	protected TsAnimNotifyStateSetPartCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060016EA RID: 5866 RVA: 0x0007C18C File Offset: 0x0007A38C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x0007C1C8 File Offset: 0x0007A3C8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060016EC RID: 5868 RVA: 0x0007C1FB File Offset: 0x0007A3FB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FB4 RID: 4020
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetPartCollision.TsAnimNotifyStateSetPartCollision_C";

	// Token: 0x04000FB5 RID: 4021
	private static IntPtr _ClassPtr;

	// Token: 0x04000FB6 RID: 4022
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FB7 RID: 4023
	private static int __PropertyOffset_CompName;

	// Token: 0x04000FB8 RID: 4024
	private static int __PropertyOffset_CompNames;

	// Token: 0x04000FB9 RID: 4025
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _CompNames;

	// Token: 0x04000FBA RID: 4026
	private static int __PropertyOffset_IsBlockPawn;

	// Token: 0x04000FBB RID: 4027
	private static int __PropertyOffset_IsBulletDetect;

	// Token: 0x04000FBC RID: 4028
	private static int __PropertyOffset_IsBlockCamera;

	// Token: 0x04000FBD RID: 4029
	private static int __PropertyOffset_IsActiveOcclusionDither;
}
