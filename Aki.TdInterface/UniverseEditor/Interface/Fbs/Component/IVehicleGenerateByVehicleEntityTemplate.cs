using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B14 RID: 23316
	public struct IVehicleGenerateByVehicleEntityTemplate : IFlatbufferObject
	{
		// Token: 0x1700AFF7 RID: 45047
		// (get) Token: 0x06027D5E RID: 163166 RVA: 0x0057AA68 File Offset: 0x00578C68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027D5F RID: 163167 RVA: 0x0057AA75 File Offset: 0x00578C75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027D60 RID: 163168 RVA: 0x0057AA7C File Offset: 0x00578C7C
		public static IVehicleGenerateByVehicleEntityTemplate GetRootAsIVehicleGenerateByVehicleEntityTemplate(ByteBuffer _bb)
		{
			return IVehicleGenerateByVehicleEntityTemplate.GetRootAsIVehicleGenerateByVehicleEntityTemplate(_bb, default(IVehicleGenerateByVehicleEntityTemplate));
		}

		// Token: 0x06027D61 RID: 163169 RVA: 0x0057AA98 File Offset: 0x00578C98
		public static IVehicleGenerateByVehicleEntityTemplate GetRootAsIVehicleGenerateByVehicleEntityTemplate(ByteBuffer _bb, IVehicleGenerateByVehicleEntityTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027D62 RID: 163170 RVA: 0x0057AAB5 File Offset: 0x00578CB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027D63 RID: 163171 RVA: 0x0057AAC4 File Offset: 0x00578CC4
		public IVehicleGenerateByVehicleEntityTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFF8 RID: 45048
		// (get) Token: 0x06027D64 RID: 163172 RVA: 0x0057AAD4 File Offset: 0x00578CD4
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

		// Token: 0x1700AFF9 RID: 45049
		// (get) Token: 0x06027D65 RID: 163173 RVA: 0x0057AB10 File Offset: 0x00578D10
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

		// Token: 0x1700AFFA RID: 45050
		// (get) Token: 0x06027D66 RID: 163174 RVA: 0x0057AB4C File Offset: 0x00578D4C
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

		// Token: 0x06027D67 RID: 163175 RVA: 0x0057AB88 File Offset: 0x00578D88
		public static Offset<IVehicleGenerateByVehicleEntityTemplate> CreateIVehicleGenerateByVehicleEntityTemplate(FlatBufferBuilder builder, EVehicleGenerationType Type = EVehicleGenerationType.VehicleEntityTemplate, int Id = 0, int Weight = 0)
		{
			builder.StartTable(3);
			IVehicleGenerateByVehicleEntityTemplate.AddWeight(builder, Weight);
			IVehicleGenerateByVehicleEntityTemplate.AddId(builder, Id);
			IVehicleGenerateByVehicleEntityTemplate.AddType(builder, Type);
			return IVehicleGenerateByVehicleEntityTemplate.EndIVehicleGenerateByVehicleEntityTemplate(builder);
		}

		// Token: 0x06027D68 RID: 163176 RVA: 0x0057ABAC File Offset: 0x00578DAC
		public static void StartIVehicleGenerateByVehicleEntityTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027D69 RID: 163177 RVA: 0x0057ABB5 File Offset: 0x00578DB5
		public static void AddType(FlatBufferBuilder builder, EVehicleGenerationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027D6A RID: 163178 RVA: 0x0057ABC0 File Offset: 0x00578DC0
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06027D6B RID: 163179 RVA: 0x0057ABCB File Offset: 0x00578DCB
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(2, weight, 0);
		}

		// Token: 0x06027D6C RID: 163180 RVA: 0x0057ABD6 File Offset: 0x00578DD6
		public static Offset<IVehicleGenerateByVehicleEntityTemplate> EndIVehicleGenerateByVehicleEntityTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleGenerateByVehicleEntityTemplate>(builder.EndTable());
		}

		// Token: 0x06027D6D RID: 163181 RVA: 0x0057ABE4 File Offset: 0x00578DE4
		public IVehicleGenerateByVehicleEntityTemplateT UnPack()
		{
			IVehicleGenerateByVehicleEntityTemplateT vehicleGenerateByVehicleEntityTemplateT = new IVehicleGenerateByVehicleEntityTemplateT();
			this.UnPackTo(vehicleGenerateByVehicleEntityTemplateT);
			return vehicleGenerateByVehicleEntityTemplateT;
		}

		// Token: 0x06027D6E RID: 163182 RVA: 0x0057ABFF File Offset: 0x00578DFF
		public void UnPackTo(IVehicleGenerateByVehicleEntityTemplateT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Weight = this.Weight;
		}

		// Token: 0x06027D6F RID: 163183 RVA: 0x0057AC28 File Offset: 0x00578E28
		public static Offset<IVehicleGenerateByVehicleEntityTemplate> Pack(FlatBufferBuilder builder, IVehicleGenerateByVehicleEntityTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleGenerateByVehicleEntityTemplate>);
			}
			return IVehicleGenerateByVehicleEntityTemplate.CreateIVehicleGenerateByVehicleEntityTemplate(builder, _o.Type, _o.Id, _o.Weight);
		}

		// Token: 0x0400F22A RID: 61994
		private Table __p;
	}
}
