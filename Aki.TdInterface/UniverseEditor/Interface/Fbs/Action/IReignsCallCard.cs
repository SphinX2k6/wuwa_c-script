using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A0 RID: 30112
	public struct IReignsCallCard : IFlatbufferObject
	{
		// Token: 0x1700DD74 RID: 56692
		// (get) Token: 0x06034D27 RID: 216359 RVA: 0x0071A119 File Offset: 0x00718319
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034D28 RID: 216360 RVA: 0x0071A126 File Offset: 0x00718326
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034D29 RID: 216361 RVA: 0x0071A130 File Offset: 0x00718330
		public static IReignsCallCard GetRootAsIReignsCallCard(ByteBuffer _bb)
		{
			return IReignsCallCard.GetRootAsIReignsCallCard(_bb, default(IReignsCallCard));
		}

		// Token: 0x06034D2A RID: 216362 RVA: 0x0071A14C File Offset: 0x0071834C
		public static IReignsCallCard GetRootAsIReignsCallCard(ByteBuffer _bb, IReignsCallCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034D2B RID: 216363 RVA: 0x0071A169 File Offset: 0x00718369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034D2C RID: 216364 RVA: 0x0071A178 File Offset: 0x00718378
		public IReignsCallCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD75 RID: 56693
		// (get) Token: 0x06034D2D RID: 216365 RVA: 0x0071A188 File Offset: 0x00718388
		public int CardId
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

		// Token: 0x06034D2E RID: 216366 RVA: 0x0071A1C4 File Offset: 0x007183C4
		public static Offset<IReignsCallCard> CreateIReignsCallCard(FlatBufferBuilder builder, int CardId = 0)
		{
			builder.StartTable(1);
			IReignsCallCard.AddCardId(builder, CardId);
			return IReignsCallCard.EndIReignsCallCard(builder);
		}

		// Token: 0x06034D2F RID: 216367 RVA: 0x0071A1DA File Offset: 0x007183DA
		public static void StartIReignsCallCard(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034D30 RID: 216368 RVA: 0x0071A1E3 File Offset: 0x007183E3
		public static void AddCardId(FlatBufferBuilder builder, int cardId)
		{
			builder.AddInt(0, cardId, 0);
		}

		// Token: 0x06034D31 RID: 216369 RVA: 0x0071A1EE File Offset: 0x007183EE
		public static Offset<IReignsCallCard> EndIReignsCallCard(FlatBufferBuilder builder)
		{
			return new Offset<IReignsCallCard>(builder.EndTable());
		}

		// Token: 0x06034D32 RID: 216370 RVA: 0x0071A1FC File Offset: 0x007183FC
		public IReignsCallCardT UnPack()
		{
			IReignsCallCardT reignsCallCardT = new IReignsCallCardT();
			this.UnPackTo(reignsCallCardT);
			return reignsCallCardT;
		}

		// Token: 0x06034D33 RID: 216371 RVA: 0x0071A217 File Offset: 0x00718417
		public void UnPackTo(IReignsCallCardT _o)
		{
			_o.CardId = this.CardId;
		}

		// Token: 0x06034D34 RID: 216372 RVA: 0x0071A228 File Offset: 0x00718428
		public static Offset<IReignsCallCard> Pack(FlatBufferBuilder builder, IReignsCallCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsCallCard>);
			}
			return IReignsCallCard.CreateIReignsCallCard(builder, _o.CardId);
		}

		// Token: 0x0401278B RID: 75659
		private Table __p;
	}
}
