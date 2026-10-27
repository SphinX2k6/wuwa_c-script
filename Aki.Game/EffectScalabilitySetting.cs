using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scalability;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200347D RID: 13437
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectScalabilitySetting.EffectScalabilitySetting_C")]
public class EffectScalabilitySetting : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002819 RID: 10265
	// (get) Token: 0x0601D1FD RID: 119293 RVA: 0x0081E298 File Offset: 0x0081C498
	[Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<TEnumAsByte<EEffectScalabilityType>, TSoftObjectPtr<NiagaraScalabilitySetting>> NiagaraSettings
	{
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		get
		{
			base.FastCheckIsValid();
			TMap<TEnumAsByte<EEffectScalabilityType>, TSoftObjectPtr<NiagaraScalabilitySetting>> result;
			if ((result = this._NiagaraSettings) == null)
			{
				result = (this._NiagaraSettings = new TMap<TEnumAsByte<EEffectScalabilityType>, TSoftObjectPtr<NiagaraScalabilitySetting>>(base.NativePtr + (IntPtr)EffectScalabilitySetting.__PropertyOffset_NiagaraSettings, this));
			}
			return result;
		}
	}

	// Token: 0x0601D1FE RID: 119294 RVA: 0x0081E2D1 File Offset: 0x0081C4D1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectScalabilitySetting._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectScalabilitySetting.EffectScalabilitySetting_C");
		}
		return EffectScalabilitySetting._ClassPtr;
	}

	// Token: 0x0601D1FF RID: 119295 RVA: 0x0081E2F8 File Offset: 0x0081C4F8
	public EffectScalabilitySetting() : this(BuiltinUtils.AllocNativeUObject(EffectScalabilitySetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D200 RID: 119296 RVA: 0x0081E320 File Offset: 0x0081C520
	[NullableContext(1)]
	public EffectScalabilitySetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectScalabilitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D201 RID: 119297 RVA: 0x0081E353 File Offset: 0x0081C553
	protected EffectScalabilitySetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E55E RID: 58718
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectScalabilitySetting.EffectScalabilitySetting_C";

	// Token: 0x0400E55F RID: 58719
	private static IntPtr _ClassPtr;

	// Token: 0x0400E560 RID: 58720
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E561 RID: 58721
	private static int __PropertyOffset_NiagaraSettings;

	// Token: 0x0400E562 RID: 58722
	[Nullable(new byte[]
	{
		2,
		0,
		1,
		1
	})]
	private TMap<TEnumAsByte<EEffectScalabilityType>, TSoftObjectPtr<NiagaraScalabilitySetting>> _NiagaraSettings;
}
