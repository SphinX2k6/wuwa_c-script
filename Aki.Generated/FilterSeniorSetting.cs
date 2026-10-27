using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C6F RID: 3183
	public struct FilterSeniorSetting : IFlatbufferObject
	{
		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06006E54 RID: 28244 RVA: 0x0022EC4D File Offset: 0x0022CE4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E55 RID: 28245 RVA: 0x0022EC5A File Offset: 0x0022CE5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E56 RID: 28246 RVA: 0x0022EC64 File Offset: 0x0022CE64
		public static FilterSeniorSetting GetRootAsFilterSeniorSetting(ByteBuffer _bb)
		{
			return FilterSeniorSetting.GetRootAsFilterSeniorSetting(_bb, default(FilterSeniorSetting));
		}

		// Token: 0x06006E57 RID: 28247 RVA: 0x0022EC80 File Offset: 0x0022CE80
		public static FilterSeniorSetting GetRootAsFilterSeniorSetting(ByteBuffer _bb, FilterSeniorSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x0022EC9D File Offset: 0x0022CE9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x0022ECAC File Offset: 0x0022CEAC
		public FilterSeniorSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06006E5A RID: 28250 RVA: 0x0022ECBC File Offset: 0x0022CEBC
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

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06006E5B RID: 28251 RVA: 0x0022ECF8 File Offset: 0x0022CEF8
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

		// Token: 0x06006E5C RID: 28252 RVA: 0x0022ED2F File Offset: 0x0022CF2F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006E5D RID: 28253 RVA: 0x0022ED3E File Offset: 0x0022CF3E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06006E5E RID: 28254 RVA: 0x0022ED58 File Offset: 0x0022CF58
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

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06006E5F RID: 28255 RVA: 0x0022ED94 File Offset: 0x0022CF94
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

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06006E60 RID: 28256 RVA: 0x0022EDD4 File Offset: 0x0022CFD4
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

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06006E61 RID: 28257 RVA: 0x0022EE18 File Offset: 0x0022D018
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

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06006E62 RID: 28258 RVA: 0x0022EE5C File Offset: 0x0022D05C
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

		// Token: 0x06006E63 RID: 28259 RVA: 0x0022EE94 File Offset: 0x0022D094
		public Span<byte> GetUnitBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006E64 RID: 28260 RVA: 0x0022EEA4 File Offset: 0x0022D0A4
		public byte[] GetUnitArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06006E65 RID: 28261 RVA: 0x0022EEBC File Offset: 0x0022D0BC
		public bool IsNeedSpecialBg
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06006E66 RID: 28262 RVA: 0x0022EEFC File Offset: 0x0022D0FC
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

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06006E67 RID: 28263 RVA: 0x0022EF3C File Offset: 0x0022D13C
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

		// Token: 0x04004CBA RID: 19642
		private Table __p;
	}
}
