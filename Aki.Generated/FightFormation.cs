using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C67 RID: 3175
	public struct FightFormation : IFlatbufferObject
	{
		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06006D84 RID: 28036 RVA: 0x0022CDB0 File Offset: 0x0022AFB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x0022CDBD File Offset: 0x0022AFBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D86 RID: 28038 RVA: 0x0022CDC4 File Offset: 0x0022AFC4
		public static FightFormation GetRootAsFightFormation(ByteBuffer _bb)
		{
			return FightFormation.GetRootAsFightFormation(_bb, default(FightFormation));
		}

		// Token: 0x06006D87 RID: 28039 RVA: 0x0022CDE0 File Offset: 0x0022AFE0
		public static FightFormation GetRootAsFightFormation(ByteBuffer _bb, FightFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D88 RID: 28040 RVA: 0x0022CDFD File Offset: 0x0022AFFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x0022CE0C File Offset: 0x0022B00C
		public FightFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06006D8A RID: 28042 RVA: 0x0022CE1C File Offset: 0x0022B01C
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

		// Token: 0x06006D8B RID: 28043 RVA: 0x0022CE58 File Offset: 0x0022B058
		public int LimitRole(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06006D8C RID: 28044 RVA: 0x0022CE98 File Offset: 0x0022B098
		public int LimitRoleLength
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

		// Token: 0x06006D8D RID: 28045 RVA: 0x0022CEC3 File Offset: 0x0022B0C3
		public Span<int> GetLimitRoleBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x0022CED2 File Offset: 0x0022B0D2
		public int[] GetLimitRoleArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06006D8F RID: 28047 RVA: 0x0022CEEC File Offset: 0x0022B0EC
		public int LimitCount(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06006D90 RID: 28048 RVA: 0x0022CF2C File Offset: 0x0022B12C
		public int LimitCountLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006D91 RID: 28049 RVA: 0x0022CF57 File Offset: 0x0022B157
		public Span<int> GetLimitCountBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06006D92 RID: 28050 RVA: 0x0022CF66 File Offset: 0x0022B166
		public int[] GetLimitCountArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x0022CF80 File Offset: 0x0022B180
		public int LitmitElement(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06006D94 RID: 28052 RVA: 0x0022CFC0 File Offset: 0x0022B1C0
		public int LitmitElementLength
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

		// Token: 0x06006D95 RID: 28053 RVA: 0x0022CFEC File Offset: 0x0022B1EC
		public Span<int> GetLitmitElementBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x0022CFFC File Offset: 0x0022B1FC
		public int[] GetLitmitElementArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06006D97 RID: 28055 RVA: 0x0022D014 File Offset: 0x0022B214
		public string Content
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

		// Token: 0x06006D98 RID: 28056 RVA: 0x0022D04C File Offset: 0x0022B24C
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006D99 RID: 28057 RVA: 0x0022D05C File Offset: 0x0022B25C
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06006D9A RID: 28058 RVA: 0x0022D074 File Offset: 0x0022B274
		public int RecommendFormation(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06006D9B RID: 28059 RVA: 0x0022D0B4 File Offset: 0x0022B2B4
		public int RecommendFormationLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x0022D0E0 File Offset: 0x0022B2E0
		public Span<int> GetRecommendFormationBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x0022D0F0 File Offset: 0x0022B2F0
		public int[] GetRecommendFormationArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x0022D108 File Offset: 0x0022B308
		public int TrialRole(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06006D9F RID: 28063 RVA: 0x0022D148 File Offset: 0x0022B348
		public int TrialRoleLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x0022D174 File Offset: 0x0022B374
		public Span<int> GetTrialRoleBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x0022D184 File Offset: 0x0022B384
		public int[] GetTrialRoleArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x0022D19C File Offset: 0x0022B39C
		public int AutoRole(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06006DA3 RID: 28067 RVA: 0x0022D1DC File Offset: 0x0022B3DC
		public int AutoRoleLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006DA4 RID: 28068 RVA: 0x0022D208 File Offset: 0x0022B408
		public Span<int> GetAutoRoleBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x0022D218 File Offset: 0x0022B418
		public int[] GetAutoRoleArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06006DA6 RID: 28070 RVA: 0x0022D230 File Offset: 0x0022B430
		public bool ChooseRole
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x0022D270 File Offset: 0x0022B470
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AutoRoleIter()或GetAutoRoleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AutoRole()
		{
			FightFormation fightFormation = this;
			return fightFormation.GetAutoRoleArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x0022D294 File Offset: 0x0022B494
		[NullableContext(1)]
		public readonly IEnumerable<int> AutoRoleIter()
		{
			FightFormation.<AutoRoleIter>d__47 <AutoRoleIter>d__ = new FightFormation.<AutoRoleIter>d__47(-2);
			<AutoRoleIter>d__.<>3__<>4__this = this;
			return <AutoRoleIter>d__;
		}

		// Token: 0x06006DA9 RID: 28073 RVA: 0x0022D2AC File Offset: 0x0022B4AC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LimitCountIter()或GetLimitCountBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LimitCount()
		{
			FightFormation fightFormation = this;
			return fightFormation.GetLimitCountArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006DAA RID: 28074 RVA: 0x0022D2D0 File Offset: 0x0022B4D0
		[NullableContext(1)]
		public readonly IEnumerable<int> LimitCountIter()
		{
			FightFormation.<LimitCountIter>d__49 <LimitCountIter>d__ = new FightFormation.<LimitCountIter>d__49(-2);
			<LimitCountIter>d__.<>3__<>4__this = this;
			return <LimitCountIter>d__;
		}

		// Token: 0x06006DAB RID: 28075 RVA: 0x0022D2E8 File Offset: 0x0022B4E8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LimitRoleIter()或GetLimitRoleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LimitRole()
		{
			FightFormation fightFormation = this;
			return fightFormation.GetLimitRoleArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x0022D30C File Offset: 0x0022B50C
		[NullableContext(1)]
		public readonly IEnumerable<int> LimitRoleIter()
		{
			FightFormation.<LimitRoleIter>d__51 <LimitRoleIter>d__ = new FightFormation.<LimitRoleIter>d__51(-2);
			<LimitRoleIter>d__.<>3__<>4__this = this;
			return <LimitRoleIter>d__;
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x0022D324 File Offset: 0x0022B524
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LitmitElementIter()或GetLitmitElementBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LitmitElement()
		{
			FightFormation fightFormation = this;
			return fightFormation.GetLitmitElementArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006DAE RID: 28078 RVA: 0x0022D348 File Offset: 0x0022B548
		[NullableContext(1)]
		public readonly IEnumerable<int> LitmitElementIter()
		{
			FightFormation.<LitmitElementIter>d__53 <LitmitElementIter>d__ = new FightFormation.<LitmitElementIter>d__53(-2);
			<LitmitElementIter>d__.<>3__<>4__this = this;
			return <LitmitElementIter>d__;
		}

		// Token: 0x06006DAF RID: 28079 RVA: 0x0022D360 File Offset: 0x0022B560
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendFormationIter()或GetRecommendFormationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendFormation()
		{
			FightFormation fightFormation = this;
			return fightFormation.GetRecommendFormationArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x0022D384 File Offset: 0x0022B584
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendFormationIter()
		{
			FightFormation.<RecommendFormationIter>d__55 <RecommendFormationIter>d__ = new FightFormation.<RecommendFormationIter>d__55(-2);
			<RecommendFormationIter>d__.<>3__<>4__this = this;
			return <RecommendFormationIter>d__;
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x0022D39C File Offset: 0x0022B59C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TrialRoleIter()或GetTrialRoleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TrialRole()
		{
			FightFormation fightFormation = this;
			return fightFormation.GetTrialRoleArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006DB2 RID: 28082 RVA: 0x0022D3C0 File Offset: 0x0022B5C0
		[NullableContext(1)]
		public readonly IEnumerable<int> TrialRoleIter()
		{
			FightFormation.<TrialRoleIter>d__57 <TrialRoleIter>d__ = new FightFormation.<TrialRoleIter>d__57(-2);
			<TrialRoleIter>d__.<>3__<>4__this = this;
			return <TrialRoleIter>d__;
		}

		// Token: 0x04004CB2 RID: 19634
		private Table __p;
	}
}
