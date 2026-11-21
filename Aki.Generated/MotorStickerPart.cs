using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F50 RID: 3920
	public struct MotorStickerPart : IFlatbufferObject
	{
		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x0600A272 RID: 41586 RVA: 0x002B5431 File Offset: 0x002B3631
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A273 RID: 41587 RVA: 0x002B543E File Offset: 0x002B363E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A274 RID: 41588 RVA: 0x002B5448 File Offset: 0x002B3648
		public static MotorStickerPart GetRootAsMotorStickerPart(ByteBuffer _bb)
		{
			return MotorStickerPart.GetRootAsMotorStickerPart(_bb, default(MotorStickerPart));
		}

		// Token: 0x0600A275 RID: 41589 RVA: 0x002B5464 File Offset: 0x002B3664
		public static MotorStickerPart GetRootAsMotorStickerPart(ByteBuffer _bb, MotorStickerPart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A276 RID: 41590 RVA: 0x002B5481 File Offset: 0x002B3681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A277 RID: 41591 RVA: 0x002B5490 File Offset: 0x002B3690
		public MotorStickerPart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x0600A278 RID: 41592 RVA: 0x002B54A0 File Offset: 0x002B36A0
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

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x0600A279 RID: 41593 RVA: 0x002B54DC File Offset: 0x002B36DC
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

		// Token: 0x0600A27A RID: 41594 RVA: 0x002B5513 File Offset: 0x002B3713
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A27B RID: 41595 RVA: 0x002B5522 File Offset: 0x002B3722
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x0600A27C RID: 41596 RVA: 0x002B553C File Offset: 0x002B373C
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

		// Token: 0x0600A27D RID: 41597 RVA: 0x002B5573 File Offset: 0x002B3773
		public Span<byte> GetIconSelectBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A27E RID: 41598 RVA: 0x002B5582 File Offset: 0x002B3782
		public byte[] GetIconSelectArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A27F RID: 41599 RVA: 0x002B559C File Offset: 0x002B379C
		public DicIntInt? CameraId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x0600A280 RID: 41600 RVA: 0x002B5600 File Offset: 0x002B3800
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

		// Token: 0x0600A281 RID: 41601 RVA: 0x002B562C File Offset: 0x002B382C
		public string CameraIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x0600A282 RID: 41602 RVA: 0x002B5668 File Offset: 0x002B3868
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

		// Token: 0x0600A283 RID: 41603 RVA: 0x002B5694 File Offset: 0x002B3894
		public string DetailCameraIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x0600A284 RID: 41604 RVA: 0x002B56D0 File Offset: 0x002B38D0
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

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x0600A285 RID: 41605 RVA: 0x002B56FC File Offset: 0x002B38FC
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

		// Token: 0x0600A286 RID: 41606 RVA: 0x002B5734 File Offset: 0x002B3934
		public Span<byte> GetTipsCameraIdBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x002B5744 File Offset: 0x002B3944
		public byte[] GetTipsCameraIdArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A288 RID: 41608 RVA: 0x002B575C File Offset: 0x002B395C
		public string EditCameraIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x0600A289 RID: 41609 RVA: 0x002B5798 File Offset: 0x002B3998
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

		// Token: 0x0600A28A RID: 41610 RVA: 0x002B57C4 File Offset: 0x002B39C4
		public string EditDetailCameraIds(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x0600A28B RID: 41611 RVA: 0x002B5800 File Offset: 0x002B3A00
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

		// Token: 0x0600A28C RID: 41612 RVA: 0x002B582C File Offset: 0x002B3A2C
		[NullableContext(1)]
		public Dictionary<int, int> CameraId()
		{
			return this.CameraIdIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A28D RID: 41613 RVA: 0x002B5882 File Offset: 0x002B3A82
		[NullableContext(1)]
		public IEnumerable<DicIntInt> CameraIdIter()
		{
			MotorStickerPart.<CameraIdIter>d__38 <CameraIdIter>d__ = new MotorStickerPart.<CameraIdIter>d__38(-2);
			<CameraIdIter>d__.<>3__<>4__this = this;
			return <CameraIdIter>d__;
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x002B5897 File Offset: 0x002B3A97
		[NullableContext(1)]
		public string[] CameraIds()
		{
			return this.CameraIdsIter().ToArray<string>();
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x002B58A4 File Offset: 0x002B3AA4
		[NullableContext(1)]
		public IEnumerable<string> CameraIdsIter()
		{
			MotorStickerPart.<CameraIdsIter>d__40 <CameraIdsIter>d__ = new MotorStickerPart.<CameraIdsIter>d__40(-2);
			<CameraIdsIter>d__.<>3__<>4__this = this;
			return <CameraIdsIter>d__;
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x002B58B9 File Offset: 0x002B3AB9
		[NullableContext(1)]
		public string[] DetailCameraIds()
		{
			return this.DetailCameraIdsIter().ToArray<string>();
		}

		// Token: 0x0600A291 RID: 41617 RVA: 0x002B58C6 File Offset: 0x002B3AC6
		[NullableContext(1)]
		public IEnumerable<string> DetailCameraIdsIter()
		{
			MotorStickerPart.<DetailCameraIdsIter>d__42 <DetailCameraIdsIter>d__ = new MotorStickerPart.<DetailCameraIdsIter>d__42(-2);
			<DetailCameraIdsIter>d__.<>3__<>4__this = this;
			return <DetailCameraIdsIter>d__;
		}

		// Token: 0x0600A292 RID: 41618 RVA: 0x002B58DB File Offset: 0x002B3ADB
		[NullableContext(1)]
		public string[] EditCameraIds()
		{
			return this.EditCameraIdsIter().ToArray<string>();
		}

		// Token: 0x0600A293 RID: 41619 RVA: 0x002B58E8 File Offset: 0x002B3AE8
		[NullableContext(1)]
		public IEnumerable<string> EditCameraIdsIter()
		{
			MotorStickerPart.<EditCameraIdsIter>d__44 <EditCameraIdsIter>d__ = new MotorStickerPart.<EditCameraIdsIter>d__44(-2);
			<EditCameraIdsIter>d__.<>3__<>4__this = this;
			return <EditCameraIdsIter>d__;
		}

		// Token: 0x0600A294 RID: 41620 RVA: 0x002B58FD File Offset: 0x002B3AFD
		[NullableContext(1)]
		public string[] EditDetailCameraIds()
		{
			return this.EditDetailCameraIdsIter().ToArray<string>();
		}

		// Token: 0x0600A295 RID: 41621 RVA: 0x002B590A File Offset: 0x002B3B0A
		[NullableContext(1)]
		public IEnumerable<string> EditDetailCameraIdsIter()
		{
			MotorStickerPart.<EditDetailCameraIdsIter>d__46 <EditDetailCameraIdsIter>d__ = new MotorStickerPart.<EditDetailCameraIdsIter>d__46(-2);
			<EditDetailCameraIdsIter>d__.<>3__<>4__this = this;
			return <EditDetailCameraIdsIter>d__;
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x002B5920 File Offset: 0x002B3B20
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

		// Token: 0x0600A297 RID: 41623 RVA: 0x002B5954 File Offset: 0x002B3B54
		private void EnsureCameraIdCacheIfNeeded()
		{
			if (this.CameraIdCache != null)
			{
				return;
			}
			this.CameraIdCache = this.CameraIdIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x002B59BA File Offset: 0x002B3BBA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetCameraIdFrozenDict()
		{
			this.EnsureCameraIdCacheIfNeeded();
			return this.CameraIdCache;
		}

		// Token: 0x040054FD RID: 21757
		private Table __p;

		// Token: 0x040054FE RID: 21758
		[Nullable(2)]
		private FrozenDictionary<int, int> CameraIdCache;
	}
}
