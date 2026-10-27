using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE3 RID: 3299
	public struct GaChaShare : IFlatbufferObject
	{
		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x0600783D RID: 30781 RVA: 0x00246251 File Offset: 0x00244451
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x0024625E File Offset: 0x0024445E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x00246268 File Offset: 0x00244468
		public static GaChaShare GetRootAsGaChaShare(ByteBuffer _bb)
		{
			return GaChaShare.GetRootAsGaChaShare(_bb, default(GaChaShare));
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x00246284 File Offset: 0x00244484
		public static GaChaShare GetRootAsGaChaShare(ByteBuffer _bb, GaChaShare obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x002462A1 File Offset: 0x002444A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x002462B0 File Offset: 0x002444B0
		public GaChaShare __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06007843 RID: 30787 RVA: 0x002462C0 File Offset: 0x002444C0
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

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06007844 RID: 30788 RVA: 0x002462FC File Offset: 0x002444FC
		public int Type
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

		// Token: 0x06007845 RID: 30789 RVA: 0x00246338 File Offset: 0x00244538
		public int ShareTypes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06007846 RID: 30790 RVA: 0x00246378 File Offset: 0x00244578
		public int ShareTypesLength
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

		// Token: 0x06007847 RID: 30791 RVA: 0x002463A3 File Offset: 0x002445A3
		public Span<int> GetShareTypesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x002463B2 File Offset: 0x002445B2
		public int[] GetShareTypesArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06007849 RID: 30793 RVA: 0x002463CC File Offset: 0x002445CC
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x00246404 File Offset: 0x00244604
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x00246414 File Offset: 0x00244614
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x0600784C RID: 30796 RVA: 0x0024642C File Offset: 0x0024462C
		public string SharePic
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x00246464 File Offset: 0x00244664
		public Span<byte> GetSharePicBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x00246474 File Offset: 0x00244674
		public byte[] GetSharePicArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x0024648C File Offset: 0x0024468C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShareTypesIter()或GetShareTypesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShareTypes()
		{
			GaChaShare gaChaShare = this;
			return gaChaShare.GetShareTypesArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x002464B0 File Offset: 0x002446B0
		[NullableContext(1)]
		public readonly IEnumerable<int> ShareTypesIter()
		{
			GaChaShare.<ShareTypesIter>d__26 <ShareTypesIter>d__ = new GaChaShare.<ShareTypesIter>d__26(-2);
			<ShareTypesIter>d__.<>3__<>4__this = this;
			return <ShareTypesIter>d__;
		}

		// Token: 0x04004D54 RID: 19796
		private Table __p;
	}
}
