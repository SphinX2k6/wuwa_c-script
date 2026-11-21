using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x0200635B RID: 25435
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class SocketTrackingInfo : ISocketTrackingInfo
	{
		// Token: 0x17007505 RID: 29957
		// (get) Token: 0x0603DA2A RID: 252458 RVA: 0x011DB40C File Offset: 0x011D960C
		// (set) Token: 0x0603DA2B RID: 252459 RVA: 0x011DB414 File Offset: 0x011D9614
		[RequiredMember]
		public WeakReference<USceneComponent> TargetComponent { get; set; }

		// Token: 0x17007506 RID: 29958
		// (get) Token: 0x0603DA2C RID: 252460 RVA: 0x011DB41D File Offset: 0x011D961D
		// (set) Token: 0x0603DA2D RID: 252461 RVA: 0x011DB425 File Offset: 0x011D9625
		[RequiredMember]
		public FName SocketName { get; set; }

		// Token: 0x0603DA2E RID: 252462 RVA: 0x011DB42E File Offset: 0x011D962E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SocketTrackingInfo()
		{
		}
	}
}
