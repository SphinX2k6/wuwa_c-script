using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB4 RID: 2740
	public struct AbyssRewardType : IFlatbufferObject
	{
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060041C7 RID: 16839 RVA: 0x001C85F1 File Offset: 0x001C67F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x001C85FE File Offset: 0x001C67FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x001C8608 File Offset: 0x001C6808
		public static AbyssRewardType GetRootAsAbyssRewardType(ByteBuffer _bb)
		{
			return AbyssRewardType.GetRootAsAbyssRewardType(_bb, default(AbyssRewardType));
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x001C8624 File Offset: 0x001C6824
		public static AbyssRewardType GetRootAsAbyssRewardType(ByteBuffer _bb, AbyssRewardType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x001C8641 File Offset: 0x001C6841
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x001C8650 File Offset: 0x001C6850
		public AbyssRewardType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x001C8660 File Offset: 0x001C6860
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
		// (get) Token: 0x060041CE RID: 16846 RVA: 0x001C869C File Offset: 0x001C689C
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
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x001C86D8 File Offset: 0x001C68D8
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
		// (get) Token: 0x060041D0 RID: 16848 RVA: 0x001C8714 File Offset: 0x001C6914
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

		// Token: 0x04004A8A RID: 19082
		private Table __p;
	}
}
