using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012FD RID: 4861
	public struct FloatRange : IFlatbufferObject
	{
		// Token: 0x17004248 RID: 16968
		// (get) Token: 0x0600F7DE RID: 63454 RVA: 0x00372CFA File Offset: 0x00370EFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F7DF RID: 63455 RVA: 0x00372D07 File Offset: 0x00370F07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F7E0 RID: 63456 RVA: 0x00372D10 File Offset: 0x00370F10
		public static FloatRange GetRootAsFloatRange(ByteBuffer _bb)
		{
			return FloatRange.GetRootAsFloatRange(_bb, default(FloatRange));
		}

		// Token: 0x0600F7E1 RID: 63457 RVA: 0x00372D2C File Offset: 0x00370F2C
		public static FloatRange GetRootAsFloatRange(ByteBuffer _bb, FloatRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F7E2 RID: 63458 RVA: 0x00372D49 File Offset: 0x00370F49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F7E3 RID: 63459 RVA: 0x00372D58 File Offset: 0x00370F58
		public FloatRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004249 RID: 16969
		// (get) Token: 0x0600F7E4 RID: 63460 RVA: 0x00372D68 File Offset: 0x00370F68
		public float Min
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700424A RID: 16970
		// (get) Token: 0x0600F7E5 RID: 63461 RVA: 0x00372DA8 File Offset: 0x00370FA8
		public float Max
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400596D RID: 22893
		private Table __p;
	}
}
