using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ACD RID: 2765
	public struct ActivitySplitPak : IFlatbufferObject
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060043F6 RID: 17398 RVA: 0x001CD72D File Offset: 0x001CB92D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x001CD73A File Offset: 0x001CB93A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x001CD744 File Offset: 0x001CB944
		public static ActivitySplitPak GetRootAsActivitySplitPak(ByteBuffer _bb)
		{
			return ActivitySplitPak.GetRootAsActivitySplitPak(_bb, default(ActivitySplitPak));
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x001CD760 File Offset: 0x001CB960
		public static ActivitySplitPak GetRootAsActivitySplitPak(ByteBuffer _bb, ActivitySplitPak obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060043FA RID: 17402 RVA: 0x001CD77D File Offset: 0x001CB97D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x001CD78C File Offset: 0x001CB98C
		public ActivitySplitPak __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060043FC RID: 17404 RVA: 0x001CD79C File Offset: 0x001CB99C
		public int ActivityType
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

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060043FD RID: 17405 RVA: 0x001CD7D8 File Offset: 0x001CB9D8
		public string ActivityTypeString
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

		// Token: 0x060043FE RID: 17406 RVA: 0x001CD80F File Offset: 0x001CBA0F
		public Span<byte> GetActivityTypeStringBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x001CD81E File Offset: 0x001CBA1E
		public byte[] GetActivityTypeStringArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x001CD838 File Offset: 0x001CBA38
		public string DependentDbList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06004401 RID: 17409 RVA: 0x001CD874 File Offset: 0x001CBA74
		public int DependentDbListLength
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

		// Token: 0x06004402 RID: 17410 RVA: 0x001CD89F File Offset: 0x001CBA9F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DependentDbListIter()或GetDependentDbListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DependentDbList()
		{
			return this.DependentDbListIter().ToArray<string>();
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x001CD8AC File Offset: 0x001CBAAC
		[NullableContext(1)]
		public readonly IEnumerable<string> DependentDbListIter()
		{
			ActivitySplitPak.<DependentDbListIter>d__18 <DependentDbListIter>d__ = new ActivitySplitPak.<DependentDbListIter>d__18(-2);
			<DependentDbListIter>d__.<>3__<>4__this = this;
			return <DependentDbListIter>d__;
		}

		// Token: 0x04004AAA RID: 19114
		private Table __p;
	}
}
