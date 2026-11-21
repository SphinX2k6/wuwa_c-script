using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200102A RID: 4138
	public struct PlayerHeadRe : IFlatbufferObject
	{
		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x0600B787 RID: 46983 RVA: 0x002E3E45 File Offset: 0x002E2045
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B788 RID: 46984 RVA: 0x002E3E52 File Offset: 0x002E2052
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B789 RID: 46985 RVA: 0x002E3E5C File Offset: 0x002E205C
		public static PlayerHeadRe GetRootAsPlayerHeadRe(ByteBuffer _bb)
		{
			return PlayerHeadRe.GetRootAsPlayerHeadRe(_bb, default(PlayerHeadRe));
		}

		// Token: 0x0600B78A RID: 46986 RVA: 0x002E3E78 File Offset: 0x002E2078
		public static PlayerHeadRe GetRootAsPlayerHeadRe(ByteBuffer _bb, PlayerHeadRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x002E3E95 File Offset: 0x002E2095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B78C RID: 46988 RVA: 0x002E3EA4 File Offset: 0x002E20A4
		public PlayerHeadRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x0600B78D RID: 46989 RVA: 0x002E3EB4 File Offset: 0x002E20B4
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

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x0600B78E RID: 46990 RVA: 0x002E3EF0 File Offset: 0x002E20F0
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

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x0600B78F RID: 46991 RVA: 0x002E3F2C File Offset: 0x002E212C
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

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x0600B790 RID: 46992 RVA: 0x002E3F68 File Offset: 0x002E2168
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

		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x0600B791 RID: 46993 RVA: 0x002E3FA8 File Offset: 0x002E21A8
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

		// Token: 0x0600B792 RID: 46994 RVA: 0x002E3FE0 File Offset: 0x002E21E0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x002E3FF0 File Offset: 0x002E21F0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x0600B794 RID: 46996 RVA: 0x002E4008 File Offset: 0x002E2208
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

		// Token: 0x0600B795 RID: 46997 RVA: 0x002E4040 File Offset: 0x002E2240
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B796 RID: 46998 RVA: 0x002E4050 File Offset: 0x002E2250
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x0600B797 RID: 46999 RVA: 0x002E4068 File Offset: 0x002E2268
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

		// Token: 0x0600B798 RID: 47000 RVA: 0x002E40A0 File Offset: 0x002E22A0
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B799 RID: 47001 RVA: 0x002E40B0 File Offset: 0x002E22B0
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x0600B79A RID: 47002 RVA: 0x002E40C8 File Offset: 0x002E22C8
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

		// Token: 0x0600B79B RID: 47003 RVA: 0x002E4100 File Offset: 0x002E2300
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B79C RID: 47004 RVA: 0x002E4110 File Offset: 0x002E2310
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x0600B79D RID: 47005 RVA: 0x002E4128 File Offset: 0x002E2328
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

		// Token: 0x0600B79E RID: 47006 RVA: 0x002E4160 File Offset: 0x002E2360
		public Span<byte> GetRoleHeadIconCircleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B79F RID: 47007 RVA: 0x002E4170 File Offset: 0x002E2370
		public byte[] GetRoleHeadIconCircleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x0600B7A0 RID: 47008 RVA: 0x002E4188 File Offset: 0x002E2388
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

		// Token: 0x0600B7A1 RID: 47009 RVA: 0x002E41C0 File Offset: 0x002E23C0
		public Span<byte> GetRoleHeadIconLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B7A2 RID: 47010 RVA: 0x002E41D0 File Offset: 0x002E23D0
		public byte[] GetRoleHeadIconLargeArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x0600B7A3 RID: 47011 RVA: 0x002E41E8 File Offset: 0x002E23E8
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

		// Token: 0x0600B7A4 RID: 47012 RVA: 0x002E4220 File Offset: 0x002E2420
		public Span<byte> GetRoleHeadIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B7A5 RID: 47013 RVA: 0x002E4230 File Offset: 0x002E2430
		public byte[] GetRoleHeadIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x0600B7A6 RID: 47014 RVA: 0x002E4248 File Offset: 0x002E2448
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

		// Token: 0x0600B7A7 RID: 47015 RVA: 0x002E4280 File Offset: 0x002E2480
		public Span<byte> GetCardBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600B7A8 RID: 47016 RVA: 0x002E4290 File Offset: 0x002E2490
		public byte[] GetCardArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AB1 RID: 10929
		// (get) Token: 0x0600B7A9 RID: 47017 RVA: 0x002E42A8 File Offset: 0x002E24A8
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

		// Token: 0x0600B7AA RID: 47018 RVA: 0x002E42E0 File Offset: 0x002E24E0
		public Span<byte> GetRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B7AB RID: 47019 RVA: 0x002E42F0 File Offset: 0x002E24F0
		public byte[] GetRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AB2 RID: 10930
		// (get) Token: 0x0600B7AC RID: 47020 RVA: 0x002E4308 File Offset: 0x002E2508
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

		// Token: 0x0600B7AD RID: 47021 RVA: 0x002E4348 File Offset: 0x002E2548
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x0600B7AE RID: 47022 RVA: 0x002E4388 File Offset: 0x002E2588
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

		// Token: 0x0600B7AF RID: 47023 RVA: 0x002E43B4 File Offset: 0x002E25B4
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600B7B0 RID: 47024 RVA: 0x002E43C4 File Offset: 0x002E25C4
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x0600B7B1 RID: 47025 RVA: 0x002E43DC File Offset: 0x002E25DC
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

		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x0600B7B2 RID: 47026 RVA: 0x002E441C File Offset: 0x002E261C
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

		// Token: 0x0600B7B3 RID: 47027 RVA: 0x002E4454 File Offset: 0x002E2654
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600B7B4 RID: 47028 RVA: 0x002E4464 File Offset: 0x002E2664
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x0600B7B5 RID: 47029 RVA: 0x002E447C File Offset: 0x002E267C
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

		// Token: 0x0600B7B6 RID: 47030 RVA: 0x002E44B4 File Offset: 0x002E26B4
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600B7B7 RID: 47031 RVA: 0x002E44C4 File Offset: 0x002E26C4
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AB7 RID: 10935
		// (get) Token: 0x0600B7B8 RID: 47032 RVA: 0x002E44DC File Offset: 0x002E26DC
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

		// Token: 0x0600B7B9 RID: 47033 RVA: 0x002E4514 File Offset: 0x002E2714
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600B7BA RID: 47034 RVA: 0x002E4524 File Offset: 0x002E2724
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AB8 RID: 10936
		// (get) Token: 0x0600B7BB RID: 47035 RVA: 0x002E453C File Offset: 0x002E273C
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

		// Token: 0x0600B7BC RID: 47036 RVA: 0x002E4574 File Offset: 0x002E2774
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600B7BD RID: 47037 RVA: 0x002E4584 File Offset: 0x002E2784
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AB9 RID: 10937
		// (get) Token: 0x0600B7BE RID: 47038 RVA: 0x002E459C File Offset: 0x002E279C
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

		// Token: 0x0600B7BF RID: 47039 RVA: 0x002E45D4 File Offset: 0x002E27D4
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600B7C0 RID: 47040 RVA: 0x002E45E4 File Offset: 0x002E27E4
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ABA RID: 10938
		// (get) Token: 0x0600B7C1 RID: 47041 RVA: 0x002E45FC File Offset: 0x002E27FC
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

		// Token: 0x0600B7C2 RID: 47042 RVA: 0x002E4634 File Offset: 0x002E2834
		public Span<byte> GetTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600B7C3 RID: 47043 RVA: 0x002E4644 File Offset: 0x002E2844
		public byte[] GetTipsArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ABB RID: 10939
		// (get) Token: 0x0600B7C4 RID: 47044 RVA: 0x002E465C File Offset: 0x002E285C
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x0600B7C5 RID: 47045 RVA: 0x002E469C File Offset: 0x002E289C
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

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x0600B7C6 RID: 47046 RVA: 0x002E46DC File Offset: 0x002E28DC
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

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x002E4714 File Offset: 0x002E2914
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600B7C8 RID: 47048 RVA: 0x002E4724 File Offset: 0x002E2924
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x0600B7C9 RID: 47049 RVA: 0x002E473C File Offset: 0x002E293C
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

		// Token: 0x0600B7CA RID: 47050 RVA: 0x002E4774 File Offset: 0x002E2974
		public Span<byte> GetSpineDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x002E4784 File Offset: 0x002E2984
		public byte[] GetSpineDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x002E479C File Offset: 0x002E299C
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600B7CD RID: 47053 RVA: 0x002E47A4 File Offset: 0x002E29A4
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			PlayerHeadRe.<ItemAccessIter>d__98 <ItemAccessIter>d__ = new PlayerHeadRe.<ItemAccessIter>d__98(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x040055F7 RID: 22007
		private Table __p;
	}
}
