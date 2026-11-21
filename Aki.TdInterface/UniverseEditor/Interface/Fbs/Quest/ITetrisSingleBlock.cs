using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004625 RID: 17957
	public struct ITetrisSingleBlock : IFlatbufferObject
	{
		// Token: 0x17007D9D RID: 32157
		// (get) Token: 0x0601A452 RID: 107602 RVA: 0x003BD4DA File Offset: 0x003BB6DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A453 RID: 107603 RVA: 0x003BD4E7 File Offset: 0x003BB6E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A454 RID: 107604 RVA: 0x003BD4F0 File Offset: 0x003BB6F0
		public static ITetrisSingleBlock GetRootAsITetrisSingleBlock(ByteBuffer _bb)
		{
			return ITetrisSingleBlock.GetRootAsITetrisSingleBlock(_bb, default(ITetrisSingleBlock));
		}

		// Token: 0x0601A455 RID: 107605 RVA: 0x003BD50C File Offset: 0x003BB70C
		public static ITetrisSingleBlock GetRootAsITetrisSingleBlock(ByteBuffer _bb, ITetrisSingleBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A456 RID: 107606 RVA: 0x003BD529 File Offset: 0x003BB729
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A457 RID: 107607 RVA: 0x003BD538 File Offset: 0x003BB738
		public ITetrisSingleBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D9E RID: 32158
		// (get) Token: 0x0601A458 RID: 107608 RVA: 0x003BD548 File Offset: 0x003BB748
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

		// Token: 0x0601A459 RID: 107609 RVA: 0x003BD57F File Offset: 0x003BB77F
		public Span<byte> GetStyleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601A45A RID: 107610 RVA: 0x003BD58E File Offset: 0x003BB78E
		public byte[] GetStyleNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601A45B RID: 107611 RVA: 0x003BD59C File Offset: 0x003BB79C
		public static Offset<ITetrisSingleBlock> CreateITetrisSingleBlock(FlatBufferBuilder builder, StringOffset StyleNameOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ITetrisSingleBlock.AddStyleName(builder, StyleNameOffset);
			return ITetrisSingleBlock.EndITetrisSingleBlock(builder);
		}

		// Token: 0x0601A45C RID: 107612 RVA: 0x003BD5B2 File Offset: 0x003BB7B2
		public static void StartITetrisSingleBlock(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A45D RID: 107613 RVA: 0x003BD5BB File Offset: 0x003BB7BB
		public static void AddStyleName(FlatBufferBuilder builder, StringOffset styleNameOffset)
		{
			builder.AddOffset(0, styleNameOffset.Value, 0);
		}

		// Token: 0x0601A45E RID: 107614 RVA: 0x003BD5CB File Offset: 0x003BB7CB
		public static Offset<ITetrisSingleBlock> EndITetrisSingleBlock(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisSingleBlock>(builder.EndTable());
		}

		// Token: 0x0601A45F RID: 107615 RVA: 0x003BD5D8 File Offset: 0x003BB7D8
		public ITetrisSingleBlockT UnPack()
		{
			ITetrisSingleBlockT tetrisSingleBlockT = new ITetrisSingleBlockT();
			this.UnPackTo(tetrisSingleBlockT);
			return tetrisSingleBlockT;
		}

		// Token: 0x0601A460 RID: 107616 RVA: 0x003BD5F3 File Offset: 0x003BB7F3
		public void UnPackTo(ITetrisSingleBlockT _o)
		{
			_o.StyleName = this.StyleName;
		}

		// Token: 0x0601A461 RID: 107617 RVA: 0x003BD604 File Offset: 0x003BB804
		public static Offset<ITetrisSingleBlock> Pack(FlatBufferBuilder builder, ITetrisSingleBlockT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisSingleBlock>);
			}
			StringOffset styleNameOffset = (_o.StyleName == null) ? default(StringOffset) : builder.CreateString(_o.StyleName);
			return ITetrisSingleBlock.CreateITetrisSingleBlock(builder, styleNameOffset);
		}

		// Token: 0x0400C822 RID: 51234
		private Table __p;
	}
}
