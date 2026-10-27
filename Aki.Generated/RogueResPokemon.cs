using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200100D RID: 4109
	public struct RogueResPokemon : IFlatbufferObject
	{
		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x0600C379 RID: 50041 RVA: 0x002EECEC File Offset: 0x002ECEEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C37A RID: 50042 RVA: 0x002EECF9 File Offset: 0x002ECEF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C37B RID: 50043 RVA: 0x002EED00 File Offset: 0x002ECF00
		public static RogueResPokemon GetRootAsRogueResPokemon(ByteBuffer _bb)
		{
			return RogueResPokemon.GetRootAsRogueResPokemon(_bb, default(RogueResPokemon));
		}

		// Token: 0x0600C37C RID: 50044 RVA: 0x002EED1C File Offset: 0x002ECF1C
		public static RogueResPokemon GetRootAsRogueResPokemon(ByteBuffer _bb, RogueResPokemon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C37D RID: 50045 RVA: 0x002EED39 File Offset: 0x002ECF39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C37E RID: 50046 RVA: 0x002EED48 File Offset: 0x002ECF48
		public RogueResPokemon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x0600C37F RID: 50047 RVA: 0x002EED58 File Offset: 0x002ECF58
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

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x0600C380 RID: 50048 RVA: 0x002EED94 File Offset: 0x002ECF94
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

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x0600C381 RID: 50049 RVA: 0x002EEDD0 File Offset: 0x002ECFD0
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

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x0600C382 RID: 50050 RVA: 0x002EEE0C File Offset: 0x002ED00C
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

		// Token: 0x0600C383 RID: 50051 RVA: 0x002EEE44 File Offset: 0x002ED044
		public Span<byte> GetPokemonIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C384 RID: 50052 RVA: 0x002EEE54 File Offset: 0x002ED054
		public byte[] GetPokemonIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x0600C385 RID: 50053 RVA: 0x002EEE6C File Offset: 0x002ED06C
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

		// Token: 0x0600C386 RID: 50054 RVA: 0x002EEEA4 File Offset: 0x002ED0A4
		public Span<byte> GetPokemonNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C387 RID: 50055 RVA: 0x002EEEB4 File Offset: 0x002ED0B4
		public byte[] GetPokemonNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x0600C388 RID: 50056 RVA: 0x002EEECC File Offset: 0x002ED0CC
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

		// Token: 0x0600C389 RID: 50057 RVA: 0x002EEF04 File Offset: 0x002ED104
		public Span<byte> GetPokemonSettleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C38A RID: 50058 RVA: 0x002EEF14 File Offset: 0x002ED114
		public byte[] GetPokemonSettleIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x0600C38B RID: 50059 RVA: 0x002EEF2C File Offset: 0x002ED12C
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

		// Token: 0x0600C38C RID: 50060 RVA: 0x002EEF64 File Offset: 0x002ED164
		public Span<byte> GetPokemonSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C38D RID: 50061 RVA: 0x002EEF74 File Offset: 0x002ED174
		public byte[] GetPokemonSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040050FA RID: 20730
		private Table __p;
	}
}
