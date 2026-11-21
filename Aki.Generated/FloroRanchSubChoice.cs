using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D96 RID: 3478
	public struct FloroRanchSubChoice : IFlatbufferObject
	{
		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06007A06 RID: 31238 RVA: 0x0025B7B4 File Offset: 0x002599B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A07 RID: 31239 RVA: 0x0025B7C1 File Offset: 0x002599C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A08 RID: 31240 RVA: 0x0025B7C8 File Offset: 0x002599C8
		public static FloroRanchSubChoice GetRootAsFloroRanchSubChoice(ByteBuffer _bb)
		{
			return FloroRanchSubChoice.GetRootAsFloroRanchSubChoice(_bb, default(FloroRanchSubChoice));
		}

		// Token: 0x06007A09 RID: 31241 RVA: 0x0025B7E4 File Offset: 0x002599E4
		public static FloroRanchSubChoice GetRootAsFloroRanchSubChoice(ByteBuffer _bb, FloroRanchSubChoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x0025B801 File Offset: 0x00259A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x0025B810 File Offset: 0x00259A10
		public FloroRanchSubChoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06007A0C RID: 31244 RVA: 0x0025B820 File Offset: 0x00259A20
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

		// Token: 0x040052FE RID: 21246
		private Table __p;
	}
}
