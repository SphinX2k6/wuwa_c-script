using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004997 RID: 18839
	public struct ICheckChessWinner : IFlatbufferObject
	{
		// Token: 0x1700881B RID: 34843
		// (get) Token: 0x0601D618 RID: 120344 RVA: 0x00424388 File Offset: 0x00422588
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D619 RID: 120345 RVA: 0x00424395 File Offset: 0x00422595
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D61A RID: 120346 RVA: 0x0042439C File Offset: 0x0042259C
		public static ICheckChessWinner GetRootAsICheckChessWinner(ByteBuffer _bb)
		{
			return ICheckChessWinner.GetRootAsICheckChessWinner(_bb, default(ICheckChessWinner));
		}

		// Token: 0x0601D61B RID: 120347 RVA: 0x004243B8 File Offset: 0x004225B8
		public static ICheckChessWinner GetRootAsICheckChessWinner(ByteBuffer _bb, ICheckChessWinner obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D61C RID: 120348 RVA: 0x004243D5 File Offset: 0x004225D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D61D RID: 120349 RVA: 0x004243E4 File Offset: 0x004225E4
		public ICheckChessWinner __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700881C RID: 34844
		// (get) Token: 0x0601D61E RID: 120350 RVA: 0x004243F4 File Offset: 0x004225F4
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

		// Token: 0x1700881D RID: 34845
		// (get) Token: 0x0601D61F RID: 120351 RVA: 0x00424430 File Offset: 0x00422630
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

		// Token: 0x1700881E RID: 34846
		// (get) Token: 0x0601D620 RID: 120352 RVA: 0x0042446C File Offset: 0x0042266C
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

		// Token: 0x0601D621 RID: 120353 RVA: 0x004244A8 File Offset: 0x004226A8
		public static Offset<ICheckChessWinner> CreateICheckChessWinner(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ChessboardId = 0, ERenjuController Winner = ERenjuController.Computer)
		{
			builder.StartTable(3);
			ICheckChessWinner.AddChessboardId(builder, ChessboardId);
			ICheckChessWinner.AddWinner(builder, Winner);
			ICheckChessWinner.AddType(builder, Type);
			return ICheckChessWinner.EndICheckChessWinner(builder);
		}

		// Token: 0x0601D622 RID: 120354 RVA: 0x004244CC File Offset: 0x004226CC
		public static void StartICheckChessWinner(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D623 RID: 120355 RVA: 0x004244D5 File Offset: 0x004226D5
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D624 RID: 120356 RVA: 0x004244E0 File Offset: 0x004226E0
		public static void AddChessboardId(FlatBufferBuilder builder, int chessboardId)
		{
			builder.AddInt(1, chessboardId, 0);
		}

		// Token: 0x0601D625 RID: 120357 RVA: 0x004244EB File Offset: 0x004226EB
		public static void AddWinner(FlatBufferBuilder builder, ERenjuController winner)
		{
			builder.AddByte(2, (byte)winner, 0);
		}

		// Token: 0x0601D626 RID: 120358 RVA: 0x004244F6 File Offset: 0x004226F6
		public static Offset<ICheckChessWinner> EndICheckChessWinner(FlatBufferBuilder builder)
		{
			return new Offset<ICheckChessWinner>(builder.EndTable());
		}

		// Token: 0x0601D627 RID: 120359 RVA: 0x00424504 File Offset: 0x00422704
		public ICheckChessWinnerT UnPack()
		{
			ICheckChessWinnerT checkChessWinnerT = new ICheckChessWinnerT();
			this.UnPackTo(checkChessWinnerT);
			return checkChessWinnerT;
		}

		// Token: 0x0601D628 RID: 120360 RVA: 0x0042451F File Offset: 0x0042271F
		public void UnPackTo(ICheckChessWinnerT _o)
		{
			_o.Type = this.Type;
			_o.ChessboardId = this.ChessboardId;
			_o.Winner = this.Winner;
		}

		// Token: 0x0601D629 RID: 120361 RVA: 0x00424548 File Offset: 0x00422748
		public static Offset<ICheckChessWinner> Pack(FlatBufferBuilder builder, ICheckChessWinnerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckChessWinner>);
			}
			return ICheckChessWinner.CreateICheckChessWinner(builder, _o.Type, _o.ChessboardId, _o.Winner);
		}

		// Token: 0x0400D1AA RID: 53674
		private Table __p;
	}
}
