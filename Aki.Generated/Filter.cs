using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C6D RID: 3181
	public struct Filter : IFlatbufferObject
	{
		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06006E2D RID: 28205 RVA: 0x0022E6EC File Offset: 0x0022C8EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E2E RID: 28206 RVA: 0x0022E6F9 File Offset: 0x0022C8F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E2F RID: 28207 RVA: 0x0022E700 File Offset: 0x0022C900
		public static Filter GetRootAsFilter(ByteBuffer _bb)
		{
			return Filter.GetRootAsFilter(_bb, default(Filter));
		}

		// Token: 0x06006E30 RID: 28208 RVA: 0x0022E71C File Offset: 0x0022C91C
		public static Filter GetRootAsFilter(ByteBuffer _bb, Filter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E31 RID: 28209 RVA: 0x0022E739 File Offset: 0x0022C939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E32 RID: 28210 RVA: 0x0022E748 File Offset: 0x0022C948
		public Filter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06006E33 RID: 28211 RVA: 0x0022E758 File Offset: 0x0022C958
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

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06006E34 RID: 28212 RVA: 0x0022E794 File Offset: 0x0022C994
		public int DataType
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

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06006E35 RID: 28213 RVA: 0x0022E7D0 File Offset: 0x0022C9D0
		public int PrefabType
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

		// Token: 0x06006E36 RID: 28214 RVA: 0x0022E80C File Offset: 0x0022CA0C
		public int RuleList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06006E37 RID: 28215 RVA: 0x0022E84C File Offset: 0x0022CA4C
		public int RuleListLength
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

		// Token: 0x06006E38 RID: 28216 RVA: 0x0022E878 File Offset: 0x0022CA78
		public Span<int> GetRuleListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006E39 RID: 28217 RVA: 0x0022E888 File Offset: 0x0022CA88
		public int[] GetRuleListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06006E3A RID: 28218 RVA: 0x0022E8A0 File Offset: 0x0022CAA0
		public bool IsSupportSelectAll
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06006E3B RID: 28219 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
		public bool IsSelectAllUnion
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06006E3C RID: 28220 RVA: 0x0022E920 File Offset: 0x0022CB20
		public bool IsShowIcon
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06006E3D RID: 28221 RVA: 0x0022E960 File Offset: 0x0022CB60
		public string GridType
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

		// Token: 0x06006E3E RID: 28222 RVA: 0x0022E998 File Offset: 0x0022CB98
		public Span<byte> GetGridTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006E3F RID: 28223 RVA: 0x0022E9A8 File Offset: 0x0022CBA8
		public byte[] GetGridTypeArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06006E40 RID: 28224 RVA: 0x0022E9C0 File Offset: 0x0022CBC0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RuleListIter()或GetRuleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RuleList()
		{
			Filter filter = this;
			return filter.GetRuleListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006E41 RID: 28225 RVA: 0x0022E9E4 File Offset: 0x0022CBE4
		[NullableContext(1)]
		public readonly IEnumerable<int> RuleListIter()
		{
			Filter.<RuleListIter>d__30 <RuleListIter>d__ = new Filter.<RuleListIter>d__30(-2);
			<RuleListIter>d__.<>3__<>4__this = this;
			return <RuleListIter>d__;
		}

		// Token: 0x04004CB8 RID: 19640
		private Table __p;
	}
}
