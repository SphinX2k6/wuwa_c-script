using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DDD RID: 3549
	public struct LongShanUiConfig : IFlatbufferObject
	{
		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x06008F9F RID: 36767 RVA: 0x0027B414 File Offset: 0x00279614
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008FA0 RID: 36768 RVA: 0x0027B421 File Offset: 0x00279621
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008FA1 RID: 36769 RVA: 0x0027B428 File Offset: 0x00279628
		public static LongShanUiConfig GetRootAsLongShanUiConfig(ByteBuffer _bb)
		{
			return LongShanUiConfig.GetRootAsLongShanUiConfig(_bb, default(LongShanUiConfig));
		}

		// Token: 0x06008FA2 RID: 36770 RVA: 0x0027B444 File Offset: 0x00279644
		public static LongShanUiConfig GetRootAsLongShanUiConfig(ByteBuffer _bb, LongShanUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008FA3 RID: 36771 RVA: 0x0027B461 File Offset: 0x00279661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008FA4 RID: 36772 RVA: 0x0027B470 File Offset: 0x00279670
		public LongShanUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x06008FA5 RID: 36773 RVA: 0x0027B480 File Offset: 0x00279680
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

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x06008FA6 RID: 36774 RVA: 0x0027B4BC File Offset: 0x002796BC
		public string SubViewId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008FA7 RID: 36775 RVA: 0x0027B4F3 File Offset: 0x002796F3
		public Span<byte> GetSubViewIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008FA8 RID: 36776 RVA: 0x0027B502 File Offset: 0x00279702
		public byte[] GetSubViewIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x06008FA9 RID: 36777 RVA: 0x0027B51C File Offset: 0x0027971C
		public string MainViewId
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

		// Token: 0x06008FAA RID: 36778 RVA: 0x0027B553 File Offset: 0x00279753
		public Span<byte> GetMainViewIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008FAB RID: 36779 RVA: 0x0027B562 File Offset: 0x00279762
		public byte[] GetMainViewIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x06008FAC RID: 36780 RVA: 0x0027B57C File Offset: 0x0027977C
		public string RewardViewId
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

		// Token: 0x06008FAD RID: 36781 RVA: 0x0027B5B4 File Offset: 0x002797B4
		public Span<byte> GetRewardViewIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008FAE RID: 36782 RVA: 0x0027B5C4 File Offset: 0x002797C4
		public byte[] GetRewardViewIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x06008FAF RID: 36783 RVA: 0x0027B5DC File Offset: 0x002797DC
		public string OpenTipId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008FB0 RID: 36784 RVA: 0x0027B614 File Offset: 0x00279814
		public Span<byte> GetOpenTipIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008FB1 RID: 36785 RVA: 0x0027B624 File Offset: 0x00279824
		public byte[] GetOpenTipIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E79 RID: 20089
		private Table __p;
	}
}
