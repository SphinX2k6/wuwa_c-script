using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067BA RID: 26554
	public struct IAdjustFixedLookAtCamera : IFlatbufferObject
	{
		// Token: 0x1700C24D RID: 49741
		// (get) Token: 0x0602D36B RID: 185195 RVA: 0x0062FC20 File Offset: 0x0062DE20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D36C RID: 185196 RVA: 0x0062FC2D File Offset: 0x0062DE2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D36D RID: 185197 RVA: 0x0062FC34 File Offset: 0x0062DE34
		public static IAdjustFixedLookAtCamera GetRootAsIAdjustFixedLookAtCamera(ByteBuffer _bb)
		{
			return IAdjustFixedLookAtCamera.GetRootAsIAdjustFixedLookAtCamera(_bb, default(IAdjustFixedLookAtCamera));
		}

		// Token: 0x0602D36E RID: 185198 RVA: 0x0062FC50 File Offset: 0x0062DE50
		public static IAdjustFixedLookAtCamera GetRootAsIAdjustFixedLookAtCamera(ByteBuffer _bb, IAdjustFixedLookAtCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D36F RID: 185199 RVA: 0x0062FC6D File Offset: 0x0062DE6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D370 RID: 185200 RVA: 0x0062FC7C File Offset: 0x0062DE7C
		public IAdjustFixedLookAtCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C24E RID: 49742
		// (get) Token: 0x0602D371 RID: 185201 RVA: 0x0062FC8C File Offset: 0x0062DE8C
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

		// Token: 0x1700C24F RID: 49743
		// (get) Token: 0x0602D372 RID: 185202 RVA: 0x0062FCC8 File Offset: 0x0062DEC8
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

		// Token: 0x1700C250 RID: 49744
		// (get) Token: 0x0602D373 RID: 185203 RVA: 0x0062FD04 File Offset: 0x0062DF04
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

		// Token: 0x1700C251 RID: 49745
		// (get) Token: 0x0602D374 RID: 185204 RVA: 0x0062FD44 File Offset: 0x0062DF44
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

		// Token: 0x1700C252 RID: 49746
		// (get) Token: 0x0602D375 RID: 185205 RVA: 0x0062FDA4 File Offset: 0x0062DFA4
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

		// Token: 0x1700C253 RID: 49747
		// (get) Token: 0x0602D376 RID: 185206 RVA: 0x0062FDE8 File Offset: 0x0062DFE8
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

		// Token: 0x1700C254 RID: 49748
		// (get) Token: 0x0602D377 RID: 185207 RVA: 0x0062FE48 File Offset: 0x0062E048
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

		// Token: 0x1700C255 RID: 49749
		// (get) Token: 0x0602D378 RID: 185208 RVA: 0x0062FE8C File Offset: 0x0062E08C
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

		// Token: 0x1700C256 RID: 49750
		// (get) Token: 0x0602D379 RID: 185209 RVA: 0x0062FED0 File Offset: 0x0062E0D0
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

		// Token: 0x1700C257 RID: 49751
		// (get) Token: 0x0602D37A RID: 185210 RVA: 0x0062FF14 File Offset: 0x0062E114
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

		// Token: 0x1700C258 RID: 49752
		// (get) Token: 0x0602D37B RID: 185211 RVA: 0x0062FF74 File Offset: 0x0062E174
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

		// Token: 0x1700C259 RID: 49753
		// (get) Token: 0x0602D37C RID: 185212 RVA: 0x0062FFD4 File Offset: 0x0062E1D4
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

		// Token: 0x1700C25A RID: 49754
		// (get) Token: 0x0602D37D RID: 185213 RVA: 0x00630018 File Offset: 0x0062E218
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

		// Token: 0x1700C25B RID: 49755
		// (get) Token: 0x0602D37E RID: 185214 RVA: 0x0063005C File Offset: 0x0062E25C
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

		// Token: 0x1700C25C RID: 49756
		// (get) Token: 0x0602D37F RID: 185215 RVA: 0x006300A0 File Offset: 0x0062E2A0
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

		// Token: 0x1700C25D RID: 49757
		// (get) Token: 0x0602D380 RID: 185216 RVA: 0x006300E4 File Offset: 0x0062E2E4
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

		// Token: 0x1700C25E RID: 49758
		// (get) Token: 0x0602D381 RID: 185217 RVA: 0x00630128 File Offset: 0x0062E328
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C25F RID: 49759
		// (get) Token: 0x0602D382 RID: 185218 RVA: 0x00630168 File Offset: 0x0062E368
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

		// Token: 0x0602D383 RID: 185219 RVA: 0x006301A8 File Offset: 0x0062E3A8
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D384 RID: 185220 RVA: 0x006301F0 File Offset: 0x0062E3F0
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602D385 RID: 185221 RVA: 0x0063020C File Offset: 0x0062E40C
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602D386 RID: 185222 RVA: 0x00630228 File Offset: 0x0062E428
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602D387 RID: 185223 RVA: 0x00630244 File Offset: 0x0062E444
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700C260 RID: 49760
		// (get) Token: 0x0602D388 RID: 185224 RVA: 0x00630260 File Offset: 0x0062E460
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C261 RID: 49761
		// (get) Token: 0x0602D389 RID: 185225 RVA: 0x006302A0 File Offset: 0x0062E4A0
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C262 RID: 49762
		// (get) Token: 0x0602D38A RID: 185226 RVA: 0x006302E0 File Offset: 0x0062E4E0
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

		// Token: 0x0602D38B RID: 185227 RVA: 0x00630318 File Offset: 0x0062E518
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602D38C RID: 185228 RVA: 0x00630328 File Offset: 0x0062E528
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700C263 RID: 49763
		// (get) Token: 0x0602D38D RID: 185229 RVA: 0x00630338 File Offset: 0x0062E538
		public IAdjustFixedLookAtTargetRangeEntity? TargetType
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return new IAdjustFixedLookAtTargetRangeEntity?(default(IAdjustFixedLookAtTargetRangeEntity).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C264 RID: 49764
		// (get) Token: 0x0602D38E RID: 185230 RVA: 0x00630398 File Offset: 0x0062E598
		public EPlayerMoveTag PlayerMoveTag
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return EPlayerMoveTag.VehicleMotorHighSpeed;
				}
				return (EPlayerMoveTag)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C265 RID: 49765
		// (get) Token: 0x0602D38F RID: 185231 RVA: 0x006303D8 File Offset: 0x0062E5D8
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

		// Token: 0x0602D390 RID: 185232 RVA: 0x00630418 File Offset: 0x0062E618
		public static Offset<IAdjustFixedLookAtCamera> CreateIAdjustFixedLookAtCamera(FlatBufferBuilder builder, EAdjustPlayerCamera Type = EAdjustPlayerCamera.Basic, int Priority = 0, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>), float FadeOutTime = 0f, Offset<IBaseCurve> FadeOutCurveOffset = default(Offset<IBaseCurve>), float ArmLength = 0f, float MinumArmLength = 0f, float MaxiumArmLength = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArmOffsetOffset = default(Offset<IVectorInfo>), float YawLimitMin = 0f, float YawLimitMax = 0f, float PitchLimitMin = 0f, float PitchLimitMax = 0f, float Fov = 0f, bool IsDisableResetFocus = false, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool IsDisableCollision = false, bool IsDisableDither = false, StringOffset SubScreenBindKeyOffset = default(StringOffset), Offset<IAdjustFixedLookAtTargetRangeEntity> TargetTypeOffset = default(Offset<IAdjustFixedLookAtTargetRangeEntity>), EPlayerMoveTag PlayerMoveTag = EPlayerMoveTag.VehicleMotorHighSpeed, byte NullMask = 0)
		{
			builder.StartTable(25);
			IAdjustFixedLookAtCamera.AddTargetType(builder, TargetTypeOffset);
			IAdjustFixedLookAtCamera.AddSubScreenBindKey(builder, SubScreenBindKeyOffset);
			IAdjustFixedLookAtCamera.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustFixedLookAtCamera.AddFov(builder, Fov);
			IAdjustFixedLookAtCamera.AddPitchLimitMax(builder, PitchLimitMax);
			IAdjustFixedLookAtCamera.AddPitchLimitMin(builder, PitchLimitMin);
			IAdjustFixedLookAtCamera.AddYawLimitMax(builder, YawLimitMax);
			IAdjustFixedLookAtCamera.AddYawLimitMin(builder, YawLimitMin);
			IAdjustFixedLookAtCamera.AddArmOffset(builder, ArmOffsetOffset);
			IAdjustFixedLookAtCamera.AddOffset(builder, OffsetOffset);
			IAdjustFixedLookAtCamera.AddMaxiumArmLength(builder, MaxiumArmLength);
			IAdjustFixedLookAtCamera.AddMinumArmLength(builder, MinumArmLength);
			IAdjustFixedLookAtCamera.AddArmLength(builder, ArmLength);
			IAdjustFixedLookAtCamera.AddFadeOutCurve(builder, FadeOutCurveOffset);
			IAdjustFixedLookAtCamera.AddFadeOutTime(builder, FadeOutTime);
			IAdjustFixedLookAtCamera.AddFadeInCurve(builder, FadeInCurveOffset);
			IAdjustFixedLookAtCamera.AddFadeInTime(builder, FadeInTime);
			IAdjustFixedLookAtCamera.AddPriority(builder, Priority);
			IAdjustFixedLookAtCamera.AddNullMask(builder, NullMask);
			IAdjustFixedLookAtCamera.AddPlayerMoveTag(builder, PlayerMoveTag);
			IAdjustFixedLookAtCamera.AddIsDisableDither(builder, IsDisableDither);
			IAdjustFixedLookAtCamera.AddIsDisableCollision(builder, IsDisableCollision);
			IAdjustFixedLookAtCamera.AddGravityDirectionType(builder, GravityDirection_type);
			IAdjustFixedLookAtCamera.AddIsDisableResetFocus(builder, IsDisableResetFocus);
			IAdjustFixedLookAtCamera.AddType(builder, Type);
			return IAdjustFixedLookAtCamera.EndIAdjustFixedLookAtCamera(builder);
		}

		// Token: 0x0602D391 RID: 185233 RVA: 0x006304F8 File Offset: 0x0062E6F8
		public static void StartIAdjustFixedLookAtCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(25);
		}

		// Token: 0x0602D392 RID: 185234 RVA: 0x00630502 File Offset: 0x0062E702
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D393 RID: 185235 RVA: 0x0063050D File Offset: 0x0062E70D
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602D394 RID: 185236 RVA: 0x00630518 File Offset: 0x0062E718
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602D395 RID: 185237 RVA: 0x0063052B File Offset: 0x0062E72B
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602D396 RID: 185238 RVA: 0x0063053B File Offset: 0x0062E73B
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602D397 RID: 185239 RVA: 0x0063054E File Offset: 0x0062E74E
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602D398 RID: 185240 RVA: 0x0063055E File Offset: 0x0062E75E
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602D399 RID: 185241 RVA: 0x00630571 File Offset: 0x0062E771
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602D39A RID: 185242 RVA: 0x00630584 File Offset: 0x0062E784
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602D39B RID: 185243 RVA: 0x00630597 File Offset: 0x0062E797
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602D39C RID: 185244 RVA: 0x006305A8 File Offset: 0x0062E7A8
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602D39D RID: 185245 RVA: 0x006305B9 File Offset: 0x0062E7B9
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602D39E RID: 185246 RVA: 0x006305CD File Offset: 0x0062E7CD
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602D39F RID: 185247 RVA: 0x006305E1 File Offset: 0x0062E7E1
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602D3A0 RID: 185248 RVA: 0x006305F5 File Offset: 0x0062E7F5
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602D3A1 RID: 185249 RVA: 0x00630609 File Offset: 0x0062E809
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602D3A2 RID: 185250 RVA: 0x0063061D File Offset: 0x0062E81D
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602D3A3 RID: 185251 RVA: 0x00630629 File Offset: 0x0062E829
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602D3A4 RID: 185252 RVA: 0x00630635 File Offset: 0x0062E835
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602D3A5 RID: 185253 RVA: 0x00630641 File Offset: 0x0062E841
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602D3A6 RID: 185254 RVA: 0x0063064D File Offset: 0x0062E84D
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602D3A7 RID: 185255 RVA: 0x00630659 File Offset: 0x0062E859
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602D3A8 RID: 185256 RVA: 0x0063066A File Offset: 0x0062E86A
		public static void AddTargetType(FlatBufferBuilder builder, Offset<IAdjustFixedLookAtTargetRangeEntity> targetTypeOffset)
		{
			builder.AddOffset(22, targetTypeOffset.Value, 0);
		}

		// Token: 0x0602D3A9 RID: 185257 RVA: 0x0063067B File Offset: 0x0062E87B
		public static void AddPlayerMoveTag(FlatBufferBuilder builder, EPlayerMoveTag playerMoveTag)
		{
			builder.AddByte(23, (byte)playerMoveTag, 0);
		}

		// Token: 0x0602D3AA RID: 185258 RVA: 0x00630687 File Offset: 0x0062E887
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(24, nullMask, 0);
		}

		// Token: 0x0602D3AB RID: 185259 RVA: 0x00630693 File Offset: 0x0062E893
		public static Offset<IAdjustFixedLookAtCamera> EndIAdjustFixedLookAtCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedLookAtCamera>(builder.EndTable());
		}

		// Token: 0x0602D3AC RID: 185260 RVA: 0x006306A0 File Offset: 0x0062E8A0
		public IAdjustFixedLookAtCameraT UnPack()
		{
			IAdjustFixedLookAtCameraT adjustFixedLookAtCameraT = new IAdjustFixedLookAtCameraT();
			this.UnPackTo(adjustFixedLookAtCameraT);
			return adjustFixedLookAtCameraT;
		}

		// Token: 0x0602D3AD RID: 185261 RVA: 0x006306BC File Offset: 0x0062E8BC
		public void UnPackTo(IAdjustFixedLookAtCameraT _o)
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
			_o.TargetType = ((this.TargetType != null) ? this.TargetType.Value.UnPack() : null);
			_o.PlayerMoveTag = this.PlayerMoveTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D3AE RID: 185262 RVA: 0x006309B8 File Offset: 0x0062EBB8
		public static Offset<IAdjustFixedLookAtCamera> Pack(FlatBufferBuilder builder, IAdjustFixedLookAtCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustFixedLookAtCamera>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			Offset<IBaseCurve> fadeOutCurveOffset = (_o.FadeOutCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeOutCurve);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> armOffsetOffset = (_o.ArmOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArmOffset);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			StringOffset subScreenBindKeyOffset = (_o.SubScreenBindKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenBindKey);
			Offset<IAdjustFixedLookAtTargetRangeEntity> targetTypeOffset = (_o.TargetType == null) ? default(Offset<IAdjustFixedLookAtTargetRangeEntity>) : IAdjustFixedLookAtTargetRangeEntity.Pack(builder, _o.TargetType);
			return IAdjustFixedLookAtCamera.CreateIAdjustFixedLookAtCamera(builder, _o.Type, _o.Priority, _o.FadeInTime, fadeInCurveOffset, _o.FadeOutTime, fadeOutCurveOffset, _o.ArmLength, _o.MinumArmLength, _o.MaxiumArmLength, offsetOffset, armOffsetOffset, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.Fov, _o.IsDisableResetFocus, gravityDirection_type, gravityDirectionOffset, _o.IsDisableCollision, _o.IsDisableDither, subScreenBindKeyOffset, targetTypeOffset, _o.PlayerMoveTag, _o.NullMask);
		}

		// Token: 0x040113D1 RID: 70609
		private Table __p;
	}
}
