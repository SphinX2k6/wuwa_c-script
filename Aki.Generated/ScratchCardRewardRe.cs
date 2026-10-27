using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001090 RID: 4240
	public struct ScratchCardRewardRe : IFlatbufferObject
	{
		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0600CFBE RID: 53182 RVA: 0x0030A509 File Offset: 0x00308709
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CFBF RID: 53183 RVA: 0x0030A516 File Offset: 0x00308716
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CFC0 RID: 53184 RVA: 0x0030A520 File Offset: 0x00308720
		public static ScratchCardRewardRe GetRootAsScratchCardRewardRe(ByteBuffer _bb)
		{
			return ScratchCardRewardRe.GetRootAsScratchCardRewardRe(_bb, default(ScratchCardRewardRe));
		}

		// Token: 0x0600CFC1 RID: 53185 RVA: 0x0030A53C File Offset: 0x0030873C
		public static ScratchCardRewardRe GetRootAsScratchCardRewardRe(ByteBuffer _bb, ScratchCardRewardRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CFC2 RID: 53186 RVA: 0x0030A559 File Offset: 0x00308759
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CFC3 RID: 53187 RVA: 0x0030A568 File Offset: 0x00308768
		public ScratchCardRewardRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x0600CFC4 RID: 53188 RVA: 0x0030A578 File Offset: 0x00308778
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

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0600CFC5 RID: 53189 RVA: 0x0030A5B4 File Offset: 0x003087B4
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

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0600CFC6 RID: 53190 RVA: 0x0030A5F0 File Offset: 0x003087F0
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x0600CFC7 RID: 53191 RVA: 0x0030A630 File Offset: 0x00308830
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

		// Token: 0x0400519D RID: 20893
		private Table __p;
	}
}
