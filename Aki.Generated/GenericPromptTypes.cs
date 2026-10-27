using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF4 RID: 3316
	public struct GenericPromptTypes : IFlatbufferObject
	{
		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x060079DF RID: 31199 RVA: 0x00249DA9 File Offset: 0x00247FA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060079E0 RID: 31200 RVA: 0x00249DB6 File Offset: 0x00247FB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x00249DC0 File Offset: 0x00247FC0
		public static GenericPromptTypes GetRootAsGenericPromptTypes(ByteBuffer _bb)
		{
			return GenericPromptTypes.GetRootAsGenericPromptTypes(_bb, default(GenericPromptTypes));
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x00249DDC File Offset: 0x00247FDC
		public static GenericPromptTypes GetRootAsGenericPromptTypes(ByteBuffer _bb, GenericPromptTypes obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060079E3 RID: 31203 RVA: 0x00249DF9 File Offset: 0x00247FF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060079E4 RID: 31204 RVA: 0x00249E08 File Offset: 0x00248008
		public GenericPromptTypes __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x060079E5 RID: 31205 RVA: 0x00249E18 File Offset: 0x00248018
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

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x060079E6 RID: 31206 RVA: 0x00249E54 File Offset: 0x00248054
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

		// Token: 0x060079E7 RID: 31207 RVA: 0x00249E8B File Offset: 0x0024808B
		public Span<byte> GetGeneralTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x00249E9A File Offset: 0x0024809A
		public byte[] GetGeneralTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x060079E9 RID: 31209 RVA: 0x00249EB4 File Offset: 0x002480B4
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

		// Token: 0x060079EA RID: 31210 RVA: 0x00249EEB File Offset: 0x002480EB
		public Span<byte> GetGeneralExtraTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x00249EFA File Offset: 0x002480FA
		public byte[] GetGeneralExtraTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x060079EC RID: 31212 RVA: 0x00249F14 File Offset: 0x00248114
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

		// Token: 0x060079ED RID: 31213 RVA: 0x00249F4C File Offset: 0x0024814C
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x00249F5C File Offset: 0x0024815C
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x060079EF RID: 31215 RVA: 0x00249F74 File Offset: 0x00248174
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

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x060079F0 RID: 31216 RVA: 0x00249FB4 File Offset: 0x002481B4
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

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x060079F1 RID: 31217 RVA: 0x00249FF4 File Offset: 0x002481F4
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

		// Token: 0x060079F2 RID: 31218 RVA: 0x0024A02C File Offset: 0x0024822C
		public Span<byte> GetShowAreaBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x0024A03C File Offset: 0x0024823C
		public byte[] GetShowAreaArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x060079F4 RID: 31220 RVA: 0x0024A054 File Offset: 0x00248254
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

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x060079F5 RID: 31221 RVA: 0x0024A094 File Offset: 0x00248294
		public bool OnlyBattle
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x060079F6 RID: 31222 RVA: 0x0024A0D4 File Offset: 0x002482D4
		public bool Tickable
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x060079F7 RID: 31223 RVA: 0x0024A114 File Offset: 0x00248314
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

		// Token: 0x060079F8 RID: 31224 RVA: 0x0024A14C File Offset: 0x0024834C
		public Span<byte> GetUiPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x0024A15C File Offset: 0x0024835C
		public byte[] GetUiPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x060079FA RID: 31226 RVA: 0x0024A174 File Offset: 0x00248374
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

		// Token: 0x04004D67 RID: 19815
		private Table __p;
	}
}
