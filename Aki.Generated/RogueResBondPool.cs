using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF0 RID: 4080
	public struct RogueResBondPool : IFlatbufferObject
	{
		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x0600C0CD RID: 49357 RVA: 0x002E90CD File Offset: 0x002E72CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C0CE RID: 49358 RVA: 0x002E90DA File Offset: 0x002E72DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C0CF RID: 49359 RVA: 0x002E90E4 File Offset: 0x002E72E4
		public static RogueResBondPool GetRootAsRogueResBondPool(ByteBuffer _bb)
		{
			return RogueResBondPool.GetRootAsRogueResBondPool(_bb, default(RogueResBondPool));
		}

		// Token: 0x0600C0D0 RID: 49360 RVA: 0x002E9100 File Offset: 0x002E7300
		public static RogueResBondPool GetRootAsRogueResBondPool(ByteBuffer _bb, RogueResBondPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C0D1 RID: 49361 RVA: 0x002E911D File Offset: 0x002E731D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C0D2 RID: 49362 RVA: 0x002E912C File Offset: 0x002E732C
		public RogueResBondPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x0600C0D3 RID: 49363 RVA: 0x002E913C File Offset: 0x002E733C
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

		// Token: 0x040050D7 RID: 20695
		private Table __p;
	}
}
