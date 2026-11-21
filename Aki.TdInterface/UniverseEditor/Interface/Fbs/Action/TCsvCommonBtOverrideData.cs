using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EA3 RID: 32419
	public struct TCsvCommonBtOverrideData : IFlatbufferObject
	{
		// Token: 0x1700F235 RID: 62005
		// (get) Token: 0x0603A87B RID: 239739 RVA: 0x007E083E File Offset: 0x007DEA3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A87C RID: 239740 RVA: 0x007E084B File Offset: 0x007DEA4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A87D RID: 239741 RVA: 0x007E0854 File Offset: 0x007DEA54
		public static TCsvCommonBtOverrideData GetRootAsTCsvCommonBtOverrideData(ByteBuffer _bb)
		{
			return TCsvCommonBtOverrideData.GetRootAsTCsvCommonBtOverrideData(_bb, default(TCsvCommonBtOverrideData));
		}

		// Token: 0x0603A87E RID: 239742 RVA: 0x007E0870 File Offset: 0x007DEA70
		public static TCsvCommonBtOverrideData GetRootAsTCsvCommonBtOverrideData(ByteBuffer _bb, TCsvCommonBtOverrideData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A87F RID: 239743 RVA: 0x007E088D File Offset: 0x007DEA8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A880 RID: 239744 RVA: 0x007E089C File Offset: 0x007DEA9C
		public TCsvCommonBtOverrideData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F236 RID: 62006
		// (get) Token: 0x0603A881 RID: 239745 RVA: 0x007E08AC File Offset: 0x007DEAAC
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

		// Token: 0x1700F237 RID: 62007
		// (get) Token: 0x0603A882 RID: 239746 RVA: 0x007E08E8 File Offset: 0x007DEAE8
		public ICommonBtOverride? Data
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICommonBtOverride?(default(ICommonBtOverride).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603A883 RID: 239747 RVA: 0x007E0945 File Offset: 0x007DEB45
		public static Offset<TCsvCommonBtOverrideData> CreateTCsvCommonBtOverrideData(FlatBufferBuilder builder, int Id = 0, Offset<ICommonBtOverride> DataOffset = default(Offset<ICommonBtOverride>))
		{
			builder.StartTable(2);
			TCsvCommonBtOverrideData.AddData(builder, DataOffset);
			TCsvCommonBtOverrideData.AddId(builder, Id);
			return TCsvCommonBtOverrideData.EndTCsvCommonBtOverrideData(builder);
		}

		// Token: 0x0603A884 RID: 239748 RVA: 0x007E0962 File Offset: 0x007DEB62
		public static void StartTCsvCommonBtOverrideData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A885 RID: 239749 RVA: 0x007E096B File Offset: 0x007DEB6B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0603A886 RID: 239750 RVA: 0x007E0976 File Offset: 0x007DEB76
		public static void AddData(FlatBufferBuilder builder, Offset<ICommonBtOverride> dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x0603A887 RID: 239751 RVA: 0x007E0986 File Offset: 0x007DEB86
		public static Offset<TCsvCommonBtOverrideData> EndTCsvCommonBtOverrideData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvCommonBtOverrideData>(builder.EndTable());
		}

		// Token: 0x0603A888 RID: 239752 RVA: 0x007E0994 File Offset: 0x007DEB94
		public TCsvCommonBtOverrideDataT UnPack()
		{
			TCsvCommonBtOverrideDataT tcsvCommonBtOverrideDataT = new TCsvCommonBtOverrideDataT();
			this.UnPackTo(tcsvCommonBtOverrideDataT);
			return tcsvCommonBtOverrideDataT;
		}

		// Token: 0x0603A889 RID: 239753 RVA: 0x007E09B0 File Offset: 0x007DEBB0
		public void UnPackTo(TCsvCommonBtOverrideDataT _o)
		{
			_o.Id = this.Id;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x0603A88A RID: 239754 RVA: 0x007E09F8 File Offset: 0x007DEBF8
		public static Offset<TCsvCommonBtOverrideData> Pack(FlatBufferBuilder builder, TCsvCommonBtOverrideDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvCommonBtOverrideData>);
			}
			Offset<ICommonBtOverride> dataOffset = (_o.Data == null) ? default(Offset<ICommonBtOverride>) : ICommonBtOverride.Pack(builder, _o.Data);
			return TCsvCommonBtOverrideData.CreateTCsvCommonBtOverrideData(builder, _o.Id, dataOffset);
		}

		// Token: 0x0401370D RID: 79629
		private Table __p;
	}
}
