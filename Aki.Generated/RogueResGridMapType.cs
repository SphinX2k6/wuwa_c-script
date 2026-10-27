using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200100A RID: 4106
	public struct RogueResGridMapType : IFlatbufferObject
	{
		// Token: 0x17003085 RID: 12421
		// (get) Token: 0x0600C32A RID: 49962 RVA: 0x002EE138 File Offset: 0x002EC338
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C32B RID: 49963 RVA: 0x002EE145 File Offset: 0x002EC345
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C32C RID: 49964 RVA: 0x002EE14C File Offset: 0x002EC34C
		public static RogueResGridMapType GetRootAsRogueResGridMapType(ByteBuffer _bb)
		{
			return RogueResGridMapType.GetRootAsRogueResGridMapType(_bb, default(RogueResGridMapType));
		}

		// Token: 0x0600C32D RID: 49965 RVA: 0x002EE168 File Offset: 0x002EC368
		public static RogueResGridMapType GetRootAsRogueResGridMapType(ByteBuffer _bb, RogueResGridMapType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C32E RID: 49966 RVA: 0x002EE185 File Offset: 0x002EC385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C32F RID: 49967 RVA: 0x002EE194 File Offset: 0x002EC394
		public RogueResGridMapType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x0600C330 RID: 49968 RVA: 0x002EE1A4 File Offset: 0x002EC3A4
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

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x0600C331 RID: 49969 RVA: 0x002EE1E0 File Offset: 0x002EC3E0
		public string MapType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C332 RID: 49970 RVA: 0x002EE217 File Offset: 0x002EC417
		public Span<byte> GetMapTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C333 RID: 49971 RVA: 0x002EE226 File Offset: 0x002EC426
		public byte[] GetMapTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C334 RID: 49972 RVA: 0x002EE240 File Offset: 0x002EC440
		public DicStringInt? GroundPath(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x0600C335 RID: 49973 RVA: 0x002EE2A0 File Offset: 0x002EC4A0
		public int GroundPathLength
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

		// Token: 0x0600C336 RID: 49974 RVA: 0x002EE2CC File Offset: 0x002EC4CC
		public DicStringInt? DecorationPath(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x0600C337 RID: 49975 RVA: 0x002EE330 File Offset: 0x002EC530
		public int DecorationPathLength
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

		// Token: 0x0600C338 RID: 49976 RVA: 0x002EE35C File Offset: 0x002EC55C
		public string ExtraPathList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x0600C339 RID: 49977 RVA: 0x002EE398 File Offset: 0x002EC598
		public int ExtraPathListLength
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

		// Token: 0x0600C33A RID: 49978 RVA: 0x002EE3C4 File Offset: 0x002EC5C4
		public int ExtraOffsetList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x0600C33B RID: 49979 RVA: 0x002EE404 File Offset: 0x002EC604
		public int ExtraOffsetListLength
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

		// Token: 0x0600C33C RID: 49980 RVA: 0x002EE430 File Offset: 0x002EC630
		public Span<int> GetExtraOffsetListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C33D RID: 49981 RVA: 0x002EE440 File Offset: 0x002EC640
		public int[] GetExtraOffsetListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600C33E RID: 49982 RVA: 0x002EE458 File Offset: 0x002EC658
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DecorationPathFrozenDict()缓存字典，遍历请使用DecorationPathIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, int> DecorationPath()
		{
			return this.DecorationPathIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600C33F RID: 49983 RVA: 0x002EE4AE File Offset: 0x002EC6AE
		[NullableContext(1)]
		public readonly IEnumerable<DicStringInt> DecorationPathIter()
		{
			RogueResGridMapType.<DecorationPathIter>d__29 <DecorationPathIter>d__ = new RogueResGridMapType.<DecorationPathIter>d__29(-2);
			<DecorationPathIter>d__.<>3__<>4__this = this;
			return <DecorationPathIter>d__;
		}

		// Token: 0x0600C340 RID: 49984 RVA: 0x002EE4C4 File Offset: 0x002EC6C4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExtraOffsetListIter()或GetExtraOffsetListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExtraOffsetList()
		{
			RogueResGridMapType rogueResGridMapType = this;
			return rogueResGridMapType.GetExtraOffsetListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C341 RID: 49985 RVA: 0x002EE4E8 File Offset: 0x002EC6E8
		[NullableContext(1)]
		public readonly IEnumerable<int> ExtraOffsetListIter()
		{
			RogueResGridMapType.<ExtraOffsetListIter>d__31 <ExtraOffsetListIter>d__ = new RogueResGridMapType.<ExtraOffsetListIter>d__31(-2);
			<ExtraOffsetListIter>d__.<>3__<>4__this = this;
			return <ExtraOffsetListIter>d__;
		}

		// Token: 0x0600C342 RID: 49986 RVA: 0x002EE4FD File Offset: 0x002EC6FD
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExtraPathListIter()或GetExtraPathListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExtraPathList()
		{
			return this.ExtraPathListIter().ToArray<string>();
		}

		// Token: 0x0600C343 RID: 49987 RVA: 0x002EE50A File Offset: 0x002EC70A
		[NullableContext(1)]
		public readonly IEnumerable<string> ExtraPathListIter()
		{
			RogueResGridMapType.<ExtraPathListIter>d__33 <ExtraPathListIter>d__ = new RogueResGridMapType.<ExtraPathListIter>d__33(-2);
			<ExtraPathListIter>d__.<>3__<>4__this = this;
			return <ExtraPathListIter>d__;
		}

		// Token: 0x0600C344 RID: 49988 RVA: 0x002EE520 File Offset: 0x002EC720
		[NullableContext(1)]
		[Obsolete("已废弃，请使用GroundPathFrozenDict()缓存字典，遍历请使用GroundPathIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, int> GroundPath()
		{
			return this.GroundPathIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600C345 RID: 49989 RVA: 0x002EE576 File Offset: 0x002EC776
		[NullableContext(1)]
		public readonly IEnumerable<DicStringInt> GroundPathIter()
		{
			RogueResGridMapType.<GroundPathIter>d__35 <GroundPathIter>d__ = new RogueResGridMapType.<GroundPathIter>d__35(-2);
			<GroundPathIter>d__.<>3__<>4__this = this;
			return <GroundPathIter>d__;
		}

		// Token: 0x0600C346 RID: 49990 RVA: 0x002EE58C File Offset: 0x002EC78C
		[NullableContext(1)]
		public int? GetDecorationPath(string key)
		{
			this.EnsureDecorationPathCacheIfNeeded();
			int value;
			if (!this.DecorationPathCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C347 RID: 49991 RVA: 0x002EE5C0 File Offset: 0x002EC7C0
		[NullableContext(1)]
		public int? GetGroundPath(string key)
		{
			this.EnsureGroundPathCacheIfNeeded();
			int value;
			if (!this.GroundPathCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C348 RID: 49992 RVA: 0x002EE5F4 File Offset: 0x002EC7F4
		private void EnsureDecorationPathCacheIfNeeded()
		{
			if (this.DecorationPathCache != null)
			{
				return;
			}
			this.DecorationPathCache = this.DecorationPathIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C349 RID: 49993 RVA: 0x002EE65C File Offset: 0x002EC85C
		private void EnsureGroundPathCacheIfNeeded()
		{
			if (this.GroundPathCache != null)
			{
				return;
			}
			this.GroundPathCache = this.GroundPathIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C34A RID: 49994 RVA: 0x002EE6C2 File Offset: 0x002EC8C2
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, int> GetDecorationPathFrozenDict(string key)
		{
			this.EnsureDecorationPathCacheIfNeeded();
			return this.DecorationPathCache;
		}

		// Token: 0x0600C34B RID: 49995 RVA: 0x002EE6D0 File Offset: 0x002EC8D0
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, int> GetGroundPathFrozenDict(string key)
		{
			this.EnsureGroundPathCacheIfNeeded();
			return this.GroundPathCache;
		}

		// Token: 0x040050F5 RID: 20725
		private Table __p;

		// Token: 0x040050F6 RID: 20726
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> DecorationPathCache;

		// Token: 0x040050F7 RID: 20727
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> GroundPathCache;
	}
}
