using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048B9 RID: 18617
	public struct ITwoDimensionOutlineTree : IFlatbufferObject
	{
		// Token: 0x17008705 RID: 34565
		// (get) Token: 0x0601D130 RID: 119088 RVA: 0x0041AF2A File Offset: 0x0041912A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D131 RID: 119089 RVA: 0x0041AF37 File Offset: 0x00419137
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D132 RID: 119090 RVA: 0x0041AF40 File Offset: 0x00419140
		public static ITwoDimensionOutlineTree GetRootAsITwoDimensionOutlineTree(ByteBuffer _bb)
		{
			return ITwoDimensionOutlineTree.GetRootAsITwoDimensionOutlineTree(_bb, default(ITwoDimensionOutlineTree));
		}

		// Token: 0x0601D133 RID: 119091 RVA: 0x0041AF5C File Offset: 0x0041915C
		public static ITwoDimensionOutlineTree GetRootAsITwoDimensionOutlineTree(ByteBuffer _bb, ITwoDimensionOutlineTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D134 RID: 119092 RVA: 0x0041AF79 File Offset: 0x00419179
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D135 RID: 119093 RVA: 0x0041AF88 File Offset: 0x00419188
		public ITwoDimensionOutlineTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008706 RID: 34566
		// (get) Token: 0x0601D136 RID: 119094 RVA: 0x0041AF98 File Offset: 0x00419198
		public ITwoDimensionOutlineFolderNode? Root
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITwoDimensionOutlineFolderNode?(default(ITwoDimensionOutlineFolderNode).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008707 RID: 34567
		// (get) Token: 0x0601D137 RID: 119095 RVA: 0x0041AFF8 File Offset: 0x004191F8
		public int NextFolderIndex
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D138 RID: 119096 RVA: 0x0041B034 File Offset: 0x00419234
		public static Offset<ITwoDimensionOutlineTree> CreateITwoDimensionOutlineTree(FlatBufferBuilder builder, Offset<ITwoDimensionOutlineFolderNode> RootOffset = default(Offset<ITwoDimensionOutlineFolderNode>), int NextFolderIndex = 0)
		{
			builder.StartTable(2);
			ITwoDimensionOutlineTree.AddNextFolderIndex(builder, NextFolderIndex);
			ITwoDimensionOutlineTree.AddRoot(builder, RootOffset);
			return ITwoDimensionOutlineTree.EndITwoDimensionOutlineTree(builder);
		}

		// Token: 0x0601D139 RID: 119097 RVA: 0x0041B051 File Offset: 0x00419251
		public static void StartITwoDimensionOutlineTree(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D13A RID: 119098 RVA: 0x0041B05A File Offset: 0x0041925A
		public static void AddRoot(FlatBufferBuilder builder, Offset<ITwoDimensionOutlineFolderNode> rootOffset)
		{
			builder.AddOffset(0, rootOffset.Value, 0);
		}

		// Token: 0x0601D13B RID: 119099 RVA: 0x0041B06A File Offset: 0x0041926A
		public static void AddNextFolderIndex(FlatBufferBuilder builder, int nextFolderIndex)
		{
			builder.AddInt(1, nextFolderIndex, 0);
		}

		// Token: 0x0601D13C RID: 119100 RVA: 0x0041B075 File Offset: 0x00419275
		public static Offset<ITwoDimensionOutlineTree> EndITwoDimensionOutlineTree(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionOutlineTree>(builder.EndTable());
		}

		// Token: 0x0601D13D RID: 119101 RVA: 0x0041B084 File Offset: 0x00419284
		public ITwoDimensionOutlineTreeT UnPack()
		{
			ITwoDimensionOutlineTreeT twoDimensionOutlineTreeT = new ITwoDimensionOutlineTreeT();
			this.UnPackTo(twoDimensionOutlineTreeT);
			return twoDimensionOutlineTreeT;
		}

		// Token: 0x0601D13E RID: 119102 RVA: 0x0041B0A0 File Offset: 0x004192A0
		public void UnPackTo(ITwoDimensionOutlineTreeT _o)
		{
			_o.Root = ((this.Root != null) ? this.Root.Value.UnPack() : null);
			_o.NextFolderIndex = this.NextFolderIndex;
		}

		// Token: 0x0601D13F RID: 119103 RVA: 0x0041B0E8 File Offset: 0x004192E8
		public static Offset<ITwoDimensionOutlineTree> Pack(FlatBufferBuilder builder, ITwoDimensionOutlineTreeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITwoDimensionOutlineTree>);
			}
			Offset<ITwoDimensionOutlineFolderNode> rootOffset = (_o.Root == null) ? default(Offset<ITwoDimensionOutlineFolderNode>) : ITwoDimensionOutlineFolderNode.Pack(builder, _o.Root);
			return ITwoDimensionOutlineTree.CreateITwoDimensionOutlineTree(builder, rootOffset, _o.NextFolderIndex);
		}

		// Token: 0x0400CEAF RID: 52911
		private Table __p;
	}
}
