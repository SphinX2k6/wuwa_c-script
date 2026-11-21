using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006217 RID: 25111
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class SceneItemGuidePathVisibilityProvider : ISceneItemGuidePathVisibilityProvider
	{
		// Token: 0x17007200 RID: 29184
		// (get) Token: 0x0603C614 RID: 247316 RVA: 0x0113AF11 File Offset: 0x01139111
		// (set) Token: 0x0603C615 RID: 247317 RVA: 0x0113AF19 File Offset: 0x01139119
		[RequiredMember]
		public Func<bool> IsVisible { get; set; }

		// Token: 0x17007201 RID: 29185
		// (get) Token: 0x0603C616 RID: 247318 RVA: 0x0113AF22 File Offset: 0x01139122
		// (set) Token: 0x0603C617 RID: 247319 RVA: 0x0113AF2A File Offset: 0x0113912A
		[Nullable(2)]
		public Action OnDetached { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x0603C618 RID: 247320 RVA: 0x0113AF33 File Offset: 0x01139133
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SceneItemGuidePathVisibilityProvider()
		{
		}
	}
}
