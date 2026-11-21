using System;
using System.Reflection;
using CSharpScript.Core.Common;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E74 RID: 3700
	[GeneratePropertyAccessMethod(false, false, "int")]
	[Obfuscation]
	public struct KSCBaseProperty : IFlatbufferObject
	{
		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x06008DF8 RID: 36344 RVA: 0x00287764 File Offset: 0x00285964
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008DF9 RID: 36345 RVA: 0x00287771 File Offset: 0x00285971
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008DFA RID: 36346 RVA: 0x00287778 File Offset: 0x00285978
		public static KSCBaseProperty GetRootAsKSCBaseProperty(ByteBuffer _bb)
		{
			return KSCBaseProperty.GetRootAsKSCBaseProperty(_bb, default(KSCBaseProperty));
		}

		// Token: 0x06008DFB RID: 36347 RVA: 0x00287794 File Offset: 0x00285994
		public static KSCBaseProperty GetRootAsKSCBaseProperty(ByteBuffer _bb, KSCBaseProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008DFC RID: 36348 RVA: 0x002877B1 File Offset: 0x002859B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008DFD RID: 36349 RVA: 0x002877C0 File Offset: 0x002859C0
		public KSCBaseProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x06008DFE RID: 36350 RVA: 0x002877D0 File Offset: 0x002859D0
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

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x06008DFF RID: 36351 RVA: 0x0028780C File Offset: 0x00285A0C
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

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x06008E00 RID: 36352 RVA: 0x00287848 File Offset: 0x00285A48
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

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x06008E01 RID: 36353 RVA: 0x00287884 File Offset: 0x00285A84
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

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x06008E02 RID: 36354 RVA: 0x002878C4 File Offset: 0x00285AC4
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

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x06008E03 RID: 36355 RVA: 0x00287904 File Offset: 0x00285B04
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

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x06008E04 RID: 36356 RVA: 0x00287944 File Offset: 0x00285B44
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

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x06008E05 RID: 36357 RVA: 0x00287984 File Offset: 0x00285B84
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

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06008E06 RID: 36358 RVA: 0x002879C4 File Offset: 0x00285BC4
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

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06008E07 RID: 36359 RVA: 0x00287A08 File Offset: 0x00285C08
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

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06008E08 RID: 36360 RVA: 0x00287A48 File Offset: 0x00285C48
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

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06008E09 RID: 36361 RVA: 0x00287A88 File Offset: 0x00285C88
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

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06008E0A RID: 36362 RVA: 0x00287AC8 File Offset: 0x00285CC8
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

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x06008E0B RID: 36363 RVA: 0x00287B08 File Offset: 0x00285D08
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

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x06008E0C RID: 36364 RVA: 0x00287B48 File Offset: 0x00285D48
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

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x06008E0D RID: 36365 RVA: 0x00287B88 File Offset: 0x00285D88
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

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06008E0E RID: 36366 RVA: 0x00287BC8 File Offset: 0x00285DC8
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

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06008E0F RID: 36367 RVA: 0x00287C08 File Offset: 0x00285E08
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

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06008E10 RID: 36368 RVA: 0x00287C48 File Offset: 0x00285E48
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

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06008E11 RID: 36369 RVA: 0x00287C88 File Offset: 0x00285E88
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

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x06008E12 RID: 36370 RVA: 0x00287CC8 File Offset: 0x00285EC8
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

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x06008E13 RID: 36371 RVA: 0x00287D08 File Offset: 0x00285F08
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

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x06008E14 RID: 36372 RVA: 0x00287D48 File Offset: 0x00285F48
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

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x06008E15 RID: 36373 RVA: 0x00287D88 File Offset: 0x00285F88
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

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x06008E16 RID: 36374 RVA: 0x00287DC8 File Offset: 0x00285FC8
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

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x06008E17 RID: 36375 RVA: 0x00287E08 File Offset: 0x00286008
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

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x06008E18 RID: 36376 RVA: 0x00287E48 File Offset: 0x00286048
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

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x06008E19 RID: 36377 RVA: 0x00287E88 File Offset: 0x00286088
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

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x06008E1A RID: 36378 RVA: 0x00287EC8 File Offset: 0x002860C8
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

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x06008E1B RID: 36379 RVA: 0x00287F08 File Offset: 0x00286108
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

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x06008E1C RID: 36380 RVA: 0x00287F48 File Offset: 0x00286148
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

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x06008E1D RID: 36381 RVA: 0x00287F88 File Offset: 0x00286188
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

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x06008E1E RID: 36382 RVA: 0x00287FC8 File Offset: 0x002861C8
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

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x06008E1F RID: 36383 RVA: 0x00288008 File Offset: 0x00286208
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

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x06008E20 RID: 36384 RVA: 0x00288048 File Offset: 0x00286248
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

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x06008E21 RID: 36385 RVA: 0x00288088 File Offset: 0x00286288
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

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x06008E22 RID: 36386 RVA: 0x002880C8 File Offset: 0x002862C8
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

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x06008E23 RID: 36387 RVA: 0x00288108 File Offset: 0x00286308
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

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x06008E24 RID: 36388 RVA: 0x00288148 File Offset: 0x00286348
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

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x06008E25 RID: 36389 RVA: 0x00288188 File Offset: 0x00286388
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

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x06008E26 RID: 36390 RVA: 0x002881C8 File Offset: 0x002863C8
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

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x06008E27 RID: 36391 RVA: 0x00288208 File Offset: 0x00286408
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

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x06008E28 RID: 36392 RVA: 0x0028824C File Offset: 0x0028644C
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

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x06008E29 RID: 36393 RVA: 0x0028828C File Offset: 0x0028648C
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

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x06008E2A RID: 36394 RVA: 0x002882CC File Offset: 0x002864CC
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

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x06008E2B RID: 36395 RVA: 0x0028830C File Offset: 0x0028650C
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

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x06008E2C RID: 36396 RVA: 0x00288350 File Offset: 0x00286550
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

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x06008E2D RID: 36397 RVA: 0x00288390 File Offset: 0x00286590
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

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x06008E2E RID: 36398 RVA: 0x002883D0 File Offset: 0x002865D0
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

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x06008E2F RID: 36399 RVA: 0x00288410 File Offset: 0x00286610
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

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x06008E30 RID: 36400 RVA: 0x00288450 File Offset: 0x00286650
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

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x06008E31 RID: 36401 RVA: 0x00288490 File Offset: 0x00286690
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

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x06008E32 RID: 36402 RVA: 0x002884D0 File Offset: 0x002866D0
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

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x06008E33 RID: 36403 RVA: 0x00288510 File Offset: 0x00286710
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

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x06008E34 RID: 36404 RVA: 0x00288550 File Offset: 0x00286750
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

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x06008E35 RID: 36405 RVA: 0x00288590 File Offset: 0x00286790
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

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x06008E36 RID: 36406 RVA: 0x002885D0 File Offset: 0x002867D0
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

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x06008E37 RID: 36407 RVA: 0x00288610 File Offset: 0x00286810
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

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x06008E38 RID: 36408 RVA: 0x00288650 File Offset: 0x00286850
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

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x06008E39 RID: 36409 RVA: 0x00288690 File Offset: 0x00286890
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

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x06008E3A RID: 36410 RVA: 0x002886D0 File Offset: 0x002868D0
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

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x06008E3B RID: 36411 RVA: 0x00288710 File Offset: 0x00286910
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

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x06008E3C RID: 36412 RVA: 0x00288750 File Offset: 0x00286950
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

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06008E3D RID: 36413 RVA: 0x00288790 File Offset: 0x00286990
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

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06008E3E RID: 36414 RVA: 0x002887D0 File Offset: 0x002869D0
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

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06008E3F RID: 36415 RVA: 0x00288810 File Offset: 0x00286A10
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

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x06008E40 RID: 36416 RVA: 0x00288850 File Offset: 0x00286A50
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

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06008E41 RID: 36417 RVA: 0x00288890 File Offset: 0x00286A90
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

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06008E42 RID: 36418 RVA: 0x002888D0 File Offset: 0x00286AD0
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

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06008E43 RID: 36419 RVA: 0x00288910 File Offset: 0x00286B10
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

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06008E44 RID: 36420 RVA: 0x00288950 File Offset: 0x00286B50
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

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06008E45 RID: 36421 RVA: 0x00288990 File Offset: 0x00286B90
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

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06008E46 RID: 36422 RVA: 0x002889D0 File Offset: 0x00286BD0
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

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06008E47 RID: 36423 RVA: 0x00288A10 File Offset: 0x00286C10
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

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x06008E48 RID: 36424 RVA: 0x00288A50 File Offset: 0x00286C50
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

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x06008E49 RID: 36425 RVA: 0x00288A90 File Offset: 0x00286C90
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

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06008E4A RID: 36426 RVA: 0x00288AD0 File Offset: 0x00286CD0
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

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06008E4B RID: 36427 RVA: 0x00288B10 File Offset: 0x00286D10
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

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06008E4C RID: 36428 RVA: 0x00288B50 File Offset: 0x00286D50
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

		// Token: 0x06008E4D RID: 36429 RVA: 0x00288B90 File Offset: 0x00286D90
		public bool TryGetMember(string key, out int value)
		{
			if (key != null)
			{
				switch (key.Length)
				{
				case 2:
				{
					char c = key[0];
					if (c != 'I')
					{
						if (c == 'L')
						{
							if (key == "Lv")
							{
								value = this.Lv;
								return true;
							}
						}
					}
					else if (key == "Id")
					{
						value = this.Id;
						return true;
					}
					break;
				}
				case 3:
				{
					char c = key[0];
					if (c != 'A')
					{
						if (c == 'D')
						{
							if (key == "Def")
							{
								value = this.Def;
								return true;
							}
						}
					}
					else if (key == "Atk")
					{
						value = this.Atk;
						return true;
					}
					break;
				}
				case 4:
				{
					char c = key[0];
					if (c != 'C')
					{
						if (c == 'L')
						{
							if (key == "Life")
							{
								value = this.Life;
								return true;
							}
						}
					}
					else if (key == "Crit")
					{
						value = this.Crit;
						return true;
					}
					break;
				}
				case 6:
					if (key == "Sheild")
					{
						value = this.Sheild;
						return true;
					}
					break;
				case 7:
				{
					char c = key[6];
					switch (c)
					{
					case '0':
						if (key == "Attr120")
						{
							value = this.Attr120;
							return true;
						}
						if (key == "Attr130")
						{
							value = this.Attr130;
							return true;
						}
						if (key == "Attr140")
						{
							value = this.Attr140;
							return true;
						}
						if (key == "Attr150")
						{
							value = this.Attr150;
							return true;
						}
						break;
					case '1':
						if (key == "Attr121")
						{
							value = this.Attr121;
							return true;
						}
						if (key == "Attr131")
						{
							value = this.Attr131;
							return true;
						}
						if (key == "Attr141")
						{
							value = this.Attr141;
							return true;
						}
						if (key == "Attr151")
						{
							value = this.Attr151;
							return true;
						}
						break;
					case '2':
						if (key == "Attr122")
						{
							value = this.Attr122;
							return true;
						}
						if (key == "Attr132")
						{
							value = this.Attr132;
							return true;
						}
						if (key == "Attr142")
						{
							value = this.Attr142;
							return true;
						}
						break;
					case '3':
						if (key == "Attr123")
						{
							value = this.Attr123;
							return true;
						}
						if (key == "Attr133")
						{
							value = this.Attr133;
							return true;
						}
						if (key == "Attr143")
						{
							value = this.Attr143;
							return true;
						}
						break;
					case '4':
						if (key == "Attr124")
						{
							value = this.Attr124;
							return true;
						}
						if (key == "Attr134")
						{
							value = this.Attr134;
							return true;
						}
						if (key == "Attr144")
						{
							value = this.Attr144;
							return true;
						}
						break;
					case '5':
						if (key == "Attr125")
						{
							value = this.Attr125;
							return true;
						}
						if (key == "Attr135")
						{
							value = this.Attr135;
							return true;
						}
						if (key == "Attr145")
						{
							value = this.Attr145;
							return true;
						}
						break;
					case '6':
						if (key == "Attr126")
						{
							value = this.Attr126;
							return true;
						}
						if (key == "Attr136")
						{
							value = this.Attr136;
							return true;
						}
						if (key == "Attr146")
						{
							value = this.Attr146;
							return true;
						}
						break;
					case '7':
						if (key == "Attr127")
						{
							value = this.Attr127;
							return true;
						}
						if (key == "Attr137")
						{
							value = this.Attr137;
							return true;
						}
						if (key == "Attr147")
						{
							value = this.Attr147;
							return true;
						}
						break;
					case '8':
						if (key == "Attr128")
						{
							value = this.Attr128;
							return true;
						}
						if (key == "Attr138")
						{
							value = this.Attr138;
							return true;
						}
						if (key == "Attr148")
						{
							value = this.Attr148;
							return true;
						}
						break;
					case '9':
						if (key == "Attr129")
						{
							value = this.Attr129;
							return true;
						}
						if (key == "Attr139")
						{
							value = this.Attr139;
							return true;
						}
						if (key == "Attr149")
						{
							value = this.Attr149;
							return true;
						}
						break;
					default:
						if (c == 'x')
						{
							if (key == "LifeMax")
							{
								value = this.LifeMax;
								return true;
							}
						}
						break;
					}
					break;
				}
				case 9:
					if (key == "MoveSpeed")
					{
						value = this.MoveSpeed;
						return true;
					}
					break;
				case 10:
				{
					char c = key[0];
					if (c != 'C')
					{
						if (c == 'H')
						{
							if (key == "HealChange")
							{
								value = this.HealChange;
								return true;
							}
						}
					}
					else if (key == "CritDamage")
					{
						value = this.CritDamage;
						return true;
					}
					break;
				}
				case 11:
					if (key == "AttackSpeed")
					{
						value = this.AttackSpeed;
						return true;
					}
					break;
				case 12:
					if (key == "HealedChange")
					{
						value = this.HealedChange;
						return true;
					}
					break;
				case 13:
				{
					char c = key[0];
					if (c != 'I')
					{
						if (c == 'S')
						{
							if (key == "SkillCoolDown")
							{
								value = this.SkillCoolDown;
								return true;
							}
						}
					}
					else if (key == "IgnoreDefRate")
					{
						value = this.IgnoreDefRate;
						return true;
					}
					break;
				}
				case 14:
				{
					char c = key[13];
					if (c != '1')
					{
						if (c == '2')
						{
							if (key == "DamageAmplify2")
							{
								value = this.DamageAmplify2;
								return true;
							}
						}
					}
					else if (key == "DamageAmplify1")
					{
						value = this.DamageAmplify1;
						return true;
					}
					break;
				}
				case 15:
					if (key == "KscGameplayType")
					{
						value = this.KscGameplayType;
						return true;
					}
					break;
				case 16:
				{
					char c = key[6];
					if (c != 'C')
					{
						if (c == 'R')
						{
							if (key == "DamageReducePhys")
							{
								value = this.DamageReducePhys;
								return true;
							}
						}
					}
					else if (key == "DamageChangePhys")
					{
						value = this.DamageChangePhys;
						return true;
					}
					break;
				}
				case 20:
				{
					char c = key[19];
					switch (c)
					{
					case '1':
						if (key == "DamageChangeElement1")
						{
							value = this.DamageChangeElement1;
							return true;
						}
						if (key == "DamageReduceElement1")
						{
							value = this.DamageReduceElement1;
							return true;
						}
						break;
					case '2':
						if (key == "DamageChangeElement2")
						{
							value = this.DamageChangeElement2;
							return true;
						}
						if (key == "DamageReduceElement2")
						{
							value = this.DamageReduceElement2;
							return true;
						}
						break;
					case '3':
						if (key == "DamageChangeElement3")
						{
							value = this.DamageChangeElement3;
							return true;
						}
						if (key == "DamageReduceElement3")
						{
							value = this.DamageReduceElement3;
							return true;
						}
						break;
					case '4':
						if (key == "DamageChangeElement4")
						{
							value = this.DamageChangeElement4;
							return true;
						}
						if (key == "DamageReduceElement4")
						{
							value = this.DamageReduceElement4;
							return true;
						}
						break;
					case '5':
						if (key == "DamageChangeElement5")
						{
							value = this.DamageChangeElement5;
							return true;
						}
						if (key == "DamageReduceElement5")
						{
							value = this.DamageReduceElement5;
							return true;
						}
						break;
					case '6':
						if (key == "DamageChangeElement6")
						{
							value = this.DamageChangeElement6;
							return true;
						}
						if (key == "DamageReduceElement6")
						{
							value = this.DamageReduceElement6;
							return true;
						}
						break;
					default:
						if (c == 's')
						{
							if (key == "DamageResistancePhys")
							{
								value = this.DamageResistancePhys;
								return true;
							}
						}
						break;
					}
					break;
				}
				case 22:
					if (key == "SkillCoolDownChangeMin")
					{
						value = this.SkillCoolDownChangeMin;
						return true;
					}
					break;
				case 24:
					switch (key[23])
					{
					case '1':
						if (key == "DamageResistanceElement1")
						{
							value = this.DamageResistanceElement1;
							return true;
						}
						break;
					case '2':
						if (key == "DamageResistanceElement2")
						{
							value = this.DamageResistanceElement2;
							return true;
						}
						break;
					case '3':
						if (key == "DamageResistanceElement3")
						{
							value = this.DamageResistanceElement3;
							return true;
						}
						break;
					case '4':
						if (key == "DamageResistanceElement4")
						{
							value = this.DamageResistanceElement4;
							return true;
						}
						break;
					case '5':
						if (key == "DamageResistanceElement5")
						{
							value = this.DamageResistanceElement5;
							return true;
						}
						break;
					case '6':
						if (key == "DamageResistanceElement6")
						{
							value = this.DamageResistanceElement6;
							return true;
						}
						break;
					}
					break;
				case 26:
					if (key == "IgnoreDamageResistancePhys")
					{
						value = this.IgnoreDamageResistancePhys;
						return true;
					}
					break;
				case 30:
					switch (key[29])
					{
					case '1':
						if (key == "IgnoreDamageResistanceElement1")
						{
							value = this.IgnoreDamageResistanceElement1;
							return true;
						}
						break;
					case '2':
						if (key == "IgnoreDamageResistanceElement2")
						{
							value = this.IgnoreDamageResistanceElement2;
							return true;
						}
						break;
					case '3':
						if (key == "IgnoreDamageResistanceElement3")
						{
							value = this.IgnoreDamageResistanceElement3;
							return true;
						}
						break;
					case '4':
						if (key == "IgnoreDamageResistanceElement4")
						{
							value = this.IgnoreDamageResistanceElement4;
							return true;
						}
						break;
					case '5':
						if (key == "IgnoreDamageResistanceElement5")
						{
							value = this.IgnoreDamageResistanceElement5;
							return true;
						}
						break;
					case '6':
						if (key == "IgnoreDamageResistanceElement6")
						{
							value = this.IgnoreDamageResistanceElement6;
							return true;
						}
						break;
					}
					break;
				}
			}
			value = 0;
			return false;
		}

		// Token: 0x04005401 RID: 21505
		private Table __p;
	}
}
