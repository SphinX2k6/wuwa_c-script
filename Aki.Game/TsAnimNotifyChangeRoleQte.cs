using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A3 RID: 419
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeRoleQte.TsAnimNotifyChangeRoleQte_C")]
public class TsAnimNotifyChangeRoleQte : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000452 RID: 1106
	// (get) Token: 0x06001A99 RID: 6809 RVA: 0x0008A907 File Offset: 0x00088B07
	// (set) Token: 0x06001A9A RID: 6810 RVA: 0x0008A917 File Offset: 0x00088B17
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

	// Token: 0x17000453 RID: 1107
	// (get) Token: 0x06001A9B RID: 6811 RVA: 0x0008A928 File Offset: 0x00088B28
	// (set) Token: 0x06001A9C RID: 6812 RVA: 0x0008A938 File Offset: 0x00088B38
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

	// Token: 0x06001A9D RID: 6813 RVA: 0x0008A94C File Offset: 0x00088B4C
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

	// Token: 0x06001A9E RID: 6814 RVA: 0x0008A9EC File Offset: 0x00088BEC
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

	// Token: 0x06001A9F RID: 6815 RVA: 0x0008AC54 File Offset: 0x00088E54
	[NullableContext(1)]
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

	// Token: 0x06001AA0 RID: 6816 RVA: 0x0008ACCF File Offset: 0x00088ECF
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "换人QTE";
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x0008ACD6 File Offset: 0x00088ED6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyChangeRoleQte._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeRoleQte.TsAnimNotifyChangeRoleQte_C");
		}
		return TsAnimNotifyChangeRoleQte._ClassPtr;
	}

	// Token: 0x06001AA2 RID: 6818 RVA: 0x0008ACFC File Offset: 0x00088EFC
	public TsAnimNotifyChangeRoleQte() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeRoleQte.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001AA3 RID: 6819 RVA: 0x0008AD24 File Offset: 0x00088F24
	[NullableContext(1)]
	public TsAnimNotifyChangeRoleQte(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeRoleQte.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001AA4 RID: 6820 RVA: 0x0008AD57 File Offset: 0x00088F57
	protected TsAnimNotifyChangeRoleQte(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001AA5 RID: 6821 RVA: 0x0008AD60 File Offset: 0x00088F60
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001AA6 RID: 6822 RVA: 0x0008AD93 File Offset: 0x00088F93
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400113A RID: 4410
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeRoleQte.TsAnimNotifyChangeRoleQte_C";

	// Token: 0x0400113B RID: 4411
	private static IntPtr _ClassPtr;

	// Token: 0x0400113C RID: 4412
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400113D RID: 4413
	private static int __PropertyOffset_QteId;

	// Token: 0x0400113E RID: 4414
	private static int __PropertyOffset_QteDistance;
}
