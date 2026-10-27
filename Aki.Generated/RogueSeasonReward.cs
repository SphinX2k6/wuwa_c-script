using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001020 RID: 4128
	public struct RogueSeasonReward : IFlatbufferObject
	{
		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x0600C4EA RID: 50410 RVA: 0x002F1F72 File Offset: 0x002F0172
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C4EB RID: 50411 RVA: 0x002F1F7F File Offset: 0x002F017F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C4EC RID: 50412 RVA: 0x002F1F88 File Offset: 0x002F0188
		public static RogueSeasonReward GetRootAsRogueSeasonReward(ByteBuffer _bb)
		{
			return RogueSeasonReward.GetRootAsRogueSeasonReward(_bb, default(RogueSeasonReward));
		}

		// Token: 0x0600C4ED RID: 50413 RVA: 0x002F1FA4 File Offset: 0x002F01A4
		public static RogueSeasonReward GetRootAsRogueSeasonReward(ByteBuffer _bb, RogueSeasonReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C4EE RID: 50414 RVA: 0x002F1FC1 File Offset: 0x002F01C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C4EF RID: 50415 RVA: 0x002F1FD0 File Offset: 0x002F01D0
		public RogueSeasonReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x0600C4F0 RID: 50416 RVA: 0x002F1FE0 File Offset: 0x002F01E0
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

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x0600C4F1 RID: 50417 RVA: 0x002F201C File Offset: 0x002F021C
		public int SeasonId
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

		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x0600C4F2 RID: 50418 RVA: 0x002F2058 File Offset: 0x002F0258
		public int Index
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

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x0600C4F3 RID: 50419 RVA: 0x002F2094 File Offset: 0x002F0294
		public int Point
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

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x0600C4F4 RID: 50420 RVA: 0x002F20D4 File Offset: 0x002F02D4
		public int DropId
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

		// Token: 0x04005112 RID: 20754
		private Table __p;
	}
}
