using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000144 RID: 324
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMeshDitherDetect.TsAnimNotifyStateMeshDitherDetect_C")]
public class TsAnimNotifyStateMeshDitherDetect : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700033F RID: 831
	// (get) Token: 0x060013ED RID: 5101 RVA: 0x0006F4A0 File Offset: 0x0006D6A0
	// (set) Token: 0x060013EE RID: 5102 RVA: 0x0006F4D9 File Offset: 0x0006D6D9
	[UProperty(EPropertyFlags.CPF_None)]
	public SMeshDitherDetectConfig MeshDitherDetectConfig
	{
		get
		{
			base.FastCheckIsValid();
			SMeshDitherDetectConfig result;
			if ((result = this._MeshDitherDetectConfig) == null)
			{
				result = (this._MeshDitherDetectConfig = new SMeshDitherDetectConfig(base.NativePtr + (IntPtr)TsAnimNotifyStateMeshDitherDetect.__PropertyOffset_MeshDitherDetectConfig, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SMeshDitherDetectConfig.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateMeshDitherDetect.__PropertyOffset_MeshDitherDetectConfig, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x0006F504 File Offset: 0x0006D704
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

	// Token: 0x060013F0 RID: 5104 RVA: 0x0006F5AC File Offset: 0x0006D7AC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (this.MeshDitherDetectConfig == null)
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(((TsBaseCharacter)owner).EntityId);
		if (entityById == null || !entityById.Valid)
		{
			return false;
		}
		WorldEntity entity = entityById.Entity;
		CharacterMeshDitherDetectComponent characterMeshDitherDetectComponent = (entity != null) ? entity.GetComponent<CharacterMeshDitherDetectComponent>() : null;
		if (characterMeshDitherDetectComponent == null || !characterMeshDitherDetectComponent.Valid)
		{
			return false;
		}
		this.MeshDitherDetectConfigId = characterMeshDitherDetectComponent.EnableDetectDither(this.MeshDitherDetectConfig);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "[Mesh虚化检测]ANS开启角色Mesh检测并虚化";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", owner);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return true;
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x0006F658 File Offset: 0x0006D858
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

	// Token: 0x060013F2 RID: 5106 RVA: 0x0006F6F8 File Offset: 0x0006D8F8
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.MeshDitherDetectConfig == null)
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(((TsBaseCharacter)owner).EntityId);
		if (entityById == null || !entityById.Valid)
		{
			return false;
		}
		WorldEntity entity = entityById.Entity;
		CharacterMeshDitherDetectComponent characterMeshDitherDetectComponent = (entity != null) ? entity.GetComponent<CharacterMeshDitherDetectComponent>() : null;
		if (characterMeshDitherDetectComponent == null || !characterMeshDitherDetectComponent.Valid)
		{
			return false;
		}
		characterMeshDitherDetectComponent.DisableDetectDither(this.MeshDitherDetectConfigId);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "[Mesh虚化检测]ANS关闭角色Mesh检测并虚化";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", owner);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return true;
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x0006F7A0 File Offset: 0x0006D9A0
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

	// Token: 0x060013F4 RID: 5108 RVA: 0x0006F81B File Offset: 0x0006DA1B
	protected override string GetNotifyName_Implementation()
	{
		return "角色Mesh检测并虚化";
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x0006F822 File Offset: 0x0006DA22
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateMeshDitherDetect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMeshDitherDetect.TsAnimNotifyStateMeshDitherDetect_C");
		}
		return TsAnimNotifyStateMeshDitherDetect._ClassPtr;
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x0006F848 File Offset: 0x0006DA48
	public TsAnimNotifyStateMeshDitherDetect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateMeshDitherDetect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x0006F870 File Offset: 0x0006DA70
	public TsAnimNotifyStateMeshDitherDetect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateMeshDitherDetect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x0006F8A3 File Offset: 0x0006DAA3
	protected TsAnimNotifyStateMeshDitherDetect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x0006F8B4 File Offset: 0x0006DAB4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x0006F8F0 File Offset: 0x0006DAF0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x0006F923 File Offset: 0x0006DB23
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E6F RID: 3695
	private int MeshDitherDetectConfigId = -1;

	// Token: 0x04000E70 RID: 3696
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMeshDitherDetect.TsAnimNotifyStateMeshDitherDetect_C";

	// Token: 0x04000E71 RID: 3697
	private static IntPtr _ClassPtr;

	// Token: 0x04000E72 RID: 3698
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E73 RID: 3699
	private static int __PropertyOffset_MeshDitherDetectConfig;

	// Token: 0x04000E74 RID: 3700
	[Nullable(2)]
	private SMeshDitherDetectConfig _MeshDitherDetectConfig;
}
