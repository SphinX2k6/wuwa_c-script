using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B37 RID: 2871
	public struct BlackCoastThemeStageRe : IFlatbufferObject
	{
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06004D88 RID: 19848 RVA: 0x001E4371 File Offset: 0x001E2571
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x001E437E File Offset: 0x001E257E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x001E4388 File Offset: 0x001E2588
		public static BlackCoastThemeStageRe GetRootAsBlackCoastThemeStageRe(ByteBuffer _bb)
		{
			return BlackCoastThemeStageRe.GetRootAsBlackCoastThemeStageRe(_bb, default(BlackCoastThemeStageRe));
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x001E43A4 File Offset: 0x001E25A4
		public static BlackCoastThemeStageRe GetRootAsBlackCoastThemeStageRe(ByteBuffer _bb, BlackCoastThemeStageRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x001E43C1 File Offset: 0x001E25C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x001E43D0 File Offset: 0x001E25D0
		public BlackCoastThemeStageRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06004D8E RID: 19854 RVA: 0x001E43E0 File Offset: 0x001E25E0
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06004D8F RID: 19855 RVA: 0x001E441C File Offset: 0x001E261C
		public int ActivityId
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

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06004D90 RID: 19856 RVA: 0x001E4458 File Offset: 0x001E2658
		public string Title
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

		// Token: 0x06004D91 RID: 19857 RVA: 0x001E448F File Offset: 0x001E268F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x001E449E File Offset: 0x001E269E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06004D93 RID: 19859 RVA: 0x001E44B8 File Offset: 0x001E26B8
		public string TitleDetail
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

		// Token: 0x06004D94 RID: 19860 RVA: 0x001E44F0 File Offset: 0x001E26F0
		public Span<byte> GetTitleDetailBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x001E4500 File Offset: 0x001E2700
		public byte[] GetTitleDetailArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06004D96 RID: 19862 RVA: 0x001E4518 File Offset: 0x001E2718
		public int OpenConditionId
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

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06004D97 RID: 19863 RVA: 0x001E4558 File Offset: 0x001E2758
		public int QuestionId
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

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06004D98 RID: 19864 RVA: 0x001E4598 File Offset: 0x001E2798
		public string VideoSource
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

		// Token: 0x06004D99 RID: 19865 RVA: 0x001E45D0 File Offset: 0x001E27D0
		public Span<byte> GetVideoSourceBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x001E45E0 File Offset: 0x001E27E0
		public byte[] GetVideoSourceArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06004D9B RID: 19867 RVA: 0x001E45F8 File Offset: 0x001E27F8
		public string TextureSmall
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

		// Token: 0x06004D9C RID: 19868 RVA: 0x001E4630 File Offset: 0x001E2830
		public Span<byte> GetTextureSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x001E4640 File Offset: 0x001E2840
		public byte[] GetTextureSmallArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06004D9E RID: 19870 RVA: 0x001E4658 File Offset: 0x001E2858
		public string TextureNormal
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

		// Token: 0x06004D9F RID: 19871 RVA: 0x001E4690 File Offset: 0x001E2890
		public Span<byte> GetTextureNormalBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x001E46A0 File Offset: 0x001E28A0
		public byte[] GetTextureNormalArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B32 RID: 19250
		private Table __p;
	}
}
