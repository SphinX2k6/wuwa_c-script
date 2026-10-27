using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02005146 RID: 20806
	public class PhantomArenaMainViewRoleSpineItem : UiPanelBase
	{
		// Token: 0x060352C2 RID: 217794 RVA: 0x00C99489 File Offset: 0x00C97689
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent))
			};
		}

		// Token: 0x060352C3 RID: 217795 RVA: 0x00C994C2 File Offset: 0x00C976C2
		protected override void OnStart()
		{
			base.GetSpine(0).SetAnimation(0, "idle", true);
			base.GetSpine(1).SetAnimation(0, "idle", true);
		}

		// Token: 0x0200B2A9 RID: 45737
		private class EComponent
		{
			// Token: 0x04036201 RID: 221697
			public const int SpineSkeleton1 = 0;

			// Token: 0x04036202 RID: 221698
			public const int SpineSkeleton2 = 1;
		}
	}
}
