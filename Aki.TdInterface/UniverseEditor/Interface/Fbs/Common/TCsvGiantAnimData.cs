using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064B5 RID: 25781
	public struct TCsvGiantAnimData : IFlatbufferObject
	{
		// Token: 0x1700BE29 RID: 48681
		// (get) Token: 0x0602BD45 RID: 179525 RVA: 0x005F5EF0 File Offset: 0x005F40F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BD46 RID: 179526 RVA: 0x005F5EFD File Offset: 0x005F40FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BD47 RID: 179527 RVA: 0x005F5F04 File Offset: 0x005F4104
		public static TCsvGiantAnimData GetRootAsTCsvGiantAnimData(ByteBuffer _bb)
		{
			return TCsvGiantAnimData.GetRootAsTCsvGiantAnimData(_bb, default(TCsvGiantAnimData));
		}

		// Token: 0x0602BD48 RID: 179528 RVA: 0x005F5F20 File Offset: 0x005F4120
		public static TCsvGiantAnimData GetRootAsTCsvGiantAnimData(ByteBuffer _bb, TCsvGiantAnimData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BD49 RID: 179529 RVA: 0x005F5F3D File Offset: 0x005F413D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BD4A RID: 179530 RVA: 0x005F5F4C File Offset: 0x005F414C
		public TCsvGiantAnimData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE2A RID: 48682
		// (get) Token: 0x0602BD4B RID: 179531 RVA: 0x005F5F5C File Offset: 0x005F415C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BE2B RID: 48683
		// (get) Token: 0x0602BD4C RID: 179532 RVA: 0x005F5F98 File Offset: 0x005F4198
		public IGiantAnimDataType_Union DataType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return IGiantAnimDataType_Union.NONE;
				}
				return (IGiantAnimDataType_Union)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BD4D RID: 179533 RVA: 0x005F5FD4 File Offset: 0x005F41D4
		public TTable? Data<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602BD4E RID: 179534 RVA: 0x005F6018 File Offset: 0x005F4218
		public IGiantAnimDataType DataAsIGiantAnimDataType()
		{
			return this.Data<IGiantAnimDataType>().Value;
		}

		// Token: 0x0602BD4F RID: 179535 RVA: 0x005F6034 File Offset: 0x005F4234
		public IGiantIdleAnimData DataAsIGiantIdleAnimData()
		{
			return this.Data<IGiantIdleAnimData>().Value;
		}

		// Token: 0x0602BD50 RID: 179536 RVA: 0x005F6050 File Offset: 0x005F4250
		public IGiantSpecialAnimData DataAsIGiantSpecialAnimData()
		{
			return this.Data<IGiantSpecialAnimData>().Value;
		}

		// Token: 0x0602BD51 RID: 179537 RVA: 0x005F606B File Offset: 0x005F426B
		public static Offset<TCsvGiantAnimData> CreateTCsvGiantAnimData(FlatBufferBuilder builder, int Id = 0, IGiantAnimDataType_Union Data_type = IGiantAnimDataType_Union.NONE, int DataOffset = 0)
		{
			builder.StartTable(3);
			TCsvGiantAnimData.AddData(builder, DataOffset);
			TCsvGiantAnimData.AddId(builder, Id);
			TCsvGiantAnimData.AddDataType(builder, Data_type);
			return TCsvGiantAnimData.EndTCsvGiantAnimData(builder);
		}

		// Token: 0x0602BD52 RID: 179538 RVA: 0x005F608F File Offset: 0x005F428F
		public static void StartTCsvGiantAnimData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BD53 RID: 179539 RVA: 0x005F6098 File Offset: 0x005F4298
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602BD54 RID: 179540 RVA: 0x005F60A3 File Offset: 0x005F42A3
		public static void AddDataType(FlatBufferBuilder builder, IGiantAnimDataType_Union dataType)
		{
			builder.AddByte(1, (byte)dataType, 0);
		}

		// Token: 0x0602BD55 RID: 179541 RVA: 0x005F60AE File Offset: 0x005F42AE
		public static void AddData(FlatBufferBuilder builder, int dataOffset)
		{
			builder.AddOffset(2, dataOffset, 0);
		}

		// Token: 0x0602BD56 RID: 179542 RVA: 0x005F60B9 File Offset: 0x005F42B9
		public static Offset<TCsvGiantAnimData> EndTCsvGiantAnimData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvGiantAnimData>(builder.EndTable());
		}

		// Token: 0x0602BD57 RID: 179543 RVA: 0x005F60C8 File Offset: 0x005F42C8
		public TCsvGiantAnimDataT UnPack()
		{
			TCsvGiantAnimDataT tcsvGiantAnimDataT = new TCsvGiantAnimDataT();
			this.UnPackTo(tcsvGiantAnimDataT);
			return tcsvGiantAnimDataT;
		}

		// Token: 0x0602BD58 RID: 179544 RVA: 0x005F60E4 File Offset: 0x005F42E4
		public void UnPackTo(TCsvGiantAnimDataT _o)
		{
			_o.Id = this.Id;
			_o.Data = new IGiantAnimDataType_UnionUnion();
			_o.Data.Type = this.DataType;
			switch (this.DataType)
			{
			case IGiantAnimDataType_Union.IGiantAnimDataType:
				_o.Data.Value = ((this.Data<IGiantAnimDataType>() != null) ? this.Data<IGiantAnimDataType>().Value.UnPack() : null);
				return;
			case IGiantAnimDataType_Union.IGiantIdleAnimData:
				_o.Data.Value = ((this.Data<IGiantIdleAnimData>() != null) ? this.Data<IGiantIdleAnimData>().Value.UnPack() : null);
				return;
			case IGiantAnimDataType_Union.IGiantSpecialAnimData:
				_o.Data.Value = ((this.Data<IGiantSpecialAnimData>() != null) ? this.Data<IGiantSpecialAnimData>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602BD59 RID: 179545 RVA: 0x005F61D8 File Offset: 0x005F43D8
		public static Offset<TCsvGiantAnimData> Pack(FlatBufferBuilder builder, TCsvGiantAnimDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvGiantAnimData>);
			}
			IGiantAnimDataType_Union data_type = (_o.Data == null) ? IGiantAnimDataType_Union.NONE : _o.Data.Type;
			int dataOffset = (_o.Data == null) ? 0 : IGiantAnimDataType_UnionUnion.Pack(builder, _o.Data);
			return TCsvGiantAnimData.CreateTCsvGiantAnimData(builder, _o.Id, data_type, dataOffset);
		}

		// Token: 0x04010603 RID: 67075
		private Table __p;
	}
}
