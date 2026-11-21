using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002350 RID: 9040
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataCreateBullet.LogicDataCreateBullet_C")]
public class LogicDataCreateBullet : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700223E RID: 8766
	// (get) Token: 0x06016416 RID: 91158 RVA: 0x0067E298 File Offset: 0x0067C498
	// (set) Token: 0x06016417 RID: 91159 RVA: 0x0067E2A8 File Offset: 0x0067C4A8
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

	// Token: 0x1700223F RID: 8767
	// (get) Token: 0x06016418 RID: 91160 RVA: 0x0067E2B9 File Offset: 0x0067C4B9
	// (set) Token: 0x06016419 RID: 91161 RVA: 0x0067E2CD File Offset: 0x0067C4CD
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

	// Token: 0x17002240 RID: 8768
	// (get) Token: 0x0601641A RID: 91162 RVA: 0x0067E2E2 File Offset: 0x0067C4E2
	// (set) Token: 0x0601641B RID: 91163 RVA: 0x0067E2F2 File Offset: 0x0067C4F2
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

	// Token: 0x17002241 RID: 8769
	// (get) Token: 0x0601641C RID: 91164 RVA: 0x0067E303 File Offset: 0x0067C503
	// (set) Token: 0x0601641D RID: 91165 RVA: 0x0067E313 File Offset: 0x0067C513
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

	// Token: 0x17002242 RID: 8770
	// (get) Token: 0x0601641E RID: 91166 RVA: 0x0067E324 File Offset: 0x0067C524
	// (set) Token: 0x0601641F RID: 91167 RVA: 0x0067E338 File Offset: 0x0067C538
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

	// Token: 0x17002243 RID: 8771
	// (get) Token: 0x06016420 RID: 91168 RVA: 0x0067E34D File Offset: 0x0067C54D
	// (set) Token: 0x06016421 RID: 91169 RVA: 0x0067E361 File Offset: 0x0067C561
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

	// Token: 0x06016422 RID: 91170 RVA: 0x0067E376 File Offset: 0x0067C576
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataCreateBullet._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataCreateBullet.LogicDataCreateBullet_C");
		}
		return LogicDataCreateBullet._ClassPtr;
	}

	// Token: 0x06016423 RID: 91171 RVA: 0x0067E39C File Offset: 0x0067C59C
	public LogicDataCreateBullet() : this(BuiltinUtils.AllocNativeUObject(LogicDataCreateBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016424 RID: 91172 RVA: 0x0067E3C4 File Offset: 0x0067C5C4
	public LogicDataCreateBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataCreateBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016425 RID: 91173 RVA: 0x0067E3F7 File Offset: 0x0067C5F7
	protected LogicDataCreateBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BBD6 RID: 48086
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataCreateBullet.LogicDataCreateBullet_C";

	// Token: 0x0400BBD7 RID: 48087
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBD8 RID: 48088
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BBD9 RID: 48089
	private static int __PropertyOffset_BulletOwner;

	// Token: 0x0400BBDA RID: 48090
	private static int __PropertyOffset_CreateBulletRowName;

	// Token: 0x0400BBDB RID: 48091
	private static int __PropertyOffset_BulletTransform;

	// Token: 0x0400BBDC RID: 48092
	private static int __PropertyOffset_AttachToActor;

	// Token: 0x0400BBDD RID: 48093
	private static int __PropertyOffset_AttachToBoneName;

	// Token: 0x0400BBDE RID: 48094
	private static int __PropertyOffset_FlashBulletRowName;
}
