using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200800D RID: 32781
	public class TTeamTypeUnion
	{
		// Token: 0x1700F32B RID: 62251
		// (get) Token: 0x0603AFD9 RID: 241625 RVA: 0x007EBE7C File Offset: 0x007EA07C
		// (set) Token: 0x0603AFDA RID: 241626 RVA: 0x007EBE84 File Offset: 0x007EA084
		public TTeamType Type { get; set; }

		// Token: 0x1700F32C RID: 62252
		// (get) Token: 0x0603AFDB RID: 241627 RVA: 0x007EBE8D File Offset: 0x007EA08D
		// (set) Token: 0x0603AFDC RID: 241628 RVA: 0x007EBE95 File Offset: 0x007EA095
		public object Value { get; set; }

		// Token: 0x0603AFDD RID: 241629 RVA: 0x007EBE9E File Offset: 0x007EA09E
		public TTeamTypeUnion()
		{
			this.Type = TTeamType.NONE;
			this.Value = null;
		}

		// Token: 0x0603AFDE RID: 241630 RVA: 0x007EBEB4 File Offset: 0x007EA0B4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AFDF RID: 241631 RVA: 0x007EBEC6 File Offset: 0x007EA0C6
		public IBattleTeamT AsIBattleTeam()
		{
			return this.As<IBattleTeamT>();
		}

		// Token: 0x0603AFE0 RID: 241632 RVA: 0x007EBECE File Offset: 0x007EA0CE
		public static TTeamTypeUnion FromIBattleTeam(IBattleTeamT _ibattleteam)
		{
			return new TTeamTypeUnion
			{
				Type = TTeamType.IBattleTeam,
				Value = _ibattleteam
			};
		}

		// Token: 0x0603AFE1 RID: 241633 RVA: 0x007EBEE3 File Offset: 0x007EA0E3
		public ICurrentTeamT AsICurrentTeam()
		{
			return this.As<ICurrentTeamT>();
		}

		// Token: 0x0603AFE2 RID: 241634 RVA: 0x007EBEEB File Offset: 0x007EA0EB
		public static TTeamTypeUnion FromICurrentTeam(ICurrentTeamT _icurrentteam)
		{
			return new TTeamTypeUnion
			{
				Type = TTeamType.ICurrentTeam,
				Value = _icurrentteam
			};
		}

		// Token: 0x0603AFE3 RID: 241635 RVA: 0x007EBF00 File Offset: 0x007EA100
		public IFlowTeamT AsIFlowTeam()
		{
			return this.As<IFlowTeamT>();
		}

		// Token: 0x0603AFE4 RID: 241636 RVA: 0x007EBF08 File Offset: 0x007EA108
		public static TTeamTypeUnion FromIFlowTeam(IFlowTeamT _iflowteam)
		{
			return new TTeamTypeUnion
			{
				Type = TTeamType.IFlowTeam,
				Value = _iflowteam
			};
		}

		// Token: 0x0603AFE5 RID: 241637 RVA: 0x007EBF20 File Offset: 0x007EA120
		public static int Pack(FlatBufferBuilder builder, TTeamTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TTeamType.IBattleTeam:
				return IBattleTeam.Pack(builder, _o.AsIBattleTeam()).Value;
			case TTeamType.ICurrentTeam:
				return ICurrentTeam.Pack(builder, _o.AsICurrentTeam()).Value;
			case TTeamType.IFlowTeam:
				return IFlowTeam.Pack(builder, _o.AsIFlowTeam()).Value;
			default:
				return 0;
			}
		}
	}
}
