using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067FF RID: 26623
	public struct IAppointedVehicle : IFlatbufferObject
	{
		// Token: 0x1700C3B3 RID: 50099
		// (get) Token: 0x0602D795 RID: 186261 RVA: 0x00639CAC File Offset: 0x00637EAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D796 RID: 186262 RVA: 0x00639CB9 File Offset: 0x00637EB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D797 RID: 186263 RVA: 0x00639CC0 File Offset: 0x00637EC0
		public static IAppointedVehicle GetRootAsIAppointedVehicle(ByteBuffer _bb)
		{
			return IAppointedVehicle.GetRootAsIAppointedVehicle(_bb, default(IAppointedVehicle));
		}

		// Token: 0x0602D798 RID: 186264 RVA: 0x00639CDC File Offset: 0x00637EDC
		public static IAppointedVehicle GetRootAsIAppointedVehicle(ByteBuffer _bb, IAppointedVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D799 RID: 186265 RVA: 0x00639CF9 File Offset: 0x00637EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D79A RID: 186266 RVA: 0x00639D08 File Offset: 0x00637F08
		public IAppointedVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3B4 RID: 50100
		// (get) Token: 0x0602D79B RID: 186267 RVA: 0x00639D18 File Offset: 0x00637F18
		public ETargetVehicle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetVehicle.Current;
				}
				return (ETargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3B5 RID: 50101
		// (get) Token: 0x0602D79C RID: 186268 RVA: 0x00639D54 File Offset: 0x00637F54
		public int VehicleId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D79D RID: 186269 RVA: 0x00639D90 File Offset: 0x00637F90
		public static Offset<IAppointedVehicle> CreateIAppointedVehicle(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current, int VehicleId = 0)
		{
			builder.StartTable(2);
			IAppointedVehicle.AddVehicleId(builder, VehicleId);
			IAppointedVehicle.AddType(builder, Type);
			return IAppointedVehicle.EndIAppointedVehicle(builder);
		}

		// Token: 0x0602D79E RID: 186270 RVA: 0x00639DAD File Offset: 0x00637FAD
		public static void StartIAppointedVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D79F RID: 186271 RVA: 0x00639DB6 File Offset: 0x00637FB6
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D7A0 RID: 186272 RVA: 0x00639DC1 File Offset: 0x00637FC1
		public static void AddVehicleId(FlatBufferBuilder builder, int vehicleId)
		{
			builder.AddInt(1, vehicleId, 0);
		}

		// Token: 0x0602D7A1 RID: 186273 RVA: 0x00639DCC File Offset: 0x00637FCC
		public static Offset<IAppointedVehicle> EndIAppointedVehicle(FlatBufferBuilder builder)
		{
			return new Offset<IAppointedVehicle>(builder.EndTable());
		}

		// Token: 0x0602D7A2 RID: 186274 RVA: 0x00639DDC File Offset: 0x00637FDC
		public IAppointedVehicleT UnPack()
		{
			IAppointedVehicleT appointedVehicleT = new IAppointedVehicleT();
			this.UnPackTo(appointedVehicleT);
			return appointedVehicleT;
		}

		// Token: 0x0602D7A3 RID: 186275 RVA: 0x00639DF7 File Offset: 0x00637FF7
		public void UnPackTo(IAppointedVehicleT _o)
		{
			_o.Type = this.Type;
			_o.VehicleId = this.VehicleId;
		}

		// Token: 0x0602D7A4 RID: 186276 RVA: 0x00639E14 File Offset: 0x00638014
		public static Offset<IAppointedVehicle> Pack(FlatBufferBuilder builder, IAppointedVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAppointedVehicle>);
			}
			return IAppointedVehicle.CreateIAppointedVehicle(builder, _o.Type, _o.VehicleId);
		}

		// Token: 0x040114B2 RID: 70834
		private Table __p;
	}
}
