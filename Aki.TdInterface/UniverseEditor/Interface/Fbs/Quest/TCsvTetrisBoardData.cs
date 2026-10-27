using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C6 RID: 17094
	public struct TCsvTetrisBoardData : IFlatbufferObject
	{
		// Token: 0x17007939 RID: 31033
		// (get) Token: 0x060195AB RID: 103851 RVA: 0x003A36A6 File Offset: 0x003A18A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060195AC RID: 103852 RVA: 0x003A36B3 File Offset: 0x003A18B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060195AD RID: 103853 RVA: 0x003A36BC File Offset: 0x003A18BC
		public static TCsvTetrisBoardData GetRootAsTCsvTetrisBoardData(ByteBuffer _bb)
		{
			return TCsvTetrisBoardData.GetRootAsTCsvTetrisBoardData(_bb, default(TCsvTetrisBoardData));
		}

		// Token: 0x060195AE RID: 103854 RVA: 0x003A36D8 File Offset: 0x003A18D8
		public static TCsvTetrisBoardData GetRootAsTCsvTetrisBoardData(ByteBuffer _bb, TCsvTetrisBoardData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060195AF RID: 103855 RVA: 0x003A36F5 File Offset: 0x003A18F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060195B0 RID: 103856 RVA: 0x003A3704 File Offset: 0x003A1904
		public TCsvTetrisBoardData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700793A RID: 31034
		// (get) Token: 0x060195B1 RID: 103857 RVA: 0x003A3714 File Offset: 0x003A1914
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

		// Token: 0x1700793B RID: 31035
		// (get) Token: 0x060195B2 RID: 103858 RVA: 0x003A3750 File Offset: 0x003A1950
		public ITetrisBoard? Data
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITetrisBoard?(default(ITetrisBoard).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060195B3 RID: 103859 RVA: 0x003A37AD File Offset: 0x003A19AD
		public static Offset<TCsvTetrisBoardData> CreateTCsvTetrisBoardData(FlatBufferBuilder builder, int Id = 0, Offset<ITetrisBoard> DataOffset = default(Offset<ITetrisBoard>))
		{
			builder.StartTable(2);
			TCsvTetrisBoardData.AddData(builder, DataOffset);
			TCsvTetrisBoardData.AddId(builder, Id);
			return TCsvTetrisBoardData.EndTCsvTetrisBoardData(builder);
		}

		// Token: 0x060195B4 RID: 103860 RVA: 0x003A37CA File Offset: 0x003A19CA
		public static void StartTCsvTetrisBoardData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060195B5 RID: 103861 RVA: 0x003A37D3 File Offset: 0x003A19D3
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x060195B6 RID: 103862 RVA: 0x003A37DE File Offset: 0x003A19DE
		public static void AddData(FlatBufferBuilder builder, Offset<ITetrisBoard> dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x060195B7 RID: 103863 RVA: 0x003A37EE File Offset: 0x003A19EE
		public static Offset<TCsvTetrisBoardData> EndTCsvTetrisBoardData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvTetrisBoardData>(builder.EndTable());
		}

		// Token: 0x060195B8 RID: 103864 RVA: 0x003A37FC File Offset: 0x003A19FC
		public TCsvTetrisBoardDataT UnPack()
		{
			TCsvTetrisBoardDataT tcsvTetrisBoardDataT = new TCsvTetrisBoardDataT();
			this.UnPackTo(tcsvTetrisBoardDataT);
			return tcsvTetrisBoardDataT;
		}

		// Token: 0x060195B9 RID: 103865 RVA: 0x003A3818 File Offset: 0x003A1A18
		public void UnPackTo(TCsvTetrisBoardDataT _o)
		{
			_o.Id = this.Id;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x060195BA RID: 103866 RVA: 0x003A3860 File Offset: 0x003A1A60
		public static Offset<TCsvTetrisBoardData> Pack(FlatBufferBuilder builder, TCsvTetrisBoardDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvTetrisBoardData>);
			}
			Offset<ITetrisBoard> dataOffset = (_o.Data == null) ? default(Offset<ITetrisBoard>) : ITetrisBoard.Pack(builder, _o.Data);
			return TCsvTetrisBoardData.CreateTCsvTetrisBoardData(builder, _o.Id, dataOffset);
		}

		// Token: 0x0400BFCD RID: 49101
		private Table __p;
	}
}
