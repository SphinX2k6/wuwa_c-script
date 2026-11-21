using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012F9 RID: 4857
	public struct DungeonEntrance : IFlatbufferObject
	{
		// Token: 0x17004243 RID: 16963
		// (get) Token: 0x0600F7CA RID: 63434 RVA: 0x00372AF5 File Offset: 0x00370CF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F7CB RID: 63435 RVA: 0x00372B02 File Offset: 0x00370D02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F7CC RID: 63436 RVA: 0x00372B0C File Offset: 0x00370D0C
		public static DungeonEntrance GetRootAsDungeonEntrance(ByteBuffer _bb)
		{
			return DungeonEntrance.GetRootAsDungeonEntrance(_bb, default(DungeonEntrance));
		}

		// Token: 0x0600F7CD RID: 63437 RVA: 0x00372B28 File Offset: 0x00370D28
		public static DungeonEntrance GetRootAsDungeonEntrance(ByteBuffer _bb, DungeonEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F7CE RID: 63438 RVA: 0x00372B45 File Offset: 0x00370D45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F7CF RID: 63439 RVA: 0x00372B54 File Offset: 0x00370D54
		public DungeonEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004244 RID: 16964
		// (get) Token: 0x0600F7D0 RID: 63440 RVA: 0x00372B64 File Offset: 0x00370D64
		public int DungeonId
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

		// Token: 0x17004245 RID: 16965
		// (get) Token: 0x0600F7D1 RID: 63441 RVA: 0x00372BA0 File Offset: 0x00370DA0
		public int EntranceEntityId
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

		// Token: 0x0400595F RID: 22879
		private Table __p;
	}
}
