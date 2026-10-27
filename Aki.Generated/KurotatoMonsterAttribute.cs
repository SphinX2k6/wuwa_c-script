using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA9 RID: 3497
	public struct KurotatoMonsterAttribute : IFlatbufferObject
	{
		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06008AC7 RID: 35527 RVA: 0x00270AAD File Offset: 0x0026ECAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008AC8 RID: 35528 RVA: 0x00270ABA File Offset: 0x0026ECBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008AC9 RID: 35529 RVA: 0x00270AC4 File Offset: 0x0026ECC4
		public static KurotatoMonsterAttribute GetRootAsKurotatoMonsterAttribute(ByteBuffer _bb)
		{
			return KurotatoMonsterAttribute.GetRootAsKurotatoMonsterAttribute(_bb, default(KurotatoMonsterAttribute));
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x00270AE0 File Offset: 0x0026ECE0
		public static KurotatoMonsterAttribute GetRootAsKurotatoMonsterAttribute(ByteBuffer _bb, KurotatoMonsterAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x00270AFD File Offset: 0x0026ECFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x00270B0C File Offset: 0x0026ED0C
		public KurotatoMonsterAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x06008ACD RID: 35533 RVA: 0x00270B1C File Offset: 0x0026ED1C
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

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x06008ACE RID: 35534 RVA: 0x00270B58 File Offset: 0x0026ED58
		public string Key
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

		// Token: 0x06008ACF RID: 35535 RVA: 0x00270B8F File Offset: 0x0026ED8F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x00270B9E File Offset: 0x0026ED9E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x06008AD1 RID: 35537 RVA: 0x00270BB8 File Offset: 0x0026EDB8
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

		// Token: 0x06008AD2 RID: 35538 RVA: 0x00270BEF File Offset: 0x0026EDEF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008AD3 RID: 35539 RVA: 0x00270BFE File Offset: 0x0026EDFE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x06008AD4 RID: 35540 RVA: 0x00270C18 File Offset: 0x0026EE18
		public string Icon
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

		// Token: 0x06008AD5 RID: 35541 RVA: 0x00270C50 File Offset: 0x0026EE50
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008AD6 RID: 35542 RVA: 0x00270C60 File Offset: 0x0026EE60
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E3B RID: 20027
		private Table __p;
	}
}
