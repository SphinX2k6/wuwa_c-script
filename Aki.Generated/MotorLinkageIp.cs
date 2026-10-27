using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E59 RID: 3673
	public struct MotorLinkageIp : IFlatbufferObject
	{
		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x06009A7F RID: 39551 RVA: 0x002939D9 File Offset: 0x00291BD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x002939E6 File Offset: 0x00291BE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A81 RID: 39553 RVA: 0x002939F0 File Offset: 0x00291BF0
		public static MotorLinkageIp GetRootAsMotorLinkageIp(ByteBuffer _bb)
		{
			return MotorLinkageIp.GetRootAsMotorLinkageIp(_bb, default(MotorLinkageIp));
		}

		// Token: 0x06009A82 RID: 39554 RVA: 0x00293A0C File Offset: 0x00291C0C
		public static MotorLinkageIp GetRootAsMotorLinkageIp(ByteBuffer _bb, MotorLinkageIp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009A83 RID: 39555 RVA: 0x00293A29 File Offset: 0x00291C29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009A84 RID: 39556 RVA: 0x00293A38 File Offset: 0x00291C38
		public MotorLinkageIp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x06009A85 RID: 39557 RVA: 0x00293A48 File Offset: 0x00291C48
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

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06009A86 RID: 39558 RVA: 0x00293A84 File Offset: 0x00291C84
		public int Sort
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

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x06009A87 RID: 39559 RVA: 0x00293AC0 File Offset: 0x00291CC0
		public string IpName
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

		// Token: 0x06009A88 RID: 39560 RVA: 0x00293AF7 File Offset: 0x00291CF7
		public Span<byte> GetIpNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009A89 RID: 39561 RVA: 0x00293B06 File Offset: 0x00291D06
		public byte[] GetIpNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06009A8A RID: 39562 RVA: 0x00293B20 File Offset: 0x00291D20
		public int IpStickerList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x06009A8B RID: 39563 RVA: 0x00293B60 File Offset: 0x00291D60
		public int IpStickerListLength
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

		// Token: 0x06009A8C RID: 39564 RVA: 0x00293B8C File Offset: 0x00291D8C
		public Span<int> GetIpStickerListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009A8D RID: 39565 RVA: 0x00293B9C File Offset: 0x00291D9C
		public int[] GetIpStickerListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x06009A8E RID: 39566 RVA: 0x00293BB4 File Offset: 0x00291DB4
		public string BackgroundPath
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

		// Token: 0x06009A8F RID: 39567 RVA: 0x00293BEC File Offset: 0x00291DEC
		public Span<byte> GetBackgroundPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009A90 RID: 39568 RVA: 0x00293BFC File Offset: 0x00291DFC
		public byte[] GetBackgroundPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x06009A91 RID: 39569 RVA: 0x00293C14 File Offset: 0x00291E14
		public string StickerIcon
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

		// Token: 0x06009A92 RID: 39570 RVA: 0x00293C4C File Offset: 0x00291E4C
		public Span<byte> GetStickerIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009A93 RID: 39571 RVA: 0x00293C5C File Offset: 0x00291E5C
		public byte[] GetStickerIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x06009A94 RID: 39572 RVA: 0x00293C74 File Offset: 0x00291E74
		public string Background
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

		// Token: 0x06009A95 RID: 39573 RVA: 0x00293CAC File Offset: 0x00291EAC
		public Span<byte> GetBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009A96 RID: 39574 RVA: 0x00293CBC File Offset: 0x00291EBC
		public byte[] GetBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x06009A97 RID: 39575 RVA: 0x00293CD4 File Offset: 0x00291ED4
		public string LinkageImage
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

		// Token: 0x06009A98 RID: 39576 RVA: 0x00293D0C File Offset: 0x00291F0C
		public Span<byte> GetLinkageImageBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009A99 RID: 39577 RVA: 0x00293D1C File Offset: 0x00291F1C
		public byte[] GetLinkageImageArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06009A9A RID: 39578 RVA: 0x00293D34 File Offset: 0x00291F34
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IpStickerListIter()或GetIpStickerListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] IpStickerList()
		{
			MotorLinkageIp motorLinkageIp = this;
			return motorLinkageIp.GetIpStickerListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009A9B RID: 39579 RVA: 0x00293D58 File Offset: 0x00291F58
		[NullableContext(1)]
		public readonly IEnumerable<int> IpStickerListIter()
		{
			MotorLinkageIp.<IpStickerListIter>d__38 <IpStickerListIter>d__ = new MotorLinkageIp.<IpStickerListIter>d__38(-2);
			<IpStickerListIter>d__.<>3__<>4__this = this;
			return <IpStickerListIter>d__;
		}

		// Token: 0x04004F02 RID: 20226
		private Table __p;
	}
}
