using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200612A RID: 24874
	public struct IVehicleGenerateByVehicleEntityTemplate : IFlatbufferObject
	{
		// Token: 0x1700B93F RID: 47423
		// (get) Token: 0x0602A322 RID: 172834 RVA: 0x005C24BC File Offset: 0x005C06BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A323 RID: 172835 RVA: 0x005C24C9 File Offset: 0x005C06C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A324 RID: 172836 RVA: 0x005C24D0 File Offset: 0x005C06D0
		public static IVehicleGenerateByVehicleEntityTemplate GetRootAsIVehicleGenerateByVehicleEntityTemplate(ByteBuffer _bb)
		{
			return IVehicleGenerateByVehicleEntityTemplate.GetRootAsIVehicleGenerateByVehicleEntityTemplate(_bb, default(IVehicleGenerateByVehicleEntityTemplate));
		}

		// Token: 0x0602A325 RID: 172837 RVA: 0x005C24EC File Offset: 0x005C06EC
		public static IVehicleGenerateByVehicleEntityTemplate GetRootAsIVehicleGenerateByVehicleEntityTemplate(ByteBuffer _bb, IVehicleGenerateByVehicleEntityTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A326 RID: 172838 RVA: 0x005C2509 File Offset: 0x005C0709
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A327 RID: 172839 RVA: 0x005C2518 File Offset: 0x005C0718
		public IVehicleGenerateByVehicleEntityTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B940 RID: 47424
		// (get) Token: 0x0602A328 RID: 172840 RVA: 0x005C2528 File Offset: 0x005C0728
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

		// Token: 0x1700B941 RID: 47425
		// (get) Token: 0x0602A329 RID: 172841 RVA: 0x005C2564 File Offset: 0x005C0764
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

		// Token: 0x1700B942 RID: 47426
		// (get) Token: 0x0602A32A RID: 172842 RVA: 0x005C25A0 File Offset: 0x005C07A0
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

		// Token: 0x0602A32B RID: 172843 RVA: 0x005C25DC File Offset: 0x005C07DC
		public static Offset<IVehicleGenerateByVehicleEntityTemplate> CreateIVehicleGenerateByVehicleEntityTemplate(FlatBufferBuilder builder, EVehicleGenerationType Type = EVehicleGenerationType.VehicleEntityTemplate, int Id = 0, int Weight = 0)
		{
			builder.StartTable(3);
			IVehicleGenerateByVehicleEntityTemplate.AddWeight(builder, Weight);
			IVehicleGenerateByVehicleEntityTemplate.AddId(builder, Id);
			IVehicleGenerateByVehicleEntityTemplate.AddType(builder, Type);
			return IVehicleGenerateByVehicleEntityTemplate.EndIVehicleGenerateByVehicleEntityTemplate(builder);
		}

		// Token: 0x0602A32C RID: 172844 RVA: 0x005C2600 File Offset: 0x005C0800
		public static void StartIVehicleGenerateByVehicleEntityTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A32D RID: 172845 RVA: 0x005C2609 File Offset: 0x005C0809
		public static void AddType(FlatBufferBuilder builder, EVehicleGenerationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A32E RID: 172846 RVA: 0x005C2614 File Offset: 0x005C0814
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602A32F RID: 172847 RVA: 0x005C261F File Offset: 0x005C081F
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(2, weight, 0);
		}

		// Token: 0x0602A330 RID: 172848 RVA: 0x005C262A File Offset: 0x005C082A
		public static Offset<IVehicleGenerateByVehicleEntityTemplate> EndIVehicleGenerateByVehicleEntityTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleGenerateByVehicleEntityTemplate>(builder.EndTable());
		}

		// Token: 0x0602A331 RID: 172849 RVA: 0x005C2638 File Offset: 0x005C0838
		public IVehicleGenerateByVehicleEntityTemplateT UnPack()
		{
			IVehicleGenerateByVehicleEntityTemplateT vehicleGenerateByVehicleEntityTemplateT = new IVehicleGenerateByVehicleEntityTemplateT();
			this.UnPackTo(vehicleGenerateByVehicleEntityTemplateT);
			return vehicleGenerateByVehicleEntityTemplateT;
		}

		// Token: 0x0602A332 RID: 172850 RVA: 0x005C2653 File Offset: 0x005C0853
		public void UnPackTo(IVehicleGenerateByVehicleEntityTemplateT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Weight = this.Weight;
		}

		// Token: 0x0602A333 RID: 172851 RVA: 0x005C267C File Offset: 0x005C087C
		public static Offset<IVehicleGenerateByVehicleEntityTemplate> Pack(FlatBufferBuilder builder, IVehicleGenerateByVehicleEntityTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleGenerateByVehicleEntityTemplate>);
			}
			return IVehicleGenerateByVehicleEntityTemplate.CreateIVehicleGenerateByVehicleEntityTemplate(builder, _o.Type, _o.Id, _o.Weight);
		}

		// Token: 0x0400FF30 RID: 65328
		private Table __p;
	}
}
