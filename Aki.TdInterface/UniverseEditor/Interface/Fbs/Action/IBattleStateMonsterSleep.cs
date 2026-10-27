using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061F4 RID: 25076
	public struct IBattleStateMonsterSleep : IFlatbufferObject
	{
		// Token: 0x1700BAEF RID: 47855
		// (get) Token: 0x0602B38D RID: 177037 RVA: 0x005F4A21 File Offset: 0x005F2C21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B38E RID: 177038 RVA: 0x005F4A2E File Offset: 0x005F2C2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B38F RID: 177039 RVA: 0x005F4A38 File Offset: 0x005F2C38
		public static IBattleStateMonsterSleep GetRootAsIBattleStateMonsterSleep(ByteBuffer _bb)
		{
			return IBattleStateMonsterSleep.GetRootAsIBattleStateMonsterSleep(_bb, default(IBattleStateMonsterSleep));
		}

		// Token: 0x0602B390 RID: 177040 RVA: 0x005F4A54 File Offset: 0x005F2C54
		public static IBattleStateMonsterSleep GetRootAsIBattleStateMonsterSleep(ByteBuffer _bb, IBattleStateMonsterSleep obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B391 RID: 177041 RVA: 0x005F4A71 File Offset: 0x005F2C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B392 RID: 177042 RVA: 0x005F4A80 File Offset: 0x005F2C80
		public IBattleStateMonsterSleep __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAF0 RID: 47856
		// (get) Token: 0x0602B393 RID: 177043 RVA: 0x005F4A90 File Offset: 0x005F2C90
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

		// Token: 0x0602B394 RID: 177044 RVA: 0x005F4ACC File Offset: 0x005F2CCC
		public static Offset<IBattleStateMonsterSleep> CreateIBattleStateMonsterSleep(FlatBufferBuilder builder, ESetBattleTagType Type = ESetBattleTagType.BattleMonsterLanding)
		{
			builder.StartTable(1);
			IBattleStateMonsterSleep.AddType(builder, Type);
			return IBattleStateMonsterSleep.EndIBattleStateMonsterSleep(builder);
		}

		// Token: 0x0602B395 RID: 177045 RVA: 0x005F4AE2 File Offset: 0x005F2CE2
		public static void StartIBattleStateMonsterSleep(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B396 RID: 177046 RVA: 0x005F4AEB File Offset: 0x005F2CEB
		public static void AddType(FlatBufferBuilder builder, ESetBattleTagType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B397 RID: 177047 RVA: 0x005F4AF6 File Offset: 0x005F2CF6
		public static Offset<IBattleStateMonsterSleep> EndIBattleStateMonsterSleep(FlatBufferBuilder builder)
		{
			return new Offset<IBattleStateMonsterSleep>(builder.EndTable());
		}

		// Token: 0x0602B398 RID: 177048 RVA: 0x005F4B04 File Offset: 0x005F2D04
		public IBattleStateMonsterSleepT UnPack()
		{
			IBattleStateMonsterSleepT battleStateMonsterSleepT = new IBattleStateMonsterSleepT();
			this.UnPackTo(battleStateMonsterSleepT);
			return battleStateMonsterSleepT;
		}

		// Token: 0x0602B399 RID: 177049 RVA: 0x005F4B1F File Offset: 0x005F2D1F
		public void UnPackTo(IBattleStateMonsterSleepT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B39A RID: 177050 RVA: 0x005F4B30 File Offset: 0x005F2D30
		public static Offset<IBattleStateMonsterSleep> Pack(FlatBufferBuilder builder, IBattleStateMonsterSleepT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleStateMonsterSleep>);
			}
			return IBattleStateMonsterSleep.CreateIBattleStateMonsterSleep(builder, _o.Type);
		}

		// Token: 0x04010727 RID: 67367
		private Table __p;
	}
}
