using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DF1 RID: 11761
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataAdditiveAccelerate.LogicDataAdditiveAccelerate_C")]
public class LogicDataAdditiveAccelerate : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170021C4 RID: 8644
	// (get) Token: 0x06018B25 RID: 101157 RVA: 0x00657B70 File Offset: 0x00655D70
	// (set) Token: 0x06018B26 RID: 101158 RVA: 0x00657B84 File Offset: 0x00655D84
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector Acceleration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataAdditiveAccelerate.__PropertyOffset_Acceleration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataAdditiveAccelerate.__PropertyOffset_Acceleration) = value;
		}
	}

	// Token: 0x170021C5 RID: 8645
	// (get) Token: 0x06018B27 RID: 101159 RVA: 0x00657B99 File Offset: 0x00655D99
	// (set) Token: 0x06018B28 RID: 101160 RVA: 0x00657BAD File Offset: 0x00655DAD
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveVector AccelerationCurve
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + LogicDataAdditiveAccelerate.__PropertyOffset_AccelerationCurve);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LogicDataAdditiveAccelerate.__PropertyOffset_AccelerationCurve, value);
		}
	}

	// Token: 0x06018B29 RID: 101161 RVA: 0x00657BC2 File Offset: 0x00655DC2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataAdditiveAccelerate._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataAdditiveAccelerate.LogicDataAdditiveAccelerate_C");
		}
		return LogicDataAdditiveAccelerate._ClassPtr;
	}

	// Token: 0x06018B2A RID: 101162 RVA: 0x00657BE8 File Offset: 0x00655DE8
	public LogicDataAdditiveAccelerate() : this(BuiltinUtils.AllocNativeUObject(LogicDataAdditiveAccelerate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018B2B RID: 101163 RVA: 0x00657C10 File Offset: 0x00655E10
	[NullableContext(1)]
	public LogicDataAdditiveAccelerate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataAdditiveAccelerate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018B2C RID: 101164 RVA: 0x00657C43 File Offset: 0x00655E43
	protected LogicDataAdditiveAccelerate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B827 RID: 47143
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataAdditiveAccelerate.LogicDataAdditiveAccelerate_C";

	// Token: 0x0400B828 RID: 47144
	private static IntPtr _ClassPtr;

	// Token: 0x0400B829 RID: 47145
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B82A RID: 47146
	private static int __PropertyOffset_Acceleration;

	// Token: 0x0400B82B RID: 47147
	private static int __PropertyOffset_AccelerationCurve;
}
