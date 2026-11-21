using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scalability;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029F1 RID: 10737
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectScalabilitySetting.EffectScalabilitySetting_C")]
public class EffectScalabilitySetting : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002BB8 RID: 11192
	// (get) Token: 0x0601AF05 RID: 110341 RVA: 0x00845598 File Offset: 0x00843798
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

	// Token: 0x0601AF06 RID: 110342 RVA: 0x008455D1 File Offset: 0x008437D1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectScalabilitySetting._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectScalabilitySetting.EffectScalabilitySetting_C");
		}
		return EffectScalabilitySetting._ClassPtr;
	}

	// Token: 0x0601AF07 RID: 110343 RVA: 0x008455F8 File Offset: 0x008437F8
	public EffectScalabilitySetting() : this(BuiltinUtils.AllocNativeUObject(EffectScalabilitySetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AF08 RID: 110344 RVA: 0x00845620 File Offset: 0x00843820
	[NullableContext(1)]
	public EffectScalabilitySetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectScalabilitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AF09 RID: 110345 RVA: 0x00845653 File Offset: 0x00843853
	protected EffectScalabilitySetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400EA16 RID: 59926
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectScalabilitySetting.EffectScalabilitySetting_C";

	// Token: 0x0400EA17 RID: 59927
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA18 RID: 59928
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400EA19 RID: 59929
	private static int __PropertyOffset_NiagaraSettings;

	// Token: 0x0400EA1A RID: 59930
	[Nullable(new byte[]
	{
		2,
		0,
		1,
		1
	})]
	private TMap<TEnumAsByte<EEffectScalabilityType>, TSoftObjectPtr<NiagaraScalabilitySetting>> _NiagaraSettings;
}
