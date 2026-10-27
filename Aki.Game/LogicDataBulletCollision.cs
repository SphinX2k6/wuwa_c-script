using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DF3 RID: 11763
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataBulletCollision.LogicDataBulletCollision_C")]
public class LogicDataBulletCollision : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170021C7 RID: 8647
	// (get) Token: 0x06018B33 RID: 101171 RVA: 0x00657CF8 File Offset: 0x00655EF8
	// (set) Token: 0x06018B34 RID: 101172 RVA: 0x00657D08 File Offset: 0x00655F08
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int DestroyType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_DestroyType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_DestroyType) = value;
		}
	}

	// Token: 0x170021C8 RID: 8648
	// (get) Token: 0x06018B35 RID: 101173 RVA: 0x00657D19 File Offset: 0x00655F19
	// (set) Token: 0x06018B36 RID: 101174 RVA: 0x00657D29 File Offset: 0x00655F29
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int BulletPosition
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_BulletPosition);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_BulletPosition) = value;
		}
	}

	// Token: 0x170021C9 RID: 8649
	// (get) Token: 0x06018B37 RID: 101175 RVA: 0x00657D3C File Offset: 0x00655F3C
	// (set) Token: 0x06018B38 RID: 101176 RVA: 0x00657D75 File Offset: 0x00655F75
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> BulletRowName
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._BulletRowName) == null)
			{
				result = (this._BulletRowName = new TArray<string>(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_BulletRowName, this));
			}
			return result;
		}
		set
		{
			this.BulletRowName.CopyAssign(value);
		}
	}

	// Token: 0x170021CA RID: 8650
	// (get) Token: 0x06018B39 RID: 101177 RVA: 0x00657D84 File Offset: 0x00655F84
	// (set) Token: 0x06018B3A RID: 101178 RVA: 0x00657DBD File Offset: 0x00655FBD
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> EffectCollision
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._EffectCollision) == null)
			{
				result = (this._EffectCollision = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_EffectCollision, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_EffectCollision, 1);
		}
	}

	// Token: 0x170021CB RID: 8651
	// (get) Token: 0x06018B3B RID: 101179 RVA: 0x00657DE2 File Offset: 0x00655FE2
	// (set) Token: 0x06018B3C RID: 101180 RVA: 0x00657DF6 File Offset: 0x00655FF6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector PositionOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_PositionOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_PositionOffset) = value;
		}
	}

	// Token: 0x170021CC RID: 8652
	// (get) Token: 0x06018B3D RID: 101181 RVA: 0x00657E0B File Offset: 0x0065600B
	// (set) Token: 0x06018B3E RID: 101182 RVA: 0x00657E1F File Offset: 0x0065601F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FRotator RotationOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_RotationOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_RotationOffset) = value;
		}
	}

	// Token: 0x170021CD RID: 8653
	// (get) Token: 0x06018B3F RID: 101183 RVA: 0x00657E34 File Offset: 0x00656034
	// (set) Token: 0x06018B40 RID: 101184 RVA: 0x00657E6D File Offset: 0x0065606D
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftClassPtr<UCameraShakeBase> ScreenShake
	{
		get
		{
			base.FastCheckIsValid();
			TSoftClassPtr<UCameraShakeBase> result;
			if ((result = this._ScreenShake) == null)
			{
				result = (this._ScreenShake = new TSoftClassPtr<UCameraShakeBase>(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_ScreenShake, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_ScreenShake, 1);
		}
	}

	// Token: 0x170021CE RID: 8654
	// (get) Token: 0x06018B41 RID: 101185 RVA: 0x00657E94 File Offset: 0x00656094
	// (set) Token: 0x06018B42 RID: 101186 RVA: 0x00657ECD File Offset: 0x006560CD
	[UProperty(EPropertyFlags.CPF_None)]
	public SCounterAttackCamera CameraModified
	{
		get
		{
			base.FastCheckIsValid();
			SCounterAttackCamera result;
			if ((result = this._CameraModified) == null)
			{
				result = (this._CameraModified = new SCounterAttackCamera(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_CameraModified, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SCounterAttackCamera.StaticStruct(), base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_CameraModified, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x170021CF RID: 8655
	// (get) Token: 0x06018B43 RID: 101187 RVA: 0x00657EF8 File Offset: 0x006560F8
	// (set) Token: 0x06018B44 RID: 101188 RVA: 0x00657F31 File Offset: 0x00656131
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> TriggerBulletIds
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._TriggerBulletIds) == null)
			{
				result = (this._TriggerBulletIds = new TArray<string>(base.NativePtr + (IntPtr)LogicDataBulletCollision.__PropertyOffset_TriggerBulletIds, this));
			}
			return result;
		}
		set
		{
			this.TriggerBulletIds.CopyAssign(value);
		}
	}

	// Token: 0x06018B45 RID: 101189 RVA: 0x00657F3F File Offset: 0x0065613F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataBulletCollision._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataBulletCollision.LogicDataBulletCollision_C");
		}
		return LogicDataBulletCollision._ClassPtr;
	}

	// Token: 0x06018B46 RID: 101190 RVA: 0x00657F64 File Offset: 0x00656164
	public LogicDataBulletCollision() : this(BuiltinUtils.AllocNativeUObject(LogicDataBulletCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06018B47 RID: 101191 RVA: 0x00657F8C File Offset: 0x0065618C
	public LogicDataBulletCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataBulletCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06018B48 RID: 101192 RVA: 0x00657FBF File Offset: 0x006561BF
	protected LogicDataBulletCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400B830 RID: 47152
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataBulletCollision.LogicDataBulletCollision_C";

	// Token: 0x0400B831 RID: 47153
	private static IntPtr _ClassPtr;

	// Token: 0x0400B832 RID: 47154
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400B833 RID: 47155
	private static int __PropertyOffset_DestroyType;

	// Token: 0x0400B834 RID: 47156
	private static int __PropertyOffset_BulletPosition;

	// Token: 0x0400B835 RID: 47157
	private static int __PropertyOffset_BulletRowName;

	// Token: 0x0400B836 RID: 47158
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _BulletRowName;

	// Token: 0x0400B837 RID: 47159
	private static int __PropertyOffset_EffectCollision;

	// Token: 0x0400B838 RID: 47160
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _EffectCollision;

	// Token: 0x0400B839 RID: 47161
	private static int __PropertyOffset_PositionOffset;

	// Token: 0x0400B83A RID: 47162
	private static int __PropertyOffset_RotationOffset;

	// Token: 0x0400B83B RID: 47163
	private static int __PropertyOffset_ScreenShake;

	// Token: 0x0400B83C RID: 47164
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftClassPtr<UCameraShakeBase> _ScreenShake;

	// Token: 0x0400B83D RID: 47165
	private static int __PropertyOffset_CameraModified;

	// Token: 0x0400B83E RID: 47166
	[Nullable(2)]
	private SCounterAttackCamera _CameraModified;

	// Token: 0x0400B83F RID: 47167
	private static int __PropertyOffset_TriggerBulletIds;

	// Token: 0x0400B840 RID: 47168
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _TriggerBulletIds;
}
