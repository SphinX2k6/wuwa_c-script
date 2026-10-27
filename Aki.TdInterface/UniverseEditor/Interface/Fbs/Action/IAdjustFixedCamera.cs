using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200614C RID: 24908
	public struct IAdjustFixedCamera : IFlatbufferObject
	{
		// Token: 0x1700B888 RID: 47240
		// (get) Token: 0x0602AB95 RID: 174997 RVA: 0x005E34AF File Offset: 0x005E16AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AB96 RID: 174998 RVA: 0x005E34BC File Offset: 0x005E16BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AB97 RID: 174999 RVA: 0x005E34C4 File Offset: 0x005E16C4
		public static IAdjustFixedCamera GetRootAsIAdjustFixedCamera(ByteBuffer _bb)
		{
			return IAdjustFixedCamera.GetRootAsIAdjustFixedCamera(_bb, default(IAdjustFixedCamera));
		}

		// Token: 0x0602AB98 RID: 175000 RVA: 0x005E34E0 File Offset: 0x005E16E0
		public static IAdjustFixedCamera GetRootAsIAdjustFixedCamera(ByteBuffer _bb, IAdjustFixedCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AB99 RID: 175001 RVA: 0x005E34FD File Offset: 0x005E16FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AB9A RID: 175002 RVA: 0x005E350C File Offset: 0x005E170C
		public IAdjustFixedCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B889 RID: 47241
		// (get) Token: 0x0602AB9B RID: 175003 RVA: 0x005E351C File Offset: 0x005E171C
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

		// Token: 0x1700B88A RID: 47242
		// (get) Token: 0x0602AB9C RID: 175004 RVA: 0x005E3558 File Offset: 0x005E1758
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

		// Token: 0x1700B88B RID: 47243
		// (get) Token: 0x0602AB9D RID: 175005 RVA: 0x005E3594 File Offset: 0x005E1794
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

		// Token: 0x1700B88C RID: 47244
		// (get) Token: 0x0602AB9E RID: 175006 RVA: 0x005E35D4 File Offset: 0x005E17D4
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

		// Token: 0x1700B88D RID: 47245
		// (get) Token: 0x0602AB9F RID: 175007 RVA: 0x005E3634 File Offset: 0x005E1834
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

		// Token: 0x1700B88E RID: 47246
		// (get) Token: 0x0602ABA0 RID: 175008 RVA: 0x005E3678 File Offset: 0x005E1878
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

		// Token: 0x1700B88F RID: 47247
		// (get) Token: 0x0602ABA1 RID: 175009 RVA: 0x005E36D8 File Offset: 0x005E18D8
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

		// Token: 0x1700B890 RID: 47248
		// (get) Token: 0x0602ABA2 RID: 175010 RVA: 0x005E371C File Offset: 0x005E191C
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

		// Token: 0x1700B891 RID: 47249
		// (get) Token: 0x0602ABA3 RID: 175011 RVA: 0x005E3760 File Offset: 0x005E1960
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

		// Token: 0x1700B892 RID: 47250
		// (get) Token: 0x0602ABA4 RID: 175012 RVA: 0x005E37A4 File Offset: 0x005E19A4
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

		// Token: 0x1700B893 RID: 47251
		// (get) Token: 0x0602ABA5 RID: 175013 RVA: 0x005E3804 File Offset: 0x005E1A04
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

		// Token: 0x1700B894 RID: 47252
		// (get) Token: 0x0602ABA6 RID: 175014 RVA: 0x005E3864 File Offset: 0x005E1A64
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

		// Token: 0x1700B895 RID: 47253
		// (get) Token: 0x0602ABA7 RID: 175015 RVA: 0x005E38A8 File Offset: 0x005E1AA8
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

		// Token: 0x1700B896 RID: 47254
		// (get) Token: 0x0602ABA8 RID: 175016 RVA: 0x005E38EC File Offset: 0x005E1AEC
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

		// Token: 0x1700B897 RID: 47255
		// (get) Token: 0x0602ABA9 RID: 175017 RVA: 0x005E3930 File Offset: 0x005E1B30
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

		// Token: 0x1700B898 RID: 47256
		// (get) Token: 0x0602ABAA RID: 175018 RVA: 0x005E3974 File Offset: 0x005E1B74
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

		// Token: 0x1700B899 RID: 47257
		// (get) Token: 0x0602ABAB RID: 175019 RVA: 0x005E39B8 File Offset: 0x005E1BB8
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B89A RID: 47258
		// (get) Token: 0x0602ABAC RID: 175020 RVA: 0x005E39F8 File Offset: 0x005E1BF8
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

		// Token: 0x0602ABAD RID: 175021 RVA: 0x005E3A38 File Offset: 0x005E1C38
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602ABAE RID: 175022 RVA: 0x005E3A80 File Offset: 0x005E1C80
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602ABAF RID: 175023 RVA: 0x005E3A9C File Offset: 0x005E1C9C
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602ABB0 RID: 175024 RVA: 0x005E3AB8 File Offset: 0x005E1CB8
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602ABB1 RID: 175025 RVA: 0x005E3AD4 File Offset: 0x005E1CD4
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700B89B RID: 47259
		// (get) Token: 0x0602ABB2 RID: 175026 RVA: 0x005E3AF0 File Offset: 0x005E1CF0
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B89C RID: 47260
		// (get) Token: 0x0602ABB3 RID: 175027 RVA: 0x005E3B30 File Offset: 0x005E1D30
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B89D RID: 47261
		// (get) Token: 0x0602ABB4 RID: 175028 RVA: 0x005E3B70 File Offset: 0x005E1D70
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

		// Token: 0x0602ABB5 RID: 175029 RVA: 0x005E3BA8 File Offset: 0x005E1DA8
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602ABB6 RID: 175030 RVA: 0x005E3BB8 File Offset: 0x005E1DB8
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700B89E RID: 47262
		// (get) Token: 0x0602ABB7 RID: 175031 RVA: 0x005E3BC8 File Offset: 0x005E1DC8
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

		// Token: 0x1700B89F RID: 47263
		// (get) Token: 0x0602ABB8 RID: 175032 RVA: 0x005E3C28 File Offset: 0x005E1E28
		public IVectorInfo? CenterRot
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B8A0 RID: 47264
		// (get) Token: 0x0602ABB9 RID: 175033 RVA: 0x005E3C88 File Offset: 0x005E1E88
		public IBlendFunction? BlendIn
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

		// Token: 0x1700B8A1 RID: 47265
		// (get) Token: 0x0602ABBA RID: 175034 RVA: 0x005E3CE8 File Offset: 0x005E1EE8
		public IBlendFunction? BlendOut
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return new IBlendFunction?(default(IBlendFunction).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B8A2 RID: 47266
		// (get) Token: 0x0602ABBB RID: 175035 RVA: 0x005E3D48 File Offset: 0x005E1F48
		public IAdjustFixedCameraOrthogonalConfig? OrthogonalConfig
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return new IAdjustFixedCameraOrthogonalConfig?(default(IAdjustFixedCameraOrthogonalConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B8A3 RID: 47267
		// (get) Token: 0x0602ABBC RID: 175036 RVA: 0x005E3DA8 File Offset: 0x005E1FA8
		public IAdjustFixedCameraRotateConfig? RotateConfig
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return new IAdjustFixedCameraRotateConfig?(default(IAdjustFixedCameraRotateConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B8A4 RID: 47268
		// (get) Token: 0x0602ABBD RID: 175037 RVA: 0x005E3E08 File Offset: 0x005E2008
		public TTargetEntity FollowTargetType
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602ABBE RID: 175038 RVA: 0x005E3E48 File Offset: 0x005E2048
		public TTable? FollowTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602ABBF RID: 175039 RVA: 0x005E3E90 File Offset: 0x005E2090
		public IPlayerEntity FollowTargetAsIPlayerEntity()
		{
			return this.FollowTarget<IPlayerEntity>().Value;
		}

		// Token: 0x0602ABC0 RID: 175040 RVA: 0x005E3EAC File Offset: 0x005E20AC
		public ISelfEntity FollowTargetAsISelfEntity()
		{
			return this.FollowTarget<ISelfEntity>().Value;
		}

		// Token: 0x0602ABC1 RID: 175041 RVA: 0x005E3EC8 File Offset: 0x005E20C8
		public ITargetEntity FollowTargetAsITargetEntity()
		{
			return this.FollowTarget<ITargetEntity>().Value;
		}

		// Token: 0x0602ABC2 RID: 175042 RVA: 0x005E3EE4 File Offset: 0x005E20E4
		public ITriggeredEntity FollowTargetAsITriggeredEntity()
		{
			return this.FollowTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x0602ABC3 RID: 175043 RVA: 0x005E3F00 File Offset: 0x005E2100
		public IVehicleEntity FollowTargetAsIVehicleEntity()
		{
			return this.FollowTarget<IVehicleEntity>().Value;
		}

		// Token: 0x1700B8A5 RID: 47269
		// (get) Token: 0x0602ABC4 RID: 175044 RVA: 0x005E3F1C File Offset: 0x005E211C
		public bool IsPlotEnable
		{
			get
			{
				int num = this.__p.__offset(64);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B8A6 RID: 47270
		// (get) Token: 0x0602ABC5 RID: 175045 RVA: 0x005E3F5C File Offset: 0x005E215C
		public bool HidePlayer
		{
			get
			{
				int num = this.__p.__offset(66);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B8A7 RID: 47271
		// (get) Token: 0x0602ABC6 RID: 175046 RVA: 0x005E3F9C File Offset: 0x005E219C
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602ABC7 RID: 175047 RVA: 0x005E3FDC File Offset: 0x005E21DC
		public static Offset<IAdjustFixedCamera> CreateIAdjustFixedCamera(FlatBufferBuilder builder, EAdjustPlayerCamera Type = EAdjustPlayerCamera.Basic, int Priority = 0, float FadeInTime = 0f, Offset<IBaseCurve> FadeInCurveOffset = default(Offset<IBaseCurve>), float FadeOutTime = 0f, Offset<IBaseCurve> FadeOutCurveOffset = default(Offset<IBaseCurve>), float ArmLength = 0f, float MinumArmLength = 0f, float MaxiumArmLength = 0f, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArmOffsetOffset = default(Offset<IVectorInfo>), float YawLimitMin = 0f, float YawLimitMax = 0f, float PitchLimitMin = 0f, float PitchLimitMax = 0f, float Fov = 0f, bool IsDisableResetFocus = false, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool IsDisableCollision = false, bool IsDisableDither = false, StringOffset SubScreenBindKeyOffset = default(StringOffset), Offset<IVectorInfo> CenterPosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> CenterRotOffset = default(Offset<IVectorInfo>), Offset<IBlendFunction> BlendInOffset = default(Offset<IBlendFunction>), Offset<IBlendFunction> BlendOutOffset = default(Offset<IBlendFunction>), Offset<IAdjustFixedCameraOrthogonalConfig> OrthogonalConfigOffset = default(Offset<IAdjustFixedCameraOrthogonalConfig>), Offset<IAdjustFixedCameraRotateConfig> RotateConfigOffset = default(Offset<IAdjustFixedCameraRotateConfig>), TTargetEntity FollowTarget_type = TTargetEntity.NONE, int FollowTargetOffset = 0, bool IsPlotEnable = false, bool HidePlayer = false, ushort NullMask = 0)
		{
			builder.StartTable(33);
			IAdjustFixedCamera.AddFollowTarget(builder, FollowTargetOffset);
			IAdjustFixedCamera.AddRotateConfig(builder, RotateConfigOffset);
			IAdjustFixedCamera.AddOrthogonalConfig(builder, OrthogonalConfigOffset);
			IAdjustFixedCamera.AddBlendOut(builder, BlendOutOffset);
			IAdjustFixedCamera.AddBlendIn(builder, BlendInOffset);
			IAdjustFixedCamera.AddCenterRot(builder, CenterRotOffset);
			IAdjustFixedCamera.AddCenterPos(builder, CenterPosOffset);
			IAdjustFixedCamera.AddSubScreenBindKey(builder, SubScreenBindKeyOffset);
			IAdjustFixedCamera.AddGravityDirection(builder, GravityDirectionOffset);
			IAdjustFixedCamera.AddFov(builder, Fov);
			IAdjustFixedCamera.AddPitchLimitMax(builder, PitchLimitMax);
			IAdjustFixedCamera.AddPitchLimitMin(builder, PitchLimitMin);
			IAdjustFixedCamera.AddYawLimitMax(builder, YawLimitMax);
			IAdjustFixedCamera.AddYawLimitMin(builder, YawLimitMin);
			IAdjustFixedCamera.AddArmOffset(builder, ArmOffsetOffset);
			IAdjustFixedCamera.AddOffset(builder, OffsetOffset);
			IAdjustFixedCamera.AddMaxiumArmLength(builder, MaxiumArmLength);
			IAdjustFixedCamera.AddMinumArmLength(builder, MinumArmLength);
			IAdjustFixedCamera.AddArmLength(builder, ArmLength);
			IAdjustFixedCamera.AddFadeOutCurve(builder, FadeOutCurveOffset);
			IAdjustFixedCamera.AddFadeOutTime(builder, FadeOutTime);
			IAdjustFixedCamera.AddFadeInCurve(builder, FadeInCurveOffset);
			IAdjustFixedCamera.AddFadeInTime(builder, FadeInTime);
			IAdjustFixedCamera.AddPriority(builder, Priority);
			IAdjustFixedCamera.AddNullMask(builder, NullMask);
			IAdjustFixedCamera.AddHidePlayer(builder, HidePlayer);
			IAdjustFixedCamera.AddIsPlotEnable(builder, IsPlotEnable);
			IAdjustFixedCamera.AddFollowTargetType(builder, FollowTarget_type);
			IAdjustFixedCamera.AddIsDisableDither(builder, IsDisableDither);
			IAdjustFixedCamera.AddIsDisableCollision(builder, IsDisableCollision);
			IAdjustFixedCamera.AddGravityDirectionType(builder, GravityDirection_type);
			IAdjustFixedCamera.AddIsDisableResetFocus(builder, IsDisableResetFocus);
			IAdjustFixedCamera.AddType(builder, Type);
			return IAdjustFixedCamera.EndIAdjustFixedCamera(builder);
		}

		// Token: 0x0602ABC8 RID: 175048 RVA: 0x005E40FC File Offset: 0x005E22FC
		public static void StartIAdjustFixedCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(33);
		}

		// Token: 0x0602ABC9 RID: 175049 RVA: 0x005E4106 File Offset: 0x005E2306
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ABCA RID: 175050 RVA: 0x005E4111 File Offset: 0x005E2311
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602ABCB RID: 175051 RVA: 0x005E411C File Offset: 0x005E231C
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602ABCC RID: 175052 RVA: 0x005E412F File Offset: 0x005E232F
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602ABCD RID: 175053 RVA: 0x005E413F File Offset: 0x005E233F
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602ABCE RID: 175054 RVA: 0x005E4152 File Offset: 0x005E2352
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602ABCF RID: 175055 RVA: 0x005E4162 File Offset: 0x005E2362
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602ABD0 RID: 175056 RVA: 0x005E4175 File Offset: 0x005E2375
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602ABD1 RID: 175057 RVA: 0x005E4188 File Offset: 0x005E2388
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602ABD2 RID: 175058 RVA: 0x005E419B File Offset: 0x005E239B
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602ABD3 RID: 175059 RVA: 0x005E41AC File Offset: 0x005E23AC
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602ABD4 RID: 175060 RVA: 0x005E41BD File Offset: 0x005E23BD
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602ABD5 RID: 175061 RVA: 0x005E41D1 File Offset: 0x005E23D1
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602ABD6 RID: 175062 RVA: 0x005E41E5 File Offset: 0x005E23E5
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602ABD7 RID: 175063 RVA: 0x005E41F9 File Offset: 0x005E23F9
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602ABD8 RID: 175064 RVA: 0x005E420D File Offset: 0x005E240D
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602ABD9 RID: 175065 RVA: 0x005E4221 File Offset: 0x005E2421
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602ABDA RID: 175066 RVA: 0x005E422D File Offset: 0x005E242D
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602ABDB RID: 175067 RVA: 0x005E4239 File Offset: 0x005E2439
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602ABDC RID: 175068 RVA: 0x005E4245 File Offset: 0x005E2445
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602ABDD RID: 175069 RVA: 0x005E4251 File Offset: 0x005E2451
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602ABDE RID: 175070 RVA: 0x005E425D File Offset: 0x005E245D
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602ABDF RID: 175071 RVA: 0x005E426E File Offset: 0x005E246E
		public static void AddCenterPos(FlatBufferBuilder builder, Offset<IVectorInfo> centerPosOffset)
		{
			builder.AddOffset(22, centerPosOffset.Value, 0);
		}

		// Token: 0x0602ABE0 RID: 175072 RVA: 0x005E427F File Offset: 0x005E247F
		public static void AddCenterRot(FlatBufferBuilder builder, Offset<IVectorInfo> centerRotOffset)
		{
			builder.AddOffset(23, centerRotOffset.Value, 0);
		}

		// Token: 0x0602ABE1 RID: 175073 RVA: 0x005E4290 File Offset: 0x005E2490
		public static void AddBlendIn(FlatBufferBuilder builder, Offset<IBlendFunction> blendInOffset)
		{
			builder.AddOffset(24, blendInOffset.Value, 0);
		}

		// Token: 0x0602ABE2 RID: 175074 RVA: 0x005E42A1 File Offset: 0x005E24A1
		public static void AddBlendOut(FlatBufferBuilder builder, Offset<IBlendFunction> blendOutOffset)
		{
			builder.AddOffset(25, blendOutOffset.Value, 0);
		}

		// Token: 0x0602ABE3 RID: 175075 RVA: 0x005E42B2 File Offset: 0x005E24B2
		public static void AddOrthogonalConfig(FlatBufferBuilder builder, Offset<IAdjustFixedCameraOrthogonalConfig> orthogonalConfigOffset)
		{
			builder.AddOffset(26, orthogonalConfigOffset.Value, 0);
		}

		// Token: 0x0602ABE4 RID: 175076 RVA: 0x005E42C3 File Offset: 0x005E24C3
		public static void AddRotateConfig(FlatBufferBuilder builder, Offset<IAdjustFixedCameraRotateConfig> rotateConfigOffset)
		{
			builder.AddOffset(27, rotateConfigOffset.Value, 0);
		}

		// Token: 0x0602ABE5 RID: 175077 RVA: 0x005E42D4 File Offset: 0x005E24D4
		public static void AddFollowTargetType(FlatBufferBuilder builder, TTargetEntity followTargetType)
		{
			builder.AddByte(28, (byte)followTargetType, 0);
		}

		// Token: 0x0602ABE6 RID: 175078 RVA: 0x005E42E0 File Offset: 0x005E24E0
		public static void AddFollowTarget(FlatBufferBuilder builder, int followTargetOffset)
		{
			builder.AddOffset(29, followTargetOffset, 0);
		}

		// Token: 0x0602ABE7 RID: 175079 RVA: 0x005E42EC File Offset: 0x005E24EC
		public static void AddIsPlotEnable(FlatBufferBuilder builder, bool isPlotEnable)
		{
			builder.AddBool(30, isPlotEnable, false);
		}

		// Token: 0x0602ABE8 RID: 175080 RVA: 0x005E42F8 File Offset: 0x005E24F8
		public static void AddHidePlayer(FlatBufferBuilder builder, bool hidePlayer)
		{
			builder.AddBool(31, hidePlayer, false);
		}

		// Token: 0x0602ABE9 RID: 175081 RVA: 0x005E4304 File Offset: 0x005E2504
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(32, nullMask, 0);
		}

		// Token: 0x0602ABEA RID: 175082 RVA: 0x005E4310 File Offset: 0x005E2510
		public static Offset<IAdjustFixedCamera> EndIAdjustFixedCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedCamera>(builder.EndTable());
		}

		// Token: 0x0602ABEB RID: 175083 RVA: 0x005E4320 File Offset: 0x005E2520
		public IAdjustFixedCameraT UnPack()
		{
			IAdjustFixedCameraT adjustFixedCameraT = new IAdjustFixedCameraT();
			this.UnPackTo(adjustFixedCameraT);
			return adjustFixedCameraT;
		}

		// Token: 0x0602ABEC RID: 175084 RVA: 0x005E433C File Offset: 0x005E253C
		public void UnPackTo(IAdjustFixedCameraT _o)
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
			_o.CenterRot = ((this.CenterRot != null) ? this.CenterRot.Value.UnPack() : null);
			_o.BlendIn = ((this.BlendIn != null) ? this.BlendIn.Value.UnPack() : null);
			_o.BlendOut = ((this.BlendOut != null) ? this.BlendOut.Value.UnPack() : null);
			_o.OrthogonalConfig = ((this.OrthogonalConfig != null) ? this.OrthogonalConfig.Value.UnPack() : null);
			_o.RotateConfig = ((this.RotateConfig != null) ? this.RotateConfig.Value.UnPack() : null);
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
			_o.IsPlotEnable = this.IsPlotEnable;
			_o.HidePlayer = this.HidePlayer;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602ABED RID: 175085 RVA: 0x005E48A0 File Offset: 0x005E2AA0
		public static Offset<IAdjustFixedCamera> Pack(FlatBufferBuilder builder, IAdjustFixedCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustFixedCamera>);
			}
			Offset<IBaseCurve> fadeInCurveOffset = (_o.FadeInCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeInCurve);
			Offset<IBaseCurve> fadeOutCurveOffset = (_o.FadeOutCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.FadeOutCurve);
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IVectorInfo> armOffsetOffset = (_o.ArmOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArmOffset);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			StringOffset subScreenBindKeyOffset = (_o.SubScreenBindKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenBindKey);
			Offset<IVectorInfo> centerPosOffset = (_o.CenterPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CenterPos);
			Offset<IVectorInfo> centerRotOffset = (_o.CenterRot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CenterRot);
			Offset<IBlendFunction> blendInOffset = (_o.BlendIn == null) ? default(Offset<IBlendFunction>) : IBlendFunction.Pack(builder, _o.BlendIn);
			Offset<IBlendFunction> blendOutOffset = (_o.BlendOut == null) ? default(Offset<IBlendFunction>) : IBlendFunction.Pack(builder, _o.BlendOut);
			Offset<IAdjustFixedCameraOrthogonalConfig> orthogonalConfigOffset = (_o.OrthogonalConfig == null) ? default(Offset<IAdjustFixedCameraOrthogonalConfig>) : IAdjustFixedCameraOrthogonalConfig.Pack(builder, _o.OrthogonalConfig);
			Offset<IAdjustFixedCameraRotateConfig> rotateConfigOffset = (_o.RotateConfig == null) ? default(Offset<IAdjustFixedCameraRotateConfig>) : IAdjustFixedCameraRotateConfig.Pack(builder, _o.RotateConfig);
			TTargetEntity followTarget_type = (_o.FollowTarget == null) ? TTargetEntity.NONE : _o.FollowTarget.Type;
			int followTargetOffset = (_o.FollowTarget == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.FollowTarget);
			return IAdjustFixedCamera.CreateIAdjustFixedCamera(builder, _o.Type, _o.Priority, _o.FadeInTime, fadeInCurveOffset, _o.FadeOutTime, fadeOutCurveOffset, _o.ArmLength, _o.MinumArmLength, _o.MaxiumArmLength, offsetOffset, armOffsetOffset, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.Fov, _o.IsDisableResetFocus, gravityDirection_type, gravityDirectionOffset, _o.IsDisableCollision, _o.IsDisableDither, subScreenBindKeyOffset, centerPosOffset, centerRotOffset, blendInOffset, blendOutOffset, orthogonalConfigOffset, rotateConfigOffset, followTarget_type, followTargetOffset, _o.IsPlotEnable, _o.HidePlayer, _o.NullMask);
		}

		// Token: 0x0401059E RID: 66974
		private Table __p;
	}
}
