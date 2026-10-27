using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004309 RID: 17161
	public class TRoleTowerChallengeTitleTypeUnion
	{
		// Token: 0x17007968 RID: 31080
		// (get) Token: 0x06019735 RID: 104245 RVA: 0x003A5DCA File Offset: 0x003A3FCA
		// (set) Token: 0x06019736 RID: 104246 RVA: 0x003A5DD2 File Offset: 0x003A3FD2
		public TRoleTowerChallengeTitleType Type { get; set; }

		// Token: 0x17007969 RID: 31081
		// (get) Token: 0x06019737 RID: 104247 RVA: 0x003A5DDB File Offset: 0x003A3FDB
		// (set) Token: 0x06019738 RID: 104248 RVA: 0x003A5DE3 File Offset: 0x003A3FE3
		public object Value { get; set; }

		// Token: 0x06019739 RID: 104249 RVA: 0x003A5DEC File Offset: 0x003A3FEC
		public TRoleTowerChallengeTitleTypeUnion()
		{
			this.Type = TRoleTowerChallengeTitleType.NONE;
			this.Value = null;
		}

		// Token: 0x0601973A RID: 104250 RVA: 0x003A5E02 File Offset: 0x003A4002
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601973B RID: 104251 RVA: 0x003A5E14 File Offset: 0x003A4014
		public IRoleTowerChallengeTitleCurrentFloorT AsIRoleTowerChallengeTitleCurrentFloor()
		{
			return this.As<IRoleTowerChallengeTitleCurrentFloorT>();
		}

		// Token: 0x0601973C RID: 104252 RVA: 0x003A5E1C File Offset: 0x003A401C
		public static TRoleTowerChallengeTitleTypeUnion FromIRoleTowerChallengeTitleCurrentFloor(IRoleTowerChallengeTitleCurrentFloorT _iroletowerchallengetitlecurrentfloor)
		{
			return new TRoleTowerChallengeTitleTypeUnion
			{
				Type = TRoleTowerChallengeTitleType.IRoleTowerChallengeTitleCurrentFloor,
				Value = _iroletowerchallengetitlecurrentfloor
			};
		}

		// Token: 0x0601973D RID: 104253 RVA: 0x003A5E31 File Offset: 0x003A4031
		public IRoleTowerChallengeTitleKillProgressT AsIRoleTowerChallengeTitleKillProgress()
		{
			return this.As<IRoleTowerChallengeTitleKillProgressT>();
		}

		// Token: 0x0601973E RID: 104254 RVA: 0x003A5E39 File Offset: 0x003A4039
		public static TRoleTowerChallengeTitleTypeUnion FromIRoleTowerChallengeTitleKillProgress(IRoleTowerChallengeTitleKillProgressT _iroletowerchallengetitlekillprogress)
		{
			return new TRoleTowerChallengeTitleTypeUnion
			{
				Type = TRoleTowerChallengeTitleType.IRoleTowerChallengeTitleKillProgress,
				Value = _iroletowerchallengetitlekillprogress
			};
		}

		// Token: 0x0601973F RID: 104255 RVA: 0x003A5E4E File Offset: 0x003A404E
		public IRoleTowerChallengeTitlePhantomExpT AsIRoleTowerChallengeTitlePhantomExp()
		{
			return this.As<IRoleTowerChallengeTitlePhantomExpT>();
		}

		// Token: 0x06019740 RID: 104256 RVA: 0x003A5E56 File Offset: 0x003A4056
		public static TRoleTowerChallengeTitleTypeUnion FromIRoleTowerChallengeTitlePhantomExp(IRoleTowerChallengeTitlePhantomExpT _iroletowerchallengetitlephantomexp)
		{
			return new TRoleTowerChallengeTitleTypeUnion
			{
				Type = TRoleTowerChallengeTitleType.IRoleTowerChallengeTitlePhantomExp,
				Value = _iroletowerchallengetitlephantomexp
			};
		}

		// Token: 0x06019741 RID: 104257 RVA: 0x003A5E6C File Offset: 0x003A406C
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
