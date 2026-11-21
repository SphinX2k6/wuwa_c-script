using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029EF RID: 10735
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelStaticMesh.EffectModelStaticMesh_C")]
public class EffectModelStaticMesh : UEffectModelStaticMesh, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AEFD RID: 110333 RVA: 0x00845488 File Offset: 0x00843688
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelStaticMesh._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelStaticMesh.EffectModelStaticMesh_C");
		}
		return EffectModelStaticMesh._ClassPtr;
	}

	// Token: 0x0601AEFE RID: 110334 RVA: 0x008454AC File Offset: 0x008436AC
	public EffectModelStaticMesh() : this(BuiltinUtils.AllocNativeUObject(EffectModelStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEFF RID: 110335 RVA: 0x008454D4 File Offset: 0x008436D4
	[NullableContext(1)]
	public EffectModelStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AF00 RID: 110336 RVA: 0x00845507 File Offset: 0x00843707
	protected EffectModelStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400EA10 RID: 59920
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelStaticMesh.EffectModelStaticMesh_C";

	// Token: 0x0400EA11 RID: 59921
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA12 RID: 59922
	private static IntPtr _ClassDefaultObjectPtr;
}
