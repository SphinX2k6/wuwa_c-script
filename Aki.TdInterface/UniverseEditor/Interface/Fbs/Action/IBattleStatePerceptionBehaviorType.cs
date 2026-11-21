using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006865 RID: 26725
	public struct IBattleStatePerceptionBehaviorType : IFlatbufferObject
	{
		// Token: 0x1700C475 RID: 50293
		// (get) Token: 0x0602DAE6 RID: 187110 RVA: 0x0063F60D File Offset: 0x0063D80D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DAE7 RID: 187111 RVA: 0x0063F61A File Offset: 0x0063D81A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DAE8 RID: 187112 RVA: 0x0063F624 File Offset: 0x0063D824
		public static IBattleStatePerceptionBehaviorType GetRootAsIBattleStatePerceptionBehaviorType(ByteBuffer _bb)
		{
			return IBattleStatePerceptionBehaviorType.GetRootAsIBattleStatePerceptionBehaviorType(_bb, default(IBattleStatePerceptionBehaviorType));
		}

		// Token: 0x0602DAE9 RID: 187113 RVA: 0x0063F640 File Offset: 0x0063D840
		public static IBattleStatePerceptionBehaviorType GetRootAsIBattleStatePerceptionBehaviorType(ByteBuffer _bb, IBattleStatePerceptionBehaviorType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DAEA RID: 187114 RVA: 0x0063F65D File Offset: 0x0063D85D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DAEB RID: 187115 RVA: 0x0063F66C File Offset: 0x0063D86C
		public IBattleStatePerceptionBehaviorType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C476 RID: 50294
		// (get) Token: 0x0602DAEC RID: 187116 RVA: 0x0063F67C File Offset: 0x0063D87C
		public EBattleStatePerceptionBehavior Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
				}
				return (EBattleStatePerceptionBehavior)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DAED RID: 187117 RVA: 0x0063F6B8 File Offset: 0x0063D8B8
		public static Offset<IBattleStatePerceptionBehaviorType> CreateIBattleStatePerceptionBehaviorType(FlatBufferBuilder builder, EBattleStatePerceptionBehavior Type = EBattleStatePerceptionBehavior.NotifyGatherToPlayer)
		{
			builder.StartTable(1);
			IBattleStatePerceptionBehaviorType.AddType(builder, Type);
			return IBattleStatePerceptionBehaviorType.EndIBattleStatePerceptionBehaviorType(builder);
		}

		// Token: 0x0602DAEE RID: 187118 RVA: 0x0063F6CE File Offset: 0x0063D8CE
		public static void StartIBattleStatePerceptionBehaviorType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DAEF RID: 187119 RVA: 0x0063F6D7 File Offset: 0x0063D8D7
		public static void AddType(FlatBufferBuilder builder, EBattleStatePerceptionBehavior type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DAF0 RID: 187120 RVA: 0x0063F6E2 File Offset: 0x0063D8E2
		public static Offset<IBattleStatePerceptionBehaviorType> EndIBattleStatePerceptionBehaviorType(FlatBufferBuilder builder)
		{
			return new Offset<IBattleStatePerceptionBehaviorType>(builder.EndTable());
		}

		// Token: 0x0602DAF1 RID: 187121 RVA: 0x0063F6F0 File Offset: 0x0063D8F0
		public IBattleStatePerceptionBehaviorTypeT UnPack()
		{
			IBattleStatePerceptionBehaviorTypeT battleStatePerceptionBehaviorTypeT = new IBattleStatePerceptionBehaviorTypeT();
			this.UnPackTo(battleStatePerceptionBehaviorTypeT);
			return battleStatePerceptionBehaviorTypeT;
		}

		// Token: 0x0602DAF2 RID: 187122 RVA: 0x0063F70B File Offset: 0x0063D90B
		public void UnPackTo(IBattleStatePerceptionBehaviorTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DAF3 RID: 187123 RVA: 0x0063F71C File Offset: 0x0063D91C
		public static Offset<IBattleStatePerceptionBehaviorType> Pack(FlatBufferBuilder builder, IBattleStatePerceptionBehaviorTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleStatePerceptionBehaviorType>);
			}
			return IBattleStatePerceptionBehaviorType.CreateIBattleStatePerceptionBehaviorType(builder, _o.Type);
		}

		// Token: 0x0401153B RID: 70971
		private Table __p;
	}
}
