using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005358 RID: 21336
	public struct IActivateAllCorrectPiece : IFlatbufferObject
	{
		// Token: 0x170096A4 RID: 38564
		// (get) Token: 0x06021377 RID: 136055 RVA: 0x00495ABC File Offset: 0x00493CBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021378 RID: 136056 RVA: 0x00495AC9 File Offset: 0x00493CC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021379 RID: 136057 RVA: 0x00495AD0 File Offset: 0x00493CD0
		public static IActivateAllCorrectPiece GetRootAsIActivateAllCorrectPiece(ByteBuffer _bb)
		{
			return IActivateAllCorrectPiece.GetRootAsIActivateAllCorrectPiece(_bb, default(IActivateAllCorrectPiece));
		}

		// Token: 0x0602137A RID: 136058 RVA: 0x00495AEC File Offset: 0x00493CEC
		public static IActivateAllCorrectPiece GetRootAsIActivateAllCorrectPiece(ByteBuffer _bb, IActivateAllCorrectPiece obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602137B RID: 136059 RVA: 0x00495B09 File Offset: 0x00493D09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602137C RID: 136060 RVA: 0x00495B18 File Offset: 0x00493D18
		public IActivateAllCorrectPiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096A5 RID: 38565
		// (get) Token: 0x0602137D RID: 136061 RVA: 0x00495B28 File Offset: 0x00493D28
		public EJigsawCompleteCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EJigsawCompleteCondition.ActivateAllCorrectPiece;
				}
				return (EJigsawCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602137E RID: 136062 RVA: 0x00495B64 File Offset: 0x00493D64
		public static Offset<IActivateAllCorrectPiece> CreateIActivateAllCorrectPiece(FlatBufferBuilder builder, EJigsawCompleteCondition Type = EJigsawCompleteCondition.ActivateAllCorrectPiece)
		{
			builder.StartTable(1);
			IActivateAllCorrectPiece.AddType(builder, Type);
			return IActivateAllCorrectPiece.EndIActivateAllCorrectPiece(builder);
		}

		// Token: 0x0602137F RID: 136063 RVA: 0x00495B7A File Offset: 0x00493D7A
		public static void StartIActivateAllCorrectPiece(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021380 RID: 136064 RVA: 0x00495B83 File Offset: 0x00493D83
		public static void AddType(FlatBufferBuilder builder, EJigsawCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021381 RID: 136065 RVA: 0x00495B8E File Offset: 0x00493D8E
		public static Offset<IActivateAllCorrectPiece> EndIActivateAllCorrectPiece(FlatBufferBuilder builder)
		{
			return new Offset<IActivateAllCorrectPiece>(builder.EndTable());
		}

		// Token: 0x06021382 RID: 136066 RVA: 0x00495B9C File Offset: 0x00493D9C
		public IActivateAllCorrectPieceT UnPack()
		{
			IActivateAllCorrectPieceT activateAllCorrectPieceT = new IActivateAllCorrectPieceT();
			this.UnPackTo(activateAllCorrectPieceT);
			return activateAllCorrectPieceT;
		}

		// Token: 0x06021383 RID: 136067 RVA: 0x00495BB7 File Offset: 0x00493DB7
		public void UnPackTo(IActivateAllCorrectPieceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021384 RID: 136068 RVA: 0x00495BC8 File Offset: 0x00493DC8
		public static Offset<IActivateAllCorrectPiece> Pack(FlatBufferBuilder builder, IActivateAllCorrectPieceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActivateAllCorrectPiece>);
			}
			return IActivateAllCorrectPiece.CreateIActivateAllCorrectPiece(builder, _o.Type);
		}

		// Token: 0x0400E75D RID: 59229
		private Table __p;
	}
}
