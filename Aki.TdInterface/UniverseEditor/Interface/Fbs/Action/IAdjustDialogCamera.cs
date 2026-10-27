using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006146 RID: 24902
	public struct IAdjustDialogCamera : IFlatbufferObject
	{
		// Token: 0x1700B826 RID: 47142
		// (get) Token: 0x0602AAA9 RID: 174761 RVA: 0x005E0CF7 File Offset: 0x005DEEF7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AAAA RID: 174762 RVA: 0x005E0D04 File Offset: 0x005DEF04
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AAAB RID: 174763 RVA: 0x005E0D0C File Offset: 0x005DEF0C
		public static IAdjustDialogCamera GetRootAsIAdjustDialogCamera(ByteBuffer _bb)
		{
			return IAdjustDialogCamera.GetRootAsIAdjustDialogCamera(_bb, default(IAdjustDialogCamera));
		}

		// Token: 0x0602AAAC RID: 174764 RVA: 0x005E0D28 File Offset: 0x005DEF28
		public static IAdjustDialogCamera GetRootAsIAdjustDialogCamera(ByteBuffer _bb, IAdjustDialogCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AAAD RID: 174765 RVA: 0x005E0D45 File Offset: 0x005DEF45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AAAE RID: 174766 RVA: 0x005E0D54 File Offset: 0x005DEF54
		public IAdjustDialogCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B827 RID: 47143
		// (get) Token: 0x0602AAAF RID: 174767 RVA: 0x005E0D64 File Offset: 0x005DEF64
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

		// Token: 0x1700B828 RID: 47144
		// (get) Token: 0x0602AAB0 RID: 174768 RVA: 0x005E0DA0 File Offset: 0x005DEFA0
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

		// Token: 0x1700B829 RID: 47145
		// (get) Token: 0x0602AAB1 RID: 174769 RVA: 0x005E0DDC File Offset: 0x005DEFDC
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

		// Token: 0x1700B82A RID: 47146
		// (get) Token: 0x0602AAB2 RID: 174770 RVA: 0x005E0E1C File Offset: 0x005DF01C
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

		// Token: 0x1700B82B RID: 47147
		// (get) Token: 0x0602AAB3 RID: 174771 RVA: 0x005E0E7C File Offset: 0x005DF07C
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

		// Token: 0x1700B82C RID: 47148
		// (get) Token: 0x0602AAB4 RID: 174772 RVA: 0x005E0EC0 File Offset: 0x005DF0C0
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

		// Token: 0x1700B82D RID: 47149
		// (get) Token: 0x0602AAB5 RID: 174773 RVA: 0x005E0F20 File Offset: 0x005DF120
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

		// Token: 0x1700B82E RID: 47150
		// (get) Token: 0x0602AAB6 RID: 174774 RVA: 0x005E0F64 File Offset: 0x005DF164
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

		// Token: 0x1700B82F RID: 47151
		// (get) Token: 0x0602AAB7 RID: 174775 RVA: 0x005E0FA8 File Offset: 0x005DF1A8
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

		// Token: 0x1700B830 RID: 47152
		// (get) Token: 0x0602AAB8 RID: 174776 RVA: 0x005E0FEC File Offset: 0x005DF1EC
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

		// Token: 0x1700B831 RID: 47153
		// (get) Token: 0x0602AAB9 RID: 174777 RVA: 0x005E104C File Offset: 0x005DF24C
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

		// Token: 0x1700B832 RID: 47154
		// (get) Token: 0x0602AABA RID: 174778 RVA: 0x005E10AC File Offset: 0x005DF2AC
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

		// Token: 0x1700B833 RID: 47155
		// (get) Token: 0x0602AABB RID: 174779 RVA: 0x005E10F0 File Offset: 0x005DF2F0
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

		// Token: 0x1700B834 RID: 47156
		// (get) Token: 0x0602AABC RID: 174780 RVA: 0x005E1134 File Offset: 0x005DF334
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

		// Token: 0x1700B835 RID: 47157
		// (get) Token: 0x0602AABD RID: 174781 RVA: 0x005E1178 File Offset: 0x005DF378
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

		// Token: 0x1700B836 RID: 47158
		// (get) Token: 0x0602AABE RID: 174782 RVA: 0x005E11BC File Offset: 0x005DF3BC
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

		// Token: 0x1700B837 RID: 47159
		// (get) Token: 0x0602AABF RID: 174783 RVA: 0x005E1200 File Offset: 0x005DF400
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B838 RID: 47160
		// (get) Token: 0x0602AAC0 RID: 174784 RVA: 0x005E1240 File Offset: 0x005DF440
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

		// Token: 0x0602AAC1 RID: 174785 RVA: 0x005E1280 File Offset: 0x005DF480
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602AAC2 RID: 174786 RVA: 0x005E12C8 File Offset: 0x005DF4C8
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602AAC3 RID: 174787 RVA: 0x005E12E4 File Offset: 0x005DF4E4
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602AAC4 RID: 174788 RVA: 0x005E1300 File Offset: 0x005DF500
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602AAC5 RID: 174789 RVA: 0x005E131C File Offset: 0x005DF51C
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700B839 RID: 47161
		// (get) Token: 0x0602AAC6 RID: 174790 RVA: 0x005E1338 File Offset: 0x005DF538
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B83A RID: 47162
		// (get) Token: 0x0602AAC7 RID: 174791 RVA: 0x005E1378 File Offset: 0x005DF578
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B83B RID: 47163
		// (get) Token: 0x0602AAC8 RID: 174792 RVA: 0x005E13B8 File Offset: 0x005DF5B8
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

		// Token: 0x0602AAC9 RID: 174793 RVA: 0x005E13F0 File Offset: 0x005DF5F0
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602AACA RID: 174794 RVA: 0x005E1400 File Offset: 0x005DF600
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700B83C RID: 47164
		// (get) Token: 0x0602AACB RID: 174795 RVA: 0x005E1410 File Offset: 0x005DF610
		public float YawAngle
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

		// Token: 0x1700B83D RID: 47165
		// (get) Token: 0x0602AACC RID: 174796 RVA: 0x005E1454 File Offset: 0x005DF654
		public float PitchAngle
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

		// Token: 0x1700B83E RID: 47166
		// (get) Token: 0x0602AACD RID: 174797 RVA: 0x005E1498 File Offset: 0x005DF698
		public IVectorInfo? CenterPos
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B83F RID: 47167
		// (get) Token: 0x0602AACE RID: 174798 RVA: 0x005E14F8 File Offset: 0x005DF6F8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602AACF RID: 174799 RVA: 0x005E1538 File Offset: 0x005DF738
		public static Offset<IAdjustDialogCamera> CreateIAdjustDialogCamera(FlatBufferBuilder builder, EAdjustPlayerCamera Type = EAdjustPlayerCamera.Basic, int Priority = 0, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>), float FadeOutTime = 0f, Offset<IBaseCurve> FadeOutCurveOffset = default(Offset<IBaseCurve>), float ArmLength = 0f, float MinumArmLength = 0f, float MaxiumArmLength = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArmOffsetOffset = default(Offset<IVectorInfo>), float YawLimitMin = 0f, float YawLimitMax = 0f, float PitchLimitMin = 0f, float PitchLimitMax = 0f, float Fov = 0f, bool IsDisableResetFocus = false, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool IsDisableCollision = false, bool IsDisableDither = false, StringOffset SubScreenBindKeyOffset = default(StringOffset), float YawAngle = 0f, float PitchAngle = 0f, Offset<IVectorInfo> CenterPosOffset = default(Offset<IVectorInfo>), byte NullMask = 0)
		{
			builder.StartTable(26);
			IAdjustDialogCamera.AddCenterPos(builder, CenterPosOffset);
			IAdjustDialogCamera.AddPitchAngle(builder, PitchAngle);
			IAdjustDialogCamera.AddYawAngle(builder, YawAngle);
			IAdjustDialogCamera.AddSubScreenBindKey(builder, SubScreenBindKeyOffset);
			IAdjustDialogCamera.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustDialogCamera.AddFov(builder, Fov);
			IAdjustDialogCamera.AddPitchLimitMax(builder, PitchLimitMax);
			IAdjustDialogCamera.AddPitchLimitMin(builder, PitchLimitMin);
			IAdjustDialogCamera.AddYawLimitMax(builder, YawLimitMax);
			IAdjustDialogCamera.AddYawLimitMin(builder, YawLimitMin);
			IAdjustDialogCamera.AddArmOffset(builder, ArmOffsetOffset);
			IAdjustDialogCamera.AddOffset(builder, OffsetOffset);
			IAdjustDialogCamera.AddMaxiumArmLength(builder, MaxiumArmLength);
			IAdjustDialogCamera.AddMinumArmLength(builder, MinumArmLength);
			IAdjustDialogCamera.AddArmLength(builder, ArmLength);
			IAdjustDialogCamera.AddFadeOutCurve(builder, FadeOutCurveOffset);
			IAdjustDialogCamera.AddFadeOutTime(builder, FadeOutTime);
			IAdjustDialogCamera.AddFadeInCurve(builder, FadeInCurveOffset);
			IAdjustDialogCamera.AddFadeInTime(builder, FadeInTime);
			IAdjustDialogCamera.AddPriority(builder, Priority);
			IAdjustDialogCamera.AddNullMask(builder, NullMask);
			IAdjustDialogCamera.AddIsDisableDither(builder, IsDisableDither);
			IAdjustDialogCamera.AddIsDisableCollision(builder, IsDisableCollision);
			IAdjustDialogCamera.AddGravityDirectionType(builder, GravityDirection_type);
			IAdjustDialogCamera.AddIsDisableResetFocus(builder, IsDisableResetFocus);
			IAdjustDialogCamera.AddType(builder, Type);
			return IAdjustDialogCamera.EndIAdjustDialogCamera(builder);
		}

		// Token: 0x0602AAD0 RID: 174800 RVA: 0x005E1620 File Offset: 0x005DF820
		public static void StartIAdjustDialogCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(26);
		}

		// Token: 0x0602AAD1 RID: 174801 RVA: 0x005E162A File Offset: 0x005DF82A
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AAD2 RID: 174802 RVA: 0x005E1635 File Offset: 0x005DF835
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602AAD3 RID: 174803 RVA: 0x005E1640 File Offset: 0x005DF840
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602AAD4 RID: 174804 RVA: 0x005E1653 File Offset: 0x005DF853
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602AAD5 RID: 174805 RVA: 0x005E1663 File Offset: 0x005DF863
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602AAD6 RID: 174806 RVA: 0x005E1676 File Offset: 0x005DF876
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602AAD7 RID: 174807 RVA: 0x005E1686 File Offset: 0x005DF886
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602AAD8 RID: 174808 RVA: 0x005E1699 File Offset: 0x005DF899
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602AAD9 RID: 174809 RVA: 0x005E16AC File Offset: 0x005DF8AC
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602AADA RID: 174810 RVA: 0x005E16BF File Offset: 0x005DF8BF
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602AADB RID: 174811 RVA: 0x005E16D0 File Offset: 0x005DF8D0
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602AADC RID: 174812 RVA: 0x005E16E1 File Offset: 0x005DF8E1
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602AADD RID: 174813 RVA: 0x005E16F5 File Offset: 0x005DF8F5
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602AADE RID: 174814 RVA: 0x005E1709 File Offset: 0x005DF909
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602AADF RID: 174815 RVA: 0x005E171D File Offset: 0x005DF91D
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602AAE0 RID: 174816 RVA: 0x005E1731 File Offset: 0x005DF931
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602AAE1 RID: 174817 RVA: 0x005E1745 File Offset: 0x005DF945
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602AAE2 RID: 174818 RVA: 0x005E1751 File Offset: 0x005DF951
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602AAE3 RID: 174819 RVA: 0x005E175D File Offset: 0x005DF95D
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602AAE4 RID: 174820 RVA: 0x005E1769 File Offset: 0x005DF969
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602AAE5 RID: 174821 RVA: 0x005E1775 File Offset: 0x005DF975
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602AAE6 RID: 174822 RVA: 0x005E1781 File Offset: 0x005DF981
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602AAE7 RID: 174823 RVA: 0x005E1792 File Offset: 0x005DF992
		public static void AddYawAngle(FlatBufferBuilder builder, float yawAngle)
		{
			builder.AddFloat(22, yawAngle, 0.0);
		}

		// Token: 0x0602AAE8 RID: 174824 RVA: 0x005E17A6 File Offset: 0x005DF9A6
		public static void AddPitchAngle(FlatBufferBuilder builder, float pitchAngle)
		{
			builder.AddFloat(23, pitchAngle, 0.0);
		}

		// Token: 0x0602AAE9 RID: 174825 RVA: 0x005E17BA File Offset: 0x005DF9BA
		public static void AddCenterPos(FlatBufferBuilder builder, Offset<IVectorInfo> centerPosOffset)
		{
			builder.AddOffset(24, centerPosOffset.Value, 0);
		}

		// Token: 0x0602AAEA RID: 174826 RVA: 0x005E17CB File Offset: 0x005DF9CB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(25, nullMask, 0);
		}

		// Token: 0x0602AAEB RID: 174827 RVA: 0x005E17D7 File Offset: 0x005DF9D7
		public static Offset<IAdjustDialogCamera> EndIAdjustDialogCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustDialogCamera>(builder.EndTable());
		}

		// Token: 0x0602AAEC RID: 174828 RVA: 0x005E17E4 File Offset: 0x005DF9E4
		public IAdjustDialogCameraT UnPack()
		{
			IAdjustDialogCameraT adjustDialogCameraT = new IAdjustDialogCameraT();
			this.UnPackTo(adjustDialogCameraT);
			return adjustDialogCameraT;
		}

		// Token: 0x0602AAED RID: 174829 RVA: 0x005E1800 File Offset: 0x005DFA00
		public void UnPackTo(IAdjustDialogCameraT _o)
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
			_o.YawAngle = this.YawAngle;
			_o.PitchAngle = this.PitchAngle;
			_o.CenterPos = ((this.CenterPos != null) ? this.CenterPos.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602AAEE RID: 174830 RVA: 0x005E1B04 File Offset: 0x005DFD04
		public static Offset<IAdjustDialogCamera> Pack(FlatBufferBuilder builder, IAdjustDialogCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustDialogCamera>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			Offset<IBaseCurve> fadeOutCurveOffset = (_o.FadeOutCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeOutCurve);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> armOffsetOffset = (_o.ArmOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArmOffset);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			StringOffset subScreenBindKeyOffset = (_o.SubScreenBindKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenBindKey);
			Offset<IVectorInfo> centerPosOffset = (_o.CenterPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CenterPos);
			return IAdjustDialogCamera.CreateIAdjustDialogCamera(builder, _o.Type, _o.Priority, _o.FadeInTime, fadeInCurveOffset, _o.FadeOutTime, fadeOutCurveOffset, _o.ArmLength, _o.MinumArmLength, _o.MaxiumArmLength, offsetOffset, armOffsetOffset, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.Fov, _o.IsDisableResetFocus, gravityDirection_type, gravityDirectionOffset, _o.IsDisableCollision, _o.IsDisableDither, subScreenBindKeyOffset, _o.YawAngle, _o.PitchAngle, centerPosOffset, _o.NullMask);
		}

		// Token: 0x0401056C RID: 66924
		private Table __p;
	}
}
