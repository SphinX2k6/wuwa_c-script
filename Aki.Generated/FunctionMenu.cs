using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD3 RID: 3283
	public struct FunctionMenu : IFlatbufferObject
	{
		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06007727 RID: 30503 RVA: 0x00243D9C File Offset: 0x00241F9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x00243DA9 File Offset: 0x00241FA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x00243DB0 File Offset: 0x00241FB0
		public static FunctionMenu GetRootAsFunctionMenu(ByteBuffer _bb)
		{
			return FunctionMenu.GetRootAsFunctionMenu(_bb, default(FunctionMenu));
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00243DCC File Offset: 0x00241FCC
		public static FunctionMenu GetRootAsFunctionMenu(ByteBuffer _bb, FunctionMenu obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x00243DE9 File Offset: 0x00241FE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x00243DF8 File Offset: 0x00241FF8
		public FunctionMenu __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x0600772D RID: 30509 RVA: 0x00243E08 File Offset: 0x00242008
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

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x0600772E RID: 30510 RVA: 0x00243E44 File Offset: 0x00242044
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

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x0600772F RID: 30511 RVA: 0x00243E80 File Offset: 0x00242080
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

		// Token: 0x06007730 RID: 30512 RVA: 0x00243EB7 File Offset: 0x002420B7
		public Span<byte> GetFunctionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x00243EC6 File Offset: 0x002420C6
		public byte[] GetFunctionNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06007732 RID: 30514 RVA: 0x00243EE0 File Offset: 0x002420E0
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

		// Token: 0x06007733 RID: 30515 RVA: 0x00243F18 File Offset: 0x00242118
		public Span<byte> GetFunctionIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x00243F28 File Offset: 0x00242128
		public byte[] GetFunctionIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06007735 RID: 30517 RVA: 0x00243F40 File Offset: 0x00242140
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

		// Token: 0x06007736 RID: 30518 RVA: 0x00243F78 File Offset: 0x00242178
		public Span<byte> GetJumpViewBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007737 RID: 30519 RVA: 0x00243F88 File Offset: 0x00242188
		public byte[] GetJumpViewArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D43 RID: 19779
		private Table __p;
	}
}
