using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043A7 RID: 17319
	public struct INodeRefOccupations : IFlatbufferObject
	{
		// Token: 0x17007A6D RID: 31341
		// (get) Token: 0x06019C8C RID: 105612 RVA: 0x003B0F7C File Offset: 0x003AF17C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019C8D RID: 105613 RVA: 0x003B0F89 File Offset: 0x003AF189
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019C8E RID: 105614 RVA: 0x003B0F90 File Offset: 0x003AF190
		public static INodeRefOccupations GetRootAsINodeRefOccupations(ByteBuffer _bb)
		{
			return INodeRefOccupations.GetRootAsINodeRefOccupations(_bb, default(INodeRefOccupations));
		}

		// Token: 0x06019C8F RID: 105615 RVA: 0x003B0FAC File Offset: 0x003AF1AC
		public static INodeRefOccupations GetRootAsINodeRefOccupations(ByteBuffer _bb, INodeRefOccupations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019C90 RID: 105616 RVA: 0x003B0FC9 File Offset: 0x003AF1C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019C91 RID: 105617 RVA: 0x003B0FD8 File Offset: 0x003AF1D8
		public INodeRefOccupations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A6E RID: 31342
		// (get) Token: 0x06019C92 RID: 105618 RVA: 0x003B0FE8 File Offset: 0x003AF1E8
		public int NodeId
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

		// Token: 0x06019C93 RID: 105619 RVA: 0x003B1024 File Offset: 0x003AF224
		public INodeRefOccupationData? Occupations(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INodeRefOccupationData?(default(INodeRefOccupationData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007A6F RID: 31343
		// (get) Token: 0x06019C94 RID: 105620 RVA: 0x003B1084 File Offset: 0x003AF284
		public int OccupationsLength
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

		// Token: 0x06019C95 RID: 105621 RVA: 0x003B10AF File Offset: 0x003AF2AF
		public static Offset<INodeRefOccupations> CreateINodeRefOccupations(FlatBufferBuilder builder, int NodeId = 0, VectorOffset OccupationsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			INodeRefOccupations.AddOccupations(builder, OccupationsOffset);
			INodeRefOccupations.AddNodeId(builder, NodeId);
			return INodeRefOccupations.EndINodeRefOccupations(builder);
		}

		// Token: 0x06019C96 RID: 105622 RVA: 0x003B10CC File Offset: 0x003AF2CC
		public static void StartINodeRefOccupations(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019C97 RID: 105623 RVA: 0x003B10D5 File Offset: 0x003AF2D5
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(0, nodeId, 0);
		}

		// Token: 0x06019C98 RID: 105624 RVA: 0x003B10E0 File Offset: 0x003AF2E0
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(1, occupationsOffset.Value, 0);
		}

		// Token: 0x06019C99 RID: 105625 RVA: 0x003B10F0 File Offset: 0x003AF2F0
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019C9A RID: 105626 RVA: 0x003B1130 File Offset: 0x003AF330
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C9B RID: 105627 RVA: 0x003B114A File Offset: 0x003AF34A
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INodeRefOccupationData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019C9C RID: 105628 RVA: 0x003B1168 File Offset: 0x003AF368
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INodeRefOccupationData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019C9D RID: 105629 RVA: 0x003B1181 File Offset: 0x003AF381
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019C9E RID: 105630 RVA: 0x003B118C File Offset: 0x003AF38C
		public static Offset<INodeRefOccupations> EndINodeRefOccupations(FlatBufferBuilder builder)
		{
			return new Offset<INodeRefOccupations>(builder.EndTable());
		}

		// Token: 0x06019C9F RID: 105631 RVA: 0x003B119C File Offset: 0x003AF39C
		public INodeRefOccupationsT UnPack()
		{
			INodeRefOccupationsT nodeRefOccupationsT = new INodeRefOccupationsT();
			this.UnPackTo(nodeRefOccupationsT);
			return nodeRefOccupationsT;
		}

		// Token: 0x06019CA0 RID: 105632 RVA: 0x003B11B8 File Offset: 0x003AF3B8
		public void UnPackTo(INodeRefOccupationsT _o)
		{
			_o.NodeId = this.NodeId;
			_o.Occupations = new List<INodeRefOccupationDataT>();
			for (int i = 0; i < this.OccupationsLength; i++)
			{
				_o.Occupations.Add((this.Occupations(i) != null) ? this.Occupations(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06019CA1 RID: 105633 RVA: 0x003B1224 File Offset: 0x003AF424
		public static Offset<INodeRefOccupations> Pack(FlatBufferBuilder builder, INodeRefOccupationsT _o)
		{
			if (_o == null)
			{
				return default(Offset<INodeRefOccupations>);
			}
			VectorOffset occupationsOffset = default(VectorOffset);
			if (_o.Occupations != null)
			{
				Offset<INodeRefOccupationData>[] array = new Offset<INodeRefOccupationData>[_o.Occupations.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INodeRefOccupationData.Pack(builder, _o.Occupations[i]);
				}
				occupationsOffset = INodeRefOccupations.CreateOccupationsVector(builder, array);
			}
			return INodeRefOccupations.CreateINodeRefOccupations(builder, _o.NodeId, occupationsOffset);
		}

		// Token: 0x0400C1DD RID: 49629
		private Table __p;
	}
}
