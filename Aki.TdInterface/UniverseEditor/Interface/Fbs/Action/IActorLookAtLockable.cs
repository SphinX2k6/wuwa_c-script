using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006742 RID: 26434
	public struct IActorLookAtLockable : IFlatbufferObject
	{
		// Token: 0x1700C02D RID: 49197
		// (get) Token: 0x0602CCA1 RID: 183457 RVA: 0x0062070C File Offset: 0x0061E90C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CCA2 RID: 183458 RVA: 0x00620719 File Offset: 0x0061E919
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CCA3 RID: 183459 RVA: 0x00620720 File Offset: 0x0061E920
		public static IActorLookAtLockable GetRootAsIActorLookAtLockable(ByteBuffer _bb)
		{
			return IActorLookAtLockable.GetRootAsIActorLookAtLockable(_bb, default(IActorLookAtLockable));
		}

		// Token: 0x0602CCA4 RID: 183460 RVA: 0x0062073C File Offset: 0x0061E93C
		public static IActorLookAtLockable GetRootAsIActorLookAtLockable(ByteBuffer _bb, IActorLookAtLockable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CCA5 RID: 183461 RVA: 0x00620759 File Offset: 0x0061E959
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CCA6 RID: 183462 RVA: 0x00620768 File Offset: 0x0061E968
		public IActorLookAtLockable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C02E RID: 49198
		// (get) Token: 0x0602CCA7 RID: 183463 RVA: 0x00620778 File Offset: 0x0061E978
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

		// Token: 0x1700C02F RID: 49199
		// (get) Token: 0x0602CCA8 RID: 183464 RVA: 0x006207B4 File Offset: 0x0061E9B4
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C030 RID: 49200
		// (get) Token: 0x0602CCA9 RID: 183465 RVA: 0x006207F4 File Offset: 0x0061E9F4
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

		// Token: 0x0602CCAA RID: 183466 RVA: 0x00620830 File Offset: 0x0061EA30
		public static Offset<IActorLookAtLockable> CreateIActorLookAtLockable(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorLookAtLockable.AddNullMask(builder, NullMask);
			IActorLookAtLockable.AddLock(builder, Lock);
			IActorLookAtLockable.AddType(builder, Type);
			return IActorLookAtLockable.EndIActorLookAtLockable(builder);
		}

		// Token: 0x0602CCAB RID: 183467 RVA: 0x00620854 File Offset: 0x0061EA54
		public static void StartIActorLookAtLockable(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CCAC RID: 183468 RVA: 0x0062085D File Offset: 0x0061EA5D
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CCAD RID: 183469 RVA: 0x00620868 File Offset: 0x0061EA68
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602CCAE RID: 183470 RVA: 0x00620873 File Offset: 0x0061EA73
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602CCAF RID: 183471 RVA: 0x0062087E File Offset: 0x0061EA7E
		public static Offset<IActorLookAtLockable> EndIActorLookAtLockable(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtLockable>(builder.EndTable());
		}

		// Token: 0x0602CCB0 RID: 183472 RVA: 0x0062088C File Offset: 0x0061EA8C
		public IActorLookAtLockableT UnPack()
		{
			IActorLookAtLockableT actorLookAtLockableT = new IActorLookAtLockableT();
			this.UnPackTo(actorLookAtLockableT);
			return actorLookAtLockableT;
		}

		// Token: 0x0602CCB1 RID: 183473 RVA: 0x006208A7 File Offset: 0x0061EAA7
		public void UnPackTo(IActorLookAtLockableT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CCB2 RID: 183474 RVA: 0x006208D0 File Offset: 0x0061EAD0
		public static Offset<IActorLookAtLockable> Pack(FlatBufferBuilder builder, IActorLookAtLockableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtLockable>);
			}
			return IActorLookAtLockable.CreateIActorLookAtLockable(builder, _o.Type, _o.Lock, _o.NullMask);
		}

		// Token: 0x040112A0 RID: 70304
		private Table __p;
	}
}
