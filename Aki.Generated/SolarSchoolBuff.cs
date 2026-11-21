using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D8 RID: 4568
	public struct SolarSchoolBuff : IFlatbufferObject
	{
		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x0600E000 RID: 57344 RVA: 0x0033DDE0 File Offset: 0x0033BFE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E001 RID: 57345 RVA: 0x0033DDED File Offset: 0x0033BFED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E002 RID: 57346 RVA: 0x0033DDF4 File Offset: 0x0033BFF4
		public static SolarSchoolBuff GetRootAsSolarSchoolBuff(ByteBuffer _bb)
		{
			return SolarSchoolBuff.GetRootAsSolarSchoolBuff(_bb, default(SolarSchoolBuff));
		}

		// Token: 0x0600E003 RID: 57347 RVA: 0x0033DE10 File Offset: 0x0033C010
		public static SolarSchoolBuff GetRootAsSolarSchoolBuff(ByteBuffer _bb, SolarSchoolBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E004 RID: 57348 RVA: 0x0033DE2D File Offset: 0x0033C02D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E005 RID: 57349 RVA: 0x0033DE3C File Offset: 0x0033C03C
		public SolarSchoolBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x0600E006 RID: 57350 RVA: 0x0033DE4C File Offset: 0x0033C04C
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

		// Token: 0x0600E007 RID: 57351 RVA: 0x0033DE88 File Offset: 0x0033C088
		public int EffectIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x0600E008 RID: 57352 RVA: 0x0033DEC8 File Offset: 0x0033C0C8
		public int EffectIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E009 RID: 57353 RVA: 0x0033DEF3 File Offset: 0x0033C0F3
		public Span<int> GetEffectIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600E00A RID: 57354 RVA: 0x0033DF02 File Offset: 0x0033C102
		public int[] GetEffectIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x0600E00B RID: 57355 RVA: 0x0033DF1C File Offset: 0x0033C11C
		public string EffectDesc
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

		// Token: 0x0600E00C RID: 57356 RVA: 0x0033DF53 File Offset: 0x0033C153
		public Span<byte> GetEffectDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E00D RID: 57357 RVA: 0x0033DF62 File Offset: 0x0033C162
		public byte[] GetEffectDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x0600E00E RID: 57358 RVA: 0x0033DF7C File Offset: 0x0033C17C
		public int DurationDays
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

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x0600E00F RID: 57359 RVA: 0x0033DFBC File Offset: 0x0033C1BC
		public int WeeklyRewardId
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

		// Token: 0x0600E010 RID: 57360 RVA: 0x0033DFF9 File Offset: 0x0033C1F9
		[NullableContext(1)]
		public int[] EffectIds()
		{
			return this.GetEffectIdsArray();
		}

		// Token: 0x0600E011 RID: 57361 RVA: 0x0033E001 File Offset: 0x0033C201
		[NullableContext(1)]
		public IEnumerable<int> EffectIdsIter()
		{
			SolarSchoolBuff.<EffectIdsIter>d__24 <EffectIdsIter>d__ = new SolarSchoolBuff.<EffectIdsIter>d__24(-2);
			<EffectIdsIter>d__.<>3__<>4__this = this;
			return <EffectIdsIter>d__;
		}

		// Token: 0x04005815 RID: 22549
		private Table __p;
	}
}
