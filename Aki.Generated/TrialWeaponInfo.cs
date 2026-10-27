using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200117A RID: 4474
	public struct TrialWeaponInfo : IFlatbufferObject
	{
		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x0600E58F RID: 58767 RVA: 0x0033D139 File Offset: 0x0033B339
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E590 RID: 58768 RVA: 0x0033D146 File Offset: 0x0033B346
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E591 RID: 58769 RVA: 0x0033D150 File Offset: 0x0033B350
		public static TrialWeaponInfo GetRootAsTrialWeaponInfo(ByteBuffer _bb)
		{
			return TrialWeaponInfo.GetRootAsTrialWeaponInfo(_bb, default(TrialWeaponInfo));
		}

		// Token: 0x0600E592 RID: 58770 RVA: 0x0033D16C File Offset: 0x0033B36C
		public static TrialWeaponInfo GetRootAsTrialWeaponInfo(ByteBuffer _bb, TrialWeaponInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E593 RID: 58771 RVA: 0x0033D189 File Offset: 0x0033B389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E594 RID: 58772 RVA: 0x0033D198 File Offset: 0x0033B398
		public TrialWeaponInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x0600E595 RID: 58773 RVA: 0x0033D1A8 File Offset: 0x0033B3A8
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

		// Token: 0x17003CF3 RID: 15603
		// (get) Token: 0x0600E596 RID: 58774 RVA: 0x0033D1E4 File Offset: 0x0033B3E4
		public int WeaponId
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

		// Token: 0x17003CF4 RID: 15604
		// (get) Token: 0x0600E597 RID: 58775 RVA: 0x0033D220 File Offset: 0x0033B420
		public int WeaponLevel
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

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x0600E598 RID: 58776 RVA: 0x0033D25C File Offset: 0x0033B45C
		public int WeaponSkinId
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

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x0600E599 RID: 58777 RVA: 0x0033D29C File Offset: 0x0033B49C
		public int WeaponResonanceLevel
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

		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x0600E59A RID: 58778 RVA: 0x0033D2DC File Offset: 0x0033B4DC
		public int FullLevelTrialId
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

		// Token: 0x040052C0 RID: 21184
		private Table __p;
	}
}
