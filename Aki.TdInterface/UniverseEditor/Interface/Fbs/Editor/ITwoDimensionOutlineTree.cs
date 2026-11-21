using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D1E RID: 19742
	public struct ITwoDimensionOutlineTree : IFlatbufferObject
	{
		// Token: 0x17008D4D RID: 36173
		// (get) Token: 0x0601E91D RID: 125213 RVA: 0x004476C6 File Offset: 0x004458C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E91E RID: 125214 RVA: 0x004476D3 File Offset: 0x004458D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E91F RID: 125215 RVA: 0x004476DC File Offset: 0x004458DC
		public static ITwoDimensionOutlineTree GetRootAsITwoDimensionOutlineTree(ByteBuffer _bb)
		{
			return ITwoDimensionOutlineTree.GetRootAsITwoDimensionOutlineTree(_bb, default(ITwoDimensionOutlineTree));
		}

		// Token: 0x0601E920 RID: 125216 RVA: 0x004476F8 File Offset: 0x004458F8
		public static ITwoDimensionOutlineTree GetRootAsITwoDimensionOutlineTree(ByteBuffer _bb, ITwoDimensionOutlineTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E921 RID: 125217 RVA: 0x00447715 File Offset: 0x00445915
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E922 RID: 125218 RVA: 0x00447724 File Offset: 0x00445924
		public ITwoDimensionOutlineTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D4E RID: 36174
		// (get) Token: 0x0601E923 RID: 125219 RVA: 0x00447734 File Offset: 0x00445934
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

		// Token: 0x17008D4F RID: 36175
		// (get) Token: 0x0601E924 RID: 125220 RVA: 0x00447794 File Offset: 0x00445994
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

		// Token: 0x0601E925 RID: 125221 RVA: 0x004477D0 File Offset: 0x004459D0
		public static Offset<ITwoDimensionOutlineTree> CreateITwoDimensionOutlineTree(FlatBufferBuilder builder, Offset<ITwoDimensionOutlineFolderNode> RootOffset = default(Offset<ITwoDimensionOutlineFolderNode>), int NextFolderIndex = 0)
		{
			builder.StartTable(2);
			ITwoDimensionOutlineTree.AddNextFolderIndex(builder, NextFolderIndex);
			ITwoDimensionOutlineTree.AddRoot(builder, RootOffset);
			return ITwoDimensionOutlineTree.EndITwoDimensionOutlineTree(builder);
		}

		// Token: 0x0601E926 RID: 125222 RVA: 0x004477ED File Offset: 0x004459ED
		public static void StartITwoDimensionOutlineTree(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E927 RID: 125223 RVA: 0x004477F6 File Offset: 0x004459F6
		public static void AddRoot(FlatBufferBuilder builder, Offset<ITwoDimensionOutlineFolderNode> rootOffset)
		{
			builder.AddOffset(0, rootOffset.Value, 0);
		}

		// Token: 0x0601E928 RID: 125224 RVA: 0x00447806 File Offset: 0x00445A06
		public static void AddNextFolderIndex(FlatBufferBuilder builder, int nextFolderIndex)
		{
			builder.AddInt(1, nextFolderIndex, 0);
		}

		// Token: 0x0601E929 RID: 125225 RVA: 0x00447811 File Offset: 0x00445A11
		public static Offset<ITwoDimensionOutlineTree> EndITwoDimensionOutlineTree(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionOutlineTree>(builder.EndTable());
		}

		// Token: 0x0601E92A RID: 125226 RVA: 0x00447820 File Offset: 0x00445A20
		public ITwoDimensionOutlineTreeT UnPack()
		{
			ITwoDimensionOutlineTreeT twoDimensionOutlineTreeT = new ITwoDimensionOutlineTreeT();
			this.UnPackTo(twoDimensionOutlineTreeT);
			return twoDimensionOutlineTreeT;
		}

		// Token: 0x0601E92B RID: 125227 RVA: 0x0044783C File Offset: 0x00445A3C
		public void UnPackTo(ITwoDimensionOutlineTreeT _o)
		{
			_o.Root = ((this.Root != null) ? this.Root.Value.UnPack() : null);
			_o.NextFolderIndex = this.NextFolderIndex;
		}

		// Token: 0x0601E92C RID: 125228 RVA: 0x00447884 File Offset: 0x00445A84
		public static Offset<ITwoDimensionOutlineTree> Pack(FlatBufferBuilder builder, ITwoDimensionOutlineTreeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITwoDimensionOutlineTree>);
			}
			Offset<ITwoDimensionOutlineFolderNode> rootOffset = (_o.Root == null) ? default(Offset<ITwoDimensionOutlineFolderNode>) : ITwoDimensionOutlineFolderNode.Pack(builder, _o.Root);
			return ITwoDimensionOutlineTree.CreateITwoDimensionOutlineTree(builder, rootOffset, _o.NextFolderIndex);
		}

		// Token: 0x0400D8E8 RID: 55528
		private Table __p;
	}
}
