using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F6F RID: 3951
	public struct NewTowerBossBuff : IFlatbufferObject
	{
		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x0600A51B RID: 42267 RVA: 0x002BABF0 File Offset: 0x002B8DF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x002BABFD File Offset: 0x002B8DFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A51D RID: 42269 RVA: 0x002BAC04 File Offset: 0x002B8E04
		public static NewTowerBossBuff GetRootAsNewTowerBossBuff(ByteBuffer _bb)
		{
			return NewTowerBossBuff.GetRootAsNewTowerBossBuff(_bb, default(NewTowerBossBuff));
		}

		// Token: 0x0600A51E RID: 42270 RVA: 0x002BAC20 File Offset: 0x002B8E20
		public static NewTowerBossBuff GetRootAsNewTowerBossBuff(ByteBuffer _bb, NewTowerBossBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A51F RID: 42271 RVA: 0x002BAC3D File Offset: 0x002B8E3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A520 RID: 42272 RVA: 0x002BAC4C File Offset: 0x002B8E4C
		public NewTowerBossBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x0600A521 RID: 42273 RVA: 0x002BAC5C File Offset: 0x002B8E5C
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

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x0600A522 RID: 42274 RVA: 0x002BAC98 File Offset: 0x002B8E98
		public string SkillBgQuality
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A523 RID: 42275 RVA: 0x002BACCF File Offset: 0x002B8ECF
		public Span<byte> GetSkillBgQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A524 RID: 42276 RVA: 0x002BACDE File Offset: 0x002B8EDE
		public byte[] GetSkillBgQualityArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x0600A525 RID: 42277 RVA: 0x002BACF8 File Offset: 0x002B8EF8
		public string SkillIconBgQuality
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A526 RID: 42278 RVA: 0x002BAD2F File Offset: 0x002B8F2F
		public Span<byte> GetSkillIconBgQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A527 RID: 42279 RVA: 0x002BAD3E File Offset: 0x002B8F3E
		public byte[] GetSkillIconBgQualityArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x0600A528 RID: 42280 RVA: 0x002BAD58 File Offset: 0x002B8F58
		public string DetailTipBgQuality
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A529 RID: 42281 RVA: 0x002BAD90 File Offset: 0x002B8F90
		public Span<byte> GetDetailTipBgQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A52A RID: 42282 RVA: 0x002BADA0 File Offset: 0x002B8FA0
		public byte[] GetDetailTipBgQualityArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x0600A52B RID: 42283 RVA: 0x002BADB8 File Offset: 0x002B8FB8
		public string BuffColor
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

		// Token: 0x0600A52C RID: 42284 RVA: 0x002BADF0 File Offset: 0x002B8FF0
		public Span<byte> GetBuffColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A52D RID: 42285 RVA: 0x002BAE00 File Offset: 0x002B9000
		public byte[] GetBuffColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x0600A52E RID: 42286 RVA: 0x002BAE18 File Offset: 0x002B9018
		public string SkillIcon
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

		// Token: 0x0600A52F RID: 42287 RVA: 0x002BAE50 File Offset: 0x002B9050
		public Span<byte> GetSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A530 RID: 42288 RVA: 0x002BAE60 File Offset: 0x002B9060
		public byte[] GetSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x0600A531 RID: 42289 RVA: 0x002BAE78 File Offset: 0x002B9078
		public string SmallIcon
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

		// Token: 0x0600A532 RID: 42290 RVA: 0x002BAEB0 File Offset: 0x002B90B0
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A533 RID: 42291 RVA: 0x002BAEC0 File Offset: 0x002B90C0
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x0600A534 RID: 42292 RVA: 0x002BAED8 File Offset: 0x002B90D8
		public string SkillTitle
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A535 RID: 42293 RVA: 0x002BAF10 File Offset: 0x002B9110
		public Span<byte> GetSkillTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A536 RID: 42294 RVA: 0x002BAF20 File Offset: 0x002B9120
		public byte[] GetSkillTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x0600A537 RID: 42295 RVA: 0x002BAF38 File Offset: 0x002B9138
		public string SkillDesc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A538 RID: 42296 RVA: 0x002BAF70 File Offset: 0x002B9170
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A539 RID: 42297 RVA: 0x002BAF80 File Offset: 0x002B9180
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0400551D RID: 21789
		private Table __p;
	}
}
