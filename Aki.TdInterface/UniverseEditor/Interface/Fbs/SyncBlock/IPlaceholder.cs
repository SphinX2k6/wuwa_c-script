using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B78 RID: 15224
	public struct IPlaceholder : IFlatbufferObject
	{
		// Token: 0x1700685B RID: 26715
		// (get) Token: 0x06014D77 RID: 85367 RVA: 0x00306BBC File Offset: 0x00304DBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014D78 RID: 85368 RVA: 0x00306BC9 File Offset: 0x00304DC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014D79 RID: 85369 RVA: 0x00306BD0 File Offset: 0x00304DD0
		public static IPlaceholder GetRootAsIPlaceholder(ByteBuffer _bb)
		{
			return IPlaceholder.GetRootAsIPlaceholder(_bb, default(IPlaceholder));
		}

		// Token: 0x06014D7A RID: 85370 RVA: 0x00306BEC File Offset: 0x00304DEC
		public static IPlaceholder GetRootAsIPlaceholder(ByteBuffer _bb, IPlaceholder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014D7B RID: 85371 RVA: 0x00306C09 File Offset: 0x00304E09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014D7C RID: 85372 RVA: 0x00306C18 File Offset: 0x00304E18
		public IPlaceholder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700685C RID: 26716
		// (get) Token: 0x06014D7D RID: 85373 RVA: 0x00306C28 File Offset: 0x00304E28
		public TPlaceholderType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TPlaceholderType.BuffIdList;
				}
				return (TPlaceholderType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700685D RID: 26717
		// (get) Token: 0x06014D7E RID: 85374 RVA: 0x00306C64 File Offset: 0x00304E64
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

		// Token: 0x06014D7F RID: 85375 RVA: 0x00306C9B File Offset: 0x00304E9B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06014D80 RID: 85376 RVA: 0x00306CAA File Offset: 0x00304EAA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700685E RID: 26718
		// (get) Token: 0x06014D81 RID: 85377 RVA: 0x00306CB8 File Offset: 0x00304EB8
		public int NodeId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700685F RID: 26719
		// (get) Token: 0x06014D82 RID: 85378 RVA: 0x00306CF4 File Offset: 0x00304EF4
		public int Segment
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006860 RID: 26720
		// (get) Token: 0x06014D83 RID: 85379 RVA: 0x00306D34 File Offset: 0x00304F34
		public string Data
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014D84 RID: 85380 RVA: 0x00306D6C File Offset: 0x00304F6C
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06014D85 RID: 85381 RVA: 0x00306D7C File Offset: 0x00304F7C
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17006861 RID: 26721
		// (get) Token: 0x06014D86 RID: 85382 RVA: 0x00306D8C File Offset: 0x00304F8C
		public string Path
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014D87 RID: 85383 RVA: 0x00306DC4 File Offset: 0x00304FC4
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06014D88 RID: 85384 RVA: 0x00306DD4 File Offset: 0x00304FD4
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x06014D89 RID: 85385 RVA: 0x00306DE3 File Offset: 0x00304FE3
		public static Offset<IPlaceholder> CreateIPlaceholder(FlatBufferBuilder builder, TPlaceholderType Type = TPlaceholderType.BuffIdList, StringOffset NameOffset = default(StringOffset), int NodeId = 0, int Segment = 0, StringOffset DataOffset = default(StringOffset), StringOffset PathOffset = default(StringOffset))
		{
			builder.StartTable(6);
			IPlaceholder.AddPath(builder, PathOffset);
			IPlaceholder.AddData(builder, DataOffset);
			IPlaceholder.AddSegment(builder, Segment);
			IPlaceholder.AddNodeId(builder, NodeId);
			IPlaceholder.AddName(builder, NameOffset);
			IPlaceholder.AddType(builder, Type);
			return IPlaceholder.EndIPlaceholder(builder);
		}

		// Token: 0x06014D8A RID: 85386 RVA: 0x00306E1F File Offset: 0x0030501F
		public static void StartIPlaceholder(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06014D8B RID: 85387 RVA: 0x00306E28 File Offset: 0x00305028
		public static void AddType(FlatBufferBuilder builder, TPlaceholderType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014D8C RID: 85388 RVA: 0x00306E33 File Offset: 0x00305033
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06014D8D RID: 85389 RVA: 0x00306E43 File Offset: 0x00305043
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(2, nodeId, 0);
		}

		// Token: 0x06014D8E RID: 85390 RVA: 0x00306E4E File Offset: 0x0030504E
		public static void AddSegment(FlatBufferBuilder builder, int segment)
		{
			builder.AddInt(3, segment, 0);
		}

		// Token: 0x06014D8F RID: 85391 RVA: 0x00306E59 File Offset: 0x00305059
		public static void AddData(FlatBufferBuilder builder, StringOffset dataOffset)
		{
			builder.AddOffset(4, dataOffset.Value, 0);
		}

		// Token: 0x06014D90 RID: 85392 RVA: 0x00306E69 File Offset: 0x00305069
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(5, pathOffset.Value, 0);
		}

		// Token: 0x06014D91 RID: 85393 RVA: 0x00306E79 File Offset: 0x00305079
		public static Offset<IPlaceholder> EndIPlaceholder(FlatBufferBuilder builder)
		{
			return new Offset<IPlaceholder>(builder.EndTable());
		}

		// Token: 0x06014D92 RID: 85394 RVA: 0x00306E88 File Offset: 0x00305088
		public IPlaceholderT UnPack()
		{
			IPlaceholderT placeholderT = new IPlaceholderT();
			this.UnPackTo(placeholderT);
			return placeholderT;
		}

		// Token: 0x06014D93 RID: 85395 RVA: 0x00306EA4 File Offset: 0x003050A4
		public void UnPackTo(IPlaceholderT _o)
		{
			_o.Type = this.Type;
			_o.Name = this.Name;
			_o.NodeId = this.NodeId;
			_o.Segment = this.Segment;
			_o.Data = this.Data;
			_o.Path = this.Path;
		}

		// Token: 0x06014D94 RID: 85396 RVA: 0x00306EFC File Offset: 0x003050FC
		public static Offset<IPlaceholder> Pack(FlatBufferBuilder builder, IPlaceholderT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlaceholder>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset dataOffset = (_o.Data == null) ? default(StringOffset) : builder.CreateString(_o.Data);
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			return IPlaceholder.CreateIPlaceholder(builder, _o.Type, nameOffset, _o.NodeId, _o.Segment, dataOffset, pathOffset);
		}

		// Token: 0x0400B0C3 RID: 45251
		private Table __p;
	}
}
