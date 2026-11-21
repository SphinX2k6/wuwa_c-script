using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D8 RID: 4312
	public struct RogueResBondPool : IFlatbufferObject
	{
		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x0600C717 RID: 50967 RVA: 0x003053D1 File Offset: 0x003035D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C718 RID: 50968 RVA: 0x003053DE File Offset: 0x003035DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C719 RID: 50969 RVA: 0x003053E8 File Offset: 0x003035E8
		public static RogueResBondPool GetRootAsRogueResBondPool(ByteBuffer _bb)
		{
			return RogueResBondPool.GetRootAsRogueResBondPool(_bb, default(RogueResBondPool));
		}

		// Token: 0x0600C71A RID: 50970 RVA: 0x00305404 File Offset: 0x00303604
		public static RogueResBondPool GetRootAsRogueResBondPool(ByteBuffer _bb, RogueResBondPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C71B RID: 50971 RVA: 0x00305421 File Offset: 0x00303621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C71C RID: 50972 RVA: 0x00305430 File Offset: 0x00303630
		public RogueResBondPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x0600C71D RID: 50973 RVA: 0x00305440 File Offset: 0x00303640
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

		// Token: 0x040056BF RID: 22207
		private Table __p;
	}
}
