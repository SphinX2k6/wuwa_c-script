using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006966 RID: 26982
	public struct IInstrumentBoardSize : IFlatbufferObject
	{
		// Token: 0x1700C818 RID: 51224
		// (get) Token: 0x0602F1B4 RID: 192948 RVA: 0x0066B1D5 File Offset: 0x006693D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F1B5 RID: 192949 RVA: 0x0066B1E2 File Offset: 0x006693E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F1B6 RID: 192950 RVA: 0x0066B1EC File Offset: 0x006693EC
		public static IInstrumentBoardSize GetRootAsIInstrumentBoardSize(ByteBuffer _bb)
		{
			return IInstrumentBoardSize.GetRootAsIInstrumentBoardSize(_bb, default(IInstrumentBoardSize));
		}

		// Token: 0x0602F1B7 RID: 192951 RVA: 0x0066B208 File Offset: 0x00669408
		public static IInstrumentBoardSize GetRootAsIInstrumentBoardSize(ByteBuffer _bb, IInstrumentBoardSize obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F1B8 RID: 192952 RVA: 0x0066B225 File Offset: 0x00669425
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F1B9 RID: 192953 RVA: 0x0066B234 File Offset: 0x00669434
		public IInstrumentBoardSize __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C819 RID: 51225
		// (get) Token: 0x0602F1BA RID: 192954 RVA: 0x0066B244 File Offset: 0x00669444
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

		// Token: 0x1700C81A RID: 51226
		// (get) Token: 0x0602F1BB RID: 192955 RVA: 0x0066B280 File Offset: 0x00669480
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

		// Token: 0x0602F1BC RID: 192956 RVA: 0x0066B2BC File Offset: 0x006694BC
		public static Offset<IInstrumentBoardSize> CreateIInstrumentBoardSize(FlatBufferBuilder builder, int X = 0, int Y = 0)
		{
			builder.StartTable(2);
			IInstrumentBoardSize.AddY(builder, Y);
			IInstrumentBoardSize.AddX(builder, X);
			return IInstrumentBoardSize.EndIInstrumentBoardSize(builder);
		}

		// Token: 0x0602F1BD RID: 192957 RVA: 0x0066B2D9 File Offset: 0x006694D9
		public static void StartIInstrumentBoardSize(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F1BE RID: 192958 RVA: 0x0066B2E2 File Offset: 0x006694E2
		public static void AddX(FlatBufferBuilder builder, int x)
		{
			builder.AddInt(0, x, 0);
		}

		// Token: 0x0602F1BF RID: 192959 RVA: 0x0066B2ED File Offset: 0x006694ED
		public static void AddY(FlatBufferBuilder builder, int y)
		{
			builder.AddInt(1, y, 0);
		}

		// Token: 0x0602F1C0 RID: 192960 RVA: 0x0066B2F8 File Offset: 0x006694F8
		public static Offset<IInstrumentBoardSize> EndIInstrumentBoardSize(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentBoardSize>(builder.EndTable());
		}

		// Token: 0x0602F1C1 RID: 192961 RVA: 0x0066B308 File Offset: 0x00669508
		public IInstrumentBoardSizeT UnPack()
		{
			IInstrumentBoardSizeT instrumentBoardSizeT = new IInstrumentBoardSizeT();
			this.UnPackTo(instrumentBoardSizeT);
			return instrumentBoardSizeT;
		}

		// Token: 0x0602F1C2 RID: 192962 RVA: 0x0066B323 File Offset: 0x00669523
		public void UnPackTo(IInstrumentBoardSizeT _o)
		{
			_o.X = this.X;
			_o.Y = this.Y;
		}

		// Token: 0x0602F1C3 RID: 192963 RVA: 0x0066B340 File Offset: 0x00669540
		public static Offset<IInstrumentBoardSize> Pack(FlatBufferBuilder builder, IInstrumentBoardSizeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInstrumentBoardSize>);
			}
			return IInstrumentBoardSize.CreateIInstrumentBoardSize(builder, _o.X, _o.Y);
		}

		// Token: 0x040110E8 RID: 69864
		private Table __p;
	}
}
