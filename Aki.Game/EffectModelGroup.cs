using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029E7 RID: 10727
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGroup.EffectModelGroup_C")]
public class EffectModelGroup : UEffectModelGroup, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AEDD RID: 110301 RVA: 0x00845048 File Offset: 0x00843248
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelGroup._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGroup.EffectModelGroup_C");
		}
		return EffectModelGroup._ClassPtr;
	}

	// Token: 0x0601AEDE RID: 110302 RVA: 0x0084506C File Offset: 0x0084326C
	public EffectModelGroup() : this(BuiltinUtils.AllocNativeUObject(EffectModelGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEDF RID: 110303 RVA: 0x00845094 File Offset: 0x00843294
	[NullableContext(1)]
	public EffectModelGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEE0 RID: 110304 RVA: 0x008450C7 File Offset: 0x008432C7
	protected EffectModelGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E9F8 RID: 59896
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelGroup.EffectModelGroup_C";

	// Token: 0x0400E9F9 RID: 59897
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9FA RID: 59898
	private static IntPtr _ClassDefaultObjectPtr;
}
