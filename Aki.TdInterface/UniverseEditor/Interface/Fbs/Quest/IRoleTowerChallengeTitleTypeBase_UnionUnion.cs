using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040CB RID: 16587
	public class IRoleTowerChallengeTitleTypeBase_UnionUnion
	{
		// Token: 0x17007500 RID: 29952
		// (get) Token: 0x060182A4 RID: 98980 RVA: 0x0037B605 File Offset: 0x00379805
		// (set) Token: 0x060182A5 RID: 98981 RVA: 0x0037B60D File Offset: 0x0037980D
		public IRoleTowerChallengeTitleTypeBase_Union Type { get; set; }

		// Token: 0x17007501 RID: 29953
		// (get) Token: 0x060182A6 RID: 98982 RVA: 0x0037B616 File Offset: 0x00379816
		// (set) Token: 0x060182A7 RID: 98983 RVA: 0x0037B61E File Offset: 0x0037981E
		public object Value { get; set; }

		// Token: 0x060182A8 RID: 98984 RVA: 0x0037B627 File Offset: 0x00379827
		public IRoleTowerChallengeTitleTypeBase_UnionUnion()
		{
			this.Type = IRoleTowerChallengeTitleTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060182A9 RID: 98985 RVA: 0x0037B63D File Offset: 0x0037983D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060182AA RID: 98986 RVA: 0x0037B64F File Offset: 0x0037984F
		public IRoleTowerChallengeTitleTypeBaseT AsIRoleTowerChallengeTitleTypeBase()
		{
			return this.As<IRoleTowerChallengeTitleTypeBaseT>();
		}

		// Token: 0x060182AB RID: 98987 RVA: 0x0037B657 File Offset: 0x00379857
		public static IRoleTowerChallengeTitleTypeBase_UnionUnion FromIRoleTowerChallengeTitleTypeBase(IRoleTowerChallengeTitleTypeBaseT _iroletowerchallengetitletypebase)
		{
			return new IRoleTowerChallengeTitleTypeBase_UnionUnion
			{
				Type = IRoleTowerChallengeTitleTypeBase_Union.IRoleTowerChallengeTitleTypeBase,
				Value = _iroletowerchallengetitletypebase
			};
		}

		// Token: 0x060182AC RID: 98988 RVA: 0x0037B66C File Offset: 0x0037986C
		public IRoleTowerChallengeTitleKillProgressT AsIRoleTowerChallengeTitleKillProgress()
		{
			return this.As<IRoleTowerChallengeTitleKillProgressT>();
		}

		// Token: 0x060182AD RID: 98989 RVA: 0x0037B674 File Offset: 0x00379874
		public static IRoleTowerChallengeTitleTypeBase_UnionUnion FromIRoleTowerChallengeTitleKillProgress(IRoleTowerChallengeTitleKillProgressT _iroletowerchallengetitlekillprogress)
		{
			return new IRoleTowerChallengeTitleTypeBase_UnionUnion
			{
				Type = IRoleTowerChallengeTitleTypeBase_Union.IRoleTowerChallengeTitleKillProgress,
				Value = _iroletowerchallengetitlekillprogress
			};
		}

		// Token: 0x060182AE RID: 98990 RVA: 0x0037B689 File Offset: 0x00379889
		public IRoleTowerChallengeTitlePhantomExpT AsIRoleTowerChallengeTitlePhantomExp()
		{
			return this.As<IRoleTowerChallengeTitlePhantomExpT>();
		}

		// Token: 0x060182AF RID: 98991 RVA: 0x0037B691 File Offset: 0x00379891
		public static IRoleTowerChallengeTitleTypeBase_UnionUnion FromIRoleTowerChallengeTitlePhantomExp(IRoleTowerChallengeTitlePhantomExpT _iroletowerchallengetitlephantomexp)
		{
			return new IRoleTowerChallengeTitleTypeBase_UnionUnion
			{
				Type = IRoleTowerChallengeTitleTypeBase_Union.IRoleTowerChallengeTitlePhantomExp,
				Value = _iroletowerchallengetitlephantomexp
			};
		}

		// Token: 0x060182B0 RID: 98992 RVA: 0x0037B6A6 File Offset: 0x003798A6
		public IRoleTowerChallengeTitleCurrentFloorT AsIRoleTowerChallengeTitleCurrentFloor()
		{
			return this.As<IRoleTowerChallengeTitleCurrentFloorT>();
		}

		// Token: 0x060182B1 RID: 98993 RVA: 0x0037B6AE File Offset: 0x003798AE
		public static IRoleTowerChallengeTitleTypeBase_UnionUnion FromIRoleTowerChallengeTitleCurrentFloor(IRoleTowerChallengeTitleCurrentFloorT _iroletowerchallengetitlecurrentfloor)
		{
			return new IRoleTowerChallengeTitleTypeBase_UnionUnion
			{
				Type = IRoleTowerChallengeTitleTypeBase_Union.IRoleTowerChallengeTitleCurrentFloor,
				Value = _iroletowerchallengetitlecurrentfloor
			};
		}

		// Token: 0x060182B2 RID: 98994 RVA: 0x0037B6C4 File Offset: 0x003798C4
		public static int Pack(FlatBufferBuilder builder, IRoleTowerChallengeTitleTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRoleTowerChallengeTitleTypeBase_Union.IRoleTowerChallengeTitleTypeBase:
				return IRoleTowerChallengeTitleTypeBase.Pack(builder, _o.AsIRoleTowerChallengeTitleTypeBase()).Value;
			case IRoleTowerChallengeTitleTypeBase_Union.IRoleTowerChallengeTitleKillProgress:
				return IRoleTowerChallengeTitleKillProgress.Pack(builder, _o.AsIRoleTowerChallengeTitleKillProgress()).Value;
			case IRoleTowerChallengeTitleTypeBase_Union.IRoleTowerChallengeTitlePhantomExp:
				return IRoleTowerChallengeTitlePhantomExp.Pack(builder, _o.AsIRoleTowerChallengeTitlePhantomExp()).Value;
			case IRoleTowerChallengeTitleTypeBase_Union.IRoleTowerChallengeTitleCurrentFloor:
				return IRoleTowerChallengeTitleCurrentFloor.Pack(builder, _o.AsIRoleTowerChallengeTitleCurrentFloor()).Value;
			default:
				return 0;
			}
		}
	}
}
