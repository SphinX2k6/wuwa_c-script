using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C37 RID: 3127
	public struct BuffItemCdGroup : IFlatbufferObject
	{
		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060056E9 RID: 22249 RVA: 0x0020C34D File Offset: 0x0020A54D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060056EA RID: 22250 RVA: 0x0020C35A File Offset: 0x0020A55A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060056EB RID: 22251 RVA: 0x0020C364 File Offset: 0x0020A564
		public static BuffItemCdGroup GetRootAsBuffItemCdGroup(ByteBuffer _bb)
		{
			return BuffItemCdGroup.GetRootAsBuffItemCdGroup(_bb, default(BuffItemCdGroup));
		}

		// Token: 0x060056EC RID: 22252 RVA: 0x0020C380 File Offset: 0x0020A580
		public static BuffItemCdGroup GetRootAsBuffItemCdGroup(ByteBuffer _bb, BuffItemCdGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x0020C39D File Offset: 0x0020A59D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x0020C3AC File Offset: 0x0020A5AC
		public BuffItemCdGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060056EF RID: 22255 RVA: 0x0020C3BC File Offset: 0x0020A5BC
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

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060056F0 RID: 22256 RVA: 0x0020C3F8 File Offset: 0x0020A5F8
		public int CoolDownTime
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

		// Token: 0x04005134 RID: 20788
		private Table __p;
	}
}
