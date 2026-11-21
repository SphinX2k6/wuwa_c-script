using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029DF RID: 10719
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/EffectClusteredStuffDefaultSettings.EffectClusteredStuffDefaultSettings_C")]
public class EffectClusteredStuffDefaultSettings : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002BB3 RID: 11187
	// (get) Token: 0x0601AEB4 RID: 110260 RVA: 0x00844B00 File Offset: 0x00842D00
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

	// Token: 0x0601AEB5 RID: 110261 RVA: 0x00844B39 File Offset: 0x00842D39
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectClusteredStuffDefaultSettings._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/EffectClusteredStuffDefaultSettings.EffectClusteredStuffDefaultSettings_C");
		}
		return EffectClusteredStuffDefaultSettings._ClassPtr;
	}

	// Token: 0x0601AEB6 RID: 110262 RVA: 0x00844B60 File Offset: 0x00842D60
	public EffectClusteredStuffDefaultSettings() : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffDefaultSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEB7 RID: 110263 RVA: 0x00844B88 File Offset: 0x00842D88
	public EffectClusteredStuffDefaultSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffDefaultSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEB8 RID: 110264 RVA: 0x00844BBB File Offset: 0x00842DBB
	protected EffectClusteredStuffDefaultSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E9D9 RID: 59865
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/EffectClusteredStuffDefaultSettings.EffectClusteredStuffDefaultSettings_C";

	// Token: 0x0400E9DA RID: 59866
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9DB RID: 59867
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E9DC RID: 59868
	private static int __PropertyOffset_Settings;

	// Token: 0x0400E9DD RID: 59869
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<EffectClusteredStuffSettings> _Settings;
}
