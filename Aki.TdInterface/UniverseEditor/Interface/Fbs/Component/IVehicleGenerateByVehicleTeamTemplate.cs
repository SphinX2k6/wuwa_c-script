using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200612D RID: 24877
	public struct IVehicleGenerateByVehicleTeamTemplate : IFlatbufferObject
	{
		// Token: 0x1700B946 RID: 47430
		// (get) Token: 0x0602A33C RID: 172860 RVA: 0x005C274C File Offset: 0x005C094C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A33D RID: 172861 RVA: 0x005C2759 File Offset: 0x005C0959
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A33E RID: 172862 RVA: 0x005C2760 File Offset: 0x005C0960
		public static IVehicleGenerateByVehicleTeamTemplate GetRootAsIVehicleGenerateByVehicleTeamTemplate(ByteBuffer _bb)
		{
			return IVehicleGenerateByVehicleTeamTemplate.GetRootAsIVehicleGenerateByVehicleTeamTemplate(_bb, default(IVehicleGenerateByVehicleTeamTemplate));
		}

		// Token: 0x0602A33F RID: 172863 RVA: 0x005C277C File Offset: 0x005C097C
		public static IVehicleGenerateByVehicleTeamTemplate GetRootAsIVehicleGenerateByVehicleTeamTemplate(ByteBuffer _bb, IVehicleGenerateByVehicleTeamTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A340 RID: 172864 RVA: 0x005C2799 File Offset: 0x005C0999
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A341 RID: 172865 RVA: 0x005C27A8 File Offset: 0x005C09A8
		public IVehicleGenerateByVehicleTeamTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B947 RID: 47431
		// (get) Token: 0x0602A342 RID: 172866 RVA: 0x005C27B8 File Offset: 0x005C09B8
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

		// Token: 0x1700B948 RID: 47432
		// (get) Token: 0x0602A343 RID: 172867 RVA: 0x005C27F4 File Offset: 0x005C09F4
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

		// Token: 0x1700B949 RID: 47433
		// (get) Token: 0x0602A344 RID: 172868 RVA: 0x005C2830 File Offset: 0x005C0A30
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

		// Token: 0x0602A345 RID: 172869 RVA: 0x005C286C File Offset: 0x005C0A6C
		public static Offset<IVehicleGenerateByVehicleTeamTemplate> CreateIVehicleGenerateByVehicleTeamTemplate(FlatBufferBuilder builder, EVehicleGenerationType Type = EVehicleGenerationType.VehicleEntityTemplate, int Id = 0, int Weight = 0)
		{
			builder.StartTable(3);
			IVehicleGenerateByVehicleTeamTemplate.AddWeight(builder, Weight);
			IVehicleGenerateByVehicleTeamTemplate.AddId(builder, Id);
			IVehicleGenerateByVehicleTeamTemplate.AddType(builder, Type);
			return IVehicleGenerateByVehicleTeamTemplate.EndIVehicleGenerateByVehicleTeamTemplate(builder);
		}

		// Token: 0x0602A346 RID: 172870 RVA: 0x005C2890 File Offset: 0x005C0A90
		public static void StartIVehicleGenerateByVehicleTeamTemplate(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A347 RID: 172871 RVA: 0x005C2899 File Offset: 0x005C0A99
		public static void AddType(FlatBufferBuilder builder, EVehicleGenerationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A348 RID: 172872 RVA: 0x005C28A4 File Offset: 0x005C0AA4
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602A349 RID: 172873 RVA: 0x005C28AF File Offset: 0x005C0AAF
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(2, weight, 0);
		}

		// Token: 0x0602A34A RID: 172874 RVA: 0x005C28BA File Offset: 0x005C0ABA
		public static Offset<IVehicleGenerateByVehicleTeamTemplate> EndIVehicleGenerateByVehicleTeamTemplate(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleGenerateByVehicleTeamTemplate>(builder.EndTable());
		}

		// Token: 0x0602A34B RID: 172875 RVA: 0x005C28C8 File Offset: 0x005C0AC8
		public IVehicleGenerateByVehicleTeamTemplateT UnPack()
		{
			IVehicleGenerateByVehicleTeamTemplateT vehicleGenerateByVehicleTeamTemplateT = new IVehicleGenerateByVehicleTeamTemplateT();
			this.UnPackTo(vehicleGenerateByVehicleTeamTemplateT);
			return vehicleGenerateByVehicleTeamTemplateT;
		}

		// Token: 0x0602A34C RID: 172876 RVA: 0x005C28E3 File Offset: 0x005C0AE3
		public void UnPackTo(IVehicleGenerateByVehicleTeamTemplateT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Weight = this.Weight;
		}

		// Token: 0x0602A34D RID: 172877 RVA: 0x005C290C File Offset: 0x005C0B0C
		public static Offset<IVehicleGenerateByVehicleTeamTemplate> Pack(FlatBufferBuilder builder, IVehicleGenerateByVehicleTeamTemplateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleGenerateByVehicleTeamTemplate>);
			}
			return IVehicleGenerateByVehicleTeamTemplate.CreateIVehicleGenerateByVehicleTeamTemplate(builder, _o.Type, _o.Id, _o.Weight);
		}

		// Token: 0x0400FF34 RID: 65332
		private Table __p;
	}
}
