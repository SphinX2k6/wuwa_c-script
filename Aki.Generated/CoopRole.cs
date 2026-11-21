using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C85 RID: 3205
	public struct CoopRole : IFlatbufferObject
	{
		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06005F7B RID: 24443 RVA: 0x002200C5 File Offset: 0x0021E2C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x002200D2 File Offset: 0x0021E2D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x002200DC File Offset: 0x0021E2DC
		public static CoopRole GetRootAsCoopRole(ByteBuffer _bb)
		{
			return CoopRole.GetRootAsCoopRole(_bb, default(CoopRole));
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x002200F8 File Offset: 0x0021E2F8
		public static CoopRole GetRootAsCoopRole(ByteBuffer _bb, CoopRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x00220115 File Offset: 0x0021E315
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x00220124 File Offset: 0x0021E324
		public CoopRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06005F81 RID: 24449 RVA: 0x00220134 File Offset: 0x0021E334
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

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06005F82 RID: 24450 RVA: 0x00220170 File Offset: 0x0021E370
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

		// Token: 0x06005F83 RID: 24451 RVA: 0x002201A7 File Offset: 0x0021E3A7
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x002201B6 File Offset: 0x0021E3B6
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06005F85 RID: 24453 RVA: 0x002201D0 File Offset: 0x0021E3D0
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

		// Token: 0x06005F86 RID: 24454 RVA: 0x00220207 File Offset: 0x0021E407
		public Span<byte> GetRoleInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x00220216 File Offset: 0x0021E416
		public byte[] GetRoleInfoArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06005F88 RID: 24456 RVA: 0x00220230 File Offset: 0x0021E430
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06005F89 RID: 24457 RVA: 0x00220270 File Offset: 0x0021E470
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

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06005F8A RID: 24458 RVA: 0x002202B0 File Offset: 0x0021E4B0
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

		// Token: 0x06005F8B RID: 24459 RVA: 0x002202E8 File Offset: 0x0021E4E8
		public Span<byte> GetLevelUpRolePortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005F8C RID: 24460 RVA: 0x002202F8 File Offset: 0x0021E4F8
		public byte[] GetLevelUpRolePortraitArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06005F8D RID: 24461 RVA: 0x00220310 File Offset: 0x0021E510
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

		// Token: 0x06005F8E RID: 24462 RVA: 0x00220348 File Offset: 0x0021E548
		public Span<byte> GetRolePortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x00220358 File Offset: 0x0021E558
		public byte[] GetRolePortraitArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06005F90 RID: 24464 RVA: 0x00220370 File Offset: 0x0021E570
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

		// Token: 0x06005F91 RID: 24465 RVA: 0x002203A8 File Offset: 0x0021E5A8
		public Span<byte> GetRoleBGBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005F92 RID: 24466 RVA: 0x002203B8 File Offset: 0x0021E5B8
		public byte[] GetRoleBGArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06005F93 RID: 24467 RVA: 0x002203D0 File Offset: 0x0021E5D0
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

		// Token: 0x06005F94 RID: 24468 RVA: 0x00220408 File Offset: 0x0021E608
		public Span<byte> GetRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x00220418 File Offset: 0x0021E618
		public byte[] GetRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06005F96 RID: 24470 RVA: 0x00220430 File Offset: 0x0021E630
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

		// Token: 0x06005F97 RID: 24471 RVA: 0x00220468 File Offset: 0x0021E668
		public Span<byte> GetPhotoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005F98 RID: 24472 RVA: 0x00220478 File Offset: 0x0021E678
		public byte[] GetPhotoPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06005F99 RID: 24473 RVA: 0x00220490 File Offset: 0x0021E690
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

		// Token: 0x06005F9A RID: 24474 RVA: 0x002204C8 File Offset: 0x0021E6C8
		public Span<byte> GetBigPhotoPathMBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x002204D8 File Offset: 0x0021E6D8
		public byte[] GetBigPhotoPathMArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06005F9C RID: 24476 RVA: 0x002204F0 File Offset: 0x0021E6F0
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

		// Token: 0x06005F9D RID: 24477 RVA: 0x00220528 File Offset: 0x0021E728
		public Span<byte> GetBigPhotoPathFBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06005F9E RID: 24478 RVA: 0x00220538 File Offset: 0x0021E738
		public byte[] GetBigPhotoPathFArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06005F9F RID: 24479 RVA: 0x00220550 File Offset: 0x0021E750
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

		// Token: 0x06005FA0 RID: 24480 RVA: 0x00220588 File Offset: 0x0021E788
		public Span<byte> GetSmallPhotoPathMBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x00220598 File Offset: 0x0021E798
		public byte[] GetSmallPhotoPathMArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06005FA2 RID: 24482 RVA: 0x002205B0 File Offset: 0x0021E7B0
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

		// Token: 0x06005FA3 RID: 24483 RVA: 0x002205E8 File Offset: 0x0021E7E8
		public Span<byte> GetSmallPhotoPathFBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x002205F8 File Offset: 0x0021E7F8
		public byte[] GetSmallPhotoPathFArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x040051A8 RID: 20904
		private Table __p;
	}
}
