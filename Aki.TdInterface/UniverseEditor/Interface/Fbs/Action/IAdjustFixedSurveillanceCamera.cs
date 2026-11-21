using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C6 RID: 26566
	public struct IAdjustFixedSurveillanceCamera : IFlatbufferObject
	{
		// Token: 0x1700C28E RID: 49806
		// (get) Token: 0x0602D421 RID: 185377 RVA: 0x006317D7 File Offset: 0x0062F9D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D422 RID: 185378 RVA: 0x006317E4 File Offset: 0x0062F9E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D423 RID: 185379 RVA: 0x006317EC File Offset: 0x0062F9EC
		public static IAdjustFixedSurveillanceCamera GetRootAsIAdjustFixedSurveillanceCamera(ByteBuffer _bb)
		{
			return IAdjustFixedSurveillanceCamera.GetRootAsIAdjustFixedSurveillanceCamera(_bb, default(IAdjustFixedSurveillanceCamera));
		}

		// Token: 0x0602D424 RID: 185380 RVA: 0x00631808 File Offset: 0x0062FA08
		public static IAdjustFixedSurveillanceCamera GetRootAsIAdjustFixedSurveillanceCamera(ByteBuffer _bb, IAdjustFixedSurveillanceCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D425 RID: 185381 RVA: 0x00631825 File Offset: 0x0062FA25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D426 RID: 185382 RVA: 0x00631834 File Offset: 0x0062FA34
		public IAdjustFixedSurveillanceCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C28F RID: 49807
		// (get) Token: 0x0602D427 RID: 185383 RVA: 0x00631844 File Offset: 0x0062FA44
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

		// Token: 0x1700C290 RID: 49808
		// (get) Token: 0x0602D428 RID: 185384 RVA: 0x00631880 File Offset: 0x0062FA80
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

		// Token: 0x1700C291 RID: 49809
		// (get) Token: 0x0602D429 RID: 185385 RVA: 0x006318BC File Offset: 0x0062FABC
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

		// Token: 0x1700C292 RID: 49810
		// (get) Token: 0x0602D42A RID: 185386 RVA: 0x006318FC File Offset: 0x0062FAFC
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

		// Token: 0x1700C293 RID: 49811
		// (get) Token: 0x0602D42B RID: 185387 RVA: 0x0063195C File Offset: 0x0062FB5C
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

		// Token: 0x1700C294 RID: 49812
		// (get) Token: 0x0602D42C RID: 185388 RVA: 0x006319A0 File Offset: 0x0062FBA0
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

		// Token: 0x1700C295 RID: 49813
		// (get) Token: 0x0602D42D RID: 185389 RVA: 0x00631A00 File Offset: 0x0062FC00
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

		// Token: 0x1700C296 RID: 49814
		// (get) Token: 0x0602D42E RID: 185390 RVA: 0x00631A44 File Offset: 0x0062FC44
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

		// Token: 0x1700C297 RID: 49815
		// (get) Token: 0x0602D42F RID: 185391 RVA: 0x00631A88 File Offset: 0x0062FC88
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

		// Token: 0x1700C298 RID: 49816
		// (get) Token: 0x0602D430 RID: 185392 RVA: 0x00631ACC File Offset: 0x0062FCCC
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

		// Token: 0x1700C299 RID: 49817
		// (get) Token: 0x0602D431 RID: 185393 RVA: 0x00631B2C File Offset: 0x0062FD2C
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

		// Token: 0x1700C29A RID: 49818
		// (get) Token: 0x0602D432 RID: 185394 RVA: 0x00631B8C File Offset: 0x0062FD8C
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

		// Token: 0x1700C29B RID: 49819
		// (get) Token: 0x0602D433 RID: 185395 RVA: 0x00631BD0 File Offset: 0x0062FDD0
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

		// Token: 0x1700C29C RID: 49820
		// (get) Token: 0x0602D434 RID: 185396 RVA: 0x00631C14 File Offset: 0x0062FE14
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

		// Token: 0x1700C29D RID: 49821
		// (get) Token: 0x0602D435 RID: 185397 RVA: 0x00631C58 File Offset: 0x0062FE58
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

		// Token: 0x1700C29E RID: 49822
		// (get) Token: 0x0602D436 RID: 185398 RVA: 0x00631C9C File Offset: 0x0062FE9C
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

		// Token: 0x1700C29F RID: 49823
		// (get) Token: 0x0602D437 RID: 185399 RVA: 0x00631CE0 File Offset: 0x0062FEE0
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2A0 RID: 49824
		// (get) Token: 0x0602D438 RID: 185400 RVA: 0x00631D20 File Offset: 0x0062FF20
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

		// Token: 0x0602D439 RID: 185401 RVA: 0x00631D60 File Offset: 0x0062FF60
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D43A RID: 185402 RVA: 0x00631DA8 File Offset: 0x0062FFA8
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602D43B RID: 185403 RVA: 0x00631DC4 File Offset: 0x0062FFC4
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602D43C RID: 185404 RVA: 0x00631DE0 File Offset: 0x0062FFE0
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602D43D RID: 185405 RVA: 0x00631DFC File Offset: 0x0062FFFC
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700C2A1 RID: 49825
		// (get) Token: 0x0602D43E RID: 185406 RVA: 0x00631E18 File Offset: 0x00630018
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2A2 RID: 49826
		// (get) Token: 0x0602D43F RID: 185407 RVA: 0x00631E58 File Offset: 0x00630058
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C2A3 RID: 49827
		// (get) Token: 0x0602D440 RID: 185408 RVA: 0x00631E98 File Offset: 0x00630098
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

		// Token: 0x0602D441 RID: 185409 RVA: 0x00631ED0 File Offset: 0x006300D0
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602D442 RID: 185410 RVA: 0x00631EE0 File Offset: 0x006300E0
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700C2A4 RID: 49828
		// (get) Token: 0x0602D443 RID: 185411 RVA: 0x00631EF0 File Offset: 0x006300F0
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

		// Token: 0x1700C2A5 RID: 49829
		// (get) Token: 0x0602D444 RID: 185412 RVA: 0x00631F50 File Offset: 0x00630150
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

		// Token: 0x1700C2A6 RID: 49830
		// (get) Token: 0x0602D445 RID: 185413 RVA: 0x00631FB0 File Offset: 0x006301B0
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

		// Token: 0x1700C2A7 RID: 49831
		// (get) Token: 0x0602D446 RID: 185414 RVA: 0x00632010 File Offset: 0x00630210
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

		// Token: 0x1700C2A8 RID: 49832
		// (get) Token: 0x0602D447 RID: 185415 RVA: 0x00632070 File Offset: 0x00630270
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

		// Token: 0x0602D448 RID: 185416 RVA: 0x006320B0 File Offset: 0x006302B0
		public TTable? FollowTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D449 RID: 185417 RVA: 0x006320F8 File Offset: 0x006302F8
		public IPlayerEntity FollowTargetAsIPlayerEntity()
		{
			return this.FollowTarget<IPlayerEntity>().Value;
		}

		// Token: 0x0602D44A RID: 185418 RVA: 0x00632114 File Offset: 0x00630314
		public ISelfEntity FollowTargetAsISelfEntity()
		{
			return this.FollowTarget<ISelfEntity>().Value;
		}

		// Token: 0x0602D44B RID: 185419 RVA: 0x00632130 File Offset: 0x00630330
		public ITargetEntity FollowTargetAsITargetEntity()
		{
			return this.FollowTarget<ITargetEntity>().Value;
		}

		// Token: 0x0602D44C RID: 185420 RVA: 0x0063214C File Offset: 0x0063034C
		public ITriggeredEntity FollowTargetAsITriggeredEntity()
		{
			return this.FollowTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x0602D44D RID: 185421 RVA: 0x00632168 File Offset: 0x00630368
		public IVehicleEntity FollowTargetAsIVehicleEntity()
		{
			return this.FollowTarget<IVehicleEntity>().Value;
		}

		// Token: 0x1700C2A9 RID: 49833
		// (get) Token: 0x0602D44E RID: 185422 RVA: 0x00632184 File Offset: 0x00630384
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

		// Token: 0x0602D44F RID: 185423 RVA: 0x006321C4 File Offset: 0x006303C4
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

		// Token: 0x0602D450 RID: 185424 RVA: 0x006322C4 File Offset: 0x006304C4
		public static void StartIAdjustFixedSurveillanceCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(29);
		}

		// Token: 0x0602D451 RID: 185425 RVA: 0x006322CE File Offset: 0x006304CE
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D452 RID: 185426 RVA: 0x006322D9 File Offset: 0x006304D9
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602D453 RID: 185427 RVA: 0x006322E4 File Offset: 0x006304E4
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602D454 RID: 185428 RVA: 0x006322F7 File Offset: 0x006304F7
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602D455 RID: 185429 RVA: 0x00632307 File Offset: 0x00630507
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602D456 RID: 185430 RVA: 0x0063231A File Offset: 0x0063051A
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602D457 RID: 185431 RVA: 0x0063232A File Offset: 0x0063052A
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602D458 RID: 185432 RVA: 0x0063233D File Offset: 0x0063053D
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602D459 RID: 185433 RVA: 0x00632350 File Offset: 0x00630550
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602D45A RID: 185434 RVA: 0x00632363 File Offset: 0x00630563
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602D45B RID: 185435 RVA: 0x00632374 File Offset: 0x00630574
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602D45C RID: 185436 RVA: 0x00632385 File Offset: 0x00630585
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602D45D RID: 185437 RVA: 0x00632399 File Offset: 0x00630599
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602D45E RID: 185438 RVA: 0x006323AD File Offset: 0x006305AD
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602D45F RID: 185439 RVA: 0x006323C1 File Offset: 0x006305C1
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602D460 RID: 185440 RVA: 0x006323D5 File Offset: 0x006305D5
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602D461 RID: 185441 RVA: 0x006323E9 File Offset: 0x006305E9
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602D462 RID: 185442 RVA: 0x006323F5 File Offset: 0x006305F5
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602D463 RID: 185443 RVA: 0x00632401 File Offset: 0x00630601
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602D464 RID: 185444 RVA: 0x0063240D File Offset: 0x0063060D
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602D465 RID: 185445 RVA: 0x00632419 File Offset: 0x00630619
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602D466 RID: 185446 RVA: 0x00632425 File Offset: 0x00630625
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602D467 RID: 185447 RVA: 0x00632436 File Offset: 0x00630636
		public static void AddCenterPos(FlatBufferBuilder builder, Offset<IVectorInfo> centerPosOffset)
		{
			builder.AddOffset(22, centerPosOffset.Value, 0);
		}

		// Token: 0x0602D468 RID: 185448 RVA: 0x00632447 File Offset: 0x00630647
		public static void AddBlendIn(FlatBufferBuilder builder, Offset<IBlendFunction> blendInOffset)
		{
			builder.AddOffset(23, blendInOffset.Value, 0);
		}

		// Token: 0x0602D469 RID: 185449 RVA: 0x00632458 File Offset: 0x00630658
		public static void AddBlendOut(FlatBufferBuilder builder, Offset<IBlendFunction> blendOutOffset)
		{
			builder.AddOffset(24, blendOutOffset.Value, 0);
		}

		// Token: 0x0602D46A RID: 185450 RVA: 0x00632469 File Offset: 0x00630669
		public static void AddOrthogonalConfig(FlatBufferBuilder builder, Offset<IAdjustFixedCameraOrthogonalConfig> orthogonalConfigOffset)
		{
			builder.AddOffset(25, orthogonalConfigOffset.Value, 0);
		}

		// Token: 0x0602D46B RID: 185451 RVA: 0x0063247A File Offset: 0x0063067A
		public static void AddFollowTargetType(FlatBufferBuilder builder, TTargetEntity followTargetType)
		{
			builder.AddByte(26, (byte)followTargetType, 0);
		}

		// Token: 0x0602D46C RID: 185452 RVA: 0x00632486 File Offset: 0x00630686
		public static void AddFollowTarget(FlatBufferBuilder builder, int followTargetOffset)
		{
			builder.AddOffset(27, followTargetOffset, 0);
		}

		// Token: 0x0602D46D RID: 185453 RVA: 0x00632492 File Offset: 0x00630692
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(28, nullMask, 0);
		}

		// Token: 0x0602D46E RID: 185454 RVA: 0x0063249E File Offset: 0x0063069E
		public static Offset<IAdjustFixedSurveillanceCamera> EndIAdjustFixedSurveillanceCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedSurveillanceCamera>(builder.EndTable());
		}

		// Token: 0x0602D46F RID: 185455 RVA: 0x006324AC File Offset: 0x006306AC
		public IAdjustFixedSurveillanceCameraT UnPack()
		{
			IAdjustFixedSurveillanceCameraT adjustFixedSurveillanceCameraT = new IAdjustFixedSurveillanceCameraT();
			this.UnPackTo(adjustFixedSurveillanceCameraT);
			return adjustFixedSurveillanceCameraT;
		}

		// Token: 0x0602D470 RID: 185456 RVA: 0x006324C8 File Offset: 0x006306C8
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

		// Token: 0x0602D471 RID: 185457 RVA: 0x006329B0 File Offset: 0x00630BB0
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

		// Token: 0x040113F8 RID: 70648
		private Table __p;
	}
}
