using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041CF RID: 16847
	public struct ITetrisSingleGrid : IFlatbufferObject
	{
		// Token: 0x17007774 RID: 30580
		// (get) Token: 0x06018D10 RID: 101648 RVA: 0x00392230 File Offset: 0x00390430
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018D11 RID: 101649 RVA: 0x0039223D File Offset: 0x0039043D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018D12 RID: 101650 RVA: 0x00392244 File Offset: 0x00390444
		public static ITetrisSingleGrid GetRootAsITetrisSingleGrid(ByteBuffer _bb)
		{
			return ITetrisSingleGrid.GetRootAsITetrisSingleGrid(_bb, default(ITetrisSingleGrid));
		}

		// Token: 0x06018D13 RID: 101651 RVA: 0x00392260 File Offset: 0x00390460
		public static ITetrisSingleGrid GetRootAsITetrisSingleGrid(ByteBuffer _bb, ITetrisSingleGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018D14 RID: 101652 RVA: 0x0039227D File Offset: 0x0039047D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018D15 RID: 101653 RVA: 0x0039228C File Offset: 0x0039048C
		public ITetrisSingleGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007775 RID: 30581
		// (get) Token: 0x06018D16 RID: 101654 RVA: 0x0039229C File Offset: 0x0039049C
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

		// Token: 0x06018D17 RID: 101655 RVA: 0x003922F9 File Offset: 0x003904F9
		public static Offset<ITetrisSingleGrid> CreateITetrisSingleGrid(FlatBufferBuilder builder, Offset<ITetrisSingleBlock> BlockOffset = default(Offset<ITetrisSingleBlock>))
		{
			builder.StartTable(1);
			ITetrisSingleGrid.AddBlock(builder, BlockOffset);
			return ITetrisSingleGrid.EndITetrisSingleGrid(builder);
		}

		// Token: 0x06018D18 RID: 101656 RVA: 0x0039230F File Offset: 0x0039050F
		public static void StartITetrisSingleGrid(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018D19 RID: 101657 RVA: 0x00392318 File Offset: 0x00390518
		public static void AddBlock(FlatBufferBuilder builder, Offset<ITetrisSingleBlock> blockOffset)
		{
			builder.AddOffset(0, blockOffset.Value, 0);
		}

		// Token: 0x06018D1A RID: 101658 RVA: 0x00392328 File Offset: 0x00390528
		public static Offset<ITetrisSingleGrid> EndITetrisSingleGrid(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisSingleGrid>(builder.EndTable());
		}

		// Token: 0x06018D1B RID: 101659 RVA: 0x00392338 File Offset: 0x00390538
		public ITetrisSingleGridT UnPack()
		{
			ITetrisSingleGridT tetrisSingleGridT = new ITetrisSingleGridT();
			this.UnPackTo(tetrisSingleGridT);
			return tetrisSingleGridT;
		}

		// Token: 0x06018D1C RID: 101660 RVA: 0x00392354 File Offset: 0x00390554
		public void UnPackTo(ITetrisSingleGridT _o)
		{
			_o.Block = ((this.Block != null) ? this.Block.Value.UnPack() : null);
		}

		// Token: 0x06018D1D RID: 101661 RVA: 0x00392390 File Offset: 0x00390590
		public static Offset<ITetrisSingleGrid> Pack(FlatBufferBuilder builder, ITetrisSingleGridT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisSingleGrid>);
			}
			Offset<ITetrisSingleBlock> blockOffset = (_o.Block == null) ? default(Offset<ITetrisSingleBlock>) : ITetrisSingleBlock.Pack(builder, _o.Block);
			return ITetrisSingleGrid.CreateITetrisSingleGrid(builder, blockOffset);
		}

		// Token: 0x0400BE1A RID: 48666
		private Table __p;
	}
}
