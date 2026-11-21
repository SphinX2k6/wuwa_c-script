using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A5 RID: 26533
	public struct IAdjustAxisLockCamera : IFlatbufferObject
	{
		// Token: 0x1700C11E RID: 49438
		// (get) Token: 0x0602D088 RID: 184456 RVA: 0x00627D84 File Offset: 0x00625F84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D089 RID: 184457 RVA: 0x00627D91 File Offset: 0x00625F91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D08A RID: 184458 RVA: 0x00627D98 File Offset: 0x00625F98
		public static IAdjustAxisLockCamera GetRootAsIAdjustAxisLockCamera(ByteBuffer _bb)
		{
			return IAdjustAxisLockCamera.GetRootAsIAdjustAxisLockCamera(_bb, default(IAdjustAxisLockCamera));
		}

		// Token: 0x0602D08B RID: 184459 RVA: 0x00627DB4 File Offset: 0x00625FB4
		public static IAdjustAxisLockCamera GetRootAsIAdjustAxisLockCamera(ByteBuffer _bb, IAdjustAxisLockCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D08C RID: 184460 RVA: 0x00627DD1 File Offset: 0x00625FD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D08D RID: 184461 RVA: 0x00627DE0 File Offset: 0x00625FE0
		public IAdjustAxisLockCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C11F RID: 49439
		// (get) Token: 0x0602D08E RID: 184462 RVA: 0x00627DF0 File Offset: 0x00625FF0
		public EAdjustPlayerCamera Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAdjustPlayerCamera.Basic;
				}
				return (EAdjustPlayerCamera)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C120 RID: 49440
		// (get) Token: 0x0602D08F RID: 184463 RVA: 0x00627E2C File Offset: 0x0062602C
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C121 RID: 49441
		// (get) Token: 0x0602D090 RID: 184464 RVA: 0x00627E68 File Offset: 0x00626068
		public float FadeInTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C122 RID: 49442
		// (get) Token: 0x0602D091 RID: 184465 RVA: 0x00627EA8 File Offset: 0x006260A8
		public IBaseCurve? FadeInCurve
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IBaseCurve?(default(IBaseCurve).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C123 RID: 49443
		// (get) Token: 0x0602D092 RID: 184466 RVA: 0x00627F08 File Offset: 0x00626108
		public float FadeOutTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C124 RID: 49444
		// (get) Token: 0x0602D093 RID: 184467 RVA: 0x00627F4C File Offset: 0x0062614C
		public IBaseCurve? FadeOutCurve
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IBaseCurve?(default(IBaseCurve).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C125 RID: 49445
		// (get) Token: 0x0602D094 RID: 184468 RVA: 0x00627FAC File Offset: 0x006261AC
		public float ArmLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C126 RID: 49446
		// (get) Token: 0x0602D095 RID: 184469 RVA: 0x00627FF0 File Offset: 0x006261F0
		public float MinumArmLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C127 RID: 49447
		// (get) Token: 0x0602D096 RID: 184470 RVA: 0x00628034 File Offset: 0x00626234
		public float MaxiumArmLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C128 RID: 49448
		// (get) Token: 0x0602D097 RID: 184471 RVA: 0x00628078 File Offset: 0x00626278
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C129 RID: 49449
		// (get) Token: 0x0602D098 RID: 184472 RVA: 0x006280D8 File Offset: 0x006262D8
		public IVectorInfo? ArmOffset
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C12A RID: 49450
		// (get) Token: 0x0602D099 RID: 184473 RVA: 0x00628138 File Offset: 0x00626338
		public float YawLimitMin
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C12B RID: 49451
		// (get) Token: 0x0602D09A RID: 184474 RVA: 0x0062817C File Offset: 0x0062637C
		public float YawLimitMax
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C12C RID: 49452
		// (get) Token: 0x0602D09B RID: 184475 RVA: 0x006281C0 File Offset: 0x006263C0
		public float PitchLimitMin
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C12D RID: 49453
		// (get) Token: 0x0602D09C RID: 184476 RVA: 0x00628204 File Offset: 0x00626404
		public float PitchLimitMax
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C12E RID: 49454
		// (get) Token: 0x0602D09D RID: 184477 RVA: 0x00628248 File Offset: 0x00626448
		public float Fov
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C12F RID: 49455
		// (get) Token: 0x0602D09E RID: 184478 RVA: 0x0062828C File Offset: 0x0062648C
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C130 RID: 49456
		// (get) Token: 0x0602D09F RID: 184479 RVA: 0x006282CC File Offset: 0x006264CC
		public TGravityDirection GravityDirectionType
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return TGravityDirection.NONE;
				}
				return (TGravityDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D0A0 RID: 184480 RVA: 0x0062830C File Offset: 0x0062650C
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D0A1 RID: 184481 RVA: 0x00628354 File Offset: 0x00626554
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602D0A2 RID: 184482 RVA: 0x00628370 File Offset: 0x00626570
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602D0A3 RID: 184483 RVA: 0x0062838C File Offset: 0x0062658C
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602D0A4 RID: 184484 RVA: 0x006283A8 File Offset: 0x006265A8
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700C131 RID: 49457
		// (get) Token: 0x0602D0A5 RID: 184485 RVA: 0x006283C4 File Offset: 0x006265C4
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C132 RID: 49458
		// (get) Token: 0x0602D0A6 RID: 184486 RVA: 0x00628404 File Offset: 0x00626604
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C133 RID: 49459
		// (get) Token: 0x0602D0A7 RID: 184487 RVA: 0x00628444 File Offset: 0x00626644
		public string SubScreenBindKey
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D0A8 RID: 184488 RVA: 0x0062847C File Offset: 0x0062667C
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602D0A9 RID: 184489 RVA: 0x0062848C File Offset: 0x0062668C
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700C134 RID: 49460
		// (get) Token: 0x0602D0AA RID: 184490 RVA: 0x0062849C File Offset: 0x0062669C
		public IVectorInfo? AxisRotate
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C135 RID: 49461
		// (get) Token: 0x0602D0AB RID: 184491 RVA: 0x006284FC File Offset: 0x006266FC
		public bool IsLockRoll
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C136 RID: 49462
		// (get) Token: 0x0602D0AC RID: 184492 RVA: 0x0062853C File Offset: 0x0062673C
		public IAxisLockScreenConfig? ScreenConfig
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return new IAxisLockScreenConfig?(default(IAxisLockScreenConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C137 RID: 49463
		// (get) Token: 0x0602D0AD RID: 184493 RVA: 0x0062859C File Offset: 0x0062679C
		public float NearClipDistanceToTarget
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C138 RID: 49464
		// (get) Token: 0x0602D0AE RID: 184494 RVA: 0x006285E0 File Offset: 0x006267E0
		public ISpringArmSoftZoneConfig? SpringArmSoftZoneConfig
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return new ISpringArmSoftZoneConfig?(default(ISpringArmSoftZoneConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C139 RID: 49465
		// (get) Token: 0x0602D0AF RID: 184495 RVA: 0x00628640 File Offset: 0x00626840
		public ISpringArmFixConfig? SpringArmFix
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return new ISpringArmFixConfig?(default(ISpringArmFixConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C13A RID: 49466
		// (get) Token: 0x0602D0B0 RID: 184496 RVA: 0x006286A0 File Offset: 0x006268A0
		public bool HidePlayer
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C13B RID: 49467
		// (get) Token: 0x0602D0B1 RID: 184497 RVA: 0x006286E0 File Offset: 0x006268E0
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D0B2 RID: 184498 RVA: 0x00628720 File Offset: 0x00626920
		public static Offset<IAdjustAxisLockCamera> CreateIAdjustAxisLockCamera(FlatBufferBuilder builder, EAdjustPlayerCamera Type = EAdjustPlayerCamera.Basic, int Priority = 0, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>), float FadeOutTime = 0f, Offset<IBaseCurve> FadeOutCurveOffset = default(Offset<IBaseCurve>), float ArmLength = 0f, float MinumArmLength = 0f, float MaxiumArmLength = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArmOffsetOffset = default(Offset<IVectorInfo>), float YawLimitMin = 0f, float YawLimitMax = 0f, float PitchLimitMin = 0f, float PitchLimitMax = 0f, float Fov = 0f, bool IsDisableResetFocus = false, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool IsDisableCollision = false, bool IsDisableDither = false, StringOffset SubScreenBindKeyOffset = default(StringOffset), Offset<IVectorInfo> AxisRotateOffset = default(Offset<IVectorInfo>), bool IsLockRoll = false, Offset<IAxisLockScreenConfig> ScreenConfigOffset = default(Offset<IAxisLockScreenConfig>), float NearClipDistanceToTarget = 0f, Offset<ISpringArmSoftZoneConfig> SpringArmSoftZoneConfigOffset = default(Offset<ISpringArmSoftZoneConfig>), Offset<ISpringArmFixConfig> SpringArmFixOffset = default(Offset<ISpringArmFixConfig>), bool HidePlayer = false, ushort NullMask = 0)
		{
			builder.StartTable(30);
			IAdjustAxisLockCamera.AddSpringArmFix(builder, SpringArmFixOffset);
			IAdjustAxisLockCamera.AddSpringArmSoftZoneConfig(builder, SpringArmSoftZoneConfigOffset);
			IAdjustAxisLockCamera.AddNearClipDistanceToTarget(builder, NearClipDistanceToTarget);
			IAdjustAxisLockCamera.AddScreenConfig(builder, ScreenConfigOffset);
			IAdjustAxisLockCamera.AddAxisRotate(builder, AxisRotateOffset);
			IAdjustAxisLockCamera.AddSubScreenBindKey(builder, SubScreenBindKeyOffset);
			IAdjustAxisLockCamera.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustAxisLockCamera.AddFov(builder, Fov);
			IAdjustAxisLockCamera.AddPitchLimitMax(builder, PitchLimitMax);
			IAdjustAxisLockCamera.AddPitchLimitMin(builder, PitchLimitMin);
			IAdjustAxisLockCamera.AddYawLimitMax(builder, YawLimitMax);
			IAdjustAxisLockCamera.AddYawLimitMin(builder, YawLimitMin);
			IAdjustAxisLockCamera.AddArmOffset(builder, ArmOffsetOffset);
			IAdjustAxisLockCamera.AddOffset(builder, OffsetOffset);
			IAdjustAxisLockCamera.AddMaxiumArmLength(builder, MaxiumArmLength);
			IAdjustAxisLockCamera.AddMinumArmLength(builder, MinumArmLength);
			IAdjustAxisLockCamera.AddArmLength(builder, ArmLength);
			IAdjustAxisLockCamera.AddFadeOutCurve(builder, FadeOutCurveOffset);
			IAdjustAxisLockCamera.AddFadeOutTime(builder, FadeOutTime);
			IAdjustAxisLockCamera.AddFadeInCurve(builder, FadeInCurveOffset);
			IAdjustAxisLockCamera.AddFadeInTime(builder, FadeInTime);
			IAdjustAxisLockCamera.AddPriority(builder, Priority);
			IAdjustAxisLockCamera.AddNullMask(builder, NullMask);
			IAdjustAxisLockCamera.AddHidePlayer(builder, HidePlayer);
			IAdjustAxisLockCamera.AddIsLockRoll(builder, IsLockRoll);
			IAdjustAxisLockCamera.AddIsDisableDither(builder, IsDisableDither);
			IAdjustAxisLockCamera.AddIsDisableCollision(builder, IsDisableCollision);
			IAdjustAxisLockCamera.AddGravityDirectionType(builder, GravityDirection_type);
			IAdjustAxisLockCamera.AddIsDisableResetFocus(builder, IsDisableResetFocus);
			IAdjustAxisLockCamera.AddType(builder, Type);
			return IAdjustAxisLockCamera.EndIAdjustAxisLockCamera(builder);
		}

		// Token: 0x0602D0B3 RID: 184499 RVA: 0x00628828 File Offset: 0x00626A28
		public static void StartIAdjustAxisLockCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(30);
		}

		// Token: 0x0602D0B4 RID: 184500 RVA: 0x00628832 File Offset: 0x00626A32
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D0B5 RID: 184501 RVA: 0x0062883D File Offset: 0x00626A3D
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602D0B6 RID: 184502 RVA: 0x00628848 File Offset: 0x00626A48
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602D0B7 RID: 184503 RVA: 0x0062885B File Offset: 0x00626A5B
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602D0B8 RID: 184504 RVA: 0x0062886B File Offset: 0x00626A6B
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602D0B9 RID: 184505 RVA: 0x0062887E File Offset: 0x00626A7E
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602D0BA RID: 184506 RVA: 0x0062888E File Offset: 0x00626A8E
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602D0BB RID: 184507 RVA: 0x006288A1 File Offset: 0x00626AA1
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602D0BC RID: 184508 RVA: 0x006288B4 File Offset: 0x00626AB4
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602D0BD RID: 184509 RVA: 0x006288C7 File Offset: 0x00626AC7
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602D0BE RID: 184510 RVA: 0x006288D8 File Offset: 0x00626AD8
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602D0BF RID: 184511 RVA: 0x006288E9 File Offset: 0x00626AE9
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602D0C0 RID: 184512 RVA: 0x006288FD File Offset: 0x00626AFD
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602D0C1 RID: 184513 RVA: 0x00628911 File Offset: 0x00626B11
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602D0C2 RID: 184514 RVA: 0x00628925 File Offset: 0x00626B25
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602D0C3 RID: 184515 RVA: 0x00628939 File Offset: 0x00626B39
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602D0C4 RID: 184516 RVA: 0x0062894D File Offset: 0x00626B4D
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602D0C5 RID: 184517 RVA: 0x00628959 File Offset: 0x00626B59
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602D0C6 RID: 184518 RVA: 0x00628965 File Offset: 0x00626B65
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602D0C7 RID: 184519 RVA: 0x00628971 File Offset: 0x00626B71
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602D0C8 RID: 184520 RVA: 0x0062897D File Offset: 0x00626B7D
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602D0C9 RID: 184521 RVA: 0x00628989 File Offset: 0x00626B89
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602D0CA RID: 184522 RVA: 0x0062899A File Offset: 0x00626B9A
		public static void AddAxisRotate(FlatBufferBuilder builder, Offset<IVectorInfo> axisRotateOffset)
		{
			builder.AddOffset(22, axisRotateOffset.Value, 0);
		}

		// Token: 0x0602D0CB RID: 184523 RVA: 0x006289AB File Offset: 0x00626BAB
		public static void AddIsLockRoll(FlatBufferBuilder builder, bool isLockRoll)
		{
			builder.AddBool(23, isLockRoll, false);
		}

		// Token: 0x0602D0CC RID: 184524 RVA: 0x006289B7 File Offset: 0x00626BB7
		public static void AddScreenConfig(FlatBufferBuilder builder, Offset<IAxisLockScreenConfig> screenConfigOffset)
		{
			builder.AddOffset(24, screenConfigOffset.Value, 0);
		}

		// Token: 0x0602D0CD RID: 184525 RVA: 0x006289C8 File Offset: 0x00626BC8
		public static void AddNearClipDistanceToTarget(FlatBufferBuilder builder, float nearClipDistanceToTarget)
		{
			builder.AddFloat(25, nearClipDistanceToTarget, 0.0);
		}

		// Token: 0x0602D0CE RID: 184526 RVA: 0x006289DC File Offset: 0x00626BDC
		public static void AddSpringArmSoftZoneConfig(FlatBufferBuilder builder, Offset<ISpringArmSoftZoneConfig> springArmSoftZoneConfigOffset)
		{
			builder.AddOffset(26, springArmSoftZoneConfigOffset.Value, 0);
		}

		// Token: 0x0602D0CF RID: 184527 RVA: 0x006289ED File Offset: 0x00626BED
		public static void AddSpringArmFix(FlatBufferBuilder builder, Offset<ISpringArmFixConfig> springArmFixOffset)
		{
			builder.AddOffset(27, springArmFixOffset.Value, 0);
		}

		// Token: 0x0602D0D0 RID: 184528 RVA: 0x006289FE File Offset: 0x00626BFE
		public static void AddHidePlayer(FlatBufferBuilder builder, bool hidePlayer)
		{
			builder.AddBool(28, hidePlayer, false);
		}

		// Token: 0x0602D0D1 RID: 184529 RVA: 0x00628A0A File Offset: 0x00626C0A
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(29, nullMask, 0);
		}

		// Token: 0x0602D0D2 RID: 184530 RVA: 0x00628A16 File Offset: 0x00626C16
		public static Offset<IAdjustAxisLockCamera> EndIAdjustAxisLockCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustAxisLockCamera>(builder.EndTable());
		}

		// Token: 0x0602D0D3 RID: 184531 RVA: 0x00628A24 File Offset: 0x00626C24
		public IAdjustAxisLockCameraT UnPack()
		{
			IAdjustAxisLockCameraT adjustAxisLockCameraT = new IAdjustAxisLockCameraT();
			this.UnPackTo(adjustAxisLockCameraT);
			return adjustAxisLockCameraT;
		}

		// Token: 0x0602D0D4 RID: 184532 RVA: 0x00628A40 File Offset: 0x00626C40
		public void UnPackTo(IAdjustAxisLockCameraT _o)
		{
			_o.Type = this.Type;
			_o.Priority = this.Priority;
			_o.FadeInTime = this.FadeInTime;
			_o.FadeInCurve = ((this.FadeInCurve != null) ? this.FadeInCurve.Value.UnPack() : null);
			_o.FadeOutTime = this.FadeOutTime;
			_o.FadeOutCurve = ((this.FadeOutCurve != null) ? this.FadeOutCurve.Value.UnPack() : null);
			_o.ArmLength = this.ArmLength;
			_o.MinumArmLength = this.MinumArmLength;
			_o.MaxiumArmLength = this.MaxiumArmLength;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.ArmOffset = ((this.ArmOffset != null) ? this.ArmOffset.Value.UnPack() : null);
			_o.YawLimitMin = this.YawLimitMin;
			_o.YawLimitMax = this.YawLimitMax;
			_o.PitchLimitMin = this.PitchLimitMin;
			_o.PitchLimitMax = this.PitchLimitMax;
			_o.Fov = this.Fov;
			_o.IsDisableResetFocus = this.IsDisableResetFocus;
			_o.GravityDirection = new TGravityDirectionUnion();
			_o.GravityDirection.Type = this.GravityDirectionType;
			switch (this.GravityDirectionType)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionByEntityGravity>() != null) ? this.GravityDirection<IGravityDirectionByEntityGravity>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionSelfRotation:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionSelfRotation>() != null) ? this.GravityDirection<IGravityDirectionSelfRotation>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionVectorInfo:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionVectorInfo>() != null) ? this.GravityDirection<IGravityDirectionVectorInfo>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionWorldAxis:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionWorldAxis>() != null) ? this.GravityDirection<IGravityDirectionWorldAxis>().Value.UnPack() : null);
				break;
			}
			_o.IsDisableCollision = this.IsDisableCollision;
			_o.IsDisableDither = this.IsDisableDither;
			_o.SubScreenBindKey = this.SubScreenBindKey;
			_o.AxisRotate = ((this.AxisRotate != null) ? this.AxisRotate.Value.UnPack() : null);
			_o.IsLockRoll = this.IsLockRoll;
			_o.ScreenConfig = ((this.ScreenConfig != null) ? this.ScreenConfig.Value.UnPack() : null);
			_o.NearClipDistanceToTarget = this.NearClipDistanceToTarget;
			_o.SpringArmSoftZoneConfig = ((this.SpringArmSoftZoneConfig != null) ? this.SpringArmSoftZoneConfig.Value.UnPack() : null);
			_o.SpringArmFix = ((this.SpringArmFix != null) ? this.SpringArmFix.Value.UnPack() : null);
			_o.HidePlayer = this.HidePlayer;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D0D5 RID: 184533 RVA: 0x00628DE8 File Offset: 0x00626FE8
		public static Offset<IAdjustAxisLockCamera> Pack(FlatBufferBuilder builder, IAdjustAxisLockCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustAxisLockCamera>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			Offset<IBaseCurve> fadeOutCurveOffset = (_o.FadeOutCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeOutCurve);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> armOffsetOffset = (_o.ArmOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArmOffset);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			StringOffset subScreenBindKeyOffset = (_o.SubScreenBindKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenBindKey);
			Offset<IVectorInfo> axisRotateOffset = (_o.AxisRotate == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.AxisRotate);
			Offset<IAxisLockScreenConfig> screenConfigOffset = (_o.ScreenConfig == null) ? default(Offset<IAxisLockScreenConfig>) : IAxisLockScreenConfig.Pack(builder, _o.ScreenConfig);
			Offset<ISpringArmSoftZoneConfig> springArmSoftZoneConfigOffset = (_o.SpringArmSoftZoneConfig == null) ? default(Offset<ISpringArmSoftZoneConfig>) : ISpringArmSoftZoneConfig.Pack(builder, _o.SpringArmSoftZoneConfig);
			Offset<ISpringArmFixConfig> springArmFixOffset = (_o.SpringArmFix == null) ? default(Offset<ISpringArmFixConfig>) : ISpringArmFixConfig.Pack(builder, _o.SpringArmFix);
			return IAdjustAxisLockCamera.CreateIAdjustAxisLockCamera(builder, _o.Type, _o.Priority, _o.FadeInTime, fadeInCurveOffset, _o.FadeOutTime, fadeOutCurveOffset, _o.ArmLength, _o.MinumArmLength, _o.MaxiumArmLength, offsetOffset, armOffsetOffset, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.Fov, _o.IsDisableResetFocus, gravityDirection_type, gravityDirectionOffset, _o.IsDisableCollision, _o.IsDisableDither, subScreenBindKeyOffset, axisRotateOffset, _o.IsLockRoll, screenConfigOffset, _o.NearClipDistanceToTarget, springArmSoftZoneConfigOffset, springArmFixOffset, _o.HidePlayer, _o.NullMask);
		}

		// Token: 0x04011336 RID: 70454
		private Table __p;
	}
}
