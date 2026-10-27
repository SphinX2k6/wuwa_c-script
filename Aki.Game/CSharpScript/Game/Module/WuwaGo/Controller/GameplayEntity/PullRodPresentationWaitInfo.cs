using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x02004776 RID: 18294
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class PullRodPresentationWaitInfo : IPullRodPresentationWaitInfo
	{
		// Token: 0x17007772 RID: 30578
		// (get) Token: 0x0602FD38 RID: 195896 RVA: 0x00B14FAB File Offset: 0x00B131AB
		// (set) Token: 0x0602FD39 RID: 195897 RVA: 0x00B14FB3 File Offset: 0x00B131B3
		[RequiredMember]
		public SceneInteractionActor SceneActor { get; set; }

		// Token: 0x17007773 RID: 30579
		// (get) Token: 0x0602FD3A RID: 195898 RVA: 0x00B14FBC File Offset: 0x00B131BC
		// (set) Token: 0x0602FD3B RID: 195899 RVA: 0x00B14FC4 File Offset: 0x00B131C4
		[RequiredMember]
		public ULevelSequence Sequence { get; set; }

		// Token: 0x17007774 RID: 30580
		// (get) Token: 0x0602FD3C RID: 195900 RVA: 0x00B14FCD File Offset: 0x00B131CD
		// (set) Token: 0x0602FD3D RID: 195901 RVA: 0x00B14FD5 File Offset: 0x00B131D5
		[RequiredMember]
		public float PlayRate { get; set; }

		// Token: 0x0602FD3E RID: 195902 RVA: 0x00B14FDE File Offset: 0x00B131DE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PullRodPresentationWaitInfo()
		{
		}
	}
}
