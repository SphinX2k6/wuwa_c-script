using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AiInteraction.AiWeapon;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000B9B RID: 2971
[UClass("/Game/Aki/TypeScript/Game/Module/AiInteraction/AiWeapon/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/AiInteraction/AiWeapon/AiWeaponBlueprintFunctionLibrary.AiWeaponBlueprintFunctionLibrary_C")]
public class AiWeaponBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06007BC8 RID: 31688 RVA: 0x002656F0 File Offset: 0x002638F0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CharacterRequestPickUpAiWeapon(int entityId, int itemEntityId)
	{
		AiWeaponModel.Instance.Net.SendHoldWeaponPush(entityId, itemEntityId);
	}

	// Token: 0x06007BC9 RID: 31689 RVA: 0x00265704 File Offset: 0x00263904
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AiWeaponBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/AiInteraction/AiWeapon/AiWeaponBlueprintFunctionLibrary.AiWeaponBlueprintFunctionLibrary_C");
		}
		return AiWeaponBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06007BCA RID: 31690 RVA: 0x00265728 File Offset: 0x00263928
	public AiWeaponBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(AiWeaponBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06007BCB RID: 31691 RVA: 0x00265750 File Offset: 0x00263950
	[NullableContext(1)]
	public AiWeaponBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AiWeaponBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06007BCC RID: 31692 RVA: 0x00265783 File Offset: 0x00263983
	protected AiWeaponBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06007BCD RID: 31693 RVA: 0x0026578C File Offset: 0x0026398C
	protected unsafe static void __CPPCALL_CharacterRequestPickUpAiWeapon_Implementation(AiWeaponBlueprintFunctionLibrary.__CharacterRequestPickUpAiWeapon_FunctionParams* __Params)
	{
		AiWeaponBlueprintFunctionLibrary.CharacterRequestPickUpAiWeapon(__Params->entityId, __Params->itemEntityId);
	}

	// Token: 0x04004C50 RID: 19536
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/AiInteraction/AiWeapon/AiWeaponBlueprintFunctionLibrary.AiWeaponBlueprintFunctionLibrary_C";

	// Token: 0x04004C51 RID: 19537
	private static IntPtr _ClassPtr;

	// Token: 0x04004C52 RID: 19538
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02006E3B RID: 28219
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __CharacterRequestPickUpAiWeapon_FunctionParams
	{
		// Token: 0x040241A9 RID: 147881
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x040241AA RID: 147882
		[FieldOffset(4)]
		public int itemEntityId;

		// Token: 0x040241AB RID: 147883
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
