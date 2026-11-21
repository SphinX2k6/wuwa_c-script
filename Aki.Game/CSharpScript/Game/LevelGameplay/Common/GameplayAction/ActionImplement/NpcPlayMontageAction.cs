using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x020060B1 RID: 24753
	[NullableContext(2)]
	[Nullable(0)]
	public class NpcPlayMontageAction : GameplayAction
	{
		// Token: 0x0603B5B1 RID: 243121 RVA: 0x010CC6D9 File Offset: 0x010CA8D9
		[NullableContext(1)]
		public void Init(EntityHandle entityHandle, UAnimMontage montage, bool isLoop, bool needInterrupt = true)
		{
			this.IsLoopInner = isLoop;
			this.EntityHandle = entityHandle;
			this.Montage = montage;
			this.NeedInterrupt = needInterrupt;
		}

		// Token: 0x0603B5B2 RID: 243122 RVA: 0x010CC6F8 File Offset: 0x010CA8F8
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
			bool isLoopInner = this.IsLoopInner;
			component.PlayPerformMontage(EPerformMode.Action, new IPlayMontageParam
			{
				MontageAsset = montage,
				IsLoop = new bool?(isLoopInner)
			}, null, isLoopInner ? null : new Action<int>(delegate(int _)
			{
				TimerSystem.Instance.Next(delegate(float _)
				{
					base.FinishExecute();
				}, null, null);
			}), false);
		}

		// Token: 0x0603B5B3 RID: 243123 RVA: 0x010CC788 File Offset: 0x010CA988
		protected override void OnInterruptAction()
		{
			if (!this.NeedInterrupt)
			{
				return;
			}
			UAnimMontage montage = this.Montage;
			if (montage == null || !montage.IsValid())
			{
				return;
			}
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle == null || !entityHandle.IsInit)
			{
				return;
			}
			BasePerformComponent component = entityHandle.Entity.GetComponent<BasePerformComponent>();
			if (component == null)
			{
				return;
			}
			component.StopPerformMontage(EPerformMode.Action, new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.BlendOut),
				Montage = montage,
				BlendOutTime = new float?(0.1f)
			}, null, null);
		}

		// Token: 0x0401F464 RID: 128100
		private EntityHandle EntityHandle;

		// Token: 0x0401F465 RID: 128101
		private UAnimMontage Montage;

		// Token: 0x0401F466 RID: 128102
		private bool NeedInterrupt = true;
	}
}
