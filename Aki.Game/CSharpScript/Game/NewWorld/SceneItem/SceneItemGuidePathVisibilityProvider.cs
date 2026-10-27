using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007163 RID: 29027
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class SceneItemGuidePathVisibilityProvider : ISceneItemGuidePathVisibilityProvider
	{
		// Token: 0x17009D55 RID: 40277
		// (get) Token: 0x06046DC8 RID: 290248 RVA: 0x011DF4B1 File Offset: 0x011DD6B1
		// (set) Token: 0x06046DC9 RID: 290249 RVA: 0x011DF4B9 File Offset: 0x011DD6B9
		[RequiredMember]
		public Func<bool> IsVisible { get; set; }

		// Token: 0x17009D56 RID: 40278
		// (get) Token: 0x06046DCA RID: 290250 RVA: 0x011DF4C2 File Offset: 0x011DD6C2
		// (set) Token: 0x06046DCB RID: 290251 RVA: 0x011DF4CA File Offset: 0x011DD6CA
		[Nullable(2)]
		public Action OnDetached { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06046DCC RID: 290252 RVA: 0x011DF4D3 File Offset: 0x011DD6D3
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SceneItemGuidePathVisibilityProvider()
		{
		}
	}
}
