using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029EE RID: 10734
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelSkeletalMesh.EffectModelSkeletalMesh_C")]
public class EffectModelSkeletalMesh : UEffectModelSkeletalMesh, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AEF9 RID: 110329 RVA: 0x00845400 File Offset: 0x00843600
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelSkeletalMesh._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelSkeletalMesh.EffectModelSkeletalMesh_C");
		}
		return EffectModelSkeletalMesh._ClassPtr;
	}

	// Token: 0x0601AEFA RID: 110330 RVA: 0x00845424 File Offset: 0x00843624
	public EffectModelSkeletalMesh() : this(BuiltinUtils.AllocNativeUObject(EffectModelSkeletalMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEFB RID: 110331 RVA: 0x0084544C File Offset: 0x0084364C
	[NullableContext(1)]
	public EffectModelSkeletalMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelSkeletalMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEFC RID: 110332 RVA: 0x0084547F File Offset: 0x0084367F
	protected EffectModelSkeletalMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400EA0D RID: 59917
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelSkeletalMesh.EffectModelSkeletalMesh_C";

	// Token: 0x0400EA0E RID: 59918
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA0F RID: 59919
	private static IntPtr _ClassDefaultObjectPtr;
}
