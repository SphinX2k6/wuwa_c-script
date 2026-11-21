using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002353 RID: 9043
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataEffectSave.LogicDataEffectSave_C")]
public class LogicDataEffectSave : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700224A RID: 8778
	// (get) Token: 0x0601643A RID: 91194 RVA: 0x0067E5E8 File Offset: 0x0067C7E8
	// (set) Token: 0x0601643B RID: 91195 RVA: 0x0067E621 File Offset: 0x0067C821
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

	// Token: 0x0601643C RID: 91196 RVA: 0x0067E646 File Offset: 0x0067C846
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataEffectSave._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataEffectSave.LogicDataEffectSave_C");
		}
		return LogicDataEffectSave._ClassPtr;
	}

	// Token: 0x0601643D RID: 91197 RVA: 0x0067E66C File Offset: 0x0067C86C
	public LogicDataEffectSave() : this(BuiltinUtils.AllocNativeUObject(LogicDataEffectSave.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601643E RID: 91198 RVA: 0x0067E694 File Offset: 0x0067C894
	public LogicDataEffectSave(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataEffectSave.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601643F RID: 91199 RVA: 0x0067E6C7 File Offset: 0x0067C8C7
	protected LogicDataEffectSave(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BBEB RID: 48107
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataEffectSave.LogicDataEffectSave_C";

	// Token: 0x0400BBEC RID: 48108
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBED RID: 48109
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BBEE RID: 48110
	private static int __PropertyOffset_Effect;

	// Token: 0x0400BBEF RID: 48111
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _Effect;
}
