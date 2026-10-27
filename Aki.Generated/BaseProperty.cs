using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B27 RID: 2855
	public struct BaseProperty : IFlatbufferObject
	{
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06004BB9 RID: 19385 RVA: 0x001DEFFC File Offset: 0x001DD1FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x001DF009 File Offset: 0x001DD209
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x001DF010 File Offset: 0x001DD210
		public static BaseProperty GetRootAsBaseProperty(ByteBuffer _bb)
		{
			return BaseProperty.GetRootAsBaseProperty(_bb, default(BaseProperty));
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x001DF02C File Offset: 0x001DD22C
		public static BaseProperty GetRootAsBaseProperty(ByteBuffer _bb, BaseProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x001DF049 File Offset: 0x001DD249
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x001DF058 File Offset: 0x001DD258
		public BaseProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06004BBF RID: 19391 RVA: 0x001DF068 File Offset: 0x001DD268
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

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06004BC0 RID: 19392 RVA: 0x001DF0A4 File Offset: 0x001DD2A4
		public int Lv
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

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06004BC1 RID: 19393 RVA: 0x001DF0E0 File Offset: 0x001DD2E0
		public int LifeMax
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

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06004BC2 RID: 19394 RVA: 0x001DF11C File Offset: 0x001DD31C
		public int Life
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

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06004BC3 RID: 19395 RVA: 0x001DF15C File Offset: 0x001DD35C
		public int Sheild
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

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06004BC4 RID: 19396 RVA: 0x001DF19C File Offset: 0x001DD39C
		public int SheildDamageChange
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

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06004BC5 RID: 19397 RVA: 0x001DF1DC File Offset: 0x001DD3DC
		public int SheildDamageReduce
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

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06004BC6 RID: 19398 RVA: 0x001DF21C File Offset: 0x001DD41C
		public int Atk
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

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06004BC7 RID: 19399 RVA: 0x001DF25C File Offset: 0x001DD45C
		public int Crit
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

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06004BC8 RID: 19400 RVA: 0x001DF29C File Offset: 0x001DD49C
		public int CritDamage
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06004BC9 RID: 19401 RVA: 0x001DF2E0 File Offset: 0x001DD4E0
		public int Def
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

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06004BCA RID: 19402 RVA: 0x001DF320 File Offset: 0x001DD520
		public int EnergyEfficiency
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06004BCB RID: 19403 RVA: 0x001DF364 File Offset: 0x001DD564
		public int CdReduse
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06004BCC RID: 19404 RVA: 0x001DF3A8 File Offset: 0x001DD5A8
		public int DamageChangeNormalSkill
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

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06004BCD RID: 19405 RVA: 0x001DF3E8 File Offset: 0x001DD5E8
		public int DamageChange
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

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06004BCE RID: 19406 RVA: 0x001DF428 File Offset: 0x001DD628
		public int DamageReduce
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

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06004BCF RID: 19407 RVA: 0x001DF468 File Offset: 0x001DD668
		public int DamageChangeAuto
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

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06004BD0 RID: 19408 RVA: 0x001DF4A8 File Offset: 0x001DD6A8
		public int DamageChangeCast
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

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06004BD1 RID: 19409 RVA: 0x001DF4E8 File Offset: 0x001DD6E8
		public int DamageChangeUltra
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

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06004BD2 RID: 19410 RVA: 0x001DF528 File Offset: 0x001DD728
		public int DamageChangeQte
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

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06004BD3 RID: 19411 RVA: 0x001DF568 File Offset: 0x001DD768
		public int DamageChangePhys
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

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06004BD4 RID: 19412 RVA: 0x001DF5A8 File Offset: 0x001DD7A8
		public int DamageChangeElement1
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

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06004BD5 RID: 19413 RVA: 0x001DF5E8 File Offset: 0x001DD7E8
		public int DamageChangeElement2
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

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x001DF628 File Offset: 0x001DD828
		public int DamageChangeElement3
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

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06004BD7 RID: 19415 RVA: 0x001DF668 File Offset: 0x001DD868
		public int DamageChangeElement4
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

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06004BD8 RID: 19416 RVA: 0x001DF6A8 File Offset: 0x001DD8A8
		public int DamageChangeElement5
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

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06004BD9 RID: 19417 RVA: 0x001DF6E8 File Offset: 0x001DD8E8
		public int DamageChangeElement6
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

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06004BDA RID: 19418 RVA: 0x001DF728 File Offset: 0x001DD928
		public int DamageResistancePhys
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

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06004BDB RID: 19419 RVA: 0x001DF768 File Offset: 0x001DD968
		public int DamageResistanceElement1
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

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06004BDC RID: 19420 RVA: 0x001DF7A8 File Offset: 0x001DD9A8
		public int DamageResistanceElement2
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

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06004BDD RID: 19421 RVA: 0x001DF7E8 File Offset: 0x001DD9E8
		public int DamageResistanceElement3
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

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06004BDE RID: 19422 RVA: 0x001DF828 File Offset: 0x001DDA28
		public int DamageResistanceElement4
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

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06004BDF RID: 19423 RVA: 0x001DF868 File Offset: 0x001DDA68
		public int DamageResistanceElement5
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

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06004BE0 RID: 19424 RVA: 0x001DF8A8 File Offset: 0x001DDAA8
		public int DamageResistanceElement6
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

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06004BE1 RID: 19425 RVA: 0x001DF8E8 File Offset: 0x001DDAE8
		public int HealChange
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

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06004BE2 RID: 19426 RVA: 0x001DF928 File Offset: 0x001DDB28
		public int HealedChange
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

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06004BE3 RID: 19427 RVA: 0x001DF968 File Offset: 0x001DDB68
		public int DamageReducePhys
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

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06004BE4 RID: 19428 RVA: 0x001DF9A8 File Offset: 0x001DDBA8
		public int DamageReduceElement1
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

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06004BE5 RID: 19429 RVA: 0x001DF9E8 File Offset: 0x001DDBE8
		public int DamageReduceElement2
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

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x001DFA28 File Offset: 0x001DDC28
		public int DamageReduceElement3
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

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x001DFA68 File Offset: 0x001DDC68
		public int DamageReduceElement4
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

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06004BE8 RID: 19432 RVA: 0x001DFAA8 File Offset: 0x001DDCA8
		public int DamageReduceElement5
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06004BE9 RID: 19433 RVA: 0x001DFAE8 File Offset: 0x001DDCE8
		public int DamageReduceElement6
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

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06004BEA RID: 19434 RVA: 0x001DFB28 File Offset: 0x001DDD28
		public int EnergyMax
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06004BEB RID: 19435 RVA: 0x001DFB6C File Offset: 0x001DDD6C
		public int Energy
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

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06004BEC RID: 19436 RVA: 0x001DFBAC File Offset: 0x001DDDAC
		public int SpecialEnergy1Max
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06004BED RID: 19437 RVA: 0x001DFBEC File Offset: 0x001DDDEC
		public int SpecialEnergy1
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

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06004BEE RID: 19438 RVA: 0x001DFC2C File Offset: 0x001DDE2C
		public int SpecialEnergy2Max
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06004BEF RID: 19439 RVA: 0x001DFC6C File Offset: 0x001DDE6C
		public int SpecialEnergy2
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

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06004BF0 RID: 19440 RVA: 0x001DFCAC File Offset: 0x001DDEAC
		public int SpecialEnergy3Max
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06004BF1 RID: 19441 RVA: 0x001DFCEC File Offset: 0x001DDEEC
		public int SpecialEnergy3
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

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x001DFD2C File Offset: 0x001DDF2C
		public int SpecialEnergy4Max
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06004BF3 RID: 19443 RVA: 0x001DFD70 File Offset: 0x001DDF70
		public int SpecialEnergy4
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

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06004BF4 RID: 19444 RVA: 0x001DFDB0 File Offset: 0x001DDFB0
		public int SpecialEnergy5Max
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06004BF5 RID: 19445 RVA: 0x001DFDF4 File Offset: 0x001DDFF4
		public int SpecialEnergy5
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

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06004BF6 RID: 19446 RVA: 0x001DFE34 File Offset: 0x001DE034
		public int StrengthMax
		{
			get
			{
				int num = this.__p.__offset(114);
				if (num == 0)
				{
					return 14000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x001DFE78 File Offset: 0x001DE078
		public int Strength
		{
			get
			{
				int num = this.__p.__offset(116);
				if (num == 0)
				{
					return 14000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06004BF8 RID: 19448 RVA: 0x001DFEBC File Offset: 0x001DE0BC
		public int StrengthRecover
		{
			get
			{
				int num = this.__p.__offset(118);
				if (num == 0)
				{
					return 250;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x001DFF00 File Offset: 0x001DE100
		public int StrengthPunishTime
		{
			get
			{
				int num = this.__p.__offset(120);
				if (num == 0)
				{
					return 2000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06004BFA RID: 19450 RVA: 0x001DFF44 File Offset: 0x001DE144
		public int StrengthRun
		{
			get
			{
				int num = this.__p.__offset(122);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06004BFB RID: 19451 RVA: 0x001DFF84 File Offset: 0x001DE184
		public int StrengthSwim
		{
			get
			{
				int num = this.__p.__offset(124);
				if (num == 0)
				{
					return 26;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06004BFC RID: 19452 RVA: 0x001DFFC4 File Offset: 0x001DE1C4
		public int StrengthFastSwim
		{
			get
			{
				int num = this.__p.__offset(126);
				if (num == 0)
				{
					return 66;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06004BFD RID: 19453 RVA: 0x001E0004 File Offset: 0x001DE204
		public int HardnessMax
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

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06004BFE RID: 19454 RVA: 0x001E0044 File Offset: 0x001DE244
		public int Hardness
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

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06004BFF RID: 19455 RVA: 0x001E0084 File Offset: 0x001DE284
		public int HardnessRecover
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

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06004C00 RID: 19456 RVA: 0x001E00C4 File Offset: 0x001DE2C4
		public int HardnessPunishTime
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

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06004C01 RID: 19457 RVA: 0x001E0104 File Offset: 0x001DE304
		public int HardnessChange
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

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06004C02 RID: 19458 RVA: 0x001E0144 File Offset: 0x001DE344
		public int HardnessReduce
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

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06004C03 RID: 19459 RVA: 0x001E0184 File Offset: 0x001DE384
		public int RageMax
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

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06004C04 RID: 19460 RVA: 0x001E01C4 File Offset: 0x001DE3C4
		public int Rage
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

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06004C05 RID: 19461 RVA: 0x001E0204 File Offset: 0x001DE404
		public int RageRecover
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

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06004C06 RID: 19462 RVA: 0x001E0244 File Offset: 0x001DE444
		public int RagePunishTime
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

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06004C07 RID: 19463 RVA: 0x001E0284 File Offset: 0x001DE484
		public int RageChange
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

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06004C08 RID: 19464 RVA: 0x001E02C4 File Offset: 0x001DE4C4
		public int RageReduce
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

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06004C09 RID: 19465 RVA: 0x001E0304 File Offset: 0x001DE504
		public int ToughMax
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

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06004C0A RID: 19466 RVA: 0x001E0344 File Offset: 0x001DE544
		public int Tough
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

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06004C0B RID: 19467 RVA: 0x001E0384 File Offset: 0x001DE584
		public int ToughRecover
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

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06004C0C RID: 19468 RVA: 0x001E03C4 File Offset: 0x001DE5C4
		public int ToughChange
		{
			get
			{
				int num = this.__p.__offset(158);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06004C0D RID: 19469 RVA: 0x001E0408 File Offset: 0x001DE608
		public int ToughReduce
		{
			get
			{
				int num = this.__p.__offset(160);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06004C0E RID: 19470 RVA: 0x001E044C File Offset: 0x001DE64C
		public int ToughRecoverDelayTime
		{
			get
			{
				int num = this.__p.__offset(162);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06004C0F RID: 19471 RVA: 0x001E048C File Offset: 0x001DE68C
		public int ElementPower1
		{
			get
			{
				int num = this.__p.__offset(164);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06004C10 RID: 19472 RVA: 0x001E04CC File Offset: 0x001DE6CC
		public int ElementPower2
		{
			get
			{
				int num = this.__p.__offset(166);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x001E050C File Offset: 0x001DE70C
		public int ElementPower3
		{
			get
			{
				int num = this.__p.__offset(168);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06004C12 RID: 19474 RVA: 0x001E054C File Offset: 0x001DE74C
		public int ElementPower4
		{
			get
			{
				int num = this.__p.__offset(170);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06004C13 RID: 19475 RVA: 0x001E058C File Offset: 0x001DE78C
		public int ElementPower5
		{
			get
			{
				int num = this.__p.__offset(172);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06004C14 RID: 19476 RVA: 0x001E05CC File Offset: 0x001DE7CC
		public int ElementPower6
		{
			get
			{
				int num = this.__p.__offset(174);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06004C15 RID: 19477 RVA: 0x001E060C File Offset: 0x001DE80C
		public int SpecialDamageChange
		{
			get
			{
				int num = this.__p.__offset(176);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06004C16 RID: 19478 RVA: 0x001E064C File Offset: 0x001DE84C
		public int StrengthFastClimbCost
		{
			get
			{
				int num = this.__p.__offset(178);
				if (num == 0)
				{
					return 242;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06004C17 RID: 19479 RVA: 0x001E0690 File Offset: 0x001DE890
		public int ElementPropertyType
		{
			get
			{
				int num = this.__p.__offset(180);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06004C18 RID: 19480 RVA: 0x001E06D0 File Offset: 0x001DE8D0
		public int WeakTime
		{
			get
			{
				int num = this.__p.__offset(182);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06004C19 RID: 19481 RVA: 0x001E0710 File Offset: 0x001DE910
		public int IgnoreDefRate
		{
			get
			{
				int num = this.__p.__offset(184);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06004C1A RID: 19482 RVA: 0x001E0750 File Offset: 0x001DE950
		public int IgnoreDamageResistancePhys
		{
			get
			{
				int num = this.__p.__offset(186);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06004C1B RID: 19483 RVA: 0x001E0790 File Offset: 0x001DE990
		public int IgnoreDamageResistanceElement1
		{
			get
			{
				int num = this.__p.__offset(188);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06004C1C RID: 19484 RVA: 0x001E07D0 File Offset: 0x001DE9D0
		public int IgnoreDamageResistanceElement2
		{
			get
			{
				int num = this.__p.__offset(190);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06004C1D RID: 19485 RVA: 0x001E0810 File Offset: 0x001DEA10
		public int IgnoreDamageResistanceElement3
		{
			get
			{
				int num = this.__p.__offset(192);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06004C1E RID: 19486 RVA: 0x001E0850 File Offset: 0x001DEA50
		public int IgnoreDamageResistanceElement4
		{
			get
			{
				int num = this.__p.__offset(194);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06004C1F RID: 19487 RVA: 0x001E0890 File Offset: 0x001DEA90
		public int IgnoreDamageResistanceElement5
		{
			get
			{
				int num = this.__p.__offset(196);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06004C20 RID: 19488 RVA: 0x001E08D0 File Offset: 0x001DEAD0
		public int IgnoreDamageResistanceElement6
		{
			get
			{
				int num = this.__p.__offset(198);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06004C21 RID: 19489 RVA: 0x001E0910 File Offset: 0x001DEB10
		public int SkillToughRatio
		{
			get
			{
				int num = this.__p.__offset(200);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06004C22 RID: 19490 RVA: 0x001E0954 File Offset: 0x001DEB54
		public int StrengthClimbJump
		{
			get
			{
				int num = this.__p.__offset(202);
				if (num == 0)
				{
					return 1220;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06004C23 RID: 19491 RVA: 0x001E0998 File Offset: 0x001DEB98
		public int StrengthGliding
		{
			get
			{
				int num = this.__p.__offset(204);
				if (num == 0)
				{
					return 30;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06004C24 RID: 19492 RVA: 0x001E09DC File Offset: 0x001DEBDC
		public int Mass
		{
			get
			{
				int num = this.__p.__offset(206);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06004C25 RID: 19493 RVA: 0x001E0A20 File Offset: 0x001DEC20
		public int BrakingFrictionFactor
		{
			get
			{
				int num = this.__p.__offset(208);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06004C26 RID: 19494 RVA: 0x001E0A64 File Offset: 0x001DEC64
		public int GravityScale
		{
			get
			{
				int num = this.__p.__offset(210);
				if (num == 0)
				{
					return 20000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06004C27 RID: 19495 RVA: 0x001E0AA8 File Offset: 0x001DECA8
		public int SpeedRatio
		{
			get
			{
				int num = this.__p.__offset(212);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06004C28 RID: 19496 RVA: 0x001E0AEC File Offset: 0x001DECEC
		public int DamageChangePhantom
		{
			get
			{
				int num = this.__p.__offset(214);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06004C29 RID: 19497 RVA: 0x001E0B2C File Offset: 0x001DED2C
		public int AutoAttackSpeed
		{
			get
			{
				int num = this.__p.__offset(216);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06004C2A RID: 19498 RVA: 0x001E0B70 File Offset: 0x001DED70
		public int CastAttackSpeed
		{
			get
			{
				int num = this.__p.__offset(218);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06004C2B RID: 19499 RVA: 0x001E0BB4 File Offset: 0x001DEDB4
		public int StatusBuildUp1Max
		{
			get
			{
				int num = this.__p.__offset(220);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06004C2C RID: 19500 RVA: 0x001E0BF8 File Offset: 0x001DEDF8
		public int StatusBuildUp1
		{
			get
			{
				int num = this.__p.__offset(222);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06004C2D RID: 19501 RVA: 0x001E0C38 File Offset: 0x001DEE38
		public int StatusBuildUp2Max
		{
			get
			{
				int num = this.__p.__offset(224);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06004C2E RID: 19502 RVA: 0x001E0C7C File Offset: 0x001DEE7C
		public int StatusBuildUp2
		{
			get
			{
				int num = this.__p.__offset(226);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06004C2F RID: 19503 RVA: 0x001E0CBC File Offset: 0x001DEEBC
		public int StatusBuildUp3Max
		{
			get
			{
				int num = this.__p.__offset(228);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06004C30 RID: 19504 RVA: 0x001E0D00 File Offset: 0x001DEF00
		public int StatusBuildUp3
		{
			get
			{
				int num = this.__p.__offset(230);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06004C31 RID: 19505 RVA: 0x001E0D40 File Offset: 0x001DEF40
		public int StatusBuildUp4Max
		{
			get
			{
				int num = this.__p.__offset(232);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06004C32 RID: 19506 RVA: 0x001E0D84 File Offset: 0x001DEF84
		public int StatusBuildUp4
		{
			get
			{
				int num = this.__p.__offset(234);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06004C33 RID: 19507 RVA: 0x001E0DC4 File Offset: 0x001DEFC4
		public int StatusBuildUp5Max
		{
			get
			{
				int num = this.__p.__offset(236);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06004C34 RID: 19508 RVA: 0x001E0E08 File Offset: 0x001DF008
		public int StatusBuildUp5
		{
			get
			{
				int num = this.__p.__offset(238);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06004C35 RID: 19509 RVA: 0x001E0E48 File Offset: 0x001DF048
		public int ParalysisTimeMax
		{
			get
			{
				int num = this.__p.__offset(240);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06004C36 RID: 19510 RVA: 0x001E0E88 File Offset: 0x001DF088
		public int ParalysisTime
		{
			get
			{
				int num = this.__p.__offset(242);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06004C37 RID: 19511 RVA: 0x001E0EC8 File Offset: 0x001DF0C8
		public int ParalysisTimeRecover
		{
			get
			{
				int num = this.__p.__offset(244);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06004C38 RID: 19512 RVA: 0x001E0F08 File Offset: 0x001DF108
		public int ElementEnergyMax
		{
			get
			{
				int num = this.__p.__offset(246);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06004C39 RID: 19513 RVA: 0x001E0F4C File Offset: 0x001DF14C
		public int ElementEnergy
		{
			get
			{
				int num = this.__p.__offset(248);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06004C3A RID: 19514 RVA: 0x001E0F8C File Offset: 0x001DF18C
		public int ElementEfficiency
		{
			get
			{
				int num = this.__p.__offset(250);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06004C3B RID: 19515 RVA: 0x001E0FD0 File Offset: 0x001DF1D0
		public int WeaknessBuildUp
		{
			get
			{
				int num = this.__p.__offset(252);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06004C3C RID: 19516 RVA: 0x001E1010 File Offset: 0x001DF210
		public int WeaknessBuildUpMax
		{
			get
			{
				int num = this.__p.__offset(254);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06004C3D RID: 19517 RVA: 0x001E1054 File Offset: 0x001DF254
		public int WeaknessTotalBonus
		{
			get
			{
				int num = this.__p.__offset(256);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06004C3E RID: 19518 RVA: 0x001E1094 File Offset: 0x001DF294
		public int BreakWeaknessRatio
		{
			get
			{
				int num = this.__p.__offset(258);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06004C3F RID: 19519 RVA: 0x001E10D8 File Offset: 0x001DF2D8
		public int WeaknessMastery
		{
			get
			{
				int num = this.__p.__offset(260);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004B19 RID: 19225
		private Table __p;
	}
}
