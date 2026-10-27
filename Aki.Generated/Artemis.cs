using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B0B RID: 2827
	public struct Artemis : IFlatbufferObject
	{
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06004926 RID: 18726 RVA: 0x001D8F9D File Offset: 0x001D719D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x001D8FAA File Offset: 0x001D71AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x001D8FB4 File Offset: 0x001D71B4
		public static Artemis GetRootAsArtemis(ByteBuffer _bb)
		{
			return Artemis.GetRootAsArtemis(_bb, default(Artemis));
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x001D8FD0 File Offset: 0x001D71D0
		public static Artemis GetRootAsArtemis(ByteBuffer _bb, Artemis obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x001D8FED File Offset: 0x001D71ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x001D8FFC File Offset: 0x001D71FC
		public Artemis __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600492C RID: 18732 RVA: 0x001D900C File Offset: 0x001D720C
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

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600492D RID: 18733 RVA: 0x001D9048 File Offset: 0x001D7248
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

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600492E RID: 18734 RVA: 0x001D9084 File Offset: 0x001D7284
		public int UnlockDay
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

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600492F RID: 18735 RVA: 0x001D90C0 File Offset: 0x001D72C0
		public int OpenDay
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

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06004930 RID: 18736 RVA: 0x001D9100 File Offset: 0x001D7300
		public int DropId
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

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06004931 RID: 18737 RVA: 0x001D9140 File Offset: 0x001D7340
		public int PreSignId
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

		// Token: 0x06004932 RID: 18738 RVA: 0x001D9180 File Offset: 0x001D7380
		public int ChatIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06004933 RID: 18739 RVA: 0x001D91C0 File Offset: 0x001D73C0
		public int ChatIdsLength
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

		// Token: 0x06004934 RID: 18740 RVA: 0x001D91EC File Offset: 0x001D73EC
		public Span<int> GetChatIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x001D91FC File Offset: 0x001D73FC
		public int[] GetChatIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06004936 RID: 18742 RVA: 0x001D9214 File Offset: 0x001D7414
		public int QteId
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

		// Token: 0x06004937 RID: 18743 RVA: 0x001D9254 File Offset: 0x001D7454
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ChatIdsIter()或GetChatIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ChatIds()
		{
			Artemis artemis = this;
			return artemis.GetChatIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x001D9278 File Offset: 0x001D7478
		[NullableContext(1)]
		public readonly IEnumerable<int> ChatIdsIter()
		{
			Artemis.<ChatIdsIter>d__28 <ChatIdsIter>d__ = new Artemis.<ChatIdsIter>d__28(-2);
			<ChatIdsIter>d__.<>3__<>4__this = this;
			return <ChatIdsIter>d__;
		}

		// Token: 0x04004AF0 RID: 19184
		private Table __p;
	}
}
