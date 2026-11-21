using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002362 RID: 9058
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSupport.LogicDataSupport_C")]
public class LogicDataSupport : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170022AC RID: 8876
	// (get) Token: 0x0601653A RID: 91450 RVA: 0x00680088 File Offset: 0x0067E288
	// (set) Token: 0x0601653B RID: 91451 RVA: 0x0068009C File Offset: 0x0067E29C
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

	// Token: 0x170022AD RID: 8877
	// (get) Token: 0x0601653C RID: 91452 RVA: 0x006800B1 File Offset: 0x0067E2B1
	// (set) Token: 0x0601653D RID: 91453 RVA: 0x006800C1 File Offset: 0x0067E2C1
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

	// Token: 0x170022AE RID: 8878
	// (get) Token: 0x0601653E RID: 91454 RVA: 0x006800D4 File Offset: 0x0067E2D4
	// (set) Token: 0x0601653F RID: 91455 RVA: 0x0068010D File Offset: 0x0067E30D
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

	// Token: 0x06016540 RID: 91456 RVA: 0x00680132 File Offset: 0x0067E332
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataSupport._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSupport.LogicDataSupport_C");
		}
		return LogicDataSupport._ClassPtr;
	}

	// Token: 0x06016541 RID: 91457 RVA: 0x00680158 File Offset: 0x0067E358
	public LogicDataSupport() : this(BuiltinUtils.AllocNativeUObject(LogicDataSupport.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016542 RID: 91458 RVA: 0x00680180 File Offset: 0x0067E380
	public LogicDataSupport(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataSupport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016543 RID: 91459 RVA: 0x006801B3 File Offset: 0x0067E3B3
	protected LogicDataSupport(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC94 RID: 48276
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataSupport.LogicDataSupport_C";

	// Token: 0x0400BC95 RID: 48277
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC96 RID: 48278
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC97 RID: 48279
	private static int __PropertyOffset_Tag;

	// Token: 0x0400BC98 RID: 48280
	private static int __PropertyOffset_Camp;

	// Token: 0x0400BC99 RID: 48281
	private static int __PropertyOffset_Effect;

	// Token: 0x0400BC9A RID: 48282
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _Effect;
}
