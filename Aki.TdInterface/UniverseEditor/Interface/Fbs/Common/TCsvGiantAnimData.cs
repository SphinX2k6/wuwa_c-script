using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E72 RID: 24178
	public struct TCsvGiantAnimData : IFlatbufferObject
	{
		// Token: 0x1700B4BE RID: 46270
		// (get) Token: 0x0602969D RID: 169629 RVA: 0x005ACF4C File Offset: 0x005AB14C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602969E RID: 169630 RVA: 0x005ACF59 File Offset: 0x005AB159
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602969F RID: 169631 RVA: 0x005ACF60 File Offset: 0x005AB160
		public static TCsvGiantAnimData GetRootAsTCsvGiantAnimData(ByteBuffer _bb)
		{
			return TCsvGiantAnimData.GetRootAsTCsvGiantAnimData(_bb, default(TCsvGiantAnimData));
		}

		// Token: 0x060296A0 RID: 169632 RVA: 0x005ACF7C File Offset: 0x005AB17C
		public static TCsvGiantAnimData GetRootAsTCsvGiantAnimData(ByteBuffer _bb, TCsvGiantAnimData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060296A1 RID: 169633 RVA: 0x005ACF99 File Offset: 0x005AB199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060296A2 RID: 169634 RVA: 0x005ACFA8 File Offset: 0x005AB1A8
		public TCsvGiantAnimData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4BF RID: 46271
		// (get) Token: 0x060296A3 RID: 169635 RVA: 0x005ACFB8 File Offset: 0x005AB1B8
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

		// Token: 0x1700B4C0 RID: 46272
		// (get) Token: 0x060296A4 RID: 169636 RVA: 0x005ACFF4 File Offset: 0x005AB1F4
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

		// Token: 0x060296A5 RID: 169637 RVA: 0x005AD030 File Offset: 0x005AB230
		public TTable? Data<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060296A6 RID: 169638 RVA: 0x005AD074 File Offset: 0x005AB274
		public IGiantAnimDataType DataAsIGiantAnimDataType()
		{
			return this.Data<IGiantAnimDataType>().Value;
		}

		// Token: 0x060296A7 RID: 169639 RVA: 0x005AD090 File Offset: 0x005AB290
		public IGiantIdleAnimData DataAsIGiantIdleAnimData()
		{
			return this.Data<IGiantIdleAnimData>().Value;
		}

		// Token: 0x060296A8 RID: 169640 RVA: 0x005AD0AC File Offset: 0x005AB2AC
		public IGiantSpecialAnimData DataAsIGiantSpecialAnimData()
		{
			return this.Data<IGiantSpecialAnimData>().Value;
		}

		// Token: 0x060296A9 RID: 169641 RVA: 0x005AD0C7 File Offset: 0x005AB2C7
		public static Offset<TCsvGiantAnimData> CreateTCsvGiantAnimData(FlatBufferBuilder builder, int Id = 0, IGiantAnimDataType_Union Data_type = IGiantAnimDataType_Union.NONE, int DataOffset = 0)
		{
			builder.StartTable(3);
			TCsvGiantAnimData.AddData(builder, DataOffset);
			TCsvGiantAnimData.AddId(builder, Id);
			TCsvGiantAnimData.AddDataType(builder, Data_type);
			return TCsvGiantAnimData.EndTCsvGiantAnimData(builder);
		}

		// Token: 0x060296AA RID: 169642 RVA: 0x005AD0EB File Offset: 0x005AB2EB
		public static void StartTCsvGiantAnimData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060296AB RID: 169643 RVA: 0x005AD0F4 File Offset: 0x005AB2F4
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x060296AC RID: 169644 RVA: 0x005AD0FF File Offset: 0x005AB2FF
		public static void AddDataType(FlatBufferBuilder builder, IGiantAnimDataType_Union dataType)
		{
			builder.AddByte(1, (byte)dataType, 0);
		}

		// Token: 0x060296AD RID: 169645 RVA: 0x005AD10A File Offset: 0x005AB30A
		public static void AddData(FlatBufferBuilder builder, int dataOffset)
		{
			builder.AddOffset(2, dataOffset, 0);
		}

		// Token: 0x060296AE RID: 169646 RVA: 0x005AD115 File Offset: 0x005AB315
		public static Offset<TCsvGiantAnimData> EndTCsvGiantAnimData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvGiantAnimData>(builder.EndTable());
		}

		// Token: 0x060296AF RID: 169647 RVA: 0x005AD124 File Offset: 0x005AB324
		public TCsvGiantAnimDataT UnPack()
		{
			TCsvGiantAnimDataT tcsvGiantAnimDataT = new TCsvGiantAnimDataT();
			this.UnPackTo(tcsvGiantAnimDataT);
			return tcsvGiantAnimDataT;
		}

		// Token: 0x060296B0 RID: 169648 RVA: 0x005AD140 File Offset: 0x005AB340
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

		// Token: 0x060296B1 RID: 169649 RVA: 0x005AD234 File Offset: 0x005AB434
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

		// Token: 0x0400F8A0 RID: 63648
		private Table __p;
	}
}
