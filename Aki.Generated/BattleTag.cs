using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B2F RID: 2863
	public struct BattleTag : IFlatbufferObject
	{
		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06004CE4 RID: 19684 RVA: 0x001E2B4D File Offset: 0x001E0D4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x001E2B5A File Offset: 0x001E0D5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x001E2B64 File Offset: 0x001E0D64
		public static BattleTag GetRootAsBattleTag(ByteBuffer _bb)
		{
			return BattleTag.GetRootAsBattleTag(_bb, default(BattleTag));
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x001E2B80 File Offset: 0x001E0D80
		public static BattleTag GetRootAsBattleTag(ByteBuffer _bb, BattleTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004CE8 RID: 19688 RVA: 0x001E2B9D File Offset: 0x001E0D9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x001E2BAC File Offset: 0x001E0DAC
		public BattleTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06004CEA RID: 19690 RVA: 0x001E2BBC File Offset: 0x001E0DBC
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

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06004CEB RID: 19691 RVA: 0x001E2BF8 File Offset: 0x001E0DF8
		public string Desc
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

		// Token: 0x06004CEC RID: 19692 RVA: 0x001E2C2F File Offset: 0x001E0E2F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x001E2C3E File Offset: 0x001E0E3E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06004CEE RID: 19694 RVA: 0x001E2C58 File Offset: 0x001E0E58
		public string AddTag
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

		// Token: 0x06004CEF RID: 19695 RVA: 0x001E2C8F File Offset: 0x001E0E8F
		public Span<byte> GetAddTagBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x001E2C9E File Offset: 0x001E0E9E
		public byte[] GetAddTagArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06004CF1 RID: 19697 RVA: 0x001E2CB8 File Offset: 0x001E0EB8
		public string FinishTag
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

		// Token: 0x06004CF2 RID: 19698 RVA: 0x001E2CF0 File Offset: 0x001E0EF0
		public Span<byte> GetFinishTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x001E2D00 File Offset: 0x001E0F00
		public byte[] GetFinishTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B27 RID: 19239
		private Table __p;
	}
}
