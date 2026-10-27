using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D6D RID: 3437
	public struct InfrV2ScoreReward : IFlatbufferObject
	{
		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06008420 RID: 33824 RVA: 0x002608C6 File Offset: 0x0025EAC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008421 RID: 33825 RVA: 0x002608D3 File Offset: 0x0025EAD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008422 RID: 33826 RVA: 0x002608DC File Offset: 0x0025EADC
		public static InfrV2ScoreReward GetRootAsInfrV2ScoreReward(ByteBuffer _bb)
		{
			return InfrV2ScoreReward.GetRootAsInfrV2ScoreReward(_bb, default(InfrV2ScoreReward));
		}

		// Token: 0x06008423 RID: 33827 RVA: 0x002608F8 File Offset: 0x0025EAF8
		public static InfrV2ScoreReward GetRootAsInfrV2ScoreReward(ByteBuffer _bb, InfrV2ScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008424 RID: 33828 RVA: 0x00260915 File Offset: 0x0025EB15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008425 RID: 33829 RVA: 0x00260924 File Offset: 0x0025EB24
		public InfrV2ScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x06008426 RID: 33830 RVA: 0x00260934 File Offset: 0x0025EB34
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

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x06008427 RID: 33831 RVA: 0x00260970 File Offset: 0x0025EB70
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

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x06008428 RID: 33832 RVA: 0x002609AC File Offset: 0x0025EBAC
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

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x06008429 RID: 33833 RVA: 0x002609E8 File Offset: 0x0025EBE8
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

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x0600842A RID: 33834 RVA: 0x00260A28 File Offset: 0x0025EC28
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

		// Token: 0x04004DF0 RID: 19952
		private Table __p;
	}
}
