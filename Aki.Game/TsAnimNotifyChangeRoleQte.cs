using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A7 RID: 423
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeRoleQte.TsAnimNotifyChangeRoleQte_C")]
public class TsAnimNotifyChangeRoleQte : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000474 RID: 1140
	// (get) Token: 0x06001B36 RID: 6966 RVA: 0x00090FA7 File Offset: 0x0008F1A7
	// (set) Token: 0x06001B37 RID: 6967 RVA: 0x00090FB7 File Offset: 0x0008F1B7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int QteId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyChangeRoleQte.__PropertyOffset_QteId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyChangeRoleQte.__PropertyOffset_QteId) = value;
		}
	}

	// Token: 0x17000475 RID: 1141
	// (get) Token: 0x06001B38 RID: 6968 RVA: 0x00090FC8 File Offset: 0x0008F1C8
	// (set) Token: 0x06001B39 RID: 6969 RVA: 0x00090FD8 File Offset: 0x0008F1D8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float QteDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyChangeRoleQte.__PropertyOffset_QteDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyChangeRoleQte.__PropertyOffset_QteDistance) = value;
		}
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x00090FEC File Offset: 0x0008F1EC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyChangeRoleQte) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyChangeRoleQte.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001B3B RID: 6971 RVA: 0x000910A4 File Offset: 0x0008F2A4
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (GameModeModel.Instance.IsMulti)
		{
			return true;
		}
		SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
		if (getCurrentTeamItem != null)
		{
			EntityHandle entityHandle = getCurrentTeamItem.EntityHandle;
			bool? flag;
			if (entityHandle == null)
			{
				flag = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				if (entity == null)
				{
					flag = null;
				}
				else
				{
					BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
					flag = ((component != null) ? new bool?(component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"])) : null);
				}
			}
			bool? flag2 = flag;
			if (flag2.GetValueOrDefault())
			{
				return true;
			}
		}
		if (this.QteDistance > 0f)
		{
			AActor owner = meshComp.GetOwner();
			FVectorDouble? fvectorDouble = (owner != null) ? new FVectorDouble?(owner.D_K2_GetActorLocation()) : null;
			Vector vector;
			if (getCurrentTeamItem == null)
			{
				vector = null;
			}
			else
			{
				EntityHandle entityHandle2 = getCurrentTeamItem.EntityHandle;
				if (entityHandle2 == null)
				{
					vector = null;
				}
				else
				{
					WorldEntity entity2 = entityHandle2.Entity;
					vector = ((entity2 != null) ? entity2.GetComponent<CharacterActorComponent>().ActorLocationProxy : null);
				}
			}
			Vector vector2 = vector;
			if (fvectorDouble == null || vector2 == null)
			{
				return true;
			}
			if (Math.Pow(fvectorDouble.Value.X - vector2.X, 2.0) + Math.Pow(fvectorDouble.Value.Y - vector2.Y, 2.0) + Math.Pow(fvectorDouble.Value.Z - vector2.Z, 2.0) > (double)(this.QteDistance * this.QteDistance))
			{
				return true;
			}
		}
		long? preMessageId = null;
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			object obj;
			if (tsBaseCharacter == null)
			{
				obj = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
				obj = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			object obj2 = obj;
			preMessageId = ((obj2 != null) ? obj2.GetComponent<BaseBuffComponent>().CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null);
		}
		foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(false))
		{
			long creatureDataId = sceneTeamItem.GetCreatureDataId();
			long? num = (getCurrentTeamItem != null) ? new long?(getCurrentTeamItem.GetCreatureDataId()) : null;
			if (!(creatureDataId == num.GetValueOrDefault() & num != null) && sceneTeamItem.CanGoBattle() == EGoBattleResultType.Success)
			{
				PanelQteController.Instance.StartAnimNotifyQte(this.QteId, meshComp, preMessageId);
				return true;
			}
		}
		return true;
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x0009130C File Offset: 0x0008F50C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyChangeRoleQte) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyChangeRoleQte.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001B3D RID: 6973 RVA: 0x0009139C File Offset: 0x0008F59C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "换人QTE";
	}

	// Token: 0x06001B3E RID: 6974 RVA: 0x000913A3 File Offset: 0x0008F5A3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyChangeRoleQte._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeRoleQte.TsAnimNotifyChangeRoleQte_C");
		}
		return TsAnimNotifyChangeRoleQte._ClassPtr;
	}

	// Token: 0x06001B3F RID: 6975 RVA: 0x000913C8 File Offset: 0x0008F5C8
	public TsAnimNotifyChangeRoleQte() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeRoleQte.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B40 RID: 6976 RVA: 0x000913F0 File Offset: 0x0008F5F0
	[NullableContext(1)]
	public TsAnimNotifyChangeRoleQte(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeRoleQte.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x00091423 File Offset: 0x0008F623
	protected TsAnimNotifyChangeRoleQte(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x0009142C File Offset: 0x0008F62C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B43 RID: 6979 RVA: 0x0009145F File Offset: 0x0008F65F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400117D RID: 4477
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeRoleQte.TsAnimNotifyChangeRoleQte_C";

	// Token: 0x0400117E RID: 4478
	private static IntPtr _ClassPtr;

	// Token: 0x0400117F RID: 4479
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001180 RID: 4480
	private static int __PropertyOffset_QteId;

	// Token: 0x04001181 RID: 4481
	private static int __PropertyOffset_QteDistance;
}
