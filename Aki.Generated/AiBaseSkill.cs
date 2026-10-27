using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE8 RID: 2792
	public struct AiBaseSkill : IFlatbufferObject
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06004647 RID: 17991 RVA: 0x001D236C File Offset: 0x001D056C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x001D2379 File Offset: 0x001D0579
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x001D2380 File Offset: 0x001D0580
		public static AiBaseSkill GetRootAsAiBaseSkill(ByteBuffer _bb)
		{
			return AiBaseSkill.GetRootAsAiBaseSkill(_bb, default(AiBaseSkill));
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x001D239C File Offset: 0x001D059C
		public static AiBaseSkill GetRootAsAiBaseSkill(ByteBuffer _bb, AiBaseSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x001D23B9 File Offset: 0x001D05B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x001D23C8 File Offset: 0x001D05C8
		public AiBaseSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600464D RID: 17997 RVA: 0x001D23D8 File Offset: 0x001D05D8
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

		// Token: 0x0600464E RID: 17998 RVA: 0x001D2414 File Offset: 0x001D0614
		public IntArray? RandomSkills(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600464F RID: 17999 RVA: 0x001D2474 File Offset: 0x001D0674
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

		// Token: 0x06004650 RID: 18000 RVA: 0x001D249F File Offset: 0x001D069F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RandomSkillsIter()或GetRandomSkillsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] RandomSkills()
		{
			return this.RandomSkillsIter().ToArray<IntArray>();
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x001D24AC File Offset: 0x001D06AC
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> RandomSkillsIter()
		{
			AiBaseSkill.<RandomSkillsIter>d__14 <RandomSkillsIter>d__ = new AiBaseSkill.<RandomSkillsIter>d__14(-2);
			<RandomSkillsIter>d__.<>3__<>4__this = this;
			return <RandomSkillsIter>d__;
		}

		// Token: 0x04004AC9 RID: 19145
		private Table __p;
	}
}
