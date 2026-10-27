using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C18 RID: 3096
	public struct EasterEggConfig : IFlatbufferObject
	{
		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x060066EC RID: 26348 RVA: 0x0021EAA9 File Offset: 0x0021CCA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x0021EAB6 File Offset: 0x0021CCB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060066EE RID: 26350 RVA: 0x0021EAC0 File Offset: 0x0021CCC0
		public static EasterEggConfig GetRootAsEasterEggConfig(ByteBuffer _bb)
		{
			return EasterEggConfig.GetRootAsEasterEggConfig(_bb, default(EasterEggConfig));
		}

		// Token: 0x060066EF RID: 26351 RVA: 0x0021EADC File Offset: 0x0021CCDC
		public static EasterEggConfig GetRootAsEasterEggConfig(ByteBuffer _bb, EasterEggConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060066F0 RID: 26352 RVA: 0x0021EAF9 File Offset: 0x0021CCF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060066F1 RID: 26353 RVA: 0x0021EB08 File Offset: 0x0021CD08
		public EasterEggConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x060066F2 RID: 26354 RVA: 0x0021EB18 File Offset: 0x0021CD18
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

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x060066F3 RID: 26355 RVA: 0x0021EB54 File Offset: 0x0021CD54
		public string Description
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

		// Token: 0x060066F4 RID: 26356 RVA: 0x0021EB8B File Offset: 0x0021CD8B
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x0021EB9A File Offset: 0x0021CD9A
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C58 RID: 19544
		private Table __p;
	}
}
