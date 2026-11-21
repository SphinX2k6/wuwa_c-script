using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x0200445A RID: 17498
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class MechanismEventInfo : IMechanismEventInfo
	{
		// Token: 0x17005821 RID: 22561
		// (get) Token: 0x0602C221 RID: 180769 RVA: 0x00C65430 File Offset: 0x00C63630
		// (set) Token: 0x0602C222 RID: 180770 RVA: 0x00C65438 File Offset: 0x00C63638
		[RequiredMember]
		public ISceneItemSeqEventCbType Info { get; set; }

		// Token: 0x17005822 RID: 22562
		// (get) Token: 0x0602C223 RID: 180771 RVA: 0x00C65441 File Offset: 0x00C63641
		// (set) Token: 0x0602C224 RID: 180772 RVA: 0x00C65449 File Offset: 0x00C63649
		[RequiredMember]
		public string SeqGuid { get; set; }

		// Token: 0x0602C225 RID: 180773 RVA: 0x00C65452 File Offset: 0x00C63652
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MechanismEventInfo()
		{
		}
	}
}
