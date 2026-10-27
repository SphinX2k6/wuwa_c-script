using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006218 RID: 25112
	public struct IBossPilingRandomBuff : IFlatbufferObject
	{
		// Token: 0x1700BB22 RID: 47906
		// (get) Token: 0x0602B48C RID: 177292 RVA: 0x005F6316 File Offset: 0x005F4516
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B48D RID: 177293 RVA: 0x005F6323 File Offset: 0x005F4523
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B48E RID: 177294 RVA: 0x005F632C File Offset: 0x005F452C
		public static IBossPilingRandomBuff GetRootAsIBossPilingRandomBuff(ByteBuffer _bb)
		{
			return IBossPilingRandomBuff.GetRootAsIBossPilingRandomBuff(_bb, default(IBossPilingRandomBuff));
		}

		// Token: 0x0602B48F RID: 177295 RVA: 0x005F6348 File Offset: 0x005F4548
		public static IBossPilingRandomBuff GetRootAsIBossPilingRandomBuff(ByteBuffer _bb, IBossPilingRandomBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B490 RID: 177296 RVA: 0x005F6365 File Offset: 0x005F4565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B491 RID: 177297 RVA: 0x005F6374 File Offset: 0x005F4574
		public IBossPilingRandomBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB23 RID: 47907
		// (get) Token: 0x0602B492 RID: 177298 RVA: 0x005F6384 File Offset: 0x005F4584
		public int BuffPoolId
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

		// Token: 0x0602B493 RID: 177299 RVA: 0x005F63C0 File Offset: 0x005F45C0
		public static Offset<IBossPilingRandomBuff> CreateIBossPilingRandomBuff(FlatBufferBuilder builder, int BuffPoolId = 0)
		{
			builder.StartTable(1);
			IBossPilingRandomBuff.AddBuffPoolId(builder, BuffPoolId);
			return IBossPilingRandomBuff.EndIBossPilingRandomBuff(builder);
		}

		// Token: 0x0602B494 RID: 177300 RVA: 0x005F63D6 File Offset: 0x005F45D6
		public static void StartIBossPilingRandomBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B495 RID: 177301 RVA: 0x005F63DF File Offset: 0x005F45DF
		public static void AddBuffPoolId(FlatBufferBuilder builder, int buffPoolId)
		{
			builder.AddInt(0, buffPoolId, 0);
		}

		// Token: 0x0602B496 RID: 177302 RVA: 0x005F63EA File Offset: 0x005F45EA
		public static Offset<IBossPilingRandomBuff> EndIBossPilingRandomBuff(FlatBufferBuilder builder)
		{
			return new Offset<IBossPilingRandomBuff>(builder.EndTable());
		}

		// Token: 0x0602B497 RID: 177303 RVA: 0x005F63F8 File Offset: 0x005F45F8
		public IBossPilingRandomBuffT UnPack()
		{
			IBossPilingRandomBuffT bossPilingRandomBuffT = new IBossPilingRandomBuffT();
			this.UnPackTo(bossPilingRandomBuffT);
			return bossPilingRandomBuffT;
		}

		// Token: 0x0602B498 RID: 177304 RVA: 0x005F6413 File Offset: 0x005F4613
		public void UnPackTo(IBossPilingRandomBuffT _o)
		{
			_o.BuffPoolId = this.BuffPoolId;
		}

		// Token: 0x0602B499 RID: 177305 RVA: 0x005F6424 File Offset: 0x005F4624
		public static Offset<IBossPilingRandomBuff> Pack(FlatBufferBuilder builder, IBossPilingRandomBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBossPilingRandomBuff>);
			}
			return IBossPilingRandomBuff.CreateIBossPilingRandomBuff(builder, _o.BuffPoolId);
		}

		// Token: 0x04010756 RID: 67414
		private Table __p;
	}
}
