using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD7 RID: 4055
	public struct RogueAffix : IFlatbufferObject
	{
		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x0600BE0F RID: 48655 RVA: 0x002E2B7A File Offset: 0x002E0D7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE10 RID: 48656 RVA: 0x002E2B87 File Offset: 0x002E0D87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE11 RID: 48657 RVA: 0x002E2B90 File Offset: 0x002E0D90
		public static RogueAffix GetRootAsRogueAffix(ByteBuffer _bb)
		{
			return RogueAffix.GetRootAsRogueAffix(_bb, default(RogueAffix));
		}

		// Token: 0x0600BE12 RID: 48658 RVA: 0x002E2BAC File Offset: 0x002E0DAC
		public static RogueAffix GetRootAsRogueAffix(ByteBuffer _bb, RogueAffix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE13 RID: 48659 RVA: 0x002E2BC9 File Offset: 0x002E0DC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE14 RID: 48660 RVA: 0x002E2BD8 File Offset: 0x002E0DD8
		public RogueAffix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x0600BE15 RID: 48661 RVA: 0x002E2BE8 File Offset: 0x002E0DE8
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

		// Token: 0x0600BE16 RID: 48662 RVA: 0x002E2C24 File Offset: 0x002E0E24
		public long BuffId(int j)
		{
			int num = this.__p.__offset(6);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x0600BE17 RID: 48663 RVA: 0x002E2C70 File Offset: 0x002E0E70
		public int BuffIdLength
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

		// Token: 0x0600BE18 RID: 48664 RVA: 0x002E2C9B File Offset: 0x002E0E9B
		public Span<long> GetBuffIdBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(6, 8));
		}

		// Token: 0x0600BE19 RID: 48665 RVA: 0x002E2CAF File Offset: 0x002E0EAF
		public long[] GetBuffIdArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(6) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x0600BE1A RID: 48666 RVA: 0x002E2CEC File Offset: 0x002E0EEC
		public string AffixDesc
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

		// Token: 0x0600BE1B RID: 48667 RVA: 0x002E2D23 File Offset: 0x002E0F23
		public Span<byte> GetAffixDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BE1C RID: 48668 RVA: 0x002E2D32 File Offset: 0x002E0F32
		public byte[] GetAffixDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BE1D RID: 48669 RVA: 0x002E2D4C File Offset: 0x002E0F4C
		public string AffixDescParam(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x0600BE1E RID: 48670 RVA: 0x002E2D88 File Offset: 0x002E0F88
		public int AffixDescParamLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x0600BE1F RID: 48671 RVA: 0x002E2DB4 File Offset: 0x002E0FB4
		public string AffixDescSimple
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

		// Token: 0x0600BE20 RID: 48672 RVA: 0x002E2DEC File Offset: 0x002E0FEC
		public Span<byte> GetAffixDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BE21 RID: 48673 RVA: 0x002E2DFC File Offset: 0x002E0FFC
		public byte[] GetAffixDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BE22 RID: 48674 RVA: 0x002E2E14 File Offset: 0x002E1014
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AffixDescParamIter()或GetAffixDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AffixDescParam()
		{
			return this.AffixDescParamIter().ToArray<string>();
		}

		// Token: 0x0600BE23 RID: 48675 RVA: 0x002E2E21 File Offset: 0x002E1021
		[NullableContext(1)]
		public readonly IEnumerable<string> AffixDescParamIter()
		{
			RogueAffix.<AffixDescParamIter>d__27 <AffixDescParamIter>d__ = new RogueAffix.<AffixDescParamIter>d__27(-2);
			<AffixDescParamIter>d__.<>3__<>4__this = this;
			return <AffixDescParamIter>d__;
		}

		// Token: 0x0600BE24 RID: 48676 RVA: 0x002E2E38 File Offset: 0x002E1038
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdIter()或GetBuffIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffId()
		{
			RogueAffix rogueAffix = this;
			return rogueAffix.GetBuffIdArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600BE25 RID: 48677 RVA: 0x002E2E5C File Offset: 0x002E105C
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdIter()
		{
			RogueAffix.<BuffIdIter>d__29 <BuffIdIter>d__ = new RogueAffix.<BuffIdIter>d__29(-2);
			<BuffIdIter>d__.<>3__<>4__this = this;
			return <BuffIdIter>d__;
		}

		// Token: 0x040050B3 RID: 20659
		private Table __p;
	}
}
