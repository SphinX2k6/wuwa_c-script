using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC8 RID: 3784
	public struct PhantomBattleCardSlotSort : IFlatbufferObject
	{
		// Token: 0x170025E1 RID: 9697
		// (get) Token: 0x0600A62D RID: 42541 RVA: 0x002ADC43 File Offset: 0x002ABE43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A62E RID: 42542 RVA: 0x002ADC50 File Offset: 0x002ABE50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A62F RID: 42543 RVA: 0x002ADC58 File Offset: 0x002ABE58
		public static PhantomBattleCardSlotSort GetRootAsPhantomBattleCardSlotSort(ByteBuffer _bb)
		{
			return PhantomBattleCardSlotSort.GetRootAsPhantomBattleCardSlotSort(_bb, default(PhantomBattleCardSlotSort));
		}

		// Token: 0x0600A630 RID: 42544 RVA: 0x002ADC74 File Offset: 0x002ABE74
		public static PhantomBattleCardSlotSort GetRootAsPhantomBattleCardSlotSort(ByteBuffer _bb, PhantomBattleCardSlotSort obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A631 RID: 42545 RVA: 0x002ADC91 File Offset: 0x002ABE91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A632 RID: 42546 RVA: 0x002ADCA0 File Offset: 0x002ABEA0
		public PhantomBattleCardSlotSort __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025E2 RID: 9698
		// (get) Token: 0x0600A633 RID: 42547 RVA: 0x002ADCB0 File Offset: 0x002ABEB0
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

		// Token: 0x170025E3 RID: 9699
		// (get) Token: 0x0600A634 RID: 42548 RVA: 0x002ADCEC File Offset: 0x002ABEEC
		public string Name
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

		// Token: 0x0600A635 RID: 42549 RVA: 0x002ADD23 File Offset: 0x002ABF23
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A636 RID: 42550 RVA: 0x002ADD32 File Offset: 0x002ABF32
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F84 RID: 20356
		private Table __p;
	}
}
