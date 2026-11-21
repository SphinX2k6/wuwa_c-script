using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC8 RID: 4040
	public struct PhantomDirectRefining : IFlatbufferObject
	{
		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x0600AE75 RID: 44661 RVA: 0x002CFA84 File Offset: 0x002CDC84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE76 RID: 44662 RVA: 0x002CFA91 File Offset: 0x002CDC91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE77 RID: 44663 RVA: 0x002CFA98 File Offset: 0x002CDC98
		public static PhantomDirectRefining GetRootAsPhantomDirectRefining(ByteBuffer _bb)
		{
			return PhantomDirectRefining.GetRootAsPhantomDirectRefining(_bb, default(PhantomDirectRefining));
		}

		// Token: 0x0600AE78 RID: 44664 RVA: 0x002CFAB4 File Offset: 0x002CDCB4
		public static PhantomDirectRefining GetRootAsPhantomDirectRefining(ByteBuffer _bb, PhantomDirectRefining obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE79 RID: 44665 RVA: 0x002CFAD1 File Offset: 0x002CDCD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE7A RID: 44666 RVA: 0x002CFAE0 File Offset: 0x002CDCE0
		public PhantomDirectRefining __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002719 RID: 10009
		// (get) Token: 0x0600AE7B RID: 44667 RVA: 0x002CFAF0 File Offset: 0x002CDCF0
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

		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x0600AE7C RID: 44668 RVA: 0x002CFB2C File Offset: 0x002CDD2C
		public int FetterGroup
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

		// Token: 0x04005589 RID: 21897
		private Table __p;
	}
}
