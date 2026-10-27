using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ECD RID: 3789
	public struct PhantomBattleCountType : IFlatbufferObject
	{
		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x0600A6E2 RID: 42722 RVA: 0x002AF7D5 File Offset: 0x002AD9D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A6E3 RID: 42723 RVA: 0x002AF7E2 File Offset: 0x002AD9E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A6E4 RID: 42724 RVA: 0x002AF7EC File Offset: 0x002AD9EC
		public static PhantomBattleCountType GetRootAsPhantomBattleCountType(ByteBuffer _bb)
		{
			return PhantomBattleCountType.GetRootAsPhantomBattleCountType(_bb, default(PhantomBattleCountType));
		}

		// Token: 0x0600A6E5 RID: 42725 RVA: 0x002AF808 File Offset: 0x002ADA08
		public static PhantomBattleCountType GetRootAsPhantomBattleCountType(ByteBuffer _bb, PhantomBattleCountType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A6E6 RID: 42726 RVA: 0x002AF825 File Offset: 0x002ADA25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A6E7 RID: 42727 RVA: 0x002AF834 File Offset: 0x002ADA34
		public PhantomBattleCountType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x0600A6E8 RID: 42728 RVA: 0x002AF844 File Offset: 0x002ADA44
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

		// Token: 0x04004F8B RID: 20363
		private Table __p;
	}
}
