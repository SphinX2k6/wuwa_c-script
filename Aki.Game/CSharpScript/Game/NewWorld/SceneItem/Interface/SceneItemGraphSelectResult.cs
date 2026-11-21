using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Interface
{
	// Token: 0x020062AE RID: 25262
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class SceneItemGraphSelectResult : ISceneItemGraphSelectResult
	{
		// Token: 0x1700736C RID: 29548
		// (get) Token: 0x0603CFBA RID: 249786 RVA: 0x01189188 File Offset: 0x01187388
		// (set) Token: 0x0603CFBB RID: 249787 RVA: 0x01189190 File Offset: 0x01187390
		public int NodeId { get; set; }

		// Token: 0x1700736D RID: 29549
		// (get) Token: 0x0603CFBC RID: 249788 RVA: 0x01189199 File Offset: 0x01187399
		// (set) Token: 0x0603CFBD RID: 249789 RVA: 0x011891A1 File Offset: 0x011873A1
		[RequiredMember]
		public Vector Location { get; set; }

		// Token: 0x0603CFBE RID: 249790 RVA: 0x011891AA File Offset: 0x011873AA
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SceneItemGraphSelectResult()
		{
		}
	}
}
