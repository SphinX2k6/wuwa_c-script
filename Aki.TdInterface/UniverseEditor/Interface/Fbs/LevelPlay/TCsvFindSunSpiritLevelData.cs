using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045ED RID: 17901
	public struct TCsvFindSunSpiritLevelData : IFlatbufferObject
	{
		// Token: 0x17007F47 RID: 32583
		// (get) Token: 0x0601B1C9 RID: 111049 RVA: 0x003DD294 File Offset: 0x003DB494
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B1CA RID: 111050 RVA: 0x003DD2A1 File Offset: 0x003DB4A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B1CB RID: 111051 RVA: 0x003DD2A8 File Offset: 0x003DB4A8
		public static TCsvFindSunSpiritLevelData GetRootAsTCsvFindSunSpiritLevelData(ByteBuffer _bb)
		{
			return TCsvFindSunSpiritLevelData.GetRootAsTCsvFindSunSpiritLevelData(_bb, default(TCsvFindSunSpiritLevelData));
		}

		// Token: 0x0601B1CC RID: 111052 RVA: 0x003DD2C4 File Offset: 0x003DB4C4
		public static TCsvFindSunSpiritLevelData GetRootAsTCsvFindSunSpiritLevelData(ByteBuffer _bb, TCsvFindSunSpiritLevelData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B1CD RID: 111053 RVA: 0x003DD2E1 File Offset: 0x003DB4E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B1CE RID: 111054 RVA: 0x003DD2F0 File Offset: 0x003DB4F0
		public TCsvFindSunSpiritLevelData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F48 RID: 32584
		// (get) Token: 0x0601B1CF RID: 111055 RVA: 0x003DD300 File Offset: 0x003DB500
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

		// Token: 0x17007F49 RID: 32585
		// (get) Token: 0x0601B1D0 RID: 111056 RVA: 0x003DD33C File Offset: 0x003DB53C
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

		// Token: 0x0601B1D1 RID: 111057 RVA: 0x003DD399 File Offset: 0x003DB599
		public static Offset<TCsvFindSunSpiritLevelData> CreateTCsvFindSunSpiritLevelData(FlatBufferBuilder builder, int Id = 0, Offset<IFindSunSpiritLevelConfig> DataOffset = default(Offset<IFindSunSpiritLevelConfig>))
		{
			builder.StartTable(2);
			TCsvFindSunSpiritLevelData.AddData(builder, DataOffset);
			TCsvFindSunSpiritLevelData.AddId(builder, Id);
			return TCsvFindSunSpiritLevelData.EndTCsvFindSunSpiritLevelData(builder);
		}

		// Token: 0x0601B1D2 RID: 111058 RVA: 0x003DD3B6 File Offset: 0x003DB5B6
		public static void StartTCsvFindSunSpiritLevelData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B1D3 RID: 111059 RVA: 0x003DD3BF File Offset: 0x003DB5BF
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B1D4 RID: 111060 RVA: 0x003DD3CA File Offset: 0x003DB5CA
		public static void AddData(FlatBufferBuilder builder, Offset<IFindSunSpiritLevelConfig> dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x0601B1D5 RID: 111061 RVA: 0x003DD3DA File Offset: 0x003DB5DA
		public static Offset<TCsvFindSunSpiritLevelData> EndTCsvFindSunSpiritLevelData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvFindSunSpiritLevelData>(builder.EndTable());
		}

		// Token: 0x0601B1D6 RID: 111062 RVA: 0x003DD3E8 File Offset: 0x003DB5E8
		public TCsvFindSunSpiritLevelDataT UnPack()
		{
			TCsvFindSunSpiritLevelDataT tcsvFindSunSpiritLevelDataT = new TCsvFindSunSpiritLevelDataT();
			this.UnPackTo(tcsvFindSunSpiritLevelDataT);
			return tcsvFindSunSpiritLevelDataT;
		}

		// Token: 0x0601B1D7 RID: 111063 RVA: 0x003DD404 File Offset: 0x003DB604
		public void UnPackTo(TCsvFindSunSpiritLevelDataT _o)
		{
			_o.Id = this.Id;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x0601B1D8 RID: 111064 RVA: 0x003DD44C File Offset: 0x003DB64C
		public static Offset<TCsvFindSunSpiritLevelData> Pack(FlatBufferBuilder builder, TCsvFindSunSpiritLevelDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvFindSunSpiritLevelData>);
			}
			Offset<IFindSunSpiritLevelConfig> dataOffset = (_o.Data == null) ? default(Offset<IFindSunSpiritLevelConfig>) : IFindSunSpiritLevelConfig.Pack(builder, _o.Data);
			return TCsvFindSunSpiritLevelData.CreateTCsvFindSunSpiritLevelData(builder, _o.Id, dataOffset);
		}

		// Token: 0x0400C6CF RID: 50895
		private Table __p;
	}
}
