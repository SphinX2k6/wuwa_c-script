using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x02005476 RID: 21622
	[NullableContext(1)]
	public interface IMechanismEventInfo
	{
		// Token: 0x17008453 RID: 33875
		// (get) Token: 0x060372D4 RID: 226004
		// (set) Token: 0x060372D5 RID: 226005
		ISceneItemSeqEventCbType Info { get; set; }

		// Token: 0x17008454 RID: 33876
		// (get) Token: 0x060372D6 RID: 226006
		// (set) Token: 0x060372D7 RID: 226007
		string SeqGuid { get; set; }
	}
}
