using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B43 RID: 31555
	public class ITargetVehicle_UnionUnion
	{
		// Token: 0x1700EC53 RID: 60499
		// (get) Token: 0x06038D31 RID: 232753 RVA: 0x007AF24D File Offset: 0x007AD44D
		// (set) Token: 0x06038D32 RID: 232754 RVA: 0x007AF255 File Offset: 0x007AD455
		public ITargetVehicle_Union Type { get; set; }

		// Token: 0x1700EC54 RID: 60500
		// (get) Token: 0x06038D33 RID: 232755 RVA: 0x007AF25E File Offset: 0x007AD45E
		// (set) Token: 0x06038D34 RID: 232756 RVA: 0x007AF266 File Offset: 0x007AD466
		public object Value { get; set; }

		// Token: 0x06038D35 RID: 232757 RVA: 0x007AF26F File Offset: 0x007AD46F
		public ITargetVehicle_UnionUnion()
		{
			this.Type = ITargetVehicle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038D36 RID: 232758 RVA: 0x007AF285 File Offset: 0x007AD485
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038D37 RID: 232759 RVA: 0x007AF297 File Offset: 0x007AD497
		public ITargetVehicleT AsITargetVehicle()
		{
			return this.As<ITargetVehicleT>();
		}

		// Token: 0x06038D38 RID: 232760 RVA: 0x007AF29F File Offset: 0x007AD49F
		public static ITargetVehicle_UnionUnion FromITargetVehicle(ITargetVehicleT _itargetvehicle)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.ITargetVehicle,
				Value = _itargetvehicle
			};
		}

		// Token: 0x06038D39 RID: 232761 RVA: 0x007AF2B4 File Offset: 0x007AD4B4
		public ICurrentVehicleT AsICurrentVehicle()
		{
			return this.As<ICurrentVehicleT>();
		}

		// Token: 0x06038D3A RID: 232762 RVA: 0x007AF2BC File Offset: 0x007AD4BC
		public static ITargetVehicle_UnionUnion FromICurrentVehicle(ICurrentVehicleT _icurrentvehicle)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.ICurrentVehicle,
				Value = _icurrentvehicle
			};
		}

		// Token: 0x06038D3B RID: 232763 RVA: 0x007AF2D1 File Offset: 0x007AD4D1
		public ISelfVehicleT AsISelfVehicle()
		{
			return this.As<ISelfVehicleT>();
		}

		// Token: 0x06038D3C RID: 232764 RVA: 0x007AF2D9 File Offset: 0x007AD4D9
		public static ITargetVehicle_UnionUnion FromISelfVehicle(ISelfVehicleT _iselfvehicle)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.ISelfVehicle,
				Value = _iselfvehicle
			};
		}

		// Token: 0x06038D3D RID: 232765 RVA: 0x007AF2EE File Offset: 0x007AD4EE
		public IAppointedVehicleT AsIAppointedVehicle()
		{
			return this.As<IAppointedVehicleT>();
		}

		// Token: 0x06038D3E RID: 232766 RVA: 0x007AF2F6 File Offset: 0x007AD4F6
		public static ITargetVehicle_UnionUnion FromIAppointedVehicle(IAppointedVehicleT _iappointedvehicle)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.IAppointedVehicle,
				Value = _iappointedvehicle
			};
		}

		// Token: 0x06038D3F RID: 232767 RVA: 0x007AF30B File Offset: 0x007AD50B
		public ITriggeredVehicleT AsITriggeredVehicle()
		{
			return this.As<ITriggeredVehicleT>();
		}

		// Token: 0x06038D40 RID: 232768 RVA: 0x007AF313 File Offset: 0x007AD513
		public static ITargetVehicle_UnionUnion FromITriggeredVehicle(ITriggeredVehicleT _itriggeredvehicle)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.ITriggeredVehicle,
				Value = _itriggeredvehicle
			};
		}

		// Token: 0x06038D41 RID: 232769 RVA: 0x007AF328 File Offset: 0x007AD528
		public IFishingBoatVehicleT AsIFishingBoatVehicle()
		{
			return this.As<IFishingBoatVehicleT>();
		}

		// Token: 0x06038D42 RID: 232770 RVA: 0x007AF330 File Offset: 0x007AD530
		public static ITargetVehicle_UnionUnion FromIFishingBoatVehicle(IFishingBoatVehicleT _ifishingboatvehicle)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.IFishingBoatVehicle,
				Value = _ifishingboatvehicle
			};
		}

		// Token: 0x06038D43 RID: 232771 RVA: 0x007AF345 File Offset: 0x007AD545
		public IVehicleTeamT AsIVehicleTeam()
		{
			return this.As<IVehicleTeamT>();
		}

		// Token: 0x06038D44 RID: 232772 RVA: 0x007AF34D File Offset: 0x007AD54D
		public static ITargetVehicle_UnionUnion FromIVehicleTeam(IVehicleTeamT _ivehicleteam)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.IVehicleTeam,
				Value = _ivehicleteam
			};
		}

		// Token: 0x06038D45 RID: 232773 RVA: 0x007AF362 File Offset: 0x007AD562
		public IVehiclePlayerMotorT AsIVehiclePlayerMotor()
		{
			return this.As<IVehiclePlayerMotorT>();
		}

		// Token: 0x06038D46 RID: 232774 RVA: 0x007AF36A File Offset: 0x007AD56A
		public static ITargetVehicle_UnionUnion FromIVehiclePlayerMotor(IVehiclePlayerMotorT _ivehicleplayermotor)
		{
			return new ITargetVehicle_UnionUnion
			{
				Type = ITargetVehicle_Union.IVehiclePlayerMotor,
				Value = _ivehicleplayermotor
			};
		}

		// Token: 0x06038D47 RID: 232775 RVA: 0x007AF380 File Offset: 0x007AD580
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
