using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200025C RID: 604
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Define/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Define/CounterAttackCameraData.CounterAttackCameraData_C")]
public class CounterAttackCameraData : UKuroBpDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700059C RID: 1436
	// (get) Token: 0x0600252D RID: 9517 RVA: 0x000E0BF8 File Offset: 0x000DEDF8
	// (set) Token: 0x0600252E RID: 9518 RVA: 0x000E0C31 File Offset: 0x000DEE31
	[UProperty(EPropertyFlags.CPF_None)]
	public SCounterAttackCamera CameraData
	{
		get
		{
			base.FastCheckIsValid();
			SCounterAttackCamera result;
			if ((result = this._CameraData) == null)
			{
				result = (this._CameraData = new SCounterAttackCamera(base.NativePtr + (IntPtr)CounterAttackCameraData.__PropertyOffset_CameraData, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SCounterAttackCamera.StaticStruct(), base.NativePtr + (IntPtr)CounterAttackCameraData.__PropertyOffset_CameraData, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700059D RID: 1437
	// (get) Token: 0x0600252F RID: 9519 RVA: 0x000E0C5C File Offset: 0x000DEE5C
	// (set) Token: 0x06002530 RID: 9520 RVA: 0x000E0C95 File Offset: 0x000DEE95
	[UProperty(EPropertyFlags.CPF_None)]
	public STimeScale AttackerTimeScale
	{
		get
		{
			base.FastCheckIsValid();
			STimeScale result;
			if ((result = this._AttackerTimeScale) == null)
			{
				result = (this._AttackerTimeScale = new STimeScale(base.NativePtr + (IntPtr)CounterAttackCameraData.__PropertyOffset_AttackerTimeScale, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)CounterAttackCameraData.__PropertyOffset_AttackerTimeScale, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700059E RID: 1438
	// (get) Token: 0x06002531 RID: 9521 RVA: 0x000E0CC0 File Offset: 0x000DEEC0
	// (set) Token: 0x06002532 RID: 9522 RVA: 0x000E0CF9 File Offset: 0x000DEEF9
	[UProperty(EPropertyFlags.CPF_None)]
	public STimeScale VictimTimeScale
	{
		get
		{
			base.FastCheckIsValid();
			STimeScale result;
			if ((result = this._VictimTimeScale) == null)
			{
				result = (this._VictimTimeScale = new STimeScale(base.NativePtr + (IntPtr)CounterAttackCameraData.__PropertyOffset_VictimTimeScale, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(STimeScale.StaticStruct(), base.NativePtr + (IntPtr)CounterAttackCameraData.__PropertyOffset_VictimTimeScale, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x1700059F RID: 1439
	// (get) Token: 0x06002533 RID: 9523 RVA: 0x000E0D21 File Offset: 0x000DEF21
	// (set) Token: 0x06002534 RID: 9524 RVA: 0x000E0D35 File Offset: 0x000DEF35
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TSubclassOf<UCameraShakeBase> CameraShake
	{
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		get
		{
			return *(base.NativePtr + (IntPtr)CounterAttackCameraData.__PropertyOffset_CameraShake);
		}
		[param: Nullable(new byte[]
		{
			0,
			1
		})]
		set
		{
			*(base.NativePtr + (IntPtr)CounterAttackCameraData.__PropertyOffset_CameraShake) = value;
		}
	}

	// Token: 0x06002535 RID: 9525 RVA: 0x000E0D4A File Offset: 0x000DEF4A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CounterAttackCameraData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Define/CounterAttackCameraData.CounterAttackCameraData_C");
		}
		return CounterAttackCameraData._ClassPtr;
	}

	// Token: 0x06002536 RID: 9526 RVA: 0x000E0D70 File Offset: 0x000DEF70
	public CounterAttackCameraData() : this(BuiltinUtils.AllocNativeUObject(CounterAttackCameraData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002537 RID: 9527 RVA: 0x000E0D98 File Offset: 0x000DEF98
	public CounterAttackCameraData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CounterAttackCameraData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002538 RID: 9528 RVA: 0x000E0DCB File Offset: 0x000DEFCB
	protected CounterAttackCameraData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x04002419 RID: 9241
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Define/CounterAttackCameraData.CounterAttackCameraData_C";

	// Token: 0x0400241A RID: 9242
	private static IntPtr _ClassPtr;

	// Token: 0x0400241B RID: 9243
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400241C RID: 9244
	private static int __PropertyOffset_CameraData;

	// Token: 0x0400241D RID: 9245
	[Nullable(2)]
	private SCounterAttackCamera _CameraData;

	// Token: 0x0400241E RID: 9246
	private static int __PropertyOffset_AttackerTimeScale;

	// Token: 0x0400241F RID: 9247
	[Nullable(2)]
	private STimeScale _AttackerTimeScale;

	// Token: 0x04002420 RID: 9248
	private static int __PropertyOffset_VictimTimeScale;

	// Token: 0x04002421 RID: 9249
	[Nullable(2)]
	private STimeScale _VictimTimeScale;

	// Token: 0x04002422 RID: 9250
	private static int __PropertyOffset_CameraShake;
}
