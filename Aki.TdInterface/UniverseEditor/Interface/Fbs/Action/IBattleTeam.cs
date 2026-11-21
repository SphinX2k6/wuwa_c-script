using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200686B RID: 26731
	public struct IBattleTeam : IFlatbufferObject
	{
		// Token: 0x1700C47A RID: 50298
		// (get) Token: 0x0602DB06 RID: 187142 RVA: 0x0063F8D0 File Offset: 0x0063DAD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DB07 RID: 187143 RVA: 0x0063F8DD File Offset: 0x0063DADD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DB08 RID: 187144 RVA: 0x0063F8E4 File Offset: 0x0063DAE4
		public static IBattleTeam GetRootAsIBattleTeam(ByteBuffer _bb)
		{
			return IBattleTeam.GetRootAsIBattleTeam(_bb, default(IBattleTeam));
		}

		// Token: 0x0602DB09 RID: 187145 RVA: 0x0063F900 File Offset: 0x0063DB00
		public static IBattleTeam GetRootAsIBattleTeam(ByteBuffer _bb, IBattleTeam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DB0A RID: 187146 RVA: 0x0063F91D File Offset: 0x0063DB1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DB0B RID: 187147 RVA: 0x0063F92C File Offset: 0x0063DB2C
		public IBattleTeam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C47B RID: 50299
		// (get) Token: 0x0602DB0C RID: 187148 RVA: 0x0063F93C File Offset: 0x0063DB3C
		public ETeamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeamType.Current;
				}
				return (ETeamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DB0D RID: 187149 RVA: 0x0063F978 File Offset: 0x0063DB78
		public static Offset<IBattleTeam> CreateIBattleTeam(FlatBufferBuilder builder, ETeamType Type = ETeamType.Current)
		{
			builder.StartTable(1);
			IBattleTeam.AddType(builder, Type);
			return IBattleTeam.EndIBattleTeam(builder);
		}

		// Token: 0x0602DB0E RID: 187150 RVA: 0x0063F98E File Offset: 0x0063DB8E
		public static void StartIBattleTeam(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DB0F RID: 187151 RVA: 0x0063F997 File Offset: 0x0063DB97
		public static void AddType(FlatBufferBuilder builder, ETeamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DB10 RID: 187152 RVA: 0x0063F9A2 File Offset: 0x0063DBA2
		public static Offset<IBattleTeam> EndIBattleTeam(FlatBufferBuilder builder)
		{
			return new Offset<IBattleTeam>(builder.EndTable());
		}

		// Token: 0x0602DB11 RID: 187153 RVA: 0x0063F9B0 File Offset: 0x0063DBB0
		public IBattleTeamT UnPack()
		{
			IBattleTeamT battleTeamT = new IBattleTeamT();
			this.UnPackTo(battleTeamT);
			return battleTeamT;
		}

		// Token: 0x0602DB12 RID: 187154 RVA: 0x0063F9CB File Offset: 0x0063DBCB
		public void UnPackTo(IBattleTeamT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DB13 RID: 187155 RVA: 0x0063F9DC File Offset: 0x0063DBDC
		public static Offset<IBattleTeam> Pack(FlatBufferBuilder builder, IBattleTeamT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleTeam>);
			}
			return IBattleTeam.CreateIBattleTeam(builder, _o.Type);
		}

		// Token: 0x04011544 RID: 70980
		private Table __p;
	}
}
