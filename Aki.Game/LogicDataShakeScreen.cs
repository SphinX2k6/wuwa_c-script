using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002359 RID: 9049
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShakeScreen.LogicDataShakeScreen_C")]
public class LogicDataShakeScreen : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002270 RID: 8816
	// (get) Token: 0x0601649E RID: 91294 RVA: 0x0067F178 File Offset: 0x0067D378
	// (set) Token: 0x0601649F RID: 91295 RVA: 0x0067F188 File Offset: 0x0067D388
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

	// Token: 0x17002271 RID: 8817
	// (get) Token: 0x060164A0 RID: 91296 RVA: 0x0067F199 File Offset: 0x0067D399
	// (set) Token: 0x060164A1 RID: 91297 RVA: 0x0067F1AD File Offset: 0x0067D3AD
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

	// Token: 0x17002272 RID: 8818
	// (get) Token: 0x060164A2 RID: 91298 RVA: 0x0067F1C2 File Offset: 0x0067D3C2
	// (set) Token: 0x060164A3 RID: 91299 RVA: 0x0067F1D2 File Offset: 0x0067D3D2
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

	// Token: 0x17002273 RID: 8819
	// (get) Token: 0x060164A4 RID: 91300 RVA: 0x0067F1E3 File Offset: 0x0067D3E3
	// (set) Token: 0x060164A5 RID: 91301 RVA: 0x0067F1F3 File Offset: 0x0067D3F3
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

	// Token: 0x17002274 RID: 8820
	// (get) Token: 0x060164A6 RID: 91302 RVA: 0x0067F204 File Offset: 0x0067D404
	// (set) Token: 0x060164A7 RID: 91303 RVA: 0x0067F214 File Offset: 0x0067D414
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

	// Token: 0x17002275 RID: 8821
	// (get) Token: 0x060164A8 RID: 91304 RVA: 0x0067F225 File Offset: 0x0067D425
	// (set) Token: 0x060164A9 RID: 91305 RVA: 0x0067F235 File Offset: 0x0067D435
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

	// Token: 0x17002276 RID: 8822
	// (get) Token: 0x060164AA RID: 91306 RVA: 0x0067F246 File Offset: 0x0067D446
	// (set) Token: 0x060164AB RID: 91307 RVA: 0x0067F256 File Offset: 0x0067D456
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

	// Token: 0x17002277 RID: 8823
	// (get) Token: 0x060164AC RID: 91308 RVA: 0x0067F268 File Offset: 0x0067D468
	// (set) Token: 0x060164AD RID: 91309 RVA: 0x0067F2A1 File Offset: 0x0067D4A1
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

	// Token: 0x060164AE RID: 91310 RVA: 0x0067F2C6 File Offset: 0x0067D4C6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataShakeScreen._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShakeScreen.LogicDataShakeScreen_C");
		}
		return LogicDataShakeScreen._ClassPtr;
	}

	// Token: 0x060164AF RID: 91311 RVA: 0x0067F2EC File Offset: 0x0067D4EC
	public LogicDataShakeScreen() : this(BuiltinUtils.AllocNativeUObject(LogicDataShakeScreen.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060164B0 RID: 91312 RVA: 0x0067F314 File Offset: 0x0067D514
	public LogicDataShakeScreen(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShakeScreen.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060164B1 RID: 91313 RVA: 0x0067F347 File Offset: 0x0067D547
	protected LogicDataShakeScreen(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC31 RID: 48177
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShakeScreen.LogicDataShakeScreen_C";

	// Token: 0x0400BC32 RID: 48178
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC33 RID: 48179
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC34 RID: 48180
	private static int __PropertyOffset_Count;

	// Token: 0x0400BC35 RID: 48181
	private static int __PropertyOffset_Epicenter;

	// Token: 0x0400BC36 RID: 48182
	private static int __PropertyOffset_Falloff;

	// Token: 0x0400BC37 RID: 48183
	private static int __PropertyOffset_InnerRadius;

	// Token: 0x0400BC38 RID: 48184
	private static int __PropertyOffset_Interval;

	// Token: 0x0400BC39 RID: 48185
	private static int __PropertyOffset_OrientShakeTowardsEpicenter;

	// Token: 0x0400BC3A RID: 48186
	private static int __PropertyOffset_OuterRadius;

	// Token: 0x0400BC3B RID: 48187
	private static int __PropertyOffset_Shake;

	// Token: 0x0400BC3C RID: 48188
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftClassPtr<UMatineeCameraShake> _Shake;
}
