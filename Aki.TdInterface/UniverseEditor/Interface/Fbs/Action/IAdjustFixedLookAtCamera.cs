using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006155 RID: 24917
	public struct IAdjustFixedLookAtCamera : IFlatbufferObject
	{
		// Token: 0x1700B8DD RID: 47325
		// (get) Token: 0x0602AC72 RID: 175218 RVA: 0x005E5A44 File Offset: 0x005E3C44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AC73 RID: 175219 RVA: 0x005E5A51 File Offset: 0x005E3C51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AC74 RID: 175220 RVA: 0x005E5A58 File Offset: 0x005E3C58
		public static IAdjustFixedLookAtCamera GetRootAsIAdjustFixedLookAtCamera(ByteBuffer _bb)
		{
			return IAdjustFixedLookAtCamera.GetRootAsIAdjustFixedLookAtCamera(_bb, default(IAdjustFixedLookAtCamera));
		}

		// Token: 0x0602AC75 RID: 175221 RVA: 0x005E5A74 File Offset: 0x005E3C74
		public static IAdjustFixedLookAtCamera GetRootAsIAdjustFixedLookAtCamera(ByteBuffer _bb, IAdjustFixedLookAtCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AC76 RID: 175222 RVA: 0x005E5A91 File Offset: 0x005E3C91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AC77 RID: 175223 RVA: 0x005E5AA0 File Offset: 0x005E3CA0
		public IAdjustFixedLookAtCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8DE RID: 47326
		// (get) Token: 0x0602AC78 RID: 175224 RVA: 0x005E5AB0 File Offset: 0x005E3CB0
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

		// Token: 0x1700B8DF RID: 47327
		// (get) Token: 0x0602AC79 RID: 175225 RVA: 0x005E5AEC File Offset: 0x005E3CEC
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

		// Token: 0x1700B8E0 RID: 47328
		// (get) Token: 0x0602AC7A RID: 175226 RVA: 0x005E5B28 File Offset: 0x005E3D28
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

		// Token: 0x1700B8E1 RID: 47329
		// (get) Token: 0x0602AC7B RID: 175227 RVA: 0x005E5B68 File Offset: 0x005E3D68
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

		// Token: 0x1700B8E2 RID: 47330
		// (get) Token: 0x0602AC7C RID: 175228 RVA: 0x005E5BC8 File Offset: 0x005E3DC8
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

		// Token: 0x1700B8E3 RID: 47331
		// (get) Token: 0x0602AC7D RID: 175229 RVA: 0x005E5C0C File Offset: 0x005E3E0C
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

		// Token: 0x1700B8E4 RID: 47332
		// (get) Token: 0x0602AC7E RID: 175230 RVA: 0x005E5C6C File Offset: 0x005E3E6C
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

		// Token: 0x1700B8E5 RID: 47333
		// (get) Token: 0x0602AC7F RID: 175231 RVA: 0x005E5CB0 File Offset: 0x005E3EB0
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

		// Token: 0x1700B8E6 RID: 47334
		// (get) Token: 0x0602AC80 RID: 175232 RVA: 0x005E5CF4 File Offset: 0x005E3EF4
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

		// Token: 0x1700B8E7 RID: 47335
		// (get) Token: 0x0602AC81 RID: 175233 RVA: 0x005E5D38 File Offset: 0x005E3F38
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

		// Token: 0x1700B8E8 RID: 47336
		// (get) Token: 0x0602AC82 RID: 175234 RVA: 0x005E5D98 File Offset: 0x005E3F98
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

		// Token: 0x1700B8E9 RID: 47337
		// (get) Token: 0x0602AC83 RID: 175235 RVA: 0x005E5DF8 File Offset: 0x005E3FF8
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

		// Token: 0x1700B8EA RID: 47338
		// (get) Token: 0x0602AC84 RID: 175236 RVA: 0x005E5E3C File Offset: 0x005E403C
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

		// Token: 0x1700B8EB RID: 47339
		// (get) Token: 0x0602AC85 RID: 175237 RVA: 0x005E5E80 File Offset: 0x005E4080
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

		// Token: 0x1700B8EC RID: 47340
		// (get) Token: 0x0602AC86 RID: 175238 RVA: 0x005E5EC4 File Offset: 0x005E40C4
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

		// Token: 0x1700B8ED RID: 47341
		// (get) Token: 0x0602AC87 RID: 175239 RVA: 0x005E5F08 File Offset: 0x005E4108
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

		// Token: 0x1700B8EE RID: 47342
		// (get) Token: 0x0602AC88 RID: 175240 RVA: 0x005E5F4C File Offset: 0x005E414C
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B8EF RID: 47343
		// (get) Token: 0x0602AC89 RID: 175241 RVA: 0x005E5F8C File Offset: 0x005E418C
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

		// Token: 0x0602AC8A RID: 175242 RVA: 0x005E5FCC File Offset: 0x005E41CC
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602AC8B RID: 175243 RVA: 0x005E6014 File Offset: 0x005E4214
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602AC8C RID: 175244 RVA: 0x005E6030 File Offset: 0x005E4230
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602AC8D RID: 175245 RVA: 0x005E604C File Offset: 0x005E424C
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602AC8E RID: 175246 RVA: 0x005E6068 File Offset: 0x005E4268
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700B8F0 RID: 47344
		// (get) Token: 0x0602AC8F RID: 175247 RVA: 0x005E6084 File Offset: 0x005E4284
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B8F1 RID: 47345
		// (get) Token: 0x0602AC90 RID: 175248 RVA: 0x005E60C4 File Offset: 0x005E42C4
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B8F2 RID: 47346
		// (get) Token: 0x0602AC91 RID: 175249 RVA: 0x005E6104 File Offset: 0x005E4304
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

		// Token: 0x0602AC92 RID: 175250 RVA: 0x005E613C File Offset: 0x005E433C
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602AC93 RID: 175251 RVA: 0x005E614C File Offset: 0x005E434C
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700B8F3 RID: 47347
		// (get) Token: 0x0602AC94 RID: 175252 RVA: 0x005E615C File Offset: 0x005E435C
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

		// Token: 0x1700B8F4 RID: 47348
		// (get) Token: 0x0602AC95 RID: 175253 RVA: 0x005E61BC File Offset: 0x005E43BC
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

		// Token: 0x1700B8F5 RID: 47349
		// (get) Token: 0x0602AC96 RID: 175254 RVA: 0x005E61FC File Offset: 0x005E43FC
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

		// Token: 0x0602AC97 RID: 175255 RVA: 0x005E623C File Offset: 0x005E443C
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

		// Token: 0x0602AC98 RID: 175256 RVA: 0x005E631C File Offset: 0x005E451C
		public static void StartIAdjustFixedLookAtCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(25);
		}

		// Token: 0x0602AC99 RID: 175257 RVA: 0x005E6326 File Offset: 0x005E4526
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AC9A RID: 175258 RVA: 0x005E6331 File Offset: 0x005E4531
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602AC9B RID: 175259 RVA: 0x005E633C File Offset: 0x005E453C
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602AC9C RID: 175260 RVA: 0x005E634F File Offset: 0x005E454F
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602AC9D RID: 175261 RVA: 0x005E635F File Offset: 0x005E455F
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602AC9E RID: 175262 RVA: 0x005E6372 File Offset: 0x005E4572
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602AC9F RID: 175263 RVA: 0x005E6382 File Offset: 0x005E4582
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602ACA0 RID: 175264 RVA: 0x005E6395 File Offset: 0x005E4595
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602ACA1 RID: 175265 RVA: 0x005E63A8 File Offset: 0x005E45A8
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602ACA2 RID: 175266 RVA: 0x005E63BB File Offset: 0x005E45BB
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602ACA3 RID: 175267 RVA: 0x005E63CC File Offset: 0x005E45CC
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602ACA4 RID: 175268 RVA: 0x005E63DD File Offset: 0x005E45DD
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602ACA5 RID: 175269 RVA: 0x005E63F1 File Offset: 0x005E45F1
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602ACA6 RID: 175270 RVA: 0x005E6405 File Offset: 0x005E4605
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602ACA7 RID: 175271 RVA: 0x005E6419 File Offset: 0x005E4619
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602ACA8 RID: 175272 RVA: 0x005E642D File Offset: 0x005E462D
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602ACA9 RID: 175273 RVA: 0x005E6441 File Offset: 0x005E4641
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602ACAA RID: 175274 RVA: 0x005E644D File Offset: 0x005E464D
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602ACAB RID: 175275 RVA: 0x005E6459 File Offset: 0x005E4659
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602ACAC RID: 175276 RVA: 0x005E6465 File Offset: 0x005E4665
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602ACAD RID: 175277 RVA: 0x005E6471 File Offset: 0x005E4671
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602ACAE RID: 175278 RVA: 0x005E647D File Offset: 0x005E467D
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602ACAF RID: 175279 RVA: 0x005E648E File Offset: 0x005E468E
		public static void AddTargetType(FlatBufferBuilder builder, Offset<IAdjustFixedLookAtTargetRangeEntity> targetTypeOffset)
		{
			builder.AddOffset(22, targetTypeOffset.Value, 0);
		}

		// Token: 0x0602ACB0 RID: 175280 RVA: 0x005E649F File Offset: 0x005E469F
		public static void AddPlayerMoveTag(FlatBufferBuilder builder, EPlayerMoveTag playerMoveTag)
		{
			builder.AddByte(23, (byte)playerMoveTag, 0);
		}

		// Token: 0x0602ACB1 RID: 175281 RVA: 0x005E64AB File Offset: 0x005E46AB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(24, nullMask, 0);
		}

		// Token: 0x0602ACB2 RID: 175282 RVA: 0x005E64B7 File Offset: 0x005E46B7
		public static Offset<IAdjustFixedLookAtCamera> EndIAdjustFixedLookAtCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedLookAtCamera>(builder.EndTable());
		}

		// Token: 0x0602ACB3 RID: 175283 RVA: 0x005E64C4 File Offset: 0x005E46C4
		public IAdjustFixedLookAtCameraT UnPack()
		{
			IAdjustFixedLookAtCameraT adjustFixedLookAtCameraT = new IAdjustFixedLookAtCameraT();
			this.UnPackTo(adjustFixedLookAtCameraT);
			return adjustFixedLookAtCameraT;
		}

		// Token: 0x0602ACB4 RID: 175284 RVA: 0x005E64E0 File Offset: 0x005E46E0
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

		// Token: 0x0602ACB5 RID: 175285 RVA: 0x005E67DC File Offset: 0x005E49DC
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

		// Token: 0x040105CA RID: 67018
		private Table __p;
	}
}
