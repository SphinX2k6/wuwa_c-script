using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002363 RID: 9059
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataWhirlpool.LogicDataWhirlpool_C")]
public class LogicDataWhirlpool : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170022AF RID: 8879
	// (get) Token: 0x06016544 RID: 91460 RVA: 0x006801BC File Offset: 0x0067E3BC
	// (set) Token: 0x06016545 RID: 91461 RVA: 0x006801CC File Offset: 0x0067E3CC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MoveTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_MoveTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_MoveTime) = value;
		}
	}

	// Token: 0x170022B0 RID: 8880
	// (get) Token: 0x06016546 RID: 91462 RVA: 0x006801DD File Offset: 0x0067E3DD
	// (set) Token: 0x06016547 RID: 91463 RVA: 0x006801ED File Offset: 0x0067E3ED
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float WeightLimit
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_WeightLimit);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_WeightLimit) = value;
		}
	}

	// Token: 0x170022B1 RID: 8881
	// (get) Token: 0x06016548 RID: 91464 RVA: 0x006801FE File Offset: 0x0067E3FE
	// (set) Token: 0x06016549 RID: 91465 RVA: 0x00680212 File Offset: 0x0067E412
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<AkiClient.Game.Aki.Character.BaseCharacter.EVelocityCurveType> VelocityCurve
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_VelocityCurve);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_VelocityCurve) = value;
		}
	}

	// Token: 0x170022B2 RID: 8882
	// (get) Token: 0x0601654A RID: 91466 RVA: 0x00680227 File Offset: 0x0067E427
	// (set) Token: 0x0601654B RID: 91467 RVA: 0x0068023B File Offset: 0x0067E43B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag TagNeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_TagNeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_TagNeed) = value;
		}
	}

	// Token: 0x170022B3 RID: 8883
	// (get) Token: 0x0601654C RID: 91468 RVA: 0x00680250 File Offset: 0x0067E450
	// (set) Token: 0x0601654D RID: 91469 RVA: 0x00680264 File Offset: 0x0067E464
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName AttackerSocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_AttackerSocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_AttackerSocketName) = value;
		}
	}

	// Token: 0x170022B4 RID: 8884
	// (get) Token: 0x0601654E RID: 91470 RVA: 0x00680279 File Offset: 0x0067E479
	// (set) Token: 0x0601654F RID: 91471 RVA: 0x00680289 File Offset: 0x0067E489
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CancelByHit
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_CancelByHit) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataWhirlpool.__PropertyOffset_CancelByHit) = (value ? 1 : 0);
		}
	}

	// Token: 0x06016550 RID: 91472 RVA: 0x0068029A File Offset: 0x0067E49A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataWhirlpool._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataWhirlpool.LogicDataWhirlpool_C");
		}
		return LogicDataWhirlpool._ClassPtr;
	}

	// Token: 0x06016551 RID: 91473 RVA: 0x006802C0 File Offset: 0x0067E4C0
	public LogicDataWhirlpool() : this(BuiltinUtils.AllocNativeUObject(LogicDataWhirlpool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016552 RID: 91474 RVA: 0x006802E8 File Offset: 0x0067E4E8
	[NullableContext(1)]
	public LogicDataWhirlpool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataWhirlpool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016553 RID: 91475 RVA: 0x0068031B File Offset: 0x0067E51B
	protected LogicDataWhirlpool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC9B RID: 48283
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataWhirlpool.LogicDataWhirlpool_C";

	// Token: 0x0400BC9C RID: 48284
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC9D RID: 48285
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC9E RID: 48286
	private static int __PropertyOffset_MoveTime;

	// Token: 0x0400BC9F RID: 48287
	private static int __PropertyOffset_WeightLimit;

	// Token: 0x0400BCA0 RID: 48288
	private static int __PropertyOffset_VelocityCurve;

	// Token: 0x0400BCA1 RID: 48289
	private static int __PropertyOffset_TagNeed;

	// Token: 0x0400BCA2 RID: 48290
	private static int __PropertyOffset_AttackerSocketName;

	// Token: 0x0400BCA3 RID: 48291
	private static int __PropertyOffset_CancelByHit;
}
