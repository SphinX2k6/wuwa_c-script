using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FED RID: 4077
	public struct RogueResAffixLibrary : IFlatbufferObject
	{
		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x0600C069 RID: 49257 RVA: 0x002E7F81 File Offset: 0x002E6181
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C06A RID: 49258 RVA: 0x002E7F8E File Offset: 0x002E618E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C06B RID: 49259 RVA: 0x002E7F98 File Offset: 0x002E6198
		public static RogueResAffixLibrary GetRootAsRogueResAffixLibrary(ByteBuffer _bb)
		{
			return RogueResAffixLibrary.GetRootAsRogueResAffixLibrary(_bb, default(RogueResAffixLibrary));
		}

		// Token: 0x0600C06C RID: 49260 RVA: 0x002E7FB4 File Offset: 0x002E61B4
		public static RogueResAffixLibrary GetRootAsRogueResAffixLibrary(ByteBuffer _bb, RogueResAffixLibrary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C06D RID: 49261 RVA: 0x002E7FD1 File Offset: 0x002E61D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C06E RID: 49262 RVA: 0x002E7FE0 File Offset: 0x002E61E0
		public RogueResAffixLibrary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x0600C06F RID: 49263 RVA: 0x002E7FF0 File Offset: 0x002E61F0
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

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x0600C070 RID: 49264 RVA: 0x002E802C File Offset: 0x002E622C
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

		// Token: 0x040050CE RID: 20686
		private Table __p;
	}
}
