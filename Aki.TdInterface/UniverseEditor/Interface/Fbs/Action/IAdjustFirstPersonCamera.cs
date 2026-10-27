using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006149 RID: 24905
	public struct IAdjustFirstPersonCamera : IFlatbufferObject
	{
		// Token: 0x1700B859 RID: 47193
		// (get) Token: 0x0602AB23 RID: 174883 RVA: 0x005E21B4 File Offset: 0x005E03B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AB24 RID: 174884 RVA: 0x005E21C1 File Offset: 0x005E03C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AB25 RID: 174885 RVA: 0x005E21C8 File Offset: 0x005E03C8
		public static IAdjustFirstPersonCamera GetRootAsIAdjustFirstPersonCamera(ByteBuffer _bb)
		{
			return IAdjustFirstPersonCamera.GetRootAsIAdjustFirstPersonCamera(_bb, default(IAdjustFirstPersonCamera));
		}

		// Token: 0x0602AB26 RID: 174886 RVA: 0x005E21E4 File Offset: 0x005E03E4
		public static IAdjustFirstPersonCamera GetRootAsIAdjustFirstPersonCamera(ByteBuffer _bb, IAdjustFirstPersonCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AB27 RID: 174887 RVA: 0x005E2201 File Offset: 0x005E0401
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AB28 RID: 174888 RVA: 0x005E2210 File Offset: 0x005E0410
		public IAdjustFirstPersonCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B85A RID: 47194
		// (get) Token: 0x0602AB29 RID: 174889 RVA: 0x005E2220 File Offset: 0x005E0420
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

		// Token: 0x1700B85B RID: 47195
		// (get) Token: 0x0602AB2A RID: 174890 RVA: 0x005E225C File Offset: 0x005E045C
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

		// Token: 0x1700B85C RID: 47196
		// (get) Token: 0x0602AB2B RID: 174891 RVA: 0x005E2298 File Offset: 0x005E0498
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

		// Token: 0x1700B85D RID: 47197
		// (get) Token: 0x0602AB2C RID: 174892 RVA: 0x005E22D8 File Offset: 0x005E04D8
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

		// Token: 0x1700B85E RID: 47198
		// (get) Token: 0x0602AB2D RID: 174893 RVA: 0x005E2338 File Offset: 0x005E0538
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

		// Token: 0x1700B85F RID: 47199
		// (get) Token: 0x0602AB2E RID: 174894 RVA: 0x005E237C File Offset: 0x005E057C
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

		// Token: 0x1700B860 RID: 47200
		// (get) Token: 0x0602AB2F RID: 174895 RVA: 0x005E23DC File Offset: 0x005E05DC
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

		// Token: 0x1700B861 RID: 47201
		// (get) Token: 0x0602AB30 RID: 174896 RVA: 0x005E2420 File Offset: 0x005E0620
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

		// Token: 0x1700B862 RID: 47202
		// (get) Token: 0x0602AB31 RID: 174897 RVA: 0x005E2464 File Offset: 0x005E0664
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

		// Token: 0x1700B863 RID: 47203
		// (get) Token: 0x0602AB32 RID: 174898 RVA: 0x005E24A8 File Offset: 0x005E06A8
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

		// Token: 0x1700B864 RID: 47204
		// (get) Token: 0x0602AB33 RID: 174899 RVA: 0x005E2508 File Offset: 0x005E0708
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

		// Token: 0x1700B865 RID: 47205
		// (get) Token: 0x0602AB34 RID: 174900 RVA: 0x005E2568 File Offset: 0x005E0768
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

		// Token: 0x1700B866 RID: 47206
		// (get) Token: 0x0602AB35 RID: 174901 RVA: 0x005E25AC File Offset: 0x005E07AC
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

		// Token: 0x1700B867 RID: 47207
		// (get) Token: 0x0602AB36 RID: 174902 RVA: 0x005E25F0 File Offset: 0x005E07F0
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

		// Token: 0x1700B868 RID: 47208
		// (get) Token: 0x0602AB37 RID: 174903 RVA: 0x005E2634 File Offset: 0x005E0834
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

		// Token: 0x1700B869 RID: 47209
		// (get) Token: 0x0602AB38 RID: 174904 RVA: 0x005E2678 File Offset: 0x005E0878
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

		// Token: 0x1700B86A RID: 47210
		// (get) Token: 0x0602AB39 RID: 174905 RVA: 0x005E26BC File Offset: 0x005E08BC
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B86B RID: 47211
		// (get) Token: 0x0602AB3A RID: 174906 RVA: 0x005E26FC File Offset: 0x005E08FC
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

		// Token: 0x0602AB3B RID: 174907 RVA: 0x005E273C File Offset: 0x005E093C
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602AB3C RID: 174908 RVA: 0x005E2784 File Offset: 0x005E0984
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602AB3D RID: 174909 RVA: 0x005E27A0 File Offset: 0x005E09A0
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602AB3E RID: 174910 RVA: 0x005E27BC File Offset: 0x005E09BC
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602AB3F RID: 174911 RVA: 0x005E27D8 File Offset: 0x005E09D8
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700B86C RID: 47212
		// (get) Token: 0x0602AB40 RID: 174912 RVA: 0x005E27F4 File Offset: 0x005E09F4
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B86D RID: 47213
		// (get) Token: 0x0602AB41 RID: 174913 RVA: 0x005E2834 File Offset: 0x005E0A34
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B86E RID: 47214
		// (get) Token: 0x0602AB42 RID: 174914 RVA: 0x005E2874 File Offset: 0x005E0A74
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

		// Token: 0x0602AB43 RID: 174915 RVA: 0x005E28AC File Offset: 0x005E0AAC
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602AB44 RID: 174916 RVA: 0x005E28BC File Offset: 0x005E0ABC
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700B86F RID: 47215
		// (get) Token: 0x0602AB45 RID: 174917 RVA: 0x005E28CC File Offset: 0x005E0ACC
		public bool HidePlayer
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B870 RID: 47216
		// (get) Token: 0x0602AB46 RID: 174918 RVA: 0x005E290C File Offset: 0x005E0B0C
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

		// Token: 0x0602AB47 RID: 174919 RVA: 0x005E294C File Offset: 0x005E0B4C
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

		// Token: 0x0602AB48 RID: 174920 RVA: 0x005E2A24 File Offset: 0x005E0C24
		public static void StartIAdjustFirstPersonCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(24);
		}

		// Token: 0x0602AB49 RID: 174921 RVA: 0x005E2A2E File Offset: 0x005E0C2E
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AB4A RID: 174922 RVA: 0x005E2A39 File Offset: 0x005E0C39
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602AB4B RID: 174923 RVA: 0x005E2A44 File Offset: 0x005E0C44
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602AB4C RID: 174924 RVA: 0x005E2A57 File Offset: 0x005E0C57
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602AB4D RID: 174925 RVA: 0x005E2A67 File Offset: 0x005E0C67
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602AB4E RID: 174926 RVA: 0x005E2A7A File Offset: 0x005E0C7A
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602AB4F RID: 174927 RVA: 0x005E2A8A File Offset: 0x005E0C8A
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602AB50 RID: 174928 RVA: 0x005E2A9D File Offset: 0x005E0C9D
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602AB51 RID: 174929 RVA: 0x005E2AB0 File Offset: 0x005E0CB0
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602AB52 RID: 174930 RVA: 0x005E2AC3 File Offset: 0x005E0CC3
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602AB53 RID: 174931 RVA: 0x005E2AD4 File Offset: 0x005E0CD4
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602AB54 RID: 174932 RVA: 0x005E2AE5 File Offset: 0x005E0CE5
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602AB55 RID: 174933 RVA: 0x005E2AF9 File Offset: 0x005E0CF9
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602AB56 RID: 174934 RVA: 0x005E2B0D File Offset: 0x005E0D0D
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602AB57 RID: 174935 RVA: 0x005E2B21 File Offset: 0x005E0D21
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602AB58 RID: 174936 RVA: 0x005E2B35 File Offset: 0x005E0D35
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602AB59 RID: 174937 RVA: 0x005E2B49 File Offset: 0x005E0D49
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602AB5A RID: 174938 RVA: 0x005E2B55 File Offset: 0x005E0D55
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602AB5B RID: 174939 RVA: 0x005E2B61 File Offset: 0x005E0D61
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602AB5C RID: 174940 RVA: 0x005E2B6D File Offset: 0x005E0D6D
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602AB5D RID: 174941 RVA: 0x005E2B79 File Offset: 0x005E0D79
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602AB5E RID: 174942 RVA: 0x005E2B85 File Offset: 0x005E0D85
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602AB5F RID: 174943 RVA: 0x005E2B96 File Offset: 0x005E0D96
		public static void AddHidePlayer(FlatBufferBuilder builder, bool hidePlayer)
		{
			builder.AddBool(22, hidePlayer, false);
		}

		// Token: 0x0602AB60 RID: 174944 RVA: 0x005E2BA2 File Offset: 0x005E0DA2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(23, nullMask, 0);
		}

		// Token: 0x0602AB61 RID: 174945 RVA: 0x005E2BAE File Offset: 0x005E0DAE
		public static Offset<IAdjustFirstPersonCamera> EndIAdjustFirstPersonCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFirstPersonCamera>(builder.EndTable());
		}

		// Token: 0x0602AB62 RID: 174946 RVA: 0x005E2BBC File Offset: 0x005E0DBC
		public IAdjustFirstPersonCameraT UnPack()
		{
			IAdjustFirstPersonCameraT adjustFirstPersonCameraT = new IAdjustFirstPersonCameraT();
			this.UnPackTo(adjustFirstPersonCameraT);
			return adjustFirstPersonCameraT;
		}

		// Token: 0x0602AB63 RID: 174947 RVA: 0x005E2BD8 File Offset: 0x005E0DD8
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

		// Token: 0x0602AB64 RID: 174948 RVA: 0x005E2EA0 File Offset: 0x005E10A0
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

		// Token: 0x04010586 RID: 66950
		private Table __p;
	}
}
