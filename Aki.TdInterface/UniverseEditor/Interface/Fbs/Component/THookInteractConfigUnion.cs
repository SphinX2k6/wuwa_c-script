using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C37 RID: 23607
	public class THookInteractConfigUnion
	{
		// Token: 0x1700B202 RID: 45570
		// (get) Token: 0x06028797 RID: 165783 RVA: 0x005919EC File Offset: 0x0058FBEC
		// (set) Token: 0x06028798 RID: 165784 RVA: 0x005919F4 File Offset: 0x0058FBF4
		public THookInteractConfig Type { get; set; }

		// Token: 0x1700B203 RID: 45571
		// (get) Token: 0x06028799 RID: 165785 RVA: 0x005919FD File Offset: 0x0058FBFD
		// (set) Token: 0x0602879A RID: 165786 RVA: 0x00591A05 File Offset: 0x0058FC05
		public object Value { get; set; }

		// Token: 0x0602879B RID: 165787 RVA: 0x00591A0E File Offset: 0x0058FC0E
		public THookInteractConfigUnion()
		{
			this.Type = THookInteractConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602879C RID: 165788 RVA: 0x00591A24 File Offset: 0x0058FC24
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602879D RID: 165789 RVA: 0x00591A36 File Offset: 0x0058FC36
		public ICableWayT AsICableWay()
		{
			return this.As<ICableWayT>();
		}

		// Token: 0x0602879E RID: 165790 RVA: 0x00591A3E File Offset: 0x0058FC3E
		public static THookInteractConfigUnion FromICableWay(ICableWayT _icableway)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.ICableWay,
				Value = _icableway
			};
		}

		// Token: 0x0602879F RID: 165791 RVA: 0x00591A53 File Offset: 0x0058FC53
		public IChargeSlashHookT AsIChargeSlashHook()
		{
			return this.As<IChargeSlashHookT>();
		}

		// Token: 0x060287A0 RID: 165792 RVA: 0x00591A5B File Offset: 0x0058FC5B
		public static THookInteractConfigUnion FromIChargeSlashHook(IChargeSlashHookT _ichargeslashhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IChargeSlashHook,
				Value = _ichargeslashhook
			};
		}

		// Token: 0x060287A1 RID: 165793 RVA: 0x00591A70 File Offset: 0x0058FC70
		public IFixedPointHookT AsIFixedPointHook()
		{
			return this.As<IFixedPointHookT>();
		}

		// Token: 0x060287A2 RID: 165794 RVA: 0x00591A78 File Offset: 0x0058FC78
		public static THookInteractConfigUnion FromIFixedPointHook(IFixedPointHookT _ifixedpointhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IFixedPointHook,
				Value = _ifixedpointhook
			};
		}

		// Token: 0x060287A3 RID: 165795 RVA: 0x00591A8D File Offset: 0x0058FC8D
		public IFlyingFeatherT AsIFlyingFeather()
		{
			return this.As<IFlyingFeatherT>();
		}

		// Token: 0x060287A4 RID: 165796 RVA: 0x00591A95 File Offset: 0x0058FC95
		public static THookInteractConfigUnion FromIFlyingFeather(IFlyingFeatherT _iflyingfeather)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IFlyingFeather,
				Value = _iflyingfeather
			};
		}

		// Token: 0x060287A5 RID: 165797 RVA: 0x00591AAA File Offset: 0x0058FCAA
		public IFollowerShootT AsIFollowerShoot()
		{
			return this.As<IFollowerShootT>();
		}

		// Token: 0x060287A6 RID: 165798 RVA: 0x00591AB2 File Offset: 0x0058FCB2
		public static THookInteractConfigUnion FromIFollowerShoot(IFollowerShootT _ifollowershoot)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IFollowerShoot,
				Value = _ifollowershoot
			};
		}

		// Token: 0x060287A7 RID: 165799 RVA: 0x00591AC7 File Offset: 0x0058FCC7
		public IFoxJumpingPointT AsIFoxJumpingPoint()
		{
			return this.As<IFoxJumpingPointT>();
		}

		// Token: 0x060287A8 RID: 165800 RVA: 0x00591ACF File Offset: 0x0058FCCF
		public static THookInteractConfigUnion FromIFoxJumpingPoint(IFoxJumpingPointT _ifoxjumpingpoint)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IFoxJumpingPoint,
				Value = _ifoxjumpingpoint
			};
		}

		// Token: 0x060287A9 RID: 165801 RVA: 0x00591AE4 File Offset: 0x0058FCE4
		public IGravityHookT AsIGravityHook()
		{
			return this.As<IGravityHookT>();
		}

		// Token: 0x060287AA RID: 165802 RVA: 0x00591AEC File Offset: 0x0058FCEC
		public static THookInteractConfigUnion FromIGravityHook(IGravityHookT _igravityhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IGravityHook,
				Value = _igravityhook
			};
		}

		// Token: 0x060287AB RID: 165803 RVA: 0x00591B01 File Offset: 0x0058FD01
		public IHookSpaceStationEnergyCoreT AsIHookSpaceStationEnergyCore()
		{
			return this.As<IHookSpaceStationEnergyCoreT>();
		}

		// Token: 0x060287AC RID: 165804 RVA: 0x00591B09 File Offset: 0x0058FD09
		public static THookInteractConfigUnion FromIHookSpaceStationEnergyCore(IHookSpaceStationEnergyCoreT _ihookspacestationenergycore)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IHookSpaceStationEnergyCore,
				Value = _ihookspacestationenergycore
			};
		}

		// Token: 0x060287AD RID: 165805 RVA: 0x00591B1E File Offset: 0x0058FD1E
		public IKiteHookT AsIKiteHook()
		{
			return this.As<IKiteHookT>();
		}

		// Token: 0x060287AE RID: 165806 RVA: 0x00591B26 File Offset: 0x0058FD26
		public static THookInteractConfigUnion FromIKiteHook(IKiteHookT _ikitehook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IKiteHook,
				Value = _ikitehook
			};
		}

		// Token: 0x060287AF RID: 165807 RVA: 0x00591B3C File Offset: 0x0058FD3C
		public IMechHookT AsIMechHook()
		{
			return this.As<IMechHookT>();
		}

		// Token: 0x060287B0 RID: 165808 RVA: 0x00591B44 File Offset: 0x0058FD44
		public static THookInteractConfigUnion FromIMechHook(IMechHookT _imechhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IMechHook,
				Value = _imechhook
			};
		}

		// Token: 0x060287B1 RID: 165809 RVA: 0x00591B5A File Offset: 0x0058FD5A
		public IMechPullInteractT AsIMechPullInteract()
		{
			return this.As<IMechPullInteractT>();
		}

		// Token: 0x060287B2 RID: 165810 RVA: 0x00591B62 File Offset: 0x0058FD62
		public static THookInteractConfigUnion FromIMechPullInteract(IMechPullInteractT _imechpullinteract)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IMechPullInteract,
				Value = _imechpullinteract
			};
		}

		// Token: 0x060287B3 RID: 165811 RVA: 0x00591B78 File Offset: 0x0058FD78
		public IMotorEjectHookT AsIMotorEjectHook()
		{
			return this.As<IMotorEjectHookT>();
		}

		// Token: 0x060287B4 RID: 165812 RVA: 0x00591B80 File Offset: 0x0058FD80
		public static THookInteractConfigUnion FromIMotorEjectHook(IMotorEjectHookT _imotorejecthook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IMotorEjectHook,
				Value = _imotorejecthook
			};
		}

		// Token: 0x060287B5 RID: 165813 RVA: 0x00591B96 File Offset: 0x0058FD96
		public IMotorPullInteractT AsIMotorPullInteract()
		{
			return this.As<IMotorPullInteractT>();
		}

		// Token: 0x060287B6 RID: 165814 RVA: 0x00591B9E File Offset: 0x0058FD9E
		public static THookInteractConfigUnion FromIMotorPullInteract(IMotorPullInteractT _imotorpullinteract)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IMotorPullInteract,
				Value = _imotorpullinteract
			};
		}

		// Token: 0x060287B7 RID: 165815 RVA: 0x00591BB4 File Offset: 0x0058FDB4
		public IMovementPointHookT AsIMovementPointHook()
		{
			return this.As<IMovementPointHookT>();
		}

		// Token: 0x060287B8 RID: 165816 RVA: 0x00591BBC File Offset: 0x0058FDBC
		public static THookInteractConfigUnion FromIMovementPointHook(IMovementPointHookT _imovementpointhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IMovementPointHook,
				Value = _imovementpointhook
			};
		}

		// Token: 0x060287B9 RID: 165817 RVA: 0x00591BD2 File Offset: 0x0058FDD2
		public IPilotThrowT AsIPilotThrow()
		{
			return this.As<IPilotThrowT>();
		}

		// Token: 0x060287BA RID: 165818 RVA: 0x00591BDA File Offset: 0x0058FDDA
		public static THookInteractConfigUnion FromIPilotThrow(IPilotThrowT _ipilotthrow)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IPilotThrow,
				Value = _ipilotthrow
			};
		}

		// Token: 0x060287BB RID: 165819 RVA: 0x00591BF0 File Offset: 0x0058FDF0
		public IRagDollClimbingPointT AsIRagDollClimbingPoint()
		{
			return this.As<IRagDollClimbingPointT>();
		}

		// Token: 0x060287BC RID: 165820 RVA: 0x00591BF8 File Offset: 0x0058FDF8
		public static THookInteractConfigUnion FromIRagDollClimbingPoint(IRagDollClimbingPointT _iragdollclimbingpoint)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IRagDollClimbingPoint,
				Value = _iragdollclimbingpoint
			};
		}

		// Token: 0x060287BD RID: 165821 RVA: 0x00591C0E File Offset: 0x0058FE0E
		public IRagDollJumpingPointT AsIRagDollJumpingPoint()
		{
			return this.As<IRagDollJumpingPointT>();
		}

		// Token: 0x060287BE RID: 165822 RVA: 0x00591C16 File Offset: 0x0058FE16
		public static THookInteractConfigUnion FromIRagDollJumpingPoint(IRagDollJumpingPointT _iragdolljumpingpoint)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IRagDollJumpingPoint,
				Value = _iragdolljumpingpoint
			};
		}

		// Token: 0x060287BF RID: 165823 RVA: 0x00591C2C File Offset: 0x0058FE2C
		public ISlashHookT AsISlashHook()
		{
			return this.As<ISlashHookT>();
		}

		// Token: 0x060287C0 RID: 165824 RVA: 0x00591C34 File Offset: 0x0058FE34
		public static THookInteractConfigUnion FromISlashHook(ISlashHookT _islashhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.ISlashHook,
				Value = _islashhook
			};
		}

		// Token: 0x060287C1 RID: 165825 RVA: 0x00591C4A File Offset: 0x0058FE4A
		public ISuiGuangHookT AsISuiGuangHook()
		{
			return this.As<ISuiGuangHookT>();
		}

		// Token: 0x060287C2 RID: 165826 RVA: 0x00591C52 File Offset: 0x0058FE52
		public static THookInteractConfigUnion FromISuiGuangHook(ISuiGuangHookT _isuiguanghook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.ISuiGuangHook,
				Value = _isuiguanghook
			};
		}

		// Token: 0x060287C3 RID: 165827 RVA: 0x00591C68 File Offset: 0x0058FE68
		public ISunSpiritLauncherT AsISunSpiritLauncher()
		{
			return this.As<ISunSpiritLauncherT>();
		}

		// Token: 0x060287C4 RID: 165828 RVA: 0x00591C70 File Offset: 0x0058FE70
		public static THookInteractConfigUnion FromISunSpiritLauncher(ISunSpiritLauncherT _isunspiritlauncher)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.ISunSpiritLauncher,
				Value = _isunspiritlauncher
			};
		}

		// Token: 0x060287C5 RID: 165829 RVA: 0x00591C86 File Offset: 0x0058FE86
		public IWaterBoxBigWeaponHookT AsIWaterBoxBigWeaponHook()
		{
			return this.As<IWaterBoxBigWeaponHookT>();
		}

		// Token: 0x060287C6 RID: 165830 RVA: 0x00591C8E File Offset: 0x0058FE8E
		public static THookInteractConfigUnion FromIWaterBoxBigWeaponHook(IWaterBoxBigWeaponHookT _iwaterboxbigweaponhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IWaterBoxBigWeaponHook,
				Value = _iwaterboxbigweaponhook
			};
		}

		// Token: 0x060287C7 RID: 165831 RVA: 0x00591CA4 File Offset: 0x0058FEA4
		public static int Pack(FlatBufferBuilder builder, THookInteractConfigUnion _o)
		{
			switch (_o.Type)
			{
			case THookInteractConfig.ICableWay:
				return ICableWay.Pack(builder, _o.AsICableWay()).Value;
			case THookInteractConfig.IChargeSlashHook:
				return IChargeSlashHook.Pack(builder, _o.AsIChargeSlashHook()).Value;
			case THookInteractConfig.IFixedPointHook:
				return IFixedPointHook.Pack(builder, _o.AsIFixedPointHook()).Value;
			case THookInteractConfig.IFlyingFeather:
				return IFlyingFeather.Pack(builder, _o.AsIFlyingFeather()).Value;
			case THookInteractConfig.IFollowerShoot:
				return IFollowerShoot.Pack(builder, _o.AsIFollowerShoot()).Value;
			case THookInteractConfig.IFoxJumpingPoint:
				return IFoxJumpingPoint.Pack(builder, _o.AsIFoxJumpingPoint()).Value;
			case THookInteractConfig.IGravityHook:
				return IGravityHook.Pack(builder, _o.AsIGravityHook()).Value;
			case THookInteractConfig.IHookSpaceStationEnergyCore:
				return IHookSpaceStationEnergyCore.Pack(builder, _o.AsIHookSpaceStationEnergyCore()).Value;
			case THookInteractConfig.IKiteHook:
				return IKiteHook.Pack(builder, _o.AsIKiteHook()).Value;
			case THookInteractConfig.IMechHook:
				return IMechHook.Pack(builder, _o.AsIMechHook()).Value;
			case THookInteractConfig.IMechPullInteract:
				return IMechPullInteract.Pack(builder, _o.AsIMechPullInteract()).Value;
			case THookInteractConfig.IMotorEjectHook:
				return IMotorEjectHook.Pack(builder, _o.AsIMotorEjectHook()).Value;
			case THookInteractConfig.IMotorPullInteract:
				return IMotorPullInteract.Pack(builder, _o.AsIMotorPullInteract()).Value;
			case THookInteractConfig.IMovementPointHook:
				return IMovementPointHook.Pack(builder, _o.AsIMovementPointHook()).Value;
			case THookInteractConfig.IPilotThrow:
				return IPilotThrow.Pack(builder, _o.AsIPilotThrow()).Value;
			case THookInteractConfig.IRagDollClimbingPoint:
				return IRagDollClimbingPoint.Pack(builder, _o.AsIRagDollClimbingPoint()).Value;
			case THookInteractConfig.IRagDollJumpingPoint:
				return IRagDollJumpingPoint.Pack(builder, _o.AsIRagDollJumpingPoint()).Value;
			case THookInteractConfig.ISlashHook:
				return ISlashHook.Pack(builder, _o.AsISlashHook()).Value;
			case THookInteractConfig.ISuiGuangHook:
				return ISuiGuangHook.Pack(builder, _o.AsISuiGuangHook()).Value;
			case THookInteractConfig.ISunSpiritLauncher:
				return ISunSpiritLauncher.Pack(builder, _o.AsISunSpiritLauncher()).Value;
			case THookInteractConfig.IWaterBoxBigWeaponHook:
				return IWaterBoxBigWeaponHook.Pack(builder, _o.AsIWaterBoxBigWeaponHook()).Value;
			default:
				return 0;
			}
		}
	}
}
