using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006706 RID: 26374
	public struct IActorFaceExpressionType : IFlatbufferObject
	{
		// Token: 0x1700BFBB RID: 49083
		// (get) Token: 0x0602CA95 RID: 182933 RVA: 0x0061C704 File Offset: 0x0061A904
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA96 RID: 182934 RVA: 0x0061C711 File Offset: 0x0061A911
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA97 RID: 182935 RVA: 0x0061C718 File Offset: 0x0061A918
		public static IActorFaceExpressionType GetRootAsIActorFaceExpressionType(ByteBuffer _bb)
		{
			return IActorFaceExpressionType.GetRootAsIActorFaceExpressionType(_bb, default(IActorFaceExpressionType));
		}

		// Token: 0x0602CA98 RID: 182936 RVA: 0x0061C734 File Offset: 0x0061A934
		public static IActorFaceExpressionType GetRootAsIActorFaceExpressionType(ByteBuffer _bb, IActorFaceExpressionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA99 RID: 182937 RVA: 0x0061C751 File Offset: 0x0061A951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA9A RID: 182938 RVA: 0x0061C760 File Offset: 0x0061A960
		public IActorFaceExpressionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFBC RID: 49084
		// (get) Token: 0x0602CA9B RID: 182939 RVA: 0x0061C770 File Offset: 0x0061A970
		public EActorFaceExpressionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorFaceExpressionType.Play;
				}
				return (EActorFaceExpressionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CA9C RID: 182940 RVA: 0x0061C7AC File Offset: 0x0061A9AC
		public static Offset<IActorFaceExpressionType> CreateIActorFaceExpressionType(FlatBufferBuilder builder, EActorFaceExpressionType Type = EActorFaceExpressionType.Play)
		{
			builder.StartTable(1);
			IActorFaceExpressionType.AddType(builder, Type);
			return IActorFaceExpressionType.EndIActorFaceExpressionType(builder);
		}

		// Token: 0x0602CA9D RID: 182941 RVA: 0x0061C7C2 File Offset: 0x0061A9C2
		public static void StartIActorFaceExpressionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CA9E RID: 182942 RVA: 0x0061C7CB File Offset: 0x0061A9CB
		public static void AddType(FlatBufferBuilder builder, EActorFaceExpressionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CA9F RID: 182943 RVA: 0x0061C7D6 File Offset: 0x0061A9D6
		public static Offset<IActorFaceExpressionType> EndIActorFaceExpressionType(FlatBufferBuilder builder)
		{
			return new Offset<IActorFaceExpressionType>(builder.EndTable());
		}

		// Token: 0x0602CAA0 RID: 182944 RVA: 0x0061C7E4 File Offset: 0x0061A9E4
		public IActorFaceExpressionTypeT UnPack()
		{
			IActorFaceExpressionTypeT actorFaceExpressionTypeT = new IActorFaceExpressionTypeT();
			this.UnPackTo(actorFaceExpressionTypeT);
			return actorFaceExpressionTypeT;
		}

		// Token: 0x0602CAA1 RID: 182945 RVA: 0x0061C7FF File Offset: 0x0061A9FF
		public void UnPackTo(IActorFaceExpressionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CAA2 RID: 182946 RVA: 0x0061C810 File Offset: 0x0061AA10
		public static Offset<IActorFaceExpressionType> Pack(FlatBufferBuilder builder, IActorFaceExpressionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFaceExpressionType>);
			}
			return IActorFaceExpressionType.CreateIActorFaceExpressionType(builder, _o.Type);
		}

		// Token: 0x04011241 RID: 70209
		private Table __p;
	}
}
