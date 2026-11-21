using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012B0 RID: 4784
	public struct TrialWeaponInfo : IFlatbufferObject
	{
		// Token: 0x17004055 RID: 16469
		// (get) Token: 0x0600F2FD RID: 62205 RVA: 0x00367F33 File Offset: 0x00366133
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F2FE RID: 62206 RVA: 0x00367F40 File Offset: 0x00366140
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F2FF RID: 62207 RVA: 0x00367F48 File Offset: 0x00366148
		public static TrialWeaponInfo GetRootAsTrialWeaponInfo(ByteBuffer _bb)
		{
			return TrialWeaponInfo.GetRootAsTrialWeaponInfo(_bb, default(TrialWeaponInfo));
		}

		// Token: 0x0600F300 RID: 62208 RVA: 0x00367F64 File Offset: 0x00366164
		public static TrialWeaponInfo GetRootAsTrialWeaponInfo(ByteBuffer _bb, TrialWeaponInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F301 RID: 62209 RVA: 0x00367F81 File Offset: 0x00366181
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F302 RID: 62210 RVA: 0x00367F90 File Offset: 0x00366190
		public TrialWeaponInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004056 RID: 16470
		// (get) Token: 0x0600F303 RID: 62211 RVA: 0x00367FA0 File Offset: 0x003661A0
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

		// Token: 0x17004057 RID: 16471
		// (get) Token: 0x0600F304 RID: 62212 RVA: 0x00367FDC File Offset: 0x003661DC
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

		// Token: 0x17004058 RID: 16472
		// (get) Token: 0x0600F305 RID: 62213 RVA: 0x00368018 File Offset: 0x00366218
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

		// Token: 0x17004059 RID: 16473
		// (get) Token: 0x0600F306 RID: 62214 RVA: 0x00368054 File Offset: 0x00366254
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

		// Token: 0x1700405A RID: 16474
		// (get) Token: 0x0600F307 RID: 62215 RVA: 0x00368094 File Offset: 0x00366294
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

		// Token: 0x1700405B RID: 16475
		// (get) Token: 0x0600F308 RID: 62216 RVA: 0x003680D4 File Offset: 0x003662D4
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

		// Token: 0x04005903 RID: 22787
		private Table __p;
	}
}
