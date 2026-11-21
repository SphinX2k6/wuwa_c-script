using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000338 RID: 824
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscBulletData.KscBulletData_C")]
public class KscBulletData : KscBpDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170006C7 RID: 1735
	// (get) Token: 0x06002E54 RID: 11860 RVA: 0x0011068C File Offset: 0x0010E88C
	// (set) Token: 0x06002E55 RID: 11861 RVA: 0x0011069C File Offset: 0x0010E89C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int BulletConfigId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)KscBulletData.__PropertyOffset_BulletConfigId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)KscBulletData.__PropertyOffset_BulletConfigId) = value;
		}
	}

	// Token: 0x170006C8 RID: 1736
	// (get) Token: 0x06002E56 RID: 11862 RVA: 0x001106AD File Offset: 0x0010E8AD
	// (set) Token: 0x06002E57 RID: 11863 RVA: 0x001106C1 File Offset: 0x0010E8C1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string LaunchMeshComponentName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)KscBulletData.__PropertyOffset_LaunchMeshComponentName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)KscBulletData.__PropertyOffset_LaunchMeshComponentName)), value);
		}
	}

	// Token: 0x170006C9 RID: 1737
	// (get) Token: 0x06002E58 RID: 11864 RVA: 0x001106D6 File Offset: 0x0010E8D6
	// (set) Token: 0x06002E59 RID: 11865 RVA: 0x001106EA File Offset: 0x0010E8EA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string LaunchBoneOrSocketName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)KscBulletData.__PropertyOffset_LaunchBoneOrSocketName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)KscBulletData.__PropertyOffset_LaunchBoneOrSocketName)), value);
		}
	}

	// Token: 0x06002E5A RID: 11866 RVA: 0x001106FF File Offset: 0x0010E8FF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (KscBulletData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscBulletData.KscBulletData_C");
		}
		return KscBulletData._ClassPtr;
	}

	// Token: 0x06002E5B RID: 11867 RVA: 0x00110724 File Offset: 0x0010E924
	public KscBulletData() : this(BuiltinUtils.AllocNativeUObject(KscBulletData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002E5C RID: 11868 RVA: 0x0011074C File Offset: 0x0010E94C
	public KscBulletData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscBulletData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002E5D RID: 11869 RVA: 0x0011077F File Offset: 0x0010E97F
	protected KscBulletData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x04002A12 RID: 10770
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscBulletData.KscBulletData_C";

	// Token: 0x04002A13 RID: 10771
	private static IntPtr _ClassPtr;

	// Token: 0x04002A14 RID: 10772
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04002A15 RID: 10773
	private static int __PropertyOffset_BulletConfigId;

	// Token: 0x04002A16 RID: 10774
	private static int __PropertyOffset_LaunchMeshComponentName;

	// Token: 0x04002A17 RID: 10775
	private static int __PropertyOffset_LaunchBoneOrSocketName;
}
