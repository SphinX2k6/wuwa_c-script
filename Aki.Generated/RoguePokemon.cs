using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D1 RID: 4305
	public struct RoguePokemon : IFlatbufferObject
	{
		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x0600C660 RID: 50784 RVA: 0x00303846 File Offset: 0x00301A46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C661 RID: 50785 RVA: 0x00303853 File Offset: 0x00301A53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C662 RID: 50786 RVA: 0x0030385C File Offset: 0x00301A5C
		public static RoguePokemon GetRootAsRoguePokemon(ByteBuffer _bb)
		{
			return RoguePokemon.GetRootAsRoguePokemon(_bb, default(RoguePokemon));
		}

		// Token: 0x0600C663 RID: 50787 RVA: 0x00303878 File Offset: 0x00301A78
		public static RoguePokemon GetRootAsRoguePokemon(ByteBuffer _bb, RoguePokemon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C664 RID: 50788 RVA: 0x00303895 File Offset: 0x00301A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C665 RID: 50789 RVA: 0x003038A4 File Offset: 0x00301AA4
		public RoguePokemon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x0600C666 RID: 50790 RVA: 0x003038B4 File Offset: 0x00301AB4
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

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x0600C667 RID: 50791 RVA: 0x003038F0 File Offset: 0x00301AF0
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

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x0600C668 RID: 50792 RVA: 0x0030392C File Offset: 0x00301B2C
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

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x0600C669 RID: 50793 RVA: 0x00303968 File Offset: 0x00301B68
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

		// Token: 0x0600C66A RID: 50794 RVA: 0x003039A0 File Offset: 0x00301BA0
		public Span<byte> GetUnlockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C66B RID: 50795 RVA: 0x003039B0 File Offset: 0x00301BB0
		public byte[] GetUnlockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x0600C66C RID: 50796 RVA: 0x003039C8 File Offset: 0x00301BC8
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

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x0600C66D RID: 50797 RVA: 0x00303A08 File Offset: 0x00301C08
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

		// Token: 0x0600C66E RID: 50798 RVA: 0x00303A40 File Offset: 0x00301C40
		public Span<byte> GetPokemonIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C66F RID: 50799 RVA: 0x00303A50 File Offset: 0x00301C50
		public byte[] GetPokemonIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x0600C670 RID: 50800 RVA: 0x00303A68 File Offset: 0x00301C68
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

		// Token: 0x0600C671 RID: 50801 RVA: 0x00303AA0 File Offset: 0x00301CA0
		public Span<byte> GetPokemonNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C672 RID: 50802 RVA: 0x00303AB0 File Offset: 0x00301CB0
		public byte[] GetPokemonNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x0600C673 RID: 50803 RVA: 0x00303AC8 File Offset: 0x00301CC8
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

		// Token: 0x0600C674 RID: 50804 RVA: 0x00303B00 File Offset: 0x00301D00
		public Span<byte> GetPokemonSettleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C675 RID: 50805 RVA: 0x00303B10 File Offset: 0x00301D10
		public byte[] GetPokemonSettleIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x0600C676 RID: 50806 RVA: 0x00303B28 File Offset: 0x00301D28
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

		// Token: 0x0600C677 RID: 50807 RVA: 0x00303B60 File Offset: 0x00301D60
		public Span<byte> GetPokemonSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C678 RID: 50808 RVA: 0x00303B70 File Offset: 0x00301D70
		public byte[] GetPokemonSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x040056B2 RID: 22194
		private Table __p;
	}
}
