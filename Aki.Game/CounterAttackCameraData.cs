using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000260 RID: 608
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Define/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Define/CounterAttackCameraData.CounterAttackCameraData_C")]
public class CounterAttackCameraData : UKuroBpDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x170005C3 RID: 1475
	// (get) Token: 0x060025E4 RID: 9700 RVA: 0x000E6F94 File Offset: 0x000E5194
	// (set) Token: 0x060025E5 RID: 9701 RVA: 0x000E6FCD File Offset: 0x000E51CD
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

	// Token: 0x170005C4 RID: 1476
	// (get) Token: 0x060025E6 RID: 9702 RVA: 0x000E6FF8 File Offset: 0x000E51F8
	// (set) Token: 0x060025E7 RID: 9703 RVA: 0x000E7031 File Offset: 0x000E5231
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

	// Token: 0x170005C5 RID: 1477
	// (get) Token: 0x060025E8 RID: 9704 RVA: 0x000E705C File Offset: 0x000E525C
	// (set) Token: 0x060025E9 RID: 9705 RVA: 0x000E7095 File Offset: 0x000E5295
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

	// Token: 0x170005C6 RID: 1478
	// (get) Token: 0x060025EA RID: 9706 RVA: 0x000E70BD File Offset: 0x000E52BD
	// (set) Token: 0x060025EB RID: 9707 RVA: 0x000E70D1 File Offset: 0x000E52D1
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

	// Token: 0x060025EC RID: 9708 RVA: 0x000E70E6 File Offset: 0x000E52E6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CounterAttackCameraData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Define/CounterAttackCameraData.CounterAttackCameraData_C");
		}
		return CounterAttackCameraData._ClassPtr;
	}

	// Token: 0x060025ED RID: 9709 RVA: 0x000E710C File Offset: 0x000E530C
	public CounterAttackCameraData() : this(BuiltinUtils.AllocNativeUObject(CounterAttackCameraData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060025EE RID: 9710 RVA: 0x000E7134 File Offset: 0x000E5334
	public CounterAttackCameraData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CounterAttackCameraData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060025EF RID: 9711 RVA: 0x000E7167 File Offset: 0x000E5367
	protected CounterAttackCameraData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x04002497 RID: 9367
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Define/CounterAttackCameraData.CounterAttackCameraData_C";

	// Token: 0x04002498 RID: 9368
	private static IntPtr _ClassPtr;

	// Token: 0x04002499 RID: 9369
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400249A RID: 9370
	private static int __PropertyOffset_CameraData;

	// Token: 0x0400249B RID: 9371
	[Nullable(2)]
	private SCounterAttackCamera _CameraData;

	// Token: 0x0400249C RID: 9372
	private static int __PropertyOffset_AttackerTimeScale;

	// Token: 0x0400249D RID: 9373
	[Nullable(2)]
	private STimeScale _AttackerTimeScale;

	// Token: 0x0400249E RID: 9374
	private static int __PropertyOffset_VictimTimeScale;

	// Token: 0x0400249F RID: 9375
	[Nullable(2)]
	private STimeScale _VictimTimeScale;

	// Token: 0x040024A0 RID: 9376
	private static int __PropertyOffset_CameraShake;
}
