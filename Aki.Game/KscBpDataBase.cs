using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000337 RID: 823
[UClass("/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscBpDataBase.KscBpDataBase_C")]
public class KscBpDataBase : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x06002E50 RID: 11856 RVA: 0x00110604 File Offset: 0x0010E804
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (KscBpDataBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscBpDataBase.KscBpDataBase_C");
		}
		return KscBpDataBase._ClassPtr;
	}

	// Token: 0x06002E51 RID: 11857 RVA: 0x00110628 File Offset: 0x0010E828
	public KscBpDataBase() : this(BuiltinUtils.AllocNativeUObject(KscBpDataBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06002E52 RID: 11858 RVA: 0x00110650 File Offset: 0x0010E850
	[NullableContext(1)]
	public KscBpDataBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscBpDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06002E53 RID: 11859 RVA: 0x00110683 File Offset: 0x0010E883
	protected KscBpDataBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x04002A0F RID: 10767
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscBpDataBase.KscBpDataBase_C";

	// Token: 0x04002A10 RID: 10768
	private static IntPtr _ClassPtr;

	// Token: 0x04002A11 RID: 10769
	private static IntPtr _ClassDefaultObjectPtr;
}
