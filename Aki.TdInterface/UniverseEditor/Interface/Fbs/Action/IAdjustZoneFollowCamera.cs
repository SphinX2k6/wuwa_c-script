using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067DB RID: 26587
	public struct IAdjustZoneFollowCamera : IFlatbufferObject
	{
		// Token: 0x1700C346 RID: 49990
		// (get) Token: 0x0602D623 RID: 185891 RVA: 0x00636EAC File Offset: 0x006350AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D624 RID: 185892 RVA: 0x00636EB9 File Offset: 0x006350B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D625 RID: 185893 RVA: 0x00636EC0 File Offset: 0x006350C0
		public static IAdjustZoneFollowCamera GetRootAsIAdjustZoneFollowCamera(ByteBuffer _bb)
		{
			return IAdjustZoneFollowCamera.GetRootAsIAdjustZoneFollowCamera(_bb, default(IAdjustZoneFollowCamera));
		}

		// Token: 0x0602D626 RID: 185894 RVA: 0x00636EDC File Offset: 0x006350DC
		public static IAdjustZoneFollowCamera GetRootAsIAdjustZoneFollowCamera(ByteBuffer _bb, IAdjustZoneFollowCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D627 RID: 185895 RVA: 0x00636EF9 File Offset: 0x006350F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D628 RID: 185896 RVA: 0x00636F08 File Offset: 0x00635108
		public IAdjustZoneFollowCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C347 RID: 49991
		// (get) Token: 0x0602D629 RID: 185897 RVA: 0x00636F18 File Offset: 0x00635118
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

		// Token: 0x1700C348 RID: 49992
		// (get) Token: 0x0602D62A RID: 185898 RVA: 0x00636F54 File Offset: 0x00635154
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

		// Token: 0x1700C349 RID: 49993
		// (get) Token: 0x0602D62B RID: 185899 RVA: 0x00636F90 File Offset: 0x00635190
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

		// Token: 0x1700C34A RID: 49994
		// (get) Token: 0x0602D62C RID: 185900 RVA: 0x00636FD0 File Offset: 0x006351D0
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

		// Token: 0x1700C34B RID: 49995
		// (get) Token: 0x0602D62D RID: 185901 RVA: 0x00637030 File Offset: 0x00635230
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

		// Token: 0x1700C34C RID: 49996
		// (get) Token: 0x0602D62E RID: 185902 RVA: 0x00637074 File Offset: 0x00635274
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

		// Token: 0x1700C34D RID: 49997
		// (get) Token: 0x0602D62F RID: 185903 RVA: 0x006370D4 File Offset: 0x006352D4
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

		// Token: 0x1700C34E RID: 49998
		// (get) Token: 0x0602D630 RID: 185904 RVA: 0x00637118 File Offset: 0x00635318
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

		// Token: 0x1700C34F RID: 49999
		// (get) Token: 0x0602D631 RID: 185905 RVA: 0x0063715C File Offset: 0x0063535C
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

		// Token: 0x1700C350 RID: 50000
		// (get) Token: 0x0602D632 RID: 185906 RVA: 0x006371A0 File Offset: 0x006353A0
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

		// Token: 0x1700C351 RID: 50001
		// (get) Token: 0x0602D633 RID: 185907 RVA: 0x00637200 File Offset: 0x00635400
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

		// Token: 0x1700C352 RID: 50002
		// (get) Token: 0x0602D634 RID: 185908 RVA: 0x00637260 File Offset: 0x00635460
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

		// Token: 0x1700C353 RID: 50003
		// (get) Token: 0x0602D635 RID: 185909 RVA: 0x006372A4 File Offset: 0x006354A4
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

		// Token: 0x1700C354 RID: 50004
		// (get) Token: 0x0602D636 RID: 185910 RVA: 0x006372E8 File Offset: 0x006354E8
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

		// Token: 0x1700C355 RID: 50005
		// (get) Token: 0x0602D637 RID: 185911 RVA: 0x0063732C File Offset: 0x0063552C
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

		// Token: 0x1700C356 RID: 50006
		// (get) Token: 0x0602D638 RID: 185912 RVA: 0x00637370 File Offset: 0x00635570
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

		// Token: 0x1700C357 RID: 50007
		// (get) Token: 0x0602D639 RID: 185913 RVA: 0x006373B4 File Offset: 0x006355B4
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C358 RID: 50008
		// (get) Token: 0x0602D63A RID: 185914 RVA: 0x006373F4 File Offset: 0x006355F4
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

		// Token: 0x0602D63B RID: 185915 RVA: 0x00637434 File Offset: 0x00635634
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D63C RID: 185916 RVA: 0x0063747C File Offset: 0x0063567C
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602D63D RID: 185917 RVA: 0x00637498 File Offset: 0x00635698
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602D63E RID: 185918 RVA: 0x006374B4 File Offset: 0x006356B4
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602D63F RID: 185919 RVA: 0x006374D0 File Offset: 0x006356D0
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700C359 RID: 50009
		// (get) Token: 0x0602D640 RID: 185920 RVA: 0x006374EC File Offset: 0x006356EC
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C35A RID: 50010
		// (get) Token: 0x0602D641 RID: 185921 RVA: 0x0063752C File Offset: 0x0063572C
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C35B RID: 50011
		// (get) Token: 0x0602D642 RID: 185922 RVA: 0x0063756C File Offset: 0x0063576C
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

		// Token: 0x0602D643 RID: 185923 RVA: 0x006375A4 File Offset: 0x006357A4
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602D644 RID: 185924 RVA: 0x006375B4 File Offset: 0x006357B4
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700C35C RID: 50012
		// (get) Token: 0x0602D645 RID: 185925 RVA: 0x006375C4 File Offset: 0x006357C4
		public bool IsFollowPlayer
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C35D RID: 50013
		// (get) Token: 0x0602D646 RID: 185926 RVA: 0x00637604 File Offset: 0x00635804
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

		// Token: 0x1700C35E RID: 50014
		// (get) Token: 0x0602D647 RID: 185927 RVA: 0x00637644 File Offset: 0x00635844
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

		// Token: 0x0602D648 RID: 185928 RVA: 0x00637684 File Offset: 0x00635884
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

		// Token: 0x0602D649 RID: 185929 RVA: 0x00637764 File Offset: 0x00635964
		public static void StartIAdjustZoneFollowCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(25);
		}

		// Token: 0x0602D64A RID: 185930 RVA: 0x0063776E File Offset: 0x0063596E
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D64B RID: 185931 RVA: 0x00637779 File Offset: 0x00635979
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602D64C RID: 185932 RVA: 0x00637784 File Offset: 0x00635984
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602D64D RID: 185933 RVA: 0x00637797 File Offset: 0x00635997
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602D64E RID: 185934 RVA: 0x006377A7 File Offset: 0x006359A7
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602D64F RID: 185935 RVA: 0x006377BA File Offset: 0x006359BA
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602D650 RID: 185936 RVA: 0x006377CA File Offset: 0x006359CA
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602D651 RID: 185937 RVA: 0x006377DD File Offset: 0x006359DD
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602D652 RID: 185938 RVA: 0x006377F0 File Offset: 0x006359F0
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602D653 RID: 185939 RVA: 0x00637803 File Offset: 0x00635A03
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602D654 RID: 185940 RVA: 0x00637814 File Offset: 0x00635A14
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602D655 RID: 185941 RVA: 0x00637825 File Offset: 0x00635A25
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602D656 RID: 185942 RVA: 0x00637839 File Offset: 0x00635A39
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602D657 RID: 185943 RVA: 0x0063784D File Offset: 0x00635A4D
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602D658 RID: 185944 RVA: 0x00637861 File Offset: 0x00635A61
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602D659 RID: 185945 RVA: 0x00637875 File Offset: 0x00635A75
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602D65A RID: 185946 RVA: 0x00637889 File Offset: 0x00635A89
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602D65B RID: 185947 RVA: 0x00637895 File Offset: 0x00635A95
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602D65C RID: 185948 RVA: 0x006378A1 File Offset: 0x00635AA1
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602D65D RID: 185949 RVA: 0x006378AD File Offset: 0x00635AAD
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602D65E RID: 185950 RVA: 0x006378B9 File Offset: 0x00635AB9
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602D65F RID: 185951 RVA: 0x006378C5 File Offset: 0x00635AC5
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602D660 RID: 185952 RVA: 0x006378D6 File Offset: 0x00635AD6
		public static void AddIsFollowPlayer(FlatBufferBuilder builder, bool isFollowPlayer)
		{
			builder.AddBool(22, isFollowPlayer, false);
		}

		// Token: 0x0602D661 RID: 185953 RVA: 0x006378E2 File Offset: 0x00635AE2
		public static void AddSceneActorRefEntityId(FlatBufferBuilder builder, int sceneActorRefEntityId)
		{
			builder.AddInt(23, sceneActorRefEntityId, 0);
		}

		// Token: 0x0602D662 RID: 185954 RVA: 0x006378EE File Offset: 0x00635AEE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(24, nullMask, 0);
		}

		// Token: 0x0602D663 RID: 185955 RVA: 0x006378FA File Offset: 0x00635AFA
		public static Offset<IAdjustZoneFollowCamera> EndIAdjustZoneFollowCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustZoneFollowCamera>(builder.EndTable());
		}

		// Token: 0x0602D664 RID: 185956 RVA: 0x00637908 File Offset: 0x00635B08
		public IAdjustZoneFollowCameraT UnPack()
		{
			IAdjustZoneFollowCameraT adjustZoneFollowCameraT = new IAdjustZoneFollowCameraT();
			this.UnPackTo(adjustZoneFollowCameraT);
			return adjustZoneFollowCameraT;
		}

		// Token: 0x0602D665 RID: 185957 RVA: 0x00637924 File Offset: 0x00635B24
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

		// Token: 0x0602D666 RID: 185958 RVA: 0x00637BF8 File Offset: 0x00635DF8
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

		// Token: 0x04011464 RID: 70756
		private Table __p;
	}
}
