using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC1 RID: 3265
	public struct DangoSkillEffect : IFlatbufferObject
	{
		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x060066AD RID: 26285 RVA: 0x0022FCEE File Offset: 0x0022DEEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x0022FCFB File Offset: 0x0022DEFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x0022FD04 File Offset: 0x0022DF04
		public static DangoSkillEffect GetRootAsDangoSkillEffect(ByteBuffer _bb)
		{
			return DangoSkillEffect.GetRootAsDangoSkillEffect(_bb, default(DangoSkillEffect));
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x0022FD20 File Offset: 0x0022DF20
		public static DangoSkillEffect GetRootAsDangoSkillEffect(ByteBuffer _bb, DangoSkillEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x0022FD3D File Offset: 0x0022DF3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x0022FD4C File Offset: 0x0022DF4C
		public DangoSkillEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060066B3 RID: 26291 RVA: 0x0022FD5C File Offset: 0x0022DF5C
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

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x060066B4 RID: 26292 RVA: 0x0022FD98 File Offset: 0x0022DF98
		public int TrigggerPerformance
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

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x060066B5 RID: 26293 RVA: 0x0022FDD4 File Offset: 0x0022DFD4
		public int Type
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

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x060066B6 RID: 26294 RVA: 0x0022FE10 File Offset: 0x0022E010
		public int TrigggerTiming
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

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x060066B7 RID: 26295 RVA: 0x0022FE50 File Offset: 0x0022E050
		public int ShowTime
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

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060066B8 RID: 26296 RVA: 0x0022FE90 File Offset: 0x0022E090
		public int ParamNum
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

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060066B9 RID: 26297 RVA: 0x0022FED0 File Offset: 0x0022E0D0
		public bool NeedPerformance
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060066BA RID: 26298 RVA: 0x0022FF10 File Offset: 0x0022E110
		public int PerformanceType
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

		// Token: 0x040051EE RID: 20974
		private Table __p;
	}
}
