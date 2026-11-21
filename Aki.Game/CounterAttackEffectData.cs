using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000261 RID: 609
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Define/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Define/CounterAttackEffectData.CounterAttackEffectData_C")]
public class CounterAttackEffectData : UKuroBpDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x170005C7 RID: 1479
	// (get) Token: 0x060025F0 RID: 9712 RVA: 0x000E7170 File Offset: 0x000E5370
	// (set) Token: 0x060025F1 RID: 9713 RVA: 0x000E7180 File Offset: 0x000E5380
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Pos
	{
		get
		{
			return *(base.NativePtr + (IntPtr)CounterAttackEffectData.__PropertyOffset_Pos);
		}
		set
		{
			*(base.NativePtr + (IntPtr)CounterAttackEffectData.__PropertyOffset_Pos) = value;
		}
	}

	// Token: 0x170005C8 RID: 1480
	// (get) Token: 0x060025F2 RID: 9714 RVA: 0x000E7191 File Offset: 0x000E5391
	// (set) Token: 0x060025F3 RID: 9715 RVA: 0x000E71A5 File Offset: 0x000E53A5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector Offset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)CounterAttackEffectData.__PropertyOffset_Offset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)CounterAttackEffectData.__PropertyOffset_Offset) = value;
		}
	}

	// Token: 0x170005C9 RID: 1481
	// (get) Token: 0x060025F4 RID: 9716 RVA: 0x000E71BA File Offset: 0x000E53BA
	// (set) Token: 0x060025F5 RID: 9717 RVA: 0x000E71CE File Offset: 0x000E53CE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector Scale
	{
		get
		{
			return *(base.NativePtr + (IntPtr)CounterAttackEffectData.__PropertyOffset_Scale);
		}
		set
		{
			*(base.NativePtr + (IntPtr)CounterAttackEffectData.__PropertyOffset_Scale) = value;
		}
	}

	// Token: 0x170005CA RID: 1482
	// (get) Token: 0x060025F6 RID: 9718 RVA: 0x000E71E4 File Offset: 0x000E53E4
	// (set) Token: 0x060025F7 RID: 9719 RVA: 0x000E721D File Offset: 0x000E541D
	[UProperty(EPropertyFlags.CPF_None)]
	public FSoftObjectPath EffectDA
	{
		get
		{
			base.FastCheckIsValid();
			FSoftObjectPath result;
			if ((result = this._EffectDA) == null)
			{
				result = (this._EffectDA = new FSoftObjectPath(base.NativePtr + (IntPtr)CounterAttackEffectData.__PropertyOffset_EffectDA, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)CounterAttackEffectData.__PropertyOffset_EffectDA, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x060025F8 RID: 9720 RVA: 0x000E7245 File Offset: 0x000E5445
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CounterAttackEffectData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Define/CounterAttackEffectData.CounterAttackEffectData_C");
		}
		return CounterAttackEffectData._ClassPtr;
	}

	// Token: 0x060025F9 RID: 9721 RVA: 0x000E726C File Offset: 0x000E546C
	public CounterAttackEffectData() : this(BuiltinUtils.AllocNativeUObject(CounterAttackEffectData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060025FA RID: 9722 RVA: 0x000E7294 File Offset: 0x000E5494
	public CounterAttackEffectData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CounterAttackEffectData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060025FB RID: 9723 RVA: 0x000E72C7 File Offset: 0x000E54C7
	protected CounterAttackEffectData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x040024A1 RID: 9377
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Define/CounterAttackEffectData.CounterAttackEffectData_C";

	// Token: 0x040024A2 RID: 9378
	private static IntPtr _ClassPtr;

	// Token: 0x040024A3 RID: 9379
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040024A4 RID: 9380
	private static int __PropertyOffset_Pos;

	// Token: 0x040024A5 RID: 9381
	private static int __PropertyOffset_Offset;

	// Token: 0x040024A6 RID: 9382
	private static int __PropertyOffset_Scale;

	// Token: 0x040024A7 RID: 9383
	private static int __PropertyOffset_EffectDA;

	// Token: 0x040024A8 RID: 9384
	[Nullable(2)]
	private FSoftObjectPath _EffectDA;
}
