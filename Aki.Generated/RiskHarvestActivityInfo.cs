using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC9 RID: 4041
	public struct RiskHarvestActivityInfo : IFlatbufferObject
	{
		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x0600BD14 RID: 48404 RVA: 0x002E07DD File Offset: 0x002DE9DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD15 RID: 48405 RVA: 0x002E07EA File Offset: 0x002DE9EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD16 RID: 48406 RVA: 0x002E07F4 File Offset: 0x002DE9F4
		public static RiskHarvestActivityInfo GetRootAsRiskHarvestActivityInfo(ByteBuffer _bb)
		{
			return RiskHarvestActivityInfo.GetRootAsRiskHarvestActivityInfo(_bb, default(RiskHarvestActivityInfo));
		}

		// Token: 0x0600BD17 RID: 48407 RVA: 0x002E0810 File Offset: 0x002DEA10
		public static RiskHarvestActivityInfo GetRootAsRiskHarvestActivityInfo(ByteBuffer _bb, RiskHarvestActivityInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD18 RID: 48408 RVA: 0x002E082D File Offset: 0x002DEA2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD19 RID: 48409 RVA: 0x002E083C File Offset: 0x002DEA3C
		public RiskHarvestActivityInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x0600BD1A RID: 48410 RVA: 0x002E084C File Offset: 0x002DEA4C
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

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x0600BD1B RID: 48411 RVA: 0x002E0888 File Offset: 0x002DEA88
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

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x0600BD1C RID: 48412 RVA: 0x002E08C4 File Offset: 0x002DEAC4
		public int EntranceId
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

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x0600BD1D RID: 48413 RVA: 0x002E0900 File Offset: 0x002DEB00
		public int QuestId
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

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x0600BD1E RID: 48414 RVA: 0x002E0940 File Offset: 0x002DEB40
		public int MarkId
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

		// Token: 0x040050A4 RID: 20644
		private Table __p;
	}
}
