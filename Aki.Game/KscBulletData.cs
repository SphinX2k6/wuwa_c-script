using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000E83 RID: 3715
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscBulletData.KscBulletData_C")]
public class KscBulletData : KscBpDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170006A3 RID: 1699
	// (get) Token: 0x06005ABD RID: 23229 RVA: 0x001089DC File Offset: 0x00106BDC
	// (set) Token: 0x06005ABE RID: 23230 RVA: 0x001089EC File Offset: 0x00106BEC
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

	// Token: 0x170006A4 RID: 1700
	// (get) Token: 0x06005ABF RID: 23231 RVA: 0x001089FD File Offset: 0x00106BFD
	// (set) Token: 0x06005AC0 RID: 23232 RVA: 0x00108A11 File Offset: 0x00106C11
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

	// Token: 0x170006A5 RID: 1701
	// (get) Token: 0x06005AC1 RID: 23233 RVA: 0x00108A26 File Offset: 0x00106C26
	// (set) Token: 0x06005AC2 RID: 23234 RVA: 0x00108A3A File Offset: 0x00106C3A
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

	// Token: 0x06005AC3 RID: 23235 RVA: 0x00108A4F File Offset: 0x00106C4F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (KscBulletData._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscBulletData.KscBulletData_C");
		}
		return KscBulletData._ClassPtr;
	}

	// Token: 0x06005AC4 RID: 23236 RVA: 0x00108A74 File Offset: 0x00106C74
	public KscBulletData() : this(BuiltinUtils.AllocNativeUObject(KscBulletData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06005AC5 RID: 23237 RVA: 0x00108A9C File Offset: 0x00106C9C
	public KscBulletData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscBulletData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06005AC6 RID: 23238 RVA: 0x00108ACF File Offset: 0x00106CCF
	protected KscBulletData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x04002977 RID: 10615
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscBulletData.KscBulletData_C";

	// Token: 0x04002978 RID: 10616
	private static IntPtr _ClassPtr;

	// Token: 0x04002979 RID: 10617
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400297A RID: 10618
	private static int __PropertyOffset_BulletConfigId;

	// Token: 0x0400297B RID: 10619
	private static int __PropertyOffset_LaunchMeshComponentName;

	// Token: 0x0400297C RID: 10620
	private static int __PropertyOffset_LaunchBoneOrSocketName;
}
