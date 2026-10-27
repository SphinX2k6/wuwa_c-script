using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C6 RID: 21446
	public class IHookInteractType_UnionUnion
	{
		// Token: 0x17009DA7 RID: 40359
		// (get) Token: 0x0602327C RID: 143996 RVA: 0x004DDE79 File Offset: 0x004DC079
		// (set) Token: 0x0602327D RID: 143997 RVA: 0x004DDE81 File Offset: 0x004DC081
		public IHookInteractType_Union Type { get; set; }

		// Token: 0x17009DA8 RID: 40360
		// (get) Token: 0x0602327E RID: 143998 RVA: 0x004DDE8A File Offset: 0x004DC08A
		// (set) Token: 0x0602327F RID: 143999 RVA: 0x004DDE92 File Offset: 0x004DC092
		public object Value { get; set; }

		// Token: 0x06023280 RID: 144000 RVA: 0x004DDE9B File Offset: 0x004DC09B
		public IHookInteractType_UnionUnion()
		{
			this.Type = IHookInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023281 RID: 144001 RVA: 0x004DDEB1 File Offset: 0x004DC0B1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023282 RID: 144002 RVA: 0x004DDEC3 File Offset: 0x004DC0C3
		public IHookInteractTypeT AsIHookInteractType()
		{
			return this.As<IHookInteractTypeT>();
		}

		// Token: 0x06023283 RID: 144003 RVA: 0x004DDECB File Offset: 0x004DC0CB
		public static IHookInteractType_UnionUnion FromIHookInteractType(IHookInteractTypeT _ihookinteracttype)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IHookInteractType,
				Value = _ihookinteracttype
			};
		}

		// Token: 0x06023284 RID: 144004 RVA: 0x004DDEE0 File Offset: 0x004DC0E0
		public IFixedPointHookT AsIFixedPointHook()
		{
			return this.As<IFixedPointHookT>();
		}

		// Token: 0x06023285 RID: 144005 RVA: 0x004DDEE8 File Offset: 0x004DC0E8
		public static IHookInteractType_UnionUnion FromIFixedPointHook(IFixedPointHookT _ifixedpointhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IFixedPointHook,
				Value = _ifixedpointhook
			};
		}

		// Token: 0x06023286 RID: 144006 RVA: 0x004DDEFD File Offset: 0x004DC0FD
		public IMovementPointHookT AsIMovementPointHook()
		{
			return this.As<IMovementPointHookT>();
		}

		// Token: 0x06023287 RID: 144007 RVA: 0x004DDF05 File Offset: 0x004DC105
		public static IHookInteractType_UnionUnion FromIMovementPointHook(IMovementPointHookT _imovementpointhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IMovementPointHook,
				Value = _imovementpointhook
			};
		}

		// Token: 0x06023288 RID: 144008 RVA: 0x004DDF1A File Offset: 0x004DC11A
		public ISuiGuangHookT AsISuiGuangHook()
		{
			return this.As<ISuiGuangHookT>();
		}

		// Token: 0x06023289 RID: 144009 RVA: 0x004DDF22 File Offset: 0x004DC122
		public static IHookInteractType_UnionUnion FromISuiGuangHook(ISuiGuangHookT _isuiguanghook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.ISuiGuangHook,
				Value = _isuiguanghook
			};
		}

		// Token: 0x0602328A RID: 144010 RVA: 0x004DDF37 File Offset: 0x004DC137
		public IWaterBoxBigWeaponHookT AsIWaterBoxBigWeaponHook()
		{
			return this.As<IWaterBoxBigWeaponHookT>();
		}

		// Token: 0x0602328B RID: 144011 RVA: 0x004DDF3F File Offset: 0x004DC13F
		public static IHookInteractType_UnionUnion FromIWaterBoxBigWeaponHook(IWaterBoxBigWeaponHookT _iwaterboxbigweaponhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IWaterBoxBigWeaponHook,
				Value = _iwaterboxbigweaponhook
			};
		}

		// Token: 0x0602328C RID: 144012 RVA: 0x004DDF54 File Offset: 0x004DC154
		public IMechHookT AsIMechHook()
		{
			return this.As<IMechHookT>();
		}

		// Token: 0x0602328D RID: 144013 RVA: 0x004DDF5C File Offset: 0x004DC15C
		public static IHookInteractType_UnionUnion FromIMechHook(IMechHookT _imechhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IMechHook,
				Value = _imechhook
			};
		}

		// Token: 0x0602328E RID: 144014 RVA: 0x004DDF71 File Offset: 0x004DC171
		public IKiteHookT AsIKiteHook()
		{
			return this.As<IKiteHookT>();
		}

		// Token: 0x0602328F RID: 144015 RVA: 0x004DDF79 File Offset: 0x004DC179
		public static IHookInteractType_UnionUnion FromIKiteHook(IKiteHookT _ikitehook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IKiteHook,
				Value = _ikitehook
			};
		}

		// Token: 0x06023290 RID: 144016 RVA: 0x004DDF8E File Offset: 0x004DC18E
		public IRagDollJumpingPointT AsIRagDollJumpingPoint()
		{
			return this.As<IRagDollJumpingPointT>();
		}

		// Token: 0x06023291 RID: 144017 RVA: 0x004DDF96 File Offset: 0x004DC196
		public static IHookInteractType_UnionUnion FromIRagDollJumpingPoint(IRagDollJumpingPointT _iragdolljumpingpoint)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IRagDollJumpingPoint,
				Value = _iragdolljumpingpoint
			};
		}

		// Token: 0x06023292 RID: 144018 RVA: 0x004DDFAB File Offset: 0x004DC1AB
		public IRagDollClimbingPointT AsIRagDollClimbingPoint()
		{
			return this.As<IRagDollClimbingPointT>();
		}

		// Token: 0x06023293 RID: 144019 RVA: 0x004DDFB3 File Offset: 0x004DC1B3
		public static IHookInteractType_UnionUnion FromIRagDollClimbingPoint(IRagDollClimbingPointT _iragdollclimbingpoint)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IRagDollClimbingPoint,
				Value = _iragdollclimbingpoint
			};
		}

		// Token: 0x06023294 RID: 144020 RVA: 0x004DDFC9 File Offset: 0x004DC1C9
		public IFoxJumpingPointT AsIFoxJumpingPoint()
		{
			return this.As<IFoxJumpingPointT>();
		}

		// Token: 0x06023295 RID: 144021 RVA: 0x004DDFD1 File Offset: 0x004DC1D1
		public static IHookInteractType_UnionUnion FromIFoxJumpingPoint(IFoxJumpingPointT _ifoxjumpingpoint)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IFoxJumpingPoint,
				Value = _ifoxjumpingpoint
			};
		}

		// Token: 0x06023296 RID: 144022 RVA: 0x004DDFE7 File Offset: 0x004DC1E7
		public ISlashHookT AsISlashHook()
		{
			return this.As<ISlashHookT>();
		}

		// Token: 0x06023297 RID: 144023 RVA: 0x004DDFEF File Offset: 0x004DC1EF
		public static IHookInteractType_UnionUnion FromISlashHook(ISlashHookT _islashhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.ISlashHook,
				Value = _islashhook
			};
		}

		// Token: 0x06023298 RID: 144024 RVA: 0x004DE005 File Offset: 0x004DC205
		public IChargeSlashHookT AsIChargeSlashHook()
		{
			return this.As<IChargeSlashHookT>();
		}

		// Token: 0x06023299 RID: 144025 RVA: 0x004DE00D File Offset: 0x004DC20D
		public static IHookInteractType_UnionUnion FromIChargeSlashHook(IChargeSlashHookT _ichargeslashhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IChargeSlashHook,
				Value = _ichargeslashhook
			};
		}

		// Token: 0x0602329A RID: 144026 RVA: 0x004DE023 File Offset: 0x004DC223
		public IGravityHookT AsIGravityHook()
		{
			return this.As<IGravityHookT>();
		}

		// Token: 0x0602329B RID: 144027 RVA: 0x004DE02B File Offset: 0x004DC22B
		public static IHookInteractType_UnionUnion FromIGravityHook(IGravityHookT _igravityhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IGravityHook,
				Value = _igravityhook
			};
		}

		// Token: 0x0602329C RID: 144028 RVA: 0x004DE041 File Offset: 0x004DC241
		public IFlyingFeatherT AsIFlyingFeather()
		{
			return this.As<IFlyingFeatherT>();
		}

		// Token: 0x0602329D RID: 144029 RVA: 0x004DE049 File Offset: 0x004DC249
		public static IHookInteractType_UnionUnion FromIFlyingFeather(IFlyingFeatherT _iflyingfeather)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IFlyingFeather,
				Value = _iflyingfeather
			};
		}

		// Token: 0x0602329E RID: 144030 RVA: 0x004DE05F File Offset: 0x004DC25F
		public IPilotThrowT AsIPilotThrow()
		{
			return this.As<IPilotThrowT>();
		}

		// Token: 0x0602329F RID: 144031 RVA: 0x004DE067 File Offset: 0x004DC267
		public static IHookInteractType_UnionUnion FromIPilotThrow(IPilotThrowT _ipilotthrow)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IPilotThrow,
				Value = _ipilotthrow
			};
		}

		// Token: 0x060232A0 RID: 144032 RVA: 0x004DE07D File Offset: 0x004DC27D
		public ISunSpiritLauncherT AsISunSpiritLauncher()
		{
			return this.As<ISunSpiritLauncherT>();
		}

		// Token: 0x060232A1 RID: 144033 RVA: 0x004DE085 File Offset: 0x004DC285
		public static IHookInteractType_UnionUnion FromISunSpiritLauncher(ISunSpiritLauncherT _isunspiritlauncher)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.ISunSpiritLauncher,
				Value = _isunspiritlauncher
			};
		}

		// Token: 0x060232A2 RID: 144034 RVA: 0x004DE09B File Offset: 0x004DC29B
		public ICableWayT AsICableWay()
		{
			return this.As<ICableWayT>();
		}

		// Token: 0x060232A3 RID: 144035 RVA: 0x004DE0A3 File Offset: 0x004DC2A3
		public static IHookInteractType_UnionUnion FromICableWay(ICableWayT _icableway)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.ICableWay,
				Value = _icableway
			};
		}

		// Token: 0x060232A4 RID: 144036 RVA: 0x004DE0B9 File Offset: 0x004DC2B9
		public IFollowerShootT AsIFollowerShoot()
		{
			return this.As<IFollowerShootT>();
		}

		// Token: 0x060232A5 RID: 144037 RVA: 0x004DE0C1 File Offset: 0x004DC2C1
		public static IHookInteractType_UnionUnion FromIFollowerShoot(IFollowerShootT _ifollowershoot)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IFollowerShoot,
				Value = _ifollowershoot
			};
		}

		// Token: 0x060232A6 RID: 144038 RVA: 0x004DE0D7 File Offset: 0x004DC2D7
		public IMotorPullInteractT AsIMotorPullInteract()
		{
			return this.As<IMotorPullInteractT>();
		}

		// Token: 0x060232A7 RID: 144039 RVA: 0x004DE0DF File Offset: 0x004DC2DF
		public static IHookInteractType_UnionUnion FromIMotorPullInteract(IMotorPullInteractT _imotorpullinteract)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IMotorPullInteract,
				Value = _imotorpullinteract
			};
		}

		// Token: 0x060232A8 RID: 144040 RVA: 0x004DE0F5 File Offset: 0x004DC2F5
		public IMechPullInteractT AsIMechPullInteract()
		{
			return this.As<IMechPullInteractT>();
		}

		// Token: 0x060232A9 RID: 144041 RVA: 0x004DE0FD File Offset: 0x004DC2FD
		public static IHookInteractType_UnionUnion FromIMechPullInteract(IMechPullInteractT _imechpullinteract)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IMechPullInteract,
				Value = _imechpullinteract
			};
		}

		// Token: 0x060232AA RID: 144042 RVA: 0x004DE113 File Offset: 0x004DC313
		public IHookSpaceStationEnergyCoreT AsIHookSpaceStationEnergyCore()
		{
			return this.As<IHookSpaceStationEnergyCoreT>();
		}

		// Token: 0x060232AB RID: 144043 RVA: 0x004DE11B File Offset: 0x004DC31B
		public static IHookInteractType_UnionUnion FromIHookSpaceStationEnergyCore(IHookSpaceStationEnergyCoreT _ihookspacestationenergycore)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IHookSpaceStationEnergyCore,
				Value = _ihookspacestationenergycore
			};
		}

		// Token: 0x060232AC RID: 144044 RVA: 0x004DE131 File Offset: 0x004DC331
		public IMotorEjectHookT AsIMotorEjectHook()
		{
			return this.As<IMotorEjectHookT>();
		}

		// Token: 0x060232AD RID: 144045 RVA: 0x004DE139 File Offset: 0x004DC339
		public static IHookInteractType_UnionUnion FromIMotorEjectHook(IMotorEjectHookT _imotorejecthook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IMotorEjectHook,
				Value = _imotorejecthook
			};
		}

		// Token: 0x060232AE RID: 144046 RVA: 0x004DE150 File Offset: 0x004DC350
		public static int Pack(FlatBufferBuilder builder, IHookInteractType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IHookInteractType_Union.IHookInteractType:
				return IHookInteractType.Pack(builder, _o.AsIHookInteractType()).Value;
			case IHookInteractType_Union.IFixedPointHook:
				return IFixedPointHook.Pack(builder, _o.AsIFixedPointHook()).Value;
			case IHookInteractType_Union.IMovementPointHook:
				return IMovementPointHook.Pack(builder, _o.AsIMovementPointHook()).Value;
			case IHookInteractType_Union.ISuiGuangHook:
				return ISuiGuangHook.Pack(builder, _o.AsISuiGuangHook()).Value;
			case IHookInteractType_Union.IWaterBoxBigWeaponHook:
				return IWaterBoxBigWeaponHook.Pack(builder, _o.AsIWaterBoxBigWeaponHook()).Value;
			case IHookInteractType_Union.IMechHook:
				return IMechHook.Pack(builder, _o.AsIMechHook()).Value;
			case IHookInteractType_Union.IKiteHook:
				return IKiteHook.Pack(builder, _o.AsIKiteHook()).Value;
			case IHookInteractType_Union.IRagDollJumpingPoint:
				return IRagDollJumpingPoint.Pack(builder, _o.AsIRagDollJumpingPoint()).Value;
			case IHookInteractType_Union.IRagDollClimbingPoint:
				return IRagDollClimbingPoint.Pack(builder, _o.AsIRagDollClimbingPoint()).Value;
			case IHookInteractType_Union.IFoxJumpingPoint:
				return IFoxJumpingPoint.Pack(builder, _o.AsIFoxJumpingPoint()).Value;
			case IHookInteractType_Union.ISlashHook:
				return ISlashHook.Pack(builder, _o.AsISlashHook()).Value;
			case IHookInteractType_Union.IChargeSlashHook:
				return IChargeSlashHook.Pack(builder, _o.AsIChargeSlashHook()).Value;
			case IHookInteractType_Union.IGravityHook:
				return IGravityHook.Pack(builder, _o.AsIGravityHook()).Value;
			case IHookInteractType_Union.IFlyingFeather:
				return IFlyingFeather.Pack(builder, _o.AsIFlyingFeather()).Value;
			case IHookInteractType_Union.IPilotThrow:
				return IPilotThrow.Pack(builder, _o.AsIPilotThrow()).Value;
			case IHookInteractType_Union.ISunSpiritLauncher:
				return ISunSpiritLauncher.Pack(builder, _o.AsISunSpiritLauncher()).Value;
			case IHookInteractType_Union.ICableWay:
				return ICableWay.Pack(builder, _o.AsICableWay()).Value;
			case IHookInteractType_Union.IFollowerShoot:
				return IFollowerShoot.Pack(builder, _o.AsIFollowerShoot()).Value;
			case IHookInteractType_Union.IMotorPullInteract:
				return IMotorPullInteract.Pack(builder, _o.AsIMotorPullInteract()).Value;
			case IHookInteractType_Union.IMechPullInteract:
				return IMechPullInteract.Pack(builder, _o.AsIMechPullInteract()).Value;
			case IHookInteractType_Union.IHookSpaceStationEnergyCore:
				return IHookSpaceStationEnergyCore.Pack(builder, _o.AsIHookSpaceStationEnergyCore()).Value;
			case IHookInteractType_Union.IMotorEjectHook:
				return IMotorEjectHook.Pack(builder, _o.AsIMotorEjectHook()).Value;
			default:
				return 0;
			}
		}
	}
}
