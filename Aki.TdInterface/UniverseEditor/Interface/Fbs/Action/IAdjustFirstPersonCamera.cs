using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067AE RID: 26542
	public struct IAdjustFirstPersonCamera : IFlatbufferObject
	{
		// Token: 0x1700C1C9 RID: 49609
		// (get) Token: 0x0602D21C RID: 184860 RVA: 0x0062C390 File Offset: 0x0062A590
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D21D RID: 184861 RVA: 0x0062C39D File Offset: 0x0062A59D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D21E RID: 184862 RVA: 0x0062C3A4 File Offset: 0x0062A5A4
		public static IAdjustFirstPersonCamera GetRootAsIAdjustFirstPersonCamera(ByteBuffer _bb)
		{
			return IAdjustFirstPersonCamera.GetRootAsIAdjustFirstPersonCamera(_bb, default(IAdjustFirstPersonCamera));
		}

		// Token: 0x0602D21F RID: 184863 RVA: 0x0062C3C0 File Offset: 0x0062A5C0
		public static IAdjustFirstPersonCamera GetRootAsIAdjustFirstPersonCamera(ByteBuffer _bb, IAdjustFirstPersonCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D220 RID: 184864 RVA: 0x0062C3DD File Offset: 0x0062A5DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D221 RID: 184865 RVA: 0x0062C3EC File Offset: 0x0062A5EC
		public IAdjustFirstPersonCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C1CA RID: 49610
		// (get) Token: 0x0602D222 RID: 184866 RVA: 0x0062C3FC File Offset: 0x0062A5FC
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

		// Token: 0x1700C1CB RID: 49611
		// (get) Token: 0x0602D223 RID: 184867 RVA: 0x0062C438 File Offset: 0x0062A638
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

		// Token: 0x1700C1CC RID: 49612
		// (get) Token: 0x0602D224 RID: 184868 RVA: 0x0062C474 File Offset: 0x0062A674
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

		// Token: 0x1700C1CD RID: 49613
		// (get) Token: 0x0602D225 RID: 184869 RVA: 0x0062C4B4 File Offset: 0x0062A6B4
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

		// Token: 0x1700C1CE RID: 49614
		// (get) Token: 0x0602D226 RID: 184870 RVA: 0x0062C514 File Offset: 0x0062A714
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

		// Token: 0x1700C1CF RID: 49615
		// (get) Token: 0x0602D227 RID: 184871 RVA: 0x0062C558 File Offset: 0x0062A758
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

		// Token: 0x1700C1D0 RID: 49616
		// (get) Token: 0x0602D228 RID: 184872 RVA: 0x0062C5B8 File Offset: 0x0062A7B8
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

		// Token: 0x1700C1D1 RID: 49617
		// (get) Token: 0x0602D229 RID: 184873 RVA: 0x0062C5FC File Offset: 0x0062A7FC
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

		// Token: 0x1700C1D2 RID: 49618
		// (get) Token: 0x0602D22A RID: 184874 RVA: 0x0062C640 File Offset: 0x0062A840
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

		// Token: 0x1700C1D3 RID: 49619
		// (get) Token: 0x0602D22B RID: 184875 RVA: 0x0062C684 File Offset: 0x0062A884
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

		// Token: 0x1700C1D4 RID: 49620
		// (get) Token: 0x0602D22C RID: 184876 RVA: 0x0062C6E4 File Offset: 0x0062A8E4
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

		// Token: 0x1700C1D5 RID: 49621
		// (get) Token: 0x0602D22D RID: 184877 RVA: 0x0062C744 File Offset: 0x0062A944
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

		// Token: 0x1700C1D6 RID: 49622
		// (get) Token: 0x0602D22E RID: 184878 RVA: 0x0062C788 File Offset: 0x0062A988
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

		// Token: 0x1700C1D7 RID: 49623
		// (get) Token: 0x0602D22F RID: 184879 RVA: 0x0062C7CC File Offset: 0x0062A9CC
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

		// Token: 0x1700C1D8 RID: 49624
		// (get) Token: 0x0602D230 RID: 184880 RVA: 0x0062C810 File Offset: 0x0062AA10
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

		// Token: 0x1700C1D9 RID: 49625
		// (get) Token: 0x0602D231 RID: 184881 RVA: 0x0062C854 File Offset: 0x0062AA54
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

		// Token: 0x1700C1DA RID: 49626
		// (get) Token: 0x0602D232 RID: 184882 RVA: 0x0062C898 File Offset: 0x0062AA98
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1DB RID: 49627
		// (get) Token: 0x0602D233 RID: 184883 RVA: 0x0062C8D8 File Offset: 0x0062AAD8
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

		// Token: 0x0602D234 RID: 184884 RVA: 0x0062C918 File Offset: 0x0062AB18
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D235 RID: 184885 RVA: 0x0062C960 File Offset: 0x0062AB60
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602D236 RID: 184886 RVA: 0x0062C97C File Offset: 0x0062AB7C
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602D237 RID: 184887 RVA: 0x0062C998 File Offset: 0x0062AB98
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602D238 RID: 184888 RVA: 0x0062C9B4 File Offset: 0x0062ABB4
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700C1DC RID: 49628
		// (get) Token: 0x0602D239 RID: 184889 RVA: 0x0062C9D0 File Offset: 0x0062ABD0
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1DD RID: 49629
		// (get) Token: 0x0602D23A RID: 184890 RVA: 0x0062CA10 File Offset: 0x0062AC10
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1DE RID: 49630
		// (get) Token: 0x0602D23B RID: 184891 RVA: 0x0062CA50 File Offset: 0x0062AC50
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

		// Token: 0x0602D23C RID: 184892 RVA: 0x0062CA88 File Offset: 0x0062AC88
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602D23D RID: 184893 RVA: 0x0062CA98 File Offset: 0x0062AC98
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700C1DF RID: 49631
		// (get) Token: 0x0602D23E RID: 184894 RVA: 0x0062CAA8 File Offset: 0x0062ACA8
		public bool HidePlayer
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C1E0 RID: 49632
		// (get) Token: 0x0602D23F RID: 184895 RVA: 0x0062CAE8 File Offset: 0x0062ACE8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D240 RID: 184896 RVA: 0x0062CB28 File Offset: 0x0062AD28
		public static Offset<IAdjustFirstPersonCamera> CreateIAdjustFirstPersonCamera(FlatBufferBuilder builder, EAdjustPlayerCamera Type = EAdjustPlayerCamera.Basic, int Priority = 0, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>), float FadeOutTime = 0f, Offset<IBaseCurve> FadeOutCurveOffset = default(Offset<IBaseCurve>), float ArmLength = 0f, float MinumArmLength = 0f, float MaxiumArmLength = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArmOffsetOffset = default(Offset<IVectorInfo>), float YawLimitMin = 0f, float YawLimitMax = 0f, float PitchLimitMin = 0f, float PitchLimitMax = 0f, float Fov = 0f, bool IsDisableResetFocus = false, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool IsDisableCollision = false, bool IsDisableDither = false, StringOffset SubScreenBindKeyOffset = default(StringOffset), bool HidePlayer = false, byte NullMask = 0)
		{
			builder.StartTable(24);
			IAdjustFirstPersonCamera.AddSubScreenBindKey(builder, SubScreenBindKeyOffset);
			IAdjustFirstPersonCamera.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustFirstPersonCamera.AddFov(builder, Fov);
			IAdjustFirstPersonCamera.AddPitchLimitMax(builder, PitchLimitMax);
			IAdjustFirstPersonCamera.AddPitchLimitMin(builder, PitchLimitMin);
			IAdjustFirstPersonCamera.AddYawLimitMax(builder, YawLimitMax);
			IAdjustFirstPersonCamera.AddYawLimitMin(builder, YawLimitMin);
			IAdjustFirstPersonCamera.AddArmOffset(builder, ArmOffsetOffset);
			IAdjustFirstPersonCamera.AddOffset(builder, OffsetOffset);
			IAdjustFirstPersonCamera.AddMaxiumArmLength(builder, MaxiumArmLength);
			IAdjustFirstPersonCamera.AddMinumArmLength(builder, MinumArmLength);
			IAdjustFirstPersonCamera.AddArmLength(builder, ArmLength);
			IAdjustFirstPersonCamera.AddFadeOutCurve(builder, FadeOutCurveOffset);
			IAdjustFirstPersonCamera.AddFadeOutTime(builder, FadeOutTime);
			IAdjustFirstPersonCamera.AddFadeInCurve(builder, FadeInCurveOffset);
			IAdjustFirstPersonCamera.AddFadeInTime(builder, FadeInTime);
			IAdjustFirstPersonCamera.AddPriority(builder, Priority);
			IAdjustFirstPersonCamera.AddNullMask(builder, NullMask);
			IAdjustFirstPersonCamera.AddHidePlayer(builder, HidePlayer);
			IAdjustFirstPersonCamera.AddIsDisableDither(builder, IsDisableDither);
			IAdjustFirstPersonCamera.AddIsDisableCollision(builder, IsDisableCollision);
			IAdjustFirstPersonCamera.AddGravityDirectionType(builder, GravityDirection_type);
			IAdjustFirstPersonCamera.AddIsDisableResetFocus(builder, IsDisableResetFocus);
			IAdjustFirstPersonCamera.AddType(builder, Type);
			return IAdjustFirstPersonCamera.EndIAdjustFirstPersonCamera(builder);
		}

		// Token: 0x0602D241 RID: 184897 RVA: 0x0062CC00 File Offset: 0x0062AE00
		public static void StartIAdjustFirstPersonCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(24);
		}

		// Token: 0x0602D242 RID: 184898 RVA: 0x0062CC0A File Offset: 0x0062AE0A
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D243 RID: 184899 RVA: 0x0062CC15 File Offset: 0x0062AE15
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602D244 RID: 184900 RVA: 0x0062CC20 File Offset: 0x0062AE20
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602D245 RID: 184901 RVA: 0x0062CC33 File Offset: 0x0062AE33
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602D246 RID: 184902 RVA: 0x0062CC43 File Offset: 0x0062AE43
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602D247 RID: 184903 RVA: 0x0062CC56 File Offset: 0x0062AE56
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602D248 RID: 184904 RVA: 0x0062CC66 File Offset: 0x0062AE66
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602D249 RID: 184905 RVA: 0x0062CC79 File Offset: 0x0062AE79
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602D24A RID: 184906 RVA: 0x0062CC8C File Offset: 0x0062AE8C
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602D24B RID: 184907 RVA: 0x0062CC9F File Offset: 0x0062AE9F
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602D24C RID: 184908 RVA: 0x0062CCB0 File Offset: 0x0062AEB0
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602D24D RID: 184909 RVA: 0x0062CCC1 File Offset: 0x0062AEC1
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602D24E RID: 184910 RVA: 0x0062CCD5 File Offset: 0x0062AED5
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602D24F RID: 184911 RVA: 0x0062CCE9 File Offset: 0x0062AEE9
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602D250 RID: 184912 RVA: 0x0062CCFD File Offset: 0x0062AEFD
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602D251 RID: 184913 RVA: 0x0062CD11 File Offset: 0x0062AF11
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602D252 RID: 184914 RVA: 0x0062CD25 File Offset: 0x0062AF25
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602D253 RID: 184915 RVA: 0x0062CD31 File Offset: 0x0062AF31
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602D254 RID: 184916 RVA: 0x0062CD3D File Offset: 0x0062AF3D
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602D255 RID: 184917 RVA: 0x0062CD49 File Offset: 0x0062AF49
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602D256 RID: 184918 RVA: 0x0062CD55 File Offset: 0x0062AF55
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602D257 RID: 184919 RVA: 0x0062CD61 File Offset: 0x0062AF61
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602D258 RID: 184920 RVA: 0x0062CD72 File Offset: 0x0062AF72
		public static void AddHidePlayer(FlatBufferBuilder builder, bool hidePlayer)
		{
			builder.AddBool(22, hidePlayer, false);
		}

		// Token: 0x0602D259 RID: 184921 RVA: 0x0062CD7E File Offset: 0x0062AF7E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(23, nullMask, 0);
		}

		// Token: 0x0602D25A RID: 184922 RVA: 0x0062CD8A File Offset: 0x0062AF8A
		public static Offset<IAdjustFirstPersonCamera> EndIAdjustFirstPersonCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFirstPersonCamera>(builder.EndTable());
		}

		// Token: 0x0602D25B RID: 184923 RVA: 0x0062CD98 File Offset: 0x0062AF98
		public IAdjustFirstPersonCameraT UnPack()
		{
			IAdjustFirstPersonCameraT adjustFirstPersonCameraT = new IAdjustFirstPersonCameraT();
			this.UnPackTo(adjustFirstPersonCameraT);
			return adjustFirstPersonCameraT;
		}

		// Token: 0x0602D25C RID: 184924 RVA: 0x0062CDB4 File Offset: 0x0062AFB4
		public void UnPackTo(IAdjustFirstPersonCameraT _o)
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
			_o.HidePlayer = this.HidePlayer;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D25D RID: 184925 RVA: 0x0062D07C File Offset: 0x0062B27C
		public static Offset<IAdjustFirstPersonCamera> Pack(FlatBufferBuilder builder, IAdjustFirstPersonCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustFirstPersonCamera>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			Offset<IBaseCurve> fadeOutCurveOffset = (_o.FadeOutCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeOutCurve);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> armOffsetOffset = (_o.ArmOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArmOffset);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			StringOffset subScreenBindKeyOffset = (_o.SubScreenBindKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenBindKey);
			return IAdjustFirstPersonCamera.CreateIAdjustFirstPersonCamera(builder, _o.Type, _o.Priority, _o.FadeInTime, fadeInCurveOffset, _o.FadeOutTime, fadeOutCurveOffset, _o.ArmLength, _o.MinumArmLength, _o.MaxiumArmLength, offsetOffset, armOffsetOffset, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.Fov, _o.IsDisableResetFocus, gravityDirection_type, gravityDirectionOffset, _o.IsDisableCollision, _o.IsDisableDither, subScreenBindKeyOffset, _o.HidePlayer, _o.NullMask);
		}

		// Token: 0x0401138D RID: 70541
		private Table __p;
	}
}
