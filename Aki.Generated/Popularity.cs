using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F50 RID: 3920
	public struct Popularity : IFlatbufferObject
	{
		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x0600B27E RID: 45694 RVA: 0x002C9978 File Offset: 0x002C7B78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B27F RID: 45695 RVA: 0x002C9985 File Offset: 0x002C7B85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B280 RID: 45696 RVA: 0x002C998C File Offset: 0x002C7B8C
		public static Popularity GetRootAsPopularity(ByteBuffer _bb)
		{
			return Popularity.GetRootAsPopularity(_bb, default(Popularity));
		}

		// Token: 0x0600B281 RID: 45697 RVA: 0x002C99A8 File Offset: 0x002C7BA8
		public static Popularity GetRootAsPopularity(ByteBuffer _bb, Popularity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B282 RID: 45698 RVA: 0x002C99C5 File Offset: 0x002C7BC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B283 RID: 45699 RVA: 0x002C99D4 File Offset: 0x002C7BD4
		public Popularity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x0600B284 RID: 45700 RVA: 0x002C99E4 File Offset: 0x002C7BE4
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

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x0600B285 RID: 45701 RVA: 0x002C9A20 File Offset: 0x002C7C20
		public int PopularityValue
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

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x0600B286 RID: 45702 RVA: 0x002C9A5C File Offset: 0x002C7C5C
		public string PopularityRating
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

		// Token: 0x0600B287 RID: 45703 RVA: 0x002C9A93 File Offset: 0x002C7C93
		public Span<byte> GetPopularityRatingBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B288 RID: 45704 RVA: 0x002C9AA2 File Offset: 0x002C7CA2
		public byte[] GetPopularityRatingArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x0600B289 RID: 45705 RVA: 0x002C9ABC File Offset: 0x002C7CBC
		public int NpcCount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x0600B28A RID: 45706 RVA: 0x002C9AFC File Offset: 0x002C7CFC
		public string NpcDialog
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

		// Token: 0x0600B28B RID: 45707 RVA: 0x002C9B34 File Offset: 0x002C7D34
		public Span<byte> GetNpcDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B28C RID: 45708 RVA: 0x002C9B44 File Offset: 0x002C7D44
		public byte[] GetNpcDialogArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x0600B28D RID: 45709 RVA: 0x002C9B5C File Offset: 0x002C7D5C
		public string NpcDialogGirl
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

		// Token: 0x0600B28E RID: 45710 RVA: 0x002C9B94 File Offset: 0x002C7D94
		public Span<byte> GetNpcDialogGirlBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B28F RID: 45711 RVA: 0x002C9BA4 File Offset: 0x002C7DA4
		public byte[] GetNpcDialogGirlArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400501D RID: 20509
		private Table __p;
	}
}
