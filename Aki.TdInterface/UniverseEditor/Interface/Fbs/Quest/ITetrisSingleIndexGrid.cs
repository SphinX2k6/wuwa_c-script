using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D2 RID: 16850
	public struct ITetrisSingleIndexGrid : IFlatbufferObject
	{
		// Token: 0x17007777 RID: 30583
		// (get) Token: 0x06018D22 RID: 101666 RVA: 0x0039242B File Offset: 0x0039062B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018D23 RID: 101667 RVA: 0x00392438 File Offset: 0x00390638
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018D24 RID: 101668 RVA: 0x00392440 File Offset: 0x00390640
		public static ITetrisSingleIndexGrid GetRootAsITetrisSingleIndexGrid(ByteBuffer _bb)
		{
			return ITetrisSingleIndexGrid.GetRootAsITetrisSingleIndexGrid(_bb, default(ITetrisSingleIndexGrid));
		}

		// Token: 0x06018D25 RID: 101669 RVA: 0x0039245C File Offset: 0x0039065C
		public static ITetrisSingleIndexGrid GetRootAsITetrisSingleIndexGrid(ByteBuffer _bb, ITetrisSingleIndexGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018D26 RID: 101670 RVA: 0x00392479 File Offset: 0x00390679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018D27 RID: 101671 RVA: 0x00392488 File Offset: 0x00390688
		public ITetrisSingleIndexGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007778 RID: 30584
		// (get) Token: 0x06018D28 RID: 101672 RVA: 0x00392498 File Offset: 0x00390698
		public int Index
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

		// Token: 0x17007779 RID: 30585
		// (get) Token: 0x06018D29 RID: 101673 RVA: 0x003924D4 File Offset: 0x003906D4
		public ITetrisSingleGrid? Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITetrisSingleGrid?(default(ITetrisSingleGrid).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06018D2A RID: 101674 RVA: 0x00392531 File Offset: 0x00390731
		public static Offset<ITetrisSingleIndexGrid> CreateITetrisSingleIndexGrid(FlatBufferBuilder builder, int Index = 0, Offset<ITetrisSingleGrid> ValueOffset = default(Offset<ITetrisSingleGrid>))
		{
			builder.StartTable(2);
			ITetrisSingleIndexGrid.AddValue(builder, ValueOffset);
			ITetrisSingleIndexGrid.AddIndex(builder, Index);
			return ITetrisSingleIndexGrid.EndITetrisSingleIndexGrid(builder);
		}

		// Token: 0x06018D2B RID: 101675 RVA: 0x0039254E File Offset: 0x0039074E
		public static void StartITetrisSingleIndexGrid(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018D2C RID: 101676 RVA: 0x00392557 File Offset: 0x00390757
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		// Token: 0x06018D2D RID: 101677 RVA: 0x00392562 File Offset: 0x00390762
		public static void AddValue(FlatBufferBuilder builder, Offset<ITetrisSingleGrid> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x06018D2E RID: 101678 RVA: 0x00392572 File Offset: 0x00390772
		public static Offset<ITetrisSingleIndexGrid> EndITetrisSingleIndexGrid(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisSingleIndexGrid>(builder.EndTable());
		}

		// Token: 0x06018D2F RID: 101679 RVA: 0x00392580 File Offset: 0x00390780
		public ITetrisSingleIndexGridT UnPack()
		{
			ITetrisSingleIndexGridT tetrisSingleIndexGridT = new ITetrisSingleIndexGridT();
			this.UnPackTo(tetrisSingleIndexGridT);
			return tetrisSingleIndexGridT;
		}

		// Token: 0x06018D30 RID: 101680 RVA: 0x0039259C File Offset: 0x0039079C
		public void UnPackTo(ITetrisSingleIndexGridT _o)
		{
			_o.Index = this.Index;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x06018D31 RID: 101681 RVA: 0x003925E4 File Offset: 0x003907E4
		public static Offset<ITetrisSingleIndexGrid> Pack(FlatBufferBuilder builder, ITetrisSingleIndexGridT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisSingleIndexGrid>);
			}
			Offset<ITetrisSingleGrid> valueOffset = (_o.Value == null) ? default(Offset<ITetrisSingleGrid>) : ITetrisSingleGrid.Pack(builder, _o.Value);
			return ITetrisSingleIndexGrid.CreateITetrisSingleIndexGrid(builder, _o.Index, valueOffset);
		}

		// Token: 0x0400BE1C RID: 48668
		private Table __p;
	}
}
