using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF3 RID: 3315
	public struct GenericPrompt : IFlatbufferObject
	{
		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x060079CD RID: 31181 RVA: 0x00249B61 File Offset: 0x00247D61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x00249B6E File Offset: 0x00247D6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060079CF RID: 31183 RVA: 0x00249B78 File Offset: 0x00247D78
		public static GenericPrompt GetRootAsGenericPrompt(ByteBuffer _bb)
		{
			return GenericPrompt.GetRootAsGenericPrompt(_bb, default(GenericPrompt));
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x00249B94 File Offset: 0x00247D94
		public static GenericPrompt GetRootAsGenericPrompt(ByteBuffer _bb, GenericPrompt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060079D1 RID: 31185 RVA: 0x00249BB1 File Offset: 0x00247DB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x00249BC0 File Offset: 0x00247DC0
		public GenericPrompt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x060079D3 RID: 31187 RVA: 0x00249BD0 File Offset: 0x00247DD0
		public string TipsId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x00249C07 File Offset: 0x00247E07
		public Span<byte> GetTipsIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x00249C16 File Offset: 0x00247E16
		public byte[] GetTipsIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x060079D6 RID: 31190 RVA: 0x00249C30 File Offset: 0x00247E30
		public int TypeId
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

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x060079D7 RID: 31191 RVA: 0x00249C6C File Offset: 0x00247E6C
		public string TipsText
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

		// Token: 0x060079D8 RID: 31192 RVA: 0x00249CA3 File Offset: 0x00247EA3
		public Span<byte> GetTipsTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060079D9 RID: 31193 RVA: 0x00249CB2 File Offset: 0x00247EB2
		public byte[] GetTipsTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x060079DA RID: 31194 RVA: 0x00249CCC File Offset: 0x00247ECC
		public string ExtraText
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

		// Token: 0x060079DB RID: 31195 RVA: 0x00249D04 File Offset: 0x00247F04
		public Span<byte> GetExtraTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x00249D14 File Offset: 0x00247F14
		public byte[] GetExtraTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x060079DD RID: 31197 RVA: 0x00249D2C File Offset: 0x00247F2C
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

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x060079DE RID: 31198 RVA: 0x00249D6C File Offset: 0x00247F6C
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

		// Token: 0x04004D66 RID: 19814
		private Table __p;
	}
}
