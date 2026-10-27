using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF2 RID: 4082
	public struct RogueResBondShop : IFlatbufferObject
	{
		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x0600C0E2 RID: 49378 RVA: 0x002E9329 File Offset: 0x002E7529
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C0E3 RID: 49379 RVA: 0x002E9336 File Offset: 0x002E7536
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C0E4 RID: 49380 RVA: 0x002E9340 File Offset: 0x002E7540
		public static RogueResBondShop GetRootAsRogueResBondShop(ByteBuffer _bb)
		{
			return RogueResBondShop.GetRootAsRogueResBondShop(_bb, default(RogueResBondShop));
		}

		// Token: 0x0600C0E5 RID: 49381 RVA: 0x002E935C File Offset: 0x002E755C
		public static RogueResBondShop GetRootAsRogueResBondShop(ByteBuffer _bb, RogueResBondShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C0E6 RID: 49382 RVA: 0x002E9379 File Offset: 0x002E7579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C0E7 RID: 49383 RVA: 0x002E9388 File Offset: 0x002E7588
		public RogueResBondShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x0600C0E8 RID: 49384 RVA: 0x002E9398 File Offset: 0x002E7598
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

		// Token: 0x040050D9 RID: 20697
		private Table __p;
	}
}
