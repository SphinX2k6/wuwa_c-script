using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02007147 RID: 28999
	[NullableContext(1)]
	public interface ISocketTrackingInfo
	{
		// Token: 0x17009D47 RID: 40263
		// (get) Token: 0x06046C9A RID: 289946
		// (set) Token: 0x06046C9B RID: 289947
		WeakReference<USceneComponent> TargetComponent { get; set; }

		// Token: 0x17009D48 RID: 40264
		// (get) Token: 0x06046C9C RID: 289948
		// (set) Token: 0x06046C9D RID: 289949
		FName SocketName { get; set; }
	}
}
