using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FDA RID: 4058
	public struct PhantomQuality : IFlatbufferObject
	{
		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x0600B00A RID: 45066 RVA: 0x002D3185 File Offset: 0x002D1385
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B00B RID: 45067 RVA: 0x002D3192 File Offset: 0x002D1392
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B00C RID: 45068 RVA: 0x002D319C File Offset: 0x002D139C
		public static PhantomQuality GetRootAsPhantomQuality(ByteBuffer _bb)
		{
			return PhantomQuality.GetRootAsPhantomQuality(_bb, default(PhantomQuality));
		}

		// Token: 0x0600B00D RID: 45069 RVA: 0x002D31B8 File Offset: 0x002D13B8
		public static PhantomQuality GetRootAsPhantomQuality(ByteBuffer _bb, PhantomQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B00E RID: 45070 RVA: 0x002D31D5 File Offset: 0x002D13D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B00F RID: 45071 RVA: 0x002D31E4 File Offset: 0x002D13E4
		public PhantomQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x0600B010 RID: 45072 RVA: 0x002D31F4 File Offset: 0x002D13F4
		public int Quality
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

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x0600B011 RID: 45073 RVA: 0x002D3230 File Offset: 0x002D1430
		public int LevelLimit
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

		// Token: 0x0600B012 RID: 45074 RVA: 0x002D326C File Offset: 0x002D146C
		public int SlotUnlockLevel(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x0600B013 RID: 45075 RVA: 0x002D32AC File Offset: 0x002D14AC
		public int SlotUnlockLevelLength
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

		// Token: 0x0600B014 RID: 45076 RVA: 0x002D32D7 File Offset: 0x002D14D7
		public Span<int> GetSlotUnlockLevelBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600B015 RID: 45077 RVA: 0x002D32E6 File Offset: 0x002D14E6
		public int[] GetSlotUnlockLevelArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600B016 RID: 45078 RVA: 0x002D3300 File Offset: 0x002D1500
		public DicIntInt? IdentifyCost(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x0600B017 RID: 45079 RVA: 0x002D3364 File Offset: 0x002D1564
		public int IdentifyCostLength
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

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x0600B018 RID: 45080 RVA: 0x002D3390 File Offset: 0x002D1590
		public int IdentifyCoin
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

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x0600B019 RID: 45081 RVA: 0x002D33D0 File Offset: 0x002D15D0
		public string QualitySprite
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B01A RID: 45082 RVA: 0x002D3408 File Offset: 0x002D1608
		public Span<byte> GetQualitySpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B01B RID: 45083 RVA: 0x002D3418 File Offset: 0x002D1618
		public byte[] GetQualitySpriteArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B01C RID: 45084 RVA: 0x002D3430 File Offset: 0x002D1630
		[NullableContext(1)]
		public Dictionary<int, int> IdentifyCost()
		{
			return this.IdentifyCostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600B01D RID: 45085 RVA: 0x002D3486 File Offset: 0x002D1686
		[NullableContext(1)]
		public IEnumerable<DicIntInt> IdentifyCostIter()
		{
			PhantomQuality.<IdentifyCostIter>d__27 <IdentifyCostIter>d__ = new PhantomQuality.<IdentifyCostIter>d__27(-2);
			<IdentifyCostIter>d__.<>3__<>4__this = this;
			return <IdentifyCostIter>d__;
		}

		// Token: 0x0600B01E RID: 45086 RVA: 0x002D349B File Offset: 0x002D169B
		[NullableContext(1)]
		public int[] SlotUnlockLevel()
		{
			return this.GetSlotUnlockLevelArray();
		}

		// Token: 0x0600B01F RID: 45087 RVA: 0x002D34A3 File Offset: 0x002D16A3
		[NullableContext(1)]
		public IEnumerable<int> SlotUnlockLevelIter()
		{
			PhantomQuality.<SlotUnlockLevelIter>d__29 <SlotUnlockLevelIter>d__ = new PhantomQuality.<SlotUnlockLevelIter>d__29(-2);
			<SlotUnlockLevelIter>d__.<>3__<>4__this = this;
			return <SlotUnlockLevelIter>d__;
		}

		// Token: 0x0600B020 RID: 45088 RVA: 0x002D34B8 File Offset: 0x002D16B8
		public int? GetIdentifyCost(int key)
		{
			this.EnsureIdentifyCostCacheIfNeeded();
			int value;
			if (!this.IdentifyCostCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600B021 RID: 45089 RVA: 0x002D34EC File Offset: 0x002D16EC
		private void EnsureIdentifyCostCacheIfNeeded()
		{
			if (this.IdentifyCostCache != null)
			{
				return;
			}
			this.IdentifyCostCache = this.IdentifyCostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B022 RID: 45090 RVA: 0x002D3552 File Offset: 0x002D1752
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetIdentifyCostFrozenDict()
		{
			this.EnsureIdentifyCostCacheIfNeeded();
			return this.IdentifyCostCache;
		}

		// Token: 0x0400559F RID: 21919
		private Table __p;

		// Token: 0x040055A0 RID: 21920
		[Nullable(2)]
		private FrozenDictionary<int, int> IdentifyCostCache;
	}
}
