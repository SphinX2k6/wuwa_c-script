using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ABC RID: 2748
	public struct Achievement : IFlatbufferObject
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600424E RID: 16974 RVA: 0x001C9A3C File Offset: 0x001C7C3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x001C9A49 File Offset: 0x001C7C49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x001C9A50 File Offset: 0x001C7C50
		public static Achievement GetRootAsAchievement(ByteBuffer _bb)
		{
			return Achievement.GetRootAsAchievement(_bb, default(Achievement));
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x001C9A6C File Offset: 0x001C7C6C
		public static Achievement GetRootAsAchievement(ByteBuffer _bb, Achievement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x001C9A89 File Offset: 0x001C7C89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x001C9A98 File Offset: 0x001C7C98
		public Achievement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06004254 RID: 16980 RVA: 0x001C9AA8 File Offset: 0x001C7CA8
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06004255 RID: 16981 RVA: 0x001C9AE4 File Offset: 0x001C7CE4
		public int GroupId
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06004256 RID: 16982 RVA: 0x001C9B20 File Offset: 0x001C7D20
		public int Level
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06004257 RID: 16983 RVA: 0x001C9B5C File Offset: 0x001C7D5C
		public string Name
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

		// Token: 0x06004258 RID: 16984 RVA: 0x001C9B94 File Offset: 0x001C7D94
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x001C9BA4 File Offset: 0x001C7DA4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600425A RID: 16986 RVA: 0x001C9BBC File Offset: 0x001C7DBC
		public string Desc
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

		// Token: 0x0600425B RID: 16987 RVA: 0x001C9BF4 File Offset: 0x001C7DF4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x001C9C04 File Offset: 0x001C7E04
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600425D RID: 16989 RVA: 0x001C9C1C File Offset: 0x001C7E1C
		public string IconPath
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

		// Token: 0x0600425E RID: 16990 RVA: 0x001C9C54 File Offset: 0x001C7E54
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x001C9C64 File Offset: 0x001C7E64
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06004260 RID: 16992 RVA: 0x001C9C7C File Offset: 0x001C7E7C
		public int OverrideDropId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06004261 RID: 16993 RVA: 0x001C9CBC File Offset: 0x001C7EBC
		public bool Hidden
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06004262 RID: 16994 RVA: 0x001C9CFC File Offset: 0x001C7EFC
		public int NextLink
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06004263 RID: 16995 RVA: 0x001C9D3C File Offset: 0x001C7F3C
		public bool ClientTrigger
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06004264 RID: 16996 RVA: 0x001C9D7C File Offset: 0x001C7F7C
		public int ThirdPartyTrophyId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06004265 RID: 16997 RVA: 0x001C9DBC File Offset: 0x001C7FBC
		public string ExternalTrophyId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x001C9DF4 File Offset: 0x001C7FF4
		public Span<byte> GetExternalTrophyIdBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x001C9E04 File Offset: 0x001C8004
		public byte[] GetExternalTrophyIdArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06004268 RID: 17000 RVA: 0x001C9E1C File Offset: 0x001C801C
		public string GPExternalTrophyId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x001C9E54 File Offset: 0x001C8054
		public Span<byte> GetGPExternalTrophyIdBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x001C9E64 File Offset: 0x001C8064
		public byte[] GetGPExternalTrophyIdArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600426B RID: 17003 RVA: 0x001C9E7C File Offset: 0x001C807C
		public string XSXExternalTrophyId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x001C9EB4 File Offset: 0x001C80B4
		public Span<byte> GetXSXExternalTrophyIdBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x001C9EC4 File Offset: 0x001C80C4
		public byte[] GetXSXExternalTrophyIdArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x04004A96 RID: 19094
		private Table __p;
	}
}
