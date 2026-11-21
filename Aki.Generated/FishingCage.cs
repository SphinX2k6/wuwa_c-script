using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D5E RID: 3422
	public struct FishingCage : IFlatbufferObject
	{
		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x060074F4 RID: 29940 RVA: 0x0024F204 File Offset: 0x0024D404
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x0024F211 File Offset: 0x0024D411
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x0024F218 File Offset: 0x0024D418
		public static FishingCage GetRootAsFishingCage(ByteBuffer _bb)
		{
			return FishingCage.GetRootAsFishingCage(_bb, default(FishingCage));
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x0024F234 File Offset: 0x0024D434
		public static FishingCage GetRootAsFishingCage(ByteBuffer _bb, FishingCage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x0024F251 File Offset: 0x0024D451
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x0024F260 File Offset: 0x0024D460
		public FishingCage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x060074FA RID: 29946 RVA: 0x0024F270 File Offset: 0x0024D470
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

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x060074FB RID: 29947 RVA: 0x0024F2AC File Offset: 0x0024D4AC
		public int EntityConfigId
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

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x060074FC RID: 29948 RVA: 0x0024F2E8 File Offset: 0x0024D4E8
		public int SceneConfigId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x060074FD RID: 29949 RVA: 0x0024F324 File Offset: 0x0024D524
		public int UnlockCondition
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

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x060074FE RID: 29950 RVA: 0x0024F364 File Offset: 0x0024D564
		public int CountLimit
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

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x060074FF RID: 29951 RVA: 0x0024F3A4 File Offset: 0x0024D5A4
		public int RefreshTime
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

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06007500 RID: 29952 RVA: 0x0024F3E4 File Offset: 0x0024D5E4
		public int OutputGroupId
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

		// Token: 0x040052A9 RID: 21161
		private Table __p;
	}
}
