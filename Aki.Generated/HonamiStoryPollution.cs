using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D47 RID: 3399
	public struct HonamiStoryPollution : IFlatbufferObject
	{
		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x060080E3 RID: 32995 RVA: 0x00259725 File Offset: 0x00257925
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080E4 RID: 32996 RVA: 0x00259732 File Offset: 0x00257932
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080E5 RID: 32997 RVA: 0x0025973C File Offset: 0x0025793C
		public static HonamiStoryPollution GetRootAsHonamiStoryPollution(ByteBuffer _bb)
		{
			return HonamiStoryPollution.GetRootAsHonamiStoryPollution(_bb, default(HonamiStoryPollution));
		}

		// Token: 0x060080E6 RID: 32998 RVA: 0x00259758 File Offset: 0x00257958
		public static HonamiStoryPollution GetRootAsHonamiStoryPollution(ByteBuffer _bb, HonamiStoryPollution obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080E7 RID: 32999 RVA: 0x00259775 File Offset: 0x00257975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080E8 RID: 33000 RVA: 0x00259784 File Offset: 0x00257984
		public HonamiStoryPollution __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x060080E9 RID: 33001 RVA: 0x00259794 File Offset: 0x00257994
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

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x060080EA RID: 33002 RVA: 0x002597D0 File Offset: 0x002579D0
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

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x060080EB RID: 33003 RVA: 0x0025980C File Offset: 0x00257A0C
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

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x060080EC RID: 33004 RVA: 0x00259848 File Offset: 0x00257A48
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

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x060080ED RID: 33005 RVA: 0x00259888 File Offset: 0x00257A88
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

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x060080EE RID: 33006 RVA: 0x002598C8 File Offset: 0x00257AC8
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

		// Token: 0x04004DC3 RID: 19907
		private Table __p;
	}
}
