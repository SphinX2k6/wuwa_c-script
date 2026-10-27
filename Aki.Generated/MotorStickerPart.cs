using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E6B RID: 3691
	public struct MotorStickerPart : IFlatbufferObject
	{
		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x06009C52 RID: 40018 RVA: 0x00297B79 File Offset: 0x00295D79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C53 RID: 40019 RVA: 0x00297B86 File Offset: 0x00295D86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C54 RID: 40020 RVA: 0x00297B90 File Offset: 0x00295D90
		public static MotorStickerPart GetRootAsMotorStickerPart(ByteBuffer _bb)
		{
			return MotorStickerPart.GetRootAsMotorStickerPart(_bb, default(MotorStickerPart));
		}

		// Token: 0x06009C55 RID: 40021 RVA: 0x00297BAC File Offset: 0x00295DAC
		public static MotorStickerPart GetRootAsMotorStickerPart(ByteBuffer _bb, MotorStickerPart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C56 RID: 40022 RVA: 0x00297BC9 File Offset: 0x00295DC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C57 RID: 40023 RVA: 0x00297BD8 File Offset: 0x00295DD8
		public MotorStickerPart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x06009C58 RID: 40024 RVA: 0x00297BE8 File Offset: 0x00295DE8
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

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x06009C59 RID: 40025 RVA: 0x00297C24 File Offset: 0x00295E24
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

		// Token: 0x06009C5A RID: 40026 RVA: 0x00297C5B File Offset: 0x00295E5B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009C5B RID: 40027 RVA: 0x00297C6A File Offset: 0x00295E6A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x06009C5C RID: 40028 RVA: 0x00297C84 File Offset: 0x00295E84
		public string IconSelect
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

		// Token: 0x06009C5D RID: 40029 RVA: 0x00297CBB File Offset: 0x00295EBB
		public Span<byte> GetIconSelectBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009C5E RID: 40030 RVA: 0x00297CCA File Offset: 0x00295ECA
		public byte[] GetIconSelectArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06009C5F RID: 40031 RVA: 0x00297CE4 File Offset: 0x00295EE4
		public DicIntInt? CameraId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x06009C60 RID: 40032 RVA: 0x00297D48 File Offset: 0x00295F48
		public int CameraIdLength
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

		// Token: 0x06009C61 RID: 40033 RVA: 0x00297D74 File Offset: 0x00295F74
		public string CameraIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x06009C62 RID: 40034 RVA: 0x00297DB0 File Offset: 0x00295FB0
		public int CameraIdsLength
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

		// Token: 0x06009C63 RID: 40035 RVA: 0x00297DDC File Offset: 0x00295FDC
		public string DetailCameraIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x06009C64 RID: 40036 RVA: 0x00297E18 File Offset: 0x00296018
		public int DetailCameraIdsLength
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

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x06009C65 RID: 40037 RVA: 0x00297E44 File Offset: 0x00296044
		public string TipsCameraId
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

		// Token: 0x06009C66 RID: 40038 RVA: 0x00297E7C File Offset: 0x0029607C
		public Span<byte> GetTipsCameraIdBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009C67 RID: 40039 RVA: 0x00297E8C File Offset: 0x0029608C
		public byte[] GetTipsCameraIdArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x00297EA4 File Offset: 0x002960A4
		public string EditCameraIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x06009C69 RID: 40041 RVA: 0x00297EE0 File Offset: 0x002960E0
		public int EditCameraIdsLength
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

		// Token: 0x06009C6A RID: 40042 RVA: 0x00297F0C File Offset: 0x0029610C
		public string EditDetailCameraIds(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x06009C6B RID: 40043 RVA: 0x00297F48 File Offset: 0x00296148
		public int EditDetailCameraIdsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009C6C RID: 40044 RVA: 0x00297F74 File Offset: 0x00296174
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CameraIdFrozenDict()缓存字典，遍历请使用CameraIdIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> CameraId()
		{
			return this.CameraIdIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009C6D RID: 40045 RVA: 0x00297FCA File Offset: 0x002961CA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CameraIdIter()
		{
			MotorStickerPart.<CameraIdIter>d__38 <CameraIdIter>d__ = new MotorStickerPart.<CameraIdIter>d__38(-2);
			<CameraIdIter>d__.<>3__<>4__this = this;
			return <CameraIdIter>d__;
		}

		// Token: 0x06009C6E RID: 40046 RVA: 0x00297FDF File Offset: 0x002961DF
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CameraIdsIter()或GetCameraIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] CameraIds()
		{
			return this.CameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009C6F RID: 40047 RVA: 0x00297FEC File Offset: 0x002961EC
		[NullableContext(1)]
		public readonly IEnumerable<string> CameraIdsIter()
		{
			MotorStickerPart.<CameraIdsIter>d__40 <CameraIdsIter>d__ = new MotorStickerPart.<CameraIdsIter>d__40(-2);
			<CameraIdsIter>d__.<>3__<>4__this = this;
			return <CameraIdsIter>d__;
		}

		// Token: 0x06009C70 RID: 40048 RVA: 0x00298001 File Offset: 0x00296201
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DetailCameraIdsIter()或GetDetailCameraIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DetailCameraIds()
		{
			return this.DetailCameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009C71 RID: 40049 RVA: 0x0029800E File Offset: 0x0029620E
		[NullableContext(1)]
		public readonly IEnumerable<string> DetailCameraIdsIter()
		{
			MotorStickerPart.<DetailCameraIdsIter>d__42 <DetailCameraIdsIter>d__ = new MotorStickerPart.<DetailCameraIdsIter>d__42(-2);
			<DetailCameraIdsIter>d__.<>3__<>4__this = this;
			return <DetailCameraIdsIter>d__;
		}

		// Token: 0x06009C72 RID: 40050 RVA: 0x00298023 File Offset: 0x00296223
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EditCameraIdsIter()或GetEditCameraIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EditCameraIds()
		{
			return this.EditCameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009C73 RID: 40051 RVA: 0x00298030 File Offset: 0x00296230
		[NullableContext(1)]
		public readonly IEnumerable<string> EditCameraIdsIter()
		{
			MotorStickerPart.<EditCameraIdsIter>d__44 <EditCameraIdsIter>d__ = new MotorStickerPart.<EditCameraIdsIter>d__44(-2);
			<EditCameraIdsIter>d__.<>3__<>4__this = this;
			return <EditCameraIdsIter>d__;
		}

		// Token: 0x06009C74 RID: 40052 RVA: 0x00298045 File Offset: 0x00296245
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EditDetailCameraIdsIter()或GetEditDetailCameraIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EditDetailCameraIds()
		{
			return this.EditDetailCameraIdsIter().ToArray<string>();
		}

		// Token: 0x06009C75 RID: 40053 RVA: 0x00298052 File Offset: 0x00296252
		[NullableContext(1)]
		public readonly IEnumerable<string> EditDetailCameraIdsIter()
		{
			MotorStickerPart.<EditDetailCameraIdsIter>d__46 <EditDetailCameraIdsIter>d__ = new MotorStickerPart.<EditDetailCameraIdsIter>d__46(-2);
			<EditDetailCameraIdsIter>d__.<>3__<>4__this = this;
			return <EditDetailCameraIdsIter>d__;
		}

		// Token: 0x06009C76 RID: 40054 RVA: 0x00298068 File Offset: 0x00296268
		public int? GetCameraId(int key)
		{
			this.EnsureCameraIdCacheIfNeeded();
			int value;
			if (!this.CameraIdCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06009C77 RID: 40055 RVA: 0x0029809C File Offset: 0x0029629C
		private void EnsureCameraIdCacheIfNeeded()
		{
			if (this.CameraIdCache != null)
			{
				return;
			}
			this.CameraIdCache = this.CameraIdIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009C78 RID: 40056 RVA: 0x00298102 File Offset: 0x00296302
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCameraIdFrozenDict(int key)
		{
			this.EnsureCameraIdCacheIfNeeded();
			return this.CameraIdCache;
		}

		// Token: 0x04004F18 RID: 20248
		private Table __p;

		// Token: 0x04004F19 RID: 20249
		[Nullable(2)]
		private FrozenDictionary<int, int> CameraIdCache;
	}
}
