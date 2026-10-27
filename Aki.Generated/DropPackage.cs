using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C12 RID: 3090
	public struct DropPackage : IFlatbufferObject
	{
		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x060065FE RID: 26110 RVA: 0x0021C579 File Offset: 0x0021A779
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060065FF RID: 26111 RVA: 0x0021C586 File Offset: 0x0021A786
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x0021C590 File Offset: 0x0021A790
		public static DropPackage GetRootAsDropPackage(ByteBuffer _bb)
		{
			return DropPackage.GetRootAsDropPackage(_bb, default(DropPackage));
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x0021C5AC File Offset: 0x0021A7AC
		public static DropPackage GetRootAsDropPackage(ByteBuffer _bb, DropPackage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x0021C5C9 File Offset: 0x0021A7C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006603 RID: 26115 RVA: 0x0021C5D8 File Offset: 0x0021A7D8
		public DropPackage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06006604 RID: 26116 RVA: 0x0021C5E8 File Offset: 0x0021A7E8
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

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06006605 RID: 26117 RVA: 0x0021C624 File Offset: 0x0021A824
		public bool ShowBg
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06006606 RID: 26118 RVA: 0x0021C664 File Offset: 0x0021A864
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

		// Token: 0x06006607 RID: 26119 RVA: 0x0021C69B File Offset: 0x0021A89B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x0021C6AA File Offset: 0x0021A8AA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06006609 RID: 26121 RVA: 0x0021C6C4 File Offset: 0x0021A8C4
		public int DropPlan
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

		// Token: 0x0600660A RID: 26122 RVA: 0x0021C704 File Offset: 0x0021A904
		public DicIntInt? DropPreview(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x0600660B RID: 26123 RVA: 0x0021C768 File Offset: 0x0021A968
		public int DropPreviewLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600660C RID: 26124 RVA: 0x0021C794 File Offset: 0x0021A994
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DropPreviewFrozenDict()缓存字典，遍历请使用DropPreviewIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DropPreview()
		{
			return this.DropPreviewIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600660D RID: 26125 RVA: 0x0021C7EA File Offset: 0x0021A9EA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DropPreviewIter()
		{
			DropPackage.<DropPreviewIter>d__22 <DropPreviewIter>d__ = new DropPackage.<DropPreviewIter>d__22(-2);
			<DropPreviewIter>d__.<>3__<>4__this = this;
			return <DropPreviewIter>d__;
		}

		// Token: 0x0600660E RID: 26126 RVA: 0x0021C800 File Offset: 0x0021AA00
		public int? GetDropPreview(int key)
		{
			this.EnsureDropPreviewCacheIfNeeded();
			int value;
			if (!this.DropPreviewCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600660F RID: 26127 RVA: 0x0021C834 File Offset: 0x0021AA34
		private void EnsureDropPreviewCacheIfNeeded()
		{
			if (this.DropPreviewCache != null)
			{
				return;
			}
			this.DropPreviewCache = this.DropPreviewIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006610 RID: 26128 RVA: 0x0021C89A File Offset: 0x0021AA9A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDropPreviewFrozenDict(int key)
		{
			this.EnsureDropPreviewCacheIfNeeded();
			return this.DropPreviewCache;
		}

		// Token: 0x04004C4F RID: 19535
		private Table __p;

		// Token: 0x04004C50 RID: 19536
		[Nullable(2)]
		private FrozenDictionary<int, int> DropPreviewCache;
	}
}
