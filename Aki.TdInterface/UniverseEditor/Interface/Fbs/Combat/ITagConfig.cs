using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EF0 RID: 24304
	public struct ITagConfig : IFlatbufferObject
	{
		// Token: 0x1700B5B4 RID: 46516
		// (get) Token: 0x06029BD2 RID: 170962 RVA: 0x005BA58B File Offset: 0x005B878B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029BD3 RID: 170963 RVA: 0x005BA598 File Offset: 0x005B8798
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029BD4 RID: 170964 RVA: 0x005BA5A0 File Offset: 0x005B87A0
		public static ITagConfig GetRootAsITagConfig(ByteBuffer _bb)
		{
			return ITagConfig.GetRootAsITagConfig(_bb, default(ITagConfig));
		}

		// Token: 0x06029BD5 RID: 170965 RVA: 0x005BA5BC File Offset: 0x005B87BC
		public static ITagConfig GetRootAsITagConfig(ByteBuffer _bb, ITagConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029BD6 RID: 170966 RVA: 0x005BA5D9 File Offset: 0x005B87D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029BD7 RID: 170967 RVA: 0x005BA5E8 File Offset: 0x005B87E8
		public ITagConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5B5 RID: 46517
		// (get) Token: 0x06029BD8 RID: 170968 RVA: 0x005BA5F8 File Offset: 0x005B87F8
		public string Tag
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

		// Token: 0x06029BD9 RID: 170969 RVA: 0x005BA62F File Offset: 0x005B882F
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06029BDA RID: 170970 RVA: 0x005BA63E File Offset: 0x005B883E
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B5B6 RID: 46518
		// (get) Token: 0x06029BDB RID: 170971 RVA: 0x005BA64C File Offset: 0x005B884C
		public string Name
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

		// Token: 0x06029BDC RID: 170972 RVA: 0x005BA683 File Offset: 0x005B8883
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029BDD RID: 170973 RVA: 0x005BA692 File Offset: 0x005B8892
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06029BDE RID: 170974 RVA: 0x005BA6A0 File Offset: 0x005B88A0
		public static Offset<ITagConfig> CreateITagConfig(FlatBufferBuilder builder, StringOffset TagOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITagConfig.AddName(builder, NameOffset);
			ITagConfig.AddTag(builder, TagOffset);
			return ITagConfig.EndITagConfig(builder);
		}

		// Token: 0x06029BDF RID: 170975 RVA: 0x005BA6BD File Offset: 0x005B88BD
		public static void StartITagConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029BE0 RID: 170976 RVA: 0x005BA6C6 File Offset: 0x005B88C6
		public static void AddTag(FlatBufferBuilder builder, StringOffset tagOffset)
		{
			builder.AddOffset(0, tagOffset.Value, 0);
		}

		// Token: 0x06029BE1 RID: 170977 RVA: 0x005BA6D6 File Offset: 0x005B88D6
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06029BE2 RID: 170978 RVA: 0x005BA6E6 File Offset: 0x005B88E6
		public static Offset<ITagConfig> EndITagConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITagConfig>(builder.EndTable());
		}

		// Token: 0x06029BE3 RID: 170979 RVA: 0x005BA6F4 File Offset: 0x005B88F4
		public ITagConfigT UnPack()
		{
			ITagConfigT tagConfigT = new ITagConfigT();
			this.UnPackTo(tagConfigT);
			return tagConfigT;
		}

		// Token: 0x06029BE4 RID: 170980 RVA: 0x005BA70F File Offset: 0x005B890F
		public void UnPackTo(ITagConfigT _o)
		{
			_o.Tag = this.Tag;
			_o.Name = this.Name;
		}

		// Token: 0x06029BE5 RID: 170981 RVA: 0x005BA72C File Offset: 0x005B892C
		public static Offset<ITagConfig> Pack(FlatBufferBuilder builder, ITagConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITagConfig>);
			}
			StringOffset tagOffset = (_o.Tag == null) ? default(StringOffset) : builder.CreateString(_o.Tag);
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			return ITagConfig.CreateITagConfig(builder, tagOffset, nameOffset);
		}

		// Token: 0x0400F9F3 RID: 63987
		private Table __p;
	}
}
