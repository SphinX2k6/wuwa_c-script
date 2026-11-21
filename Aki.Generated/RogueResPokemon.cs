using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F5 RID: 4341
	public struct RogueResPokemon : IFlatbufferObject
	{
		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x0600C9C3 RID: 51651 RVA: 0x0030ADC8 File Offset: 0x00308FC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C9C4 RID: 51652 RVA: 0x0030ADD5 File Offset: 0x00308FD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C9C5 RID: 51653 RVA: 0x0030ADDC File Offset: 0x00308FDC
		public static RogueResPokemon GetRootAsRogueResPokemon(ByteBuffer _bb)
		{
			return RogueResPokemon.GetRootAsRogueResPokemon(_bb, default(RogueResPokemon));
		}

		// Token: 0x0600C9C6 RID: 51654 RVA: 0x0030ADF8 File Offset: 0x00308FF8
		public static RogueResPokemon GetRootAsRogueResPokemon(ByteBuffer _bb, RogueResPokemon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C9C7 RID: 51655 RVA: 0x0030AE15 File Offset: 0x00309015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C9C8 RID: 51656 RVA: 0x0030AE24 File Offset: 0x00309024
		public RogueResPokemon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x0600C9C9 RID: 51657 RVA: 0x0030AE34 File Offset: 0x00309034
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

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x0600C9CA RID: 51658 RVA: 0x0030AE70 File Offset: 0x00309070
		public int PhantomItem
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

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x0600C9CB RID: 51659 RVA: 0x0030AEAC File Offset: 0x003090AC
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x0600C9CC RID: 51660 RVA: 0x0030AEE8 File Offset: 0x003090E8
		public string PokemonIcon
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

		// Token: 0x0600C9CD RID: 51661 RVA: 0x0030AF20 File Offset: 0x00309120
		public Span<byte> GetPokemonIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C9CE RID: 51662 RVA: 0x0030AF30 File Offset: 0x00309130
		public byte[] GetPokemonIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x0600C9CF RID: 51663 RVA: 0x0030AF48 File Offset: 0x00309148
		public string PokemonName
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

		// Token: 0x0600C9D0 RID: 51664 RVA: 0x0030AF80 File Offset: 0x00309180
		public Span<byte> GetPokemonNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C9D1 RID: 51665 RVA: 0x0030AF90 File Offset: 0x00309190
		public byte[] GetPokemonNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x0600C9D2 RID: 51666 RVA: 0x0030AFA8 File Offset: 0x003091A8
		public string PokemonSettleIcon
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

		// Token: 0x0600C9D3 RID: 51667 RVA: 0x0030AFE0 File Offset: 0x003091E0
		public Span<byte> GetPokemonSettleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C9D4 RID: 51668 RVA: 0x0030AFF0 File Offset: 0x003091F0
		public byte[] GetPokemonSettleIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x0600C9D5 RID: 51669 RVA: 0x0030B008 File Offset: 0x00309208
		public string PokemonSkillDesc
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

		// Token: 0x0600C9D6 RID: 51670 RVA: 0x0030B040 File Offset: 0x00309240
		public Span<byte> GetPokemonSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C9D7 RID: 51671 RVA: 0x0030B050 File Offset: 0x00309250
		public byte[] GetPokemonSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040056E2 RID: 22242
		private Table __p;
	}
}
