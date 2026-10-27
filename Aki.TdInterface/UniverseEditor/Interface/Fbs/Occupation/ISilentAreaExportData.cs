using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043C8 RID: 17352
	public struct ISilentAreaExportData : IFlatbufferObject
	{
		// Token: 0x17007AB0 RID: 31408
		// (get) Token: 0x06019DF2 RID: 105970 RVA: 0x003B3ECD File Offset: 0x003B20CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019DF3 RID: 105971 RVA: 0x003B3EDA File Offset: 0x003B20DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019DF4 RID: 105972 RVA: 0x003B3EE4 File Offset: 0x003B20E4
		public static ISilentAreaExportData GetRootAsISilentAreaExportData(ByteBuffer _bb)
		{
			return ISilentAreaExportData.GetRootAsISilentAreaExportData(_bb, default(ISilentAreaExportData));
		}

		// Token: 0x06019DF5 RID: 105973 RVA: 0x003B3F00 File Offset: 0x003B2100
		public static ISilentAreaExportData GetRootAsISilentAreaExportData(ByteBuffer _bb, ISilentAreaExportData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019DF6 RID: 105974 RVA: 0x003B3F1D File Offset: 0x003B211D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019DF7 RID: 105975 RVA: 0x003B3F2C File Offset: 0x003B212C
		public ISilentAreaExportData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AB1 RID: 31409
		// (get) Token: 0x06019DF8 RID: 105976 RVA: 0x003B3F3C File Offset: 0x003B213C
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019DF9 RID: 105977 RVA: 0x003B3F73 File Offset: 0x003B2173
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06019DFA RID: 105978 RVA: 0x003B3F82 File Offset: 0x003B2182
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17007AB2 RID: 31410
		// (get) Token: 0x06019DFB RID: 105979 RVA: 0x003B3F90 File Offset: 0x003B2190
		public string NameStringKey
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019DFC RID: 105980 RVA: 0x003B3FC7 File Offset: 0x003B21C7
		public Span<byte> GetNameStringKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06019DFD RID: 105981 RVA: 0x003B3FD6 File Offset: 0x003B21D6
		public byte[] GetNameStringKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17007AB3 RID: 31411
		// (get) Token: 0x06019DFE RID: 105982 RVA: 0x003B3FE4 File Offset: 0x003B21E4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019DFF RID: 105983 RVA: 0x003B401B File Offset: 0x003B221B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019E00 RID: 105984 RVA: 0x003B402A File Offset: 0x003B222A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007AB4 RID: 31412
		// (get) Token: 0x06019E01 RID: 105985 RVA: 0x003B4038 File Offset: 0x003B2238
		public ISilentAreaOccupationData? Data
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISilentAreaOccupationData?(default(ISilentAreaOccupationData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06019E02 RID: 105986 RVA: 0x003B4096 File Offset: 0x003B2296
		public static Offset<ISilentAreaExportData> CreateISilentAreaExportData(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), StringOffset NameStringKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), Offset<ISilentAreaOccupationData> DataOffset = default(Offset<ISilentAreaOccupationData>))
		{
			builder.StartTable(4);
			ISilentAreaExportData.AddData(builder, DataOffset);
			ISilentAreaExportData.AddName(builder, NameOffset);
			ISilentAreaExportData.AddNameStringKey(builder, NameStringKeyOffset);
			ISilentAreaExportData.AddId(builder, IdOffset);
			return ISilentAreaExportData.EndISilentAreaExportData(builder);
		}

		// Token: 0x06019E03 RID: 105987 RVA: 0x003B40C2 File Offset: 0x003B22C2
		public static void StartISilentAreaExportData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019E04 RID: 105988 RVA: 0x003B40CB File Offset: 0x003B22CB
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x06019E05 RID: 105989 RVA: 0x003B40DB File Offset: 0x003B22DB
		public static void AddNameStringKey(FlatBufferBuilder builder, StringOffset nameStringKeyOffset)
		{
			builder.AddOffset(1, nameStringKeyOffset.Value, 0);
		}

		// Token: 0x06019E06 RID: 105990 RVA: 0x003B40EB File Offset: 0x003B22EB
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(2, nameOffset.Value, 0);
		}

		// Token: 0x06019E07 RID: 105991 RVA: 0x003B40FB File Offset: 0x003B22FB
		public static void AddData(FlatBufferBuilder builder, Offset<ISilentAreaOccupationData> dataOffset)
		{
			builder.AddOffset(3, dataOffset.Value, 0);
		}

		// Token: 0x06019E08 RID: 105992 RVA: 0x003B410B File Offset: 0x003B230B
		public static Offset<ISilentAreaExportData> EndISilentAreaExportData(FlatBufferBuilder builder)
		{
			return new Offset<ISilentAreaExportData>(builder.EndTable());
		}

		// Token: 0x06019E09 RID: 105993 RVA: 0x003B4118 File Offset: 0x003B2318
		public ISilentAreaExportDataT UnPack()
		{
			ISilentAreaExportDataT silentAreaExportDataT = new ISilentAreaExportDataT();
			this.UnPackTo(silentAreaExportDataT);
			return silentAreaExportDataT;
		}

		// Token: 0x06019E0A RID: 105994 RVA: 0x003B4134 File Offset: 0x003B2334
		public void UnPackTo(ISilentAreaExportDataT _o)
		{
			_o.Id = this.Id;
			_o.NameStringKey = this.NameStringKey;
			_o.Name = this.Name;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x06019E0B RID: 105995 RVA: 0x003B4194 File Offset: 0x003B2394
		public static Offset<ISilentAreaExportData> Pack(FlatBufferBuilder builder, ISilentAreaExportDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISilentAreaExportData>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			StringOffset nameStringKeyOffset = (_o.NameStringKey == null) ? default(StringOffset) : builder.CreateString(_o.NameStringKey);
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			Offset<ISilentAreaOccupationData> dataOffset = (_o.Data == null) ? default(Offset<ISilentAreaOccupationData>) : ISilentAreaOccupationData.Pack(builder, _o.Data);
			return ISilentAreaExportData.CreateISilentAreaExportData(builder, idOffset, nameStringKeyOffset, nameOffset, dataOffset);
		}

		// Token: 0x0400C214 RID: 49684
		private Table __p;
	}
}
