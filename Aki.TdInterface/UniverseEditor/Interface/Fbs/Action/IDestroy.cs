using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200657C RID: 25980
	public struct IDestroy : IFlatbufferObject
	{
		// Token: 0x1700C101 RID: 49409
		// (get) Token: 0x0602D114 RID: 184596 RVA: 0x0062EEEA File Offset: 0x0062D0EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D115 RID: 184597 RVA: 0x0062EEF7 File Offset: 0x0062D0F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D116 RID: 184598 RVA: 0x0062EF00 File Offset: 0x0062D100
		public static IDestroy GetRootAsIDestroy(ByteBuffer _bb)
		{
			return IDestroy.GetRootAsIDestroy(_bb, default(IDestroy));
		}

		// Token: 0x0602D117 RID: 184599 RVA: 0x0062EF1C File Offset: 0x0062D11C
		public static IDestroy GetRootAsIDestroy(ByteBuffer _bb, IDestroy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D118 RID: 184600 RVA: 0x0062EF39 File Offset: 0x0062D139
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D119 RID: 184601 RVA: 0x0062EF48 File Offset: 0x0062D148
		public IDestroy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C102 RID: 49410
		// (get) Token: 0x0602D11A RID: 184602 RVA: 0x0062EF58 File Offset: 0x0062D158
		public bool DelayDestroy
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C103 RID: 49411
		// (get) Token: 0x0602D11B RID: 184603 RVA: 0x0062EF98 File Offset: 0x0062D198
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D11C RID: 184604 RVA: 0x0062EFD4 File Offset: 0x0062D1D4
		public static Offset<IDestroy> CreateIDestroy(FlatBufferBuilder builder, bool DelayDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IDestroy.AddNullMask(builder, NullMask);
			IDestroy.AddDelayDestroy(builder, DelayDestroy);
			return IDestroy.EndIDestroy(builder);
		}

		// Token: 0x0602D11D RID: 184605 RVA: 0x0062EFF1 File Offset: 0x0062D1F1
		public static void StartIDestroy(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D11E RID: 184606 RVA: 0x0062EFFA File Offset: 0x0062D1FA
		public static void AddDelayDestroy(FlatBufferBuilder builder, bool delayDestroy)
		{
			builder.AddBool(0, delayDestroy, false);
		}

		// Token: 0x0602D11F RID: 184607 RVA: 0x0062F005 File Offset: 0x0062D205
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602D120 RID: 184608 RVA: 0x0062F010 File Offset: 0x0062D210
		public static Offset<IDestroy> EndIDestroy(FlatBufferBuilder builder)
		{
			return new Offset<IDestroy>(builder.EndTable());
		}

		// Token: 0x0602D121 RID: 184609 RVA: 0x0062F020 File Offset: 0x0062D220
		public IDestroyT UnPack()
		{
			IDestroyT destroyT = new IDestroyT();
			this.UnPackTo(destroyT);
			return destroyT;
		}

		// Token: 0x0602D122 RID: 184610 RVA: 0x0062F03B File Offset: 0x0062D23B
		public void UnPackTo(IDestroyT _o)
		{
			_o.DelayDestroy = this.DelayDestroy;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D123 RID: 184611 RVA: 0x0062F058 File Offset: 0x0062D258
		public static Offset<IDestroy> Pack(FlatBufferBuilder builder, IDestroyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroy>);
			}
			return IDestroy.CreateIDestroy(builder, _o.DelayDestroy, _o.NullMask);
		}

		// Token: 0x04010BD6 RID: 68566
		private Table __p;
	}
}
