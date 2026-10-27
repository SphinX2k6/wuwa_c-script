using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DFB RID: 11771
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataManipulatableCreateBullet.LogicDataManipulatableCreateBullet_C")]
public class LogicDataManipulatableCreateBullet : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170021FB RID: 8699
	// (get) Token: 0x06018BBB RID: 101307 RVA: 0x00658A80 File Offset: 0x00656C80
	// (set) Token: 0x06018BBC RID: 101308 RVA: 0x00658AB9 File Offset: 0x00656CB9
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer ExistTagsCondition
	{
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._ExistTagsCondition) == null)
			{
				result = (this._ExistTagsCondition = new FGameplayTagContainer(base.NativePtr + (IntPtr)LogicDataManipulatableCreateBullet.__PropertyOffset_ExistTagsCondition, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)LogicDataManipulatableCreateBullet.__PropertyOffset_ExistTagsCondition, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170021FC RID: 8700
	// (get) Token: 0x06018BBD RID: 101309 RVA: 0x00658AE4 File Offset: 0x00656CE4
	// (set) Token: 0x06018BBE RID: 101310 RVA: 0x00658B1D File Offset: 0x00656D1D
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer UnExistTagsCondition
	{
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._UnExistTagsCondition) == null)
			{
				result = (this._UnExistTagsCondition = new FGameplayTagContainer(base.NativePtr + (IntPtr)LogicDataManipulatableCreateBullet.__PropertyOffset_UnExistTagsCondition, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)LogicDataManipulatableCreateBullet.__PropertyOffset_UnExistTagsCondition, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170021FD RID: 8701
	// (get) Token: 0x06018BBF RID: 101311 RVA: 0x00658B45 File Offset: 0x00656D45
	// (set) Token: 0x06018BC0 RID: 101312 RVA: 0x00658B55 File Offset: 0x00656D55
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EBulletObject BulletOwner
	{
		get
		{
			return (EBulletObject)(*(base.NativePtr + (IntPtr)LogicDataManipulatableCreateBullet.__PropertyOffset_BulletOwner));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataManipulatableCreateBullet.__PropertyOffset_BulletOwner) = (byte)value;
		}
	}

	// Token: 0x170021FE RID: 8702
	// (get) Token: 0x06018BC1 RID: 101313 RVA: 0x00658B68 File Offset: 0x00656D68
	// (set) Token: 0x06018BC2 RID: 101314 RVA: 0x00658BA1 File Offset: 0x00656DA1
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> CreateBulletRowName
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._CreateBulletRowName) == null)
			{
				result = (this._CreateBulletRowName = new TArray<string>(base.NativePtr + (IntPtr)LogicDataManipulatableCreateBullet.__PropertyOffset_CreateBulletRowName, this));
			}
			return result;
		}
		set
		{
			this.CreateBulletRowName.CopyAssign(value);
		}
	}

	// Token: 0x170021FF RID: 8703
	// (get) Token: 0x06018BC3 RID: 101315 RVA: 0x00658BAF File Offset: 0x00656DAF
	// (set) Token: 0x06018BC4 RID: 101316 RVA: 0x00658BBF File Offset: 0x00656DBF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EBulletObject BulletTransform
	{
		get
		{
			return (EBulletObject)(*(base.NativePtr + (IntPtr)LogicDataManipulatableCreateBullet.__PropertyOffset_BulletTransform));
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataManipulatableCreateBullet.__PropertyOffset_BulletTransform) = (byte)value;
		}
	}

	// Token: 0x06018BC5 RID: 101317 RVA: 0x00658BD0 File Offset: 0x00656DD0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataManipulatableCreateBullet._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataManipulatableCreateBullet.LogicDataManipulatableCreateBullet_C");
		}
		return LogicDataManipulatableCreateBullet._ClassPtr;
	}

	// Token: 0x06018BC6 RID: 101318 RVA: 0x00658BF4 File Offset: 0x00656DF4
	public LogicDataManipulatableCreateBullet() : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableCreateBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018BC7 RID: 101319 RVA: 0x00658C1C File Offset: 0x00656E1C
	public LogicDataManipulatableCreateBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableCreateBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018BC8 RID: 101320 RVA: 0x00658C4F File Offset: 0x00656E4F
	protected LogicDataManipulatableCreateBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B886 RID: 47238
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataManipulatableCreateBullet.LogicDataManipulatableCreateBullet_C";

	// Token: 0x0400B887 RID: 47239
	private static IntPtr _ClassPtr;

	// Token: 0x0400B888 RID: 47240
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B889 RID: 47241
	private static int __PropertyOffset_ExistTagsCondition;

	// Token: 0x0400B88A RID: 47242
	[Nullable(2)]
	private FGameplayTagContainer _ExistTagsCondition;

	// Token: 0x0400B88B RID: 47243
	private static int __PropertyOffset_UnExistTagsCondition;

	// Token: 0x0400B88C RID: 47244
	[Nullable(2)]
	private FGameplayTagContainer _UnExistTagsCondition;

	// Token: 0x0400B88D RID: 47245
	private static int __PropertyOffset_BulletOwner;

	// Token: 0x0400B88E RID: 47246
	private static int __PropertyOffset_CreateBulletRowName;

	// Token: 0x0400B88F RID: 47247
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _CreateBulletRowName;

	// Token: 0x0400B890 RID: 47248
	private static int __PropertyOffset_BulletTransform;
}
