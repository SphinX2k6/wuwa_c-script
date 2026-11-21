using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F2 RID: 4338
	public struct RogueResGridMapType : IFlatbufferObject
	{
		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x0600C974 RID: 51572 RVA: 0x0030A230 File Offset: 0x00308430
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C975 RID: 51573 RVA: 0x0030A23D File Offset: 0x0030843D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C976 RID: 51574 RVA: 0x0030A244 File Offset: 0x00308444
		public static RogueResGridMapType GetRootAsRogueResGridMapType(ByteBuffer _bb)
		{
			return RogueResGridMapType.GetRootAsRogueResGridMapType(_bb, default(RogueResGridMapType));
		}

		// Token: 0x0600C977 RID: 51575 RVA: 0x0030A260 File Offset: 0x00308460
		public static RogueResGridMapType GetRootAsRogueResGridMapType(ByteBuffer _bb, RogueResGridMapType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C978 RID: 51576 RVA: 0x0030A27D File Offset: 0x0030847D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C979 RID: 51577 RVA: 0x0030A28C File Offset: 0x0030848C
		public RogueResGridMapType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x0600C97A RID: 51578 RVA: 0x0030A29C File Offset: 0x0030849C
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

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x0600C97B RID: 51579 RVA: 0x0030A2D8 File Offset: 0x003084D8
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

		// Token: 0x0600C97C RID: 51580 RVA: 0x0030A30F File Offset: 0x0030850F
		public Span<byte> GetMapTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C97D RID: 51581 RVA: 0x0030A31E File Offset: 0x0030851E
		public byte[] GetMapTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C97E RID: 51582 RVA: 0x0030A338 File Offset: 0x00308538
		public DicStringInt? GroundPath(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x0600C97F RID: 51583 RVA: 0x0030A398 File Offset: 0x00308598
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

		// Token: 0x0600C980 RID: 51584 RVA: 0x0030A3C4 File Offset: 0x003085C4
		public DicStringInt? DecorationPath(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x0600C981 RID: 51585 RVA: 0x0030A428 File Offset: 0x00308628
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

		// Token: 0x0600C982 RID: 51586 RVA: 0x0030A454 File Offset: 0x00308654
		public string ExtraPathList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x0600C983 RID: 51587 RVA: 0x0030A490 File Offset: 0x00308690
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

		// Token: 0x0600C984 RID: 51588 RVA: 0x0030A4BC File Offset: 0x003086BC
		public int ExtraOffsetList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x0600C985 RID: 51589 RVA: 0x0030A4FC File Offset: 0x003086FC
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

		// Token: 0x0600C986 RID: 51590 RVA: 0x0030A528 File Offset: 0x00308728
		public Span<int> GetExtraOffsetListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C987 RID: 51591 RVA: 0x0030A538 File Offset: 0x00308738
		public int[] GetExtraOffsetListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600C988 RID: 51592 RVA: 0x0030A550 File Offset: 0x00308750
		[NullableContext(1)]
		public Dictionary<string, int> DecorationPath()
		{
			return this.DecorationPathIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600C989 RID: 51593 RVA: 0x0030A5A6 File Offset: 0x003087A6
		[NullableContext(1)]
		public IEnumerable<DicStringInt> DecorationPathIter()
		{
			RogueResGridMapType.<DecorationPathIter>d__29 <DecorationPathIter>d__ = new RogueResGridMapType.<DecorationPathIter>d__29(-2);
			<DecorationPathIter>d__.<>3__<>4__this = this;
			return <DecorationPathIter>d__;
		}

		// Token: 0x0600C98A RID: 51594 RVA: 0x0030A5BB File Offset: 0x003087BB
		[NullableContext(1)]
		public int[] ExtraOffsetList()
		{
			return this.GetExtraOffsetListArray();
		}

		// Token: 0x0600C98B RID: 51595 RVA: 0x0030A5C3 File Offset: 0x003087C3
		[NullableContext(1)]
		public IEnumerable<int> ExtraOffsetListIter()
		{
			RogueResGridMapType.<ExtraOffsetListIter>d__31 <ExtraOffsetListIter>d__ = new RogueResGridMapType.<ExtraOffsetListIter>d__31(-2);
			<ExtraOffsetListIter>d__.<>3__<>4__this = this;
			return <ExtraOffsetListIter>d__;
		}

		// Token: 0x0600C98C RID: 51596 RVA: 0x0030A5D8 File Offset: 0x003087D8
		[NullableContext(1)]
		public string[] ExtraPathList()
		{
			return this.ExtraPathListIter().ToArray<string>();
		}

		// Token: 0x0600C98D RID: 51597 RVA: 0x0030A5E5 File Offset: 0x003087E5
		[NullableContext(1)]
		public IEnumerable<string> ExtraPathListIter()
		{
			RogueResGridMapType.<ExtraPathListIter>d__33 <ExtraPathListIter>d__ = new RogueResGridMapType.<ExtraPathListIter>d__33(-2);
			<ExtraPathListIter>d__.<>3__<>4__this = this;
			return <ExtraPathListIter>d__;
		}

		// Token: 0x0600C98E RID: 51598 RVA: 0x0030A5FC File Offset: 0x003087FC
		[NullableContext(1)]
		public Dictionary<string, int> GroundPath()
		{
			return this.GroundPathIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600C98F RID: 51599 RVA: 0x0030A652 File Offset: 0x00308852
		[NullableContext(1)]
		public IEnumerable<DicStringInt> GroundPathIter()
		{
			RogueResGridMapType.<GroundPathIter>d__35 <GroundPathIter>d__ = new RogueResGridMapType.<GroundPathIter>d__35(-2);
			<GroundPathIter>d__.<>3__<>4__this = this;
			return <GroundPathIter>d__;
		}

		// Token: 0x0600C990 RID: 51600 RVA: 0x0030A668 File Offset: 0x00308868
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

		// Token: 0x0600C991 RID: 51601 RVA: 0x0030A69C File Offset: 0x0030889C
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

		// Token: 0x0600C992 RID: 51602 RVA: 0x0030A6D0 File Offset: 0x003088D0
		private void EnsureDecorationPathCacheIfNeeded()
		{
			if (this.DecorationPathCache != null)
			{
				return;
			}
			this.DecorationPathCache = this.DecorationPathIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C993 RID: 51603 RVA: 0x0030A738 File Offset: 0x00308938
		private void EnsureGroundPathCacheIfNeeded()
		{
			if (this.GroundPathCache != null)
			{
				return;
			}
			this.GroundPathCache = this.GroundPathIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C994 RID: 51604 RVA: 0x0030A79E File Offset: 0x0030899E
		[NullableContext(1)]
		public FrozenDictionary<string, int> GetDecorationPathFrozenDict()
		{
			this.EnsureDecorationPathCacheIfNeeded();
			return this.DecorationPathCache;
		}

		// Token: 0x0600C995 RID: 51605 RVA: 0x0030A7AC File Offset: 0x003089AC
		[NullableContext(1)]
		public FrozenDictionary<string, int> GetGroundPathFrozenDict()
		{
			this.EnsureGroundPathCacheIfNeeded();
			return this.GroundPathCache;
		}

		// Token: 0x040056DD RID: 22237
		private Table __p;

		// Token: 0x040056DE RID: 22238
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> DecorationPathCache;

		// Token: 0x040056DF RID: 22239
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> GroundPathCache;
	}
}
