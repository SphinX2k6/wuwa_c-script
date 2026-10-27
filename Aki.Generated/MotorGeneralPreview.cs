using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E56 RID: 3670
	public struct MotorGeneralPreview : IFlatbufferObject
	{
		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x06009A2C RID: 39468 RVA: 0x00292F5C File Offset: 0x0029115C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A2D RID: 39469 RVA: 0x00292F69 File Offset: 0x00291169
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A2E RID: 39470 RVA: 0x00292F70 File Offset: 0x00291170
		public static MotorGeneralPreview GetRootAsMotorGeneralPreview(ByteBuffer _bb)
		{
			return MotorGeneralPreview.GetRootAsMotorGeneralPreview(_bb, default(MotorGeneralPreview));
		}

		// Token: 0x06009A2F RID: 39471 RVA: 0x00292F8C File Offset: 0x0029118C
		public static MotorGeneralPreview GetRootAsMotorGeneralPreview(ByteBuffer _bb, MotorGeneralPreview obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009A30 RID: 39472 RVA: 0x00292FA9 File Offset: 0x002911A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009A31 RID: 39473 RVA: 0x00292FB8 File Offset: 0x002911B8
		public MotorGeneralPreview __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x06009A32 RID: 39474 RVA: 0x00292FC8 File Offset: 0x002911C8
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

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x06009A33 RID: 39475 RVA: 0x00293004 File Offset: 0x00291204
		public int Frame
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

		// Token: 0x06009A34 RID: 39476 RVA: 0x00293040 File Offset: 0x00291240
		public int Sticker(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x06009A35 RID: 39477 RVA: 0x00293080 File Offset: 0x00291280
		public int StickerLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009A36 RID: 39478 RVA: 0x002930AB File Offset: 0x002912AB
		public Span<int> GetStickerBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009A37 RID: 39479 RVA: 0x002930BA File Offset: 0x002912BA
		public int[] GetStickerArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009A38 RID: 39480 RVA: 0x002930D4 File Offset: 0x002912D4
		public int Decorations(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x06009A39 RID: 39481 RVA: 0x00293114 File Offset: 0x00291314
		public int DecorationsLength
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

		// Token: 0x06009A3A RID: 39482 RVA: 0x00293140 File Offset: 0x00291340
		public Span<int> GetDecorationsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009A3B RID: 39483 RVA: 0x00293150 File Offset: 0x00291350
		public int[] GetDecorationsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x06009A3C RID: 39484 RVA: 0x00293168 File Offset: 0x00291368
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

		// Token: 0x06009A3D RID: 39485 RVA: 0x002931A0 File Offset: 0x002913A0
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009A3E RID: 39486 RVA: 0x002931B0 File Offset: 0x002913B0
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x06009A3F RID: 39487 RVA: 0x002931C8 File Offset: 0x002913C8
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

		// Token: 0x06009A40 RID: 39488 RVA: 0x00293200 File Offset: 0x00291400
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009A41 RID: 39489 RVA: 0x00293210 File Offset: 0x00291410
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x06009A42 RID: 39490 RVA: 0x00293228 File Offset: 0x00291428
		public bool IsShowIcon
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x06009A43 RID: 39491 RVA: 0x00293268 File Offset: 0x00291468
		public string IconTitle
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

		// Token: 0x06009A44 RID: 39492 RVA: 0x002932A0 File Offset: 0x002914A0
		public Span<byte> GetIconTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009A45 RID: 39493 RVA: 0x002932B0 File Offset: 0x002914B0
		public byte[] GetIconTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x06009A46 RID: 39494 RVA: 0x002932C8 File Offset: 0x002914C8
		public string Describe
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

		// Token: 0x06009A47 RID: 39495 RVA: 0x00293300 File Offset: 0x00291500
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009A48 RID: 39496 RVA: 0x00293310 File Offset: 0x00291510
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x06009A49 RID: 39497 RVA: 0x00293328 File Offset: 0x00291528
		public string CameraId
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

		// Token: 0x06009A4A RID: 39498 RVA: 0x00293360 File Offset: 0x00291560
		public Span<byte> GetCameraIdBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009A4B RID: 39499 RVA: 0x00293370 File Offset: 0x00291570
		public byte[] GetCameraIdArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x06009A4C RID: 39500 RVA: 0x00293388 File Offset: 0x00291588
		public bool IsFree
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x06009A4D RID: 39501 RVA: 0x002933C8 File Offset: 0x002915C8
		public string FreeCamera
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009A4E RID: 39502 RVA: 0x00293400 File Offset: 0x00291600
		public Span<byte> GetFreeCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009A4F RID: 39503 RVA: 0x00293410 File Offset: 0x00291610
		public byte[] GetFreeCameraArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x06009A50 RID: 39504 RVA: 0x00293428 File Offset: 0x00291628
		public string FreeCameraConfig
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009A51 RID: 39505 RVA: 0x00293460 File Offset: 0x00291660
		public Span<byte> GetFreeCameraConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009A52 RID: 39506 RVA: 0x00293470 File Offset: 0x00291670
		public byte[] GetFreeCameraConfigArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x06009A53 RID: 39507 RVA: 0x00293488 File Offset: 0x00291688
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DecorationsIter()或GetDecorationsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Decorations()
		{
			MotorGeneralPreview motorGeneralPreview = this;
			return motorGeneralPreview.GetDecorationsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009A54 RID: 39508 RVA: 0x002934AC File Offset: 0x002916AC
		[NullableContext(1)]
		public readonly IEnumerable<int> DecorationsIter()
		{
			MotorGeneralPreview.<DecorationsIter>d__55 <DecorationsIter>d__ = new MotorGeneralPreview.<DecorationsIter>d__55(-2);
			<DecorationsIter>d__.<>3__<>4__this = this;
			return <DecorationsIter>d__;
		}

		// Token: 0x06009A55 RID: 39509 RVA: 0x002934C4 File Offset: 0x002916C4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StickerIter()或GetStickerBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Sticker()
		{
			MotorGeneralPreview motorGeneralPreview = this;
			return motorGeneralPreview.GetStickerArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009A56 RID: 39510 RVA: 0x002934E8 File Offset: 0x002916E8
		[NullableContext(1)]
		public readonly IEnumerable<int> StickerIter()
		{
			MotorGeneralPreview.<StickerIter>d__57 <StickerIter>d__ = new MotorGeneralPreview.<StickerIter>d__57(-2);
			<StickerIter>d__.<>3__<>4__this = this;
			return <StickerIter>d__;
		}

		// Token: 0x04004EFF RID: 20223
		private Table __p;
	}
}
