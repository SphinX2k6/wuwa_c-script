using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200531E RID: 21278
	public struct IGraph3dNormal : IFlatbufferObject
	{
		// Token: 0x17009C3B RID: 39995
		// (get) Token: 0x06022C2E RID: 142382 RVA: 0x004D0D40 File Offset: 0x004CEF40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022C2F RID: 142383 RVA: 0x004D0D4D File Offset: 0x004CEF4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022C30 RID: 142384 RVA: 0x004D0D54 File Offset: 0x004CEF54
		public static IGraph3dNormal GetRootAsIGraph3dNormal(ByteBuffer _bb)
		{
			return IGraph3dNormal.GetRootAsIGraph3dNormal(_bb, default(IGraph3dNormal));
		}

		// Token: 0x06022C31 RID: 142385 RVA: 0x004D0D70 File Offset: 0x004CEF70
		public static IGraph3dNormal GetRootAsIGraph3dNormal(ByteBuffer _bb, IGraph3dNormal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022C32 RID: 142386 RVA: 0x004D0D8D File Offset: 0x004CEF8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022C33 RID: 142387 RVA: 0x004D0D9C File Offset: 0x004CEF9C
		public IGraph3dNormal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C3C RID: 39996
		// (get) Token: 0x06022C34 RID: 142388 RVA: 0x004D0DAC File Offset: 0x004CEFAC
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

		// Token: 0x06022C35 RID: 142389 RVA: 0x004D0DE8 File Offset: 0x004CEFE8
		public IGraph3dNodeBase? Nodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IGraph3dNodeBase?(default(IGraph3dNodeBase).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C3D RID: 39997
		// (get) Token: 0x06022C36 RID: 142390 RVA: 0x004D0E48 File Offset: 0x004CF048
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

		// Token: 0x06022C37 RID: 142391 RVA: 0x004D0E74 File Offset: 0x004CF074
		public IGraph3dEdgeBase? Edges(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IGraph3dEdgeBase?(default(IGraph3dEdgeBase).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C3E RID: 39998
		// (get) Token: 0x06022C38 RID: 142392 RVA: 0x004D0ED4 File Offset: 0x004CF0D4
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

		// Token: 0x06022C39 RID: 142393 RVA: 0x004D0EFF File Offset: 0x004CF0FF
		public static Offset<IGraph3dNormal> CreateIGraph3dNormal(FlatBufferBuilder builder, EGraph3dType Type = EGraph3dType.Normal, VectorOffset NodesOffset = default(VectorOffset), VectorOffset EdgesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IGraph3dNormal.AddEdges(builder, EdgesOffset);
			IGraph3dNormal.AddNodes(builder, NodesOffset);
			IGraph3dNormal.AddType(builder, Type);
			return IGraph3dNormal.EndIGraph3dNormal(builder);
		}

		// Token: 0x06022C3A RID: 142394 RVA: 0x004D0F23 File Offset: 0x004CF123
		public static void StartIGraph3dNormal(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022C3B RID: 142395 RVA: 0x004D0F2C File Offset: 0x004CF12C
		public static void AddType(FlatBufferBuilder builder, EGraph3dType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022C3C RID: 142396 RVA: 0x004D0F37 File Offset: 0x004CF137
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
			builder.AddOffset(1, nodesOffset.Value, 0);
		}

		// Token: 0x06022C3D RID: 142397 RVA: 0x004D0F48 File Offset: 0x004CF148
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<IGraph3dNodeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022C3E RID: 142398 RVA: 0x004D0F88 File Offset: 0x004CF188
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<IGraph3dNodeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGraph3dNodeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022C3F RID: 142399 RVA: 0x004D0FA2 File Offset: 0x004CF1A2
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGraph3dNodeBase>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGraph3dNodeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022C40 RID: 142400 RVA: 0x004D0FC0 File Offset: 0x004CF1C0
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGraph3dNodeBase>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022C41 RID: 142401 RVA: 0x004D0FD9 File Offset: 0x004CF1D9
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022C42 RID: 142402 RVA: 0x004D0FE4 File Offset: 0x004CF1E4
		public static void AddEdges(FlatBufferBuilder builder, VectorOffset edgesOffset)
		{
			builder.AddOffset(2, edgesOffset.Value, 0);
		}

		// Token: 0x06022C43 RID: 142403 RVA: 0x004D0FF4 File Offset: 0x004CF1F4
		public static VectorOffset CreateEdgesVector(FlatBufferBuilder builder, Offset<IGraph3dEdgeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022C44 RID: 142404 RVA: 0x004D1034 File Offset: 0x004CF234
		public static VectorOffset CreateEdgesVectorBlock(FlatBufferBuilder builder, Offset<IGraph3dEdgeBase>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGraph3dEdgeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022C45 RID: 142405 RVA: 0x004D104E File Offset: 0x004CF24E
		public static VectorOffset CreateEdgesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGraph3dEdgeBase>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGraph3dEdgeBase>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022C46 RID: 142406 RVA: 0x004D106C File Offset: 0x004CF26C
		public static VectorOffset CreateEdgesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGraph3dEdgeBase>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022C47 RID: 142407 RVA: 0x004D1085 File Offset: 0x004CF285
		public static void StartEdgesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022C48 RID: 142408 RVA: 0x004D1090 File Offset: 0x004CF290
		public static Offset<IGraph3dNormal> EndIGraph3dNormal(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dNormal>(builder.EndTable());
		}

		// Token: 0x06022C49 RID: 142409 RVA: 0x004D10A0 File Offset: 0x004CF2A0
		public IGraph3dNormalT UnPack()
		{
			IGraph3dNormalT graph3dNormalT = new IGraph3dNormalT();
			this.UnPackTo(graph3dNormalT);
			return graph3dNormalT;
		}

		// Token: 0x06022C4A RID: 142410 RVA: 0x004D10BC File Offset: 0x004CF2BC
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

		// Token: 0x06022C4B RID: 142411 RVA: 0x004D117C File Offset: 0x004CF37C
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

		// Token: 0x0400E4D7 RID: 58583
		private Table __p;
	}
}
