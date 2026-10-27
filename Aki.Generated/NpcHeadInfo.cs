using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E9C RID: 3740
	public struct NpcHeadInfo : IFlatbufferObject
	{
		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x0600A0D1 RID: 41169 RVA: 0x002A1831 File Offset: 0x0029FA31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x002A183E File Offset: 0x0029FA3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x002A1848 File Offset: 0x0029FA48
		public static NpcHeadInfo GetRootAsNpcHeadInfo(ByteBuffer _bb)
		{
			return NpcHeadInfo.GetRootAsNpcHeadInfo(_bb, default(NpcHeadInfo));
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x002A1864 File Offset: 0x0029FA64
		public static NpcHeadInfo GetRootAsNpcHeadInfo(ByteBuffer _bb, NpcHeadInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x002A1881 File Offset: 0x0029FA81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x002A1890 File Offset: 0x0029FA90
		public NpcHeadInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x0600A0D7 RID: 41175 RVA: 0x002A18A0 File Offset: 0x0029FAA0
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

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x0600A0D8 RID: 41176 RVA: 0x002A18DC File Offset: 0x0029FADC
		public string SecondName
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

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x002A1913 File Offset: 0x0029FB13
		public Span<byte> GetSecondNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A0DA RID: 41178 RVA: 0x002A1922 File Offset: 0x0029FB22
		public byte[] GetSecondNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x0600A0DB RID: 41179 RVA: 0x002A193C File Offset: 0x0029FB3C
		public string FunctionPath
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

		// Token: 0x0600A0DC RID: 41180 RVA: 0x002A1973 File Offset: 0x0029FB73
		public Span<byte> GetFunctionPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x002A1982 File Offset: 0x0029FB82
		public byte[] GetFunctionPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F50 RID: 20304
		private Table __p;
	}
}
