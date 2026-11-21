using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F8C RID: 16268
	public struct ISyncBlockGroup : IFlatbufferObject
	{
		// Token: 0x17006E18 RID: 28184
		// (get) Token: 0x060162C1 RID: 90817 RVA: 0x0032DF34 File Offset: 0x0032C134
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060162C2 RID: 90818 RVA: 0x0032DF41 File Offset: 0x0032C141
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060162C3 RID: 90819 RVA: 0x0032DF48 File Offset: 0x0032C148
		public static ISyncBlockGroup GetRootAsISyncBlockGroup(ByteBuffer _bb)
		{
			return ISyncBlockGroup.GetRootAsISyncBlockGroup(_bb, default(ISyncBlockGroup));
		}

		// Token: 0x060162C4 RID: 90820 RVA: 0x0032DF64 File Offset: 0x0032C164
		public static ISyncBlockGroup GetRootAsISyncBlockGroup(ByteBuffer _bb, ISyncBlockGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060162C5 RID: 90821 RVA: 0x0032DF81 File Offset: 0x0032C181
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060162C6 RID: 90822 RVA: 0x0032DF90 File Offset: 0x0032C190
		public ISyncBlockGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E19 RID: 28185
		// (get) Token: 0x060162C7 RID: 90823 RVA: 0x0032DFA0 File Offset: 0x0032C1A0
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

		// Token: 0x060162C8 RID: 90824 RVA: 0x0032DFD7 File Offset: 0x0032C1D7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060162C9 RID: 90825 RVA: 0x0032DFE6 File Offset: 0x0032C1E6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060162CA RID: 90826 RVA: 0x0032DFF4 File Offset: 0x0032C1F4
		public ISyncBlock? SyncBlocks(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISyncBlock?(default(ISyncBlock).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006E1A RID: 28186
		// (get) Token: 0x060162CB RID: 90827 RVA: 0x0032E054 File Offset: 0x0032C254
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

		// Token: 0x060162CC RID: 90828 RVA: 0x0032E07F File Offset: 0x0032C27F
		public static Offset<ISyncBlockGroup> CreateISyncBlockGroup(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), VectorOffset SyncBlocksOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISyncBlockGroup.AddSyncBlocks(builder, SyncBlocksOffset);
			ISyncBlockGroup.AddName(builder, NameOffset);
			return ISyncBlockGroup.EndISyncBlockGroup(builder);
		}

		// Token: 0x060162CD RID: 90829 RVA: 0x0032E09C File Offset: 0x0032C29C
		public static void StartISyncBlockGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060162CE RID: 90830 RVA: 0x0032E0A5 File Offset: 0x0032C2A5
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x060162CF RID: 90831 RVA: 0x0032E0B5 File Offset: 0x0032C2B5
		public static void AddSyncBlocks(FlatBufferBuilder builder, VectorOffset syncBlocksOffset)
		{
			builder.AddOffset(1, syncBlocksOffset.Value, 0);
		}

		// Token: 0x060162D0 RID: 90832 RVA: 0x0032E0C8 File Offset: 0x0032C2C8
		public static VectorOffset CreateSyncBlocksVector(FlatBufferBuilder builder, Offset<ISyncBlock>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060162D1 RID: 90833 RVA: 0x0032E108 File Offset: 0x0032C308
		public static VectorOffset CreateSyncBlocksVectorBlock(FlatBufferBuilder builder, Offset<ISyncBlock>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISyncBlock>>(data);
			return builder.EndVector();
		}

		// Token: 0x060162D2 RID: 90834 RVA: 0x0032E122 File Offset: 0x0032C322
		public static VectorOffset CreateSyncBlocksVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISyncBlock>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISyncBlock>>(data);
			return builder.EndVector();
		}

		// Token: 0x060162D3 RID: 90835 RVA: 0x0032E140 File Offset: 0x0032C340
		public static VectorOffset CreateSyncBlocksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISyncBlock>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060162D4 RID: 90836 RVA: 0x0032E159 File Offset: 0x0032C359
		public static void StartSyncBlocksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060162D5 RID: 90837 RVA: 0x0032E164 File Offset: 0x0032C364
		public static Offset<ISyncBlockGroup> EndISyncBlockGroup(FlatBufferBuilder builder)
		{
			return new Offset<ISyncBlockGroup>(builder.EndTable());
		}

		// Token: 0x060162D6 RID: 90838 RVA: 0x0032E174 File Offset: 0x0032C374
		public ISyncBlockGroupT UnPack()
		{
			ISyncBlockGroupT syncBlockGroupT = new ISyncBlockGroupT();
			this.UnPackTo(syncBlockGroupT);
			return syncBlockGroupT;
		}

		// Token: 0x060162D7 RID: 90839 RVA: 0x0032E190 File Offset: 0x0032C390
		public void UnPackTo(ISyncBlockGroupT _o)
		{
			_o.Name = this.Name;
			_o.SyncBlocks = new List<ISyncBlockT>();
			for (int i = 0; i < this.SyncBlocksLength; i++)
			{
				_o.SyncBlocks.Add((this.SyncBlocks(i) != null) ? this.SyncBlocks(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060162D8 RID: 90840 RVA: 0x0032E1FC File Offset: 0x0032C3FC
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

		// Token: 0x0400BA51 RID: 47697
		private Table __p;
	}
}
