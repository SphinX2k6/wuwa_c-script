using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B1 RID: 26545
	public struct IAdjustFixedCamera : IFlatbufferObject
	{
		// Token: 0x1700C1F8 RID: 49656
		// (get) Token: 0x0602D28E RID: 184974 RVA: 0x0062D68B File Offset: 0x0062B88B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D28F RID: 184975 RVA: 0x0062D698 File Offset: 0x0062B898
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D290 RID: 184976 RVA: 0x0062D6A0 File Offset: 0x0062B8A0
		public static IAdjustFixedCamera GetRootAsIAdjustFixedCamera(ByteBuffer _bb)
		{
			return IAdjustFixedCamera.GetRootAsIAdjustFixedCamera(_bb, default(IAdjustFixedCamera));
		}

		// Token: 0x0602D291 RID: 184977 RVA: 0x0062D6BC File Offset: 0x0062B8BC
		public static IAdjustFixedCamera GetRootAsIAdjustFixedCamera(ByteBuffer _bb, IAdjustFixedCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D292 RID: 184978 RVA: 0x0062D6D9 File Offset: 0x0062B8D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D293 RID: 184979 RVA: 0x0062D6E8 File Offset: 0x0062B8E8
		public IAdjustFixedCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C1F9 RID: 49657
		// (get) Token: 0x0602D294 RID: 184980 RVA: 0x0062D6F8 File Offset: 0x0062B8F8
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

		// Token: 0x1700C1FA RID: 49658
		// (get) Token: 0x0602D295 RID: 184981 RVA: 0x0062D734 File Offset: 0x0062B934
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

		// Token: 0x1700C1FB RID: 49659
		// (get) Token: 0x0602D296 RID: 184982 RVA: 0x0062D770 File Offset: 0x0062B970
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

		// Token: 0x1700C1FC RID: 49660
		// (get) Token: 0x0602D297 RID: 184983 RVA: 0x0062D7B0 File Offset: 0x0062B9B0
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

		// Token: 0x1700C1FD RID: 49661
		// (get) Token: 0x0602D298 RID: 184984 RVA: 0x0062D810 File Offset: 0x0062BA10
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

		// Token: 0x1700C1FE RID: 49662
		// (get) Token: 0x0602D299 RID: 184985 RVA: 0x0062D854 File Offset: 0x0062BA54
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

		// Token: 0x1700C1FF RID: 49663
		// (get) Token: 0x0602D29A RID: 184986 RVA: 0x0062D8B4 File Offset: 0x0062BAB4
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

		// Token: 0x1700C200 RID: 49664
		// (get) Token: 0x0602D29B RID: 184987 RVA: 0x0062D8F8 File Offset: 0x0062BAF8
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

		// Token: 0x1700C201 RID: 49665
		// (get) Token: 0x0602D29C RID: 184988 RVA: 0x0062D93C File Offset: 0x0062BB3C
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

		// Token: 0x1700C202 RID: 49666
		// (get) Token: 0x0602D29D RID: 184989 RVA: 0x0062D980 File Offset: 0x0062BB80
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

		// Token: 0x1700C203 RID: 49667
		// (get) Token: 0x0602D29E RID: 184990 RVA: 0x0062D9E0 File Offset: 0x0062BBE0
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

		// Token: 0x1700C204 RID: 49668
		// (get) Token: 0x0602D29F RID: 184991 RVA: 0x0062DA40 File Offset: 0x0062BC40
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

		// Token: 0x1700C205 RID: 49669
		// (get) Token: 0x0602D2A0 RID: 184992 RVA: 0x0062DA84 File Offset: 0x0062BC84
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

		// Token: 0x1700C206 RID: 49670
		// (get) Token: 0x0602D2A1 RID: 184993 RVA: 0x0062DAC8 File Offset: 0x0062BCC8
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

		// Token: 0x1700C207 RID: 49671
		// (get) Token: 0x0602D2A2 RID: 184994 RVA: 0x0062DB0C File Offset: 0x0062BD0C
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

		// Token: 0x1700C208 RID: 49672
		// (get) Token: 0x0602D2A3 RID: 184995 RVA: 0x0062DB50 File Offset: 0x0062BD50
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

		// Token: 0x1700C209 RID: 49673
		// (get) Token: 0x0602D2A4 RID: 184996 RVA: 0x0062DB94 File Offset: 0x0062BD94
		public bool IsDisableResetFocus
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C20A RID: 49674
		// (get) Token: 0x0602D2A5 RID: 184997 RVA: 0x0062DBD4 File Offset: 0x0062BDD4
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

		// Token: 0x0602D2A6 RID: 184998 RVA: 0x0062DC14 File Offset: 0x0062BE14
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D2A7 RID: 184999 RVA: 0x0062DC5C File Offset: 0x0062BE5C
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x0602D2A8 RID: 185000 RVA: 0x0062DC78 File Offset: 0x0062BE78
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x0602D2A9 RID: 185001 RVA: 0x0062DC94 File Offset: 0x0062BE94
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0602D2AA RID: 185002 RVA: 0x0062DCB0 File Offset: 0x0062BEB0
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700C20B RID: 49675
		// (get) Token: 0x0602D2AB RID: 185003 RVA: 0x0062DCCC File Offset: 0x0062BECC
		public bool IsDisableCollision
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C20C RID: 49676
		// (get) Token: 0x0602D2AC RID: 185004 RVA: 0x0062DD0C File Offset: 0x0062BF0C
		public bool IsDisableDither
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C20D RID: 49677
		// (get) Token: 0x0602D2AD RID: 185005 RVA: 0x0062DD4C File Offset: 0x0062BF4C
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

		// Token: 0x0602D2AE RID: 185006 RVA: 0x0062DD84 File Offset: 0x0062BF84
		public Span<byte> GetSubScreenBindKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0602D2AF RID: 185007 RVA: 0x0062DD94 File Offset: 0x0062BF94
		public byte[] GetSubScreenBindKeyArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x1700C20E RID: 49678
		// (get) Token: 0x0602D2B0 RID: 185008 RVA: 0x0062DDA4 File Offset: 0x0062BFA4
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

		// Token: 0x1700C20F RID: 49679
		// (get) Token: 0x0602D2B1 RID: 185009 RVA: 0x0062DE04 File Offset: 0x0062C004
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

		// Token: 0x1700C210 RID: 49680
		// (get) Token: 0x0602D2B2 RID: 185010 RVA: 0x0062DE64 File Offset: 0x0062C064
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

		// Token: 0x1700C211 RID: 49681
		// (get) Token: 0x0602D2B3 RID: 185011 RVA: 0x0062DEC4 File Offset: 0x0062C0C4
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

		// Token: 0x1700C212 RID: 49682
		// (get) Token: 0x0602D2B4 RID: 185012 RVA: 0x0062DF24 File Offset: 0x0062C124
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

		// Token: 0x1700C213 RID: 49683
		// (get) Token: 0x0602D2B5 RID: 185013 RVA: 0x0062DF84 File Offset: 0x0062C184
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

		// Token: 0x1700C214 RID: 49684
		// (get) Token: 0x0602D2B6 RID: 185014 RVA: 0x0062DFE4 File Offset: 0x0062C1E4
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

		// Token: 0x0602D2B7 RID: 185015 RVA: 0x0062E024 File Offset: 0x0062C224
		public TTable? FollowTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D2B8 RID: 185016 RVA: 0x0062E06C File Offset: 0x0062C26C
		public IPlayerEntity FollowTargetAsIPlayerEntity()
		{
			return this.FollowTarget<IPlayerEntity>().Value;
		}

		// Token: 0x0602D2B9 RID: 185017 RVA: 0x0062E088 File Offset: 0x0062C288
		public ISelfEntity FollowTargetAsISelfEntity()
		{
			return this.FollowTarget<ISelfEntity>().Value;
		}

		// Token: 0x0602D2BA RID: 185018 RVA: 0x0062E0A4 File Offset: 0x0062C2A4
		public ITargetEntity FollowTargetAsITargetEntity()
		{
			return this.FollowTarget<ITargetEntity>().Value;
		}

		// Token: 0x0602D2BB RID: 185019 RVA: 0x0062E0C0 File Offset: 0x0062C2C0
		public ITriggeredEntity FollowTargetAsITriggeredEntity()
		{
			return this.FollowTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x0602D2BC RID: 185020 RVA: 0x0062E0DC File Offset: 0x0062C2DC
		public IVehicleEntity FollowTargetAsIVehicleEntity()
		{
			return this.FollowTarget<IVehicleEntity>().Value;
		}

		// Token: 0x1700C215 RID: 49685
		// (get) Token: 0x0602D2BD RID: 185021 RVA: 0x0062E0F8 File Offset: 0x0062C2F8
		public bool IsPlotEnable
		{
			get
			{
				int num = this.__p.__offset(64);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C216 RID: 49686
		// (get) Token: 0x0602D2BE RID: 185022 RVA: 0x0062E138 File Offset: 0x0062C338
		public bool HidePlayer
		{
			get
			{
				int num = this.__p.__offset(66);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C217 RID: 49687
		// (get) Token: 0x0602D2BF RID: 185023 RVA: 0x0062E178 File Offset: 0x0062C378
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

		// Token: 0x0602D2C0 RID: 185024 RVA: 0x0062E1B8 File Offset: 0x0062C3B8
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

		// Token: 0x0602D2C1 RID: 185025 RVA: 0x0062E2D8 File Offset: 0x0062C4D8
		public static void StartIAdjustFixedCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(33);
		}

		// Token: 0x0602D2C2 RID: 185026 RVA: 0x0062E2E2 File Offset: 0x0062C4E2
		public static void AddType(FlatBufferBuilder builder, EAdjustPlayerCamera type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D2C3 RID: 185027 RVA: 0x0062E2ED File Offset: 0x0062C4ED
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
			builder.AddInt(1, priority, 0);
		}

		// Token: 0x0602D2C4 RID: 185028 RVA: 0x0062E2F8 File Offset: 0x0062C4F8
		public static void AddFadeInTime(FlatBufferBuilder builder, float fadeInTime)
		{
			builder.AddFloat(2, fadeInTime, 0.0);
		}

		// Token: 0x0602D2C5 RID: 185029 RVA: 0x0062E30B File Offset: 0x0062C50B
		public static void AddFadeInCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeInCurveOffset)
		{
			builder.AddOffset(3, fadeInCurveOffset.Value, 0);
		}

		// Token: 0x0602D2C6 RID: 185030 RVA: 0x0062E31B File Offset: 0x0062C51B
		public static void AddFadeOutTime(FlatBufferBuilder builder, float fadeOutTime)
		{
			builder.AddFloat(4, fadeOutTime, 0.0);
		}

		// Token: 0x0602D2C7 RID: 185031 RVA: 0x0062E32E File Offset: 0x0062C52E
		public static void AddFadeOutCurve(FlatBufferBuilder builder, Offset<IBaseCurve> fadeOutCurveOffset)
		{
			builder.AddOffset(5, fadeOutCurveOffset.Value, 0);
		}

		// Token: 0x0602D2C8 RID: 185032 RVA: 0x0062E33E File Offset: 0x0062C53E
		public static void AddArmLength(FlatBufferBuilder builder, float armLength)
		{
			builder.AddFloat(6, armLength, 0.0);
		}

		// Token: 0x0602D2C9 RID: 185033 RVA: 0x0062E351 File Offset: 0x0062C551
		public static void AddMinumArmLength(FlatBufferBuilder builder, float minumArmLength)
		{
			builder.AddFloat(7, minumArmLength, 0.0);
		}

		// Token: 0x0602D2CA RID: 185034 RVA: 0x0062E364 File Offset: 0x0062C564
		public static void AddMaxiumArmLength(FlatBufferBuilder builder, float maxiumArmLength)
		{
			builder.AddFloat(8, maxiumArmLength, 0.0);
		}

		// Token: 0x0602D2CB RID: 185035 RVA: 0x0062E377 File Offset: 0x0062C577
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(9, offsetOffset.Value, 0);
		}

		// Token: 0x0602D2CC RID: 185036 RVA: 0x0062E388 File Offset: 0x0062C588
		public static void AddArmOffset(FlatBufferBuilder builder, Offset<IVectorInfo> armOffsetOffset)
		{
			builder.AddOffset(10, armOffsetOffset.Value, 0);
		}

		// Token: 0x0602D2CD RID: 185037 RVA: 0x0062E399 File Offset: 0x0062C599
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(11, yawLimitMin, 0.0);
		}

		// Token: 0x0602D2CE RID: 185038 RVA: 0x0062E3AD File Offset: 0x0062C5AD
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(12, yawLimitMax, 0.0);
		}

		// Token: 0x0602D2CF RID: 185039 RVA: 0x0062E3C1 File Offset: 0x0062C5C1
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(13, pitchLimitMin, 0.0);
		}

		// Token: 0x0602D2D0 RID: 185040 RVA: 0x0062E3D5 File Offset: 0x0062C5D5
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(14, pitchLimitMax, 0.0);
		}

		// Token: 0x0602D2D1 RID: 185041 RVA: 0x0062E3E9 File Offset: 0x0062C5E9
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(15, fov, 0.0);
		}

		// Token: 0x0602D2D2 RID: 185042 RVA: 0x0062E3FD File Offset: 0x0062C5FD
		public static void AddIsDisableResetFocus(FlatBufferBuilder builder, bool isDisableResetFocus)
		{
			builder.AddBool(16, isDisableResetFocus, false);
		}

		// Token: 0x0602D2D3 RID: 185043 RVA: 0x0062E409 File Offset: 0x0062C609
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(17, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0602D2D4 RID: 185044 RVA: 0x0062E415 File Offset: 0x0062C615
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(18, gravityDirectionOffset, 0);
		}

		// Token: 0x0602D2D5 RID: 185045 RVA: 0x0062E421 File Offset: 0x0062C621
		public static void AddIsDisableCollision(FlatBufferBuilder builder, bool isDisableCollision)
		{
			builder.AddBool(19, isDisableCollision, false);
		}

		// Token: 0x0602D2D6 RID: 185046 RVA: 0x0062E42D File Offset: 0x0062C62D
		public static void AddIsDisableDither(FlatBufferBuilder builder, bool isDisableDither)
		{
			builder.AddBool(20, isDisableDither, false);
		}

		// Token: 0x0602D2D7 RID: 185047 RVA: 0x0062E439 File Offset: 0x0062C639
		public static void AddSubScreenBindKey(FlatBufferBuilder builder, StringOffset subScreenBindKeyOffset)
		{
			builder.AddOffset(21, subScreenBindKeyOffset.Value, 0);
		}

		// Token: 0x0602D2D8 RID: 185048 RVA: 0x0062E44A File Offset: 0x0062C64A
		public static void AddCenterPos(FlatBufferBuilder builder, Offset<IVectorInfo> centerPosOffset)
		{
			builder.AddOffset(22, centerPosOffset.Value, 0);
		}

		// Token: 0x0602D2D9 RID: 185049 RVA: 0x0062E45B File Offset: 0x0062C65B
		public static void AddCenterRot(FlatBufferBuilder builder, Offset<IVectorInfo> centerRotOffset)
		{
			builder.AddOffset(23, centerRotOffset.Value, 0);
		}

		// Token: 0x0602D2DA RID: 185050 RVA: 0x0062E46C File Offset: 0x0062C66C
		public static void AddBlendIn(FlatBufferBuilder builder, Offset<IBlendFunction> blendInOffset)
		{
			builder.AddOffset(24, blendInOffset.Value, 0);
		}

		// Token: 0x0602D2DB RID: 185051 RVA: 0x0062E47D File Offset: 0x0062C67D
		public static void AddBlendOut(FlatBufferBuilder builder, Offset<IBlendFunction> blendOutOffset)
		{
			builder.AddOffset(25, blendOutOffset.Value, 0);
		}

		// Token: 0x0602D2DC RID: 185052 RVA: 0x0062E48E File Offset: 0x0062C68E
		public static void AddOrthogonalConfig(FlatBufferBuilder builder, Offset<IAdjustFixedCameraOrthogonalConfig> orthogonalConfigOffset)
		{
			builder.AddOffset(26, orthogonalConfigOffset.Value, 0);
		}

		// Token: 0x0602D2DD RID: 185053 RVA: 0x0062E49F File Offset: 0x0062C69F
		public static void AddRotateConfig(FlatBufferBuilder builder, Offset<IAdjustFixedCameraRotateConfig> rotateConfigOffset)
		{
			builder.AddOffset(27, rotateConfigOffset.Value, 0);
		}

		// Token: 0x0602D2DE RID: 185054 RVA: 0x0062E4B0 File Offset: 0x0062C6B0
		public static void AddFollowTargetType(FlatBufferBuilder builder, TTargetEntity followTargetType)
		{
			builder.AddByte(28, (byte)followTargetType, 0);
		}

		// Token: 0x0602D2DF RID: 185055 RVA: 0x0062E4BC File Offset: 0x0062C6BC
		public static void AddFollowTarget(FlatBufferBuilder builder, int followTargetOffset)
		{
			builder.AddOffset(29, followTargetOffset, 0);
		}

		// Token: 0x0602D2E0 RID: 185056 RVA: 0x0062E4C8 File Offset: 0x0062C6C8
		public static void AddIsPlotEnable(FlatBufferBuilder builder, bool isPlotEnable)
		{
			builder.AddBool(30, isPlotEnable, false);
		}

		// Token: 0x0602D2E1 RID: 185057 RVA: 0x0062E4D4 File Offset: 0x0062C6D4
		public static void AddHidePlayer(FlatBufferBuilder builder, bool hidePlayer)
		{
			builder.AddBool(31, hidePlayer, false);
		}

		// Token: 0x0602D2E2 RID: 185058 RVA: 0x0062E4E0 File Offset: 0x0062C6E0
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(32, nullMask, 0);
		}

		// Token: 0x0602D2E3 RID: 185059 RVA: 0x0062E4EC File Offset: 0x0062C6EC
		public static Offset<IAdjustFixedCamera> EndIAdjustFixedCamera(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedCamera>(builder.EndTable());
		}

		// Token: 0x0602D2E4 RID: 185060 RVA: 0x0062E4FC File Offset: 0x0062C6FC
		public IAdjustFixedCameraT UnPack()
		{
			IAdjustFixedCameraT adjustFixedCameraT = new IAdjustFixedCameraT();
			this.UnPackTo(adjustFixedCameraT);
			return adjustFixedCameraT;
		}

		// Token: 0x0602D2E5 RID: 185061 RVA: 0x0062E518 File Offset: 0x0062C718
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

		// Token: 0x0602D2E6 RID: 185062 RVA: 0x0062EA7C File Offset: 0x0062CC7C
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

		// Token: 0x040113A5 RID: 70565
		private Table __p;
	}
}
