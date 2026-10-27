using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC6 RID: 3782
	public struct PhantomBattleCardReward : IFlatbufferObject
	{
		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x0600A5D0 RID: 42448 RVA: 0x002ACF65 File Offset: 0x002AB165
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A5D1 RID: 42449 RVA: 0x002ACF72 File Offset: 0x002AB172
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x002ACF7C File Offset: 0x002AB17C
		public static PhantomBattleCardReward GetRootAsPhantomBattleCardReward(ByteBuffer _bb)
		{
			return PhantomBattleCardReward.GetRootAsPhantomBattleCardReward(_bb, default(PhantomBattleCardReward));
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x002ACF98 File Offset: 0x002AB198
		public static PhantomBattleCardReward GetRootAsPhantomBattleCardReward(ByteBuffer _bb, PhantomBattleCardReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A5D4 RID: 42452 RVA: 0x002ACFB5 File Offset: 0x002AB1B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A5D5 RID: 42453 RVA: 0x002ACFC4 File Offset: 0x002AB1C4
		public PhantomBattleCardReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x0600A5D6 RID: 42454 RVA: 0x002ACFD4 File Offset: 0x002AB1D4
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

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x0600A5D7 RID: 42455 RVA: 0x002AD010 File Offset: 0x002AB210
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

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x0600A5D8 RID: 42456 RVA: 0x002AD04C File Offset: 0x002AB24C
		public int DropId
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

		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x0600A5D9 RID: 42457 RVA: 0x002AD088 File Offset: 0x002AB288
		public int BitFlagId
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

		// Token: 0x04004F82 RID: 20354
		private Table __p;
	}
}
