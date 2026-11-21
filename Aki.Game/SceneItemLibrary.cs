using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002824 RID: 10276
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/Util/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/Util/SceneItemLibrary.SceneItemLibrary_C")]
public class SceneItemLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06019E46 RID: 106054 RVA: 0x007FB8D8 File Offset: 0x007F9AD8
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

	// Token: 0x06019E47 RID: 106055 RVA: 0x007FB940 File Offset: 0x007F9B40
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SceneItemLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/Util/SceneItemLibrary.SceneItemLibrary_C");
		}
		return SceneItemLibrary._ClassPtr;
	}

	// Token: 0x06019E48 RID: 106056 RVA: 0x007FB964 File Offset: 0x007F9B64
	public SceneItemLibrary() : this(BuiltinUtils.AllocNativeUObject(SceneItemLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019E49 RID: 106057 RVA: 0x007FB98C File Offset: 0x007F9B8C
	[NullableContext(1)]
	public SceneItemLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneItemLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019E4A RID: 106058 RVA: 0x007FB9BF File Offset: 0x007F9BBF
	protected SceneItemLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06019E4B RID: 106059 RVA: 0x007FB9C8 File Offset: 0x007F9BC8
	protected unsafe static void __CPPCALL_FindInteractItemByTypeId_Implementation(SceneItemLibrary.__FindInteractItemByTypeId_FunctionParams* __Params)
	{
		TArray<TsSimpleInteractBase> tarray = SceneItemLibrary.FindInteractItemByTypeId(__Params->typeId);
		if (tarray == null)
		{
			return;
		}
		tarray.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0400E32E RID: 58158
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/Util/SceneItemLibrary.SceneItemLibrary_C";

	// Token: 0x0400E32F RID: 58159
	private static IntPtr _ClassPtr;

	// Token: 0x0400E330 RID: 58160
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008972 RID: 35186
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __FindInteractItemByTypeId_FunctionParams
	{
		// Token: 0x0402BD0C RID: 179468
		[FieldOffset(0)]
		public int typeId;

		// Token: 0x0402BD0D RID: 179469
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402BD0E RID: 179470
		[FieldOffset(16)]
		public byte __Result;
	}
}
