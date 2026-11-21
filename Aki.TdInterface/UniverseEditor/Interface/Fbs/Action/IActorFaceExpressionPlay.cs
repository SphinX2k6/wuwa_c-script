using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006700 RID: 26368
	public struct IActorFaceExpressionPlay : IFlatbufferObject
	{
		// Token: 0x1700BFAB RID: 49067
		// (get) Token: 0x0602CA5D RID: 182877 RVA: 0x0061C13C File Offset: 0x0061A33C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA5E RID: 182878 RVA: 0x0061C149 File Offset: 0x0061A349
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA5F RID: 182879 RVA: 0x0061C150 File Offset: 0x0061A350
		public static IActorFaceExpressionPlay GetRootAsIActorFaceExpressionPlay(ByteBuffer _bb)
		{
			return IActorFaceExpressionPlay.GetRootAsIActorFaceExpressionPlay(_bb, default(IActorFaceExpressionPlay));
		}

		// Token: 0x0602CA60 RID: 182880 RVA: 0x0061C16C File Offset: 0x0061A36C
		public static IActorFaceExpressionPlay GetRootAsIActorFaceExpressionPlay(ByteBuffer _bb, IActorFaceExpressionPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA61 RID: 182881 RVA: 0x0061C189 File Offset: 0x0061A389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA62 RID: 182882 RVA: 0x0061C198 File Offset: 0x0061A398
		public IActorFaceExpressionPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFAC RID: 49068
		// (get) Token: 0x0602CA63 RID: 182883 RVA: 0x0061C1A8 File Offset: 0x0061A3A8
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

		// Token: 0x1700BFAD RID: 49069
		// (get) Token: 0x0602CA64 RID: 182884 RVA: 0x0061C1E4 File Offset: 0x0061A3E4
		public int FaceExpressionId
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

		// Token: 0x1700BFAE RID: 49070
		// (get) Token: 0x0602CA65 RID: 182885 RVA: 0x0061C220 File Offset: 0x0061A420
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFAF RID: 49071
		// (get) Token: 0x0602CA66 RID: 182886 RVA: 0x0061C260 File Offset: 0x0061A460
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CA67 RID: 182887 RVA: 0x0061C29D File Offset: 0x0061A49D
		public static Offset<IActorFaceExpressionPlay> CreateIActorFaceExpressionPlay(FlatBufferBuilder builder, EActorFaceExpressionType Type = EActorFaceExpressionType.Play, int FaceExpressionId = 0, float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IActorFaceExpressionPlay.AddDelayTime(builder, DelayTime);
			IActorFaceExpressionPlay.AddFaceExpressionId(builder, FaceExpressionId);
			IActorFaceExpressionPlay.AddNullMask(builder, NullMask);
			IActorFaceExpressionPlay.AddType(builder, Type);
			return IActorFaceExpressionPlay.EndIActorFaceExpressionPlay(builder);
		}

		// Token: 0x0602CA68 RID: 182888 RVA: 0x0061C2C9 File Offset: 0x0061A4C9
		public static void StartIActorFaceExpressionPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602CA69 RID: 182889 RVA: 0x0061C2D2 File Offset: 0x0061A4D2
		public static void AddType(FlatBufferBuilder builder, EActorFaceExpressionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CA6A RID: 182890 RVA: 0x0061C2DD File Offset: 0x0061A4DD
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(1, faceExpressionId, 0);
		}

		// Token: 0x0602CA6B RID: 182891 RVA: 0x0061C2E8 File Offset: 0x0061A4E8
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(2, delayTime, 0.0);
		}

		// Token: 0x0602CA6C RID: 182892 RVA: 0x0061C2FB File Offset: 0x0061A4FB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602CA6D RID: 182893 RVA: 0x0061C306 File Offset: 0x0061A506
		public static Offset<IActorFaceExpressionPlay> EndIActorFaceExpressionPlay(FlatBufferBuilder builder)
		{
			return new Offset<IActorFaceExpressionPlay>(builder.EndTable());
		}

		// Token: 0x0602CA6E RID: 182894 RVA: 0x0061C314 File Offset: 0x0061A514
		public IActorFaceExpressionPlayT UnPack()
		{
			IActorFaceExpressionPlayT actorFaceExpressionPlayT = new IActorFaceExpressionPlayT();
			this.UnPackTo(actorFaceExpressionPlayT);
			return actorFaceExpressionPlayT;
		}

		// Token: 0x0602CA6F RID: 182895 RVA: 0x0061C32F File Offset: 0x0061A52F
		public void UnPackTo(IActorFaceExpressionPlayT _o)
		{
			_o.Type = this.Type;
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CA70 RID: 182896 RVA: 0x0061C364 File Offset: 0x0061A564
		public static Offset<IActorFaceExpressionPlay> Pack(FlatBufferBuilder builder, IActorFaceExpressionPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFaceExpressionPlay>);
			}
			return IActorFaceExpressionPlay.CreateIActorFaceExpressionPlay(builder, _o.Type, _o.FaceExpressionId, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x04011238 RID: 70200
		private Table __p;
	}
}
