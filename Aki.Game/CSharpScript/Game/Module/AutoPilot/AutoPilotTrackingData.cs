using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E58 RID: 20056
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class AutoPilotTrackingData : AutoPilotDefine.IAutoPilotTrackingData
	{
		// Token: 0x17006254 RID: 25172
		// (get) Token: 0x0603277C RID: 206716 RVA: 0x00E28A5D File Offset: 0x00E26C5D
		// (set) Token: 0x0603277D RID: 206717 RVA: 0x00E28A65 File Offset: 0x00E26C65
		[RequiredMember]
		public Vector TargetPos { get; set; }

		// Token: 0x17006255 RID: 25173
		// (get) Token: 0x0603277E RID: 206718 RVA: 0x00E28A6E File Offset: 0x00E26C6E
		// (set) Token: 0x0603277F RID: 206719 RVA: 0x00E28A76 File Offset: 0x00E26C76
		public int MapId { get; set; }

		// Token: 0x06032780 RID: 206720 RVA: 0x00E28A7F File Offset: 0x00E26C7F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public AutoPilotTrackingData()
		{
		}
	}
}
