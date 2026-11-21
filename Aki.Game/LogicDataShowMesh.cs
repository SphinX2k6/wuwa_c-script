using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200235B RID: 9051
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShowMesh.LogicDataShowMesh_C")]
public class LogicDataShowMesh : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002286 RID: 8838
	// (get) Token: 0x060164D2 RID: 91346 RVA: 0x0067F6B8 File Offset: 0x0067D8B8
	// (set) Token: 0x060164D3 RID: 91347 RVA: 0x0067F6F1 File Offset: 0x0067D8F1
	[UProperty(EPropertyFlags.CPF_None)]
	public FSoftObjectPath MaterialEffect
	{
		get
		{
			base.FastCheckIsValid();
			FSoftObjectPath result;
			if ((result = this._MaterialEffect) == null)
			{
				result = (this._MaterialEffect = new FSoftObjectPath(base.NativePtr + (IntPtr)LogicDataShowMesh.__PropertyOffset_MaterialEffect, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)LogicDataShowMesh.__PropertyOffset_MaterialEffect, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x060164D4 RID: 91348 RVA: 0x0067F719 File Offset: 0x0067D919
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataShowMesh._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShowMesh.LogicDataShowMesh_C");
		}
		return LogicDataShowMesh._ClassPtr;
	}

	// Token: 0x060164D5 RID: 91349 RVA: 0x0067F740 File Offset: 0x0067D940
	public LogicDataShowMesh() : this(BuiltinUtils.AllocNativeUObject(LogicDataShowMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060164D6 RID: 91350 RVA: 0x0067F768 File Offset: 0x0067D968
	public LogicDataShowMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShowMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060164D7 RID: 91351 RVA: 0x0067F79B File Offset: 0x0067D99B
	protected LogicDataShowMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC55 RID: 48213
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShowMesh.LogicDataShowMesh_C";

	// Token: 0x0400BC56 RID: 48214
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC57 RID: 48215
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC58 RID: 48216
	private static int __PropertyOffset_MaterialEffect;

	// Token: 0x0400BC59 RID: 48217
	[Nullable(2)]
	private FSoftObjectPath _MaterialEffect;
}
