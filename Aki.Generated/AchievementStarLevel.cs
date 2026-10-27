using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ABF RID: 2751
	public struct AchievementStarLevel : IFlatbufferObject
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06004296 RID: 17046 RVA: 0x001CA400 File Offset: 0x001C8600
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x001CA40D File Offset: 0x001C860D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x001CA414 File Offset: 0x001C8614
		public static AchievementStarLevel GetRootAsAchievementStarLevel(ByteBuffer _bb)
		{
			return AchievementStarLevel.GetRootAsAchievementStarLevel(_bb, default(AchievementStarLevel));
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x001CA430 File Offset: 0x001C8630
		public static AchievementStarLevel GetRootAsAchievementStarLevel(ByteBuffer _bb, AchievementStarLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x001CA44D File Offset: 0x001C864D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x001CA45C File Offset: 0x001C865C
		public AchievementStarLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600429C RID: 17052 RVA: 0x001CA46C File Offset: 0x001C866C
		public int Level
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600429D RID: 17053 RVA: 0x001CA4A8 File Offset: 0x001C86A8
		public int DropId
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

		// Token: 0x04004A99 RID: 19097
		private Table __p;
	}
}
