using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200462B RID: 17963
	public struct ITetrisSingleIndexGrid : IFlatbufferObject
	{
		// Token: 0x17007DA3 RID: 32163
		// (get) Token: 0x0601A478 RID: 107640 RVA: 0x003BD87F File Offset: 0x003BBA7F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A479 RID: 107641 RVA: 0x003BD88C File Offset: 0x003BBA8C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A47A RID: 107642 RVA: 0x003BD894 File Offset: 0x003BBA94
		public static ITetrisSingleIndexGrid GetRootAsITetrisSingleIndexGrid(ByteBuffer _bb)
		{
			return ITetrisSingleIndexGrid.GetRootAsITetrisSingleIndexGrid(_bb, default(ITetrisSingleIndexGrid));
		}

		// Token: 0x0601A47B RID: 107643 RVA: 0x003BD8B0 File Offset: 0x003BBAB0
		public static ITetrisSingleIndexGrid GetRootAsITetrisSingleIndexGrid(ByteBuffer _bb, ITetrisSingleIndexGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A47C RID: 107644 RVA: 0x003BD8CD File Offset: 0x003BBACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A47D RID: 107645 RVA: 0x003BD8DC File Offset: 0x003BBADC
		public ITetrisSingleIndexGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DA4 RID: 32164
		// (get) Token: 0x0601A47E RID: 107646 RVA: 0x003BD8EC File Offset: 0x003BBAEC
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

		// Token: 0x17007DA5 RID: 32165
		// (get) Token: 0x0601A47F RID: 107647 RVA: 0x003BD928 File Offset: 0x003BBB28
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

		// Token: 0x0601A480 RID: 107648 RVA: 0x003BD985 File Offset: 0x003BBB85
		public static Offset<ITetrisSingleIndexGrid> CreateITetrisSingleIndexGrid(FlatBufferBuilder builder, int Index = 0, Offset<ITetrisSingleGrid> ValueOffset = default(Offset<ITetrisSingleGrid>))
		{
			builder.StartTable(2);
			ITetrisSingleIndexGrid.AddValue(builder, ValueOffset);
			ITetrisSingleIndexGrid.AddIndex(builder, Index);
			return ITetrisSingleIndexGrid.EndITetrisSingleIndexGrid(builder);
		}

		// Token: 0x0601A481 RID: 107649 RVA: 0x003BD9A2 File Offset: 0x003BBBA2
		public static void StartITetrisSingleIndexGrid(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A482 RID: 107650 RVA: 0x003BD9AB File Offset: 0x003BBBAB
		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		// Token: 0x0601A483 RID: 107651 RVA: 0x003BD9B6 File Offset: 0x003BBBB6
		public static void AddValue(FlatBufferBuilder builder, Offset<ITetrisSingleGrid> valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		// Token: 0x0601A484 RID: 107652 RVA: 0x003BD9C6 File Offset: 0x003BBBC6
		public static Offset<ITetrisSingleIndexGrid> EndITetrisSingleIndexGrid(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisSingleIndexGrid>(builder.EndTable());
		}

		// Token: 0x0601A485 RID: 107653 RVA: 0x003BD9D4 File Offset: 0x003BBBD4
		public ITetrisSingleIndexGridT UnPack()
		{
			ITetrisSingleIndexGridT tetrisSingleIndexGridT = new ITetrisSingleIndexGridT();
			this.UnPackTo(tetrisSingleIndexGridT);
			return tetrisSingleIndexGridT;
		}

		// Token: 0x0601A486 RID: 107654 RVA: 0x003BD9F0 File Offset: 0x003BBBF0
		public void UnPackTo(ITetrisSingleIndexGridT _o)
		{
			_o.Index = this.Index;
			_o.Value = ((this.Value != null) ? this.Value.Value.UnPack() : null);
		}

		// Token: 0x0601A487 RID: 107655 RVA: 0x003BDA38 File Offset: 0x003BBC38
		public static Offset<ITetrisSingleIndexGrid> Pack(FlatBufferBuilder builder, ITetrisSingleIndexGridT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisSingleIndexGrid>);
			}
			Offset<ITetrisSingleGrid> valueOffset = (_o.Value == null) ? default(Offset<ITetrisSingleGrid>) : ITetrisSingleGrid.Pack(builder, _o.Value);
			return ITetrisSingleIndexGrid.CreateITetrisSingleIndexGrid(builder, _o.Index, valueOffset);
		}

		// Token: 0x0400C826 RID: 51238
		private Table __p;
	}
}
