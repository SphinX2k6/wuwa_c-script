using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200609E RID: 24734
	public struct IActorFaceExpressionPlay : IFlatbufferObject
	{
		// Token: 0x1700B640 RID: 46656
		// (get) Token: 0x0602A37C RID: 172924 RVA: 0x005D2194 File Offset: 0x005D0394
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A37D RID: 172925 RVA: 0x005D21A1 File Offset: 0x005D03A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A37E RID: 172926 RVA: 0x005D21A8 File Offset: 0x005D03A8
		public static IActorFaceExpressionPlay GetRootAsIActorFaceExpressionPlay(ByteBuffer _bb)
		{
			return IActorFaceExpressionPlay.GetRootAsIActorFaceExpressionPlay(_bb, default(IActorFaceExpressionPlay));
		}

		// Token: 0x0602A37F RID: 172927 RVA: 0x005D21C4 File Offset: 0x005D03C4
		public static IActorFaceExpressionPlay GetRootAsIActorFaceExpressionPlay(ByteBuffer _bb, IActorFaceExpressionPlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A380 RID: 172928 RVA: 0x005D21E1 File Offset: 0x005D03E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A381 RID: 172929 RVA: 0x005D21F0 File Offset: 0x005D03F0
		public IActorFaceExpressionPlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B641 RID: 46657
		// (get) Token: 0x0602A382 RID: 172930 RVA: 0x005D2200 File Offset: 0x005D0400
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

		// Token: 0x1700B642 RID: 46658
		// (get) Token: 0x0602A383 RID: 172931 RVA: 0x005D223C File Offset: 0x005D043C
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

		// Token: 0x1700B643 RID: 46659
		// (get) Token: 0x0602A384 RID: 172932 RVA: 0x005D2278 File Offset: 0x005D0478
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

		// Token: 0x1700B644 RID: 46660
		// (get) Token: 0x0602A385 RID: 172933 RVA: 0x005D22B8 File Offset: 0x005D04B8
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

		// Token: 0x0602A386 RID: 172934 RVA: 0x005D22F5 File Offset: 0x005D04F5
		public static Offset<IActorFaceExpressionPlay> CreateIActorFaceExpressionPlay(FlatBufferBuilder builder, EActorFaceExpressionType Type = EActorFaceExpressionType.Play, int FaceExpressionId = 0, float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IActorFaceExpressionPlay.AddDelayTime(builder, DelayTime);
			IActorFaceExpressionPlay.AddFaceExpressionId(builder, FaceExpressionId);
			IActorFaceExpressionPlay.AddNullMask(builder, NullMask);
			IActorFaceExpressionPlay.AddType(builder, Type);
			return IActorFaceExpressionPlay.EndIActorFaceExpressionPlay(builder);
		}

		// Token: 0x0602A387 RID: 172935 RVA: 0x005D2321 File Offset: 0x005D0521
		public static void StartIActorFaceExpressionPlay(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602A388 RID: 172936 RVA: 0x005D232A File Offset: 0x005D052A
		public static void AddType(FlatBufferBuilder builder, EActorFaceExpressionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A389 RID: 172937 RVA: 0x005D2335 File Offset: 0x005D0535
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(1, faceExpressionId, 0);
		}

		// Token: 0x0602A38A RID: 172938 RVA: 0x005D2340 File Offset: 0x005D0540
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(2, delayTime, 0.0);
		}

		// Token: 0x0602A38B RID: 172939 RVA: 0x005D2353 File Offset: 0x005D0553
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602A38C RID: 172940 RVA: 0x005D235E File Offset: 0x005D055E
		public static Offset<IActorFaceExpressionPlay> EndIActorFaceExpressionPlay(FlatBufferBuilder builder)
		{
			return new Offset<IActorFaceExpressionPlay>(builder.EndTable());
		}

		// Token: 0x0602A38D RID: 172941 RVA: 0x005D236C File Offset: 0x005D056C
		public IActorFaceExpressionPlayT UnPack()
		{
			IActorFaceExpressionPlayT actorFaceExpressionPlayT = new IActorFaceExpressionPlayT();
			this.UnPackTo(actorFaceExpressionPlayT);
			return actorFaceExpressionPlayT;
		}

		// Token: 0x0602A38E RID: 172942 RVA: 0x005D2387 File Offset: 0x005D0587
		public void UnPackTo(IActorFaceExpressionPlayT _o)
		{
			_o.Type = this.Type;
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A38F RID: 172943 RVA: 0x005D23BC File Offset: 0x005D05BC
		public static Offset<IActorFaceExpressionPlay> Pack(FlatBufferBuilder builder, IActorFaceExpressionPlayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFaceExpressionPlay>);
			}
			return IActorFaceExpressionPlay.CreateIActorFaceExpressionPlay(builder, _o.Type, _o.FaceExpressionId, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x04010434 RID: 66612
		private Table __p;
	}
}
