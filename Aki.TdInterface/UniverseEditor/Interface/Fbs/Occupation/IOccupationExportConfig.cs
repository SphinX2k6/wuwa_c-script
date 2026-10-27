using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043B3 RID: 17331
	public struct IOccupationExportConfig : IFlatbufferObject
	{
		// Token: 0x17007A93 RID: 31379
		// (get) Token: 0x06019D46 RID: 105798 RVA: 0x003B2B4D File Offset: 0x003B0D4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019D47 RID: 105799 RVA: 0x003B2B5A File Offset: 0x003B0D5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019D48 RID: 105800 RVA: 0x003B2B64 File Offset: 0x003B0D64
		public static IOccupationExportConfig GetRootAsIOccupationExportConfig(ByteBuffer _bb)
		{
			return IOccupationExportConfig.GetRootAsIOccupationExportConfig(_bb, default(IOccupationExportConfig));
		}

		// Token: 0x06019D49 RID: 105801 RVA: 0x003B2B80 File Offset: 0x003B0D80
		public static IOccupationExportConfig GetRootAsIOccupationExportConfig(ByteBuffer _bb, IOccupationExportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019D4A RID: 105802 RVA: 0x003B2B9D File Offset: 0x003B0D9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019D4B RID: 105803 RVA: 0x003B2BAC File Offset: 0x003B0DAC
		public IOccupationExportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A94 RID: 31380
		// (get) Token: 0x06019D4C RID: 105804 RVA: 0x003B2BBC File Offset: 0x003B0DBC
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

		// Token: 0x06019D4D RID: 105805 RVA: 0x003B2BF3 File Offset: 0x003B0DF3
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06019D4E RID: 105806 RVA: 0x003B2C02 File Offset: 0x003B0E02
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17007A95 RID: 31381
		// (get) Token: 0x06019D4F RID: 105807 RVA: 0x003B2C10 File Offset: 0x003B0E10
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

		// Token: 0x06019D50 RID: 105808 RVA: 0x003B2C47 File Offset: 0x003B0E47
		public Span<byte> GetNameStringKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06019D51 RID: 105809 RVA: 0x003B2C56 File Offset: 0x003B0E56
		public byte[] GetNameStringKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17007A96 RID: 31382
		// (get) Token: 0x06019D52 RID: 105810 RVA: 0x003B2C64 File Offset: 0x003B0E64
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

		// Token: 0x06019D53 RID: 105811 RVA: 0x003B2C9B File Offset: 0x003B0E9B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019D54 RID: 105812 RVA: 0x003B2CAA File Offset: 0x003B0EAA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06019D55 RID: 105813 RVA: 0x003B2CB8 File Offset: 0x003B0EB8
		public static Offset<IOccupationExportConfig> CreateIOccupationExportConfig(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), StringOffset NameStringKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IOccupationExportConfig.AddName(builder, NameOffset);
			IOccupationExportConfig.AddNameStringKey(builder, NameStringKeyOffset);
			IOccupationExportConfig.AddId(builder, IdOffset);
			return IOccupationExportConfig.EndIOccupationExportConfig(builder);
		}

		// Token: 0x06019D56 RID: 105814 RVA: 0x003B2CDC File Offset: 0x003B0EDC
		public static void StartIOccupationExportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019D57 RID: 105815 RVA: 0x003B2CE5 File Offset: 0x003B0EE5
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x06019D58 RID: 105816 RVA: 0x003B2CF5 File Offset: 0x003B0EF5
		public static void AddNameStringKey(FlatBufferBuilder builder, StringOffset nameStringKeyOffset)
		{
			builder.AddOffset(1, nameStringKeyOffset.Value, 0);
		}

		// Token: 0x06019D59 RID: 105817 RVA: 0x003B2D05 File Offset: 0x003B0F05
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(2, nameOffset.Value, 0);
		}

		// Token: 0x06019D5A RID: 105818 RVA: 0x003B2D15 File Offset: 0x003B0F15
		public static Offset<IOccupationExportConfig> EndIOccupationExportConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOccupationExportConfig>(builder.EndTable());
		}

		// Token: 0x06019D5B RID: 105819 RVA: 0x003B2D24 File Offset: 0x003B0F24
		public IOccupationExportConfigT UnPack()
		{
			IOccupationExportConfigT occupationExportConfigT = new IOccupationExportConfigT();
			this.UnPackTo(occupationExportConfigT);
			return occupationExportConfigT;
		}

		// Token: 0x06019D5C RID: 105820 RVA: 0x003B2D3F File Offset: 0x003B0F3F
		public void UnPackTo(IOccupationExportConfigT _o)
		{
			_o.Id = this.Id;
			_o.NameStringKey = this.NameStringKey;
			_o.Name = this.Name;
		}

		// Token: 0x06019D5D RID: 105821 RVA: 0x003B2D68 File Offset: 0x003B0F68
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

		// Token: 0x0400C1F2 RID: 49650
		private Table __p;
	}
}
