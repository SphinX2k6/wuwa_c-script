using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE0 RID: 3808
	public struct PhantomCollectActivity : IFlatbufferObject
	{
		// Token: 0x1700269F RID: 9887
		// (get) Token: 0x0600A812 RID: 43026 RVA: 0x002B1F81 File Offset: 0x002B0181
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x002B1F8E File Offset: 0x002B018E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A814 RID: 43028 RVA: 0x002B1F98 File Offset: 0x002B0198
		public static PhantomCollectActivity GetRootAsPhantomCollectActivity(ByteBuffer _bb)
		{
			return PhantomCollectActivity.GetRootAsPhantomCollectActivity(_bb, default(PhantomCollectActivity));
		}

		// Token: 0x0600A815 RID: 43029 RVA: 0x002B1FB4 File Offset: 0x002B01B4
		public static PhantomCollectActivity GetRootAsPhantomCollectActivity(ByteBuffer _bb, PhantomCollectActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A816 RID: 43030 RVA: 0x002B1FD1 File Offset: 0x002B01D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A817 RID: 43031 RVA: 0x002B1FE0 File Offset: 0x002B01E0
		public PhantomCollectActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x0600A818 RID: 43032 RVA: 0x002B1FF0 File Offset: 0x002B01F0
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

		// Token: 0x0600A819 RID: 43033 RVA: 0x002B202C File Offset: 0x002B022C
		public int Phantoms(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x0600A81A RID: 43034 RVA: 0x002B206C File Offset: 0x002B026C
		public int PhantomsLength
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

		// Token: 0x0600A81B RID: 43035 RVA: 0x002B2097 File Offset: 0x002B0297
		public Span<int> GetPhantomsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600A81C RID: 43036 RVA: 0x002B20A6 File Offset: 0x002B02A6
		public int[] GetPhantomsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x0600A81D RID: 43037 RVA: 0x002B20C0 File Offset: 0x002B02C0
		public int PhantomReward
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

		// Token: 0x0600A81E RID: 43038 RVA: 0x002B20FC File Offset: 0x002B02FC
		public DicIntString? PhantomDesc(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170026A3 RID: 9891
		// (get) Token: 0x0600A81F RID: 43039 RVA: 0x002B2160 File Offset: 0x002B0360
		public int PhantomDescLength
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

		// Token: 0x0600A820 RID: 43040 RVA: 0x002B218C File Offset: 0x002B038C
		public DicIntString? PhantomActivityImage(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170026A4 RID: 9892
		// (get) Token: 0x0600A821 RID: 43041 RVA: 0x002B21F0 File Offset: 0x002B03F0
		public int PhantomActivityImageLength
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

		// Token: 0x170026A5 RID: 9893
		// (get) Token: 0x0600A822 RID: 43042 RVA: 0x002B221C File Offset: 0x002B041C
		public int DataDockLevel
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

		// Token: 0x170026A6 RID: 9894
		// (get) Token: 0x0600A823 RID: 43043 RVA: 0x002B225C File Offset: 0x002B045C
		public int DataDockReward
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

		// Token: 0x0600A824 RID: 43044 RVA: 0x002B229C File Offset: 0x002B049C
		public int PhantomSideQuest(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x0600A825 RID: 43045 RVA: 0x002B22DC File Offset: 0x002B04DC
		public int PhantomSideQuestLength
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

		// Token: 0x0600A826 RID: 43046 RVA: 0x002B2308 File Offset: 0x002B0508
		public Span<int> GetPhantomSideQuestBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600A827 RID: 43047 RVA: 0x002B2318 File Offset: 0x002B0518
		public int[] GetPhantomSideQuestArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x0600A828 RID: 43048 RVA: 0x002B2330 File Offset: 0x002B0530
		public int PhantomSideQuestReward
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

		// Token: 0x0600A829 RID: 43049 RVA: 0x002B2370 File Offset: 0x002B0570
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PhantomActivityImageFrozenDict()缓存字典，遍历请使用PhantomActivityImageIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> PhantomActivityImage()
		{
			return this.PhantomActivityImageIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600A82A RID: 43050 RVA: 0x002B23C6 File Offset: 0x002B05C6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> PhantomActivityImageIter()
		{
			PhantomCollectActivity.<PhantomActivityImageIter>d__35 <PhantomActivityImageIter>d__ = new PhantomCollectActivity.<PhantomActivityImageIter>d__35(-2);
			<PhantomActivityImageIter>d__.<>3__<>4__this = this;
			return <PhantomActivityImageIter>d__;
		}

		// Token: 0x0600A82B RID: 43051 RVA: 0x002B23DC File Offset: 0x002B05DC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PhantomDescFrozenDict()缓存字典，遍历请使用PhantomDescIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> PhantomDesc()
		{
			return this.PhantomDescIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600A82C RID: 43052 RVA: 0x002B2432 File Offset: 0x002B0632
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> PhantomDescIter()
		{
			PhantomCollectActivity.<PhantomDescIter>d__37 <PhantomDescIter>d__ = new PhantomCollectActivity.<PhantomDescIter>d__37(-2);
			<PhantomDescIter>d__.<>3__<>4__this = this;
			return <PhantomDescIter>d__;
		}

		// Token: 0x0600A82D RID: 43053 RVA: 0x002B2448 File Offset: 0x002B0648
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomSideQuestIter()或GetPhantomSideQuestBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhantomSideQuest()
		{
			PhantomCollectActivity phantomCollectActivity = this;
			return phantomCollectActivity.GetPhantomSideQuestArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A82E RID: 43054 RVA: 0x002B246C File Offset: 0x002B066C
		[NullableContext(1)]
		public readonly IEnumerable<int> PhantomSideQuestIter()
		{
			PhantomCollectActivity.<PhantomSideQuestIter>d__39 <PhantomSideQuestIter>d__ = new PhantomCollectActivity.<PhantomSideQuestIter>d__39(-2);
			<PhantomSideQuestIter>d__.<>3__<>4__this = this;
			return <PhantomSideQuestIter>d__;
		}

		// Token: 0x0600A82F RID: 43055 RVA: 0x002B2484 File Offset: 0x002B0684
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomsIter()或GetPhantomsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Phantoms()
		{
			PhantomCollectActivity phantomCollectActivity = this;
			return phantomCollectActivity.GetPhantomsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A830 RID: 43056 RVA: 0x002B24A8 File Offset: 0x002B06A8
		[NullableContext(1)]
		public readonly IEnumerable<int> PhantomsIter()
		{
			PhantomCollectActivity.<PhantomsIter>d__41 <PhantomsIter>d__ = new PhantomCollectActivity.<PhantomsIter>d__41(-2);
			<PhantomsIter>d__.<>3__<>4__this = this;
			return <PhantomsIter>d__;
		}

		// Token: 0x0600A831 RID: 43057 RVA: 0x002B24C0 File Offset: 0x002B06C0
		[NullableContext(2)]
		public string GetPhantomActivityImage(int key)
		{
			this.EnsurePhantomActivityImageCacheIfNeeded();
			string result;
			if (!this.PhantomActivityImageCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600A832 RID: 43058 RVA: 0x002B24E8 File Offset: 0x002B06E8
		[NullableContext(2)]
		public string GetPhantomDesc(int key)
		{
			this.EnsurePhantomDescCacheIfNeeded();
			string result;
			if (!this.PhantomDescCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600A833 RID: 43059 RVA: 0x002B2510 File Offset: 0x002B0710
		private void EnsurePhantomActivityImageCacheIfNeeded()
		{
			if (this.PhantomActivityImageCache != null)
			{
				return;
			}
			this.PhantomActivityImageCache = this.PhantomActivityImageIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600A834 RID: 43060 RVA: 0x002B2578 File Offset: 0x002B0778
		private void EnsurePhantomDescCacheIfNeeded()
		{
			if (this.PhantomDescCache != null)
			{
				return;
			}
			this.PhantomDescCache = this.PhantomDescIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600A835 RID: 43061 RVA: 0x002B25DE File Offset: 0x002B07DE
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetPhantomActivityImageFrozenDict(int key)
		{
			this.EnsurePhantomActivityImageCacheIfNeeded();
			return this.PhantomActivityImageCache;
		}

		// Token: 0x0600A836 RID: 43062 RVA: 0x002B25EC File Offset: 0x002B07EC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetPhantomDescFrozenDict(int key)
		{
			this.EnsurePhantomDescCacheIfNeeded();
			return this.PhantomDescCache;
		}

		// Token: 0x04004F9E RID: 20382
		private Table __p;

		// Token: 0x04004F9F RID: 20383
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> PhantomActivityImageCache;

		// Token: 0x04004FA0 RID: 20384
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> PhantomDescCache;
	}
}
