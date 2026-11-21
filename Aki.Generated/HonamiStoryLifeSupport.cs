using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E20 RID: 3616
	public struct HonamiStoryLifeSupport : IFlatbufferObject
	{
		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06008636 RID: 34358 RVA: 0x00276464 File Offset: 0x00274664
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008637 RID: 34359 RVA: 0x00276471 File Offset: 0x00274671
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008638 RID: 34360 RVA: 0x00276478 File Offset: 0x00274678
		public static HonamiStoryLifeSupport GetRootAsHonamiStoryLifeSupport(ByteBuffer _bb)
		{
			return HonamiStoryLifeSupport.GetRootAsHonamiStoryLifeSupport(_bb, default(HonamiStoryLifeSupport));
		}

		// Token: 0x06008639 RID: 34361 RVA: 0x00276494 File Offset: 0x00274694
		public static HonamiStoryLifeSupport GetRootAsHonamiStoryLifeSupport(ByteBuffer _bb, HonamiStoryLifeSupport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600863A RID: 34362 RVA: 0x002764B1 File Offset: 0x002746B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600863B RID: 34363 RVA: 0x002764C0 File Offset: 0x002746C0
		public HonamiStoryLifeSupport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x0600863C RID: 34364 RVA: 0x002764D0 File Offset: 0x002746D0
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

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x0600863D RID: 34365 RVA: 0x0027650C File Offset: 0x0027470C
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

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x0600863E RID: 34366 RVA: 0x00276548 File Offset: 0x00274748
		public int Level
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

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x0600863F RID: 34367 RVA: 0x00276584 File Offset: 0x00274784
		public string Icon
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

		// Token: 0x06008640 RID: 34368 RVA: 0x002765BC File Offset: 0x002747BC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008641 RID: 34369 RVA: 0x002765CC File Offset: 0x002747CC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06008642 RID: 34370 RVA: 0x002765E4 File Offset: 0x002747E4
		public int SteadyValue
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

		// Token: 0x06008643 RID: 34371 RVA: 0x00276624 File Offset: 0x00274824
		public DicIntInt? ConsumeItems(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06008644 RID: 34372 RVA: 0x00276688 File Offset: 0x00274888
		public int ConsumeItemsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008645 RID: 34373 RVA: 0x002766B4 File Offset: 0x002748B4
		[NullableContext(1)]
		public Dictionary<int, int> ConsumeItems()
		{
			return this.ConsumeItemsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008646 RID: 34374 RVA: 0x0027670A File Offset: 0x0027490A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeItemsIter()
		{
			HonamiStoryLifeSupport.<ConsumeItemsIter>d__24 <ConsumeItemsIter>d__ = new HonamiStoryLifeSupport.<ConsumeItemsIter>d__24(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x06008647 RID: 34375 RVA: 0x00276720 File Offset: 0x00274920
		public int? GetConsumeItems(int key)
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			int value;
			if (!this.ConsumeItemsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008648 RID: 34376 RVA: 0x00276754 File Offset: 0x00274954
		private void EnsureConsumeItemsCacheIfNeeded()
		{
			if (this.ConsumeItemsCache != null)
			{
				return;
			}
			this.ConsumeItemsCache = this.ConsumeItemsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008649 RID: 34377 RVA: 0x002767BA File Offset: 0x002749BA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeItemsFrozenDict()
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			return this.ConsumeItemsCache;
		}

		// Token: 0x0400539A RID: 21402
		private Table __p;

		// Token: 0x0400539B RID: 21403
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeItemsCache;
	}
}
