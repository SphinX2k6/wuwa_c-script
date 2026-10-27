using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A3F RID: 19007
	public struct ICheckGiantTotalProgressInteractActivatedNode : IFlatbufferObject
	{
		// Token: 0x1700899A RID: 35226
		// (get) Token: 0x0601DC22 RID: 121890 RVA: 0x0042F49E File Offset: 0x0042D69E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DC23 RID: 121891 RVA: 0x0042F4AB File Offset: 0x0042D6AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DC24 RID: 121892 RVA: 0x0042F4B4 File Offset: 0x0042D6B4
		public static ICheckGiantTotalProgressInteractActivatedNode GetRootAsICheckGiantTotalProgressInteractActivatedNode(ByteBuffer _bb)
		{
			return ICheckGiantTotalProgressInteractActivatedNode.GetRootAsICheckGiantTotalProgressInteractActivatedNode(_bb, default(ICheckGiantTotalProgressInteractActivatedNode));
		}

		// Token: 0x0601DC25 RID: 121893 RVA: 0x0042F4D0 File Offset: 0x0042D6D0
		public static ICheckGiantTotalProgressInteractActivatedNode GetRootAsICheckGiantTotalProgressInteractActivatedNode(ByteBuffer _bb, ICheckGiantTotalProgressInteractActivatedNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DC26 RID: 121894 RVA: 0x0042F4ED File Offset: 0x0042D6ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DC27 RID: 121895 RVA: 0x0042F4FC File Offset: 0x0042D6FC
		public ICheckGiantTotalProgressInteractActivatedNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700899B RID: 35227
		// (get) Token: 0x0601DC28 RID: 121896 RVA: 0x0042F50C File Offset: 0x0042D70C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DC29 RID: 121897 RVA: 0x0042F548 File Offset: 0x0042D748
		public int NodeIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700899C RID: 35228
		// (get) Token: 0x0601DC2A RID: 121898 RVA: 0x0042F588 File Offset: 0x0042D788
		public int NodeIdsLength
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

		// Token: 0x0601DC2B RID: 121899 RVA: 0x0042F5B3 File Offset: 0x0042D7B3
		public Span<int> GetNodeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601DC2C RID: 121900 RVA: 0x0042F5C2 File Offset: 0x0042D7C2
		public int[] GetNodeIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601DC2D RID: 121901 RVA: 0x0042F5D0 File Offset: 0x0042D7D0
		public static Offset<ICheckGiantTotalProgressInteractActivatedNode> CreateICheckGiantTotalProgressInteractActivatedNode(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, VectorOffset NodeIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICheckGiantTotalProgressInteractActivatedNode.AddNodeIds(builder, NodeIdsOffset);
			ICheckGiantTotalProgressInteractActivatedNode.AddType(builder, Type);
			return ICheckGiantTotalProgressInteractActivatedNode.EndICheckGiantTotalProgressInteractActivatedNode(builder);
		}

		// Token: 0x0601DC2E RID: 121902 RVA: 0x0042F5ED File Offset: 0x0042D7ED
		public static void StartICheckGiantTotalProgressInteractActivatedNode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DC2F RID: 121903 RVA: 0x0042F5F6 File Offset: 0x0042D7F6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DC30 RID: 121904 RVA: 0x0042F601 File Offset: 0x0042D801
		public static void AddNodeIds(FlatBufferBuilder builder, VectorOffset nodeIdsOffset)
		{
			builder.AddOffset(1, nodeIdsOffset.Value, 0);
		}

		// Token: 0x0601DC31 RID: 121905 RVA: 0x0042F614 File Offset: 0x0042D814
		public static VectorOffset CreateNodeIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DC32 RID: 121906 RVA: 0x0042F64B File Offset: 0x0042D84B
		public static VectorOffset CreateNodeIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DC33 RID: 121907 RVA: 0x0042F665 File Offset: 0x0042D865
		public static VectorOffset CreateNodeIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DC34 RID: 121908 RVA: 0x0042F683 File Offset: 0x0042D883
		public static VectorOffset CreateNodeIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DC35 RID: 121909 RVA: 0x0042F69C File Offset: 0x0042D89C
		public static void StartNodeIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DC36 RID: 121910 RVA: 0x0042F6A7 File Offset: 0x0042D8A7
		public static Offset<ICheckGiantTotalProgressInteractActivatedNode> EndICheckGiantTotalProgressInteractActivatedNode(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGiantTotalProgressInteractActivatedNode>(builder.EndTable());
		}

		// Token: 0x0601DC37 RID: 121911 RVA: 0x0042F6B4 File Offset: 0x0042D8B4
		public ICheckGiantTotalProgressInteractActivatedNodeT UnPack()
		{
			ICheckGiantTotalProgressInteractActivatedNodeT checkGiantTotalProgressInteractActivatedNodeT = new ICheckGiantTotalProgressInteractActivatedNodeT();
			this.UnPackTo(checkGiantTotalProgressInteractActivatedNodeT);
			return checkGiantTotalProgressInteractActivatedNodeT;
		}

		// Token: 0x0601DC38 RID: 121912 RVA: 0x0042F6D0 File Offset: 0x0042D8D0
		public void UnPackTo(ICheckGiantTotalProgressInteractActivatedNodeT _o)
		{
			_o.Type = this.Type;
			_o.NodeIds = new List<int>();
			for (int i = 0; i < this.NodeIdsLength; i++)
			{
				_o.NodeIds.Add(this.NodeIds(i));
			}
		}

		// Token: 0x0601DC39 RID: 121913 RVA: 0x0042F718 File Offset: 0x0042D918
		public static Offset<ICheckGiantTotalProgressInteractActivatedNode> Pack(FlatBufferBuilder builder, ICheckGiantTotalProgressInteractActivatedNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckGiantTotalProgressInteractActivatedNode>);
			}
			VectorOffset nodeIdsOffset = default(VectorOffset);
			if (_o.NodeIds != null)
			{
				int[] data = _o.NodeIds.ToArray();
				nodeIdsOffset = ICheckGiantTotalProgressInteractActivatedNode.CreateNodeIdsVector(builder, data);
			}
			return ICheckGiantTotalProgressInteractActivatedNode.CreateICheckGiantTotalProgressInteractActivatedNode(builder, _o.Type, nodeIdsOffset);
		}

		// Token: 0x0400D295 RID: 53909
		private Table __p;
	}
}
