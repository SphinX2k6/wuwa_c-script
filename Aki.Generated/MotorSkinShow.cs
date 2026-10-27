using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E69 RID: 3689
	public struct MotorSkinShow : IFlatbufferObject
	{
		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x06009BFE RID: 39934 RVA: 0x00296F85 File Offset: 0x00295185
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009BFF RID: 39935 RVA: 0x00296F92 File Offset: 0x00295192
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C00 RID: 39936 RVA: 0x00296F9C File Offset: 0x0029519C
		public static MotorSkinShow GetRootAsMotorSkinShow(ByteBuffer _bb)
		{
			return MotorSkinShow.GetRootAsMotorSkinShow(_bb, default(MotorSkinShow));
		}

		// Token: 0x06009C01 RID: 39937 RVA: 0x00296FB8 File Offset: 0x002951B8
		public static MotorSkinShow GetRootAsMotorSkinShow(ByteBuffer _bb, MotorSkinShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C02 RID: 39938 RVA: 0x00296FD5 File Offset: 0x002951D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C03 RID: 39939 RVA: 0x00296FE4 File Offset: 0x002951E4
		public MotorSkinShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x06009C04 RID: 39940 RVA: 0x00296FF4 File Offset: 0x002951F4
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

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x06009C05 RID: 39941 RVA: 0x00297030 File Offset: 0x00295230
		public int QualityId
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

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x06009C06 RID: 39942 RVA: 0x0029706C File Offset: 0x0029526C
		public int FreeItem
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

		// Token: 0x06009C07 RID: 39943 RVA: 0x002970A8 File Offset: 0x002952A8
		public DicStringInt? ItemCount(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x06009C08 RID: 39944 RVA: 0x0029710C File Offset: 0x0029530C
		public int ItemCountLength
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

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x06009C09 RID: 39945 RVA: 0x00297138 File Offset: 0x00295338
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C0A RID: 39946 RVA: 0x00297170 File Offset: 0x00295370
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009C0B RID: 39947 RVA: 0x00297180 File Offset: 0x00295380
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x06009C0C RID: 39948 RVA: 0x00297198 File Offset: 0x00295398
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

		// Token: 0x06009C0D RID: 39949 RVA: 0x002971D0 File Offset: 0x002953D0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009C0E RID: 39950 RVA: 0x002971E0 File Offset: 0x002953E0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x06009C0F RID: 39951 RVA: 0x002971F8 File Offset: 0x002953F8
		public string TypeDescription
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

		// Token: 0x06009C10 RID: 39952 RVA: 0x00297230 File Offset: 0x00295430
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009C11 RID: 39953 RVA: 0x00297240 File Offset: 0x00295440
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x06009C12 RID: 39954 RVA: 0x00297258 File Offset: 0x00295458
		public string Desc
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

		// Token: 0x06009C13 RID: 39955 RVA: 0x00297290 File Offset: 0x00295490
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009C14 RID: 39956 RVA: 0x002972A0 File Offset: 0x002954A0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x06009C15 RID: 39957 RVA: 0x002972B8 File Offset: 0x002954B8
		public int JumpDiyRoot
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

		// Token: 0x06009C16 RID: 39958 RVA: 0x002972F8 File Offset: 0x002954F8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ItemCountFrozenDict()缓存字典，遍历请使用ItemCountIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, int> ItemCount()
		{
			return this.ItemCountIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x06009C17 RID: 39959 RVA: 0x0029734E File Offset: 0x0029554E
		[NullableContext(1)]
		public readonly IEnumerable<DicStringInt> ItemCountIter()
		{
			MotorSkinShow.<ItemCountIter>d__36 <ItemCountIter>d__ = new MotorSkinShow.<ItemCountIter>d__36(-2);
			<ItemCountIter>d__.<>3__<>4__this = this;
			return <ItemCountIter>d__;
		}

		// Token: 0x06009C18 RID: 39960 RVA: 0x00297364 File Offset: 0x00295564
		[NullableContext(1)]
		public int? GetItemCount(string key)
		{
			this.EnsureItemCountCacheIfNeeded();
			int value;
			if (!this.ItemCountCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06009C19 RID: 39961 RVA: 0x00297398 File Offset: 0x00295598
		private void EnsureItemCountCacheIfNeeded()
		{
			if (this.ItemCountCache != null)
			{
				return;
			}
			this.ItemCountCache = this.ItemCountIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009C1A RID: 39962 RVA: 0x002973FE File Offset: 0x002955FE
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, int> GetItemCountFrozenDict(string key)
		{
			this.EnsureItemCountCacheIfNeeded();
			return this.ItemCountCache;
		}

		// Token: 0x04004F15 RID: 20245
		private Table __p;

		// Token: 0x04004F16 RID: 20246
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> ItemCountCache;
	}
}
