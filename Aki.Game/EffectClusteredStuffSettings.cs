using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200346C RID: 13420
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/EffectClusteredStuffSettings.EffectClusteredStuffSettings_C")]
public class EffectClusteredStuffSettings : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002815 RID: 10261
	// (get) Token: 0x0601D1B1 RID: 119217 RVA: 0x0081D8C4 File Offset: 0x0081BAC4
	// (set) Token: 0x0601D1B2 RID: 119218 RVA: 0x0081D8FD File Offset: 0x0081BAFD
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> EffectDataRef
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._EffectDataRef) == null)
			{
				result = (this._EffectDataRef = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_EffectDataRef, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_EffectDataRef, 1);
		}
	}

	// Token: 0x17002816 RID: 10262
	// (get) Token: 0x0601D1B3 RID: 119219 RVA: 0x0081D922 File Offset: 0x0081BB22
	// (set) Token: 0x0601D1B4 RID: 119220 RVA: 0x0081D932 File Offset: 0x0081BB32
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float DensityChangeSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_DensityChangeSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_DensityChangeSpeed) = value;
		}
	}

	// Token: 0x17002817 RID: 10263
	// (get) Token: 0x0601D1B5 RID: 119221 RVA: 0x0081D943 File Offset: 0x0081BB43
	// (set) Token: 0x0601D1B6 RID: 119222 RVA: 0x0081D953 File Offset: 0x0081BB53
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool AttachToActor
	{
		get
		{
			return *(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_AttachToActor) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_AttachToActor) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002818 RID: 10264
	// (get) Token: 0x0601D1B7 RID: 119223 RVA: 0x0081D964 File Offset: 0x0081BB64
	// (set) Token: 0x0601D1B8 RID: 119224 RVA: 0x0081D978 File Offset: 0x0081BB78
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector AbsoluteWorldPosition
	{
		get
		{
			return *(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_AbsoluteWorldPosition);
		}
		set
		{
			*(base.NativePtr + (IntPtr)EffectClusteredStuffSettings.__PropertyOffset_AbsoluteWorldPosition) = value;
		}
	}

	// Token: 0x0601D1B9 RID: 119225 RVA: 0x0081D98D File Offset: 0x0081BB8D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (EffectClusteredStuffSettings._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/EffectClusteredStuffSettings.EffectClusteredStuffSettings_C");
		}
		return EffectClusteredStuffSettings._ClassPtr;
	}

	// Token: 0x0601D1BA RID: 119226 RVA: 0x0081D9B4 File Offset: 0x0081BBB4
	public EffectClusteredStuffSettings() : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D1BB RID: 119227 RVA: 0x0081D9DC File Offset: 0x0081BBDC
	public EffectClusteredStuffSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectClusteredStuffSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D1BC RID: 119228 RVA: 0x0081DA0F File Offset: 0x0081BC0F
	protected EffectClusteredStuffSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E526 RID: 58662
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/ClusteredStuff/EffectClusteredStuffSettings.EffectClusteredStuffSettings_C";

	// Token: 0x0400E527 RID: 58663
	private static IntPtr _ClassPtr;

	// Token: 0x0400E528 RID: 58664
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E529 RID: 58665
	private static int __PropertyOffset_EffectDataRef;

	// Token: 0x0400E52A RID: 58666
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _EffectDataRef;

	// Token: 0x0400E52B RID: 58667
	private static int __PropertyOffset_DensityChangeSpeed;

	// Token: 0x0400E52C RID: 58668
	private static int __PropertyOffset_AttachToActor;

	// Token: 0x0400E52D RID: 58669
	private static int __PropertyOffset_AbsoluteWorldPosition;
}
