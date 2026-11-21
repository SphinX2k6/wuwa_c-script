using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D5 RID: 4309
	public struct RogueResAffixLibrary : IFlatbufferObject
	{
		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x0600C6B3 RID: 50867 RVA: 0x003042A7 File Offset: 0x003024A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C6B4 RID: 50868 RVA: 0x003042B4 File Offset: 0x003024B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C6B5 RID: 50869 RVA: 0x003042BC File Offset: 0x003024BC
		public static RogueResAffixLibrary GetRootAsRogueResAffixLibrary(ByteBuffer _bb)
		{
			return RogueResAffixLibrary.GetRootAsRogueResAffixLibrary(_bb, default(RogueResAffixLibrary));
		}

		// Token: 0x0600C6B6 RID: 50870 RVA: 0x003042D8 File Offset: 0x003024D8
		public static RogueResAffixLibrary GetRootAsRogueResAffixLibrary(ByteBuffer _bb, RogueResAffixLibrary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C6B7 RID: 50871 RVA: 0x003042F5 File Offset: 0x003024F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C6B8 RID: 50872 RVA: 0x00304304 File Offset: 0x00302504
		public RogueResAffixLibrary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x0600C6B9 RID: 50873 RVA: 0x00304314 File Offset: 0x00302514
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

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x0600C6BA RID: 50874 RVA: 0x00304350 File Offset: 0x00302550
		public int AffixId
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

		// Token: 0x040056B6 RID: 22198
		private Table __p;
	}
}
