using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D23 RID: 3363
	public struct ErrorCode : IFlatbufferObject
	{
		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x0600704E RID: 28750 RVA: 0x00244B3C File Offset: 0x00242D3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600704F RID: 28751 RVA: 0x00244B49 File Offset: 0x00242D49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007050 RID: 28752 RVA: 0x00244B50 File Offset: 0x00242D50
		public static ErrorCode GetRootAsErrorCode(ByteBuffer _bb)
		{
			return ErrorCode.GetRootAsErrorCode(_bb, default(ErrorCode));
		}

		// Token: 0x06007051 RID: 28753 RVA: 0x00244B6C File Offset: 0x00242D6C
		public static ErrorCode GetRootAsErrorCode(ByteBuffer _bb, ErrorCode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007052 RID: 28754 RVA: 0x00244B89 File Offset: 0x00242D89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007053 RID: 28755 RVA: 0x00244B98 File Offset: 0x00242D98
		public ErrorCode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06007054 RID: 28756 RVA: 0x00244BA8 File Offset: 0x00242DA8
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

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06007055 RID: 28757 RVA: 0x00244BE4 File Offset: 0x00242DE4
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

		// Token: 0x06007056 RID: 28758 RVA: 0x00244C1B File Offset: 0x00242E1B
		public Span<byte> GetDebugTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007057 RID: 28759 RVA: 0x00244C2A File Offset: 0x00242E2A
		public byte[] GetDebugTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06007058 RID: 28760 RVA: 0x00244C44 File Offset: 0x00242E44
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

		// Token: 0x06007059 RID: 28761 RVA: 0x00244C7B File Offset: 0x00242E7B
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600705A RID: 28762 RVA: 0x00244C8A File Offset: 0x00242E8A
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x0600705B RID: 28763 RVA: 0x00244CA4 File Offset: 0x00242EA4
		public bool IsTip
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005263 RID: 21091
		private Table __p;
	}
}
