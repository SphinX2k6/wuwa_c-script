using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B94 RID: 2964
	public struct AchievementStarLevel : IFlatbufferObject
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06004794 RID: 18324 RVA: 0x001E9644 File Offset: 0x001E7844
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x001E9651 File Offset: 0x001E7851
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x001E9658 File Offset: 0x001E7858
		public static AchievementStarLevel GetRootAsAchievementStarLevel(ByteBuffer _bb)
		{
			return AchievementStarLevel.GetRootAsAchievementStarLevel(_bb, default(AchievementStarLevel));
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x001E9674 File Offset: 0x001E7874
		public static AchievementStarLevel GetRootAsAchievementStarLevel(ByteBuffer _bb, AchievementStarLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x001E9691 File Offset: 0x001E7891
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x001E96A0 File Offset: 0x001E78A0
		public AchievementStarLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x001E96B0 File Offset: 0x001E78B0
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
		// (get) Token: 0x0600479B RID: 18331 RVA: 0x001E96EC File Offset: 0x001E78EC
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

		// Token: 0x0400506C RID: 20588
		private Table __p;
	}
}
