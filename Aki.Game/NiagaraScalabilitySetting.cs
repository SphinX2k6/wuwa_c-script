using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scalability;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029F3 RID: 10739
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/Data/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/NiagaraScalabilitySetting.NiagaraScalabilitySetting_C")]
public class NiagaraScalabilitySetting : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002BB9 RID: 11193
	// (get) Token: 0x0601AF0E RID: 110350 RVA: 0x008456E4 File Offset: 0x008438E4
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

	// Token: 0x0601AF0F RID: 110351 RVA: 0x0084571D File Offset: 0x0084391D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (NiagaraScalabilitySetting._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/NiagaraScalabilitySetting.NiagaraScalabilitySetting_C");
		}
		return NiagaraScalabilitySetting._ClassPtr;
	}

	// Token: 0x0601AF10 RID: 110352 RVA: 0x00845744 File Offset: 0x00843944
	public NiagaraScalabilitySetting() : this(BuiltinUtils.AllocNativeUObject(NiagaraScalabilitySetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AF11 RID: 110353 RVA: 0x0084576C File Offset: 0x0084396C
	public NiagaraScalabilitySetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NiagaraScalabilitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AF12 RID: 110354 RVA: 0x0084579F File Offset: 0x0084399F
	protected NiagaraScalabilitySetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400EA1E RID: 59934
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/NiagaraScalabilitySetting.NiagaraScalabilitySetting_C";

	// Token: 0x0400EA1F RID: 59935
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA20 RID: 59936
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400EA21 RID: 59937
	private static int __PropertyOffset_NiagaraEffectTypes;

	// Token: 0x0400EA22 RID: 59938
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TMap<ENiagaraScalabilityType, UNiagaraEffectType> _NiagaraEffectTypes;
}
