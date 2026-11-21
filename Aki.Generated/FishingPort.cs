using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D6A RID: 3434
	public struct FishingPort : IFlatbufferObject
	{
		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x060075F9 RID: 30201 RVA: 0x00251AFA File Offset: 0x0024FCFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x00251B07 File Offset: 0x0024FD07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x00251B10 File Offset: 0x0024FD10
		public static FishingPort GetRootAsFishingPort(ByteBuffer _bb)
		{
			return FishingPort.GetRootAsFishingPort(_bb, default(FishingPort));
		}

		// Token: 0x060075FC RID: 30204 RVA: 0x00251B2C File Offset: 0x0024FD2C
		public static FishingPort GetRootAsFishingPort(ByteBuffer _bb, FishingPort obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060075FD RID: 30205 RVA: 0x00251B49 File Offset: 0x0024FD49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060075FE RID: 30206 RVA: 0x00251B58 File Offset: 0x0024FD58
		public FishingPort __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x060075FF RID: 30207 RVA: 0x00251B68 File Offset: 0x0024FD68
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

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06007600 RID: 30208 RVA: 0x00251BA4 File Offset: 0x0024FDA4
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

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x06007601 RID: 30209 RVA: 0x00251BE0 File Offset: 0x0024FDE0
		public int NpcEntityConfigId
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

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x06007602 RID: 30210 RVA: 0x00251C1C File Offset: 0x0024FE1C
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

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06007603 RID: 30211 RVA: 0x00251C5C File Offset: 0x0024FE5C
		public int SceneConfigId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06007604 RID: 30212 RVA: 0x00251C9C File Offset: 0x0024FE9C
		public int SailingPoint
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

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06007605 RID: 30213 RVA: 0x00251CDC File Offset: 0x0024FEDC
		public int AshorePoint
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

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06007606 RID: 30214 RVA: 0x00251D1C File Offset: 0x0024FF1C
		public int MarkId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x06007607 RID: 30215 RVA: 0x00251D5C File Offset: 0x0024FF5C
		public int ShopId
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

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x06007608 RID: 30216 RVA: 0x00251D9C File Offset: 0x0024FF9C
		public int EnterRange
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

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06007609 RID: 30217 RVA: 0x00251DDC File Offset: 0x0024FFDC
		public int LeaveRange
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

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x0600760A RID: 30218 RVA: 0x00251E1C File Offset: 0x0025001C
		public int RangeCenter
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

		// Token: 0x040052BC RID: 21180
		private Table __p;
	}
}
