using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E6F RID: 3695
	public struct MotorTechTag : IFlatbufferObject
	{
		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x06009CCC RID: 40140 RVA: 0x00298CA1 File Offset: 0x00296EA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009CCD RID: 40141 RVA: 0x00298CAE File Offset: 0x00296EAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009CCE RID: 40142 RVA: 0x00298CB8 File Offset: 0x00296EB8
		public static MotorTechTag GetRootAsMotorTechTag(ByteBuffer _bb)
		{
			return MotorTechTag.GetRootAsMotorTechTag(_bb, default(MotorTechTag));
		}

		// Token: 0x06009CCF RID: 40143 RVA: 0x00298CD4 File Offset: 0x00296ED4
		public static MotorTechTag GetRootAsMotorTechTag(ByteBuffer _bb, MotorTechTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009CD0 RID: 40144 RVA: 0x00298CF1 File Offset: 0x00296EF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009CD1 RID: 40145 RVA: 0x00298D00 File Offset: 0x00296F00
		public MotorTechTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x06009CD2 RID: 40146 RVA: 0x00298D10 File Offset: 0x00296F10
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

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x06009CD3 RID: 40147 RVA: 0x00298D4C File Offset: 0x00296F4C
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

		// Token: 0x06009CD4 RID: 40148 RVA: 0x00298D83 File Offset: 0x00296F83
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009CD5 RID: 40149 RVA: 0x00298D92 File Offset: 0x00296F92
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x06009CD6 RID: 40150 RVA: 0x00298DAC File Offset: 0x00296FAC
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

		// Token: 0x06009CD7 RID: 40151 RVA: 0x00298DE3 File Offset: 0x00296FE3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009CD8 RID: 40152 RVA: 0x00298DF2 File Offset: 0x00296FF2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x06009CD9 RID: 40153 RVA: 0x00298E0C File Offset: 0x0029700C
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

		// Token: 0x06009CDA RID: 40154 RVA: 0x00298E44 File Offset: 0x00297044
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009CDB RID: 40155 RVA: 0x00298E54 File Offset: 0x00297054
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x06009CDC RID: 40156 RVA: 0x00298E6C File Offset: 0x0029706C
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

		// Token: 0x06009CDD RID: 40157 RVA: 0x00298EA4 File Offset: 0x002970A4
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009CDE RID: 40158 RVA: 0x00298EB4 File Offset: 0x002970B4
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x06009CDF RID: 40159 RVA: 0x00298ECC File Offset: 0x002970CC
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

		// Token: 0x06009CE0 RID: 40160 RVA: 0x00298F04 File Offset: 0x00297104
		public Span<byte> GetNameColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009CE1 RID: 40161 RVA: 0x00298F14 File Offset: 0x00297114
		public byte[] GetNameColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F1D RID: 20253
		private Table __p;
	}
}
