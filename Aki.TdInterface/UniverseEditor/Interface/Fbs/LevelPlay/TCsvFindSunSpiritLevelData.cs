using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A55 RID: 19029
	public struct TCsvFindSunSpiritLevelData : IFlatbufferObject
	{
		// Token: 0x17008588 RID: 34184
		// (get) Token: 0x0601C99E RID: 117150 RVA: 0x00409530 File Offset: 0x00407730
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C99F RID: 117151 RVA: 0x0040953D File Offset: 0x0040773D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C9A0 RID: 117152 RVA: 0x00409544 File Offset: 0x00407744
		public static TCsvFindSunSpiritLevelData GetRootAsTCsvFindSunSpiritLevelData(ByteBuffer _bb)
		{
			return TCsvFindSunSpiritLevelData.GetRootAsTCsvFindSunSpiritLevelData(_bb, default(TCsvFindSunSpiritLevelData));
		}

		// Token: 0x0601C9A1 RID: 117153 RVA: 0x00409560 File Offset: 0x00407760
		public static TCsvFindSunSpiritLevelData GetRootAsTCsvFindSunSpiritLevelData(ByteBuffer _bb, TCsvFindSunSpiritLevelData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C9A2 RID: 117154 RVA: 0x0040957D File Offset: 0x0040777D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C9A3 RID: 117155 RVA: 0x0040958C File Offset: 0x0040778C
		public TCsvFindSunSpiritLevelData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008589 RID: 34185
		// (get) Token: 0x0601C9A4 RID: 117156 RVA: 0x0040959C File Offset: 0x0040779C
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

		// Token: 0x1700858A RID: 34186
		// (get) Token: 0x0601C9A5 RID: 117157 RVA: 0x004095D8 File Offset: 0x004077D8
		public IFindSunSpiritLevelConfig? Data
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFindSunSpiritLevelConfig?(default(IFindSunSpiritLevelConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601C9A6 RID: 117158 RVA: 0x00409635 File Offset: 0x00407835
		public static Offset<TCsvFindSunSpiritLevelData> CreateTCsvFindSunSpiritLevelData(FlatBufferBuilder builder, int Id = 0, Offset<IFindSunSpiritLevelConfig> DataOffset = default(Offset<IFindSunSpiritLevelConfig>))
		{
			builder.StartTable(2);
			TCsvFindSunSpiritLevelData.AddData(builder, DataOffset);
			TCsvFindSunSpiritLevelData.AddId(builder, Id);
			return TCsvFindSunSpiritLevelData.EndTCsvFindSunSpiritLevelData(builder);
		}

		// Token: 0x0601C9A7 RID: 117159 RVA: 0x00409652 File Offset: 0x00407852
		public static void StartTCsvFindSunSpiritLevelData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C9A8 RID: 117160 RVA: 0x0040965B File Offset: 0x0040785B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C9A9 RID: 117161 RVA: 0x00409666 File Offset: 0x00407866
		public static void AddData(FlatBufferBuilder builder, Offset<IFindSunSpiritLevelConfig> dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x0601C9AA RID: 117162 RVA: 0x00409676 File Offset: 0x00407876
		public static Offset<TCsvFindSunSpiritLevelData> EndTCsvFindSunSpiritLevelData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvFindSunSpiritLevelData>(builder.EndTable());
		}

		// Token: 0x0601C9AB RID: 117163 RVA: 0x00409684 File Offset: 0x00407884
		public TCsvFindSunSpiritLevelDataT UnPack()
		{
			TCsvFindSunSpiritLevelDataT tcsvFindSunSpiritLevelDataT = new TCsvFindSunSpiritLevelDataT();
			this.UnPackTo(tcsvFindSunSpiritLevelDataT);
			return tcsvFindSunSpiritLevelDataT;
		}

		// Token: 0x0601C9AC RID: 117164 RVA: 0x004096A0 File Offset: 0x004078A0
		public void UnPackTo(TCsvFindSunSpiritLevelDataT _o)
		{
			_o.Id = this.Id;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x0601C9AD RID: 117165 RVA: 0x004096E8 File Offset: 0x004078E8
		public static Offset<TCsvFindSunSpiritLevelData> Pack(FlatBufferBuilder builder, TCsvFindSunSpiritLevelDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvFindSunSpiritLevelData>);
			}
			Offset<IFindSunSpiritLevelConfig> dataOffset = (_o.Data == null) ? default(Offset<IFindSunSpiritLevelConfig>) : IFindSunSpiritLevelConfig.Pack(builder, _o.Data);
			return TCsvFindSunSpiritLevelData.CreateTCsvFindSunSpiritLevelData(builder, _o.Id, dataOffset);
		}

		// Token: 0x0400D0FE RID: 53502
		private Table __p;
	}
}
