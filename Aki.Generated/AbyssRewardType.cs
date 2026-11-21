using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B89 RID: 2953
	public struct AbyssRewardType : IFlatbufferObject
	{
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060046C5 RID: 18117 RVA: 0x001E7851 File Offset: 0x001E5A51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x001E785E File Offset: 0x001E5A5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x001E7868 File Offset: 0x001E5A68
		public static AbyssRewardType GetRootAsAbyssRewardType(ByteBuffer _bb)
		{
			return AbyssRewardType.GetRootAsAbyssRewardType(_bb, default(AbyssRewardType));
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x001E7884 File Offset: 0x001E5A84
		public static AbyssRewardType GetRootAsAbyssRewardType(ByteBuffer _bb, AbyssRewardType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x001E78A1 File Offset: 0x001E5AA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x001E78B0 File Offset: 0x001E5AB0
		public AbyssRewardType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060046CB RID: 18123 RVA: 0x001E78C0 File Offset: 0x001E5AC0
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x001E78FC File Offset: 0x001E5AFC
		public int ActivityId
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x001E7938 File Offset: 0x001E5B38
		public int RewardType
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x001E7974 File Offset: 0x001E5B74
		public int TabId
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

		// Token: 0x0400505D RID: 20573
		private Table __p;
	}
}
