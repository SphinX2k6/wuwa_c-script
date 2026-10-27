using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006176 RID: 24950
	public struct IAdjustZoneFollowCamera : IFlatbufferObject
	{
		// Token: 0x1700B9D6 RID: 47574
		// (get) Token: 0x0602AF2A RID: 175914 RVA: 0x005ECCD0 File Offset: 0x005EAED0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AF2B RID: 175915 RVA: 0x005ECCDD File Offset: 0x005EAEDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AF2C RID: 175916 RVA: 0x005ECCE4 File Offset: 0x005EAEE4
		public static IAdjustZoneFollowCamera GetRootAsIAdjustZoneFollowCamera(ByteBuffer _bb)
		{
			return IAdjustZoneFollowCamera.GetRootAsIAdjustZoneFollowCamera(_bb, default(IAdjustZoneFollowCamera));
		}

		// Token: 0x0602AF2D RID: 175917 RVA: 0x005ECD00 File Offset: 0x005EAF00
		public static IAdjustZoneFollowCamera GetRootAsIAdjustZoneFollowCamera(ByteBuffer _bb, IAdjustZoneFollowCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AF2E RID: 175918 RVA: 0x005ECD1D File Offset: 0x005EAF1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AF2F RID: 175919 RVA: 0x005ECD2C File Offset: 0x005EAF2C
		public IAdjustZoneFollowCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B9D7 RID: 47575
		// (get) Token: 0x0602AF30 RID: 175920 RVA: 0x005ECD3C File Offset: 0x005EAF3C
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

		// Token: 0x1700B9D8 RID: 47576
		// (get) Token: 0x0602AF31 RID: 175921 RVA: 0x005ECD78 File Offset: 0x005EAF78
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

		// Token: 0x1700B9D9 RID: 47577
		// (get) Token: 0x0602AF32 RID: 175922 RVA: 0x005ECDB4 File Offset: 0x005EAFB4
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

		// Token: 0x1700B9DA RID: 47578
		// (get) Token: 0x0602AF33 RID: 175923 RVA: 0x005ECDF4 File Offset: 0x005EAFF4
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

		// Token: 0x1700B9DB RID: 47579
		// (get) Token: 0x0602AF34 RID: 175924 RVA: 0x005ECE54 File Offset: 0x005EB054
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

		// Token: 0x1700B9DC RID: 47580
		// (get) Token: 0x0602AF35 RID: 175925 RVA: 0x005ECE98 File Offset: 0x005EB098
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

		// Token: 0x1700B9DD RID: 47581
		// (get) Token: 0x0602AF36 RID: 175926 RVA: 0x005ECEF8 File Offset: 0x005EB0F8
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

		// Token: 0x1700B9DE RID: 47582
		// (get) Token: 0x0602AF37 RID: 175927 RVA: 0x005ECF3C File Offset: 0x005EB13C
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

		// Token: 0x1700B9DF RID: 47583
		// (get) Token: 0x0602AF38 RID: 175928 RVA: 0x005ECF80 File Offset: 0x005EB180
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

		// Token: 0x1700B9E0 RID: 47584
		// (get) Token: 0x0602AF39 RID: 175929 RVA: 0x005ECFC4 File Offset: 0x005EB1C4
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

		// Token: 0x1700B9E1 RID: 47585
		// (get) Token: 0x0602AF3A RID: 175930 RVA: 0x005ED024 File Offset: 0x005EB224
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

		// Token: 0x1700B9E2 RID: 47586
		// (get) Token: 0x0602AF3B RID: 175931 RVA: 0x005ED084 File Offset: 0x005EB284
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

		// Token: 0x1700B9E3 RID: 47587
		// (get) Token: 0x0602AF3C RID: 175932 RVA: 0x005ED0C8 File Offset: 0x005EB2C8
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

		// Token: 0x1700B9E4 RID: 47588
		// (get) Token: 0x0602AF3D RID: 175933 RVA: 0x005ED10C File Offset: 0x005EB30C
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

		// Token: 0x1700B9E5 RID: 47589
		// (get) Token: 0x0602AF3E RID: 175934 RVA: 0x005ED150 File Offset: 0x005EB350
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

		// Token: 0x1700B9E6 RID: 47590
		// (get) Token: 0x0602AF3F RID: 175935 RVA: 0x005ED194 File Offset: 0x005EB394
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

		// Token: 0x1700B9E7 RID: 47591
		// (get) Token: 0x0602AF40 RID: 175936 RVA: 0x005ED1D8 File Offset: 0x005EB3D8
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B9E8 RID: 47592
		// (get) Token: 0x0602AF41 RID: 175937 RVA: 0x005ED218 File Offset: 0x005EB418
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

		// Token: 0x0602AF42 RID: 175938 RVA: 0x005ED258 File Offset: 0x005EB458
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602AF43 RID: 175939 RVA: 0x005ED2A0 File Offset: 0x005EB4A0
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602AF44 RID: 175940 RVA: 0x005ED2BC File Offset: 0x005EB4BC
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602AF45 RID: 175941 RVA: 0x005ED2D8 File Offset: 0x005EB4D8
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602AF46 RID: 175942 RVA: 0x005ED2F4 File Offset: 0x005EB4F4
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700B9E9 RID: 47593
		// (get) Token: 0x0602AF47 RID: 175943 RVA: 0x005ED310 File Offset: 0x005EB510
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B9EA RID: 47594
		// (get) Token: 0x0602AF48 RID: 175944 RVA: 0x005ED350 File Offset: 0x005EB550
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B9EB RID: 47595
		// (get) Token: 0x0602AF49 RID: 175945 RVA: 0x005ED390 File Offset: 0x005EB590
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

		// Token: 0x0602AF4A RID: 175946 RVA: 0x005ED3C8 File Offset: 0x005EB5C8
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602AF4B RID: 175947 RVA: 0x005ED3D8 File Offset: 0x005EB5D8
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700B9EC RID: 47596
		// (get) Token: 0x0602AF4C RID: 175948 RVA: 0x005ED3E8 File Offset: 0x005EB5E8
		public bool IsFollowPlayer
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B9ED RID: 47597
		// (get) Token: 0x0602AF4D RID: 175949 RVA: 0x005ED428 File Offset: 0x005EB628
		public int SceneActorRefEntityId
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B9EE RID: 47598
		// (get) Token: 0x0602AF4E RID: 175950 RVA: 0x005ED468 File Offset: 0x005EB668
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602AF4F RID: 175951 RVA: 0x005ED4A8 File Offset: 0x005EB6A8
		public static Offset<IAdjustZoneFollowCamera> CreateIAdjustZoneFollowCamera(FlatBufferBuilder builder, EAdjustPlayerCamera Type = EAdjustPlayerCamera.Basic, int Priority = 0, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>), float FadeOutTime = 0f, Offset<IBaseCurve> FadeOutCurveOffset = default(Offset<IBaseCurve>), float ArmLength = 0f, float MinumArmLength = 0f, float MaxiumArmLength = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArmOffsetOffset = default(Offset<IVectorInfo>), float YawLimitMin = 0f, float YawLimitMax = 0f, float PitchLimitMin = 0f, float PitchLimitMax = 0f, float Fov = 0f, bool IsDisableResetFocus = false, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool IsDisableCollision = false, bool IsDisableDither = false, StringOffset SubScreenBindKeyOffset = default(StringOffset), bool IsFollowPlayer = false, int SceneActorRefEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(25);
			IAdjustZoneFollowCamera.AddSceneActorRefEntityId(builder, SceneActorRefEntityId);
			IAdjustZoneFollowCamera.AddSubScreenBindKey(builder, SubScreenBindKeyOffset);
			IAdjustZoneFollowCamera.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustZoneFollowCamera.AddFov(builder, Fov);
			IAdjustZoneFollowCamera.AddPitchLimitMax(builder, PitchLimitMax);
			IAdjustZoneFollowCamera.AddPitchLimitMin(builder, PitchLimitMin);
			IAdjustZoneFollowCamera.AddYawLimitMax(builder, YawLimitMax);
			IAdjustZoneFollowCamera.AddYawLimitMin(builder, YawLimitMin);
			IAdjustZoneFollowCamera.AddArmOffset(builder, ArmOffsetOffset);
			IAdjustZoneFollowCamera.AddOffset(builder, OffsetOffset);
			IAdjustZoneFollowCamera.AddMaxiumArmLength(builder, MaxiumArmLength);
			IAdjustZoneFollowCamera.AddMinumArmLength(builder, MinumArmLength);
			IAdjustZoneFollowCamera.AddArmLength(builder, ArmLength);
			IAdjustZoneFollowCamera.AddFadeOutCurve(builder, FadeOutCurveOffset);
			IAdjustZoneFollowCamera.AddFadeOutTime(builder, FadeOutTime);
			IAdjustZoneFollowCamera.AddFadeInCurve(builder, FadeInCurveOffset);
			IAdjustZoneFollowCamera.AddFadeInTime(builder, FadeInTime);
			IAdjustZoneFollowCamera.AddPriority(builder, Priority);
			IAdjustZoneFollowCamera.AddNullMask(builder, NullMask);
			IAdjustZoneFollowCamera.AddIsFollowPlayer(builder, IsFollowPlayer);
			IAdjustZoneFollowCamera.AddIsDisableDither(builder, IsDisableDither);
			IAdjustZoneFollowCamera.AddIsDisableCollision(builder, IsDisableCollision);
			IAdjustZoneFollowCamera.AddGravityDirectionType(builder, GravityDirection_type);
			IAdjustZoneFollowCamera.AddIsDisableResetFocus(builder, IsDisableResetFocus);
			IAdjustZoneFollowCamera.AddType(builder, Type);
			return IAdjustZoneFollowCamera.EndIAdjustZoneFollowCamera(builder);
		}

		// Token: 0x0602AF50 RID: 175952 RVA: 0x005ED588 File Offset: 0x005EB788
		public static void StartIAdjustZoneFollowCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(25);
		}

		// Token: 0x0602AF51 RID: 175953 RVA: 0x005ED592 File Offset: 0x005EB792
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AF52 RID: 175954 RVA: 0x005ED59D File Offset: 0x005EB79D
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602AF53 RID: 175955 RVA: 0x005ED5A8 File Offset: 0x005EB7A8
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602AF54 RID: 175956 RVA: 0x005ED5BB File Offset: 0x005EB7BB
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602AF55 RID: 175957 RVA: 0x005ED5CB File Offset: 0x005EB7CB
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602AF56 RID: 175958 RVA: 0x005ED5DE File Offset: 0x005EB7DE
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602AF57 RID: 175959 RVA: 0x005ED5EE File Offset: 0x005EB7EE
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602AF58 RID: 175960 RVA: 0x005ED601 File Offset: 0x005EB801
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602AF59 RID: 175961 RVA: 0x005ED614 File Offset: 0x005EB814
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602AF5A RID: 175962 RVA: 0x005ED627 File Offset: 0x005EB827
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602AF5B RID: 175963 RVA: 0x005ED638 File Offset: 0x005EB838
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602AF5C RID: 175964 RVA: 0x005ED649 File Offset: 0x005EB849
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602AF5D RID: 175965 RVA: 0x005ED65D File Offset: 0x005EB85D
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602AF5E RID: 175966 RVA: 0x005ED671 File Offset: 0x005EB871
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602AF5F RID: 175967 RVA: 0x005ED685 File Offset: 0x005EB885
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602AF60 RID: 175968 RVA: 0x005ED699 File Offset: 0x005EB899
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602AF61 RID: 175969 RVA: 0x005ED6AD File Offset: 0x005EB8AD
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602AF62 RID: 175970 RVA: 0x005ED6B9 File Offset: 0x005EB8B9
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602AF63 RID: 175971 RVA: 0x005ED6C5 File Offset: 0x005EB8C5
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602AF64 RID: 175972 RVA: 0x005ED6D1 File Offset: 0x005EB8D1
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602AF65 RID: 175973 RVA: 0x005ED6DD File Offset: 0x005EB8DD
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602AF66 RID: 175974 RVA: 0x005ED6E9 File Offset: 0x005EB8E9
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602AF67 RID: 175975 RVA: 0x005ED6FA File Offset: 0x005EB8FA
		public static void AddIsFollowPlayer(FlatBufferBuilder builder, bool isFollowPlayer)
		{
			builder.AddBool(22, isFollowPlayer, false);
		}

		// Token: 0x0602AF68 RID: 175976 RVA: 0x005ED706 File Offset: 0x005EB906
		public static void AddSceneActorRefEntityId(FlatBufferBuilder builder, int sceneActorRefEntityId)
		{
			builder.AddInt(23, sceneActorRefEntityId, 0);
		}

		// Token: 0x0602AF69 RID: 175977 RVA: 0x005ED712 File Offset: 0x005EB912
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(24, nullMask, 0);
		}

		// Token: 0x0602AF6A RID: 175978 RVA: 0x005ED71E File Offset: 0x005EB91E
		public static Offset<IAdjustZoneFollowCamera> EndIAdjustZoneFollowCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustZoneFollowCamera>(builder.EndTable());
		}

		// Token: 0x0602AF6B RID: 175979 RVA: 0x005ED72C File Offset: 0x005EB92C
		public IAdjustZoneFollowCameraT UnPack()
		{
			IAdjustZoneFollowCameraT adjustZoneFollowCameraT = new IAdjustZoneFollowCameraT();
			this.UnPackTo(adjustZoneFollowCameraT);
			return adjustZoneFollowCameraT;
		}

		// Token: 0x0602AF6C RID: 175980 RVA: 0x005ED748 File Offset: 0x005EB948
		public void UnPackTo(IAdjustZoneFollowCameraT _o)
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
			_o.IsFollowPlayer = this.IsFollowPlayer;
			_o.SceneActorRefEntityId = this.SceneActorRefEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602AF6D RID: 175981 RVA: 0x005EDA1C File Offset: 0x005EBC1C
		public static Offset<IAdjustZoneFollowCamera> Pack(FlatBufferBuilder builder, IAdjustZoneFollowCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustZoneFollowCamera>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			Offset<IBaseCurve> fadeOutCurveOffset = (_o.FadeOutCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeOutCurve);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> armOffsetOffset = (_o.ArmOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArmOffset);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			StringOffset subScreenBindKeyOffset = (_o.SubScreenBindKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenBindKey);
			return IAdjustZoneFollowCamera.CreateIAdjustZoneFollowCamera(builder, _o.Type, _o.Priority, _o.FadeInTime, fadeInCurveOffset, _o.FadeOutTime, fadeOutCurveOffset, _o.ArmLength, _o.MinumArmLength, _o.MaxiumArmLength, offsetOffset, armOffsetOffset, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.Fov, _o.IsDisableResetFocus, gravityDirection_type, gravityDirectionOffset, _o.IsDisableCollision, _o.IsDisableDither, subScreenBindKeyOffset, _o.IsFollowPlayer, _o.SceneActorRefEntityId, _o.NullMask);
		}

		// Token: 0x0401065D RID: 67165
		private Table __p;
	}
}
