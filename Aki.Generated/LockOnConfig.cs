using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EBC RID: 3772
	public struct LockOnConfig : IFlatbufferObject
	{
		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x0600955C RID: 38236 RVA: 0x002989C8 File Offset: 0x00296BC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600955D RID: 38237 RVA: 0x002989D5 File Offset: 0x00296BD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600955E RID: 38238 RVA: 0x002989DC File Offset: 0x00296BDC
		public static LockOnConfig GetRootAsLockOnConfig(ByteBuffer _bb)
		{
			return LockOnConfig.GetRootAsLockOnConfig(_bb, default(LockOnConfig));
		}

		// Token: 0x0600955F RID: 38239 RVA: 0x002989F8 File Offset: 0x00296BF8
		public static LockOnConfig GetRootAsLockOnConfig(ByteBuffer _bb, LockOnConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009560 RID: 38240 RVA: 0x00298A15 File Offset: 0x00296C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009561 RID: 38241 RVA: 0x00298A24 File Offset: 0x00296C24
		public LockOnConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x06009562 RID: 38242 RVA: 0x00298A34 File Offset: 0x00296C34
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

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06009563 RID: 38243 RVA: 0x00298A70 File Offset: 0x00296C70
		public int Distance
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

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x06009564 RID: 38244 RVA: 0x00298AAC File Offset: 0x00296CAC
		public int UpDistance
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 300;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x06009565 RID: 38245 RVA: 0x00298AEC File Offset: 0x00296CEC
		public int DownDistance
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 800;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06009566 RID: 38246 RVA: 0x00298B30 File Offset: 0x00296D30
		public int SectorRadius
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

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06009567 RID: 38247 RVA: 0x00298B70 File Offset: 0x00296D70
		public int SectorAngle
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

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06009568 RID: 38248 RVA: 0x00298BB0 File Offset: 0x00296DB0
		public float ToleranceAngle
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 22.5f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005457 RID: 21591
		private Table __p;
	}
}
