using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007166 RID: 29030
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GuidePathVisibilityHost : IGuidePathVisibilityHost
	{
		// Token: 0x17009D5B RID: 40283
		// (get) Token: 0x06046DD5 RID: 290261 RVA: 0x011DF4DB File Offset: 0x011DD6DB
		// (set) Token: 0x06046DD6 RID: 290262 RVA: 0x011DF4E3 File Offset: 0x011DD6E3
		[RequiredMember]
		public Action<ISceneItemGuidePathVisibilityProvider, EGuidePathProviderRemovedBehavior?> SetExternalVisibilityProvider { get; set; }

		// Token: 0x17009D5C RID: 40284
		// (get) Token: 0x06046DD7 RID: 290263 RVA: 0x011DF4EC File Offset: 0x011DD6EC
		// (set) Token: 0x06046DD8 RID: 290264 RVA: 0x011DF4F4 File Offset: 0x011DD6F4
		[RequiredMember]
		public Action<ISceneItemGuidePathVisibilityProvider> ClearExternalVisibilityProvider { get; set; }

		// Token: 0x17009D5D RID: 40285
		// (get) Token: 0x06046DD9 RID: 290265 RVA: 0x011DF4FD File Offset: 0x011DD6FD
		// (set) Token: 0x06046DDA RID: 290266 RVA: 0x011DF505 File Offset: 0x011DD705
		[RequiredMember]
		public Action<ISceneItemGuidePathVisibilityProvider> NotifyExternalVisibilityChanged { get; set; }

		// Token: 0x17009D5E RID: 40286
		// (get) Token: 0x06046DDB RID: 290267 RVA: 0x011DF50E File Offset: 0x011DD70E
		// (set) Token: 0x06046DDC RID: 290268 RVA: 0x011DF516 File Offset: 0x011DD716
		[RequiredMember]
		public Func<bool> HasExternalVisibilityProvider { get; set; }

		// Token: 0x06046DDD RID: 290269 RVA: 0x011DF51F File Offset: 0x011DD71F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GuidePathVisibilityHost()
		{
		}
	}
}
