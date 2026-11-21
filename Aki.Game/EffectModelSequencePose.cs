using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029ED RID: 10733
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelSequencePose.EffectModelSequencePose_C")]
public class EffectModelSequencePose : UEffectModelSequencePose, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AEF5 RID: 110325 RVA: 0x00845378 File Offset: 0x00843578
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelSequencePose._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelSequencePose.EffectModelSequencePose_C");
		}
		return EffectModelSequencePose._ClassPtr;
	}

	// Token: 0x0601AEF6 RID: 110326 RVA: 0x0084539C File Offset: 0x0084359C
	public EffectModelSequencePose() : this(BuiltinUtils.AllocNativeUObject(EffectModelSequencePose.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEF7 RID: 110327 RVA: 0x008453C4 File Offset: 0x008435C4
	[NullableContext(1)]
	public EffectModelSequencePose(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelSequencePose.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEF8 RID: 110328 RVA: 0x008453F7 File Offset: 0x008435F7
	protected EffectModelSequencePose(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400EA0A RID: 59914
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelSequencePose.EffectModelSequencePose_C";

	// Token: 0x0400EA0B RID: 59915
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA0C RID: 59916
	private static IntPtr _ClassDefaultObjectPtr;
}
