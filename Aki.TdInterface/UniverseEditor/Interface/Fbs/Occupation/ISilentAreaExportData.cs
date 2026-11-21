using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200482D RID: 18477
	public struct ISilentAreaExportData : IFlatbufferObject
	{
		// Token: 0x170080EA RID: 33002
		// (get) Token: 0x0601B59F RID: 112031 RVA: 0x003DFCDD File Offset: 0x003DDEDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B5A0 RID: 112032 RVA: 0x003DFCEA File Offset: 0x003DDEEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B5A1 RID: 112033 RVA: 0x003DFCF4 File Offset: 0x003DDEF4
		public static ISilentAreaExportData GetRootAsISilentAreaExportData(ByteBuffer _bb)
		{
			return ISilentAreaExportData.GetRootAsISilentAreaExportData(_bb, default(ISilentAreaExportData));
		}

		// Token: 0x0601B5A2 RID: 112034 RVA: 0x003DFD10 File Offset: 0x003DDF10
		public static ISilentAreaExportData GetRootAsISilentAreaExportData(ByteBuffer _bb, ISilentAreaExportData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B5A3 RID: 112035 RVA: 0x003DFD2D File Offset: 0x003DDF2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B5A4 RID: 112036 RVA: 0x003DFD3C File Offset: 0x003DDF3C
		public ISilentAreaExportData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080EB RID: 33003
		// (get) Token: 0x0601B5A5 RID: 112037 RVA: 0x003DFD4C File Offset: 0x003DDF4C
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

		// Token: 0x0601B5A6 RID: 112038 RVA: 0x003DFD83 File Offset: 0x003DDF83
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601B5A7 RID: 112039 RVA: 0x003DFD92 File Offset: 0x003DDF92
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170080EC RID: 33004
		// (get) Token: 0x0601B5A8 RID: 112040 RVA: 0x003DFDA0 File Offset: 0x003DDFA0
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

		// Token: 0x0601B5A9 RID: 112041 RVA: 0x003DFDD7 File Offset: 0x003DDFD7
		public Span<byte> GetNameStringKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601B5AA RID: 112042 RVA: 0x003DFDE6 File Offset: 0x003DDFE6
		public byte[] GetNameStringKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170080ED RID: 33005
		// (get) Token: 0x0601B5AB RID: 112043 RVA: 0x003DFDF4 File Offset: 0x003DDFF4
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

		// Token: 0x0601B5AC RID: 112044 RVA: 0x003DFE2B File Offset: 0x003DE02B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B5AD RID: 112045 RVA: 0x003DFE3A File Offset: 0x003DE03A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170080EE RID: 33006
		// (get) Token: 0x0601B5AE RID: 112046 RVA: 0x003DFE48 File Offset: 0x003DE048
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

		// Token: 0x0601B5AF RID: 112047 RVA: 0x003DFEA6 File Offset: 0x003DE0A6
		public static Offset<ISilentAreaExportData> CreateISilentAreaExportData(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), StringOffset NameStringKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), Offset<ISilentAreaOccupationData> DataOffset = default(Offset<ISilentAreaOccupationData>))
		{
			builder.StartTable(4);
			ISilentAreaExportData.AddData(builder, DataOffset);
			ISilentAreaExportData.AddName(builder, NameOffset);
			ISilentAreaExportData.AddNameStringKey(builder, NameStringKeyOffset);
			ISilentAreaExportData.AddId(builder, IdOffset);
			return ISilentAreaExportData.EndISilentAreaExportData(builder);
		}

		// Token: 0x0601B5B0 RID: 112048 RVA: 0x003DFED2 File Offset: 0x003DE0D2
		public static void StartISilentAreaExportData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B5B1 RID: 112049 RVA: 0x003DFEDB File Offset: 0x003DE0DB
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x0601B5B2 RID: 112050 RVA: 0x003DFEEB File Offset: 0x003DE0EB
		public static void AddNameStringKey(FlatBufferBuilder builder, StringOffset nameStringKeyOffset)
		{
			builder.AddOffset(1, nameStringKeyOffset.Value, 0);
		}

		// Token: 0x0601B5B3 RID: 112051 RVA: 0x003DFEFB File Offset: 0x003DE0FB
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(2, nameOffset.Value, 0);
		}

		// Token: 0x0601B5B4 RID: 112052 RVA: 0x003DFF0B File Offset: 0x003DE10B
		public static void AddData(FlatBufferBuilder builder, Offset<ISilentAreaOccupationData> dataOffset)
		{
			builder.AddOffset(3, dataOffset.Value, 0);
		}

		// Token: 0x0601B5B5 RID: 112053 RVA: 0x003DFF1B File Offset: 0x003DE11B
		public static Offset<ISilentAreaExportData> EndISilentAreaExportData(FlatBufferBuilder builder)
		{
			return new Offset<ISilentAreaExportData>(builder.EndTable());
		}

		// Token: 0x0601B5B6 RID: 112054 RVA: 0x003DFF28 File Offset: 0x003DE128
		public ISilentAreaExportDataT UnPack()
		{
			ISilentAreaExportDataT silentAreaExportDataT = new ISilentAreaExportDataT();
			this.UnPackTo(silentAreaExportDataT);
			return silentAreaExportDataT;
		}

		// Token: 0x0601B5B7 RID: 112055 RVA: 0x003DFF44 File Offset: 0x003DE144
		public void UnPackTo(ISilentAreaExportDataT _o)
		{
			_o.Id = this.Id;
			_o.NameStringKey = this.NameStringKey;
			_o.Name = this.Name;
			_o.Data = ((this.Data != null) ? this.Data.Value.UnPack() : null);
		}

		// Token: 0x0601B5B8 RID: 112056 RVA: 0x003DFFA4 File Offset: 0x003DE1A4
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

		// Token: 0x0400CC37 RID: 52279
		private Table __p;
	}
}
