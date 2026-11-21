using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200118B RID: 4491
	public struct ScratchCardRewardRe : IFlatbufferObject
	{
		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x0600D791 RID: 55185 RVA: 0x00329ADE File Offset: 0x00327CDE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D792 RID: 55186 RVA: 0x00329AEB File Offset: 0x00327CEB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D793 RID: 55187 RVA: 0x00329AF4 File Offset: 0x00327CF4
		public static ScratchCardRewardRe GetRootAsScratchCardRewardRe(ByteBuffer _bb)
		{
			return ScratchCardRewardRe.GetRootAsScratchCardRewardRe(_bb, default(ScratchCardRewardRe));
		}

		// Token: 0x0600D794 RID: 55188 RVA: 0x00329B10 File Offset: 0x00327D10
		public static ScratchCardRewardRe GetRootAsScratchCardRewardRe(ByteBuffer _bb, ScratchCardRewardRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D795 RID: 55189 RVA: 0x00329B2D File Offset: 0x00327D2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D796 RID: 55190 RVA: 0x00329B3C File Offset: 0x00327D3C
		public ScratchCardRewardRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x0600D797 RID: 55191 RVA: 0x00329B4C File Offset: 0x00327D4C
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

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x0600D798 RID: 55192 RVA: 0x00329B88 File Offset: 0x00327D88
		public int RoundId
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

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x0600D799 RID: 55193 RVA: 0x00329BC4 File Offset: 0x00327DC4
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x0600D79A RID: 55194 RVA: 0x00329C04 File Offset: 0x00327E04
		public IntPair? RewardItem
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IntPair?(default(IntPair).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0400579C RID: 22428
		private Table __p;
	}
}
