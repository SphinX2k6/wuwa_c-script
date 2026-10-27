using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DF5 RID: 11765
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataCreateBullet.LogicDataCreateBullet_C")]
public class LogicDataCreateBullet : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170021DA RID: 8666
	// (get) Token: 0x06018B61 RID: 101217 RVA: 0x00658214 File Offset: 0x00656414
	// (set) Token: 0x06018B62 RID: 101218 RVA: 0x00658224 File Offset: 0x00656424
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EBulletObject BulletOwner
	{
		get
		{
			return (EBulletObject)(*(base.NativePtr + (IntPtr)LogicDataCreateBullet.__PropertyOffset_BulletOwner));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataCreateBullet.__PropertyOffset_BulletOwner) = (byte)value;
		}
	}

	// Token: 0x170021DB RID: 8667
	// (get) Token: 0x06018B63 RID: 101219 RVA: 0x00658235 File Offset: 0x00656435
	// (set) Token: 0x06018B64 RID: 101220 RVA: 0x00658249 File Offset: 0x00656449
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string CreateBulletRowName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataCreateBullet.__PropertyOffset_CreateBulletRowName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataCreateBullet.__PropertyOffset_CreateBulletRowName)), value);
		}
	}

	// Token: 0x170021DC RID: 8668
	// (get) Token: 0x06018B65 RID: 101221 RVA: 0x0065825E File Offset: 0x0065645E
	// (set) Token: 0x06018B66 RID: 101222 RVA: 0x0065826E File Offset: 0x0065646E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EBulletObject BulletTransform
	{
		get
		{
			return (EBulletObject)(*(base.NativePtr + (IntPtr)LogicDataCreateBullet.__PropertyOffset_BulletTransform));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataCreateBullet.__PropertyOffset_BulletTransform) = (byte)value;
		}
	}

	// Token: 0x170021DD RID: 8669
	// (get) Token: 0x06018B67 RID: 101223 RVA: 0x0065827F File Offset: 0x0065647F
	// (set) Token: 0x06018B68 RID: 101224 RVA: 0x0065828F File Offset: 0x0065648F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EBulletObject AttachToActor
	{
		get
		{
			return (EBulletObject)(*(base.NativePtr + (IntPtr)LogicDataCreateBullet.__PropertyOffset_AttachToActor));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataCreateBullet.__PropertyOffset_AttachToActor) = (byte)value;
		}
	}

	// Token: 0x170021DE RID: 8670
	// (get) Token: 0x06018B69 RID: 101225 RVA: 0x006582A0 File Offset: 0x006564A0
	// (set) Token: 0x06018B6A RID: 101226 RVA: 0x006582B4 File Offset: 0x006564B4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string AttachToBoneName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataCreateBullet.__PropertyOffset_AttachToBoneName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataCreateBullet.__PropertyOffset_AttachToBoneName)), value);
		}
	}

	// Token: 0x170021DF RID: 8671
	// (get) Token: 0x06018B6B RID: 101227 RVA: 0x006582C9 File Offset: 0x006564C9
	// (set) Token: 0x06018B6C RID: 101228 RVA: 0x006582DD File Offset: 0x006564DD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string FlashBulletRowName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataCreateBullet.__PropertyOffset_FlashBulletRowName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataCreateBullet.__PropertyOffset_FlashBulletRowName)), value);
		}
	}

	// Token: 0x06018B6D RID: 101229 RVA: 0x006582F2 File Offset: 0x006564F2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataCreateBullet._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataCreateBullet.LogicDataCreateBullet_C");
		}
		return LogicDataCreateBullet._ClassPtr;
	}

	// Token: 0x06018B6E RID: 101230 RVA: 0x00658318 File Offset: 0x00656518
	public LogicDataCreateBullet() : this(BuiltinUtils.AllocNativeUObject(LogicDataCreateBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018B6F RID: 101231 RVA: 0x00658340 File Offset: 0x00656540
	public LogicDataCreateBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataCreateBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018B70 RID: 101232 RVA: 0x00658373 File Offset: 0x00656573
	protected LogicDataCreateBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B850 RID: 47184
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataCreateBullet.LogicDataCreateBullet_C";

	// Token: 0x0400B851 RID: 47185
	private static IntPtr _ClassPtr;

	// Token: 0x0400B852 RID: 47186
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B853 RID: 47187
	private static int __PropertyOffset_BulletOwner;

	// Token: 0x0400B854 RID: 47188
	private static int __PropertyOffset_CreateBulletRowName;

	// Token: 0x0400B855 RID: 47189
	private static int __PropertyOffset_BulletTransform;

	// Token: 0x0400B856 RID: 47190
	private static int __PropertyOffset_AttachToActor;

	// Token: 0x0400B857 RID: 47191
	private static int __PropertyOffset_AttachToBoneName;

	// Token: 0x0400B858 RID: 47192
	private static int __PropertyOffset_FlashBulletRowName;
}
