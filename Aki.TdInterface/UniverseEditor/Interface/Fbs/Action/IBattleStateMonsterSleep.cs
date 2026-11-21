using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006862 RID: 26722
	public struct IBattleStateMonsterSleep : IFlatbufferObject
	{
		// Token: 0x1700C472 RID: 50290
		// (get) Token: 0x0602DAD4 RID: 187092 RVA: 0x0063F495 File Offset: 0x0063D695
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DAD5 RID: 187093 RVA: 0x0063F4A2 File Offset: 0x0063D6A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DAD6 RID: 187094 RVA: 0x0063F4AC File Offset: 0x0063D6AC
		public static IBattleStateMonsterSleep GetRootAsIBattleStateMonsterSleep(ByteBuffer _bb)
		{
			return IBattleStateMonsterSleep.GetRootAsIBattleStateMonsterSleep(_bb, default(IBattleStateMonsterSleep));
		}

		// Token: 0x0602DAD7 RID: 187095 RVA: 0x0063F4C8 File Offset: 0x0063D6C8
		public static IBattleStateMonsterSleep GetRootAsIBattleStateMonsterSleep(ByteBuffer _bb, IBattleStateMonsterSleep obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DAD8 RID: 187096 RVA: 0x0063F4E5 File Offset: 0x0063D6E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DAD9 RID: 187097 RVA: 0x0063F4F4 File Offset: 0x0063D6F4
		public IBattleStateMonsterSleep __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C473 RID: 50291
		// (get) Token: 0x0602DADA RID: 187098 RVA: 0x0063F504 File Offset: 0x0063D704
		public ESetBattleTagType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetBattleTagType.BattleMonsterLanding;
				}
				return (ESetBattleTagType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DADB RID: 187099 RVA: 0x0063F540 File Offset: 0x0063D740
		public static Offset<IBattleStateMonsterSleep> CreateIBattleStateMonsterSleep(FlatBufferBuilder builder, ESetBattleTagType Type = ESetBattleTagType.BattleMonsterLanding)
		{
			builder.StartTable(1);
			IBattleStateMonsterSleep.AddType(builder, Type);
			return IBattleStateMonsterSleep.EndIBattleStateMonsterSleep(builder);
		}

		// Token: 0x0602DADC RID: 187100 RVA: 0x0063F556 File Offset: 0x0063D756
		public static void StartIBattleStateMonsterSleep(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DADD RID: 187101 RVA: 0x0063F55F File Offset: 0x0063D75F
		public static void AddType(FlatBufferBuilder builder, ESetBattleTagType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DADE RID: 187102 RVA: 0x0063F56A File Offset: 0x0063D76A
		public static Offset<IBattleStateMonsterSleep> EndIBattleStateMonsterSleep(FlatBufferBuilder builder)
		{
			return new Offset<IBattleStateMonsterSleep>(builder.EndTable());
		}

		// Token: 0x0602DADF RID: 187103 RVA: 0x0063F578 File Offset: 0x0063D778
		public IBattleStateMonsterSleepT UnPack()
		{
			IBattleStateMonsterSleepT battleStateMonsterSleepT = new IBattleStateMonsterSleepT();
			this.UnPackTo(battleStateMonsterSleepT);
			return battleStateMonsterSleepT;
		}

		// Token: 0x0602DAE0 RID: 187104 RVA: 0x0063F593 File Offset: 0x0063D793
		public void UnPackTo(IBattleStateMonsterSleepT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DAE1 RID: 187105 RVA: 0x0063F5A4 File Offset: 0x0063D7A4
		public static Offset<IBattleStateMonsterSleep> Pack(FlatBufferBuilder builder, IBattleStateMonsterSleepT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleStateMonsterSleep>);
			}
			return IBattleStateMonsterSleep.CreateIBattleStateMonsterSleep(builder, _o.Type);
		}

		// Token: 0x04011539 RID: 70969
		private Table __p;
	}
}
