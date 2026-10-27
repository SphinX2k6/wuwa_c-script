using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001198 RID: 4504
	public struct WeaponPropertyGrowth : IFlatbufferObject
	{
		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x0600E801 RID: 59393 RVA: 0x00342E16 File Offset: 0x00341016
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E802 RID: 59394 RVA: 0x00342E23 File Offset: 0x00341023
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E803 RID: 59395 RVA: 0x00342E2C File Offset: 0x0034102C
		public static WeaponPropertyGrowth GetRootAsWeaponPropertyGrowth(ByteBuffer _bb)
		{
			return WeaponPropertyGrowth.GetRootAsWeaponPropertyGrowth(_bb, default(WeaponPropertyGrowth));
		}

		// Token: 0x0600E804 RID: 59396 RVA: 0x00342E48 File Offset: 0x00341048
		public static WeaponPropertyGrowth GetRootAsWeaponPropertyGrowth(ByteBuffer _bb, WeaponPropertyGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E805 RID: 59397 RVA: 0x00342E65 File Offset: 0x00341065
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E806 RID: 59398 RVA: 0x00342E74 File Offset: 0x00341074
		public WeaponPropertyGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x0600E807 RID: 59399 RVA: 0x00342E84 File Offset: 0x00341084
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

		// Token: 0x17003DFD RID: 15869
		// (get) Token: 0x0600E808 RID: 59400 RVA: 0x00342EC0 File Offset: 0x003410C0
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

		// Token: 0x17003DFE RID: 15870
		// (get) Token: 0x0600E809 RID: 59401 RVA: 0x00342EFC File Offset: 0x003410FC
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

		// Token: 0x17003DFF RID: 15871
		// (get) Token: 0x0600E80A RID: 59402 RVA: 0x00342F38 File Offset: 0x00341138
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

		// Token: 0x17003E00 RID: 15872
		// (get) Token: 0x0600E80B RID: 59403 RVA: 0x00342F78 File Offset: 0x00341178
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

		// Token: 0x040052E3 RID: 21219
		private Table __p;
	}
}
