using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD8 RID: 4056
	public struct RogueAffixLibrary : IFlatbufferObject
	{
		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x0600BE26 RID: 48678 RVA: 0x002E2E71 File Offset: 0x002E1071
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE27 RID: 48679 RVA: 0x002E2E7E File Offset: 0x002E107E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE28 RID: 48680 RVA: 0x002E2E88 File Offset: 0x002E1088
		public static RogueAffixLibrary GetRootAsRogueAffixLibrary(ByteBuffer _bb)
		{
			return RogueAffixLibrary.GetRootAsRogueAffixLibrary(_bb, default(RogueAffixLibrary));
		}

		// Token: 0x0600BE29 RID: 48681 RVA: 0x002E2EA4 File Offset: 0x002E10A4
		public static RogueAffixLibrary GetRootAsRogueAffixLibrary(ByteBuffer _bb, RogueAffixLibrary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE2A RID: 48682 RVA: 0x002E2EC1 File Offset: 0x002E10C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE2B RID: 48683 RVA: 0x002E2ED0 File Offset: 0x002E10D0
		public RogueAffixLibrary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x0600BE2C RID: 48684 RVA: 0x002E2EE0 File Offset: 0x002E10E0
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

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x0600BE2D RID: 48685 RVA: 0x002E2F1C File Offset: 0x002E111C
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

		// Token: 0x040050B4 RID: 20660
		private Table __p;
	}
}
