using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C16 RID: 3094
	public struct BlackCoastThemeRewardRe : IFlatbufferObject
	{
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x0600533F RID: 21311 RVA: 0x00204516 File Offset: 0x00202716
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x00204523 File Offset: 0x00202723
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x0020452C File Offset: 0x0020272C
		public static BlackCoastThemeRewardRe GetRootAsBlackCoastThemeRewardRe(ByteBuffer _bb)
		{
			return BlackCoastThemeRewardRe.GetRootAsBlackCoastThemeRewardRe(_bb, default(BlackCoastThemeRewardRe));
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x00204548 File Offset: 0x00202748
		public static BlackCoastThemeRewardRe GetRootAsBlackCoastThemeRewardRe(ByteBuffer _bb, BlackCoastThemeRewardRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x00204565 File Offset: 0x00202765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x00204574 File Offset: 0x00202774
		public BlackCoastThemeRewardRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06005345 RID: 21317 RVA: 0x00204584 File Offset: 0x00202784
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

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06005346 RID: 21318 RVA: 0x002045C0 File Offset: 0x002027C0
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06005347 RID: 21319 RVA: 0x002045FC File Offset: 0x002027FC
		public int ItemId
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

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06005348 RID: 21320 RVA: 0x00204638 File Offset: 0x00202838
		public int Active
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

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06005349 RID: 21321 RVA: 0x00204678 File Offset: 0x00202878
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

		// Token: 0x04005111 RID: 20753
		private Table __p;
	}
}
