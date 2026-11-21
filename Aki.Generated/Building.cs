using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C38 RID: 3128
	public struct Building : IFlatbufferObject
	{
		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060056F1 RID: 22257 RVA: 0x0020C434 File Offset: 0x0020A634
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x0020C441 File Offset: 0x0020A641
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x0020C448 File Offset: 0x0020A648
		public static Building GetRootAsBuilding(ByteBuffer _bb)
		{
			return Building.GetRootAsBuilding(_bb, default(Building));
		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x0020C464 File Offset: 0x0020A664
		public static Building GetRootAsBuilding(ByteBuffer _bb, Building obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x0020C481 File Offset: 0x0020A681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x0020C490 File Offset: 0x0020A690
		public Building __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060056F7 RID: 22263 RVA: 0x0020C4A0 File Offset: 0x0020A6A0
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

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060056F8 RID: 22264 RVA: 0x0020C4DC File Offset: 0x0020A6DC
		public string Name
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

		// Token: 0x060056F9 RID: 22265 RVA: 0x0020C513 File Offset: 0x0020A713
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060056FA RID: 22266 RVA: 0x0020C522 File Offset: 0x0020A722
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060056FB RID: 22267 RVA: 0x0020C53C File Offset: 0x0020A73C
		public int Sort
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

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060056FC RID: 22268 RVA: 0x0020C578 File Offset: 0x0020A778
		public string Desc
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

		// Token: 0x060056FD RID: 22269 RVA: 0x0020C5B0 File Offset: 0x0020A7B0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060056FE RID: 22270 RVA: 0x0020C5C0 File Offset: 0x0020A7C0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060056FF RID: 22271 RVA: 0x0020C5D8 File Offset: 0x0020A7D8
		public int AssociateRole
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

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06005700 RID: 22272 RVA: 0x0020C618 File Offset: 0x0020A818
		public string RoleTips
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

		// Token: 0x06005701 RID: 22273 RVA: 0x0020C650 File Offset: 0x0020A850
		public Span<byte> GetRoleTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005702 RID: 22274 RVA: 0x0020C660 File Offset: 0x0020A860
		public byte[] GetRoleTipsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06005703 RID: 22275 RVA: 0x0020C678 File Offset: 0x0020A878
		public string BuildingTexture
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

		// Token: 0x06005704 RID: 22276 RVA: 0x0020C6B0 File Offset: 0x0020A8B0
		public Span<byte> GetBuildingTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005705 RID: 22277 RVA: 0x0020C6C0 File Offset: 0x0020A8C0
		public byte[] GetBuildingTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06005706 RID: 22278 RVA: 0x0020C6D8 File Offset: 0x0020A8D8
		public string TipsSprite
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

		// Token: 0x06005707 RID: 22279 RVA: 0x0020C710 File Offset: 0x0020A910
		public Span<byte> GetTipsSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x0020C720 File Offset: 0x0020A920
		public byte[] GetTipsSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06005709 RID: 22281 RVA: 0x0020C738 File Offset: 0x0020A938
		public int MapMarkId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600570A RID: 22282 RVA: 0x0020C778 File Offset: 0x0020A978
		public int UnLockPrice
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600570B RID: 22283 RVA: 0x0020C7B8 File Offset: 0x0020A9B8
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600570C RID: 22284 RVA: 0x0020C7F8 File Offset: 0x0020A9F8
		public int JumpType
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600570D RID: 22285 RVA: 0x0020C838 File Offset: 0x0020AA38
		public int JumpParam
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600570E RID: 22286 RVA: 0x0020C878 File Offset: 0x0020AA78
		public int UpGradeCurve
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600570F RID: 22287 RVA: 0x0020C8B8 File Offset: 0x0020AAB8
		public string FlowListName
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x0020C8F0 File Offset: 0x0020AAF0
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x0020C900 File Offset: 0x0020AB00
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06005712 RID: 22290 RVA: 0x0020C918 File Offset: 0x0020AB18
		public int FlowId
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

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06005713 RID: 22291 RVA: 0x0020C958 File Offset: 0x0020AB58
		public int StateId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06005714 RID: 22292 RVA: 0x0020C998 File Offset: 0x0020AB98
		public int TriggerEntityId
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005135 RID: 20789
		private Table __p;
	}
}
