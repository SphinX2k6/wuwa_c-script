using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA6 RID: 3238
	public struct FloroRanchChoiceType : IFlatbufferObject
	{
		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x0600730F RID: 29455 RVA: 0x0023A705 File Offset: 0x00238905
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007310 RID: 29456 RVA: 0x0023A712 File Offset: 0x00238912
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007311 RID: 29457 RVA: 0x0023A71C File Offset: 0x0023891C
		public static FloroRanchChoiceType GetRootAsFloroRanchChoiceType(ByteBuffer _bb)
		{
			return FloroRanchChoiceType.GetRootAsFloroRanchChoiceType(_bb, default(FloroRanchChoiceType));
		}

		// Token: 0x06007312 RID: 29458 RVA: 0x0023A738 File Offset: 0x00238938
		public static FloroRanchChoiceType GetRootAsFloroRanchChoiceType(ByteBuffer _bb, FloroRanchChoiceType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007313 RID: 29459 RVA: 0x0023A755 File Offset: 0x00238955
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007314 RID: 29460 RVA: 0x0023A764 File Offset: 0x00238964
		public FloroRanchChoiceType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06007315 RID: 29461 RVA: 0x0023A774 File Offset: 0x00238974
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

		// Token: 0x04004D08 RID: 19720
		private Table __p;
	}
}
