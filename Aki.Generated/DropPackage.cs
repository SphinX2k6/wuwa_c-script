using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF4 RID: 3316
	public struct DropPackage : IFlatbufferObject
	{
		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06006BDD RID: 27613 RVA: 0x0023B84D File Offset: 0x00239A4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x0023B85A File Offset: 0x00239A5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x0023B864 File Offset: 0x00239A64
		public static DropPackage GetRootAsDropPackage(ByteBuffer _bb)
		{
			return DropPackage.GetRootAsDropPackage(_bb, default(DropPackage));
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x0023B880 File Offset: 0x00239A80
		public static DropPackage GetRootAsDropPackage(ByteBuffer _bb, DropPackage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x0023B89D File Offset: 0x00239A9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006BE2 RID: 27618 RVA: 0x0023B8AC File Offset: 0x00239AAC
		public DropPackage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06006BE3 RID: 27619 RVA: 0x0023B8BC File Offset: 0x00239ABC
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

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06006BE4 RID: 27620 RVA: 0x0023B8F8 File Offset: 0x00239AF8
		public bool ShowBg
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06006BE5 RID: 27621 RVA: 0x0023B938 File Offset: 0x00239B38
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

		// Token: 0x06006BE6 RID: 27622 RVA: 0x0023B96F File Offset: 0x00239B6F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x0023B97E File Offset: 0x00239B7E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06006BE8 RID: 27624 RVA: 0x0023B998 File Offset: 0x00239B98
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

		// Token: 0x06006BE9 RID: 27625 RVA: 0x0023B9D8 File Offset: 0x00239BD8
		public DicIntInt? DropPreview(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06006BEA RID: 27626 RVA: 0x0023BA3C File Offset: 0x00239C3C
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

		// Token: 0x06006BEB RID: 27627 RVA: 0x0023BA68 File Offset: 0x00239C68
		[NullableContext(1)]
		public Dictionary<int, int> DropPreview()
		{
			return this.DropPreviewIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006BEC RID: 27628 RVA: 0x0023BABE File Offset: 0x00239CBE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DropPreviewIter()
		{
			DropPackage.<DropPreviewIter>d__22 <DropPreviewIter>d__ = new DropPackage.<DropPreviewIter>d__22(-2);
			<DropPreviewIter>d__.<>3__<>4__this = this;
			return <DropPreviewIter>d__;
		}

		// Token: 0x06006BED RID: 27629 RVA: 0x0023BAD4 File Offset: 0x00239CD4
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

		// Token: 0x06006BEE RID: 27630 RVA: 0x0023BB08 File Offset: 0x00239D08
		private void EnsureDropPreviewCacheIfNeeded()
		{
			if (this.DropPreviewCache != null)
			{
				return;
			}
			this.DropPreviewCache = this.DropPreviewIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x0023BB6E File Offset: 0x00239D6E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDropPreviewFrozenDict()
		{
			this.EnsureDropPreviewCacheIfNeeded();
			return this.DropPreviewCache;
		}

		// Token: 0x04005231 RID: 21041
		private Table __p;

		// Token: 0x04005232 RID: 21042
		[Nullable(2)]
		private FrozenDictionary<int, int> DropPreviewCache;
	}
}
