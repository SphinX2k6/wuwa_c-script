using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD9 RID: 3545
	public struct GenericPromptTypes : IFlatbufferObject
	{
		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06007FF7 RID: 32759 RVA: 0x00268979 File Offset: 0x00266B79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007FF8 RID: 32760 RVA: 0x00268986 File Offset: 0x00266B86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007FF9 RID: 32761 RVA: 0x00268990 File Offset: 0x00266B90
		public static GenericPromptTypes GetRootAsGenericPromptTypes(ByteBuffer _bb)
		{
			return GenericPromptTypes.GetRootAsGenericPromptTypes(_bb, default(GenericPromptTypes));
		}

		// Token: 0x06007FFA RID: 32762 RVA: 0x002689AC File Offset: 0x00266BAC
		public static GenericPromptTypes GetRootAsGenericPromptTypes(ByteBuffer _bb, GenericPromptTypes obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007FFB RID: 32763 RVA: 0x002689C9 File Offset: 0x00266BC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007FFC RID: 32764 RVA: 0x002689D8 File Offset: 0x00266BD8
		public GenericPromptTypes __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06007FFD RID: 32765 RVA: 0x002689E8 File Offset: 0x00266BE8
		public int TypeId
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

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06007FFE RID: 32766 RVA: 0x00268A24 File Offset: 0x00266C24
		public string GeneralText
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

		// Token: 0x06007FFF RID: 32767 RVA: 0x00268A5B File Offset: 0x00266C5B
		public Span<byte> GetGeneralTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008000 RID: 32768 RVA: 0x00268A6A File Offset: 0x00266C6A
		public byte[] GetGeneralTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06008001 RID: 32769 RVA: 0x00268A84 File Offset: 0x00266C84
		public string GeneralExtraText
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

		// Token: 0x06008002 RID: 32770 RVA: 0x00268ABB File Offset: 0x00266CBB
		public Span<byte> GetGeneralExtraTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008003 RID: 32771 RVA: 0x00268ACA File Offset: 0x00266CCA
		public byte[] GetGeneralExtraTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06008004 RID: 32772 RVA: 0x00268AE4 File Offset: 0x00266CE4
		public string TextColor
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

		// Token: 0x06008005 RID: 32773 RVA: 0x00268B1C File Offset: 0x00266D1C
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008006 RID: 32774 RVA: 0x00268B2C File Offset: 0x00266D2C
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06008007 RID: 32775 RVA: 0x00268B44 File Offset: 0x00266D44
		public int Duration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06008008 RID: 32776 RVA: 0x00268B84 File Offset: 0x00266D84
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06008009 RID: 32777 RVA: 0x00268BC4 File Offset: 0x00266DC4
		public string ShowArea
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

		// Token: 0x0600800A RID: 32778 RVA: 0x00268BFC File Offset: 0x00266DFC
		public Span<byte> GetShowAreaBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600800B RID: 32779 RVA: 0x00268C0C File Offset: 0x00266E0C
		public byte[] GetShowAreaArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x0600800C RID: 32780 RVA: 0x00268C24 File Offset: 0x00266E24
		public int MaxCount
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x0600800D RID: 32781 RVA: 0x00268C64 File Offset: 0x00266E64
		public bool OnlyBattle
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x0600800E RID: 32782 RVA: 0x00268CA4 File Offset: 0x00266EA4
		public bool Tickable
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x0600800F RID: 32783 RVA: 0x00268CE4 File Offset: 0x00266EE4
		public string UiPath
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

		// Token: 0x06008010 RID: 32784 RVA: 0x00268D1C File Offset: 0x00266F1C
		public Span<byte> GetUiPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008011 RID: 32785 RVA: 0x00268D2C File Offset: 0x00266F2C
		public byte[] GetUiPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06008012 RID: 32786 RVA: 0x00268D44 File Offset: 0x00266F44
		public float OffsetY
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400534C RID: 21324
		private Table __p;
	}
}
