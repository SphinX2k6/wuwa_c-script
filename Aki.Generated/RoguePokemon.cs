using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE9 RID: 4073
	public struct RoguePokemon : IFlatbufferObject
	{
		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x0600C016 RID: 49174 RVA: 0x002E7502 File Offset: 0x002E5702
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C017 RID: 49175 RVA: 0x002E750F File Offset: 0x002E570F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C018 RID: 49176 RVA: 0x002E7518 File Offset: 0x002E5718
		public static RoguePokemon GetRootAsRoguePokemon(ByteBuffer _bb)
		{
			return RoguePokemon.GetRootAsRoguePokemon(_bb, default(RoguePokemon));
		}

		// Token: 0x0600C019 RID: 49177 RVA: 0x002E7534 File Offset: 0x002E5734
		public static RoguePokemon GetRootAsRoguePokemon(ByteBuffer _bb, RoguePokemon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C01A RID: 49178 RVA: 0x002E7551 File Offset: 0x002E5751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C01B RID: 49179 RVA: 0x002E7560 File Offset: 0x002E5760
		public RoguePokemon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x0600C01C RID: 49180 RVA: 0x002E7570 File Offset: 0x002E5770
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

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x0600C01D RID: 49181 RVA: 0x002E75AC File Offset: 0x002E57AC
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

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x0600C01E RID: 49182 RVA: 0x002E75E8 File Offset: 0x002E57E8
		public int UnlockInst
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

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x0600C01F RID: 49183 RVA: 0x002E7624 File Offset: 0x002E5824
		public string UnlockTips
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

		// Token: 0x0600C020 RID: 49184 RVA: 0x002E765C File Offset: 0x002E585C
		public Span<byte> GetUnlockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C021 RID: 49185 RVA: 0x002E766C File Offset: 0x002E586C
		public byte[] GetUnlockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x0600C022 RID: 49186 RVA: 0x002E7684 File Offset: 0x002E5884
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x0600C023 RID: 49187 RVA: 0x002E76C4 File Offset: 0x002E58C4
		public string PokemonIcon
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

		// Token: 0x0600C024 RID: 49188 RVA: 0x002E76FC File Offset: 0x002E58FC
		public Span<byte> GetPokemonIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C025 RID: 49189 RVA: 0x002E770C File Offset: 0x002E590C
		public byte[] GetPokemonIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x0600C026 RID: 49190 RVA: 0x002E7724 File Offset: 0x002E5924
		public string PokemonName
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

		// Token: 0x0600C027 RID: 49191 RVA: 0x002E775C File Offset: 0x002E595C
		public Span<byte> GetPokemonNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C028 RID: 49192 RVA: 0x002E776C File Offset: 0x002E596C
		public byte[] GetPokemonNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x0600C029 RID: 49193 RVA: 0x002E7784 File Offset: 0x002E5984
		public string PokemonSettleIcon
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

		// Token: 0x0600C02A RID: 49194 RVA: 0x002E77BC File Offset: 0x002E59BC
		public Span<byte> GetPokemonSettleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C02B RID: 49195 RVA: 0x002E77CC File Offset: 0x002E59CC
		public byte[] GetPokemonSettleIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x0600C02C RID: 49196 RVA: 0x002E77E4 File Offset: 0x002E59E4
		public string PokemonSkillDesc
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

		// Token: 0x0600C02D RID: 49197 RVA: 0x002E781C File Offset: 0x002E5A1C
		public Span<byte> GetPokemonSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C02E RID: 49198 RVA: 0x002E782C File Offset: 0x002E5A2C
		public byte[] GetPokemonSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x040050CA RID: 20682
		private Table __p;
	}
}
