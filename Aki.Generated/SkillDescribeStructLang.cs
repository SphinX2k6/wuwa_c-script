using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E1 RID: 4577
	public struct SkillDescribeStructLang : IFlatbufferObject
	{
		// Token: 0x17003F2D RID: 16173
		// (get) Token: 0x0600EB79 RID: 60281 RVA: 0x0034A555 File Offset: 0x00348755
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB7A RID: 60282 RVA: 0x0034A562 File Offset: 0x00348762
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB7B RID: 60283 RVA: 0x0034A56C File Offset: 0x0034876C
		public static SkillDescribeStructLang GetRootAsSkillDescribeStructLang(ByteBuffer _bb)
		{
			return SkillDescribeStructLang.GetRootAsSkillDescribeStructLang(_bb, default(SkillDescribeStructLang));
		}

		// Token: 0x0600EB7C RID: 60284 RVA: 0x0034A588 File Offset: 0x00348788
		public static SkillDescribeStructLang GetRootAsSkillDescribeStructLang(ByteBuffer _bb, SkillDescribeStructLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB7D RID: 60285 RVA: 0x0034A5A5 File Offset: 0x003487A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB7E RID: 60286 RVA: 0x0034A5B4 File Offset: 0x003487B4
		public SkillDescribeStructLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F2E RID: 16174
		// (get) Token: 0x0600EB7F RID: 60287 RVA: 0x0034A5C4 File Offset: 0x003487C4
		public int Title
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

		// Token: 0x17003F2F RID: 16175
		// (get) Token: 0x0600EB80 RID: 60288 RVA: 0x0034A600 File Offset: 0x00348800
		public int Content
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

		// Token: 0x0400535A RID: 21338
		private Table __p;
	}
}
