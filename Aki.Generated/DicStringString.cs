using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C0 RID: 4544
	public struct DicStringString : IFlatbufferObject
	{
		// Token: 0x17003EDB RID: 16091
		// (get) Token: 0x0600EA4D RID: 59981 RVA: 0x00347D40 File Offset: 0x00345F40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA4E RID: 59982 RVA: 0x00347D4D File Offset: 0x00345F4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA4F RID: 59983 RVA: 0x00347D54 File Offset: 0x00345F54
		public static DicStringString GetRootAsDicStringString(ByteBuffer _bb)
		{
			return DicStringString.GetRootAsDicStringString(_bb, default(DicStringString));
		}

		// Token: 0x0600EA50 RID: 59984 RVA: 0x00347D70 File Offset: 0x00345F70
		public static DicStringString GetRootAsDicStringString(ByteBuffer _bb, DicStringString obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA51 RID: 59985 RVA: 0x00347D8D File Offset: 0x00345F8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA52 RID: 59986 RVA: 0x00347D9C File Offset: 0x00345F9C
		public DicStringString __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EDC RID: 16092
		// (get) Token: 0x0600EA53 RID: 59987 RVA: 0x00347DAC File Offset: 0x00345FAC
		public string Key
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

		// Token: 0x0600EA54 RID: 59988 RVA: 0x00347DE3 File Offset: 0x00345FE3
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600EA55 RID: 59989 RVA: 0x00347DF2 File Offset: 0x00345FF2
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EDD RID: 16093
		// (get) Token: 0x0600EA56 RID: 59990 RVA: 0x00347E0C File Offset: 0x0034600C
		public string Value
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

		// Token: 0x0600EA57 RID: 59991 RVA: 0x00347E43 File Offset: 0x00346043
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EA58 RID: 59992 RVA: 0x00347E52 File Offset: 0x00346052
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005311 RID: 21265
		private Table __p;
	}
}
