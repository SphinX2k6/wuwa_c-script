using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FEC RID: 4076
	public struct RogueResAffix : IFlatbufferObject
	{
		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x0600C052 RID: 49234 RVA: 0x002E7C8C File Offset: 0x002E5E8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C053 RID: 49235 RVA: 0x002E7C99 File Offset: 0x002E5E99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C054 RID: 49236 RVA: 0x002E7CA0 File Offset: 0x002E5EA0
		public static RogueResAffix GetRootAsRogueResAffix(ByteBuffer _bb)
		{
			return RogueResAffix.GetRootAsRogueResAffix(_bb, default(RogueResAffix));
		}

		// Token: 0x0600C055 RID: 49237 RVA: 0x002E7CBC File Offset: 0x002E5EBC
		public static RogueResAffix GetRootAsRogueResAffix(ByteBuffer _bb, RogueResAffix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C056 RID: 49238 RVA: 0x002E7CD9 File Offset: 0x002E5ED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C057 RID: 49239 RVA: 0x002E7CE8 File Offset: 0x002E5EE8
		public RogueResAffix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x0600C058 RID: 49240 RVA: 0x002E7CF8 File Offset: 0x002E5EF8
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

		// Token: 0x0600C059 RID: 49241 RVA: 0x002E7D34 File Offset: 0x002E5F34
		public long BuffId(int j)
		{
			int num = this.__p.__offset(6);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x0600C05A RID: 49242 RVA: 0x002E7D80 File Offset: 0x002E5F80
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

		// Token: 0x0600C05B RID: 49243 RVA: 0x002E7DAB File Offset: 0x002E5FAB
		public Span<long> GetBuffIdBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(6, 8));
		}

		// Token: 0x0600C05C RID: 49244 RVA: 0x002E7DBF File Offset: 0x002E5FBF
		public long[] GetBuffIdArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(6) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x0600C05D RID: 49245 RVA: 0x002E7DFC File Offset: 0x002E5FFC
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

		// Token: 0x0600C05E RID: 49246 RVA: 0x002E7E33 File Offset: 0x002E6033
		public Span<byte> GetAffixDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C05F RID: 49247 RVA: 0x002E7E42 File Offset: 0x002E6042
		public byte[] GetAffixDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C060 RID: 49248 RVA: 0x002E7E5C File Offset: 0x002E605C
		public string AffixDescParam(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x0600C061 RID: 49249 RVA: 0x002E7E98 File Offset: 0x002E6098
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

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x0600C062 RID: 49250 RVA: 0x002E7EC4 File Offset: 0x002E60C4
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

		// Token: 0x0600C063 RID: 49251 RVA: 0x002E7EFC File Offset: 0x002E60FC
		public Span<byte> GetAffixDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C064 RID: 49252 RVA: 0x002E7F0C File Offset: 0x002E610C
		public byte[] GetAffixDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C065 RID: 49253 RVA: 0x002E7F24 File Offset: 0x002E6124
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AffixDescParamIter()或GetAffixDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AffixDescParam()
		{
			return this.AffixDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C066 RID: 49254 RVA: 0x002E7F31 File Offset: 0x002E6131
		[NullableContext(1)]
		public readonly IEnumerable<string> AffixDescParamIter()
		{
			RogueResAffix.<AffixDescParamIter>d__27 <AffixDescParamIter>d__ = new RogueResAffix.<AffixDescParamIter>d__27(-2);
			<AffixDescParamIter>d__.<>3__<>4__this = this;
			return <AffixDescParamIter>d__;
		}

		// Token: 0x0600C067 RID: 49255 RVA: 0x002E7F48 File Offset: 0x002E6148
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdIter()或GetBuffIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffId()
		{
			RogueResAffix rogueResAffix = this;
			return rogueResAffix.GetBuffIdArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600C068 RID: 49256 RVA: 0x002E7F6C File Offset: 0x002E616C
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdIter()
		{
			RogueResAffix.<BuffIdIter>d__29 <BuffIdIter>d__ = new RogueResAffix.<BuffIdIter>d__29(-2);
			<BuffIdIter>d__.<>3__<>4__this = this;
			return <BuffIdIter>d__;
		}

		// Token: 0x040050CD RID: 20685
		private Table __p;
	}
}
