using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B81 RID: 15233
	public struct ISyncBlock : IFlatbufferObject
	{
		// Token: 0x17006874 RID: 26740
		// (get) Token: 0x06014DDD RID: 85469 RVA: 0x00307735 File Offset: 0x00305935
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014DDE RID: 85470 RVA: 0x00307742 File Offset: 0x00305942
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014DDF RID: 85471 RVA: 0x0030774C File Offset: 0x0030594C
		public static ISyncBlock GetRootAsISyncBlock(ByteBuffer _bb)
		{
			return ISyncBlock.GetRootAsISyncBlock(_bb, default(ISyncBlock));
		}

		// Token: 0x06014DE0 RID: 85472 RVA: 0x00307768 File Offset: 0x00305968
		public static ISyncBlock GetRootAsISyncBlock(ByteBuffer _bb, ISyncBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014DE1 RID: 85473 RVA: 0x00307785 File Offset: 0x00305985
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014DE2 RID: 85474 RVA: 0x00307794 File Offset: 0x00305994
		public ISyncBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006875 RID: 26741
		// (get) Token: 0x06014DE3 RID: 85475 RVA: 0x003077A4 File Offset: 0x003059A4
		public string Path
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

		// Token: 0x06014DE4 RID: 85476 RVA: 0x003077DB File Offset: 0x003059DB
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06014DE5 RID: 85477 RVA: 0x003077EA File Offset: 0x003059EA
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006876 RID: 26742
		// (get) Token: 0x06014DE6 RID: 85478 RVA: 0x003077F8 File Offset: 0x003059F8
		public string Data
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

		// Token: 0x06014DE7 RID: 85479 RVA: 0x0030782F File Offset: 0x00305A2F
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06014DE8 RID: 85480 RVA: 0x0030783E File Offset: 0x00305A3E
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06014DE9 RID: 85481 RVA: 0x0030784C File Offset: 0x00305A4C
		public static Offset<ISyncBlock> CreateISyncBlock(FlatBufferBuilder builder, StringOffset PathOffset = default(StringOffset), StringOffset DataOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISyncBlock.AddData(builder, DataOffset);
			ISyncBlock.AddPath(builder, PathOffset);
			return ISyncBlock.EndISyncBlock(builder);
		}

		// Token: 0x06014DEA RID: 85482 RVA: 0x00307869 File Offset: 0x00305A69
		public static void StartISyncBlock(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014DEB RID: 85483 RVA: 0x00307872 File Offset: 0x00305A72
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(0, pathOffset.Value, 0);
		}

		// Token: 0x06014DEC RID: 85484 RVA: 0x00307882 File Offset: 0x00305A82
		public static void AddData(FlatBufferBuilder builder, StringOffset dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x06014DED RID: 85485 RVA: 0x00307892 File Offset: 0x00305A92
		public static Offset<ISyncBlock> EndISyncBlock(FlatBufferBuilder builder)
		{
			return new Offset<ISyncBlock>(builder.EndTable());
		}

		// Token: 0x06014DEE RID: 85486 RVA: 0x003078A0 File Offset: 0x00305AA0
		public ISyncBlockT UnPack()
		{
			ISyncBlockT syncBlockT = new ISyncBlockT();
			this.UnPackTo(syncBlockT);
			return syncBlockT;
		}

		// Token: 0x06014DEF RID: 85487 RVA: 0x003078BB File Offset: 0x00305ABB
		public void UnPackTo(ISyncBlockT _o)
		{
			_o.Path = this.Path;
			_o.Data = this.Data;
		}

		// Token: 0x06014DF0 RID: 85488 RVA: 0x003078D8 File Offset: 0x00305AD8
		public static Offset<ISyncBlock> Pack(FlatBufferBuilder builder, ISyncBlockT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISyncBlock>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			StringOffset dataOffset = (_o.Data == null) ? default(StringOffset) : builder.CreateString(_o.Data);
			return ISyncBlock.CreateISyncBlock(builder, pathOffset, dataOffset);
		}

		// Token: 0x0400B0D1 RID: 45265
		private Table __p;
	}
}
