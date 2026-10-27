using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D93 RID: 3475
	public struct KujiAwardsGroup : IFlatbufferObject
	{
		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06008861 RID: 34913 RVA: 0x0026B1CC File Offset: 0x002693CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008862 RID: 34914 RVA: 0x0026B1D9 File Offset: 0x002693D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008863 RID: 34915 RVA: 0x0026B1E0 File Offset: 0x002693E0
		public static KujiAwardsGroup GetRootAsKujiAwardsGroup(ByteBuffer _bb)
		{
			return KujiAwardsGroup.GetRootAsKujiAwardsGroup(_bb, default(KujiAwardsGroup));
		}

		// Token: 0x06008864 RID: 34916 RVA: 0x0026B1FC File Offset: 0x002693FC
		public static KujiAwardsGroup GetRootAsKujiAwardsGroup(ByteBuffer _bb, KujiAwardsGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008865 RID: 34917 RVA: 0x0026B219 File Offset: 0x00269419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008866 RID: 34918 RVA: 0x0026B228 File Offset: 0x00269428
		public KujiAwardsGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06008867 RID: 34919 RVA: 0x0026B238 File Offset: 0x00269438
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

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06008868 RID: 34920 RVA: 0x0026B274 File Offset: 0x00269474
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

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06008869 RID: 34921 RVA: 0x0026B2B0 File Offset: 0x002694B0
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

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x0600886A RID: 34922 RVA: 0x0026B2EC File Offset: 0x002694EC
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

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x0600886B RID: 34923 RVA: 0x0026B32C File Offset: 0x0026952C
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

		// Token: 0x04004E20 RID: 20000
		private Table __p;
	}
}
