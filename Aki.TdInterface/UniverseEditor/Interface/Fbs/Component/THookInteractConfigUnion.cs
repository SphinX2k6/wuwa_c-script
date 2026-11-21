using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200625C RID: 25180
	public class THookInteractConfigUnion
	{
		// Token: 0x1700BB54 RID: 47956
		// (get) Token: 0x0602ADA5 RID: 175525 RVA: 0x005D9C04 File Offset: 0x005D7E04
		// (set) Token: 0x0602ADA6 RID: 175526 RVA: 0x005D9C0C File Offset: 0x005D7E0C
		public THookInteractConfig Type { get; set; }

		// Token: 0x1700BB55 RID: 47957
		// (get) Token: 0x0602ADA7 RID: 175527 RVA: 0x005D9C15 File Offset: 0x005D7E15
		// (set) Token: 0x0602ADA8 RID: 175528 RVA: 0x005D9C1D File Offset: 0x005D7E1D
		public object Value { get; set; }

		// Token: 0x0602ADA9 RID: 175529 RVA: 0x005D9C26 File Offset: 0x005D7E26
		public THookInteractConfigUnion()
		{
			this.Type = THookInteractConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602ADAA RID: 175530 RVA: 0x005D9C3C File Offset: 0x005D7E3C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602ADAB RID: 175531 RVA: 0x005D9C4E File Offset: 0x005D7E4E
		public ICableWayT AsICableWay()
		{
			return this.As<ICableWayT>();
		}

		// Token: 0x0602ADAC RID: 175532 RVA: 0x005D9C56 File Offset: 0x005D7E56
		public static THookInteractConfigUnion FromICableWay(ICableWayT _icableway)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.ICableWay,
				Value = _icableway
			};
		}

		// Token: 0x0602ADAD RID: 175533 RVA: 0x005D9C6B File Offset: 0x005D7E6B
		public IChargeSlashHookT AsIChargeSlashHook()
		{
			return this.As<IChargeSlashHookT>();
		}

		// Token: 0x0602ADAE RID: 175534 RVA: 0x005D9C73 File Offset: 0x005D7E73
		public static THookInteractConfigUnion FromIChargeSlashHook(IChargeSlashHookT _ichargeslashhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IChargeSlashHook,
				Value = _ichargeslashhook
			};
		}

		// Token: 0x0602ADAF RID: 175535 RVA: 0x005D9C88 File Offset: 0x005D7E88
		public IChongLouHookT AsIChongLouHook()
		{
			return this.As<IChongLouHookT>();
		}

		// Token: 0x0602ADB0 RID: 175536 RVA: 0x005D9C90 File Offset: 0x005D7E90
		public static THookInteractConfigUnion FromIChongLouHook(IChongLouHookT _ichonglouhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IChongLouHook,
				Value = _ichonglouhook
			};
		}

		// Token: 0x0602ADB1 RID: 175537 RVA: 0x005D9CA5 File Offset: 0x005D7EA5
		public IFixedPointHookT AsIFixedPointHook()
		{
			return this.As<IFixedPointHookT>();
		}

		// Token: 0x0602ADB2 RID: 175538 RVA: 0x005D9CAD File Offset: 0x005D7EAD
		public static THookInteractConfigUnion FromIFixedPointHook(IFixedPointHookT _ifixedpointhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IFixedPointHook,
				Value = _ifixedpointhook
			};
		}

		// Token: 0x0602ADB3 RID: 175539 RVA: 0x005D9CC2 File Offset: 0x005D7EC2
		public IFlyingFeatherT AsIFlyingFeather()
		{
			return this.As<IFlyingFeatherT>();
		}

		// Token: 0x0602ADB4 RID: 175540 RVA: 0x005D9CCA File Offset: 0x005D7ECA
		public static THookInteractConfigUnion FromIFlyingFeather(IFlyingFeatherT _iflyingfeather)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IFlyingFeather,
				Value = _iflyingfeather
			};
		}

		// Token: 0x0602ADB5 RID: 175541 RVA: 0x005D9CDF File Offset: 0x005D7EDF
		public IFollowerShootT AsIFollowerShoot()
		{
			return this.As<IFollowerShootT>();
		}

		// Token: 0x0602ADB6 RID: 175542 RVA: 0x005D9CE7 File Offset: 0x005D7EE7
		public static THookInteractConfigUnion FromIFollowerShoot(IFollowerShootT _ifollowershoot)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IFollowerShoot,
				Value = _ifollowershoot
			};
		}

		// Token: 0x0602ADB7 RID: 175543 RVA: 0x005D9CFC File Offset: 0x005D7EFC
		public IFoxJumpingPointT AsIFoxJumpingPoint()
		{
			return this.As<IFoxJumpingPointT>();
		}

		// Token: 0x0602ADB8 RID: 175544 RVA: 0x005D9D04 File Offset: 0x005D7F04
		public static THookInteractConfigUnion FromIFoxJumpingPoint(IFoxJumpingPointT _ifoxjumpingpoint)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IFoxJumpingPoint,
				Value = _ifoxjumpingpoint
			};
		}

		// Token: 0x0602ADB9 RID: 175545 RVA: 0x005D9D19 File Offset: 0x005D7F19
		public IGravityHookT AsIGravityHook()
		{
			return this.As<IGravityHookT>();
		}

		// Token: 0x0602ADBA RID: 175546 RVA: 0x005D9D21 File Offset: 0x005D7F21
		public static THookInteractConfigUnion FromIGravityHook(IGravityHookT _igravityhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IGravityHook,
				Value = _igravityhook
			};
		}

		// Token: 0x0602ADBB RID: 175547 RVA: 0x005D9D36 File Offset: 0x005D7F36
		public IHookSpaceStationEnergyCoreT AsIHookSpaceStationEnergyCore()
		{
			return this.As<IHookSpaceStationEnergyCoreT>();
		}

		// Token: 0x0602ADBC RID: 175548 RVA: 0x005D9D3E File Offset: 0x005D7F3E
		public static THookInteractConfigUnion FromIHookSpaceStationEnergyCore(IHookSpaceStationEnergyCoreT _ihookspacestationenergycore)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IHookSpaceStationEnergyCore,
				Value = _ihookspacestationenergycore
			};
		}

		// Token: 0x0602ADBD RID: 175549 RVA: 0x005D9D54 File Offset: 0x005D7F54
		public IKiteHookT AsIKiteHook()
		{
			return this.As<IKiteHookT>();
		}

		// Token: 0x0602ADBE RID: 175550 RVA: 0x005D9D5C File Offset: 0x005D7F5C
		public static THookInteractConfigUnion FromIKiteHook(IKiteHookT _ikitehook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IKiteHook,
				Value = _ikitehook
			};
		}

		// Token: 0x0602ADBF RID: 175551 RVA: 0x005D9D72 File Offset: 0x005D7F72
		public IMechTransformHookT AsIMechTransformHook()
		{
			return this.As<IMechTransformHookT>();
		}

		// Token: 0x0602ADC0 RID: 175552 RVA: 0x005D9D7A File Offset: 0x005D7F7A
		public static THookInteractConfigUnion FromIMechTransformHook(IMechTransformHookT _imechtransformhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IMechTransformHook,
				Value = _imechtransformhook
			};
		}

		// Token: 0x0602ADC1 RID: 175553 RVA: 0x005D9D90 File Offset: 0x005D7F90
		public IMotorEjectHookT AsIMotorEjectHook()
		{
			return this.As<IMotorEjectHookT>();
		}

		// Token: 0x0602ADC2 RID: 175554 RVA: 0x005D9D98 File Offset: 0x005D7F98
		public static THookInteractConfigUnion FromIMotorEjectHook(IMotorEjectHookT _imotorejecthook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IMotorEjectHook,
				Value = _imotorejecthook
			};
		}

		// Token: 0x0602ADC3 RID: 175555 RVA: 0x005D9DAE File Offset: 0x005D7FAE
		public IMotorPullInteractT AsIMotorPullInteract()
		{
			return this.As<IMotorPullInteractT>();
		}

		// Token: 0x0602ADC4 RID: 175556 RVA: 0x005D9DB6 File Offset: 0x005D7FB6
		public static THookInteractConfigUnion FromIMotorPullInteract(IMotorPullInteractT _imotorpullinteract)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IMotorPullInteract,
				Value = _imotorpullinteract
			};
		}

		// Token: 0x0602ADC5 RID: 175557 RVA: 0x005D9DCC File Offset: 0x005D7FCC
		public IMovementPointHookT AsIMovementPointHook()
		{
			return this.As<IMovementPointHookT>();
		}

		// Token: 0x0602ADC6 RID: 175558 RVA: 0x005D9DD4 File Offset: 0x005D7FD4
		public static THookInteractConfigUnion FromIMovementPointHook(IMovementPointHookT _imovementpointhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IMovementPointHook,
				Value = _imovementpointhook
			};
		}

		// Token: 0x0602ADC7 RID: 175559 RVA: 0x005D9DEA File Offset: 0x005D7FEA
		public IPilotThrowT AsIPilotThrow()
		{
			return this.As<IPilotThrowT>();
		}

		// Token: 0x0602ADC8 RID: 175560 RVA: 0x005D9DF2 File Offset: 0x005D7FF2
		public static THookInteractConfigUnion FromIPilotThrow(IPilotThrowT _ipilotthrow)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IPilotThrow,
				Value = _ipilotthrow
			};
		}

		// Token: 0x0602ADC9 RID: 175561 RVA: 0x005D9E08 File Offset: 0x005D8008
		public IRagDollClimbingPointT AsIRagDollClimbingPoint()
		{
			return this.As<IRagDollClimbingPointT>();
		}

		// Token: 0x0602ADCA RID: 175562 RVA: 0x005D9E10 File Offset: 0x005D8010
		public static THookInteractConfigUnion FromIRagDollClimbingPoint(IRagDollClimbingPointT _iragdollclimbingpoint)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IRagDollClimbingPoint,
				Value = _iragdollclimbingpoint
			};
		}

		// Token: 0x0602ADCB RID: 175563 RVA: 0x005D9E26 File Offset: 0x005D8026
		public IRagDollJumpingPointT AsIRagDollJumpingPoint()
		{
			return this.As<IRagDollJumpingPointT>();
		}

		// Token: 0x0602ADCC RID: 175564 RVA: 0x005D9E2E File Offset: 0x005D802E
		public static THookInteractConfigUnion FromIRagDollJumpingPoint(IRagDollJumpingPointT _iragdolljumpingpoint)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IRagDollJumpingPoint,
				Value = _iragdolljumpingpoint
			};
		}

		// Token: 0x0602ADCD RID: 175565 RVA: 0x005D9E44 File Offset: 0x005D8044
		public ISlashHookT AsISlashHook()
		{
			return this.As<ISlashHookT>();
		}

		// Token: 0x0602ADCE RID: 175566 RVA: 0x005D9E4C File Offset: 0x005D804C
		public static THookInteractConfigUnion FromISlashHook(ISlashHookT _islashhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.ISlashHook,
				Value = _islashhook
			};
		}

		// Token: 0x0602ADCF RID: 175567 RVA: 0x005D9E62 File Offset: 0x005D8062
		public ISuiGuangHookT AsISuiGuangHook()
		{
			return this.As<ISuiGuangHookT>();
		}

		// Token: 0x0602ADD0 RID: 175568 RVA: 0x005D9E6A File Offset: 0x005D806A
		public static THookInteractConfigUnion FromISuiGuangHook(ISuiGuangHookT _isuiguanghook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.ISuiGuangHook,
				Value = _isuiguanghook
			};
		}

		// Token: 0x0602ADD1 RID: 175569 RVA: 0x005D9E80 File Offset: 0x005D8080
		public ISunSpiritLauncherT AsISunSpiritLauncher()
		{
			return this.As<ISunSpiritLauncherT>();
		}

		// Token: 0x0602ADD2 RID: 175570 RVA: 0x005D9E88 File Offset: 0x005D8088
		public static THookInteractConfigUnion FromISunSpiritLauncher(ISunSpiritLauncherT _isunspiritlauncher)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.ISunSpiritLauncher,
				Value = _isunspiritlauncher
			};
		}

		// Token: 0x0602ADD3 RID: 175571 RVA: 0x005D9E9E File Offset: 0x005D809E
		public IWaterBoxBigWeaponHookT AsIWaterBoxBigWeaponHook()
		{
			return this.As<IWaterBoxBigWeaponHookT>();
		}

		// Token: 0x0602ADD4 RID: 175572 RVA: 0x005D9EA6 File Offset: 0x005D80A6
		public static THookInteractConfigUnion FromIWaterBoxBigWeaponHook(IWaterBoxBigWeaponHookT _iwaterboxbigweaponhook)
		{
			return new THookInteractConfigUnion
			{
				Type = THookInteractConfig.IWaterBoxBigWeaponHook,
				Value = _iwaterboxbigweaponhook
			};
		}

		// Token: 0x0602ADD5 RID: 175573 RVA: 0x005D9EBC File Offset: 0x005D80BC
		public static int Pack(FlatBufferBuilder builder, THookInteractConfigUnion _o)
		{
			switch (_o.Type)
			{
			case THookInteractConfig.ICableWay:
				return ICableWay.Pack(builder, _o.AsICableWay()).Value;
			case THookInteractConfig.IChargeSlashHook:
				return IChargeSlashHook.Pack(builder, _o.AsIChargeSlashHook()).Value;
			case THookInteractConfig.IChongLouHook:
				return IChongLouHook.Pack(builder, _o.AsIChongLouHook()).Value;
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
			case THookInteractConfig.IMechTransformHook:
				return IMechTransformHook.Pack(builder, _o.AsIMechTransformHook()).Value;
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
