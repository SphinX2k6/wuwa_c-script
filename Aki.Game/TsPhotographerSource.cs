using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020025AE RID: 9646
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Module/Photograph/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/Photograph/TsPhotographerSource.TsPhotographerSource_C")]
public class TsPhotographerSource : AActor, IUnrealUObject, IUnrealObject
{
	// Token: 0x060138D7 RID: 80087 RVA: 0x004E2DD1 File Offset: 0x004E0FD1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsPhotographerSource._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/Photograph/TsPhotographerSource.TsPhotographerSource_C");
		}
		return TsPhotographerSource._ClassPtr;
	}

	// Token: 0x060138D8 RID: 80088 RVA: 0x004E2DF8 File Offset: 0x004E0FF8
	public TsPhotographerSource() : this(BuiltinUtils.AllocNativeUObject(TsPhotographerSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060138D9 RID: 80089 RVA: 0x004E2E20 File Offset: 0x004E1020
	public TsPhotographerSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsPhotographerSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060138DA RID: 80090 RVA: 0x004E2E53 File Offset: 0x004E1053
	protected TsPhotographerSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x1700192C RID: 6444
	// (get) Token: 0x060138DB RID: 80091 RVA: 0x004E2E5C File Offset: 0x004E105C
	public unsafe FPointerToUberGraphFrame UberGraphFrame
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsPhotographerSource.__PropertyOffset_UberGraphFrame);
		}
	}

	// Token: 0x1700192D RID: 6445
	// (get) Token: 0x060138DC RID: 80092 RVA: 0x004E2E6C File Offset: 0x004E106C
	[Nullable(2)]
	public unsafe USceneComponent DefaultSceneRoot
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + TsPhotographerSource.__PropertyOffset_DefaultSceneRoot);
		}
	}

	// Token: 0x040093AE RID: 37806
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/Photograph/TsPhotographerSource.TsPhotographerSource_C";

	// Token: 0x040093AF RID: 37807
	private static IntPtr _ClassPtr;

	// Token: 0x040093B0 RID: 37808
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040093B1 RID: 37809
	private static int __PropertyOffset_UberGraphFrame;

	// Token: 0x040093B2 RID: 37810
	private static int __PropertyOffset_DefaultSceneRoot;
}
