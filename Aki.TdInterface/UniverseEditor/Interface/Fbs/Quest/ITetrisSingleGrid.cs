using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004628 RID: 17960
	public struct ITetrisSingleGrid : IFlatbufferObject
	{
		// Token: 0x17007DA0 RID: 32160
		// (get) Token: 0x0601A466 RID: 107622 RVA: 0x003BD684 File Offset: 0x003BB884
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A467 RID: 107623 RVA: 0x003BD691 File Offset: 0x003BB891
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A468 RID: 107624 RVA: 0x003BD698 File Offset: 0x003BB898
		public static ITetrisSingleGrid GetRootAsITetrisSingleGrid(ByteBuffer _bb)
		{
			return ITetrisSingleGrid.GetRootAsITetrisSingleGrid(_bb, default(ITetrisSingleGrid));
		}

		// Token: 0x0601A469 RID: 107625 RVA: 0x003BD6B4 File Offset: 0x003BB8B4
		public static ITetrisSingleGrid GetRootAsITetrisSingleGrid(ByteBuffer _bb, ITetrisSingleGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A46A RID: 107626 RVA: 0x003BD6D1 File Offset: 0x003BB8D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A46B RID: 107627 RVA: 0x003BD6E0 File Offset: 0x003BB8E0
		public ITetrisSingleGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DA1 RID: 32161
		// (get) Token: 0x0601A46C RID: 107628 RVA: 0x003BD6F0 File Offset: 0x003BB8F0
		public ITetrisSingleBlock? Block
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITetrisSingleBlock?(default(ITetrisSingleBlock).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A46D RID: 107629 RVA: 0x003BD74D File Offset: 0x003BB94D
		public static Offset<ITetrisSingleGrid> CreateITetrisSingleGrid(FlatBufferBuilder builder, Offset<ITetrisSingleBlock> BlockOffset = default(Offset<ITetrisSingleBlock>))
		{
			builder.StartTable(1);
			ITetrisSingleGrid.AddBlock(builder, BlockOffset);
			return ITetrisSingleGrid.EndITetrisSingleGrid(builder);
		}

		// Token: 0x0601A46E RID: 107630 RVA: 0x003BD763 File Offset: 0x003BB963
		public static void StartITetrisSingleGrid(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A46F RID: 107631 RVA: 0x003BD76C File Offset: 0x003BB96C
		public static void AddBlock(FlatBufferBuilder builder, Offset<ITetrisSingleBlock> blockOffset)
		{
			builder.AddOffset(0, blockOffset.Value, 0);
		}

		// Token: 0x0601A470 RID: 107632 RVA: 0x003BD77C File Offset: 0x003BB97C
		public static Offset<ITetrisSingleGrid> EndITetrisSingleGrid(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisSingleGrid>(builder.EndTable());
		}

		// Token: 0x0601A471 RID: 107633 RVA: 0x003BD78C File Offset: 0x003BB98C
		public ITetrisSingleGridT UnPack()
		{
			ITetrisSingleGridT tetrisSingleGridT = new ITetrisSingleGridT();
			this.UnPackTo(tetrisSingleGridT);
			return tetrisSingleGridT;
		}

		// Token: 0x0601A472 RID: 107634 RVA: 0x003BD7A8 File Offset: 0x003BB9A8
		public void UnPackTo(ITetrisSingleGridT _o)
		{
			_o.Block = ((this.Block != null) ? this.Block.Value.UnPack() : null);
		}

		// Token: 0x0601A473 RID: 107635 RVA: 0x003BD7E4 File Offset: 0x003BB9E4
		public static Offset<ITetrisSingleGrid> Pack(FlatBufferBuilder builder, ITetrisSingleGridT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisSingleGrid>);
			}
			Offset<ITetrisSingleBlock> blockOffset = (_o.Block == null) ? default(Offset<ITetrisSingleBlock>) : ITetrisSingleBlock.Pack(builder, _o.Block);
			return ITetrisSingleGrid.CreateITetrisSingleGrid(builder, blockOffset);
		}

		// Token: 0x0400C824 RID: 51236
		private Table __p;
	}
}
