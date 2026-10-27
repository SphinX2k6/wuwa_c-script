using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006194 RID: 24980
	public struct IAppointedVehicle : IFlatbufferObject
	{
		// Token: 0x1700BA35 RID: 47669
		// (get) Token: 0x0602B064 RID: 176228 RVA: 0x005EF438 File Offset: 0x005ED638
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B065 RID: 176229 RVA: 0x005EF445 File Offset: 0x005ED645
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B066 RID: 176230 RVA: 0x005EF44C File Offset: 0x005ED64C
		public static IAppointedVehicle GetRootAsIAppointedVehicle(ByteBuffer _bb)
		{
			return IAppointedVehicle.GetRootAsIAppointedVehicle(_bb, default(IAppointedVehicle));
		}

		// Token: 0x0602B067 RID: 176231 RVA: 0x005EF468 File Offset: 0x005ED668
		public static IAppointedVehicle GetRootAsIAppointedVehicle(ByteBuffer _bb, IAppointedVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B068 RID: 176232 RVA: 0x005EF485 File Offset: 0x005ED685
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B069 RID: 176233 RVA: 0x005EF494 File Offset: 0x005ED694
		public IAppointedVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA36 RID: 47670
		// (get) Token: 0x0602B06A RID: 176234 RVA: 0x005EF4A4 File Offset: 0x005ED6A4
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

		// Token: 0x1700BA37 RID: 47671
		// (get) Token: 0x0602B06B RID: 176235 RVA: 0x005EF4E0 File Offset: 0x005ED6E0
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

		// Token: 0x0602B06C RID: 176236 RVA: 0x005EF51C File Offset: 0x005ED71C
		public static Offset<IAppointedVehicle> CreateIAppointedVehicle(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current, int VehicleId = 0)
		{
			builder.StartTable(2);
			IAppointedVehicle.AddVehicleId(builder, VehicleId);
			IAppointedVehicle.AddType(builder, Type);
			return IAppointedVehicle.EndIAppointedVehicle(builder);
		}

		// Token: 0x0602B06D RID: 176237 RVA: 0x005EF539 File Offset: 0x005ED739
		public static void StartIAppointedVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B06E RID: 176238 RVA: 0x005EF542 File Offset: 0x005ED742
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B06F RID: 176239 RVA: 0x005EF54D File Offset: 0x005ED74D
		public static void AddVehicleId(FlatBufferBuilder builder, int vehicleId)
		{
			builder.AddInt(1, vehicleId, 0);
		}

		// Token: 0x0602B070 RID: 176240 RVA: 0x005EF558 File Offset: 0x005ED758
		public static Offset<IAppointedVehicle> EndIAppointedVehicle(FlatBufferBuilder builder)
		{
			return new Offset<IAppointedVehicle>(builder.EndTable());
		}

		// Token: 0x0602B071 RID: 176241 RVA: 0x005EF568 File Offset: 0x005ED768
		public IAppointedVehicleT UnPack()
		{
			IAppointedVehicleT appointedVehicleT = new IAppointedVehicleT();
			this.UnPackTo(appointedVehicleT);
			return appointedVehicleT;
		}

		// Token: 0x0602B072 RID: 176242 RVA: 0x005EF583 File Offset: 0x005ED783
		public void UnPackTo(IAppointedVehicleT _o)
		{
			_o.Type = this.Type;
			_o.VehicleId = this.VehicleId;
		}

		// Token: 0x0602B073 RID: 176243 RVA: 0x005EF5A0 File Offset: 0x005ED7A0
		public static Offset<IAppointedVehicle> Pack(FlatBufferBuilder builder, IAppointedVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAppointedVehicle>);
			}
			return IAppointedVehicle.CreateIAppointedVehicle(builder, _o.Type, _o.VehicleId);
		}

		// Token: 0x040106A3 RID: 67235
		private Table __p;
	}
}
