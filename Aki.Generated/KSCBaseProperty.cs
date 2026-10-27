using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D8F RID: 3471
	public struct KSCBaseProperty : IFlatbufferObject
	{
		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x060087DD RID: 34781 RVA: 0x0026958C File Offset: 0x0026778C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060087DE RID: 34782 RVA: 0x00269599 File Offset: 0x00267799
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060087DF RID: 34783 RVA: 0x002695A0 File Offset: 0x002677A0
		public static KSCBaseProperty GetRootAsKSCBaseProperty(ByteBuffer _bb)
		{
			return KSCBaseProperty.GetRootAsKSCBaseProperty(_bb, default(KSCBaseProperty));
		}

		// Token: 0x060087E0 RID: 34784 RVA: 0x002695BC File Offset: 0x002677BC
		public static KSCBaseProperty GetRootAsKSCBaseProperty(ByteBuffer _bb, KSCBaseProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060087E1 RID: 34785 RVA: 0x002695D9 File Offset: 0x002677D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060087E2 RID: 34786 RVA: 0x002695E8 File Offset: 0x002677E8
		public KSCBaseProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x060087E3 RID: 34787 RVA: 0x002695F8 File Offset: 0x002677F8
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

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x060087E4 RID: 34788 RVA: 0x00269634 File Offset: 0x00267834
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

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x060087E5 RID: 34789 RVA: 0x00269670 File Offset: 0x00267870
		public int Lv
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

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x060087E6 RID: 34790 RVA: 0x002696AC File Offset: 0x002678AC
		public int LifeMax
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

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x060087E7 RID: 34791 RVA: 0x002696EC File Offset: 0x002678EC
		public int Life
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

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x060087E8 RID: 34792 RVA: 0x0026972C File Offset: 0x0026792C
		public int Sheild
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

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x060087E9 RID: 34793 RVA: 0x0026976C File Offset: 0x0026796C
		public int Atk
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

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x060087EA RID: 34794 RVA: 0x002697AC File Offset: 0x002679AC
		public int Crit
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

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x060087EB RID: 34795 RVA: 0x002697EC File Offset: 0x002679EC
		public int CritDamage
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x060087EC RID: 34796 RVA: 0x00269830 File Offset: 0x00267A30
		public int Def
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

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x060087ED RID: 34797 RVA: 0x00269870 File Offset: 0x00267A70
		public int DamageChangePhys
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

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x060087EE RID: 34798 RVA: 0x002698B0 File Offset: 0x00267AB0
		public int DamageChangeElement1
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

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x060087EF RID: 34799 RVA: 0x002698F0 File Offset: 0x00267AF0
		public int DamageChangeElement2
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

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x060087F0 RID: 34800 RVA: 0x00269930 File Offset: 0x00267B30
		public int DamageChangeElement3
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

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x060087F1 RID: 34801 RVA: 0x00269970 File Offset: 0x00267B70
		public int DamageChangeElement4
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

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x060087F2 RID: 34802 RVA: 0x002699B0 File Offset: 0x00267BB0
		public int DamageChangeElement5
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

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x060087F3 RID: 34803 RVA: 0x002699F0 File Offset: 0x00267BF0
		public int DamageChangeElement6
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x060087F4 RID: 34804 RVA: 0x00269A30 File Offset: 0x00267C30
		public int DamageResistancePhys
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

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x060087F5 RID: 34805 RVA: 0x00269A70 File Offset: 0x00267C70
		public int DamageResistanceElement1
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

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x060087F6 RID: 34806 RVA: 0x00269AB0 File Offset: 0x00267CB0
		public int DamageResistanceElement2
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

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x060087F7 RID: 34807 RVA: 0x00269AF0 File Offset: 0x00267CF0
		public int DamageResistanceElement3
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x060087F8 RID: 34808 RVA: 0x00269B30 File Offset: 0x00267D30
		public int DamageResistanceElement4
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x060087F9 RID: 34809 RVA: 0x00269B70 File Offset: 0x00267D70
		public int DamageResistanceElement5
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x060087FA RID: 34810 RVA: 0x00269BB0 File Offset: 0x00267DB0
		public int DamageResistanceElement6
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x060087FB RID: 34811 RVA: 0x00269BF0 File Offset: 0x00267DF0
		public int HealChange
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x060087FC RID: 34812 RVA: 0x00269C30 File Offset: 0x00267E30
		public int HealedChange
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x060087FD RID: 34813 RVA: 0x00269C70 File Offset: 0x00267E70
		public int DamageReducePhys
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x060087FE RID: 34814 RVA: 0x00269CB0 File Offset: 0x00267EB0
		public int DamageReduceElement1
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x060087FF RID: 34815 RVA: 0x00269CF0 File Offset: 0x00267EF0
		public int DamageReduceElement2
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x06008800 RID: 34816 RVA: 0x00269D30 File Offset: 0x00267F30
		public int DamageReduceElement3
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x06008801 RID: 34817 RVA: 0x00269D70 File Offset: 0x00267F70
		public int DamageReduceElement4
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06008802 RID: 34818 RVA: 0x00269DB0 File Offset: 0x00267FB0
		public int DamageReduceElement5
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06008803 RID: 34819 RVA: 0x00269DF0 File Offset: 0x00267FF0
		public int DamageReduceElement6
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06008804 RID: 34820 RVA: 0x00269E30 File Offset: 0x00268030
		public int IgnoreDefRate
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06008805 RID: 34821 RVA: 0x00269E70 File Offset: 0x00268070
		public int IgnoreDamageResistancePhys
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06008806 RID: 34822 RVA: 0x00269EB0 File Offset: 0x002680B0
		public int IgnoreDamageResistanceElement1
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06008807 RID: 34823 RVA: 0x00269EF0 File Offset: 0x002680F0
		public int IgnoreDamageResistanceElement2
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x06008808 RID: 34824 RVA: 0x00269F30 File Offset: 0x00268130
		public int IgnoreDamageResistanceElement3
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x06008809 RID: 34825 RVA: 0x00269F70 File Offset: 0x00268170
		public int IgnoreDamageResistanceElement4
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x0600880A RID: 34826 RVA: 0x00269FB0 File Offset: 0x002681B0
		public int IgnoreDamageResistanceElement5
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x0600880B RID: 34827 RVA: 0x00269FF0 File Offset: 0x002681F0
		public int IgnoreDamageResistanceElement6
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x0600880C RID: 34828 RVA: 0x0026A030 File Offset: 0x00268230
		public int MoveSpeed
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 200;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x0600880D RID: 34829 RVA: 0x0026A074 File Offset: 0x00268274
		public int SkillCoolDown
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x0600880E RID: 34830 RVA: 0x0026A0B4 File Offset: 0x002682B4
		public int DamageAmplify1
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x0600880F RID: 34831 RVA: 0x0026A0F4 File Offset: 0x002682F4
		public int DamageAmplify2
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x06008810 RID: 34832 RVA: 0x0026A134 File Offset: 0x00268334
		public int SkillCoolDownChangeMin
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return -5000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06008811 RID: 34833 RVA: 0x0026A178 File Offset: 0x00268378
		public int Attr120
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x06008812 RID: 34834 RVA: 0x0026A1B8 File Offset: 0x002683B8
		public int Attr121
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06008813 RID: 34835 RVA: 0x0026A1F8 File Offset: 0x002683F8
		public int Attr122
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06008814 RID: 34836 RVA: 0x0026A238 File Offset: 0x00268438
		public int Attr123
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06008815 RID: 34837 RVA: 0x0026A278 File Offset: 0x00268478
		public int Attr124
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x06008816 RID: 34838 RVA: 0x0026A2B8 File Offset: 0x002684B8
		public int Attr125
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06008817 RID: 34839 RVA: 0x0026A2F8 File Offset: 0x002684F8
		public int Attr126
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06008818 RID: 34840 RVA: 0x0026A338 File Offset: 0x00268538
		public int Attr127
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x06008819 RID: 34841 RVA: 0x0026A378 File Offset: 0x00268578
		public int Attr128
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x0600881A RID: 34842 RVA: 0x0026A3B8 File Offset: 0x002685B8
		public int Attr129
		{
			get
			{
				int num = this.__p.__offset(114);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x0600881B RID: 34843 RVA: 0x0026A3F8 File Offset: 0x002685F8
		public int Attr130
		{
			get
			{
				int num = this.__p.__offset(116);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x0600881C RID: 34844 RVA: 0x0026A438 File Offset: 0x00268638
		public int Attr131
		{
			get
			{
				int num = this.__p.__offset(118);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x0600881D RID: 34845 RVA: 0x0026A478 File Offset: 0x00268678
		public int Attr132
		{
			get
			{
				int num = this.__p.__offset(120);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x0600881E RID: 34846 RVA: 0x0026A4B8 File Offset: 0x002686B8
		public int Attr133
		{
			get
			{
				int num = this.__p.__offset(122);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x0600881F RID: 34847 RVA: 0x0026A4F8 File Offset: 0x002686F8
		public int Attr134
		{
			get
			{
				int num = this.__p.__offset(124);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x06008820 RID: 34848 RVA: 0x0026A538 File Offset: 0x00268738
		public int Attr135
		{
			get
			{
				int num = this.__p.__offset(126);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x06008821 RID: 34849 RVA: 0x0026A578 File Offset: 0x00268778
		public int Attr136
		{
			get
			{
				int num = this.__p.__offset(128);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x06008822 RID: 34850 RVA: 0x0026A5B8 File Offset: 0x002687B8
		public int Attr137
		{
			get
			{
				int num = this.__p.__offset(130);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x06008823 RID: 34851 RVA: 0x0026A5F8 File Offset: 0x002687F8
		public int Attr138
		{
			get
			{
				int num = this.__p.__offset(132);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x06008824 RID: 34852 RVA: 0x0026A638 File Offset: 0x00268838
		public int Attr139
		{
			get
			{
				int num = this.__p.__offset(134);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x06008825 RID: 34853 RVA: 0x0026A678 File Offset: 0x00268878
		public int Attr140
		{
			get
			{
				int num = this.__p.__offset(136);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x06008826 RID: 34854 RVA: 0x0026A6B8 File Offset: 0x002688B8
		public int Attr141
		{
			get
			{
				int num = this.__p.__offset(138);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x06008827 RID: 34855 RVA: 0x0026A6F8 File Offset: 0x002688F8
		public int Attr142
		{
			get
			{
				int num = this.__p.__offset(140);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x06008828 RID: 34856 RVA: 0x0026A738 File Offset: 0x00268938
		public int Attr143
		{
			get
			{
				int num = this.__p.__offset(142);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x06008829 RID: 34857 RVA: 0x0026A778 File Offset: 0x00268978
		public int Attr144
		{
			get
			{
				int num = this.__p.__offset(144);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x0600882A RID: 34858 RVA: 0x0026A7B8 File Offset: 0x002689B8
		public int Attr145
		{
			get
			{
				int num = this.__p.__offset(146);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x0600882B RID: 34859 RVA: 0x0026A7F8 File Offset: 0x002689F8
		public int Attr146
		{
			get
			{
				int num = this.__p.__offset(148);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x0600882C RID: 34860 RVA: 0x0026A838 File Offset: 0x00268A38
		public int Attr147
		{
			get
			{
				int num = this.__p.__offset(150);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x0600882D RID: 34861 RVA: 0x0026A878 File Offset: 0x00268A78
		public int Attr148
		{
			get
			{
				int num = this.__p.__offset(152);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x0600882E RID: 34862 RVA: 0x0026A8B8 File Offset: 0x00268AB8
		public int Attr149
		{
			get
			{
				int num = this.__p.__offset(154);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x0600882F RID: 34863 RVA: 0x0026A8F8 File Offset: 0x00268AF8
		public int Attr150
		{
			get
			{
				int num = this.__p.__offset(156);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x06008830 RID: 34864 RVA: 0x0026A938 File Offset: 0x00268B38
		public int Attr151
		{
			get
			{
				int num = this.__p.__offset(158);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x06008831 RID: 34865 RVA: 0x0026A978 File Offset: 0x00268B78
		public int AttackSpeed
		{
			get
			{
				int num = this.__p.__offset(160);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004E1C RID: 19996
		private Table __p;
	}
}
