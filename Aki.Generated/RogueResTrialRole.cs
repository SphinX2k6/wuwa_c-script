using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001103 RID: 4355
	public struct RogueResTrialRole : IFlatbufferObject
	{
		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x0600CADC RID: 51932 RVA: 0x0030D2A0 File Offset: 0x0030B4A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CADD RID: 51933 RVA: 0x0030D2AD File Offset: 0x0030B4AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CADE RID: 51934 RVA: 0x0030D2B4 File Offset: 0x0030B4B4
		public static RogueResTrialRole GetRootAsRogueResTrialRole(ByteBuffer _bb)
		{
			return RogueResTrialRole.GetRootAsRogueResTrialRole(_bb, default(RogueResTrialRole));
		}

		// Token: 0x0600CADF RID: 51935 RVA: 0x0030D2D0 File Offset: 0x0030B4D0
		public static RogueResTrialRole GetRootAsRogueResTrialRole(ByteBuffer _bb, RogueResTrialRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CAE0 RID: 51936 RVA: 0x0030D2ED File Offset: 0x0030B4ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CAE1 RID: 51937 RVA: 0x0030D2FC File Offset: 0x0030B4FC
		public RogueResTrialRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x0600CAE2 RID: 51938 RVA: 0x0030D30C File Offset: 0x0030B50C
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

		// Token: 0x040056F3 RID: 22259
		private Table __p;
	}
}
