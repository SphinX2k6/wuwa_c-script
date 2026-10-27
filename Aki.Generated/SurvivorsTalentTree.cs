using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001108 RID: 4360
	public struct SurvivorsTalentTree : IFlatbufferObject
	{
		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x0600DB95 RID: 56213 RVA: 0x00326734 File Offset: 0x00324934
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DB96 RID: 56214 RVA: 0x00326741 File Offset: 0x00324941
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DB97 RID: 56215 RVA: 0x00326748 File Offset: 0x00324948
		public static SurvivorsTalentTree GetRootAsSurvivorsTalentTree(ByteBuffer _bb)
		{
			return SurvivorsTalentTree.GetRootAsSurvivorsTalentTree(_bb, default(SurvivorsTalentTree));
		}

		// Token: 0x0600DB98 RID: 56216 RVA: 0x00326764 File Offset: 0x00324964
		public static SurvivorsTalentTree GetRootAsSurvivorsTalentTree(ByteBuffer _bb, SurvivorsTalentTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DB99 RID: 56217 RVA: 0x00326781 File Offset: 0x00324981
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DB9A RID: 56218 RVA: 0x00326790 File Offset: 0x00324990
		public SurvivorsTalentTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x0600DB9B RID: 56219 RVA: 0x003267A0 File Offset: 0x003249A0
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

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x0600DB9C RID: 56220 RVA: 0x003267DC File Offset: 0x003249DC
		public int ActivityId
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

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x0600DB9D RID: 56221 RVA: 0x00326818 File Offset: 0x00324A18
		public string Name
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

		// Token: 0x0600DB9E RID: 56222 RVA: 0x0032684F File Offset: 0x00324A4F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DB9F RID: 56223 RVA: 0x0032685E File Offset: 0x00324A5E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x0600DBA0 RID: 56224 RVA: 0x00326878 File Offset: 0x00324A78
		public int Area
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x0600DBA1 RID: 56225 RVA: 0x003268B8 File Offset: 0x00324AB8
		public int Type
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

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x0600DBA2 RID: 56226 RVA: 0x003268F8 File Offset: 0x00324AF8
		public int IndexId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x0600DBA3 RID: 56227 RVA: 0x00326938 File Offset: 0x00324B38
		public int IndexSortId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DBA4 RID: 56228 RVA: 0x00326978 File Offset: 0x00324B78
		public int PreNode(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x0600DBA5 RID: 56229 RVA: 0x003269B8 File Offset: 0x00324BB8
		public int PreNodeLength
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

		// Token: 0x0600DBA6 RID: 56230 RVA: 0x003269E4 File Offset: 0x00324BE4
		public Span<int> GetPreNodeBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600DBA7 RID: 56231 RVA: 0x003269F4 File Offset: 0x00324BF4
		public int[] GetPreNodeArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x0600DBA8 RID: 56232 RVA: 0x00326A0C File Offset: 0x00324C0C
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x0600DBA9 RID: 56233 RVA: 0x00326A4C File Offset: 0x00324C4C
		public string UnlockConditionDesc
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

		// Token: 0x0600DBAA RID: 56234 RVA: 0x00326A84 File Offset: 0x00324C84
		public Span<byte> GetUnlockConditionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600DBAB RID: 56235 RVA: 0x00326A94 File Offset: 0x00324C94
		public byte[] GetUnlockConditionDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x0600DBAC RID: 56236 RVA: 0x00326AAC File Offset: 0x00324CAC
		public int Effect
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x0600DBAD RID: 56237 RVA: 0x00326AEC File Offset: 0x00324CEC
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DBAE RID: 56238 RVA: 0x00326B24 File Offset: 0x00324D24
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600DBAF RID: 56239 RVA: 0x00326B34 File Offset: 0x00324D34
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DBB0 RID: 56240 RVA: 0x00326B4C File Offset: 0x00324D4C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreNodeIter()或GetPreNodeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreNode()
		{
			SurvivorsTalentTree survivorsTalentTree = this;
			return survivorsTalentTree.GetPreNodeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DBB1 RID: 56241 RVA: 0x00326B70 File Offset: 0x00324D70
		[NullableContext(1)]
		public readonly IEnumerable<int> PreNodeIter()
		{
			SurvivorsTalentTree.<PreNodeIter>d__42 <PreNodeIter>d__ = new SurvivorsTalentTree.<PreNodeIter>d__42(-2);
			<PreNodeIter>d__.<>3__<>4__this = this;
			return <PreNodeIter>d__;
		}

		// Token: 0x04005242 RID: 21058
		private Table __p;
	}
}
