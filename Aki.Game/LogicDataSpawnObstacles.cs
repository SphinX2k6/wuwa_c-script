using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.TypeScript.Game.NewWorld.Bullet.LogicDataClass;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E01 RID: 11777
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpawnObstacles.LogicDataSpawnObstacles_C")]
public class LogicDataSpawnObstacles : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002223 RID: 8739
	// (get) Token: 0x06018C23 RID: 101411 RVA: 0x00659720 File Offset: 0x00657920
	// (set) Token: 0x06018C24 RID: 101412 RVA: 0x00659730 File Offset: 0x00657930
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EBulletLogicObstacles Model
	{
		get
		{
			return (EBulletLogicObstacles)(*(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_Model));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_Model) = (byte)value;
		}
	}

	// Token: 0x17002224 RID: 8740
	// (get) Token: 0x06018C25 RID: 101413 RVA: 0x00659741 File Offset: 0x00657941
	// (set) Token: 0x06018C26 RID: 101414 RVA: 0x00659755 File Offset: 0x00657955
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UStaticMesh Mesh
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + LogicDataSpawnObstacles.__PropertyOffset_Mesh);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + LogicDataSpawnObstacles.__PropertyOffset_Mesh, value);
		}
	}

	// Token: 0x17002225 RID: 8741
	// (get) Token: 0x06018C27 RID: 101415 RVA: 0x0065976A File Offset: 0x0065796A
	// (set) Token: 0x06018C28 RID: 101416 RVA: 0x0065977E File Offset: 0x0065797E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector Size
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_Size);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_Size) = value;
		}
	}

	// Token: 0x17002226 RID: 8742
	// (get) Token: 0x06018C29 RID: 101417 RVA: 0x00659793 File Offset: 0x00657993
	// (set) Token: 0x06018C2A RID: 101418 RVA: 0x006597A7 File Offset: 0x006579A7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName ProfileName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_ProfileName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_ProfileName) = value;
		}
	}

	// Token: 0x17002227 RID: 8743
	// (get) Token: 0x06018C2B RID: 101419 RVA: 0x006597BC File Offset: 0x006579BC
	// (set) Token: 0x06018C2C RID: 101420 RVA: 0x006597CC File Offset: 0x006579CC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ShowModel
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_ShowModel) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_ShowModel) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002228 RID: 8744
	// (get) Token: 0x06018C2D RID: 101421 RVA: 0x006597DD File Offset: 0x006579DD
	// (set) Token: 0x06018C2E RID: 101422 RVA: 0x006597ED File Offset: 0x006579ED
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NeedAttach
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_NeedAttach) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_NeedAttach) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002229 RID: 8745
	// (get) Token: 0x06018C2F RID: 101423 RVA: 0x006597FE File Offset: 0x006579FE
	// (set) Token: 0x06018C30 RID: 101424 RVA: 0x0065980E File Offset: 0x00657A0E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CanStandOn
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_CanStandOn) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_CanStandOn) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700222A RID: 8746
	// (get) Token: 0x06018C31 RID: 101425 RVA: 0x0065981F File Offset: 0x00657A1F
	// (set) Token: 0x06018C32 RID: 101426 RVA: 0x0065982F File Offset: 0x00657A2F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsAirWall
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_IsAirWall) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSpawnObstacles.__PropertyOffset_IsAirWall) = (value ? 1 : 0);
		}
	}

	// Token: 0x06018C33 RID: 101427 RVA: 0x00659840 File Offset: 0x00657A40
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSpawnObstacles._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpawnObstacles.LogicDataSpawnObstacles_C");
		}
		return LogicDataSpawnObstacles._ClassPtr;
	}

	// Token: 0x06018C34 RID: 101428 RVA: 0x00659864 File Offset: 0x00657A64
	public LogicDataSpawnObstacles() : this(BuiltinUtils.AllocNativeUObject(LogicDataSpawnObstacles.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018C35 RID: 101429 RVA: 0x0065988C File Offset: 0x00657A8C
	[NullableContext(1)]
	public LogicDataSpawnObstacles(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpawnObstacles.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018C36 RID: 101430 RVA: 0x006598BF File Offset: 0x00657ABF
	protected LogicDataSpawnObstacles(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B8D4 RID: 47316
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpawnObstacles.LogicDataSpawnObstacles_C";

	// Token: 0x0400B8D5 RID: 47317
	private static IntPtr _ClassPtr;

	// Token: 0x0400B8D6 RID: 47318
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B8D7 RID: 47319
	private static int __PropertyOffset_Model;

	// Token: 0x0400B8D8 RID: 47320
	private static int __PropertyOffset_Mesh;

	// Token: 0x0400B8D9 RID: 47321
	private static int __PropertyOffset_Size;

	// Token: 0x0400B8DA RID: 47322
	private static int __PropertyOffset_ProfileName;

	// Token: 0x0400B8DB RID: 47323
	private static int __PropertyOffset_ShowModel;

	// Token: 0x0400B8DC RID: 47324
	private static int __PropertyOffset_NeedAttach;

	// Token: 0x0400B8DD RID: 47325
	private static int __PropertyOffset_CanStandOn;

	// Token: 0x0400B8DE RID: 47326
	private static int __PropertyOffset_IsAirWall;
}
