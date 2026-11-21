using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D9 RID: 4569
	public struct SolarSchoolBuffEffect : IFlatbufferObject
	{
		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x0600E012 RID: 57362 RVA: 0x0033E016 File Offset: 0x0033C216
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E013 RID: 57363 RVA: 0x0033E023 File Offset: 0x0033C223
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E014 RID: 57364 RVA: 0x0033E02C File Offset: 0x0033C22C
		public static SolarSchoolBuffEffect GetRootAsSolarSchoolBuffEffect(ByteBuffer _bb)
		{
			return SolarSchoolBuffEffect.GetRootAsSolarSchoolBuffEffect(_bb, default(SolarSchoolBuffEffect));
		}

		// Token: 0x0600E015 RID: 57365 RVA: 0x0033E048 File Offset: 0x0033C248
		public static SolarSchoolBuffEffect GetRootAsSolarSchoolBuffEffect(ByteBuffer _bb, SolarSchoolBuffEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E016 RID: 57366 RVA: 0x0033E065 File Offset: 0x0033C265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E017 RID: 57367 RVA: 0x0033E074 File Offset: 0x0033C274
		public SolarSchoolBuffEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x0600E018 RID: 57368 RVA: 0x0033E084 File Offset: 0x0033C284
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

		// Token: 0x0600E019 RID: 57369 RVA: 0x0033E0C0 File Offset: 0x0033C2C0
		public int BehaviorId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x0600E01A RID: 57370 RVA: 0x0033E100 File Offset: 0x0033C300
		public int BehaviorIdLength
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

		// Token: 0x0600E01B RID: 57371 RVA: 0x0033E12B File Offset: 0x0033C32B
		public Span<int> GetBehaviorIdBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600E01C RID: 57372 RVA: 0x0033E13A File Offset: 0x0033C33A
		public int[] GetBehaviorIdArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x0600E01D RID: 57373 RVA: 0x0033E154 File Offset: 0x0033C354
		public int Type
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

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x0600E01E RID: 57374 RVA: 0x0033E190 File Offset: 0x0033C390
		public int Value
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

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x0600E01F RID: 57375 RVA: 0x0033E1D0 File Offset: 0x0033C3D0
		public bool IsShowInBehavior
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E020 RID: 57376 RVA: 0x0033E210 File Offset: 0x0033C410
		[NullableContext(1)]
		public int[] BehaviorId()
		{
			return this.GetBehaviorIdArray();
		}

		// Token: 0x0600E021 RID: 57377 RVA: 0x0033E218 File Offset: 0x0033C418
		[NullableContext(1)]
		public IEnumerable<int> BehaviorIdIter()
		{
			SolarSchoolBuffEffect.<BehaviorIdIter>d__22 <BehaviorIdIter>d__ = new SolarSchoolBuffEffect.<BehaviorIdIter>d__22(-2);
			<BehaviorIdIter>d__.<>3__<>4__this = this;
			return <BehaviorIdIter>d__;
		}

		// Token: 0x04005816 RID: 22550
		private Table __p;
	}
}
