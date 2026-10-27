using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C40 RID: 3136
	public struct ErrorCode : IFlatbufferObject
	{
		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06006A4C RID: 27212 RVA: 0x002257F4 File Offset: 0x002239F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x00225801 File Offset: 0x00223A01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x00225808 File Offset: 0x00223A08
		public static ErrorCode GetRootAsErrorCode(ByteBuffer _bb)
		{
			return ErrorCode.GetRootAsErrorCode(_bb, default(ErrorCode));
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x00225824 File Offset: 0x00223A24
		public static ErrorCode GetRootAsErrorCode(ByteBuffer _bb, ErrorCode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x00225841 File Offset: 0x00223A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x00225850 File Offset: 0x00223A50
		public ErrorCode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06006A52 RID: 27218 RVA: 0x00225860 File Offset: 0x00223A60
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

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06006A53 RID: 27219 RVA: 0x0022589C File Offset: 0x00223A9C
		public string DebugText
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

		// Token: 0x06006A54 RID: 27220 RVA: 0x002258D3 File Offset: 0x00223AD3
		public Span<byte> GetDebugTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006A55 RID: 27221 RVA: 0x002258E2 File Offset: 0x00223AE2
		public byte[] GetDebugTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06006A56 RID: 27222 RVA: 0x002258FC File Offset: 0x00223AFC
		public string Text
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

		// Token: 0x06006A57 RID: 27223 RVA: 0x00225933 File Offset: 0x00223B33
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006A58 RID: 27224 RVA: 0x00225942 File Offset: 0x00223B42
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06006A59 RID: 27225 RVA: 0x0022595C File Offset: 0x00223B5C
		public bool IsTip
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004C80 RID: 19584
		private Table __p;
	}
}
