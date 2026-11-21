using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E76 RID: 3702
	public struct KSCDamage : IFlatbufferObject
	{
		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06008E58 RID: 36440 RVA: 0x002897E1 File Offset: 0x002879E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E59 RID: 36441 RVA: 0x002897EE File Offset: 0x002879EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E5A RID: 36442 RVA: 0x002897F8 File Offset: 0x002879F8
		public static KSCDamage GetRootAsKSCDamage(ByteBuffer _bb)
		{
			return KSCDamage.GetRootAsKSCDamage(_bb, default(KSCDamage));
		}

		// Token: 0x06008E5B RID: 36443 RVA: 0x00289814 File Offset: 0x00287A14
		public static KSCDamage GetRootAsKSCDamage(ByteBuffer _bb, KSCDamage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E5C RID: 36444 RVA: 0x00289831 File Offset: 0x00287A31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E5D RID: 36445 RVA: 0x00289840 File Offset: 0x00287A40
		public KSCDamage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x06008E5E RID: 36446 RVA: 0x00289850 File Offset: 0x00287A50
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x06008E5F RID: 36447 RVA: 0x00289898 File Offset: 0x00287A98
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

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x06008E60 RID: 36448 RVA: 0x002898D4 File Offset: 0x00287AD4
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

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06008E61 RID: 36449 RVA: 0x00289910 File Offset: 0x00287B10
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

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06008E62 RID: 36450 RVA: 0x00289950 File Offset: 0x00287B50
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

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x06008E63 RID: 36451 RVA: 0x00289990 File Offset: 0x00287B90
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

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x06008E64 RID: 36452 RVA: 0x002899D0 File Offset: 0x00287BD0
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

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x06008E65 RID: 36453 RVA: 0x00289A10 File Offset: 0x00287C10
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

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x06008E66 RID: 36454 RVA: 0x00289A50 File Offset: 0x00287C50
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

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x06008E67 RID: 36455 RVA: 0x00289A90 File Offset: 0x00287C90
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

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x06008E68 RID: 36456 RVA: 0x00289AD0 File Offset: 0x00287CD0
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

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06008E69 RID: 36457 RVA: 0x00289B10 File Offset: 0x00287D10
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

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06008E6A RID: 36458 RVA: 0x00289B50 File Offset: 0x00287D50
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

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06008E6B RID: 36459 RVA: 0x00289B90 File Offset: 0x00287D90
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

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06008E6C RID: 36460 RVA: 0x00289BD0 File Offset: 0x00287DD0
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

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06008E6D RID: 36461 RVA: 0x00289C10 File Offset: 0x00287E10
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

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x06008E6E RID: 36462 RVA: 0x00289C50 File Offset: 0x00287E50
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

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x06008E6F RID: 36463 RVA: 0x00289C90 File Offset: 0x00287E90
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

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06008E70 RID: 36464 RVA: 0x00289CD0 File Offset: 0x00287ED0
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

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06008E71 RID: 36465 RVA: 0x00289D10 File Offset: 0x00287F10
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

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06008E72 RID: 36466 RVA: 0x00289D50 File Offset: 0x00287F50
		public bool Knocked
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x06008E73 RID: 36467 RVA: 0x00289D90 File Offset: 0x00287F90
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

		// Token: 0x04005403 RID: 21507
		private Table __p;
	}
}
