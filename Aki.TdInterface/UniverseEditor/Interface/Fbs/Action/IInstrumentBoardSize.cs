using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007019 RID: 28697
	public struct IInstrumentBoardSize : IFlatbufferObject
	{
		// Token: 0x1700D21B RID: 53787
		// (get) Token: 0x06031B84 RID: 203652 RVA: 0x006BB6BD File Offset: 0x006B98BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031B85 RID: 203653 RVA: 0x006BB6CA File Offset: 0x006B98CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031B86 RID: 203654 RVA: 0x006BB6D4 File Offset: 0x006B98D4
		public static IInstrumentBoardSize GetRootAsIInstrumentBoardSize(ByteBuffer _bb)
		{
			return IInstrumentBoardSize.GetRootAsIInstrumentBoardSize(_bb, default(IInstrumentBoardSize));
		}

		// Token: 0x06031B87 RID: 203655 RVA: 0x006BB6F0 File Offset: 0x006B98F0
		public static IInstrumentBoardSize GetRootAsIInstrumentBoardSize(ByteBuffer _bb, IInstrumentBoardSize obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031B88 RID: 203656 RVA: 0x006BB70D File Offset: 0x006B990D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031B89 RID: 203657 RVA: 0x006BB71C File Offset: 0x006B991C
		public IInstrumentBoardSize __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D21C RID: 53788
		// (get) Token: 0x06031B8A RID: 203658 RVA: 0x006BB72C File Offset: 0x006B992C
		public int X
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

		// Token: 0x1700D21D RID: 53789
		// (get) Token: 0x06031B8B RID: 203659 RVA: 0x006BB768 File Offset: 0x006B9968
		public int Y
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

		// Token: 0x06031B8C RID: 203660 RVA: 0x006BB7A4 File Offset: 0x006B99A4
		public static Offset<IInstrumentBoardSize> CreateIInstrumentBoardSize(FlatBufferBuilder builder, int X = 0, int Y = 0)
		{
			builder.StartTable(2);
			IInstrumentBoardSize.AddY(builder, Y);
			IInstrumentBoardSize.AddX(builder, X);
			return IInstrumentBoardSize.EndIInstrumentBoardSize(builder);
		}

		// Token: 0x06031B8D RID: 203661 RVA: 0x006BB7C1 File Offset: 0x006B99C1
		public static void StartIInstrumentBoardSize(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031B8E RID: 203662 RVA: 0x006BB7CA File Offset: 0x006B99CA
		public static void AddX(FlatBufferBuilder builder, int x)
		{
			builder.AddInt(0, x, 0);
		}

		// Token: 0x06031B8F RID: 203663 RVA: 0x006BB7D5 File Offset: 0x006B99D5
		public static void AddY(FlatBufferBuilder builder, int y)
		{
			builder.AddInt(1, y, 0);
		}

		// Token: 0x06031B90 RID: 203664 RVA: 0x006BB7E0 File Offset: 0x006B99E0
		public static Offset<IInstrumentBoardSize> EndIInstrumentBoardSize(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentBoardSize>(builder.EndTable());
		}

		// Token: 0x06031B91 RID: 203665 RVA: 0x006BB7F0 File Offset: 0x006B99F0
		public IInstrumentBoardSizeT UnPack()
		{
			IInstrumentBoardSizeT instrumentBoardSizeT = new IInstrumentBoardSizeT();
			this.UnPackTo(instrumentBoardSizeT);
			return instrumentBoardSizeT;
		}

		// Token: 0x06031B92 RID: 203666 RVA: 0x006BB80B File Offset: 0x006B9A0B
		public void UnPackTo(IInstrumentBoardSizeT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
		}

		// Token: 0x06031B93 RID: 203667 RVA: 0x006BB828 File Offset: 0x006B9A28
		public static Offset<IInstrumentBoardSize> Pack(FlatBufferBuilder builder, IInstrumentBoardSizeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInstrumentBoardSize>);
			}
			return IInstrumentBoardSize.CreateIInstrumentBoardSize(builder, _o.X, _o.Y);
		}

		// Token: 0x04011F54 RID: 73556
		private Table __p;
	}
}
