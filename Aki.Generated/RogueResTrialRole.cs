using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200101B RID: 4123
	public struct RogueResTrialRole : IFlatbufferObject
	{
		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x0600C492 RID: 50322 RVA: 0x002F1298 File Offset: 0x002EF498
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C493 RID: 50323 RVA: 0x002F12A5 File Offset: 0x002EF4A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C494 RID: 50324 RVA: 0x002F12AC File Offset: 0x002EF4AC
		public static RogueResTrialRole GetRootAsRogueResTrialRole(ByteBuffer _bb)
		{
			return RogueResTrialRole.GetRootAsRogueResTrialRole(_bb, default(RogueResTrialRole));
		}

		// Token: 0x0600C495 RID: 50325 RVA: 0x002F12C8 File Offset: 0x002EF4C8
		public static RogueResTrialRole GetRootAsRogueResTrialRole(ByteBuffer _bb, RogueResTrialRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C496 RID: 50326 RVA: 0x002F12E5 File Offset: 0x002EF4E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C497 RID: 50327 RVA: 0x002F12F4 File Offset: 0x002EF4F4
		public RogueResTrialRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x0600C498 RID: 50328 RVA: 0x002F1304 File Offset: 0x002EF504
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

		// Token: 0x0400510B RID: 20747
		private Table __p;
	}
}
