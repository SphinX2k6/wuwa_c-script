using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F89 RID: 16265
	public struct ISyncBlock : IFlatbufferObject
	{
		// Token: 0x17006E13 RID: 28179
		// (get) Token: 0x060162A7 RID: 90791 RVA: 0x0032DCCD File Offset: 0x0032BECD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060162A8 RID: 90792 RVA: 0x0032DCDA File Offset: 0x0032BEDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060162A9 RID: 90793 RVA: 0x0032DCE4 File Offset: 0x0032BEE4
		public static ISyncBlock GetRootAsISyncBlock(ByteBuffer _bb)
		{
			return ISyncBlock.GetRootAsISyncBlock(_bb, default(ISyncBlock));
		}

		// Token: 0x060162AA RID: 90794 RVA: 0x0032DD00 File Offset: 0x0032BF00
		public static ISyncBlock GetRootAsISyncBlock(ByteBuffer _bb, ISyncBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060162AB RID: 90795 RVA: 0x0032DD1D File Offset: 0x0032BF1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060162AC RID: 90796 RVA: 0x0032DD2C File Offset: 0x0032BF2C
		public ISyncBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E14 RID: 28180
		// (get) Token: 0x060162AD RID: 90797 RVA: 0x0032DD3C File Offset: 0x0032BF3C
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

		// Token: 0x060162AE RID: 90798 RVA: 0x0032DD73 File Offset: 0x0032BF73
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060162AF RID: 90799 RVA: 0x0032DD82 File Offset: 0x0032BF82
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006E15 RID: 28181
		// (get) Token: 0x060162B0 RID: 90800 RVA: 0x0032DD90 File Offset: 0x0032BF90
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

		// Token: 0x060162B1 RID: 90801 RVA: 0x0032DDC7 File Offset: 0x0032BFC7
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060162B2 RID: 90802 RVA: 0x0032DDD6 File Offset: 0x0032BFD6
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060162B3 RID: 90803 RVA: 0x0032DDE4 File Offset: 0x0032BFE4
		public static Offset<ISyncBlock> CreateISyncBlock(FlatBufferBuilder builder, StringOffset PathOffset = default(StringOffset), StringOffset DataOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISyncBlock.AddData(builder, DataOffset);
			ISyncBlock.AddPath(builder, PathOffset);
			return ISyncBlock.EndISyncBlock(builder);
		}

		// Token: 0x060162B4 RID: 90804 RVA: 0x0032DE01 File Offset: 0x0032C001
		public static void StartISyncBlock(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060162B5 RID: 90805 RVA: 0x0032DE0A File Offset: 0x0032C00A
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(0, pathOffset.Value, 0);
		}

		// Token: 0x060162B6 RID: 90806 RVA: 0x0032DE1A File Offset: 0x0032C01A
		public static void AddData(FlatBufferBuilder builder, StringOffset dataOffset)
		{
			builder.AddOffset(1, dataOffset.Value, 0);
		}

		// Token: 0x060162B7 RID: 90807 RVA: 0x0032DE2A File Offset: 0x0032C02A
		public static Offset<ISyncBlock> EndISyncBlock(FlatBufferBuilder builder)
		{
			return new Offset<ISyncBlock>(builder.EndTable());
		}

		// Token: 0x060162B8 RID: 90808 RVA: 0x0032DE38 File Offset: 0x0032C038
		public ISyncBlockT UnPack()
		{
			ISyncBlockT syncBlockT = new ISyncBlockT();
			this.UnPackTo(syncBlockT);
			return syncBlockT;
		}

		// Token: 0x060162B9 RID: 90809 RVA: 0x0032DE53 File Offset: 0x0032C053
		public void UnPackTo(ISyncBlockT _o)
		{
			_o.Path = this.Path;
			_o.Data = this.Data;
		}

		// Token: 0x060162BA RID: 90810 RVA: 0x0032DE70 File Offset: 0x0032C070
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

		// Token: 0x0400BA4E RID: 47694
		private Table __p;
	}
}
