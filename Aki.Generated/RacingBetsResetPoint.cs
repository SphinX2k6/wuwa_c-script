using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F8F RID: 3983
	public struct RacingBetsResetPoint : IFlatbufferObject
	{
		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x0600B897 RID: 47255 RVA: 0x002D6508 File Offset: 0x002D4708
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B898 RID: 47256 RVA: 0x002D6515 File Offset: 0x002D4715
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B899 RID: 47257 RVA: 0x002D651C File Offset: 0x002D471C
		public static RacingBetsResetPoint GetRootAsRacingBetsResetPoint(ByteBuffer _bb)
		{
			return RacingBetsResetPoint.GetRootAsRacingBetsResetPoint(_bb, default(RacingBetsResetPoint));
		}

		// Token: 0x0600B89A RID: 47258 RVA: 0x002D6538 File Offset: 0x002D4738
		public static RacingBetsResetPoint GetRootAsRacingBetsResetPoint(ByteBuffer _bb, RacingBetsResetPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B89B RID: 47259 RVA: 0x002D6555 File Offset: 0x002D4755
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B89C RID: 47260 RVA: 0x002D6564 File Offset: 0x002D4764
		public RacingBetsResetPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x0600B89D RID: 47261 RVA: 0x002D6574 File Offset: 0x002D4774
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

		// Token: 0x0400505E RID: 20574
		private Table __p;
	}
}
