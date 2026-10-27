using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x02006F31 RID: 28465
	[NullableContext(2)]
	[Nullable(0)]
	public class NpcStopMontageAction : GameplayAction
	{
		// Token: 0x06045409 RID: 283657 RVA: 0x0112288C File Offset: 0x01120A8C
		[NullableContext(1)]
		public void Init(EntityHandle entityHandle, UAnimMontage montage, float blendOutTime = 0.1f)
		{
			this.EntityHandle = entityHandle;
			this.Montage = montage;
			this.BlendOutTime = blendOutTime;
		}

		// Token: 0x0604540A RID: 283658 RVA: 0x011228A4 File Offset: 0x01120AA4
		protected override void OnExecuteAction()
		{
			UAnimMontage montage = this.Montage;
			if (montage == null || !montage.IsValid())
			{
				base.FinishExecute();
				return;
			}
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle == null || !entityHandle.IsInit)
			{
				base.FinishExecute();
				return;
			}
			BasePerformComponent component = entityHandle.Entity.GetComponent<BasePerformComponent>();
			if (component == null)
			{
				base.FinishExecute();
				return;
			}
			component.StopPerformMontage(EPerformMode.Action, new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.BlendOut),
				Montage = montage,
				BlendOutTime = new float?(this.BlendOutTime)
			}, null, null);
		}

		// Token: 0x0604540B RID: 283659 RVA: 0x0112292C File Offset: 0x01120B2C
		protected override void OnInterruptAction()
		{
		}

		// Token: 0x040241B2 RID: 147890
		private EntityHandle EntityHandle;

		// Token: 0x040241B3 RID: 147891
		private UAnimMontage Montage;

		// Token: 0x040241B4 RID: 147892
		private float BlendOutTime;
	}
}
