using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006133 RID: 24883
	public struct IVehicleGenerationType : IFlatbufferObject
	{
		// Token: 0x1700B959 RID: 47449
		// (get) Token: 0x0602A38E RID: 172942 RVA: 0x005C3397 File Offset: 0x005C1597
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A38F RID: 172943 RVA: 0x005C33A4 File Offset: 0x005C15A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A390 RID: 172944 RVA: 0x005C33AC File Offset: 0x005C15AC
		public static IVehicleGenerationType GetRootAsIVehicleGenerationType(ByteBuffer _bb)
		{
			return IVehicleGenerationType.GetRootAsIVehicleGenerationType(_bb, default(IVehicleGenerationType));
		}

		// Token: 0x0602A391 RID: 172945 RVA: 0x005C33C8 File Offset: 0x005C15C8
		public static IVehicleGenerationType GetRootAsIVehicleGenerationType(ByteBuffer _bb, IVehicleGenerationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A392 RID: 172946 RVA: 0x005C33E5 File Offset: 0x005C15E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A393 RID: 172947 RVA: 0x005C33F4 File Offset: 0x005C15F4
		public IVehicleGenerationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B95A RID: 47450
		// (get) Token: 0x0602A394 RID: 172948 RVA: 0x005C3404 File Offset: 0x005C1604
		public EVehicleGenerationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleGenerationType.VehicleEntityTemplate;
				}
				return (EVehicleGenerationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B95B RID: 47451
		// (get) Token: 0x0602A395 RID: 172949 RVA: 0x005C3440 File Offset: 0x005C1640
		public int Id
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

		// Token: 0x1700B95C RID: 47452
		// (get) Token: 0x0602A396 RID: 172950 RVA: 0x005C347C File Offset: 0x005C167C
		public int Weight
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A397 RID: 172951 RVA: 0x005C34B8 File Offset: 0x005C16B8
		public static Offset<IVehicleGenerationType> CreateIVehicleGenerationType(FlatBufferBuilder builder, EVehicleGenerationType Type = EVehicleGenerationType.VehicleEntityTemplate, int Id = 0, int Weight = 0)
		{
			builder.StartTable(3);
			IVehicleGenerationType.AddWeight(builder, Weight);
			IVehicleGenerationType.AddId(builder, Id);
			IVehicleGenerationType.AddType(builder, Type);
			return IVehicleGenerationType.EndIVehicleGenerationType(builder);
		}

		// Token: 0x0602A398 RID: 172952 RVA: 0x005C34DC File Offset: 0x005C16DC
		public static void StartIVehicleGenerationType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A399 RID: 172953 RVA: 0x005C34E5 File Offset: 0x005C16E5
		public static void AddType(FlatBufferBuilder builder, EVehicleGenerationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A39A RID: 172954 RVA: 0x005C34F0 File Offset: 0x005C16F0
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602A39B RID: 172955 RVA: 0x005C34FB File Offset: 0x005C16FB
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(2, weight, 0);
		}

		// Token: 0x0602A39C RID: 172956 RVA: 0x005C3506 File Offset: 0x005C1706
		public static Offset<IVehicleGenerationType> EndIVehicleGenerationType(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleGenerationType>(builder.EndTable());
		}

		// Token: 0x0602A39D RID: 172957 RVA: 0x005C3514 File Offset: 0x005C1714
		public IVehicleGenerationTypeT UnPack()
		{
			IVehicleGenerationTypeT vehicleGenerationTypeT = new IVehicleGenerationTypeT();
			this.UnPackTo(vehicleGenerationTypeT);
			return vehicleGenerationTypeT;
		}

		// Token: 0x0602A39E RID: 172958 RVA: 0x005C352F File Offset: 0x005C172F
		public void UnPackTo(IVehicleGenerationTypeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Weight = this.Weight;
		}

		// Token: 0x0602A39F RID: 172959 RVA: 0x005C3558 File Offset: 0x005C1758
		public static Offset<IVehicleGenerationType> Pack(FlatBufferBuilder builder, IVehicleGenerationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleGenerationType>);
			}
			return IVehicleGenerationType.CreateIVehicleGenerationType(builder, _o.Type, _o.Id, _o.Weight);
		}

		// Token: 0x0400FF3E RID: 65342
		private Table __p;
	}
}
