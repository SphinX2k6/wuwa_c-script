using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047F6 RID: 18422
	public struct TCsvEffectConfigData : IFlatbufferObject
	{
		// Token: 0x17008463 RID: 33891
		// (get) Token: 0x0601C7E4 RID: 116708 RVA: 0x00407CF8 File Offset: 0x00405EF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C7E5 RID: 116709 RVA: 0x00407D05 File Offset: 0x00405F05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C7E6 RID: 116710 RVA: 0x00407D0C File Offset: 0x00405F0C
		public static TCsvEffectConfigData GetRootAsTCsvEffectConfigData(ByteBuffer _bb)
		{
			return TCsvEffectConfigData.GetRootAsTCsvEffectConfigData(_bb, default(TCsvEffectConfigData));
		}

		// Token: 0x0601C7E7 RID: 116711 RVA: 0x00407D28 File Offset: 0x00405F28
		public static TCsvEffectConfigData GetRootAsTCsvEffectConfigData(ByteBuffer _bb, TCsvEffectConfigData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C7E8 RID: 116712 RVA: 0x00407D45 File Offset: 0x00405F45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C7E9 RID: 116713 RVA: 0x00407D54 File Offset: 0x00405F54
		public TCsvEffectConfigData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008464 RID: 33892
		// (get) Token: 0x0601C7EA RID: 116714 RVA: 0x00407D64 File Offset: 0x00405F64
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

		// Token: 0x17008465 RID: 33893
		// (get) Token: 0x0601C7EB RID: 116715 RVA: 0x00407DA0 File Offset: 0x00405FA0
		public IEffectConfigBase_Union DataType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return IEffectConfigBase_Union.NONE;
				}
				return (IEffectConfigBase_Union)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C7EC RID: 116716 RVA: 0x00407DDC File Offset: 0x00405FDC
		public TTable? Data<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601C7ED RID: 116717 RVA: 0x00407E20 File Offset: 0x00406020
		public IEffectConfigBase DataAsIEffectConfigBase()
		{
			return this.Data<IEffectConfigBase>().Value;
		}

		// Token: 0x0601C7EE RID: 116718 RVA: 0x00407E3C File Offset: 0x0040603C
		public IEffectConfigMonsterDeath DataAsIEffectConfigMonsterDeath()
		{
			return this.Data<IEffectConfigMonsterDeath>().Value;
		}

		// Token: 0x0601C7EF RID: 116719 RVA: 0x00407E58 File Offset: 0x00406058
		public IEffectConfigMonsterDeathGroup DataAsIEffectConfigMonsterDeathGroup()
		{
			return this.Data<IEffectConfigMonsterDeathGroup>().Value;
		}

		// Token: 0x0601C7F0 RID: 116720 RVA: 0x00407E73 File Offset: 0x00406073
		public static Offset<TCsvEffectConfigData> CreateTCsvEffectConfigData(FlatBufferBuilder builder, int Id = 0, IEffectConfigBase_Union Data_type = IEffectConfigBase_Union.NONE, int DataOffset = 0)
		{
			builder.StartTable(3);
			TCsvEffectConfigData.AddData(builder, DataOffset);
			TCsvEffectConfigData.AddId(builder, Id);
			TCsvEffectConfigData.AddDataType(builder, Data_type);
			return TCsvEffectConfigData.EndTCsvEffectConfigData(builder);
		}

		// Token: 0x0601C7F1 RID: 116721 RVA: 0x00407E97 File Offset: 0x00406097
		public static void StartTCsvEffectConfigData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C7F2 RID: 116722 RVA: 0x00407EA0 File Offset: 0x004060A0
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C7F3 RID: 116723 RVA: 0x00407EAB File Offset: 0x004060AB
		public static void AddDataType(FlatBufferBuilder builder, IEffectConfigBase_Union dataType)
		{
			builder.AddByte(1, (byte)dataType, 0);
		}

		// Token: 0x0601C7F4 RID: 116724 RVA: 0x00407EB6 File Offset: 0x004060B6
		public static void AddData(FlatBufferBuilder builder, int dataOffset)
		{
			builder.AddOffset(2, dataOffset, 0);
		}

		// Token: 0x0601C7F5 RID: 116725 RVA: 0x00407EC1 File Offset: 0x004060C1
		public static Offset<TCsvEffectConfigData> EndTCsvEffectConfigData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvEffectConfigData>(builder.EndTable());
		}

		// Token: 0x0601C7F6 RID: 116726 RVA: 0x00407ED0 File Offset: 0x004060D0
		public TCsvEffectConfigDataT UnPack()
		{
			TCsvEffectConfigDataT tcsvEffectConfigDataT = new TCsvEffectConfigDataT();
			this.UnPackTo(tcsvEffectConfigDataT);
			return tcsvEffectConfigDataT;
		}

		// Token: 0x0601C7F7 RID: 116727 RVA: 0x00407EEC File Offset: 0x004060EC
		public void UnPackTo(TCsvEffectConfigDataT _o)
		{
			_o.Id = this.Id;
			_o.Data = new IEffectConfigBase_UnionUnion();
			_o.Data.Type = this.DataType;
			switch (this.DataType)
			{
			case IEffectConfigBase_Union.IEffectConfigBase:
				_o.Data.Value = ((this.Data<IEffectConfigBase>() != null) ? this.Data<IEffectConfigBase>().Value.UnPack() : null);
				return;
			case IEffectConfigBase_Union.IEffectConfigMonsterDeath:
				_o.Data.Value = ((this.Data<IEffectConfigMonsterDeath>() != null) ? this.Data<IEffectConfigMonsterDeath>().Value.UnPack() : null);
				return;
			case IEffectConfigBase_Union.IEffectConfigMonsterDeathGroup:
				_o.Data.Value = ((this.Data<IEffectConfigMonsterDeathGroup>() != null) ? this.Data<IEffectConfigMonsterDeathGroup>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601C7F8 RID: 116728 RVA: 0x00407FE0 File Offset: 0x004061E0
		public static Offset<TCsvEffectConfigData> Pack(FlatBufferBuilder builder, TCsvEffectConfigDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvEffectConfigData>);
			}
			IEffectConfigBase_Union data_type = (_o.Data == null) ? IEffectConfigBase_Union.NONE : _o.Data.Type;
			int dataOffset = (_o.Data == null) ? 0 : IEffectConfigBase_UnionUnion.Pack(builder, _o.Data);
			return TCsvEffectConfigData.CreateTCsvEffectConfigData(builder, _o.Id, data_type, dataOffset);
		}

		// Token: 0x0400CC8D RID: 52365
		private Table __p;
	}
}
