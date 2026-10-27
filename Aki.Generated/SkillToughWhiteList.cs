using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C5 RID: 4293
	public struct SkillToughWhiteList : IFlatbufferObject
	{
		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x0600D582 RID: 54658 RVA: 0x00318734 File Offset: 0x00316934
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D583 RID: 54659 RVA: 0x00318741 File Offset: 0x00316941
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D584 RID: 54660 RVA: 0x00318748 File Offset: 0x00316948
		public static SkillToughWhiteList GetRootAsSkillToughWhiteList(ByteBuffer _bb)
		{
			return SkillToughWhiteList.GetRootAsSkillToughWhiteList(_bb, default(SkillToughWhiteList));
		}

		// Token: 0x0600D585 RID: 54661 RVA: 0x00318764 File Offset: 0x00316964
		public static SkillToughWhiteList GetRootAsSkillToughWhiteList(ByteBuffer _bb, SkillToughWhiteList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D586 RID: 54662 RVA: 0x00318781 File Offset: 0x00316981
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D587 RID: 54663 RVA: 0x00318790 File Offset: 0x00316990
		public SkillToughWhiteList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x0600D588 RID: 54664 RVA: 0x003187A0 File Offset: 0x003169A0
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x040051F2 RID: 20978
		private Table __p;
	}
}
