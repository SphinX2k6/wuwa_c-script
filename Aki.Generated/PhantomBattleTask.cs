using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EDC RID: 3804
	public struct PhantomBattleTask : IFlatbufferObject
	{
		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x0600A7E4 RID: 42980 RVA: 0x002B1993 File Offset: 0x002AFB93
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A7E5 RID: 42981 RVA: 0x002B19A0 File Offset: 0x002AFBA0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A7E6 RID: 42982 RVA: 0x002B19A8 File Offset: 0x002AFBA8
		public static PhantomBattleTask GetRootAsPhantomBattleTask(ByteBuffer _bb)
		{
			return PhantomBattleTask.GetRootAsPhantomBattleTask(_bb, default(PhantomBattleTask));
		}

		// Token: 0x0600A7E7 RID: 42983 RVA: 0x002B19C4 File Offset: 0x002AFBC4
		public static PhantomBattleTask GetRootAsPhantomBattleTask(ByteBuffer _bb, PhantomBattleTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A7E8 RID: 42984 RVA: 0x002B19E1 File Offset: 0x002AFBE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A7E9 RID: 42985 RVA: 0x002B19F0 File Offset: 0x002AFBF0
		public PhantomBattleTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x0600A7EA RID: 42986 RVA: 0x002B1A00 File Offset: 0x002AFC00
		public int TaskId
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

		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x0600A7EB RID: 42987 RVA: 0x002B1A3C File Offset: 0x002AFC3C
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

		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x0600A7EC RID: 42988 RVA: 0x002B1A78 File Offset: 0x002AFC78
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A7ED RID: 42989 RVA: 0x002B1AAF File Offset: 0x002AFCAF
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A7EE RID: 42990 RVA: 0x002B1ABE File Offset: 0x002AFCBE
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x0600A7EF RID: 42991 RVA: 0x002B1AD8 File Offset: 0x002AFCD8
		public int LimitShopItemNum
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

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x0600A7F0 RID: 42992 RVA: 0x002B1B18 File Offset: 0x002AFD18
		public int NormalDropId
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

		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x0600A7F1 RID: 42993 RVA: 0x002B1B58 File Offset: 0x002AFD58
		public int AccessPath
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

		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x0600A7F2 RID: 42994 RVA: 0x002B1B98 File Offset: 0x002AFD98
		public int TaskType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004F9A RID: 20378
		private Table __p;
	}
}
