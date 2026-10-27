using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D10 RID: 15632
	public struct IAreaQuestTracking : IFlatbufferObject
	{
		// Token: 0x17006B3B RID: 27451
		// (get) Token: 0x06015901 RID: 88321 RVA: 0x0031D5F1 File Offset: 0x0031B7F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015902 RID: 88322 RVA: 0x0031D5FE File Offset: 0x0031B7FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015903 RID: 88323 RVA: 0x0031D608 File Offset: 0x0031B808
		public static IAreaQuestTracking GetRootAsIAreaQuestTracking(ByteBuffer _bb)
		{
			return IAreaQuestTracking.GetRootAsIAreaQuestTracking(_bb, default(IAreaQuestTracking));
		}

		// Token: 0x06015904 RID: 88324 RVA: 0x0031D624 File Offset: 0x0031B824
		public static IAreaQuestTracking GetRootAsIAreaQuestTracking(ByteBuffer _bb, IAreaQuestTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015905 RID: 88325 RVA: 0x0031D641 File Offset: 0x0031B841
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015906 RID: 88326 RVA: 0x0031D650 File Offset: 0x0031B850
		public IAreaQuestTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B3C RID: 27452
		// (get) Token: 0x06015907 RID: 88327 RVA: 0x0031D660 File Offset: 0x0031B860
		public int QuestId
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

		// Token: 0x17006B3D RID: 27453
		// (get) Token: 0x06015908 RID: 88328 RVA: 0x0031D69C File Offset: 0x0031B89C
		public int NodeId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015909 RID: 88329 RVA: 0x0031D6D8 File Offset: 0x0031B8D8
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006B3E RID: 27454
		// (get) Token: 0x0601590A RID: 88330 RVA: 0x0031D718 File Offset: 0x0031B918
		public int AreaIdsLength
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

		// Token: 0x0601590B RID: 88331 RVA: 0x0031D743 File Offset: 0x0031B943
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601590C RID: 88332 RVA: 0x0031D752 File Offset: 0x0031B952
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0601590D RID: 88333 RVA: 0x0031D760 File Offset: 0x0031B960
		public static Offset<IAreaQuestTracking> CreateIAreaQuestTracking(FlatBufferBuilder builder, int QuestId = 0, int NodeId = 0, VectorOffset AreaIdsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IAreaQuestTracking.AddAreaIds(builder, AreaIdsOffset);
			IAreaQuestTracking.AddNodeId(builder, NodeId);
			IAreaQuestTracking.AddQuestId(builder, QuestId);
			return IAreaQuestTracking.EndIAreaQuestTracking(builder);
		}

		// Token: 0x0601590E RID: 88334 RVA: 0x0031D784 File Offset: 0x0031B984
		public static void StartIAreaQuestTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601590F RID: 88335 RVA: 0x0031D78D File Offset: 0x0031B98D
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(0, questId, 0);
		}

		// Token: 0x06015910 RID: 88336 RVA: 0x0031D798 File Offset: 0x0031B998
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x06015911 RID: 88337 RVA: 0x0031D7A3 File Offset: 0x0031B9A3
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(2, areaIdsOffset.Value, 0);
		}

		// Token: 0x06015912 RID: 88338 RVA: 0x0031D7B4 File Offset: 0x0031B9B4
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015913 RID: 88339 RVA: 0x0031D7EB File Offset: 0x0031B9EB
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015914 RID: 88340 RVA: 0x0031D805 File Offset: 0x0031BA05
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015915 RID: 88341 RVA: 0x0031D823 File Offset: 0x0031BA23
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015916 RID: 88342 RVA: 0x0031D83C File Offset: 0x0031BA3C
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015917 RID: 88343 RVA: 0x0031D847 File Offset: 0x0031BA47
		public static Offset<IAreaQuestTracking> EndIAreaQuestTracking(FlatBufferBuilder builder)
		{
			return new Offset<IAreaQuestTracking>(builder.EndTable());
		}

		// Token: 0x06015918 RID: 88344 RVA: 0x0031D854 File Offset: 0x0031BA54
		public IAreaQuestTrackingT UnPack()
		{
			IAreaQuestTrackingT areaQuestTrackingT = new IAreaQuestTrackingT();
			this.UnPackTo(areaQuestTrackingT);
			return areaQuestTrackingT;
		}

		// Token: 0x06015919 RID: 88345 RVA: 0x0031D870 File Offset: 0x0031BA70
		public void UnPackTo(IAreaQuestTrackingT _o)
		{
			_o.QuestId = this.QuestId;
			_o.NodeId = this.NodeId;
			_o.AreaIds = new List<int>();
			for (int i = 0; i < this.AreaIdsLength; i++)
			{
				_o.AreaIds.Add(this.AreaIds(i));
			}
		}

		// Token: 0x0601591A RID: 88346 RVA: 0x0031D8C4 File Offset: 0x0031BAC4
		public static Offset<IAreaQuestTracking> Pack(FlatBufferBuilder builder, IAreaQuestTrackingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAreaQuestTracking>);
			}
			VectorOffset areaIdsOffset = default(VectorOffset);
			if (_o.AreaIds != null)
			{
				int[] data = _o.AreaIds.ToArray();
				areaIdsOffset = IAreaQuestTracking.CreateAreaIdsVector(builder, data);
			}
			return IAreaQuestTracking.CreateIAreaQuestTracking(builder, _o.QuestId, _o.NodeId, areaIdsOffset);
		}

		// Token: 0x0400B5C3 RID: 46531
		private Table __p;
	}
}
