using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200116F RID: 4463
	public struct TrapDefenseSpecialReward : IFlatbufferObject
	{
		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x0600E48A RID: 58506 RVA: 0x0033AACC File Offset: 0x00338CCC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E48B RID: 58507 RVA: 0x0033AAD9 File Offset: 0x00338CD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E48C RID: 58508 RVA: 0x0033AAE0 File Offset: 0x00338CE0
		public static TrapDefenseSpecialReward GetRootAsTrapDefenseSpecialReward(ByteBuffer _bb)
		{
			return TrapDefenseSpecialReward.GetRootAsTrapDefenseSpecialReward(_bb, default(TrapDefenseSpecialReward));
		}

		// Token: 0x0600E48D RID: 58509 RVA: 0x0033AAFC File Offset: 0x00338CFC
		public static TrapDefenseSpecialReward GetRootAsTrapDefenseSpecialReward(ByteBuffer _bb, TrapDefenseSpecialReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E48E RID: 58510 RVA: 0x0033AB19 File Offset: 0x00338D19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E48F RID: 58511 RVA: 0x0033AB28 File Offset: 0x00338D28
		public TrapDefenseSpecialReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x0600E490 RID: 58512 RVA: 0x0033AB38 File Offset: 0x00338D38
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

		// Token: 0x17003C81 RID: 15489
		// (get) Token: 0x0600E491 RID: 58513 RVA: 0x0033AB74 File Offset: 0x00338D74
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

		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x0600E492 RID: 58514 RVA: 0x0033ABB0 File Offset: 0x00338DB0
		public int RewardId
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

		// Token: 0x17003C83 RID: 15491
		// (get) Token: 0x0600E493 RID: 58515 RVA: 0x0033ABEC File Offset: 0x00338DEC
		public int Target
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C84 RID: 15492
		// (get) Token: 0x0600E494 RID: 58516 RVA: 0x0033AC2C File Offset: 0x00338E2C
		public int NeedItemId
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

		// Token: 0x17003C85 RID: 15493
		// (get) Token: 0x0600E495 RID: 58517 RVA: 0x0033AC6C File Offset: 0x00338E6C
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E496 RID: 58518 RVA: 0x0033ACA4 File Offset: 0x00338EA4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E497 RID: 58519 RVA: 0x0033ACB4 File Offset: 0x00338EB4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040052B5 RID: 21173
		private Table __p;
	}
}
