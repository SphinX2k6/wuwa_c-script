using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001039 RID: 4153
	public struct PreheatBonus : IFlatbufferObject
	{
		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x0600B8D4 RID: 47316 RVA: 0x002E6808 File Offset: 0x002E4A08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B8D5 RID: 47317 RVA: 0x002E6815 File Offset: 0x002E4A15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B8D6 RID: 47318 RVA: 0x002E681C File Offset: 0x002E4A1C
		public static PreheatBonus GetRootAsPreheatBonus(ByteBuffer _bb)
		{
			return PreheatBonus.GetRootAsPreheatBonus(_bb, default(PreheatBonus));
		}

		// Token: 0x0600B8D7 RID: 47319 RVA: 0x002E6838 File Offset: 0x002E4A38
		public static PreheatBonus GetRootAsPreheatBonus(ByteBuffer _bb, PreheatBonus obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B8D8 RID: 47320 RVA: 0x002E6855 File Offset: 0x002E4A55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B8D9 RID: 47321 RVA: 0x002E6864 File Offset: 0x002E4A64
		public PreheatBonus __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x0600B8DA RID: 47322 RVA: 0x002E6874 File Offset: 0x002E4A74
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

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x0600B8DB RID: 47323 RVA: 0x002E68B0 File Offset: 0x002E4AB0
		public string Title
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

		// Token: 0x0600B8DC RID: 47324 RVA: 0x002E68E7 File Offset: 0x002E4AE7
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B8DD RID: 47325 RVA: 0x002E68F6 File Offset: 0x002E4AF6
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x0600B8DE RID: 47326 RVA: 0x002E6910 File Offset: 0x002E4B10
		public string Content
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

		// Token: 0x0600B8DF RID: 47327 RVA: 0x002E6947 File Offset: 0x002E4B47
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B8E0 RID: 47328 RVA: 0x002E6956 File Offset: 0x002E4B56
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x0600B8E1 RID: 47329 RVA: 0x002E6970 File Offset: 0x002E4B70
		public int CrestIndex
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

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x0600B8E2 RID: 47330 RVA: 0x002E69B0 File Offset: 0x002E4BB0
		public string MainTex
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

		// Token: 0x0600B8E3 RID: 47331 RVA: 0x002E69E8 File Offset: 0x002E4BE8
		public Span<byte> GetMainTexBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B8E4 RID: 47332 RVA: 0x002E69F8 File Offset: 0x002E4BF8
		public byte[] GetMainTexArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x0600B8E5 RID: 47333 RVA: 0x002E6A10 File Offset: 0x002E4C10
		public string Photo
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

		// Token: 0x0600B8E6 RID: 47334 RVA: 0x002E6A48 File Offset: 0x002E4C48
		public Span<byte> GetPhotoBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B8E7 RID: 47335 RVA: 0x002E6A58 File Offset: 0x002E4C58
		public byte[] GetPhotoArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x0600B8E8 RID: 47336 RVA: 0x002E6A70 File Offset: 0x002E4C70
		public string SharePhoto
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

		// Token: 0x0600B8E9 RID: 47337 RVA: 0x002E6AA8 File Offset: 0x002E4CA8
		public Span<byte> GetSharePhotoBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B8EA RID: 47338 RVA: 0x002E6AB8 File Offset: 0x002E4CB8
		public byte[] GetSharePhotoArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x0600B8EB RID: 47339 RVA: 0x002E6AD0 File Offset: 0x002E4CD0
		public string NpcIconPath
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

		// Token: 0x0600B8EC RID: 47340 RVA: 0x002E6B08 File Offset: 0x002E4D08
		public Span<byte> GetNpcIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B8ED RID: 47341 RVA: 0x002E6B18 File Offset: 0x002E4D18
		public byte[] GetNpcIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x0600B8EE RID: 47342 RVA: 0x002E6B30 File Offset: 0x002E4D30
		public string NpcContent
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

		// Token: 0x0600B8EF RID: 47343 RVA: 0x002E6B68 File Offset: 0x002E4D68
		public Span<byte> GetNpcContentBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B8F0 RID: 47344 RVA: 0x002E6B78 File Offset: 0x002E4D78
		public byte[] GetNpcContentArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x0600B8F1 RID: 47345 RVA: 0x002E6B90 File Offset: 0x002E4D90
		public string BonusTxt
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B8F2 RID: 47346 RVA: 0x002E6BC8 File Offset: 0x002E4DC8
		public Span<byte> GetBonusTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B8F3 RID: 47347 RVA: 0x002E6BD8 File Offset: 0x002E4DD8
		public byte[] GetBonusTxtArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005606 RID: 22022
		private Table __p;
	}
}
