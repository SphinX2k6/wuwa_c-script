using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006143 RID: 24899
	public struct IAdjustBasicCamera : IFlatbufferObject
	{
		// Token: 0x1700B7E9 RID: 47081
		// (get) Token: 0x0602AA19 RID: 174617 RVA: 0x005DF423 File Offset: 0x005DD623
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AA1A RID: 174618 RVA: 0x005DF430 File Offset: 0x005DD630
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AA1B RID: 174619 RVA: 0x005DF438 File Offset: 0x005DD638
		public static IAdjustBasicCamera GetRootAsIAdjustBasicCamera(ByteBuffer _bb)
		{
			return IAdjustBasicCamera.GetRootAsIAdjustBasicCamera(_bb, default(IAdjustBasicCamera));
		}

		// Token: 0x0602AA1C RID: 174620 RVA: 0x005DF454 File Offset: 0x005DD654
		public static IAdjustBasicCamera GetRootAsIAdjustBasicCamera(ByteBuffer _bb, IAdjustBasicCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AA1D RID: 174621 RVA: 0x005DF471 File Offset: 0x005DD671
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AA1E RID: 174622 RVA: 0x005DF480 File Offset: 0x005DD680
		public IAdjustBasicCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7EA RID: 47082
		// (get) Token: 0x0602AA1F RID: 174623 RVA: 0x005DF490 File Offset: 0x005DD690
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

		// Token: 0x1700B7EB RID: 47083
		// (get) Token: 0x0602AA20 RID: 174624 RVA: 0x005DF4CC File Offset: 0x005DD6CC
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

		// Token: 0x1700B7EC RID: 47084
		// (get) Token: 0x0602AA21 RID: 174625 RVA: 0x005DF508 File Offset: 0x005DD708
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

		// Token: 0x1700B7ED RID: 47085
		// (get) Token: 0x0602AA22 RID: 174626 RVA: 0x005DF548 File Offset: 0x005DD748
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

		// Token: 0x1700B7EE RID: 47086
		// (get) Token: 0x0602AA23 RID: 174627 RVA: 0x005DF5A8 File Offset: 0x005DD7A8
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

		// Token: 0x1700B7EF RID: 47087
		// (get) Token: 0x0602AA24 RID: 174628 RVA: 0x005DF5EC File Offset: 0x005DD7EC
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

		// Token: 0x1700B7F0 RID: 47088
		// (get) Token: 0x0602AA25 RID: 174629 RVA: 0x005DF64C File Offset: 0x005DD84C
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

		// Token: 0x1700B7F1 RID: 47089
		// (get) Token: 0x0602AA26 RID: 174630 RVA: 0x005DF690 File Offset: 0x005DD890
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

		// Token: 0x1700B7F2 RID: 47090
		// (get) Token: 0x0602AA27 RID: 174631 RVA: 0x005DF6D4 File Offset: 0x005DD8D4
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

		// Token: 0x1700B7F3 RID: 47091
		// (get) Token: 0x0602AA28 RID: 174632 RVA: 0x005DF718 File Offset: 0x005DD918
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

		// Token: 0x1700B7F4 RID: 47092
		// (get) Token: 0x0602AA29 RID: 174633 RVA: 0x005DF778 File Offset: 0x005DD978
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

		// Token: 0x1700B7F5 RID: 47093
		// (get) Token: 0x0602AA2A RID: 174634 RVA: 0x005DF7D8 File Offset: 0x005DD9D8
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

		// Token: 0x1700B7F6 RID: 47094
		// (get) Token: 0x0602AA2B RID: 174635 RVA: 0x005DF81C File Offset: 0x005DDA1C
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

		// Token: 0x1700B7F7 RID: 47095
		// (get) Token: 0x0602AA2C RID: 174636 RVA: 0x005DF860 File Offset: 0x005DDA60
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

		// Token: 0x1700B7F8 RID: 47096
		// (get) Token: 0x0602AA2D RID: 174637 RVA: 0x005DF8A4 File Offset: 0x005DDAA4
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

		// Token: 0x1700B7F9 RID: 47097
		// (get) Token: 0x0602AA2E RID: 174638 RVA: 0x005DF8E8 File Offset: 0x005DDAE8
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

		// Token: 0x1700B7FA RID: 47098
		// (get) Token: 0x0602AA2F RID: 174639 RVA: 0x005DF92C File Offset: 0x005DDB2C
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B7FB RID: 47099
		// (get) Token: 0x0602AA30 RID: 174640 RVA: 0x005DF96C File Offset: 0x005DDB6C
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

		// Token: 0x0602AA31 RID: 174641 RVA: 0x005DF9AC File Offset: 0x005DDBAC
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602AA32 RID: 174642 RVA: 0x005DF9F4 File Offset: 0x005DDBF4
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602AA33 RID: 174643 RVA: 0x005DFA10 File Offset: 0x005DDC10
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602AA34 RID: 174644 RVA: 0x005DFA2C File Offset: 0x005DDC2C
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602AA35 RID: 174645 RVA: 0x005DFA48 File Offset: 0x005DDC48
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700B7FC RID: 47100
		// (get) Token: 0x0602AA36 RID: 174646 RVA: 0x005DFA64 File Offset: 0x005DDC64
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B7FD RID: 47101
		// (get) Token: 0x0602AA37 RID: 174647 RVA: 0x005DFAA4 File Offset: 0x005DDCA4
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B7FE RID: 47102
		// (get) Token: 0x0602AA38 RID: 174648 RVA: 0x005DFAE4 File Offset: 0x005DDCE4
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

		// Token: 0x0602AA39 RID: 174649 RVA: 0x005DFB1C File Offset: 0x005DDD1C
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602AA3A RID: 174650 RVA: 0x005DFB2C File Offset: 0x005DDD2C
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700B7FF RID: 47103
		// (get) Token: 0x0602AA3B RID: 174651 RVA: 0x005DFB3C File Offset: 0x005DDD3C
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

		// Token: 0x1700B800 RID: 47104
		// (get) Token: 0x0602AA3C RID: 174652 RVA: 0x005DFB80 File Offset: 0x005DDD80
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

		// Token: 0x0602AA3D RID: 174653 RVA: 0x005DFBB8 File Offset: 0x005DDDB8
		public Span<byte> GetSightUiBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0602AA3E RID: 174654 RVA: 0x005DFBC8 File Offset: 0x005DDDC8
		public byte[] GetSightUiArray()
		{
			return this.__p.__vector_as_array<byte>(50);
		}

		// Token: 0x1700B801 RID: 47105
		// (get) Token: 0x0602AA3F RID: 174655 RVA: 0x005DFBD8 File Offset: 0x005DDDD8
		public bool IsSynchronous
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B802 RID: 47106
		// (get) Token: 0x0602AA40 RID: 174656 RVA: 0x005DFC18 File Offset: 0x005DDE18
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

		// Token: 0x1700B803 RID: 47107
		// (get) Token: 0x0602AA41 RID: 174657 RVA: 0x005DFC5C File Offset: 0x005DDE5C
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

		// Token: 0x1700B804 RID: 47108
		// (get) Token: 0x0602AA42 RID: 174658 RVA: 0x005DFCBC File Offset: 0x005DDEBC
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

		// Token: 0x1700B805 RID: 47109
		// (get) Token: 0x0602AA43 RID: 174659 RVA: 0x005DFD1C File Offset: 0x005DDF1C
		public bool HidePlayer
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B806 RID: 47110
		// (get) Token: 0x0602AA44 RID: 174660 RVA: 0x005DFD5C File Offset: 0x005DDF5C
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

		// Token: 0x1700B807 RID: 47111
		// (get) Token: 0x0602AA45 RID: 174661 RVA: 0x005DFDBC File Offset: 0x005DDFBC
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

		// Token: 0x0602AA46 RID: 174662 RVA: 0x005DFDFC File Offset: 0x005DDFFC
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

		// Token: 0x0602AA47 RID: 174663 RVA: 0x005DFF0C File Offset: 0x005DE10C
		public static void StartIAdjustBasicCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(31);
		}

		// Token: 0x0602AA48 RID: 174664 RVA: 0x005DFF16 File Offset: 0x005DE116
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AA49 RID: 174665 RVA: 0x005DFF21 File Offset: 0x005DE121
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602AA4A RID: 174666 RVA: 0x005DFF2C File Offset: 0x005DE12C
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602AA4B RID: 174667 RVA: 0x005DFF3F File Offset: 0x005DE13F
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602AA4C RID: 174668 RVA: 0x005DFF4F File Offset: 0x005DE14F
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602AA4D RID: 174669 RVA: 0x005DFF62 File Offset: 0x005DE162
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602AA4E RID: 174670 RVA: 0x005DFF72 File Offset: 0x005DE172
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602AA4F RID: 174671 RVA: 0x005DFF85 File Offset: 0x005DE185
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602AA50 RID: 174672 RVA: 0x005DFF98 File Offset: 0x005DE198
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602AA51 RID: 174673 RVA: 0x005DFFAB File Offset: 0x005DE1AB
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602AA52 RID: 174674 RVA: 0x005DFFBC File Offset: 0x005DE1BC
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602AA53 RID: 174675 RVA: 0x005DFFCD File Offset: 0x005DE1CD
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602AA54 RID: 174676 RVA: 0x005DFFE1 File Offset: 0x005DE1E1
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602AA55 RID: 174677 RVA: 0x005DFFF5 File Offset: 0x005DE1F5
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602AA56 RID: 174678 RVA: 0x005E0009 File Offset: 0x005DE209
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602AA57 RID: 174679 RVA: 0x005E001D File Offset: 0x005DE21D
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602AA58 RID: 174680 RVA: 0x005E0031 File Offset: 0x005DE231
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602AA59 RID: 174681 RVA: 0x005E003D File Offset: 0x005DE23D
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602AA5A RID: 174682 RVA: 0x005E0049 File Offset: 0x005DE249
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602AA5B RID: 174683 RVA: 0x005E0055 File Offset: 0x005DE255
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602AA5C RID: 174684 RVA: 0x005E0061 File Offset: 0x005DE261
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602AA5D RID: 174685 RVA: 0x005E006D File Offset: 0x005DE26D
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602AA5E RID: 174686 RVA: 0x005E007E File Offset: 0x005DE27E
		public static void AddOverlayArmLength(FlatBufferBuilder builder, float overlayArmLength)
		{
			builder.AddFloat(22, overlayArmLength, 0.0);
		}

		// Token: 0x0602AA5F RID: 174687 RVA: 0x005E0092 File Offset: 0x005DE292
		public static void AddSightUi(FlatBufferBuilder builder, StringOffset sightUiOffset)
		{
			builder.AddOffset(23, sightUiOffset.Value, 0);
		}

		// Token: 0x0602AA60 RID: 174688 RVA: 0x005E00A3 File Offset: 0x005DE2A3
		public static void AddIsSynchronous(FlatBufferBuilder builder, bool isSynchronous)
		{
			builder.AddBool(24, isSynchronous, false);
		}

		// Token: 0x0602AA61 RID: 174689 RVA: 0x005E00AF File Offset: 0x005DE2AF
		public static void AddNearClipDistanceToTarget(FlatBufferBuilder builder, float nearClipDistanceToTarget)
		{
			builder.AddFloat(25, nearClipDistanceToTarget, 0.0);
		}

		// Token: 0x0602AA62 RID: 174690 RVA: 0x005E00C3 File Offset: 0x005DE2C3
		public static void AddSpringArmSoftZoneConfig(FlatBufferBuilder builder, Offset<ISpringArmSoftZoneConfig> springArmSoftZoneConfigOffset)
		{
			builder.AddOffset(26, springArmSoftZoneConfigOffset.Value, 0);
		}

		// Token: 0x0602AA63 RID: 174691 RVA: 0x005E00D4 File Offset: 0x005DE2D4
		public static void AddSpringArmFix(FlatBufferBuilder builder, Offset<ISpringArmFixConfig> springArmFixOffset)
		{
			builder.AddOffset(27, springArmFixOffset.Value, 0);
		}

		// Token: 0x0602AA64 RID: 174692 RVA: 0x005E00E5 File Offset: 0x005DE2E5
		public static void AddHidePlayer(FlatBufferBuilder builder, bool hidePlayer)
		{
			builder.AddBool(28, hidePlayer, false);
		}

		// Token: 0x0602AA65 RID: 174693 RVA: 0x005E00F1 File Offset: 0x005DE2F1
		public static void AddLockConfig(FlatBufferBuilder builder, Offset<ICameraLockConfig> lockConfigOffset)
		{
			builder.AddOffset(29, lockConfigOffset.Value, 0);
		}

		// Token: 0x0602AA66 RID: 174694 RVA: 0x005E0102 File Offset: 0x005DE302
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(30, nullMask, 0);
		}

		// Token: 0x0602AA67 RID: 174695 RVA: 0x005E010E File Offset: 0x005DE30E
		public static Offset<IAdjustBasicCamera> EndIAdjustBasicCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustBasicCamera>(builder.EndTable());
		}

		// Token: 0x0602AA68 RID: 174696 RVA: 0x005E011C File Offset: 0x005DE31C
		public IAdjustBasicCameraT UnPack()
		{
			IAdjustBasicCameraT adjustBasicCameraT = new IAdjustBasicCameraT();
			this.UnPackTo(adjustBasicCameraT);
			return adjustBasicCameraT;
		}

		// Token: 0x0602AA69 RID: 174697 RVA: 0x005E0138 File Offset: 0x005DE338
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

		// Token: 0x0602AA6A RID: 174698 RVA: 0x005E04C8 File Offset: 0x005DE6C8
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

		// Token: 0x0401054D RID: 66893
		private Table __p;
	}
}
