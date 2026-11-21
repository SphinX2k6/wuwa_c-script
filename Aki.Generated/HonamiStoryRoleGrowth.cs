using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E32 RID: 3634
	public struct HonamiStoryRoleGrowth : IFlatbufferObject
	{
		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06008741 RID: 34625 RVA: 0x00278839 File Offset: 0x00276A39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008742 RID: 34626 RVA: 0x00278846 File Offset: 0x00276A46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008743 RID: 34627 RVA: 0x00278850 File Offset: 0x00276A50
		public static HonamiStoryRoleGrowth GetRootAsHonamiStoryRoleGrowth(ByteBuffer _bb)
		{
			return HonamiStoryRoleGrowth.GetRootAsHonamiStoryRoleGrowth(_bb, default(HonamiStoryRoleGrowth));
		}

		// Token: 0x06008744 RID: 34628 RVA: 0x0027886C File Offset: 0x00276A6C
		public static HonamiStoryRoleGrowth GetRootAsHonamiStoryRoleGrowth(ByteBuffer _bb, HonamiStoryRoleGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008745 RID: 34629 RVA: 0x00278889 File Offset: 0x00276A89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008746 RID: 34630 RVA: 0x00278898 File Offset: 0x00276A98
		public HonamiStoryRoleGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06008747 RID: 34631 RVA: 0x002788A8 File Offset: 0x00276AA8
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

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x06008748 RID: 34632 RVA: 0x002788E4 File Offset: 0x00276AE4
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

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x06008749 RID: 34633 RVA: 0x00278920 File Offset: 0x00276B20
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

		// Token: 0x0600874A RID: 34634 RVA: 0x0027895C File Offset: 0x00276B5C
		public DicIntInt? AddPro(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x0600874B RID: 34635 RVA: 0x002789C0 File Offset: 0x00276BC0
		public int AddProLength
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

		// Token: 0x0600874C RID: 34636 RVA: 0x002789EC File Offset: 0x00276BEC
		[NullableContext(1)]
		public Dictionary<int, int> AddPro()
		{
			return this.AddProIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600874D RID: 34637 RVA: 0x00278A42 File Offset: 0x00276C42
		[NullableContext(1)]
		public IEnumerable<DicIntInt> AddProIter()
		{
			HonamiStoryRoleGrowth.<AddProIter>d__18 <AddProIter>d__ = new HonamiStoryRoleGrowth.<AddProIter>d__18(-2);
			<AddProIter>d__.<>3__<>4__this = this;
			return <AddProIter>d__;
		}

		// Token: 0x0600874E RID: 34638 RVA: 0x00278A58 File Offset: 0x00276C58
		public int? GetAddPro(int key)
		{
			this.EnsureAddProCacheIfNeeded();
			int value;
			if (!this.AddProCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600874F RID: 34639 RVA: 0x00278A8C File Offset: 0x00276C8C
		private void EnsureAddProCacheIfNeeded()
		{
			if (this.AddProCache != null)
			{
				return;
			}
			this.AddProCache = this.AddProIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008750 RID: 34640 RVA: 0x00278AF2 File Offset: 0x00276CF2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetAddProFrozenDict()
		{
			this.EnsureAddProCacheIfNeeded();
			return this.AddProCache;
		}

		// Token: 0x040053AE RID: 21422
		private Table __p;

		// Token: 0x040053AF RID: 21423
		[Nullable(2)]
		private FrozenDictionary<int, int> AddProCache;
	}
}
