using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006748 RID: 26440
	public struct IActorLookAtPlayerData : IFlatbufferObject
	{
		// Token: 0x1700C03D RID: 49213
		// (get) Token: 0x0602CCD9 RID: 183513 RVA: 0x00620CBC File Offset: 0x0061EEBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CCDA RID: 183514 RVA: 0x00620CC9 File Offset: 0x0061EEC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CCDB RID: 183515 RVA: 0x00620CD0 File Offset: 0x0061EED0
		public static IActorLookAtPlayerData GetRootAsIActorLookAtPlayerData(ByteBuffer _bb)
		{
			return IActorLookAtPlayerData.GetRootAsIActorLookAtPlayerData(_bb, default(IActorLookAtPlayerData));
		}

		// Token: 0x0602CCDC RID: 183516 RVA: 0x00620CEC File Offset: 0x0061EEEC
		public static IActorLookAtPlayerData GetRootAsIActorLookAtPlayerData(ByteBuffer _bb, IActorLookAtPlayerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CCDD RID: 183517 RVA: 0x00620D09 File Offset: 0x0061EF09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CCDE RID: 183518 RVA: 0x00620D18 File Offset: 0x0061EF18
		public IActorLookAtPlayerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C03E RID: 49214
		// (get) Token: 0x0602CCDF RID: 183519 RVA: 0x00620D28 File Offset: 0x0061EF28
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

		// Token: 0x1700C03F RID: 49215
		// (get) Token: 0x0602CCE0 RID: 183520 RVA: 0x00620D64 File Offset: 0x0061EF64
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C040 RID: 49216
		// (get) Token: 0x0602CCE1 RID: 183521 RVA: 0x00620DA4 File Offset: 0x0061EFA4
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

		// Token: 0x0602CCE2 RID: 183522 RVA: 0x00620DE0 File Offset: 0x0061EFE0
		public static Offset<IActorLookAtPlayerData> CreateIActorLookAtPlayerData(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IActorLookAtPlayerData.AddNullMask(builder, NullMask);
			IActorLookAtPlayerData.AddLock(builder, Lock);
			IActorLookAtPlayerData.AddType(builder, Type);
			return IActorLookAtPlayerData.EndIActorLookAtPlayerData(builder);
		}

		// Token: 0x0602CCE3 RID: 183523 RVA: 0x00620E04 File Offset: 0x0061F004
		public static void StartIActorLookAtPlayerData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CCE4 RID: 183524 RVA: 0x00620E0D File Offset: 0x0061F00D
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CCE5 RID: 183525 RVA: 0x00620E18 File Offset: 0x0061F018
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602CCE6 RID: 183526 RVA: 0x00620E23 File Offset: 0x0061F023
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602CCE7 RID: 183527 RVA: 0x00620E2E File Offset: 0x0061F02E
		public static Offset<IActorLookAtPlayerData> EndIActorLookAtPlayerData(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtPlayerData>(builder.EndTable());
		}

		// Token: 0x0602CCE8 RID: 183528 RVA: 0x00620E3C File Offset: 0x0061F03C
		public IActorLookAtPlayerDataT UnPack()
		{
			IActorLookAtPlayerDataT actorLookAtPlayerDataT = new IActorLookAtPlayerDataT();
			this.UnPackTo(actorLookAtPlayerDataT);
			return actorLookAtPlayerDataT;
		}

		// Token: 0x0602CCE9 RID: 183529 RVA: 0x00620E57 File Offset: 0x0061F057
		public void UnPackTo(IActorLookAtPlayerDataT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CCEA RID: 183530 RVA: 0x00620E80 File Offset: 0x0061F080
		public static Offset<IActorLookAtPlayerData> Pack(FlatBufferBuilder builder, IActorLookAtPlayerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtPlayerData>);
			}
			return IActorLookAtPlayerData.CreateIActorLookAtPlayerData(builder, _o.Type, _o.Lock, _o.NullMask);
		}

		// Token: 0x040112A9 RID: 70313
		private Table __p;
	}
}
