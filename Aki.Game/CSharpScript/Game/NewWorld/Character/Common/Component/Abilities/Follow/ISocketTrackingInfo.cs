using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02006375 RID: 25461
	[NullableContext(1)]
	public interface ISocketTrackingInfo
	{
		// Token: 0x17007519 RID: 29977
		// (get) Token: 0x0603DAEB RID: 252651
		// (set) Token: 0x0603DAEC RID: 252652
		WeakReference<USceneComponent> TargetComponent { get; set; }

		// Token: 0x1700751A RID: 29978
		// (get) Token: 0x0603DAED RID: 252653
		// (set) Token: 0x0603DAEE RID: 252654
		FName SocketName { get; set; }
	}
}
