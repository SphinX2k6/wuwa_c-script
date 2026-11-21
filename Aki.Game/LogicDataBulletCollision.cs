using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200234E RID: 9038
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataBulletCollision.LogicDataBulletCollision_C")]
public class LogicDataBulletCollision : LogicDataBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700222B RID: 8747
	// (get) Token: 0x060163E8 RID: 91112 RVA: 0x0067DD7C File Offset: 0x0067BF7C
	// (set) Token: 0x060163E9 RID: 91113 RVA: 0x0067DD8C File Offset: 0x0067BF8C
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

	// Token: 0x1700222C RID: 8748
	// (get) Token: 0x060163EA RID: 91114 RVA: 0x0067DD9D File Offset: 0x0067BF9D
	// (set) Token: 0x060163EB RID: 91115 RVA: 0x0067DDAD File Offset: 0x0067BFAD
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

	// Token: 0x1700222D RID: 8749
	// (get) Token: 0x060163EC RID: 91116 RVA: 0x0067DDC0 File Offset: 0x0067BFC0
	// (set) Token: 0x060163ED RID: 91117 RVA: 0x0067DDF9 File Offset: 0x0067BFF9
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

	// Token: 0x1700222E RID: 8750
	// (get) Token: 0x060163EE RID: 91118 RVA: 0x0067DE08 File Offset: 0x0067C008
	// (set) Token: 0x060163EF RID: 91119 RVA: 0x0067DE41 File Offset: 0x0067C041
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

	// Token: 0x1700222F RID: 8751
	// (get) Token: 0x060163F0 RID: 91120 RVA: 0x0067DE66 File Offset: 0x0067C066
	// (set) Token: 0x060163F1 RID: 91121 RVA: 0x0067DE7A File Offset: 0x0067C07A
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

	// Token: 0x17002230 RID: 8752
	// (get) Token: 0x060163F2 RID: 91122 RVA: 0x0067DE8F File Offset: 0x0067C08F
	// (set) Token: 0x060163F3 RID: 91123 RVA: 0x0067DEA3 File Offset: 0x0067C0A3
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

	// Token: 0x17002231 RID: 8753
	// (get) Token: 0x060163F4 RID: 91124 RVA: 0x0067DEB8 File Offset: 0x0067C0B8
	// (set) Token: 0x060163F5 RID: 91125 RVA: 0x0067DEF1 File Offset: 0x0067C0F1
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

	// Token: 0x17002232 RID: 8754
	// (get) Token: 0x060163F6 RID: 91126 RVA: 0x0067DF18 File Offset: 0x0067C118
	// (set) Token: 0x060163F7 RID: 91127 RVA: 0x0067DF51 File Offset: 0x0067C151
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

	// Token: 0x17002233 RID: 8755
	// (get) Token: 0x060163F8 RID: 91128 RVA: 0x0067DF7C File Offset: 0x0067C17C
	// (set) Token: 0x060163F9 RID: 91129 RVA: 0x0067DFB5 File Offset: 0x0067C1B5
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

	// Token: 0x060163FA RID: 91130 RVA: 0x0067DFC3 File Offset: 0x0067C1C3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LogicDataBulletCollision._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataBulletCollision.LogicDataBulletCollision_C");
		}
		return LogicDataBulletCollision._ClassPtr;
	}

	// Token: 0x060163FB RID: 91131 RVA: 0x0067DFE8 File Offset: 0x0067C1E8
	public LogicDataBulletCollision() : this(BuiltinUtils.AllocNativeUObject(LogicDataBulletCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060163FC RID: 91132 RVA: 0x0067E010 File Offset: 0x0067C210
	public LogicDataBulletCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LogicDataBulletCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060163FD RID: 91133 RVA: 0x0067E043 File Offset: 0x0067C243
	protected LogicDataBulletCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400BBB6 RID: 48054
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/LogicDataClass/LogicDataBulletCollision.LogicDataBulletCollision_C";

	// Token: 0x0400BBB7 RID: 48055
	private static IntPtr _ClassPtr;

	// Token: 0x0400BBB8 RID: 48056
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400BBB9 RID: 48057
	private static int __PropertyOffset_DestroyType;

	// Token: 0x0400BBBA RID: 48058
	private static int __PropertyOffset_BulletPosition;

	// Token: 0x0400BBBB RID: 48059
	private static int __PropertyOffset_BulletRowName;

	// Token: 0x0400BBBC RID: 48060
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _BulletRowName;

	// Token: 0x0400BBBD RID: 48061
	private static int __PropertyOffset_EffectCollision;

	// Token: 0x0400BBBE RID: 48062
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _EffectCollision;

	// Token: 0x0400BBBF RID: 48063
	private static int __PropertyOffset_PositionOffset;

	// Token: 0x0400BBC0 RID: 48064
	private static int __PropertyOffset_RotationOffset;

	// Token: 0x0400BBC1 RID: 48065
	private static int __PropertyOffset_ScreenShake;

	// Token: 0x0400BBC2 RID: 48066
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftClassPtr<UCameraShakeBase> _ScreenShake;

	// Token: 0x0400BBC3 RID: 48067
	private static int __PropertyOffset_CameraModified;

	// Token: 0x0400BBC4 RID: 48068
	[Nullable(2)]
	private SCounterAttackCamera _CameraModified;

	// Token: 0x0400BBC5 RID: 48069
	private static int __PropertyOffset_TriggerBulletIds;

	// Token: 0x0400BBC6 RID: 48070
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _TriggerBulletIds;
}
