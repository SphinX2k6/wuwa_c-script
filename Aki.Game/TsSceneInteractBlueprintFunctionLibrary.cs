using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020023A1 RID: 9121
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsSceneInteractBlueprintFunctionLibrary.TsSceneInteractBlueprintFunctionLibrary_C")]
public class TsSceneInteractBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06016CF7 RID: 93431 RVA: 0x006A55E6 File Offset: 0x006A37E6
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetSitDownState(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		return component != null && component.GetSitDownState();
	}

	// Token: 0x06016CF8 RID: 93432 RVA: 0x006A55FE File Offset: 0x006A37FE
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetEnterSitDownIndex(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		return (float)((component != null) ? component.EnterSitDownIndex : 0);
	}

	// Token: 0x06016CF9 RID: 93433 RVA: 0x006A5618 File Offset: 0x006A3818
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetLeaveSitDownIndex(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		return (float)((component != null) ? component.LeaveSitDownIndex : 0);
	}

	// Token: 0x06016CFA RID: 93434 RVA: 0x006A5632 File Offset: 0x006A3832
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void PreLeaveSitDownAction(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.PreLeaveSitDownAction("");
	}

	// Token: 0x06016CFB RID: 93435 RVA: 0x006A564E File Offset: 0x006A384E
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void LeaveSitDownAction(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.LeaveSitDownAction();
	}

	// Token: 0x06016CFC RID: 93436 RVA: 0x006A5665 File Offset: 0x006A3865
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static AActor GetGiantActor(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.Giant;
	}

	// Token: 0x06016CFD RID: 93437 RVA: 0x006A567D File Offset: 0x006A387D
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EndCatapult(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.EndCatapult();
	}

	// Token: 0x06016CFE RID: 93438 RVA: 0x006A5694 File Offset: 0x006A3894
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EndBounce(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.EndBounce();
	}

	// Token: 0x06016CFF RID: 93439 RVA: 0x006A56AB File Offset: 0x006A38AB
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsAiDriver(int entityId)
	{
		CharacterAiComponent component = EntitySystem.Instance.GetComponent<CharacterAiComponent>(entityId);
		return component != null && component.IsAiDriver;
	}

	// Token: 0x06016D00 RID: 93440 RVA: 0x006A56C3 File Offset: 0x006A38C3
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsDropItem(int entityId)
	{
		return EntitySystem.Instance.GetComponent<SceneItemDropItemComponent>(entityId) != null;
	}

	// Token: 0x06016D01 RID: 93441 RVA: 0x006A56D4 File Offset: 0x006A38D4
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void PickUpDropItem(int entityId, int targetEntityId)
	{
		CreatureDataComponent component = EntitySystem.Instance.Get(targetEntityId).GetComponent<CreatureDataComponent>();
		RewardController.Instance.PickUpFightDrop(component.GetCreatureDataId(), component.GetPbDataId(), null);
	}

	// Token: 0x06016D02 RID: 93442 RVA: 0x006A570A File Offset: 0x006A390A
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void InteractSceneItem(int entityId, int targetEntityId)
	{
		PawnInteractNewComponent component = EntitySystem.Instance.GetComponent<PawnInteractNewComponent>(targetEntityId);
		if (component == null)
		{
			return;
		}
		component.ExecuteInteractFromVision(entityId);
	}

	// Token: 0x06016D03 RID: 93443 RVA: 0x006A5722 File Offset: 0x006A3922
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSceneInteractBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsSceneInteractBlueprintFunctionLibrary.TsSceneInteractBlueprintFunctionLibrary_C");
		}
		return TsSceneInteractBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06016D04 RID: 93444 RVA: 0x006A5748 File Offset: 0x006A3948
	public TsSceneInteractBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsSceneInteractBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016D05 RID: 93445 RVA: 0x006A5770 File Offset: 0x006A3970
	[NullableContext(1)]
	public TsSceneInteractBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneInteractBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016D06 RID: 93446 RVA: 0x006A57A3 File Offset: 0x006A39A3
	protected TsSceneInteractBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06016D07 RID: 93447 RVA: 0x006A57AC File Offset: 0x006A39AC
	protected unsafe static void __CPPCALL_GetSitDownState_Implementation(TsSceneInteractBlueprintFunctionLibrary.__GetSitDownState_FunctionParams* __Params)
	{
		__Params->__Result = TsSceneInteractBlueprintFunctionLibrary.GetSitDownState(__Params->entityId);
	}

	// Token: 0x06016D08 RID: 93448 RVA: 0x006A57BF File Offset: 0x006A39BF
	protected unsafe static void __CPPCALL_GetEnterSitDownIndex_Implementation(TsSceneInteractBlueprintFunctionLibrary.__GetEnterSitDownIndex_FunctionParams* __Params)
	{
		__Params->__Result = TsSceneInteractBlueprintFunctionLibrary.GetEnterSitDownIndex(__Params->entityId);
	}

	// Token: 0x06016D09 RID: 93449 RVA: 0x006A57D2 File Offset: 0x006A39D2
	protected unsafe static void __CPPCALL_GetLeaveSitDownIndex_Implementation(TsSceneInteractBlueprintFunctionLibrary.__GetLeaveSitDownIndex_FunctionParams* __Params)
	{
		__Params->__Result = TsSceneInteractBlueprintFunctionLibrary.GetLeaveSitDownIndex(__Params->entityId);
	}

	// Token: 0x06016D0A RID: 93450 RVA: 0x006A57E5 File Offset: 0x006A39E5
	protected unsafe static void __CPPCALL_PreLeaveSitDownAction_Implementation(TsSceneInteractBlueprintFunctionLibrary.__PreLeaveSitDownAction_FunctionParams* __Params)
	{
		TsSceneInteractBlueprintFunctionLibrary.PreLeaveSitDownAction(__Params->entityId);
	}

	// Token: 0x06016D0B RID: 93451 RVA: 0x006A57F2 File Offset: 0x006A39F2
	protected unsafe static void __CPPCALL_LeaveSitDownAction_Implementation(TsSceneInteractBlueprintFunctionLibrary.__LeaveSitDownAction_FunctionParams* __Params)
	{
		TsSceneInteractBlueprintFunctionLibrary.LeaveSitDownAction(__Params->entityId);
	}

	// Token: 0x06016D0C RID: 93452 RVA: 0x006A57FF File Offset: 0x006A39FF
	protected unsafe static void __CPPCALL_GetGiantActor_Implementation(TsSceneInteractBlueprintFunctionLibrary.__GetGiantActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor giantActor = TsSceneInteractBlueprintFunctionLibrary.GetGiantActor(__Params->entityId);
		ptr = ((giantActor != null) ? giantActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016D0D RID: 93453 RVA: 0x006A5821 File Offset: 0x006A3A21
	protected unsafe static void __CPPCALL_EndCatapult_Implementation(TsSceneInteractBlueprintFunctionLibrary.__EndCatapult_FunctionParams* __Params)
	{
		TsSceneInteractBlueprintFunctionLibrary.EndCatapult(__Params->entityId);
	}

	// Token: 0x06016D0E RID: 93454 RVA: 0x006A582E File Offset: 0x006A3A2E
	protected unsafe static void __CPPCALL_EndBounce_Implementation(TsSceneInteractBlueprintFunctionLibrary.__EndBounce_FunctionParams* __Params)
	{
		TsSceneInteractBlueprintFunctionLibrary.EndBounce(__Params->entityId);
	}

	// Token: 0x06016D0F RID: 93455 RVA: 0x006A583B File Offset: 0x006A3A3B
	protected unsafe static void __CPPCALL_IsAiDriver_Implementation(TsSceneInteractBlueprintFunctionLibrary.__IsAiDriver_FunctionParams* __Params)
	{
		__Params->__Result = TsSceneInteractBlueprintFunctionLibrary.IsAiDriver(__Params->entityId);
	}

	// Token: 0x06016D10 RID: 93456 RVA: 0x006A584E File Offset: 0x006A3A4E
	protected unsafe static void __CPPCALL_IsDropItem_Implementation(TsSceneInteractBlueprintFunctionLibrary.__IsDropItem_FunctionParams* __Params)
	{
		__Params->__Result = TsSceneInteractBlueprintFunctionLibrary.IsDropItem(__Params->entityId);
	}

	// Token: 0x06016D11 RID: 93457 RVA: 0x006A5861 File Offset: 0x006A3A61
	protected unsafe static void __CPPCALL_PickUpDropItem_Implementation(TsSceneInteractBlueprintFunctionLibrary.__PickUpDropItem_FunctionParams* __Params)
	{
		TsSceneInteractBlueprintFunctionLibrary.PickUpDropItem(__Params->entityId, __Params->targetEntityId);
	}

	// Token: 0x06016D12 RID: 93458 RVA: 0x006A5874 File Offset: 0x006A3A74
	protected unsafe static void __CPPCALL_InteractSceneItem_Implementation(TsSceneInteractBlueprintFunctionLibrary.__InteractSceneItem_FunctionParams* __Params)
	{
		TsSceneInteractBlueprintFunctionLibrary.InteractSceneItem(__Params->entityId, __Params->targetEntityId);
	}

	// Token: 0x0400BF3D RID: 48957
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsSceneInteractBlueprintFunctionLibrary.TsSceneInteractBlueprintFunctionLibrary_C";

	// Token: 0x0400BF3E RID: 48958
	private static IntPtr _ClassPtr;

	// Token: 0x0400BF3F RID: 48959
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020087CC RID: 34764
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSitDownState_FunctionParams
	{
		// Token: 0x0402B76D RID: 178029
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B76E RID: 178030
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B76F RID: 178031
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020087CD RID: 34765
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEnterSitDownIndex_FunctionParams
	{
		// Token: 0x0402B770 RID: 178032
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B771 RID: 178033
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B772 RID: 178034
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020087CE RID: 34766
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetLeaveSitDownIndex_FunctionParams
	{
		// Token: 0x0402B773 RID: 178035
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B774 RID: 178036
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B775 RID: 178037
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020087CF RID: 34767
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __PreLeaveSitDownAction_FunctionParams
	{
		// Token: 0x0402B776 RID: 178038
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B777 RID: 178039
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087D0 RID: 34768
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LeaveSitDownAction_FunctionParams
	{
		// Token: 0x0402B778 RID: 178040
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B779 RID: 178041
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087D1 RID: 34769
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetGiantActor_FunctionParams
	{
		// Token: 0x0402B77A RID: 178042
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B77B RID: 178043
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B77C RID: 178044
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x020087D2 RID: 34770
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndCatapult_FunctionParams
	{
		// Token: 0x0402B77D RID: 178045
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B77E RID: 178046
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087D3 RID: 34771
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndBounce_FunctionParams
	{
		// Token: 0x0402B77F RID: 178047
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B780 RID: 178048
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087D4 RID: 34772
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsAiDriver_FunctionParams
	{
		// Token: 0x0402B781 RID: 178049
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B782 RID: 178050
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B783 RID: 178051
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020087D5 RID: 34773
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsDropItem_FunctionParams
	{
		// Token: 0x0402B784 RID: 178052
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B785 RID: 178053
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B786 RID: 178054
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020087D6 RID: 34774
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __PickUpDropItem_FunctionParams
	{
		// Token: 0x0402B787 RID: 178055
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B788 RID: 178056
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402B789 RID: 178057
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020087D7 RID: 34775
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __InteractSceneItem_FunctionParams
	{
		// Token: 0x0402B78A RID: 178058
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B78B RID: 178059
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402B78C RID: 178060
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
