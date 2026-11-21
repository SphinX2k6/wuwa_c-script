using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C39 RID: 3129
	public struct BuildingUpGradeCurve : IFlatbufferObject
	{
		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06005715 RID: 22293 RVA: 0x0020C9D5 File Offset: 0x0020ABD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005716 RID: 22294 RVA: 0x0020C9E2 File Offset: 0x0020ABE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005717 RID: 22295 RVA: 0x0020C9EC File Offset: 0x0020ABEC
		public static BuildingUpGradeCurve GetRootAsBuildingUpGradeCurve(ByteBuffer _bb)
		{
			return BuildingUpGradeCurve.GetRootAsBuildingUpGradeCurve(_bb, default(BuildingUpGradeCurve));
		}

		// Token: 0x06005718 RID: 22296 RVA: 0x0020CA08 File Offset: 0x0020AC08
		public static BuildingUpGradeCurve GetRootAsBuildingUpGradeCurve(ByteBuffer _bb, BuildingUpGradeCurve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005719 RID: 22297 RVA: 0x0020CA25 File Offset: 0x0020AC25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600571A RID: 22298 RVA: 0x0020CA34 File Offset: 0x0020AC34
		public BuildingUpGradeCurve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x0600571B RID: 22299 RVA: 0x0020CA44 File Offset: 0x0020AC44
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

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x0600571C RID: 22300 RVA: 0x0020CA80 File Offset: 0x0020AC80
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

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600571D RID: 22301 RVA: 0x0020CABC File Offset: 0x0020ACBC
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

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600571E RID: 22302 RVA: 0x0020CAF8 File Offset: 0x0020ACF8
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

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600571F RID: 22303 RVA: 0x0020CB38 File Offset: 0x0020AD38
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

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06005720 RID: 22304 RVA: 0x0020CB78 File Offset: 0x0020AD78
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

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06005721 RID: 22305 RVA: 0x0020CBB8 File Offset: 0x0020ADB8
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

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06005722 RID: 22306 RVA: 0x0020CBF8 File Offset: 0x0020ADF8
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

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06005723 RID: 22307 RVA: 0x0020CC38 File Offset: 0x0020AE38
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

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06005724 RID: 22308 RVA: 0x0020CC78 File Offset: 0x0020AE78
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

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06005725 RID: 22309 RVA: 0x0020CCB8 File Offset: 0x0020AEB8
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

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06005726 RID: 22310 RVA: 0x0020CCF8 File Offset: 0x0020AEF8
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

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06005727 RID: 22311 RVA: 0x0020CD38 File Offset: 0x0020AF38
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

		// Token: 0x04005136 RID: 20790
		private Table __p;
	}
}
