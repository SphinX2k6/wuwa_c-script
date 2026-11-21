using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F3E RID: 3902
	public struct MotorLinkageIp : IFlatbufferObject
	{
		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x0600A09F RID: 41119 RVA: 0x002B13FD File Offset: 0x002AF5FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A0A0 RID: 41120 RVA: 0x002B140A File Offset: 0x002AF60A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A0A1 RID: 41121 RVA: 0x002B1414 File Offset: 0x002AF614
		public static MotorLinkageIp GetRootAsMotorLinkageIp(ByteBuffer _bb)
		{
			return MotorLinkageIp.GetRootAsMotorLinkageIp(_bb, default(MotorLinkageIp));
		}

		// Token: 0x0600A0A2 RID: 41122 RVA: 0x002B1430 File Offset: 0x002AF630
		public static MotorLinkageIp GetRootAsMotorLinkageIp(ByteBuffer _bb, MotorLinkageIp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A0A3 RID: 41123 RVA: 0x002B144D File Offset: 0x002AF64D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A0A4 RID: 41124 RVA: 0x002B145C File Offset: 0x002AF65C
		public MotorLinkageIp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x0600A0A5 RID: 41125 RVA: 0x002B146C File Offset: 0x002AF66C
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

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x0600A0A6 RID: 41126 RVA: 0x002B14A8 File Offset: 0x002AF6A8
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

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x0600A0A7 RID: 41127 RVA: 0x002B14E4 File Offset: 0x002AF6E4
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

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x002B151B File Offset: 0x002AF71B
		public Span<byte> GetIpNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x002B152A File Offset: 0x002AF72A
		public byte[] GetIpNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x002B1544 File Offset: 0x002AF744
		public int IpStickerList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x0600A0AB RID: 41131 RVA: 0x002B1584 File Offset: 0x002AF784
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

		// Token: 0x0600A0AC RID: 41132 RVA: 0x002B15B0 File Offset: 0x002AF7B0
		public Span<int> GetIpStickerListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x002B15C0 File Offset: 0x002AF7C0
		public int[] GetIpStickerListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x0600A0AE RID: 41134 RVA: 0x002B15D8 File Offset: 0x002AF7D8
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

		// Token: 0x0600A0AF RID: 41135 RVA: 0x002B1610 File Offset: 0x002AF810
		public Span<byte> GetBackgroundPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A0B0 RID: 41136 RVA: 0x002B1620 File Offset: 0x002AF820
		public byte[] GetBackgroundPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x0600A0B1 RID: 41137 RVA: 0x002B1638 File Offset: 0x002AF838
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

		// Token: 0x0600A0B2 RID: 41138 RVA: 0x002B1670 File Offset: 0x002AF870
		public Span<byte> GetStickerIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A0B3 RID: 41139 RVA: 0x002B1680 File Offset: 0x002AF880
		public byte[] GetStickerIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x0600A0B4 RID: 41140 RVA: 0x002B1698 File Offset: 0x002AF898
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

		// Token: 0x0600A0B5 RID: 41141 RVA: 0x002B16D0 File Offset: 0x002AF8D0
		public Span<byte> GetBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x002B16E0 File Offset: 0x002AF8E0
		public byte[] GetBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x0600A0B7 RID: 41143 RVA: 0x002B16F8 File Offset: 0x002AF8F8
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

		// Token: 0x0600A0B8 RID: 41144 RVA: 0x002B1730 File Offset: 0x002AF930
		public Span<byte> GetLinkageImageBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A0B9 RID: 41145 RVA: 0x002B1740 File Offset: 0x002AF940
		public byte[] GetLinkageImageArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A0BA RID: 41146 RVA: 0x002B1758 File Offset: 0x002AF958
		[NullableContext(1)]
		public int[] IpStickerList()
		{
			return this.GetIpStickerListArray();
		}

		// Token: 0x0600A0BB RID: 41147 RVA: 0x002B1760 File Offset: 0x002AF960
		[NullableContext(1)]
		public IEnumerable<int> IpStickerListIter()
		{
			MotorLinkageIp.<IpStickerListIter>d__38 <IpStickerListIter>d__ = new MotorLinkageIp.<IpStickerListIter>d__38(-2);
			<IpStickerListIter>d__.<>3__<>4__this = this;
			return <IpStickerListIter>d__;
		}

		// Token: 0x040054E7 RID: 21735
		private Table __p;
	}
}
