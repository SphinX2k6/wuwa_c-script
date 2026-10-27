using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B59 RID: 2905
	public struct BuildingUpGradeCurve : IFlatbufferObject
	{
		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06005153 RID: 20819 RVA: 0x001ECBA9 File Offset: 0x001EADA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x001ECBB6 File Offset: 0x001EADB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x001ECBC0 File Offset: 0x001EADC0
		public static BuildingUpGradeCurve GetRootAsBuildingUpGradeCurve(ByteBuffer _bb)
		{
			return BuildingUpGradeCurve.GetRootAsBuildingUpGradeCurve(_bb, default(BuildingUpGradeCurve));
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x001ECBDC File Offset: 0x001EADDC
		public static BuildingUpGradeCurve GetRootAsBuildingUpGradeCurve(ByteBuffer _bb, BuildingUpGradeCurve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x001ECBF9 File Offset: 0x001EADF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x001ECC08 File Offset: 0x001EAE08
		public BuildingUpGradeCurve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06005159 RID: 20825 RVA: 0x001ECC18 File Offset: 0x001EAE18
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

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600515A RID: 20826 RVA: 0x001ECC54 File Offset: 0x001EAE54
		public int GroupId
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

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600515B RID: 20827 RVA: 0x001ECC90 File Offset: 0x001EAE90
		public int Level
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

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x0600515C RID: 20828 RVA: 0x001ECCCC File Offset: 0x001EAECC
		public int UpGradePrice
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

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x0600515D RID: 20829 RVA: 0x001ECD0C File Offset: 0x001EAF0C
		public int HeatAddition
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

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600515E RID: 20830 RVA: 0x001ECD4C File Offset: 0x001EAF4C
		public int GoldAddition
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600515F RID: 20831 RVA: 0x001ECD8C File Offset: 0x001EAF8C
		public int GoldAdditionFix
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06005160 RID: 20832 RVA: 0x001ECDCC File Offset: 0x001EAFCC
		public int WishAddition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06005161 RID: 20833 RVA: 0x001ECE0C File Offset: 0x001EB00C
		public int WishAdditionFix
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06005162 RID: 20834 RVA: 0x001ECE4C File Offset: 0x001EB04C
		public int EnergyAddition
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06005163 RID: 20835 RVA: 0x001ECE8C File Offset: 0x001EB08C
		public int ModelId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06005164 RID: 20836 RVA: 0x001ECECC File Offset: 0x001EB0CC
		public int IdeaRatioAddition
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06005165 RID: 20837 RVA: 0x001ECF0C File Offset: 0x001EB10C
		public int SuccessAddition
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004B56 RID: 19286
		private Table __p;
	}
}
