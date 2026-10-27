using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D91 RID: 3473
	public struct KSCDamage : IFlatbufferObject
	{
		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x0600883C RID: 34876 RVA: 0x0026AABD File Offset: 0x00268CBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600883D RID: 34877 RVA: 0x0026AACA File Offset: 0x00268CCA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x0026AAD4 File Offset: 0x00268CD4
		public static KSCDamage GetRootAsKSCDamage(ByteBuffer _bb)
		{
			return KSCDamage.GetRootAsKSCDamage(_bb, default(KSCDamage));
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x0026AAF0 File Offset: 0x00268CF0
		public static KSCDamage GetRootAsKSCDamage(ByteBuffer _bb, KSCDamage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x0026AB0D File Offset: 0x00268D0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x0026AB1C File Offset: 0x00268D1C
		public KSCDamage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x06008842 RID: 34882 RVA: 0x0026AB2C File Offset: 0x00268D2C
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x06008843 RID: 34883 RVA: 0x0026AB74 File Offset: 0x00268D74
		public int KscGameplayType
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

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06008844 RID: 34884 RVA: 0x0026ABB0 File Offset: 0x00268DB0
		public int CalculateType
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

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06008845 RID: 34885 RVA: 0x0026ABEC File Offset: 0x00268DEC
		public int Element
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

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x06008846 RID: 34886 RVA: 0x0026AC2C File Offset: 0x00268E2C
		public int RelatedProperty
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 7;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06008847 RID: 34887 RVA: 0x0026AC6C File Offset: 0x00268E6C
		public int Amplify
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

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06008848 RID: 34888 RVA: 0x0026ACAC File Offset: 0x00268EAC
		public int MainDamageType
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

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x06008849 RID: 34889 RVA: 0x0026ACEC File Offset: 0x00268EEC
		public int SubDamageType
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

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x0600884A RID: 34890 RVA: 0x0026AD2C File Offset: 0x00268F2C
		public int RelatedProperty1
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 7;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x0600884B RID: 34891 RVA: 0x0026AD6C File Offset: 0x00268F6C
		public int Amplify1
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

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x0600884C RID: 34892 RVA: 0x0026ADAC File Offset: 0x00268FAC
		public int MainDamageType1
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

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x0600884D RID: 34893 RVA: 0x0026ADEC File Offset: 0x00268FEC
		public int SubDamageType1
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

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x0600884E RID: 34894 RVA: 0x0026AE2C File Offset: 0x0026902C
		public int RelatedProperty2
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 7;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x0600884F RID: 34895 RVA: 0x0026AE6C File Offset: 0x0026906C
		public int Amplify2
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x06008850 RID: 34896 RVA: 0x0026AEAC File Offset: 0x002690AC
		public int MainDamageType2
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x06008851 RID: 34897 RVA: 0x0026AEEC File Offset: 0x002690EC
		public int SubDamageType2
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x06008852 RID: 34898 RVA: 0x0026AF2C File Offset: 0x0026912C
		public int RelatedProperty3
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 7;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x06008853 RID: 34899 RVA: 0x0026AF6C File Offset: 0x0026916C
		public int Amplify3
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x06008854 RID: 34900 RVA: 0x0026AFAC File Offset: 0x002691AC
		public int MainDamageType3
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x06008855 RID: 34901 RVA: 0x0026AFEC File Offset: 0x002691EC
		public int SubDamageType3
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x06008856 RID: 34902 RVA: 0x0026B02C File Offset: 0x0026922C
		public bool Knocked
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x06008857 RID: 34903 RVA: 0x0026B06C File Offset: 0x0026926C
		public int CritAttrType
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004E1E RID: 19998
		private Table __p;
	}
}
