using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B17 RID: 23319
	public struct IVehicleGenerateByVehicleTeamTemplate : IFlatbufferObject
	{
		// Token: 0x1700AFFE RID: 45054
		// (get) Token: 0x06027D78 RID: 163192 RVA: 0x0057ACF8 File Offset: 0x00578EF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027D79 RID: 163193 RVA: 0x0057AD05 File Offset: 0x00578F05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027D7A RID: 163194 RVA: 0x0057AD0C File Offset: 0x00578F0C
		public static IVehicleGenerateByVehicleTeamTemplate GetRootAsIVehicleGenerateByVehicleTeamTemplate(ByteBuffer _bb)
		{
			return IVehicleGenerateByVehicleTeamTemplate.GetRootAsIVehicleGenerateByVehicleTeamTemplate(_bb, default(IVehicleGenerateByVehicleTeamTemplate));
		}

		// Token: 0x06027D7B RID: 163195 RVA: 0x0057AD28 File Offset: 0x00578F28
		public static IVehicleGenerateByVehicleTeamTemplate GetRootAsIVehicleGenerateByVehicleTeamTemplate(ByteBuffer _bb, IVehicleGenerateByVehicleTeamTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027D7C RID: 163196 RVA: 0x0057AD45 File Offset: 0x00578F45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027D7D RID: 163197 RVA: 0x0057AD54 File Offset: 0x00578F54
		public IVehicleGenerateByVehicleTeamTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFFF RID: 45055
		// (get) Token: 0x06027D7E RID: 163198 RVA: 0x0057AD64 File Offset: 0x00578F64
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

		// Token: 0x1700B000 RID: 45056
		// (get) Token: 0x06027D7F RID: 163199 RVA: 0x0057ADA0 File Offset: 0x00578FA0
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

		// Token: 0x1700B001 RID: 45057
		// (get) Token: 0x06027D80 RID: 163200 RVA: 0x0057ADDC File Offset: 0x00578FDC
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

		// Token: 0x06027D81 RID: 163201 RVA: 0x0057AE18 File Offset: 0x00579018
		public static Offset<IVehicleGenerateByVehicleTeamTemplate> CreateIVehicleGenerateByVehicleTeamTemplate(FlatBufferBuilder builder, EVehicleGenerationType Type = EVehicleGenerationType.VehicleEntityTemplate, int Id = 0, int Weight = 0)
		{
			builder.StartTable(3);
			IVehicleGenerateByVehicleTeamTemplate.AddWeight(builder, Weight);
			IVehicleGenerateByVehicleTeamTemplate.AddId(builder, Id);
			IVehicleGenerateByVehicleTeamTemplate.AddType(builder, Type);
			return IVehicleGenerateByVehicleTeamTemplate.EndIVehicleGenerateByVehicleTeamTemplate(builder);
		}

		// Token: 0x06027D82 RID: 163202 RVA: 0x0057AE3C File Offset: 0x0057903C
		public static void StartIVehicleGenerateByVehicleTeamTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027D83 RID: 163203 RVA: 0x0057AE45 File Offset: 0x00579045
		public static void AddType(FlatBufferBuilder builder, EVehicleGenerationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027D84 RID: 163204 RVA: 0x0057AE50 File Offset: 0x00579050
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06027D85 RID: 163205 RVA: 0x0057AE5B File Offset: 0x0057905B
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(2, weight, 0);
		}

		// Token: 0x06027D86 RID: 163206 RVA: 0x0057AE66 File Offset: 0x00579066
		public static Offset<IVehicleGenerateByVehicleTeamTemplate> EndIVehicleGenerateByVehicleTeamTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleGenerateByVehicleTeamTemplate>(builder.EndTable());
		}

		// Token: 0x06027D87 RID: 163207 RVA: 0x0057AE74 File Offset: 0x00579074
		public IVehicleGenerateByVehicleTeamTemplateT UnPack()
		{
			IVehicleGenerateByVehicleTeamTemplateT vehicleGenerateByVehicleTeamTemplateT = new IVehicleGenerateByVehicleTeamTemplateT();
			this.UnPackTo(vehicleGenerateByVehicleTeamTemplateT);
			return vehicleGenerateByVehicleTeamTemplateT;
		}

		// Token: 0x06027D88 RID: 163208 RVA: 0x0057AE8F File Offset: 0x0057908F
		public void UnPackTo(IVehicleGenerateByVehicleTeamTemplateT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Weight = this.Weight;
		}

		// Token: 0x06027D89 RID: 163209 RVA: 0x0057AEB8 File Offset: 0x005790B8
		public static Offset<IVehicleGenerateByVehicleTeamTemplate> Pack(FlatBufferBuilder builder, IVehicleGenerateByVehicleTeamTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleGenerateByVehicleTeamTemplate>);
			}
			return IVehicleGenerateByVehicleTeamTemplate.CreateIVehicleGenerateByVehicleTeamTemplate(builder, _o.Type, _o.Id, _o.Weight);
		}

		// Token: 0x0400F22E RID: 61998
		private Table __p;
	}
}
