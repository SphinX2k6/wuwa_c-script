using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001269 RID: 4713
	public struct TotalTopUpScore : IFlatbufferObject
	{
		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x0600ECB4 RID: 60596 RVA: 0x0035A2F0 File Offset: 0x003584F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ECB5 RID: 60597 RVA: 0x0035A2FD File Offset: 0x003584FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ECB6 RID: 60598 RVA: 0x0035A304 File Offset: 0x00358504
		public static TotalTopUpScore GetRootAsTotalTopUpScore(ByteBuffer _bb)
		{
			return TotalTopUpScore.GetRootAsTotalTopUpScore(_bb, default(TotalTopUpScore));
		}

		// Token: 0x0600ECB7 RID: 60599 RVA: 0x0035A320 File Offset: 0x00358520
		public static TotalTopUpScore GetRootAsTotalTopUpScore(ByteBuffer _bb, TotalTopUpScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ECB8 RID: 60600 RVA: 0x0035A33D File Offset: 0x0035853D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ECB9 RID: 60601 RVA: 0x0035A34C File Offset: 0x0035854C
		public TotalTopUpScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DFD RID: 15869
		// (get) Token: 0x0600ECBA RID: 60602 RVA: 0x0035A35C File Offset: 0x0035855C
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

		// Token: 0x17003DFE RID: 15870
		// (get) Token: 0x0600ECBB RID: 60603 RVA: 0x0035A398 File Offset: 0x00358598
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

		// Token: 0x040058B7 RID: 22711
		private Table __p;
	}
}
