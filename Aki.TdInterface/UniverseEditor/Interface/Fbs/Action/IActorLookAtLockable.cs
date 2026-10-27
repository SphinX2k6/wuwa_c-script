using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060E0 RID: 24800
	public struct IActorLookAtLockable : IFlatbufferObject
	{
		// Token: 0x1700B6C2 RID: 46786
		// (get) Token: 0x0602A5C0 RID: 173504 RVA: 0x005D6764 File Offset: 0x005D4964
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A5C1 RID: 173505 RVA: 0x005D6771 File Offset: 0x005D4971
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A5C2 RID: 173506 RVA: 0x005D6778 File Offset: 0x005D4978
		public static IActorLookAtLockable GetRootAsIActorLookAtLockable(ByteBuffer _bb)
		{
			return IActorLookAtLockable.GetRootAsIActorLookAtLockable(_bb, default(IActorLookAtLockable));
		}

		// Token: 0x0602A5C3 RID: 173507 RVA: 0x005D6794 File Offset: 0x005D4994
		public static IActorLookAtLockable GetRootAsIActorLookAtLockable(ByteBuffer _bb, IActorLookAtLockable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A5C4 RID: 173508 RVA: 0x005D67B1 File Offset: 0x005D49B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A5C5 RID: 173509 RVA: 0x005D67C0 File Offset: 0x005D49C0
		public IActorLookAtLockable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6C3 RID: 46787
		// (get) Token: 0x0602A5C6 RID: 173510 RVA: 0x005D67D0 File Offset: 0x005D49D0
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

		// Token: 0x1700B6C4 RID: 46788
		// (get) Token: 0x0602A5C7 RID: 173511 RVA: 0x005D680C File Offset: 0x005D4A0C
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6C5 RID: 46789
		// (get) Token: 0x0602A5C8 RID: 173512 RVA: 0x005D684C File Offset: 0x005D4A4C
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

		// Token: 0x0602A5C9 RID: 173513 RVA: 0x005D6888 File Offset: 0x005D4A88
		public static Offset<IActorLookAtLockable> CreateIActorLookAtLockable(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorLookAtLockable.AddNullMask(builder, NullMask);
			IActorLookAtLockable.AddLock(builder, Lock);
			IActorLookAtLockable.AddType(builder, Type);
			return IActorLookAtLockable.EndIActorLookAtLockable(builder);
		}

		// Token: 0x0602A5CA RID: 173514 RVA: 0x005D68AC File Offset: 0x005D4AAC
		public static void StartIActorLookAtLockable(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A5CB RID: 173515 RVA: 0x005D68B5 File Offset: 0x005D4AB5
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A5CC RID: 173516 RVA: 0x005D68C0 File Offset: 0x005D4AC0
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602A5CD RID: 173517 RVA: 0x005D68CB File Offset: 0x005D4ACB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A5CE RID: 173518 RVA: 0x005D68D6 File Offset: 0x005D4AD6
		public static Offset<IActorLookAtLockable> EndIActorLookAtLockable(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtLockable>(builder.EndTable());
		}

		// Token: 0x0602A5CF RID: 173519 RVA: 0x005D68E4 File Offset: 0x005D4AE4
		public IActorLookAtLockableT UnPack()
		{
			IActorLookAtLockableT actorLookAtLockableT = new IActorLookAtLockableT();
			this.UnPackTo(actorLookAtLockableT);
			return actorLookAtLockableT;
		}

		// Token: 0x0602A5D0 RID: 173520 RVA: 0x005D68FF File Offset: 0x005D4AFF
		public void UnPackTo(IActorLookAtLockableT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A5D1 RID: 173521 RVA: 0x005D6928 File Offset: 0x005D4B28
		public static Offset<IActorLookAtLockable> Pack(FlatBufferBuilder builder, IActorLookAtLockableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtLockable>);
			}
			return IActorLookAtLockable.CreateIActorLookAtLockable(builder, _o.Type, _o.Lock, _o.NullMask);
		}

		// Token: 0x0401049C RID: 66716
		private Table __p;
	}
}
