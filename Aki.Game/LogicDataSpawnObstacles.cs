using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.TypeScript.Game.NewWorld.Bullet.LogicDataClass;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200235C RID: 9052
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpawnObstacles.LogicDataSpawnObstacles_C")]
public class LogicDataSpawnObstacles : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002287 RID: 8839
	// (get) Token: 0x060164D8 RID: 91352 RVA: 0x0067F7A4 File Offset: 0x0067D9A4
	// (set) Token: 0x060164D9 RID: 91353 RVA: 0x0067F7B4 File Offset: 0x0067D9B4
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

	// Token: 0x17002288 RID: 8840
	// (get) Token: 0x060164DA RID: 91354 RVA: 0x0067F7C5 File Offset: 0x0067D9C5
	// (set) Token: 0x060164DB RID: 91355 RVA: 0x0067F7D9 File Offset: 0x0067D9D9
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

	// Token: 0x17002289 RID: 8841
	// (get) Token: 0x060164DC RID: 91356 RVA: 0x0067F7EE File Offset: 0x0067D9EE
	// (set) Token: 0x060164DD RID: 91357 RVA: 0x0067F802 File Offset: 0x0067DA02
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

	// Token: 0x1700228A RID: 8842
	// (get) Token: 0x060164DE RID: 91358 RVA: 0x0067F817 File Offset: 0x0067DA17
	// (set) Token: 0x060164DF RID: 91359 RVA: 0x0067F82B File Offset: 0x0067DA2B
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

	// Token: 0x1700228B RID: 8843
	// (get) Token: 0x060164E0 RID: 91360 RVA: 0x0067F840 File Offset: 0x0067DA40
	// (set) Token: 0x060164E1 RID: 91361 RVA: 0x0067F850 File Offset: 0x0067DA50
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

	// Token: 0x1700228C RID: 8844
	// (get) Token: 0x060164E2 RID: 91362 RVA: 0x0067F861 File Offset: 0x0067DA61
	// (set) Token: 0x060164E3 RID: 91363 RVA: 0x0067F871 File Offset: 0x0067DA71
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

	// Token: 0x1700228D RID: 8845
	// (get) Token: 0x060164E4 RID: 91364 RVA: 0x0067F882 File Offset: 0x0067DA82
	// (set) Token: 0x060164E5 RID: 91365 RVA: 0x0067F892 File Offset: 0x0067DA92
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

	// Token: 0x1700228E RID: 8846
	// (get) Token: 0x060164E6 RID: 91366 RVA: 0x0067F8A3 File Offset: 0x0067DAA3
	// (set) Token: 0x060164E7 RID: 91367 RVA: 0x0067F8B3 File Offset: 0x0067DAB3
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

	// Token: 0x060164E8 RID: 91368 RVA: 0x0067F8C4 File Offset: 0x0067DAC4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSpawnObstacles._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpawnObstacles.LogicDataSpawnObstacles_C");
		}
		return LogicDataSpawnObstacles._ClassPtr;
	}

	// Token: 0x060164E9 RID: 91369 RVA: 0x0067F8E8 File Offset: 0x0067DAE8
	public LogicDataSpawnObstacles() : this(BuiltinUtils.AllocNativeUObject(LogicDataSpawnObstacles.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060164EA RID: 91370 RVA: 0x0067F910 File Offset: 0x0067DB10
	[NullableContext(1)]
	public LogicDataSpawnObstacles(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSpawnObstacles.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060164EB RID: 91371 RVA: 0x0067F943 File Offset: 0x0067DB43
	protected LogicDataSpawnObstacles(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC5A RID: 48218
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSpawnObstacles.LogicDataSpawnObstacles_C";

	// Token: 0x0400BC5B RID: 48219
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC5C RID: 48220
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC5D RID: 48221
	private static int __PropertyOffset_Model;

	// Token: 0x0400BC5E RID: 48222
	private static int __PropertyOffset_Mesh;

	// Token: 0x0400BC5F RID: 48223
	private static int __PropertyOffset_Size;

	// Token: 0x0400BC60 RID: 48224
	private static int __PropertyOffset_ProfileName;

	// Token: 0x0400BC61 RID: 48225
	private static int __PropertyOffset_ShowModel;

	// Token: 0x0400BC62 RID: 48226
	private static int __PropertyOffset_NeedAttach;

	// Token: 0x0400BC63 RID: 48227
	private static int __PropertyOffset_CanStandOn;

	// Token: 0x0400BC64 RID: 48228
	private static int __PropertyOffset_IsAirWall;
}
