using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ED1 RID: 32465
	public class TExitVehicleTypeUnion
	{
		// Token: 0x1700F259 RID: 62041
		// (get) Token: 0x0603A97B RID: 239995 RVA: 0x007E2440 File Offset: 0x007E0640
		// (set) Token: 0x0603A97C RID: 239996 RVA: 0x007E2448 File Offset: 0x007E0648
		public TExitVehicleType Type { get; set; }

		// Token: 0x1700F25A RID: 62042
		// (get) Token: 0x0603A97D RID: 239997 RVA: 0x007E2451 File Offset: 0x007E0651
		// (set) Token: 0x0603A97E RID: 239998 RVA: 0x007E2459 File Offset: 0x007E0659
		public object Value { get; set; }

		// Token: 0x0603A97F RID: 239999 RVA: 0x007E2462 File Offset: 0x007E0662
		public TExitVehicleTypeUnion()
		{
			this.Type = TExitVehicleType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A980 RID: 240000 RVA: 0x007E2478 File Offset: 0x007E0678
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A981 RID: 240001 RVA: 0x007E248A File Offset: 0x007E068A
		public IExitVehicleLaunchT AsIExitVehicleLaunch()
		{
			return this.As<IExitVehicleLaunchT>();
		}

		// Token: 0x0603A982 RID: 240002 RVA: 0x007E2492 File Offset: 0x007E0692
		public static TExitVehicleTypeUnion FromIExitVehicleLaunch(IExitVehicleLaunchT _iexitvehiclelaunch)
		{
			return new TExitVehicleTypeUnion
			{
				Type = TExitVehicleType.IExitVehicleLaunch,
				Value = _iexitvehiclelaunch
			};
		}

		// Token: 0x0603A983 RID: 240003 RVA: 0x007E24A7 File Offset: 0x007E06A7
		public IExitVehicleSeatStandUpT AsIExitVehicleSeatStandUp()
		{
			return this.As<IExitVehicleSeatStandUpT>();
		}

		// Token: 0x0603A984 RID: 240004 RVA: 0x007E24AF File Offset: 0x007E06AF
		public static TExitVehicleTypeUnion FromIExitVehicleSeatStandUp(IExitVehicleSeatStandUpT _iexitvehicleseatstandup)
		{
			return new TExitVehicleTypeUnion
			{
				Type = TExitVehicleType.IExitVehicleSeatStandUp,
				Value = _iexitvehicleseatstandup
			};
		}

		// Token: 0x0603A985 RID: 240005 RVA: 0x007E24C4 File Offset: 0x007E06C4
		public IExitVehicleStandUpT AsIExitVehicleStandUp()
		{
			return this.As<IExitVehicleStandUpT>();
		}

		// Token: 0x0603A986 RID: 240006 RVA: 0x007E24CC File Offset: 0x007E06CC
		public static TExitVehicleTypeUnion FromIExitVehicleStandUp(IExitVehicleStandUpT _iexitvehiclestandup)
		{
			return new TExitVehicleTypeUnion
			{
				Type = TExitVehicleType.IExitVehicleStandUp,
				Value = _iexitvehiclestandup
			};
		}

		// Token: 0x0603A987 RID: 240007 RVA: 0x007E24E1 File Offset: 0x007E06E1
		public IExitVehicleTeleportT AsIExitVehicleTeleport()
		{
			return this.As<IExitVehicleTeleportT>();
		}

		// Token: 0x0603A988 RID: 240008 RVA: 0x007E24E9 File Offset: 0x007E06E9
		public static TExitVehicleTypeUnion FromIExitVehicleTeleport(IExitVehicleTeleportT _iexitvehicleteleport)
		{
			return new TExitVehicleTypeUnion
			{
				Type = TExitVehicleType.IExitVehicleTeleport,
				Value = _iexitvehicleteleport
			};
		}

		// Token: 0x0603A989 RID: 240009 RVA: 0x007E2500 File Offset: 0x007E0700
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
