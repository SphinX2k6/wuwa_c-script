using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AiInteraction.AiWeapon;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020016E3 RID: 5859
[UClass("/Game/Aki/TypeScript/Game/Module/AiInteraction/AiWeapon/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/AiInteraction/AiWeapon/AiWeaponBlueprintFunctionLibrary.AiWeaponBlueprintFunctionLibrary_C")]
public class AiWeaponBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600A7E8 RID: 42984 RVA: 0x0025B2E8 File Offset: 0x002594E8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CharacterRequestPickUpAiWeapon(int entityId, int itemEntityId)
	{
		AiWeaponModel.Instance.Net.SendHoldWeaponPush(entityId, itemEntityId);
	}

	// Token: 0x0600A7E9 RID: 42985 RVA: 0x0025B2FC File Offset: 0x002594FC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AiWeaponBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/AiInteraction/AiWeapon/AiWeaponBlueprintFunctionLibrary.AiWeaponBlueprintFunctionLibrary_C");
		}
		return AiWeaponBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0600A7EA RID: 42986 RVA: 0x0025B320 File Offset: 0x00259520
	public AiWeaponBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(AiWeaponBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600A7EB RID: 42987 RVA: 0x0025B348 File Offset: 0x00259548
	[NullableContext(1)]
	public AiWeaponBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AiWeaponBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600A7EC RID: 42988 RVA: 0x0025B37B File Offset: 0x0025957B
	protected AiWeaponBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600A7ED RID: 42989 RVA: 0x0025B384 File Offset: 0x00259584
	protected unsafe static void __CPPCALL_CharacterRequestPickUpAiWeapon_Implementation(AiWeaponBlueprintFunctionLibrary.__CharacterRequestPickUpAiWeapon_FunctionParams* __Params)
	{
		AiWeaponBlueprintFunctionLibrary.CharacterRequestPickUpAiWeapon(__Params->entityId, __Params->itemEntityId);
	}

	// Token: 0x04004BA9 RID: 19369
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/AiInteraction/AiWeapon/AiWeaponBlueprintFunctionLibrary.AiWeaponBlueprintFunctionLibrary_C";

	// Token: 0x04004BAA RID: 19370
	private static IntPtr _ClassPtr;

	// Token: 0x04004BAB RID: 19371
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02007CB6 RID: 31926
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __CharacterRequestPickUpAiWeapon_FunctionParams
	{
		// Token: 0x04028E80 RID: 167552
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04028E81 RID: 167553
		[FieldOffset(4)]
		public int itemEntityId;

		// Token: 0x04028E82 RID: 167554
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
