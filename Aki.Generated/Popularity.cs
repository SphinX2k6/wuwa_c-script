using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001035 RID: 4149
	public struct Popularity : IFlatbufferObject
	{
		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x0600B89F RID: 47263 RVA: 0x002E61C4 File Offset: 0x002E43C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B8A0 RID: 47264 RVA: 0x002E61D1 File Offset: 0x002E43D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B8A1 RID: 47265 RVA: 0x002E61D8 File Offset: 0x002E43D8
		public static Popularity GetRootAsPopularity(ByteBuffer _bb)
		{
			return Popularity.GetRootAsPopularity(_bb, default(Popularity));
		}

		// Token: 0x0600B8A2 RID: 47266 RVA: 0x002E61F4 File Offset: 0x002E43F4
		public static Popularity GetRootAsPopularity(ByteBuffer _bb, Popularity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B8A3 RID: 47267 RVA: 0x002E6211 File Offset: 0x002E4411
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B8A4 RID: 47268 RVA: 0x002E6220 File Offset: 0x002E4420
		public Popularity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x0600B8A5 RID: 47269 RVA: 0x002E6230 File Offset: 0x002E4430
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

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x0600B8A6 RID: 47270 RVA: 0x002E626C File Offset: 0x002E446C
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

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x0600B8A7 RID: 47271 RVA: 0x002E62A8 File Offset: 0x002E44A8
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

		// Token: 0x0600B8A8 RID: 47272 RVA: 0x002E62DF File Offset: 0x002E44DF
		public Span<byte> GetPopularityRatingBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B8A9 RID: 47273 RVA: 0x002E62EE File Offset: 0x002E44EE
		public byte[] GetPopularityRatingArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x0600B8AA RID: 47274 RVA: 0x002E6308 File Offset: 0x002E4508
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

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x0600B8AB RID: 47275 RVA: 0x002E6348 File Offset: 0x002E4548
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

		// Token: 0x0600B8AC RID: 47276 RVA: 0x002E6380 File Offset: 0x002E4580
		public Span<byte> GetNpcDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B8AD RID: 47277 RVA: 0x002E6390 File Offset: 0x002E4590
		public byte[] GetNpcDialogArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x0600B8AE RID: 47278 RVA: 0x002E63A8 File Offset: 0x002E45A8
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

		// Token: 0x0600B8AF RID: 47279 RVA: 0x002E63E0 File Offset: 0x002E45E0
		public Span<byte> GetNpcDialogGirlBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B8B0 RID: 47280 RVA: 0x002E63F0 File Offset: 0x002E45F0
		public byte[] GetNpcDialogGirlArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005602 RID: 22018
		private Table __p;
	}
}
