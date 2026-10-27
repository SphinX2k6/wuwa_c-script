using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020032B3 RID: 12979
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/Util/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/Util/SceneItemLibrary.SceneItemLibrary_C")]
public class SceneItemLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601C205 RID: 115205 RVA: 0x007D47DC File Offset: 0x007D29DC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<TsSimpleInteractBase> FindInteractItemByTypeId(int typeId)
	{
		HashSet<TsSimpleInteractBase> tsSimpleInteractItemById = WorldModel.Instance.GetTsSimpleInteractItemById((long)typeId);
		TArray<TsSimpleInteractBase> tarray = new TArray<TsSimpleInteractBase>();
		if (tsSimpleInteractItemById == null)
		{
			return tarray;
		}
		foreach (TsSimpleInteractBase value in tsSimpleInteractItemById)
		{
			tarray.Add(value);
		}
		return tarray;
	}

	// Token: 0x0601C206 RID: 115206 RVA: 0x007D4844 File Offset: 0x007D2A44
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SceneItemLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/Util/SceneItemLibrary.SceneItemLibrary_C");
		}
		return SceneItemLibrary._ClassPtr;
	}

	// Token: 0x0601C207 RID: 115207 RVA: 0x007D4868 File Offset: 0x007D2A68
	public SceneItemLibrary() : this(BuiltinUtils.AllocNativeUObject(SceneItemLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C208 RID: 115208 RVA: 0x007D4890 File Offset: 0x007D2A90
	[NullableContext(1)]
	public SceneItemLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneItemLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C209 RID: 115209 RVA: 0x007D48C3 File Offset: 0x007D2AC3
	protected SceneItemLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C20A RID: 115210 RVA: 0x007D48CC File Offset: 0x007D2ACC
	protected unsafe static void __CPPCALL_FindInteractItemByTypeId_Implementation(SceneItemLibrary.__FindInteractItemByTypeId_FunctionParams* __Params)
	{
		TArray<TsSimpleInteractBase> tarray = SceneItemLibrary.FindInteractItemByTypeId(__Params->typeId);
		if (tarray == null)
		{
			return;
		}
		tarray.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0400DE88 RID: 56968
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/Util/SceneItemLibrary.SceneItemLibrary_C";

	// Token: 0x0400DE89 RID: 56969
	private static IntPtr _ClassPtr;

	// Token: 0x0400DE8A RID: 56970
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0200974B RID: 38731
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __FindInteractItemByTypeId_FunctionParams
	{
		// Token: 0x04030675 RID: 198261
		[FieldOffset(0)]
		public int typeId;

		// Token: 0x04030676 RID: 198262
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04030677 RID: 198263
		[FieldOffset(16)]
		public byte __Result;
	}
}
