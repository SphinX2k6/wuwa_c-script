using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.PathLine.PathLine_Bullet;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E03 RID: 11779
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSplineMovement.LogicDataSplineMovement_C")]
public class LogicDataSplineMovement : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700222E RID: 8750
	// (get) Token: 0x06018C41 RID: 101441 RVA: 0x006599B4 File Offset: 0x00657BB4
	// (set) Token: 0x06018C42 RID: 101442 RVA: 0x006599C4 File Offset: 0x00657BC4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Duration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Duration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Duration) = value;
		}
	}

	// Token: 0x1700222F RID: 8751
	// (get) Token: 0x06018C43 RID: 101443 RVA: 0x006599D8 File Offset: 0x00657BD8
	// (set) Token: 0x06018C44 RID: 101444 RVA: 0x00659A11 File Offset: 0x00657C11
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> EffectOnReach
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._EffectOnReach) == null)
			{
				result = (this._EffectOnReach = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_EffectOnReach, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_EffectOnReach, 1);
		}
	}

	// Token: 0x17002230 RID: 8752
	// (get) Token: 0x06018C45 RID: 101445 RVA: 0x00659A36 File Offset: 0x00657C36
	// (set) Token: 0x06018C46 RID: 101446 RVA: 0x00659A46 File Offset: 0x00657C46
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsDestroyReach
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_IsDestroyReach) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_IsDestroyReach) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002231 RID: 8753
	// (get) Token: 0x06018C47 RID: 101447 RVA: 0x00659A57 File Offset: 0x00657C57
	// (set) Token: 0x06018C48 RID: 101448 RVA: 0x00659A67 File Offset: 0x00657C67
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsForwardTangent
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_IsForwardTangent) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_IsForwardTangent) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002232 RID: 8754
	// (get) Token: 0x06018C49 RID: 101449 RVA: 0x00659A78 File Offset: 0x00657C78
	// (set) Token: 0x06018C4A RID: 101450 RVA: 0x00659A88 File Offset: 0x00657C88
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsSummonOnReach
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_IsSummonOnReach) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_IsSummonOnReach) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002233 RID: 8755
	// (get) Token: 0x06018C4B RID: 101451 RVA: 0x00659A99 File Offset: 0x00657C99
	// (set) Token: 0x06018C4C RID: 101452 RVA: 0x00659AA9 File Offset: 0x00657CA9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Rotate
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Rotate);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Rotate) = value;
		}
	}

	// Token: 0x17002234 RID: 8756
	// (get) Token: 0x06018C4D RID: 101453 RVA: 0x00659ABA File Offset: 0x00657CBA
	// (set) Token: 0x06018C4E RID: 101454 RVA: 0x00659ACA File Offset: 0x00657CCA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Length
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Length);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Length) = value;
		}
	}

	// Token: 0x17002235 RID: 8757
	// (get) Token: 0x06018C4F RID: 101455 RVA: 0x00659ADB File Offset: 0x00657CDB
	// (set) Token: 0x06018C50 RID: 101456 RVA: 0x00659AEB File Offset: 0x00657CEB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Height
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Height);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_Height) = value;
		}
	}

	// Token: 0x17002236 RID: 8758
	// (get) Token: 0x06018C51 RID: 101457 RVA: 0x00659AFC File Offset: 0x00657CFC
	// (set) Token: 0x06018C52 RID: 101458 RVA: 0x00659B0C File Offset: 0x00657D0C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_MaxSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_MaxSpeed) = value;
		}
	}

	// Token: 0x17002237 RID: 8759
	// (get) Token: 0x06018C53 RID: 101459 RVA: 0x00659B1D File Offset: 0x00657D1D
	// (set) Token: 0x06018C54 RID: 101460 RVA: 0x00659B2D File Offset: 0x00657D2D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_MinSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_MinSpeed) = value;
		}
	}

	// Token: 0x17002238 RID: 8760
	// (get) Token: 0x06018C55 RID: 101461 RVA: 0x00659B3E File Offset: 0x00657D3E
	// (set) Token: 0x06018C56 RID: 101462 RVA: 0x00659B4E File Offset: 0x00657D4E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SelfHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SelfHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SelfHeight) = value;
		}
	}

	// Token: 0x17002239 RID: 8761
	// (get) Token: 0x06018C57 RID: 101463 RVA: 0x00659B5F File Offset: 0x00657D5F
	// (set) Token: 0x06018C58 RID: 101464 RVA: 0x00659B6F File Offset: 0x00657D6F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SelfLength
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SelfLength);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SelfLength) = value;
		}
	}

	// Token: 0x1700223A RID: 8762
	// (get) Token: 0x06018C59 RID: 101465 RVA: 0x00659B80 File Offset: 0x00657D80
	// (set) Token: 0x06018C5A RID: 101466 RVA: 0x00659B90 File Offset: 0x00657D90
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SelfRotate
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SelfRotate);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SelfRotate) = value;
		}
	}

	// Token: 0x1700223B RID: 8763
	// (get) Token: 0x06018C5B RID: 101467 RVA: 0x00659BA4 File Offset: 0x00657DA4
	// (set) Token: 0x06018C5C RID: 101468 RVA: 0x00659BDD File Offset: 0x00657DDD
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftClassPtr<BP_BasePathLineBullet_C> SplineTrace
	{
		get
		{
			base.FastCheckIsValid();
			TSoftClassPtr<BP_BasePathLineBullet_C> result;
			if ((result = this._SplineTrace) == null)
			{
				result = (this._SplineTrace = new TSoftClassPtr<BP_BasePathLineBullet_C>(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SplineTrace, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_SplineTrace, 1);
		}
	}

	// Token: 0x1700223C RID: 8764
	// (get) Token: 0x06018C5D RID: 101469 RVA: 0x00659C02 File Offset: 0x00657E02
	// (set) Token: 0x06018C5E RID: 101470 RVA: 0x00659C12 File Offset: 0x00657E12
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseTargetLocation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_UseTargetLocation) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSplineMovement.__PropertyOffset_UseTargetLocation) = (value ? 1 : 0);
		}
	}

	// Token: 0x06018C5F RID: 101471 RVA: 0x00659C23 File Offset: 0x00657E23
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSplineMovement._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSplineMovement.LogicDataSplineMovement_C");
		}
		return LogicDataSplineMovement._ClassPtr;
	}

	// Token: 0x06018C60 RID: 101472 RVA: 0x00659C48 File Offset: 0x00657E48
	public LogicDataSplineMovement() : this(BuiltinUtils.AllocNativeUObject(LogicDataSplineMovement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018C61 RID: 101473 RVA: 0x00659C70 File Offset: 0x00657E70
	public LogicDataSplineMovement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSplineMovement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018C62 RID: 101474 RVA: 0x00659CA3 File Offset: 0x00657EA3
	protected LogicDataSplineMovement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B8E5 RID: 47333
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSplineMovement.LogicDataSplineMovement_C";

	// Token: 0x0400B8E6 RID: 47334
	private static IntPtr _ClassPtr;

	// Token: 0x0400B8E7 RID: 47335
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B8E8 RID: 47336
	private static int __PropertyOffset_Duration;

	// Token: 0x0400B8E9 RID: 47337
	private static int __PropertyOffset_EffectOnReach;

	// Token: 0x0400B8EA RID: 47338
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _EffectOnReach;

	// Token: 0x0400B8EB RID: 47339
	private static int __PropertyOffset_IsDestroyReach;

	// Token: 0x0400B8EC RID: 47340
	private static int __PropertyOffset_IsForwardTangent;

	// Token: 0x0400B8ED RID: 47341
	private static int __PropertyOffset_IsSummonOnReach;

	// Token: 0x0400B8EE RID: 47342
	private static int __PropertyOffset_Rotate;

	// Token: 0x0400B8EF RID: 47343
	private static int __PropertyOffset_Length;

	// Token: 0x0400B8F0 RID: 47344
	private static int __PropertyOffset_Height;

	// Token: 0x0400B8F1 RID: 47345
	private static int __PropertyOffset_MaxSpeed;

	// Token: 0x0400B8F2 RID: 47346
	private static int __PropertyOffset_MinSpeed;

	// Token: 0x0400B8F3 RID: 47347
	private static int __PropertyOffset_SelfHeight;

	// Token: 0x0400B8F4 RID: 47348
	private static int __PropertyOffset_SelfLength;

	// Token: 0x0400B8F5 RID: 47349
	private static int __PropertyOffset_SelfRotate;

	// Token: 0x0400B8F6 RID: 47350
	private static int __PropertyOffset_SplineTrace;

	// Token: 0x0400B8F7 RID: 47351
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftClassPtr<BP_BasePathLineBullet_C> _SplineTrace;

	// Token: 0x0400B8F8 RID: 47352
	private static int __PropertyOffset_UseTargetLocation;
}
