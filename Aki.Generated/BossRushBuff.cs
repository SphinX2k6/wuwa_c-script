using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B44 RID: 2884
	public struct BossRushBuff : IFlatbufferObject
	{
		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06004EFF RID: 20223 RVA: 0x001E758D File Offset: 0x001E578D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x001E759A File Offset: 0x001E579A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x001E75A4 File Offset: 0x001E57A4
		public static BossRushBuff GetRootAsBossRushBuff(ByteBuffer _bb)
		{
			return BossRushBuff.GetRootAsBossRushBuff(_bb, default(BossRushBuff));
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x001E75C0 File Offset: 0x001E57C0
		public static BossRushBuff GetRootAsBossRushBuff(ByteBuffer _bb, BossRushBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x001E75DD File Offset: 0x001E57DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x001E75EC File Offset: 0x001E57EC
		public BossRushBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06004F05 RID: 20229 RVA: 0x001E75FC File Offset: 0x001E57FC
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

		// Token: 0x06004F06 RID: 20230 RVA: 0x001E7638 File Offset: 0x001E5838
		public long BuffId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06004F07 RID: 20231 RVA: 0x001E7678 File Offset: 0x001E5878
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

		// Token: 0x06004F08 RID: 20232 RVA: 0x001E76A3 File Offset: 0x001E58A3
		public Span<long> GetBuffIdBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x06004F09 RID: 20233 RVA: 0x001E76B2 File Offset: 0x001E58B2
		public long[] GetBuffIdArray()
		{
			return this.__p.__vector_as_array<long>(6) ?? Array.Empty<long>();
		}

		// Token: 0x06004F0A RID: 20234 RVA: 0x001E76CC File Offset: 0x001E58CC
		public long PassiveSkill(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06004F0B RID: 20235 RVA: 0x001E770C File Offset: 0x001E590C
		public int PassiveSkillLength
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

		// Token: 0x06004F0C RID: 20236 RVA: 0x001E7737 File Offset: 0x001E5937
		public Span<long> GetPassiveSkillBytes()
		{
			return this.__p.__vector_as_span<long>(8, 8);
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x001E7746 File Offset: 0x001E5946
		public long[] GetPassiveSkillArray()
		{
			return this.__p.__vector_as_array<long>(8) ?? Array.Empty<long>();
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06004F0E RID: 20238 RVA: 0x001E7760 File Offset: 0x001E5960
		public string Texture
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

		// Token: 0x06004F0F RID: 20239 RVA: 0x001E7798 File Offset: 0x001E5998
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x001E77A8 File Offset: 0x001E59A8
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06004F11 RID: 20241 RVA: 0x001E77C0 File Offset: 0x001E59C0
		public string Name
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

		// Token: 0x06004F12 RID: 20242 RVA: 0x001E77F8 File Offset: 0x001E59F8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x001E7808 File Offset: 0x001E5A08
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x001E7820 File Offset: 0x001E5A20
		public int PopDescIdList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06004F15 RID: 20245 RVA: 0x001E7860 File Offset: 0x001E5A60
		public int PopDescIdListLength
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

		// Token: 0x06004F16 RID: 20246 RVA: 0x001E788C File Offset: 0x001E5A8C
		public Span<int> GetPopDescIdListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x001E789C File Offset: 0x001E5A9C
		public int[] GetPopDescIdListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06004F18 RID: 20248 RVA: 0x001E78B4 File Offset: 0x001E5AB4
		public string BuffTitle
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

		// Token: 0x06004F19 RID: 20249 RVA: 0x001E78EC File Offset: 0x001E5AEC
		public Span<byte> GetBuffTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x001E78FC File Offset: 0x001E5AFC
		public byte[] GetBuffTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06004F1B RID: 20251 RVA: 0x001E7914 File Offset: 0x001E5B14
		public string BuffDesc
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

		// Token: 0x06004F1C RID: 20252 RVA: 0x001E794C File Offset: 0x001E5B4C
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x001E795C File Offset: 0x001E5B5C
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x001E7974 File Offset: 0x001E5B74
		public string BuffDescParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06004F1F RID: 20255 RVA: 0x001E79B0 File Offset: 0x001E5BB0
		public int BuffDescParamLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06004F20 RID: 20256 RVA: 0x001E79DC File Offset: 0x001E5BDC
		public string Description
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x001E7A14 File Offset: 0x001E5C14
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x001E7A24 File Offset: 0x001E5C24
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x001E7A3C File Offset: 0x001E5C3C
		public string DescriptionParam(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06004F24 RID: 20260 RVA: 0x001E7A78 File Offset: 0x001E5C78
		public int DescriptionParamLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x001E7AA4 File Offset: 0x001E5CA4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffDescParamIter()或GetBuffDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BuffDescParam()
		{
			return this.BuffDescParamIter().ToArray<string>();
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x001E7AB1 File Offset: 0x001E5CB1
		[NullableContext(1)]
		public readonly IEnumerable<string> BuffDescParamIter()
		{
			BossRushBuff.<BuffDescParamIter>d__52 <BuffDescParamIter>d__ = new BossRushBuff.<BuffDescParamIter>d__52(-2);
			<BuffDescParamIter>d__.<>3__<>4__this = this;
			return <BuffDescParamIter>d__;
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x001E7AC8 File Offset: 0x001E5CC8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdIter()或GetBuffIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffId()
		{
			BossRushBuff bossRushBuff = this;
			return bossRushBuff.GetBuffIdArray() ?? Array.Empty<long>();
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x001E7AEC File Offset: 0x001E5CEC
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdIter()
		{
			BossRushBuff.<BuffIdIter>d__54 <BuffIdIter>d__ = new BossRushBuff.<BuffIdIter>d__54(-2);
			<BuffIdIter>d__.<>3__<>4__this = this;
			return <BuffIdIter>d__;
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x001E7B01 File Offset: 0x001E5D01
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescriptionParamIter()或GetDescriptionParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescriptionParam()
		{
			return this.DescriptionParamIter().ToArray<string>();
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x001E7B0E File Offset: 0x001E5D0E
		[NullableContext(1)]
		public readonly IEnumerable<string> DescriptionParamIter()
		{
			BossRushBuff.<DescriptionParamIter>d__56 <DescriptionParamIter>d__ = new BossRushBuff.<DescriptionParamIter>d__56(-2);
			<DescriptionParamIter>d__.<>3__<>4__this = this;
			return <DescriptionParamIter>d__;
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x001E7B24 File Offset: 0x001E5D24
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PassiveSkillIter()或GetPassiveSkillBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] PassiveSkill()
		{
			BossRushBuff bossRushBuff = this;
			return bossRushBuff.GetPassiveSkillArray() ?? Array.Empty<long>();
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x001E7B48 File Offset: 0x001E5D48
		[NullableContext(1)]
		public readonly IEnumerable<long> PassiveSkillIter()
		{
			BossRushBuff.<PassiveSkillIter>d__58 <PassiveSkillIter>d__ = new BossRushBuff.<PassiveSkillIter>d__58(-2);
			<PassiveSkillIter>d__.<>3__<>4__this = this;
			return <PassiveSkillIter>d__;
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x001E7B60 File Offset: 0x001E5D60
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PopDescIdListIter()或GetPopDescIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PopDescIdList()
		{
			BossRushBuff bossRushBuff = this;
			return bossRushBuff.GetPopDescIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004F2E RID: 20270 RVA: 0x001E7B84 File Offset: 0x001E5D84
		[NullableContext(1)]
		public readonly IEnumerable<int> PopDescIdListIter()
		{
			BossRushBuff.<PopDescIdListIter>d__60 <PopDescIdListIter>d__ = new BossRushBuff.<PopDescIdListIter>d__60(-2);
			<PopDescIdListIter>d__.<>3__<>4__this = this;
			return <PopDescIdListIter>d__;
		}

		// Token: 0x04004B3F RID: 19263
		private Table __p;
	}
}
