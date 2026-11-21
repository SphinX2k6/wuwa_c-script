using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200621A RID: 25114
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GuidePathVisibilityHost : IGuidePathVisibilityHost
	{
		// Token: 0x17007206 RID: 29190
		// (get) Token: 0x0603C621 RID: 247329 RVA: 0x0113AF3B File Offset: 0x0113913B
		// (set) Token: 0x0603C622 RID: 247330 RVA: 0x0113AF43 File Offset: 0x01139143
		[RequiredMember]
		public Action<ISceneItemGuidePathVisibilityProvider, EGuidePathProviderRemovedBehavior?> SetExternalVisibilityProvider { get; set; }

		// Token: 0x17007207 RID: 29191
		// (get) Token: 0x0603C623 RID: 247331 RVA: 0x0113AF4C File Offset: 0x0113914C
		// (set) Token: 0x0603C624 RID: 247332 RVA: 0x0113AF54 File Offset: 0x01139154
		[RequiredMember]
		public Action<ISceneItemGuidePathVisibilityProvider> ClearExternalVisibilityProvider { get; set; }

		// Token: 0x17007208 RID: 29192
		// (get) Token: 0x0603C625 RID: 247333 RVA: 0x0113AF5D File Offset: 0x0113915D
		// (set) Token: 0x0603C626 RID: 247334 RVA: 0x0113AF65 File Offset: 0x01139165
		[RequiredMember]
		public Action<ISceneItemGuidePathVisibilityProvider> NotifyExternalVisibilityChanged { get; set; }

		// Token: 0x17007209 RID: 29193
		// (get) Token: 0x0603C627 RID: 247335 RVA: 0x0113AF6E File Offset: 0x0113916E
		// (set) Token: 0x0603C628 RID: 247336 RVA: 0x0113AF76 File Offset: 0x01139176
		[RequiredMember]
		public Func<bool> HasExternalVisibilityProvider { get; set; }

		// Token: 0x0603C629 RID: 247337 RVA: 0x0113AF7F File Offset: 0x0113917F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GuidePathVisibilityHost()
		{
		}
	}
}
