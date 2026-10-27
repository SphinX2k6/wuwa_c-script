using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DFE RID: 11774
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShakeScreen.LogicDataShakeScreen_C")]
public class LogicDataShakeScreen : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700220C RID: 8716
	// (get) Token: 0x06018BE9 RID: 101353 RVA: 0x006590F4 File Offset: 0x006572F4
	// (set) Token: 0x06018BEA RID: 101354 RVA: 0x00659104 File Offset: 0x00657304
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Count
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_Count);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_Count) = value;
		}
	}

	// Token: 0x1700220D RID: 8717
	// (get) Token: 0x06018BEB RID: 101355 RVA: 0x00659115 File Offset: 0x00657315
	// (set) Token: 0x06018BEC RID: 101356 RVA: 0x00659129 File Offset: 0x00657329
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string Epicenter
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataShakeScreen.__PropertyOffset_Epicenter)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataShakeScreen.__PropertyOffset_Epicenter)), value);
		}
	}

	// Token: 0x1700220E RID: 8718
	// (get) Token: 0x06018BED RID: 101357 RVA: 0x0065913E File Offset: 0x0065733E
	// (set) Token: 0x06018BEE RID: 101358 RVA: 0x0065914E File Offset: 0x0065734E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Falloff
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_Falloff);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_Falloff) = value;
		}
	}

	// Token: 0x1700220F RID: 8719
	// (get) Token: 0x06018BEF RID: 101359 RVA: 0x0065915F File Offset: 0x0065735F
	// (set) Token: 0x06018BF0 RID: 101360 RVA: 0x0065916F File Offset: 0x0065736F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float InnerRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_InnerRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_InnerRadius) = value;
		}
	}

	// Token: 0x17002210 RID: 8720
	// (get) Token: 0x06018BF1 RID: 101361 RVA: 0x00659180 File Offset: 0x00657380
	// (set) Token: 0x06018BF2 RID: 101362 RVA: 0x00659190 File Offset: 0x00657390
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Interval
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_Interval);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_Interval) = value;
		}
	}

	// Token: 0x17002211 RID: 8721
	// (get) Token: 0x06018BF3 RID: 101363 RVA: 0x006591A1 File Offset: 0x006573A1
	// (set) Token: 0x06018BF4 RID: 101364 RVA: 0x006591B1 File Offset: 0x006573B1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OrientShakeTowardsEpicenter
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_OrientShakeTowardsEpicenter) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_OrientShakeTowardsEpicenter) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002212 RID: 8722
	// (get) Token: 0x06018BF5 RID: 101365 RVA: 0x006591C2 File Offset: 0x006573C2
	// (set) Token: 0x06018BF6 RID: 101366 RVA: 0x006591D2 File Offset: 0x006573D2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float OuterRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_OuterRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_OuterRadius) = value;
		}
	}

	// Token: 0x17002213 RID: 8723
	// (get) Token: 0x06018BF7 RID: 101367 RVA: 0x006591E4 File Offset: 0x006573E4
	// (set) Token: 0x06018BF8 RID: 101368 RVA: 0x0065921D File Offset: 0x0065741D
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftClassPtr<UMatineeCameraShake> Shake
	{
		get
		{
			base.FastCheckIsValid();
			TSoftClassPtr<UMatineeCameraShake> result;
			if ((result = this._Shake) == null)
			{
				result = (this._Shake = new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_Shake, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)LogicDataShakeScreen.__PropertyOffset_Shake, 1);
		}
	}

	// Token: 0x06018BF9 RID: 101369 RVA: 0x00659242 File Offset: 0x00657442
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataShakeScreen._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShakeScreen.LogicDataShakeScreen_C");
		}
		return LogicDataShakeScreen._ClassPtr;
	}

	// Token: 0x06018BFA RID: 101370 RVA: 0x00659268 File Offset: 0x00657468
	public LogicDataShakeScreen() : this(BuiltinUtils.AllocNativeUObject(LogicDataShakeScreen.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018BFB RID: 101371 RVA: 0x00659290 File Offset: 0x00657490
	public LogicDataShakeScreen(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShakeScreen.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018BFC RID: 101372 RVA: 0x006592C3 File Offset: 0x006574C3
	protected LogicDataShakeScreen(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B8AB RID: 47275
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShakeScreen.LogicDataShakeScreen_C";

	// Token: 0x0400B8AC RID: 47276
	private static IntPtr _ClassPtr;

	// Token: 0x0400B8AD RID: 47277
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B8AE RID: 47278
	private static int __PropertyOffset_Count;

	// Token: 0x0400B8AF RID: 47279
	private static int __PropertyOffset_Epicenter;

	// Token: 0x0400B8B0 RID: 47280
	private static int __PropertyOffset_Falloff;

	// Token: 0x0400B8B1 RID: 47281
	private static int __PropertyOffset_InnerRadius;

	// Token: 0x0400B8B2 RID: 47282
	private static int __PropertyOffset_Interval;

	// Token: 0x0400B8B3 RID: 47283
	private static int __PropertyOffset_OrientShakeTowardsEpicenter;

	// Token: 0x0400B8B4 RID: 47284
	private static int __PropertyOffset_OuterRadius;

	// Token: 0x0400B8B5 RID: 47285
	private static int __PropertyOffset_Shake;

	// Token: 0x0400B8B6 RID: 47286
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftClassPtr<UMatineeCameraShake> _Shake;
}
