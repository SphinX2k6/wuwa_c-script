using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE7 RID: 3303
	public struct DrinksOrnament : IFlatbufferObject
	{
		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06006A00 RID: 27136 RVA: 0x002371ED File Offset: 0x002353ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x002371FA File Offset: 0x002353FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x00237204 File Offset: 0x00235404
		public static DrinksOrnament GetRootAsDrinksOrnament(ByteBuffer _bb)
		{
			return DrinksOrnament.GetRootAsDrinksOrnament(_bb, default(DrinksOrnament));
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x00237220 File Offset: 0x00235420
		public static DrinksOrnament GetRootAsDrinksOrnament(ByteBuffer _bb, DrinksOrnament obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x0023723D File Offset: 0x0023543D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x0023724C File Offset: 0x0023544C
		public DrinksOrnament __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06006A06 RID: 27142 RVA: 0x0023725C File Offset: 0x0023545C
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

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06006A07 RID: 27143 RVA: 0x00237298 File Offset: 0x00235498
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

		// Token: 0x06006A08 RID: 27144 RVA: 0x002372CF File Offset: 0x002354CF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x002372DE File Offset: 0x002354DE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06006A0A RID: 27146 RVA: 0x002372F8 File Offset: 0x002354F8
		public string Icon
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

		// Token: 0x06006A0B RID: 27147 RVA: 0x0023732F File Offset: 0x0023552F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006A0C RID: 27148 RVA: 0x0023733E File Offset: 0x0023553E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06006A0D RID: 27149 RVA: 0x00237358 File Offset: 0x00235558
		public string Mesh
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

		// Token: 0x06006A0E RID: 27150 RVA: 0x00237390 File Offset: 0x00235590
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x002373A0 File Offset: 0x002355A0
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x002373B8 File Offset: 0x002355B8
		public DicIntInt? Scale(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06006A11 RID: 27153 RVA: 0x0023741C File Offset: 0x0023561C
		public int ScaleLength
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

		// Token: 0x06006A12 RID: 27154 RVA: 0x00237448 File Offset: 0x00235648
		public DicIntIntArray? Location(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06006A13 RID: 27155 RVA: 0x002374AC File Offset: 0x002356AC
		public int LocationLength
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

		// Token: 0x06006A14 RID: 27156 RVA: 0x002374D8 File Offset: 0x002356D8
		public DicIntIntArray? Rotation(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06006A15 RID: 27157 RVA: 0x0023753C File Offset: 0x0023573C
		public int RotationLength
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

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06006A16 RID: 27158 RVA: 0x00237568 File Offset: 0x00235768
		public int MeshTagId
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

		// Token: 0x06006A17 RID: 27159 RVA: 0x002375A8 File Offset: 0x002357A8
		[NullableContext(1)]
		public Dictionary<int, IntArray> Location()
		{
			return this.LocationIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x002375FE File Offset: 0x002357FE
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> LocationIter()
		{
			DrinksOrnament.<LocationIter>d__34 <LocationIter>d__ = new DrinksOrnament.<LocationIter>d__34(-2);
			<LocationIter>d__.<>3__<>4__this = this;
			return <LocationIter>d__;
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x00237614 File Offset: 0x00235814
		[NullableContext(1)]
		public Dictionary<int, IntArray> Rotation()
		{
			return this.RotationIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x0023766A File Offset: 0x0023586A
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> RotationIter()
		{
			DrinksOrnament.<RotationIter>d__36 <RotationIter>d__ = new DrinksOrnament.<RotationIter>d__36(-2);
			<RotationIter>d__.<>3__<>4__this = this;
			return <RotationIter>d__;
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x00237680 File Offset: 0x00235880
		[NullableContext(1)]
		public Dictionary<int, int> Scale()
		{
			return this.ScaleIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x002376D6 File Offset: 0x002358D6
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ScaleIter()
		{
			DrinksOrnament.<ScaleIter>d__38 <ScaleIter>d__ = new DrinksOrnament.<ScaleIter>d__38(-2);
			<ScaleIter>d__.<>3__<>4__this = this;
			return <ScaleIter>d__;
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x002376EC File Offset: 0x002358EC
		public IntArray? GetLocation(int key)
		{
			this.EnsureLocationCacheIfNeeded();
			IntArray value;
			if (!this.LocationCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x00237720 File Offset: 0x00235920
		public IntArray? GetRotation(int key)
		{
			this.EnsureRotationCacheIfNeeded();
			IntArray value;
			if (!this.RotationCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x06006A1F RID: 27167 RVA: 0x00237754 File Offset: 0x00235954
		public int? GetScale(int key)
		{
			this.EnsureScaleCacheIfNeeded();
			int value;
			if (!this.ScaleCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x00237788 File Offset: 0x00235988
		private void EnsureLocationCacheIfNeeded()
		{
			if (this.LocationCache != null)
			{
				return;
			}
			this.LocationCache = this.LocationIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x002377F0 File Offset: 0x002359F0
		private void EnsureRotationCacheIfNeeded()
		{
			if (this.RotationCache != null)
			{
				return;
			}
			this.RotationCache = this.RotationIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x00237858 File Offset: 0x00235A58
		private void EnsureScaleCacheIfNeeded()
		{
			if (this.ScaleCache != null)
			{
				return;
			}
			this.ScaleCache = this.ScaleIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x002378BE File Offset: 0x00235ABE
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetLocationFrozenDict()
		{
			this.EnsureLocationCacheIfNeeded();
			return this.LocationCache;
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x002378CC File Offset: 0x00235ACC
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetRotationFrozenDict()
		{
			this.EnsureRotationCacheIfNeeded();
			return this.RotationCache;
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x002378DA File Offset: 0x00235ADA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetScaleFrozenDict()
		{
			this.EnsureScaleCacheIfNeeded();
			return this.ScaleCache;
		}

		// Token: 0x0400521D RID: 21021
		private Table __p;

		// Token: 0x0400521E RID: 21022
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> LocationCache;

		// Token: 0x0400521F RID: 21023
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> RotationCache;

		// Token: 0x04005220 RID: 21024
		[Nullable(2)]
		private FrozenDictionary<int, int> ScaleCache;
	}
}
