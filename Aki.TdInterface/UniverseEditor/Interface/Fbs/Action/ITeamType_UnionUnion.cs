using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B55 RID: 31573
	public class ITeamType_UnionUnion
	{
		// Token: 0x1700EC67 RID: 60519
		// (get) Token: 0x06038DA9 RID: 232873 RVA: 0x007AFD31 File Offset: 0x007ADF31
		// (set) Token: 0x06038DAA RID: 232874 RVA: 0x007AFD39 File Offset: 0x007ADF39
		public ITeamType_Union Type { get; set; }

		// Token: 0x1700EC68 RID: 60520
		// (get) Token: 0x06038DAB RID: 232875 RVA: 0x007AFD42 File Offset: 0x007ADF42
		// (set) Token: 0x06038DAC RID: 232876 RVA: 0x007AFD4A File Offset: 0x007ADF4A
		public object Value { get; set; }

		// Token: 0x06038DAD RID: 232877 RVA: 0x007AFD53 File Offset: 0x007ADF53
		public ITeamType_UnionUnion()
		{
			this.Type = ITeamType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038DAE RID: 232878 RVA: 0x007AFD69 File Offset: 0x007ADF69
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038DAF RID: 232879 RVA: 0x007AFD7B File Offset: 0x007ADF7B
		public ITeamTypeT AsITeamType()
		{
			return this.As<ITeamTypeT>();
		}

		// Token: 0x06038DB0 RID: 232880 RVA: 0x007AFD83 File Offset: 0x007ADF83
		public static ITeamType_UnionUnion FromITeamType(ITeamTypeT _iteamtype)
		{
			return new ITeamType_UnionUnion
			{
				Type = ITeamType_Union.ITeamType,
				Value = _iteamtype
			};
		}

		// Token: 0x06038DB1 RID: 232881 RVA: 0x007AFD98 File Offset: 0x007ADF98
		public ICurrentTeamT AsICurrentTeam()
		{
			return this.As<ICurrentTeamT>();
		}

		// Token: 0x06038DB2 RID: 232882 RVA: 0x007AFDA0 File Offset: 0x007ADFA0
		public static ITeamType_UnionUnion FromICurrentTeam(ICurrentTeamT _icurrentteam)
		{
			return new ITeamType_UnionUnion
			{
				Type = ITeamType_Union.ICurrentTeam,
				Value = _icurrentteam
			};
		}

		// Token: 0x06038DB3 RID: 232883 RVA: 0x007AFDB5 File Offset: 0x007ADFB5
		public IBattleTeamT AsIBattleTeam()
		{
			return this.As<IBattleTeamT>();
		}

		// Token: 0x06038DB4 RID: 232884 RVA: 0x007AFDBD File Offset: 0x007ADFBD
		public static ITeamType_UnionUnion FromIBattleTeam(IBattleTeamT _ibattleteam)
		{
			return new ITeamType_UnionUnion
			{
				Type = ITeamType_Union.IBattleTeam,
				Value = _ibattleteam
			};
		}

		// Token: 0x06038DB5 RID: 232885 RVA: 0x007AFDD2 File Offset: 0x007ADFD2
		public IFlowTeamT AsIFlowTeam()
		{
			return this.As<IFlowTeamT>();
		}

		// Token: 0x06038DB6 RID: 232886 RVA: 0x007AFDDA File Offset: 0x007ADFDA
		public static ITeamType_UnionUnion FromIFlowTeam(IFlowTeamT _iflowteam)
		{
			return new ITeamType_UnionUnion
			{
				Type = ITeamType_Union.IFlowTeam,
				Value = _iflowteam
			};
		}

		// Token: 0x06038DB7 RID: 232887 RVA: 0x007AFDF0 File Offset: 0x007ADFF0
		public static int Pack(FlatBufferBuilder builder, ITeamType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITeamType_Union.ITeamType:
				return ITeamType.Pack(builder, _o.AsITeamType()).Value;
			case ITeamType_Union.ICurrentTeam:
				return ICurrentTeam.Pack(builder, _o.AsICurrentTeam()).Value;
			case ITeamType_Union.IBattleTeam:
				return IBattleTeam.Pack(builder, _o.AsIBattleTeam()).Value;
			case ITeamType_Union.IFlowTeam:
				return IFlowTeam.Pack(builder, _o.AsIFlowTeam()).Value;
			default:
				return 0;
			}
		}
	}
}
