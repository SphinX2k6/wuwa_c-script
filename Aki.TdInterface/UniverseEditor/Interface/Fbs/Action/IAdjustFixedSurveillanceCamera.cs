using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006161 RID: 24929
	public struct IAdjustFixedSurveillanceCamera : IFlatbufferObject
	{
		// Token: 0x1700B91E RID: 47390
		// (get) Token: 0x0602AD28 RID: 175400 RVA: 0x005E75FB File Offset: 0x005E57FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AD29 RID: 175401 RVA: 0x005E7608 File Offset: 0x005E5808
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AD2A RID: 175402 RVA: 0x005E7610 File Offset: 0x005E5810
		public static IAdjustFixedSurveillanceCamera GetRootAsIAdjustFixedSurveillanceCamera(ByteBuffer _bb)
		{
			return IAdjustFixedSurveillanceCamera.GetRootAsIAdjustFixedSurveillanceCamera(_bb, default(IAdjustFixedSurveillanceCamera));
		}

		// Token: 0x0602AD2B RID: 175403 RVA: 0x005E762C File Offset: 0x005E582C
		public static IAdjustFixedSurveillanceCamera GetRootAsIAdjustFixedSurveillanceCamera(ByteBuffer _bb, IAdjustFixedSurveillanceCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AD2C RID: 175404 RVA: 0x005E7649 File Offset: 0x005E5849
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AD2D RID: 175405 RVA: 0x005E7658 File Offset: 0x005E5858
		public IAdjustFixedSurveillanceCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B91F RID: 47391
		// (get) Token: 0x0602AD2E RID: 175406 RVA: 0x005E7668 File Offset: 0x005E5868
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

		// Token: 0x1700B920 RID: 47392
		// (get) Token: 0x0602AD2F RID: 175407 RVA: 0x005E76A4 File Offset: 0x005E58A4
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

		// Token: 0x1700B921 RID: 47393
		// (get) Token: 0x0602AD30 RID: 175408 RVA: 0x005E76E0 File Offset: 0x005E58E0
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

		// Token: 0x1700B922 RID: 47394
		// (get) Token: 0x0602AD31 RID: 175409 RVA: 0x005E7720 File Offset: 0x005E5920
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

		// Token: 0x1700B923 RID: 47395
		// (get) Token: 0x0602AD32 RID: 175410 RVA: 0x005E7780 File Offset: 0x005E5980
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

		// Token: 0x1700B924 RID: 47396
		// (get) Token: 0x0602AD33 RID: 175411 RVA: 0x005E77C4 File Offset: 0x005E59C4
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

		// Token: 0x1700B925 RID: 47397
		// (get) Token: 0x0602AD34 RID: 175412 RVA: 0x005E7824 File Offset: 0x005E5A24
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

		// Token: 0x1700B926 RID: 47398
		// (get) Token: 0x0602AD35 RID: 175413 RVA: 0x005E7868 File Offset: 0x005E5A68
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

		// Token: 0x1700B927 RID: 47399
		// (get) Token: 0x0602AD36 RID: 175414 RVA: 0x005E78AC File Offset: 0x005E5AAC
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

		// Token: 0x1700B928 RID: 47400
		// (get) Token: 0x0602AD37 RID: 175415 RVA: 0x005E78F0 File Offset: 0x005E5AF0
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

		// Token: 0x1700B929 RID: 47401
		// (get) Token: 0x0602AD38 RID: 175416 RVA: 0x005E7950 File Offset: 0x005E5B50
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

		// Token: 0x1700B92A RID: 47402
		// (get) Token: 0x0602AD39 RID: 175417 RVA: 0x005E79B0 File Offset: 0x005E5BB0
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

		// Token: 0x1700B92B RID: 47403
		// (get) Token: 0x0602AD3A RID: 175418 RVA: 0x005E79F4 File Offset: 0x005E5BF4
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

		// Token: 0x1700B92C RID: 47404
		// (get) Token: 0x0602AD3B RID: 175419 RVA: 0x005E7A38 File Offset: 0x005E5C38
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

		// Token: 0x1700B92D RID: 47405
		// (get) Token: 0x0602AD3C RID: 175420 RVA: 0x005E7A7C File Offset: 0x005E5C7C
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

		// Token: 0x1700B92E RID: 47406
		// (get) Token: 0x0602AD3D RID: 175421 RVA: 0x005E7AC0 File Offset: 0x005E5CC0
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

		// Token: 0x1700B92F RID: 47407
		// (get) Token: 0x0602AD3E RID: 175422 RVA: 0x005E7B04 File Offset: 0x005E5D04
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B930 RID: 47408
		// (get) Token: 0x0602AD3F RID: 175423 RVA: 0x005E7B44 File Offset: 0x005E5D44
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

		// Token: 0x0602AD40 RID: 175424 RVA: 0x005E7B84 File Offset: 0x005E5D84
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602AD41 RID: 175425 RVA: 0x005E7BCC File Offset: 0x005E5DCC
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602AD42 RID: 175426 RVA: 0x005E7BE8 File Offset: 0x005E5DE8
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602AD43 RID: 175427 RVA: 0x005E7C04 File Offset: 0x005E5E04
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602AD44 RID: 175428 RVA: 0x005E7C20 File Offset: 0x005E5E20
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700B931 RID: 47409
		// (get) Token: 0x0602AD45 RID: 175429 RVA: 0x005E7C3C File Offset: 0x005E5E3C
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B932 RID: 47410
		// (get) Token: 0x0602AD46 RID: 175430 RVA: 0x005E7C7C File Offset: 0x005E5E7C
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B933 RID: 47411
		// (get) Token: 0x0602AD47 RID: 175431 RVA: 0x005E7CBC File Offset: 0x005E5EBC
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

		// Token: 0x0602AD48 RID: 175432 RVA: 0x005E7CF4 File Offset: 0x005E5EF4
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602AD49 RID: 175433 RVA: 0x005E7D04 File Offset: 0x005E5F04
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700B934 RID: 47412
		// (get) Token: 0x0602AD4A RID: 175434 RVA: 0x005E7D14 File Offset: 0x005E5F14
		public IVectorInfo? CenterPos
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B935 RID: 47413
		// (get) Token: 0x0602AD4B RID: 175435 RVA: 0x005E7D74 File Offset: 0x005E5F74
		public IBlendFunction? BlendIn
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return new IBlendFunction?(default(IBlendFunction).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B936 RID: 47414
		// (get) Token: 0x0602AD4C RID: 175436 RVA: 0x005E7DD4 File Offset: 0x005E5FD4
		public IBlendFunction? BlendOut
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return new IBlendFunction?(default(IBlendFunction).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B937 RID: 47415
		// (get) Token: 0x0602AD4D RID: 175437 RVA: 0x005E7E34 File Offset: 0x005E6034
		public IAdjustFixedCameraOrthogonalConfig? OrthogonalConfig
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return new IAdjustFixedCameraOrthogonalConfig?(default(IAdjustFixedCameraOrthogonalConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B938 RID: 47416
		// (get) Token: 0x0602AD4E RID: 175438 RVA: 0x005E7E94 File Offset: 0x005E6094
		public TTargetEntity FollowTargetType
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602AD4F RID: 175439 RVA: 0x005E7ED4 File Offset: 0x005E60D4
		public TTable? FollowTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602AD50 RID: 175440 RVA: 0x005E7F1C File Offset: 0x005E611C
		public IPlayerEntity FollowTargetAsIPlayerEntity()
		{
			return this.FollowTarget<IPlayerEntity>().Value;
		}

		// Token: 0x0602AD51 RID: 175441 RVA: 0x005E7F38 File Offset: 0x005E6138
		public ISelfEntity FollowTargetAsISelfEntity()
		{
			return this.FollowTarget<ISelfEntity>().Value;
		}

		// Token: 0x0602AD52 RID: 175442 RVA: 0x005E7F54 File Offset: 0x005E6154
		public ITargetEntity FollowTargetAsITargetEntity()
		{
			return this.FollowTarget<ITargetEntity>().Value;
		}

		// Token: 0x0602AD53 RID: 175443 RVA: 0x005E7F70 File Offset: 0x005E6170
		public ITriggeredEntity FollowTargetAsITriggeredEntity()
		{
			return this.FollowTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x0602AD54 RID: 175444 RVA: 0x005E7F8C File Offset: 0x005E618C
		public IVehicleEntity FollowTargetAsIVehicleEntity()
		{
			return this.FollowTarget<IVehicleEntity>().Value;
		}

		// Token: 0x1700B939 RID: 47417
		// (get) Token: 0x0602AD55 RID: 175445 RVA: 0x005E7FA8 File Offset: 0x005E61A8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602AD56 RID: 175446 RVA: 0x005E7FE8 File Offset: 0x005E61E8
		public static Offset<IAdjustFixedSurveillanceCamera> CreateIAdjustFixedSurveillanceCamera(FlatBufferBuilder builder, EAdjustPlayerCamera Type = EAdjustPlayerCamera.Basic, int Priority = 0, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>), float FadeOutTime = 0f, Offset<IBaseCurve> FadeOutCurveOffset = default(Offset<IBaseCurve>), float ArmLength = 0f, float MinumArmLength = 0f, float MaxiumArmLength = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArmOffsetOffset = default(Offset<IVectorInfo>), float YawLimitMin = 0f, float YawLimitMax = 0f, float PitchLimitMin = 0f, float PitchLimitMax = 0f, float Fov = 0f, bool IsDisableResetFocus = false, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool IsDisableCollision = false, bool IsDisableDither = false, StringOffset SubScreenBindKeyOffset = default(StringOffset), Offset<IVectorInfo> CenterPosOffset = default(Offset<IVectorInfo>), Offset<IBlendFunction> BlendInOffset = default(Offset<IBlendFunction>), Offset<IBlendFunction> BlendOutOffset = default(Offset<IBlendFunction>), Offset<IAdjustFixedCameraOrthogonalConfig> OrthogonalConfigOffset = default(Offset<IAdjustFixedCameraOrthogonalConfig>), TTargetEntity FollowTarget_type = TTargetEntity.NONE, int FollowTargetOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(29);
			IAdjustFixedSurveillanceCamera.AddFollowTarget(builder, FollowTargetOffset);
			IAdjustFixedSurveillanceCamera.AddOrthogonalConfig(builder, OrthogonalConfigOffset);
			IAdjustFixedSurveillanceCamera.AddBlendOut(builder, BlendOutOffset);
			IAdjustFixedSurveillanceCamera.AddBlendIn(builder, BlendInOffset);
			IAdjustFixedSurveillanceCamera.AddCenterPos(builder, CenterPosOffset);
			IAdjustFixedSurveillanceCamera.AddSubScreenBindKey(builder, SubScreenBindKeyOffset);
			IAdjustFixedSurveillanceCamera.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustFixedSurveillanceCamera.AddFov(builder, Fov);
			IAdjustFixedSurveillanceCamera.AddPitchLimitMax(builder, PitchLimitMax);
			IAdjustFixedSurveillanceCamera.AddPitchLimitMin(builder, PitchLimitMin);
			IAdjustFixedSurveillanceCamera.AddYawLimitMax(builder, YawLimitMax);
			IAdjustFixedSurveillanceCamera.AddYawLimitMin(builder, YawLimitMin);
			IAdjustFixedSurveillanceCamera.AddArmOffset(builder, ArmOffsetOffset);
			IAdjustFixedSurveillanceCamera.AddOffset(builder, OffsetOffset);
			IAdjustFixedSurveillanceCamera.AddMaxiumArmLength(builder, MaxiumArmLength);
			IAdjustFixedSurveillanceCamera.AddMinumArmLength(builder, MinumArmLength);
			IAdjustFixedSurveillanceCamera.AddArmLength(builder, ArmLength);
			IAdjustFixedSurveillanceCamera.AddFadeOutCurve(builder, FadeOutCurveOffset);
			IAdjustFixedSurveillanceCamera.AddFadeOutTime(builder, FadeOutTime);
			IAdjustFixedSurveillanceCamera.AddFadeInCurve(builder, FadeInCurveOffset);
			IAdjustFixedSurveillanceCamera.AddFadeInTime(builder, FadeInTime);
			IAdjustFixedSurveillanceCamera.AddPriority(builder, Priority);
			IAdjustFixedSurveillanceCamera.AddNullMask(builder, NullMask);
			IAdjustFixedSurveillanceCamera.AddFollowTargetType(builder, FollowTarget_type);
			IAdjustFixedSurveillanceCamera.AddIsDisableDither(builder, IsDisableDither);
			IAdjustFixedSurveillanceCamera.AddIsDisableCollision(builder, IsDisableCollision);
			IAdjustFixedSurveillanceCamera.AddGravityDirectionType(builder, GravityDirection_type);
			IAdjustFixedSurveillanceCamera.AddIsDisableResetFocus(builder, IsDisableResetFocus);
			IAdjustFixedSurveillanceCamera.AddType(builder, Type);
			return IAdjustFixedSurveillanceCamera.EndIAdjustFixedSurveillanceCamera(builder);
		}

		// Token: 0x0602AD57 RID: 175447 RVA: 0x005E80E8 File Offset: 0x005E62E8
		public static void StartIAdjustFixedSurveillanceCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(29);
		}

		// Token: 0x0602AD58 RID: 175448 RVA: 0x005E80F2 File Offset: 0x005E62F2
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AD59 RID: 175449 RVA: 0x005E80FD File Offset: 0x005E62FD
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602AD5A RID: 175450 RVA: 0x005E8108 File Offset: 0x005E6308
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602AD5B RID: 175451 RVA: 0x005E811B File Offset: 0x005E631B
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602AD5C RID: 175452 RVA: 0x005E812B File Offset: 0x005E632B
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602AD5D RID: 175453 RVA: 0x005E813E File Offset: 0x005E633E
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602AD5E RID: 175454 RVA: 0x005E814E File Offset: 0x005E634E
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602AD5F RID: 175455 RVA: 0x005E8161 File Offset: 0x005E6361
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602AD60 RID: 175456 RVA: 0x005E8174 File Offset: 0x005E6374
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602AD61 RID: 175457 RVA: 0x005E8187 File Offset: 0x005E6387
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602AD62 RID: 175458 RVA: 0x005E8198 File Offset: 0x005E6398
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602AD63 RID: 175459 RVA: 0x005E81A9 File Offset: 0x005E63A9
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602AD64 RID: 175460 RVA: 0x005E81BD File Offset: 0x005E63BD
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602AD65 RID: 175461 RVA: 0x005E81D1 File Offset: 0x005E63D1
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602AD66 RID: 175462 RVA: 0x005E81E5 File Offset: 0x005E63E5
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602AD67 RID: 175463 RVA: 0x005E81F9 File Offset: 0x005E63F9
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602AD68 RID: 175464 RVA: 0x005E820D File Offset: 0x005E640D
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602AD69 RID: 175465 RVA: 0x005E8219 File Offset: 0x005E6419
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602AD6A RID: 175466 RVA: 0x005E8225 File Offset: 0x005E6425
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602AD6B RID: 175467 RVA: 0x005E8231 File Offset: 0x005E6431
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602AD6C RID: 175468 RVA: 0x005E823D File Offset: 0x005E643D
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602AD6D RID: 175469 RVA: 0x005E8249 File Offset: 0x005E6449
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602AD6E RID: 175470 RVA: 0x005E825A File Offset: 0x005E645A
		public static void AddCenterPos(FlatBufferBuilder builder, Offset<IVectorInfo> centerPosOffset)
		{
			builder.AddOffset(22, centerPosOffset.Value, 0);
		}

		// Token: 0x0602AD6F RID: 175471 RVA: 0x005E826B File Offset: 0x005E646B
		public static void AddBlendIn(FlatBufferBuilder builder, Offset<IBlendFunction> blendInOffset)
		{
			builder.AddOffset(23, blendInOffset.Value, 0);
		}

		// Token: 0x0602AD70 RID: 175472 RVA: 0x005E827C File Offset: 0x005E647C
		public static void AddBlendOut(FlatBufferBuilder builder, Offset<IBlendFunction> blendOutOffset)
		{
			builder.AddOffset(24, blendOutOffset.Value, 0);
		}

		// Token: 0x0602AD71 RID: 175473 RVA: 0x005E828D File Offset: 0x005E648D
		public static void AddOrthogonalConfig(FlatBufferBuilder builder, Offset<IAdjustFixedCameraOrthogonalConfig> orthogonalConfigOffset)
		{
			builder.AddOffset(25, orthogonalConfigOffset.Value, 0);
		}

		// Token: 0x0602AD72 RID: 175474 RVA: 0x005E829E File Offset: 0x005E649E
		public static void AddFollowTargetType(FlatBufferBuilder builder, TTargetEntity followTargetType)
		{
			builder.AddByte(26, (byte)followTargetType, 0);
		}

		// Token: 0x0602AD73 RID: 175475 RVA: 0x005E82AA File Offset: 0x005E64AA
		public static void AddFollowTarget(FlatBufferBuilder builder, int followTargetOffset)
		{
			builder.AddOffset(27, followTargetOffset, 0);
		}

		// Token: 0x0602AD74 RID: 175476 RVA: 0x005E82B6 File Offset: 0x005E64B6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(28, nullMask, 0);
		}

		// Token: 0x0602AD75 RID: 175477 RVA: 0x005E82C2 File Offset: 0x005E64C2
		public static Offset<IAdjustFixedSurveillanceCamera> EndIAdjustFixedSurveillanceCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedSurveillanceCamera>(builder.EndTable());
		}

		// Token: 0x0602AD76 RID: 175478 RVA: 0x005E82D0 File Offset: 0x005E64D0
		public IAdjustFixedSurveillanceCameraT UnPack()
		{
			IAdjustFixedSurveillanceCameraT adjustFixedSurveillanceCameraT = new IAdjustFixedSurveillanceCameraT();
			this.UnPackTo(adjustFixedSurveillanceCameraT);
			return adjustFixedSurveillanceCameraT;
		}

		// Token: 0x0602AD77 RID: 175479 RVA: 0x005E82EC File Offset: 0x005E64EC
		public void UnPackTo(IAdjustFixedSurveillanceCameraT _o)
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
			_o.CenterPos = ((this.CenterPos != null) ? this.CenterPos.Value.UnPack() : null);
			_o.BlendIn = ((this.BlendIn != null) ? this.BlendIn.Value.UnPack() : null);
			_o.BlendOut = ((this.BlendOut != null) ? this.BlendOut.Value.UnPack() : null);
			_o.OrthogonalConfig = ((this.OrthogonalConfig != null) ? this.OrthogonalConfig.Value.UnPack() : null);
			_o.FollowTarget = new TTargetEntityUnion();
			_o.FollowTarget.Type = this.FollowTargetType;
			switch (this.FollowTargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.FollowTarget.Value = ((this.FollowTarget<IPlayerEntity>() != null) ? this.FollowTarget<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.FollowTarget.Value = ((this.FollowTarget<ISelfEntity>() != null) ? this.FollowTarget<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.FollowTarget.Value = ((this.FollowTarget<ITargetEntity>() != null) ? this.FollowTarget<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.FollowTarget.Value = ((this.FollowTarget<ITriggeredEntity>() != null) ? this.FollowTarget<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.FollowTarget.Value = ((this.FollowTarget<IVehicleEntity>() != null) ? this.FollowTarget<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602AD78 RID: 175480 RVA: 0x005E87D4 File Offset: 0x005E69D4
		public static Offset<IAdjustFixedSurveillanceCamera> Pack(FlatBufferBuilder builder, IAdjustFixedSurveillanceCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustFixedSurveillanceCamera>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			Offset<IBaseCurve> fadeOutCurveOffset = (_o.FadeOutCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeOutCurve);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> armOffsetOffset = (_o.ArmOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArmOffset);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			StringOffset subScreenBindKeyOffset = (_o.SubScreenBindKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenBindKey);
			Offset<IVectorInfo> centerPosOffset = (_o.CenterPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CenterPos);
			Offset<IBlendFunction> blendInOffset = (_o.BlendIn == null) ? default(Offset<IBlendFunction>) : IBlendFunction.Pack(builder, _o.BlendIn);
			Offset<IBlendFunction> blendOutOffset = (_o.BlendOut == null) ? default(Offset<IBlendFunction>) : IBlendFunction.Pack(builder, _o.BlendOut);
			Offset<IAdjustFixedCameraOrthogonalConfig> orthogonalConfigOffset = (_o.OrthogonalConfig == null) ? default(Offset<IAdjustFixedCameraOrthogonalConfig>) : IAdjustFixedCameraOrthogonalConfig.Pack(builder, _o.OrthogonalConfig);
			TTargetEntity followTarget_type = (_o.FollowTarget == null) ? TTargetEntity.NONE : _o.FollowTarget.Type;
			int followTargetOffset = (_o.FollowTarget == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.FollowTarget);
			return IAdjustFixedSurveillanceCamera.CreateIAdjustFixedSurveillanceCamera(builder, _o.Type, _o.Priority, _o.FadeInTime, fadeInCurveOffset, _o.FadeOutTime, fadeOutCurveOffset, _o.ArmLength, _o.MinumArmLength, _o.MaxiumArmLength, offsetOffset, armOffsetOffset, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.Fov, _o.IsDisableResetFocus, gravityDirection_type, gravityDirectionOffset, _o.IsDisableCollision, _o.IsDisableDither, subScreenBindKeyOffset, centerPosOffset, blendInOffset, blendOutOffset, orthogonalConfigOffset, followTarget_type, followTargetOffset, _o.NullMask);
		}

		// Token: 0x040105F1 RID: 67057
		private Table __p;
	}
}
