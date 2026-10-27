using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001162 RID: 4450
	public struct TrapDefenseGoldenCoin : IFlatbufferObject
	{
		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x0600E39F RID: 58271 RVA: 0x00338BDC File Offset: 0x00336DDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E3A0 RID: 58272 RVA: 0x00338BE9 File Offset: 0x00336DE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E3A1 RID: 58273 RVA: 0x00338BF0 File Offset: 0x00336DF0
		public static TrapDefenseGoldenCoin GetRootAsTrapDefenseGoldenCoin(ByteBuffer _bb)
		{
			return TrapDefenseGoldenCoin.GetRootAsTrapDefenseGoldenCoin(_bb, default(TrapDefenseGoldenCoin));
		}

		// Token: 0x0600E3A2 RID: 58274 RVA: 0x00338C0C File Offset: 0x00336E0C
		public static TrapDefenseGoldenCoin GetRootAsTrapDefenseGoldenCoin(ByteBuffer _bb, TrapDefenseGoldenCoin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E3A3 RID: 58275 RVA: 0x00338C29 File Offset: 0x00336E29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E3A4 RID: 58276 RVA: 0x00338C38 File Offset: 0x00336E38
		public TrapDefenseGoldenCoin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x0600E3A5 RID: 58277 RVA: 0x00338C48 File Offset: 0x00336E48
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

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x0600E3A6 RID: 58278 RVA: 0x00338C84 File Offset: 0x00336E84
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

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x0600E3A7 RID: 58279 RVA: 0x00338CC0 File Offset: 0x00336EC0
		public int SimpleCombatSubtypeId
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

		// Token: 0x17003C2E RID: 15406
		// (get) Token: 0x0600E3A8 RID: 58280 RVA: 0x00338CFC File Offset: 0x00336EFC
		public int AbsorbGold
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

		// Token: 0x040052A8 RID: 21160
		private Table __p;
	}
}
