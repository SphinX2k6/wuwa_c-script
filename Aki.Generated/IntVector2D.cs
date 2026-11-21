using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001307 RID: 4871
	public struct IntVector2D : IFlatbufferObject
	{
		// Token: 0x1700425F RID: 16991
		// (get) Token: 0x0600F82B RID: 63531 RVA: 0x00373610 File Offset: 0x00371810
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F82C RID: 63532 RVA: 0x0037361D File Offset: 0x0037181D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F82D RID: 63533 RVA: 0x00373624 File Offset: 0x00371824
		public static IntVector2D GetRootAsIntVector2D(ByteBuffer _bb)
		{
			return IntVector2D.GetRootAsIntVector2D(_bb, default(IntVector2D));
		}

		// Token: 0x0600F82E RID: 63534 RVA: 0x00373640 File Offset: 0x00371840
		public static IntVector2D GetRootAsIntVector2D(ByteBuffer _bb, IntVector2D obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F82F RID: 63535 RVA: 0x0037365D File Offset: 0x0037185D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F830 RID: 63536 RVA: 0x0037366C File Offset: 0x0037186C
		public IntVector2D __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004260 RID: 16992
		// (get) Token: 0x0600F831 RID: 63537 RVA: 0x0037367C File Offset: 0x0037187C
		public int X
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

		// Token: 0x17004261 RID: 16993
		// (get) Token: 0x0600F832 RID: 63538 RVA: 0x003736B8 File Offset: 0x003718B8
		public int Y
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

		// Token: 0x04005982 RID: 22914
		private Table __p;
	}
}
