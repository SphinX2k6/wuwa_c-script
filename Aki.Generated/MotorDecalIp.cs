using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F16 RID: 3862
	public struct MotorDecalIp : IFlatbufferObject
	{
		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x06009D03 RID: 40195 RVA: 0x002A933D File Offset: 0x002A753D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009D04 RID: 40196 RVA: 0x002A934A File Offset: 0x002A754A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009D05 RID: 40197 RVA: 0x002A9354 File Offset: 0x002A7554
		public static MotorDecalIp GetRootAsMotorDecalIp(ByteBuffer _bb)
		{
			return MotorDecalIp.GetRootAsMotorDecalIp(_bb, default(MotorDecalIp));
		}

		// Token: 0x06009D06 RID: 40198 RVA: 0x002A9370 File Offset: 0x002A7570
		public static MotorDecalIp GetRootAsMotorDecalIp(ByteBuffer _bb, MotorDecalIp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009D07 RID: 40199 RVA: 0x002A938D File Offset: 0x002A758D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009D08 RID: 40200 RVA: 0x002A939C File Offset: 0x002A759C
		public MotorDecalIp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x06009D09 RID: 40201 RVA: 0x002A93AC File Offset: 0x002A75AC
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

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x06009D0A RID: 40202 RVA: 0x002A93E8 File Offset: 0x002A75E8
		public int ActivityId
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

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x06009D0B RID: 40203 RVA: 0x002A9424 File Offset: 0x002A7624
		public int Sort
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

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06009D0C RID: 40204 RVA: 0x002A9460 File Offset: 0x002A7660
		public string IpNamePath
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

		// Token: 0x06009D0D RID: 40205 RVA: 0x002A9498 File Offset: 0x002A7698
		public Span<byte> GetIpNamePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009D0E RID: 40206 RVA: 0x002A94A8 File Offset: 0x002A76A8
		public byte[] GetIpNamePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06009D0F RID: 40207 RVA: 0x002A94C0 File Offset: 0x002A76C0
		public string IpNamePathCN
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

		// Token: 0x06009D10 RID: 40208 RVA: 0x002A94F8 File Offset: 0x002A76F8
		public Span<byte> GetIpNamePathCNBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009D11 RID: 40209 RVA: 0x002A9508 File Offset: 0x002A7708
		public byte[] GetIpNamePathCNArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06009D12 RID: 40210 RVA: 0x002A9520 File Offset: 0x002A7720
		public int IpStickerList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x06009D13 RID: 40211 RVA: 0x002A9560 File Offset: 0x002A7760
		public int IpStickerListLength
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

		// Token: 0x06009D14 RID: 40212 RVA: 0x002A958C File Offset: 0x002A778C
		public Span<int> GetIpStickerListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06009D15 RID: 40213 RVA: 0x002A959C File Offset: 0x002A779C
		public int[] GetIpStickerListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x06009D16 RID: 40214 RVA: 0x002A95B4 File Offset: 0x002A77B4
		public string BackgroundPath
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

		// Token: 0x06009D17 RID: 40215 RVA: 0x002A95EC File Offset: 0x002A77EC
		public Span<byte> GetBackgroundPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009D18 RID: 40216 RVA: 0x002A95FC File Offset: 0x002A77FC
		public byte[] GetBackgroundPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06009D19 RID: 40217 RVA: 0x002A9614 File Offset: 0x002A7814
		[NullableContext(1)]
		public int[] IpStickerList()
		{
			return this.GetIpStickerListArray();
		}

		// Token: 0x06009D1A RID: 40218 RVA: 0x002A961C File Offset: 0x002A781C
		[NullableContext(1)]
		public IEnumerable<int> IpStickerListIter()
		{
			MotorDecalIp.<IpStickerListIter>d__32 <IpStickerListIter>d__ = new MotorDecalIp.<IpStickerListIter>d__32(-2);
			<IpStickerListIter>d__.<>3__<>4__this = this;
			return <IpStickerListIter>d__;
		}

		// Token: 0x040054BB RID: 21691
		private Table __p;
	}
}
