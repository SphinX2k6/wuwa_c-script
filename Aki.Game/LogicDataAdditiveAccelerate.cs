using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200234C RID: 9036
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataAdditiveAccelerate.LogicDataAdditiveAccelerate_C")]
public class LogicDataAdditiveAccelerate : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002228 RID: 8744
	// (get) Token: 0x060163DA RID: 91098 RVA: 0x0067DBF4 File Offset: 0x0067BDF4
	// (set) Token: 0x060163DB RID: 91099 RVA: 0x0067DC08 File Offset: 0x0067BE08
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

	// Token: 0x17002229 RID: 8745
	// (get) Token: 0x060163DC RID: 91100 RVA: 0x0067DC1D File Offset: 0x0067BE1D
	// (set) Token: 0x060163DD RID: 91101 RVA: 0x0067DC31 File Offset: 0x0067BE31
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

	// Token: 0x060163DE RID: 91102 RVA: 0x0067DC46 File Offset: 0x0067BE46
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataAdditiveAccelerate._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataAdditiveAccelerate.LogicDataAdditiveAccelerate_C");
		}
		return LogicDataAdditiveAccelerate._ClassPtr;
	}

	// Token: 0x060163DF RID: 91103 RVA: 0x0067DC6C File Offset: 0x0067BE6C
	public LogicDataAdditiveAccelerate() : this(BuiltinUtils.AllocNativeUObject(LogicDataAdditiveAccelerate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060163E0 RID: 91104 RVA: 0x0067DC94 File Offset: 0x0067BE94
	[NullableContext(1)]
	public LogicDataAdditiveAccelerate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataAdditiveAccelerate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060163E1 RID: 91105 RVA: 0x0067DCC7 File Offset: 0x0067BEC7
	protected LogicDataAdditiveAccelerate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BBAD RID: 48045
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataAdditiveAccelerate.LogicDataAdditiveAccelerate_C";

	// Token: 0x0400BBAE RID: 48046
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBAF RID: 48047
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BBB0 RID: 48048
	private static int __PropertyOffset_Acceleration;

	// Token: 0x0400BBB1 RID: 48049
	private static int __PropertyOffset_AccelerationCurve;
}
