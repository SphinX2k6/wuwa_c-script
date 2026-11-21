using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E73 RID: 3699
	public struct KingShipBuff : IFlatbufferObject
	{
		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x06008DD9 RID: 36313 RVA: 0x002872C8 File Offset: 0x002854C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008DDA RID: 36314 RVA: 0x002872D5 File Offset: 0x002854D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008DDB RID: 36315 RVA: 0x002872DC File Offset: 0x002854DC
		public static KingShipBuff GetRootAsKingShipBuff(ByteBuffer _bb)
		{
			return KingShipBuff.GetRootAsKingShipBuff(_bb, default(KingShipBuff));
		}

		// Token: 0x06008DDC RID: 36316 RVA: 0x002872F8 File Offset: 0x002854F8
		public static KingShipBuff GetRootAsKingShipBuff(ByteBuffer _bb, KingShipBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008DDD RID: 36317 RVA: 0x00287315 File Offset: 0x00285515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008DDE RID: 36318 RVA: 0x00287324 File Offset: 0x00285524
		public KingShipBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x06008DDF RID: 36319 RVA: 0x00287334 File Offset: 0x00285534
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

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x06008DE0 RID: 36320 RVA: 0x00287370 File Offset: 0x00285570
		public string Icon
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

		// Token: 0x06008DE1 RID: 36321 RVA: 0x002873A7 File Offset: 0x002855A7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008DE2 RID: 36322 RVA: 0x002873B6 File Offset: 0x002855B6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x06008DE3 RID: 36323 RVA: 0x002873D0 File Offset: 0x002855D0
		public string NameText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008DE4 RID: 36324 RVA: 0x00287407 File Offset: 0x00285607
		public Span<byte> GetNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008DE5 RID: 36325 RVA: 0x00287416 File Offset: 0x00285616
		public byte[] GetNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x06008DE6 RID: 36326 RVA: 0x00287430 File Offset: 0x00285630
		public string DesText
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

		// Token: 0x06008DE7 RID: 36327 RVA: 0x00287468 File Offset: 0x00285668
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008DE8 RID: 36328 RVA: 0x00287478 File Offset: 0x00285678
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x06008DE9 RID: 36329 RVA: 0x00287490 File Offset: 0x00285690
		public int Type
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

		// Token: 0x06008DEA RID: 36330 RVA: 0x002874D0 File Offset: 0x002856D0
		public int Param(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x06008DEB RID: 36331 RVA: 0x00287510 File Offset: 0x00285710
		public int ParamLength
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

		// Token: 0x06008DEC RID: 36332 RVA: 0x0028753C File Offset: 0x0028573C
		public Span<int> GetParamBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06008DED RID: 36333 RVA: 0x0028754C File Offset: 0x0028574C
		public int[] GetParamArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06008DEE RID: 36334 RVA: 0x00287564 File Offset: 0x00285764
		public DicIntInt? ParamMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x06008DEF RID: 36335 RVA: 0x002875C8 File Offset: 0x002857C8
		public int ParamMapLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x06008DF0 RID: 36336 RVA: 0x002875F4 File Offset: 0x002857F4
		public int Rrounds
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x00287631 File Offset: 0x00285831
		[NullableContext(1)]
		public int[] Param()
		{
			return this.GetParamArray();
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x00287639 File Offset: 0x00285839
		[NullableContext(1)]
		public IEnumerable<int> ParamIter()
		{
			KingShipBuff.<ParamIter>d__35 <ParamIter>d__ = new KingShipBuff.<ParamIter>d__35(-2);
			<ParamIter>d__.<>3__<>4__this = this;
			return <ParamIter>d__;
		}

		// Token: 0x06008DF3 RID: 36339 RVA: 0x00287650 File Offset: 0x00285850
		[NullableContext(1)]
		public Dictionary<int, int> ParamMap()
		{
			return this.ParamMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008DF4 RID: 36340 RVA: 0x002876A6 File Offset: 0x002858A6
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ParamMapIter()
		{
			KingShipBuff.<ParamMapIter>d__37 <ParamMapIter>d__ = new KingShipBuff.<ParamMapIter>d__37(-2);
			<ParamMapIter>d__.<>3__<>4__this = this;
			return <ParamMapIter>d__;
		}

		// Token: 0x06008DF5 RID: 36341 RVA: 0x002876BC File Offset: 0x002858BC
		public int? GetParamMap(int key)
		{
			this.EnsureParamMapCacheIfNeeded();
			int value;
			if (!this.ParamMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008DF6 RID: 36342 RVA: 0x002876F0 File Offset: 0x002858F0
		private void EnsureParamMapCacheIfNeeded()
		{
			if (this.ParamMapCache != null)
			{
				return;
			}
			this.ParamMapCache = this.ParamMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008DF7 RID: 36343 RVA: 0x00287756 File Offset: 0x00285956
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetParamMapFrozenDict()
		{
			this.EnsureParamMapCacheIfNeeded();
			return this.ParamMapCache;
		}

		// Token: 0x040053FF RID: 21503
		private Table __p;

		// Token: 0x04005400 RID: 21504
		[Nullable(2)]
		private FrozenDictionary<int, int> ParamMapCache;
	}
}
