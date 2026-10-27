using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C0 RID: 448
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyJoinTeamQte.TsAnimNotifyJoinTeamQte_C")]
public class TsAnimNotifyJoinTeamQte : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000480 RID: 1152
	// (get) Token: 0x06001C15 RID: 7189 RVA: 0x0008F91F File Offset: 0x0008DB1F
	// (set) Token: 0x06001C16 RID: 7190 RVA: 0x0008F92F File Offset: 0x0008DB2F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int QteId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyJoinTeamQte.__PropertyOffset_QteId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyJoinTeamQte.__PropertyOffset_QteId) = value;
		}
	}

	// Token: 0x17000481 RID: 1153
	// (get) Token: 0x06001C17 RID: 7191 RVA: 0x0008F940 File Offset: 0x0008DB40
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> PreloadRoleIdList
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._PreloadRoleIdList) == null)
			{
				result = (this._PreloadRoleIdList = new TArray<int>(base.NativePtr + (IntPtr)TsAnimNotifyJoinTeamQte.__PropertyOffset_PreloadRoleIdList, this));
			}
			return result;
		}
	}

	// Token: 0x17000482 RID: 1154
	// (get) Token: 0x06001C18 RID: 7192 RVA: 0x0008F979 File Offset: 0x0008DB79
	// (set) Token: 0x06001C19 RID: 7193 RVA: 0x0008F989 File Offset: 0x0008DB89
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ShowTrialRoleTips
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyJoinTeamQte.__PropertyOffset_ShowTrialRoleTips) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyJoinTeamQte.__PropertyOffset_ShowTrialRoleTips) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x0008F99C File Offset: 0x0008DB9C
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

	// Token: 0x06001C1B RID: 7195 RVA: 0x0008FA3C File Offset: 0x0008DC3C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (GameModeModel.Instance.IsMulti)
		{
			return true;
		}
		if (this.PreloadRoleIdList == null)
		{
			return true;
		}
		long? preMessageId = null;
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return true;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null)
		{
			return true;
		}
		preMessageId = entity.GetComponent<BaseBuffComponent>().CreateAnimNotifyContent(animation.GetName(), base.exportIndex);
		int num = PanelQteController.Instance.StartAnimNotifyQte(this.QteId, meshComp, preMessageId);
		if (num <= 0)
		{
			return true;
		}
		List<int> list = new List<int>();
		for (int i = 0; i < this.PreloadRoleIdList.Num(); i++)
		{
			list.Add(this.PreloadRoleIdList.Get(i));
		}
		SceneTeamController.Instance.RegisterPanelQteJoinTeam(num, list.ToArray(), this.ShowTrialRoleTips);
		return true;
	}

	// Token: 0x06001C1C RID: 7196 RVA: 0x0008FB18 File Offset: 0x0008DD18
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

	// Token: 0x06001C1D RID: 7197 RVA: 0x0008FB93 File Offset: 0x0008DD93
	protected override string GetNotifyName_Implementation()
	{
		return "角色入队QTE";
	}

	// Token: 0x06001C1E RID: 7198 RVA: 0x0008FB9A File Offset: 0x0008DD9A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyJoinTeamQte._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyJoinTeamQte.TsAnimNotifyJoinTeamQte_C");
		}
		return TsAnimNotifyJoinTeamQte._ClassPtr;
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x0008FBC0 File Offset: 0x0008DDC0
	public TsAnimNotifyJoinTeamQte() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyJoinTeamQte.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x0008FBE8 File Offset: 0x0008DDE8
	public TsAnimNotifyJoinTeamQte(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyJoinTeamQte.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C21 RID: 7201 RVA: 0x0008FC1B File Offset: 0x0008DE1B
	protected TsAnimNotifyJoinTeamQte(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C22 RID: 7202 RVA: 0x0008FC24 File Offset: 0x0008DE24
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C23 RID: 7203 RVA: 0x0008FC57 File Offset: 0x0008DE57
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011C6 RID: 4550
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyJoinTeamQte.TsAnimNotifyJoinTeamQte_C";

	// Token: 0x040011C7 RID: 4551
	private static IntPtr _ClassPtr;

	// Token: 0x040011C8 RID: 4552
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011C9 RID: 4553
	private static int __PropertyOffset_QteId;

	// Token: 0x040011CA RID: 4554
	private static int __PropertyOffset_PreloadRoleIdList;

	// Token: 0x040011CB RID: 4555
	[Nullable(2)]
	private TArray<int> _PreloadRoleIdList;

	// Token: 0x040011CC RID: 4556
	private static int __PropertyOffset_ShowTrialRoleTips;
}
