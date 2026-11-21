using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200680E RID: 26638
	public struct IAssistCharacterSplineMove : IFlatbufferObject
	{
		// Token: 0x1700C3CB RID: 50123
		// (get) Token: 0x0602D803 RID: 186371 RVA: 0x0063A88F File Offset: 0x00638A8F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D804 RID: 186372 RVA: 0x0063A89C File Offset: 0x00638A9C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D805 RID: 186373 RVA: 0x0063A8A4 File Offset: 0x00638AA4
		public static IAssistCharacterSplineMove GetRootAsIAssistCharacterSplineMove(ByteBuffer _bb)
		{
			return IAssistCharacterSplineMove.GetRootAsIAssistCharacterSplineMove(_bb, default(IAssistCharacterSplineMove));
		}

		// Token: 0x0602D806 RID: 186374 RVA: 0x0063A8C0 File Offset: 0x00638AC0
		public static IAssistCharacterSplineMove GetRootAsIAssistCharacterSplineMove(ByteBuffer _bb, IAssistCharacterSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D807 RID: 186375 RVA: 0x0063A8DD File Offset: 0x00638ADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D808 RID: 186376 RVA: 0x0063A8EC File Offset: 0x00638AEC
		public IAssistCharacterSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3CC RID: 50124
		// (get) Token: 0x0602D809 RID: 186377 RVA: 0x0063A8FC File Offset: 0x00638AFC
		public EAssistCharacterMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAssistCharacterMoveType.Navigation;
				}
				return (EAssistCharacterMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3CD RID: 50125
		// (get) Token: 0x0602D80A RID: 186378 RVA: 0x0063A938 File Offset: 0x00638B38
		public int SplineId
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

		// Token: 0x0602D80B RID: 186379 RVA: 0x0063A974 File Offset: 0x00638B74
		public static Offset<IAssistCharacterSplineMove> CreateIAssistCharacterSplineMove(FlatBufferBuilder builder, EAssistCharacterMoveType Type = EAssistCharacterMoveType.Navigation, int SplineId = 0)
		{
			builder.StartTable(2);
			IAssistCharacterSplineMove.AddSplineId(builder, SplineId);
			IAssistCharacterSplineMove.AddType(builder, Type);
			return IAssistCharacterSplineMove.EndIAssistCharacterSplineMove(builder);
		}

		// Token: 0x0602D80C RID: 186380 RVA: 0x0063A991 File Offset: 0x00638B91
		public static void StartIAssistCharacterSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D80D RID: 186381 RVA: 0x0063A99A File Offset: 0x00638B9A
		public static void AddType(FlatBufferBuilder builder, EAssistCharacterMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D80E RID: 186382 RVA: 0x0063A9A5 File Offset: 0x00638BA5
		public static void AddSplineId(FlatBufferBuilder builder, int splineId)
		{
			builder.AddInt(1, splineId, 0);
		}

		// Token: 0x0602D80F RID: 186383 RVA: 0x0063A9B0 File Offset: 0x00638BB0
		public static Offset<IAssistCharacterSplineMove> EndIAssistCharacterSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<IAssistCharacterSplineMove>(builder.EndTable());
		}

		// Token: 0x0602D810 RID: 186384 RVA: 0x0063A9C0 File Offset: 0x00638BC0
		public IAssistCharacterSplineMoveT UnPack()
		{
			IAssistCharacterSplineMoveT assistCharacterSplineMoveT = new IAssistCharacterSplineMoveT();
			this.UnPackTo(assistCharacterSplineMoveT);
			return assistCharacterSplineMoveT;
		}

		// Token: 0x0602D811 RID: 186385 RVA: 0x0063A9DB File Offset: 0x00638BDB
		public void UnPackTo(IAssistCharacterSplineMoveT _o)
		{
			_o.Type = this.Type;
			_o.SplineId = this.SplineId;
		}

		// Token: 0x0602D812 RID: 186386 RVA: 0x0063A9F8 File Offset: 0x00638BF8
		public static Offset<IAssistCharacterSplineMove> Pack(FlatBufferBuilder builder, IAssistCharacterSplineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAssistCharacterSplineMove>);
			}
			return IAssistCharacterSplineMove.CreateIAssistCharacterSplineMove(builder, _o.Type, _o.SplineId);
		}

		// Token: 0x040114C6 RID: 70854
		private Table __p;
	}
}
