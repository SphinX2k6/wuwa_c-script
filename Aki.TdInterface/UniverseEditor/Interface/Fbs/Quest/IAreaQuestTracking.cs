using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004127 RID: 16679
	public struct IAreaQuestTracking : IFlatbufferObject
	{
		// Token: 0x170070F5 RID: 28917
		// (get) Token: 0x06016E39 RID: 93753 RVA: 0x00344869 File Offset: 0x00342A69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016E3A RID: 93754 RVA: 0x00344876 File Offset: 0x00342A76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016E3B RID: 93755 RVA: 0x00344880 File Offset: 0x00342A80
		public static IAreaQuestTracking GetRootAsIAreaQuestTracking(ByteBuffer _bb)
		{
			return IAreaQuestTracking.GetRootAsIAreaQuestTracking(_bb, default(IAreaQuestTracking));
		}

		// Token: 0x06016E3C RID: 93756 RVA: 0x0034489C File Offset: 0x00342A9C
		public static IAreaQuestTracking GetRootAsIAreaQuestTracking(ByteBuffer _bb, IAreaQuestTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016E3D RID: 93757 RVA: 0x003448B9 File Offset: 0x00342AB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016E3E RID: 93758 RVA: 0x003448C8 File Offset: 0x00342AC8
		public IAreaQuestTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070F6 RID: 28918
		// (get) Token: 0x06016E3F RID: 93759 RVA: 0x003448D8 File Offset: 0x00342AD8
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

		// Token: 0x170070F7 RID: 28919
		// (get) Token: 0x06016E40 RID: 93760 RVA: 0x00344914 File Offset: 0x00342B14
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

		// Token: 0x06016E41 RID: 93761 RVA: 0x00344950 File Offset: 0x00342B50
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170070F8 RID: 28920
		// (get) Token: 0x06016E42 RID: 93762 RVA: 0x00344990 File Offset: 0x00342B90
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

		// Token: 0x06016E43 RID: 93763 RVA: 0x003449BB File Offset: 0x00342BBB
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06016E44 RID: 93764 RVA: 0x003449CA File Offset: 0x00342BCA
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x06016E45 RID: 93765 RVA: 0x003449D8 File Offset: 0x00342BD8
		public static Offset<IAreaQuestTracking> CreateIAreaQuestTracking(FlatBufferBuilder builder, int QuestId = 0, int NodeId = 0, VectorOffset AreaIdsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IAreaQuestTracking.AddAreaIds(builder, AreaIdsOffset);
			IAreaQuestTracking.AddNodeId(builder, NodeId);
			IAreaQuestTracking.AddQuestId(builder, QuestId);
			return IAreaQuestTracking.EndIAreaQuestTracking(builder);
		}

		// Token: 0x06016E46 RID: 93766 RVA: 0x003449FC File Offset: 0x00342BFC
		public static void StartIAreaQuestTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016E47 RID: 93767 RVA: 0x00344A05 File Offset: 0x00342C05
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(0, questId, 0);
		}

		// Token: 0x06016E48 RID: 93768 RVA: 0x00344A10 File Offset: 0x00342C10
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x06016E49 RID: 93769 RVA: 0x00344A1B File Offset: 0x00342C1B
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(2, areaIdsOffset.Value, 0);
		}

		// Token: 0x06016E4A RID: 93770 RVA: 0x00344A2C File Offset: 0x00342C2C
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016E4B RID: 93771 RVA: 0x00344A63 File Offset: 0x00342C63
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016E4C RID: 93772 RVA: 0x00344A7D File Offset: 0x00342C7D
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016E4D RID: 93773 RVA: 0x00344A9B File Offset: 0x00342C9B
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016E4E RID: 93774 RVA: 0x00344AB4 File Offset: 0x00342CB4
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016E4F RID: 93775 RVA: 0x00344ABF File Offset: 0x00342CBF
		public static Offset<IAreaQuestTracking> EndIAreaQuestTracking(FlatBufferBuilder builder)
		{
			return new Offset<IAreaQuestTracking>(builder.EndTable());
		}

		// Token: 0x06016E50 RID: 93776 RVA: 0x00344ACC File Offset: 0x00342CCC
		public IAreaQuestTrackingT UnPack()
		{
			IAreaQuestTrackingT areaQuestTrackingT = new IAreaQuestTrackingT();
			this.UnPackTo(areaQuestTrackingT);
			return areaQuestTrackingT;
		}

		// Token: 0x06016E51 RID: 93777 RVA: 0x00344AE8 File Offset: 0x00342CE8
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

		// Token: 0x06016E52 RID: 93778 RVA: 0x00344B3C File Offset: 0x00342D3C
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

		// Token: 0x0400BF70 RID: 49008
		private Table __p;
	}
}
