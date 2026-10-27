using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FEA RID: 4074
	public struct RoguePopularEntrieArg : IFlatbufferObject
	{
		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x0600C02F RID: 49199 RVA: 0x002E7844 File Offset: 0x002E5A44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C030 RID: 49200 RVA: 0x002E7851 File Offset: 0x002E5A51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C031 RID: 49201 RVA: 0x002E7858 File Offset: 0x002E5A58
		public static RoguePopularEntrieArg GetRootAsRoguePopularEntrieArg(ByteBuffer _bb)
		{
			return RoguePopularEntrieArg.GetRootAsRoguePopularEntrieArg(_bb, default(RoguePopularEntrieArg));
		}

		// Token: 0x0600C032 RID: 49202 RVA: 0x002E7874 File Offset: 0x002E5A74
		public static RoguePopularEntrieArg GetRootAsRoguePopularEntrieArg(ByteBuffer _bb, RoguePopularEntrieArg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C033 RID: 49203 RVA: 0x002E7891 File Offset: 0x002E5A91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C034 RID: 49204 RVA: 0x002E78A0 File Offset: 0x002E5AA0
		public RoguePopularEntrieArg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x0600C035 RID: 49205 RVA: 0x002E78B0 File Offset: 0x002E5AB0
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

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x0600C036 RID: 49206 RVA: 0x002E78EC File Offset: 0x002E5AEC
		public int SeasonId
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

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x0600C037 RID: 49207 RVA: 0x002E7928 File Offset: 0x002E5B28
		public int InstId
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

		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x0600C038 RID: 49208 RVA: 0x002E7964 File Offset: 0x002E5B64
		public int Slot
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

		// Token: 0x040050CB RID: 20683
		private Table __p;
	}
}
