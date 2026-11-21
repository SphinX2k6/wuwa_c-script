using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001231 RID: 4657
	public struct SurvivorsGoldenCoin : IFlatbufferObject
	{
		// Token: 0x17003C17 RID: 15383
		// (get) Token: 0x0600E7B5 RID: 59317 RVA: 0x0034EEFC File Offset: 0x0034D0FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E7B6 RID: 59318 RVA: 0x0034EF09 File Offset: 0x0034D109
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E7B7 RID: 59319 RVA: 0x0034EF10 File Offset: 0x0034D110
		public static SurvivorsGoldenCoin GetRootAsSurvivorsGoldenCoin(ByteBuffer _bb)
		{
			return SurvivorsGoldenCoin.GetRootAsSurvivorsGoldenCoin(_bb, default(SurvivorsGoldenCoin));
		}

		// Token: 0x0600E7B8 RID: 59320 RVA: 0x0034EF2C File Offset: 0x0034D12C
		public static SurvivorsGoldenCoin GetRootAsSurvivorsGoldenCoin(ByteBuffer _bb, SurvivorsGoldenCoin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E7B9 RID: 59321 RVA: 0x0034EF49 File Offset: 0x0034D149
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E7BA RID: 59322 RVA: 0x0034EF58 File Offset: 0x0034D158
		public SurvivorsGoldenCoin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C18 RID: 15384
		// (get) Token: 0x0600E7BB RID: 59323 RVA: 0x0034EF68 File Offset: 0x0034D168
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

		// Token: 0x17003C19 RID: 15385
		// (get) Token: 0x0600E7BC RID: 59324 RVA: 0x0034EFA4 File Offset: 0x0034D1A4
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

		// Token: 0x17003C1A RID: 15386
		// (get) Token: 0x0600E7BD RID: 59325 RVA: 0x0034EFE0 File Offset: 0x0034D1E0
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

		// Token: 0x17003C1B RID: 15387
		// (get) Token: 0x0600E7BE RID: 59326 RVA: 0x0034F01C File Offset: 0x0034D21C
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

		// Token: 0x17003C1C RID: 15388
		// (get) Token: 0x0600E7BF RID: 59327 RVA: 0x0034F05C File Offset: 0x0034D25C
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

		// Token: 0x17003C1D RID: 15389
		// (get) Token: 0x0600E7C0 RID: 59328 RVA: 0x0034F09C File Offset: 0x0034D29C
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

		// Token: 0x04005874 RID: 22644
		private Table __p;
	}
}
