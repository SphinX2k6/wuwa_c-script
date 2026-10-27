using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x02005477 RID: 21623
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class MechanismEventInfo : IMechanismEventInfo
	{
		// Token: 0x17008455 RID: 33877
		// (get) Token: 0x060372D8 RID: 226008 RVA: 0x00D15FD8 File Offset: 0x00D141D8
		// (set) Token: 0x060372D9 RID: 226009 RVA: 0x00D15FE0 File Offset: 0x00D141E0
		[RequiredMember]
		public ISceneItemSeqEventCbType Info { get; set; }

		// Token: 0x17008456 RID: 33878
		// (get) Token: 0x060372DA RID: 226010 RVA: 0x00D15FE9 File Offset: 0x00D141E9
		// (set) Token: 0x060372DB RID: 226011 RVA: 0x00D15FF1 File Offset: 0x00D141F1
		[RequiredMember]
		public string SeqGuid { get; set; }

		// Token: 0x060372DC RID: 226012 RVA: 0x00D15FFA File Offset: 0x00D141FA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MechanismEventInfo()
		{
		}
	}
}
