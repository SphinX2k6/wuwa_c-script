using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001109 RID: 4361
	public struct RogueSkill : IFlatbufferObject
	{
		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x0600CB3F RID: 52031 RVA: 0x0030E119 File Offset: 0x0030C319
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB40 RID: 52032 RVA: 0x0030E126 File Offset: 0x0030C326
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB41 RID: 52033 RVA: 0x0030E130 File Offset: 0x0030C330
		public static RogueSkill GetRootAsRogueSkill(ByteBuffer _bb)
		{
			return RogueSkill.GetRootAsRogueSkill(_bb, default(RogueSkill));
		}

		// Token: 0x0600CB42 RID: 52034 RVA: 0x0030E14C File Offset: 0x0030C34C
		public static RogueSkill GetRootAsRogueSkill(ByteBuffer _bb, RogueSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB43 RID: 52035 RVA: 0x0030E169 File Offset: 0x0030C369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB44 RID: 52036 RVA: 0x0030E178 File Offset: 0x0030C378
		public RogueSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x0600CB45 RID: 52037 RVA: 0x0030E188 File Offset: 0x0030C388
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

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x0600CB46 RID: 52038 RVA: 0x0030E1C4 File Offset: 0x0030C3C4
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

		// Token: 0x0600CB47 RID: 52039 RVA: 0x0030E1FB File Offset: 0x0030C3FB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CB48 RID: 52040 RVA: 0x0030E20A File Offset: 0x0030C40A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x0600CB49 RID: 52041 RVA: 0x0030E224 File Offset: 0x0030C424
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

		// Token: 0x0600CB4A RID: 52042 RVA: 0x0030E25B File Offset: 0x0030C45B
		public Span<byte> GetSkillTypeTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CB4B RID: 52043 RVA: 0x0030E26A File Offset: 0x0030C46A
		public byte[] GetSkillTypeTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x0600CB4C RID: 52044 RVA: 0x0030E284 File Offset: 0x0030C484
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

		// Token: 0x0600CB4D RID: 52045 RVA: 0x0030E2BC File Offset: 0x0030C4BC
		public Span<byte> GetSkillNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CB4E RID: 52046 RVA: 0x0030E2CC File Offset: 0x0030C4CC
		public byte[] GetSkillNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x0600CB4F RID: 52047 RVA: 0x0030E2E4 File Offset: 0x0030C4E4
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

		// Token: 0x0600CB50 RID: 52048 RVA: 0x0030E31C File Offset: 0x0030C51C
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CB51 RID: 52049 RVA: 0x0030E32C File Offset: 0x0030C52C
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CB52 RID: 52050 RVA: 0x0030E344 File Offset: 0x0030C544
		public string SkillDescParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x0600CB53 RID: 52051 RVA: 0x0030E380 File Offset: 0x0030C580
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

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x0600CB54 RID: 52052 RVA: 0x0030E3AC File Offset: 0x0030C5AC
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

		// Token: 0x0600CB55 RID: 52053 RVA: 0x0030E3E4 File Offset: 0x0030C5E4
		public Span<byte> GetSkillResumeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CB56 RID: 52054 RVA: 0x0030E3F4 File Offset: 0x0030C5F4
		public byte[] GetSkillResumeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CB57 RID: 52055 RVA: 0x0030E40C File Offset: 0x0030C60C
		public string SkillResumeParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x0600CB58 RID: 52056 RVA: 0x0030E448 File Offset: 0x0030C648
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

		// Token: 0x0600CB59 RID: 52057 RVA: 0x0030E474 File Offset: 0x0030C674
		[NullableContext(1)]
		public string[] SkillDescParam()
		{
			return this.SkillDescParamIter().ToArray<string>();
		}

		// Token: 0x0600CB5A RID: 52058 RVA: 0x0030E481 File Offset: 0x0030C681
		[NullableContext(1)]
		public IEnumerable<string> SkillDescParamIter()
		{
			RogueSkill.<SkillDescParamIter>d__37 <SkillDescParamIter>d__ = new RogueSkill.<SkillDescParamIter>d__37(-2);
			<SkillDescParamIter>d__.<>3__<>4__this = this;
			return <SkillDescParamIter>d__;
		}

		// Token: 0x0600CB5B RID: 52059 RVA: 0x0030E496 File Offset: 0x0030C696
		[NullableContext(1)]
		public string[] SkillResumeParam()
		{
			return this.SkillResumeParamIter().ToArray<string>();
		}

		// Token: 0x0600CB5C RID: 52060 RVA: 0x0030E4A3 File Offset: 0x0030C6A3
		[NullableContext(1)]
		public IEnumerable<string> SkillResumeParamIter()
		{
			RogueSkill.<SkillResumeParamIter>d__39 <SkillResumeParamIter>d__ = new RogueSkill.<SkillResumeParamIter>d__39(-2);
			<SkillResumeParamIter>d__.<>3__<>4__this = this;
			return <SkillResumeParamIter>d__;
		}

		// Token: 0x040056FB RID: 22267
		private Table __p;
	}
}
