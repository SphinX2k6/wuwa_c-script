using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA3 RID: 2979
	public struct CoopRole : IFlatbufferObject
	{
		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060059A2 RID: 22946 RVA: 0x00200365 File Offset: 0x001FE565
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x00200372 File Offset: 0x001FE572
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060059A4 RID: 22948 RVA: 0x0020037C File Offset: 0x001FE57C
		public static CoopRole GetRootAsCoopRole(ByteBuffer _bb)
		{
			return CoopRole.GetRootAsCoopRole(_bb, default(CoopRole));
		}

		// Token: 0x060059A5 RID: 22949 RVA: 0x00200398 File Offset: 0x001FE598
		public static CoopRole GetRootAsCoopRole(ByteBuffer _bb, CoopRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060059A6 RID: 22950 RVA: 0x002003B5 File Offset: 0x001FE5B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x002003C4 File Offset: 0x001FE5C4
		public CoopRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060059A8 RID: 22952 RVA: 0x002003D4 File Offset: 0x001FE5D4
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

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060059A9 RID: 22953 RVA: 0x00200410 File Offset: 0x001FE610
		public string RoleName
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

		// Token: 0x060059AA RID: 22954 RVA: 0x00200447 File Offset: 0x001FE647
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x00200456 File Offset: 0x001FE656
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060059AC RID: 22956 RVA: 0x00200470 File Offset: 0x001FE670
		public string RoleInfo
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

		// Token: 0x060059AD RID: 22957 RVA: 0x002004A7 File Offset: 0x001FE6A7
		public Span<byte> GetRoleInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x002004B6 File Offset: 0x001FE6B6
		public byte[] GetRoleInfoArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060059AF RID: 22959 RVA: 0x002004D0 File Offset: 0x001FE6D0
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060059B0 RID: 22960 RVA: 0x00200510 File Offset: 0x001FE710
		public int UnlockQuestId
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

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060059B1 RID: 22961 RVA: 0x00200550 File Offset: 0x001FE750
		public string LevelUpRolePortrait
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

		// Token: 0x060059B2 RID: 22962 RVA: 0x00200588 File Offset: 0x001FE788
		public Span<byte> GetLevelUpRolePortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x00200598 File Offset: 0x001FE798
		public byte[] GetLevelUpRolePortraitArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060059B4 RID: 22964 RVA: 0x002005B0 File Offset: 0x001FE7B0
		public string RolePortrait
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

		// Token: 0x060059B5 RID: 22965 RVA: 0x002005E8 File Offset: 0x001FE7E8
		public Span<byte> GetRolePortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x002005F8 File Offset: 0x001FE7F8
		public byte[] GetRolePortraitArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060059B7 RID: 22967 RVA: 0x00200610 File Offset: 0x001FE810
		public string RoleBG
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

		// Token: 0x060059B8 RID: 22968 RVA: 0x00200648 File Offset: 0x001FE848
		public Span<byte> GetRoleBGBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x00200658 File Offset: 0x001FE858
		public byte[] GetRoleBGArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060059BA RID: 22970 RVA: 0x00200670 File Offset: 0x001FE870
		public string RoleHeadIcon
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

		// Token: 0x060059BB RID: 22971 RVA: 0x002006A8 File Offset: 0x001FE8A8
		public Span<byte> GetRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x002006B8 File Offset: 0x001FE8B8
		public byte[] GetRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060059BD RID: 22973 RVA: 0x002006D0 File Offset: 0x001FE8D0
		public string PhotoPath
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

		// Token: 0x060059BE RID: 22974 RVA: 0x00200708 File Offset: 0x001FE908
		public Span<byte> GetPhotoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x00200718 File Offset: 0x001FE918
		public byte[] GetPhotoPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060059C0 RID: 22976 RVA: 0x00200730 File Offset: 0x001FE930
		public string BigPhotoPathM
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

		// Token: 0x060059C1 RID: 22977 RVA: 0x00200768 File Offset: 0x001FE968
		public Span<byte> GetBigPhotoPathMBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x00200778 File Offset: 0x001FE978
		public byte[] GetBigPhotoPathMArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x060059C3 RID: 22979 RVA: 0x00200790 File Offset: 0x001FE990
		public string BigPhotoPathF
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

		// Token: 0x060059C4 RID: 22980 RVA: 0x002007C8 File Offset: 0x001FE9C8
		public Span<byte> GetBigPhotoPathFBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x002007D8 File Offset: 0x001FE9D8
		public byte[] GetBigPhotoPathFArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060059C6 RID: 22982 RVA: 0x002007F0 File Offset: 0x001FE9F0
		public string SmallPhotoPathM
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

		// Token: 0x060059C7 RID: 22983 RVA: 0x00200828 File Offset: 0x001FEA28
		public Span<byte> GetSmallPhotoPathMBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x00200838 File Offset: 0x001FEA38
		public byte[] GetSmallPhotoPathMArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060059C9 RID: 22985 RVA: 0x00200850 File Offset: 0x001FEA50
		public string SmallPhotoPathF
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

		// Token: 0x060059CA RID: 22986 RVA: 0x00200888 File Offset: 0x001FEA88
		public Span<byte> GetSmallPhotoPathFBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060059CB RID: 22987 RVA: 0x00200898 File Offset: 0x001FEA98
		public byte[] GetSmallPhotoPathFArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BC6 RID: 19398
		private Table __p;
	}
}
