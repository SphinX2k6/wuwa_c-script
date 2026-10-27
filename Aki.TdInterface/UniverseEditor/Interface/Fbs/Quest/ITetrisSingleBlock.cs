using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041CC RID: 16844
	public struct ITetrisSingleBlock : IFlatbufferObject
	{
		// Token: 0x17007771 RID: 30577
		// (get) Token: 0x06018CFC RID: 101628 RVA: 0x00392086 File Offset: 0x00390286
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018CFD RID: 101629 RVA: 0x00392093 File Offset: 0x00390293
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018CFE RID: 101630 RVA: 0x0039209C File Offset: 0x0039029C
		public static ITetrisSingleBlock GetRootAsITetrisSingleBlock(ByteBuffer _bb)
		{
			return ITetrisSingleBlock.GetRootAsITetrisSingleBlock(_bb, default(ITetrisSingleBlock));
		}

		// Token: 0x06018CFF RID: 101631 RVA: 0x003920B8 File Offset: 0x003902B8
		public static ITetrisSingleBlock GetRootAsITetrisSingleBlock(ByteBuffer _bb, ITetrisSingleBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018D00 RID: 101632 RVA: 0x003920D5 File Offset: 0x003902D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018D01 RID: 101633 RVA: 0x003920E4 File Offset: 0x003902E4
		public ITetrisSingleBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007772 RID: 30578
		// (get) Token: 0x06018D02 RID: 101634 RVA: 0x003920F4 File Offset: 0x003902F4
		public string StyleName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018D03 RID: 101635 RVA: 0x0039212B File Offset: 0x0039032B
		public Span<byte> GetStyleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06018D04 RID: 101636 RVA: 0x0039213A File Offset: 0x0039033A
		public byte[] GetStyleNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06018D05 RID: 101637 RVA: 0x00392148 File Offset: 0x00390348
		public static Offset<ITetrisSingleBlock> CreateITetrisSingleBlock(FlatBufferBuilder builder, StringOffset StyleNameOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ITetrisSingleBlock.AddStyleName(builder, StyleNameOffset);
			return ITetrisSingleBlock.EndITetrisSingleBlock(builder);
		}

		// Token: 0x06018D06 RID: 101638 RVA: 0x0039215E File Offset: 0x0039035E
		public static void StartITetrisSingleBlock(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018D07 RID: 101639 RVA: 0x00392167 File Offset: 0x00390367
		public static void AddStyleName(FlatBufferBuilder builder, StringOffset styleNameOffset)
		{
			builder.AddOffset(0, styleNameOffset.Value, 0);
		}

		// Token: 0x06018D08 RID: 101640 RVA: 0x00392177 File Offset: 0x00390377
		public static Offset<ITetrisSingleBlock> EndITetrisSingleBlock(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisSingleBlock>(builder.EndTable());
		}

		// Token: 0x06018D09 RID: 101641 RVA: 0x00392184 File Offset: 0x00390384
		public ITetrisSingleBlockT UnPack()
		{
			ITetrisSingleBlockT tetrisSingleBlockT = new ITetrisSingleBlockT();
			this.UnPackTo(tetrisSingleBlockT);
			return tetrisSingleBlockT;
		}

		// Token: 0x06018D0A RID: 101642 RVA: 0x0039219F File Offset: 0x0039039F
		public void UnPackTo(ITetrisSingleBlockT _o)
		{
			_o.StyleName = this.StyleName;
		}

		// Token: 0x06018D0B RID: 101643 RVA: 0x003921B0 File Offset: 0x003903B0
		public static Offset<ITetrisSingleBlock> Pack(FlatBufferBuilder builder, ITetrisSingleBlockT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisSingleBlock>);
			}
			StringOffset styleNameOffset = (_o.StyleName == null) ? default(StringOffset) : builder.CreateString(_o.StyleName);
			return ITetrisSingleBlock.CreateITetrisSingleBlock(builder, styleNameOffset);
		}

		// Token: 0x0400BE18 RID: 48664
		private Table __p;
	}
}
