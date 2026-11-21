using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C62 RID: 3170
	public struct CircumScoreReward : IFlatbufferObject
	{
		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06005BC8 RID: 23496 RVA: 0x00216CBD File Offset: 0x00214EBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x00216CCA File Offset: 0x00214ECA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x00216CD4 File Offset: 0x00214ED4
		public static CircumScoreReward GetRootAsCircumScoreReward(ByteBuffer _bb)
		{
			return CircumScoreReward.GetRootAsCircumScoreReward(_bb, default(CircumScoreReward));
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x00216CF0 File Offset: 0x00214EF0
		public static CircumScoreReward GetRootAsCircumScoreReward(ByteBuffer _bb, CircumScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x00216D0D File Offset: 0x00214F0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x00216D1C File Offset: 0x00214F1C
		public CircumScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06005BCE RID: 23502 RVA: 0x00216D2C File Offset: 0x00214F2C
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

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06005BCF RID: 23503 RVA: 0x00216D68 File Offset: 0x00214F68
		public int NeedScore
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

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06005BD0 RID: 23504 RVA: 0x00216DA4 File Offset: 0x00214FA4
		public int DropGroup
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

		// Token: 0x04005166 RID: 20838
		private Table __p;
	}
}
