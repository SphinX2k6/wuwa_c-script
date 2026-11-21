using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029EC RID: 10732
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelPostProcess.EffectModelPostProcess_C")]
public class EffectModelPostProcess : UEffectModelPostProcess, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AEF1 RID: 110321 RVA: 0x008452F0 File Offset: 0x008434F0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelPostProcess._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelPostProcess.EffectModelPostProcess_C");
		}
		return EffectModelPostProcess._ClassPtr;
	}

	// Token: 0x0601AEF2 RID: 110322 RVA: 0x00845314 File Offset: 0x00843514
	public EffectModelPostProcess() : this(BuiltinUtils.AllocNativeUObject(EffectModelPostProcess.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEF3 RID: 110323 RVA: 0x0084533C File Offset: 0x0084353C
	[NullableContext(1)]
	public EffectModelPostProcess(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelPostProcess.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEF4 RID: 110324 RVA: 0x0084536F File Offset: 0x0084356F
	protected EffectModelPostProcess(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400EA07 RID: 59911
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelPostProcess.EffectModelPostProcess_C";

	// Token: 0x0400EA08 RID: 59912
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA09 RID: 59913
	private static IntPtr _ClassDefaultObjectPtr;
}
