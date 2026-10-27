using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200347B RID: 13435
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelStaticMesh.EffectModelStaticMesh_C")]
public class EffectModelStaticMesh : UEffectModelStaticMesh, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1F5 RID: 119285 RVA: 0x0081E188 File Offset: 0x0081C388
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelStaticMesh._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelStaticMesh.EffectModelStaticMesh_C");
		}
		return EffectModelStaticMesh._ClassPtr;
	}

	// Token: 0x0601D1F6 RID: 119286 RVA: 0x0081E1AC File Offset: 0x0081C3AC
	public EffectModelStaticMesh() : this(BuiltinUtils.AllocNativeUObject(EffectModelStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1F7 RID: 119287 RVA: 0x0081E1D4 File Offset: 0x0081C3D4
	[NullableContext(1)]
	public EffectModelStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1F8 RID: 119288 RVA: 0x0081E207 File Offset: 0x0081C407
	protected EffectModelStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E558 RID: 58712
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelStaticMesh.EffectModelStaticMesh_C";

	// Token: 0x0400E559 RID: 58713
	private static IntPtr _ClassPtr;

	// Token: 0x0400E55A RID: 58714
	private static IntPtr _ClassDefaultObjectPtr;
}
