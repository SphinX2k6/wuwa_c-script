using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E6C RID: 3692
	public struct JokerSkill : IFlatbufferObject
	{
		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06008D2E RID: 36142 RVA: 0x00285BF0 File Offset: 0x00283DF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D2F RID: 36143 RVA: 0x00285BFD File Offset: 0x00283DFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D30 RID: 36144 RVA: 0x00285C04 File Offset: 0x00283E04
		public static JokerSkill GetRootAsJokerSkill(ByteBuffer _bb)
		{
			return JokerSkill.GetRootAsJokerSkill(_bb, default(JokerSkill));
		}

		// Token: 0x06008D31 RID: 36145 RVA: 0x00285C20 File Offset: 0x00283E20
		public static JokerSkill GetRootAsJokerSkill(ByteBuffer _bb, JokerSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D32 RID: 36146 RVA: 0x00285C3D File Offset: 0x00283E3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D33 RID: 36147 RVA: 0x00285C4C File Offset: 0x00283E4C
		public JokerSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06008D34 RID: 36148 RVA: 0x00285C5C File Offset: 0x00283E5C
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

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06008D35 RID: 36149 RVA: 0x00285C98 File Offset: 0x00283E98
		public string SkillName
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

		// Token: 0x06008D36 RID: 36150 RVA: 0x00285CCF File Offset: 0x00283ECF
		public Span<byte> GetSkillNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008D37 RID: 36151 RVA: 0x00285CDE File Offset: 0x00283EDE
		public byte[] GetSkillNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x06008D38 RID: 36152 RVA: 0x00285CF8 File Offset: 0x00283EF8
		public string SkillDesc
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

		// Token: 0x06008D39 RID: 36153 RVA: 0x00285D2F File Offset: 0x00283F2F
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008D3A RID: 36154 RVA: 0x00285D3E File Offset: 0x00283F3E
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06008D3B RID: 36155 RVA: 0x00285D58 File Offset: 0x00283F58
		public string ShortSkillDesc
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

		// Token: 0x06008D3C RID: 36156 RVA: 0x00285D90 File Offset: 0x00283F90
		public Span<byte> GetShortSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008D3D RID: 36157 RVA: 0x00285DA0 File Offset: 0x00283FA0
		public byte[] GetShortSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x06008D3E RID: 36158 RVA: 0x00285DB8 File Offset: 0x00283FB8
		public string SkillIconPath
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

		// Token: 0x06008D3F RID: 36159 RVA: 0x00285DF0 File Offset: 0x00283FF0
		public Span<byte> GetSkillIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008D40 RID: 36160 RVA: 0x00285E00 File Offset: 0x00284000
		public byte[] GetSkillIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x06008D41 RID: 36161 RVA: 0x00285E18 File Offset: 0x00284018
		public string WhiteSkillIconPath
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008D42 RID: 36162 RVA: 0x00285E50 File Offset: 0x00284050
		public Span<byte> GetWhiteSkillIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008D43 RID: 36163 RVA: 0x00285E60 File Offset: 0x00284060
		public byte[] GetWhiteSkillIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06008D44 RID: 36164 RVA: 0x00285E78 File Offset: 0x00284078
		public string SkillPlayTexture(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06008D45 RID: 36165 RVA: 0x00285EB4 File Offset: 0x002840B4
		public int SkillPlayTextureLength
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

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06008D46 RID: 36166 RVA: 0x00285EE0 File Offset: 0x002840E0
		public int EffectPlayStrategy
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06008D47 RID: 36167 RVA: 0x00285F20 File Offset: 0x00284120
		public bool ShowGiveUpTip
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06008D48 RID: 36168 RVA: 0x00285F60 File Offset: 0x00284160
		public int HelpId
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

		// Token: 0x06008D49 RID: 36169 RVA: 0x00285F9D File Offset: 0x0028419D
		[NullableContext(1)]
		public string[] SkillPlayTexture()
		{
			return this.SkillPlayTextureIter().ToArray<string>();
		}

		// Token: 0x06008D4A RID: 36170 RVA: 0x00285FAA File Offset: 0x002841AA
		[NullableContext(1)]
		public IEnumerable<string> SkillPlayTextureIter()
		{
			JokerSkill.<SkillPlayTextureIter>d__40 <SkillPlayTextureIter>d__ = new JokerSkill.<SkillPlayTextureIter>d__40(-2);
			<SkillPlayTextureIter>d__.<>3__<>4__this = this;
			return <SkillPlayTextureIter>d__;
		}

		// Token: 0x040053F8 RID: 21496
		private Table __p;
	}
}
