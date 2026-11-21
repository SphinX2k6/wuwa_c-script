using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D53 RID: 3411
	public struct FilterSeniorSetting : IFlatbufferObject
	{
		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x0600745F RID: 29791 RVA: 0x0024DE51 File Offset: 0x0024C051
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x0024DE5E File Offset: 0x0024C05E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x0024DE68 File Offset: 0x0024C068
		public static FilterSeniorSetting GetRootAsFilterSeniorSetting(ByteBuffer _bb)
		{
			return FilterSeniorSetting.GetRootAsFilterSeniorSetting(_bb, default(FilterSeniorSetting));
		}

		// Token: 0x06007462 RID: 29794 RVA: 0x0024DE84 File Offset: 0x0024C084
		public static FilterSeniorSetting GetRootAsFilterSeniorSetting(ByteBuffer _bb, FilterSeniorSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007463 RID: 29795 RVA: 0x0024DEA1 File Offset: 0x0024C0A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007464 RID: 29796 RVA: 0x0024DEB0 File Offset: 0x0024C0B0
		public FilterSeniorSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06007465 RID: 29797 RVA: 0x0024DEC0 File Offset: 0x0024C0C0
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

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06007466 RID: 29798 RVA: 0x0024DEFC File Offset: 0x0024C0FC
		public string Name
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

		// Token: 0x06007467 RID: 29799 RVA: 0x0024DF33 File Offset: 0x0024C133
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007468 RID: 29800 RVA: 0x0024DF42 File Offset: 0x0024C142
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06007469 RID: 29801 RVA: 0x0024DF5C File Offset: 0x0024C15C
		public int ParamIndex
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

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x0600746A RID: 29802 RVA: 0x0024DF98 File Offset: 0x0024C198
		public int SortId
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

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x0600746B RID: 29803 RVA: 0x0024DFD8 File Offset: 0x0024C1D8
		public float RangeMin
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return -1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x0600746C RID: 29804 RVA: 0x0024E01C File Offset: 0x0024C21C
		public float RangeMax
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x0600746D RID: 29805 RVA: 0x0024E060 File Offset: 0x0024C260
		public string Unit
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

		// Token: 0x0600746E RID: 29806 RVA: 0x0024E098 File Offset: 0x0024C298
		public Span<byte> GetUnitBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600746F RID: 29807 RVA: 0x0024E0A8 File Offset: 0x0024C2A8
		public byte[] GetUnitArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06007470 RID: 29808 RVA: 0x0024E0C0 File Offset: 0x0024C2C0
		public bool IsNeedSpecialBg
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06007471 RID: 29809 RVA: 0x0024E100 File Offset: 0x0024C300
		public int DecimalPlaces
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

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06007472 RID: 29810 RVA: 0x0024E140 File Offset: 0x0024C340
		public int Ratio
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400529E RID: 21150
		private Table __p;
	}
}
