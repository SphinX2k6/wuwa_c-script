using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA7 RID: 3239
	public struct DangoBrawlItemType : IFlatbufferObject
	{
		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060063F5 RID: 25589 RVA: 0x0022A0CD File Offset: 0x002282CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x0022A0DA File Offset: 0x002282DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x0022A0E4 File Offset: 0x002282E4
		public static DangoBrawlItemType GetRootAsDangoBrawlItemType(ByteBuffer _bb)
		{
			return DangoBrawlItemType.GetRootAsDangoBrawlItemType(_bb, default(DangoBrawlItemType));
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x0022A100 File Offset: 0x00228300
		public static DangoBrawlItemType GetRootAsDangoBrawlItemType(ByteBuffer _bb, DangoBrawlItemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x0022A11D File Offset: 0x0022831D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x0022A12C File Offset: 0x0022832C
		public DangoBrawlItemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060063FB RID: 25595 RVA: 0x0022A13C File Offset: 0x0022833C
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

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060063FC RID: 25596 RVA: 0x0022A178 File Offset: 0x00228378
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

		// Token: 0x060063FD RID: 25597 RVA: 0x0022A1AF File Offset: 0x002283AF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x0022A1BE File Offset: 0x002283BE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x060063FF RID: 25599 RVA: 0x0022A1D8 File Offset: 0x002283D8
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

		// Token: 0x06006400 RID: 25600 RVA: 0x0022A20F File Offset: 0x0022840F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x0022A21E File Offset: 0x0022841E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040051D0 RID: 20944
		private Table __p;
	}
}
