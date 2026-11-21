using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066FD RID: 26365
	public struct IActorFaceExpression : IFlatbufferObject
	{
		// Token: 0x1700BFA6 RID: 49062
		// (get) Token: 0x0602CA43 RID: 182851 RVA: 0x0061BDBF File Offset: 0x00619FBF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA44 RID: 182852 RVA: 0x0061BDCC File Offset: 0x00619FCC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA45 RID: 182853 RVA: 0x0061BDD4 File Offset: 0x00619FD4
		public static IActorFaceExpression GetRootAsIActorFaceExpression(ByteBuffer _bb)
		{
			return IActorFaceExpression.GetRootAsIActorFaceExpression(_bb, default(IActorFaceExpression));
		}

		// Token: 0x0602CA46 RID: 182854 RVA: 0x0061BDF0 File Offset: 0x00619FF0
		public static IActorFaceExpression GetRootAsIActorFaceExpression(ByteBuffer _bb, IActorFaceExpression obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA47 RID: 182855 RVA: 0x0061BE0D File Offset: 0x0061A00D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA48 RID: 182856 RVA: 0x0061BE1C File Offset: 0x0061A01C
		public IActorFaceExpression __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFA7 RID: 49063
		// (get) Token: 0x0602CA49 RID: 182857 RVA: 0x0061BE2C File Offset: 0x0061A02C
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

		// Token: 0x1700BFA8 RID: 49064
		// (get) Token: 0x0602CA4A RID: 182858 RVA: 0x0061BE68 File Offset: 0x0061A068
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

		// Token: 0x0602CA4B RID: 182859 RVA: 0x0061BEA4 File Offset: 0x0061A0A4
		public TTable? FaceExpression<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CA4C RID: 182860 RVA: 0x0061BEE8 File Offset: 0x0061A0E8
		public IActorFaceExpressionPlay FaceExpressionAsIActorFaceExpressionPlay()
		{
			return this.FaceExpression<IActorFaceExpressionPlay>().Value;
		}

		// Token: 0x0602CA4D RID: 182861 RVA: 0x0061BF04 File Offset: 0x0061A104
		public IActorFaceExpressionStop FaceExpressionAsIActorFaceExpressionStop()
		{
			return this.FaceExpression<IActorFaceExpressionStop>().Value;
		}

		// Token: 0x0602CA4E RID: 182862 RVA: 0x0061BF1F File Offset: 0x0061A11F
		public static Offset<IActorFaceExpression> CreateIActorFaceExpression(FlatBufferBuilder builder, int ActorIndex = 0, TActorFaceExpression FaceExpression_type = TActorFaceExpression.NONE, int FaceExpressionOffset = 0)
		{
			builder.StartTable(3);
			IActorFaceExpression.AddFaceExpression(builder, FaceExpressionOffset);
			IActorFaceExpression.AddActorIndex(builder, ActorIndex);
			IActorFaceExpression.AddFaceExpressionType(builder, FaceExpression_type);
			return IActorFaceExpression.EndIActorFaceExpression(builder);
		}

		// Token: 0x0602CA4F RID: 182863 RVA: 0x0061BF43 File Offset: 0x0061A143
		public static void StartIActorFaceExpression(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CA50 RID: 182864 RVA: 0x0061BF4C File Offset: 0x0061A14C
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602CA51 RID: 182865 RVA: 0x0061BF57 File Offset: 0x0061A157
		public static void AddFaceExpressionType(FlatBufferBuilder builder, TActorFaceExpression faceExpressionType)
		{
			builder.AddByte(1, (byte)faceExpressionType, 0);
		}

		// Token: 0x0602CA52 RID: 182866 RVA: 0x0061BF62 File Offset: 0x0061A162
		public static void AddFaceExpression(FlatBufferBuilder builder, int faceExpressionOffset)
		{
			builder.AddOffset(2, faceExpressionOffset, 0);
		}

		// Token: 0x0602CA53 RID: 182867 RVA: 0x0061BF6D File Offset: 0x0061A16D
		public static Offset<IActorFaceExpression> EndIActorFaceExpression(FlatBufferBuilder builder)
		{
			return new Offset<IActorFaceExpression>(builder.EndTable());
		}

		// Token: 0x0602CA54 RID: 182868 RVA: 0x0061BF7C File Offset: 0x0061A17C
		public IActorFaceExpressionT UnPack()
		{
			IActorFaceExpressionT actorFaceExpressionT = new IActorFaceExpressionT();
			this.UnPackTo(actorFaceExpressionT);
			return actorFaceExpressionT;
		}

		// Token: 0x0602CA55 RID: 182869 RVA: 0x0061BF98 File Offset: 0x0061A198
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

		// Token: 0x0602CA56 RID: 182870 RVA: 0x0061C048 File Offset: 0x0061A248
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

		// Token: 0x04011235 RID: 70197
		private Table __p;
	}
}
