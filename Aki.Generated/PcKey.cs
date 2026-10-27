using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB6 RID: 3766
	public struct PcKey : IFlatbufferObject
	{
		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x0600A370 RID: 41840 RVA: 0x002A7594 File Offset: 0x002A5794
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A371 RID: 41841 RVA: 0x002A75A1 File Offset: 0x002A57A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A372 RID: 41842 RVA: 0x002A75A8 File Offset: 0x002A57A8
		public static PcKey GetRootAsPcKey(ByteBuffer _bb)
		{
			return PcKey.GetRootAsPcKey(_bb, default(PcKey));
		}

		// Token: 0x0600A373 RID: 41843 RVA: 0x002A75C4 File Offset: 0x002A57C4
		public static PcKey GetRootAsPcKey(ByteBuffer _bb, PcKey obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A374 RID: 41844 RVA: 0x002A75E1 File Offset: 0x002A57E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A375 RID: 41845 RVA: 0x002A75F0 File Offset: 0x002A57F0
		public PcKey __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x0600A376 RID: 41846 RVA: 0x002A7600 File Offset: 0x002A5800
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

		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x0600A377 RID: 41847 RVA: 0x002A763C File Offset: 0x002A583C
		public string KeyName
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

		// Token: 0x0600A378 RID: 41848 RVA: 0x002A7673 File Offset: 0x002A5873
		public Span<byte> GetKeyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A379 RID: 41849 RVA: 0x002A7682 File Offset: 0x002A5882
		public byte[] GetKeyNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x0600A37A RID: 41850 RVA: 0x002A769C File Offset: 0x002A589C
		public string KeyDescription
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

		// Token: 0x0600A37B RID: 41851 RVA: 0x002A76D3 File Offset: 0x002A58D3
		public Span<byte> GetKeyDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A37C RID: 41852 RVA: 0x002A76E2 File Offset: 0x002A58E2
		public byte[] GetKeyDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x0600A37D RID: 41853 RVA: 0x002A76FC File Offset: 0x002A58FC
		public string KeyDisplayName
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

		// Token: 0x0600A37E RID: 41854 RVA: 0x002A7734 File Offset: 0x002A5934
		public Span<byte> GetKeyDisplayNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A37F RID: 41855 RVA: 0x002A7744 File Offset: 0x002A5944
		public byte[] GetKeyDisplayNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x0600A380 RID: 41856 RVA: 0x002A775C File Offset: 0x002A595C
		public string FrenchKeyName
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

		// Token: 0x0600A381 RID: 41857 RVA: 0x002A7794 File Offset: 0x002A5994
		public Span<byte> GetFrenchKeyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A382 RID: 41858 RVA: 0x002A77A4 File Offset: 0x002A59A4
		public byte[] GetFrenchKeyNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x0600A383 RID: 41859 RVA: 0x002A77BC File Offset: 0x002A59BC
		public string ThaiKeyName
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

		// Token: 0x0600A384 RID: 41860 RVA: 0x002A77F4 File Offset: 0x002A59F4
		public Span<byte> GetThaiKeyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A385 RID: 41861 RVA: 0x002A7804 File Offset: 0x002A5A04
		public byte[] GetThaiKeyNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x0600A386 RID: 41862 RVA: 0x002A781C File Offset: 0x002A5A1C
		public string KeyIconPath
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

		// Token: 0x0600A387 RID: 41863 RVA: 0x002A7854 File Offset: 0x002A5A54
		public Span<byte> GetKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A388 RID: 41864 RVA: 0x002A7864 File Offset: 0x002A5A64
		public byte[] GetKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x0600A389 RID: 41865 RVA: 0x002A787C File Offset: 0x002A5A7C
		public string MacKeyIconPath
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

		// Token: 0x0600A38A RID: 41866 RVA: 0x002A78B4 File Offset: 0x002A5AB4
		public Span<byte> GetMacKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A38B RID: 41867 RVA: 0x002A78C4 File Offset: 0x002A5AC4
		public byte[] GetMacKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x0600A38C RID: 41868 RVA: 0x002A78DC File Offset: 0x002A5ADC
		public string FrenchKeyIconPath
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

		// Token: 0x0600A38D RID: 41869 RVA: 0x002A7914 File Offset: 0x002A5B14
		public Span<byte> GetFrenchKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A38E RID: 41870 RVA: 0x002A7924 File Offset: 0x002A5B24
		public byte[] GetFrenchKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x0600A38F RID: 41871 RVA: 0x002A793C File Offset: 0x002A5B3C
		public string ThaiKeyIconPath
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

		// Token: 0x0600A390 RID: 41872 RVA: 0x002A7974 File Offset: 0x002A5B74
		public Span<byte> GetThaiKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A391 RID: 41873 RVA: 0x002A7984 File Offset: 0x002A5B84
		public byte[] GetThaiKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F6C RID: 20332
		private Table __p;
	}
}
