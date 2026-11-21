using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F02 RID: 20226
	public struct ICheckGiantTotalProgressInteractActivatedNode : IFlatbufferObject
	{
		// Token: 0x1700906F RID: 36975
		// (get) Token: 0x0601F6AB RID: 128683 RVA: 0x00460396 File Offset: 0x0045E596
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F6AC RID: 128684 RVA: 0x004603A3 File Offset: 0x0045E5A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F6AD RID: 128685 RVA: 0x004603AC File Offset: 0x0045E5AC
		public static ICheckGiantTotalProgressInteractActivatedNode GetRootAsICheckGiantTotalProgressInteractActivatedNode(ByteBuffer _bb)
		{
			return ICheckGiantTotalProgressInteractActivatedNode.GetRootAsICheckGiantTotalProgressInteractActivatedNode(_bb, default(ICheckGiantTotalProgressInteractActivatedNode));
		}

		// Token: 0x0601F6AE RID: 128686 RVA: 0x004603C8 File Offset: 0x0045E5C8
		public static ICheckGiantTotalProgressInteractActivatedNode GetRootAsICheckGiantTotalProgressInteractActivatedNode(ByteBuffer _bb, ICheckGiantTotalProgressInteractActivatedNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F6AF RID: 128687 RVA: 0x004603E5 File Offset: 0x0045E5E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F6B0 RID: 128688 RVA: 0x004603F4 File Offset: 0x0045E5F4
		public ICheckGiantTotalProgressInteractActivatedNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009070 RID: 36976
		// (get) Token: 0x0601F6B1 RID: 128689 RVA: 0x00460404 File Offset: 0x0045E604
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

		// Token: 0x0601F6B2 RID: 128690 RVA: 0x00460440 File Offset: 0x0045E640
		public int NodeIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009071 RID: 36977
		// (get) Token: 0x0601F6B3 RID: 128691 RVA: 0x00460480 File Offset: 0x0045E680
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

		// Token: 0x0601F6B4 RID: 128692 RVA: 0x004604AB File Offset: 0x0045E6AB
		public Span<int> GetNodeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601F6B5 RID: 128693 RVA: 0x004604BA File Offset: 0x0045E6BA
		public int[] GetNodeIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601F6B6 RID: 128694 RVA: 0x004604C8 File Offset: 0x0045E6C8
		public static Offset<ICheckGiantTotalProgressInteractActivatedNode> CreateICheckGiantTotalProgressInteractActivatedNode(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, VectorOffset NodeIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICheckGiantTotalProgressInteractActivatedNode.AddNodeIds(builder, NodeIdsOffset);
			ICheckGiantTotalProgressInteractActivatedNode.AddType(builder, Type);
			return ICheckGiantTotalProgressInteractActivatedNode.EndICheckGiantTotalProgressInteractActivatedNode(builder);
		}

		// Token: 0x0601F6B7 RID: 128695 RVA: 0x004604E5 File Offset: 0x0045E6E5
		public static void StartICheckGiantTotalProgressInteractActivatedNode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F6B8 RID: 128696 RVA: 0x004604EE File Offset: 0x0045E6EE
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F6B9 RID: 128697 RVA: 0x004604F9 File Offset: 0x0045E6F9
		public static void AddNodeIds(FlatBufferBuilder builder, VectorOffset nodeIdsOffset)
		{
			builder.AddOffset(1, nodeIdsOffset.Value, 0);
		}

		// Token: 0x0601F6BA RID: 128698 RVA: 0x0046050C File Offset: 0x0045E70C
		public static VectorOffset CreateNodeIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F6BB RID: 128699 RVA: 0x00460543 File Offset: 0x0045E743
		public static VectorOffset CreateNodeIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F6BC RID: 128700 RVA: 0x0046055D File Offset: 0x0045E75D
		public static VectorOffset CreateNodeIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F6BD RID: 128701 RVA: 0x0046057B File Offset: 0x0045E77B
		public static VectorOffset CreateNodeIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F6BE RID: 128702 RVA: 0x00460594 File Offset: 0x0045E794
		public static void StartNodeIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F6BF RID: 128703 RVA: 0x0046059F File Offset: 0x0045E79F
		public static Offset<ICheckGiantTotalProgressInteractActivatedNode> EndICheckGiantTotalProgressInteractActivatedNode(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGiantTotalProgressInteractActivatedNode>(builder.EndTable());
		}

		// Token: 0x0601F6C0 RID: 128704 RVA: 0x004605AC File Offset: 0x0045E7AC
		public ICheckGiantTotalProgressInteractActivatedNodeT UnPack()
		{
			ICheckGiantTotalProgressInteractActivatedNodeT checkGiantTotalProgressInteractActivatedNodeT = new ICheckGiantTotalProgressInteractActivatedNodeT();
			this.UnPackTo(checkGiantTotalProgressInteractActivatedNodeT);
			return checkGiantTotalProgressInteractActivatedNodeT;
		}

		// Token: 0x0601F6C1 RID: 128705 RVA: 0x004605C8 File Offset: 0x0045E7C8
		public void UnPackTo(ICheckGiantTotalProgressInteractActivatedNodeT _o)
		{
			_o.Type = this.Type;
			_o.NodeIds = new List<int>();
			for (int i = 0; i < this.NodeIdsLength; i++)
			{
				_o.NodeIds.Add(this.NodeIds(i));
			}
		}

		// Token: 0x0601F6C2 RID: 128706 RVA: 0x00460610 File Offset: 0x0045E810
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

		// Token: 0x0400DD6C RID: 56684
		private Table __p;
	}
}
