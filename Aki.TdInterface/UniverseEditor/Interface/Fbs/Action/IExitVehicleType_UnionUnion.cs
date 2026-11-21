using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DBC RID: 28092
	public class IExitVehicleType_UnionUnion
	{
		// Token: 0x1700CDF2 RID: 52722
		// (get) Token: 0x060307C3 RID: 198595 RVA: 0x00695F19 File Offset: 0x00694119
		// (set) Token: 0x060307C4 RID: 198596 RVA: 0x00695F21 File Offset: 0x00694121
		public IExitVehicleType_Union Type { get; set; }

		// Token: 0x1700CDF3 RID: 52723
		// (get) Token: 0x060307C5 RID: 198597 RVA: 0x00695F2A File Offset: 0x0069412A
		// (set) Token: 0x060307C6 RID: 198598 RVA: 0x00695F32 File Offset: 0x00694132
		public object Value { get; set; }

		// Token: 0x060307C7 RID: 198599 RVA: 0x00695F3B File Offset: 0x0069413B
		public IExitVehicleType_UnionUnion()
		{
			this.Type = IExitVehicleType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060307C8 RID: 198600 RVA: 0x00695F51 File Offset: 0x00694151
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060307C9 RID: 198601 RVA: 0x00695F63 File Offset: 0x00694163
		public IExitVehicleTypeT AsIExitVehicleType()
		{
			return this.As<IExitVehicleTypeT>();
		}

		// Token: 0x060307CA RID: 198602 RVA: 0x00695F6B File Offset: 0x0069416B
		public static IExitVehicleType_UnionUnion FromIExitVehicleType(IExitVehicleTypeT _iexitvehicletype)
		{
			return new IExitVehicleType_UnionUnion
			{
				Type = IExitVehicleType_Union.IExitVehicleType,
				Value = _iexitvehicletype
			};
		}

		// Token: 0x060307CB RID: 198603 RVA: 0x00695F80 File Offset: 0x00694180
		public IExitVehicleLaunchT AsIExitVehicleLaunch()
		{
			return this.As<IExitVehicleLaunchT>();
		}

		// Token: 0x060307CC RID: 198604 RVA: 0x00695F88 File Offset: 0x00694188
		public static IExitVehicleType_UnionUnion FromIExitVehicleLaunch(IExitVehicleLaunchT _iexitvehiclelaunch)
		{
			return new IExitVehicleType_UnionUnion
			{
				Type = IExitVehicleType_Union.IExitVehicleLaunch,
				Value = _iexitvehiclelaunch
			};
		}

		// Token: 0x060307CD RID: 198605 RVA: 0x00695F9D File Offset: 0x0069419D
		public IExitVehicleStandUpT AsIExitVehicleStandUp()
		{
			return this.As<IExitVehicleStandUpT>();
		}

		// Token: 0x060307CE RID: 198606 RVA: 0x00695FA5 File Offset: 0x006941A5
		public static IExitVehicleType_UnionUnion FromIExitVehicleStandUp(IExitVehicleStandUpT _iexitvehiclestandup)
		{
			return new IExitVehicleType_UnionUnion
			{
				Type = IExitVehicleType_Union.IExitVehicleStandUp,
				Value = _iexitvehiclestandup
			};
		}

		// Token: 0x060307CF RID: 198607 RVA: 0x00695FBA File Offset: 0x006941BA
		public IExitVehicleTeleportT AsIExitVehicleTeleport()
		{
			return this.As<IExitVehicleTeleportT>();
		}

		// Token: 0x060307D0 RID: 198608 RVA: 0x00695FC2 File Offset: 0x006941C2
		public static IExitVehicleType_UnionUnion FromIExitVehicleTeleport(IExitVehicleTeleportT _iexitvehicleteleport)
		{
			return new IExitVehicleType_UnionUnion
			{
				Type = IExitVehicleType_Union.IExitVehicleTeleport,
				Value = _iexitvehicleteleport
			};
		}

		// Token: 0x060307D1 RID: 198609 RVA: 0x00695FD7 File Offset: 0x006941D7
		public IExitVehicleSeatStandUpT AsIExitVehicleSeatStandUp()
		{
			return this.As<IExitVehicleSeatStandUpT>();
		}

		// Token: 0x060307D2 RID: 198610 RVA: 0x00695FDF File Offset: 0x006941DF
		public static IExitVehicleType_UnionUnion FromIExitVehicleSeatStandUp(IExitVehicleSeatStandUpT _iexitvehicleseatstandup)
		{
			return new IExitVehicleType_UnionUnion
			{
				Type = IExitVehicleType_Union.IExitVehicleSeatStandUp,
				Value = _iexitvehicleseatstandup
			};
		}

		// Token: 0x060307D3 RID: 198611 RVA: 0x00695FF4 File Offset: 0x006941F4
		public static int Pack(FlatBufferBuilder builder, IExitVehicleType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IExitVehicleType_Union.IExitVehicleType:
				return IExitVehicleType.Pack(builder, _o.AsIExitVehicleType()).Value;
			case IExitVehicleType_Union.IExitVehicleLaunch:
				return IExitVehicleLaunch.Pack(builder, _o.AsIExitVehicleLaunch()).Value;
			case IExitVehicleType_Union.IExitVehicleStandUp:
				return IExitVehicleStandUp.Pack(builder, _o.AsIExitVehicleStandUp()).Value;
			case IExitVehicleType_Union.IExitVehicleTeleport:
				return IExitVehicleTeleport.Pack(builder, _o.AsIExitVehicleTeleport()).Value;
			case IExitVehicleType_Union.IExitVehicleSeatStandUp:
				return IExitVehicleSeatStandUp.Pack(builder, _o.AsIExitVehicleSeatStandUp()).Value;
			default:
				return 0;
			}
		}
	}
}
