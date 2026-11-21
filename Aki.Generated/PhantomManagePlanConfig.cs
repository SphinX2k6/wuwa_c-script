using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD6 RID: 4054
	public struct PhantomManagePlanConfig : IFlatbufferObject
	{
		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x0600AFB9 RID: 44985 RVA: 0x002D2535 File Offset: 0x002D0735
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AFBA RID: 44986 RVA: 0x002D2542 File Offset: 0x002D0742
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AFBB RID: 44987 RVA: 0x002D254C File Offset: 0x002D074C
		public static PhantomManagePlanConfig GetRootAsPhantomManagePlanConfig(ByteBuffer _bb)
		{
			return PhantomManagePlanConfig.GetRootAsPhantomManagePlanConfig(_bb, default(PhantomManagePlanConfig));
		}

		// Token: 0x0600AFBC RID: 44988 RVA: 0x002D2568 File Offset: 0x002D0768
		public static PhantomManagePlanConfig GetRootAsPhantomManagePlanConfig(ByteBuffer _bb, PhantomManagePlanConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AFBD RID: 44989 RVA: 0x002D2585 File Offset: 0x002D0785
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AFBE RID: 44990 RVA: 0x002D2594 File Offset: 0x002D0794
		public PhantomManagePlanConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x0600AFBF RID: 44991 RVA: 0x002D25A4 File Offset: 0x002D07A4
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

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x0600AFC0 RID: 44992 RVA: 0x002D25E0 File Offset: 0x002D07E0
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

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x0600AFC1 RID: 44993 RVA: 0x002D261C File Offset: 0x002D081C
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

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x0600AFC2 RID: 44994 RVA: 0x002D2658 File Offset: 0x002D0858
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x0600AFC3 RID: 44995 RVA: 0x002D2698 File Offset: 0x002D0898
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

		// Token: 0x0600AFC4 RID: 44996 RVA: 0x002D26D0 File Offset: 0x002D08D0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AFC5 RID: 44997 RVA: 0x002D26E0 File Offset: 0x002D08E0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AFC6 RID: 44998 RVA: 0x002D26F8 File Offset: 0x002D08F8
		public DicIntIntArray? RuleMap(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x0600AFC7 RID: 44999 RVA: 0x002D275C File Offset: 0x002D095C
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

		// Token: 0x0600AFC8 RID: 45000 RVA: 0x002D2788 File Offset: 0x002D0988
		[NullableContext(1)]
		public Dictionary<int, IntArray> RuleMap()
		{
			return this.RuleMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600AFC9 RID: 45001 RVA: 0x002D27DE File Offset: 0x002D09DE
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> RuleMapIter()
		{
			PhantomManagePlanConfig.<RuleMapIter>d__24 <RuleMapIter>d__ = new PhantomManagePlanConfig.<RuleMapIter>d__24(-2);
			<RuleMapIter>d__.<>3__<>4__this = this;
			return <RuleMapIter>d__;
		}

		// Token: 0x0600AFCA RID: 45002 RVA: 0x002D27F4 File Offset: 0x002D09F4
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

		// Token: 0x0600AFCB RID: 45003 RVA: 0x002D2828 File Offset: 0x002D0A28
		private void EnsureRuleMapCacheIfNeeded()
		{
			if (this.RuleMapCache != null)
			{
				return;
			}
			this.RuleMapCache = this.RuleMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600AFCC RID: 45004 RVA: 0x002D288E File Offset: 0x002D0A8E
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetRuleMapFrozenDict()
		{
			this.EnsureRuleMapCacheIfNeeded();
			return this.RuleMapCache;
		}

		// Token: 0x04005598 RID: 21912
		private Table __p;

		// Token: 0x04005599 RID: 21913
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> RuleMapCache;
	}
}
