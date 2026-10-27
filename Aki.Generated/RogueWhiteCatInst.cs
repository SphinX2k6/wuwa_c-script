using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001035 RID: 4149
	public struct RogueWhiteCatInst : IFlatbufferObject
	{
		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0600C712 RID: 50962 RVA: 0x002F725D File Offset: 0x002F545D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C713 RID: 50963 RVA: 0x002F726A File Offset: 0x002F546A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C714 RID: 50964 RVA: 0x002F7274 File Offset: 0x002F5474
		public static RogueWhiteCatInst GetRootAsRogueWhiteCatInst(ByteBuffer _bb)
		{
			return RogueWhiteCatInst.GetRootAsRogueWhiteCatInst(_bb, default(RogueWhiteCatInst));
		}

		// Token: 0x0600C715 RID: 50965 RVA: 0x002F7290 File Offset: 0x002F5490
		public static RogueWhiteCatInst GetRootAsRogueWhiteCatInst(ByteBuffer _bb, RogueWhiteCatInst obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C716 RID: 50966 RVA: 0x002F72AD File Offset: 0x002F54AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C717 RID: 50967 RVA: 0x002F72BC File Offset: 0x002F54BC
		public RogueWhiteCatInst __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x0600C718 RID: 50968 RVA: 0x002F72CC File Offset: 0x002F54CC
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

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x0600C719 RID: 50969 RVA: 0x002F7308 File Offset: 0x002F5508
		public int InstId
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

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x0600C71A RID: 50970 RVA: 0x002F7344 File Offset: 0x002F5544
		public int ConditionGroupId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x0600C71B RID: 50971 RVA: 0x002F7380 File Offset: 0x002F5580
		public int UnlockDay
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0600C71C RID: 50972 RVA: 0x002F73C0 File Offset: 0x002F55C0
		public int TrialRoleId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005132 RID: 20786
		private Table __p;
	}
}
