using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012AA RID: 4778
	public struct TravelTaskArea : IFlatbufferObject
	{
		// Token: 0x17004020 RID: 16416
		// (get) Token: 0x0600F288 RID: 62088 RVA: 0x00366E29 File Offset: 0x00365029
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F289 RID: 62089 RVA: 0x00366E36 File Offset: 0x00365036
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F28A RID: 62090 RVA: 0x00366E40 File Offset: 0x00365040
		public static TravelTaskArea GetRootAsTravelTaskArea(ByteBuffer _bb)
		{
			return TravelTaskArea.GetRootAsTravelTaskArea(_bb, default(TravelTaskArea));
		}

		// Token: 0x0600F28B RID: 62091 RVA: 0x00366E5C File Offset: 0x0036505C
		public static TravelTaskArea GetRootAsTravelTaskArea(ByteBuffer _bb, TravelTaskArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F28C RID: 62092 RVA: 0x00366E79 File Offset: 0x00365079
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F28D RID: 62093 RVA: 0x00366E88 File Offset: 0x00365088
		public TravelTaskArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004021 RID: 16417
		// (get) Token: 0x0600F28E RID: 62094 RVA: 0x00366E98 File Offset: 0x00365098
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

		// Token: 0x17004022 RID: 16418
		// (get) Token: 0x0600F28F RID: 62095 RVA: 0x00366ED4 File Offset: 0x003650D4
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

		// Token: 0x17004023 RID: 16419
		// (get) Token: 0x0600F290 RID: 62096 RVA: 0x00366F10 File Offset: 0x00365110
		public int UnLockCondition
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

		// Token: 0x17004024 RID: 16420
		// (get) Token: 0x0600F291 RID: 62097 RVA: 0x00366F4C File Offset: 0x0036514C
		public int UnlockAccessId
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

		// Token: 0x17004025 RID: 16421
		// (get) Token: 0x0600F292 RID: 62098 RVA: 0x00366F8C File Offset: 0x0036518C
		public int Sort
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

		// Token: 0x040058FD RID: 22781
		private Table __p;
	}
}
