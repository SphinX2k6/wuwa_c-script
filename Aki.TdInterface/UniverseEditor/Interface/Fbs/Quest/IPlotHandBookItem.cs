using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043E8 RID: 17384
	public struct IPlotHandBookItem : IFlatbufferObject
	{
		// Token: 0x170077C4 RID: 30660
		// (get) Token: 0x06018B1F RID: 101151 RVA: 0x0038540E File Offset: 0x0038360E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018B20 RID: 101152 RVA: 0x0038541B File Offset: 0x0038361B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018B21 RID: 101153 RVA: 0x00385424 File Offset: 0x00383624
		public static IPlotHandBookItem GetRootAsIPlotHandBookItem(ByteBuffer _bb)
		{
			return IPlotHandBookItem.GetRootAsIPlotHandBookItem(_bb, default(IPlotHandBookItem));
		}

		// Token: 0x06018B22 RID: 101154 RVA: 0x00385440 File Offset: 0x00383640
		public static IPlotHandBookItem GetRootAsIPlotHandBookItem(ByteBuffer _bb, IPlotHandBookItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018B23 RID: 101155 RVA: 0x0038545D File Offset: 0x0038365D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018B24 RID: 101156 RVA: 0x0038546C File Offset: 0x0038366C
		public IPlotHandBookItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077C5 RID: 30661
		// (get) Token: 0x06018B25 RID: 101157 RVA: 0x0038547C File Offset: 0x0038367C
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

		// Token: 0x06018B26 RID: 101158 RVA: 0x003854B8 File Offset: 0x003836B8
		public IPlotHandBookNode? Nodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPlotHandBookNode?(default(IPlotHandBookNode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170077C6 RID: 30662
		// (get) Token: 0x06018B27 RID: 101159 RVA: 0x00385518 File Offset: 0x00383718
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

		// Token: 0x06018B28 RID: 101160 RVA: 0x00385543 File Offset: 0x00383743
		public static Offset<IPlotHandBookItem> CreateIPlotHandBookItem(FlatBufferBuilder builder, int Id = 0, VectorOffset NodesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPlotHandBookItem.AddNodes(builder, NodesOffset);
			IPlotHandBookItem.AddId(builder, Id);
			return IPlotHandBookItem.EndIPlotHandBookItem(builder);
		}

		// Token: 0x06018B29 RID: 101161 RVA: 0x00385560 File Offset: 0x00383760
		public static void StartIPlotHandBookItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018B2A RID: 101162 RVA: 0x00385569 File Offset: 0x00383769
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06018B2B RID: 101163 RVA: 0x00385574 File Offset: 0x00383774
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
			builder.AddOffset(1, nodesOffset.Value, 0);
		}

		// Token: 0x06018B2C RID: 101164 RVA: 0x00385584 File Offset: 0x00383784
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<IPlotHandBookNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018B2D RID: 101165 RVA: 0x003855C4 File Offset: 0x003837C4
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<IPlotHandBookNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPlotHandBookNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018B2E RID: 101166 RVA: 0x003855DE File Offset: 0x003837DE
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPlotHandBookNode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPlotHandBookNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018B2F RID: 101167 RVA: 0x003855FC File Offset: 0x003837FC
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPlotHandBookNode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018B30 RID: 101168 RVA: 0x00385615 File Offset: 0x00383815
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018B31 RID: 101169 RVA: 0x00385620 File Offset: 0x00383820
		public static Offset<IPlotHandBookItem> EndIPlotHandBookItem(FlatBufferBuilder builder)
		{
			return new Offset<IPlotHandBookItem>(builder.EndTable());
		}

		// Token: 0x06018B32 RID: 101170 RVA: 0x00385630 File Offset: 0x00383830
		public IPlotHandBookItemT UnPack()
		{
			IPlotHandBookItemT plotHandBookItemT = new IPlotHandBookItemT();
			this.UnPackTo(plotHandBookItemT);
			return plotHandBookItemT;
		}

		// Token: 0x06018B33 RID: 101171 RVA: 0x0038564C File Offset: 0x0038384C
		public void UnPackTo(IPlotHandBookItemT _o)
		{
			_o.Id = this.Id;
			_o.Nodes = new List<IPlotHandBookNodeT>();
			for (int i = 0; i < this.NodesLength; i++)
			{
				_o.Nodes.Add((this.Nodes(i) != null) ? this.Nodes(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06018B34 RID: 101172 RVA: 0x003856B8 File Offset: 0x003838B8
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

		// Token: 0x0400C3F4 RID: 50164
		private Table __p;
	}
}
