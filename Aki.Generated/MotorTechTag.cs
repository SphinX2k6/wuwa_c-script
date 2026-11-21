using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F54 RID: 3924
	public struct MotorTechTag : IFlatbufferObject
	{
		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x0600A2EC RID: 41708 RVA: 0x002B64FD File Offset: 0x002B46FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A2ED RID: 41709 RVA: 0x002B650A File Offset: 0x002B470A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A2EE RID: 41710 RVA: 0x002B6514 File Offset: 0x002B4714
		public static MotorTechTag GetRootAsMotorTechTag(ByteBuffer _bb)
		{
			return MotorTechTag.GetRootAsMotorTechTag(_bb, default(MotorTechTag));
		}

		// Token: 0x0600A2EF RID: 41711 RVA: 0x002B6530 File Offset: 0x002B4730
		public static MotorTechTag GetRootAsMotorTechTag(ByteBuffer _bb, MotorTechTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A2F0 RID: 41712 RVA: 0x002B654D File Offset: 0x002B474D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A2F1 RID: 41713 RVA: 0x002B655C File Offset: 0x002B475C
		public MotorTechTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x0600A2F2 RID: 41714 RVA: 0x002B656C File Offset: 0x002B476C
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

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x0600A2F3 RID: 41715 RVA: 0x002B65A8 File Offset: 0x002B47A8
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

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x002B65DF File Offset: 0x002B47DF
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A2F5 RID: 41717 RVA: 0x002B65EE File Offset: 0x002B47EE
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x0600A2F6 RID: 41718 RVA: 0x002B6608 File Offset: 0x002B4808
		public string Name
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

		// Token: 0x0600A2F7 RID: 41719 RVA: 0x002B663F File Offset: 0x002B483F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A2F8 RID: 41720 RVA: 0x002B664E File Offset: 0x002B484E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x0600A2F9 RID: 41721 RVA: 0x002B6668 File Offset: 0x002B4868
		public string Bg
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

		// Token: 0x0600A2FA RID: 41722 RVA: 0x002B66A0 File Offset: 0x002B48A0
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A2FB RID: 41723 RVA: 0x002B66B0 File Offset: 0x002B48B0
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x0600A2FC RID: 41724 RVA: 0x002B66C8 File Offset: 0x002B48C8
		public string BgColor
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

		// Token: 0x0600A2FD RID: 41725 RVA: 0x002B6700 File Offset: 0x002B4900
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A2FE RID: 41726 RVA: 0x002B6710 File Offset: 0x002B4910
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x0600A2FF RID: 41727 RVA: 0x002B6728 File Offset: 0x002B4928
		public string NameColor
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

		// Token: 0x0600A300 RID: 41728 RVA: 0x002B6760 File Offset: 0x002B4960
		public Span<byte> GetNameColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A301 RID: 41729 RVA: 0x002B6770 File Offset: 0x002B4970
		public byte[] GetNameColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005502 RID: 21762
		private Table __p;
	}
}
