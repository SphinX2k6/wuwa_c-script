using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C3 RID: 30403
	public class TExitVehicleTypeUnion
	{
		// Token: 0x1700E61B RID: 58907
		// (get) Token: 0x060374C6 RID: 226502 RVA: 0x0077E12E File Offset: 0x0077C32E
		// (set) Token: 0x060374C7 RID: 226503 RVA: 0x0077E136 File Offset: 0x0077C336
		public TExitVehicleType Type { get; set; }

		// Token: 0x1700E61C RID: 58908
		// (get) Token: 0x060374C8 RID: 226504 RVA: 0x0077E13F File Offset: 0x0077C33F
		// (set) Token: 0x060374C9 RID: 226505 RVA: 0x0077E147 File Offset: 0x0077C347
		public object Value { get; set; }

		// Token: 0x060374CA RID: 226506 RVA: 0x0077E150 File Offset: 0x0077C350
		public TExitVehicleTypeUnion()
		{
			this.Type = TExitVehicleType.NONE;
			this.Value = null;
		}

		// Token: 0x060374CB RID: 226507 RVA: 0x0077E166 File Offset: 0x0077C366
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060374CC RID: 226508 RVA: 0x0077E178 File Offset: 0x0077C378
		public IExitVehicleLaunchT AsIExitVehicleLaunch()
		{
			return this.As<IExitVehicleLaunchT>();
		}

		// Token: 0x060374CD RID: 226509 RVA: 0x0077E180 File Offset: 0x0077C380
		public static TExitVehicleTypeUnion FromIExitVehicleLaunch(IExitVehicleLaunchT _iexitvehiclelaunch)
		{
			return new TExitVehicleTypeUnion
			{
				Type = TExitVehicleType.IExitVehicleLaunch,
				Value = _iexitvehiclelaunch
			};
		}

		// Token: 0x060374CE RID: 226510 RVA: 0x0077E195 File Offset: 0x0077C395
		public IExitVehicleSeatStandUpT AsIExitVehicleSeatStandUp()
		{
			return this.As<IExitVehicleSeatStandUpT>();
		}

		// Token: 0x060374CF RID: 226511 RVA: 0x0077E19D File Offset: 0x0077C39D
		public static TExitVehicleTypeUnion FromIExitVehicleSeatStandUp(IExitVehicleSeatStandUpT _iexitvehicleseatstandup)
		{
			return new TExitVehicleTypeUnion
			{
				Type = TExitVehicleType.IExitVehicleSeatStandUp,
				Value = _iexitvehicleseatstandup
			};
		}

		// Token: 0x060374D0 RID: 226512 RVA: 0x0077E1B2 File Offset: 0x0077C3B2
		public IExitVehicleStandUpT AsIExitVehicleStandUp()
		{
			return this.As<IExitVehicleStandUpT>();
		}

		// Token: 0x060374D1 RID: 226513 RVA: 0x0077E1BA File Offset: 0x0077C3BA
		public static TExitVehicleTypeUnion FromIExitVehicleStandUp(IExitVehicleStandUpT _iexitvehiclestandup)
		{
			return new TExitVehicleTypeUnion
			{
				Type = TExitVehicleType.IExitVehicleStandUp,
				Value = _iexitvehiclestandup
			};
		}

		// Token: 0x060374D2 RID: 226514 RVA: 0x0077E1CF File Offset: 0x0077C3CF
		public IExitVehicleTeleportT AsIExitVehicleTeleport()
		{
			return this.As<IExitVehicleTeleportT>();
		}

		// Token: 0x060374D3 RID: 226515 RVA: 0x0077E1D7 File Offset: 0x0077C3D7
		public static TExitVehicleTypeUnion FromIExitVehicleTeleport(IExitVehicleTeleportT _iexitvehicleteleport)
		{
			return new TExitVehicleTypeUnion
			{
				Type = TExitVehicleType.IExitVehicleTeleport,
				Value = _iexitvehicleteleport
			};
		}

		// Token: 0x060374D4 RID: 226516 RVA: 0x0077E1EC File Offset: 0x0077C3EC
		public static int Pack(FlatBufferBuilder builder, TExitVehicleTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TExitVehicleType.IExitVehicleLaunch:
				return IExitVehicleLaunch.Pack(builder, _o.AsIExitVehicleLaunch()).Value;
			case TExitVehicleType.IExitVehicleSeatStandUp:
				return IExitVehicleSeatStandUp.Pack(builder, _o.AsIExitVehicleSeatStandUp()).Value;
			case TExitVehicleType.IExitVehicleStandUp:
				return IExitVehicleStandUp.Pack(builder, _o.AsIExitVehicleStandUp()).Value;
			case TExitVehicleType.IExitVehicleTeleport:
				return IExitVehicleTeleport.Pack(builder, _o.AsIExitVehicleTeleport()).Value;
			default:
				return 0;
			}
		}
	}
}
