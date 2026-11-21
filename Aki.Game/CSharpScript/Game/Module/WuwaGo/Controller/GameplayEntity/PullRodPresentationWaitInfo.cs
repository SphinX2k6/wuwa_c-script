using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x020036A7 RID: 13991
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class PullRodPresentationWaitInfo : IPullRodPresentationWaitInfo
	{
		// Token: 0x17004A2E RID: 18990
		// (get) Token: 0x06024502 RID: 148738 RVA: 0x00A4500B File Offset: 0x00A4320B
		// (set) Token: 0x06024503 RID: 148739 RVA: 0x00A45013 File Offset: 0x00A43213
		[RequiredMember]
		public SceneInteractionActor SceneActor { get; set; }

		// Token: 0x17004A2F RID: 18991
		// (get) Token: 0x06024504 RID: 148740 RVA: 0x00A4501C File Offset: 0x00A4321C
		// (set) Token: 0x06024505 RID: 148741 RVA: 0x00A45024 File Offset: 0x00A43224
		[RequiredMember]
		public ULevelSequence Sequence { get; set; }

		// Token: 0x17004A30 RID: 18992
		// (get) Token: 0x06024506 RID: 148742 RVA: 0x00A4502D File Offset: 0x00A4322D
		// (set) Token: 0x06024507 RID: 148743 RVA: 0x00A45035 File Offset: 0x00A43235
		[RequiredMember]
		public float PlayRate { get; set; }

		// Token: 0x06024508 RID: 148744 RVA: 0x00A4503E File Offset: 0x00A4323E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PullRodPresentationWaitInfo()
		{
		}
	}
}
