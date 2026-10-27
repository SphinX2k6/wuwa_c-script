using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060E3 RID: 24803
	public struct IActorLookAtOtherActor : IFlatbufferObject
	{
		// Token: 0x1700B6C9 RID: 46793
		// (get) Token: 0x0602A5DA RID: 173530 RVA: 0x005D69F8 File Offset: 0x005D4BF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A5DB RID: 173531 RVA: 0x005D6A05 File Offset: 0x005D4C05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A5DC RID: 173532 RVA: 0x005D6A0C File Offset: 0x005D4C0C
		public static IActorLookAtOtherActor GetRootAsIActorLookAtOtherActor(ByteBuffer _bb)
		{
			return IActorLookAtOtherActor.GetRootAsIActorLookAtOtherActor(_bb, default(IActorLookAtOtherActor));
		}

		// Token: 0x0602A5DD RID: 173533 RVA: 0x005D6A28 File Offset: 0x005D4C28
		public static IActorLookAtOtherActor GetRootAsIActorLookAtOtherActor(ByteBuffer _bb, IActorLookAtOtherActor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A5DE RID: 173534 RVA: 0x005D6A45 File Offset: 0x005D4C45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A5DF RID: 173535 RVA: 0x005D6A54 File Offset: 0x005D4C54
		public IActorLookAtOtherActor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6CA RID: 46794
		// (get) Token: 0x0602A5E0 RID: 173536 RVA: 0x005D6A64 File Offset: 0x005D4C64
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

		// Token: 0x1700B6CB RID: 46795
		// (get) Token: 0x0602A5E1 RID: 173537 RVA: 0x005D6AA0 File Offset: 0x005D4CA0
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6CC RID: 46796
		// (get) Token: 0x0602A5E2 RID: 173538 RVA: 0x005D6AE0 File Offset: 0x005D4CE0
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

		// Token: 0x1700B6CD RID: 46797
		// (get) Token: 0x0602A5E3 RID: 173539 RVA: 0x005D6B1C File Offset: 0x005D4D1C
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

		// Token: 0x0602A5E4 RID: 173540 RVA: 0x005D6B59 File Offset: 0x005D4D59
		public static Offset<IActorLookAtOtherActor> CreateIActorLookAtOtherActor(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, int ActorIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IActorLookAtOtherActor.AddActorIndex(builder, ActorIndex);
			IActorLookAtOtherActor.AddNullMask(builder, NullMask);
			IActorLookAtOtherActor.AddLock(builder, Lock);
			IActorLookAtOtherActor.AddType(builder, Type);
			return IActorLookAtOtherActor.EndIActorLookAtOtherActor(builder);
		}

		// Token: 0x0602A5E5 RID: 173541 RVA: 0x005D6B85 File Offset: 0x005D4D85
		public static void StartIActorLookAtOtherActor(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602A5E6 RID: 173542 RVA: 0x005D6B8E File Offset: 0x005D4D8E
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A5E7 RID: 173543 RVA: 0x005D6B99 File Offset: 0x005D4D99
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602A5E8 RID: 173544 RVA: 0x005D6BA4 File Offset: 0x005D4DA4
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(2, actorIndex, 0);
		}

		// Token: 0x0602A5E9 RID: 173545 RVA: 0x005D6BAF File Offset: 0x005D4DAF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602A5EA RID: 173546 RVA: 0x005D6BBA File Offset: 0x005D4DBA
		public static Offset<IActorLookAtOtherActor> EndIActorLookAtOtherActor(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtOtherActor>(builder.EndTable());
		}

		// Token: 0x0602A5EB RID: 173547 RVA: 0x005D6BC8 File Offset: 0x005D4DC8
		public IActorLookAtOtherActorT UnPack()
		{
			IActorLookAtOtherActorT actorLookAtOtherActorT = new IActorLookAtOtherActorT();
			this.UnPackTo(actorLookAtOtherActorT);
			return actorLookAtOtherActorT;
		}

		// Token: 0x0602A5EC RID: 173548 RVA: 0x005D6BE3 File Offset: 0x005D4DE3
		public void UnPackTo(IActorLookAtOtherActorT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.ActorIndex = this.ActorIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A5ED RID: 173549 RVA: 0x005D6C18 File Offset: 0x005D4E18
		public static Offset<IActorLookAtOtherActor> Pack(FlatBufferBuilder builder, IActorLookAtOtherActorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtOtherActor>);
			}
			return IActorLookAtOtherActor.CreateIActorLookAtOtherActor(builder, _o.Type, _o.Lock, _o.ActorIndex, _o.NullMask);
		}

		// Token: 0x040104A0 RID: 66720
		private Table __p;
	}
}
