using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004094 RID: 16532
	public struct IRecallEntry : IFlatbufferObject
	{
		// Token: 0x170074AA RID: 29866
		// (get) Token: 0x060180F9 RID: 98553 RVA: 0x003784FF File Offset: 0x003766FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060180FA RID: 98554 RVA: 0x0037850C File Offset: 0x0037670C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060180FB RID: 98555 RVA: 0x00378514 File Offset: 0x00376714
		public static IRecallEntry GetRootAsIRecallEntry(ByteBuffer _bb)
		{
			return IRecallEntry.GetRootAsIRecallEntry(_bb, default(IRecallEntry));
		}

		// Token: 0x060180FC RID: 98556 RVA: 0x00378530 File Offset: 0x00376730
		public static IRecallEntry GetRootAsIRecallEntry(ByteBuffer _bb, IRecallEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060180FD RID: 98557 RVA: 0x0037854D File Offset: 0x0037674D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060180FE RID: 98558 RVA: 0x0037855C File Offset: 0x0037675C
		public IRecallEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074AB RID: 29867
		// (get) Token: 0x060180FF RID: 98559 RVA: 0x0037856C File Offset: 0x0037676C
		public int RecallId
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

		// Token: 0x06018100 RID: 98560 RVA: 0x003785A8 File Offset: 0x003767A8
		public int IncludeGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170074AC RID: 29868
		// (get) Token: 0x06018101 RID: 98561 RVA: 0x003785E8 File Offset: 0x003767E8
		public int IncludeGroupsLength
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

		// Token: 0x06018102 RID: 98562 RVA: 0x00378613 File Offset: 0x00376813
		public Span<int> GetIncludeGroupsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06018103 RID: 98563 RVA: 0x00378622 File Offset: 0x00376822
		public int[] GetIncludeGroupsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06018104 RID: 98564 RVA: 0x00378630 File Offset: 0x00376830
		public int ExcludeGroups(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170074AD RID: 29869
		// (get) Token: 0x06018105 RID: 98565 RVA: 0x00378670 File Offset: 0x00376870
		public int ExcludeGroupsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06018106 RID: 98566 RVA: 0x0037869B File Offset: 0x0037689B
		public Span<int> GetExcludeGroupsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06018107 RID: 98567 RVA: 0x003786AA File Offset: 0x003768AA
		public int[] GetExcludeGroupsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06018108 RID: 98568 RVA: 0x003786B8 File Offset: 0x003768B8
		public static Offset<IRecallEntry> CreateIRecallEntry(FlatBufferBuilder builder, int RecallId = 0, VectorOffset IncludeGroupsOffset = default(VectorOffset), VectorOffset ExcludeGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IRecallEntry.AddExcludeGroups(builder, ExcludeGroupsOffset);
			IRecallEntry.AddIncludeGroups(builder, IncludeGroupsOffset);
			IRecallEntry.AddRecallId(builder, RecallId);
			return IRecallEntry.EndIRecallEntry(builder);
		}

		// Token: 0x06018109 RID: 98569 RVA: 0x003786DC File Offset: 0x003768DC
		public static void StartIRecallEntry(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601810A RID: 98570 RVA: 0x003786E5 File Offset: 0x003768E5
		public static void AddRecallId(FlatBufferBuilder builder, int recallId)
		{
			builder.AddInt(0, recallId, 0);
		}

		// Token: 0x0601810B RID: 98571 RVA: 0x003786F0 File Offset: 0x003768F0
		public static void AddIncludeGroups(FlatBufferBuilder builder, VectorOffset includeGroupsOffset)
		{
			builder.AddOffset(1, includeGroupsOffset.Value, 0);
		}

		// Token: 0x0601810C RID: 98572 RVA: 0x00378700 File Offset: 0x00376900
		public static VectorOffset CreateIncludeGroupsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601810D RID: 98573 RVA: 0x00378737 File Offset: 0x00376937
		public static VectorOffset CreateIncludeGroupsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601810E RID: 98574 RVA: 0x00378751 File Offset: 0x00376951
		public static VectorOffset CreateIncludeGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601810F RID: 98575 RVA: 0x0037876F File Offset: 0x0037696F
		public static VectorOffset CreateIncludeGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018110 RID: 98576 RVA: 0x00378788 File Offset: 0x00376988
		public static void StartIncludeGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018111 RID: 98577 RVA: 0x00378793 File Offset: 0x00376993
		public static void AddExcludeGroups(FlatBufferBuilder builder, VectorOffset excludeGroupsOffset)
		{
			builder.AddOffset(2, excludeGroupsOffset.Value, 0);
		}

		// Token: 0x06018112 RID: 98578 RVA: 0x003787A4 File Offset: 0x003769A4
		public static VectorOffset CreateExcludeGroupsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06018113 RID: 98579 RVA: 0x003787DB File Offset: 0x003769DB
		public static VectorOffset CreateExcludeGroupsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018114 RID: 98580 RVA: 0x003787F5 File Offset: 0x003769F5
		public static VectorOffset CreateExcludeGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018115 RID: 98581 RVA: 0x00378813 File Offset: 0x00376A13
		public static VectorOffset CreateExcludeGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018116 RID: 98582 RVA: 0x0037882C File Offset: 0x00376A2C
		public static void StartExcludeGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018117 RID: 98583 RVA: 0x00378837 File Offset: 0x00376A37
		public static Offset<IRecallEntry> EndIRecallEntry(FlatBufferBuilder builder)
		{
			return new Offset<IRecallEntry>(builder.EndTable());
		}

		// Token: 0x06018118 RID: 98584 RVA: 0x00378844 File Offset: 0x00376A44
		public IRecallEntryT UnPack()
		{
			IRecallEntryT recallEntryT = new IRecallEntryT();
			this.UnPackTo(recallEntryT);
			return recallEntryT;
		}

		// Token: 0x06018119 RID: 98585 RVA: 0x00378860 File Offset: 0x00376A60
		public void UnPackTo(IRecallEntryT _o)
		{
			_o.RecallId = this.RecallId;
			_o.IncludeGroups = new List<int>();
			for (int i = 0; i < this.IncludeGroupsLength; i++)
			{
				_o.IncludeGroups.Add(this.IncludeGroups(i));
			}
			_o.ExcludeGroups = new List<int>();
			for (int j = 0; j < this.ExcludeGroupsLength; j++)
			{
				_o.ExcludeGroups.Add(this.ExcludeGroups(j));
			}
		}

		// Token: 0x0601811A RID: 98586 RVA: 0x003788D8 File Offset: 0x00376AD8
		public static Offset<IRecallEntry> Pack(FlatBufferBuilder builder, IRecallEntryT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallEntry>);
			}
			VectorOffset includeGroupsOffset = default(VectorOffset);
			if (_o.IncludeGroups != null)
			{
				int[] data = _o.IncludeGroups.ToArray();
				includeGroupsOffset = IRecallEntry.CreateIncludeGroupsVector(builder, data);
			}
			VectorOffset excludeGroupsOffset = default(VectorOffset);
			if (_o.ExcludeGroups != null)
			{
				int[] data2 = _o.ExcludeGroups.ToArray();
				excludeGroupsOffset = IRecallEntry.CreateExcludeGroupsVector(builder, data2);
			}
			return IRecallEntry.CreateIRecallEntry(builder, _o.RecallId, includeGroupsOffset, excludeGroupsOffset);
		}

		// Token: 0x0400BC1F RID: 48159
		private Table __p;
	}
}
