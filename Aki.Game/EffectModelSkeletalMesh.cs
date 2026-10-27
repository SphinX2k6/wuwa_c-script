using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200347A RID: 13434
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelSkeletalMesh.EffectModelSkeletalMesh_C")]
public class EffectModelSkeletalMesh : UEffectModelSkeletalMesh, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1F1 RID: 119281 RVA: 0x0081E100 File Offset: 0x0081C300
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelSkeletalMesh._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelSkeletalMesh.EffectModelSkeletalMesh_C");
		}
		return EffectModelSkeletalMesh._ClassPtr;
	}

	// Token: 0x0601D1F2 RID: 119282 RVA: 0x0081E124 File Offset: 0x0081C324
	public EffectModelSkeletalMesh() : this(BuiltinUtils.AllocNativeUObject(EffectModelSkeletalMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1F3 RID: 119283 RVA: 0x0081E14C File Offset: 0x0081C34C
	[NullableContext(1)]
	public EffectModelSkeletalMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelSkeletalMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1F4 RID: 119284 RVA: 0x0081E17F File Offset: 0x0081C37F
	protected EffectModelSkeletalMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E555 RID: 58709
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelSkeletalMesh.EffectModelSkeletalMesh_C";

	// Token: 0x0400E556 RID: 58710
	private static IntPtr _ClassPtr;

	// Token: 0x0400E557 RID: 58711
	private static IntPtr _ClassDefaultObjectPtr;
}
