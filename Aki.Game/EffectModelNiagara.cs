using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029EB RID: 10731
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNiagara.EffectModelNiagara_C")]
public class EffectModelNiagara : UEffectModelNiagara, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AEED RID: 110317 RVA: 0x00845268 File Offset: 0x00843468
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelNiagara._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNiagara.EffectModelNiagara_C");
		}
		return EffectModelNiagara._ClassPtr;
	}

	// Token: 0x0601AEEE RID: 110318 RVA: 0x0084528C File Offset: 0x0084348C
	public EffectModelNiagara() : this(BuiltinUtils.AllocNativeUObject(EffectModelNiagara.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEEF RID: 110319 RVA: 0x008452B4 File Offset: 0x008434B4
	[NullableContext(1)]
	public EffectModelNiagara(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNiagara.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEF0 RID: 110320 RVA: 0x008452E7 File Offset: 0x008434E7
	protected EffectModelNiagara(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400EA04 RID: 59908
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNiagara.EffectModelNiagara_C";

	// Token: 0x0400EA05 RID: 59909
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA06 RID: 59910
	private static IntPtr _ClassDefaultObjectPtr;
}
