using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200609B RID: 24731
	public struct IActorFaceExpression : IFlatbufferObject
	{
		// Token: 0x1700B63B RID: 46651
		// (get) Token: 0x0602A362 RID: 172898 RVA: 0x005D1E17 File Offset: 0x005D0017
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A363 RID: 172899 RVA: 0x005D1E24 File Offset: 0x005D0024
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A364 RID: 172900 RVA: 0x005D1E2C File Offset: 0x005D002C
		public static IActorFaceExpression GetRootAsIActorFaceExpression(ByteBuffer _bb)
		{
			return IActorFaceExpression.GetRootAsIActorFaceExpression(_bb, default(IActorFaceExpression));
		}

		// Token: 0x0602A365 RID: 172901 RVA: 0x005D1E48 File Offset: 0x005D0048
		public static IActorFaceExpression GetRootAsIActorFaceExpression(ByteBuffer _bb, IActorFaceExpression obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A366 RID: 172902 RVA: 0x005D1E65 File Offset: 0x005D0065
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A367 RID: 172903 RVA: 0x005D1E74 File Offset: 0x005D0074
		public IActorFaceExpression __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B63C RID: 46652
		// (get) Token: 0x0602A368 RID: 172904 RVA: 0x005D1E84 File Offset: 0x005D0084
		public int ActorIndex
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

		// Token: 0x1700B63D RID: 46653
		// (get) Token: 0x0602A369 RID: 172905 RVA: 0x005D1EC0 File Offset: 0x005D00C0
		public TActorFaceExpression FaceExpressionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TActorFaceExpression.NONE;
				}
				return (TActorFaceExpression)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A36A RID: 172906 RVA: 0x005D1EFC File Offset: 0x005D00FC
		public TTable? FaceExpression<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A36B RID: 172907 RVA: 0x005D1F40 File Offset: 0x005D0140
		public IActorFaceExpressionPlay FaceExpressionAsIActorFaceExpressionPlay()
		{
			return this.FaceExpression<IActorFaceExpressionPlay>().Value;
		}

		// Token: 0x0602A36C RID: 172908 RVA: 0x005D1F5C File Offset: 0x005D015C
		public IActorFaceExpressionStop FaceExpressionAsIActorFaceExpressionStop()
		{
			return this.FaceExpression<IActorFaceExpressionStop>().Value;
		}

		// Token: 0x0602A36D RID: 172909 RVA: 0x005D1F77 File Offset: 0x005D0177
		public static Offset<IActorFaceExpression> CreateIActorFaceExpression(FlatBufferBuilder builder, int ActorIndex = 0, TActorFaceExpression FaceExpression_type = TActorFaceExpression.NONE, int FaceExpressionOffset = 0)
		{
			builder.StartTable(3);
			IActorFaceExpression.AddFaceExpression(builder, FaceExpressionOffset);
			IActorFaceExpression.AddActorIndex(builder, ActorIndex);
			IActorFaceExpression.AddFaceExpressionType(builder, FaceExpression_type);
			return IActorFaceExpression.EndIActorFaceExpression(builder);
		}

		// Token: 0x0602A36E RID: 172910 RVA: 0x005D1F9B File Offset: 0x005D019B
		public static void StartIActorFaceExpression(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A36F RID: 172911 RVA: 0x005D1FA4 File Offset: 0x005D01A4
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602A370 RID: 172912 RVA: 0x005D1FAF File Offset: 0x005D01AF
		public static void AddFaceExpressionType(FlatBufferBuilder builder, TActorFaceExpression faceExpressionType)
		{
			builder.AddByte(1, (byte)faceExpressionType, 0);
		}

		// Token: 0x0602A371 RID: 172913 RVA: 0x005D1FBA File Offset: 0x005D01BA
		public static void AddFaceExpression(FlatBufferBuilder builder, int faceExpressionOffset)
		{
			builder.AddOffset(2, faceExpressionOffset, 0);
		}

		// Token: 0x0602A372 RID: 172914 RVA: 0x005D1FC5 File Offset: 0x005D01C5
		public static Offset<IActorFaceExpression> EndIActorFaceExpression(FlatBufferBuilder builder)
		{
			return new Offset<IActorFaceExpression>(builder.EndTable());
		}

		// Token: 0x0602A373 RID: 172915 RVA: 0x005D1FD4 File Offset: 0x005D01D4
		public IActorFaceExpressionT UnPack()
		{
			IActorFaceExpressionT actorFaceExpressionT = new IActorFaceExpressionT();
			this.UnPackTo(actorFaceExpressionT);
			return actorFaceExpressionT;
		}

		// Token: 0x0602A374 RID: 172916 RVA: 0x005D1FF0 File Offset: 0x005D01F0
		public void UnPackTo(IActorFaceExpressionT _o)
		{
			_o.ActorIndex = this.ActorIndex;
			_o.FaceExpression = new TActorFaceExpressionUnion();
			_o.FaceExpression.Type = this.FaceExpressionType;
			TActorFaceExpression faceExpressionType = this.FaceExpressionType;
			if (faceExpressionType == TActorFaceExpression.IActorFaceExpressionPlay)
			{
				_o.FaceExpression.Value = ((this.FaceExpression<IActorFaceExpressionPlay>() != null) ? this.FaceExpression<IActorFaceExpressionPlay>().Value.UnPack() : null);
				return;
			}
			if (faceExpressionType != TActorFaceExpression.IActorFaceExpressionStop)
			{
				return;
			}
			_o.FaceExpression.Value = ((this.FaceExpression<IActorFaceExpressionStop>() != null) ? this.FaceExpression<IActorFaceExpressionStop>().Value.UnPack() : null);
		}

		// Token: 0x0602A375 RID: 172917 RVA: 0x005D20A0 File Offset: 0x005D02A0
		public static Offset<IActorFaceExpression> Pack(FlatBufferBuilder builder, IActorFaceExpressionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFaceExpression>);
			}
			TActorFaceExpression faceExpression_type = (_o.FaceExpression == null) ? TActorFaceExpression.NONE : _o.FaceExpression.Type;
			int faceExpressionOffset = (_o.FaceExpression == null) ? 0 : TActorFaceExpressionUnion.Pack(builder, _o.FaceExpression);
			return IActorFaceExpression.CreateIActorFaceExpression(builder, _o.ActorIndex, faceExpression_type, faceExpressionOffset);
		}

		// Token: 0x04010431 RID: 66609
		private Table __p;
	}
}
