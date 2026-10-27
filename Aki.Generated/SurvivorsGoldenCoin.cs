using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010FB RID: 4347
	public struct SurvivorsGoldenCoin : IFlatbufferObject
	{
		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x0600DA6A RID: 55914 RVA: 0x00323B28 File Offset: 0x00321D28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DA6B RID: 55915 RVA: 0x00323B35 File Offset: 0x00321D35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DA6C RID: 55916 RVA: 0x00323B3C File Offset: 0x00321D3C
		public static SurvivorsGoldenCoin GetRootAsSurvivorsGoldenCoin(ByteBuffer _bb)
		{
			return SurvivorsGoldenCoin.GetRootAsSurvivorsGoldenCoin(_bb, default(SurvivorsGoldenCoin));
		}

		// Token: 0x0600DA6D RID: 55917 RVA: 0x00323B58 File Offset: 0x00321D58
		public static SurvivorsGoldenCoin GetRootAsSurvivorsGoldenCoin(ByteBuffer _bb, SurvivorsGoldenCoin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DA6E RID: 55918 RVA: 0x00323B75 File Offset: 0x00321D75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DA6F RID: 55919 RVA: 0x00323B84 File Offset: 0x00321D84
		public SurvivorsGoldenCoin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x0600DA70 RID: 55920 RVA: 0x00323B94 File Offset: 0x00321D94
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

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x0600DA71 RID: 55921 RVA: 0x00323BD0 File Offset: 0x00321DD0
		public int TemplateId
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

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x0600DA72 RID: 55922 RVA: 0x00323C0C File Offset: 0x00321E0C
		public int CoinType
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

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x0600DA73 RID: 55923 RVA: 0x00323C48 File Offset: 0x00321E48
		public int SimpleCombatSubtypeId
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

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x0600DA74 RID: 55924 RVA: 0x00323C88 File Offset: 0x00321E88
		public int AbsorbGold
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

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x0600DA75 RID: 55925 RVA: 0x00323CC8 File Offset: 0x00321EC8
		public int Effect
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

		// Token: 0x04005231 RID: 21041
		private Table __p;
	}
}
