using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067AB RID: 26539
	public struct IAdjustDialogCamera : IFlatbufferObject
	{
		// Token: 0x1700C196 RID: 49558
		// (get) Token: 0x0602D1A2 RID: 184738 RVA: 0x0062AED3 File Offset: 0x006290D3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D1A3 RID: 184739 RVA: 0x0062AEE0 File Offset: 0x006290E0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D1A4 RID: 184740 RVA: 0x0062AEE8 File Offset: 0x006290E8
		public static IAdjustDialogCamera GetRootAsIAdjustDialogCamera(ByteBuffer _bb)
		{
			return IAdjustDialogCamera.GetRootAsIAdjustDialogCamera(_bb, default(IAdjustDialogCamera));
		}

		// Token: 0x0602D1A5 RID: 184741 RVA: 0x0062AF04 File Offset: 0x00629104
		public static IAdjustDialogCamera GetRootAsIAdjustDialogCamera(ByteBuffer _bb, IAdjustDialogCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D1A6 RID: 184742 RVA: 0x0062AF21 File Offset: 0x00629121
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D1A7 RID: 184743 RVA: 0x0062AF30 File Offset: 0x00629130
		public IAdjustDialogCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C197 RID: 49559
		// (get) Token: 0x0602D1A8 RID: 184744 RVA: 0x0062AF40 File Offset: 0x00629140
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

		// Token: 0x1700C198 RID: 49560
		// (get) Token: 0x0602D1A9 RID: 184745 RVA: 0x0062AF7C File Offset: 0x0062917C
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

		// Token: 0x1700C199 RID: 49561
		// (get) Token: 0x0602D1AA RID: 184746 RVA: 0x0062AFB8 File Offset: 0x006291B8
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

		// Token: 0x1700C19A RID: 49562
		// (get) Token: 0x0602D1AB RID: 184747 RVA: 0x0062AFF8 File Offset: 0x006291F8
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

		// Token: 0x1700C19B RID: 49563
		// (get) Token: 0x0602D1AC RID: 184748 RVA: 0x0062B058 File Offset: 0x00629258
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

		// Token: 0x1700C19C RID: 49564
		// (get) Token: 0x0602D1AD RID: 184749 RVA: 0x0062B09C File Offset: 0x0062929C
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

		// Token: 0x1700C19D RID: 49565
		// (get) Token: 0x0602D1AE RID: 184750 RVA: 0x0062B0FC File Offset: 0x006292FC
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

		// Token: 0x1700C19E RID: 49566
		// (get) Token: 0x0602D1AF RID: 184751 RVA: 0x0062B140 File Offset: 0x00629340
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

		// Token: 0x1700C19F RID: 49567
		// (get) Token: 0x0602D1B0 RID: 184752 RVA: 0x0062B184 File Offset: 0x00629384
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

		// Token: 0x1700C1A0 RID: 49568
		// (get) Token: 0x0602D1B1 RID: 184753 RVA: 0x0062B1C8 File Offset: 0x006293C8
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

		// Token: 0x1700C1A1 RID: 49569
		// (get) Token: 0x0602D1B2 RID: 184754 RVA: 0x0062B228 File Offset: 0x00629428
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

		// Token: 0x1700C1A2 RID: 49570
		// (get) Token: 0x0602D1B3 RID: 184755 RVA: 0x0062B288 File Offset: 0x00629488
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

		// Token: 0x1700C1A3 RID: 49571
		// (get) Token: 0x0602D1B4 RID: 184756 RVA: 0x0062B2CC File Offset: 0x006294CC
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

		// Token: 0x1700C1A4 RID: 49572
		// (get) Token: 0x0602D1B5 RID: 184757 RVA: 0x0062B310 File Offset: 0x00629510
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

		// Token: 0x1700C1A5 RID: 49573
		// (get) Token: 0x0602D1B6 RID: 184758 RVA: 0x0062B354 File Offset: 0x00629554
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

		// Token: 0x1700C1A6 RID: 49574
		// (get) Token: 0x0602D1B7 RID: 184759 RVA: 0x0062B398 File Offset: 0x00629598
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

		// Token: 0x1700C1A7 RID: 49575
		// (get) Token: 0x0602D1B8 RID: 184760 RVA: 0x0062B3DC File Offset: 0x006295DC
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1A8 RID: 49576
		// (get) Token: 0x0602D1B9 RID: 184761 RVA: 0x0062B41C File Offset: 0x0062961C
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

		// Token: 0x0602D1BA RID: 184762 RVA: 0x0062B45C File Offset: 0x0062965C
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D1BB RID: 184763 RVA: 0x0062B4A4 File Offset: 0x006296A4
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602D1BC RID: 184764 RVA: 0x0062B4C0 File Offset: 0x006296C0
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602D1BD RID: 184765 RVA: 0x0062B4DC File Offset: 0x006296DC
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602D1BE RID: 184766 RVA: 0x0062B4F8 File Offset: 0x006296F8
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700C1A9 RID: 49577
		// (get) Token: 0x0602D1BF RID: 184767 RVA: 0x0062B514 File Offset: 0x00629714
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1AA RID: 49578
		// (get) Token: 0x0602D1C0 RID: 184768 RVA: 0x0062B554 File Offset: 0x00629754
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1AB RID: 49579
		// (get) Token: 0x0602D1C1 RID: 184769 RVA: 0x0062B594 File Offset: 0x00629794
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

		// Token: 0x0602D1C2 RID: 184770 RVA: 0x0062B5CC File Offset: 0x006297CC
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602D1C3 RID: 184771 RVA: 0x0062B5DC File Offset: 0x006297DC
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700C1AC RID: 49580
		// (get) Token: 0x0602D1C4 RID: 184772 RVA: 0x0062B5EC File Offset: 0x006297EC
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

		// Token: 0x1700C1AD RID: 49581
		// (get) Token: 0x0602D1C5 RID: 184773 RVA: 0x0062B630 File Offset: 0x00629830
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

		// Token: 0x1700C1AE RID: 49582
		// (get) Token: 0x0602D1C6 RID: 184774 RVA: 0x0062B674 File Offset: 0x00629874
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

		// Token: 0x1700C1AF RID: 49583
		// (get) Token: 0x0602D1C7 RID: 184775 RVA: 0x0062B6D4 File Offset: 0x006298D4
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

		// Token: 0x0602D1C8 RID: 184776 RVA: 0x0062B714 File Offset: 0x00629914
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

		// Token: 0x0602D1C9 RID: 184777 RVA: 0x0062B7FC File Offset: 0x006299FC
		public static void StartIAdjustDialogCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(26);
		}

		// Token: 0x0602D1CA RID: 184778 RVA: 0x0062B806 File Offset: 0x00629A06
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D1CB RID: 184779 RVA: 0x0062B811 File Offset: 0x00629A11
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602D1CC RID: 184780 RVA: 0x0062B81C File Offset: 0x00629A1C
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602D1CD RID: 184781 RVA: 0x0062B82F File Offset: 0x00629A2F
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602D1CE RID: 184782 RVA: 0x0062B83F File Offset: 0x00629A3F
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602D1CF RID: 184783 RVA: 0x0062B852 File Offset: 0x00629A52
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602D1D0 RID: 184784 RVA: 0x0062B862 File Offset: 0x00629A62
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602D1D1 RID: 184785 RVA: 0x0062B875 File Offset: 0x00629A75
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602D1D2 RID: 184786 RVA: 0x0062B888 File Offset: 0x00629A88
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602D1D3 RID: 184787 RVA: 0x0062B89B File Offset: 0x00629A9B
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602D1D4 RID: 184788 RVA: 0x0062B8AC File Offset: 0x00629AAC
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602D1D5 RID: 184789 RVA: 0x0062B8BD File Offset: 0x00629ABD
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602D1D6 RID: 184790 RVA: 0x0062B8D1 File Offset: 0x00629AD1
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602D1D7 RID: 184791 RVA: 0x0062B8E5 File Offset: 0x00629AE5
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602D1D8 RID: 184792 RVA: 0x0062B8F9 File Offset: 0x00629AF9
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602D1D9 RID: 184793 RVA: 0x0062B90D File Offset: 0x00629B0D
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602D1DA RID: 184794 RVA: 0x0062B921 File Offset: 0x00629B21
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602D1DB RID: 184795 RVA: 0x0062B92D File Offset: 0x00629B2D
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602D1DC RID: 184796 RVA: 0x0062B939 File Offset: 0x00629B39
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602D1DD RID: 184797 RVA: 0x0062B945 File Offset: 0x00629B45
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602D1DE RID: 184798 RVA: 0x0062B951 File Offset: 0x00629B51
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602D1DF RID: 184799 RVA: 0x0062B95D File Offset: 0x00629B5D
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602D1E0 RID: 184800 RVA: 0x0062B96E File Offset: 0x00629B6E
		public static void AddYawAngle(FlatBufferBuilder builder, float yawAngle)
		{
			builder.AddFloat(22, yawAngle, 0.0);
		}

		// Token: 0x0602D1E1 RID: 184801 RVA: 0x0062B982 File Offset: 0x00629B82
		public static void AddPitchAngle(FlatBufferBuilder builder, float pitchAngle)
		{
			builder.AddFloat(23, pitchAngle, 0.0);
		}

		// Token: 0x0602D1E2 RID: 184802 RVA: 0x0062B996 File Offset: 0x00629B96
		public static void AddCenterPos(FlatBufferBuilder builder, Offset<IVectorInfo> centerPosOffset)
		{
			builder.AddOffset(24, centerPosOffset.Value, 0);
		}

		// Token: 0x0602D1E3 RID: 184803 RVA: 0x0062B9A7 File Offset: 0x00629BA7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(25, nullMask, 0);
		}

		// Token: 0x0602D1E4 RID: 184804 RVA: 0x0062B9B3 File Offset: 0x00629BB3
		public static Offset<IAdjustDialogCamera> EndIAdjustDialogCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustDialogCamera>(builder.EndTable());
		}

		// Token: 0x0602D1E5 RID: 184805 RVA: 0x0062B9C0 File Offset: 0x00629BC0
		public IAdjustDialogCameraT UnPack()
		{
			IAdjustDialogCameraT adjustDialogCameraT = new IAdjustDialogCameraT();
			this.UnPackTo(adjustDialogCameraT);
			return adjustDialogCameraT;
		}

		// Token: 0x0602D1E6 RID: 184806 RVA: 0x0062B9DC File Offset: 0x00629BDC
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

		// Token: 0x0602D1E7 RID: 184807 RVA: 0x0062BCE0 File Offset: 0x00629EE0
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

		// Token: 0x04011373 RID: 70515
		private Table __p;
	}
}
