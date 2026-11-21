using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200800A RID: 32778
	public class TTargetVehicleUnion
	{
		// Token: 0x1700F329 RID: 62249
		// (get) Token: 0x0603AFC3 RID: 241603 RVA: 0x007EBC2C File Offset: 0x007E9E2C
		// (set) Token: 0x0603AFC4 RID: 241604 RVA: 0x007EBC34 File Offset: 0x007E9E34
		public TTargetVehicle Type { get; set; }

		// Token: 0x1700F32A RID: 62250
		// (get) Token: 0x0603AFC5 RID: 241605 RVA: 0x007EBC3D File Offset: 0x007E9E3D
		// (set) Token: 0x0603AFC6 RID: 241606 RVA: 0x007EBC45 File Offset: 0x007E9E45
		public object Value { get; set; }

		// Token: 0x0603AFC7 RID: 241607 RVA: 0x007EBC4E File Offset: 0x007E9E4E
		public TTargetVehicleUnion()
		{
			this.Type = TTargetVehicle.NONE;
			this.Value = null;
		}

		// Token: 0x0603AFC8 RID: 241608 RVA: 0x007EBC64 File Offset: 0x007E9E64
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AFC9 RID: 241609 RVA: 0x007EBC76 File Offset: 0x007E9E76
		public IAppointedVehicleT AsIAppointedVehicle()
		{
			return this.As<IAppointedVehicleT>();
		}

		// Token: 0x0603AFCA RID: 241610 RVA: 0x007EBC7E File Offset: 0x007E9E7E
		public static TTargetVehicleUnion FromIAppointedVehicle(IAppointedVehicleT _iappointedvehicle)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.IAppointedVehicle,
				Value = _iappointedvehicle
			};
		}

		// Token: 0x0603AFCB RID: 241611 RVA: 0x007EBC93 File Offset: 0x007E9E93
		public ICurrentVehicleT AsICurrentVehicle()
		{
			return this.As<ICurrentVehicleT>();
		}

		// Token: 0x0603AFCC RID: 241612 RVA: 0x007EBC9B File Offset: 0x007E9E9B
		public static TTargetVehicleUnion FromICurrentVehicle(ICurrentVehicleT _icurrentvehicle)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.ICurrentVehicle,
				Value = _icurrentvehicle
			};
		}

		// Token: 0x0603AFCD RID: 241613 RVA: 0x007EBCB0 File Offset: 0x007E9EB0
		public IFishingBoatVehicleT AsIFishingBoatVehicle()
		{
			return this.As<IFishingBoatVehicleT>();
		}

		// Token: 0x0603AFCE RID: 241614 RVA: 0x007EBCB8 File Offset: 0x007E9EB8
		public static TTargetVehicleUnion FromIFishingBoatVehicle(IFishingBoatVehicleT _ifishingboatvehicle)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.IFishingBoatVehicle,
				Value = _ifishingboatvehicle
			};
		}

		// Token: 0x0603AFCF RID: 241615 RVA: 0x007EBCCD File Offset: 0x007E9ECD
		public ISelfVehicleT AsISelfVehicle()
		{
			return this.As<ISelfVehicleT>();
		}

		// Token: 0x0603AFD0 RID: 241616 RVA: 0x007EBCD5 File Offset: 0x007E9ED5
		public static TTargetVehicleUnion FromISelfVehicle(ISelfVehicleT _iselfvehicle)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.ISelfVehicle,
				Value = _iselfvehicle
			};
		}

		// Token: 0x0603AFD1 RID: 241617 RVA: 0x007EBCEA File Offset: 0x007E9EEA
		public ITriggeredVehicleT AsITriggeredVehicle()
		{
			return this.As<ITriggeredVehicleT>();
		}

		// Token: 0x0603AFD2 RID: 241618 RVA: 0x007EBCF2 File Offset: 0x007E9EF2
		public static TTargetVehicleUnion FromITriggeredVehicle(ITriggeredVehicleT _itriggeredvehicle)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.ITriggeredVehicle,
				Value = _itriggeredvehicle
			};
		}

		// Token: 0x0603AFD3 RID: 241619 RVA: 0x007EBD07 File Offset: 0x007E9F07
		public IVehiclePlayerMotorT AsIVehiclePlayerMotor()
		{
			return this.As<IVehiclePlayerMotorT>();
		}

		// Token: 0x0603AFD4 RID: 241620 RVA: 0x007EBD0F File Offset: 0x007E9F0F
		public static TTargetVehicleUnion FromIVehiclePlayerMotor(IVehiclePlayerMotorT _ivehicleplayermotor)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.IVehiclePlayerMotor,
				Value = _ivehicleplayermotor
			};
		}

		// Token: 0x0603AFD5 RID: 241621 RVA: 0x007EBD24 File Offset: 0x007E9F24
		public IVehicleTeamT AsIVehicleTeam()
		{
			return this.As<IVehicleTeamT>();
		}

		// Token: 0x0603AFD6 RID: 241622 RVA: 0x007EBD2C File Offset: 0x007E9F2C
		public static TTargetVehicleUnion FromIVehicleTeam(IVehicleTeamT _ivehicleteam)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.IVehicleTeam,
				Value = _ivehicleteam
			};
		}

		// Token: 0x0603AFD7 RID: 241623 RVA: 0x007EBD44 File Offset: 0x007E9F44
		public static int Pack(FlatBufferBuilder builder, TTargetVehicleUnion _o)
		{
			switch (_o.Type)
			{
			case TTargetVehicle.IAppointedVehicle:
				return IAppointedVehicle.Pack(builder, _o.AsIAppointedVehicle()).Value;
			case TTargetVehicle.ICurrentVehicle:
				return ICurrentVehicle.Pack(builder, _o.AsICurrentVehicle()).Value;
			case TTargetVehicle.IFishingBoatVehicle:
				return IFishingBoatVehicle.Pack(builder, _o.AsIFishingBoatVehicle()).Value;
			case TTargetVehicle.ISelfVehicle:
				return ISelfVehicle.Pack(builder, _o.AsISelfVehicle()).Value;
			case TTargetVehicle.ITriggeredVehicle:
				return ITriggeredVehicle.Pack(builder, _o.AsITriggeredVehicle()).Value;
			case TTargetVehicle.IVehiclePlayerMotor:
				return IVehiclePlayerMotor.Pack(builder, _o.AsIVehiclePlayerMotor()).Value;
			case TTargetVehicle.IVehicleTeam:
				return IVehicleTeam.Pack(builder, _o.AsIVehicleTeam()).Value;
			default:
				return 0;
			}
		}
	}
}
