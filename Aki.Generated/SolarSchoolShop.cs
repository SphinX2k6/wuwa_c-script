using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001204 RID: 4612
	public struct SolarSchoolShop : IFlatbufferObject
	{
		// Token: 0x17003AA4 RID: 15012
		// (get) Token: 0x0600E3F3 RID: 58355 RVA: 0x003469E5 File Offset: 0x00344BE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E3F4 RID: 58356 RVA: 0x003469F2 File Offset: 0x00344BF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E3F5 RID: 58357 RVA: 0x003469FC File Offset: 0x00344BFC
		public static SolarSchoolShop GetRootAsSolarSchoolShop(ByteBuffer _bb)
		{
			return SolarSchoolShop.GetRootAsSolarSchoolShop(_bb, default(SolarSchoolShop));
		}

		// Token: 0x0600E3F6 RID: 58358 RVA: 0x00346A18 File Offset: 0x00344C18
		public static SolarSchoolShop GetRootAsSolarSchoolShop(ByteBuffer _bb, SolarSchoolShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E3F7 RID: 58359 RVA: 0x00346A35 File Offset: 0x00344C35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E3F8 RID: 58360 RVA: 0x00346A44 File Offset: 0x00344C44
		public SolarSchoolShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AA5 RID: 15013
		// (get) Token: 0x0600E3F9 RID: 58361 RVA: 0x00346A54 File Offset: 0x00344C54
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

		// Token: 0x17003AA6 RID: 15014
		// (get) Token: 0x0600E3FA RID: 58362 RVA: 0x00346A90 File Offset: 0x00344C90
		public int ActivityId
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

		// Token: 0x17003AA7 RID: 15015
		// (get) Token: 0x0600E3FB RID: 58363 RVA: 0x00346ACC File Offset: 0x00344CCC
		public int LocationId
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

		// Token: 0x17003AA8 RID: 15016
		// (get) Token: 0x0600E3FC RID: 58364 RVA: 0x00346B08 File Offset: 0x00344D08
		public int ClerkRoleId
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

		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x0600E3FD RID: 58365 RVA: 0x00346B48 File Offset: 0x00344D48
		public int OpenConditionId
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

		// Token: 0x17003AAA RID: 15018
		// (get) Token: 0x0600E3FE RID: 58366 RVA: 0x00346B88 File Offset: 0x00344D88
		public int RefreshIntervalDays
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

		// Token: 0x17003AAB RID: 15019
		// (get) Token: 0x0600E3FF RID: 58367 RVA: 0x00346BC8 File Offset: 0x00344DC8
		public int GroupMaxCount
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

		// Token: 0x04005842 RID: 22594
		private Table __p;
	}
}
