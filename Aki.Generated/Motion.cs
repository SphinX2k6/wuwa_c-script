using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E2D RID: 3629
	public struct Motion : IFlatbufferObject
	{
		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x0600967F RID: 38527 RVA: 0x0028A839 File Offset: 0x00288A39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009680 RID: 38528 RVA: 0x0028A846 File Offset: 0x00288A46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009681 RID: 38529 RVA: 0x0028A850 File Offset: 0x00288A50
		public static Motion GetRootAsMotion(ByteBuffer _bb)
		{
			return Motion.GetRootAsMotion(_bb, default(Motion));
		}

		// Token: 0x06009682 RID: 38530 RVA: 0x0028A86C File Offset: 0x00288A6C
		public static Motion GetRootAsMotion(ByteBuffer _bb, Motion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009683 RID: 38531 RVA: 0x0028A889 File Offset: 0x00288A89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009684 RID: 38532 RVA: 0x0028A898 File Offset: 0x00288A98
		public Motion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x06009685 RID: 38533 RVA: 0x0028A8A8 File Offset: 0x00288AA8
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

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06009686 RID: 38534 RVA: 0x0028A8E4 File Offset: 0x00288AE4
		public int RoleId
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

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x06009687 RID: 38535 RVA: 0x0028A920 File Offset: 0x00288B20
		public int SkinId
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

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06009688 RID: 38536 RVA: 0x0028A95C File Offset: 0x00288B5C
		public int Type
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

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x06009689 RID: 38537 RVA: 0x0028A99C File Offset: 0x00288B9C
		public int Sort
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

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x0600968A RID: 38538 RVA: 0x0028A9DC File Offset: 0x00288BDC
		public string Title
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

		// Token: 0x0600968B RID: 38539 RVA: 0x0028AA14 File Offset: 0x00288C14
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600968C RID: 38540 RVA: 0x0028AA24 File Offset: 0x00288C24
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x0600968D RID: 38541 RVA: 0x0028AA3C File Offset: 0x00288C3C
		public string Content
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

		// Token: 0x0600968E RID: 38542 RVA: 0x0028AA74 File Offset: 0x00288C74
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600968F RID: 38543 RVA: 0x0028AA84 File Offset: 0x00288C84
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06009690 RID: 38544 RVA: 0x0028AA9C File Offset: 0x00288C9C
		public string MotionImg
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

		// Token: 0x06009691 RID: 38545 RVA: 0x0028AAD4 File Offset: 0x00288CD4
		public Span<byte> GetMotionImgBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009692 RID: 38546 RVA: 0x0028AAE4 File Offset: 0x00288CE4
		public byte[] GetMotionImgArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x06009693 RID: 38547 RVA: 0x0028AAFC File Offset: 0x00288CFC
		public string AniBlueprint
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

		// Token: 0x06009694 RID: 38548 RVA: 0x0028AB34 File Offset: 0x00288D34
		public Span<byte> GetAniBlueprintBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009695 RID: 38549 RVA: 0x0028AB44 File Offset: 0x00288D44
		public byte[] GetAniBlueprintArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x06009696 RID: 38550 RVA: 0x0028AB5C File Offset: 0x00288D5C
		public string AniMontage
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

		// Token: 0x06009697 RID: 38551 RVA: 0x0028AB94 File Offset: 0x00288D94
		public Span<byte> GetAniMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009698 RID: 38552 RVA: 0x0028ABA4 File Offset: 0x00288DA4
		public byte[] GetAniMontageArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x06009699 RID: 38553 RVA: 0x0028ABBC File Offset: 0x00288DBC
		public int CondGroupId
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

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x0600969A RID: 38554 RVA: 0x0028ABFC File Offset: 0x00288DFC
		public int Morph
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

		// Token: 0x04004ED2 RID: 20178
		private Table __p;
	}
}
