using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002355 RID: 9045
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataFreeze.LogicDataFreeze_C")]
public class LogicDataFreeze : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700225C RID: 8796
	// (get) Token: 0x06016466 RID: 91238 RVA: 0x0067E9D4 File Offset: 0x0067CBD4
	// (set) Token: 0x06016467 RID: 91239 RVA: 0x0067E9E4 File Offset: 0x0067CBE4
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

	// Token: 0x1700225D RID: 8797
	// (get) Token: 0x06016468 RID: 91240 RVA: 0x0067E9F8 File Offset: 0x0067CBF8
	// (set) Token: 0x06016469 RID: 91241 RVA: 0x0067EA31 File Offset: 0x0067CC31
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

	// Token: 0x1700225E RID: 8798
	// (get) Token: 0x0601646A RID: 91242 RVA: 0x0067EA59 File Offset: 0x0067CC59
	// (set) Token: 0x0601646B RID: 91243 RVA: 0x0067EA69 File Offset: 0x0067CC69
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

	// Token: 0x0601646C RID: 91244 RVA: 0x0067EA7A File Offset: 0x0067CC7A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataFreeze._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataFreeze.LogicDataFreeze_C");
		}
		return LogicDataFreeze._ClassPtr;
	}

	// Token: 0x0601646D RID: 91245 RVA: 0x0067EAA0 File Offset: 0x0067CCA0
	public LogicDataFreeze() : this(BuiltinUtils.AllocNativeUObject(LogicDataFreeze.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601646E RID: 91246 RVA: 0x0067EAC8 File Offset: 0x0067CCC8
	public LogicDataFreeze(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataFreeze.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601646F RID: 91247 RVA: 0x0067EAFB File Offset: 0x0067CCFB
	protected LogicDataFreeze(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC05 RID: 48133
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataFreeze.LogicDataFreeze_C";

	// Token: 0x0400BC06 RID: 48134
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC07 RID: 48135
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC08 RID: 48136
	private static int __PropertyOffset_Target;

	// Token: 0x0400BC09 RID: 48137
	private static int __PropertyOffset_Tags;

	// Token: 0x0400BC0A RID: 48138
	[Nullable(2)]
	private FGameplayTagContainer _Tags;

	// Token: 0x0400BC0B RID: 48139
	private static int __PropertyOffset_FreezeTime;
}
