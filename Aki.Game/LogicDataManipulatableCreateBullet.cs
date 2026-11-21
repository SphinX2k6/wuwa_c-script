using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002356 RID: 9046
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataManipulatableCreateBullet.LogicDataManipulatableCreateBullet_C")]
public class LogicDataManipulatableCreateBullet : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700225F RID: 8799
	// (get) Token: 0x06016470 RID: 91248 RVA: 0x0067EB04 File Offset: 0x0067CD04
	// (set) Token: 0x06016471 RID: 91249 RVA: 0x0067EB3D File Offset: 0x0067CD3D
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

	// Token: 0x17002260 RID: 8800
	// (get) Token: 0x06016472 RID: 91250 RVA: 0x0067EB68 File Offset: 0x0067CD68
	// (set) Token: 0x06016473 RID: 91251 RVA: 0x0067EBA1 File Offset: 0x0067CDA1
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

	// Token: 0x17002261 RID: 8801
	// (get) Token: 0x06016474 RID: 91252 RVA: 0x0067EBC9 File Offset: 0x0067CDC9
	// (set) Token: 0x06016475 RID: 91253 RVA: 0x0067EBD9 File Offset: 0x0067CDD9
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

	// Token: 0x17002262 RID: 8802
	// (get) Token: 0x06016476 RID: 91254 RVA: 0x0067EBEC File Offset: 0x0067CDEC
	// (set) Token: 0x06016477 RID: 91255 RVA: 0x0067EC25 File Offset: 0x0067CE25
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

	// Token: 0x17002263 RID: 8803
	// (get) Token: 0x06016478 RID: 91256 RVA: 0x0067EC33 File Offset: 0x0067CE33
	// (set) Token: 0x06016479 RID: 91257 RVA: 0x0067EC43 File Offset: 0x0067CE43
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

	// Token: 0x0601647A RID: 91258 RVA: 0x0067EC54 File Offset: 0x0067CE54
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataManipulatableCreateBullet._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataManipulatableCreateBullet.LogicDataManipulatableCreateBullet_C");
		}
		return LogicDataManipulatableCreateBullet._ClassPtr;
	}

	// Token: 0x0601647B RID: 91259 RVA: 0x0067EC78 File Offset: 0x0067CE78
	public LogicDataManipulatableCreateBullet() : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableCreateBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601647C RID: 91260 RVA: 0x0067ECA0 File Offset: 0x0067CEA0
	public LogicDataManipulatableCreateBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataManipulatableCreateBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601647D RID: 91261 RVA: 0x0067ECD3 File Offset: 0x0067CED3
	protected LogicDataManipulatableCreateBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BC0C RID: 48140
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataManipulatableCreateBullet.LogicDataManipulatableCreateBullet_C";

	// Token: 0x0400BC0D RID: 48141
	private static IntPtr _ClassPtr;

	// Token: 0x0400BC0E RID: 48142
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BC0F RID: 48143
	private static int __PropertyOffset_ExistTagsCondition;

	// Token: 0x0400BC10 RID: 48144
	[Nullable(2)]
	private FGameplayTagContainer _ExistTagsCondition;

	// Token: 0x0400BC11 RID: 48145
	private static int __PropertyOffset_UnExistTagsCondition;

	// Token: 0x0400BC12 RID: 48146
	[Nullable(2)]
	private FGameplayTagContainer _UnExistTagsCondition;

	// Token: 0x0400BC13 RID: 48147
	private static int __PropertyOffset_BulletOwner;

	// Token: 0x0400BC14 RID: 48148
	private static int __PropertyOffset_CreateBulletRowName;

	// Token: 0x0400BC15 RID: 48149
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _CreateBulletRowName;

	// Token: 0x0400BC16 RID: 48150
	private static int __PropertyOffset_BulletTransform;
}
