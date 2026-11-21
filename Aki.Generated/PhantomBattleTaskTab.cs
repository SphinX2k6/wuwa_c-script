using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC2 RID: 4034
	public struct PhantomBattleTaskTab : IFlatbufferObject
	{
		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x0600AE14 RID: 44564 RVA: 0x002CEC79 File Offset: 0x002CCE79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE15 RID: 44565 RVA: 0x002CEC86 File Offset: 0x002CCE86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE16 RID: 44566 RVA: 0x002CEC90 File Offset: 0x002CCE90
		public static PhantomBattleTaskTab GetRootAsPhantomBattleTaskTab(ByteBuffer _bb)
		{
			return PhantomBattleTaskTab.GetRootAsPhantomBattleTaskTab(_bb, default(PhantomBattleTaskTab));
		}

		// Token: 0x0600AE17 RID: 44567 RVA: 0x002CECAC File Offset: 0x002CCEAC
		public static PhantomBattleTaskTab GetRootAsPhantomBattleTaskTab(ByteBuffer _bb, PhantomBattleTaskTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE18 RID: 44568 RVA: 0x002CECC9 File Offset: 0x002CCEC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE19 RID: 44569 RVA: 0x002CECD8 File Offset: 0x002CCED8
		public PhantomBattleTaskTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x0600AE1A RID: 44570 RVA: 0x002CECE8 File Offset: 0x002CCEE8
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

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x0600AE1B RID: 44571 RVA: 0x002CED24 File Offset: 0x002CCF24
		public string Title
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

		// Token: 0x0600AE1C RID: 44572 RVA: 0x002CED5B File Offset: 0x002CCF5B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AE1D RID: 44573 RVA: 0x002CED6A File Offset: 0x002CCF6A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x0600AE1E RID: 44574 RVA: 0x002CED84 File Offset: 0x002CCF84
		public int Order
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

		// Token: 0x04005580 RID: 21888
		private Table __p;
	}
}
