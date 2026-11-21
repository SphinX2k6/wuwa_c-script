using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD7 RID: 3031
	public struct AnimalStandbyMontage : IFlatbufferObject
	{
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06004D33 RID: 19763 RVA: 0x001F5B78 File Offset: 0x001F3D78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x001F5B85 File Offset: 0x001F3D85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x001F5B8C File Offset: 0x001F3D8C
		public static AnimalStandbyMontage GetRootAsAnimalStandbyMontage(ByteBuffer _bb)
		{
			return AnimalStandbyMontage.GetRootAsAnimalStandbyMontage(_bb, default(AnimalStandbyMontage));
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x001F5BA8 File Offset: 0x001F3DA8
		public static AnimalStandbyMontage GetRootAsAnimalStandbyMontage(ByteBuffer _bb, AnimalStandbyMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x001F5BC5 File Offset: 0x001F3DC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x001F5BD4 File Offset: 0x001F3DD4
		public AnimalStandbyMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06004D39 RID: 19769 RVA: 0x001F5BE4 File Offset: 0x001F3DE4
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

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06004D3A RID: 19770 RVA: 0x001F5C20 File Offset: 0x001F3E20
		public string Bp
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

		// Token: 0x06004D3B RID: 19771 RVA: 0x001F5C57 File Offset: 0x001F3E57
		public Span<byte> GetBpBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x001F5C66 File Offset: 0x001F3E66
		public byte[] GetBpArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06004D3D RID: 19773 RVA: 0x001F5C80 File Offset: 0x001F3E80
		public string ClassName
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

		// Token: 0x06004D3E RID: 19774 RVA: 0x001F5CB7 File Offset: 0x001F3EB7
		public Span<byte> GetClassNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x001F5CC6 File Offset: 0x001F3EC6
		public byte[] GetClassNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06004D40 RID: 19776 RVA: 0x001F5CE0 File Offset: 0x001F3EE0
		public string Tag
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

		// Token: 0x06004D41 RID: 19777 RVA: 0x001F5D18 File Offset: 0x001F3F18
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x001F5D28 File Offset: 0x001F3F28
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06004D43 RID: 19779 RVA: 0x001F5D40 File Offset: 0x001F3F40
		public string MontageStart
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

		// Token: 0x06004D44 RID: 19780 RVA: 0x001F5D78 File Offset: 0x001F3F78
		public Span<byte> GetMontageStartBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x001F5D88 File Offset: 0x001F3F88
		public byte[] GetMontageStartArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06004D46 RID: 19782 RVA: 0x001F5DA0 File Offset: 0x001F3FA0
		public string MontageLoop
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

		// Token: 0x06004D47 RID: 19783 RVA: 0x001F5DD8 File Offset: 0x001F3FD8
		public Span<byte> GetMontageLoopBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x001F5DE8 File Offset: 0x001F3FE8
		public byte[] GetMontageLoopArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06004D49 RID: 19785 RVA: 0x001F5E00 File Offset: 0x001F4000
		public string MontageEnd
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

		// Token: 0x06004D4A RID: 19786 RVA: 0x001F5E38 File Offset: 0x001F4038
		public Span<byte> GetMontageEndBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x001F5E48 File Offset: 0x001F4048
		public byte[] GetMontageEndArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x001F5E60 File Offset: 0x001F4060
		public string MontageBranch1
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

		// Token: 0x06004D4D RID: 19789 RVA: 0x001F5E98 File Offset: 0x001F4098
		public Span<byte> GetMontageBranch1Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x001F5EA8 File Offset: 0x001F40A8
		public byte[] GetMontageBranch1Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06004D4F RID: 19791 RVA: 0x001F5EC0 File Offset: 0x001F40C0
		public string MontageBranch2
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

		// Token: 0x06004D50 RID: 19792 RVA: 0x001F5EF8 File Offset: 0x001F40F8
		public Span<byte> GetMontageBranch2Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x001F5F08 File Offset: 0x001F4108
		public byte[] GetMontageBranch2Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06004D52 RID: 19794 RVA: 0x001F5F20 File Offset: 0x001F4120
		public string MontageBranch3
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

		// Token: 0x06004D53 RID: 19795 RVA: 0x001F5F58 File Offset: 0x001F4158
		public Span<byte> GetMontageBranch3Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x001F5F68 File Offset: 0x001F4168
		public byte[] GetMontageBranch3Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06004D55 RID: 19797 RVA: 0x001F5F80 File Offset: 0x001F4180
		public string MontageBranch4
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x001F5FB8 File Offset: 0x001F41B8
		public Span<byte> GetMontageBranch4Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x001F5FC8 File Offset: 0x001F41C8
		public byte[] GetMontageBranch4Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x040050B8 RID: 20664
		private Table __p;
	}
}
