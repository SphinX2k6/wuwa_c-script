using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF7 RID: 3063
	public struct AvoidBlockReward : IFlatbufferObject
	{
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06004FD7 RID: 20439 RVA: 0x001FB75C File Offset: 0x001F995C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004FD8 RID: 20440 RVA: 0x001FB769 File Offset: 0x001F9969
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004FD9 RID: 20441 RVA: 0x001FB770 File Offset: 0x001F9970
		public static AvoidBlockReward GetRootAsAvoidBlockReward(ByteBuffer _bb)
		{
			return AvoidBlockReward.GetRootAsAvoidBlockReward(_bb, default(AvoidBlockReward));
		}

		// Token: 0x06004FDA RID: 20442 RVA: 0x001FB78C File Offset: 0x001F998C
		public static AvoidBlockReward GetRootAsAvoidBlockReward(ByteBuffer _bb, AvoidBlockReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x001FB7A9 File Offset: 0x001F99A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x001FB7B8 File Offset: 0x001F99B8
		public AvoidBlockReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06004FDD RID: 20445 RVA: 0x001FB7C8 File Offset: 0x001F99C8
		public int RewardId
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

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06004FDE RID: 20446 RVA: 0x001FB804 File Offset: 0x001F9A04
		public int RewardGroupId
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

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06004FDF RID: 20447 RVA: 0x001FB840 File Offset: 0x001F9A40
		public int TargetScore
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

		// Token: 0x040050DF RID: 20703
		private Table __p;
	}
}
