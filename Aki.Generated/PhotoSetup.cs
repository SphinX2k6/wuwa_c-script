using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FFC RID: 4092
	public struct PhotoSetup : IFlatbufferObject
	{
		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x0600B32E RID: 45870 RVA: 0x002DA154 File Offset: 0x002D8354
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B32F RID: 45871 RVA: 0x002DA161 File Offset: 0x002D8361
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B330 RID: 45872 RVA: 0x002DA168 File Offset: 0x002D8368
		public static PhotoSetup GetRootAsPhotoSetup(ByteBuffer _bb)
		{
			return PhotoSetup.GetRootAsPhotoSetup(_bb, default(PhotoSetup));
		}

		// Token: 0x0600B331 RID: 45873 RVA: 0x002DA184 File Offset: 0x002D8384
		public static PhotoSetup GetRootAsPhotoSetup(ByteBuffer _bb, PhotoSetup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B332 RID: 45874 RVA: 0x002DA1A1 File Offset: 0x002D83A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B333 RID: 45875 RVA: 0x002DA1B0 File Offset: 0x002D83B0
		public PhotoSetup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x0600B334 RID: 45876 RVA: 0x002DA1C0 File Offset: 0x002D83C0
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

		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x0600B335 RID: 45877 RVA: 0x002DA1FC File Offset: 0x002D83FC
		public int ValueType
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

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x0600B336 RID: 45878 RVA: 0x002DA238 File Offset: 0x002D8438
		public string Name
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

		// Token: 0x0600B337 RID: 45879 RVA: 0x002DA26F File Offset: 0x002D846F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B338 RID: 45880 RVA: 0x002DA27E File Offset: 0x002D847E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x0600B339 RID: 45881 RVA: 0x002DA298 File Offset: 0x002D8498
		public int Type
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B33A RID: 45882 RVA: 0x002DA2D8 File Offset: 0x002D84D8
		public string Options(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x0600B33B RID: 45883 RVA: 0x002DA314 File Offset: 0x002D8514
		public int OptionsLength
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

		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x0600B33C RID: 45884 RVA: 0x002DA340 File Offset: 0x002D8540
		public int DefaultOptionIndex
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x0600B33D RID: 45885 RVA: 0x002DA380 File Offset: 0x002D8580
		public int DefaultDropDownIndex
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x002DA3C0 File Offset: 0x002D85C0
		public DicIntIntArray? SubOptions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170028E8 RID: 10472
		// (get) Token: 0x0600B33F RID: 45887 RVA: 0x002DA424 File Offset: 0x002D8624
		public int SubOptionsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x0600B340 RID: 45888 RVA: 0x002DA450 File Offset: 0x002D8650
		public int SubOptionBanType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B341 RID: 45889 RVA: 0x002DA490 File Offset: 0x002D8690
		public float ValueRange(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x0600B342 RID: 45890 RVA: 0x002DA4D4 File Offset: 0x002D86D4
		public int ValueRangeLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B343 RID: 45891 RVA: 0x002DA500 File Offset: 0x002D8700
		public Span<float> GetValueRangeBytes()
		{
			return this.__p.__vector_as_span<float>(22, 4);
		}

		// Token: 0x0600B344 RID: 45892 RVA: 0x002DA510 File Offset: 0x002D8710
		public float[] GetValueRangeArray()
		{
			return this.__p.__vector_as_array<float>(22) ?? Array.Empty<float>();
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x0600B345 RID: 45893 RVA: 0x002DA528 File Offset: 0x002D8728
		public bool IsReverseSet
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170028EC RID: 10476
		// (get) Token: 0x0600B346 RID: 45894 RVA: 0x002DA568 File Offset: 0x002D8768
		public float ChangeValue
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0.1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170028ED RID: 10477
		// (get) Token: 0x0600B347 RID: 45895 RVA: 0x002DA5AC File Offset: 0x002D87AC
		public bool IsShowRedDot
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170028EE RID: 10478
		// (get) Token: 0x0600B348 RID: 45896 RVA: 0x002DA5EC File Offset: 0x002D87EC
		public bool IsLocalStorage
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170028EF RID: 10479
		// (get) Token: 0x0600B349 RID: 45897 RVA: 0x002DA62C File Offset: 0x002D882C
		public int Digits
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x0600B34A RID: 45898 RVA: 0x002DA66C File Offset: 0x002D886C
		public string Unit
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B34B RID: 45899 RVA: 0x002DA6A4 File Offset: 0x002D88A4
		public Span<byte> GetUnitBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600B34C RID: 45900 RVA: 0x002DA6B4 File Offset: 0x002D88B4
		public byte[] GetUnitArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x0600B34D RID: 45901 RVA: 0x002DA6CC File Offset: 0x002D88CC
		public bool IsShowInPS5
		{
			get
			{
				int num = this.__p.__offset(36);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x0600B34E RID: 45902 RVA: 0x002DA70C File Offset: 0x002D890C
		public bool IsShowInXbox
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B34F RID: 45903 RVA: 0x002DA74C File Offset: 0x002D894C
		[NullableContext(1)]
		public string[] Options()
		{
			return this.OptionsIter().ToArray<string>();
		}

		// Token: 0x0600B350 RID: 45904 RVA: 0x002DA759 File Offset: 0x002D8959
		[NullableContext(1)]
		public IEnumerable<string> OptionsIter()
		{
			PhotoSetup.<OptionsIter>d__54 <OptionsIter>d__ = new PhotoSetup.<OptionsIter>d__54(-2);
			<OptionsIter>d__.<>3__<>4__this = this;
			return <OptionsIter>d__;
		}

		// Token: 0x0600B351 RID: 45905 RVA: 0x002DA770 File Offset: 0x002D8970
		[NullableContext(1)]
		public Dictionary<int, IntArray> SubOptions()
		{
			return this.SubOptionsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600B352 RID: 45906 RVA: 0x002DA7C6 File Offset: 0x002D89C6
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> SubOptionsIter()
		{
			PhotoSetup.<SubOptionsIter>d__56 <SubOptionsIter>d__ = new PhotoSetup.<SubOptionsIter>d__56(-2);
			<SubOptionsIter>d__.<>3__<>4__this = this;
			return <SubOptionsIter>d__;
		}

		// Token: 0x0600B353 RID: 45907 RVA: 0x002DA7DB File Offset: 0x002D89DB
		[NullableContext(1)]
		public float[] ValueRange()
		{
			return this.GetValueRangeArray();
		}

		// Token: 0x0600B354 RID: 45908 RVA: 0x002DA7E3 File Offset: 0x002D89E3
		[NullableContext(1)]
		public IEnumerable<float> ValueRangeIter()
		{
			PhotoSetup.<ValueRangeIter>d__58 <ValueRangeIter>d__ = new PhotoSetup.<ValueRangeIter>d__58(-2);
			<ValueRangeIter>d__.<>3__<>4__this = this;
			return <ValueRangeIter>d__;
		}

		// Token: 0x0600B355 RID: 45909 RVA: 0x002DA7F8 File Offset: 0x002D89F8
		public IntArray? GetSubOptions(int key)
		{
			this.EnsureSubOptionsCacheIfNeeded();
			IntArray value;
			if (!this.SubOptionsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600B356 RID: 45910 RVA: 0x002DA82C File Offset: 0x002D8A2C
		private void EnsureSubOptionsCacheIfNeeded()
		{
			if (this.SubOptionsCache != null)
			{
				return;
			}
			this.SubOptionsCache = this.SubOptionsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600B357 RID: 45911 RVA: 0x002DA892 File Offset: 0x002D8A92
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetSubOptionsFrozenDict()
		{
			this.EnsureSubOptionsCacheIfNeeded();
			return this.SubOptionsCache;
		}

		// Token: 0x040055C4 RID: 21956
		private Table __p;

		// Token: 0x040055C5 RID: 21957
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> SubOptionsCache;
	}
}
