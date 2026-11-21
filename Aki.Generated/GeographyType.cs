using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DDC RID: 3548
	public struct GeographyType : IFlatbufferObject
	{
		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06008035 RID: 32821 RVA: 0x0026918D File Offset: 0x0026738D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008036 RID: 32822 RVA: 0x0026919A File Offset: 0x0026739A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008037 RID: 32823 RVA: 0x002691A4 File Offset: 0x002673A4
		public static GeographyType GetRootAsGeographyType(ByteBuffer _bb)
		{
			return GeographyType.GetRootAsGeographyType(_bb, default(GeographyType));
		}

		// Token: 0x06008038 RID: 32824 RVA: 0x002691C0 File Offset: 0x002673C0
		public static GeographyType GetRootAsGeographyType(ByteBuffer _bb, GeographyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008039 RID: 32825 RVA: 0x002691DD File Offset: 0x002673DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600803A RID: 32826 RVA: 0x002691EC File Offset: 0x002673EC
		public GeographyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x0600803B RID: 32827 RVA: 0x002691FC File Offset: 0x002673FC
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

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x0600803C RID: 32828 RVA: 0x00269238 File Offset: 0x00267438
		public string TypeDescription
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

		// Token: 0x0600803D RID: 32829 RVA: 0x0026926F File Offset: 0x0026746F
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600803E RID: 32830 RVA: 0x0026927E File Offset: 0x0026747E
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x0600803F RID: 32831 RVA: 0x00269298 File Offset: 0x00267498
		public string Icon
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

		// Token: 0x06008040 RID: 32832 RVA: 0x002692CF File Offset: 0x002674CF
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008041 RID: 32833 RVA: 0x002692DE File Offset: 0x002674DE
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400534F RID: 21327
		private Table __p;
	}
}
