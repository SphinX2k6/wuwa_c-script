using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C3 RID: 4547
	public struct DungeonEntrance : IFlatbufferObject
	{
		// Token: 0x17003EDE RID: 16094
		// (get) Token: 0x0600EA59 RID: 59993 RVA: 0x00347E69 File Offset: 0x00346069
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA5A RID: 59994 RVA: 0x00347E76 File Offset: 0x00346076
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA5B RID: 59995 RVA: 0x00347E80 File Offset: 0x00346080
		public static DungeonEntrance GetRootAsDungeonEntrance(ByteBuffer _bb)
		{
			return DungeonEntrance.GetRootAsDungeonEntrance(_bb, default(DungeonEntrance));
		}

		// Token: 0x0600EA5C RID: 59996 RVA: 0x00347E9C File Offset: 0x0034609C
		public static DungeonEntrance GetRootAsDungeonEntrance(ByteBuffer _bb, DungeonEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA5D RID: 59997 RVA: 0x00347EB9 File Offset: 0x003460B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA5E RID: 59998 RVA: 0x00347EC8 File Offset: 0x003460C8
		public DungeonEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EDF RID: 16095
		// (get) Token: 0x0600EA5F RID: 59999 RVA: 0x00347ED8 File Offset: 0x003460D8
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

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x0600EA60 RID: 60000 RVA: 0x00347F14 File Offset: 0x00346114
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

		// Token: 0x0400531C RID: 21276
		private Table __p;
	}
}
