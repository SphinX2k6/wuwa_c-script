using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007368 RID: 29544
	public class ITargetVehicle_UnionUnion
	{
		// Token: 0x1700E052 RID: 57426
		// (get) Token: 0x060359E8 RID: 219624 RVA: 0x0074D479 File Offset: 0x0074B679
		// (set) Token: 0x060359E9 RID: 219625 RVA: 0x0074D481 File Offset: 0x0074B681
		public ITargetVehicle_Union Type { get; set; }

		// Token: 0x1700E053 RID: 57427
		// (get) Token: 0x060359EA RID: 219626 RVA: 0x0074D48A File Offset: 0x0074B68A
		// (set) Token: 0x060359EB RID: 219627 RVA: 0x0074D492 File Offset: 0x0074B692
		public object Value { get; set; }

		// Token: 0x060359EC RID: 219628 RVA: 0x0074D49B File Offset: 0x0074B69B
		public ITargetVehicle_UnionUnion()
		{
			this.Type = ITargetVehicle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060359ED RID: 219629 RVA: 0x0074D4B1 File Offset: 0x0074B6B1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060359EE RID: 219630 RVA: 0x0074D4C3 File Offset: 0x0074B6C3
		public ITargetVehicleT AsITargetVehicle()
		{
			return this.As<ITargetVehicleT>();
		}

		// Token: 0x060359EF RID: 219631 RVA: 0x0074D4CB File Offset: 0x0074B6CB
		public static ITargetVehicle_UnionUnion FromITargetVehicle(ITargetVehicleT _itargetvehicle)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.ITargetVehicle,
				Value = _itargetvehicle
			};
		}

		// Token: 0x060359F0 RID: 219632 RVA: 0x0074D4E0 File Offset: 0x0074B6E0
		public ICurrentVehicleT AsICurrentVehicle()
		{
			return this.As<ICurrentVehicleT>();
		}

		// Token: 0x060359F1 RID: 219633 RVA: 0x0074D4E8 File Offset: 0x0074B6E8
		public static ITargetVehicle_UnionUnion FromICurrentVehicle(ICurrentVehicleT _icurrentvehicle)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.ICurrentVehicle,
				Value = _icurrentvehicle
			};
		}

		// Token: 0x060359F2 RID: 219634 RVA: 0x0074D4FD File Offset: 0x0074B6FD
		public ISelfVehicleT AsISelfVehicle()
		{
			return this.As<ISelfVehicleT>();
		}

		// Token: 0x060359F3 RID: 219635 RVA: 0x0074D505 File Offset: 0x0074B705
		public static ITargetVehicle_UnionUnion FromISelfVehicle(ISelfVehicleT _iselfvehicle)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.ISelfVehicle,
				Value = _iselfvehicle
			};
		}

		// Token: 0x060359F4 RID: 219636 RVA: 0x0074D51A File Offset: 0x0074B71A
		public IAppointedVehicleT AsIAppointedVehicle()
		{
			return this.As<IAppointedVehicleT>();
		}

		// Token: 0x060359F5 RID: 219637 RVA: 0x0074D522 File Offset: 0x0074B722
		public static ITargetVehicle_UnionUnion FromIAppointedVehicle(IAppointedVehicleT _iappointedvehicle)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.IAppointedVehicle,
				Value = _iappointedvehicle
			};
		}

		// Token: 0x060359F6 RID: 219638 RVA: 0x0074D537 File Offset: 0x0074B737
		public ITriggeredVehicleT AsITriggeredVehicle()
		{
			return this.As<ITriggeredVehicleT>();
		}

		// Token: 0x060359F7 RID: 219639 RVA: 0x0074D53F File Offset: 0x0074B73F
		public static ITargetVehicle_UnionUnion FromITriggeredVehicle(ITriggeredVehicleT _itriggeredvehicle)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.ITriggeredVehicle,
				Value = _itriggeredvehicle
			};
		}

		// Token: 0x060359F8 RID: 219640 RVA: 0x0074D554 File Offset: 0x0074B754
		public IFishingBoatVehicleT AsIFishingBoatVehicle()
		{
			return this.As<IFishingBoatVehicleT>();
		}

		// Token: 0x060359F9 RID: 219641 RVA: 0x0074D55C File Offset: 0x0074B75C
		public static ITargetVehicle_UnionUnion FromIFishingBoatVehicle(IFishingBoatVehicleT _ifishingboatvehicle)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.IFishingBoatVehicle,
				Value = _ifishingboatvehicle
			};
		}

		// Token: 0x060359FA RID: 219642 RVA: 0x0074D571 File Offset: 0x0074B771
		public IVehicleTeamT AsIVehicleTeam()
		{
			return this.As<IVehicleTeamT>();
		}

		// Token: 0x060359FB RID: 219643 RVA: 0x0074D579 File Offset: 0x0074B779
		public static ITargetVehicle_UnionUnion FromIVehicleTeam(IVehicleTeamT _ivehicleteam)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.IVehicleTeam,
				Value = _ivehicleteam
			};
		}

		// Token: 0x060359FC RID: 219644 RVA: 0x0074D58E File Offset: 0x0074B78E
		public IVehiclePlayerMotorT AsIVehiclePlayerMotor()
		{
			return this.As<IVehiclePlayerMotorT>();
		}

		// Token: 0x060359FD RID: 219645 RVA: 0x0074D596 File Offset: 0x0074B796
		public static ITargetVehicle_UnionUnion FromIVehiclePlayerMotor(IVehiclePlayerMotorT _ivehicleplayermotor)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.IVehiclePlayerMotor,
				Value = _ivehicleplayermotor
			};
		}

		// Token: 0x060359FE RID: 219646 RVA: 0x0074D5AC File Offset: 0x0074B7AC
		public static int Pack(FlatBufferBuilder builder, ITargetVehicle_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITargetVehicle_Union.ITargetVehicle:
				return ITargetVehicle.Pack(builder, _o.AsITargetVehicle()).Value;
			case ITargetVehicle_Union.ICurrentVehicle:
				return ICurrentVehicle.Pack(builder, _o.AsICurrentVehicle()).Value;
			case ITargetVehicle_Union.ISelfVehicle:
				return ISelfVehicle.Pack(builder, _o.AsISelfVehicle()).Value;
			case ITargetVehicle_Union.IAppointedVehicle:
				return IAppointedVehicle.Pack(builder, _o.AsIAppointedVehicle()).Value;
			case ITargetVehicle_Union.ITriggeredVehicle:
				return ITriggeredVehicle.Pack(builder, _o.AsITriggeredVehicle()).Value;
			case ITargetVehicle_Union.IFishingBoatVehicle:
				return IFishingBoatVehicle.Pack(builder, _o.AsIFishingBoatVehicle()).Value;
			case ITargetVehicle_Union.IVehicleTeam:
				return IVehicleTeam.Pack(builder, _o.AsIVehicleTeam()).Value;
			case ITargetVehicle_Union.IVehiclePlayerMotor:
				return IVehiclePlayerMotor.Pack(builder, _o.AsIVehiclePlayerMotor()).Value;
			default:
				return 0;
			}
		}
	}
}
