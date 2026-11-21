using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044CF RID: 17615
	public struct IRecallEntityGroup : IFlatbufferObject
	{
		// Token: 0x17007A9E RID: 31390
		// (get) Token: 0x0601974C RID: 104268 RVA: 0x003A1B8B File Offset: 0x0039FD8B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601974D RID: 104269 RVA: 0x003A1B98 File Offset: 0x0039FD98
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601974E RID: 104270 RVA: 0x003A1BA0 File Offset: 0x0039FDA0
		public static IRecallEntityGroup GetRootAsIRecallEntityGroup(ByteBuffer _bb)
		{
			return IRecallEntityGroup.GetRootAsIRecallEntityGroup(_bb, default(IRecallEntityGroup));
		}

		// Token: 0x0601974F RID: 104271 RVA: 0x003A1BBC File Offset: 0x0039FDBC
		public static IRecallEntityGroup GetRootAsIRecallEntityGroup(ByteBuffer _bb, IRecallEntityGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019750 RID: 104272 RVA: 0x003A1BD9 File Offset: 0x0039FDD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019751 RID: 104273 RVA: 0x003A1BE8 File Offset: 0x0039FDE8
		public IRecallEntityGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A9F RID: 31391
		// (get) Token: 0x06019752 RID: 104274 RVA: 0x003A1BF8 File Offset: 0x0039FDF8
		public int Index
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007AA0 RID: 31392
		// (get) Token: 0x06019753 RID: 104275 RVA: 0x003A1C34 File Offset: 0x0039FE34
		public string Source
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

		// Token: 0x06019754 RID: 104276 RVA: 0x003A1C6B File Offset: 0x0039FE6B
		public Span<byte> GetSourceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06019755 RID: 104277 RVA: 0x003A1C7A File Offset: 0x0039FE7A
		public byte[] GetSourceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17007AA1 RID: 31393
		// (get) Token: 0x06019756 RID: 104278 RVA: 0x003A1C88 File Offset: 0x0039FE88
		public int LevelId
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

		// Token: 0x06019757 RID: 104279 RVA: 0x003A1CC4 File Offset: 0x0039FEC4
		public int Entities(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007AA2 RID: 31394
		// (get) Token: 0x06019758 RID: 104280 RVA: 0x003A1D04 File Offset: 0x0039FF04
		public int EntitiesLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06019759 RID: 104281 RVA: 0x003A1D30 File Offset: 0x0039FF30
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0601975A RID: 104282 RVA: 0x003A1D40 File Offset: 0x0039FF40
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x0601975B RID: 104283 RVA: 0x003A1D4F File Offset: 0x0039FF4F
		public static Offset<IRecallEntityGroup> CreateIRecallEntityGroup(FlatBufferBuilder builder, int Index = 0, StringOffset SourceOffset = default(StringOffset), int LevelId = 0, VectorOffset EntitiesOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IRecallEntityGroup.AddEntities(builder, EntitiesOffset);
			IRecallEntityGroup.AddLevelId(builder, LevelId);
			IRecallEntityGroup.AddSource(builder, SourceOffset);
			IRecallEntityGroup.AddIndex(builder, Index);
			return IRecallEntityGroup.EndIRecallEntityGroup(builder);
		}

		// Token: 0x0601975C RID: 104284 RVA: 0x003A1D7B File Offset: 0x0039FF7B
		public static void StartIRecallEntityGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601975D RID: 104285 RVA: 0x003A1D84 File Offset: 0x0039FF84
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		// Token: 0x0601975E RID: 104286 RVA: 0x003A1D8F File Offset: 0x0039FF8F
		public static void AddSource(FlatBufferBuilder builder, StringOffset sourceOffset)
		{
			builder.AddOffset(1, sourceOffset.Value, 0);
		}

		// Token: 0x0601975F RID: 104287 RVA: 0x003A1D9F File Offset: 0x0039FF9F
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(2, levelId, 0);
		}

		// Token: 0x06019760 RID: 104288 RVA: 0x003A1DAA File Offset: 0x0039FFAA
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(3, entitiesOffset.Value, 0);
		}

		// Token: 0x06019761 RID: 104289 RVA: 0x003A1DBC File Offset: 0x0039FFBC
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019762 RID: 104290 RVA: 0x003A1DF3 File Offset: 0x0039FFF3
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019763 RID: 104291 RVA: 0x003A1E0D File Offset: 0x003A000D
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019764 RID: 104292 RVA: 0x003A1E2B File Offset: 0x003A002B
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019765 RID: 104293 RVA: 0x003A1E44 File Offset: 0x003A0044
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019766 RID: 104294 RVA: 0x003A1E4F File Offset: 0x003A004F
		public static Offset<IRecallEntityGroup> EndIRecallEntityGroup(FlatBufferBuilder builder)
		{
			return new Offset<IRecallEntityGroup>(builder.EndTable());
		}

		// Token: 0x06019767 RID: 104295 RVA: 0x003A1E5C File Offset: 0x003A005C
		public IRecallEntityGroupT UnPack()
		{
			IRecallEntityGroupT recallEntityGroupT = new IRecallEntityGroupT();
			this.UnPackTo(recallEntityGroupT);
			return recallEntityGroupT;
		}

		// Token: 0x06019768 RID: 104296 RVA: 0x003A1E78 File Offset: 0x003A0078
		public void UnPackTo(IRecallEntityGroupT _o)
		{
			_o.Index = this.Index;
			_o.Source = this.Source;
			_o.LevelId = this.LevelId;
			_o.Entities = new List<int>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add(this.Entities(i));
			}
		}

		// Token: 0x06019769 RID: 104297 RVA: 0x003A1ED8 File Offset: 0x003A00D8
		public static Offset<IRecallEntityGroup> Pack(FlatBufferBuilder builder, IRecallEntityGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallEntityGroup>);
			}
			StringOffset sourceOffset = (_o.Source == null) ? default(StringOffset) : builder.CreateString(_o.Source);
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				int[] data = _o.Entities.ToArray();
				entitiesOffset = IRecallEntityGroup.CreateEntitiesVector(builder, data);
			}
			return IRecallEntityGroup.CreateIRecallEntityGroup(builder, _o.Index, sourceOffset, _o.LevelId, entitiesOffset);
		}

		// Token: 0x0400C5FE RID: 50686
		private Table __p;
	}
}
