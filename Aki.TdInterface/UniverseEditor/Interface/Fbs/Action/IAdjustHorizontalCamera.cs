using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006164 RID: 24932
	public struct IAdjustHorizontalCamera : IFlatbufferObject
	{
		// Token: 0x1700B955 RID: 47445
		// (get) Token: 0x0602ADB1 RID: 175537 RVA: 0x005E8FDD File Offset: 0x005E71DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ADB2 RID: 175538 RVA: 0x005E8FEA File Offset: 0x005E71EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ADB3 RID: 175539 RVA: 0x005E8FF4 File Offset: 0x005E71F4
		public static IAdjustHorizontalCamera GetRootAsIAdjustHorizontalCamera(ByteBuffer _bb)
		{
			return IAdjustHorizontalCamera.GetRootAsIAdjustHorizontalCamera(_bb, default(IAdjustHorizontalCamera));
		}

		// Token: 0x0602ADB4 RID: 175540 RVA: 0x005E9010 File Offset: 0x005E7210
		public static IAdjustHorizontalCamera GetRootAsIAdjustHorizontalCamera(ByteBuffer _bb, IAdjustHorizontalCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ADB5 RID: 175541 RVA: 0x005E902D File Offset: 0x005E722D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ADB6 RID: 175542 RVA: 0x005E903C File Offset: 0x005E723C
		public IAdjustHorizontalCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B956 RID: 47446
		// (get) Token: 0x0602ADB7 RID: 175543 RVA: 0x005E904C File Offset: 0x005E724C
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

		// Token: 0x1700B957 RID: 47447
		// (get) Token: 0x0602ADB8 RID: 175544 RVA: 0x005E9088 File Offset: 0x005E7288
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

		// Token: 0x1700B958 RID: 47448
		// (get) Token: 0x0602ADB9 RID: 175545 RVA: 0x005E90C4 File Offset: 0x005E72C4
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

		// Token: 0x1700B959 RID: 47449
		// (get) Token: 0x0602ADBA RID: 175546 RVA: 0x005E9104 File Offset: 0x005E7304
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

		// Token: 0x1700B95A RID: 47450
		// (get) Token: 0x0602ADBB RID: 175547 RVA: 0x005E9164 File Offset: 0x005E7364
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

		// Token: 0x1700B95B RID: 47451
		// (get) Token: 0x0602ADBC RID: 175548 RVA: 0x005E91A8 File Offset: 0x005E73A8
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

		// Token: 0x1700B95C RID: 47452
		// (get) Token: 0x0602ADBD RID: 175549 RVA: 0x005E9208 File Offset: 0x005E7408
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

		// Token: 0x1700B95D RID: 47453
		// (get) Token: 0x0602ADBE RID: 175550 RVA: 0x005E924C File Offset: 0x005E744C
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

		// Token: 0x1700B95E RID: 47454
		// (get) Token: 0x0602ADBF RID: 175551 RVA: 0x005E9290 File Offset: 0x005E7490
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

		// Token: 0x1700B95F RID: 47455
		// (get) Token: 0x0602ADC0 RID: 175552 RVA: 0x005E92D4 File Offset: 0x005E74D4
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

		// Token: 0x1700B960 RID: 47456
		// (get) Token: 0x0602ADC1 RID: 175553 RVA: 0x005E9334 File Offset: 0x005E7534
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

		// Token: 0x1700B961 RID: 47457
		// (get) Token: 0x0602ADC2 RID: 175554 RVA: 0x005E9394 File Offset: 0x005E7594
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

		// Token: 0x1700B962 RID: 47458
		// (get) Token: 0x0602ADC3 RID: 175555 RVA: 0x005E93D8 File Offset: 0x005E75D8
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

		// Token: 0x1700B963 RID: 47459
		// (get) Token: 0x0602ADC4 RID: 175556 RVA: 0x005E941C File Offset: 0x005E761C
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

		// Token: 0x1700B964 RID: 47460
		// (get) Token: 0x0602ADC5 RID: 175557 RVA: 0x005E9460 File Offset: 0x005E7660
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

		// Token: 0x1700B965 RID: 47461
		// (get) Token: 0x0602ADC6 RID: 175558 RVA: 0x005E94A4 File Offset: 0x005E76A4
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

		// Token: 0x1700B966 RID: 47462
		// (get) Token: 0x0602ADC7 RID: 175559 RVA: 0x005E94E8 File Offset: 0x005E76E8
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B967 RID: 47463
		// (get) Token: 0x0602ADC8 RID: 175560 RVA: 0x005E9528 File Offset: 0x005E7728
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

		// Token: 0x0602ADC9 RID: 175561 RVA: 0x005E9568 File Offset: 0x005E7768
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602ADCA RID: 175562 RVA: 0x005E95B0 File Offset: 0x005E77B0
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602ADCB RID: 175563 RVA: 0x005E95CC File Offset: 0x005E77CC
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602ADCC RID: 175564 RVA: 0x005E95E8 File Offset: 0x005E77E8
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602ADCD RID: 175565 RVA: 0x005E9604 File Offset: 0x005E7804
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700B968 RID: 47464
		// (get) Token: 0x0602ADCE RID: 175566 RVA: 0x005E9620 File Offset: 0x005E7820
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B969 RID: 47465
		// (get) Token: 0x0602ADCF RID: 175567 RVA: 0x005E9660 File Offset: 0x005E7860
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B96A RID: 47466
		// (get) Token: 0x0602ADD0 RID: 175568 RVA: 0x005E96A0 File Offset: 0x005E78A0
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

		// Token: 0x0602ADD1 RID: 175569 RVA: 0x005E96D8 File Offset: 0x005E78D8
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602ADD2 RID: 175570 RVA: 0x005E96E8 File Offset: 0x005E78E8
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700B96B RID: 47467
		// (get) Token: 0x0602ADD3 RID: 175571 RVA: 0x005E96F8 File Offset: 0x005E78F8
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

		// Token: 0x1700B96C RID: 47468
		// (get) Token: 0x0602ADD4 RID: 175572 RVA: 0x005E9738 File Offset: 0x005E7938
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

		// Token: 0x1700B96D RID: 47469
		// (get) Token: 0x0602ADD5 RID: 175573 RVA: 0x005E977C File Offset: 0x005E797C
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

		// Token: 0x1700B96E RID: 47470
		// (get) Token: 0x0602ADD6 RID: 175574 RVA: 0x005E97C0 File Offset: 0x005E79C0
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

		// Token: 0x1700B96F RID: 47471
		// (get) Token: 0x0602ADD7 RID: 175575 RVA: 0x005E9804 File Offset: 0x005E7A04
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

		// Token: 0x1700B970 RID: 47472
		// (get) Token: 0x0602ADD8 RID: 175576 RVA: 0x005E9864 File Offset: 0x005E7A64
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

		// Token: 0x1700B971 RID: 47473
		// (get) Token: 0x0602ADD9 RID: 175577 RVA: 0x005E98C4 File Offset: 0x005E7AC4
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

		// Token: 0x1700B972 RID: 47474
		// (get) Token: 0x0602ADDA RID: 175578 RVA: 0x005E9908 File Offset: 0x005E7B08
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

		// Token: 0x1700B973 RID: 47475
		// (get) Token: 0x0602ADDB RID: 175579 RVA: 0x005E9968 File Offset: 0x005E7B68
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

		// Token: 0x1700B974 RID: 47476
		// (get) Token: 0x0602ADDC RID: 175580 RVA: 0x005E99C8 File Offset: 0x005E7BC8
		public bool IsCameraFollowSplineRoll
		{
			get
			{
				int num = this.__p.__offset(66);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B975 RID: 47477
		// (get) Token: 0x0602ADDD RID: 175581 RVA: 0x005E9A08 File Offset: 0x005E7C08
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

		// Token: 0x0602ADDE RID: 175582 RVA: 0x005E9A48 File Offset: 0x005E7C48
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

		// Token: 0x0602ADDF RID: 175583 RVA: 0x005E9B68 File Offset: 0x005E7D68
		public static void StartIAdjustHorizontalCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(33);
		}

		// Token: 0x0602ADE0 RID: 175584 RVA: 0x005E9B72 File Offset: 0x005E7D72
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ADE1 RID: 175585 RVA: 0x005E9B7D File Offset: 0x005E7D7D
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602ADE2 RID: 175586 RVA: 0x005E9B88 File Offset: 0x005E7D88
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602ADE3 RID: 175587 RVA: 0x005E9B9B File Offset: 0x005E7D9B
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602ADE4 RID: 175588 RVA: 0x005E9BAB File Offset: 0x005E7DAB
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602ADE5 RID: 175589 RVA: 0x005E9BBE File Offset: 0x005E7DBE
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602ADE6 RID: 175590 RVA: 0x005E9BCE File Offset: 0x005E7DCE
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602ADE7 RID: 175591 RVA: 0x005E9BE1 File Offset: 0x005E7DE1
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602ADE8 RID: 175592 RVA: 0x005E9BF4 File Offset: 0x005E7DF4
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602ADE9 RID: 175593 RVA: 0x005E9C07 File Offset: 0x005E7E07
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602ADEA RID: 175594 RVA: 0x005E9C18 File Offset: 0x005E7E18
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602ADEB RID: 175595 RVA: 0x005E9C29 File Offset: 0x005E7E29
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602ADEC RID: 175596 RVA: 0x005E9C3D File Offset: 0x005E7E3D
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602ADED RID: 175597 RVA: 0x005E9C51 File Offset: 0x005E7E51
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602ADEE RID: 175598 RVA: 0x005E9C65 File Offset: 0x005E7E65
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602ADEF RID: 175599 RVA: 0x005E9C79 File Offset: 0x005E7E79
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602ADF0 RID: 175600 RVA: 0x005E9C8D File Offset: 0x005E7E8D
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602ADF1 RID: 175601 RVA: 0x005E9C99 File Offset: 0x005E7E99
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602ADF2 RID: 175602 RVA: 0x005E9CA5 File Offset: 0x005E7EA5
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602ADF3 RID: 175603 RVA: 0x005E9CB1 File Offset: 0x005E7EB1
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602ADF4 RID: 175604 RVA: 0x005E9CBD File Offset: 0x005E7EBD
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602ADF5 RID: 175605 RVA: 0x005E9CC9 File Offset: 0x005E7EC9
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602ADF6 RID: 175606 RVA: 0x005E9CDA File Offset: 0x005E7EDA
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(22, splineEntityId, 0);
		}

		// Token: 0x0602ADF7 RID: 175607 RVA: 0x005E9CE6 File Offset: 0x005E7EE6
		public static void AddYawAngle(FlatBufferBuilder builder, float yawAngle)
		{
			builder.AddFloat(23, yawAngle, 0.0);
		}

		// Token: 0x0602ADF8 RID: 175608 RVA: 0x005E9CFA File Offset: 0x005E7EFA
		public static void AddPitchAngle(FlatBufferBuilder builder, float pitchAngle)
		{
			builder.AddFloat(24, pitchAngle, 0.0);
		}

		// Token: 0x0602ADF9 RID: 175609 RVA: 0x005E9D0E File Offset: 0x005E7F0E
		public static void AddRollAngle(FlatBufferBuilder builder, float rollAngle)
		{
			builder.AddFloat(25, rollAngle, 0.0);
		}

		// Token: 0x0602ADFA RID: 175610 RVA: 0x005E9D22 File Offset: 0x005E7F22
		public static void AddDepthOfField(FlatBufferBuilder builder, Offset<ICameraDepthOfField> depthOfFieldOffset)
		{
			builder.AddOffset(26, depthOfFieldOffset.Value, 0);
		}

		// Token: 0x0602ADFB RID: 175611 RVA: 0x005E9D33 File Offset: 0x005E7F33
		public static void AddOffsetInMovementDirection(FlatBufferBuilder builder, Offset<ICameraOffsetInMovementDirection> offsetInMovementDirectionOffset)
		{
			builder.AddOffset(27, offsetInMovementDirectionOffset.Value, 0);
		}

		// Token: 0x0602ADFC RID: 175612 RVA: 0x005E9D44 File Offset: 0x005E7F44
		public static void AddNearClipDistanceToTarget(FlatBufferBuilder builder, float nearClipDistanceToTarget)
		{
			builder.AddFloat(28, nearClipDistanceToTarget, 0.0);
		}

		// Token: 0x0602ADFD RID: 175613 RVA: 0x005E9D58 File Offset: 0x005E7F58
		public static void AddSpringArmSoftZoneConfig(FlatBufferBuilder builder, Offset<ISpringArmSoftZoneConfig> springArmSoftZoneConfigOffset)
		{
			builder.AddOffset(29, springArmSoftZoneConfigOffset.Value, 0);
		}

		// Token: 0x0602ADFE RID: 175614 RVA: 0x005E9D69 File Offset: 0x005E7F69
		public static void AddSpringArmFix(FlatBufferBuilder builder, Offset<ISpringArmFixConfig> springArmFixOffset)
		{
			builder.AddOffset(30, springArmFixOffset.Value, 0);
		}

		// Token: 0x0602ADFF RID: 175615 RVA: 0x005E9D7A File Offset: 0x005E7F7A
		public static void AddIsCameraFollowSplineRoll(FlatBufferBuilder builder, bool isCameraFollowSplineRoll)
		{
			builder.AddBool(31, isCameraFollowSplineRoll, false);
		}

		// Token: 0x0602AE00 RID: 175616 RVA: 0x005E9D86 File Offset: 0x005E7F86
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(32, nullMask, 0);
		}

		// Token: 0x0602AE01 RID: 175617 RVA: 0x005E9D92 File Offset: 0x005E7F92
		public static Offset<IAdjustHorizontalCamera> EndIAdjustHorizontalCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustHorizontalCamera>(builder.EndTable());
		}

		// Token: 0x0602AE02 RID: 175618 RVA: 0x005E9DA0 File Offset: 0x005E7FA0
		public IAdjustHorizontalCameraT UnPack()
		{
			IAdjustHorizontalCameraT adjustHorizontalCameraT = new IAdjustHorizontalCameraT();
			this.UnPackTo(adjustHorizontalCameraT);
			return adjustHorizontalCameraT;
		}

		// Token: 0x0602AE03 RID: 175619 RVA: 0x005E9DBC File Offset: 0x005E7FBC
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

		// Token: 0x0602AE04 RID: 175620 RVA: 0x005EA188 File Offset: 0x005E8388
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

		// Token: 0x0401060D RID: 67085
		private Table __p;
	}
}
