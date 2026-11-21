using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C9 RID: 26569
	public struct IAdjustHorizontalCamera : IFlatbufferObject
	{
		// Token: 0x1700C2C5 RID: 49861
		// (get) Token: 0x0602D4AA RID: 185514 RVA: 0x006331B9 File Offset: 0x006313B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D4AB RID: 185515 RVA: 0x006331C6 File Offset: 0x006313C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D4AC RID: 185516 RVA: 0x006331D0 File Offset: 0x006313D0
		public static IAdjustHorizontalCamera GetRootAsIAdjustHorizontalCamera(ByteBuffer _bb)
		{
			return IAdjustHorizontalCamera.GetRootAsIAdjustHorizontalCamera(_bb, default(IAdjustHorizontalCamera));
		}

		// Token: 0x0602D4AD RID: 185517 RVA: 0x006331EC File Offset: 0x006313EC
		public static IAdjustHorizontalCamera GetRootAsIAdjustHorizontalCamera(ByteBuffer _bb, IAdjustHorizontalCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D4AE RID: 185518 RVA: 0x00633209 File Offset: 0x00631409
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D4AF RID: 185519 RVA: 0x00633218 File Offset: 0x00631418
		public IAdjustHorizontalCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2C6 RID: 49862
		// (get) Token: 0x0602D4B0 RID: 185520 RVA: 0x00633228 File Offset: 0x00631428
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

		// Token: 0x1700C2C7 RID: 49863
		// (get) Token: 0x0602D4B1 RID: 185521 RVA: 0x00633264 File Offset: 0x00631464
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

		// Token: 0x1700C2C8 RID: 49864
		// (get) Token: 0x0602D4B2 RID: 185522 RVA: 0x006332A0 File Offset: 0x006314A0
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

		// Token: 0x1700C2C9 RID: 49865
		// (get) Token: 0x0602D4B3 RID: 185523 RVA: 0x006332E0 File Offset: 0x006314E0
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

		// Token: 0x1700C2CA RID: 49866
		// (get) Token: 0x0602D4B4 RID: 185524 RVA: 0x00633340 File Offset: 0x00631540
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

		// Token: 0x1700C2CB RID: 49867
		// (get) Token: 0x0602D4B5 RID: 185525 RVA: 0x00633384 File Offset: 0x00631584
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

		// Token: 0x1700C2CC RID: 49868
		// (get) Token: 0x0602D4B6 RID: 185526 RVA: 0x006333E4 File Offset: 0x006315E4
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

		// Token: 0x1700C2CD RID: 49869
		// (get) Token: 0x0602D4B7 RID: 185527 RVA: 0x00633428 File Offset: 0x00631628
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

		// Token: 0x1700C2CE RID: 49870
		// (get) Token: 0x0602D4B8 RID: 185528 RVA: 0x0063346C File Offset: 0x0063166C
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

		// Token: 0x1700C2CF RID: 49871
		// (get) Token: 0x0602D4B9 RID: 185529 RVA: 0x006334B0 File Offset: 0x006316B0
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

		// Token: 0x1700C2D0 RID: 49872
		// (get) Token: 0x0602D4BA RID: 185530 RVA: 0x00633510 File Offset: 0x00631710
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

		// Token: 0x1700C2D1 RID: 49873
		// (get) Token: 0x0602D4BB RID: 185531 RVA: 0x00633570 File Offset: 0x00631770
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

		// Token: 0x1700C2D2 RID: 49874
		// (get) Token: 0x0602D4BC RID: 185532 RVA: 0x006335B4 File Offset: 0x006317B4
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

		// Token: 0x1700C2D3 RID: 49875
		// (get) Token: 0x0602D4BD RID: 185533 RVA: 0x006335F8 File Offset: 0x006317F8
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

		// Token: 0x1700C2D4 RID: 49876
		// (get) Token: 0x0602D4BE RID: 185534 RVA: 0x0063363C File Offset: 0x0063183C
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

		// Token: 0x1700C2D5 RID: 49877
		// (get) Token: 0x0602D4BF RID: 185535 RVA: 0x00633680 File Offset: 0x00631880
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

		// Token: 0x1700C2D6 RID: 49878
		// (get) Token: 0x0602D4C0 RID: 185536 RVA: 0x006336C4 File Offset: 0x006318C4
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2D7 RID: 49879
		// (get) Token: 0x0602D4C1 RID: 185537 RVA: 0x00633704 File Offset: 0x00631904
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

		// Token: 0x0602D4C2 RID: 185538 RVA: 0x00633744 File Offset: 0x00631944
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D4C3 RID: 185539 RVA: 0x0063378C File Offset: 0x0063198C
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602D4C4 RID: 185540 RVA: 0x006337A8 File Offset: 0x006319A8
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602D4C5 RID: 185541 RVA: 0x006337C4 File Offset: 0x006319C4
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602D4C6 RID: 185542 RVA: 0x006337E0 File Offset: 0x006319E0
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700C2D8 RID: 49880
		// (get) Token: 0x0602D4C7 RID: 185543 RVA: 0x006337FC File Offset: 0x006319FC
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2D9 RID: 49881
		// (get) Token: 0x0602D4C8 RID: 185544 RVA: 0x0063383C File Offset: 0x00631A3C
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2DA RID: 49882
		// (get) Token: 0x0602D4C9 RID: 185545 RVA: 0x0063387C File Offset: 0x00631A7C
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

		// Token: 0x0602D4CA RID: 185546 RVA: 0x006338B4 File Offset: 0x00631AB4
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602D4CB RID: 185547 RVA: 0x006338C4 File Offset: 0x00631AC4
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700C2DB RID: 49883
		// (get) Token: 0x0602D4CC RID: 185548 RVA: 0x006338D4 File Offset: 0x00631AD4
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C2DC RID: 49884
		// (get) Token: 0x0602D4CD RID: 185549 RVA: 0x00633914 File Offset: 0x00631B14
		public float YawAngle
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C2DD RID: 49885
		// (get) Token: 0x0602D4CE RID: 185550 RVA: 0x00633958 File Offset: 0x00631B58
		public float PitchAngle
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C2DE RID: 49886
		// (get) Token: 0x0602D4CF RID: 185551 RVA: 0x0063399C File Offset: 0x00631B9C
		public float RollAngle
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

		// Token: 0x1700C2DF RID: 49887
		// (get) Token: 0x0602D4D0 RID: 185552 RVA: 0x006339E0 File Offset: 0x00631BE0
		public ICameraDepthOfField? DepthOfField
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return new ICameraDepthOfField?(default(ICameraDepthOfField).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C2E0 RID: 49888
		// (get) Token: 0x0602D4D1 RID: 185553 RVA: 0x00633A40 File Offset: 0x00631C40
		public ICameraOffsetInMovementDirection? OffsetInMovementDirection
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return new ICameraOffsetInMovementDirection?(default(ICameraOffsetInMovementDirection).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C2E1 RID: 49889
		// (get) Token: 0x0602D4D2 RID: 185554 RVA: 0x00633AA0 File Offset: 0x00631CA0
		public float NearClipDistanceToTarget
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C2E2 RID: 49890
		// (get) Token: 0x0602D4D3 RID: 185555 RVA: 0x00633AE4 File Offset: 0x00631CE4
		public ISpringArmSoftZoneConfig? SpringArmSoftZoneConfig
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return new ISpringArmSoftZoneConfig?(default(ISpringArmSoftZoneConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C2E3 RID: 49891
		// (get) Token: 0x0602D4D4 RID: 185556 RVA: 0x00633B44 File Offset: 0x00631D44
		public ISpringArmFixConfig? SpringArmFix
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return new ISpringArmFixConfig?(default(ISpringArmFixConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C2E4 RID: 49892
		// (get) Token: 0x0602D4D5 RID: 185557 RVA: 0x00633BA4 File Offset: 0x00631DA4
		public bool IsCameraFollowSplineRoll
		{
			get
			{
				int num = this.__p.__offset(66);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2E5 RID: 49893
		// (get) Token: 0x0602D4D6 RID: 185558 RVA: 0x00633BE4 File Offset: 0x00631DE4
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D4D7 RID: 185559 RVA: 0x00633C24 File Offset: 0x00631E24
		public static Offset<IAdjustHorizontalCamera> CreateIAdjustHorizontalCamera(FlatBufferBuilder builder, EAdjustPlayerCamera Type = EAdjustPlayerCamera.Basic, int Priority = 0, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>), float FadeOutTime = 0f, Offset<IBaseCurve> FadeOutCurveOffset = default(Offset<IBaseCurve>), float ArmLength = 0f, float MinumArmLength = 0f, float MaxiumArmLength = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArmOffsetOffset = default(Offset<IVectorInfo>), float YawLimitMin = 0f, float YawLimitMax = 0f, float PitchLimitMin = 0f, float PitchLimitMax = 0f, float Fov = 0f, bool IsDisableResetFocus = false, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool IsDisableCollision = false, bool IsDisableDither = false, StringOffset SubScreenBindKeyOffset = default(StringOffset), int SplineEntityId = 0, float YawAngle = 0f, float PitchAngle = 0f, float RollAngle = 0f, Offset<ICameraDepthOfField> DepthOfFieldOffset = default(Offset<ICameraDepthOfField>), Offset<ICameraOffsetInMovementDirection> OffsetInMovementDirectionOffset = default(Offset<ICameraOffsetInMovementDirection>), float NearClipDistanceToTarget = 0f, Offset<ISpringArmSoftZoneConfig> SpringArmSoftZoneConfigOffset = default(Offset<ISpringArmSoftZoneConfig>), Offset<ISpringArmFixConfig> SpringArmFixOffset = default(Offset<ISpringArmFixConfig>), bool IsCameraFollowSplineRoll = false, ushort NullMask = 0)
		{
			builder.StartTable(33);
			IAdjustHorizontalCamera.AddSpringArmFix(builder, SpringArmFixOffset);
			IAdjustHorizontalCamera.AddSpringArmSoftZoneConfig(builder, SpringArmSoftZoneConfigOffset);
			IAdjustHorizontalCamera.AddNearClipDistanceToTarget(builder, NearClipDistanceToTarget);
			IAdjustHorizontalCamera.AddOffsetInMovementDirection(builder, OffsetInMovementDirectionOffset);
			IAdjustHorizontalCamera.AddDepthOfField(builder, DepthOfFieldOffset);
			IAdjustHorizontalCamera.AddRollAngle(builder, RollAngle);
			IAdjustHorizontalCamera.AddPitchAngle(builder, PitchAngle);
			IAdjustHorizontalCamera.AddYawAngle(builder, YawAngle);
			IAdjustHorizontalCamera.AddSplineEntityId(builder, SplineEntityId);
			IAdjustHorizontalCamera.AddSubScreenBindKey(builder, SubScreenBindKeyOffset);
			IAdjustHorizontalCamera.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustHorizontalCamera.AddFov(builder, Fov);
			IAdjustHorizontalCamera.AddPitchLimitMax(builder, PitchLimitMax);
			IAdjustHorizontalCamera.AddPitchLimitMin(builder, PitchLimitMin);
			IAdjustHorizontalCamera.AddYawLimitMax(builder, YawLimitMax);
			IAdjustHorizontalCamera.AddYawLimitMin(builder, YawLimitMin);
			IAdjustHorizontalCamera.AddArmOffset(builder, ArmOffsetOffset);
			IAdjustHorizontalCamera.AddOffset(builder, OffsetOffset);
			IAdjustHorizontalCamera.AddMaxiumArmLength(builder, MaxiumArmLength);
			IAdjustHorizontalCamera.AddMinumArmLength(builder, MinumArmLength);
			IAdjustHorizontalCamera.AddArmLength(builder, ArmLength);
			IAdjustHorizontalCamera.AddFadeOutCurve(builder, FadeOutCurveOffset);
			IAdjustHorizontalCamera.AddFadeOutTime(builder, FadeOutTime);
			IAdjustHorizontalCamera.AddFadeInCurve(builder, FadeInCurveOffset);
			IAdjustHorizontalCamera.AddFadeInTime(builder, FadeInTime);
			IAdjustHorizontalCamera.AddPriority(builder, Priority);
			IAdjustHorizontalCamera.AddNullMask(builder, NullMask);
			IAdjustHorizontalCamera.AddIsCameraFollowSplineRoll(builder, IsCameraFollowSplineRoll);
			IAdjustHorizontalCamera.AddIsDisableDither(builder, IsDisableDither);
			IAdjustHorizontalCamera.AddIsDisableCollision(builder, IsDisableCollision);
			IAdjustHorizontalCamera.AddGravityDirectionType(builder, GravityDirection_type);
			IAdjustHorizontalCamera.AddIsDisableResetFocus(builder, IsDisableResetFocus);
			IAdjustHorizontalCamera.AddType(builder, Type);
			return IAdjustHorizontalCamera.EndIAdjustHorizontalCamera(builder);
		}

		// Token: 0x0602D4D8 RID: 185560 RVA: 0x00633D44 File Offset: 0x00631F44
		public static void StartIAdjustHorizontalCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(33);
		}

		// Token: 0x0602D4D9 RID: 185561 RVA: 0x00633D4E File Offset: 0x00631F4E
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D4DA RID: 185562 RVA: 0x00633D59 File Offset: 0x00631F59
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602D4DB RID: 185563 RVA: 0x00633D64 File Offset: 0x00631F64
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602D4DC RID: 185564 RVA: 0x00633D77 File Offset: 0x00631F77
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602D4DD RID: 185565 RVA: 0x00633D87 File Offset: 0x00631F87
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602D4DE RID: 185566 RVA: 0x00633D9A File Offset: 0x00631F9A
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602D4DF RID: 185567 RVA: 0x00633DAA File Offset: 0x00631FAA
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602D4E0 RID: 185568 RVA: 0x00633DBD File Offset: 0x00631FBD
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602D4E1 RID: 185569 RVA: 0x00633DD0 File Offset: 0x00631FD0
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602D4E2 RID: 185570 RVA: 0x00633DE3 File Offset: 0x00631FE3
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602D4E3 RID: 185571 RVA: 0x00633DF4 File Offset: 0x00631FF4
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602D4E4 RID: 185572 RVA: 0x00633E05 File Offset: 0x00632005
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602D4E5 RID: 185573 RVA: 0x00633E19 File Offset: 0x00632019
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602D4E6 RID: 185574 RVA: 0x00633E2D File Offset: 0x0063202D
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602D4E7 RID: 185575 RVA: 0x00633E41 File Offset: 0x00632041
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602D4E8 RID: 185576 RVA: 0x00633E55 File Offset: 0x00632055
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602D4E9 RID: 185577 RVA: 0x00633E69 File Offset: 0x00632069
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602D4EA RID: 185578 RVA: 0x00633E75 File Offset: 0x00632075
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602D4EB RID: 185579 RVA: 0x00633E81 File Offset: 0x00632081
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602D4EC RID: 185580 RVA: 0x00633E8D File Offset: 0x0063208D
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602D4ED RID: 185581 RVA: 0x00633E99 File Offset: 0x00632099
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602D4EE RID: 185582 RVA: 0x00633EA5 File Offset: 0x006320A5
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602D4EF RID: 185583 RVA: 0x00633EB6 File Offset: 0x006320B6
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(22, splineEntityId, 0);
		}

		// Token: 0x0602D4F0 RID: 185584 RVA: 0x00633EC2 File Offset: 0x006320C2
		public static void AddYawAngle(FlatBufferBuilder builder, float yawAngle)
		{
			builder.AddFloat(23, yawAngle, 0.0);
		}

		// Token: 0x0602D4F1 RID: 185585 RVA: 0x00633ED6 File Offset: 0x006320D6
		public static void AddPitchAngle(FlatBufferBuilder builder, float pitchAngle)
		{
			builder.AddFloat(24, pitchAngle, 0.0);
		}

		// Token: 0x0602D4F2 RID: 185586 RVA: 0x00633EEA File Offset: 0x006320EA
		public static void AddRollAngle(FlatBufferBuilder builder, float rollAngle)
		{
			builder.AddFloat(25, rollAngle, 0.0);
		}

		// Token: 0x0602D4F3 RID: 185587 RVA: 0x00633EFE File Offset: 0x006320FE
		public static void AddDepthOfField(FlatBufferBuilder builder, Offset<ICameraDepthOfField> depthOfFieldOffset)
		{
			builder.AddOffset(26, depthOfFieldOffset.Value, 0);
		}

		// Token: 0x0602D4F4 RID: 185588 RVA: 0x00633F0F File Offset: 0x0063210F
		public static void AddOffsetInMovementDirection(FlatBufferBuilder builder, Offset<ICameraOffsetInMovementDirection> offsetInMovementDirectionOffset)
		{
			builder.AddOffset(27, offsetInMovementDirectionOffset.Value, 0);
		}

		// Token: 0x0602D4F5 RID: 185589 RVA: 0x00633F20 File Offset: 0x00632120
		public static void AddNearClipDistanceToTarget(FlatBufferBuilder builder, float nearClipDistanceToTarget)
		{
			builder.AddFloat(28, nearClipDistanceToTarget, 0.0);
		}

		// Token: 0x0602D4F6 RID: 185590 RVA: 0x00633F34 File Offset: 0x00632134
		public static void AddSpringArmSoftZoneConfig(FlatBufferBuilder builder, Offset<ISpringArmSoftZoneConfig> springArmSoftZoneConfigOffset)
		{
			builder.AddOffset(29, springArmSoftZoneConfigOffset.Value, 0);
		}

		// Token: 0x0602D4F7 RID: 185591 RVA: 0x00633F45 File Offset: 0x00632145
		public static void AddSpringArmFix(FlatBufferBuilder builder, Offset<ISpringArmFixConfig> springArmFixOffset)
		{
			builder.AddOffset(30, springArmFixOffset.Value, 0);
		}

		// Token: 0x0602D4F8 RID: 185592 RVA: 0x00633F56 File Offset: 0x00632156
		public static void AddIsCameraFollowSplineRoll(FlatBufferBuilder builder, bool isCameraFollowSplineRoll)
		{
			builder.AddBool(31, isCameraFollowSplineRoll, false);
		}

		// Token: 0x0602D4F9 RID: 185593 RVA: 0x00633F62 File Offset: 0x00632162
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(32, nullMask, 0);
		}

		// Token: 0x0602D4FA RID: 185594 RVA: 0x00633F6E File Offset: 0x0063216E
		public static Offset<IAdjustHorizontalCamera> EndIAdjustHorizontalCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustHorizontalCamera>(builder.EndTable());
		}

		// Token: 0x0602D4FB RID: 185595 RVA: 0x00633F7C File Offset: 0x0063217C
		public IAdjustHorizontalCameraT UnPack()
		{
			IAdjustHorizontalCameraT adjustHorizontalCameraT = new IAdjustHorizontalCameraT();
			this.UnPackTo(adjustHorizontalCameraT);
			return adjustHorizontalCameraT;
		}

		// Token: 0x0602D4FC RID: 185596 RVA: 0x00633F98 File Offset: 0x00632198
		public void UnPackTo(IAdjustHorizontalCameraT _o)
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
			_o.SplineEntityId = this.SplineEntityId;
			_o.YawAngle = this.YawAngle;
			_o.PitchAngle = this.PitchAngle;
			_o.RollAngle = this.RollAngle;
			_o.DepthOfField = ((this.DepthOfField != null) ? this.DepthOfField.Value.UnPack() : null);
			_o.OffsetInMovementDirection = ((this.OffsetInMovementDirection != null) ? this.OffsetInMovementDirection.Value.UnPack() : null);
			_o.NearClipDistanceToTarget = this.NearClipDistanceToTarget;
			_o.SpringArmSoftZoneConfig = ((this.SpringArmSoftZoneConfig != null) ? this.SpringArmSoftZoneConfig.Value.UnPack() : null);
			_o.SpringArmFix = ((this.SpringArmFix != null) ? this.SpringArmFix.Value.UnPack() : null);
			_o.IsCameraFollowSplineRoll = this.IsCameraFollowSplineRoll;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D4FD RID: 185597 RVA: 0x00634364 File Offset: 0x00632564
		public static Offset<IAdjustHorizontalCamera> Pack(FlatBufferBuilder builder, IAdjustHorizontalCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustHorizontalCamera>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			Offset<IBaseCurve> fadeOutCurveOffset = (_o.FadeOutCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeOutCurve);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> armOffsetOffset = (_o.ArmOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArmOffset);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			StringOffset subScreenBindKeyOffset = (_o.SubScreenBindKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenBindKey);
			Offset<ICameraDepthOfField> depthOfFieldOffset = (_o.DepthOfField == null) ? default(Offset<ICameraDepthOfField>) : ICameraDepthOfField.Pack(builder, _o.DepthOfField);
			Offset<ICameraOffsetInMovementDirection> offsetInMovementDirectionOffset = (_o.OffsetInMovementDirection == null) ? default(Offset<ICameraOffsetInMovementDirection>) : ICameraOffsetInMovementDirection.Pack(builder, _o.OffsetInMovementDirection);
			Offset<ISpringArmSoftZoneConfig> springArmSoftZoneConfigOffset = (_o.SpringArmSoftZoneConfig == null) ? default(Offset<ISpringArmSoftZoneConfig>) : ISpringArmSoftZoneConfig.Pack(builder, _o.SpringArmSoftZoneConfig);
			Offset<ISpringArmFixConfig> springArmFixOffset = (_o.SpringArmFix == null) ? default(Offset<ISpringArmFixConfig>) : ISpringArmFixConfig.Pack(builder, _o.SpringArmFix);
			return IAdjustHorizontalCamera.CreateIAdjustHorizontalCamera(builder, _o.Type, _o.Priority, _o.FadeInTime, fadeInCurveOffset, _o.FadeOutTime, fadeOutCurveOffset, _o.ArmLength, _o.MinumArmLength, _o.MaxiumArmLength, offsetOffset, armOffsetOffset, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.Fov, _o.IsDisableResetFocus, gravityDirection_type, gravityDirectionOffset, _o.IsDisableCollision, _o.IsDisableDither, subScreenBindKeyOffset, _o.SplineEntityId, _o.YawAngle, _o.PitchAngle, _o.RollAngle, depthOfFieldOffset, offsetInMovementDirectionOffset, _o.NearClipDistanceToTarget, springArmSoftZoneConfigOffset, springArmFixOffset, _o.IsCameraFollowSplineRoll, _o.NullMask);
		}

		// Token: 0x04011414 RID: 70676
		private Table __p;
	}
}
