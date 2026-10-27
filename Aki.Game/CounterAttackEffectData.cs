using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200025D RID: 605
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Define/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Define/CounterAttackEffectData.CounterAttackEffectData_C")]
public class CounterAttackEffectData : UKuroBpDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x170005A0 RID: 1440
	// (get) Token: 0x06002539 RID: 9529 RVA: 0x000E0DD4 File Offset: 0x000DEFD4
	// (set) Token: 0x0600253A RID: 9530 RVA: 0x000E0DE4 File Offset: 0x000DEFE4
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

	// Token: 0x170005A1 RID: 1441
	// (get) Token: 0x0600253B RID: 9531 RVA: 0x000E0DF5 File Offset: 0x000DEFF5
	// (set) Token: 0x0600253C RID: 9532 RVA: 0x000E0E09 File Offset: 0x000DF009
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

	// Token: 0x170005A2 RID: 1442
	// (get) Token: 0x0600253D RID: 9533 RVA: 0x000E0E1E File Offset: 0x000DF01E
	// (set) Token: 0x0600253E RID: 9534 RVA: 0x000E0E32 File Offset: 0x000DF032
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

	// Token: 0x170005A3 RID: 1443
	// (get) Token: 0x0600253F RID: 9535 RVA: 0x000E0E48 File Offset: 0x000DF048
	// (set) Token: 0x06002540 RID: 9536 RVA: 0x000E0E81 File Offset: 0x000DF081
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

	// Token: 0x06002541 RID: 9537 RVA: 0x000E0EA9 File Offset: 0x000DF0A9
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CounterAttackEffectData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Define/CounterAttackEffectData.CounterAttackEffectData_C");
		}
		return CounterAttackEffectData._ClassPtr;
	}

	// Token: 0x06002542 RID: 9538 RVA: 0x000E0ED0 File Offset: 0x000DF0D0
	public CounterAttackEffectData() : this(BuiltinUtils.AllocNativeUObject(CounterAttackEffectData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002543 RID: 9539 RVA: 0x000E0EF8 File Offset: 0x000DF0F8
	public CounterAttackEffectData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CounterAttackEffectData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002544 RID: 9540 RVA: 0x000E0F2B File Offset: 0x000DF12B
	protected CounterAttackEffectData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x04002423 RID: 9251
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Define/CounterAttackEffectData.CounterAttackEffectData_C";

	// Token: 0x04002424 RID: 9252
	private static IntPtr _ClassPtr;

	// Token: 0x04002425 RID: 9253
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04002426 RID: 9254
	private static int __PropertyOffset_Pos;

	// Token: 0x04002427 RID: 9255
	private static int __PropertyOffset_Offset;

	// Token: 0x04002428 RID: 9256
	private static int __PropertyOffset_Scale;

	// Token: 0x04002429 RID: 9257
	private static int __PropertyOffset_EffectDA;

	// Token: 0x0400242A RID: 9258
	[Nullable(2)]
	private FSoftObjectPath _EffectDA;
}
