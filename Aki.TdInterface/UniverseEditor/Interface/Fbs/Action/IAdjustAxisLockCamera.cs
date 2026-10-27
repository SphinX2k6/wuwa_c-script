using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006140 RID: 24896
	public struct IAdjustAxisLockCamera : IFlatbufferObject
	{
		// Token: 0x1700B7AE RID: 47022
		// (get) Token: 0x0602A98F RID: 174479 RVA: 0x005DDBA8 File Offset: 0x005DBDA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A990 RID: 174480 RVA: 0x005DDBB5 File Offset: 0x005DBDB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A991 RID: 174481 RVA: 0x005DDBBC File Offset: 0x005DBDBC
		public static IAdjustAxisLockCamera GetRootAsIAdjustAxisLockCamera(ByteBuffer _bb)
		{
			return IAdjustAxisLockCamera.GetRootAsIAdjustAxisLockCamera(_bb, default(IAdjustAxisLockCamera));
		}

		// Token: 0x0602A992 RID: 174482 RVA: 0x005DDBD8 File Offset: 0x005DBDD8
		public static IAdjustAxisLockCamera GetRootAsIAdjustAxisLockCamera(ByteBuffer _bb, IAdjustAxisLockCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A993 RID: 174483 RVA: 0x005DDBF5 File Offset: 0x005DBDF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A994 RID: 174484 RVA: 0x005DDC04 File Offset: 0x005DBE04
		public IAdjustAxisLockCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7AF RID: 47023
		// (get) Token: 0x0602A995 RID: 174485 RVA: 0x005DDC14 File Offset: 0x005DBE14
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

		// Token: 0x1700B7B0 RID: 47024
		// (get) Token: 0x0602A996 RID: 174486 RVA: 0x005DDC50 File Offset: 0x005DBE50
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

		// Token: 0x1700B7B1 RID: 47025
		// (get) Token: 0x0602A997 RID: 174487 RVA: 0x005DDC8C File Offset: 0x005DBE8C
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

		// Token: 0x1700B7B2 RID: 47026
		// (get) Token: 0x0602A998 RID: 174488 RVA: 0x005DDCCC File Offset: 0x005DBECC
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

		// Token: 0x1700B7B3 RID: 47027
		// (get) Token: 0x0602A999 RID: 174489 RVA: 0x005DDD2C File Offset: 0x005DBF2C
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

		// Token: 0x1700B7B4 RID: 47028
		// (get) Token: 0x0602A99A RID: 174490 RVA: 0x005DDD70 File Offset: 0x005DBF70
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

		// Token: 0x1700B7B5 RID: 47029
		// (get) Token: 0x0602A99B RID: 174491 RVA: 0x005DDDD0 File Offset: 0x005DBFD0
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

		// Token: 0x1700B7B6 RID: 47030
		// (get) Token: 0x0602A99C RID: 174492 RVA: 0x005DDE14 File Offset: 0x005DC014
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

		// Token: 0x1700B7B7 RID: 47031
		// (get) Token: 0x0602A99D RID: 174493 RVA: 0x005DDE58 File Offset: 0x005DC058
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

		// Token: 0x1700B7B8 RID: 47032
		// (get) Token: 0x0602A99E RID: 174494 RVA: 0x005DDE9C File Offset: 0x005DC09C
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

		// Token: 0x1700B7B9 RID: 47033
		// (get) Token: 0x0602A99F RID: 174495 RVA: 0x005DDEFC File Offset: 0x005DC0FC
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

		// Token: 0x1700B7BA RID: 47034
		// (get) Token: 0x0602A9A0 RID: 174496 RVA: 0x005DDF5C File Offset: 0x005DC15C
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

		// Token: 0x1700B7BB RID: 47035
		// (get) Token: 0x0602A9A1 RID: 174497 RVA: 0x005DDFA0 File Offset: 0x005DC1A0
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

		// Token: 0x1700B7BC RID: 47036
		// (get) Token: 0x0602A9A2 RID: 174498 RVA: 0x005DDFE4 File Offset: 0x005DC1E4
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

		// Token: 0x1700B7BD RID: 47037
		// (get) Token: 0x0602A9A3 RID: 174499 RVA: 0x005DE028 File Offset: 0x005DC228
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

		// Token: 0x1700B7BE RID: 47038
		// (get) Token: 0x0602A9A4 RID: 174500 RVA: 0x005DE06C File Offset: 0x005DC26C
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

		// Token: 0x1700B7BF RID: 47039
		// (get) Token: 0x0602A9A5 RID: 174501 RVA: 0x005DE0B0 File Offset: 0x005DC2B0
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B7C0 RID: 47040
		// (get) Token: 0x0602A9A6 RID: 174502 RVA: 0x005DE0F0 File Offset: 0x005DC2F0
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

		// Token: 0x0602A9A7 RID: 174503 RVA: 0x005DE130 File Offset: 0x005DC330
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A9A8 RID: 174504 RVA: 0x005DE178 File Offset: 0x005DC378
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602A9A9 RID: 174505 RVA: 0x005DE194 File Offset: 0x005DC394
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602A9AA RID: 174506 RVA: 0x005DE1B0 File Offset: 0x005DC3B0
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602A9AB RID: 174507 RVA: 0x005DE1CC File Offset: 0x005DC3CC
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700B7C1 RID: 47041
		// (get) Token: 0x0602A9AC RID: 174508 RVA: 0x005DE1E8 File Offset: 0x005DC3E8
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B7C2 RID: 47042
		// (get) Token: 0x0602A9AD RID: 174509 RVA: 0x005DE228 File Offset: 0x005DC428
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B7C3 RID: 47043
		// (get) Token: 0x0602A9AE RID: 174510 RVA: 0x005DE268 File Offset: 0x005DC468
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

		// Token: 0x0602A9AF RID: 174511 RVA: 0x005DE2A0 File Offset: 0x005DC4A0
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602A9B0 RID: 174512 RVA: 0x005DE2B0 File Offset: 0x005DC4B0
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700B7C4 RID: 47044
		// (get) Token: 0x0602A9B1 RID: 174513 RVA: 0x005DE2C0 File Offset: 0x005DC4C0
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

		// Token: 0x1700B7C5 RID: 47045
		// (get) Token: 0x0602A9B2 RID: 174514 RVA: 0x005DE320 File Offset: 0x005DC520
		public bool IsLockRoll
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B7C6 RID: 47046
		// (get) Token: 0x0602A9B3 RID: 174515 RVA: 0x005DE360 File Offset: 0x005DC560
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

		// Token: 0x1700B7C7 RID: 47047
		// (get) Token: 0x0602A9B4 RID: 174516 RVA: 0x005DE3C0 File Offset: 0x005DC5C0
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

		// Token: 0x1700B7C8 RID: 47048
		// (get) Token: 0x0602A9B5 RID: 174517 RVA: 0x005DE404 File Offset: 0x005DC604
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

		// Token: 0x1700B7C9 RID: 47049
		// (get) Token: 0x0602A9B6 RID: 174518 RVA: 0x005DE464 File Offset: 0x005DC664
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

		// Token: 0x1700B7CA RID: 47050
		// (get) Token: 0x0602A9B7 RID: 174519 RVA: 0x005DE4C4 File Offset: 0x005DC6C4
		public bool HidePlayer
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B7CB RID: 47051
		// (get) Token: 0x0602A9B8 RID: 174520 RVA: 0x005DE504 File Offset: 0x005DC704
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

		// Token: 0x0602A9B9 RID: 174521 RVA: 0x005DE544 File Offset: 0x005DC744
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

		// Token: 0x0602A9BA RID: 174522 RVA: 0x005DE64C File Offset: 0x005DC84C
		public static void StartIAdjustAxisLockCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(30);
		}

		// Token: 0x0602A9BB RID: 174523 RVA: 0x005DE656 File Offset: 0x005DC856
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A9BC RID: 174524 RVA: 0x005DE661 File Offset: 0x005DC861
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602A9BD RID: 174525 RVA: 0x005DE66C File Offset: 0x005DC86C
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602A9BE RID: 174526 RVA: 0x005DE67F File Offset: 0x005DC87F
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602A9BF RID: 174527 RVA: 0x005DE68F File Offset: 0x005DC88F
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602A9C0 RID: 174528 RVA: 0x005DE6A2 File Offset: 0x005DC8A2
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602A9C1 RID: 174529 RVA: 0x005DE6B2 File Offset: 0x005DC8B2
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602A9C2 RID: 174530 RVA: 0x005DE6C5 File Offset: 0x005DC8C5
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602A9C3 RID: 174531 RVA: 0x005DE6D8 File Offset: 0x005DC8D8
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602A9C4 RID: 174532 RVA: 0x005DE6EB File Offset: 0x005DC8EB
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602A9C5 RID: 174533 RVA: 0x005DE6FC File Offset: 0x005DC8FC
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602A9C6 RID: 174534 RVA: 0x005DE70D File Offset: 0x005DC90D
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602A9C7 RID: 174535 RVA: 0x005DE721 File Offset: 0x005DC921
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602A9C8 RID: 174536 RVA: 0x005DE735 File Offset: 0x005DC935
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602A9C9 RID: 174537 RVA: 0x005DE749 File Offset: 0x005DC949
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602A9CA RID: 174538 RVA: 0x005DE75D File Offset: 0x005DC95D
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602A9CB RID: 174539 RVA: 0x005DE771 File Offset: 0x005DC971
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602A9CC RID: 174540 RVA: 0x005DE77D File Offset: 0x005DC97D
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602A9CD RID: 174541 RVA: 0x005DE789 File Offset: 0x005DC989
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602A9CE RID: 174542 RVA: 0x005DE795 File Offset: 0x005DC995
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602A9CF RID: 174543 RVA: 0x005DE7A1 File Offset: 0x005DC9A1
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602A9D0 RID: 174544 RVA: 0x005DE7AD File Offset: 0x005DC9AD
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602A9D1 RID: 174545 RVA: 0x005DE7BE File Offset: 0x005DC9BE
		public static void AddAxisRotate(FlatBufferBuilder builder, Offset<IVectorInfo> axisRotateOffset)
		{
			builder.AddOffset(22, axisRotateOffset.Value, 0);
		}

		// Token: 0x0602A9D2 RID: 174546 RVA: 0x005DE7CF File Offset: 0x005DC9CF
		public static void AddIsLockRoll(FlatBufferBuilder builder, bool isLockRoll)
		{
			builder.AddBool(23, isLockRoll, false);
		}

		// Token: 0x0602A9D3 RID: 174547 RVA: 0x005DE7DB File Offset: 0x005DC9DB
		public static void AddScreenConfig(FlatBufferBuilder builder, Offset<IAxisLockScreenConfig> screenConfigOffset)
		{
			builder.AddOffset(24, screenConfigOffset.Value, 0);
		}

		// Token: 0x0602A9D4 RID: 174548 RVA: 0x005DE7EC File Offset: 0x005DC9EC
		public static void AddNearClipDistanceToTarget(FlatBufferBuilder builder, float nearClipDistanceToTarget)
		{
			builder.AddFloat(25, nearClipDistanceToTarget, 0.0);
		}

		// Token: 0x0602A9D5 RID: 174549 RVA: 0x005DE800 File Offset: 0x005DCA00
		public static void AddSpringArmSoftZoneConfig(FlatBufferBuilder builder, Offset<ISpringArmSoftZoneConfig> springArmSoftZoneConfigOffset)
		{
			builder.AddOffset(26, springArmSoftZoneConfigOffset.Value, 0);
		}

		// Token: 0x0602A9D6 RID: 174550 RVA: 0x005DE811 File Offset: 0x005DCA11
		public static void AddSpringArmFix(FlatBufferBuilder builder, Offset<ISpringArmFixConfig> springArmFixOffset)
		{
			builder.AddOffset(27, springArmFixOffset.Value, 0);
		}

		// Token: 0x0602A9D7 RID: 174551 RVA: 0x005DE822 File Offset: 0x005DCA22
		public static void AddHidePlayer(FlatBufferBuilder builder, bool hidePlayer)
		{
			builder.AddBool(28, hidePlayer, false);
		}

		// Token: 0x0602A9D8 RID: 174552 RVA: 0x005DE82E File Offset: 0x005DCA2E
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(29, nullMask, 0);
		}

		// Token: 0x0602A9D9 RID: 174553 RVA: 0x005DE83A File Offset: 0x005DCA3A
		public static Offset<IAdjustAxisLockCamera> EndIAdjustAxisLockCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustAxisLockCamera>(builder.EndTable());
		}

		// Token: 0x0602A9DA RID: 174554 RVA: 0x005DE848 File Offset: 0x005DCA48
		public IAdjustAxisLockCameraT UnPack()
		{
			IAdjustAxisLockCameraT adjustAxisLockCameraT = new IAdjustAxisLockCameraT();
			this.UnPackTo(adjustAxisLockCameraT);
			return adjustAxisLockCameraT;
		}

		// Token: 0x0602A9DB RID: 174555 RVA: 0x005DE864 File Offset: 0x005DCA64
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

		// Token: 0x0602A9DC RID: 174556 RVA: 0x005DEC0C File Offset: 0x005DCE0C
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

		// Token: 0x0401052F RID: 66863
		private Table __p;
	}
}
