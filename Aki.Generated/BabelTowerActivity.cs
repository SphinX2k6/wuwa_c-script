using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BFB RID: 3067
	public struct BabelTowerActivity : IFlatbufferObject
	{
		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06005035 RID: 20533 RVA: 0x001FC834 File Offset: 0x001FAA34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x001FC841 File Offset: 0x001FAA41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x001FC848 File Offset: 0x001FAA48
		public static BabelTowerActivity GetRootAsBabelTowerActivity(ByteBuffer _bb)
		{
			return BabelTowerActivity.GetRootAsBabelTowerActivity(_bb, default(BabelTowerActivity));
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x001FC864 File Offset: 0x001FAA64
		public static BabelTowerActivity GetRootAsBabelTowerActivity(ByteBuffer _bb, BabelTowerActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x001FC881 File Offset: 0x001FAA81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x001FC890 File Offset: 0x001FAA90
		public BabelTowerActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600503B RID: 20539 RVA: 0x001FC8A0 File Offset: 0x001FAAA0
		public int ActivityId
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

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600503C RID: 20540 RVA: 0x001FC8DC File Offset: 0x001FAADC
		public int ItemId
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

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600503D RID: 20541 RVA: 0x001FC918 File Offset: 0x001FAB18
		public int ShareId
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

		// Token: 0x040050EA RID: 20714
		private Table __p;
	}
}
