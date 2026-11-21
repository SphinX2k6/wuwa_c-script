using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE2 RID: 3042
	public struct AreaTaskExplore : IFlatbufferObject
	{
		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06004E22 RID: 20002 RVA: 0x001F7DC0 File Offset: 0x001F5FC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x001F7DCD File Offset: 0x001F5FCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x001F7DD4 File Offset: 0x001F5FD4
		public static AreaTaskExplore GetRootAsAreaTaskExplore(ByteBuffer _bb)
		{
			return AreaTaskExplore.GetRootAsAreaTaskExplore(_bb, default(AreaTaskExplore));
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x001F7DF0 File Offset: 0x001F5FF0
		public static AreaTaskExplore GetRootAsAreaTaskExplore(ByteBuffer _bb, AreaTaskExplore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x001F7E0D File Offset: 0x001F600D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x001F7E1C File Offset: 0x001F601C
		public AreaTaskExplore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x001F7E2C File Offset: 0x001F602C
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

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06004E29 RID: 20009 RVA: 0x001F7E68 File Offset: 0x001F6068
		public int Area
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

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x001F7EA4 File Offset: 0x001F60A4
		public int SortIndex
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

		// Token: 0x040050C7 RID: 20679
		private Table __p;
	}
}
