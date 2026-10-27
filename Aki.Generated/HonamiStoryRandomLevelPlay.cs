using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D4B RID: 3403
	public struct HonamiStoryRandomLevelPlay : IFlatbufferObject
	{
		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06008110 RID: 33040 RVA: 0x00259D3D File Offset: 0x00257F3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008111 RID: 33041 RVA: 0x00259D4A File Offset: 0x00257F4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008112 RID: 33042 RVA: 0x00259D54 File Offset: 0x00257F54
		public static HonamiStoryRandomLevelPlay GetRootAsHonamiStoryRandomLevelPlay(ByteBuffer _bb)
		{
			return HonamiStoryRandomLevelPlay.GetRootAsHonamiStoryRandomLevelPlay(_bb, default(HonamiStoryRandomLevelPlay));
		}

		// Token: 0x06008113 RID: 33043 RVA: 0x00259D70 File Offset: 0x00257F70
		public static HonamiStoryRandomLevelPlay GetRootAsHonamiStoryRandomLevelPlay(ByteBuffer _bb, HonamiStoryRandomLevelPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008114 RID: 33044 RVA: 0x00259D8D File Offset: 0x00257F8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008115 RID: 33045 RVA: 0x00259D9C File Offset: 0x00257F9C
		public HonamiStoryRandomLevelPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06008116 RID: 33046 RVA: 0x00259DAC File Offset: 0x00257FAC
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

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06008117 RID: 33047 RVA: 0x00259DE8 File Offset: 0x00257FE8
		public int Group
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

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06008118 RID: 33048 RVA: 0x00259E24 File Offset: 0x00258024
		public int BTId
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

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06008119 RID: 33049 RVA: 0x00259E60 File Offset: 0x00258060
		public int Weight
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

		// Token: 0x04004DC7 RID: 19911
		private Table __p;
	}
}
