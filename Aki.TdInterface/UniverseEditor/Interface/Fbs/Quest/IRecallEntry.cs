using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044D5 RID: 17621
	public struct IRecallEntry : IFlatbufferObject
	{
		// Token: 0x17007AAC RID: 31404
		// (get) Token: 0x06019792 RID: 104338 RVA: 0x003A2337 File Offset: 0x003A0537
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019793 RID: 104339 RVA: 0x003A2344 File Offset: 0x003A0544
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019794 RID: 104340 RVA: 0x003A234C File Offset: 0x003A054C
		public static IRecallEntry GetRootAsIRecallEntry(ByteBuffer _bb)
		{
			return IRecallEntry.GetRootAsIRecallEntry(_bb, default(IRecallEntry));
		}

		// Token: 0x06019795 RID: 104341 RVA: 0x003A2368 File Offset: 0x003A0568
		public static IRecallEntry GetRootAsIRecallEntry(ByteBuffer _bb, IRecallEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019796 RID: 104342 RVA: 0x003A2385 File Offset: 0x003A0585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019797 RID: 104343 RVA: 0x003A2394 File Offset: 0x003A0594
		public IRecallEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AAD RID: 31405
		// (get) Token: 0x06019798 RID: 104344 RVA: 0x003A23A4 File Offset: 0x003A05A4
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

		// Token: 0x06019799 RID: 104345 RVA: 0x003A23E0 File Offset: 0x003A05E0
		public int IncludeGroups(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007AAE RID: 31406
		// (get) Token: 0x0601979A RID: 104346 RVA: 0x003A2420 File Offset: 0x003A0620
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

		// Token: 0x0601979B RID: 104347 RVA: 0x003A244B File Offset: 0x003A064B
		public Span<int> GetIncludeGroupsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601979C RID: 104348 RVA: 0x003A245A File Offset: 0x003A065A
		public int[] GetIncludeGroupsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601979D RID: 104349 RVA: 0x003A2468 File Offset: 0x003A0668
		public int ExcludeGroups(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007AAF RID: 31407
		// (get) Token: 0x0601979E RID: 104350 RVA: 0x003A24A8 File Offset: 0x003A06A8
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

		// Token: 0x0601979F RID: 104351 RVA: 0x003A24D3 File Offset: 0x003A06D3
		public Span<int> GetExcludeGroupsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060197A0 RID: 104352 RVA: 0x003A24E2 File Offset: 0x003A06E2
		public int[] GetExcludeGroupsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x060197A1 RID: 104353 RVA: 0x003A24F0 File Offset: 0x003A06F0
		public static Offset<IRecallEntry> CreateIRecallEntry(FlatBufferBuilder builder, int RecallId = 0, VectorOffset IncludeGroupsOffset = default(VectorOffset), VectorOffset ExcludeGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IRecallEntry.AddExcludeGroups(builder, ExcludeGroupsOffset);
			IRecallEntry.AddIncludeGroups(builder, IncludeGroupsOffset);
			IRecallEntry.AddRecallId(builder, RecallId);
			return IRecallEntry.EndIRecallEntry(builder);
		}

		// Token: 0x060197A2 RID: 104354 RVA: 0x003A2514 File Offset: 0x003A0714
		public static void StartIRecallEntry(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060197A3 RID: 104355 RVA: 0x003A251D File Offset: 0x003A071D
		public static void AddRecallId(FlatBufferBuilder builder, int recallId)
		{
			builder.AddInt(0, recallId, 0);
		}

		// Token: 0x060197A4 RID: 104356 RVA: 0x003A2528 File Offset: 0x003A0728
		public static void AddIncludeGroups(FlatBufferBuilder builder, VectorOffset includeGroupsOffset)
		{
			builder.AddOffset(1, includeGroupsOffset.Value, 0);
		}

		// Token: 0x060197A5 RID: 104357 RVA: 0x003A2538 File Offset: 0x003A0738
		public static VectorOffset CreateIncludeGroupsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060197A6 RID: 104358 RVA: 0x003A256F File Offset: 0x003A076F
		public static VectorOffset CreateIncludeGroupsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060197A7 RID: 104359 RVA: 0x003A2589 File Offset: 0x003A0789
		public static VectorOffset CreateIncludeGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060197A8 RID: 104360 RVA: 0x003A25A7 File Offset: 0x003A07A7
		public static VectorOffset CreateIncludeGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060197A9 RID: 104361 RVA: 0x003A25C0 File Offset: 0x003A07C0
		public static void StartIncludeGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060197AA RID: 104362 RVA: 0x003A25CB File Offset: 0x003A07CB
		public static void AddExcludeGroups(FlatBufferBuilder builder, VectorOffset excludeGroupsOffset)
		{
			builder.AddOffset(2, excludeGroupsOffset.Value, 0);
		}

		// Token: 0x060197AB RID: 104363 RVA: 0x003A25DC File Offset: 0x003A07DC
		public static VectorOffset CreateExcludeGroupsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060197AC RID: 104364 RVA: 0x003A2613 File Offset: 0x003A0813
		public static VectorOffset CreateExcludeGroupsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060197AD RID: 104365 RVA: 0x003A262D File Offset: 0x003A082D
		public static VectorOffset CreateExcludeGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060197AE RID: 104366 RVA: 0x003A264B File Offset: 0x003A084B
		public static VectorOffset CreateExcludeGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060197AF RID: 104367 RVA: 0x003A2664 File Offset: 0x003A0864
		public static void StartExcludeGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060197B0 RID: 104368 RVA: 0x003A266F File Offset: 0x003A086F
		public static Offset<IRecallEntry> EndIRecallEntry(FlatBufferBuilder builder)
		{
			return new Offset<IRecallEntry>(builder.EndTable());
		}

		// Token: 0x060197B1 RID: 104369 RVA: 0x003A267C File Offset: 0x003A087C
		public IRecallEntryT UnPack()
		{
			IRecallEntryT recallEntryT = new IRecallEntryT();
			this.UnPackTo(recallEntryT);
			return recallEntryT;
		}

		// Token: 0x060197B2 RID: 104370 RVA: 0x003A2698 File Offset: 0x003A0898
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

		// Token: 0x060197B3 RID: 104371 RVA: 0x003A2710 File Offset: 0x003A0910
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

		// Token: 0x0400C606 RID: 50694
		private Table __p;
	}
}
