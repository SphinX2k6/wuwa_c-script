using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005300 RID: 21248
	public struct IGraph3dBase : IFlatbufferObject
	{
		// Token: 0x17009C05 RID: 39941
		// (get) Token: 0x06022B46 RID: 142150 RVA: 0x004CF2F5 File Offset: 0x004CD4F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022B47 RID: 142151 RVA: 0x004CF302 File Offset: 0x004CD502
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022B48 RID: 142152 RVA: 0x004CF30C File Offset: 0x004CD50C
		public static IGraph3dBase GetRootAsIGraph3dBase(ByteBuffer _bb)
		{
			return IGraph3dBase.GetRootAsIGraph3dBase(_bb, default(IGraph3dBase));
		}

		// Token: 0x06022B49 RID: 142153 RVA: 0x004CF328 File Offset: 0x004CD528
		public static IGraph3dBase GetRootAsIGraph3dBase(ByteBuffer _bb, IGraph3dBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022B4A RID: 142154 RVA: 0x004CF345 File Offset: 0x004CD545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022B4B RID: 142155 RVA: 0x004CF354 File Offset: 0x004CD554
		public IGraph3dBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C06 RID: 39942
		// (get) Token: 0x06022B4C RID: 142156 RVA: 0x004CF364 File Offset: 0x004CD564
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

		// Token: 0x06022B4D RID: 142157 RVA: 0x004CF3A0 File Offset: 0x004CD5A0
		public IGraph3dNodeBase? Nodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IGraph3dNodeBase?(default(IGraph3dNodeBase).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C07 RID: 39943
		// (get) Token: 0x06022B4E RID: 142158 RVA: 0x004CF400 File Offset: 0x004CD600
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

		// Token: 0x06022B4F RID: 142159 RVA: 0x004CF42C File Offset: 0x004CD62C
		public IGraph3dEdgeBase? Edges(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IGraph3dEdgeBase?(default(IGraph3dEdgeBase).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C08 RID: 39944
		// (get) Token: 0x06022B50 RID: 142160 RVA: 0x004CF48C File Offset: 0x004CD68C
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

		// Token: 0x06022B51 RID: 142161 RVA: 0x004CF4B7 File Offset: 0x004CD6B7
		public static Offset<IGraph3dBase> CreateIGraph3dBase(FlatBufferBuilder builder, EGraph3dType Type = EGraph3dType.Normal, VectorOffset NodesOffset = default(VectorOffset), VectorOffset EdgesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IGraph3dBase.AddEdges(builder, EdgesOffset);
			IGraph3dBase.AddNodes(builder, NodesOffset);
			IGraph3dBase.AddType(builder, Type);
			return IGraph3dBase.EndIGraph3dBase(builder);
		}

		// Token: 0x06022B52 RID: 142162 RVA: 0x004CF4DB File Offset: 0x004CD6DB
		public static void StartIGraph3dBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022B53 RID: 142163 RVA: 0x004CF4E4 File Offset: 0x004CD6E4
		public static void AddType(FlatBufferBuilder builder, EGraph3dType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022B54 RID: 142164 RVA: 0x004CF4EF File Offset: 0x004CD6EF
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
			builder.AddOffset(1, nodesOffset.Value, 0);
		}

		// Token: 0x06022B55 RID: 142165 RVA: 0x004CF500 File Offset: 0x004CD700
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<IGraph3dNodeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022B56 RID: 142166 RVA: 0x004CF540 File Offset: 0x004CD740
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<IGraph3dNodeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGraph3dNodeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022B57 RID: 142167 RVA: 0x004CF55A File Offset: 0x004CD75A
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGraph3dNodeBase>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGraph3dNodeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022B58 RID: 142168 RVA: 0x004CF578 File Offset: 0x004CD778
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGraph3dNodeBase>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022B59 RID: 142169 RVA: 0x004CF591 File Offset: 0x004CD791
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022B5A RID: 142170 RVA: 0x004CF59C File Offset: 0x004CD79C
		public static void AddEdges(FlatBufferBuilder builder, VectorOffset edgesOffset)
		{
			builder.AddOffset(2, edgesOffset.Value, 0);
		}

		// Token: 0x06022B5B RID: 142171 RVA: 0x004CF5AC File Offset: 0x004CD7AC
		public static VectorOffset CreateEdgesVector(FlatBufferBuilder builder, Offset<IGraph3dEdgeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022B5C RID: 142172 RVA: 0x004CF5EC File Offset: 0x004CD7EC
		public static VectorOffset CreateEdgesVectorBlock(FlatBufferBuilder builder, Offset<IGraph3dEdgeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGraph3dEdgeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022B5D RID: 142173 RVA: 0x004CF606 File Offset: 0x004CD806
		public static VectorOffset CreateEdgesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGraph3dEdgeBase>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGraph3dEdgeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022B5E RID: 142174 RVA: 0x004CF624 File Offset: 0x004CD824
		public static VectorOffset CreateEdgesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGraph3dEdgeBase>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022B5F RID: 142175 RVA: 0x004CF63D File Offset: 0x004CD83D
		public static void StartEdgesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022B60 RID: 142176 RVA: 0x004CF648 File Offset: 0x004CD848
		public static Offset<IGraph3dBase> EndIGraph3dBase(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dBase>(builder.EndTable());
		}

		// Token: 0x06022B61 RID: 142177 RVA: 0x004CF658 File Offset: 0x004CD858
		public IGraph3dBaseT UnPack()
		{
			IGraph3dBaseT graph3dBaseT = new IGraph3dBaseT();
			this.UnPackTo(graph3dBaseT);
			return graph3dBaseT;
		}

		// Token: 0x06022B62 RID: 142178 RVA: 0x004CF674 File Offset: 0x004CD874
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

		// Token: 0x06022B63 RID: 142179 RVA: 0x004CF734 File Offset: 0x004CD934
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

		// Token: 0x0400E4AE RID: 58542
		private Table __p;
	}
}
