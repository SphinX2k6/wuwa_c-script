using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E78 RID: 3704
	public struct KujiAwardsGroup : IFlatbufferObject
	{
		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06008E7D RID: 36477 RVA: 0x00289EF0 File Offset: 0x002880F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E7E RID: 36478 RVA: 0x00289EFD File Offset: 0x002880FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x00289F04 File Offset: 0x00288104
		public static KujiAwardsGroup GetRootAsKujiAwardsGroup(ByteBuffer _bb)
		{
			return KujiAwardsGroup.GetRootAsKujiAwardsGroup(_bb, default(KujiAwardsGroup));
		}

		// Token: 0x06008E80 RID: 36480 RVA: 0x00289F20 File Offset: 0x00288120
		public static KujiAwardsGroup GetRootAsKujiAwardsGroup(ByteBuffer _bb, KujiAwardsGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E81 RID: 36481 RVA: 0x00289F3D File Offset: 0x0028813D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E82 RID: 36482 RVA: 0x00289F4C File Offset: 0x0028814C
		public KujiAwardsGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06008E83 RID: 36483 RVA: 0x00289F5C File Offset: 0x0028815C
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

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06008E84 RID: 36484 RVA: 0x00289F98 File Offset: 0x00288198
		public int KujiId
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

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06008E85 RID: 36485 RVA: 0x00289FD4 File Offset: 0x002881D4
		public int Amount
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

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06008E86 RID: 36486 RVA: 0x0028A010 File Offset: 0x00288210
		public int RewardId
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

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x06008E87 RID: 36487 RVA: 0x0028A050 File Offset: 0x00288250
		public int Rank
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

		// Token: 0x04005405 RID: 21509
		private Table __p;
	}
}
