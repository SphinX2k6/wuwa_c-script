using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060E6 RID: 24806
	public struct IActorLookAtPlayerData : IFlatbufferObject
	{
		// Token: 0x1700B6D2 RID: 46802
		// (get) Token: 0x0602A5F8 RID: 173560 RVA: 0x005D6D14 File Offset: 0x005D4F14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A5F9 RID: 173561 RVA: 0x005D6D21 File Offset: 0x005D4F21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A5FA RID: 173562 RVA: 0x005D6D28 File Offset: 0x005D4F28
		public static IActorLookAtPlayerData GetRootAsIActorLookAtPlayerData(ByteBuffer _bb)
		{
			return IActorLookAtPlayerData.GetRootAsIActorLookAtPlayerData(_bb, default(IActorLookAtPlayerData));
		}

		// Token: 0x0602A5FB RID: 173563 RVA: 0x005D6D44 File Offset: 0x005D4F44
		public static IActorLookAtPlayerData GetRootAsIActorLookAtPlayerData(ByteBuffer _bb, IActorLookAtPlayerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A5FC RID: 173564 RVA: 0x005D6D61 File Offset: 0x005D4F61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A5FD RID: 173565 RVA: 0x005D6D70 File Offset: 0x005D4F70
		public IActorLookAtPlayerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6D3 RID: 46803
		// (get) Token: 0x0602A5FE RID: 173566 RVA: 0x005D6D80 File Offset: 0x005D4F80
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

		// Token: 0x1700B6D4 RID: 46804
		// (get) Token: 0x0602A5FF RID: 173567 RVA: 0x005D6DBC File Offset: 0x005D4FBC
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6D5 RID: 46805
		// (get) Token: 0x0602A600 RID: 173568 RVA: 0x005D6DFC File Offset: 0x005D4FFC
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

		// Token: 0x0602A601 RID: 173569 RVA: 0x005D6E38 File Offset: 0x005D5038
		public static Offset<IActorLookAtPlayerData> CreateIActorLookAtPlayerData(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorLookAtPlayerData.AddNullMask(builder, NullMask);
			IActorLookAtPlayerData.AddLock(builder, Lock);
			IActorLookAtPlayerData.AddType(builder, Type);
			return IActorLookAtPlayerData.EndIActorLookAtPlayerData(builder);
		}

		// Token: 0x0602A602 RID: 173570 RVA: 0x005D6E5C File Offset: 0x005D505C
		public static void StartIActorLookAtPlayerData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A603 RID: 173571 RVA: 0x005D6E65 File Offset: 0x005D5065
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A604 RID: 173572 RVA: 0x005D6E70 File Offset: 0x005D5070
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602A605 RID: 173573 RVA: 0x005D6E7B File Offset: 0x005D507B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A606 RID: 173574 RVA: 0x005D6E86 File Offset: 0x005D5086
		public static Offset<IActorLookAtPlayerData> EndIActorLookAtPlayerData(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtPlayerData>(builder.EndTable());
		}

		// Token: 0x0602A607 RID: 173575 RVA: 0x005D6E94 File Offset: 0x005D5094
		public IActorLookAtPlayerDataT UnPack()
		{
			IActorLookAtPlayerDataT actorLookAtPlayerDataT = new IActorLookAtPlayerDataT();
			this.UnPackTo(actorLookAtPlayerDataT);
			return actorLookAtPlayerDataT;
		}

		// Token: 0x0602A608 RID: 173576 RVA: 0x005D6EAF File Offset: 0x005D50AF
		public void UnPackTo(IActorLookAtPlayerDataT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A609 RID: 173577 RVA: 0x005D6ED8 File Offset: 0x005D50D8
		public static Offset<IActorLookAtPlayerData> Pack(FlatBufferBuilder builder, IActorLookAtPlayerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtPlayerData>);
			}
			return IActorLookAtPlayerData.CreateIActorLookAtPlayerData(builder, _o.Type, _o.Lock, _o.NullMask);
		}

		// Token: 0x040104A5 RID: 66725
		private Table __p;
	}
}
