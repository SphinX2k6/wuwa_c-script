using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200346B RID: 13419
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/EffectClusteredStuffDefaultSettings.EffectClusteredStuffDefaultSettings_C")]
public class EffectClusteredStuffDefaultSettings : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002814 RID: 10260
	// (get) Token: 0x0601D1AC RID: 119212 RVA: 0x0081D800 File Offset: 0x0081BA00
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<EffectClusteredStuffSettings> Settings
	{
		get
		{
			base.FastCheckIsValid();
			TArray<EffectClusteredStuffSettings> result;
			if ((result = this._Settings) == null)
			{
				result = (this._Settings = new TArray<EffectClusteredStuffSettings>(base.NativePtr + (IntPtr)EffectClusteredStuffDefaultSettings.__PropertyOffset_Settings, this));
			}
			return result;
		}
	}

	// Token: 0x0601D1AD RID: 119213 RVA: 0x0081D839 File Offset: 0x0081BA39
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectClusteredStuffDefaultSettings._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/EffectClusteredStuffDefaultSettings.EffectClusteredStuffDefaultSettings_C");
		}
		return EffectClusteredStuffDefaultSettings._ClassPtr;
	}

	// Token: 0x0601D1AE RID: 119214 RVA: 0x0081D860 File Offset: 0x0081BA60
	public EffectClusteredStuffDefaultSettings() : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffDefaultSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1AF RID: 119215 RVA: 0x0081D888 File Offset: 0x0081BA88
	public EffectClusteredStuffDefaultSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffDefaultSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1B0 RID: 119216 RVA: 0x0081D8BB File Offset: 0x0081BABB
	protected EffectClusteredStuffDefaultSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E521 RID: 58657
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/EffectClusteredStuffDefaultSettings.EffectClusteredStuffDefaultSettings_C";

	// Token: 0x0400E522 RID: 58658
	private static IntPtr _ClassPtr;

	// Token: 0x0400E523 RID: 58659
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E524 RID: 58660
	private static int __PropertyOffset_Settings;

	// Token: 0x0400E525 RID: 58661
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<EffectClusteredStuffSettings> _Settings;
}
