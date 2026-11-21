using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200123C RID: 4668
	public struct SurvivorsScoreReward : IFlatbufferObject
	{
		// Token: 0x17003C7A RID: 15482
		// (get) Token: 0x0600E8B2 RID: 59570 RVA: 0x00351350 File Offset: 0x0034F550
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E8B3 RID: 59571 RVA: 0x0035135D File Offset: 0x0034F55D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E8B4 RID: 59572 RVA: 0x00351364 File Offset: 0x0034F564
		public static SurvivorsScoreReward GetRootAsSurvivorsScoreReward(ByteBuffer _bb)
		{
			return SurvivorsScoreReward.GetRootAsSurvivorsScoreReward(_bb, default(SurvivorsScoreReward));
		}

		// Token: 0x0600E8B5 RID: 59573 RVA: 0x00351380 File Offset: 0x0034F580
		public static SurvivorsScoreReward GetRootAsSurvivorsScoreReward(ByteBuffer _bb, SurvivorsScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E8B6 RID: 59574 RVA: 0x0035139D File Offset: 0x0034F59D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E8B7 RID: 59575 RVA: 0x003513AC File Offset: 0x0034F5AC
		public SurvivorsScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C7B RID: 15483
		// (get) Token: 0x0600E8B8 RID: 59576 RVA: 0x003513BC File Offset: 0x0034F5BC
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

		// Token: 0x17003C7C RID: 15484
		// (get) Token: 0x0600E8B9 RID: 59577 RVA: 0x003513F8 File Offset: 0x0034F5F8
		public int Activity
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

		// Token: 0x17003C7D RID: 15485
		// (get) Token: 0x0600E8BA RID: 59578 RVA: 0x00351434 File Offset: 0x0034F634
		public int Index
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

		// Token: 0x17003C7E RID: 15486
		// (get) Token: 0x0600E8BB RID: 59579 RVA: 0x00351470 File Offset: 0x0034F670
		public int Score
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

		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x0600E8BC RID: 59580 RVA: 0x003514B0 File Offset: 0x0034F6B0
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

		// Token: 0x04005882 RID: 22658
		private Table __p;
	}
}
