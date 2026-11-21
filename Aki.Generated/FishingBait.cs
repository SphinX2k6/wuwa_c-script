using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D5C RID: 3420
	public struct FishingBait : IFlatbufferObject
	{
		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x060074DF RID: 29919 RVA: 0x0024EF01 File Offset: 0x0024D101
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x0024EF0E File Offset: 0x0024D10E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x0024EF18 File Offset: 0x0024D118
		public static FishingBait GetRootAsFishingBait(ByteBuffer _bb)
		{
			return FishingBait.GetRootAsFishingBait(_bb, default(FishingBait));
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x0024EF34 File Offset: 0x0024D134
		public static FishingBait GetRootAsFishingBait(ByteBuffer _bb, FishingBait obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x0024EF51 File Offset: 0x0024D151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x0024EF60 File Offset: 0x0024D160
		public FishingBait __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x060074E5 RID: 29925 RVA: 0x0024EF70 File Offset: 0x0024D170
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

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x060074E6 RID: 29926 RVA: 0x0024EFAC File Offset: 0x0024D1AC
		public int ExploreToolId
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

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x060074E7 RID: 29927 RVA: 0x0024EFE8 File Offset: 0x0024D1E8
		public int AreaId
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

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x060074E8 RID: 29928 RVA: 0x0024F024 File Offset: 0x0024D224
		public int GamePlayId
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

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x060074E9 RID: 29929 RVA: 0x0024F064 File Offset: 0x0024D264
		public int ItemId
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

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x060074EA RID: 29930 RVA: 0x0024F0A4 File Offset: 0x0024D2A4
		public int CountLimit
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052A7 RID: 21159
		private Table __p;
	}
}
