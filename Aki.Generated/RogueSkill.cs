using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001021 RID: 4129
	public struct RogueSkill : IFlatbufferObject
	{
		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x0600C4F5 RID: 50421 RVA: 0x002F2111 File Offset: 0x002F0311
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C4F6 RID: 50422 RVA: 0x002F211E File Offset: 0x002F031E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C4F7 RID: 50423 RVA: 0x002F2128 File Offset: 0x002F0328
		public static RogueSkill GetRootAsRogueSkill(ByteBuffer _bb)
		{
			return RogueSkill.GetRootAsRogueSkill(_bb, default(RogueSkill));
		}

		// Token: 0x0600C4F8 RID: 50424 RVA: 0x002F2144 File Offset: 0x002F0344
		public static RogueSkill GetRootAsRogueSkill(ByteBuffer _bb, RogueSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C4F9 RID: 50425 RVA: 0x002F2161 File Offset: 0x002F0361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C4FA RID: 50426 RVA: 0x002F2170 File Offset: 0x002F0370
		public RogueSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x0600C4FB RID: 50427 RVA: 0x002F2180 File Offset: 0x002F0380
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

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x0600C4FC RID: 50428 RVA: 0x002F21BC File Offset: 0x002F03BC
		public string Icon
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

		// Token: 0x0600C4FD RID: 50429 RVA: 0x002F21F3 File Offset: 0x002F03F3
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C4FE RID: 50430 RVA: 0x002F2202 File Offset: 0x002F0402
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x0600C4FF RID: 50431 RVA: 0x002F221C File Offset: 0x002F041C
		public string SkillTypeText
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

		// Token: 0x0600C500 RID: 50432 RVA: 0x002F2253 File Offset: 0x002F0453
		public Span<byte> GetSkillTypeTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C501 RID: 50433 RVA: 0x002F2262 File Offset: 0x002F0462
		public byte[] GetSkillTypeTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x0600C502 RID: 50434 RVA: 0x002F227C File Offset: 0x002F047C
		public string SkillName
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

		// Token: 0x0600C503 RID: 50435 RVA: 0x002F22B4 File Offset: 0x002F04B4
		public Span<byte> GetSkillNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C504 RID: 50436 RVA: 0x002F22C4 File Offset: 0x002F04C4
		public byte[] GetSkillNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x0600C505 RID: 50437 RVA: 0x002F22DC File Offset: 0x002F04DC
		public string SkillDesc
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

		// Token: 0x0600C506 RID: 50438 RVA: 0x002F2314 File Offset: 0x002F0514
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C507 RID: 50439 RVA: 0x002F2324 File Offset: 0x002F0524
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C508 RID: 50440 RVA: 0x002F233C File Offset: 0x002F053C
		public string SkillDescParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x0600C509 RID: 50441 RVA: 0x002F2378 File Offset: 0x002F0578
		public int SkillDescParamLength
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

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x0600C50A RID: 50442 RVA: 0x002F23A4 File Offset: 0x002F05A4
		public string SkillResume
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

		// Token: 0x0600C50B RID: 50443 RVA: 0x002F23DC File Offset: 0x002F05DC
		public Span<byte> GetSkillResumeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C50C RID: 50444 RVA: 0x002F23EC File Offset: 0x002F05EC
		public byte[] GetSkillResumeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C50D RID: 50445 RVA: 0x002F2404 File Offset: 0x002F0604
		public string SkillResumeParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x0600C50E RID: 50446 RVA: 0x002F2440 File Offset: 0x002F0640
		public int SkillResumeParamLength
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

		// Token: 0x0600C50F RID: 50447 RVA: 0x002F246C File Offset: 0x002F066C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillDescParamIter()或GetSkillDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillDescParam()
		{
			return this.SkillDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C510 RID: 50448 RVA: 0x002F2479 File Offset: 0x002F0679
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillDescParamIter()
		{
			RogueSkill.<SkillDescParamIter>d__37 <SkillDescParamIter>d__ = new RogueSkill.<SkillDescParamIter>d__37(-2);
			<SkillDescParamIter>d__.<>3__<>4__this = this;
			return <SkillDescParamIter>d__;
		}

		// Token: 0x0600C511 RID: 50449 RVA: 0x002F248E File Offset: 0x002F068E
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillResumeParamIter()或GetSkillResumeParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkillResumeParam()
		{
			return this.SkillResumeParamIter().ToArray<string>();
		}

		// Token: 0x0600C512 RID: 50450 RVA: 0x002F249B File Offset: 0x002F069B
		[NullableContext(1)]
		public readonly IEnumerable<string> SkillResumeParamIter()
		{
			RogueSkill.<SkillResumeParamIter>d__39 <SkillResumeParamIter>d__ = new RogueSkill.<SkillResumeParamIter>d__39(-2);
			<SkillResumeParamIter>d__.<>3__<>4__this = this;
			return <SkillResumeParamIter>d__;
		}

		// Token: 0x04005113 RID: 20755
		private Table __p;
	}
}
