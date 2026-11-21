using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001076 RID: 4214
	public struct RacingBetsResetPoint : IFlatbufferObject
	{
		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x0600BED4 RID: 48852 RVA: 0x002F2DB8 File Offset: 0x002F0FB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BED5 RID: 48853 RVA: 0x002F2DC5 File Offset: 0x002F0FC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BED6 RID: 48854 RVA: 0x002F2DCC File Offset: 0x002F0FCC
		public static RacingBetsResetPoint GetRootAsRacingBetsResetPoint(ByteBuffer _bb)
		{
			return RacingBetsResetPoint.GetRootAsRacingBetsResetPoint(_bb, default(RacingBetsResetPoint));
		}

		// Token: 0x0600BED7 RID: 48855 RVA: 0x002F2DE8 File Offset: 0x002F0FE8
		public static RacingBetsResetPoint GetRootAsRacingBetsResetPoint(ByteBuffer _bb, RacingBetsResetPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BED8 RID: 48856 RVA: 0x002F2E05 File Offset: 0x002F1005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BED9 RID: 48857 RVA: 0x002F2E14 File Offset: 0x002F1014
		public RacingBetsResetPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x0600BEDA RID: 48858 RVA: 0x002F2E24 File Offset: 0x002F1024
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

		// Token: 0x04005645 RID: 22085
		private Table __p;
	}
}
