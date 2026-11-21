using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB7 RID: 3511
	public struct FunctionMenu : IFlatbufferObject
	{
		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06007D32 RID: 32050 RVA: 0x00262938 File Offset: 0x00260B38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007D33 RID: 32051 RVA: 0x00262945 File Offset: 0x00260B45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007D34 RID: 32052 RVA: 0x0026294C File Offset: 0x00260B4C
		public static FunctionMenu GetRootAsFunctionMenu(ByteBuffer _bb)
		{
			return FunctionMenu.GetRootAsFunctionMenu(_bb, default(FunctionMenu));
		}

		// Token: 0x06007D35 RID: 32053 RVA: 0x00262968 File Offset: 0x00260B68
		public static FunctionMenu GetRootAsFunctionMenu(ByteBuffer _bb, FunctionMenu obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007D36 RID: 32054 RVA: 0x00262985 File Offset: 0x00260B85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007D37 RID: 32055 RVA: 0x00262994 File Offset: 0x00260B94
		public FunctionMenu __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06007D38 RID: 32056 RVA: 0x002629A4 File Offset: 0x00260BA4
		public int FunctionId
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

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06007D39 RID: 32057 RVA: 0x002629E0 File Offset: 0x00260BE0
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06007D3A RID: 32058 RVA: 0x00262A1C File Offset: 0x00260C1C
		public string FunctionName
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

		// Token: 0x06007D3B RID: 32059 RVA: 0x00262A53 File Offset: 0x00260C53
		public Span<byte> GetFunctionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007D3C RID: 32060 RVA: 0x00262A62 File Offset: 0x00260C62
		public byte[] GetFunctionNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06007D3D RID: 32061 RVA: 0x00262A7C File Offset: 0x00260C7C
		public string FunctionIcon
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

		// Token: 0x06007D3E RID: 32062 RVA: 0x00262AB4 File Offset: 0x00260CB4
		public Span<byte> GetFunctionIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007D3F RID: 32063 RVA: 0x00262AC4 File Offset: 0x00260CC4
		public byte[] GetFunctionIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06007D40 RID: 32064 RVA: 0x00262ADC File Offset: 0x00260CDC
		public string JumpView
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

		// Token: 0x06007D41 RID: 32065 RVA: 0x00262B14 File Offset: 0x00260D14
		public Span<byte> GetJumpViewBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007D42 RID: 32066 RVA: 0x00262B24 File Offset: 0x00260D24
		public byte[] GetJumpViewArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005327 RID: 21287
		private Table __p;
	}
}
