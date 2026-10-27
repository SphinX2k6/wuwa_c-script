using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AFD RID: 2813
	public struct AnimalStandbyMontage : IFlatbufferObject
	{
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060047EC RID: 18412 RVA: 0x001D62ED File Offset: 0x001D44ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x001D62FA File Offset: 0x001D44FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x001D6304 File Offset: 0x001D4504
		public static AnimalStandbyMontage GetRootAsAnimalStandbyMontage(ByteBuffer _bb)
		{
			return AnimalStandbyMontage.GetRootAsAnimalStandbyMontage(_bb, default(AnimalStandbyMontage));
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x001D6320 File Offset: 0x001D4520
		public static AnimalStandbyMontage GetRootAsAnimalStandbyMontage(ByteBuffer _bb, AnimalStandbyMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x001D633D File Offset: 0x001D453D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x001D634C File Offset: 0x001D454C
		public AnimalStandbyMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060047F2 RID: 18418 RVA: 0x001D635C File Offset: 0x001D455C
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

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060047F3 RID: 18419 RVA: 0x001D6398 File Offset: 0x001D4598
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

		// Token: 0x060047F4 RID: 18420 RVA: 0x001D63CF File Offset: 0x001D45CF
		public Span<byte> GetBpBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x001D63DE File Offset: 0x001D45DE
		public byte[] GetBpArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060047F6 RID: 18422 RVA: 0x001D63F8 File Offset: 0x001D45F8
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

		// Token: 0x060047F7 RID: 18423 RVA: 0x001D642F File Offset: 0x001D462F
		public Span<byte> GetClassNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x001D643E File Offset: 0x001D463E
		public byte[] GetClassNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060047F9 RID: 18425 RVA: 0x001D6458 File Offset: 0x001D4658
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

		// Token: 0x060047FA RID: 18426 RVA: 0x001D6490 File Offset: 0x001D4690
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x001D64A0 File Offset: 0x001D46A0
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060047FC RID: 18428 RVA: 0x001D64B8 File Offset: 0x001D46B8
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

		// Token: 0x060047FD RID: 18429 RVA: 0x001D64F0 File Offset: 0x001D46F0
		public Span<byte> GetMontageStartBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x001D6500 File Offset: 0x001D4700
		public byte[] GetMontageStartArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060047FF RID: 18431 RVA: 0x001D6518 File Offset: 0x001D4718
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

		// Token: 0x06004800 RID: 18432 RVA: 0x001D6550 File Offset: 0x001D4750
		public Span<byte> GetMontageLoopBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x001D6560 File Offset: 0x001D4760
		public byte[] GetMontageLoopArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06004802 RID: 18434 RVA: 0x001D6578 File Offset: 0x001D4778
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

		// Token: 0x06004803 RID: 18435 RVA: 0x001D65B0 File Offset: 0x001D47B0
		public Span<byte> GetMontageEndBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x001D65C0 File Offset: 0x001D47C0
		public byte[] GetMontageEndArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x001D65D8 File Offset: 0x001D47D8
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

		// Token: 0x06004806 RID: 18438 RVA: 0x001D6610 File Offset: 0x001D4810
		public Span<byte> GetMontageBranch1Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x001D6620 File Offset: 0x001D4820
		public byte[] GetMontageBranch1Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06004808 RID: 18440 RVA: 0x001D6638 File Offset: 0x001D4838
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

		// Token: 0x06004809 RID: 18441 RVA: 0x001D6670 File Offset: 0x001D4870
		public Span<byte> GetMontageBranch2Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600480A RID: 18442 RVA: 0x001D6680 File Offset: 0x001D4880
		public byte[] GetMontageBranch2Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x001D6698 File Offset: 0x001D4898
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

		// Token: 0x0600480C RID: 18444 RVA: 0x001D66D0 File Offset: 0x001D48D0
		public Span<byte> GetMontageBranch3Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x001D66E0 File Offset: 0x001D48E0
		public byte[] GetMontageBranch3Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600480E RID: 18446 RVA: 0x001D66F8 File Offset: 0x001D48F8
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

		// Token: 0x0600480F RID: 18447 RVA: 0x001D6730 File Offset: 0x001D4930
		public Span<byte> GetMontageBranch4Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004810 RID: 18448 RVA: 0x001D6740 File Offset: 0x001D4940
		public byte[] GetMontageBranch4Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04004ADE RID: 19166
		private Table __p;
	}
}
