using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045A5 RID: 17829
	public struct IRollBlockPath : IFlatbufferObject
	{
		// Token: 0x17007EB8 RID: 32440
		// (get) Token: 0x0601AF33 RID: 110387 RVA: 0x003D81DF File Offset: 0x003D63DF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AF34 RID: 110388 RVA: 0x003D81EC File Offset: 0x003D63EC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AF35 RID: 110389 RVA: 0x003D81F4 File Offset: 0x003D63F4
		public static IRollBlockPath GetRootAsIRollBlockPath(ByteBuffer _bb)
		{
			return IRollBlockPath.GetRootAsIRollBlockPath(_bb, default(IRollBlockPath));
		}

		// Token: 0x0601AF36 RID: 110390 RVA: 0x003D8210 File Offset: 0x003D6410
		public static IRollBlockPath GetRootAsIRollBlockPath(ByteBuffer _bb, IRollBlockPath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AF37 RID: 110391 RVA: 0x003D822D File Offset: 0x003D642D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AF38 RID: 110392 RVA: 0x003D823C File Offset: 0x003D643C
		public IRollBlockPath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EB9 RID: 32441
		// (get) Token: 0x0601AF39 RID: 110393 RVA: 0x003D824C File Offset: 0x003D644C
		public float Height
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AF3A RID: 110394 RVA: 0x003D828C File Offset: 0x003D648C
		public IRollBlockPathNode? Nodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRollBlockPathNode?(default(IRollBlockPathNode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007EBA RID: 32442
		// (get) Token: 0x0601AF3B RID: 110395 RVA: 0x003D82EC File Offset: 0x003D64EC
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

		// Token: 0x0601AF3C RID: 110396 RVA: 0x003D8317 File Offset: 0x003D6517
		public static Offset<IRollBlockPath> CreateIRollBlockPath(FlatBufferBuilder builder, float Height = 0f, VectorOffset NodesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRollBlockPath.AddNodes(builder, NodesOffset);
			IRollBlockPath.AddHeight(builder, Height);
			return IRollBlockPath.EndIRollBlockPath(builder);
		}

		// Token: 0x0601AF3D RID: 110397 RVA: 0x003D8334 File Offset: 0x003D6534
		public static void StartIRollBlockPath(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AF3E RID: 110398 RVA: 0x003D833D File Offset: 0x003D653D
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(0, height, 0.0);
		}

		// Token: 0x0601AF3F RID: 110399 RVA: 0x003D8350 File Offset: 0x003D6550
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
			builder.AddOffset(1, nodesOffset.Value, 0);
		}

		// Token: 0x0601AF40 RID: 110400 RVA: 0x003D8360 File Offset: 0x003D6560
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<IRollBlockPathNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AF41 RID: 110401 RVA: 0x003D83A0 File Offset: 0x003D65A0
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<IRollBlockPathNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRollBlockPathNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AF42 RID: 110402 RVA: 0x003D83BA File Offset: 0x003D65BA
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRollBlockPathNode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRollBlockPathNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AF43 RID: 110403 RVA: 0x003D83D8 File Offset: 0x003D65D8
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRollBlockPathNode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AF44 RID: 110404 RVA: 0x003D83F1 File Offset: 0x003D65F1
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AF45 RID: 110405 RVA: 0x003D83FC File Offset: 0x003D65FC
		public static Offset<IRollBlockPath> EndIRollBlockPath(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockPath>(builder.EndTable());
		}

		// Token: 0x0601AF46 RID: 110406 RVA: 0x003D840C File Offset: 0x003D660C
		public IRollBlockPathT UnPack()
		{
			IRollBlockPathT rollBlockPathT = new IRollBlockPathT();
			this.UnPackTo(rollBlockPathT);
			return rollBlockPathT;
		}

		// Token: 0x0601AF47 RID: 110407 RVA: 0x003D8428 File Offset: 0x003D6628
		public void UnPackTo(IRollBlockPathT _o)
		{
			_o.Height = this.Height;
			_o.Nodes = new List<IRollBlockPathNodeT>();
			for (int i = 0; i < this.NodesLength; i++)
			{
				_o.Nodes.Add((this.Nodes(i) != null) ? this.Nodes(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601AF48 RID: 110408 RVA: 0x003D8494 File Offset: 0x003D6694
		public static Offset<IRollBlockPath> Pack(FlatBufferBuilder builder, IRollBlockPathT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlockPath>);
			}
			VectorOffset nodesOffset = default(VectorOffset);
			if (_o.Nodes != null)
			{
				Offset<IRollBlockPathNode>[] array = new Offset<IRollBlockPathNode>[_o.Nodes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRollBlockPathNode.Pack(builder, _o.Nodes[i]);
				}
				nodesOffset = IRollBlockPath.CreateNodesVector(builder, array);
			}
			return IRollBlockPath.CreateIRollBlockPath(builder, _o.Height, nodesOffset);
		}

		// Token: 0x0400C66D RID: 50797
		private Table __p;
	}
}
