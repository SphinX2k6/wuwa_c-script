using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D88 RID: 3464
	public struct FloroRanchCardGroup : IFlatbufferObject
	{
		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x060078DB RID: 30939 RVA: 0x00258D97 File Offset: 0x00256F97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060078DC RID: 30940 RVA: 0x00258DA4 File Offset: 0x00256FA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060078DD RID: 30941 RVA: 0x00258DAC File Offset: 0x00256FAC
		public static FloroRanchCardGroup GetRootAsFloroRanchCardGroup(ByteBuffer _bb)
		{
			return FloroRanchCardGroup.GetRootAsFloroRanchCardGroup(_bb, default(FloroRanchCardGroup));
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x00258DC8 File Offset: 0x00256FC8
		public static FloroRanchCardGroup GetRootAsFloroRanchCardGroup(ByteBuffer _bb, FloroRanchCardGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060078DF RID: 30943 RVA: 0x00258DE5 File Offset: 0x00256FE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060078E0 RID: 30944 RVA: 0x00258DF4 File Offset: 0x00256FF4
		public FloroRanchCardGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x060078E1 RID: 30945 RVA: 0x00258E04 File Offset: 0x00257004
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

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x060078E2 RID: 30946 RVA: 0x00258E40 File Offset: 0x00257040
		public int Race
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

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x060078E3 RID: 30947 RVA: 0x00258E7C File Offset: 0x0025707C
		public int RarityId
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

		// Token: 0x060078E4 RID: 30948 RVA: 0x00258EB8 File Offset: 0x002570B8
		public DicIntInt? Minimum(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x060078E5 RID: 30949 RVA: 0x00258F1C File Offset: 0x0025711C
		public int MinimumLength
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

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x060078E6 RID: 30950 RVA: 0x00258F48 File Offset: 0x00257148
		public int Price
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

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x060078E7 RID: 30951 RVA: 0x00258F88 File Offset: 0x00257188
		public string Name
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

		// Token: 0x060078E8 RID: 30952 RVA: 0x00258FC0 File Offset: 0x002571C0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x00258FD0 File Offset: 0x002571D0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x060078EA RID: 30954 RVA: 0x00258FE8 File Offset: 0x002571E8
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x00259020 File Offset: 0x00257220
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x00259030 File Offset: 0x00257230
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x060078ED RID: 30957 RVA: 0x00259048 File Offset: 0x00257248
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x00259080 File Offset: 0x00257280
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x00259090 File Offset: 0x00257290
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x002590A8 File Offset: 0x002572A8
		[NullableContext(1)]
		public Dictionary<int, int> Minimum()
		{
			return this.MinimumIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060078F1 RID: 30961 RVA: 0x002590FE File Offset: 0x002572FE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> MinimumIter()
		{
			FloroRanchCardGroup.<MinimumIter>d__32 <MinimumIter>d__ = new FloroRanchCardGroup.<MinimumIter>d__32(-2);
			<MinimumIter>d__.<>3__<>4__this = this;
			return <MinimumIter>d__;
		}

		// Token: 0x060078F2 RID: 30962 RVA: 0x00259114 File Offset: 0x00257314
		public int? GetMinimum(int key)
		{
			this.EnsureMinimumCacheIfNeeded();
			int value;
			if (!this.MinimumCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060078F3 RID: 30963 RVA: 0x00259148 File Offset: 0x00257348
		private void EnsureMinimumCacheIfNeeded()
		{
			if (this.MinimumCache != null)
			{
				return;
			}
			this.MinimumCache = this.MinimumIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x002591AE File Offset: 0x002573AE
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetMinimumFrozenDict()
		{
			this.EnsureMinimumCacheIfNeeded();
			return this.MinimumCache;
		}

		// Token: 0x040052E9 RID: 21225
		private Table __p;

		// Token: 0x040052EA RID: 21226
		[Nullable(2)]
		private FrozenDictionary<int, int> MinimumCache;
	}
}
