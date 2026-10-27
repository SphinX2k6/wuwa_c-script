using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B1B RID: 2843
	public struct BabelTowerActivity : IFlatbufferObject
	{
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06004A73 RID: 19059 RVA: 0x001DC2B4 File Offset: 0x001DA4B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x001DC2C1 File Offset: 0x001DA4C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x001DC2C8 File Offset: 0x001DA4C8
		public static BabelTowerActivity GetRootAsBabelTowerActivity(ByteBuffer _bb)
		{
			return BabelTowerActivity.GetRootAsBabelTowerActivity(_bb, default(BabelTowerActivity));
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x001DC2E4 File Offset: 0x001DA4E4
		public static BabelTowerActivity GetRootAsBabelTowerActivity(ByteBuffer _bb, BabelTowerActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x001DC301 File Offset: 0x001DA501
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x001DC310 File Offset: 0x001DA510
		public BabelTowerActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06004A79 RID: 19065 RVA: 0x001DC320 File Offset: 0x001DA520
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

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06004A7A RID: 19066 RVA: 0x001DC35C File Offset: 0x001DA55C
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

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06004A7B RID: 19067 RVA: 0x001DC398 File Offset: 0x001DA598
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

		// Token: 0x04004B0A RID: 19210
		private Table __p;
	}
}
