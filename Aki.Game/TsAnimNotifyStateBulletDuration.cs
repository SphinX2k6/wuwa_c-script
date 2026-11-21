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
	// Token: 0x1700029F RID: 671
	// (get) Token: 0x06001056 RID: 4182 RVA: 0x0005E71C File Offset: 0x0005C91C
	// (set) Token: 0x06001057 RID: 4183 RVA: 0x0005E755 File Offset: 0x0005C955
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

	// Token: 0x170002A0 RID: 672
	// (get) Token: 0x06001058 RID: 4184 RVA: 0x0005E764 File Offset: 0x0005C964
	// (set) Token: 0x06001059 RID: 4185 RVA: 0x0005E79D File Offset: 0x0005C99D
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

	// Token: 0x170002A1 RID: 673
	// (get) Token: 0x0600105A RID: 4186 RVA: 0x0005E7AC File Offset: 0x0005C9AC
	// (set) Token: 0x0600105B RID: 4187 RVA: 0x0005E7E5 File Offset: 0x0005C9E5
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

	// Token: 0x170002A2 RID: 674
	// (get) Token: 0x0600105C RID: 4188 RVA: 0x0005E7F3 File Offset: 0x0005C9F3
	// (set) Token: 0x0600105D RID: 4189 RVA: 0x0005E803 File Offset: 0x0005CA03
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

	// Token: 0x0600105E RID: 4190 RVA: 0x0005E814 File Offset: 0x0005CA14
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateBulletDuration) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateBulletDuration.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600105F RID: 4191 RVA: 0x0005E8D4 File Offset: 0x0005CAD4
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

	// Token: 0x06001060 RID: 4192 RVA: 0x0005EB3C File Offset: 0x0005CD3C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateBulletDuration) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateBulletDuration.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001061 RID: 4193 RVA: 0x0005EBF4 File Offset: 0x0005CDF4
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

	// Token: 0x06001062 RID: 4194 RVA: 0x0005ED1C File Offset: 0x0005CF1C
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

	// Token: 0x06001063 RID: 4195 RVA: 0x0005ED50 File Offset: 0x0005CF50
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateBulletDuration) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateBulletDuration.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001064 RID: 4196 RVA: 0x0005EDE0 File Offset: 0x0005CFE0
	protected override string GetNotifyName_Implementation()
	{
		return "创建子弹";
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x0005EDE7 File Offset: 0x0005CFE7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateBulletDuration._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBulletDuration.TsAnimNotifyStateBulletDuration_C");
		}
		return TsAnimNotifyStateBulletDuration._ClassPtr;
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x0005EE0C File Offset: 0x0005D00C
	public TsAnimNotifyStateBulletDuration() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBulletDuration.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x0005EE34 File Offset: 0x0005D034
	public TsAnimNotifyStateBulletDuration(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBulletDuration.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x0005EE67 File Offset: 0x0005D067
	protected TsAnimNotifyStateBulletDuration(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x0005EE70 File Offset: 0x0005D070
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x0005EEAC File Offset: 0x0005D0AC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x0005EEDF File Offset: 0x0005D0DF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C98 RID: 3224
	public Dictionary<USkeletalMeshComponent, int[]> BulletEntityIdsMap;

	// Token: 0x04000C99 RID: 3225
	private FTransformDouble? UeTransform;

	// Token: 0x04000C9A RID: 3226
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private AActor[] ArrayPreviewActor;

	// Token: 0x04000C9B RID: 3227
	[Nullable(2)]
	private AActor PreviewActor;

	// Token: 0x04000C9C RID: 3228
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBulletDuration.TsAnimNotifyStateBulletDuration_C";

	// Token: 0x04000C9D RID: 3229
	private static IntPtr _ClassPtr;

	// Token: 0x04000C9E RID: 3230
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C9F RID: 3231
	private static int __PropertyOffset_BulletIds;

	// Token: 0x04000CA0 RID: 3232
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _BulletIds;

	// Token: 0x04000CA1 RID: 3233
	private static int __PropertyOffset_LocationOffsets;

	// Token: 0x04000CA2 RID: 3234
	[Nullable(2)]
	private TArray<FVector> _LocationOffsets;

	// Token: 0x04000CA3 RID: 3235
	private static int __PropertyOffset_RotatorOffsets;

	// Token: 0x04000CA4 RID: 3236
	[Nullable(2)]
	private TArray<FRotator> _RotatorOffsets;

	// Token: 0x04000CA5 RID: 3237
	private static int __PropertyOffset_DestroyEffectImmediately;
}
