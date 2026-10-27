using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E22 RID: 28194
	public struct IReignsCallCard : IFlatbufferObject
	{
		// Token: 0x1700D225 RID: 53797
		// (get) Token: 0x06031D11 RID: 204049 RVA: 0x006BE791 File Offset: 0x006BC991
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031D12 RID: 204050 RVA: 0x006BE79E File Offset: 0x006BC99E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031D13 RID: 204051 RVA: 0x006BE7A8 File Offset: 0x006BC9A8
		public static IReignsCallCard GetRootAsIReignsCallCard(ByteBuffer _bb)
		{
			return IReignsCallCard.GetRootAsIReignsCallCard(_bb, default(IReignsCallCard));
		}

		// Token: 0x06031D14 RID: 204052 RVA: 0x006BE7C4 File Offset: 0x006BC9C4
		public static IReignsCallCard GetRootAsIReignsCallCard(ByteBuffer _bb, IReignsCallCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031D15 RID: 204053 RVA: 0x006BE7E1 File Offset: 0x006BC9E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031D16 RID: 204054 RVA: 0x006BE7F0 File Offset: 0x006BC9F0
		public IReignsCallCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D226 RID: 53798
		// (get) Token: 0x06031D17 RID: 204055 RVA: 0x006BE800 File Offset: 0x006BCA00
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

		// Token: 0x06031D18 RID: 204056 RVA: 0x006BE83C File Offset: 0x006BCA3C
		public static Offset<IReignsCallCard> CreateIReignsCallCard(FlatBufferBuilder builder, int CardId = 0)
		{
			builder.StartTable(1);
			IReignsCallCard.AddCardId(builder, CardId);
			return IReignsCallCard.EndIReignsCallCard(builder);
		}

		// Token: 0x06031D19 RID: 204057 RVA: 0x006BE852 File Offset: 0x006BCA52
		public static void StartIReignsCallCard(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031D1A RID: 204058 RVA: 0x006BE85B File Offset: 0x006BCA5B
		public static void AddCardId(FlatBufferBuilder builder, int cardId)
		{
			builder.AddInt(0, cardId, 0);
		}

		// Token: 0x06031D1B RID: 204059 RVA: 0x006BE866 File Offset: 0x006BCA66
		public static Offset<IReignsCallCard> EndIReignsCallCard(FlatBufferBuilder builder)
		{
			return new Offset<IReignsCallCard>(builder.EndTable());
		}

		// Token: 0x06031D1C RID: 204060 RVA: 0x006BE874 File Offset: 0x006BCA74
		public IReignsCallCardT UnPack()
		{
			IReignsCallCardT reignsCallCardT = new IReignsCallCardT();
			this.UnPackTo(reignsCallCardT);
			return reignsCallCardT;
		}

		// Token: 0x06031D1D RID: 204061 RVA: 0x006BE88F File Offset: 0x006BCA8F
		public void UnPackTo(IReignsCallCardT _o)
		{
			_o.CardId = this.CardId;
		}

		// Token: 0x06031D1E RID: 204062 RVA: 0x006BE8A0 File Offset: 0x006BCAA0
		public static Offset<IReignsCallCard> Pack(FlatBufferBuilder builder, IReignsCallCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsCallCard>);
			}
			return IReignsCallCard.CreateIReignsCallCard(builder, _o.CardId);
		}

		// Token: 0x0401180B RID: 71691
		private Table __p;
	}
}
