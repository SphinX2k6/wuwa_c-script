using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Tools;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000114 RID: 276
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBulletDuration.TsAnimNotifyStateBulletDuration_C")]
public class TsAnimNotifyStateBulletDuration : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700029C RID: 668
	// (get) Token: 0x06001050 RID: 4176 RVA: 0x0005D4A8 File Offset: 0x0005B6A8
	// (set) Token: 0x06001051 RID: 4177 RVA: 0x0005D4E1 File Offset: 0x0005B6E1
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> BulletIds
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._BulletIds) == null)
			{
				result = (this._BulletIds = new TArray<string>(base.NativePtr + (IntPtr)TsAnimNotifyStateBulletDuration.__PropertyOffset_BulletIds, this));
			}
			return result;
		}
		set
		{
			this.BulletIds.CopyAssign(value);
		}
	}

	// Token: 0x1700029D RID: 669
	// (get) Token: 0x06001052 RID: 4178 RVA: 0x0005D4F0 File Offset: 0x0005B6F0
	// (set) Token: 0x06001053 RID: 4179 RVA: 0x0005D529 File Offset: 0x0005B729
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FVector> LocationOffsets
	{
		get
		{
			base.FastCheckIsValid();
			TArray<FVector> result;
			if ((result = this._LocationOffsets) == null)
			{
				result = (this._LocationOffsets = new TArray<FVector>(base.NativePtr + (IntPtr)TsAnimNotifyStateBulletDuration.__PropertyOffset_LocationOffsets, this));
			}
			return result;
		}
		set
		{
			this.LocationOffsets.CopyAssign(value);
		}
	}

	// Token: 0x1700029E RID: 670
	// (get) Token: 0x06001054 RID: 4180 RVA: 0x0005D538 File Offset: 0x0005B738
	// (set) Token: 0x06001055 RID: 4181 RVA: 0x0005D571 File Offset: 0x0005B771
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<FRotator> RotatorOffsets
	{
		get
		{
			base.FastCheckIsValid();
			TArray<FRotator> result;
			if ((result = this._RotatorOffsets) == null)
			{
				result = (this._RotatorOffsets = new TArray<FRotator>(base.NativePtr + (IntPtr)TsAnimNotifyStateBulletDuration.__PropertyOffset_RotatorOffsets, this));
			}
			return result;
		}
		set
		{
			this.RotatorOffsets.CopyAssign(value);
		}
	}

	// Token: 0x1700029F RID: 671
	// (get) Token: 0x06001056 RID: 4182 RVA: 0x0005D57F File Offset: 0x0005B77F
	// (set) Token: 0x06001057 RID: 4183 RVA: 0x0005D58F File Offset: 0x0005B78F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DestroyEffectImmediately
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateBulletDuration.__PropertyOffset_DestroyEffectImmediately) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateBulletDuration.__PropertyOffset_DestroyEffectImmediately) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x0005D5A0 File Offset: 0x0005B7A0
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

	// Token: 0x06001059 RID: 4185 RVA: 0x0005D648 File Offset: 0x0005B848
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.Initialize();
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter || owner is TsBaseVehicle)
		{
			Entity entityNoBlueprint = (owner as TsBaseCharacter).GetEntityNoBlueprint();
			if (entityNoBlueprint != null && entityNoBlueprint.Valid)
			{
				BaseBuffComponent component = entityNoBlueprint.GetComponent<BaseBuffComponent>();
				long? preContextId = (component != null) ? component.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
				BaseSkillComponent component2 = entityNoBlueprint.GetComponent<BaseSkillComponent>();
				int skillId = (component2 != null) ? component2.GetCurrentMontageCorrespondingSkillId() : 0;
				int num3 = this.BulletIds.Num();
				int num2 = this.LocationOffsets.Num();
				List<int> list = new List<int>();
				for (int i = 0; i < num3; i++)
				{
					FVector? locationOffset = null;
					if (num2 > i)
					{
						locationOffset = new FVector?(this.LocationOffsets.Get(i));
					}
					FRotator? beginRotatorOffset = null;
					if (num2 > i)
					{
						beginRotatorOffset = new FRotator?(this.RotatorOffsets.Get(i));
					}
					list.Add(BulletUtil.CreateBulletFromAN(owner as TsBaseCharacter, this.BulletIds.Get(i), new FTransformDouble?(this.UeTransform.Value), skillId, false, preContextId, null, locationOffset, beginRotatorOffset));
				}
				this.BulletEntityIdsMap.Add(meshComp, list.ToArray());
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Bullet;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "No Entity for TsBaseCharacter";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", owner);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("location", owner.D_K2_GetActorLocation());
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		TArray<string> bulletIdArray = this.BulletIds;
		int num = bulletIdArray.Num();
		if (num <= 0)
		{
			return false;
		}
		BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(owner.GetWorld());
		if (worldType != BP_EWorldType.Editor && worldType != BP_EWorldType.EditorPreview)
		{
			return false;
		}
		ResourceSystem.Instance.LoadTypeAsync(EBpTypeName.BPL_BulletPreview.ToEnumString(), delegate
		{
			string pathName = UKismetSystemLibrary.GetPathName(UKismetSystemLibrary.GetOuterObject(this));
			this.ArrayPreviewActor = new AActor[num];
			for (int j = 0; j < num; j++)
			{
				AActor previewActor = new AActor();
				BPL_BulletPreview_C.ShowBulletPreview(pathName, new FName(bulletIdArray.Get(j)), owner, meshComp, owner.GetWorld(), ref previewActor);
				this.PreviewActor = previewActor;
				this.ArrayPreviewActor[j] = this.PreviewActor;
				this.PreviewActor = null;
			}
		}, "js_undefined");
		return false;
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x0005D8B0 File Offset: 0x0005BAB0
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

	// Token: 0x0600105B RID: 4187 RVA: 0x0005D950 File Offset: 0x0005BB50
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter || owner is TsBaseVehicle)
		{
			Entity entityNoBlueprint = (owner as TsBaseCharacter).GetEntityNoBlueprint();
			if (entityNoBlueprint != null && entityNoBlueprint.Valid)
			{
				int[] array2;
				foreach (int id in this.BulletEntityIdsMap.TryGetValue(meshComp, out array2) ? array2 : new int[0])
				{
					BulletController.Instance.DestroyBullet(id, false, EBulletDestroyReason.Normal, this.DestroyEffectImmediately);
				}
				this.BulletEntityIdsMap.Remove(meshComp);
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "No Entity for TsBaseCharacter";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", owner);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("location", owner.D_K2_GetActorLocation());
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		if (this.ArrayPreviewActor == null)
		{
			return false;
		}
		AActor[] arrayPreviewActor = this.ArrayPreviewActor;
		for (int i = 0; i < arrayPreviewActor.Length; i++)
		{
			arrayPreviewActor[i].K2_DestroyActor();
		}
		this.ArrayPreviewActor = null;
		return false;
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x0005DA78 File Offset: 0x0005BC78
	private void Initialize()
	{
		if (this.BulletEntityIdsMap == null)
		{
			this.BulletEntityIdsMap = new Dictionary<USkeletalMeshComponent, int[]>();
		}
		if (this.UeTransform == null)
		{
			this.UeTransform = new FTransformDouble?(new FTransformDouble());
		}
	}

	// Token: 0x0600105D RID: 4189 RVA: 0x0005DAAC File Offset: 0x0005BCAC
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

	// Token: 0x0600105E RID: 4190 RVA: 0x0005DB27 File Offset: 0x0005BD27
	protected override string GetNotifyName_Implementation()
	{
		return "创建子弹";
	}

	// Token: 0x0600105F RID: 4191 RVA: 0x0005DB2E File Offset: 0x0005BD2E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateBulletDuration._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBulletDuration.TsAnimNotifyStateBulletDuration_C");
		}
		return TsAnimNotifyStateBulletDuration._ClassPtr;
	}

	// Token: 0x06001060 RID: 4192 RVA: 0x0005DB54 File Offset: 0x0005BD54
	public TsAnimNotifyStateBulletDuration() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBulletDuration.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001061 RID: 4193 RVA: 0x0005DB7C File Offset: 0x0005BD7C
	public TsAnimNotifyStateBulletDuration(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBulletDuration.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x0005DBAF File Offset: 0x0005BDAF
	protected TsAnimNotifyStateBulletDuration(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x0005DBB8 File Offset: 0x0005BDB8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x0005DBF4 File Offset: 0x0005BDF4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x0005DC27 File Offset: 0x0005BE27
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C90 RID: 3216
	public Dictionary<USkeletalMeshComponent, int[]> BulletEntityIdsMap;

	// Token: 0x04000C91 RID: 3217
	private FTransformDouble? UeTransform;

	// Token: 0x04000C92 RID: 3218
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private AActor[] ArrayPreviewActor;

	// Token: 0x04000C93 RID: 3219
	[Nullable(2)]
	private AActor PreviewActor;

	// Token: 0x04000C94 RID: 3220
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBulletDuration.TsAnimNotifyStateBulletDuration_C";

	// Token: 0x04000C95 RID: 3221
	private static IntPtr _ClassPtr;

	// Token: 0x04000C96 RID: 3222
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C97 RID: 3223
	private static int __PropertyOffset_BulletIds;

	// Token: 0x04000C98 RID: 3224
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _BulletIds;

	// Token: 0x04000C99 RID: 3225
	private static int __PropertyOffset_LocationOffsets;

	// Token: 0x04000C9A RID: 3226
	[Nullable(2)]
	private TArray<FVector> _LocationOffsets;

	// Token: 0x04000C9B RID: 3227
	private static int __PropertyOffset_RotatorOffsets;

	// Token: 0x04000C9C RID: 3228
	[Nullable(2)]
	private TArray<FRotator> _RotatorOffsets;

	// Token: 0x04000C9D RID: 3229
	private static int __PropertyOffset_DestroyEffectImmediately;
}
