using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare
{
	// Token: 0x02004116 RID: 16662
	public class PhantomArenaMainViewRoleSpineItem : UiPanelBase
	{
		// Token: 0x0602A1BE RID: 172478 RVA: 0x00BE6989 File Offset: 0x00BE4B89
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent))
			};
		}

		// Token: 0x0602A1BF RID: 172479 RVA: 0x00BE69C2 File Offset: 0x00BE4BC2
		protected override void OnStart()
		{
			base.GetSpine(0).SetAnimation(0, "idle", true);
			base.GetSpine(1).SetAnimation(0, "idle", true);
		}

		// Token: 0x02009CE2 RID: 40162
		private class EComponent
		{
			// Token: 0x04030C56 RID: 199766
			public const int SpineSkeleton1 = 0;

			// Token: 0x04030C57 RID: 199767
			public const int SpineSkeleton2 = 1;
		}
	}
}
