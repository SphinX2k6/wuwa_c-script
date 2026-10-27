using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200100E RID: 4110
	public struct RogueResPopularEntrieArg : IFlatbufferObject
	{
		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x0600C38E RID: 50062 RVA: 0x002EEF8C File Offset: 0x002ED18C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C38F RID: 50063 RVA: 0x002EEF99 File Offset: 0x002ED199
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C390 RID: 50064 RVA: 0x002EEFA0 File Offset: 0x002ED1A0
		public static RogueResPopularEntrieArg GetRootAsRogueResPopularEntrieArg(ByteBuffer _bb)
		{
			return RogueResPopularEntrieArg.GetRootAsRogueResPopularEntrieArg(_bb, default(RogueResPopularEntrieArg));
		}

		// Token: 0x0600C391 RID: 50065 RVA: 0x002EEFBC File Offset: 0x002ED1BC
		public static RogueResPopularEntrieArg GetRootAsRogueResPopularEntrieArg(ByteBuffer _bb, RogueResPopularEntrieArg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C392 RID: 50066 RVA: 0x002EEFD9 File Offset: 0x002ED1D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C393 RID: 50067 RVA: 0x002EEFE8 File Offset: 0x002ED1E8
		public RogueResPopularEntrieArg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x0600C394 RID: 50068 RVA: 0x002EEFF8 File Offset: 0x002ED1F8
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

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x0600C395 RID: 50069 RVA: 0x002EF034 File Offset: 0x002ED234
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

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x0600C396 RID: 50070 RVA: 0x002EF070 File Offset: 0x002ED270
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

		// Token: 0x170030AA RID: 12458
		// (get) Token: 0x0600C397 RID: 50071 RVA: 0x002EF0AC File Offset: 0x002ED2AC
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

		// Token: 0x040050FB RID: 20731
		private Table __p;
	}
}
