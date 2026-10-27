using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001114 RID: 4372
	public struct TakeWeedsDifficulty : IFlatbufferObject
	{
		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x0600DCBD RID: 56509 RVA: 0x003293A5 File Offset: 0x003275A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DCBE RID: 56510 RVA: 0x003293B2 File Offset: 0x003275B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DCBF RID: 56511 RVA: 0x003293BC File Offset: 0x003275BC
		public static TakeWeedsDifficulty GetRootAsTakeWeedsDifficulty(ByteBuffer _bb)
		{
			return TakeWeedsDifficulty.GetRootAsTakeWeedsDifficulty(_bb, default(TakeWeedsDifficulty));
		}

		// Token: 0x0600DCC0 RID: 56512 RVA: 0x003293D8 File Offset: 0x003275D8
		public static TakeWeedsDifficulty GetRootAsTakeWeedsDifficulty(ByteBuffer _bb, TakeWeedsDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DCC1 RID: 56513 RVA: 0x003293F5 File Offset: 0x003275F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DCC2 RID: 56514 RVA: 0x00329404 File Offset: 0x00327604
		public TakeWeedsDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x0600DCC3 RID: 56515 RVA: 0x00329414 File Offset: 0x00327614
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

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x0600DCC4 RID: 56516 RVA: 0x00329450 File Offset: 0x00327650
		public int Magnification
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

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x0600DCC5 RID: 56517 RVA: 0x0032948C File Offset: 0x0032768C
		public int RecommendedLevel
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

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x0600DCC6 RID: 56518 RVA: 0x003294C8 File Offset: 0x003276C8
		public int Reward
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

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0600DCC7 RID: 56519 RVA: 0x00329508 File Offset: 0x00327708
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DCC8 RID: 56520 RVA: 0x00329540 File Offset: 0x00327740
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DCC9 RID: 56521 RVA: 0x00329550 File Offset: 0x00327750
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005251 RID: 21073
		private Table __p;
	}
}
