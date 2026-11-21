using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E7B RID: 3707
	public struct KurotatoBuild : IFlatbufferObject
	{
		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x06008EC0 RID: 36544 RVA: 0x0028AA1E File Offset: 0x00288C1E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008EC1 RID: 36545 RVA: 0x0028AA2B File Offset: 0x00288C2B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008EC2 RID: 36546 RVA: 0x0028AA34 File Offset: 0x00288C34
		public static KurotatoBuild GetRootAsKurotatoBuild(ByteBuffer _bb)
		{
			return KurotatoBuild.GetRootAsKurotatoBuild(_bb, default(KurotatoBuild));
		}

		// Token: 0x06008EC3 RID: 36547 RVA: 0x0028AA50 File Offset: 0x00288C50
		public static KurotatoBuild GetRootAsKurotatoBuild(ByteBuffer _bb, KurotatoBuild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008EC4 RID: 36548 RVA: 0x0028AA6D File Offset: 0x00288C6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008EC5 RID: 36549 RVA: 0x0028AA7C File Offset: 0x00288C7C
		public KurotatoBuild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x06008EC6 RID: 36550 RVA: 0x0028AA8C File Offset: 0x00288C8C
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

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06008EC7 RID: 36551 RVA: 0x0028AAC8 File Offset: 0x00288CC8
		public string Name
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

		// Token: 0x06008EC8 RID: 36552 RVA: 0x0028AAFF File Offset: 0x00288CFF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008EC9 RID: 36553 RVA: 0x0028AB0E File Offset: 0x00288D0E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06008ECA RID: 36554 RVA: 0x0028AB28 File Offset: 0x00288D28
		public string Desc
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

		// Token: 0x06008ECB RID: 36555 RVA: 0x0028AB5F File Offset: 0x00288D5F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x0028AB6E File Offset: 0x00288D6E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06008ECD RID: 36557 RVA: 0x0028AB88 File Offset: 0x00288D88
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

		// Token: 0x06008ECE RID: 36558 RVA: 0x0028ABC0 File Offset: 0x00288DC0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008ECF RID: 36559 RVA: 0x0028ABD0 File Offset: 0x00288DD0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06008ED0 RID: 36560 RVA: 0x0028ABE8 File Offset: 0x00288DE8
		public DicIntInt? WeightMultiply(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06008ED1 RID: 36561 RVA: 0x0028AC4C File Offset: 0x00288E4C
		public int WeightMultiplyLength
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

		// Token: 0x06008ED2 RID: 36562 RVA: 0x0028AC78 File Offset: 0x00288E78
		[NullableContext(1)]
		public Dictionary<int, int> WeightMultiply()
		{
			return this.WeightMultiplyIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008ED3 RID: 36563 RVA: 0x0028ACCE File Offset: 0x00288ECE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> WeightMultiplyIter()
		{
			KurotatoBuild.<WeightMultiplyIter>d__26 <WeightMultiplyIter>d__ = new KurotatoBuild.<WeightMultiplyIter>d__26(-2);
			<WeightMultiplyIter>d__.<>3__<>4__this = this;
			return <WeightMultiplyIter>d__;
		}

		// Token: 0x06008ED4 RID: 36564 RVA: 0x0028ACE4 File Offset: 0x00288EE4
		public int? GetWeightMultiply(int key)
		{
			this.EnsureWeightMultiplyCacheIfNeeded();
			int value;
			if (!this.WeightMultiplyCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008ED5 RID: 36565 RVA: 0x0028AD18 File Offset: 0x00288F18
		private void EnsureWeightMultiplyCacheIfNeeded()
		{
			if (this.WeightMultiplyCache != null)
			{
				return;
			}
			this.WeightMultiplyCache = this.WeightMultiplyIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008ED6 RID: 36566 RVA: 0x0028AD7E File Offset: 0x00288F7E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetWeightMultiplyFrozenDict()
		{
			this.EnsureWeightMultiplyCacheIfNeeded();
			return this.WeightMultiplyCache;
		}

		// Token: 0x0400540A RID: 21514
		private Table __p;

		// Token: 0x0400540B RID: 21515
		[Nullable(2)]
		private FrozenDictionary<int, int> WeightMultiplyCache;
	}
}
