using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200712D RID: 28973
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class SocketTrackingInfo : ISocketTrackingInfo
	{
		// Token: 0x17009D36 RID: 40246
		// (get) Token: 0x06046BDC RID: 289756 RVA: 0x011D28AC File Offset: 0x011D0AAC
		// (set) Token: 0x06046BDD RID: 289757 RVA: 0x011D28B4 File Offset: 0x011D0AB4
		[RequiredMember]
		public WeakReference<USceneComponent> TargetComponent { get; set; }

		// Token: 0x17009D37 RID: 40247
		// (get) Token: 0x06046BDE RID: 289758 RVA: 0x011D28BD File Offset: 0x011D0ABD
		// (set) Token: 0x06046BDF RID: 289759 RVA: 0x011D28C5 File Offset: 0x011D0AC5
		[RequiredMember]
		public FName SocketName { get; set; }

		// Token: 0x06046BE0 RID: 289760 RVA: 0x011D28CE File Offset: 0x011D0ACE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SocketTrackingInfo()
		{
		}
	}
}
