using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD1 RID: 3281
	public struct FuncMenuWheel : IFlatbufferObject
	{
		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x060076FC RID: 30460 RVA: 0x002437A9 File Offset: 0x002419A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060076FD RID: 30461 RVA: 0x002437B6 File Offset: 0x002419B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060076FE RID: 30462 RVA: 0x002437C0 File Offset: 0x002419C0
		public static FuncMenuWheel GetRootAsFuncMenuWheel(ByteBuffer _bb)
		{
			return FuncMenuWheel.GetRootAsFuncMenuWheel(_bb, default(FuncMenuWheel));
		}

		// Token: 0x060076FF RID: 30463 RVA: 0x002437DC File Offset: 0x002419DC
		public static FuncMenuWheel GetRootAsFuncMenuWheel(ByteBuffer _bb, FuncMenuWheel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x002437F9 File Offset: 0x002419F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x00243808 File Offset: 0x00241A08
		public FuncMenuWheel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06007702 RID: 30466 RVA: 0x00243818 File Offset: 0x00241A18
		public int FuncId
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

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06007703 RID: 30467 RVA: 0x00243854 File Offset: 0x00241A54
		public string FuncName
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

		// Token: 0x06007704 RID: 30468 RVA: 0x0024388B File Offset: 0x00241A8B
		public Span<byte> GetFuncNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x0024389A File Offset: 0x00241A9A
		public byte[] GetFuncNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06007706 RID: 30470 RVA: 0x002438B4 File Offset: 0x00241AB4
		public string FuncMenuIconPath
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

		// Token: 0x06007707 RID: 30471 RVA: 0x002438EB File Offset: 0x00241AEB
		public Span<byte> GetFuncMenuIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x002438FA File Offset: 0x00241AFA
		public byte[] GetFuncMenuIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06007709 RID: 30473 RVA: 0x00243914 File Offset: 0x00241B14
		public int FuncMenuSequence
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x0600770A RID: 30474 RVA: 0x00243954 File Offset: 0x00241B54
		public bool AutoEquip
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x0600770B RID: 30475 RVA: 0x00243994 File Offset: 0x00241B94
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x0600770C RID: 30476 RVA: 0x002439D4 File Offset: 0x00241BD4
		public bool ShowInAssembly
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004D41 RID: 19777
		private Table __p;
	}
}
