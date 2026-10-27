using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scalability;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200347F RID: 13439
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/NiagaraScalabilitySetting.NiagaraScalabilitySetting_C")]
public class NiagaraScalabilitySetting : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700281A RID: 10266
	// (get) Token: 0x0601D206 RID: 119302 RVA: 0x0081E3E4 File Offset: 0x0081C5E4
	[UProperty(EPropertyFlags.CPF_None)]
	public TMap<ENiagaraScalabilityType, UNiagaraEffectType> NiagaraEffectTypes
	{
		get
		{
			base.FastCheckIsValid();
			TMap<ENiagaraScalabilityType, UNiagaraEffectType> result;
			if ((result = this._NiagaraEffectTypes) == null)
			{
				result = (this._NiagaraEffectTypes = new TMap<ENiagaraScalabilityType, UNiagaraEffectType>(base.NativePtr + (IntPtr)NiagaraScalabilitySetting.__PropertyOffset_NiagaraEffectTypes, this));
			}
			return result;
		}
	}

	// Token: 0x0601D207 RID: 119303 RVA: 0x0081E41D File Offset: 0x0081C61D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (NiagaraScalabilitySetting._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/NiagaraScalabilitySetting.NiagaraScalabilitySetting_C");
		}
		return NiagaraScalabilitySetting._ClassPtr;
	}

	// Token: 0x0601D208 RID: 119304 RVA: 0x0081E444 File Offset: 0x0081C644
	public NiagaraScalabilitySetting() : this(BuiltinUtils.AllocNativeUObject(NiagaraScalabilitySetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D209 RID: 119305 RVA: 0x0081E46C File Offset: 0x0081C66C
	public NiagaraScalabilitySetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NiagaraScalabilitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D20A RID: 119306 RVA: 0x0081E49F File Offset: 0x0081C69F
	protected NiagaraScalabilitySetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E566 RID: 58726
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/NiagaraScalabilitySetting.NiagaraScalabilitySetting_C";

	// Token: 0x0400E567 RID: 58727
	private static IntPtr _ClassPtr;

	// Token: 0x0400E568 RID: 58728
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E569 RID: 58729
	private static int __PropertyOffset_NiagaraEffectTypes;

	// Token: 0x0400E56A RID: 58730
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<ENiagaraScalabilityType, UNiagaraEffectType> _NiagaraEffectTypes;
}
