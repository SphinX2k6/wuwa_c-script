using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C05 RID: 3077
	public struct DrinksOrnament : IFlatbufferObject
	{
		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06006421 RID: 25633 RVA: 0x00217BE9 File Offset: 0x00215DE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x00217BF6 File Offset: 0x00215DF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x00217C00 File Offset: 0x00215E00
		public static DrinksOrnament GetRootAsDrinksOrnament(ByteBuffer _bb)
		{
			return DrinksOrnament.GetRootAsDrinksOrnament(_bb, default(DrinksOrnament));
		}

		// Token: 0x06006424 RID: 25636 RVA: 0x00217C1C File Offset: 0x00215E1C
		public static DrinksOrnament GetRootAsDrinksOrnament(ByteBuffer _bb, DrinksOrnament obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006425 RID: 25637 RVA: 0x00217C39 File Offset: 0x00215E39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006426 RID: 25638 RVA: 0x00217C48 File Offset: 0x00215E48
		public DrinksOrnament __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06006427 RID: 25639 RVA: 0x00217C58 File Offset: 0x00215E58
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

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06006428 RID: 25640 RVA: 0x00217C94 File Offset: 0x00215E94
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

		// Token: 0x06006429 RID: 25641 RVA: 0x00217CCB File Offset: 0x00215ECB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600642A RID: 25642 RVA: 0x00217CDA File Offset: 0x00215EDA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x0600642B RID: 25643 RVA: 0x00217CF4 File Offset: 0x00215EF4
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

		// Token: 0x0600642C RID: 25644 RVA: 0x00217D2B File Offset: 0x00215F2B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600642D RID: 25645 RVA: 0x00217D3A File Offset: 0x00215F3A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x0600642E RID: 25646 RVA: 0x00217D54 File Offset: 0x00215F54
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

		// Token: 0x0600642F RID: 25647 RVA: 0x00217D8C File Offset: 0x00215F8C
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006430 RID: 25648 RVA: 0x00217D9C File Offset: 0x00215F9C
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x00217DB4 File Offset: 0x00215FB4
		public DicIntInt? Scale(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06006432 RID: 25650 RVA: 0x00217E18 File Offset: 0x00216018
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

		// Token: 0x06006433 RID: 25651 RVA: 0x00217E44 File Offset: 0x00216044
		public DicIntIntArray? Location(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06006434 RID: 25652 RVA: 0x00217EA8 File Offset: 0x002160A8
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

		// Token: 0x06006435 RID: 25653 RVA: 0x00217ED4 File Offset: 0x002160D4
		public DicIntIntArray? Rotation(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06006436 RID: 25654 RVA: 0x00217F38 File Offset: 0x00216138
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

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06006437 RID: 25655 RVA: 0x00217F64 File Offset: 0x00216164
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

		// Token: 0x06006438 RID: 25656 RVA: 0x00217FA4 File Offset: 0x002161A4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用LocationFrozenDict()缓存字典，遍历请使用LocationIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> Location()
		{
			return this.LocationIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x00217FFA File Offset: 0x002161FA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> LocationIter()
		{
			DrinksOrnament.<LocationIter>d__34 <LocationIter>d__ = new DrinksOrnament.<LocationIter>d__34(-2);
			<LocationIter>d__.<>3__<>4__this = this;
			return <LocationIter>d__;
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x00218010 File Offset: 0x00216210
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RotationFrozenDict()缓存字典，遍历请使用RotationIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> Rotation()
		{
			return this.RotationIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x00218066 File Offset: 0x00216266
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> RotationIter()
		{
			DrinksOrnament.<RotationIter>d__36 <RotationIter>d__ = new DrinksOrnament.<RotationIter>d__36(-2);
			<RotationIter>d__.<>3__<>4__this = this;
			return <RotationIter>d__;
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x0021807C File Offset: 0x0021627C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ScaleFrozenDict()缓存字典，遍历请使用ScaleIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Scale()
		{
			return this.ScaleIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x002180D2 File Offset: 0x002162D2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ScaleIter()
		{
			DrinksOrnament.<ScaleIter>d__38 <ScaleIter>d__ = new DrinksOrnament.<ScaleIter>d__38(-2);
			<ScaleIter>d__.<>3__<>4__this = this;
			return <ScaleIter>d__;
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x002180E8 File Offset: 0x002162E8
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

		// Token: 0x0600643F RID: 25663 RVA: 0x0021811C File Offset: 0x0021631C
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

		// Token: 0x06006440 RID: 25664 RVA: 0x00218150 File Offset: 0x00216350
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

		// Token: 0x06006441 RID: 25665 RVA: 0x00218184 File Offset: 0x00216384
		private void EnsureLocationCacheIfNeeded()
		{
			if (this.LocationCache != null)
			{
				return;
			}
			this.LocationCache = this.LocationIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x06006442 RID: 25666 RVA: 0x002181EC File Offset: 0x002163EC
		private void EnsureRotationCacheIfNeeded()
		{
			if (this.RotationCache != null)
			{
				return;
			}
			this.RotationCache = this.RotationIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x06006443 RID: 25667 RVA: 0x00218254 File Offset: 0x00216454
		private void EnsureScaleCacheIfNeeded()
		{
			if (this.ScaleCache != null)
			{
				return;
			}
			this.ScaleCache = this.ScaleIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006444 RID: 25668 RVA: 0x002182BA File Offset: 0x002164BA
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetLocationFrozenDict(int key)
		{
			this.EnsureLocationCacheIfNeeded();
			return this.LocationCache;
		}

		// Token: 0x06006445 RID: 25669 RVA: 0x002182C8 File Offset: 0x002164C8
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetRotationFrozenDict(int key)
		{
			this.EnsureRotationCacheIfNeeded();
			return this.RotationCache;
		}

		// Token: 0x06006446 RID: 25670 RVA: 0x002182D6 File Offset: 0x002164D6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetScaleFrozenDict(int key)
		{
			this.EnsureScaleCacheIfNeeded();
			return this.ScaleCache;
		}

		// Token: 0x04004C3B RID: 19515
		private Table __p;

		// Token: 0x04004C3C RID: 19516
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> LocationCache;

		// Token: 0x04004C3D RID: 19517
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> RotationCache;

		// Token: 0x04004C3E RID: 19518
		[Nullable(2)]
		private FrozenDictionary<int, int> ScaleCache;
	}
}
