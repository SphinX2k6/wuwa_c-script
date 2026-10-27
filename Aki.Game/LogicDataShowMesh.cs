using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E00 RID: 11776
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShowMesh.LogicDataShowMesh_C")]
public class LogicDataShowMesh : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002222 RID: 8738
	// (get) Token: 0x06018C1D RID: 101405 RVA: 0x00659634 File Offset: 0x00657834
	// (set) Token: 0x06018C1E RID: 101406 RVA: 0x0065966D File Offset: 0x0065786D
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

	// Token: 0x06018C1F RID: 101407 RVA: 0x00659695 File Offset: 0x00657895
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataShowMesh._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShowMesh.LogicDataShowMesh_C");
		}
		return LogicDataShowMesh._ClassPtr;
	}

	// Token: 0x06018C20 RID: 101408 RVA: 0x006596BC File Offset: 0x006578BC
	public LogicDataShowMesh() : this(BuiltinUtils.AllocNativeUObject(LogicDataShowMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018C21 RID: 101409 RVA: 0x006596E4 File Offset: 0x006578E4
	public LogicDataShowMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataShowMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018C22 RID: 101410 RVA: 0x00659717 File Offset: 0x00657917
	protected LogicDataShowMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B8CF RID: 47311
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataShowMesh.LogicDataShowMesh_C";

	// Token: 0x0400B8D0 RID: 47312
	private static IntPtr _ClassPtr;

	// Token: 0x0400B8D1 RID: 47313
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B8D2 RID: 47314
	private static int __PropertyOffset_MaterialEffect;

	// Token: 0x0400B8D3 RID: 47315
	[Nullable(2)]
	private FSoftObjectPath _MaterialEffect;
}
