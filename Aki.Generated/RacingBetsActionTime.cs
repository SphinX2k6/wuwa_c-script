using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200106E RID: 4206
	public struct RacingBetsActionTime : IFlatbufferObject
	{
		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x0600BE1E RID: 48670 RVA: 0x002F15D0 File Offset: 0x002EF7D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE1F RID: 48671 RVA: 0x002F15DD File Offset: 0x002EF7DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE20 RID: 48672 RVA: 0x002F15E4 File Offset: 0x002EF7E4
		public static RacingBetsActionTime GetRootAsRacingBetsActionTime(ByteBuffer _bb)
		{
			return RacingBetsActionTime.GetRootAsRacingBetsActionTime(_bb, default(RacingBetsActionTime));
		}

		// Token: 0x0600BE21 RID: 48673 RVA: 0x002F1600 File Offset: 0x002EF800
		public static RacingBetsActionTime GetRootAsRacingBetsActionTime(ByteBuffer _bb, RacingBetsActionTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE22 RID: 48674 RVA: 0x002F161D File Offset: 0x002EF81D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE23 RID: 48675 RVA: 0x002F162C File Offset: 0x002EF82C
		public RacingBetsActionTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x0600BE24 RID: 48676 RVA: 0x002F163C File Offset: 0x002EF83C
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

		// Token: 0x0400563C RID: 22076
		private Table __p;
	}
}
