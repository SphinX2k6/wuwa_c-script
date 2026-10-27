using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C7A RID: 3194
	public struct FishingCage : IFlatbufferObject
	{
		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06006EE9 RID: 28393 RVA: 0x00230038 File Offset: 0x0022E238
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006EEA RID: 28394 RVA: 0x00230045 File Offset: 0x0022E245
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006EEB RID: 28395 RVA: 0x0023004C File Offset: 0x0022E24C
		public static FishingCage GetRootAsFishingCage(ByteBuffer _bb)
		{
			return FishingCage.GetRootAsFishingCage(_bb, default(FishingCage));
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x00230068 File Offset: 0x0022E268
		public static FishingCage GetRootAsFishingCage(ByteBuffer _bb, FishingCage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006EED RID: 28397 RVA: 0x00230085 File Offset: 0x0022E285
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006EEE RID: 28398 RVA: 0x00230094 File Offset: 0x0022E294
		public FishingCage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06006EEF RID: 28399 RVA: 0x002300A4 File Offset: 0x0022E2A4
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

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06006EF0 RID: 28400 RVA: 0x002300E0 File Offset: 0x0022E2E0
		public int EntityConfigId
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

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06006EF1 RID: 28401 RVA: 0x0023011C File Offset: 0x0022E31C
		public int SceneConfigId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06006EF2 RID: 28402 RVA: 0x00230158 File Offset: 0x0022E358
		public int UnlockCondition
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

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06006EF3 RID: 28403 RVA: 0x00230198 File Offset: 0x0022E398
		public int CountLimit
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

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06006EF4 RID: 28404 RVA: 0x002301D8 File Offset: 0x0022E3D8
		public int RefreshTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06006EF5 RID: 28405 RVA: 0x00230218 File Offset: 0x0022E418
		public int OutputGroupId
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

		// Token: 0x04004CC5 RID: 19653
		private Table __p;
	}
}
