using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005886 RID: 22662
	public struct IGraph3dBase : IFlatbufferObject
	{
		// Token: 0x1700A43D RID: 42045
		// (get) Token: 0x06024BFA RID: 150522 RVA: 0x0050C1C9 File Offset: 0x0050A3C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024BFB RID: 150523 RVA: 0x0050C1D6 File Offset: 0x0050A3D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024BFC RID: 150524 RVA: 0x0050C1E0 File Offset: 0x0050A3E0
		public static IGraph3dBase GetRootAsIGraph3dBase(ByteBuffer _bb)
		{
			return IGraph3dBase.GetRootAsIGraph3dBase(_bb, default(IGraph3dBase));
		}

		// Token: 0x06024BFD RID: 150525 RVA: 0x0050C1FC File Offset: 0x0050A3FC
		public static IGraph3dBase GetRootAsIGraph3dBase(ByteBuffer _bb, IGraph3dBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024BFE RID: 150526 RVA: 0x0050C219 File Offset: 0x0050A419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024BFF RID: 150527 RVA: 0x0050C228 File Offset: 0x0050A428
		public IGraph3dBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A43E RID: 42046
		// (get) Token: 0x06024C00 RID: 150528 RVA: 0x0050C238 File Offset: 0x0050A438
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

		// Token: 0x06024C01 RID: 150529 RVA: 0x0050C274 File Offset: 0x0050A474
		public IGraph3dNodeBase? Nodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IGraph3dNodeBase?(default(IGraph3dNodeBase).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A43F RID: 42047
		// (get) Token: 0x06024C02 RID: 150530 RVA: 0x0050C2D4 File Offset: 0x0050A4D4
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

		// Token: 0x06024C03 RID: 150531 RVA: 0x0050C300 File Offset: 0x0050A500
		public IGraph3dEdgeBase? Edges(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IGraph3dEdgeBase?(default(IGraph3dEdgeBase).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A440 RID: 42048
		// (get) Token: 0x06024C04 RID: 150532 RVA: 0x0050C360 File Offset: 0x0050A560
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

		// Token: 0x06024C05 RID: 150533 RVA: 0x0050C38B File Offset: 0x0050A58B
		public static Offset<IGraph3dBase> CreateIGraph3dBase(FlatBufferBuilder builder, EGraph3dType Type = EGraph3dType.Normal, VectorOffset NodesOffset = default(VectorOffset), VectorOffset EdgesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IGraph3dBase.AddEdges(builder, EdgesOffset);
			IGraph3dBase.AddNodes(builder, NodesOffset);
			IGraph3dBase.AddType(builder, Type);
			return IGraph3dBase.EndIGraph3dBase(builder);
		}

		// Token: 0x06024C06 RID: 150534 RVA: 0x0050C3AF File Offset: 0x0050A5AF
		public static void StartIGraph3dBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024C07 RID: 150535 RVA: 0x0050C3B8 File Offset: 0x0050A5B8
		public static void AddType(FlatBufferBuilder builder, EGraph3dType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024C08 RID: 150536 RVA: 0x0050C3C3 File Offset: 0x0050A5C3
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
			builder.AddOffset(1, nodesOffset.Value, 0);
		}

		// Token: 0x06024C09 RID: 150537 RVA: 0x0050C3D4 File Offset: 0x0050A5D4
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<IGraph3dNodeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024C0A RID: 150538 RVA: 0x0050C414 File Offset: 0x0050A614
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<IGraph3dNodeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGraph3dNodeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024C0B RID: 150539 RVA: 0x0050C42E File Offset: 0x0050A62E
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGraph3dNodeBase>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGraph3dNodeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024C0C RID: 150540 RVA: 0x0050C44C File Offset: 0x0050A64C
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGraph3dNodeBase>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024C0D RID: 150541 RVA: 0x0050C465 File Offset: 0x0050A665
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024C0E RID: 150542 RVA: 0x0050C470 File Offset: 0x0050A670
		public static void AddEdges(FlatBufferBuilder builder, VectorOffset edgesOffset)
		{
			builder.AddOffset(2, edgesOffset.Value, 0);
		}

		// Token: 0x06024C0F RID: 150543 RVA: 0x0050C480 File Offset: 0x0050A680
		public static VectorOffset CreateEdgesVector(FlatBufferBuilder builder, Offset<IGraph3dEdgeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024C10 RID: 150544 RVA: 0x0050C4C0 File Offset: 0x0050A6C0
		public static VectorOffset CreateEdgesVectorBlock(FlatBufferBuilder builder, Offset<IGraph3dEdgeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGraph3dEdgeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024C11 RID: 150545 RVA: 0x0050C4DA File Offset: 0x0050A6DA
		public static VectorOffset CreateEdgesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGraph3dEdgeBase>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGraph3dEdgeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024C12 RID: 150546 RVA: 0x0050C4F8 File Offset: 0x0050A6F8
		public static VectorOffset CreateEdgesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGraph3dEdgeBase>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024C13 RID: 150547 RVA: 0x0050C511 File Offset: 0x0050A711
		public static void StartEdgesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024C14 RID: 150548 RVA: 0x0050C51C File Offset: 0x0050A71C
		public static Offset<IGraph3dBase> EndIGraph3dBase(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dBase>(builder.EndTable());
		}

		// Token: 0x06024C15 RID: 150549 RVA: 0x0050C52C File Offset: 0x0050A72C
		public IGraph3dBaseT UnPack()
		{
			IGraph3dBaseT graph3dBaseT = new IGraph3dBaseT();
			this.UnPackTo(graph3dBaseT);
			return graph3dBaseT;
		}

		// Token: 0x06024C16 RID: 150550 RVA: 0x0050C548 File Offset: 0x0050A748
		public void UnPackTo(IGraph3dBaseT _o)
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

		// Token: 0x06024C17 RID: 150551 RVA: 0x0050C608 File Offset: 0x0050A808
		public static Offset<IGraph3dBase> Pack(FlatBufferBuilder builder, IGraph3dBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dBase>);
			}
			VectorOffset nodesOffset = default(VectorOffset);
			if (_o.Nodes != null)
			{
				Offset<IGraph3dNodeBase>[] array = new Offset<IGraph3dNodeBase>[_o.Nodes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IGraph3dNodeBase.Pack(builder, _o.Nodes[i]);
				}
				nodesOffset = IGraph3dBase.CreateNodesVector(builder, array);
			}
			VectorOffset edgesOffset = default(VectorOffset);
			if (_o.Edges != null)
			{
				Offset<IGraph3dEdgeBase>[] array2 = new Offset<IGraph3dEdgeBase>[_o.Edges.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IGraph3dEdgeBase.Pack(builder, _o.Edges[j]);
				}
				edgesOffset = IGraph3dBase.CreateEdgesVector(builder, array2);
			}
			return IGraph3dBase.CreateIGraph3dBase(builder, _o.Type, nodesOffset, edgesOffset);
		}

		// Token: 0x0400F0DE RID: 61662
		private Table __p;
	}
}
