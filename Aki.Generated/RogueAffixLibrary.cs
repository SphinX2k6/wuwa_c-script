using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C0 RID: 4288
	public struct RogueAffixLibrary : IFlatbufferObject
	{
		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x0600C470 RID: 50288 RVA: 0x002FF41F File Offset: 0x002FD61F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C471 RID: 50289 RVA: 0x002FF42C File Offset: 0x002FD62C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C472 RID: 50290 RVA: 0x002FF434 File Offset: 0x002FD634
		public static RogueAffixLibrary GetRootAsRogueAffixLibrary(ByteBuffer _bb)
		{
			return RogueAffixLibrary.GetRootAsRogueAffixLibrary(_bb, default(RogueAffixLibrary));
		}

		// Token: 0x0600C473 RID: 50291 RVA: 0x002FF450 File Offset: 0x002FD650
		public static RogueAffixLibrary GetRootAsRogueAffixLibrary(ByteBuffer _bb, RogueAffixLibrary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C474 RID: 50292 RVA: 0x002FF46D File Offset: 0x002FD66D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C475 RID: 50293 RVA: 0x002FF47C File Offset: 0x002FD67C
		public RogueAffixLibrary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x0600C476 RID: 50294 RVA: 0x002FF48C File Offset: 0x002FD68C
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

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x0600C477 RID: 50295 RVA: 0x002FF4C8 File Offset: 0x002FD6C8
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

		// Token: 0x0400569C RID: 22172
		private Table __p;
	}
}
