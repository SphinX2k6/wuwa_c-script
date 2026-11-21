using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A0D RID: 18957
	public struct IRollBlockPath : IFlatbufferObject
	{
		// Token: 0x170084F9 RID: 34041
		// (get) Token: 0x0601C708 RID: 116488 RVA: 0x0040447B File Offset: 0x0040267B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C709 RID: 116489 RVA: 0x00404488 File Offset: 0x00402688
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C70A RID: 116490 RVA: 0x00404490 File Offset: 0x00402690
		public static IRollBlockPath GetRootAsIRollBlockPath(ByteBuffer _bb)
		{
			return IRollBlockPath.GetRootAsIRollBlockPath(_bb, default(IRollBlockPath));
		}

		// Token: 0x0601C70B RID: 116491 RVA: 0x004044AC File Offset: 0x004026AC
		public static IRollBlockPath GetRootAsIRollBlockPath(ByteBuffer _bb, IRollBlockPath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C70C RID: 116492 RVA: 0x004044C9 File Offset: 0x004026C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C70D RID: 116493 RVA: 0x004044D8 File Offset: 0x004026D8
		public IRollBlockPath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084FA RID: 34042
		// (get) Token: 0x0601C70E RID: 116494 RVA: 0x004044E8 File Offset: 0x004026E8
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

		// Token: 0x0601C70F RID: 116495 RVA: 0x00404528 File Offset: 0x00402728
		public IRollBlockPathNode? Nodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRollBlockPathNode?(default(IRollBlockPathNode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170084FB RID: 34043
		// (get) Token: 0x0601C710 RID: 116496 RVA: 0x00404588 File Offset: 0x00402788
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

		// Token: 0x0601C711 RID: 116497 RVA: 0x004045B3 File Offset: 0x004027B3
		public static Offset<IRollBlockPath> CreateIRollBlockPath(FlatBufferBuilder builder, float Height = 0f, VectorOffset NodesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRollBlockPath.AddNodes(builder, NodesOffset);
			IRollBlockPath.AddHeight(builder, Height);
			return IRollBlockPath.EndIRollBlockPath(builder);
		}

		// Token: 0x0601C712 RID: 116498 RVA: 0x004045D0 File Offset: 0x004027D0
		public static void StartIRollBlockPath(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C713 RID: 116499 RVA: 0x004045D9 File Offset: 0x004027D9
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(0, height, 0.0);
		}

		// Token: 0x0601C714 RID: 116500 RVA: 0x004045EC File Offset: 0x004027EC
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
			builder.AddOffset(1, nodesOffset.Value, 0);
		}

		// Token: 0x0601C715 RID: 116501 RVA: 0x004045FC File Offset: 0x004027FC
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<IRollBlockPathNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C716 RID: 116502 RVA: 0x0040463C File Offset: 0x0040283C
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<IRollBlockPathNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRollBlockPathNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C717 RID: 116503 RVA: 0x00404656 File Offset: 0x00402856
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRollBlockPathNode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRollBlockPathNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C718 RID: 116504 RVA: 0x00404674 File Offset: 0x00402874
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRollBlockPathNode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C719 RID: 116505 RVA: 0x0040468D File Offset: 0x0040288D
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C71A RID: 116506 RVA: 0x00404698 File Offset: 0x00402898
		public static Offset<IRollBlockPath> EndIRollBlockPath(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlockPath>(builder.EndTable());
		}

		// Token: 0x0601C71B RID: 116507 RVA: 0x004046A8 File Offset: 0x004028A8
		public IRollBlockPathT UnPack()
		{
			IRollBlockPathT rollBlockPathT = new IRollBlockPathT();
			this.UnPackTo(rollBlockPathT);
			return rollBlockPathT;
		}

		// Token: 0x0601C71C RID: 116508 RVA: 0x004046C4 File Offset: 0x004028C4
		public void UnPackTo(IRollBlockPathT _o)
		{
			_o.Height = this.Height;
			_o.Nodes = new List<IRollBlockPathNodeT>();
			for (int i = 0; i < this.NodesLength; i++)
			{
				_o.Nodes.Add((this.Nodes(i) != null) ? this.Nodes(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C71D RID: 116509 RVA: 0x00404730 File Offset: 0x00402930
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

		// Token: 0x0400D09C RID: 53404
		private Table __p;
	}
}
