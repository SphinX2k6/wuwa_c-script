using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200111D RID: 4381
	public struct RogueWhiteCatInst : IFlatbufferObject
	{
		// Token: 0x17003258 RID: 12888
		// (get) Token: 0x0600CD5C RID: 52572 RVA: 0x003130D1 File Offset: 0x003112D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CD5D RID: 52573 RVA: 0x003130DE File Offset: 0x003112DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CD5E RID: 52574 RVA: 0x003130E8 File Offset: 0x003112E8
		public static RogueWhiteCatInst GetRootAsRogueWhiteCatInst(ByteBuffer _bb)
		{
			return RogueWhiteCatInst.GetRootAsRogueWhiteCatInst(_bb, default(RogueWhiteCatInst));
		}

		// Token: 0x0600CD5F RID: 52575 RVA: 0x00313104 File Offset: 0x00311304
		public static RogueWhiteCatInst GetRootAsRogueWhiteCatInst(ByteBuffer _bb, RogueWhiteCatInst obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CD60 RID: 52576 RVA: 0x00313121 File Offset: 0x00311321
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CD61 RID: 52577 RVA: 0x00313130 File Offset: 0x00311330
		public RogueWhiteCatInst __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003259 RID: 12889
		// (get) Token: 0x0600CD62 RID: 52578 RVA: 0x00313140 File Offset: 0x00311340
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

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600CD63 RID: 52579 RVA: 0x0031317C File Offset: 0x0031137C
		public int InstId
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

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0600CD64 RID: 52580 RVA: 0x003131B8 File Offset: 0x003113B8
		public int ConditionGroupId
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

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x0600CD65 RID: 52581 RVA: 0x003131F4 File Offset: 0x003113F4
		public int UnlockDay
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

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x0600CD66 RID: 52582 RVA: 0x00313234 File Offset: 0x00311434
		public int TrialRoleId
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

		// Token: 0x0400571A RID: 22298
		private Table __p;
	}
}
