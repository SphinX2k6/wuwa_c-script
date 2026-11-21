using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006703 RID: 26371
	public struct IActorFaceExpressionStop : IFlatbufferObject
	{
		// Token: 0x1700BFB4 RID: 49076
		// (get) Token: 0x0602CA7B RID: 182907 RVA: 0x0061C464 File Offset: 0x0061A664
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CA7C RID: 182908 RVA: 0x0061C471 File Offset: 0x0061A671
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CA7D RID: 182909 RVA: 0x0061C478 File Offset: 0x0061A678
		public static IActorFaceExpressionStop GetRootAsIActorFaceExpressionStop(ByteBuffer _bb)
		{
			return IActorFaceExpressionStop.GetRootAsIActorFaceExpressionStop(_bb, default(IActorFaceExpressionStop));
		}

		// Token: 0x0602CA7E RID: 182910 RVA: 0x0061C494 File Offset: 0x0061A694
		public static IActorFaceExpressionStop GetRootAsIActorFaceExpressionStop(ByteBuffer _bb, IActorFaceExpressionStop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CA7F RID: 182911 RVA: 0x0061C4B1 File Offset: 0x0061A6B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CA80 RID: 182912 RVA: 0x0061C4C0 File Offset: 0x0061A6C0
		public IActorFaceExpressionStop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFB5 RID: 49077
		// (get) Token: 0x0602CA81 RID: 182913 RVA: 0x0061C4D0 File Offset: 0x0061A6D0
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

		// Token: 0x1700BFB6 RID: 49078
		// (get) Token: 0x0602CA82 RID: 182914 RVA: 0x0061C50C File Offset: 0x0061A70C
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFB7 RID: 49079
		// (get) Token: 0x0602CA83 RID: 182915 RVA: 0x0061C54C File Offset: 0x0061A74C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CA84 RID: 182916 RVA: 0x0061C588 File Offset: 0x0061A788
		public static Offset<IActorFaceExpressionStop> CreateIActorFaceExpressionStop(FlatBufferBuilder builder, EActorFaceExpressionType Type = EActorFaceExpressionType.Play, float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorFaceExpressionStop.AddDelayTime(builder, DelayTime);
			IActorFaceExpressionStop.AddNullMask(builder, NullMask);
			IActorFaceExpressionStop.AddType(builder, Type);
			return IActorFaceExpressionStop.EndIActorFaceExpressionStop(builder);
		}

		// Token: 0x0602CA85 RID: 182917 RVA: 0x0061C5AC File Offset: 0x0061A7AC
		public static void StartIActorFaceExpressionStop(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CA86 RID: 182918 RVA: 0x0061C5B5 File Offset: 0x0061A7B5
		public static void AddType(FlatBufferBuilder builder, EActorFaceExpressionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CA87 RID: 182919 RVA: 0x0061C5C0 File Offset: 0x0061A7C0
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x0602CA88 RID: 182920 RVA: 0x0061C5D3 File Offset: 0x0061A7D3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602CA89 RID: 182921 RVA: 0x0061C5DE File Offset: 0x0061A7DE
		public static Offset<IActorFaceExpressionStop> EndIActorFaceExpressionStop(FlatBufferBuilder builder)
		{
			return new Offset<IActorFaceExpressionStop>(builder.EndTable());
		}

		// Token: 0x0602CA8A RID: 182922 RVA: 0x0061C5EC File Offset: 0x0061A7EC
		public IActorFaceExpressionStopT UnPack()
		{
			IActorFaceExpressionStopT actorFaceExpressionStopT = new IActorFaceExpressionStopT();
			this.UnPackTo(actorFaceExpressionStopT);
			return actorFaceExpressionStopT;
		}

		// Token: 0x0602CA8B RID: 182923 RVA: 0x0061C607 File Offset: 0x0061A807
		public void UnPackTo(IActorFaceExpressionStopT _o)
		{
			_o.Type = this.Type;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CA8C RID: 182924 RVA: 0x0061C630 File Offset: 0x0061A830
		public static Offset<IActorFaceExpressionStop> Pack(FlatBufferBuilder builder, IActorFaceExpressionStopT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFaceExpressionStop>);
			}
			return IActorFaceExpressionStop.CreateIActorFaceExpressionStop(builder, _o.Type, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x0401123D RID: 70205
		private Table __p;
	}
}
