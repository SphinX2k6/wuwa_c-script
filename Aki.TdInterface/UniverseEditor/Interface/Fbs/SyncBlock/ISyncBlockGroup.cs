using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B84 RID: 15236
	public struct ISyncBlockGroup : IFlatbufferObject
	{
		// Token: 0x17006879 RID: 26745
		// (get) Token: 0x06014DF7 RID: 85495 RVA: 0x0030799C File Offset: 0x00305B9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014DF8 RID: 85496 RVA: 0x003079A9 File Offset: 0x00305BA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014DF9 RID: 85497 RVA: 0x003079B0 File Offset: 0x00305BB0
		public static ISyncBlockGroup GetRootAsISyncBlockGroup(ByteBuffer _bb)
		{
			return ISyncBlockGroup.GetRootAsISyncBlockGroup(_bb, default(ISyncBlockGroup));
		}

		// Token: 0x06014DFA RID: 85498 RVA: 0x003079CC File Offset: 0x00305BCC
		public static ISyncBlockGroup GetRootAsISyncBlockGroup(ByteBuffer _bb, ISyncBlockGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014DFB RID: 85499 RVA: 0x003079E9 File Offset: 0x00305BE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014DFC RID: 85500 RVA: 0x003079F8 File Offset: 0x00305BF8
		public ISyncBlockGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700687A RID: 26746
		// (get) Token: 0x06014DFD RID: 85501 RVA: 0x00307A08 File Offset: 0x00305C08
		public string Name
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

		// Token: 0x06014DFE RID: 85502 RVA: 0x00307A3F File Offset: 0x00305C3F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06014DFF RID: 85503 RVA: 0x00307A4E File Offset: 0x00305C4E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06014E00 RID: 85504 RVA: 0x00307A5C File Offset: 0x00305C5C
		public ISyncBlock? SyncBlocks(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISyncBlock?(default(ISyncBlock).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700687B RID: 26747
		// (get) Token: 0x06014E01 RID: 85505 RVA: 0x00307ABC File Offset: 0x00305CBC
		public int SyncBlocksLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06014E02 RID: 85506 RVA: 0x00307AE7 File Offset: 0x00305CE7
		public static Offset<ISyncBlockGroup> CreateISyncBlockGroup(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), VectorOffset SyncBlocksOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISyncBlockGroup.AddSyncBlocks(builder, SyncBlocksOffset);
			ISyncBlockGroup.AddName(builder, NameOffset);
			return ISyncBlockGroup.EndISyncBlockGroup(builder);
		}

		// Token: 0x06014E03 RID: 85507 RVA: 0x00307B04 File Offset: 0x00305D04
		public static void StartISyncBlockGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014E04 RID: 85508 RVA: 0x00307B0D File Offset: 0x00305D0D
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x06014E05 RID: 85509 RVA: 0x00307B1D File Offset: 0x00305D1D
		public static void AddSyncBlocks(FlatBufferBuilder builder, VectorOffset syncBlocksOffset)
		{
			builder.AddOffset(1, syncBlocksOffset.Value, 0);
		}

		// Token: 0x06014E06 RID: 85510 RVA: 0x00307B30 File Offset: 0x00305D30
		public static VectorOffset CreateSyncBlocksVector(FlatBufferBuilder builder, Offset<ISyncBlock>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06014E07 RID: 85511 RVA: 0x00307B70 File Offset: 0x00305D70
		public static VectorOffset CreateSyncBlocksVectorBlock(FlatBufferBuilder builder, Offset<ISyncBlock>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISyncBlock>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014E08 RID: 85512 RVA: 0x00307B8A File Offset: 0x00305D8A
		public static VectorOffset CreateSyncBlocksVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISyncBlock>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISyncBlock>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014E09 RID: 85513 RVA: 0x00307BA8 File Offset: 0x00305DA8
		public static VectorOffset CreateSyncBlocksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISyncBlock>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014E0A RID: 85514 RVA: 0x00307BC1 File Offset: 0x00305DC1
		public static void StartSyncBlocksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014E0B RID: 85515 RVA: 0x00307BCC File Offset: 0x00305DCC
		public static Offset<ISyncBlockGroup> EndISyncBlockGroup(FlatBufferBuilder builder)
		{
			return new Offset<ISyncBlockGroup>(builder.EndTable());
		}

		// Token: 0x06014E0C RID: 85516 RVA: 0x00307BDC File Offset: 0x00305DDC
		public ISyncBlockGroupT UnPack()
		{
			ISyncBlockGroupT syncBlockGroupT = new ISyncBlockGroupT();
			this.UnPackTo(syncBlockGroupT);
			return syncBlockGroupT;
		}

		// Token: 0x06014E0D RID: 85517 RVA: 0x00307BF8 File Offset: 0x00305DF8
		public void UnPackTo(ISyncBlockGroupT _o)
		{
			_o.Name = this.Name;
			_o.SyncBlocks = new List<ISyncBlockT>();
			for (int i = 0; i < this.SyncBlocksLength; i++)
			{
				_o.SyncBlocks.Add((this.SyncBlocks(i) != null) ? this.SyncBlocks(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06014E0E RID: 85518 RVA: 0x00307C64 File Offset: 0x00305E64
		public static Offset<ISyncBlockGroup> Pack(FlatBufferBuilder builder, ISyncBlockGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISyncBlockGroup>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			VectorOffset syncBlocksOffset = default(VectorOffset);
			if (_o.SyncBlocks != null)
			{
				Offset<ISyncBlock>[] array = new Offset<ISyncBlock>[_o.SyncBlocks.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISyncBlock.Pack(builder, _o.SyncBlocks[i]);
				}
				syncBlocksOffset = ISyncBlockGroup.CreateSyncBlocksVector(builder, array);
			}
			return ISyncBlockGroup.CreateISyncBlockGroup(builder, nameOffset, syncBlocksOffset);
		}

		// Token: 0x0400B0D4 RID: 45268
		private Table __p;
	}
}
