using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001318 RID: 4888
	public struct SkillDescribeStructLang : IFlatbufferObject
	{
		// Token: 0x17004295 RID: 17045
		// (get) Token: 0x0600F8F2 RID: 63730 RVA: 0x00375245 File Offset: 0x00373445
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F8F3 RID: 63731 RVA: 0x00375252 File Offset: 0x00373452
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F8F4 RID: 63732 RVA: 0x0037525C File Offset: 0x0037345C
		public static SkillDescribeStructLang GetRootAsSkillDescribeStructLang(ByteBuffer _bb)
		{
			return SkillDescribeStructLang.GetRootAsSkillDescribeStructLang(_bb, default(SkillDescribeStructLang));
		}

		// Token: 0x0600F8F5 RID: 63733 RVA: 0x00375278 File Offset: 0x00373478
		public static SkillDescribeStructLang GetRootAsSkillDescribeStructLang(ByteBuffer _bb, SkillDescribeStructLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F8F6 RID: 63734 RVA: 0x00375295 File Offset: 0x00373495
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F8F7 RID: 63735 RVA: 0x003752A4 File Offset: 0x003734A4
		public SkillDescribeStructLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004296 RID: 17046
		// (get) Token: 0x0600F8F8 RID: 63736 RVA: 0x003752B4 File Offset: 0x003734B4
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

		// Token: 0x17004297 RID: 17047
		// (get) Token: 0x0600F8F9 RID: 63737 RVA: 0x003752F0 File Offset: 0x003734F0
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

		// Token: 0x0400599E RID: 22942
		private Table __p;
	}
}
