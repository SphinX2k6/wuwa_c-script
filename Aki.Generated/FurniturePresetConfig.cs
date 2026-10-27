using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CDA RID: 3290
	public struct FurniturePresetConfig : IFlatbufferObject
	{
		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x060077C5 RID: 30661 RVA: 0x002451CD File Offset: 0x002433CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x002451DA File Offset: 0x002433DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x002451E4 File Offset: 0x002433E4
		public static FurniturePresetConfig GetRootAsFurniturePresetConfig(ByteBuffer _bb)
		{
			return FurniturePresetConfig.GetRootAsFurniturePresetConfig(_bb, default(FurniturePresetConfig));
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x00245200 File Offset: 0x00243400
		public static FurniturePresetConfig GetRootAsFurniturePresetConfig(ByteBuffer _bb, FurniturePresetConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x0024521D File Offset: 0x0024341D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x0024522C File Offset: 0x0024342C
		public FurniturePresetConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x060077CB RID: 30667 RVA: 0x0024523C File Offset: 0x0024343C
		public int AreaId
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

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x060077CC RID: 30668 RVA: 0x00245278 File Offset: 0x00243478
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

		// Token: 0x060077CD RID: 30669 RVA: 0x002452AF File Offset: 0x002434AF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x002452BE File Offset: 0x002434BE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x060077CF RID: 30671 RVA: 0x002452D8 File Offset: 0x002434D8
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

		// Token: 0x060077D0 RID: 30672 RVA: 0x0024530F File Offset: 0x0024350F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x0024531E File Offset: 0x0024351E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060077D2 RID: 30674 RVA: 0x00245338 File Offset: 0x00243538
		public DicIntIntArray? FurniturePlaceInfo(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x060077D3 RID: 30675 RVA: 0x0024539C File Offset: 0x0024359C
		public int FurniturePlaceInfoLength
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

		// Token: 0x060077D4 RID: 30676 RVA: 0x002453C8 File Offset: 0x002435C8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FurniturePlaceInfoFrozenDict()缓存字典，遍历请使用FurniturePlaceInfoIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> FurniturePlaceInfo()
		{
			return this.FurniturePlaceInfoIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x060077D5 RID: 30677 RVA: 0x0024541E File Offset: 0x0024361E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> FurniturePlaceInfoIter()
		{
			FurniturePresetConfig.<FurniturePlaceInfoIter>d__22 <FurniturePlaceInfoIter>d__ = new FurniturePresetConfig.<FurniturePlaceInfoIter>d__22(-2);
			<FurniturePlaceInfoIter>d__.<>3__<>4__this = this;
			return <FurniturePlaceInfoIter>d__;
		}

		// Token: 0x060077D6 RID: 30678 RVA: 0x00245434 File Offset: 0x00243634
		public IntArray? GetFurniturePlaceInfo(int key)
		{
			this.EnsureFurniturePlaceInfoCacheIfNeeded();
			IntArray value;
			if (!this.FurniturePlaceInfoCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x00245468 File Offset: 0x00243668
		private void EnsureFurniturePlaceInfoCacheIfNeeded()
		{
			if (this.FurniturePlaceInfoCache != null)
			{
				return;
			}
			this.FurniturePlaceInfoCache = this.FurniturePlaceInfoIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x002454CE File Offset: 0x002436CE
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetFurniturePlaceInfoFrozenDict(int key)
		{
			this.EnsureFurniturePlaceInfoCacheIfNeeded();
			return this.FurniturePlaceInfoCache;
		}

		// Token: 0x04004D4A RID: 19786
		private Table __p;

		// Token: 0x04004D4B RID: 19787
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> FurniturePlaceInfoCache;
	}
}
