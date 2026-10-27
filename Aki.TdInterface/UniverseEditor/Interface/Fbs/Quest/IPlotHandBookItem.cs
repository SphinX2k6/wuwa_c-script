using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FA7 RID: 16295
	public struct IPlotHandBookItem : IFlatbufferObject
	{
		// Token: 0x170071C6 RID: 29126
		// (get) Token: 0x06017490 RID: 95376 RVA: 0x0035B7F6 File Offset: 0x003599F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017491 RID: 95377 RVA: 0x0035B803 File Offset: 0x00359A03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017492 RID: 95378 RVA: 0x0035B80C File Offset: 0x00359A0C
		public static IPlotHandBookItem GetRootAsIPlotHandBookItem(ByteBuffer _bb)
		{
			return IPlotHandBookItem.GetRootAsIPlotHandBookItem(_bb, default(IPlotHandBookItem));
		}

		// Token: 0x06017493 RID: 95379 RVA: 0x0035B828 File Offset: 0x00359A28
		public static IPlotHandBookItem GetRootAsIPlotHandBookItem(ByteBuffer _bb, IPlotHandBookItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017494 RID: 95380 RVA: 0x0035B845 File Offset: 0x00359A45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017495 RID: 95381 RVA: 0x0035B854 File Offset: 0x00359A54
		public IPlotHandBookItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071C7 RID: 29127
		// (get) Token: 0x06017496 RID: 95382 RVA: 0x0035B864 File Offset: 0x00359A64
		public int Id
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

		// Token: 0x06017497 RID: 95383 RVA: 0x0035B8A0 File Offset: 0x00359AA0
		public IPlotHandBookNode? Nodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPlotHandBookNode?(default(IPlotHandBookNode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170071C8 RID: 29128
		// (get) Token: 0x06017498 RID: 95384 RVA: 0x0035B900 File Offset: 0x00359B00
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

		// Token: 0x06017499 RID: 95385 RVA: 0x0035B92B File Offset: 0x00359B2B
		public static Offset<IPlotHandBookItem> CreateIPlotHandBookItem(FlatBufferBuilder builder, int Id = 0, VectorOffset NodesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPlotHandBookItem.AddNodes(builder, NodesOffset);
			IPlotHandBookItem.AddId(builder, Id);
			return IPlotHandBookItem.EndIPlotHandBookItem(builder);
		}

		// Token: 0x0601749A RID: 95386 RVA: 0x0035B948 File Offset: 0x00359B48
		public static void StartIPlotHandBookItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601749B RID: 95387 RVA: 0x0035B951 File Offset: 0x00359B51
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601749C RID: 95388 RVA: 0x0035B95C File Offset: 0x00359B5C
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
			builder.AddOffset(1, nodesOffset.Value, 0);
		}

		// Token: 0x0601749D RID: 95389 RVA: 0x0035B96C File Offset: 0x00359B6C
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<IPlotHandBookNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601749E RID: 95390 RVA: 0x0035B9AC File Offset: 0x00359BAC
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<IPlotHandBookNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPlotHandBookNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601749F RID: 95391 RVA: 0x0035B9C6 File Offset: 0x00359BC6
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPlotHandBookNode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPlotHandBookNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x060174A0 RID: 95392 RVA: 0x0035B9E4 File Offset: 0x00359BE4
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPlotHandBookNode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060174A1 RID: 95393 RVA: 0x0035B9FD File Offset: 0x00359BFD
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060174A2 RID: 95394 RVA: 0x0035BA08 File Offset: 0x00359C08
		public static Offset<IPlotHandBookItem> EndIPlotHandBookItem(FlatBufferBuilder builder)
		{
			return new Offset<IPlotHandBookItem>(builder.EndTable());
		}

		// Token: 0x060174A3 RID: 95395 RVA: 0x0035BA18 File Offset: 0x00359C18
		public IPlotHandBookItemT UnPack()
		{
			IPlotHandBookItemT plotHandBookItemT = new IPlotHandBookItemT();
			this.UnPackTo(plotHandBookItemT);
			return plotHandBookItemT;
		}

		// Token: 0x060174A4 RID: 95396 RVA: 0x0035BA34 File Offset: 0x00359C34
		public void UnPackTo(IPlotHandBookItemT _o)
		{
			_o.Id = this.Id;
			_o.Nodes = new List<IPlotHandBookNodeT>();
			for (int i = 0; i < this.NodesLength; i++)
			{
				_o.Nodes.Add((this.Nodes(i) != null) ? this.Nodes(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060174A5 RID: 95397 RVA: 0x0035BAA0 File Offset: 0x00359CA0
		public static Offset<IPlotHandBookItem> Pack(FlatBufferBuilder builder, IPlotHandBookItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotHandBookItem>);
			}
			VectorOffset nodesOffset = default(VectorOffset);
			if (_o.Nodes != null)
			{
				Offset<IPlotHandBookNode>[] array = new Offset<IPlotHandBookNode>[_o.Nodes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPlotHandBookNode.Pack(builder, _o.Nodes[i]);
				}
				nodesOffset = IPlotHandBookItem.CreateNodesVector(builder, array);
			}
			return IPlotHandBookItem.CreateIPlotHandBookItem(builder, _o.Id, nodesOffset);
		}

		// Token: 0x0400BA0F RID: 47631
		private Table __p;
	}
}
