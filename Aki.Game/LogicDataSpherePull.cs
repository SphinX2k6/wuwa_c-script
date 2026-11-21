using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200235E RID: 9054
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpherePull.LogicDataSpherePull_C")]
public class LogicDataSpherePull : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002292 RID: 8850
	// (get) Token: 0x060164F6 RID: 91382 RVA: 0x0067FA38 File Offset: 0x0067DC38
	// (set) Token: 0x060164F7 RID: 91383 RVA: 0x0067FA48 File Offset: 0x0067DC48
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MoveTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSpherePull.__PropertyOffset_MoveTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpherePull.__PropertyOffset_MoveTime) = value;
		}
	}

	// Token: 0x17002293 RID: 8851
	// (get) Token: 0x060164F8 RID: 91384 RVA: 0x0067FA59 File Offset: 0x0067DC59
	// (set) Token: 0x060164F9 RID: 91385 RVA: 0x0067FA69 File Offset: 0x0067DC69
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SphereRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSpherePull.__PropertyOffset_SphereRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpherePull.__PropertyOffset_SphereRadius) = value;
		}
	}

	// Token: 0x17002294 RID: 8852
	// (get) Token: 0x060164FA RID: 91386 RVA: 0x0067FA7A File Offset: 0x0067DC7A
	// (set) Token: 0x060164FB RID: 91387 RVA: 0x0067FA8A File Offset: 0x0067DC8A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float GroundHeightOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSpherePull.__PropertyOffset_GroundHeightOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpherePull.__PropertyOffset_GroundHeightOffset) = value;
		}
	}

	// Token: 0x17002295 RID: 8853
	// (get) Token: 0x060164FC RID: 91388 RVA: 0x0067FA9C File Offset: 0x0067DC9C
	// (set) Token: 0x060164FD RID: 91389 RVA: 0x0067FAD5 File Offset: 0x0067DCD5
	[UProperty(EPropertyFlags.CPF_None)]
	public SBaseCurve VelocityCurve
	{
		get
		{
			base.FastCheckIsValid();
			SBaseCurve result;
			if ((result = this._VelocityCurve) == null)
			{
				result = (this._VelocityCurve = new SBaseCurve(base.NativePtr + (IntPtr)LogicDataSpherePull.__PropertyOffset_VelocityCurve, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)LogicDataSpherePull.__PropertyOffset_VelocityCurve, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x060164FE RID: 91390 RVA: 0x0067FAFD File Offset: 0x0067DCFD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSpherePull._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpherePull.LogicDataSpherePull_C");
		}
		return LogicDataSpherePull._ClassPtr;
	}

	// Token: 0x060164FF RID: 91391 RVA: 0x0067FB24 File Offset: 0x0067DD24
	public LogicDataSpherePull() : this(BuiltinUtils.AllocNativeUObject(LogicDataSpherePull.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016500 RID: 91392 RVA: 0x0067FB4C File Offset: 0x0067DD4C
	public LogicDataSpherePull(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpherePull.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016501 RID: 91393 RVA: 0x0067FB7F File Offset: 0x0067DD7F
	protected LogicDataSpherePull(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC6B RID: 48235
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpherePull.LogicDataSpherePull_C";

	// Token: 0x0400BC6C RID: 48236
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC6D RID: 48237
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC6E RID: 48238
	private static int __PropertyOffset_MoveTime;

	// Token: 0x0400BC6F RID: 48239
	private static int __PropertyOffset_SphereRadius;

	// Token: 0x0400BC70 RID: 48240
	private static int __PropertyOffset_GroundHeightOffset;

	// Token: 0x0400BC71 RID: 48241
	private static int __PropertyOffset_VelocityCurve;

	// Token: 0x0400BC72 RID: 48242
	[Nullable(2)]
	private SBaseCurve _VelocityCurve;
}
