using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC4 RID: 3012
	public struct DangoBrawlItemSubType : IFlatbufferObject
	{
		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06005E0F RID: 24079 RVA: 0x0020A7B4 File Offset: 0x002089B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x0020A7C1 File Offset: 0x002089C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005E11 RID: 24081 RVA: 0x0020A7C8 File Offset: 0x002089C8
		public static DangoBrawlItemSubType GetRootAsDangoBrawlItemSubType(ByteBuffer _bb)
		{
			return DangoBrawlItemSubType.GetRootAsDangoBrawlItemSubType(_bb, default(DangoBrawlItemSubType));
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x0020A7E4 File Offset: 0x002089E4
		public static DangoBrawlItemSubType GetRootAsDangoBrawlItemSubType(ByteBuffer _bb, DangoBrawlItemSubType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x0020A801 File Offset: 0x00208A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x0020A810 File Offset: 0x00208A10
		public DangoBrawlItemSubType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06005E15 RID: 24085 RVA: 0x0020A820 File Offset: 0x00208A20
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

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06005E16 RID: 24086 RVA: 0x0020A85C File Offset: 0x00208A5C
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

		// Token: 0x06005E17 RID: 24087 RVA: 0x0020A893 File Offset: 0x00208A93
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x0020A8A2 File Offset: 0x00208AA2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06005E19 RID: 24089 RVA: 0x0020A8BC File Offset: 0x00208ABC
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

		// Token: 0x06005E1A RID: 24090 RVA: 0x0020A8F3 File Offset: 0x00208AF3
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x0020A902 File Offset: 0x00208B02
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BED RID: 19437
		private Table __p;
	}
}
