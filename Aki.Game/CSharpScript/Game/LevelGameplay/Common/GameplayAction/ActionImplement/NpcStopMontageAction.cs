using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x020060B2 RID: 24754
	[NullableContext(2)]
	[Nullable(0)]
	public class NpcStopMontageAction : GameplayAction
	{
		// Token: 0x0603B5B7 RID: 243127 RVA: 0x010CC838 File Offset: 0x010CAA38
		[NullableContext(1)]
		public void Init(EntityHandle entityHandle, UAnimMontage montage, float blendOutTime = 0.1f)
		{
			this.EntityHandle = entityHandle;
			this.Montage = montage;
			this.BlendOutTime = blendOutTime;
		}

		// Token: 0x0603B5B8 RID: 243128 RVA: 0x010CC850 File Offset: 0x010CAA50
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

		// Token: 0x0603B5B9 RID: 243129 RVA: 0x010CC8D8 File Offset: 0x010CAAD8
		protected override void OnInterruptAction()
		{
		}

		// Token: 0x0401F467 RID: 128103
		private EntityHandle EntityHandle;

		// Token: 0x0401F468 RID: 128104
		private UAnimMontage Montage;

		// Token: 0x0401F469 RID: 128105
		private float BlendOutTime;
	}
}
