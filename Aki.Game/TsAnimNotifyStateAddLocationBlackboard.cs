using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000106 RID: 262
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddLocationBlackboard.TsAnimNotifyStateAddLocationBlackboard_C")]
public class TsAnimNotifyStateAddLocationBlackboard : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000F40 RID: 3904 RVA: 0x0005863E File Offset: 0x0005683E
	static TsAnimNotifyStateAddLocationBlackboard()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateAddLocationBlackboard.CreateStaticDefaultValue), new Action(TsAnimNotifyStateAddLocationBlackboard.ResetStaticDefaultValue));
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x00058667 File Offset: 0x00056867
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateAddLocationBlackboard.paramsPool = new List<AddLocationBlackboardParams>();
		TsAnimNotifyStateAddLocationBlackboard.paramsMaps = new Dictionary<string, Dictionary<int, AddLocationBlackboardParams>>();
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x0005867D File Offset: 0x0005687D
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateAddLocationBlackboard.paramsPool = null;
		TsAnimNotifyStateAddLocationBlackboard.paramsMaps = null;
	}

	// Token: 0x17000274 RID: 628
	// (get) Token: 0x06000F43 RID: 3907 RVA: 0x0005868B File Offset: 0x0005688B
	// (set) Token: 0x06000F44 RID: 3908 RVA: 0x0005869F File Offset: 0x0005689F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string AddLocationKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_AddLocationKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_AddLocationKey)), value);
		}
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x06000F45 RID: 3909 RVA: 0x000586B4 File Offset: 0x000568B4
	// (set) Token: 0x06000F46 RID: 3910 RVA: 0x000586C8 File Offset: 0x000568C8
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat Curve
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_Curve);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_Curve, value);
		}
	}

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000586DD File Offset: 0x000568DD
	// (set) Token: 0x06000F48 RID: 3912 RVA: 0x000586ED File Offset: 0x000568ED
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NeedChangeToFlying
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_NeedChangeToFlying) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_NeedChangeToFlying) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000277 RID: 631
	// (get) Token: 0x06000F49 RID: 3913 RVA: 0x000586FE File Offset: 0x000568FE
	// (set) Token: 0x06000F4A RID: 3914 RVA: 0x0005870E File Offset: 0x0005690E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAnsBlackboardType 黑板类型
	{
		get
		{
			return (EAnsBlackboardType)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_黑板类型));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_黑板类型) = (byte)value;
		}
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x00058720 File Offset: 0x00056920
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

	// Token: 0x06000F4C RID: 3916 RVA: 0x000587C8 File Offset: 0x000569C8
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		int id = (owner as TsBaseCharacter).CharacterActorComponent.Entity.Id;
		if (string.IsNullOrEmpty(this.AddLocationKey))
		{
			return false;
		}
		Dictionary<int, AddLocationBlackboardParams> dictionary;
		if (!TsAnimNotifyStateAddLocationBlackboard.paramsMaps.TryGetValue(this.AddLocationKey, out dictionary))
		{
			dictionary = new Dictionary<int, AddLocationBlackboardParams>();
			TsAnimNotifyStateAddLocationBlackboard.paramsMaps.Add(this.AddLocationKey, dictionary);
		}
		AddLocationBlackboardParams addLocationBlackboardParams = (TsAnimNotifyStateAddLocationBlackboard.paramsPool.Count > 0) ? TsAnimNotifyStateAddLocationBlackboard.paramsPool[TsAnimNotifyStateAddLocationBlackboard.paramsPool.Count - 1] : new AddLocationBlackboardParams();
		if (TsAnimNotifyStateAddLocationBlackboard.paramsPool.Count > 0)
		{
			TsAnimNotifyStateAddLocationBlackboard.paramsPool.RemoveAt(TsAnimNotifyStateAddLocationBlackboard.paramsPool.Count - 1);
		}
		addLocationBlackboardParams.TotalDuration = totalDuration;
		addLocationBlackboardParams.RunTime = 0f;
		switch (this.黑板类型)
		{
		case EAnsBlackboardType.Direct:
		{
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(id, this.AddLocationKey);
			if (vectorValueByEntity == null)
			{
				return false;
			}
			addLocationBlackboardParams.AddOffset.FromUeVector(vectorValueByEntity);
			break;
		}
		case EAnsBlackboardType.Location:
		{
			Aki.Protocol.Vector vectorValueByEntity2 = BlackboardController.Instance.GetVectorValueByEntity(id, this.AddLocationKey);
			if (vectorValueByEntity2 == null)
			{
				return false;
			}
			addLocationBlackboardParams.AddOffset.FromUeVector(vectorValueByEntity2);
			addLocationBlackboardParams.AddOffset.SubtractionEqual((owner as TsBaseCharacter).CharacterActorComponent.ActorLocationProxy);
			break;
		}
		case EAnsBlackboardType.EntityId:
		case EAnsBlackboardType.Int:
		{
			int? num = null;
			if (this.黑板类型 == EAnsBlackboardType.EntityId)
			{
				num = BlackboardController.Instance.GetEntityIdByEntity(id, this.AddLocationKey);
			}
			else
			{
				num = BlackboardController.Instance.GetIntValueByEntity(id, this.AddLocationKey);
			}
			if (num == null)
			{
				return false;
			}
			Entity entity = EntitySystem.Instance.Get(num.Value);
			if (entity == null || !entity.Valid)
			{
				return false;
			}
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			addLocationBlackboardParams.AddOffset.DeepCopy(component.ActorLocationProxy);
			addLocationBlackboardParams.AddOffset.SubtractionEqual((owner as TsBaseCharacter).CharacterActorComponent.ActorLocationProxy);
			break;
		}
		default:
			return false;
		}
		dictionary.Add(id, addLocationBlackboardParams);
		if (this.NeedChangeToFlying)
		{
			(owner as TsBaseCharacter).KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Flying,
				Context = "[TsAnimNotifyStateAddLocationBlackboard.K2_NotifyBegin]"
			});
		}
		return true;
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x00058A08 File Offset: 0x00056C08
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float deltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = deltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x00058AB0 File Offset: 0x00056CB0
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float deltaTime)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Entity entity = (owner as TsBaseCharacter).CharacterActorComponent.Entity;
		int id = entity.Id;
		Dictionary<int, AddLocationBlackboardParams> dictionary;
		if (!TsAnimNotifyStateAddLocationBlackboard.paramsMaps.TryGetValue(this.AddLocationKey, out dictionary))
		{
			return false;
		}
		AddLocationBlackboardParams addLocationBlackboardParams;
		if (!dictionary.TryGetValue(id, out addLocationBlackboardParams))
		{
			return false;
		}
		if (addLocationBlackboardParams.RunTime >= addLocationBlackboardParams.TotalDuration)
		{
			return true;
		}
		float num = Math.Min(addLocationBlackboardParams.TotalDuration, addLocationBlackboardParams.RunTime + deltaTime);
		float num2;
		if (this.Curve != null)
		{
			num2 = this.Curve.GetFloatValue(num / addLocationBlackboardParams.TotalDuration) - this.Curve.GetFloatValue(addLocationBlackboardParams.RunTime / addLocationBlackboardParams.TotalDuration);
		}
		else
		{
			num2 = (num - addLocationBlackboardParams.RunTime) / addLocationBlackboardParams.TotalDuration;
		}
		BaseMoveComponent component = entity.GetComponent<CharacterMoveComponent>();
		addLocationBlackboardParams.AddOffset.Multiply((double)num2, TsAnimNotifyStateAddLocationBlackboard.tmpVector);
		component.MoveCharacter(TsAnimNotifyStateAddLocationBlackboard.tmpVector, deltaTime, "");
		addLocationBlackboardParams.RunTime = num;
		return true;
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x00058BC0 File Offset: 0x00056DC0
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

	// Token: 0x06000F50 RID: 3920 RVA: 0x00058C60 File Offset: 0x00056E60
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Dictionary<int, AddLocationBlackboardParams> dictionary;
		if (!TsAnimNotifyStateAddLocationBlackboard.paramsMaps.TryGetValue(this.AddLocationKey, out dictionary))
		{
			return false;
		}
		int id = (owner as TsBaseCharacter).CharacterActorComponent.Entity.Id;
		AddLocationBlackboardParams item;
		if (!dictionary.TryGetValue(id, out item))
		{
			return true;
		}
		TsAnimNotifyStateAddLocationBlackboard.paramsPool.Add(item);
		dictionary.Remove(id);
		return true;
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x00058CCC File Offset: 0x00056ECC
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

	// Token: 0x06000F52 RID: 3922 RVA: 0x00058D47 File Offset: 0x00056F47
	protected override string GetNotifyName_Implementation()
	{
		return "黑板位置设置角色位置偏移";
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x00058D4E File Offset: 0x00056F4E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddLocationBlackboard._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddLocationBlackboard.TsAnimNotifyStateAddLocationBlackboard_C");
		}
		return TsAnimNotifyStateAddLocationBlackboard._ClassPtr;
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x00058D74 File Offset: 0x00056F74
	public TsAnimNotifyStateAddLocationBlackboard() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddLocationBlackboard.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x00058D9C File Offset: 0x00056F9C
	public TsAnimNotifyStateAddLocationBlackboard(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddLocationBlackboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x00058DCF File Offset: 0x00056FCF
	protected TsAnimNotifyStateAddLocationBlackboard(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x00058DD8 File Offset: 0x00056FD8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x00058E14 File Offset: 0x00057014
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x00058E50 File Offset: 0x00057050
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00058E83 File Offset: 0x00057083
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C09 RID: 3081
	private static List<AddLocationBlackboardParams> paramsPool;

	// Token: 0x04000C0A RID: 3082
	private static Dictionary<string, Dictionary<int, AddLocationBlackboardParams>> paramsMaps;

	// Token: 0x04000C0B RID: 3083
	[StaticVariableRuleIgnore]
	private static global::Vector tmpVector = global::Vector.Create();

	// Token: 0x04000C0C RID: 3084
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddLocationBlackboard.TsAnimNotifyStateAddLocationBlackboard_C";

	// Token: 0x04000C0D RID: 3085
	private static IntPtr _ClassPtr;

	// Token: 0x04000C0E RID: 3086
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C0F RID: 3087
	private static int __PropertyOffset_AddLocationKey;

	// Token: 0x04000C10 RID: 3088
	private static int __PropertyOffset_Curve;

	// Token: 0x04000C11 RID: 3089
	private static int __PropertyOffset_NeedChangeToFlying;

	// Token: 0x04000C12 RID: 3090
	private static int __PropertyOffset_黑板类型;
}
