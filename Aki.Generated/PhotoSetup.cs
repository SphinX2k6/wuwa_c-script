using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F17 RID: 3863
	public struct PhotoSetup : IFlatbufferObject
	{
		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x0600AD0D RID: 44301 RVA: 0x002BD53C File Offset: 0x002BB73C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x002BD549 File Offset: 0x002BB749
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD0F RID: 44303 RVA: 0x002BD550 File Offset: 0x002BB750
		public static PhotoSetup GetRootAsPhotoSetup(ByteBuffer _bb)
		{
			return PhotoSetup.GetRootAsPhotoSetup(_bb, default(PhotoSetup));
		}

		// Token: 0x0600AD10 RID: 44304 RVA: 0x002BD56C File Offset: 0x002BB76C
		public static PhotoSetup GetRootAsPhotoSetup(ByteBuffer _bb, PhotoSetup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD11 RID: 44305 RVA: 0x002BD589 File Offset: 0x002BB789
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD12 RID: 44306 RVA: 0x002BD598 File Offset: 0x002BB798
		public PhotoSetup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x0600AD13 RID: 44307 RVA: 0x002BD5A8 File Offset: 0x002BB7A8
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

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x0600AD14 RID: 44308 RVA: 0x002BD5E4 File Offset: 0x002BB7E4
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

		// Token: 0x1700287D RID: 10365
		// (get) Token: 0x0600AD15 RID: 44309 RVA: 0x002BD620 File Offset: 0x002BB820
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

		// Token: 0x0600AD16 RID: 44310 RVA: 0x002BD657 File Offset: 0x002BB857
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AD17 RID: 44311 RVA: 0x002BD666 File Offset: 0x002BB866
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x0600AD18 RID: 44312 RVA: 0x002BD680 File Offset: 0x002BB880
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

		// Token: 0x0600AD19 RID: 44313 RVA: 0x002BD6C0 File Offset: 0x002BB8C0
		public string Options(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x0600AD1A RID: 44314 RVA: 0x002BD6FC File Offset: 0x002BB8FC
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

		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x0600AD1B RID: 44315 RVA: 0x002BD728 File Offset: 0x002BB928
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

		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x0600AD1C RID: 44316 RVA: 0x002BD768 File Offset: 0x002BB968
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

		// Token: 0x0600AD1D RID: 44317 RVA: 0x002BD7A8 File Offset: 0x002BB9A8
		public DicIntIntArray? SubOptions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x0600AD1E RID: 44318 RVA: 0x002BD80C File Offset: 0x002BBA0C
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

		// Token: 0x17002883 RID: 10371
		// (get) Token: 0x0600AD1F RID: 44319 RVA: 0x002BD838 File Offset: 0x002BBA38
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

		// Token: 0x0600AD20 RID: 44320 RVA: 0x002BD878 File Offset: 0x002BBA78
		public float ValueRange(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x0600AD21 RID: 44321 RVA: 0x002BD8BC File Offset: 0x002BBABC
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

		// Token: 0x0600AD22 RID: 44322 RVA: 0x002BD8E8 File Offset: 0x002BBAE8
		public Span<float> GetValueRangeBytes()
		{
			return this.__p.__vector_as_span<float>(22, 4);
		}

		// Token: 0x0600AD23 RID: 44323 RVA: 0x002BD8F8 File Offset: 0x002BBAF8
		public float[] GetValueRangeArray()
		{
			return this.__p.__vector_as_array<float>(22) ?? Array.Empty<float>();
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x0600AD24 RID: 44324 RVA: 0x002BD910 File Offset: 0x002BBB10
		public bool IsReverseSet
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x0600AD25 RID: 44325 RVA: 0x002BD950 File Offset: 0x002BBB50
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

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x0600AD26 RID: 44326 RVA: 0x002BD994 File Offset: 0x002BBB94
		public bool IsShowRedDot
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x0600AD27 RID: 44327 RVA: 0x002BD9D4 File Offset: 0x002BBBD4
		public bool IsLocalStorage
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002889 RID: 10377
		// (get) Token: 0x0600AD28 RID: 44328 RVA: 0x002BDA14 File Offset: 0x002BBC14
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

		// Token: 0x1700288A RID: 10378
		// (get) Token: 0x0600AD29 RID: 44329 RVA: 0x002BDA54 File Offset: 0x002BBC54
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

		// Token: 0x0600AD2A RID: 44330 RVA: 0x002BDA8C File Offset: 0x002BBC8C
		public Span<byte> GetUnitBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600AD2B RID: 44331 RVA: 0x002BDA9C File Offset: 0x002BBC9C
		public byte[] GetUnitArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700288B RID: 10379
		// (get) Token: 0x0600AD2C RID: 44332 RVA: 0x002BDAB4 File Offset: 0x002BBCB4
		public bool IsShowInPS5
		{
			get
			{
				int num = this.__p.__offset(36);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700288C RID: 10380
		// (get) Token: 0x0600AD2D RID: 44333 RVA: 0x002BDAF4 File Offset: 0x002BBCF4
		public bool IsShowInXbox
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600AD2E RID: 44334 RVA: 0x002BDB34 File Offset: 0x002BBD34
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OptionsIter()或GetOptionsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Options()
		{
			return this.OptionsIter().ToArray<string>();
		}

		// Token: 0x0600AD2F RID: 44335 RVA: 0x002BDB41 File Offset: 0x002BBD41
		[NullableContext(1)]
		public readonly IEnumerable<string> OptionsIter()
		{
			PhotoSetup.<OptionsIter>d__54 <OptionsIter>d__ = new PhotoSetup.<OptionsIter>d__54(-2);
			<OptionsIter>d__.<>3__<>4__this = this;
			return <OptionsIter>d__;
		}

		// Token: 0x0600AD30 RID: 44336 RVA: 0x002BDB58 File Offset: 0x002BBD58
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SubOptionsFrozenDict()缓存字典，遍历请使用SubOptionsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> SubOptions()
		{
			return this.SubOptionsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600AD31 RID: 44337 RVA: 0x002BDBAE File Offset: 0x002BBDAE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> SubOptionsIter()
		{
			PhotoSetup.<SubOptionsIter>d__56 <SubOptionsIter>d__ = new PhotoSetup.<SubOptionsIter>d__56(-2);
			<SubOptionsIter>d__.<>3__<>4__this = this;
			return <SubOptionsIter>d__;
		}

		// Token: 0x0600AD32 RID: 44338 RVA: 0x002BDBC4 File Offset: 0x002BBDC4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ValueRangeIter()或GetValueRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] ValueRange()
		{
			PhotoSetup photoSetup = this;
			return photoSetup.GetValueRangeArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600AD33 RID: 44339 RVA: 0x002BDBE8 File Offset: 0x002BBDE8
		[NullableContext(1)]
		public readonly IEnumerable<float> ValueRangeIter()
		{
			PhotoSetup.<ValueRangeIter>d__58 <ValueRangeIter>d__ = new PhotoSetup.<ValueRangeIter>d__58(-2);
			<ValueRangeIter>d__.<>3__<>4__this = this;
			return <ValueRangeIter>d__;
		}

		// Token: 0x0600AD34 RID: 44340 RVA: 0x002BDC00 File Offset: 0x002BBE00
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

		// Token: 0x0600AD35 RID: 44341 RVA: 0x002BDC34 File Offset: 0x002BBE34
		private void EnsureSubOptionsCacheIfNeeded()
		{
			if (this.SubOptionsCache != null)
			{
				return;
			}
			this.SubOptionsCache = this.SubOptionsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600AD36 RID: 44342 RVA: 0x002BDC9A File Offset: 0x002BBE9A
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetSubOptionsFrozenDict(int key)
		{
			this.EnsureSubOptionsCacheIfNeeded();
			return this.SubOptionsCache;
		}

		// Token: 0x04004FDF RID: 20447
		private Table __p;

		// Token: 0x04004FE0 RID: 20448
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> SubOptionsCache;
	}
}
