using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E47 RID: 20039
	public struct IActivateAllCorrectPiece : IFlatbufferObject
	{
		// Token: 0x17008F6B RID: 36715
		// (get) Token: 0x0601F72C RID: 128812 RVA: 0x00461AA4 File Offset: 0x0045FCA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F72D RID: 128813 RVA: 0x00461AB1 File Offset: 0x0045FCB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F72E RID: 128814 RVA: 0x00461AB8 File Offset: 0x0045FCB8
		public static IActivateAllCorrectPiece GetRootAsIActivateAllCorrectPiece(ByteBuffer _bb)
		{
			return IActivateAllCorrectPiece.GetRootAsIActivateAllCorrectPiece(_bb, default(IActivateAllCorrectPiece));
		}

		// Token: 0x0601F72F RID: 128815 RVA: 0x00461AD4 File Offset: 0x0045FCD4
		public static IActivateAllCorrectPiece GetRootAsIActivateAllCorrectPiece(ByteBuffer _bb, IActivateAllCorrectPiece obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F730 RID: 128816 RVA: 0x00461AF1 File Offset: 0x0045FCF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F731 RID: 128817 RVA: 0x00461B00 File Offset: 0x0045FD00
		public IActivateAllCorrectPiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F6C RID: 36716
		// (get) Token: 0x0601F732 RID: 128818 RVA: 0x00461B10 File Offset: 0x0045FD10
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

		// Token: 0x0601F733 RID: 128819 RVA: 0x00461B4C File Offset: 0x0045FD4C
		public static Offset<IActivateAllCorrectPiece> CreateIActivateAllCorrectPiece(FlatBufferBuilder builder, EJigsawCompleteCondition Type = EJigsawCompleteCondition.ActivateAllCorrectPiece)
		{
			builder.StartTable(1);
			IActivateAllCorrectPiece.AddType(builder, Type);
			return IActivateAllCorrectPiece.EndIActivateAllCorrectPiece(builder);
		}

		// Token: 0x0601F734 RID: 128820 RVA: 0x00461B62 File Offset: 0x0045FD62
		public static void StartIActivateAllCorrectPiece(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F735 RID: 128821 RVA: 0x00461B6B File Offset: 0x0045FD6B
		public static void AddType(FlatBufferBuilder builder, EJigsawCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F736 RID: 128822 RVA: 0x00461B76 File Offset: 0x0045FD76
		public static Offset<IActivateAllCorrectPiece> EndIActivateAllCorrectPiece(FlatBufferBuilder builder)
		{
			return new Offset<IActivateAllCorrectPiece>(builder.EndTable());
		}

		// Token: 0x0601F737 RID: 128823 RVA: 0x00461B84 File Offset: 0x0045FD84
		public IActivateAllCorrectPieceT UnPack()
		{
			IActivateAllCorrectPieceT activateAllCorrectPieceT = new IActivateAllCorrectPieceT();
			this.UnPackTo(activateAllCorrectPieceT);
			return activateAllCorrectPieceT;
		}

		// Token: 0x0601F738 RID: 128824 RVA: 0x00461B9F File Offset: 0x0045FD9F
		public void UnPackTo(IActivateAllCorrectPieceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F739 RID: 128825 RVA: 0x00461BB0 File Offset: 0x0045FDB0
		public static Offset<IActivateAllCorrectPiece> Pack(FlatBufferBuilder builder, IActivateAllCorrectPieceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActivateAllCorrectPiece>);
			}
			return IActivateAllCorrectPiece.CreateIActivateAllCorrectPiece(builder, _o.Type);
		}

		// Token: 0x0400DBE3 RID: 56291
		private Table __p;
	}
}
