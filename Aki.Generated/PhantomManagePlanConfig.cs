using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF1 RID: 3825
	public struct PhantomManagePlanConfig : IFlatbufferObject
	{
		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x0600A998 RID: 43416 RVA: 0x002B5661 File Offset: 0x002B3861
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A999 RID: 43417 RVA: 0x002B566E File Offset: 0x002B386E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A99A RID: 43418 RVA: 0x002B5678 File Offset: 0x002B3878
		public static PhantomManagePlanConfig GetRootAsPhantomManagePlanConfig(ByteBuffer _bb)
		{
			return PhantomManagePlanConfig.GetRootAsPhantomManagePlanConfig(_bb, default(PhantomManagePlanConfig));
		}

		// Token: 0x0600A99B RID: 43419 RVA: 0x002B5694 File Offset: 0x002B3894
		public static PhantomManagePlanConfig GetRootAsPhantomManagePlanConfig(ByteBuffer _bb, PhantomManagePlanConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A99C RID: 43420 RVA: 0x002B56B1 File Offset: 0x002B38B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A99D RID: 43421 RVA: 0x002B56C0 File Offset: 0x002B38C0
		public PhantomManagePlanConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x0600A99E RID: 43422 RVA: 0x002B56D0 File Offset: 0x002B38D0
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

		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x0600A99F RID: 43423 RVA: 0x002B570C File Offset: 0x002B390C
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

		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x0600A9A0 RID: 43424 RVA: 0x002B5748 File Offset: 0x002B3948
		public int SlotIndex
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

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x0600A9A1 RID: 43425 RVA: 0x002B5784 File Offset: 0x002B3984
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x0600A9A2 RID: 43426 RVA: 0x002B57C4 File Offset: 0x002B39C4
		public string Name
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

		// Token: 0x0600A9A3 RID: 43427 RVA: 0x002B57FC File Offset: 0x002B39FC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A9A4 RID: 43428 RVA: 0x002B580C File Offset: 0x002B3A0C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A9A5 RID: 43429 RVA: 0x002B5824 File Offset: 0x002B3A24
		public DicIntIntArray? RuleMap(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x0600A9A6 RID: 43430 RVA: 0x002B5888 File Offset: 0x002B3A88
		public int RuleMapLength
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

		// Token: 0x0600A9A7 RID: 43431 RVA: 0x002B58B4 File Offset: 0x002B3AB4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RuleMapFrozenDict()缓存字典，遍历请使用RuleMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> RuleMap()
		{
			return this.RuleMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600A9A8 RID: 43432 RVA: 0x002B590A File Offset: 0x002B3B0A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> RuleMapIter()
		{
			PhantomManagePlanConfig.<RuleMapIter>d__24 <RuleMapIter>d__ = new PhantomManagePlanConfig.<RuleMapIter>d__24(-2);
			<RuleMapIter>d__.<>3__<>4__this = this;
			return <RuleMapIter>d__;
		}

		// Token: 0x0600A9A9 RID: 43433 RVA: 0x002B5920 File Offset: 0x002B3B20
		public IntArray? GetRuleMap(int key)
		{
			this.EnsureRuleMapCacheIfNeeded();
			IntArray value;
			if (!this.RuleMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600A9AA RID: 43434 RVA: 0x002B5954 File Offset: 0x002B3B54
		private void EnsureRuleMapCacheIfNeeded()
		{
			if (this.RuleMapCache != null)
			{
				return;
			}
			this.RuleMapCache = this.RuleMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600A9AB RID: 43435 RVA: 0x002B59BA File Offset: 0x002B3BBA
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetRuleMapFrozenDict(int key)
		{
			this.EnsureRuleMapCacheIfNeeded();
			return this.RuleMapCache;
		}

		// Token: 0x04004FB3 RID: 20403
		private Table __p;

		// Token: 0x04004FB4 RID: 20404
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> RuleMapCache;
	}
}
