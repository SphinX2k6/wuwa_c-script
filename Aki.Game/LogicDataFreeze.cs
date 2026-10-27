using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DFA RID: 11770
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataFreeze.LogicDataFreeze_C")]
public class LogicDataFreeze : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170021F8 RID: 8696
	// (get) Token: 0x06018BB1 RID: 101297 RVA: 0x00658950 File Offset: 0x00656B50
	// (set) Token: 0x06018BB2 RID: 101298 RVA: 0x00658960 File Offset: 0x00656B60
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EBulletObject Target
	{
		get
		{
			return (EBulletObject)(*(base.NativePtr + (IntPtr)LogicDataFreeze.__PropertyOffset_Target));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataFreeze.__PropertyOffset_Target) = (byte)value;
		}
	}

	// Token: 0x170021F9 RID: 8697
	// (get) Token: 0x06018BB3 RID: 101299 RVA: 0x00658974 File Offset: 0x00656B74
	// (set) Token: 0x06018BB4 RID: 101300 RVA: 0x006589AD File Offset: 0x00656BAD
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer Tags
	{
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._Tags) == null)
			{
				result = (this._Tags = new FGameplayTagContainer(base.NativePtr + (IntPtr)LogicDataFreeze.__PropertyOffset_Tags, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)LogicDataFreeze.__PropertyOffset_Tags, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170021FA RID: 8698
	// (get) Token: 0x06018BB5 RID: 101301 RVA: 0x006589D5 File Offset: 0x00656BD5
	// (set) Token: 0x06018BB6 RID: 101302 RVA: 0x006589E5 File Offset: 0x00656BE5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float FreezeTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataFreeze.__PropertyOffset_FreezeTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataFreeze.__PropertyOffset_FreezeTime) = value;
		}
	}

	// Token: 0x06018BB7 RID: 101303 RVA: 0x006589F6 File Offset: 0x00656BF6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataFreeze._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataFreeze.LogicDataFreeze_C");
		}
		return LogicDataFreeze._ClassPtr;
	}

	// Token: 0x06018BB8 RID: 101304 RVA: 0x00658A1C File Offset: 0x00656C1C
	public LogicDataFreeze() : this(BuiltinUtils.AllocNativeUObject(LogicDataFreeze.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018BB9 RID: 101305 RVA: 0x00658A44 File Offset: 0x00656C44
	public LogicDataFreeze(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataFreeze.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018BBA RID: 101306 RVA: 0x00658A77 File Offset: 0x00656C77
	protected LogicDataFreeze(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B87F RID: 47231
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataFreeze.LogicDataFreeze_C";

	// Token: 0x0400B880 RID: 47232
	private static IntPtr _ClassPtr;

	// Token: 0x0400B881 RID: 47233
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B882 RID: 47234
	private static int __PropertyOffset_Target;

	// Token: 0x0400B883 RID: 47235
	private static int __PropertyOffset_Tags;

	// Token: 0x0400B884 RID: 47236
	[Nullable(2)]
	private FGameplayTagContainer _Tags;

	// Token: 0x0400B885 RID: 47237
	private static int __PropertyOffset_FreezeTime;
}
