using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC9 RID: 2761
	public struct ActivityRecommend : IFlatbufferObject
	{
		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060043A0 RID: 17312 RVA: 0x001CCB84 File Offset: 0x001CAD84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x001CCB91 File Offset: 0x001CAD91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x001CCB98 File Offset: 0x001CAD98
		public static ActivityRecommend GetRootAsActivityRecommend(ByteBuffer _bb)
		{
			return ActivityRecommend.GetRootAsActivityRecommend(_bb, default(ActivityRecommend));
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x001CCBB4 File Offset: 0x001CADB4
		public static ActivityRecommend GetRootAsActivityRecommend(ByteBuffer _bb, ActivityRecommend obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x001CCBD1 File Offset: 0x001CADD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x001CCBE0 File Offset: 0x001CADE0
		public ActivityRecommend __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060043A6 RID: 17318 RVA: 0x001CCBF0 File Offset: 0x001CADF0
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

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060043A7 RID: 17319 RVA: 0x001CCC2C File Offset: 0x001CAE2C
		public int Type
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

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060043A8 RID: 17320 RVA: 0x001CCC68 File Offset: 0x001CAE68
		public int ActivityGroup
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

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060043A9 RID: 17321 RVA: 0x001CCCA4 File Offset: 0x001CAEA4
		public int Sort
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

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060043AA RID: 17322 RVA: 0x001CCCE4 File Offset: 0x001CAEE4
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x001CCD1C File Offset: 0x001CAF1C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x001CCD2C File Offset: 0x001CAF2C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060043AD RID: 17325 RVA: 0x001CCD44 File Offset: 0x001CAF44
		public string Title
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x001CCD7C File Offset: 0x001CAF7C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x001CCD8C File Offset: 0x001CAF8C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060043B0 RID: 17328 RVA: 0x001CCDA4 File Offset: 0x001CAFA4
		public string TagIcon
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x001CCDDC File Offset: 0x001CAFDC
		public Span<byte> GetTagIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x001CCDEC File Offset: 0x001CAFEC
		public byte[] GetTagIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060043B3 RID: 17331 RVA: 0x001CCE04 File Offset: 0x001CB004
		public int ShowReward
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

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060043B4 RID: 17332 RVA: 0x001CCE44 File Offset: 0x001CB044
		public int JumpParam
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

		// Token: 0x04004AA6 RID: 19110
		private Table __p;
	}
}
