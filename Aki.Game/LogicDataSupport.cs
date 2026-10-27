using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E06 RID: 11782
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSupport.LogicDataSupport_C")]
public class LogicDataSupport : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002244 RID: 8772
	// (get) Token: 0x06018C79 RID: 101497 RVA: 0x00659EB4 File Offset: 0x006580B4
	// (set) Token: 0x06018C7A RID: 101498 RVA: 0x00659EC8 File Offset: 0x006580C8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataSupport.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSupport.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x17002245 RID: 8773
	// (get) Token: 0x06018C7B RID: 101499 RVA: 0x00659EDD File Offset: 0x006580DD
	// (set) Token: 0x06018C7C RID: 101500 RVA: 0x00659EED File Offset: 0x006580ED
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECamp Camp
	{
		get
		{
			return (ECamp)(*(base.NativePtr + (IntPtr)LogicDataSupport.__PropertyOffset_Camp));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataSupport.__PropertyOffset_Camp) = (byte)value;
		}
	}

	// Token: 0x17002246 RID: 8774
	// (get) Token: 0x06018C7D RID: 101501 RVA: 0x00659F00 File Offset: 0x00658100
	// (set) Token: 0x06018C7E RID: 101502 RVA: 0x00659F39 File Offset: 0x00658139
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> Effect
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._Effect) == null)
			{
				result = (this._Effect = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)LogicDataSupport.__PropertyOffset_Effect, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)LogicDataSupport.__PropertyOffset_Effect, 1);
		}
	}

	// Token: 0x06018C7F RID: 101503 RVA: 0x00659F5E File Offset: 0x0065815E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSupport._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSupport.LogicDataSupport_C");
		}
		return LogicDataSupport._ClassPtr;
	}

	// Token: 0x06018C80 RID: 101504 RVA: 0x00659F84 File Offset: 0x00658184
	public LogicDataSupport() : this(BuiltinUtils.AllocNativeUObject(LogicDataSupport.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018C81 RID: 101505 RVA: 0x00659FAC File Offset: 0x006581AC
	public LogicDataSupport(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSupport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018C82 RID: 101506 RVA: 0x00659FDF File Offset: 0x006581DF
	protected LogicDataSupport(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B906 RID: 47366
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSupport.LogicDataSupport_C";

	// Token: 0x0400B907 RID: 47367
	private static IntPtr _ClassPtr;

	// Token: 0x0400B908 RID: 47368
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B909 RID: 47369
	private static int __PropertyOffset_Tag;

	// Token: 0x0400B90A RID: 47370
	private static int __PropertyOffset_Camp;

	// Token: 0x0400B90B RID: 47371
	private static int __PropertyOffset_Effect;

	// Token: 0x0400B90C RID: 47372
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _Effect;
}
