using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DF8 RID: 11768
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataEffectSave.LogicDataEffectSave_C")]
public class LogicDataEffectSave : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170021E6 RID: 8678
	// (get) Token: 0x06018B85 RID: 101253 RVA: 0x00658564 File Offset: 0x00656764
	// (set) Token: 0x06018B86 RID: 101254 RVA: 0x0065859D File Offset: 0x0065679D
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> Effect
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._Effect) == null)
			{
				result = (this._Effect = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)LogicDataEffectSave.__PropertyOffset_Effect, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)LogicDataEffectSave.__PropertyOffset_Effect, 1);
		}
	}

	// Token: 0x06018B87 RID: 101255 RVA: 0x006585C2 File Offset: 0x006567C2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataEffectSave._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataEffectSave.LogicDataEffectSave_C");
		}
		return LogicDataEffectSave._ClassPtr;
	}

	// Token: 0x06018B88 RID: 101256 RVA: 0x006585E8 File Offset: 0x006567E8
	public LogicDataEffectSave() : this(BuiltinUtils.AllocNativeUObject(LogicDataEffectSave.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018B89 RID: 101257 RVA: 0x00658610 File Offset: 0x00656810
	public LogicDataEffectSave(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataEffectSave.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018B8A RID: 101258 RVA: 0x00658643 File Offset: 0x00656843
	protected LogicDataEffectSave(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B865 RID: 47205
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataEffectSave.LogicDataEffectSave_C";

	// Token: 0x0400B866 RID: 47206
	private static IntPtr _ClassPtr;

	// Token: 0x0400B867 RID: 47207
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B868 RID: 47208
	private static int __PropertyOffset_Effect;

	// Token: 0x0400B869 RID: 47209
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _Effect;
}
