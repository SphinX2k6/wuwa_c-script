using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D2C RID: 3372
	public struct HonamiSteadyConsume : IFlatbufferObject
	{
		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x06007E97 RID: 32407 RVA: 0x00254320 File Offset: 0x00252520
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E98 RID: 32408 RVA: 0x0025432D File Offset: 0x0025252D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E99 RID: 32409 RVA: 0x00254334 File Offset: 0x00252534
		public static HonamiSteadyConsume GetRootAsHonamiSteadyConsume(ByteBuffer _bb)
		{
			return HonamiSteadyConsume.GetRootAsHonamiSteadyConsume(_bb, default(HonamiSteadyConsume));
		}

		// Token: 0x06007E9A RID: 32410 RVA: 0x00254350 File Offset: 0x00252550
		public static HonamiSteadyConsume GetRootAsHonamiSteadyConsume(ByteBuffer _bb, HonamiSteadyConsume obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E9B RID: 32411 RVA: 0x0025436D File Offset: 0x0025256D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E9C RID: 32412 RVA: 0x0025437C File Offset: 0x0025257C
		public HonamiSteadyConsume __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06007E9D RID: 32413 RVA: 0x0025438C File Offset: 0x0025258C
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

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06007E9E RID: 32414 RVA: 0x002543C8 File Offset: 0x002525C8
		public int CostGroup
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

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06007E9F RID: 32415 RVA: 0x00254404 File Offset: 0x00252604
		public int DangerLevel
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

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x06007EA0 RID: 32416 RVA: 0x00254440 File Offset: 0x00252640
		public int SteadyConsume
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

		// Token: 0x04004DA4 RID: 19876
		private Table __p;
	}
}
