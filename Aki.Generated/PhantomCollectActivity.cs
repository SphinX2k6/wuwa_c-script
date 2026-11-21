using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC5 RID: 4037
	public struct PhantomCollectActivity : IFlatbufferObject
	{
		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x0600AE33 RID: 44595 RVA: 0x002CF025 File Offset: 0x002CD225
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE34 RID: 44596 RVA: 0x002CF032 File Offset: 0x002CD232
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE35 RID: 44597 RVA: 0x002CF03C File Offset: 0x002CD23C
		public static PhantomCollectActivity GetRootAsPhantomCollectActivity(ByteBuffer _bb)
		{
			return PhantomCollectActivity.GetRootAsPhantomCollectActivity(_bb, default(PhantomCollectActivity));
		}

		// Token: 0x0600AE36 RID: 44598 RVA: 0x002CF058 File Offset: 0x002CD258
		public static PhantomCollectActivity GetRootAsPhantomCollectActivity(ByteBuffer _bb, PhantomCollectActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE37 RID: 44599 RVA: 0x002CF075 File Offset: 0x002CD275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE38 RID: 44600 RVA: 0x002CF084 File Offset: 0x002CD284
		public PhantomCollectActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x0600AE39 RID: 44601 RVA: 0x002CF094 File Offset: 0x002CD294
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

		// Token: 0x0600AE3A RID: 44602 RVA: 0x002CF0D0 File Offset: 0x002CD2D0
		public int Phantoms(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x0600AE3B RID: 44603 RVA: 0x002CF110 File Offset: 0x002CD310
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

		// Token: 0x0600AE3C RID: 44604 RVA: 0x002CF13B File Offset: 0x002CD33B
		public Span<int> GetPhantomsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600AE3D RID: 44605 RVA: 0x002CF14A File Offset: 0x002CD34A
		public int[] GetPhantomsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x0600AE3E RID: 44606 RVA: 0x002CF164 File Offset: 0x002CD364
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

		// Token: 0x0600AE3F RID: 44607 RVA: 0x002CF1A0 File Offset: 0x002CD3A0
		public DicIntString? PhantomDesc(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x0600AE40 RID: 44608 RVA: 0x002CF204 File Offset: 0x002CD404
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

		// Token: 0x0600AE41 RID: 44609 RVA: 0x002CF230 File Offset: 0x002CD430
		public DicIntString? PhantomActivityImage(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x0600AE42 RID: 44610 RVA: 0x002CF294 File Offset: 0x002CD494
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

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x0600AE43 RID: 44611 RVA: 0x002CF2C0 File Offset: 0x002CD4C0
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

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x0600AE44 RID: 44612 RVA: 0x002CF300 File Offset: 0x002CD500
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

		// Token: 0x0600AE45 RID: 44613 RVA: 0x002CF340 File Offset: 0x002CD540
		public int PhantomSideQuest(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x0600AE46 RID: 44614 RVA: 0x002CF380 File Offset: 0x002CD580
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

		// Token: 0x0600AE47 RID: 44615 RVA: 0x002CF3AC File Offset: 0x002CD5AC
		public Span<int> GetPhantomSideQuestBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600AE48 RID: 44616 RVA: 0x002CF3BC File Offset: 0x002CD5BC
		public int[] GetPhantomSideQuestArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x0600AE49 RID: 44617 RVA: 0x002CF3D4 File Offset: 0x002CD5D4
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

		// Token: 0x0600AE4A RID: 44618 RVA: 0x002CF414 File Offset: 0x002CD614
		[NullableContext(1)]
		public Dictionary<int, string> PhantomActivityImage()
		{
			return this.PhantomActivityImageIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600AE4B RID: 44619 RVA: 0x002CF46A File Offset: 0x002CD66A
		[NullableContext(1)]
		public IEnumerable<DicIntString> PhantomActivityImageIter()
		{
			PhantomCollectActivity.<PhantomActivityImageIter>d__35 <PhantomActivityImageIter>d__ = new PhantomCollectActivity.<PhantomActivityImageIter>d__35(-2);
			<PhantomActivityImageIter>d__.<>3__<>4__this = this;
			return <PhantomActivityImageIter>d__;
		}

		// Token: 0x0600AE4C RID: 44620 RVA: 0x002CF480 File Offset: 0x002CD680
		[NullableContext(1)]
		public Dictionary<int, string> PhantomDesc()
		{
			return this.PhantomDescIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600AE4D RID: 44621 RVA: 0x002CF4D6 File Offset: 0x002CD6D6
		[NullableContext(1)]
		public IEnumerable<DicIntString> PhantomDescIter()
		{
			PhantomCollectActivity.<PhantomDescIter>d__37 <PhantomDescIter>d__ = new PhantomCollectActivity.<PhantomDescIter>d__37(-2);
			<PhantomDescIter>d__.<>3__<>4__this = this;
			return <PhantomDescIter>d__;
		}

		// Token: 0x0600AE4E RID: 44622 RVA: 0x002CF4EB File Offset: 0x002CD6EB
		[NullableContext(1)]
		public int[] PhantomSideQuest()
		{
			return this.GetPhantomSideQuestArray();
		}

		// Token: 0x0600AE4F RID: 44623 RVA: 0x002CF4F3 File Offset: 0x002CD6F3
		[NullableContext(1)]
		public IEnumerable<int> PhantomSideQuestIter()
		{
			PhantomCollectActivity.<PhantomSideQuestIter>d__39 <PhantomSideQuestIter>d__ = new PhantomCollectActivity.<PhantomSideQuestIter>d__39(-2);
			<PhantomSideQuestIter>d__.<>3__<>4__this = this;
			return <PhantomSideQuestIter>d__;
		}

		// Token: 0x0600AE50 RID: 44624 RVA: 0x002CF508 File Offset: 0x002CD708
		[NullableContext(1)]
		public int[] Phantoms()
		{
			return this.GetPhantomsArray();
		}

		// Token: 0x0600AE51 RID: 44625 RVA: 0x002CF510 File Offset: 0x002CD710
		[NullableContext(1)]
		public IEnumerable<int> PhantomsIter()
		{
			PhantomCollectActivity.<PhantomsIter>d__41 <PhantomsIter>d__ = new PhantomCollectActivity.<PhantomsIter>d__41(-2);
			<PhantomsIter>d__.<>3__<>4__this = this;
			return <PhantomsIter>d__;
		}

		// Token: 0x0600AE52 RID: 44626 RVA: 0x002CF528 File Offset: 0x002CD728
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

		// Token: 0x0600AE53 RID: 44627 RVA: 0x002CF550 File Offset: 0x002CD750
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

		// Token: 0x0600AE54 RID: 44628 RVA: 0x002CF578 File Offset: 0x002CD778
		private void EnsurePhantomActivityImageCacheIfNeeded()
		{
			if (this.PhantomActivityImageCache != null)
			{
				return;
			}
			this.PhantomActivityImageCache = this.PhantomActivityImageIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600AE55 RID: 44629 RVA: 0x002CF5E0 File Offset: 0x002CD7E0
		private void EnsurePhantomDescCacheIfNeeded()
		{
			if (this.PhantomDescCache != null)
			{
				return;
			}
			this.PhantomDescCache = this.PhantomDescIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600AE56 RID: 44630 RVA: 0x002CF646 File Offset: 0x002CD846
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetPhantomActivityImageFrozenDict()
		{
			this.EnsurePhantomActivityImageCacheIfNeeded();
			return this.PhantomActivityImageCache;
		}

		// Token: 0x0600AE57 RID: 44631 RVA: 0x002CF654 File Offset: 0x002CD854
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetPhantomDescFrozenDict()
		{
			this.EnsurePhantomDescCacheIfNeeded();
			return this.PhantomDescCache;
		}

		// Token: 0x04005583 RID: 21891
		private Table __p;

		// Token: 0x04005584 RID: 21892
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> PhantomActivityImageCache;

		// Token: 0x04005585 RID: 21893
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> PhantomDescCache;
	}
}
