using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004815 RID: 18453
	public struct IOccupationExportConfig : IFlatbufferObject
	{
		// Token: 0x170080CA RID: 32970
		// (get) Token: 0x0601B4DF RID: 111839 RVA: 0x003DE7A1 File Offset: 0x003DC9A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B4E0 RID: 111840 RVA: 0x003DE7AE File Offset: 0x003DC9AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B4E1 RID: 111841 RVA: 0x003DE7B8 File Offset: 0x003DC9B8
		public static IOccupationExportConfig GetRootAsIOccupationExportConfig(ByteBuffer _bb)
		{
			return IOccupationExportConfig.GetRootAsIOccupationExportConfig(_bb, default(IOccupationExportConfig));
		}

		// Token: 0x0601B4E2 RID: 111842 RVA: 0x003DE7D4 File Offset: 0x003DC9D4
		public static IOccupationExportConfig GetRootAsIOccupationExportConfig(ByteBuffer _bb, IOccupationExportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B4E3 RID: 111843 RVA: 0x003DE7F1 File Offset: 0x003DC9F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B4E4 RID: 111844 RVA: 0x003DE800 File Offset: 0x003DCA00
		public IOccupationExportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080CB RID: 32971
		// (get) Token: 0x0601B4E5 RID: 111845 RVA: 0x003DE810 File Offset: 0x003DCA10
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

		// Token: 0x0601B4E6 RID: 111846 RVA: 0x003DE847 File Offset: 0x003DCA47
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601B4E7 RID: 111847 RVA: 0x003DE856 File Offset: 0x003DCA56
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170080CC RID: 32972
		// (get) Token: 0x0601B4E8 RID: 111848 RVA: 0x003DE864 File Offset: 0x003DCA64
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

		// Token: 0x0601B4E9 RID: 111849 RVA: 0x003DE89B File Offset: 0x003DCA9B
		public Span<byte> GetNameStringKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601B4EA RID: 111850 RVA: 0x003DE8AA File Offset: 0x003DCAAA
		public byte[] GetNameStringKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170080CD RID: 32973
		// (get) Token: 0x0601B4EB RID: 111851 RVA: 0x003DE8B8 File Offset: 0x003DCAB8
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

		// Token: 0x0601B4EC RID: 111852 RVA: 0x003DE8EF File Offset: 0x003DCAEF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B4ED RID: 111853 RVA: 0x003DE8FE File Offset: 0x003DCAFE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601B4EE RID: 111854 RVA: 0x003DE90C File Offset: 0x003DCB0C
		public static Offset<IOccupationExportConfig> CreateIOccupationExportConfig(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), StringOffset NameStringKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IOccupationExportConfig.AddName(builder, NameOffset);
			IOccupationExportConfig.AddNameStringKey(builder, NameStringKeyOffset);
			IOccupationExportConfig.AddId(builder, IdOffset);
			return IOccupationExportConfig.EndIOccupationExportConfig(builder);
		}

		// Token: 0x0601B4EF RID: 111855 RVA: 0x003DE930 File Offset: 0x003DCB30
		public static void StartIOccupationExportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B4F0 RID: 111856 RVA: 0x003DE939 File Offset: 0x003DCB39
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x0601B4F1 RID: 111857 RVA: 0x003DE949 File Offset: 0x003DCB49
		public static void AddNameStringKey(FlatBufferBuilder builder, StringOffset nameStringKeyOffset)
		{
			builder.AddOffset(1, nameStringKeyOffset.Value, 0);
		}

		// Token: 0x0601B4F2 RID: 111858 RVA: 0x003DE959 File Offset: 0x003DCB59
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(2, nameOffset.Value, 0);
		}

		// Token: 0x0601B4F3 RID: 111859 RVA: 0x003DE969 File Offset: 0x003DCB69
		public static Offset<IOccupationExportConfig> EndIOccupationExportConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOccupationExportConfig>(builder.EndTable());
		}

		// Token: 0x0601B4F4 RID: 111860 RVA: 0x003DE978 File Offset: 0x003DCB78
		public IOccupationExportConfigT UnPack()
		{
			IOccupationExportConfigT occupationExportConfigT = new IOccupationExportConfigT();
			this.UnPackTo(occupationExportConfigT);
			return occupationExportConfigT;
		}

		// Token: 0x0601B4F5 RID: 111861 RVA: 0x003DE993 File Offset: 0x003DCB93
		public void UnPackTo(IOccupationExportConfigT _o)
		{
			_o.Id = this.Id;
			_o.NameStringKey = this.NameStringKey;
			_o.Name = this.Name;
		}

		// Token: 0x0601B4F6 RID: 111862 RVA: 0x003DE9BC File Offset: 0x003DCBBC
		public static Offset<IOccupationExportConfig> Pack(FlatBufferBuilder builder, IOccupationExportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOccupationExportConfig>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			StringOffset nameStringKeyOffset = (_o.NameStringKey == null) ? default(StringOffset) : builder.CreateString(_o.NameStringKey);
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return IOccupationExportConfig.CreateIOccupationExportConfig(builder, idOffset, nameStringKeyOffset, nameOffset);
		}

		// Token: 0x0400CC12 RID: 52242
		private Table __p;
	}
}
