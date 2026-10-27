using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003478 RID: 13432
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelPostProcess.EffectModelPostProcess_C")]
public class EffectModelPostProcess : UEffectModelPostProcess, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1E9 RID: 119273 RVA: 0x0081DFF0 File Offset: 0x0081C1F0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelPostProcess._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelPostProcess.EffectModelPostProcess_C");
		}
		return EffectModelPostProcess._ClassPtr;
	}

	// Token: 0x0601D1EA RID: 119274 RVA: 0x0081E014 File Offset: 0x0081C214
	public EffectModelPostProcess() : this(BuiltinUtils.AllocNativeUObject(EffectModelPostProcess.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1EB RID: 119275 RVA: 0x0081E03C File Offset: 0x0081C23C
	[NullableContext(1)]
	public EffectModelPostProcess(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelPostProcess.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1EC RID: 119276 RVA: 0x0081E06F File Offset: 0x0081C26F
	protected EffectModelPostProcess(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E54F RID: 58703
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelPostProcess.EffectModelPostProcess_C";

	// Token: 0x0400E550 RID: 58704
	private static IntPtr _ClassPtr;

	// Token: 0x0400E551 RID: 58705
	private static IntPtr _ClassDefaultObjectPtr;
}
