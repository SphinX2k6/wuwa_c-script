using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A4 RID: 22692
	public struct IGraph3dNormal : IFlatbufferObject
	{
		// Token: 0x1700A473 RID: 42099
		// (get) Token: 0x06024CE2 RID: 150754 RVA: 0x0050DC14 File Offset: 0x0050BE14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024CE3 RID: 150755 RVA: 0x0050DC21 File Offset: 0x0050BE21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024CE4 RID: 150756 RVA: 0x0050DC28 File Offset: 0x0050BE28
		public static IGraph3dNormal GetRootAsIGraph3dNormal(ByteBuffer _bb)
		{
			return IGraph3dNormal.GetRootAsIGraph3dNormal(_bb, default(IGraph3dNormal));
		}

		// Token: 0x06024CE5 RID: 150757 RVA: 0x0050DC44 File Offset: 0x0050BE44
		public static IGraph3dNormal GetRootAsIGraph3dNormal(ByteBuffer _bb, IGraph3dNormal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024CE6 RID: 150758 RVA: 0x0050DC61 File Offset: 0x0050BE61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024CE7 RID: 150759 RVA: 0x0050DC70 File Offset: 0x0050BE70
		public IGraph3dNormal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A474 RID: 42100
		// (get) Token: 0x06024CE8 RID: 150760 RVA: 0x0050DC80 File Offset: 0x0050BE80
		public EGraph3dType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGraph3dType.Normal;
				}
				return (EGraph3dType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024CE9 RID: 150761 RVA: 0x0050DCBC File Offset: 0x0050BEBC
		public IGraph3dNodeBase? Nodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IGraph3dNodeBase?(default(IGraph3dNodeBase).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A475 RID: 42101
		// (get) Token: 0x06024CEA RID: 150762 RVA: 0x0050DD1C File Offset: 0x0050BF1C
		public int NodesLength
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

		// Token: 0x06024CEB RID: 150763 RVA: 0x0050DD48 File Offset: 0x0050BF48
		public IGraph3dEdgeBase? Edges(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IGraph3dEdgeBase?(default(IGraph3dEdgeBase).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A476 RID: 42102
		// (get) Token: 0x06024CEC RID: 150764 RVA: 0x0050DDA8 File Offset: 0x0050BFA8
		public int EdgesLength
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

		// Token: 0x06024CED RID: 150765 RVA: 0x0050DDD3 File Offset: 0x0050BFD3
		public static Offset<IGraph3dNormal> CreateIGraph3dNormal(FlatBufferBuilder builder, EGraph3dType Type = EGraph3dType.Normal, VectorOffset NodesOffset = default(VectorOffset), VectorOffset EdgesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IGraph3dNormal.AddEdges(builder, EdgesOffset);
			IGraph3dNormal.AddNodes(builder, NodesOffset);
			IGraph3dNormal.AddType(builder, Type);
			return IGraph3dNormal.EndIGraph3dNormal(builder);
		}

		// Token: 0x06024CEE RID: 150766 RVA: 0x0050DDF7 File Offset: 0x0050BFF7
		public static void StartIGraph3dNormal(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024CEF RID: 150767 RVA: 0x0050DE00 File Offset: 0x0050C000
		public static void AddType(FlatBufferBuilder builder, EGraph3dType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024CF0 RID: 150768 RVA: 0x0050DE0B File Offset: 0x0050C00B
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
			builder.AddOffset(1, nodesOffset.Value, 0);
		}

		// Token: 0x06024CF1 RID: 150769 RVA: 0x0050DE1C File Offset: 0x0050C01C
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<IGraph3dNodeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024CF2 RID: 150770 RVA: 0x0050DE5C File Offset: 0x0050C05C
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<IGraph3dNodeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGraph3dNodeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024CF3 RID: 150771 RVA: 0x0050DE76 File Offset: 0x0050C076
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGraph3dNodeBase>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGraph3dNodeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024CF4 RID: 150772 RVA: 0x0050DE94 File Offset: 0x0050C094
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGraph3dNodeBase>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024CF5 RID: 150773 RVA: 0x0050DEAD File Offset: 0x0050C0AD
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024CF6 RID: 150774 RVA: 0x0050DEB8 File Offset: 0x0050C0B8
		public static void AddEdges(FlatBufferBuilder builder, VectorOffset edgesOffset)
		{
			builder.AddOffset(2, edgesOffset.Value, 0);
		}

		// Token: 0x06024CF7 RID: 150775 RVA: 0x0050DEC8 File Offset: 0x0050C0C8
		public static VectorOffset CreateEdgesVector(FlatBufferBuilder builder, Offset<IGraph3dEdgeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024CF8 RID: 150776 RVA: 0x0050DF08 File Offset: 0x0050C108
		public static VectorOffset CreateEdgesVectorBlock(FlatBufferBuilder builder, Offset<IGraph3dEdgeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGraph3dEdgeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024CF9 RID: 150777 RVA: 0x0050DF22 File Offset: 0x0050C122
		public static VectorOffset CreateEdgesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGraph3dEdgeBase>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGraph3dEdgeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024CFA RID: 150778 RVA: 0x0050DF40 File Offset: 0x0050C140
		public static VectorOffset CreateEdgesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGraph3dEdgeBase>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024CFB RID: 150779 RVA: 0x0050DF59 File Offset: 0x0050C159
		public static void StartEdgesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024CFC RID: 150780 RVA: 0x0050DF64 File Offset: 0x0050C164
		public static Offset<IGraph3dNormal> EndIGraph3dNormal(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dNormal>(builder.EndTable());
		}

		// Token: 0x06024CFD RID: 150781 RVA: 0x0050DF74 File Offset: 0x0050C174
		public IGraph3dNormalT UnPack()
		{
			IGraph3dNormalT graph3dNormalT = new IGraph3dNormalT();
			this.UnPackTo(graph3dNormalT);
			return graph3dNormalT;
		}

		// Token: 0x06024CFE RID: 150782 RVA: 0x0050DF90 File Offset: 0x0050C190
		public void UnPackTo(IGraph3dNormalT _o)
		{
			_o.Type = this.Type;
			_o.Nodes = new List<IGraph3dNodeBaseT>();
			for (int i = 0; i < this.NodesLength; i++)
			{
				_o.Nodes.Add((this.Nodes(i) != null) ? this.Nodes(i).Value.UnPack() : null);
			}
			_o.Edges = new List<IGraph3dEdgeBaseT>();
			for (int j = 0; j < this.EdgesLength; j++)
			{
				_o.Edges.Add((this.Edges(j) != null) ? this.Edges(j).Value.UnPack() : null);
			}
		}

		// Token: 0x06024CFF RID: 150783 RVA: 0x0050E050 File Offset: 0x0050C250
		public static Offset<IGraph3dNormal> Pack(FlatBufferBuilder builder, IGraph3dNormalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dNormal>);
			}
			VectorOffset nodesOffset = default(VectorOffset);
			if (_o.Nodes != null)
			{
				Offset<IGraph3dNodeBase>[] array = new Offset<IGraph3dNodeBase>[_o.Nodes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IGraph3dNodeBase.Pack(builder, _o.Nodes[i]);
				}
				nodesOffset = IGraph3dNormal.CreateNodesVector(builder, array);
			}
			VectorOffset edgesOffset = default(VectorOffset);
			if (_o.Edges != null)
			{
				Offset<IGraph3dEdgeBase>[] array2 = new Offset<IGraph3dEdgeBase>[_o.Edges.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IGraph3dEdgeBase.Pack(builder, _o.Edges[j]);
				}
				edgesOffset = IGraph3dNormal.CreateEdgesVector(builder, array2);
			}
			return IGraph3dNormal.CreateIGraph3dNormal(builder, _o.Type, nodesOffset, edgesOffset);
		}

		// Token: 0x0400F107 RID: 61703
		private Table __p;
	}
}
