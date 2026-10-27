using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED9 RID: 3801
	public struct PhantomBattleRecord : IFlatbufferObject
	{
		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x0600A7B6 RID: 42934 RVA: 0x002B137D File Offset: 0x002AF57D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A7B7 RID: 42935 RVA: 0x002B138A File Offset: 0x002AF58A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A7B8 RID: 42936 RVA: 0x002B1394 File Offset: 0x002AF594
		public static PhantomBattleRecord GetRootAsPhantomBattleRecord(ByteBuffer _bb)
		{
			return PhantomBattleRecord.GetRootAsPhantomBattleRecord(_bb, default(PhantomBattleRecord));
		}

		// Token: 0x0600A7B9 RID: 42937 RVA: 0x002B13B0 File Offset: 0x002AF5B0
		public static PhantomBattleRecord GetRootAsPhantomBattleRecord(ByteBuffer _bb, PhantomBattleRecord obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A7BA RID: 42938 RVA: 0x002B13CD File Offset: 0x002AF5CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A7BB RID: 42939 RVA: 0x002B13DC File Offset: 0x002AF5DC
		public PhantomBattleRecord __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x0600A7BC RID: 42940 RVA: 0x002B13EC File Offset: 0x002AF5EC
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

		// Token: 0x04004F97 RID: 20375
		private Table __p;
	}
}
