using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001036 RID: 4150
	public struct RogueWhiteCatReward : IFlatbufferObject
	{
		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0600C71D RID: 50973 RVA: 0x002F73FD File Offset: 0x002F55FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C71E RID: 50974 RVA: 0x002F740A File Offset: 0x002F560A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C71F RID: 50975 RVA: 0x002F7414 File Offset: 0x002F5614
		public static RogueWhiteCatReward GetRootAsRogueWhiteCatReward(ByteBuffer _bb)
		{
			return RogueWhiteCatReward.GetRootAsRogueWhiteCatReward(_bb, default(RogueWhiteCatReward));
		}

		// Token: 0x0600C720 RID: 50976 RVA: 0x002F7430 File Offset: 0x002F5630
		public static RogueWhiteCatReward GetRootAsRogueWhiteCatReward(ByteBuffer _bb, RogueWhiteCatReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C721 RID: 50977 RVA: 0x002F744D File Offset: 0x002F564D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C722 RID: 50978 RVA: 0x002F745C File Offset: 0x002F565C
		public RogueWhiteCatReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0600C723 RID: 50979 RVA: 0x002F746C File Offset: 0x002F566C
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

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0600C724 RID: 50980 RVA: 0x002F74A8 File Offset: 0x002F56A8
		public int NeedEnergy
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

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0600C725 RID: 50981 RVA: 0x002F74E4 File Offset: 0x002F56E4
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

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0600C726 RID: 50982 RVA: 0x002F7520 File Offset: 0x002F5720
		public int DropId
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

		// Token: 0x04005133 RID: 20787
		private Table __p;
	}
}
