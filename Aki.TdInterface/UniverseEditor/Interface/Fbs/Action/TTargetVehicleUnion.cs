using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D2 RID: 30674
	public class TTargetVehicleUnion
	{
		// Token: 0x1700E6CF RID: 59087
		// (get) Token: 0x06037A3E RID: 227902 RVA: 0x007865C8 File Offset: 0x007847C8
		// (set) Token: 0x06037A3F RID: 227903 RVA: 0x007865D0 File Offset: 0x007847D0
		public TTargetVehicle Type { get; set; }

		// Token: 0x1700E6D0 RID: 59088
		// (get) Token: 0x06037A40 RID: 227904 RVA: 0x007865D9 File Offset: 0x007847D9
		// (set) Token: 0x06037A41 RID: 227905 RVA: 0x007865E1 File Offset: 0x007847E1
		public object Value { get; set; }

		// Token: 0x06037A42 RID: 227906 RVA: 0x007865EA File Offset: 0x007847EA
		public TTargetVehicleUnion()
		{
			this.Type = TTargetVehicle.NONE;
			this.Value = null;
		}

		// Token: 0x06037A43 RID: 227907 RVA: 0x00786600 File Offset: 0x00784800
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037A44 RID: 227908 RVA: 0x00786612 File Offset: 0x00784812
		public IAppointedVehicleT AsIAppointedVehicle()
		{
			return this.As<IAppointedVehicleT>();
		}

		// Token: 0x06037A45 RID: 227909 RVA: 0x0078661A File Offset: 0x0078481A
		public static TTargetVehicleUnion FromIAppointedVehicle(IAppointedVehicleT _iappointedvehicle)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.IAppointedVehicle,
				Value = _iappointedvehicle
			};
		}

		// Token: 0x06037A46 RID: 227910 RVA: 0x0078662F File Offset: 0x0078482F
		public ICurrentVehicleT AsICurrentVehicle()
		{
			return this.As<ICurrentVehicleT>();
		}

		// Token: 0x06037A47 RID: 227911 RVA: 0x00786637 File Offset: 0x00784837
		public static TTargetVehicleUnion FromICurrentVehicle(ICurrentVehicleT _icurrentvehicle)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.ICurrentVehicle,
				Value = _icurrentvehicle
			};
		}

		// Token: 0x06037A48 RID: 227912 RVA: 0x0078664C File Offset: 0x0078484C
		public IFishingBoatVehicleT AsIFishingBoatVehicle()
		{
			return this.As<IFishingBoatVehicleT>();
		}

		// Token: 0x06037A49 RID: 227913 RVA: 0x00786654 File Offset: 0x00784854
		public static TTargetVehicleUnion FromIFishingBoatVehicle(IFishingBoatVehicleT _ifishingboatvehicle)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.IFishingBoatVehicle,
				Value = _ifishingboatvehicle
			};
		}

		// Token: 0x06037A4A RID: 227914 RVA: 0x00786669 File Offset: 0x00784869
		public ISelfVehicleT AsISelfVehicle()
		{
			return this.As<ISelfVehicleT>();
		}

		// Token: 0x06037A4B RID: 227915 RVA: 0x00786671 File Offset: 0x00784871
		public static TTargetVehicleUnion FromISelfVehicle(ISelfVehicleT _iselfvehicle)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.ISelfVehicle,
				Value = _iselfvehicle
			};
		}

		// Token: 0x06037A4C RID: 227916 RVA: 0x00786686 File Offset: 0x00784886
		public ITriggeredVehicleT AsITriggeredVehicle()
		{
			return this.As<ITriggeredVehicleT>();
		}

		// Token: 0x06037A4D RID: 227917 RVA: 0x0078668E File Offset: 0x0078488E
		public static TTargetVehicleUnion FromITriggeredVehicle(ITriggeredVehicleT _itriggeredvehicle)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.ITriggeredVehicle,
				Value = _itriggeredvehicle
			};
		}

		// Token: 0x06037A4E RID: 227918 RVA: 0x007866A3 File Offset: 0x007848A3
		public IVehiclePlayerMotorT AsIVehiclePlayerMotor()
		{
			return this.As<IVehiclePlayerMotorT>();
		}

		// Token: 0x06037A4F RID: 227919 RVA: 0x007866AB File Offset: 0x007848AB
		public static TTargetVehicleUnion FromIVehiclePlayerMotor(IVehiclePlayerMotorT _ivehicleplayermotor)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.IVehiclePlayerMotor,
				Value = _ivehicleplayermotor
			};
		}

		// Token: 0x06037A50 RID: 227920 RVA: 0x007866C0 File Offset: 0x007848C0
		public IVehicleTeamT AsIVehicleTeam()
		{
			return this.As<IVehicleTeamT>();
		}

		// Token: 0x06037A51 RID: 227921 RVA: 0x007866C8 File Offset: 0x007848C8
		public static TTargetVehicleUnion FromIVehicleTeam(IVehicleTeamT _ivehicleteam)
		{
			return new TTargetVehicleUnion
			{
				Type = TTargetVehicle.IVehicleTeam,
				Value = _ivehicleteam
			};
		}

		// Token: 0x06037A52 RID: 227922 RVA: 0x007866E0 File Offset: 0x007848E0
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
