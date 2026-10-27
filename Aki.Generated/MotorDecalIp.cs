using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E31 RID: 3633
	public struct MotorDecalIp : IFlatbufferObject
	{
		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x060096E3 RID: 38627 RVA: 0x0028B665 File Offset: 0x00289865
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060096E4 RID: 38628 RVA: 0x0028B672 File Offset: 0x00289872
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060096E5 RID: 38629 RVA: 0x0028B67C File Offset: 0x0028987C
		public static MotorDecalIp GetRootAsMotorDecalIp(ByteBuffer _bb)
		{
			return MotorDecalIp.GetRootAsMotorDecalIp(_bb, default(MotorDecalIp));
		}

		// Token: 0x060096E6 RID: 38630 RVA: 0x0028B698 File Offset: 0x00289898
		public static MotorDecalIp GetRootAsMotorDecalIp(ByteBuffer _bb, MotorDecalIp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060096E7 RID: 38631 RVA: 0x0028B6B5 File Offset: 0x002898B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060096E8 RID: 38632 RVA: 0x0028B6C4 File Offset: 0x002898C4
		public MotorDecalIp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x060096E9 RID: 38633 RVA: 0x0028B6D4 File Offset: 0x002898D4
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

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x060096EA RID: 38634 RVA: 0x0028B710 File Offset: 0x00289910
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

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x060096EB RID: 38635 RVA: 0x0028B74C File Offset: 0x0028994C
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

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x060096EC RID: 38636 RVA: 0x0028B788 File Offset: 0x00289988
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

		// Token: 0x060096ED RID: 38637 RVA: 0x0028B7C0 File Offset: 0x002899C0
		public Span<byte> GetIpNamePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060096EE RID: 38638 RVA: 0x0028B7D0 File Offset: 0x002899D0
		public byte[] GetIpNamePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x060096EF RID: 38639 RVA: 0x0028B7E8 File Offset: 0x002899E8
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

		// Token: 0x060096F0 RID: 38640 RVA: 0x0028B820 File Offset: 0x00289A20
		public Span<byte> GetIpNamePathCNBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060096F1 RID: 38641 RVA: 0x0028B830 File Offset: 0x00289A30
		public byte[] GetIpNamePathCNArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x060096F2 RID: 38642 RVA: 0x0028B848 File Offset: 0x00289A48
		public int IpStickerList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x060096F3 RID: 38643 RVA: 0x0028B888 File Offset: 0x00289A88
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

		// Token: 0x060096F4 RID: 38644 RVA: 0x0028B8B4 File Offset: 0x00289AB4
		public Span<int> GetIpStickerListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060096F5 RID: 38645 RVA: 0x0028B8C4 File Offset: 0x00289AC4
		public int[] GetIpStickerListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x060096F6 RID: 38646 RVA: 0x0028B8DC File Offset: 0x00289ADC
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

		// Token: 0x060096F7 RID: 38647 RVA: 0x0028B914 File Offset: 0x00289B14
		public Span<byte> GetBackgroundPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060096F8 RID: 38648 RVA: 0x0028B924 File Offset: 0x00289B24
		public byte[] GetBackgroundPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060096F9 RID: 38649 RVA: 0x0028B93C File Offset: 0x00289B3C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IpStickerListIter()或GetIpStickerListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] IpStickerList()
		{
			MotorDecalIp motorDecalIp = this;
			return motorDecalIp.GetIpStickerListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060096FA RID: 38650 RVA: 0x0028B960 File Offset: 0x00289B60
		[NullableContext(1)]
		public readonly IEnumerable<int> IpStickerListIter()
		{
			MotorDecalIp.<IpStickerListIter>d__32 <IpStickerListIter>d__ = new MotorDecalIp.<IpStickerListIter>d__32(-2);
			<IpStickerListIter>d__.<>3__<>4__this = this;
			return <IpStickerListIter>d__;
		}

		// Token: 0x04004ED6 RID: 20182
		private Table __p;
	}
}
