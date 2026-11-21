using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A8 RID: 26536
	public struct IAdjustBasicCamera : IFlatbufferObject
	{
		// Token: 0x1700C159 RID: 49497
		// (get) Token: 0x0602D112 RID: 184594 RVA: 0x006295FF File Offset: 0x006277FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D113 RID: 184595 RVA: 0x0062960C File Offset: 0x0062780C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D114 RID: 184596 RVA: 0x00629614 File Offset: 0x00627814
		public static IAdjustBasicCamera GetRootAsIAdjustBasicCamera(ByteBuffer _bb)
		{
			return IAdjustBasicCamera.GetRootAsIAdjustBasicCamera(_bb, default(IAdjustBasicCamera));
		}

		// Token: 0x0602D115 RID: 184597 RVA: 0x00629630 File Offset: 0x00627830
		public static IAdjustBasicCamera GetRootAsIAdjustBasicCamera(ByteBuffer _bb, IAdjustBasicCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D116 RID: 184598 RVA: 0x0062964D File Offset: 0x0062784D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D117 RID: 184599 RVA: 0x0062965C File Offset: 0x0062785C
		public IAdjustBasicCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C15A RID: 49498
		// (get) Token: 0x0602D118 RID: 184600 RVA: 0x0062966C File Offset: 0x0062786C
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

		// Token: 0x1700C15B RID: 49499
		// (get) Token: 0x0602D119 RID: 184601 RVA: 0x006296A8 File Offset: 0x006278A8
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

		// Token: 0x1700C15C RID: 49500
		// (get) Token: 0x0602D11A RID: 184602 RVA: 0x006296E4 File Offset: 0x006278E4
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

		// Token: 0x1700C15D RID: 49501
		// (get) Token: 0x0602D11B RID: 184603 RVA: 0x00629724 File Offset: 0x00627924
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

		// Token: 0x1700C15E RID: 49502
		// (get) Token: 0x0602D11C RID: 184604 RVA: 0x00629784 File Offset: 0x00627984
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

		// Token: 0x1700C15F RID: 49503
		// (get) Token: 0x0602D11D RID: 184605 RVA: 0x006297C8 File Offset: 0x006279C8
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

		// Token: 0x1700C160 RID: 49504
		// (get) Token: 0x0602D11E RID: 184606 RVA: 0x00629828 File Offset: 0x00627A28
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

		// Token: 0x1700C161 RID: 49505
		// (get) Token: 0x0602D11F RID: 184607 RVA: 0x0062986C File Offset: 0x00627A6C
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

		// Token: 0x1700C162 RID: 49506
		// (get) Token: 0x0602D120 RID: 184608 RVA: 0x006298B0 File Offset: 0x00627AB0
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

		// Token: 0x1700C163 RID: 49507
		// (get) Token: 0x0602D121 RID: 184609 RVA: 0x006298F4 File Offset: 0x00627AF4
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

		// Token: 0x1700C164 RID: 49508
		// (get) Token: 0x0602D122 RID: 184610 RVA: 0x00629954 File Offset: 0x00627B54
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

		// Token: 0x1700C165 RID: 49509
		// (get) Token: 0x0602D123 RID: 184611 RVA: 0x006299B4 File Offset: 0x00627BB4
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

		// Token: 0x1700C166 RID: 49510
		// (get) Token: 0x0602D124 RID: 184612 RVA: 0x006299F8 File Offset: 0x00627BF8
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

		// Token: 0x1700C167 RID: 49511
		// (get) Token: 0x0602D125 RID: 184613 RVA: 0x00629A3C File Offset: 0x00627C3C
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

		// Token: 0x1700C168 RID: 49512
		// (get) Token: 0x0602D126 RID: 184614 RVA: 0x00629A80 File Offset: 0x00627C80
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

		// Token: 0x1700C169 RID: 49513
		// (get) Token: 0x0602D127 RID: 184615 RVA: 0x00629AC4 File Offset: 0x00627CC4
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

		// Token: 0x1700C16A RID: 49514
		// (get) Token: 0x0602D128 RID: 184616 RVA: 0x00629B08 File Offset: 0x00627D08
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C16B RID: 49515
		// (get) Token: 0x0602D129 RID: 184617 RVA: 0x00629B48 File Offset: 0x00627D48
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

		// Token: 0x0602D12A RID: 184618 RVA: 0x00629B88 File Offset: 0x00627D88
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D12B RID: 184619 RVA: 0x00629BD0 File Offset: 0x00627DD0
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602D12C RID: 184620 RVA: 0x00629BEC File Offset: 0x00627DEC
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602D12D RID: 184621 RVA: 0x00629C08 File Offset: 0x00627E08
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602D12E RID: 184622 RVA: 0x00629C24 File Offset: 0x00627E24
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700C16C RID: 49516
		// (get) Token: 0x0602D12F RID: 184623 RVA: 0x00629C40 File Offset: 0x00627E40
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C16D RID: 49517
		// (get) Token: 0x0602D130 RID: 184624 RVA: 0x00629C80 File Offset: 0x00627E80
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C16E RID: 49518
		// (get) Token: 0x0602D131 RID: 184625 RVA: 0x00629CC0 File Offset: 0x00627EC0
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

		// Token: 0x0602D132 RID: 184626 RVA: 0x00629CF8 File Offset: 0x00627EF8
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602D133 RID: 184627 RVA: 0x00629D08 File Offset: 0x00627F08
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700C16F RID: 49519
		// (get) Token: 0x0602D134 RID: 184628 RVA: 0x00629D18 File Offset: 0x00627F18
		public float OverlayArmLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C170 RID: 49520
		// (get) Token: 0x0602D135 RID: 184629 RVA: 0x00629D5C File Offset: 0x00627F5C
		public string SightUi
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D136 RID: 184630 RVA: 0x00629D94 File Offset: 0x00627F94
		public Span<byte> GetSightUiBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0602D137 RID: 184631 RVA: 0x00629DA4 File Offset: 0x00627FA4
		public byte[] GetSightUiArray()
		{
			return this.__p.__vector_as_array<byte>(50);
		}

		// Token: 0x1700C171 RID: 49521
		// (get) Token: 0x0602D138 RID: 184632 RVA: 0x00629DB4 File Offset: 0x00627FB4
		public bool IsSynchronous
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C172 RID: 49522
		// (get) Token: 0x0602D139 RID: 184633 RVA: 0x00629DF4 File Offset: 0x00627FF4
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

		// Token: 0x1700C173 RID: 49523
		// (get) Token: 0x0602D13A RID: 184634 RVA: 0x00629E38 File Offset: 0x00628038
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

		// Token: 0x1700C174 RID: 49524
		// (get) Token: 0x0602D13B RID: 184635 RVA: 0x00629E98 File Offset: 0x00628098
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

		// Token: 0x1700C175 RID: 49525
		// (get) Token: 0x0602D13C RID: 184636 RVA: 0x00629EF8 File Offset: 0x006280F8
		public bool HidePlayer
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C176 RID: 49526
		// (get) Token: 0x0602D13D RID: 184637 RVA: 0x00629F38 File Offset: 0x00628138
		public ICameraLockConfig? LockConfig
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return new ICameraLockConfig?(default(ICameraLockConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C177 RID: 49527
		// (get) Token: 0x0602D13E RID: 184638 RVA: 0x00629F98 File Offset: 0x00628198
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D13F RID: 184639 RVA: 0x00629FD8 File Offset: 0x006281D8
		public static Offset<IAdjustBasicCamera> CreateIAdjustBasicCamera(FlatBufferBuilder builder, EAdjustPlayerCamera Type = EAdjustPlayerCamera.Basic, int Priority = 0, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>), float FadeOutTime = 0f, Offset<IBaseCurve> FadeOutCurveOffset = default(Offset<IBaseCurve>), float ArmLength = 0f, float MinumArmLength = 0f, float MaxiumArmLength = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArmOffsetOffset = default(Offset<IVectorInfo>), float YawLimitMin = 0f, float YawLimitMax = 0f, float PitchLimitMin = 0f, float PitchLimitMax = 0f, float Fov = 0f, bool IsDisableResetFocus = false, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool IsDisableCollision = false, bool IsDisableDither = false, StringOffset SubScreenBindKeyOffset = default(StringOffset), float OverlayArmLength = 0f, StringOffset SightUiOffset = default(StringOffset), bool IsSynchronous = false, float NearClipDistanceToTarget = 0f, Offset<ISpringArmSoftZoneConfig> SpringArmSoftZoneConfigOffset = default(Offset<ISpringArmSoftZoneConfig>), Offset<ISpringArmFixConfig> SpringArmFixOffset = default(Offset<ISpringArmFixConfig>), bool HidePlayer = false, Offset<ICameraLockConfig> LockConfigOffset = default(Offset<ICameraLockConfig>), ushort NullMask = 0)
		{
			builder.StartTable(31);
			IAdjustBasicCamera.AddLockConfig(builder, LockConfigOffset);
			IAdjustBasicCamera.AddSpringArmFix(builder, SpringArmFixOffset);
			IAdjustBasicCamera.AddSpringArmSoftZoneConfig(builder, SpringArmSoftZoneConfigOffset);
			IAdjustBasicCamera.AddNearClipDistanceToTarget(builder, NearClipDistanceToTarget);
			IAdjustBasicCamera.AddSightUi(builder, SightUiOffset);
			IAdjustBasicCamera.AddOverlayArmLength(builder, OverlayArmLength);
			IAdjustBasicCamera.AddSubScreenBindKey(builder, SubScreenBindKeyOffset);
			IAdjustBasicCamera.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustBasicCamera.AddFov(builder, Fov);
			IAdjustBasicCamera.AddPitchLimitMax(builder, PitchLimitMax);
			IAdjustBasicCamera.AddPitchLimitMin(builder, PitchLimitMin);
			IAdjustBasicCamera.AddYawLimitMax(builder, YawLimitMax);
			IAdjustBasicCamera.AddYawLimitMin(builder, YawLimitMin);
			IAdjustBasicCamera.AddArmOffset(builder, ArmOffsetOffset);
			IAdjustBasicCamera.AddOffset(builder, OffsetOffset);
			IAdjustBasicCamera.AddMaxiumArmLength(builder, MaxiumArmLength);
			IAdjustBasicCamera.AddMinumArmLength(builder, MinumArmLength);
			IAdjustBasicCamera.AddArmLength(builder, ArmLength);
			IAdjustBasicCamera.AddFadeOutCurve(builder, FadeOutCurveOffset);
			IAdjustBasicCamera.AddFadeOutTime(builder, FadeOutTime);
			IAdjustBasicCamera.AddFadeInCurve(builder, FadeInCurveOffset);
			IAdjustBasicCamera.AddFadeInTime(builder, FadeInTime);
			IAdjustBasicCamera.AddPriority(builder, Priority);
			IAdjustBasicCamera.AddNullMask(builder, NullMask);
			IAdjustBasicCamera.AddHidePlayer(builder, HidePlayer);
			IAdjustBasicCamera.AddIsSynchronous(builder, IsSynchronous);
			IAdjustBasicCamera.AddIsDisableDither(builder, IsDisableDither);
			IAdjustBasicCamera.AddIsDisableCollision(builder, IsDisableCollision);
			IAdjustBasicCamera.AddGravityDirectionType(builder, GravityDirection_type);
			IAdjustBasicCamera.AddIsDisableResetFocus(builder, IsDisableResetFocus);
			IAdjustBasicCamera.AddType(builder, Type);
			return IAdjustBasicCamera.EndIAdjustBasicCamera(builder);
		}

		// Token: 0x0602D140 RID: 184640 RVA: 0x0062A0E8 File Offset: 0x006282E8
		public static void StartIAdjustBasicCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(31);
		}

		// Token: 0x0602D141 RID: 184641 RVA: 0x0062A0F2 File Offset: 0x006282F2
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D142 RID: 184642 RVA: 0x0062A0FD File Offset: 0x006282FD
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602D143 RID: 184643 RVA: 0x0062A108 File Offset: 0x00628308
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602D144 RID: 184644 RVA: 0x0062A11B File Offset: 0x0062831B
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602D145 RID: 184645 RVA: 0x0062A12B File Offset: 0x0062832B
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602D146 RID: 184646 RVA: 0x0062A13E File Offset: 0x0062833E
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602D147 RID: 184647 RVA: 0x0062A14E File Offset: 0x0062834E
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602D148 RID: 184648 RVA: 0x0062A161 File Offset: 0x00628361
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602D149 RID: 184649 RVA: 0x0062A174 File Offset: 0x00628374
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602D14A RID: 184650 RVA: 0x0062A187 File Offset: 0x00628387
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602D14B RID: 184651 RVA: 0x0062A198 File Offset: 0x00628398
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602D14C RID: 184652 RVA: 0x0062A1A9 File Offset: 0x006283A9
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602D14D RID: 184653 RVA: 0x0062A1BD File Offset: 0x006283BD
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602D14E RID: 184654 RVA: 0x0062A1D1 File Offset: 0x006283D1
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602D14F RID: 184655 RVA: 0x0062A1E5 File Offset: 0x006283E5
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602D150 RID: 184656 RVA: 0x0062A1F9 File Offset: 0x006283F9
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602D151 RID: 184657 RVA: 0x0062A20D File Offset: 0x0062840D
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602D152 RID: 184658 RVA: 0x0062A219 File Offset: 0x00628419
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602D153 RID: 184659 RVA: 0x0062A225 File Offset: 0x00628425
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602D154 RID: 184660 RVA: 0x0062A231 File Offset: 0x00628431
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602D155 RID: 184661 RVA: 0x0062A23D File Offset: 0x0062843D
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602D156 RID: 184662 RVA: 0x0062A249 File Offset: 0x00628449
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602D157 RID: 184663 RVA: 0x0062A25A File Offset: 0x0062845A
		public static void AddOverlayArmLength(FlatBufferBuilder builder, float overlayArmLength)
		{
			builder.AddFloat(22, overlayArmLength, 0.0);
		}

		// Token: 0x0602D158 RID: 184664 RVA: 0x0062A26E File Offset: 0x0062846E
		public static void AddSightUi(FlatBufferBuilder builder, StringOffset sightUiOffset)
		{
			builder.AddOffset(23, sightUiOffset.Value, 0);
		}

		// Token: 0x0602D159 RID: 184665 RVA: 0x0062A27F File Offset: 0x0062847F
		public static void AddIsSynchronous(FlatBufferBuilder builder, bool isSynchronous)
		{
			builder.AddBool(24, isSynchronous, false);
		}

		// Token: 0x0602D15A RID: 184666 RVA: 0x0062A28B File Offset: 0x0062848B
		public static void AddNearClipDistanceToTarget(FlatBufferBuilder builder, float nearClipDistanceToTarget)
		{
			builder.AddFloat(25, nearClipDistanceToTarget, 0.0);
		}

		// Token: 0x0602D15B RID: 184667 RVA: 0x0062A29F File Offset: 0x0062849F
		public static void AddSpringArmSoftZoneConfig(FlatBufferBuilder builder, Offset<ISpringArmSoftZoneConfig> springArmSoftZoneConfigOffset)
		{
			builder.AddOffset(26, springArmSoftZoneConfigOffset.Value, 0);
		}

		// Token: 0x0602D15C RID: 184668 RVA: 0x0062A2B0 File Offset: 0x006284B0
		public static void AddSpringArmFix(FlatBufferBuilder builder, Offset<ISpringArmFixConfig> springArmFixOffset)
		{
			builder.AddOffset(27, springArmFixOffset.Value, 0);
		}

		// Token: 0x0602D15D RID: 184669 RVA: 0x0062A2C1 File Offset: 0x006284C1
		public static void AddHidePlayer(FlatBufferBuilder builder, bool hidePlayer)
		{
			builder.AddBool(28, hidePlayer, false);
		}

		// Token: 0x0602D15E RID: 184670 RVA: 0x0062A2CD File Offset: 0x006284CD
		public static void AddLockConfig(FlatBufferBuilder builder, Offset<ICameraLockConfig> lockConfigOffset)
		{
			builder.AddOffset(29, lockConfigOffset.Value, 0);
		}

		// Token: 0x0602D15F RID: 184671 RVA: 0x0062A2DE File Offset: 0x006284DE
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(30, nullMask, 0);
		}

		// Token: 0x0602D160 RID: 184672 RVA: 0x0062A2EA File Offset: 0x006284EA
		public static Offset<IAdjustBasicCamera> EndIAdjustBasicCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustBasicCamera>(builder.EndTable());
		}

		// Token: 0x0602D161 RID: 184673 RVA: 0x0062A2F8 File Offset: 0x006284F8
		public IAdjustBasicCameraT UnPack()
		{
			IAdjustBasicCameraT adjustBasicCameraT = new IAdjustBasicCameraT();
			this.UnPackTo(adjustBasicCameraT);
			return adjustBasicCameraT;
		}

		// Token: 0x0602D162 RID: 184674 RVA: 0x0062A314 File Offset: 0x00628514
		public void UnPackTo(IAdjustBasicCameraT _o)
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
			_o.OverlayArmLength = this.OverlayArmLength;
			_o.SightUi = this.SightUi;
			_o.IsSynchronous = this.IsSynchronous;
			_o.NearClipDistanceToTarget = this.NearClipDistanceToTarget;
			_o.SpringArmSoftZoneConfig = ((this.SpringArmSoftZoneConfig != null) ? this.SpringArmSoftZoneConfig.Value.UnPack() : null);
			_o.SpringArmFix = ((this.SpringArmFix != null) ? this.SpringArmFix.Value.UnPack() : null);
			_o.HidePlayer = this.HidePlayer;
			_o.LockConfig = ((this.LockConfig != null) ? this.LockConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D163 RID: 184675 RVA: 0x0062A6A4 File Offset: 0x006288A4
		public static Offset<IAdjustBasicCamera> Pack(FlatBufferBuilder builder, IAdjustBasicCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustBasicCamera>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			Offset<IBaseCurve> fadeOutCurveOffset = (_o.FadeOutCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeOutCurve);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> armOffsetOffset = (_o.ArmOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArmOffset);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			StringOffset subScreenBindKeyOffset = (_o.SubScreenBindKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenBindKey);
			StringOffset sightUiOffset = (_o.SightUi == null) ? default(StringOffset) : builder.CreateString(_o.SightUi);
			Offset<ISpringArmSoftZoneConfig> springArmSoftZoneConfigOffset = (_o.SpringArmSoftZoneConfig == null) ? default(Offset<ISpringArmSoftZoneConfig>) : ISpringArmSoftZoneConfig.Pack(builder, _o.SpringArmSoftZoneConfig);
			Offset<ISpringArmFixConfig> springArmFixOffset = (_o.SpringArmFix == null) ? default(Offset<ISpringArmFixConfig>) : ISpringArmFixConfig.Pack(builder, _o.SpringArmFix);
			Offset<ICameraLockConfig> lockConfigOffset = (_o.LockConfig == null) ? default(Offset<ICameraLockConfig>) : ICameraLockConfig.Pack(builder, _o.LockConfig);
			return IAdjustBasicCamera.CreateIAdjustBasicCamera(builder, _o.Type, _o.Priority, _o.FadeInTime, fadeInCurveOffset, _o.FadeOutTime, fadeOutCurveOffset, _o.ArmLength, _o.MinumArmLength, _o.MaxiumArmLength, offsetOffset, armOffsetOffset, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.Fov, _o.IsDisableResetFocus, gravityDirection_type, gravityDirectionOffset, _o.IsDisableCollision, _o.IsDisableDither, subScreenBindKeyOffset, _o.OverlayArmLength, sightUiOffset, _o.IsSynchronous, _o.NearClipDistanceToTarget, springArmSoftZoneConfigOffset, springArmFixOffset, _o.HidePlayer, lockConfigOffset, _o.NullMask);
		}

		// Token: 0x04011354 RID: 70484
		private Table __p;
	}
}
