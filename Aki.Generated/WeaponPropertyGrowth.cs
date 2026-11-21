using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012CE RID: 4814
	public struct WeaponPropertyGrowth : IFlatbufferObject
	{
		// Token: 0x1700415F RID: 16735
		// (get) Token: 0x0600F56F RID: 62831 RVA: 0x0036DB72 File Offset: 0x0036BD72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F570 RID: 62832 RVA: 0x0036DB7F File Offset: 0x0036BD7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F571 RID: 62833 RVA: 0x0036DB88 File Offset: 0x0036BD88
		public static WeaponPropertyGrowth GetRootAsWeaponPropertyGrowth(ByteBuffer _bb)
		{
			return WeaponPropertyGrowth.GetRootAsWeaponPropertyGrowth(_bb, default(WeaponPropertyGrowth));
		}

		// Token: 0x0600F572 RID: 62834 RVA: 0x0036DBA4 File Offset: 0x0036BDA4
		public static WeaponPropertyGrowth GetRootAsWeaponPropertyGrowth(ByteBuffer _bb, WeaponPropertyGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F573 RID: 62835 RVA: 0x0036DBC1 File Offset: 0x0036BDC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F574 RID: 62836 RVA: 0x0036DBD0 File Offset: 0x0036BDD0
		public WeaponPropertyGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004160 RID: 16736
		// (get) Token: 0x0600F575 RID: 62837 RVA: 0x0036DBE0 File Offset: 0x0036BDE0
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

		// Token: 0x17004161 RID: 16737
		// (get) Token: 0x0600F576 RID: 62838 RVA: 0x0036DC1C File Offset: 0x0036BE1C
		public int CurveId
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

		// Token: 0x17004162 RID: 16738
		// (get) Token: 0x0600F577 RID: 62839 RVA: 0x0036DC58 File Offset: 0x0036BE58
		public int Level
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

		// Token: 0x17004163 RID: 16739
		// (get) Token: 0x0600F578 RID: 62840 RVA: 0x0036DC94 File Offset: 0x0036BE94
		public int BreachLevel
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

		// Token: 0x17004164 RID: 16740
		// (get) Token: 0x0600F579 RID: 62841 RVA: 0x0036DCD4 File Offset: 0x0036BED4
		public int CurveValue
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

		// Token: 0x04005926 RID: 22822
		private Table __p;
	}
}
