using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B36 RID: 2870
	public struct BlackCoastThemeRewardRe : IFlatbufferObject
	{
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06004D7D RID: 19837 RVA: 0x001E41D1 File Offset: 0x001E23D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x001E41DE File Offset: 0x001E23DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x001E41E8 File Offset: 0x001E23E8
		public static BlackCoastThemeRewardRe GetRootAsBlackCoastThemeRewardRe(ByteBuffer _bb)
		{
			return BlackCoastThemeRewardRe.GetRootAsBlackCoastThemeRewardRe(_bb, default(BlackCoastThemeRewardRe));
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x001E4204 File Offset: 0x001E2404
		public static BlackCoastThemeRewardRe GetRootAsBlackCoastThemeRewardRe(ByteBuffer _bb, BlackCoastThemeRewardRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x001E4221 File Offset: 0x001E2421
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x001E4230 File Offset: 0x001E2430
		public BlackCoastThemeRewardRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06004D83 RID: 19843 RVA: 0x001E4240 File Offset: 0x001E2440
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

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06004D84 RID: 19844 RVA: 0x001E427C File Offset: 0x001E247C
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

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06004D85 RID: 19845 RVA: 0x001E42B8 File Offset: 0x001E24B8
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

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06004D86 RID: 19846 RVA: 0x001E42F4 File Offset: 0x001E24F4
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

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06004D87 RID: 19847 RVA: 0x001E4334 File Offset: 0x001E2534
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

		// Token: 0x04004B31 RID: 19249
		private Table __p;
	}
}
