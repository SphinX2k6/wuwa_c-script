using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200111E RID: 4382
	public struct RogueWhiteCatReward : IFlatbufferObject
	{
		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x0600CD67 RID: 52583 RVA: 0x00313271 File Offset: 0x00311471
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CD68 RID: 52584 RVA: 0x0031327E File Offset: 0x0031147E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CD69 RID: 52585 RVA: 0x00313288 File Offset: 0x00311488
		public static RogueWhiteCatReward GetRootAsRogueWhiteCatReward(ByteBuffer _bb)
		{
			return RogueWhiteCatReward.GetRootAsRogueWhiteCatReward(_bb, default(RogueWhiteCatReward));
		}

		// Token: 0x0600CD6A RID: 52586 RVA: 0x003132A4 File Offset: 0x003114A4
		public static RogueWhiteCatReward GetRootAsRogueWhiteCatReward(ByteBuffer _bb, RogueWhiteCatReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CD6B RID: 52587 RVA: 0x003132C1 File Offset: 0x003114C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CD6C RID: 52588 RVA: 0x003132D0 File Offset: 0x003114D0
		public RogueWhiteCatReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0600CD6D RID: 52589 RVA: 0x003132E0 File Offset: 0x003114E0
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

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600CD6E RID: 52590 RVA: 0x0031331C File Offset: 0x0031151C
		public int NeedEnergy
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

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600CD6F RID: 52591 RVA: 0x00313358 File Offset: 0x00311558
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

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600CD70 RID: 52592 RVA: 0x00313394 File Offset: 0x00311594
		public int DropId
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

		// Token: 0x0400571B RID: 22299
		private Table __p;
	}
}
