using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA9 RID: 2985
	public struct Country : IFlatbufferObject
	{
		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06005A51 RID: 23121 RVA: 0x00201C38 File Offset: 0x001FFE38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x00201C45 File Offset: 0x001FFE45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x00201C4C File Offset: 0x001FFE4C
		public static Country GetRootAsCountry(ByteBuffer _bb)
		{
			return Country.GetRootAsCountry(_bb, default(Country));
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x00201C68 File Offset: 0x001FFE68
		public static Country GetRootAsCountry(ByteBuffer _bb, Country obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x00201C85 File Offset: 0x001FFE85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x00201C94 File Offset: 0x001FFE94
		public Country __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06005A57 RID: 23127 RVA: 0x00201CA4 File Offset: 0x001FFEA4
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

		// Token: 0x06005A58 RID: 23128 RVA: 0x00201CE0 File Offset: 0x001FFEE0
		public int Influences(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06005A59 RID: 23129 RVA: 0x00201D20 File Offset: 0x001FFF20
		public int InfluencesLength
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

		// Token: 0x06005A5A RID: 23130 RVA: 0x00201D4B File Offset: 0x001FFF4B
		public Span<int> GetInfluencesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x00201D5A File Offset: 0x001FFF5A
		public int[] GetInfluencesArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06005A5C RID: 23132 RVA: 0x00201D74 File Offset: 0x001FFF74
		public string Title
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

		// Token: 0x06005A5D RID: 23133 RVA: 0x00201DAB File Offset: 0x001FFFAB
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x00201DBA File Offset: 0x001FFFBA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06005A5F RID: 23135 RVA: 0x00201DD4 File Offset: 0x001FFFD4
		public string Desc
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

		// Token: 0x06005A60 RID: 23136 RVA: 0x00201E0C File Offset: 0x0020000C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005A61 RID: 23137 RVA: 0x00201E1C File Offset: 0x0020001C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06005A62 RID: 23138 RVA: 0x00201E34 File Offset: 0x00200034
		public string Logo
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

		// Token: 0x06005A63 RID: 23139 RVA: 0x00201E6C File Offset: 0x0020006C
		public Span<byte> GetLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x00201E7C File Offset: 0x0020007C
		public byte[] GetLogoArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06005A65 RID: 23141 RVA: 0x00201E94 File Offset: 0x00200094
		public int DailyTaskShow
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06005A66 RID: 23142 RVA: 0x00201ED4 File Offset: 0x002000D4
		public string AudioName
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

		// Token: 0x06005A67 RID: 23143 RVA: 0x00201F0C File Offset: 0x0020010C
		public Span<byte> GetAudioNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x00201F1C File Offset: 0x0020011C
		public byte[] GetAudioNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06005A69 RID: 23145 RVA: 0x00201F34 File Offset: 0x00200134
		public string WwiseStateName
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

		// Token: 0x06005A6A RID: 23146 RVA: 0x00201F6C File Offset: 0x0020016C
		public Span<byte> GetWwiseStateNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005A6B RID: 23147 RVA: 0x00201F7C File Offset: 0x0020017C
		public byte[] GetWwiseStateNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06005A6C RID: 23148 RVA: 0x00201F94 File Offset: 0x00200194
		public string Icon
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

		// Token: 0x06005A6D RID: 23149 RVA: 0x00201FCC File Offset: 0x002001CC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x00201FDC File Offset: 0x002001DC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06005A6F RID: 23151 RVA: 0x00201FF4 File Offset: 0x002001F4
		public int SortIndex
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

		// Token: 0x06005A70 RID: 23152 RVA: 0x00202034 File Offset: 0x00200234
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InfluencesIter()或GetInfluencesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Influences()
		{
			Country country = this;
			return country.GetInfluencesArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x00202058 File Offset: 0x00200258
		[NullableContext(1)]
		public readonly IEnumerable<int> InfluencesIter()
		{
			Country.<InfluencesIter>d__44 <InfluencesIter>d__ = new Country.<InfluencesIter>d__44(-2);
			<InfluencesIter>d__.<>3__<>4__this = this;
			return <InfluencesIter>d__;
		}

		// Token: 0x04004BCC RID: 19404
		private Table __p;
	}
}
