using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD7 RID: 3543
	public struct GenderText : IFlatbufferObject
	{
		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06007FD9 RID: 32729 RVA: 0x00268606 File Offset: 0x00266806
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007FDA RID: 32730 RVA: 0x00268613 File Offset: 0x00266813
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007FDB RID: 32731 RVA: 0x0026861C File Offset: 0x0026681C
		public static GenderText GetRootAsGenderText(ByteBuffer _bb)
		{
			return GenderText.GetRootAsGenderText(_bb, default(GenderText));
		}

		// Token: 0x06007FDC RID: 32732 RVA: 0x00268638 File Offset: 0x00266838
		public static GenderText GetRootAsGenderText(ByteBuffer _bb, GenderText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007FDD RID: 32733 RVA: 0x00268655 File Offset: 0x00266855
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x00268664 File Offset: 0x00266864
		public GenderText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06007FDF RID: 32735 RVA: 0x00268674 File Offset: 0x00266874
		public string MaleText
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x002686AB File Offset: 0x002668AB
		public Span<byte> GetMaleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x002686BA File Offset: 0x002668BA
		public byte[] GetMaleTextArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06007FE2 RID: 32738 RVA: 0x002686D4 File Offset: 0x002668D4
		public string FemaleText
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

		// Token: 0x06007FE3 RID: 32739 RVA: 0x0026870B File Offset: 0x0026690B
		public Span<byte> GetFemaleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007FE4 RID: 32740 RVA: 0x0026871A File Offset: 0x0026691A
		public byte[] GetFemaleTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400534A RID: 21322
		private Table __p;
	}
}
