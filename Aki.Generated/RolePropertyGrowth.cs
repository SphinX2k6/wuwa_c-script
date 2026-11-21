using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200113E RID: 4414
	public struct RolePropertyGrowth : IFlatbufferObject
	{
		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600D00F RID: 53263 RVA: 0x0031901F File Offset: 0x0031721F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D010 RID: 53264 RVA: 0x0031902C File Offset: 0x0031722C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D011 RID: 53265 RVA: 0x00319034 File Offset: 0x00317234
		public static RolePropertyGrowth GetRootAsRolePropertyGrowth(ByteBuffer _bb)
		{
			return RolePropertyGrowth.GetRootAsRolePropertyGrowth(_bb, default(RolePropertyGrowth));
		}

		// Token: 0x0600D012 RID: 53266 RVA: 0x00319050 File Offset: 0x00317250
		public static RolePropertyGrowth GetRootAsRolePropertyGrowth(ByteBuffer _bb, RolePropertyGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D013 RID: 53267 RVA: 0x0031906D File Offset: 0x0031726D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D014 RID: 53268 RVA: 0x0031907C File Offset: 0x0031727C
		public RolePropertyGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600D015 RID: 53269 RVA: 0x0031908C File Offset: 0x0031728C
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

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600D016 RID: 53270 RVA: 0x003190C8 File Offset: 0x003172C8
		public int Level
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

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600D017 RID: 53271 RVA: 0x00319104 File Offset: 0x00317304
		public int BreachLevel
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

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600D018 RID: 53272 RVA: 0x00319140 File Offset: 0x00317340
		public int LifeMaxRatio
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

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600D019 RID: 53273 RVA: 0x00319180 File Offset: 0x00317380
		public int AtkRatio
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

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600D01A RID: 53274 RVA: 0x003191C0 File Offset: 0x003173C0
		public int DefRatio
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

		// Token: 0x0400573F RID: 22335
		private Table __p;
	}
}
