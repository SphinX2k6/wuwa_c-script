using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E4E RID: 20046
	public struct ICheckChessWinner : IFlatbufferObject
	{
		// Token: 0x17008ED6 RID: 36566
		// (get) Token: 0x0601F03D RID: 127037 RVA: 0x0045483C File Offset: 0x00452A3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F03E RID: 127038 RVA: 0x00454849 File Offset: 0x00452A49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F03F RID: 127039 RVA: 0x00454850 File Offset: 0x00452A50
		public static ICheckChessWinner GetRootAsICheckChessWinner(ByteBuffer _bb)
		{
			return ICheckChessWinner.GetRootAsICheckChessWinner(_bb, default(ICheckChessWinner));
		}

		// Token: 0x0601F040 RID: 127040 RVA: 0x0045486C File Offset: 0x00452A6C
		public static ICheckChessWinner GetRootAsICheckChessWinner(ByteBuffer _bb, ICheckChessWinner obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F041 RID: 127041 RVA: 0x00454889 File Offset: 0x00452A89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F042 RID: 127042 RVA: 0x00454898 File Offset: 0x00452A98
		public ICheckChessWinner __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008ED7 RID: 36567
		// (get) Token: 0x0601F043 RID: 127043 RVA: 0x004548A8 File Offset: 0x00452AA8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008ED8 RID: 36568
		// (get) Token: 0x0601F044 RID: 127044 RVA: 0x004548E4 File Offset: 0x00452AE4
		public int ChessboardId
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

		// Token: 0x17008ED9 RID: 36569
		// (get) Token: 0x0601F045 RID: 127045 RVA: 0x00454920 File Offset: 0x00452B20
		public ERenjuController Winner
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ERenjuController.Computer;
				}
				return (ERenjuController)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F046 RID: 127046 RVA: 0x0045495C File Offset: 0x00452B5C
		public static Offset<ICheckChessWinner> CreateICheckChessWinner(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ChessboardId = 0, ERenjuController Winner = ERenjuController.Computer)
		{
			builder.StartTable(3);
			ICheckChessWinner.AddChessboardId(builder, ChessboardId);
			ICheckChessWinner.AddWinner(builder, Winner);
			ICheckChessWinner.AddType(builder, Type);
			return ICheckChessWinner.EndICheckChessWinner(builder);
		}

		// Token: 0x0601F047 RID: 127047 RVA: 0x00454980 File Offset: 0x00452B80
		public static void StartICheckChessWinner(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F048 RID: 127048 RVA: 0x00454989 File Offset: 0x00452B89
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F049 RID: 127049 RVA: 0x00454994 File Offset: 0x00452B94
		public static void AddChessboardId(FlatBufferBuilder builder, int chessboardId)
		{
			builder.AddInt(1, chessboardId, 0);
		}

		// Token: 0x0601F04A RID: 127050 RVA: 0x0045499F File Offset: 0x00452B9F
		public static void AddWinner(FlatBufferBuilder builder, ERenjuController winner)
		{
			builder.AddByte(2, (byte)winner, 0);
		}

		// Token: 0x0601F04B RID: 127051 RVA: 0x004549AA File Offset: 0x00452BAA
		public static Offset<ICheckChessWinner> EndICheckChessWinner(FlatBufferBuilder builder)
		{
			return new Offset<ICheckChessWinner>(builder.EndTable());
		}

		// Token: 0x0601F04C RID: 127052 RVA: 0x004549B8 File Offset: 0x00452BB8
		public ICheckChessWinnerT UnPack()
		{
			ICheckChessWinnerT checkChessWinnerT = new ICheckChessWinnerT();
			this.UnPackTo(checkChessWinnerT);
			return checkChessWinnerT;
		}

		// Token: 0x0601F04D RID: 127053 RVA: 0x004549D3 File Offset: 0x00452BD3
		public void UnPackTo(ICheckChessWinnerT _o)
		{
			_o.Type = this.Type;
			_o.ChessboardId = this.ChessboardId;
			_o.Winner = this.Winner;
		}

		// Token: 0x0601F04E RID: 127054 RVA: 0x004549FC File Offset: 0x00452BFC
		public static Offset<ICheckChessWinner> Pack(FlatBufferBuilder builder, ICheckChessWinnerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckChessWinner>);
			}
			return ICheckChessWinner.CreateICheckChessWinner(builder, _o.Type, _o.ChessboardId, _o.Winner);
		}

		// Token: 0x0400DC72 RID: 56434
		private Table __p;
	}
}
