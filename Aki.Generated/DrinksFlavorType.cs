using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C04 RID: 3076
	public struct DrinksFlavorType : IFlatbufferObject
	{
		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06006414 RID: 25620 RVA: 0x00217A81 File Offset: 0x00215C81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x00217A8E File Offset: 0x00215C8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006416 RID: 25622 RVA: 0x00217A98 File Offset: 0x00215C98
		public static DrinksFlavorType GetRootAsDrinksFlavorType(ByteBuffer _bb)
		{
			return DrinksFlavorType.GetRootAsDrinksFlavorType(_bb, default(DrinksFlavorType));
		}

		// Token: 0x06006417 RID: 25623 RVA: 0x00217AB4 File Offset: 0x00215CB4
		public static DrinksFlavorType GetRootAsDrinksFlavorType(ByteBuffer _bb, DrinksFlavorType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x00217AD1 File Offset: 0x00215CD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x00217AE0 File Offset: 0x00215CE0
		public DrinksFlavorType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x0600641A RID: 25626 RVA: 0x00217AF0 File Offset: 0x00215CF0
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

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x0600641B RID: 25627 RVA: 0x00217B2C File Offset: 0x00215D2C
		public string Icon
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

		// Token: 0x0600641C RID: 25628 RVA: 0x00217B63 File Offset: 0x00215D63
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600641D RID: 25629 RVA: 0x00217B72 File Offset: 0x00215D72
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x0600641E RID: 25630 RVA: 0x00217B8C File Offset: 0x00215D8C
		public string IconRichTxt
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

		// Token: 0x0600641F RID: 25631 RVA: 0x00217BC3 File Offset: 0x00215DC3
		public Span<byte> GetIconRichTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x00217BD2 File Offset: 0x00215DD2
		public byte[] GetIconRichTxtArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C3A RID: 19514
		private Table __p;
	}
}
