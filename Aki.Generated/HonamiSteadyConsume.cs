using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E11 RID: 3601
	public struct HonamiSteadyConsume : IFlatbufferObject
	{
		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x060084B1 RID: 33969 RVA: 0x00272B78 File Offset: 0x00270D78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060084B2 RID: 33970 RVA: 0x00272B85 File Offset: 0x00270D85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060084B3 RID: 33971 RVA: 0x00272B8C File Offset: 0x00270D8C
		public static HonamiSteadyConsume GetRootAsHonamiSteadyConsume(ByteBuffer _bb)
		{
			return HonamiSteadyConsume.GetRootAsHonamiSteadyConsume(_bb, default(HonamiSteadyConsume));
		}

		// Token: 0x060084B4 RID: 33972 RVA: 0x00272BA8 File Offset: 0x00270DA8
		public static HonamiSteadyConsume GetRootAsHonamiSteadyConsume(ByteBuffer _bb, HonamiSteadyConsume obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060084B5 RID: 33973 RVA: 0x00272BC5 File Offset: 0x00270DC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060084B6 RID: 33974 RVA: 0x00272BD4 File Offset: 0x00270DD4
		public HonamiSteadyConsume __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x060084B7 RID: 33975 RVA: 0x00272BE4 File Offset: 0x00270DE4
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

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x060084B8 RID: 33976 RVA: 0x00272C20 File Offset: 0x00270E20
		public int CostGroup
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

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x060084B9 RID: 33977 RVA: 0x00272C5C File Offset: 0x00270E5C
		public int DangerLevel
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

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x060084BA RID: 33978 RVA: 0x00272C98 File Offset: 0x00270E98
		public int SteadyConsume
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

		// Token: 0x04005389 RID: 21385
		private Table __p;
	}
}
