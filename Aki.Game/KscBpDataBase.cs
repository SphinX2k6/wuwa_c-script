using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000E82 RID: 3714
[UClass("/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscBpDataBase.KscBpDataBase_C")]
public class KscBpDataBase : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
{
	// Token: 0x06005AB9 RID: 23225 RVA: 0x00108954 File Offset: 0x00106B54
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (KscBpDataBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscBpDataBase.KscBpDataBase_C");
		}
		return KscBpDataBase._ClassPtr;
	}

	// Token: 0x06005ABA RID: 23226 RVA: 0x00108978 File Offset: 0x00106B78
	public KscBpDataBase() : this(BuiltinUtils.AllocNativeUObject(KscBpDataBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06005ABB RID: 23227 RVA: 0x001089A0 File Offset: 0x00106BA0
	[NullableContext(1)]
	public KscBpDataBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KscBpDataBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06005ABC RID: 23228 RVA: 0x001089D3 File Offset: 0x00106BD3
	protected KscBpDataBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x04002974 RID: 10612
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/KuroSimpleCombat/KSCDataClass/KscBpDataBase.KscBpDataBase_C";

	// Token: 0x04002975 RID: 10613
	private static IntPtr _ClassPtr;

	// Token: 0x04002976 RID: 10614
	private static IntPtr _ClassDefaultObjectPtr;
}
