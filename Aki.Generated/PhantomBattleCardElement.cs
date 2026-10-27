using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC2 RID: 3778
	public struct PhantomBattleCardElement : IFlatbufferObject
	{
		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x0600A57A RID: 42362 RVA: 0x002AC440 File Offset: 0x002AA640
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A57B RID: 42363 RVA: 0x002AC44D File Offset: 0x002AA64D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A57C RID: 42364 RVA: 0x002AC454 File Offset: 0x002AA654
		public static PhantomBattleCardElement GetRootAsPhantomBattleCardElement(ByteBuffer _bb)
		{
			return PhantomBattleCardElement.GetRootAsPhantomBattleCardElement(_bb, default(PhantomBattleCardElement));
		}

		// Token: 0x0600A57D RID: 42365 RVA: 0x002AC470 File Offset: 0x002AA670
		public static PhantomBattleCardElement GetRootAsPhantomBattleCardElement(ByteBuffer _bb, PhantomBattleCardElement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A57E RID: 42366 RVA: 0x002AC48D File Offset: 0x002AA68D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A57F RID: 42367 RVA: 0x002AC49C File Offset: 0x002AA69C
		public PhantomBattleCardElement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x0600A580 RID: 42368 RVA: 0x002AC4AC File Offset: 0x002AA6AC
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

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x0600A581 RID: 42369 RVA: 0x002AC4E8 File Offset: 0x002AA6E8
		public string Name
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

		// Token: 0x0600A582 RID: 42370 RVA: 0x002AC51F File Offset: 0x002AA71F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A583 RID: 42371 RVA: 0x002AC52E File Offset: 0x002AA72E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x0600A584 RID: 42372 RVA: 0x002AC548 File Offset: 0x002AA748
		public string TabIcon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A585 RID: 42373 RVA: 0x002AC57F File Offset: 0x002AA77F
		public Span<byte> GetTabIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x002AC58E File Offset: 0x002AA78E
		public byte[] GetTabIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x0600A587 RID: 42375 RVA: 0x002AC5A8 File Offset: 0x002AA7A8
		public string TabElementColor
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A588 RID: 42376 RVA: 0x002AC5E0 File Offset: 0x002AA7E0
		public Span<byte> GetTabElementColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A589 RID: 42377 RVA: 0x002AC5F0 File Offset: 0x002AA7F0
		public byte[] GetTabElementColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x0600A58A RID: 42378 RVA: 0x002AC608 File Offset: 0x002AA808
		public string CardElementIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A58B RID: 42379 RVA: 0x002AC640 File Offset: 0x002AA840
		public Span<byte> GetCardElementIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A58C RID: 42380 RVA: 0x002AC650 File Offset: 0x002AA850
		public byte[] GetCardElementIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x0600A58D RID: 42381 RVA: 0x002AC668 File Offset: 0x002AA868
		public string DeleteFilterIcon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A58E RID: 42382 RVA: 0x002AC6A0 File Offset: 0x002AA8A0
		public Span<byte> GetDeleteFilterIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A58F RID: 42383 RVA: 0x002AC6B0 File Offset: 0x002AA8B0
		public byte[] GetDeleteFilterIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x0600A590 RID: 42384 RVA: 0x002AC6C8 File Offset: 0x002AA8C8
		public string QuicklyBuildFilterIcon
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A591 RID: 42385 RVA: 0x002AC700 File Offset: 0x002AA900
		public Span<byte> GetQuicklyBuildFilterIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A592 RID: 42386 RVA: 0x002AC710 File Offset: 0x002AA910
		public byte[] GetQuicklyBuildFilterIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x0600A593 RID: 42387 RVA: 0x002AC728 File Offset: 0x002AA928
		public string FieldActivateUi
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x002AC760 File Offset: 0x002AA960
		public Span<byte> GetFieldActivateUiBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A595 RID: 42389 RVA: 0x002AC770 File Offset: 0x002AA970
		public byte[] GetFieldActivateUiArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x0600A596 RID: 42390 RVA: 0x002AC788 File Offset: 0x002AA988
		public string FieldActivateMaterial
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A597 RID: 42391 RVA: 0x002AC7C0 File Offset: 0x002AA9C0
		public Span<byte> GetFieldActivateMaterialBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A598 RID: 42392 RVA: 0x002AC7D0 File Offset: 0x002AA9D0
		public byte[] GetFieldActivateMaterialArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x0600A599 RID: 42393 RVA: 0x002AC7E8 File Offset: 0x002AA9E8
		public string FieldElementNiagara
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A59A RID: 42394 RVA: 0x002AC820 File Offset: 0x002AAA20
		public Span<byte> GetFieldElementNiagaraBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A59B RID: 42395 RVA: 0x002AC830 File Offset: 0x002AAA30
		public byte[] GetFieldElementNiagaraArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x0600A59C RID: 42396 RVA: 0x002AC848 File Offset: 0x002AAA48
		public string FieldActivateElementNiagara
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A59D RID: 42397 RVA: 0x002AC880 File Offset: 0x002AAA80
		public Span<byte> GetFieldActivateElementNiagaraBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A59E RID: 42398 RVA: 0x002AC890 File Offset: 0x002AAA90
		public byte[] GetFieldActivateElementNiagaraArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x0600A59F RID: 42399 RVA: 0x002AC8A8 File Offset: 0x002AAAA8
		public string FieldCardElementInDeck
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x002AC8E0 File Offset: 0x002AAAE0
		public Span<byte> GetFieldCardElementInDeckBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A5A1 RID: 42401 RVA: 0x002AC8F0 File Offset: 0x002AAAF0
		public byte[] GetFieldCardElementInDeckArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x0600A5A2 RID: 42402 RVA: 0x002AC908 File Offset: 0x002AAB08
		public string FieldAudio
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A5A3 RID: 42403 RVA: 0x002AC940 File Offset: 0x002AAB40
		public Span<byte> GetFieldAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A5A4 RID: 42404 RVA: 0x002AC950 File Offset: 0x002AAB50
		public byte[] GetFieldAudioArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F7E RID: 20350
		private Table __p;
	}
}
