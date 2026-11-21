using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044D2 RID: 17618
	public struct IRecallEntityList : IFlatbufferObject
	{
		// Token: 0x17007AA7 RID: 31399
		// (get) Token: 0x06019774 RID: 104308 RVA: 0x003A200A File Offset: 0x003A020A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019775 RID: 104309 RVA: 0x003A2017 File Offset: 0x003A0217
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019776 RID: 104310 RVA: 0x003A2020 File Offset: 0x003A0220
		public static IRecallEntityList GetRootAsIRecallEntityList(ByteBuffer _bb)
		{
			return IRecallEntityList.GetRootAsIRecallEntityList(_bb, default(IRecallEntityList));
		}

		// Token: 0x06019777 RID: 104311 RVA: 0x003A203C File Offset: 0x003A023C
		public static IRecallEntityList GetRootAsIRecallEntityList(ByteBuffer _bb, IRecallEntityList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019778 RID: 104312 RVA: 0x003A2059 File Offset: 0x003A0259
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019779 RID: 104313 RVA: 0x003A2068 File Offset: 0x003A0268
		public IRecallEntityList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AA8 RID: 31400
		// (get) Token: 0x0601977A RID: 104314 RVA: 0x003A2078 File Offset: 0x003A0278
		public int LevelId
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

		// Token: 0x0601977B RID: 104315 RVA: 0x003A20B4 File Offset: 0x003A02B4
		public int EntityList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007AA9 RID: 31401
		// (get) Token: 0x0601977C RID: 104316 RVA: 0x003A20F4 File Offset: 0x003A02F4
		public int EntityListLength
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

		// Token: 0x0601977D RID: 104317 RVA: 0x003A211F File Offset: 0x003A031F
		public Span<int> GetEntityListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601977E RID: 104318 RVA: 0x003A212E File Offset: 0x003A032E
		public int[] GetEntityListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601977F RID: 104319 RVA: 0x003A213C File Offset: 0x003A033C
		public static Offset<IRecallEntityList> CreateIRecallEntityList(FlatBufferBuilder builder, int LevelId = 0, VectorOffset EntityListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRecallEntityList.AddEntityList(builder, EntityListOffset);
			IRecallEntityList.AddLevelId(builder, LevelId);
			return IRecallEntityList.EndIRecallEntityList(builder);
		}

		// Token: 0x06019780 RID: 104320 RVA: 0x003A2159 File Offset: 0x003A0359
		public static void StartIRecallEntityList(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019781 RID: 104321 RVA: 0x003A2162 File Offset: 0x003A0362
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x06019782 RID: 104322 RVA: 0x003A216D File Offset: 0x003A036D
		public static void AddEntityList(FlatBufferBuilder builder, VectorOffset entityListOffset)
		{
			builder.AddOffset(1, entityListOffset.Value, 0);
		}

		// Token: 0x06019783 RID: 104323 RVA: 0x003A2180 File Offset: 0x003A0380
		public static VectorOffset CreateEntityListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019784 RID: 104324 RVA: 0x003A21B7 File Offset: 0x003A03B7
		public static VectorOffset CreateEntityListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019785 RID: 104325 RVA: 0x003A21D1 File Offset: 0x003A03D1
		public static VectorOffset CreateEntityListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019786 RID: 104326 RVA: 0x003A21EF File Offset: 0x003A03EF
		public static VectorOffset CreateEntityListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019787 RID: 104327 RVA: 0x003A2208 File Offset: 0x003A0408
		public static void StartEntityListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019788 RID: 104328 RVA: 0x003A2213 File Offset: 0x003A0413
		public static Offset<IRecallEntityList> EndIRecallEntityList(FlatBufferBuilder builder)
		{
			return new Offset<IRecallEntityList>(builder.EndTable());
		}

		// Token: 0x06019789 RID: 104329 RVA: 0x003A2220 File Offset: 0x003A0420
		public IRecallEntityListT UnPack()
		{
			IRecallEntityListT recallEntityListT = new IRecallEntityListT();
			this.UnPackTo(recallEntityListT);
			return recallEntityListT;
		}

		// Token: 0x0601978A RID: 104330 RVA: 0x003A223C File Offset: 0x003A043C
		public void UnPackTo(IRecallEntityListT _o)
		{
			_o.LevelId = this.LevelId;
			_o.EntityList = new List<int>();
			for (int i = 0; i < this.EntityListLength; i++)
			{
				_o.EntityList.Add(this.EntityList(i));
			}
		}

		// Token: 0x0601978B RID: 104331 RVA: 0x003A2284 File Offset: 0x003A0484
		public static Offset<IRecallEntityList> Pack(FlatBufferBuilder builder, IRecallEntityListT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallEntityList>);
			}
			VectorOffset entityListOffset = default(VectorOffset);
			if (_o.EntityList != null)
			{
				int[] data = _o.EntityList.ToArray();
				entityListOffset = IRecallEntityList.CreateEntityListVector(builder, data);
			}
			return IRecallEntityList.CreateIRecallEntityList(builder, _o.LevelId, entityListOffset);
		}

		// Token: 0x0400C603 RID: 50691
		private Table __p;
	}
}
