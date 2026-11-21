using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010BF RID: 4287
	public struct RogueAffix : IFlatbufferObject
	{
		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x0600C459 RID: 50265 RVA: 0x002FF146 File Offset: 0x002FD346
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C45A RID: 50266 RVA: 0x002FF153 File Offset: 0x002FD353
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C45B RID: 50267 RVA: 0x002FF15C File Offset: 0x002FD35C
		public static RogueAffix GetRootAsRogueAffix(ByteBuffer _bb)
		{
			return RogueAffix.GetRootAsRogueAffix(_bb, default(RogueAffix));
		}

		// Token: 0x0600C45C RID: 50268 RVA: 0x002FF178 File Offset: 0x002FD378
		public static RogueAffix GetRootAsRogueAffix(ByteBuffer _bb, RogueAffix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C45D RID: 50269 RVA: 0x002FF195 File Offset: 0x002FD395
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C45E RID: 50270 RVA: 0x002FF1A4 File Offset: 0x002FD3A4
		public RogueAffix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x0600C45F RID: 50271 RVA: 0x002FF1B4 File Offset: 0x002FD3B4
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

		// Token: 0x0600C460 RID: 50272 RVA: 0x002FF1F0 File Offset: 0x002FD3F0
		public long BuffId(int j)
		{
			int num = this.__p.__offset(6);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x0600C461 RID: 50273 RVA: 0x002FF23C File Offset: 0x002FD43C
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

		// Token: 0x0600C462 RID: 50274 RVA: 0x002FF267 File Offset: 0x002FD467
		public Span<long> GetBuffIdBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(6, 8));
		}

		// Token: 0x0600C463 RID: 50275 RVA: 0x002FF27B File Offset: 0x002FD47B
		public long[] GetBuffIdArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(6) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x0600C464 RID: 50276 RVA: 0x002FF2B8 File Offset: 0x002FD4B8
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

		// Token: 0x0600C465 RID: 50277 RVA: 0x002FF2EF File Offset: 0x002FD4EF
		public Span<byte> GetAffixDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C466 RID: 50278 RVA: 0x002FF2FE File Offset: 0x002FD4FE
		public byte[] GetAffixDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C467 RID: 50279 RVA: 0x002FF318 File Offset: 0x002FD518
		public string AffixDescParam(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x0600C468 RID: 50280 RVA: 0x002FF354 File Offset: 0x002FD554
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

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x0600C469 RID: 50281 RVA: 0x002FF380 File Offset: 0x002FD580
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

		// Token: 0x0600C46A RID: 50282 RVA: 0x002FF3B8 File Offset: 0x002FD5B8
		public Span<byte> GetAffixDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C46B RID: 50283 RVA: 0x002FF3C8 File Offset: 0x002FD5C8
		public byte[] GetAffixDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C46C RID: 50284 RVA: 0x002FF3E0 File Offset: 0x002FD5E0
		[NullableContext(1)]
		public string[] AffixDescParam()
		{
			return this.AffixDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C46D RID: 50285 RVA: 0x002FF3ED File Offset: 0x002FD5ED
		[NullableContext(1)]
		public IEnumerable<string> AffixDescParamIter()
		{
			RogueAffix.<AffixDescParamIter>d__27 <AffixDescParamIter>d__ = new RogueAffix.<AffixDescParamIter>d__27(-2);
			<AffixDescParamIter>d__.<>3__<>4__this = this;
			return <AffixDescParamIter>d__;
		}

		// Token: 0x0600C46E RID: 50286 RVA: 0x002FF402 File Offset: 0x002FD602
		[NullableContext(1)]
		public long[] BuffId()
		{
			return this.GetBuffIdArray();
		}

		// Token: 0x0600C46F RID: 50287 RVA: 0x002FF40A File Offset: 0x002FD60A
		[NullableContext(1)]
		public IEnumerable<long> BuffIdIter()
		{
			RogueAffix.<BuffIdIter>d__29 <BuffIdIter>d__ = new RogueAffix.<BuffIdIter>d__29(-2);
			<BuffIdIter>d__.<>3__<>4__this = this;
			return <BuffIdIter>d__;
		}

		// Token: 0x0400569B RID: 22171
		private Table __p;
	}
}
