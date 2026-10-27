using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BFE RID: 3070
	public struct DreamLinkWorldRun : IFlatbufferObject
	{
		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06006376 RID: 25462 RVA: 0x002160EA File Offset: 0x002142EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x002160F7 File Offset: 0x002142F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006378 RID: 25464 RVA: 0x00216100 File Offset: 0x00214300
		public static DreamLinkWorldRun GetRootAsDreamLinkWorldRun(ByteBuffer _bb)
		{
			return DreamLinkWorldRun.GetRootAsDreamLinkWorldRun(_bb, default(DreamLinkWorldRun));
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x0021611C File Offset: 0x0021431C
		public static DreamLinkWorldRun GetRootAsDreamLinkWorldRun(ByteBuffer _bb, DreamLinkWorldRun obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x00216139 File Offset: 0x00214339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600637B RID: 25467 RVA: 0x00216148 File Offset: 0x00214348
		public DreamLinkWorldRun __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x0600637C RID: 25468 RVA: 0x00216158 File Offset: 0x00214358
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

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600637D RID: 25469 RVA: 0x00216194 File Offset: 0x00214394
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

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x0600637E RID: 25470 RVA: 0x002161D0 File Offset: 0x002143D0
		public int MarkId
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

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x0600637F RID: 25471 RVA: 0x0021620C File Offset: 0x0021440C
		public int MarkRange
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

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06006380 RID: 25472 RVA: 0x0021624C File Offset: 0x0021444C
		public int ConditionGroupId
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

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06006381 RID: 25473 RVA: 0x0021628C File Offset: 0x0021448C
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

		// Token: 0x06006382 RID: 25474 RVA: 0x002162C4 File Offset: 0x002144C4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x002162D4 File Offset: 0x002144D4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06006384 RID: 25476 RVA: 0x002162EC File Offset: 0x002144EC
		public int RewardId
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

		// Token: 0x04004C2D RID: 19501
		private Table __p;
	}
}
