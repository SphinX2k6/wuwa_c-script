using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EDF RID: 3807
	public struct PhantomBattleWinSeq : IFlatbufferObject
	{
		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x0600A806 RID: 43014 RVA: 0x002B1E00 File Offset: 0x002B0000
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A807 RID: 43015 RVA: 0x002B1E0D File Offset: 0x002B000D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A808 RID: 43016 RVA: 0x002B1E14 File Offset: 0x002B0014
		public static PhantomBattleWinSeq GetRootAsPhantomBattleWinSeq(ByteBuffer _bb)
		{
			return PhantomBattleWinSeq.GetRootAsPhantomBattleWinSeq(_bb, default(PhantomBattleWinSeq));
		}

		// Token: 0x0600A809 RID: 43017 RVA: 0x002B1E30 File Offset: 0x002B0030
		public static PhantomBattleWinSeq GetRootAsPhantomBattleWinSeq(ByteBuffer _bb, PhantomBattleWinSeq obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A80A RID: 43018 RVA: 0x002B1E4D File Offset: 0x002B004D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A80B RID: 43019 RVA: 0x002B1E5C File Offset: 0x002B005C
		public PhantomBattleWinSeq __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x0600A80C RID: 43020 RVA: 0x002B1E6C File Offset: 0x002B006C
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

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x0600A80D RID: 43021 RVA: 0x002B1EA8 File Offset: 0x002B00A8
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

		// Token: 0x0600A80E RID: 43022 RVA: 0x002B1EDF File Offset: 0x002B00DF
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A80F RID: 43023 RVA: 0x002B1EEE File Offset: 0x002B00EE
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x0600A810 RID: 43024 RVA: 0x002B1F08 File Offset: 0x002B0108
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

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x0600A811 RID: 43025 RVA: 0x002B1F44 File Offset: 0x002B0144
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

		// Token: 0x04004F9D RID: 20381
		private Table __p;
	}
}
