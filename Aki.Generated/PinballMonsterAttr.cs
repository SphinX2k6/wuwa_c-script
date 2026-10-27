using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F30 RID: 3888
	public struct PinballMonsterAttr : IFlatbufferObject
	{
		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x0600AF66 RID: 44902 RVA: 0x002C2CFD File Offset: 0x002C0EFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AF67 RID: 44903 RVA: 0x002C2D0A File Offset: 0x002C0F0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AF68 RID: 44904 RVA: 0x002C2D14 File Offset: 0x002C0F14
		public static PinballMonsterAttr GetRootAsPinballMonsterAttr(ByteBuffer _bb)
		{
			return PinballMonsterAttr.GetRootAsPinballMonsterAttr(_bb, default(PinballMonsterAttr));
		}

		// Token: 0x0600AF69 RID: 44905 RVA: 0x002C2D30 File Offset: 0x002C0F30
		public static PinballMonsterAttr GetRootAsPinballMonsterAttr(ByteBuffer _bb, PinballMonsterAttr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AF6A RID: 44906 RVA: 0x002C2D4D File Offset: 0x002C0F4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AF6B RID: 44907 RVA: 0x002C2D5C File Offset: 0x002C0F5C
		public PinballMonsterAttr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x0600AF6C RID: 44908 RVA: 0x002C2D6C File Offset: 0x002C0F6C
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

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x0600AF6D RID: 44909 RVA: 0x002C2DA8 File Offset: 0x002C0FA8
		public int Life
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x0600AF6E RID: 44910 RVA: 0x002C2DE4 File Offset: 0x002C0FE4
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

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x0600AF6F RID: 44911 RVA: 0x002C2E20 File Offset: 0x002C1020
		public int Atk
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

		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x0600AF70 RID: 44912 RVA: 0x002C2E60 File Offset: 0x002C1060
		public int Def
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

		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x0600AF71 RID: 44913 RVA: 0x002C2EA0 File Offset: 0x002C10A0
		public int Crit
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

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x0600AF72 RID: 44914 RVA: 0x002C2EE0 File Offset: 0x002C10E0
		public int CritDamage
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

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x0600AF73 RID: 44915 RVA: 0x002C2F20 File Offset: 0x002C1120
		public int DamageAmplify1
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

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x0600AF74 RID: 44916 RVA: 0x002C2F60 File Offset: 0x002C1160
		public int DamageReduce
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

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x0600AF75 RID: 44917 RVA: 0x002C2FA0 File Offset: 0x002C11A0
		public int DamageReduceAuto
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

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x0600AF76 RID: 44918 RVA: 0x002C2FE0 File Offset: 0x002C11E0
		public int DamageReduceStrong
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

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x0600AF77 RID: 44919 RVA: 0x002C3020 File Offset: 0x002C1220
		public int DamageReduceSkill
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

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x0600AF78 RID: 44920 RVA: 0x002C3060 File Offset: 0x002C1260
		public int DamageReduceSprint
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

		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x0600AF79 RID: 44921 RVA: 0x002C30A0 File Offset: 0x002C12A0
		public int DamageReduceSummon
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

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x0600AF7A RID: 44922 RVA: 0x002C30E0 File Offset: 0x002C12E0
		public int ProtectMax
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004FFA RID: 20474
		private Table __p;
	}
}
