using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002352 RID: 9042
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataDestroyOtherBullet.LogicDataDestroyOtherBullet_C")]
public class LogicDataDestroyOtherBullet : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002247 RID: 8775
	// (get) Token: 0x06016430 RID: 91184 RVA: 0x0067E4F4 File Offset: 0x0067C6F4
	// (set) Token: 0x06016431 RID: 91185 RVA: 0x0067E504 File Offset: 0x0067C704
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECamp Camp
	{
		get
		{
			return (ECamp)(*(base.NativePtr + (IntPtr)LogicDataDestroyOtherBullet.__PropertyOffset_Camp));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataDestroyOtherBullet.__PropertyOffset_Camp) = (byte)value;
		}
	}

	// Token: 0x17002248 RID: 8776
	// (get) Token: 0x06016432 RID: 91186 RVA: 0x0067E515 File Offset: 0x0067C715
	// (set) Token: 0x06016433 RID: 91187 RVA: 0x0067E529 File Offset: 0x0067C729
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BulletId
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataDestroyOtherBullet.__PropertyOffset_BulletId)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)LogicDataDestroyOtherBullet.__PropertyOffset_BulletId)), value);
		}
	}

	// Token: 0x17002249 RID: 8777
	// (get) Token: 0x06016434 RID: 91188 RVA: 0x0067E53E File Offset: 0x0067C73E
	// (set) Token: 0x06016435 RID: 91189 RVA: 0x0067E54E File Offset: 0x0067C74E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SummonChildBullet
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataDestroyOtherBullet.__PropertyOffset_SummonChildBullet) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataDestroyOtherBullet.__PropertyOffset_SummonChildBullet) = (value ? 1 : 0);
		}
	}

	// Token: 0x06016436 RID: 91190 RVA: 0x0067E55F File Offset: 0x0067C75F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataDestroyOtherBullet._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataDestroyOtherBullet.LogicDataDestroyOtherBullet_C");
		}
		return LogicDataDestroyOtherBullet._ClassPtr;
	}

	// Token: 0x06016437 RID: 91191 RVA: 0x0067E584 File Offset: 0x0067C784
	public LogicDataDestroyOtherBullet() : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyOtherBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016438 RID: 91192 RVA: 0x0067E5AC File Offset: 0x0067C7AC
	public LogicDataDestroyOtherBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataDestroyOtherBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016439 RID: 91193 RVA: 0x0067E5DF File Offset: 0x0067C7DF
	protected LogicDataDestroyOtherBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BBE5 RID: 48101
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataDestroyOtherBullet.LogicDataDestroyOtherBullet_C";

	// Token: 0x0400BBE6 RID: 48102
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBE7 RID: 48103
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BBE8 RID: 48104
	private static int __PropertyOffset_Camp;

	// Token: 0x0400BBE9 RID: 48105
	private static int __PropertyOffset_BulletId;

	// Token: 0x0400BBEA RID: 48106
	private static int __PropertyOffset_SummonChildBullet;
}
