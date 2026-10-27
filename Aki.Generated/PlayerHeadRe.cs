using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F45 RID: 3909
	public struct PlayerHeadRe : IFlatbufferObject
	{
		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x0600B166 RID: 45414 RVA: 0x002C75C1 File Offset: 0x002C57C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B167 RID: 45415 RVA: 0x002C75CE File Offset: 0x002C57CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B168 RID: 45416 RVA: 0x002C75D8 File Offset: 0x002C57D8
		public static PlayerHeadRe GetRootAsPlayerHeadRe(ByteBuffer _bb)
		{
			return PlayerHeadRe.GetRootAsPlayerHeadRe(_bb, default(PlayerHeadRe));
		}

		// Token: 0x0600B169 RID: 45417 RVA: 0x002C75F4 File Offset: 0x002C57F4
		public static PlayerHeadRe GetRootAsPlayerHeadRe(ByteBuffer _bb, PlayerHeadRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B16A RID: 45418 RVA: 0x002C7611 File Offset: 0x002C5811
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B16B RID: 45419 RVA: 0x002C7620 File Offset: 0x002C5820
		public PlayerHeadRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x0600B16C RID: 45420 RVA: 0x002C7630 File Offset: 0x002C5830
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

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x0600B16D RID: 45421 RVA: 0x002C766C File Offset: 0x002C586C
		public int RoleSkinId
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

		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x0600B16E RID: 45422 RVA: 0x002C76A8 File Offset: 0x002C58A8
		public int GroupId
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

		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x0600B16F RID: 45423 RVA: 0x002C76E4 File Offset: 0x002C58E4
		public int Gender
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x0600B170 RID: 45424 RVA: 0x002C7724 File Offset: 0x002C5924
		public string Name
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

		// Token: 0x0600B171 RID: 45425 RVA: 0x002C775C File Offset: 0x002C595C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B172 RID: 45426 RVA: 0x002C776C File Offset: 0x002C596C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x0600B173 RID: 45427 RVA: 0x002C7784 File Offset: 0x002C5984
		public string Icon
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

		// Token: 0x0600B174 RID: 45428 RVA: 0x002C77BC File Offset: 0x002C59BC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B175 RID: 45429 RVA: 0x002C77CC File Offset: 0x002C59CC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x0600B176 RID: 45430 RVA: 0x002C77E4 File Offset: 0x002C59E4
		public string IconMiddle
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

		// Token: 0x0600B177 RID: 45431 RVA: 0x002C781C File Offset: 0x002C5A1C
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B178 RID: 45432 RVA: 0x002C782C File Offset: 0x002C5A2C
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x0600B179 RID: 45433 RVA: 0x002C7844 File Offset: 0x002C5A44
		public string IconSmall
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

		// Token: 0x0600B17A RID: 45434 RVA: 0x002C787C File Offset: 0x002C5A7C
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B17B RID: 45435 RVA: 0x002C788C File Offset: 0x002C5A8C
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x0600B17C RID: 45436 RVA: 0x002C78A4 File Offset: 0x002C5AA4
		public string RoleHeadIconCircle
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

		// Token: 0x0600B17D RID: 45437 RVA: 0x002C78DC File Offset: 0x002C5ADC
		public Span<byte> GetRoleHeadIconCircleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B17E RID: 45438 RVA: 0x002C78EC File Offset: 0x002C5AEC
		public byte[] GetRoleHeadIconCircleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x0600B17F RID: 45439 RVA: 0x002C7904 File Offset: 0x002C5B04
		public string RoleHeadIconLarge
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

		// Token: 0x0600B180 RID: 45440 RVA: 0x002C793C File Offset: 0x002C5B3C
		public Span<byte> GetRoleHeadIconLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B181 RID: 45441 RVA: 0x002C794C File Offset: 0x002C5B4C
		public byte[] GetRoleHeadIconLargeArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A49 RID: 10825
		// (get) Token: 0x0600B182 RID: 45442 RVA: 0x002C7964 File Offset: 0x002C5B64
		public string RoleHeadIconBig
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

		// Token: 0x0600B183 RID: 45443 RVA: 0x002C799C File Offset: 0x002C5B9C
		public Span<byte> GetRoleHeadIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B184 RID: 45444 RVA: 0x002C79AC File Offset: 0x002C5BAC
		public byte[] GetRoleHeadIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A4A RID: 10826
		// (get) Token: 0x0600B185 RID: 45445 RVA: 0x002C79C4 File Offset: 0x002C5BC4
		public string Card
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

		// Token: 0x0600B186 RID: 45446 RVA: 0x002C79FC File Offset: 0x002C5BFC
		public Span<byte> GetCardBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600B187 RID: 45447 RVA: 0x002C7A0C File Offset: 0x002C5C0C
		public byte[] GetCardArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A4B RID: 10827
		// (get) Token: 0x0600B188 RID: 45448 RVA: 0x002C7A24 File Offset: 0x002C5C24
		public string RoleHeadIcon
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

		// Token: 0x0600B189 RID: 45449 RVA: 0x002C7A5C File Offset: 0x002C5C5C
		public Span<byte> GetRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B18A RID: 45450 RVA: 0x002C7A6C File Offset: 0x002C5C6C
		public byte[] GetRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x0600B18B RID: 45451 RVA: 0x002C7A84 File Offset: 0x002C5C84
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B18C RID: 45452 RVA: 0x002C7AC4 File Offset: 0x002C5CC4
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x0600B18D RID: 45453 RVA: 0x002C7B04 File Offset: 0x002C5D04
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B18E RID: 45454 RVA: 0x002C7B30 File Offset: 0x002C5D30
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600B18F RID: 45455 RVA: 0x002C7B40 File Offset: 0x002C5D40
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x0600B190 RID: 45456 RVA: 0x002C7B58 File Offset: 0x002C5D58
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x0600B191 RID: 45457 RVA: 0x002C7B98 File Offset: 0x002C5D98
		public string Title
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B192 RID: 45458 RVA: 0x002C7BD0 File Offset: 0x002C5DD0
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600B193 RID: 45459 RVA: 0x002C7BE0 File Offset: 0x002C5DE0
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x0600B194 RID: 45460 RVA: 0x002C7BF8 File Offset: 0x002C5DF8
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B195 RID: 45461 RVA: 0x002C7C30 File Offset: 0x002C5E30
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600B196 RID: 45462 RVA: 0x002C7C40 File Offset: 0x002C5E40
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x0600B197 RID: 45463 RVA: 0x002C7C58 File Offset: 0x002C5E58
		public string ObtainedShowDescription
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B198 RID: 45464 RVA: 0x002C7C90 File Offset: 0x002C5E90
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600B199 RID: 45465 RVA: 0x002C7CA0 File Offset: 0x002C5EA0
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x0600B19A RID: 45466 RVA: 0x002C7CB8 File Offset: 0x002C5EB8
		public string TypeDescription
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B19B RID: 45467 RVA: 0x002C7CF0 File Offset: 0x002C5EF0
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600B19C RID: 45468 RVA: 0x002C7D00 File Offset: 0x002C5F00
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x0600B19D RID: 45469 RVA: 0x002C7D18 File Offset: 0x002C5F18
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B19E RID: 45470 RVA: 0x002C7D50 File Offset: 0x002C5F50
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600B19F RID: 45471 RVA: 0x002C7D60 File Offset: 0x002C5F60
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x0600B1A0 RID: 45472 RVA: 0x002C7D78 File Offset: 0x002C5F78
		public string Tips
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B1A1 RID: 45473 RVA: 0x002C7DB0 File Offset: 0x002C5FB0
		public Span<byte> GetTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600B1A2 RID: 45474 RVA: 0x002C7DC0 File Offset: 0x002C5FC0
		public byte[] GetTipsArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x0600B1A3 RID: 45475 RVA: 0x002C7DD8 File Offset: 0x002C5FD8
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x0600B1A4 RID: 45476 RVA: 0x002C7E18 File Offset: 0x002C6018
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x0600B1A5 RID: 45477 RVA: 0x002C7E58 File Offset: 0x002C6058
		public string SpineAtlasPath
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B1A6 RID: 45478 RVA: 0x002C7E90 File Offset: 0x002C6090
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600B1A7 RID: 45479 RVA: 0x002C7EA0 File Offset: 0x002C60A0
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x0600B1A8 RID: 45480 RVA: 0x002C7EB8 File Offset: 0x002C60B8
		public string SpineDataPath
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B1A9 RID: 45481 RVA: 0x002C7EF0 File Offset: 0x002C60F0
		public Span<byte> GetSpineDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600B1AA RID: 45482 RVA: 0x002C7F00 File Offset: 0x002C6100
		public byte[] GetSpineDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B1AB RID: 45483 RVA: 0x002C7F18 File Offset: 0x002C6118
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			PlayerHeadRe playerHeadRe = this;
			return playerHeadRe.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B1AC RID: 45484 RVA: 0x002C7F3C File Offset: 0x002C613C
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			PlayerHeadRe.<ItemAccessIter>d__98 <ItemAccessIter>d__ = new PlayerHeadRe.<ItemAccessIter>d__98(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x04005012 RID: 20498
		private Table __p;
	}
}
