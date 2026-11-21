using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001219 RID: 4633
	public struct SplashScreen : IFlatbufferObject
	{
		// Token: 0x17003B3E RID: 15166
		// (get) Token: 0x0600E570 RID: 58736 RVA: 0x00349E20 File Offset: 0x00348020
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E571 RID: 58737 RVA: 0x00349E2D File Offset: 0x0034802D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E572 RID: 58738 RVA: 0x00349E34 File Offset: 0x00348034
		public static SplashScreen GetRootAsSplashScreen(ByteBuffer _bb)
		{
			return SplashScreen.GetRootAsSplashScreen(_bb, default(SplashScreen));
		}

		// Token: 0x0600E573 RID: 58739 RVA: 0x00349E50 File Offset: 0x00348050
		public static SplashScreen GetRootAsSplashScreen(ByteBuffer _bb, SplashScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E574 RID: 58740 RVA: 0x00349E6D File Offset: 0x0034806D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E575 RID: 58741 RVA: 0x00349E7C File Offset: 0x0034807C
		public SplashScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B3F RID: 15167
		// (get) Token: 0x0600E576 RID: 58742 RVA: 0x00349E8C File Offset: 0x0034808C
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

		// Token: 0x17003B40 RID: 15168
		// (get) Token: 0x0600E577 RID: 58743 RVA: 0x00349EC8 File Offset: 0x003480C8
		public int Type
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

		// Token: 0x17003B41 RID: 15169
		// (get) Token: 0x0600E578 RID: 58744 RVA: 0x00349F04 File Offset: 0x00348104
		public bool InLongTaskQueue
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003B42 RID: 15170
		// (get) Token: 0x0600E579 RID: 58745 RVA: 0x00349F44 File Offset: 0x00348144
		public int Priority
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

		// Token: 0x04005859 RID: 22617
		private Table __p;
	}
}
