using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A6 RID: 4262
	public struct RewardViewFromSource : IFlatbufferObject
	{
		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x0600C25C RID: 49756 RVA: 0x002FAC00 File Offset: 0x002F8E00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C25D RID: 49757 RVA: 0x002FAC0D File Offset: 0x002F8E0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C25E RID: 49758 RVA: 0x002FAC14 File Offset: 0x002F8E14
		public static RewardViewFromSource GetRootAsRewardViewFromSource(ByteBuffer _bb)
		{
			return RewardViewFromSource.GetRootAsRewardViewFromSource(_bb, default(RewardViewFromSource));
		}

		// Token: 0x0600C25F RID: 49759 RVA: 0x002FAC30 File Offset: 0x002F8E30
		public static RewardViewFromSource GetRootAsRewardViewFromSource(ByteBuffer _bb, RewardViewFromSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C260 RID: 49760 RVA: 0x002FAC4D File Offset: 0x002F8E4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C261 RID: 49761 RVA: 0x002FAC5C File Offset: 0x002F8E5C
		public RewardViewFromSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x0600C262 RID: 49762 RVA: 0x002FAC6C File Offset: 0x002F8E6C
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

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x0600C263 RID: 49763 RVA: 0x002FACA8 File Offset: 0x002F8EA8
		public int RewardSourceId
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

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x0600C264 RID: 49764 RVA: 0x002FACE4 File Offset: 0x002F8EE4
		public int RewardViewId
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

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x0600C265 RID: 49765 RVA: 0x002FAD20 File Offset: 0x002F8F20
		public bool RewardNotifyNotTrick
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005680 RID: 22144
		private Table __p;
	}
}
