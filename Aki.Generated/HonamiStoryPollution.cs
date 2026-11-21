using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E2C RID: 3628
	public struct HonamiStoryPollution : IFlatbufferObject
	{
		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x060086FD RID: 34557 RVA: 0x00277F21 File Offset: 0x00276121
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060086FE RID: 34558 RVA: 0x00277F2E File Offset: 0x0027612E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060086FF RID: 34559 RVA: 0x00277F38 File Offset: 0x00276138
		public static HonamiStoryPollution GetRootAsHonamiStoryPollution(ByteBuffer _bb)
		{
			return HonamiStoryPollution.GetRootAsHonamiStoryPollution(_bb, default(HonamiStoryPollution));
		}

		// Token: 0x06008700 RID: 34560 RVA: 0x00277F54 File Offset: 0x00276154
		public static HonamiStoryPollution GetRootAsHonamiStoryPollution(ByteBuffer _bb, HonamiStoryPollution obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008701 RID: 34561 RVA: 0x00277F71 File Offset: 0x00276171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008702 RID: 34562 RVA: 0x00277F80 File Offset: 0x00276180
		public HonamiStoryPollution __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06008703 RID: 34563 RVA: 0x00277F90 File Offset: 0x00276190
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

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x06008704 RID: 34564 RVA: 0x00277FCC File Offset: 0x002761CC
		public int ActivityId
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

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x06008705 RID: 34565 RVA: 0x00278008 File Offset: 0x00276208
		public int Group
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

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x06008706 RID: 34566 RVA: 0x00278044 File Offset: 0x00276244
		public int Level
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

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06008707 RID: 34567 RVA: 0x00278084 File Offset: 0x00276284
		public int PersistSecond
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06008708 RID: 34568 RVA: 0x002780C4 File Offset: 0x002762C4
		public int MonsterEnhanceLevel
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040053A8 RID: 21416
		private Table __p;
	}
}
