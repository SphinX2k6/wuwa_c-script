using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x02004459 RID: 17497
	[NullableContext(1)]
	public interface IMechanismEventInfo
	{
		// Token: 0x1700581F RID: 22559
		// (get) Token: 0x0602C21D RID: 180765
		// (set) Token: 0x0602C21E RID: 180766
		ISceneItemSeqEventCbType Info { get; set; }

		// Token: 0x17005820 RID: 22560
		// (get) Token: 0x0602C21F RID: 180767
		// (set) Token: 0x0602C220 RID: 180768
		string SeqGuid { get; set; }
	}
}
