using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD8 RID: 3544
	public struct GenericPrompt : IFlatbufferObject
	{
		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06007FE5 RID: 32741 RVA: 0x00268731 File Offset: 0x00266931
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007FE6 RID: 32742 RVA: 0x0026873E File Offset: 0x0026693E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007FE7 RID: 32743 RVA: 0x00268748 File Offset: 0x00266948
		public static GenericPrompt GetRootAsGenericPrompt(ByteBuffer _bb)
		{
			return GenericPrompt.GetRootAsGenericPrompt(_bb, default(GenericPrompt));
		}

		// Token: 0x06007FE8 RID: 32744 RVA: 0x00268764 File Offset: 0x00266964
		public static GenericPrompt GetRootAsGenericPrompt(ByteBuffer _bb, GenericPrompt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007FE9 RID: 32745 RVA: 0x00268781 File Offset: 0x00266981
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007FEA RID: 32746 RVA: 0x00268790 File Offset: 0x00266990
		public GenericPrompt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06007FEB RID: 32747 RVA: 0x002687A0 File Offset: 0x002669A0
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

		// Token: 0x06007FEC RID: 32748 RVA: 0x002687D7 File Offset: 0x002669D7
		public Span<byte> GetTipsIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007FED RID: 32749 RVA: 0x002687E6 File Offset: 0x002669E6
		public byte[] GetTipsIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06007FEE RID: 32750 RVA: 0x00268800 File Offset: 0x00266A00
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

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06007FEF RID: 32751 RVA: 0x0026883C File Offset: 0x00266A3C
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

		// Token: 0x06007FF0 RID: 32752 RVA: 0x00268873 File Offset: 0x00266A73
		public Span<byte> GetTipsTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007FF1 RID: 32753 RVA: 0x00268882 File Offset: 0x00266A82
		public byte[] GetTipsTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06007FF2 RID: 32754 RVA: 0x0026889C File Offset: 0x00266A9C
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

		// Token: 0x06007FF3 RID: 32755 RVA: 0x002688D4 File Offset: 0x00266AD4
		public Span<byte> GetExtraTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007FF4 RID: 32756 RVA: 0x002688E4 File Offset: 0x00266AE4
		public byte[] GetExtraTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06007FF5 RID: 32757 RVA: 0x002688FC File Offset: 0x00266AFC
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

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06007FF6 RID: 32758 RVA: 0x0026893C File Offset: 0x00266B3C
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

		// Token: 0x0400534B RID: 21323
		private Table __p;
	}
}
