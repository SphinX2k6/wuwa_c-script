using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004768 RID: 18280
	public class TRoleTowerChallengeTitleTypeUnion
	{
		// Token: 0x17007F9B RID: 32667
		// (get) Token: 0x0601AEB7 RID: 110263 RVA: 0x003D16FA File Offset: 0x003CF8FA
		// (set) Token: 0x0601AEB8 RID: 110264 RVA: 0x003D1702 File Offset: 0x003CF902
		public TRoleTowerChallengeTitleType Type { get; set; }

		// Token: 0x17007F9C RID: 32668
		// (get) Token: 0x0601AEB9 RID: 110265 RVA: 0x003D170B File Offset: 0x003CF90B
		// (set) Token: 0x0601AEBA RID: 110266 RVA: 0x003D1713 File Offset: 0x003CF913
		public object Value { get; set; }

		// Token: 0x0601AEBB RID: 110267 RVA: 0x003D171C File Offset: 0x003CF91C
		public TRoleTowerChallengeTitleTypeUnion()
		{
			this.Type = TRoleTowerChallengeTitleType.NONE;
			this.Value = null;
		}

		// Token: 0x0601AEBC RID: 110268 RVA: 0x003D1732 File Offset: 0x003CF932
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AEBD RID: 110269 RVA: 0x003D1744 File Offset: 0x003CF944
		public IRoleTowerChallengeTitleCurrentFloorT AsIRoleTowerChallengeTitleCurrentFloor()
		{
			return this.As<IRoleTowerChallengeTitleCurrentFloorT>();
		}

		// Token: 0x0601AEBE RID: 110270 RVA: 0x003D174C File Offset: 0x003CF94C
		public static TRoleTowerChallengeTitleTypeUnion FromIRoleTowerChallengeTitleCurrentFloor(IRoleTowerChallengeTitleCurrentFloorT _iroletowerchallengetitlecurrentfloor)
		{
			return new TRoleTowerChallengeTitleTypeUnion
			{
				Type = TRoleTowerChallengeTitleType.IRoleTowerChallengeTitleCurrentFloor,
				Value = _iroletowerchallengetitlecurrentfloor
			};
		}

		// Token: 0x0601AEBF RID: 110271 RVA: 0x003D1761 File Offset: 0x003CF961
		public IRoleTowerChallengeTitleKillProgressT AsIRoleTowerChallengeTitleKillProgress()
		{
			return this.As<IRoleTowerChallengeTitleKillProgressT>();
		}

		// Token: 0x0601AEC0 RID: 110272 RVA: 0x003D1769 File Offset: 0x003CF969
		public static TRoleTowerChallengeTitleTypeUnion FromIRoleTowerChallengeTitleKillProgress(IRoleTowerChallengeTitleKillProgressT _iroletowerchallengetitlekillprogress)
		{
			return new TRoleTowerChallengeTitleTypeUnion
			{
				Type = TRoleTowerChallengeTitleType.IRoleTowerChallengeTitleKillProgress,
				Value = _iroletowerchallengetitlekillprogress
			};
		}

		// Token: 0x0601AEC1 RID: 110273 RVA: 0x003D177E File Offset: 0x003CF97E
		public IRoleTowerChallengeTitlePhantomExpT AsIRoleTowerChallengeTitlePhantomExp()
		{
			return this.As<IRoleTowerChallengeTitlePhantomExpT>();
		}

		// Token: 0x0601AEC2 RID: 110274 RVA: 0x003D1786 File Offset: 0x003CF986
		public static TRoleTowerChallengeTitleTypeUnion FromIRoleTowerChallengeTitlePhantomExp(IRoleTowerChallengeTitlePhantomExpT _iroletowerchallengetitlephantomexp)
		{
			return new TRoleTowerChallengeTitleTypeUnion
			{
				Type = TRoleTowerChallengeTitleType.IRoleTowerChallengeTitlePhantomExp,
				Value = _iroletowerchallengetitlephantomexp
			};
		}

		// Token: 0x0601AEC3 RID: 110275 RVA: 0x003D179C File Offset: 0x003CF99C
		public static int Pack(FlatBufferBuilder builder, TRoleTowerChallengeTitleTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TRoleTowerChallengeTitleType.IRoleTowerChallengeTitleCurrentFloor:
				return IRoleTowerChallengeTitleCurrentFloor.Pack(builder, _o.AsIRoleTowerChallengeTitleCurrentFloor()).Value;
			case TRoleTowerChallengeTitleType.IRoleTowerChallengeTitleKillProgress:
				return IRoleTowerChallengeTitleKillProgress.Pack(builder, _o.AsIRoleTowerChallengeTitleKillProgress()).Value;
			case TRoleTowerChallengeTitleType.IRoleTowerChallengeTitlePhantomExp:
				return IRoleTowerChallengeTitlePhantomExp.Pack(builder, _o.AsIRoleTowerChallengeTitlePhantomExp()).Value;
			default:
				return 0;
			}
		}
	}
}
