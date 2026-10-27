using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EBE RID: 3774
	public struct PhantomBattleBadgeReward : IFlatbufferObject
	{
		// Token: 0x17002541 RID: 9537
		// (get) Token: 0x0600A47F RID: 42111 RVA: 0x002A9FC5 File Offset: 0x002A81C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x002A9FD2 File Offset: 0x002A81D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A481 RID: 42113 RVA: 0x002A9FDC File Offset: 0x002A81DC
		public static PhantomBattleBadgeReward GetRootAsPhantomBattleBadgeReward(ByteBuffer _bb)
		{
			return PhantomBattleBadgeReward.GetRootAsPhantomBattleBadgeReward(_bb, default(PhantomBattleBadgeReward));
		}

		// Token: 0x0600A482 RID: 42114 RVA: 0x002A9FF8 File Offset: 0x002A81F8
		public static PhantomBattleBadgeReward GetRootAsPhantomBattleBadgeReward(ByteBuffer _bb, PhantomBattleBadgeReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A483 RID: 42115 RVA: 0x002AA015 File Offset: 0x002A8215
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A484 RID: 42116 RVA: 0x002AA024 File Offset: 0x002A8224
		public PhantomBattleBadgeReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002542 RID: 9538
		// (get) Token: 0x0600A485 RID: 42117 RVA: 0x002AA034 File Offset: 0x002A8234
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

		// Token: 0x17002543 RID: 9539
		// (get) Token: 0x0600A486 RID: 42118 RVA: 0x002AA070 File Offset: 0x002A8270
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

		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x0600A487 RID: 42119 RVA: 0x002AA0AC File Offset: 0x002A82AC
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

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x0600A488 RID: 42120 RVA: 0x002AA0E8 File Offset: 0x002A82E8
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

		// Token: 0x04004F79 RID: 20345
		private Table __p;
	}
}
