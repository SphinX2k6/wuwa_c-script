using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000148 RID: 328
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMeshDitherDetect.TsAnimNotifyStateMeshDitherDetect_C")]
public class TsAnimNotifyStateMeshDitherDetect : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000361 RID: 865
	// (get) Token: 0x0600148A RID: 5258 RVA: 0x0007465C File Offset: 0x0007285C
	// (set) Token: 0x0600148B RID: 5259 RVA: 0x00074695 File Offset: 0x00072895
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

	// Token: 0x0600148C RID: 5260 RVA: 0x000746C0 File Offset: 0x000728C0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateMeshDitherDetect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateMeshDitherDetect.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600148D RID: 5261 RVA: 0x00074780 File Offset: 0x00072980
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

	// Token: 0x0600148E RID: 5262 RVA: 0x0007482C File Offset: 0x00072A2C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateMeshDitherDetect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateMeshDitherDetect.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600148F RID: 5263 RVA: 0x000748E4 File Offset: 0x00072AE4
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

	// Token: 0x06001490 RID: 5264 RVA: 0x0007498C File Offset: 0x00072B8C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateMeshDitherDetect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateMeshDitherDetect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001491 RID: 5265 RVA: 0x00074A1C File Offset: 0x00072C1C
	protected override string GetNotifyName_Implementation()
	{
		return "角色Mesh检测并虚化";
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x00074A23 File Offset: 0x00072C23
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateMeshDitherDetect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMeshDitherDetect.TsAnimNotifyStateMeshDitherDetect_C");
		}
		return TsAnimNotifyStateMeshDitherDetect._ClassPtr;
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x00074A48 File Offset: 0x00072C48
	public TsAnimNotifyStateMeshDitherDetect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateMeshDitherDetect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x00074A70 File Offset: 0x00072C70
	public TsAnimNotifyStateMeshDitherDetect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateMeshDitherDetect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x00074AA3 File Offset: 0x00072CA3
	protected TsAnimNotifyStateMeshDitherDetect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x00074AB4 File Offset: 0x00072CB4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x00074AF0 File Offset: 0x00072CF0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x00074B23 File Offset: 0x00072D23
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000EB2 RID: 3762
	private int MeshDitherDetectConfigId = -1;

	// Token: 0x04000EB3 RID: 3763
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMeshDitherDetect.TsAnimNotifyStateMeshDitherDetect_C";

	// Token: 0x04000EB4 RID: 3764
	private static IntPtr _ClassPtr;

	// Token: 0x04000EB5 RID: 3765
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000EB6 RID: 3766
	private static int __PropertyOffset_MeshDitherDetectConfig;

	// Token: 0x04000EB7 RID: 3767
	[Nullable(2)]
	private SMeshDitherDetectConfig _MeshDitherDetectConfig;
}
