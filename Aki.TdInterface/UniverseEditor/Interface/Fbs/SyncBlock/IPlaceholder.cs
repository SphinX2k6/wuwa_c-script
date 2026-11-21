using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F80 RID: 16256
	public struct IPlaceholder : IFlatbufferObject
	{
		// Token: 0x17006DFA RID: 28154
		// (get) Token: 0x06016241 RID: 90689 RVA: 0x0032D154 File Offset: 0x0032B354
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016242 RID: 90690 RVA: 0x0032D161 File Offset: 0x0032B361
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016243 RID: 90691 RVA: 0x0032D168 File Offset: 0x0032B368
		public static IPlaceholder GetRootAsIPlaceholder(ByteBuffer _bb)
		{
			return IPlaceholder.GetRootAsIPlaceholder(_bb, default(IPlaceholder));
		}

		// Token: 0x06016244 RID: 90692 RVA: 0x0032D184 File Offset: 0x0032B384
		public static IPlaceholder GetRootAsIPlaceholder(ByteBuffer _bb, IPlaceholder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016245 RID: 90693 RVA: 0x0032D1A1 File Offset: 0x0032B3A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016246 RID: 90694 RVA: 0x0032D1B0 File Offset: 0x0032B3B0
		public IPlaceholder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DFB RID: 28155
		// (get) Token: 0x06016247 RID: 90695 RVA: 0x0032D1C0 File Offset: 0x0032B3C0
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

		// Token: 0x17006DFC RID: 28156
		// (get) Token: 0x06016248 RID: 90696 RVA: 0x0032D1FC File Offset: 0x0032B3FC
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

		// Token: 0x06016249 RID: 90697 RVA: 0x0032D233 File Offset: 0x0032B433
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601624A RID: 90698 RVA: 0x0032D242 File Offset: 0x0032B442
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006DFD RID: 28157
		// (get) Token: 0x0601624B RID: 90699 RVA: 0x0032D250 File Offset: 0x0032B450
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

		// Token: 0x17006DFE RID: 28158
		// (get) Token: 0x0601624C RID: 90700 RVA: 0x0032D28C File Offset: 0x0032B48C
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

		// Token: 0x17006DFF RID: 28159
		// (get) Token: 0x0601624D RID: 90701 RVA: 0x0032D2CC File Offset: 0x0032B4CC
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

		// Token: 0x0601624E RID: 90702 RVA: 0x0032D304 File Offset: 0x0032B504
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601624F RID: 90703 RVA: 0x0032D314 File Offset: 0x0032B514
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17006E00 RID: 28160
		// (get) Token: 0x06016250 RID: 90704 RVA: 0x0032D324 File Offset: 0x0032B524
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

		// Token: 0x06016251 RID: 90705 RVA: 0x0032D35C File Offset: 0x0032B55C
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06016252 RID: 90706 RVA: 0x0032D36C File Offset: 0x0032B56C
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x06016253 RID: 90707 RVA: 0x0032D37B File Offset: 0x0032B57B
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

		// Token: 0x06016254 RID: 90708 RVA: 0x0032D3B7 File Offset: 0x0032B5B7
		public static void StartIPlaceholder(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06016255 RID: 90709 RVA: 0x0032D3C0 File Offset: 0x0032B5C0
		public static void AddType(FlatBufferBuilder builder, TPlaceholderType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016256 RID: 90710 RVA: 0x0032D3CB File Offset: 0x0032B5CB
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06016257 RID: 90711 RVA: 0x0032D3DB File Offset: 0x0032B5DB
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(2, nodeId, 0);
		}

		// Token: 0x06016258 RID: 90712 RVA: 0x0032D3E6 File Offset: 0x0032B5E6
		public static void AddSegment(FlatBufferBuilder builder, int segment)
		{
			builder.AddInt(3, segment, 0);
		}

		// Token: 0x06016259 RID: 90713 RVA: 0x0032D3F1 File Offset: 0x0032B5F1
		public static void AddData(FlatBufferBuilder builder, StringOffset dataOffset)
		{
			builder.AddOffset(4, dataOffset.Value, 0);
		}

		// Token: 0x0601625A RID: 90714 RVA: 0x0032D401 File Offset: 0x0032B601
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(5, pathOffset.Value, 0);
		}

		// Token: 0x0601625B RID: 90715 RVA: 0x0032D411 File Offset: 0x0032B611
		public static Offset<IPlaceholder> EndIPlaceholder(FlatBufferBuilder builder)
		{
			return new Offset<IPlaceholder>(builder.EndTable());
		}

		// Token: 0x0601625C RID: 90716 RVA: 0x0032D420 File Offset: 0x0032B620
		public IPlaceholderT UnPack()
		{
			IPlaceholderT placeholderT = new IPlaceholderT();
			this.UnPackTo(placeholderT);
			return placeholderT;
		}

		// Token: 0x0601625D RID: 90717 RVA: 0x0032D43C File Offset: 0x0032B63C
		public void UnPackTo(IPlaceholderT _o)
		{
			_o.Type = this.Type;
			_o.Name = this.Name;
			_o.NodeId = this.NodeId;
			_o.Segment = this.Segment;
			_o.Data = this.Data;
			_o.Path = this.Path;
		}

		// Token: 0x0601625E RID: 90718 RVA: 0x0032D494 File Offset: 0x0032B694
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

		// Token: 0x0400BA40 RID: 47680
		private Table __p;
	}
}
