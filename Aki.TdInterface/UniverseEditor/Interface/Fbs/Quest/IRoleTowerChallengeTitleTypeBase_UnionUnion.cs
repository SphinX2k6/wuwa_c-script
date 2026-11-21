using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200450C RID: 17676
	public class IRoleTowerChallengeTitleTypeBase_UnionUnion
	{
		// Token: 0x17007B06 RID: 31494
		// (get) Token: 0x06019945 RID: 104773 RVA: 0x003A5555 File Offset: 0x003A3755
		// (set) Token: 0x06019946 RID: 104774 RVA: 0x003A555D File Offset: 0x003A375D
		public IRoleTowerChallengeTitleTypeBase_Union Type { get; set; }

		// Token: 0x17007B07 RID: 31495
		// (get) Token: 0x06019947 RID: 104775 RVA: 0x003A5566 File Offset: 0x003A3766
		// (set) Token: 0x06019948 RID: 104776 RVA: 0x003A556E File Offset: 0x003A376E
		public object Value { get; set; }

		// Token: 0x06019949 RID: 104777 RVA: 0x003A5577 File Offset: 0x003A3777
		public IRoleTowerChallengeTitleTypeBase_UnionUnion()
		{
			this.Type = IRoleTowerChallengeTitleTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601994A RID: 104778 RVA: 0x003A558D File Offset: 0x003A378D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601994B RID: 104779 RVA: 0x003A559F File Offset: 0x003A379F
		public IRoleTowerChallengeTitleTypeBaseT AsIRoleTowerChallengeTitleTypeBase()
		{
			return this.As<IRoleTowerChallengeTitleTypeBaseT>();
		}

		// Token: 0x0601994C RID: 104780 RVA: 0x003A55A7 File Offset: 0x003A37A7
		public static IRoleTowerChallengeTitleTypeBase_UnionUnion FromIRoleTowerChallengeTitleTypeBase(IRoleTowerChallengeTitleTypeBaseT _iroletowerchallengetitletypebase)
		{
			return new IRoleTowerChallengeTitleTypeBase_UnionUnion
			{
				Type = IRoleTowerChallengeTitleTypeBase_Union.IRoleTowerChallengeTitleTypeBase,
				Value = _iroletowerchallengetitletypebase
			};
		}

		// Token: 0x0601994D RID: 104781 RVA: 0x003A55BC File Offset: 0x003A37BC
		public IRoleTowerChallengeTitleKillProgressT AsIRoleTowerChallengeTitleKillProgress()
		{
			return this.As<IRoleTowerChallengeTitleKillProgressT>();
		}

		// Token: 0x0601994E RID: 104782 RVA: 0x003A55C4 File Offset: 0x003A37C4
		public static IRoleTowerChallengeTitleTypeBase_UnionUnion FromIRoleTowerChallengeTitleKillProgress(IRoleTowerChallengeTitleKillProgressT _iroletowerchallengetitlekillprogress)
		{
			return new IRoleTowerChallengeTitleTypeBase_UnionUnion
			{
				Type = IRoleTowerChallengeTitleTypeBase_Union.IRoleTowerChallengeTitleKillProgress,
				Value = _iroletowerchallengetitlekillprogress
			};
		}

		// Token: 0x0601994F RID: 104783 RVA: 0x003A55D9 File Offset: 0x003A37D9
		public IRoleTowerChallengeTitlePhantomExpT AsIRoleTowerChallengeTitlePhantomExp()
		{
			return this.As<IRoleTowerChallengeTitlePhantomExpT>();
		}

		// Token: 0x06019950 RID: 104784 RVA: 0x003A55E1 File Offset: 0x003A37E1
		public static IRoleTowerChallengeTitleTypeBase_UnionUnion FromIRoleTowerChallengeTitlePhantomExp(IRoleTowerChallengeTitlePhantomExpT _iroletowerchallengetitlephantomexp)
		{
			return new IRoleTowerChallengeTitleTypeBase_UnionUnion
			{
				Type = IRoleTowerChallengeTitleTypeBase_Union.IRoleTowerChallengeTitlePhantomExp,
				Value = _iroletowerchallengetitlephantomexp
			};
		}

		// Token: 0x06019951 RID: 104785 RVA: 0x003A55F6 File Offset: 0x003A37F6
		public IRoleTowerChallengeTitleCurrentFloorT AsIRoleTowerChallengeTitleCurrentFloor()
		{
			return this.As<IRoleTowerChallengeTitleCurrentFloorT>();
		}

		// Token: 0x06019952 RID: 104786 RVA: 0x003A55FE File Offset: 0x003A37FE
		public static IRoleTowerChallengeTitleTypeBase_UnionUnion FromIRoleTowerChallengeTitleCurrentFloor(IRoleTowerChallengeTitleCurrentFloorT _iroletowerchallengetitlecurrentfloor)
		{
			return new IRoleTowerChallengeTitleTypeBase_UnionUnion
			{
				Type = IRoleTowerChallengeTitleTypeBase_Union.IRoleTowerChallengeTitleCurrentFloor,
				Value = _iroletowerchallengetitlecurrentfloor
			};
		}

		// Token: 0x06019953 RID: 104787 RVA: 0x003A5614 File Offset: 0x003A3814
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
