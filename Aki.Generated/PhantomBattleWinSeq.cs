using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC4 RID: 4036
	public struct PhantomBattleWinSeq : IFlatbufferObject
	{
		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x0600AE27 RID: 44583 RVA: 0x002CEEA4 File Offset: 0x002CD0A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE28 RID: 44584 RVA: 0x002CEEB1 File Offset: 0x002CD0B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE29 RID: 44585 RVA: 0x002CEEB8 File Offset: 0x002CD0B8
		public static PhantomBattleWinSeq GetRootAsPhantomBattleWinSeq(ByteBuffer _bb)
		{
			return PhantomBattleWinSeq.GetRootAsPhantomBattleWinSeq(_bb, default(PhantomBattleWinSeq));
		}

		// Token: 0x0600AE2A RID: 44586 RVA: 0x002CEED4 File Offset: 0x002CD0D4
		public static PhantomBattleWinSeq GetRootAsPhantomBattleWinSeq(ByteBuffer _bb, PhantomBattleWinSeq obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE2B RID: 44587 RVA: 0x002CEEF1 File Offset: 0x002CD0F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE2C RID: 44588 RVA: 0x002CEF00 File Offset: 0x002CD100
		public PhantomBattleWinSeq __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x0600AE2D RID: 44589 RVA: 0x002CEF10 File Offset: 0x002CD110
		public int Id
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

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x0600AE2E RID: 44590 RVA: 0x002CEF4C File Offset: 0x002CD14C
		public string FlowListName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AE2F RID: 44591 RVA: 0x002CEF83 File Offset: 0x002CD183
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AE30 RID: 44592 RVA: 0x002CEF92 File Offset: 0x002CD192
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x0600AE31 RID: 44593 RVA: 0x002CEFAC File Offset: 0x002CD1AC
		public int FlowId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x0600AE32 RID: 44594 RVA: 0x002CEFE8 File Offset: 0x002CD1E8
		public int StateId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005582 RID: 21890
		private Table __p;
	}
}
