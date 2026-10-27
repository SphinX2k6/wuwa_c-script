using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C0C RID: 3084
	public struct DropCatchDropPool : IFlatbufferObject
	{
		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06006550 RID: 25936 RVA: 0x0021AB75 File Offset: 0x00218D75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006551 RID: 25937 RVA: 0x0021AB82 File Offset: 0x00218D82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x0021AB8C File Offset: 0x00218D8C
		public static DropCatchDropPool GetRootAsDropCatchDropPool(ByteBuffer _bb)
		{
			return DropCatchDropPool.GetRootAsDropCatchDropPool(_bb, default(DropCatchDropPool));
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x0021ABA8 File Offset: 0x00218DA8
		public static DropCatchDropPool GetRootAsDropCatchDropPool(ByteBuffer _bb, DropCatchDropPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x0021ABC5 File Offset: 0x00218DC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x0021ABD4 File Offset: 0x00218DD4
		public DropCatchDropPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06006556 RID: 25942 RVA: 0x0021ABE4 File Offset: 0x00218DE4
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

		// Token: 0x06006557 RID: 25943 RVA: 0x0021AC20 File Offset: 0x00218E20
		public DicIntInt? DropItemList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06006558 RID: 25944 RVA: 0x0021AC80 File Offset: 0x00218E80
		public int DropItemListLength
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

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06006559 RID: 25945 RVA: 0x0021ACAC File Offset: 0x00218EAC
		public float DropInitPosX
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 9999f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x0600655A RID: 25946 RVA: 0x0021ACEC File Offset: 0x00218EEC
		public float DropTimeInterval
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x0600655B RID: 25947 RVA: 0x0021AD30 File Offset: 0x00218F30
		public float DropPosInterval
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x0021AD74 File Offset: 0x00218F74
		public float TimeRange(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x0600655D RID: 25949 RVA: 0x0021ADB8 File Offset: 0x00218FB8
		public int TimeRangeLength
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

		// Token: 0x0600655E RID: 25950 RVA: 0x0021ADE4 File Offset: 0x00218FE4
		public Span<float> GetTimeRangeBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x0021ADF4 File Offset: 0x00218FF4
		public float[] GetTimeRangeArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x0021AE0C File Offset: 0x0021900C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DropItemListFrozenDict()缓存字典，遍历请使用DropItemListIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DropItemList()
		{
			return this.DropItemListIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006561 RID: 25953 RVA: 0x0021AE62 File Offset: 0x00219062
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DropItemListIter()
		{
			DropCatchDropPool.<DropItemListIter>d__25 <DropItemListIter>d__ = new DropCatchDropPool.<DropItemListIter>d__25(-2);
			<DropItemListIter>d__.<>3__<>4__this = this;
			return <DropItemListIter>d__;
		}

		// Token: 0x06006562 RID: 25954 RVA: 0x0021AE78 File Offset: 0x00219078
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TimeRangeIter()或GetTimeRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] TimeRange()
		{
			DropCatchDropPool dropCatchDropPool = this;
			return dropCatchDropPool.GetTimeRangeArray() ?? Array.Empty<float>();
		}

		// Token: 0x06006563 RID: 25955 RVA: 0x0021AE9C File Offset: 0x0021909C
		[NullableContext(1)]
		public readonly IEnumerable<float> TimeRangeIter()
		{
			DropCatchDropPool.<TimeRangeIter>d__27 <TimeRangeIter>d__ = new DropCatchDropPool.<TimeRangeIter>d__27(-2);
			<TimeRangeIter>d__.<>3__<>4__this = this;
			return <TimeRangeIter>d__;
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x0021AEB4 File Offset: 0x002190B4
		public int? GetDropItemList(int key)
		{
			this.EnsureDropItemListCacheIfNeeded();
			int value;
			if (!this.DropItemListCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x0021AEE8 File Offset: 0x002190E8
		private void EnsureDropItemListCacheIfNeeded()
		{
			if (this.DropItemListCache != null)
			{
				return;
			}
			this.DropItemListCache = this.DropItemListIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x0021AF4E File Offset: 0x0021914E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDropItemListFrozenDict(int key)
		{
			this.EnsureDropItemListCacheIfNeeded();
			return this.DropItemListCache;
		}

		// Token: 0x04004C48 RID: 19528
		private Table __p;

		// Token: 0x04004C49 RID: 19529
		[Nullable(2)]
		private FrozenDictionary<int, int> DropItemListCache;
	}
}
