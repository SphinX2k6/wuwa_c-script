using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C4 RID: 452
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyJoinTeamQte.TsAnimNotifyJoinTeamQte_C")]
public class TsAnimNotifyJoinTeamQte : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004A2 RID: 1186
	// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00096437 File Offset: 0x00094637
	// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x00096447 File Offset: 0x00094647
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

	// Token: 0x170004A3 RID: 1187
	// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00096458 File Offset: 0x00094658
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

	// Token: 0x170004A4 RID: 1188
	// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x00096491 File Offset: 0x00094691
	// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x000964A1 File Offset: 0x000946A1
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

	// Token: 0x06001CB7 RID: 7351 RVA: 0x000964B4 File Offset: 0x000946B4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyJoinTeamQte) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyJoinTeamQte.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001CB8 RID: 7352 RVA: 0x0009656C File Offset: 0x0009476C
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

	// Token: 0x06001CB9 RID: 7353 RVA: 0x00096648 File Offset: 0x00094848
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyJoinTeamQte) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyJoinTeamQte.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001CBA RID: 7354 RVA: 0x000966D8 File Offset: 0x000948D8
	protected override string GetNotifyName_Implementation()
	{
		return "角色入队QTE";
	}

	// Token: 0x06001CBB RID: 7355 RVA: 0x000966DF File Offset: 0x000948DF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyJoinTeamQte._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyJoinTeamQte.TsAnimNotifyJoinTeamQte_C");
		}
		return TsAnimNotifyJoinTeamQte._ClassPtr;
	}

	// Token: 0x06001CBC RID: 7356 RVA: 0x00096704 File Offset: 0x00094904
	public TsAnimNotifyJoinTeamQte() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyJoinTeamQte.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CBD RID: 7357 RVA: 0x0009672C File Offset: 0x0009492C
	public TsAnimNotifyJoinTeamQte(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyJoinTeamQte.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CBE RID: 7358 RVA: 0x0009675F File Offset: 0x0009495F
	protected TsAnimNotifyJoinTeamQte(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CBF RID: 7359 RVA: 0x00096768 File Offset: 0x00094968
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001CC0 RID: 7360 RVA: 0x0009679B File Offset: 0x0009499B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001209 RID: 4617
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyJoinTeamQte.TsAnimNotifyJoinTeamQte_C";

	// Token: 0x0400120A RID: 4618
	private static IntPtr _ClassPtr;

	// Token: 0x0400120B RID: 4619
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400120C RID: 4620
	private static int __PropertyOffset_QteId;

	// Token: 0x0400120D RID: 4621
	private static int __PropertyOffset_PreloadRoleIdList;

	// Token: 0x0400120E RID: 4622
	[Nullable(2)]
	private TArray<int> _PreloadRoleIdList;

	// Token: 0x0400120F RID: 4623
	private static int __PropertyOffset_ShowTrialRoleTips;
}
