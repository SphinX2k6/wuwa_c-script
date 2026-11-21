using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC2 RID: 3010
	public struct AiBaseSkill : IFlatbufferObject
	{
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06004B8E RID: 19342 RVA: 0x001F1E04 File Offset: 0x001F0004
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004B8F RID: 19343 RVA: 0x001F1E11 File Offset: 0x001F0011
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x001F1E18 File Offset: 0x001F0018
		public static AiBaseSkill GetRootAsAiBaseSkill(ByteBuffer _bb)
		{
			return AiBaseSkill.GetRootAsAiBaseSkill(_bb, default(AiBaseSkill));
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x001F1E34 File Offset: 0x001F0034
		public static AiBaseSkill GetRootAsAiBaseSkill(ByteBuffer _bb, AiBaseSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x001F1E51 File Offset: 0x001F0051
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x001F1E60 File Offset: 0x001F0060
		public AiBaseSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06004B94 RID: 19348 RVA: 0x001F1E70 File Offset: 0x001F0070
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

		// Token: 0x06004B95 RID: 19349 RVA: 0x001F1EAC File Offset: 0x001F00AC
		public IntArray? RandomSkills(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06004B96 RID: 19350 RVA: 0x001F1F0C File Offset: 0x001F010C
		public int RandomSkillsLength
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

		// Token: 0x06004B97 RID: 19351 RVA: 0x001F1F37 File Offset: 0x001F0137
		[NullableContext(1)]
		public IntArray[] RandomSkills()
		{
			return this.RandomSkillsIter().ToArray<IntArray>();
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x001F1F44 File Offset: 0x001F0144
		[NullableContext(1)]
		public IEnumerable<IntArray> RandomSkillsIter()
		{
			AiBaseSkill.<RandomSkillsIter>d__14 <RandomSkillsIter>d__ = new AiBaseSkill.<RandomSkillsIter>d__14(-2);
			<RandomSkillsIter>d__.<>3__<>4__this = this;
			return <RandomSkillsIter>d__;
		}

		// Token: 0x040050A3 RID: 20643
		private Table __p;
	}
}
