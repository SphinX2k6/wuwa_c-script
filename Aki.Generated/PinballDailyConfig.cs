using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F28 RID: 3880
	public struct PinballDailyConfig : IFlatbufferObject
	{
		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x0600AE9B RID: 44699 RVA: 0x002C0F35 File Offset: 0x002BF135
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE9C RID: 44700 RVA: 0x002C0F42 File Offset: 0x002BF142
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE9D RID: 44701 RVA: 0x002C0F4C File Offset: 0x002BF14C
		public static PinballDailyConfig GetRootAsPinballDailyConfig(ByteBuffer _bb)
		{
			return PinballDailyConfig.GetRootAsPinballDailyConfig(_bb, default(PinballDailyConfig));
		}

		// Token: 0x0600AE9E RID: 44702 RVA: 0x002C0F68 File Offset: 0x002BF168
		public static PinballDailyConfig GetRootAsPinballDailyConfig(ByteBuffer _bb, PinballDailyConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE9F RID: 44703 RVA: 0x002C0F85 File Offset: 0x002BF185
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AEA0 RID: 44704 RVA: 0x002C0F94 File Offset: 0x002BF194
		public PinballDailyConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x0600AEA1 RID: 44705 RVA: 0x002C0FA4 File Offset: 0x002BF1A4
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

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x0600AEA2 RID: 44706 RVA: 0x002C0FE0 File Offset: 0x002BF1E0
		public int LevelCompleteNum
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

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x0600AEA3 RID: 44707 RVA: 0x002C101C File Offset: 0x002BF21C
		public int DailyClearDropId
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

		// Token: 0x04004FF1 RID: 20465
		private Table __p;
	}
}
