using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200594C RID: 22860
	public class IHookInteractType_UnionUnion
	{
		// Token: 0x1700A5DF RID: 42463
		// (get) Token: 0x06025330 RID: 152368 RVA: 0x0051AD4D File Offset: 0x00518F4D
		// (set) Token: 0x06025331 RID: 152369 RVA: 0x0051AD55 File Offset: 0x00518F55
		public IHookInteractType_Union Type { get; set; }

		// Token: 0x1700A5E0 RID: 42464
		// (get) Token: 0x06025332 RID: 152370 RVA: 0x0051AD5E File Offset: 0x00518F5E
		// (set) Token: 0x06025333 RID: 152371 RVA: 0x0051AD66 File Offset: 0x00518F66
		public object Value { get; set; }

		// Token: 0x06025334 RID: 152372 RVA: 0x0051AD6F File Offset: 0x00518F6F
		public IHookInteractType_UnionUnion()
		{
			this.Type = IHookInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025335 RID: 152373 RVA: 0x0051AD85 File Offset: 0x00518F85
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025336 RID: 152374 RVA: 0x0051AD97 File Offset: 0x00518F97
		public IHookInteractTypeT AsIHookInteractType()
		{
			return this.As<IHookInteractTypeT>();
		}

		// Token: 0x06025337 RID: 152375 RVA: 0x0051AD9F File Offset: 0x00518F9F
		public static IHookInteractType_UnionUnion FromIHookInteractType(IHookInteractTypeT _ihookinteracttype)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IHookInteractType,
				Value = _ihookinteracttype
			};
		}

		// Token: 0x06025338 RID: 152376 RVA: 0x0051ADB4 File Offset: 0x00518FB4
		public IFixedPointHookT AsIFixedPointHook()
		{
			return this.As<IFixedPointHookT>();
		}

		// Token: 0x06025339 RID: 152377 RVA: 0x0051ADBC File Offset: 0x00518FBC
		public static IHookInteractType_UnionUnion FromIFixedPointHook(IFixedPointHookT _ifixedpointhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IFixedPointHook,
				Value = _ifixedpointhook
			};
		}

		// Token: 0x0602533A RID: 152378 RVA: 0x0051ADD1 File Offset: 0x00518FD1
		public IMovementPointHookT AsIMovementPointHook()
		{
			return this.As<IMovementPointHookT>();
		}

		// Token: 0x0602533B RID: 152379 RVA: 0x0051ADD9 File Offset: 0x00518FD9
		public static IHookInteractType_UnionUnion FromIMovementPointHook(IMovementPointHookT _imovementpointhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IMovementPointHook,
				Value = _imovementpointhook
			};
		}

		// Token: 0x0602533C RID: 152380 RVA: 0x0051ADEE File Offset: 0x00518FEE
		public ISuiGuangHookT AsISuiGuangHook()
		{
			return this.As<ISuiGuangHookT>();
		}

		// Token: 0x0602533D RID: 152381 RVA: 0x0051ADF6 File Offset: 0x00518FF6
		public static IHookInteractType_UnionUnion FromISuiGuangHook(ISuiGuangHookT _isuiguanghook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.ISuiGuangHook,
				Value = _isuiguanghook
			};
		}

		// Token: 0x0602533E RID: 152382 RVA: 0x0051AE0B File Offset: 0x0051900B
		public IWaterBoxBigWeaponHookT AsIWaterBoxBigWeaponHook()
		{
			return this.As<IWaterBoxBigWeaponHookT>();
		}

		// Token: 0x0602533F RID: 152383 RVA: 0x0051AE13 File Offset: 0x00519013
		public static IHookInteractType_UnionUnion FromIWaterBoxBigWeaponHook(IWaterBoxBigWeaponHookT _iwaterboxbigweaponhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IWaterBoxBigWeaponHook,
				Value = _iwaterboxbigweaponhook
			};
		}

		// Token: 0x06025340 RID: 152384 RVA: 0x0051AE28 File Offset: 0x00519028
		public IMechTransformHookT AsIMechTransformHook()
		{
			return this.As<IMechTransformHookT>();
		}

		// Token: 0x06025341 RID: 152385 RVA: 0x0051AE30 File Offset: 0x00519030
		public static IHookInteractType_UnionUnion FromIMechTransformHook(IMechTransformHookT _imechtransformhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IMechTransformHook,
				Value = _imechtransformhook
			};
		}

		// Token: 0x06025342 RID: 152386 RVA: 0x0051AE45 File Offset: 0x00519045
		public IKiteHookT AsIKiteHook()
		{
			return this.As<IKiteHookT>();
		}

		// Token: 0x06025343 RID: 152387 RVA: 0x0051AE4D File Offset: 0x0051904D
		public static IHookInteractType_UnionUnion FromIKiteHook(IKiteHookT _ikitehook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IKiteHook,
				Value = _ikitehook
			};
		}

		// Token: 0x06025344 RID: 152388 RVA: 0x0051AE62 File Offset: 0x00519062
		public IRagDollJumpingPointT AsIRagDollJumpingPoint()
		{
			return this.As<IRagDollJumpingPointT>();
		}

		// Token: 0x06025345 RID: 152389 RVA: 0x0051AE6A File Offset: 0x0051906A
		public static IHookInteractType_UnionUnion FromIRagDollJumpingPoint(IRagDollJumpingPointT _iragdolljumpingpoint)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IRagDollJumpingPoint,
				Value = _iragdolljumpingpoint
			};
		}

		// Token: 0x06025346 RID: 152390 RVA: 0x0051AE7F File Offset: 0x0051907F
		public IRagDollClimbingPointT AsIRagDollClimbingPoint()
		{
			return this.As<IRagDollClimbingPointT>();
		}

		// Token: 0x06025347 RID: 152391 RVA: 0x0051AE87 File Offset: 0x00519087
		public static IHookInteractType_UnionUnion FromIRagDollClimbingPoint(IRagDollClimbingPointT _iragdollclimbingpoint)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IRagDollClimbingPoint,
				Value = _iragdollclimbingpoint
			};
		}

		// Token: 0x06025348 RID: 152392 RVA: 0x0051AE9D File Offset: 0x0051909D
		public IFoxJumpingPointT AsIFoxJumpingPoint()
		{
			return this.As<IFoxJumpingPointT>();
		}

		// Token: 0x06025349 RID: 152393 RVA: 0x0051AEA5 File Offset: 0x005190A5
		public static IHookInteractType_UnionUnion FromIFoxJumpingPoint(IFoxJumpingPointT _ifoxjumpingpoint)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IFoxJumpingPoint,
				Value = _ifoxjumpingpoint
			};
		}

		// Token: 0x0602534A RID: 152394 RVA: 0x0051AEBB File Offset: 0x005190BB
		public ISlashHookT AsISlashHook()
		{
			return this.As<ISlashHookT>();
		}

		// Token: 0x0602534B RID: 152395 RVA: 0x0051AEC3 File Offset: 0x005190C3
		public static IHookInteractType_UnionUnion FromISlashHook(ISlashHookT _islashhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.ISlashHook,
				Value = _islashhook
			};
		}

		// Token: 0x0602534C RID: 152396 RVA: 0x0051AED9 File Offset: 0x005190D9
		public IChargeSlashHookT AsIChargeSlashHook()
		{
			return this.As<IChargeSlashHookT>();
		}

		// Token: 0x0602534D RID: 152397 RVA: 0x0051AEE1 File Offset: 0x005190E1
		public static IHookInteractType_UnionUnion FromIChargeSlashHook(IChargeSlashHookT _ichargeslashhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IChargeSlashHook,
				Value = _ichargeslashhook
			};
		}

		// Token: 0x0602534E RID: 152398 RVA: 0x0051AEF7 File Offset: 0x005190F7
		public IGravityHookT AsIGravityHook()
		{
			return this.As<IGravityHookT>();
		}

		// Token: 0x0602534F RID: 152399 RVA: 0x0051AEFF File Offset: 0x005190FF
		public static IHookInteractType_UnionUnion FromIGravityHook(IGravityHookT _igravityhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IGravityHook,
				Value = _igravityhook
			};
		}

		// Token: 0x06025350 RID: 152400 RVA: 0x0051AF15 File Offset: 0x00519115
		public IFlyingFeatherT AsIFlyingFeather()
		{
			return this.As<IFlyingFeatherT>();
		}

		// Token: 0x06025351 RID: 152401 RVA: 0x0051AF1D File Offset: 0x0051911D
		public static IHookInteractType_UnionUnion FromIFlyingFeather(IFlyingFeatherT _iflyingfeather)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IFlyingFeather,
				Value = _iflyingfeather
			};
		}

		// Token: 0x06025352 RID: 152402 RVA: 0x0051AF33 File Offset: 0x00519133
		public IPilotThrowT AsIPilotThrow()
		{
			return this.As<IPilotThrowT>();
		}

		// Token: 0x06025353 RID: 152403 RVA: 0x0051AF3B File Offset: 0x0051913B
		public static IHookInteractType_UnionUnion FromIPilotThrow(IPilotThrowT _ipilotthrow)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IPilotThrow,
				Value = _ipilotthrow
			};
		}

		// Token: 0x06025354 RID: 152404 RVA: 0x0051AF51 File Offset: 0x00519151
		public ISunSpiritLauncherT AsISunSpiritLauncher()
		{
			return this.As<ISunSpiritLauncherT>();
		}

		// Token: 0x06025355 RID: 152405 RVA: 0x0051AF59 File Offset: 0x00519159
		public static IHookInteractType_UnionUnion FromISunSpiritLauncher(ISunSpiritLauncherT _isunspiritlauncher)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.ISunSpiritLauncher,
				Value = _isunspiritlauncher
			};
		}

		// Token: 0x06025356 RID: 152406 RVA: 0x0051AF6F File Offset: 0x0051916F
		public ICableWayT AsICableWay()
		{
			return this.As<ICableWayT>();
		}

		// Token: 0x06025357 RID: 152407 RVA: 0x0051AF77 File Offset: 0x00519177
		public static IHookInteractType_UnionUnion FromICableWay(ICableWayT _icableway)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.ICableWay,
				Value = _icableway
			};
		}

		// Token: 0x06025358 RID: 152408 RVA: 0x0051AF8D File Offset: 0x0051918D
		public IFollowerShootT AsIFollowerShoot()
		{
			return this.As<IFollowerShootT>();
		}

		// Token: 0x06025359 RID: 152409 RVA: 0x0051AF95 File Offset: 0x00519195
		public static IHookInteractType_UnionUnion FromIFollowerShoot(IFollowerShootT _ifollowershoot)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IFollowerShoot,
				Value = _ifollowershoot
			};
		}

		// Token: 0x0602535A RID: 152410 RVA: 0x0051AFAB File Offset: 0x005191AB
		public IMotorPullInteractT AsIMotorPullInteract()
		{
			return this.As<IMotorPullInteractT>();
		}

		// Token: 0x0602535B RID: 152411 RVA: 0x0051AFB3 File Offset: 0x005191B3
		public static IHookInteractType_UnionUnion FromIMotorPullInteract(IMotorPullInteractT _imotorpullinteract)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IMotorPullInteract,
				Value = _imotorpullinteract
			};
		}

		// Token: 0x0602535C RID: 152412 RVA: 0x0051AFC9 File Offset: 0x005191C9
		public IHookSpaceStationEnergyCoreT AsIHookSpaceStationEnergyCore()
		{
			return this.As<IHookSpaceStationEnergyCoreT>();
		}

		// Token: 0x0602535D RID: 152413 RVA: 0x0051AFD1 File Offset: 0x005191D1
		public static IHookInteractType_UnionUnion FromIHookSpaceStationEnergyCore(IHookSpaceStationEnergyCoreT _ihookspacestationenergycore)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IHookSpaceStationEnergyCore,
				Value = _ihookspacestationenergycore
			};
		}

		// Token: 0x0602535E RID: 152414 RVA: 0x0051AFE7 File Offset: 0x005191E7
		public IMotorEjectHookT AsIMotorEjectHook()
		{
			return this.As<IMotorEjectHookT>();
		}

		// Token: 0x0602535F RID: 152415 RVA: 0x0051AFEF File Offset: 0x005191EF
		public static IHookInteractType_UnionUnion FromIMotorEjectHook(IMotorEjectHookT _imotorejecthook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IMotorEjectHook,
				Value = _imotorejecthook
			};
		}

		// Token: 0x06025360 RID: 152416 RVA: 0x0051B005 File Offset: 0x00519205
		public IChongLouHookT AsIChongLouHook()
		{
			return this.As<IChongLouHookT>();
		}

		// Token: 0x06025361 RID: 152417 RVA: 0x0051B00D File Offset: 0x0051920D
		public static IHookInteractType_UnionUnion FromIChongLouHook(IChongLouHookT _ichonglouhook)
		{
			return new IHookInteractType_UnionUnion
			{
				Type = IHookInteractType_Union.IChongLouHook,
				Value = _ichonglouhook
			};
		}

		// Token: 0x06025362 RID: 152418 RVA: 0x0051B024 File Offset: 0x00519224
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
			case IHookInteractType_Union.IMechTransformHook:
				return IMechTransformHook.Pack(builder, _o.AsIMechTransformHook()).Value;
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
			case IHookInteractType_Union.IHookSpaceStationEnergyCore:
				return IHookSpaceStationEnergyCore.Pack(builder, _o.AsIHookSpaceStationEnergyCore()).Value;
			case IHookInteractType_Union.IMotorEjectHook:
				return IMotorEjectHook.Pack(builder, _o.AsIMotorEjectHook()).Value;
			case IHookInteractType_Union.IChongLouHook:
				return IChongLouHook.Pack(builder, _o.AsIChongLouHook()).Value;
			default:
				return 0;
			}
		}
	}
}
