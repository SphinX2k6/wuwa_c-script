using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010CE RID: 4302
	public struct RoguelikeEffect : IFlatbufferObject
	{
		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x0600C600 RID: 50688 RVA: 0x003029B2 File Offset: 0x00300BB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C601 RID: 50689 RVA: 0x003029BF File Offset: 0x00300BBF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C602 RID: 50690 RVA: 0x003029C8 File Offset: 0x00300BC8
		public static RoguelikeEffect GetRootAsRoguelikeEffect(ByteBuffer _bb)
		{
			return RoguelikeEffect.GetRootAsRoguelikeEffect(_bb, default(RoguelikeEffect));
		}

		// Token: 0x0600C603 RID: 50691 RVA: 0x003029E4 File Offset: 0x00300BE4
		public static RoguelikeEffect GetRootAsRoguelikeEffect(ByteBuffer _bb, RoguelikeEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C604 RID: 50692 RVA: 0x00302A01 File Offset: 0x00300C01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C605 RID: 50693 RVA: 0x00302A10 File Offset: 0x00300C10
		public RoguelikeEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x0600C606 RID: 50694 RVA: 0x00302A20 File Offset: 0x00300C20
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

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x0600C607 RID: 50695 RVA: 0x00302A5C File Offset: 0x00300C5C
		public int DescIntParam
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

		// Token: 0x040056AD RID: 22189
		private Table __p;
	}
}
