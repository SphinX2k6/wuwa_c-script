using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004548 RID: 17736
	public struct IRollBlock1 : IFlatbufferObject
	{
		// Token: 0x17007DCD RID: 32205
		// (get) Token: 0x0601AAFF RID: 109311 RVA: 0x003CE80E File Offset: 0x003CCA0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AB00 RID: 109312 RVA: 0x003CE81B File Offset: 0x003CCA1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AB01 RID: 109313 RVA: 0x003CE824 File Offset: 0x003CCA24
		public static IRollBlock1 GetRootAsIRollBlock1(ByteBuffer _bb)
		{
			return IRollBlock1.GetRootAsIRollBlock1(_bb, default(IRollBlock1));
		}

		// Token: 0x0601AB02 RID: 109314 RVA: 0x003CE840 File Offset: 0x003CCA40
		public static IRollBlock1 GetRootAsIRollBlock1(ByteBuffer _bb, IRollBlock1 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AB03 RID: 109315 RVA: 0x003CE85D File Offset: 0x003CCA5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AB04 RID: 109316 RVA: 0x003CE86C File Offset: 0x003CCA6C
		public IRollBlock1 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DCE RID: 32206
		// (get) Token: 0x0601AB05 RID: 109317 RVA: 0x003CE87C File Offset: 0x003CCA7C
		public ERollBlockBlockType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERollBlockBlockType.Block1;
				}
				return (ERollBlockBlockType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007DCF RID: 32207
		// (get) Token: 0x0601AB06 RID: 109318 RVA: 0x003CE8B8 File Offset: 0x003CCAB8
		public int BlockId
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

		// Token: 0x0601AB07 RID: 109319 RVA: 0x003CE8F4 File Offset: 0x003CCAF4
		public static Offset<IRollBlock1> CreateIRollBlock1(FlatBufferBuilder builder, ERollBlockBlockType Type = ERollBlockBlockType.Block1, int BlockId = 0)
		{
			builder.StartTable(2);
			IRollBlock1.AddBlockId(builder, BlockId);
			IRollBlock1.AddType(builder, Type);
			return IRollBlock1.EndIRollBlock1(builder);
		}

		// Token: 0x0601AB08 RID: 109320 RVA: 0x003CE911 File Offset: 0x003CCB11
		public static void StartIRollBlock1(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AB09 RID: 109321 RVA: 0x003CE91A File Offset: 0x003CCB1A
		public static void AddType(FlatBufferBuilder builder, ERollBlockBlockType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AB0A RID: 109322 RVA: 0x003CE925 File Offset: 0x003CCB25
		public static void AddBlockId(FlatBufferBuilder builder, int blockId)
		{
			builder.AddInt(1, blockId, 0);
		}

		// Token: 0x0601AB0B RID: 109323 RVA: 0x003CE930 File Offset: 0x003CCB30
		public static Offset<IRollBlock1> EndIRollBlock1(FlatBufferBuilder builder)
		{
			return new Offset<IRollBlock1>(builder.EndTable());
		}

		// Token: 0x0601AB0C RID: 109324 RVA: 0x003CE940 File Offset: 0x003CCB40
		public IRollBlock1T UnPack()
		{
			IRollBlock1T rollBlock1T = new IRollBlock1T();
			this.UnPackTo(rollBlock1T);
			return rollBlock1T;
		}

		// Token: 0x0601AB0D RID: 109325 RVA: 0x003CE95B File Offset: 0x003CCB5B
		public void UnPackTo(IRollBlock1T _o)
		{
			_o.Type = this.Type;
			_o.BlockId = this.BlockId;
		}

		// Token: 0x0601AB0E RID: 109326 RVA: 0x003CE978 File Offset: 0x003CCB78
		public static Offset<IRollBlock1> Pack(FlatBufferBuilder builder, IRollBlock1T _o)
		{
			if (_o == null)
			{
				return default(Offset<IRollBlock1>);
			}
			return IRollBlock1.CreateIRollBlock1(builder, _o.Type, _o.BlockId);
		}

		// Token: 0x0400C5CF RID: 50639
		private Table __p;
	}
}
