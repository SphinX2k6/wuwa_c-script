using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B91 RID: 2961
	public struct Achievement : IFlatbufferObject
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600474C RID: 18252 RVA: 0x001E8C80 File Offset: 0x001E6E80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x001E8C8D File Offset: 0x001E6E8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x001E8C94 File Offset: 0x001E6E94
		public static Achievement GetRootAsAchievement(ByteBuffer _bb)
		{
			return Achievement.GetRootAsAchievement(_bb, default(Achievement));
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x001E8CB0 File Offset: 0x001E6EB0
		public static Achievement GetRootAsAchievement(ByteBuffer _bb, Achievement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x001E8CCD File Offset: 0x001E6ECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x001E8CDC File Offset: 0x001E6EDC
		public Achievement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x001E8CEC File Offset: 0x001E6EEC
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
		// (get) Token: 0x06004753 RID: 18259 RVA: 0x001E8D28 File Offset: 0x001E6F28
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
		// (get) Token: 0x06004754 RID: 18260 RVA: 0x001E8D64 File Offset: 0x001E6F64
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
		// (get) Token: 0x06004755 RID: 18261 RVA: 0x001E8DA0 File Offset: 0x001E6FA0
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

		// Token: 0x06004756 RID: 18262 RVA: 0x001E8DD8 File Offset: 0x001E6FD8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x001E8DE8 File Offset: 0x001E6FE8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x001E8E00 File Offset: 0x001E7000
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

		// Token: 0x06004759 RID: 18265 RVA: 0x001E8E38 File Offset: 0x001E7038
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x001E8E48 File Offset: 0x001E7048
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600475B RID: 18267 RVA: 0x001E8E60 File Offset: 0x001E7060
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

		// Token: 0x0600475C RID: 18268 RVA: 0x001E8E98 File Offset: 0x001E7098
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600475D RID: 18269 RVA: 0x001E8EA8 File Offset: 0x001E70A8
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600475E RID: 18270 RVA: 0x001E8EC0 File Offset: 0x001E70C0
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
		// (get) Token: 0x0600475F RID: 18271 RVA: 0x001E8F00 File Offset: 0x001E7100
		public bool Hidden
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06004760 RID: 18272 RVA: 0x001E8F40 File Offset: 0x001E7140
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
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x001E8F80 File Offset: 0x001E7180
		public bool ClientTrigger
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06004762 RID: 18274 RVA: 0x001E8FC0 File Offset: 0x001E71C0
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
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x001E9000 File Offset: 0x001E7200
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

		// Token: 0x06004764 RID: 18276 RVA: 0x001E9038 File Offset: 0x001E7238
		public Span<byte> GetExternalTrophyIdBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x001E9048 File Offset: 0x001E7248
		public byte[] GetExternalTrophyIdArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06004766 RID: 18278 RVA: 0x001E9060 File Offset: 0x001E7260
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

		// Token: 0x06004767 RID: 18279 RVA: 0x001E9098 File Offset: 0x001E7298
		public Span<byte> GetGPExternalTrophyIdBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x001E90A8 File Offset: 0x001E72A8
		public byte[] GetGPExternalTrophyIdArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06004769 RID: 18281 RVA: 0x001E90C0 File Offset: 0x001E72C0
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

		// Token: 0x0600476A RID: 18282 RVA: 0x001E90F8 File Offset: 0x001E72F8
		public Span<byte> GetXSXExternalTrophyIdBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x001E9108 File Offset: 0x001E7308
		public byte[] GetXSXExternalTrophyIdArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x04005069 RID: 20585
		private Table __p;
	}
}
