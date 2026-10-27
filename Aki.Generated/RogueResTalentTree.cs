using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001015 RID: 4117
	public struct RogueResTalentTree : IFlatbufferObject
	{
		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x0600C408 RID: 50184 RVA: 0x002EFEF9 File Offset: 0x002EE0F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C409 RID: 50185 RVA: 0x002EFF06 File Offset: 0x002EE106
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C40A RID: 50186 RVA: 0x002EFF10 File Offset: 0x002EE110
		public static RogueResTalentTree GetRootAsRogueResTalentTree(ByteBuffer _bb)
		{
			return RogueResTalentTree.GetRootAsRogueResTalentTree(_bb, default(RogueResTalentTree));
		}

		// Token: 0x0600C40B RID: 50187 RVA: 0x002EFF2C File Offset: 0x002EE12C
		public static RogueResTalentTree GetRootAsRogueResTalentTree(ByteBuffer _bb, RogueResTalentTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C40C RID: 50188 RVA: 0x002EFF49 File Offset: 0x002EE149
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C40D RID: 50189 RVA: 0x002EFF58 File Offset: 0x002EE158
		public RogueResTalentTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x0600C40E RID: 50190 RVA: 0x002EFF68 File Offset: 0x002EE168
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

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x0600C40F RID: 50191 RVA: 0x002EFFA4 File Offset: 0x002EE1A4
		public int SeasonId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x0600C410 RID: 50192 RVA: 0x002EFFE0 File Offset: 0x002EE1E0
		public int Condition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C411 RID: 50193 RVA: 0x002F001C File Offset: 0x002EE21C
		public int Consule(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x0600C412 RID: 50194 RVA: 0x002F005C File Offset: 0x002EE25C
		public int ConsuleLength
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

		// Token: 0x0600C413 RID: 50195 RVA: 0x002F0088 File Offset: 0x002EE288
		public Span<int> GetConsuleBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C414 RID: 50196 RVA: 0x002F0098 File Offset: 0x002EE298
		public int[] GetConsuleArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x0600C415 RID: 50197 RVA: 0x002F00B0 File Offset: 0x002EE2B0
		public int Describe
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C416 RID: 50198 RVA: 0x002F00F0 File Offset: 0x002EE2F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConsuleIter()或GetConsuleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Consule()
		{
			RogueResTalentTree rogueResTalentTree = this;
			return rogueResTalentTree.GetConsuleArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C417 RID: 50199 RVA: 0x002F0114 File Offset: 0x002EE314
		[NullableContext(1)]
		public readonly IEnumerable<int> ConsuleIter()
		{
			RogueResTalentTree.<ConsuleIter>d__22 <ConsuleIter>d__ = new RogueResTalentTree.<ConsuleIter>d__22(-2);
			<ConsuleIter>d__.<>3__<>4__this = this;
			return <ConsuleIter>d__;
		}

		// Token: 0x04005103 RID: 20739
		private Table __p;
	}
}
