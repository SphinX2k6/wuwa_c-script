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

// Token: 0x02002E45 RID: 11845
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsSceneInteractBlueprintFunctionLibrary.TsSceneInteractBlueprintFunctionLibrary_C")]
public class TsSceneInteractBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06019421 RID: 103457 RVA: 0x0067F656 File Offset: 0x0067D856
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetSitDownState(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		return component != null && component.GetSitDownState();
	}

	// Token: 0x06019422 RID: 103458 RVA: 0x0067F66E File Offset: 0x0067D86E
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetEnterSitDownIndex(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		return (float)((component != null) ? component.EnterSitDownIndex : 0);
	}

	// Token: 0x06019423 RID: 103459 RVA: 0x0067F688 File Offset: 0x0067D888
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetLeaveSitDownIndex(int entityId)
	{
		CharacterActionComponent component = EntitySystem.Instance.GetComponent<CharacterActionComponent>(entityId);
		return (float)((component != null) ? component.LeaveSitDownIndex : 0);
	}

	// Token: 0x06019424 RID: 103460 RVA: 0x0067F6A2 File Offset: 0x0067D8A2
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

	// Token: 0x06019425 RID: 103461 RVA: 0x0067F6BE File Offset: 0x0067D8BE
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

	// Token: 0x06019426 RID: 103462 RVA: 0x0067F6D5 File Offset: 0x0067D8D5
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

	// Token: 0x06019427 RID: 103463 RVA: 0x0067F6ED File Offset: 0x0067D8ED
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

	// Token: 0x06019428 RID: 103464 RVA: 0x0067F704 File Offset: 0x0067D904
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

	// Token: 0x06019429 RID: 103465 RVA: 0x0067F71B File Offset: 0x0067D91B
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsAiDriver(int entityId)
	{
		CharacterAiComponent component = EntitySystem.Instance.GetComponent<CharacterAiComponent>(entityId);
		return component != null && component.IsAiDriver;
	}

	// Token: 0x0601942A RID: 103466 RVA: 0x0067F733 File Offset: 0x0067D933
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool IsDropItem(int entityId)
	{
		return EntitySystem.Instance.GetComponent<SceneItemDropItemComponent>(entityId) != null;
	}

	// Token: 0x0601942B RID: 103467 RVA: 0x0067F744 File Offset: 0x0067D944
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void PickUpDropItem(int entityId, int targetEntityId)
	{
		CreatureDataComponent component = EntitySystem.Instance.Get(targetEntityId).GetComponent<CreatureDataComponent>();
		RewardController.Instance.PickUpFightDrop(component.GetCreatureDataId(), component.GetPbDataId(), null);
	}

	// Token: 0x0601942C RID: 103468 RVA: 0x0067F77A File Offset: 0x0067D97A
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

	// Token: 0x0601942D RID: 103469 RVA: 0x0067F792 File Offset: 0x0067D992
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSceneInteractBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsSceneInteractBlueprintFunctionLibrary.TsSceneInteractBlueprintFunctionLibrary_C");
		}
		return TsSceneInteractBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0601942E RID: 103470 RVA: 0x0067F7B8 File Offset: 0x0067D9B8
	public TsSceneInteractBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsSceneInteractBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601942F RID: 103471 RVA: 0x0067F7E0 File Offset: 0x0067D9E0
	[NullableContext(1)]
	public TsSceneInteractBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSceneInteractBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019430 RID: 103472 RVA: 0x0067F813 File Offset: 0x0067DA13
	protected TsSceneInteractBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06019431 RID: 103473 RVA: 0x0067F81C File Offset: 0x0067DA1C
	protected unsafe static void __CPPCALL_GetSitDownState_Implementation(TsSceneInteractBlueprintFunctionLibrary.__GetSitDownState_FunctionParams* __Params)
	{
		__Params->__Result = TsSceneInteractBlueprintFunctionLibrary.GetSitDownState(__Params->entityId);
	}

	// Token: 0x06019432 RID: 103474 RVA: 0x0067F82F File Offset: 0x0067DA2F
	protected unsafe static void __CPPCALL_GetEnterSitDownIndex_Implementation(TsSceneInteractBlueprintFunctionLibrary.__GetEnterSitDownIndex_FunctionParams* __Params)
	{
		__Params->__Result = TsSceneInteractBlueprintFunctionLibrary.GetEnterSitDownIndex(__Params->entityId);
	}

	// Token: 0x06019433 RID: 103475 RVA: 0x0067F842 File Offset: 0x0067DA42
	protected unsafe static void __CPPCALL_GetLeaveSitDownIndex_Implementation(TsSceneInteractBlueprintFunctionLibrary.__GetLeaveSitDownIndex_FunctionParams* __Params)
	{
		__Params->__Result = TsSceneInteractBlueprintFunctionLibrary.GetLeaveSitDownIndex(__Params->entityId);
	}

	// Token: 0x06019434 RID: 103476 RVA: 0x0067F855 File Offset: 0x0067DA55
	protected unsafe static void __CPPCALL_PreLeaveSitDownAction_Implementation(TsSceneInteractBlueprintFunctionLibrary.__PreLeaveSitDownAction_FunctionParams* __Params)
	{
		TsSceneInteractBlueprintFunctionLibrary.PreLeaveSitDownAction(__Params->entityId);
	}

	// Token: 0x06019435 RID: 103477 RVA: 0x0067F862 File Offset: 0x0067DA62
	protected unsafe static void __CPPCALL_LeaveSitDownAction_Implementation(TsSceneInteractBlueprintFunctionLibrary.__LeaveSitDownAction_FunctionParams* __Params)
	{
		TsSceneInteractBlueprintFunctionLibrary.LeaveSitDownAction(__Params->entityId);
	}

	// Token: 0x06019436 RID: 103478 RVA: 0x0067F86F File Offset: 0x0067DA6F
	protected unsafe static void __CPPCALL_GetGiantActor_Implementation(TsSceneInteractBlueprintFunctionLibrary.__GetGiantActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor giantActor = TsSceneInteractBlueprintFunctionLibrary.GetGiantActor(__Params->entityId);
		ptr = ((giantActor != null) ? giantActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06019437 RID: 103479 RVA: 0x0067F891 File Offset: 0x0067DA91
	protected unsafe static void __CPPCALL_EndCatapult_Implementation(TsSceneInteractBlueprintFunctionLibrary.__EndCatapult_FunctionParams* __Params)
	{
		TsSceneInteractBlueprintFunctionLibrary.EndCatapult(__Params->entityId);
	}

	// Token: 0x06019438 RID: 103480 RVA: 0x0067F89E File Offset: 0x0067DA9E
	protected unsafe static void __CPPCALL_EndBounce_Implementation(TsSceneInteractBlueprintFunctionLibrary.__EndBounce_FunctionParams* __Params)
	{
		TsSceneInteractBlueprintFunctionLibrary.EndBounce(__Params->entityId);
	}

	// Token: 0x06019439 RID: 103481 RVA: 0x0067F8AB File Offset: 0x0067DAAB
	protected unsafe static void __CPPCALL_IsAiDriver_Implementation(TsSceneInteractBlueprintFunctionLibrary.__IsAiDriver_FunctionParams* __Params)
	{
		__Params->__Result = TsSceneInteractBlueprintFunctionLibrary.IsAiDriver(__Params->entityId);
	}

	// Token: 0x0601943A RID: 103482 RVA: 0x0067F8BE File Offset: 0x0067DABE
	protected unsafe static void __CPPCALL_IsDropItem_Implementation(TsSceneInteractBlueprintFunctionLibrary.__IsDropItem_FunctionParams* __Params)
	{
		__Params->__Result = TsSceneInteractBlueprintFunctionLibrary.IsDropItem(__Params->entityId);
	}

	// Token: 0x0601943B RID: 103483 RVA: 0x0067F8D1 File Offset: 0x0067DAD1
	protected unsafe static void __CPPCALL_PickUpDropItem_Implementation(TsSceneInteractBlueprintFunctionLibrary.__PickUpDropItem_FunctionParams* __Params)
	{
		TsSceneInteractBlueprintFunctionLibrary.PickUpDropItem(__Params->entityId, __Params->targetEntityId);
	}

	// Token: 0x0601943C RID: 103484 RVA: 0x0067F8E4 File Offset: 0x0067DAE4
	protected unsafe static void __CPPCALL_InteractSceneItem_Implementation(TsSceneInteractBlueprintFunctionLibrary.__InteractSceneItem_FunctionParams* __Params)
	{
		TsSceneInteractBlueprintFunctionLibrary.InteractSceneItem(__Params->entityId, __Params->targetEntityId);
	}

	// Token: 0x0400BBAF RID: 48047
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsSceneInteractBlueprintFunctionLibrary.TsSceneInteractBlueprintFunctionLibrary_C";

	// Token: 0x0400BBB0 RID: 48048
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBB1 RID: 48049
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020095A2 RID: 38306
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSitDownState_FunctionParams
	{
		// Token: 0x040300DA RID: 196826
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300DB RID: 196827
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040300DC RID: 196828
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020095A3 RID: 38307
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEnterSitDownIndex_FunctionParams
	{
		// Token: 0x040300DD RID: 196829
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300DE RID: 196830
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040300DF RID: 196831
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020095A4 RID: 38308
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetLeaveSitDownIndex_FunctionParams
	{
		// Token: 0x040300E0 RID: 196832
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300E1 RID: 196833
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040300E2 RID: 196834
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x020095A5 RID: 38309
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __PreLeaveSitDownAction_FunctionParams
	{
		// Token: 0x040300E3 RID: 196835
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300E4 RID: 196836
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020095A6 RID: 38310
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __LeaveSitDownAction_FunctionParams
	{
		// Token: 0x040300E5 RID: 196837
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300E6 RID: 196838
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020095A7 RID: 38311
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetGiantActor_FunctionParams
	{
		// Token: 0x040300E7 RID: 196839
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300E8 RID: 196840
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040300E9 RID: 196841
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x020095A8 RID: 38312
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndCatapult_FunctionParams
	{
		// Token: 0x040300EA RID: 196842
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300EB RID: 196843
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020095A9 RID: 38313
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EndBounce_FunctionParams
	{
		// Token: 0x040300EC RID: 196844
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300ED RID: 196845
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020095AA RID: 38314
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsAiDriver_FunctionParams
	{
		// Token: 0x040300EE RID: 196846
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300EF RID: 196847
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040300F0 RID: 196848
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020095AB RID: 38315
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsDropItem_FunctionParams
	{
		// Token: 0x040300F1 RID: 196849
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300F2 RID: 196850
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040300F3 RID: 196851
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020095AC RID: 38316
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __PickUpDropItem_FunctionParams
	{
		// Token: 0x040300F4 RID: 196852
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300F5 RID: 196853
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x040300F6 RID: 196854
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020095AD RID: 38317
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __InteractSceneItem_FunctionParams
	{
		// Token: 0x040300F7 RID: 196855
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040300F8 RID: 196856
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x040300F9 RID: 196857
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
