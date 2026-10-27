using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200116B RID: 4459
	public struct TrapDefenseMonsterType : IFlatbufferObject
	{
		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x0600E45A RID: 58458 RVA: 0x0033A461 File Offset: 0x00338661
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E45B RID: 58459 RVA: 0x0033A46E File Offset: 0x0033866E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E45C RID: 58460 RVA: 0x0033A478 File Offset: 0x00338678
		public static TrapDefenseMonsterType GetRootAsTrapDefenseMonsterType(ByteBuffer _bb)
		{
			return TrapDefenseMonsterType.GetRootAsTrapDefenseMonsterType(_bb, default(TrapDefenseMonsterType));
		}

		// Token: 0x0600E45D RID: 58461 RVA: 0x0033A494 File Offset: 0x00338694
		public static TrapDefenseMonsterType GetRootAsTrapDefenseMonsterType(ByteBuffer _bb, TrapDefenseMonsterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E45E RID: 58462 RVA: 0x0033A4B1 File Offset: 0x003386B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E45F RID: 58463 RVA: 0x0033A4C0 File Offset: 0x003386C0
		public TrapDefenseMonsterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x0600E460 RID: 58464 RVA: 0x0033A4D0 File Offset: 0x003386D0
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

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x0600E461 RID: 58465 RVA: 0x0033A50C File Offset: 0x0033870C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E462 RID: 58466 RVA: 0x0033A543 File Offset: 0x00338743
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E463 RID: 58467 RVA: 0x0033A552 File Offset: 0x00338752
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C6C RID: 15468
		// (get) Token: 0x0600E464 RID: 58468 RVA: 0x0033A56C File Offset: 0x0033876C
		public int TemplateId
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

		// Token: 0x17003C6D RID: 15469
		// (get) Token: 0x0600E465 RID: 58469 RVA: 0x0033A5A8 File Offset: 0x003387A8
		public int RiskType
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

		// Token: 0x17003C6E RID: 15470
		// (get) Token: 0x0600E466 RID: 58470 RVA: 0x0033A5E8 File Offset: 0x003387E8
		public int BodyType
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

		// Token: 0x17003C6F RID: 15471
		// (get) Token: 0x0600E467 RID: 58471 RVA: 0x0033A628 File Offset: 0x00338828
		public string Icon
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

		// Token: 0x0600E468 RID: 58472 RVA: 0x0033A660 File Offset: 0x00338860
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E469 RID: 58473 RVA: 0x0033A670 File Offset: 0x00338870
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040052B1 RID: 21169
		private Table __p;
	}
}
