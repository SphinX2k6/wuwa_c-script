using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200616D RID: 24941
	public struct IAdjustPlayerCameraType : IFlatbufferObject
	{
		// Token: 0x1700B9A0 RID: 47520
		// (get) Token: 0x0602AE86 RID: 175750 RVA: 0x005EB4B8 File Offset: 0x005E96B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AE87 RID: 175751 RVA: 0x005EB4C5 File Offset: 0x005E96C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AE88 RID: 175752 RVA: 0x005EB4CC File Offset: 0x005E96CC
		public static IAdjustPlayerCameraType GetRootAsIAdjustPlayerCameraType(ByteBuffer _bb)
		{
			return IAdjustPlayerCameraType.GetRootAsIAdjustPlayerCameraType(_bb, default(IAdjustPlayerCameraType));
		}

		// Token: 0x0602AE89 RID: 175753 RVA: 0x005EB4E8 File Offset: 0x005E96E8
		public static IAdjustPlayerCameraType GetRootAsIAdjustPlayerCameraType(ByteBuffer _bb, IAdjustPlayerCameraType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AE8A RID: 175754 RVA: 0x005EB505 File Offset: 0x005E9705
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AE8B RID: 175755 RVA: 0x005EB514 File Offset: 0x005E9714
		public IAdjustPlayerCameraType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B9A1 RID: 47521
		// (get) Token: 0x0602AE8C RID: 175756 RVA: 0x005EB524 File Offset: 0x005E9724
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

		// Token: 0x1700B9A2 RID: 47522
		// (get) Token: 0x0602AE8D RID: 175757 RVA: 0x005EB560 File Offset: 0x005E9760
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

		// Token: 0x1700B9A3 RID: 47523
		// (get) Token: 0x0602AE8E RID: 175758 RVA: 0x005EB59C File Offset: 0x005E979C
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

		// Token: 0x1700B9A4 RID: 47524
		// (get) Token: 0x0602AE8F RID: 175759 RVA: 0x005EB5DC File Offset: 0x005E97DC
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

		// Token: 0x1700B9A5 RID: 47525
		// (get) Token: 0x0602AE90 RID: 175760 RVA: 0x005EB63C File Offset: 0x005E983C
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

		// Token: 0x1700B9A6 RID: 47526
		// (get) Token: 0x0602AE91 RID: 175761 RVA: 0x005EB680 File Offset: 0x005E9880
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

		// Token: 0x1700B9A7 RID: 47527
		// (get) Token: 0x0602AE92 RID: 175762 RVA: 0x005EB6E0 File Offset: 0x005E98E0
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

		// Token: 0x1700B9A8 RID: 47528
		// (get) Token: 0x0602AE93 RID: 175763 RVA: 0x005EB724 File Offset: 0x005E9924
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

		// Token: 0x1700B9A9 RID: 47529
		// (get) Token: 0x0602AE94 RID: 175764 RVA: 0x005EB768 File Offset: 0x005E9968
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

		// Token: 0x1700B9AA RID: 47530
		// (get) Token: 0x0602AE95 RID: 175765 RVA: 0x005EB7AC File Offset: 0x005E99AC
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

		// Token: 0x1700B9AB RID: 47531
		// (get) Token: 0x0602AE96 RID: 175766 RVA: 0x005EB80C File Offset: 0x005E9A0C
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

		// Token: 0x1700B9AC RID: 47532
		// (get) Token: 0x0602AE97 RID: 175767 RVA: 0x005EB86C File Offset: 0x005E9A6C
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

		// Token: 0x1700B9AD RID: 47533
		// (get) Token: 0x0602AE98 RID: 175768 RVA: 0x005EB8B0 File Offset: 0x005E9AB0
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

		// Token: 0x1700B9AE RID: 47534
		// (get) Token: 0x0602AE99 RID: 175769 RVA: 0x005EB8F4 File Offset: 0x005E9AF4
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

		// Token: 0x1700B9AF RID: 47535
		// (get) Token: 0x0602AE9A RID: 175770 RVA: 0x005EB938 File Offset: 0x005E9B38
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

		// Token: 0x1700B9B0 RID: 47536
		// (get) Token: 0x0602AE9B RID: 175771 RVA: 0x005EB97C File Offset: 0x005E9B7C
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

		// Token: 0x1700B9B1 RID: 47537
		// (get) Token: 0x0602AE9C RID: 175772 RVA: 0x005EB9C0 File Offset: 0x005E9BC0
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B9B2 RID: 47538
		// (get) Token: 0x0602AE9D RID: 175773 RVA: 0x005EBA00 File Offset: 0x005E9C00
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

		// Token: 0x0602AE9E RID: 175774 RVA: 0x005EBA40 File Offset: 0x005E9C40
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602AE9F RID: 175775 RVA: 0x005EBA88 File Offset: 0x005E9C88
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602AEA0 RID: 175776 RVA: 0x005EBAA4 File Offset: 0x005E9CA4
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602AEA1 RID: 175777 RVA: 0x005EBAC0 File Offset: 0x005E9CC0
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602AEA2 RID: 175778 RVA: 0x005EBADC File Offset: 0x005E9CDC
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700B9B3 RID: 47539
		// (get) Token: 0x0602AEA3 RID: 175779 RVA: 0x005EBAF8 File Offset: 0x005E9CF8
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B9B4 RID: 47540
		// (get) Token: 0x0602AEA4 RID: 175780 RVA: 0x005EBB38 File Offset: 0x005E9D38
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B9B5 RID: 47541
		// (get) Token: 0x0602AEA5 RID: 175781 RVA: 0x005EBB78 File Offset: 0x005E9D78
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

		// Token: 0x0602AEA6 RID: 175782 RVA: 0x005EBBB0 File Offset: 0x005E9DB0
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602AEA7 RID: 175783 RVA: 0x005EBBC0 File Offset: 0x005E9DC0
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700B9B6 RID: 47542
		// (get) Token: 0x0602AEA8 RID: 175784 RVA: 0x005EBBD0 File Offset: 0x005E9DD0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602AEA9 RID: 175785 RVA: 0x005EBC10 File Offset: 0x005E9E10
		public static Offset<IAdjustPlayerCameraType> CreateIAdjustPlayerCameraType(FlatBufferBuilder builder, EAdjustPlayerCamera Type = EAdjustPlayerCamera.Basic, int Priority = 0, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>), float FadeOutTime = 0f, Offset<IBaseCurve> FadeOutCurveOffset = default(Offset<IBaseCurve>), float ArmLength = 0f, float MinumArmLength = 0f, float MaxiumArmLength = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArmOffsetOffset = default(Offset<IVectorInfo>), float YawLimitMin = 0f, float YawLimitMax = 0f, float PitchLimitMin = 0f, float PitchLimitMax = 0f, float Fov = 0f, bool IsDisableResetFocus = false, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool IsDisableCollision = false, bool IsDisableDither = false, StringOffset SubScreenBindKeyOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(23);
			IAdjustPlayerCameraType.AddSubScreenBindKey(builder, SubScreenBindKeyOffset);
			IAdjustPlayerCameraType.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustPlayerCameraType.AddFov(builder, Fov);
			IAdjustPlayerCameraType.AddPitchLimitMax(builder, PitchLimitMax);
			IAdjustPlayerCameraType.AddPitchLimitMin(builder, PitchLimitMin);
			IAdjustPlayerCameraType.AddYawLimitMax(builder, YawLimitMax);
			IAdjustPlayerCameraType.AddYawLimitMin(builder, YawLimitMin);
			IAdjustPlayerCameraType.AddArmOffset(builder, ArmOffsetOffset);
			IAdjustPlayerCameraType.AddOffset(builder, OffsetOffset);
			IAdjustPlayerCameraType.AddMaxiumArmLength(builder, MaxiumArmLength);
			IAdjustPlayerCameraType.AddMinumArmLength(builder, MinumArmLength);
			IAdjustPlayerCameraType.AddArmLength(builder, ArmLength);
			IAdjustPlayerCameraType.AddFadeOutCurve(builder, FadeOutCurveOffset);
			IAdjustPlayerCameraType.AddFadeOutTime(builder, FadeOutTime);
			IAdjustPlayerCameraType.AddFadeInCurve(builder, FadeInCurveOffset);
			IAdjustPlayerCameraType.AddFadeInTime(builder, FadeInTime);
			IAdjustPlayerCameraType.AddPriority(builder, Priority);
			IAdjustPlayerCameraType.AddNullMask(builder, NullMask);
			IAdjustPlayerCameraType.AddIsDisableDither(builder, IsDisableDither);
			IAdjustPlayerCameraType.AddIsDisableCollision(builder, IsDisableCollision);
			IAdjustPlayerCameraType.AddGravityDirectionType(builder, GravityDirection_type);
			IAdjustPlayerCameraType.AddIsDisableResetFocus(builder, IsDisableResetFocus);
			IAdjustPlayerCameraType.AddType(builder, Type);
			return IAdjustPlayerCameraType.EndIAdjustPlayerCameraType(builder);
		}

		// Token: 0x0602AEAA RID: 175786 RVA: 0x005EBCE0 File Offset: 0x005E9EE0
		public static void StartIAdjustPlayerCameraType(FlatBufferBuilder builder)
		{
			builder.StartTable(23);
		}

		// Token: 0x0602AEAB RID: 175787 RVA: 0x005EBCEA File Offset: 0x005E9EEA
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AEAC RID: 175788 RVA: 0x005EBCF5 File Offset: 0x005E9EF5
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602AEAD RID: 175789 RVA: 0x005EBD00 File Offset: 0x005E9F00
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602AEAE RID: 175790 RVA: 0x005EBD13 File Offset: 0x005E9F13
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602AEAF RID: 175791 RVA: 0x005EBD23 File Offset: 0x005E9F23
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602AEB0 RID: 175792 RVA: 0x005EBD36 File Offset: 0x005E9F36
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602AEB1 RID: 175793 RVA: 0x005EBD46 File Offset: 0x005E9F46
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602AEB2 RID: 175794 RVA: 0x005EBD59 File Offset: 0x005E9F59
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602AEB3 RID: 175795 RVA: 0x005EBD6C File Offset: 0x005E9F6C
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602AEB4 RID: 175796 RVA: 0x005EBD7F File Offset: 0x005E9F7F
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602AEB5 RID: 175797 RVA: 0x005EBD90 File Offset: 0x005E9F90
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602AEB6 RID: 175798 RVA: 0x005EBDA1 File Offset: 0x005E9FA1
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602AEB7 RID: 175799 RVA: 0x005EBDB5 File Offset: 0x005E9FB5
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602AEB8 RID: 175800 RVA: 0x005EBDC9 File Offset: 0x005E9FC9
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602AEB9 RID: 175801 RVA: 0x005EBDDD File Offset: 0x005E9FDD
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602AEBA RID: 175802 RVA: 0x005EBDF1 File Offset: 0x005E9FF1
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602AEBB RID: 175803 RVA: 0x005EBE05 File Offset: 0x005EA005
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602AEBC RID: 175804 RVA: 0x005EBE11 File Offset: 0x005EA011
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602AEBD RID: 175805 RVA: 0x005EBE1D File Offset: 0x005EA01D
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602AEBE RID: 175806 RVA: 0x005EBE29 File Offset: 0x005EA029
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602AEBF RID: 175807 RVA: 0x005EBE35 File Offset: 0x005EA035
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602AEC0 RID: 175808 RVA: 0x005EBE41 File Offset: 0x005EA041
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602AEC1 RID: 175809 RVA: 0x005EBE52 File Offset: 0x005EA052
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(22, nullMask, 0);
		}

		// Token: 0x0602AEC2 RID: 175810 RVA: 0x005EBE5E File Offset: 0x005EA05E
		public static Offset<IAdjustPlayerCameraType> EndIAdjustPlayerCameraType(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustPlayerCameraType>(builder.EndTable());
		}

		// Token: 0x0602AEC3 RID: 175811 RVA: 0x005EBE6C File Offset: 0x005EA06C
		public IAdjustPlayerCameraTypeT UnPack()
		{
			IAdjustPlayerCameraTypeT adjustPlayerCameraTypeT = new IAdjustPlayerCameraTypeT();
			this.UnPackTo(adjustPlayerCameraTypeT);
			return adjustPlayerCameraTypeT;
		}

		// Token: 0x0602AEC4 RID: 175812 RVA: 0x005EBE88 File Offset: 0x005EA088
		public void UnPackTo(IAdjustPlayerCameraTypeT _o)
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602AEC5 RID: 175813 RVA: 0x005EC144 File Offset: 0x005EA344
		public static Offset<IAdjustPlayerCameraType> Pack(FlatBufferBuilder builder, IAdjustPlayerCameraTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustPlayerCameraType>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			Offset<IBaseCurve> fadeOutCurveOffset = (_o.FadeOutCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeOutCurve);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> armOffsetOffset = (_o.ArmOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArmOffset);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			StringOffset subScreenBindKeyOffset = (_o.SubScreenBindKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenBindKey);
			return IAdjustPlayerCameraType.CreateIAdjustPlayerCameraType(builder, _o.Type, _o.Priority, _o.FadeInTime, fadeInCurveOffset, _o.FadeOutTime, fadeOutCurveOffset, _o.ArmLength, _o.MinumArmLength, _o.MaxiumArmLength, offsetOffset, armOffsetOffset, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.Fov, _o.IsDisableResetFocus, gravityDirection_type, gravityDirectionOffset, _o.IsDisableCollision, _o.IsDisableDither, subScreenBindKeyOffset, _o.NullMask);
		}

		// Token: 0x04010634 RID: 67124
		private Table __p;
	}
}
