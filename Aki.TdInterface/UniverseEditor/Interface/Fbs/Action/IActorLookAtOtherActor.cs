using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006745 RID: 26437
	public struct IActorLookAtOtherActor : IFlatbufferObject
	{
		// Token: 0x1700C034 RID: 49204
		// (get) Token: 0x0602CCBB RID: 183483 RVA: 0x006209A0 File Offset: 0x0061EBA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CCBC RID: 183484 RVA: 0x006209AD File Offset: 0x0061EBAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CCBD RID: 183485 RVA: 0x006209B4 File Offset: 0x0061EBB4
		public static IActorLookAtOtherActor GetRootAsIActorLookAtOtherActor(ByteBuffer _bb)
		{
			return IActorLookAtOtherActor.GetRootAsIActorLookAtOtherActor(_bb, default(IActorLookAtOtherActor));
		}

		// Token: 0x0602CCBE RID: 183486 RVA: 0x006209D0 File Offset: 0x0061EBD0
		public static IActorLookAtOtherActor GetRootAsIActorLookAtOtherActor(ByteBuffer _bb, IActorLookAtOtherActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CCBF RID: 183487 RVA: 0x006209ED File Offset: 0x0061EBED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CCC0 RID: 183488 RVA: 0x006209FC File Offset: 0x0061EBFC
		public IActorLookAtOtherActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C035 RID: 49205
		// (get) Token: 0x0602CCC1 RID: 183489 RVA: 0x00620A0C File Offset: 0x0061EC0C
		public EActorLookAtMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorLookAtMode.Talker;
				}
				return (EActorLookAtMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C036 RID: 49206
		// (get) Token: 0x0602CCC2 RID: 183490 RVA: 0x00620A48 File Offset: 0x0061EC48
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C037 RID: 49207
		// (get) Token: 0x0602CCC3 RID: 183491 RVA: 0x00620A88 File Offset: 0x0061EC88
		public int ActorIndex
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C038 RID: 49208
		// (get) Token: 0x0602CCC4 RID: 183492 RVA: 0x00620AC4 File Offset: 0x0061ECC4
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

		// Token: 0x0602CCC5 RID: 183493 RVA: 0x00620B01 File Offset: 0x0061ED01
		public static Offset<IActorLookAtOtherActor> CreateIActorLookAtOtherActor(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, int ActorIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IActorLookAtOtherActor.AddActorIndex(builder, ActorIndex);
			IActorLookAtOtherActor.AddNullMask(builder, NullMask);
			IActorLookAtOtherActor.AddLock(builder, Lock);
			IActorLookAtOtherActor.AddType(builder, Type);
			return IActorLookAtOtherActor.EndIActorLookAtOtherActor(builder);
		}

		// Token: 0x0602CCC6 RID: 183494 RVA: 0x00620B2D File Offset: 0x0061ED2D
		public static void StartIActorLookAtOtherActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602CCC7 RID: 183495 RVA: 0x00620B36 File Offset: 0x0061ED36
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CCC8 RID: 183496 RVA: 0x00620B41 File Offset: 0x0061ED41
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602CCC9 RID: 183497 RVA: 0x00620B4C File Offset: 0x0061ED4C
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(2, actorIndex, 0);
		}

		// Token: 0x0602CCCA RID: 183498 RVA: 0x00620B57 File Offset: 0x0061ED57
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602CCCB RID: 183499 RVA: 0x00620B62 File Offset: 0x0061ED62
		public static Offset<IActorLookAtOtherActor> EndIActorLookAtOtherActor(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtOtherActor>(builder.EndTable());
		}

		// Token: 0x0602CCCC RID: 183500 RVA: 0x00620B70 File Offset: 0x0061ED70
		public IActorLookAtOtherActorT UnPack()
		{
			IActorLookAtOtherActorT actorLookAtOtherActorT = new IActorLookAtOtherActorT();
			this.UnPackTo(actorLookAtOtherActorT);
			return actorLookAtOtherActorT;
		}

		// Token: 0x0602CCCD RID: 183501 RVA: 0x00620B8B File Offset: 0x0061ED8B
		public void UnPackTo(IActorLookAtOtherActorT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.ActorIndex = this.ActorIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CCCE RID: 183502 RVA: 0x00620BC0 File Offset: 0x0061EDC0
		public static Offset<IActorLookAtOtherActor> Pack(FlatBufferBuilder builder, IActorLookAtOtherActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtOtherActor>);
			}
			return IActorLookAtOtherActor.CreateIActorLookAtOtherActor(builder, _o.Type, _o.Lock, _o.ActorIndex, _o.NullMask);
		}

		// Token: 0x040112A4 RID: 70308
		private Table __p;
	}
}
