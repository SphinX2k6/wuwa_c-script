using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200239E RID: 9118
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMediaBlueprintFunctionLibrary.TsMediaBlueprintFunctionLibrary_C")]
public class TsMediaBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06016BA9 RID: 93097 RVA: 0x006A12A0 File Offset: 0x0069F4A0
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetAffectedByP1orP3(int entityId)
	{
		CharacterAkComponent component = EntitySystem.Instance.GetComponent<CharacterAkComponent>(entityId);
		return component == null || component.IsP1;
	}

	// Token: 0x06016BAA RID: 93098 RVA: 0x006A12C4 File Offset: 0x0069F4C4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void PostAkEventByTs(int entityId, UAkComponent charAkComponent, UAkAudioEvent eventPtr, string attachName, ref TArray<string> switchDataRef, bool bFollow)
	{
		CharacterAkComponent component = EntitySystem.Instance.GetComponent<CharacterAkComponent>(entityId);
		if (component != null)
		{
			TArray<string> switchData = switchDataRef;
			component.PostAkEvent(charAkComponent, eventPtr, attachName, switchData, bFollow);
		}
	}

	// Token: 0x06016BAB RID: 93099 RVA: 0x006A12F4 File Offset: 0x0069F4F4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float PostAkEventByTsWithoutData(int entityId, UAkComponent charAkComponent, UAkAudioEvent eventPtr, string attachName, ref TArray<string> switchData, bool bFollow)
	{
		CharacterAkComponent component = EntitySystem.Instance.GetComponent<CharacterAkComponent>(entityId);
		if (component == null)
		{
			return -1f;
		}
		return (float)component.PostAkEvent(charAkComponent, eventPtr, attachName, switchData, bFollow);
	}

	// Token: 0x06016BAC RID: 93100 RVA: 0x006A1328 File Offset: 0x0069F528
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetDebug(int entityId, bool bDebug)
	{
		CharacterAkComponent component = EntitySystem.Instance.GetComponent<CharacterAkComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetDebug(bDebug);
	}

	// Token: 0x06016BAD RID: 93101 RVA: 0x006A134C File Offset: 0x0069F54C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(2)]
	protected static UAkComponent GetAkComponentBySocketName(int entityId, string socketName)
	{
		CharacterAkComponent component = EntitySystem.Instance.GetComponent<CharacterAkComponent>(entityId);
		if (component == null)
		{
			return null;
		}
		return component.GetAkComponentBySocketName(FNameUtil.GetDynamicFName(socketName).Value);
	}

	// Token: 0x06016BAE RID: 93102 RVA: 0x006A1380 File Offset: 0x0069F580
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetFootSwitch(int entityId, string footSwitch)
	{
		CharacterAkComponent component = EntitySystem.Instance.GetComponent<CharacterAkComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.FootSwitch = footSwitch;
	}

	// Token: 0x06016BAF RID: 93103 RVA: 0x006A13A4 File Offset: 0x0069F5A4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static string GetFootSwitch(int entityId)
	{
		CharacterAkComponent component = EntitySystem.Instance.GetComponent<CharacterAkComponent>(entityId);
		if (component == null)
		{
			return "";
		}
		return component.FootSwitch;
	}

	// Token: 0x06016BB0 RID: 93104 RVA: 0x006A13CC File Offset: 0x0069F5CC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static float GetWaterDepth(int entityId)
	{
		CharacterAkComponent component = EntitySystem.Instance.GetComponent<CharacterAkComponent>(entityId);
		if (component == null)
		{
			return 0f;
		}
		return (float)component.WaterDepth;
	}

	// Token: 0x06016BB1 RID: 93105 RVA: 0x006A13F5 File Offset: 0x0069F5F5
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void PostRoleAudioEvent(int entityId, string action)
	{
		CharacterAkComponent component = EntitySystem.Instance.GetComponent<CharacterAkComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.PostAudioEvent(action);
	}

	// Token: 0x06016BB2 RID: 93106 RVA: 0x006A140D File Offset: 0x0069F60D
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EmitFootOnTheGroundEvent()
	{
		EventSystem.Instance.Emit<bool>(EEventName.OnCharFootOnTheGround, false);
	}

	// Token: 0x06016BB3 RID: 93107 RVA: 0x006A1420 File Offset: 0x0069F620
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsMediaBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMediaBlueprintFunctionLibrary.TsMediaBlueprintFunctionLibrary_C");
		}
		return TsMediaBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06016BB4 RID: 93108 RVA: 0x006A1444 File Offset: 0x0069F644
	public TsMediaBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsMediaBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016BB5 RID: 93109 RVA: 0x006A146C File Offset: 0x0069F66C
	[NullableContext(1)]
	public TsMediaBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMediaBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016BB6 RID: 93110 RVA: 0x006A149F File Offset: 0x0069F69F
	protected TsMediaBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06016BB7 RID: 93111 RVA: 0x006A14A8 File Offset: 0x0069F6A8
	protected unsafe static void __CPPCALL_GetAffectedByP1orP3_Implementation(TsMediaBlueprintFunctionLibrary.__GetAffectedByP1orP3_FunctionParams* __Params)
	{
		__Params->__Result = TsMediaBlueprintFunctionLibrary.GetAffectedByP1orP3(__Params->entityId);
	}

	// Token: 0x06016BB8 RID: 93112 RVA: 0x006A14BC File Offset: 0x0069F6BC
	protected unsafe static void __CPPCALL_PostAkEventByTs_Implementation(TsMediaBlueprintFunctionLibrary.__PostAkEventByTs_FunctionParams* __Params)
	{
		UAkComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkComponent>(__Params->charAkComponent);
		UAkAudioEvent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkAudioEvent>(__Params->eventPtr);
		string attachName = FString.ToString((void*)(&__Params->attachName));
		TArray<string> tarray = new TArray<string>(&__Params->switchDataRef, true, true);
		TsMediaBlueprintFunctionLibrary.PostAkEventByTs(__Params->entityId, orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, attachName, ref tarray, __Params->bFollow);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->switchDataRef, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06016BB9 RID: 93113 RVA: 0x006A1530 File Offset: 0x0069F730
	protected unsafe static void __CPPCALL_PostAkEventByTsWithoutData_Implementation(TsMediaBlueprintFunctionLibrary.__PostAkEventByTsWithoutData_FunctionParams* __Params)
	{
		UAkComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkComponent>(__Params->charAkComponent);
		UAkAudioEvent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkAudioEvent>(__Params->eventPtr);
		string attachName = FString.ToString((void*)(&__Params->attachName));
		TArray<string> tarray = new TArray<string>(&__Params->switchData, true, true);
		__Params->__Result = TsMediaBlueprintFunctionLibrary.PostAkEventByTsWithoutData(__Params->entityId, orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, attachName, ref tarray, __Params->bFollow);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->switchData, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06016BBA RID: 93114 RVA: 0x006A15A7 File Offset: 0x0069F7A7
	protected unsafe static void __CPPCALL_SetDebug_Implementation(TsMediaBlueprintFunctionLibrary.__SetDebug_FunctionParams* __Params)
	{
		TsMediaBlueprintFunctionLibrary.SetDebug(__Params->entityId, __Params->bDebug);
	}

	// Token: 0x06016BBB RID: 93115 RVA: 0x006A15BC File Offset: 0x0069F7BC
	protected unsafe static void __CPPCALL_GetAkComponentBySocketName_Implementation(TsMediaBlueprintFunctionLibrary.__GetAkComponentBySocketName_FunctionParams* __Params)
	{
		string socketName = FString.ToString((void*)(&__Params->socketName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		UAkComponent akComponentBySocketName = TsMediaBlueprintFunctionLibrary.GetAkComponentBySocketName(__Params->entityId, socketName);
		ptr = ((akComponentBySocketName != null) ? akComponentBySocketName.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016BBC RID: 93116 RVA: 0x006A15F8 File Offset: 0x0069F7F8
	protected unsafe static void __CPPCALL_SetFootSwitch_Implementation(TsMediaBlueprintFunctionLibrary.__SetFootSwitch_FunctionParams* __Params)
	{
		string footSwitch = FString.ToString((void*)(&__Params->footSwitch));
		TsMediaBlueprintFunctionLibrary.SetFootSwitch(__Params->entityId, footSwitch);
	}

	// Token: 0x06016BBD RID: 93117 RVA: 0x006A161E File Offset: 0x0069F81E
	protected unsafe static void __CPPCALL_GetFootSwitch_Implementation(TsMediaBlueprintFunctionLibrary.__GetFootSwitch_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsMediaBlueprintFunctionLibrary.GetFootSwitch(__Params->entityId));
	}

	// Token: 0x06016BBE RID: 93118 RVA: 0x006A1637 File Offset: 0x0069F837
	protected unsafe static void __CPPCALL_GetWaterDepth_Implementation(TsMediaBlueprintFunctionLibrary.__GetWaterDepth_FunctionParams* __Params)
	{
		__Params->__Result = TsMediaBlueprintFunctionLibrary.GetWaterDepth(__Params->entityId);
	}

	// Token: 0x06016BBF RID: 93119 RVA: 0x006A164C File Offset: 0x0069F84C
	protected unsafe static void __CPPCALL_PostRoleAudioEvent_Implementation(TsMediaBlueprintFunctionLibrary.__PostRoleAudioEvent_FunctionParams* __Params)
	{
		string action = FString.ToString((void*)(&__Params->action));
		TsMediaBlueprintFunctionLibrary.PostRoleAudioEvent(__Params->entityId, action);
	}

	// Token: 0x06016BC0 RID: 93120 RVA: 0x006A1672 File Offset: 0x0069F872
	protected unsafe static void __CPPCALL_EmitFootOnTheGroundEvent_Implementation(TsMediaBlueprintFunctionLibrary.__EmitFootOnTheGroundEvent_FunctionParams* __Params)
	{
		TsMediaBlueprintFunctionLibrary.EmitFootOnTheGroundEvent();
	}

	// Token: 0x0400BF2C RID: 48940
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMediaBlueprintFunctionLibrary.TsMediaBlueprintFunctionLibrary_C";

	// Token: 0x0400BF2D RID: 48941
	private static IntPtr _ClassPtr;

	// Token: 0x0400BF2E RID: 48942
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0200872F RID: 34607
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAffectedByP1orP3_FunctionParams
	{
		// Token: 0x0402B550 RID: 177488
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B551 RID: 177489
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B552 RID: 177490
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008730 RID: 34608
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __PostAkEventByTs_FunctionParams
	{
		// Token: 0x0402B553 RID: 177491
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B554 RID: 177492
		[FieldOffset(8)]
		public IntPtr charAkComponent;

		// Token: 0x0402B555 RID: 177493
		[FieldOffset(16)]
		public IntPtr eventPtr;

		// Token: 0x0402B556 RID: 177494
		[FieldOffset(24)]
		public FString attachName;

		// Token: 0x0402B557 RID: 177495
		[FieldOffset(40)]
		public byte switchDataRef;

		// Token: 0x0402B558 RID: 177496
		[FieldOffset(56)]
		public bool bFollow;

		// Token: 0x0402B559 RID: 177497
		[FieldOffset(64)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008731 RID: 34609
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __PostAkEventByTsWithoutData_FunctionParams
	{
		// Token: 0x0402B55A RID: 177498
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B55B RID: 177499
		[FieldOffset(8)]
		public IntPtr charAkComponent;

		// Token: 0x0402B55C RID: 177500
		[FieldOffset(16)]
		public IntPtr eventPtr;

		// Token: 0x0402B55D RID: 177501
		[FieldOffset(24)]
		public FString attachName;

		// Token: 0x0402B55E RID: 177502
		[FieldOffset(40)]
		public byte switchData;

		// Token: 0x0402B55F RID: 177503
		[FieldOffset(56)]
		public bool bFollow;

		// Token: 0x0402B560 RID: 177504
		[FieldOffset(64)]
		public IntPtr __WorldContext;

		// Token: 0x0402B561 RID: 177505
		[FieldOffset(72)]
		public float __Result;
	}

	// Token: 0x02008732 RID: 34610
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDebug_FunctionParams
	{
		// Token: 0x0402B562 RID: 177506
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B563 RID: 177507
		[FieldOffset(4)]
		public bool bDebug;

		// Token: 0x0402B564 RID: 177508
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008733 RID: 34611
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetAkComponentBySocketName_FunctionParams
	{
		// Token: 0x0402B565 RID: 177509
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B566 RID: 177510
		[FieldOffset(8)]
		public FString socketName;

		// Token: 0x0402B567 RID: 177511
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402B568 RID: 177512
		[FieldOffset(32)]
		public IntPtr __Result;
	}

	// Token: 0x02008734 RID: 34612
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetFootSwitch_FunctionParams
	{
		// Token: 0x0402B569 RID: 177513
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B56A RID: 177514
		[FieldOffset(8)]
		public FString footSwitch;

		// Token: 0x0402B56B RID: 177515
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008735 RID: 34613
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetFootSwitch_FunctionParams
	{
		// Token: 0x0402B56C RID: 177516
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B56D RID: 177517
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B56E RID: 177518
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008736 RID: 34614
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetWaterDepth_FunctionParams
	{
		// Token: 0x0402B56F RID: 177519
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B570 RID: 177520
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B571 RID: 177521
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x02008737 RID: 34615
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __PostRoleAudioEvent_FunctionParams
	{
		// Token: 0x0402B572 RID: 177522
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B573 RID: 177523
		[FieldOffset(8)]
		public FString action;

		// Token: 0x0402B574 RID: 177524
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008738 RID: 34616
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __EmitFootOnTheGroundEvent_FunctionParams
	{
		// Token: 0x0402B575 RID: 177525
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}
}
