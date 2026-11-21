using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002351 RID: 9041
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataDestroyBullet.LogicDataDestroyBullet_C")]
public class LogicDataDestroyBullet : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002244 RID: 8772
	// (get) Token: 0x06016426 RID: 91174 RVA: 0x0067E400 File Offset: 0x0067C600
	// (set) Token: 0x06016427 RID: 91175 RVA: 0x0067E410 File Offset: 0x0067C610
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EBulletObject BulletOwner
	{
		get
		{
			return (EBulletObject)(*(base.NativePtr + (IntPtr)LogicDataDestroyBullet.__PropertyOffset_BulletOwner));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataDestroyBullet.__PropertyOffset_BulletOwner) = (byte)value;
		}
	}

	// Token: 0x17002245 RID: 8773
	// (get) Token: 0x06016428 RID: 91176 RVA: 0x0067E421 File Offset: 0x0067C621
	// (set) Token: 0x06016429 RID: 91177 RVA: 0x0067E435 File Offset: 0x0067C635
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string DestroyBulletRowName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataDestroyBullet.__PropertyOffset_DestroyBulletRowName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataDestroyBullet.__PropertyOffset_DestroyBulletRowName)), value);
		}
	}

	// Token: 0x17002246 RID: 8774
	// (get) Token: 0x0601642A RID: 91178 RVA: 0x0067E44A File Offset: 0x0067C64A
	// (set) Token: 0x0601642B RID: 91179 RVA: 0x0067E45A File Offset: 0x0067C65A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SummonChildBullet
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataDestroyBullet.__PropertyOffset_SummonChildBullet) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataDestroyBullet.__PropertyOffset_SummonChildBullet) = (value ? 1 : 0);
		}
	}

	// Token: 0x0601642C RID: 91180 RVA: 0x0067E46B File Offset: 0x0067C66B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataDestroyBullet._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataDestroyBullet.LogicDataDestroyBullet_C");
		}
		return LogicDataDestroyBullet._ClassPtr;
	}

	// Token: 0x0601642D RID: 91181 RVA: 0x0067E490 File Offset: 0x0067C690
	public LogicDataDestroyBullet() : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601642E RID: 91182 RVA: 0x0067E4B8 File Offset: 0x0067C6B8
	public LogicDataDestroyBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601642F RID: 91183 RVA: 0x0067E4EB File Offset: 0x0067C6EB
	protected LogicDataDestroyBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BBDF RID: 48095
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataDestroyBullet.LogicDataDestroyBullet_C";

	// Token: 0x0400BBE0 RID: 48096
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBE1 RID: 48097
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BBE2 RID: 48098
	private static int __PropertyOffset_BulletOwner;

	// Token: 0x0400BBE3 RID: 48099
	private static int __PropertyOffset_DestroyBulletRowName;

	// Token: 0x0400BBE4 RID: 48100
	private static int __PropertyOffset_SummonChildBullet;
}
