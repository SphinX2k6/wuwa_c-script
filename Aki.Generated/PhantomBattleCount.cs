using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB1 RID: 4017
	public struct PhantomBattleCount : IFlatbufferObject
	{
		// Token: 0x17002688 RID: 9864
		// (get) Token: 0x0600ACF7 RID: 44279 RVA: 0x002CC716 File Offset: 0x002CA916
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ACF8 RID: 44280 RVA: 0x002CC723 File Offset: 0x002CA923
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ACF9 RID: 44281 RVA: 0x002CC72C File Offset: 0x002CA92C
		public static PhantomBattleCount GetRootAsPhantomBattleCount(ByteBuffer _bb)
		{
			return PhantomBattleCount.GetRootAsPhantomBattleCount(_bb, default(PhantomBattleCount));
		}

		// Token: 0x0600ACFA RID: 44282 RVA: 0x002CC748 File Offset: 0x002CA948
		public static PhantomBattleCount GetRootAsPhantomBattleCount(ByteBuffer _bb, PhantomBattleCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ACFB RID: 44283 RVA: 0x002CC765 File Offset: 0x002CA965
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ACFC RID: 44284 RVA: 0x002CC774 File Offset: 0x002CA974
		public PhantomBattleCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002689 RID: 9865
		// (get) Token: 0x0600ACFD RID: 44285 RVA: 0x002CC784 File Offset: 0x002CA984
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

		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x0600ACFE RID: 44286 RVA: 0x002CC7C0 File Offset: 0x002CA9C0
		public int CountType
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

		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x0600ACFF RID: 44287 RVA: 0x002CC7FC File Offset: 0x002CA9FC
		public int TargetType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x0600AD00 RID: 44288 RVA: 0x002CC838 File Offset: 0x002CAA38
		public int UnlockCount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x0600AD01 RID: 44289 RVA: 0x002CC878 File Offset: 0x002CAA78
		public int ReduceCount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x0600AD02 RID: 44290 RVA: 0x002CC8B8 File Offset: 0x002CAAB8
		public int CountSkillLimitNum
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400556F RID: 21871
		private Table __p;
	}
}
