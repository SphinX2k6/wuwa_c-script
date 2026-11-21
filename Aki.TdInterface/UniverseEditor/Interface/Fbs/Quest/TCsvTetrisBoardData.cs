using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004722 RID: 18210
	public struct TCsvTetrisBoardData : IFlatbufferObject
	{
		// Token: 0x17007F6A RID: 32618
		// (get) Token: 0x0601AD17 RID: 109847 RVA: 0x003CED7E File Offset: 0x003CCF7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AD18 RID: 109848 RVA: 0x003CED8B File Offset: 0x003CCF8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AD19 RID: 109849 RVA: 0x003CED94 File Offset: 0x003CCF94
		public static TCsvTetrisBoardData GetRootAsTCsvTetrisBoardData(ByteBuffer _bb)
		{
			return TCsvTetrisBoardData.GetRootAsTCsvTetrisBoardData(_bb, default(TCsvTetrisBoardData));
		}

		// Token: 0x0601AD1A RID: 109850 RVA: 0x003CEDB0 File Offset: 0x003CCFB0
		public static TCsvTetrisBoardData GetRootAsTCsvTetrisBoardData(ByteBuffer _bb, TCsvTetrisBoardData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AD1B RID: 109851 RVA: 0x003CEDCD File Offset: 0x003CCFCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AD1C RID: 109852 RVA: 0x003CEDDC File Offset: 0x003CCFDC
		public TCsvTetrisBoardData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F6B RID: 32619
		// (get) Token: 0x0601AD1D RID: 109853 RVA: 0x003CEDEC File Offset: 0x003CCFEC
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

		// Token: 0x17007F6C RID: 32620
		// (get) Token: 0x0601AD1E RID: 109854 RVA: 0x003CEE28 File Offset: 0x003CD028
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

		// Token: 0x0601AD1F RID: 109855 RVA: 0x003CEE85 File Offset: 0x003CD085
		public static Offset<TCsvTetrisBoardData> CreateTCsvTetrisBoardData(FlatBufferBuilder builder, int Id = 0, Offset<ITetrisBoard> DataOffset = default(Offset<ITetrisBoard>))
		{
			builder.StartTable(2);
			TCsvTetrisBoardData.AddData(builder, DataOffset);
			TCsvTetrisBoardData.AddId(builder, Id);
			return TCsvTetrisBoardData.EndTCsvTetrisBoardData(builder);
		}

		// Token: 0x0601AD20 RID: 109856 RVA: 0x003CEEA2 File Offset: 0x003CD0A2
		public static void StartTCsvTetrisBoardData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AD21 RID: 109857 RVA: 0x003CEEAB File Offset: 0x003CD0AB
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601AD22 RID: 109858 RVA: 0x003CEEB6 File Offset: 0x003CD0B6
		public static void AddData(FlatBufferBuilder builder, Offset<ITetrisBoard> dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x0601AD23 RID: 109859 RVA: 0x003CEEC6 File Offset: 0x003CD0C6
		public static Offset<TCsvTetrisBoardData> EndTCsvTetrisBoardData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvTetrisBoardData>(builder.EndTable());
		}

		// Token: 0x0601AD24 RID: 109860 RVA: 0x003CEED4 File Offset: 0x003CD0D4
		public TCsvTetrisBoardDataT UnPack()
		{
			TCsvTetrisBoardDataT tcsvTetrisBoardDataT = new TCsvTetrisBoardDataT();
			this.UnPackTo(tcsvTetrisBoardDataT);
			return tcsvTetrisBoardDataT;
		}

		// Token: 0x0601AD25 RID: 109861 RVA: 0x003CEEF0 File Offset: 0x003CD0F0
		public void UnPackTo(TCsvTetrisBoardDataT _o)
		{
			_o.Id = this.Id;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x0601AD26 RID: 109862 RVA: 0x003CEF38 File Offset: 0x003CD138
		public static Offset<TCsvTetrisBoardData> Pack(FlatBufferBuilder builder, TCsvTetrisBoardDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvTetrisBoardData>);
			}
			Offset<ITetrisBoard> dataOffset = (_o.Data == null) ? default(Offset<ITetrisBoard>) : ITetrisBoard.Pack(builder, _o.Data);
			return TCsvTetrisBoardData.CreateTCsvTetrisBoardData(builder, _o.Id, dataOffset);
		}

		// Token: 0x0400C9DA RID: 51674
		private Table __p;
	}
}
