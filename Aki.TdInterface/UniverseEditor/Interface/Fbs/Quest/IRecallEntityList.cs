using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004091 RID: 16529
	public struct IRecallEntityList : IFlatbufferObject
	{
		// Token: 0x170074A5 RID: 29861
		// (get) Token: 0x060180DB RID: 98523 RVA: 0x003781D2 File Offset: 0x003763D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060180DC RID: 98524 RVA: 0x003781DF File Offset: 0x003763DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060180DD RID: 98525 RVA: 0x003781E8 File Offset: 0x003763E8
		public static IRecallEntityList GetRootAsIRecallEntityList(ByteBuffer _bb)
		{
			return IRecallEntityList.GetRootAsIRecallEntityList(_bb, default(IRecallEntityList));
		}

		// Token: 0x060180DE RID: 98526 RVA: 0x00378204 File Offset: 0x00376404
		public static IRecallEntityList GetRootAsIRecallEntityList(ByteBuffer _bb, IRecallEntityList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060180DF RID: 98527 RVA: 0x00378221 File Offset: 0x00376421
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060180E0 RID: 98528 RVA: 0x00378230 File Offset: 0x00376430
		public IRecallEntityList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074A6 RID: 29862
		// (get) Token: 0x060180E1 RID: 98529 RVA: 0x00378240 File Offset: 0x00376440
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

		// Token: 0x060180E2 RID: 98530 RVA: 0x0037827C File Offset: 0x0037647C
		public int EntityList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170074A7 RID: 29863
		// (get) Token: 0x060180E3 RID: 98531 RVA: 0x003782BC File Offset: 0x003764BC
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

		// Token: 0x060180E4 RID: 98532 RVA: 0x003782E7 File Offset: 0x003764E7
		public Span<int> GetEntityListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060180E5 RID: 98533 RVA: 0x003782F6 File Offset: 0x003764F6
		public int[] GetEntityListArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060180E6 RID: 98534 RVA: 0x00378304 File Offset: 0x00376504
		public static Offset<IRecallEntityList> CreateIRecallEntityList(FlatBufferBuilder builder, int LevelId = 0, VectorOffset EntityListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRecallEntityList.AddEntityList(builder, EntityListOffset);
			IRecallEntityList.AddLevelId(builder, LevelId);
			return IRecallEntityList.EndIRecallEntityList(builder);
		}

		// Token: 0x060180E7 RID: 98535 RVA: 0x00378321 File Offset: 0x00376521
		public static void StartIRecallEntityList(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060180E8 RID: 98536 RVA: 0x0037832A File Offset: 0x0037652A
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x060180E9 RID: 98537 RVA: 0x00378335 File Offset: 0x00376535
		public static void AddEntityList(FlatBufferBuilder builder, VectorOffset entityListOffset)
		{
			builder.AddOffset(1, entityListOffset.Value, 0);
		}

		// Token: 0x060180EA RID: 98538 RVA: 0x00378348 File Offset: 0x00376548
		public static VectorOffset CreateEntityListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060180EB RID: 98539 RVA: 0x0037837F File Offset: 0x0037657F
		public static VectorOffset CreateEntityListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060180EC RID: 98540 RVA: 0x00378399 File Offset: 0x00376599
		public static VectorOffset CreateEntityListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060180ED RID: 98541 RVA: 0x003783B7 File Offset: 0x003765B7
		public static VectorOffset CreateEntityListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060180EE RID: 98542 RVA: 0x003783D0 File Offset: 0x003765D0
		public static void StartEntityListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060180EF RID: 98543 RVA: 0x003783DB File Offset: 0x003765DB
		public static Offset<IRecallEntityList> EndIRecallEntityList(FlatBufferBuilder builder)
		{
			return new Offset<IRecallEntityList>(builder.EndTable());
		}

		// Token: 0x060180F0 RID: 98544 RVA: 0x003783E8 File Offset: 0x003765E8
		public IRecallEntityListT UnPack()
		{
			IRecallEntityListT recallEntityListT = new IRecallEntityListT();
			this.UnPackTo(recallEntityListT);
			return recallEntityListT;
		}

		// Token: 0x060180F1 RID: 98545 RVA: 0x00378404 File Offset: 0x00376604
		public void UnPackTo(IRecallEntityListT _o)
		{
			_o.LevelId = this.LevelId;
			_o.EntityList = new List<int>();
			for (int i = 0; i < this.EntityListLength; i++)
			{
				_o.EntityList.Add(this.EntityList(i));
			}
		}

		// Token: 0x060180F2 RID: 98546 RVA: 0x0037844C File Offset: 0x0037664C
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

		// Token: 0x0400BC1C RID: 48156
		private Table __p;
	}
}
