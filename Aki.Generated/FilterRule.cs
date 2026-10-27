using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C6E RID: 3182
	public struct FilterRule : IFlatbufferObject
	{
		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06006E42 RID: 28226 RVA: 0x0022E9F9 File Offset: 0x0022CBF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E43 RID: 28227 RVA: 0x0022EA06 File Offset: 0x0022CC06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E44 RID: 28228 RVA: 0x0022EA10 File Offset: 0x0022CC10
		public static FilterRule GetRootAsFilterRule(ByteBuffer _bb)
		{
			return FilterRule.GetRootAsFilterRule(_bb, default(FilterRule));
		}

		// Token: 0x06006E45 RID: 28229 RVA: 0x0022EA2C File Offset: 0x0022CC2C
		public static FilterRule GetRootAsFilterRule(ByteBuffer _bb, FilterRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E46 RID: 28230 RVA: 0x0022EA49 File Offset: 0x0022CC49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E47 RID: 28231 RVA: 0x0022EA58 File Offset: 0x0022CC58
		public FilterRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06006E48 RID: 28232 RVA: 0x0022EA68 File Offset: 0x0022CC68
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

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06006E49 RID: 28233 RVA: 0x0022EAA4 File Offset: 0x0022CCA4
		public int FilterType
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

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06006E4A RID: 28234 RVA: 0x0022EAE0 File Offset: 0x0022CCE0
		public string Title
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

		// Token: 0x06006E4B RID: 28235 RVA: 0x0022EB17 File Offset: 0x0022CD17
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006E4C RID: 28236 RVA: 0x0022EB26 File Offset: 0x0022CD26
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06006E4D RID: 28237 RVA: 0x0022EB40 File Offset: 0x0022CD40
		public int IdList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06006E4E RID: 28238 RVA: 0x0022EB80 File Offset: 0x0022CD80
		public int IdListLength
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

		// Token: 0x06006E4F RID: 28239 RVA: 0x0022EBAC File Offset: 0x0022CDAC
		public Span<int> GetIdListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006E50 RID: 28240 RVA: 0x0022EBBC File Offset: 0x0022CDBC
		public int[] GetIdListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06006E51 RID: 28241 RVA: 0x0022EBD4 File Offset: 0x0022CDD4
		public bool NeedChangeColor
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06006E52 RID: 28242 RVA: 0x0022EC14 File Offset: 0x0022CE14
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IdListIter()或GetIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] IdList()
		{
			FilterRule filterRule = this;
			return filterRule.GetIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006E53 RID: 28243 RVA: 0x0022EC38 File Offset: 0x0022CE38
		[NullableContext(1)]
		public readonly IEnumerable<int> IdListIter()
		{
			FilterRule.<IdListIter>d__24 <IdListIter>d__ = new FilterRule.<IdListIter>d__24(-2);
			<IdListIter>d__.<>3__<>4__this = this;
			return <IdListIter>d__;
		}

		// Token: 0x04004CB9 RID: 19641
		private Table __p;
	}
}
