using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004809 RID: 18441
	public struct INodeRefOccupations : IFlatbufferObject
	{
		// Token: 0x170080A2 RID: 32930
		// (get) Token: 0x0601B41A RID: 111642 RVA: 0x003DC9A4 File Offset: 0x003DABA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B41B RID: 111643 RVA: 0x003DC9B1 File Offset: 0x003DABB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B41C RID: 111644 RVA: 0x003DC9B8 File Offset: 0x003DABB8
		public static INodeRefOccupations GetRootAsINodeRefOccupations(ByteBuffer _bb)
		{
			return INodeRefOccupations.GetRootAsINodeRefOccupations(_bb, default(INodeRefOccupations));
		}

		// Token: 0x0601B41D RID: 111645 RVA: 0x003DC9D4 File Offset: 0x003DABD4
		public static INodeRefOccupations GetRootAsINodeRefOccupations(ByteBuffer _bb, INodeRefOccupations obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B41E RID: 111646 RVA: 0x003DC9F1 File Offset: 0x003DABF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B41F RID: 111647 RVA: 0x003DCA00 File Offset: 0x003DAC00
		public INodeRefOccupations __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080A3 RID: 32931
		// (get) Token: 0x0601B420 RID: 111648 RVA: 0x003DCA10 File Offset: 0x003DAC10
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

		// Token: 0x0601B421 RID: 111649 RVA: 0x003DCA4C File Offset: 0x003DAC4C
		public INodeRefOccupationData? Occupations(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INodeRefOccupationData?(default(INodeRefOccupationData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170080A4 RID: 32932
		// (get) Token: 0x0601B422 RID: 111650 RVA: 0x003DCAAC File Offset: 0x003DACAC
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

		// Token: 0x0601B423 RID: 111651 RVA: 0x003DCAD7 File Offset: 0x003DACD7
		public static Offset<INodeRefOccupations> CreateINodeRefOccupations(FlatBufferBuilder builder, int NodeId = 0, VectorOffset OccupationsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			INodeRefOccupations.AddOccupations(builder, OccupationsOffset);
			INodeRefOccupations.AddNodeId(builder, NodeId);
			return INodeRefOccupations.EndINodeRefOccupations(builder);
		}

		// Token: 0x0601B424 RID: 111652 RVA: 0x003DCAF4 File Offset: 0x003DACF4
		public static void StartINodeRefOccupations(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B425 RID: 111653 RVA: 0x003DCAFD File Offset: 0x003DACFD
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(0, nodeId, 0);
		}

		// Token: 0x0601B426 RID: 111654 RVA: 0x003DCB08 File Offset: 0x003DAD08
		public static void AddOccupations(FlatBufferBuilder builder, VectorOffset occupationsOffset)
		{
			builder.AddOffset(1, occupationsOffset.Value, 0);
		}

		// Token: 0x0601B427 RID: 111655 RVA: 0x003DCB18 File Offset: 0x003DAD18
		public static VectorOffset CreateOccupationsVector(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601B428 RID: 111656 RVA: 0x003DCB58 File Offset: 0x003DAD58
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, Offset<INodeRefOccupationData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B429 RID: 111657 RVA: 0x003DCB72 File Offset: 0x003DAD72
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INodeRefOccupationData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INodeRefOccupationData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601B42A RID: 111658 RVA: 0x003DCB90 File Offset: 0x003DAD90
		public static VectorOffset CreateOccupationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INodeRefOccupationData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601B42B RID: 111659 RVA: 0x003DCBA9 File Offset: 0x003DADA9
		public static void StartOccupationsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601B42C RID: 111660 RVA: 0x003DCBB4 File Offset: 0x003DADB4
		public static Offset<INodeRefOccupations> EndINodeRefOccupations(FlatBufferBuilder builder)
		{
			return new Offset<INodeRefOccupations>(builder.EndTable());
		}

		// Token: 0x0601B42D RID: 111661 RVA: 0x003DCBC4 File Offset: 0x003DADC4
		public INodeRefOccupationsT UnPack()
		{
			INodeRefOccupationsT nodeRefOccupationsT = new INodeRefOccupationsT();
			this.UnPackTo(nodeRefOccupationsT);
			return nodeRefOccupationsT;
		}

		// Token: 0x0601B42E RID: 111662 RVA: 0x003DCBE0 File Offset: 0x003DADE0
		public void UnPackTo(INodeRefOccupationsT _o)
		{
			_o.NodeId = this.NodeId;
			_o.Occupations = new List<INodeRefOccupationDataT>();
			for (int i = 0; i < this.OccupationsLength; i++)
			{
				_o.Occupations.Add((this.Occupations(i) != null) ? this.Occupations(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601B42F RID: 111663 RVA: 0x003DCC4C File Offset: 0x003DAE4C
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

		// Token: 0x0400CBFC RID: 52220
		private Table __p;
	}
}
