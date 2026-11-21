using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB5 RID: 3509
	public struct FuncMenuWheel : IFlatbufferObject
	{
		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06007D07 RID: 32007 RVA: 0x00262346 File Offset: 0x00260546
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x00262353 File Offset: 0x00260553
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007D09 RID: 32009 RVA: 0x0026235C File Offset: 0x0026055C
		public static FuncMenuWheel GetRootAsFuncMenuWheel(ByteBuffer _bb)
		{
			return FuncMenuWheel.GetRootAsFuncMenuWheel(_bb, default(FuncMenuWheel));
		}

		// Token: 0x06007D0A RID: 32010 RVA: 0x00262378 File Offset: 0x00260578
		public static FuncMenuWheel GetRootAsFuncMenuWheel(ByteBuffer _bb, FuncMenuWheel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007D0B RID: 32011 RVA: 0x00262395 File Offset: 0x00260595
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007D0C RID: 32012 RVA: 0x002623A4 File Offset: 0x002605A4
		public FuncMenuWheel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06007D0D RID: 32013 RVA: 0x002623B4 File Offset: 0x002605B4
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

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06007D0E RID: 32014 RVA: 0x002623F0 File Offset: 0x002605F0
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

		// Token: 0x06007D0F RID: 32015 RVA: 0x00262427 File Offset: 0x00260627
		public Span<byte> GetFuncNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007D10 RID: 32016 RVA: 0x00262436 File Offset: 0x00260636
		public byte[] GetFuncNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06007D11 RID: 32017 RVA: 0x00262450 File Offset: 0x00260650
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

		// Token: 0x06007D12 RID: 32018 RVA: 0x00262487 File Offset: 0x00260687
		public Span<byte> GetFuncMenuIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007D13 RID: 32019 RVA: 0x00262496 File Offset: 0x00260696
		public byte[] GetFuncMenuIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06007D14 RID: 32020 RVA: 0x002624B0 File Offset: 0x002606B0
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

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06007D15 RID: 32021 RVA: 0x002624F0 File Offset: 0x002606F0
		public bool AutoEquip
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06007D16 RID: 32022 RVA: 0x00262530 File Offset: 0x00260730
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

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06007D17 RID: 32023 RVA: 0x00262570 File Offset: 0x00260770
		public bool ShowInAssembly
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005325 RID: 21285
		private Table __p;
	}
}
