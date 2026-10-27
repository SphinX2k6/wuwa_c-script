using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003477 RID: 13431
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNiagara.EffectModelNiagara_C")]
public class EffectModelNiagara : UEffectModelNiagara, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D1E5 RID: 119269 RVA: 0x0081DF68 File Offset: 0x0081C168
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectModelNiagara._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNiagara.EffectModelNiagara_C");
		}
		return EffectModelNiagara._ClassPtr;
	}

	// Token: 0x0601D1E6 RID: 119270 RVA: 0x0081DF8C File Offset: 0x0081C18C
	public EffectModelNiagara() : this(BuiltinUtils.AllocNativeUObject(EffectModelNiagara.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1E7 RID: 119271 RVA: 0x0081DFB4 File Offset: 0x0081C1B4
	[NullableContext(1)]
	public EffectModelNiagara(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNiagara.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1E8 RID: 119272 RVA: 0x0081DFE7 File Offset: 0x0081C1E7
	protected EffectModelNiagara(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E54C RID: 58700
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNiagara.EffectModelNiagara_C";

	// Token: 0x0400E54D RID: 58701
	private static IntPtr _ClassPtr;

	// Token: 0x0400E54E RID: 58702
	private static IntPtr _ClassDefaultObjectPtr;
}
