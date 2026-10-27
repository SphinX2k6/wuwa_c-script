using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ADB RID: 2779
	public struct AdvertisingTabEnemy : IFlatbufferObject
	{
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06004533 RID: 17715 RVA: 0x001D0078 File Offset: 0x001CE278
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x001D0085 File Offset: 0x001CE285
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x001D008C File Offset: 0x001CE28C
		public static AdvertisingTabEnemy GetRootAsAdvertisingTabEnemy(ByteBuffer _bb)
		{
			return AdvertisingTabEnemy.GetRootAsAdvertisingTabEnemy(_bb, default(AdvertisingTabEnemy));
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x001D00A8 File Offset: 0x001CE2A8
		public static AdvertisingTabEnemy GetRootAsAdvertisingTabEnemy(ByteBuffer _bb, AdvertisingTabEnemy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x001D00C5 File Offset: 0x001CE2C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x001D00D4 File Offset: 0x001CE2D4
		public AdvertisingTabEnemy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06004539 RID: 17721 RVA: 0x001D00E4 File Offset: 0x001CE2E4
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

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600453A RID: 17722 RVA: 0x001D0120 File Offset: 0x001CE320
		public int Type
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

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600453B RID: 17723 RVA: 0x001D015C File Offset: 0x001CE35C
		public string ThumbnailText
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

		// Token: 0x0600453C RID: 17724 RVA: 0x001D0193 File Offset: 0x001CE393
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x001D01A2 File Offset: 0x001CE3A2
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600453E RID: 17726 RVA: 0x001D01BC File Offset: 0x001CE3BC
		public string ThumbnailPic
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

		// Token: 0x0600453F RID: 17727 RVA: 0x001D01F4 File Offset: 0x001CE3F4
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x001D0204 File Offset: 0x001CE404
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06004541 RID: 17729 RVA: 0x001D021C File Offset: 0x001CE41C
		public string Title
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

		// Token: 0x06004542 RID: 17730 RVA: 0x001D0254 File Offset: 0x001CE454
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x001D0264 File Offset: 0x001CE464
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06004544 RID: 17732 RVA: 0x001D027C File Offset: 0x001CE47C
		public string SubTitle
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

		// Token: 0x06004545 RID: 17733 RVA: 0x001D02B4 File Offset: 0x001CE4B4
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x001D02C4 File Offset: 0x001CE4C4
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x001D02DC File Offset: 0x001CE4DC
		public string Description
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

		// Token: 0x06004548 RID: 17736 RVA: 0x001D0314 File Offset: 0x001CE514
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x001D0324 File Offset: 0x001CE524
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600454A RID: 17738 RVA: 0x001D033C File Offset: 0x001CE53C
		public string MainPic
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

		// Token: 0x0600454B RID: 17739 RVA: 0x001D0374 File Offset: 0x001CE574
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x001D0384 File Offset: 0x001CE584
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x001D039C File Offset: 0x001CE59C
		public string EnemyDescription
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x001D03D4 File Offset: 0x001CE5D4
		public Span<byte> GetEnemyDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x001D03E4 File Offset: 0x001CE5E4
		public byte[] GetEnemyDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06004550 RID: 17744 RVA: 0x001D03FC File Offset: 0x001CE5FC
		public string VisionDescription
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x001D0434 File Offset: 0x001CE634
		public Span<byte> GetVisionDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x001D0444 File Offset: 0x001CE644
		public byte[] GetVisionDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x001D045C File Offset: 0x001CE65C
		public int VisionFetterList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06004554 RID: 17748 RVA: 0x001D049C File Offset: 0x001CE69C
		public int VisionFetterListLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x001D04C8 File Offset: 0x001CE6C8
		public Span<int> GetVisionFetterListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x001D04D8 File Offset: 0x001CE6D8
		public int[] GetVisionFetterListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x001D04F0 File Offset: 0x001CE6F0
		public string VisionFetterColorList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06004558 RID: 17752 RVA: 0x001D052C File Offset: 0x001CE72C
		public int VisionFetterColorListLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x001D0558 File Offset: 0x001CE758
		public string VisionFetterIconList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600455A RID: 17754 RVA: 0x001D0594 File Offset: 0x001CE794
		public int VisionFetterIconListLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x001D05C0 File Offset: 0x001CE7C0
		public DicIntString? VisionEffectMap(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600455C RID: 17756 RVA: 0x001D0624 File Offset: 0x001CE824
		public int VisionEffectMapLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600455D RID: 17757 RVA: 0x001D0650 File Offset: 0x001CE850
		public string SuitCoreSprite
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x001D0688 File Offset: 0x001CE888
		public Span<byte> GetSuitCoreSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x001D0698 File Offset: 0x001CE898
		public byte[] GetSuitCoreSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06004560 RID: 17760 RVA: 0x001D06B0 File Offset: 0x001CE8B0
		public string SuitCoreBgSprite
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

		// Token: 0x06004561 RID: 17761 RVA: 0x001D06E8 File Offset: 0x001CE8E8
		public Span<byte> GetSuitCoreBgSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x001D06F8 File Offset: 0x001CE8F8
		public byte[] GetSuitCoreBgSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06004563 RID: 17763 RVA: 0x001D0710 File Offset: 0x001CE910
		public string SuitOuterBgTexture
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x001D0748 File Offset: 0x001CE948
		public Span<byte> GetSuitOuterBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x001D0758 File Offset: 0x001CE958
		public byte[] GetSuitOuterBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06004566 RID: 17766 RVA: 0x001D0770 File Offset: 0x001CE970
		public string SuitNiagaraColor
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x001D07A8 File Offset: 0x001CE9A8
		public Span<byte> GetSuitNiagaraColorBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x001D07B8 File Offset: 0x001CE9B8
		public byte[] GetSuitNiagaraColorArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x001D07D0 File Offset: 0x001CE9D0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用VisionEffectMapFrozenDict()缓存字典，遍历请使用VisionEffectMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> VisionEffectMap()
		{
			return this.VisionEffectMapIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x001D0826 File Offset: 0x001CEA26
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> VisionEffectMapIter()
		{
			AdvertisingTabEnemy.<VisionEffectMapIter>d__75 <VisionEffectMapIter>d__ = new AdvertisingTabEnemy.<VisionEffectMapIter>d__75(-2);
			<VisionEffectMapIter>d__.<>3__<>4__this = this;
			return <VisionEffectMapIter>d__;
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x001D083B File Offset: 0x001CEA3B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用VisionFetterColorListIter()或GetVisionFetterColorListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] VisionFetterColorList()
		{
			return this.VisionFetterColorListIter().ToArray<string>();
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x001D0848 File Offset: 0x001CEA48
		[NullableContext(1)]
		public readonly IEnumerable<string> VisionFetterColorListIter()
		{
			AdvertisingTabEnemy.<VisionFetterColorListIter>d__77 <VisionFetterColorListIter>d__ = new AdvertisingTabEnemy.<VisionFetterColorListIter>d__77(-2);
			<VisionFetterColorListIter>d__.<>3__<>4__this = this;
			return <VisionFetterColorListIter>d__;
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x001D085D File Offset: 0x001CEA5D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用VisionFetterIconListIter()或GetVisionFetterIconListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] VisionFetterIconList()
		{
			return this.VisionFetterIconListIter().ToArray<string>();
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x001D086A File Offset: 0x001CEA6A
		[NullableContext(1)]
		public readonly IEnumerable<string> VisionFetterIconListIter()
		{
			AdvertisingTabEnemy.<VisionFetterIconListIter>d__79 <VisionFetterIconListIter>d__ = new AdvertisingTabEnemy.<VisionFetterIconListIter>d__79(-2);
			<VisionFetterIconListIter>d__.<>3__<>4__this = this;
			return <VisionFetterIconListIter>d__;
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x001D0880 File Offset: 0x001CEA80
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用VisionFetterListIter()或GetVisionFetterListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] VisionFetterList()
		{
			AdvertisingTabEnemy advertisingTabEnemy = this;
			return advertisingTabEnemy.GetVisionFetterListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x001D08A4 File Offset: 0x001CEAA4
		[NullableContext(1)]
		public readonly IEnumerable<int> VisionFetterListIter()
		{
			AdvertisingTabEnemy.<VisionFetterListIter>d__81 <VisionFetterListIter>d__ = new AdvertisingTabEnemy.<VisionFetterListIter>d__81(-2);
			<VisionFetterListIter>d__.<>3__<>4__this = this;
			return <VisionFetterListIter>d__;
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x001D08BC File Offset: 0x001CEABC
		[NullableContext(2)]
		public string GetVisionEffectMap(int key)
		{
			this.EnsureVisionEffectMapCacheIfNeeded();
			string result;
			if (!this.VisionEffectMapCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x001D08E4 File Offset: 0x001CEAE4
		private void EnsureVisionEffectMapCacheIfNeeded()
		{
			if (this.VisionEffectMapCache != null)
			{
				return;
			}
			this.VisionEffectMapCache = this.VisionEffectMapIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x001D094A File Offset: 0x001CEB4A
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetVisionEffectMapFrozenDict(int key)
		{
			this.EnsureVisionEffectMapCacheIfNeeded();
			return this.VisionEffectMapCache;
		}

		// Token: 0x04004ABA RID: 19130
		private Table __p;

		// Token: 0x04004ABB RID: 19131
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> VisionEffectMapCache;
	}
}
