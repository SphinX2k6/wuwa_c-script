using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200673C RID: 26428
	public class IExitVehicleType_UnionUnion
	{
		// Token: 0x1700C43C RID: 50236
		// (get) Token: 0x0602DF7D RID: 188285 RVA: 0x006487D5 File Offset: 0x006469D5
		// (set) Token: 0x0602DF7E RID: 188286 RVA: 0x006487DD File Offset: 0x006469DD
		public IExitVehicleType_Union Type { get; set; }

		// Token: 0x1700C43D RID: 50237
		// (get) Token: 0x0602DF7F RID: 188287 RVA: 0x006487E6 File Offset: 0x006469E6
		// (set) Token: 0x0602DF80 RID: 188288 RVA: 0x006487EE File Offset: 0x006469EE
		public object Value { get; set; }

		// Token: 0x0602DF81 RID: 188289 RVA: 0x006487F7 File Offset: 0x006469F7
		public IExitVehicleType_UnionUnion()
		{
			this.Type = IExitVehicleType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DF82 RID: 188290 RVA: 0x0064880D File Offset: 0x00646A0D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DF83 RID: 188291 RVA: 0x0064881F File Offset: 0x00646A1F
		public IExitVehicleTypeT AsIExitVehicleType()
		{
			return this.As<IExitVehicleTypeT>();
		}

		// Token: 0x0602DF84 RID: 188292 RVA: 0x00648827 File Offset: 0x00646A27
		public static IExitVehicleType_UnionUnion FromIExitVehicleType(IExitVehicleTypeT _iexitvehicletype)
		{
			return new IExitVehicleType_UnionUnion
			{
				Type = IExitVehicleType_Union.IExitVehicleType,
				Value = _iexitvehicletype
			};
		}

		// Token: 0x0602DF85 RID: 188293 RVA: 0x0064883C File Offset: 0x00646A3C
		public IExitVehicleLaunchT AsIExitVehicleLaunch()
		{
			return this.As<IExitVehicleLaunchT>();
		}

		// Token: 0x0602DF86 RID: 188294 RVA: 0x00648844 File Offset: 0x00646A44
		public static IExitVehicleType_UnionUnion FromIExitVehicleLaunch(IExitVehicleLaunchT _iexitvehiclelaunch)
		{
			return new IExitVehicleType_UnionUnion
			{
				Type = IExitVehicleType_Union.IExitVehicleLaunch,
				Value = _iexitvehiclelaunch
			};
		}

		// Token: 0x0602DF87 RID: 188295 RVA: 0x00648859 File Offset: 0x00646A59
		public IExitVehicleStandUpT AsIExitVehicleStandUp()
		{
			return this.As<IExitVehicleStandUpT>();
		}

		// Token: 0x0602DF88 RID: 188296 RVA: 0x00648861 File Offset: 0x00646A61
		public static IExitVehicleType_UnionUnion FromIExitVehicleStandUp(IExitVehicleStandUpT _iexitvehiclestandup)
		{
			return new IExitVehicleType_UnionUnion
			{
				Type = IExitVehicleType_Union.IExitVehicleStandUp,
				Value = _iexitvehiclestandup
			};
		}

		// Token: 0x0602DF89 RID: 188297 RVA: 0x00648876 File Offset: 0x00646A76
		public IExitVehicleTeleportT AsIExitVehicleTeleport()
		{
			return this.As<IExitVehicleTeleportT>();
		}

		// Token: 0x0602DF8A RID: 188298 RVA: 0x0064887E File Offset: 0x00646A7E
		public static IExitVehicleType_UnionUnion FromIExitVehicleTeleport(IExitVehicleTeleportT _iexitvehicleteleport)
		{
			return new IExitVehicleType_UnionUnion
			{
				Type = IExitVehicleType_Union.IExitVehicleTeleport,
				Value = _iexitvehicleteleport
			};
		}

		// Token: 0x0602DF8B RID: 188299 RVA: 0x00648893 File Offset: 0x00646A93
		public IExitVehicleSeatStandUpT AsIExitVehicleSeatStandUp()
		{
			return this.As<IExitVehicleSeatStandUpT>();
		}

		// Token: 0x0602DF8C RID: 188300 RVA: 0x0064889B File Offset: 0x00646A9B
		public static IExitVehicleType_UnionUnion FromIExitVehicleSeatStandUp(IExitVehicleSeatStandUpT _iexitvehicleseatstandup)
		{
			return new IExitVehicleType_UnionUnion
			{
				Type = IExitVehicleType_Union.IExitVehicleSeatStandUp,
				Value = _iexitvehicleseatstandup
			};
		}

		// Token: 0x0602DF8D RID: 188301 RVA: 0x006488B0 File Offset: 0x00646AB0
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
