using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C41 RID: 3137
	public struct Evaluate : IFlatbufferObject
	{
		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06006A5A RID: 27226 RVA: 0x0022599C File Offset: 0x00223B9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x002259A9 File Offset: 0x00223BA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x002259B0 File Offset: 0x00223BB0
		public static Evaluate GetRootAsEvaluate(ByteBuffer _bb)
		{
			return Evaluate.GetRootAsEvaluate(_bb, default(Evaluate));
		}

		// Token: 0x06006A5D RID: 27229 RVA: 0x002259CC File Offset: 0x00223BCC
		public static Evaluate GetRootAsEvaluate(ByteBuffer _bb, Evaluate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x002259E9 File Offset: 0x00223BE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x002259F8 File Offset: 0x00223BF8
		public Evaluate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06006A60 RID: 27232 RVA: 0x00225A08 File Offset: 0x00223C08
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

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06006A61 RID: 27233 RVA: 0x00225A44 File Offset: 0x00223C44
		public string Content
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

		// Token: 0x06006A62 RID: 27234 RVA: 0x00225A7B File Offset: 0x00223C7B
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x00225A8A File Offset: 0x00223C8A
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06006A64 RID: 27236 RVA: 0x00225AA4 File Offset: 0x00223CA4
		public string Color
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

		// Token: 0x06006A65 RID: 27237 RVA: 0x00225ADB File Offset: 0x00223CDB
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x00225AEA File Offset: 0x00223CEA
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06006A67 RID: 27239 RVA: 0x00225B04 File Offset: 0x00223D04
		public string SpriteColor
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

		// Token: 0x06006A68 RID: 27240 RVA: 0x00225B3C File Offset: 0x00223D3C
		public Span<byte> GetSpriteColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x00225B4C File Offset: 0x00223D4C
		public byte[] GetSpriteColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06006A6A RID: 27242 RVA: 0x00225B64 File Offset: 0x00223D64
		public string Icon
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

		// Token: 0x06006A6B RID: 27243 RVA: 0x00225B9C File Offset: 0x00223D9C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x00225BAC File Offset: 0x00223DAC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C81 RID: 19585
		private Table __p;
	}
}
