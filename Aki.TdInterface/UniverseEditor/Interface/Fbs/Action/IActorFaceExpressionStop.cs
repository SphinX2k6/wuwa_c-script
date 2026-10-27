using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060A1 RID: 24737
	public struct IActorFaceExpressionStop : IFlatbufferObject
	{
		// Token: 0x1700B649 RID: 46665
		// (get) Token: 0x0602A39A RID: 172954 RVA: 0x005D24BC File Offset: 0x005D06BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A39B RID: 172955 RVA: 0x005D24C9 File Offset: 0x005D06C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A39C RID: 172956 RVA: 0x005D24D0 File Offset: 0x005D06D0
		public static IActorFaceExpressionStop GetRootAsIActorFaceExpressionStop(ByteBuffer _bb)
		{
			return IActorFaceExpressionStop.GetRootAsIActorFaceExpressionStop(_bb, default(IActorFaceExpressionStop));
		}

		// Token: 0x0602A39D RID: 172957 RVA: 0x005D24EC File Offset: 0x005D06EC
		public static IActorFaceExpressionStop GetRootAsIActorFaceExpressionStop(ByteBuffer _bb, IActorFaceExpressionStop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A39E RID: 172958 RVA: 0x005D2509 File Offset: 0x005D0709
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A39F RID: 172959 RVA: 0x005D2518 File Offset: 0x005D0718
		public IActorFaceExpressionStop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B64A RID: 46666
		// (get) Token: 0x0602A3A0 RID: 172960 RVA: 0x005D2528 File Offset: 0x005D0728
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

		// Token: 0x1700B64B RID: 46667
		// (get) Token: 0x0602A3A1 RID: 172961 RVA: 0x005D2564 File Offset: 0x005D0764
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

		// Token: 0x1700B64C RID: 46668
		// (get) Token: 0x0602A3A2 RID: 172962 RVA: 0x005D25A4 File Offset: 0x005D07A4
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

		// Token: 0x0602A3A3 RID: 172963 RVA: 0x005D25E0 File Offset: 0x005D07E0
		public static Offset<IActorFaceExpressionStop> CreateIActorFaceExpressionStop(FlatBufferBuilder builder, EActorFaceExpressionType Type = EActorFaceExpressionType.Play, float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorFaceExpressionStop.AddDelayTime(builder, DelayTime);
			IActorFaceExpressionStop.AddNullMask(builder, NullMask);
			IActorFaceExpressionStop.AddType(builder, Type);
			return IActorFaceExpressionStop.EndIActorFaceExpressionStop(builder);
		}

		// Token: 0x0602A3A4 RID: 172964 RVA: 0x005D2604 File Offset: 0x005D0804
		public static void StartIActorFaceExpressionStop(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A3A5 RID: 172965 RVA: 0x005D260D File Offset: 0x005D080D
		public static void AddType(FlatBufferBuilder builder, EActorFaceExpressionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A3A6 RID: 172966 RVA: 0x005D2618 File Offset: 0x005D0818
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x0602A3A7 RID: 172967 RVA: 0x005D262B File Offset: 0x005D082B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A3A8 RID: 172968 RVA: 0x005D2636 File Offset: 0x005D0836
		public static Offset<IActorFaceExpressionStop> EndIActorFaceExpressionStop(FlatBufferBuilder builder)
		{
			return new Offset<IActorFaceExpressionStop>(builder.EndTable());
		}

		// Token: 0x0602A3A9 RID: 172969 RVA: 0x005D2644 File Offset: 0x005D0844
		public IActorFaceExpressionStopT UnPack()
		{
			IActorFaceExpressionStopT actorFaceExpressionStopT = new IActorFaceExpressionStopT();
			this.UnPackTo(actorFaceExpressionStopT);
			return actorFaceExpressionStopT;
		}

		// Token: 0x0602A3AA RID: 172970 RVA: 0x005D265F File Offset: 0x005D085F
		public void UnPackTo(IActorFaceExpressionStopT _o)
		{
			_o.Type = this.Type;
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A3AB RID: 172971 RVA: 0x005D2688 File Offset: 0x005D0888
		public static Offset<IActorFaceExpressionStop> Pack(FlatBufferBuilder builder, IActorFaceExpressionStopT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFaceExpressionStop>);
			}
			return IActorFaceExpressionStop.CreateIActorFaceExpressionStop(builder, _o.Type, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x04010439 RID: 66617
		private Table __p;
	}
}
