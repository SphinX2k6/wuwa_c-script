using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C07 RID: 3079
	public struct BaseProperty : IFlatbufferObject
	{
		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600517B RID: 20859 RVA: 0x001FF414 File Offset: 0x001FD614
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x001FF421 File Offset: 0x001FD621
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x001FF428 File Offset: 0x001FD628
		public static BaseProperty GetRootAsBaseProperty(ByteBuffer _bb)
		{
			return BaseProperty.GetRootAsBaseProperty(_bb, default(BaseProperty));
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x001FF444 File Offset: 0x001FD644
		public static BaseProperty GetRootAsBaseProperty(ByteBuffer _bb, BaseProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x001FF461 File Offset: 0x001FD661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005180 RID: 20864 RVA: 0x001FF470 File Offset: 0x001FD670
		public BaseProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06005181 RID: 20865 RVA: 0x001FF480 File Offset: 0x001FD680
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

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06005182 RID: 20866 RVA: 0x001FF4BC File Offset: 0x001FD6BC
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

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06005183 RID: 20867 RVA: 0x001FF4F8 File Offset: 0x001FD6F8
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

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06005184 RID: 20868 RVA: 0x001FF534 File Offset: 0x001FD734
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

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06005185 RID: 20869 RVA: 0x001FF574 File Offset: 0x001FD774
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

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06005186 RID: 20870 RVA: 0x001FF5B4 File Offset: 0x001FD7B4
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

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06005187 RID: 20871 RVA: 0x001FF5F4 File Offset: 0x001FD7F4
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

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06005188 RID: 20872 RVA: 0x001FF634 File Offset: 0x001FD834
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

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06005189 RID: 20873 RVA: 0x001FF674 File Offset: 0x001FD874
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

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600518A RID: 20874 RVA: 0x001FF6B4 File Offset: 0x001FD8B4
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

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600518B RID: 20875 RVA: 0x001FF6F8 File Offset: 0x001FD8F8
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

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600518C RID: 20876 RVA: 0x001FF738 File Offset: 0x001FD938
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

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600518D RID: 20877 RVA: 0x001FF77C File Offset: 0x001FD97C
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

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600518E RID: 20878 RVA: 0x001FF7C0 File Offset: 0x001FD9C0
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

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600518F RID: 20879 RVA: 0x001FF800 File Offset: 0x001FDA00
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

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06005190 RID: 20880 RVA: 0x001FF840 File Offset: 0x001FDA40
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

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06005191 RID: 20881 RVA: 0x001FF880 File Offset: 0x001FDA80
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

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06005192 RID: 20882 RVA: 0x001FF8C0 File Offset: 0x001FDAC0
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

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06005193 RID: 20883 RVA: 0x001FF900 File Offset: 0x001FDB00
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

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06005194 RID: 20884 RVA: 0x001FF940 File Offset: 0x001FDB40
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

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06005195 RID: 20885 RVA: 0x001FF980 File Offset: 0x001FDB80
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

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06005196 RID: 20886 RVA: 0x001FF9C0 File Offset: 0x001FDBC0
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

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06005197 RID: 20887 RVA: 0x001FFA00 File Offset: 0x001FDC00
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

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06005198 RID: 20888 RVA: 0x001FFA40 File Offset: 0x001FDC40
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

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06005199 RID: 20889 RVA: 0x001FFA80 File Offset: 0x001FDC80
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

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600519A RID: 20890 RVA: 0x001FFAC0 File Offset: 0x001FDCC0
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

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600519B RID: 20891 RVA: 0x001FFB00 File Offset: 0x001FDD00
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

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x0600519C RID: 20892 RVA: 0x001FFB40 File Offset: 0x001FDD40
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

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600519D RID: 20893 RVA: 0x001FFB80 File Offset: 0x001FDD80
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

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600519E RID: 20894 RVA: 0x001FFBC0 File Offset: 0x001FDDC0
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

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600519F RID: 20895 RVA: 0x001FFC00 File Offset: 0x001FDE00
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060051A0 RID: 20896 RVA: 0x001FFC40 File Offset: 0x001FDE40
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

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060051A1 RID: 20897 RVA: 0x001FFC80 File Offset: 0x001FDE80
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

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060051A2 RID: 20898 RVA: 0x001FFCC0 File Offset: 0x001FDEC0
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

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060051A3 RID: 20899 RVA: 0x001FFD00 File Offset: 0x001FDF00
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

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060051A4 RID: 20900 RVA: 0x001FFD40 File Offset: 0x001FDF40
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

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060051A5 RID: 20901 RVA: 0x001FFD80 File Offset: 0x001FDF80
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

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060051A6 RID: 20902 RVA: 0x001FFDC0 File Offset: 0x001FDFC0
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

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060051A7 RID: 20903 RVA: 0x001FFE00 File Offset: 0x001FE000
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

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060051A8 RID: 20904 RVA: 0x001FFE40 File Offset: 0x001FE040
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

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060051A9 RID: 20905 RVA: 0x001FFE80 File Offset: 0x001FE080
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

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060051AA RID: 20906 RVA: 0x001FFEC0 File Offset: 0x001FE0C0
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

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060051AB RID: 20907 RVA: 0x001FFF00 File Offset: 0x001FE100
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

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060051AC RID: 20908 RVA: 0x001FFF40 File Offset: 0x001FE140
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

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060051AD RID: 20909 RVA: 0x001FFF84 File Offset: 0x001FE184
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

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060051AE RID: 20910 RVA: 0x001FFFC4 File Offset: 0x001FE1C4
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

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060051AF RID: 20911 RVA: 0x00200004 File Offset: 0x001FE204
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

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060051B0 RID: 20912 RVA: 0x00200044 File Offset: 0x001FE244
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

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060051B1 RID: 20913 RVA: 0x00200084 File Offset: 0x001FE284
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

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x002000C4 File Offset: 0x001FE2C4
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

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060051B3 RID: 20915 RVA: 0x00200104 File Offset: 0x001FE304
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

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060051B4 RID: 20916 RVA: 0x00200144 File Offset: 0x001FE344
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

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060051B5 RID: 20917 RVA: 0x00200188 File Offset: 0x001FE388
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

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060051B6 RID: 20918 RVA: 0x002001C8 File Offset: 0x001FE3C8
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

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060051B7 RID: 20919 RVA: 0x0020020C File Offset: 0x001FE40C
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

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060051B8 RID: 20920 RVA: 0x0020024C File Offset: 0x001FE44C
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

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060051B9 RID: 20921 RVA: 0x00200290 File Offset: 0x001FE490
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

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060051BA RID: 20922 RVA: 0x002002D4 File Offset: 0x001FE4D4
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

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060051BB RID: 20923 RVA: 0x00200318 File Offset: 0x001FE518
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

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060051BC RID: 20924 RVA: 0x0020035C File Offset: 0x001FE55C
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

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060051BD RID: 20925 RVA: 0x0020039C File Offset: 0x001FE59C
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

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060051BE RID: 20926 RVA: 0x002003DC File Offset: 0x001FE5DC
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

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060051BF RID: 20927 RVA: 0x0020041C File Offset: 0x001FE61C
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

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060051C0 RID: 20928 RVA: 0x0020045C File Offset: 0x001FE65C
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

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060051C1 RID: 20929 RVA: 0x0020049C File Offset: 0x001FE69C
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060051C2 RID: 20930 RVA: 0x002004DC File Offset: 0x001FE6DC
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

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060051C3 RID: 20931 RVA: 0x0020051C File Offset: 0x001FE71C
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

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060051C4 RID: 20932 RVA: 0x0020055C File Offset: 0x001FE75C
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

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060051C5 RID: 20933 RVA: 0x0020059C File Offset: 0x001FE79C
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060051C6 RID: 20934 RVA: 0x002005DC File Offset: 0x001FE7DC
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

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060051C7 RID: 20935 RVA: 0x0020061C File Offset: 0x001FE81C
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060051C8 RID: 20936 RVA: 0x0020065C File Offset: 0x001FE85C
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

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060051C9 RID: 20937 RVA: 0x0020069C File Offset: 0x001FE89C
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

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060051CA RID: 20938 RVA: 0x002006DC File Offset: 0x001FE8DC
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

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060051CB RID: 20939 RVA: 0x0020071C File Offset: 0x001FE91C
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

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060051CC RID: 20940 RVA: 0x0020075C File Offset: 0x001FE95C
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

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060051CD RID: 20941 RVA: 0x0020079C File Offset: 0x001FE99C
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

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060051CE RID: 20942 RVA: 0x002007DC File Offset: 0x001FE9DC
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

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060051CF RID: 20943 RVA: 0x00200820 File Offset: 0x001FEA20
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

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060051D0 RID: 20944 RVA: 0x00200864 File Offset: 0x001FEA64
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

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060051D1 RID: 20945 RVA: 0x002008A4 File Offset: 0x001FEAA4
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

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060051D2 RID: 20946 RVA: 0x002008E4 File Offset: 0x001FEAE4
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

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060051D3 RID: 20947 RVA: 0x00200924 File Offset: 0x001FEB24
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

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060051D4 RID: 20948 RVA: 0x00200964 File Offset: 0x001FEB64
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060051D5 RID: 20949 RVA: 0x002009A4 File Offset: 0x001FEBA4
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

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060051D6 RID: 20950 RVA: 0x002009E4 File Offset: 0x001FEBE4
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060051D7 RID: 20951 RVA: 0x00200A24 File Offset: 0x001FEC24
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

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060051D8 RID: 20952 RVA: 0x00200A64 File Offset: 0x001FEC64
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

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060051D9 RID: 20953 RVA: 0x00200AA8 File Offset: 0x001FECA8
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

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060051DA RID: 20954 RVA: 0x00200AE8 File Offset: 0x001FECE8
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

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060051DB RID: 20955 RVA: 0x00200B28 File Offset: 0x001FED28
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

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060051DC RID: 20956 RVA: 0x00200B68 File Offset: 0x001FED68
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

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060051DD RID: 20957 RVA: 0x00200BA8 File Offset: 0x001FEDA8
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060051DE RID: 20958 RVA: 0x00200BE8 File Offset: 0x001FEDE8
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

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060051DF RID: 20959 RVA: 0x00200C28 File Offset: 0x001FEE28
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

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060051E0 RID: 20960 RVA: 0x00200C68 File Offset: 0x001FEE68
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

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060051E1 RID: 20961 RVA: 0x00200CA8 File Offset: 0x001FEEA8
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

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060051E2 RID: 20962 RVA: 0x00200CE8 File Offset: 0x001FEEE8
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

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060051E3 RID: 20963 RVA: 0x00200D28 File Offset: 0x001FEF28
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

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060051E4 RID: 20964 RVA: 0x00200D6C File Offset: 0x001FEF6C
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

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060051E5 RID: 20965 RVA: 0x00200DB0 File Offset: 0x001FEFB0
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

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060051E6 RID: 20966 RVA: 0x00200DF4 File Offset: 0x001FEFF4
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

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060051E7 RID: 20967 RVA: 0x00200E38 File Offset: 0x001FF038
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

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060051E8 RID: 20968 RVA: 0x00200E7C File Offset: 0x001FF07C
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060051E9 RID: 20969 RVA: 0x00200EC0 File Offset: 0x001FF0C0
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

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060051EA RID: 20970 RVA: 0x00200F04 File Offset: 0x001FF104
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

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060051EB RID: 20971 RVA: 0x00200F44 File Offset: 0x001FF144
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

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060051EC RID: 20972 RVA: 0x00200F88 File Offset: 0x001FF188
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

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060051ED RID: 20973 RVA: 0x00200FCC File Offset: 0x001FF1CC
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

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060051EE RID: 20974 RVA: 0x00201010 File Offset: 0x001FF210
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

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060051EF RID: 20975 RVA: 0x00201050 File Offset: 0x001FF250
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

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060051F0 RID: 20976 RVA: 0x00201094 File Offset: 0x001FF294
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060051F1 RID: 20977 RVA: 0x002010D4 File Offset: 0x001FF2D4
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

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060051F2 RID: 20978 RVA: 0x00201118 File Offset: 0x001FF318
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

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060051F3 RID: 20979 RVA: 0x00201158 File Offset: 0x001FF358
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

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060051F4 RID: 20980 RVA: 0x0020119C File Offset: 0x001FF39C
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

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060051F5 RID: 20981 RVA: 0x002011DC File Offset: 0x001FF3DC
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

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060051F6 RID: 20982 RVA: 0x00201220 File Offset: 0x001FF420
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

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060051F7 RID: 20983 RVA: 0x00201260 File Offset: 0x001FF460
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

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060051F8 RID: 20984 RVA: 0x002012A0 File Offset: 0x001FF4A0
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

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060051F9 RID: 20985 RVA: 0x002012E0 File Offset: 0x001FF4E0
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

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060051FA RID: 20986 RVA: 0x00201320 File Offset: 0x001FF520
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

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060051FB RID: 20987 RVA: 0x00201364 File Offset: 0x001FF564
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

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060051FC RID: 20988 RVA: 0x002013A4 File Offset: 0x001FF5A4
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

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060051FD RID: 20989 RVA: 0x002013E8 File Offset: 0x001FF5E8
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

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060051FE RID: 20990 RVA: 0x00201428 File Offset: 0x001FF628
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

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060051FF RID: 20991 RVA: 0x0020146C File Offset: 0x001FF66C
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

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06005200 RID: 20992 RVA: 0x002014AC File Offset: 0x001FF6AC
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

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06005201 RID: 20993 RVA: 0x002014F0 File Offset: 0x001FF6F0
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

		// Token: 0x040050F9 RID: 20729
		private Table __p;
	}
}
