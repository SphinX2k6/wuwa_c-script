using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02001A99 RID: 6809
[UClass("/Game/Aki/TypeScript/Game/Module/Photograph/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Photograph/TsPhotographerSource.TsPhotographerSource_C")]
public class TsPhotographerSource : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x06010DB8 RID: 69048 RVA: 0x004F19E1 File Offset: 0x004EFBE1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsPhotographerSource._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Photograph/TsPhotographerSource.TsPhotographerSource_C");
		}
		return TsPhotographerSource._ClassPtr;
	}

	// Token: 0x06010DB9 RID: 69049 RVA: 0x004F1A08 File Offset: 0x004EFC08
	public TsPhotographerSource() : this(BuiltinUtils.AllocNativeUObject(TsPhotographerSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06010DBA RID: 69050 RVA: 0x004F1A30 File Offset: 0x004EFC30
	[NullableContext(1)]
	public TsPhotographerSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsPhotographerSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06010DBB RID: 69051 RVA: 0x004F1A63 File Offset: 0x004EFC63
	protected TsPhotographerSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x17001965 RID: 6501
	// (get) Token: 0x06010DBC RID: 69052 RVA: 0x004F1A6C File Offset: 0x004EFC6C
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsPhotographerSource.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x04009505 RID: 38149
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Photograph/TsPhotographerSource.TsPhotographerSource_C";

	// Token: 0x04009506 RID: 38150
	private static IntPtr _ClassPtr;

	// Token: 0x04009507 RID: 38151
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04009508 RID: 38152
	private static int __PropertyOffset_DefaultSceneRoot;
}
