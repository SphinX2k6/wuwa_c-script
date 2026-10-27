using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E42 RID: 11842
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMediaBlueprintFunctionLibrary.TsMediaBlueprintFunctionLibrary_C")]
public class TsMediaBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x060192D8 RID: 103128 RVA: 0x0067B3CC File Offset: 0x006795CC
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static bool GetAffectedByP1orP3(int entityId)
	{
		CharacterAkComponent component = EntitySystem.Instance.GetComponent<CharacterAkComponent>(entityId);
		return component == null || component.IsP1;
	}

	// Token: 0x060192D9 RID: 103129 RVA: 0x0067B3F0 File Offset: 0x006795F0
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

	// Token: 0x060192DA RID: 103130 RVA: 0x0067B420 File Offset: 0x00679620
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

	// Token: 0x060192DB RID: 103131 RVA: 0x0067B454 File Offset: 0x00679654
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

	// Token: 0x060192DC RID: 103132 RVA: 0x0067B478 File Offset: 0x00679678
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

	// Token: 0x060192DD RID: 103133 RVA: 0x0067B4AC File Offset: 0x006796AC
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

	// Token: 0x060192DE RID: 103134 RVA: 0x0067B4D0 File Offset: 0x006796D0
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

	// Token: 0x060192DF RID: 103135 RVA: 0x0067B4F8 File Offset: 0x006796F8
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

	// Token: 0x060192E0 RID: 103136 RVA: 0x0067B521 File Offset: 0x00679721
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

	// Token: 0x060192E1 RID: 103137 RVA: 0x0067B539 File Offset: 0x00679739
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void EmitFootOnTheGroundEvent()
	{
		EventSystem.Instance.Emit<bool>(EEventName.OnCharFootOnTheGround, false);
	}

	// Token: 0x060192E2 RID: 103138 RVA: 0x0067B54C File Offset: 0x0067974C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsMediaBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMediaBlueprintFunctionLibrary.TsMediaBlueprintFunctionLibrary_C");
		}
		return TsMediaBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x060192E3 RID: 103139 RVA: 0x0067B570 File Offset: 0x00679770
	public TsMediaBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsMediaBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060192E4 RID: 103140 RVA: 0x0067B598 File Offset: 0x00679798
	[NullableContext(1)]
	public TsMediaBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMediaBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060192E5 RID: 103141 RVA: 0x0067B5CB File Offset: 0x006797CB
	protected TsMediaBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060192E6 RID: 103142 RVA: 0x0067B5D4 File Offset: 0x006797D4
	protected unsafe static void __CPPCALL_GetAffectedByP1orP3_Implementation(TsMediaBlueprintFunctionLibrary.__GetAffectedByP1orP3_FunctionParams* __Params)
	{
		__Params->__Result = TsMediaBlueprintFunctionLibrary.GetAffectedByP1orP3(__Params->entityId);
	}

	// Token: 0x060192E7 RID: 103143 RVA: 0x0067B5E8 File Offset: 0x006797E8
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

	// Token: 0x060192E8 RID: 103144 RVA: 0x0067B65C File Offset: 0x0067985C
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

	// Token: 0x060192E9 RID: 103145 RVA: 0x0067B6D3 File Offset: 0x006798D3
	protected unsafe static void __CPPCALL_SetDebug_Implementation(TsMediaBlueprintFunctionLibrary.__SetDebug_FunctionParams* __Params)
	{
		TsMediaBlueprintFunctionLibrary.SetDebug(__Params->entityId, __Params->bDebug);
	}

	// Token: 0x060192EA RID: 103146 RVA: 0x0067B6E8 File Offset: 0x006798E8
	protected unsafe static void __CPPCALL_GetAkComponentBySocketName_Implementation(TsMediaBlueprintFunctionLibrary.__GetAkComponentBySocketName_FunctionParams* __Params)
	{
		string socketName = FString.ToString((void*)(&__Params->socketName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		UAkComponent akComponentBySocketName = TsMediaBlueprintFunctionLibrary.GetAkComponentBySocketName(__Params->entityId, socketName);
		ptr = ((akComponentBySocketName != null) ? akComponentBySocketName.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060192EB RID: 103147 RVA: 0x0067B724 File Offset: 0x00679924
	protected unsafe static void __CPPCALL_SetFootSwitch_Implementation(TsMediaBlueprintFunctionLibrary.__SetFootSwitch_FunctionParams* __Params)
	{
		string footSwitch = FString.ToString((void*)(&__Params->footSwitch));
		TsMediaBlueprintFunctionLibrary.SetFootSwitch(__Params->entityId, footSwitch);
	}

	// Token: 0x060192EC RID: 103148 RVA: 0x0067B74A File Offset: 0x0067994A
	protected unsafe static void __CPPCALL_GetFootSwitch_Implementation(TsMediaBlueprintFunctionLibrary.__GetFootSwitch_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), TsMediaBlueprintFunctionLibrary.GetFootSwitch(__Params->entityId));
	}

	// Token: 0x060192ED RID: 103149 RVA: 0x0067B763 File Offset: 0x00679963
	protected unsafe static void __CPPCALL_GetWaterDepth_Implementation(TsMediaBlueprintFunctionLibrary.__GetWaterDepth_FunctionParams* __Params)
	{
		__Params->__Result = TsMediaBlueprintFunctionLibrary.GetWaterDepth(__Params->entityId);
	}

	// Token: 0x060192EE RID: 103150 RVA: 0x0067B778 File Offset: 0x00679978
	protected unsafe static void __CPPCALL_PostRoleAudioEvent_Implementation(TsMediaBlueprintFunctionLibrary.__PostRoleAudioEvent_FunctionParams* __Params)
	{
		string action = FString.ToString((void*)(&__Params->action));
		TsMediaBlueprintFunctionLibrary.PostRoleAudioEvent(__Params->entityId, action);
	}

	// Token: 0x060192EF RID: 103151 RVA: 0x0067B79E File Offset: 0x0067999E
	protected unsafe static void __CPPCALL_EmitFootOnTheGroundEvent_Implementation(TsMediaBlueprintFunctionLibrary.__EmitFootOnTheGroundEvent_FunctionParams* __Params)
	{
		TsMediaBlueprintFunctionLibrary.EmitFootOnTheGroundEvent();
	}

	// Token: 0x0400BB9E RID: 48030
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsMediaBlueprintFunctionLibrary.TsMediaBlueprintFunctionLibrary_C";

	// Token: 0x0400BB9F RID: 48031
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBA0 RID: 48032
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02009507 RID: 38151
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAffectedByP1orP3_FunctionParams
	{
		// Token: 0x0402FEC2 RID: 196290
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEC3 RID: 196291
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEC4 RID: 196292
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009508 RID: 38152
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 72)]
	protected ref struct __PostAkEventByTs_FunctionParams
	{
		// Token: 0x0402FEC5 RID: 196293
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEC6 RID: 196294
		[FieldOffset(8)]
		public IntPtr charAkComponent;

		// Token: 0x0402FEC7 RID: 196295
		[FieldOffset(16)]
		public IntPtr eventPtr;

		// Token: 0x0402FEC8 RID: 196296
		[FieldOffset(24)]
		public FString attachName;

		// Token: 0x0402FEC9 RID: 196297
		[FieldOffset(40)]
		public byte switchDataRef;

		// Token: 0x0402FECA RID: 196298
		[FieldOffset(56)]
		public bool bFollow;

		// Token: 0x0402FECB RID: 196299
		[FieldOffset(64)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009509 RID: 38153
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __PostAkEventByTsWithoutData_FunctionParams
	{
		// Token: 0x0402FECC RID: 196300
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FECD RID: 196301
		[FieldOffset(8)]
		public IntPtr charAkComponent;

		// Token: 0x0402FECE RID: 196302
		[FieldOffset(16)]
		public IntPtr eventPtr;

		// Token: 0x0402FECF RID: 196303
		[FieldOffset(24)]
		public FString attachName;

		// Token: 0x0402FED0 RID: 196304
		[FieldOffset(40)]
		public byte switchData;

		// Token: 0x0402FED1 RID: 196305
		[FieldOffset(56)]
		public bool bFollow;

		// Token: 0x0402FED2 RID: 196306
		[FieldOffset(64)]
		public IntPtr __WorldContext;

		// Token: 0x0402FED3 RID: 196307
		[FieldOffset(72)]
		public float __Result;
	}

	// Token: 0x0200950A RID: 38154
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetDebug_FunctionParams
	{
		// Token: 0x0402FED4 RID: 196308
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FED5 RID: 196309
		[FieldOffset(4)]
		public bool bDebug;

		// Token: 0x0402FED6 RID: 196310
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200950B RID: 38155
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __GetAkComponentBySocketName_FunctionParams
	{
		// Token: 0x0402FED7 RID: 196311
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FED8 RID: 196312
		[FieldOffset(8)]
		public FString socketName;

		// Token: 0x0402FED9 RID: 196313
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEDA RID: 196314
		[FieldOffset(32)]
		public IntPtr __Result;
	}

	// Token: 0x0200950C RID: 38156
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetFootSwitch_FunctionParams
	{
		// Token: 0x0402FEDB RID: 196315
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEDC RID: 196316
		[FieldOffset(8)]
		public FString footSwitch;

		// Token: 0x0402FEDD RID: 196317
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200950D RID: 38157
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetFootSwitch_FunctionParams
	{
		// Token: 0x0402FEDE RID: 196318
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEDF RID: 196319
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEE0 RID: 196320
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x0200950E RID: 38158
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetWaterDepth_FunctionParams
	{
		// Token: 0x0402FEE1 RID: 196321
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEE2 RID: 196322
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FEE3 RID: 196323
		[FieldOffset(16)]
		public float __Result;
	}

	// Token: 0x0200950F RID: 38159
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __PostRoleAudioEvent_FunctionParams
	{
		// Token: 0x0402FEE4 RID: 196324
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FEE5 RID: 196325
		[FieldOffset(8)]
		public FString action;

		// Token: 0x0402FEE6 RID: 196326
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009510 RID: 38160
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __EmitFootOnTheGroundEvent_FunctionParams
	{
		// Token: 0x0402FEE7 RID: 196327
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}
}
