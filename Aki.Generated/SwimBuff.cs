using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001246 RID: 4678
	public struct SwimBuff : IFlatbufferObject
	{
		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x0600E9BE RID: 59838 RVA: 0x00353A0C File Offset: 0x00351C0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9BF RID: 59839 RVA: 0x00353A19 File Offset: 0x00351C19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9C0 RID: 59840 RVA: 0x00353A20 File Offset: 0x00351C20
		public static SwimBuff GetRootAsSwimBuff(ByteBuffer _bb)
		{
			return SwimBuff.GetRootAsSwimBuff(_bb, default(SwimBuff));
		}

		// Token: 0x0600E9C1 RID: 59841 RVA: 0x00353A3C File Offset: 0x00351C3C
		public static SwimBuff GetRootAsSwimBuff(ByteBuffer _bb, SwimBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9C2 RID: 59842 RVA: 0x00353A59 File Offset: 0x00351C59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9C3 RID: 59843 RVA: 0x00353A68 File Offset: 0x00351C68
		public SwimBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x0600E9C4 RID: 59844 RVA: 0x00353A78 File Offset: 0x00351C78
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

		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x0600E9C5 RID: 59845 RVA: 0x00353AB4 File Offset: 0x00351CB4
		public int BuffId
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

		// Token: 0x04005890 RID: 22672
		private Table __p;
	}
}
