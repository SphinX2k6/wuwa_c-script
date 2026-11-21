using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001305 RID: 4869
	public struct IntRange : IFlatbufferObject
	{
		// Token: 0x17004258 RID: 16984
		// (get) Token: 0x0600F81A RID: 63514 RVA: 0x0037340C File Offset: 0x0037160C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F81B RID: 63515 RVA: 0x00373419 File Offset: 0x00371619
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F81C RID: 63516 RVA: 0x00373420 File Offset: 0x00371620
		public static IntRange GetRootAsIntRange(ByteBuffer _bb)
		{
			return IntRange.GetRootAsIntRange(_bb, default(IntRange));
		}

		// Token: 0x0600F81D RID: 63517 RVA: 0x0037343C File Offset: 0x0037163C
		public static IntRange GetRootAsIntRange(ByteBuffer _bb, IntRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F81E RID: 63518 RVA: 0x00373459 File Offset: 0x00371659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F81F RID: 63519 RVA: 0x00373468 File Offset: 0x00371668
		public IntRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004259 RID: 16985
		// (get) Token: 0x0600F820 RID: 63520 RVA: 0x00373478 File Offset: 0x00371678
		public int Min
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

		// Token: 0x1700425A RID: 16986
		// (get) Token: 0x0600F821 RID: 63521 RVA: 0x003734B4 File Offset: 0x003716B4
		public int Max
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

		// Token: 0x04005980 RID: 22912
		private Table __p;
	}
}
