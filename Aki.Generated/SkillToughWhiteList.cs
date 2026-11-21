using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C0 RID: 4544
	public struct SkillToughWhiteList : IFlatbufferObject
	{
		// Token: 0x17003804 RID: 14340
		// (get) Token: 0x0600DD5F RID: 56671 RVA: 0x00337878 File Offset: 0x00335A78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD60 RID: 56672 RVA: 0x00337885 File Offset: 0x00335A85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD61 RID: 56673 RVA: 0x0033788C File Offset: 0x00335A8C
		public static SkillToughWhiteList GetRootAsSkillToughWhiteList(ByteBuffer _bb)
		{
			return SkillToughWhiteList.GetRootAsSkillToughWhiteList(_bb, default(SkillToughWhiteList));
		}

		// Token: 0x0600DD62 RID: 56674 RVA: 0x003378A8 File Offset: 0x00335AA8
		public static SkillToughWhiteList GetRootAsSkillToughWhiteList(ByteBuffer _bb, SkillToughWhiteList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD63 RID: 56675 RVA: 0x003378C5 File Offset: 0x00335AC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD64 RID: 56676 RVA: 0x003378D4 File Offset: 0x00335AD4
		public SkillToughWhiteList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x0600DD65 RID: 56677 RVA: 0x003378E4 File Offset: 0x00335AE4
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x040057F1 RID: 22513
		private Table __p;
	}
}
