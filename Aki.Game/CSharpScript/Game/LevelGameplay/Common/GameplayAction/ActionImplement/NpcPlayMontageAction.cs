using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x02006F30 RID: 28464
	[NullableContext(2)]
	[Nullable(0)]
	public class NpcPlayMontageAction : GameplayAction
	{
		// Token: 0x06045403 RID: 283651 RVA: 0x0112272D File Offset: 0x0112092D
		[NullableContext(1)]
		public void Init(EntityHandle entityHandle, UAnimMontage montage, bool isLoop, bool needInterrupt = true)
		{
			this.IsLoopInner = isLoop;
			this.EntityHandle = entityHandle;
			this.Montage = montage;
			this.NeedInterrupt = needInterrupt;
		}

		// Token: 0x06045404 RID: 283652 RVA: 0x0112274C File Offset: 0x0112094C
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

		// Token: 0x06045405 RID: 283653 RVA: 0x011227DC File Offset: 0x011209DC
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

		// Token: 0x040241AF RID: 147887
		private EntityHandle EntityHandle;

		// Token: 0x040241B0 RID: 147888
		private UAnimMontage Montage;

		// Token: 0x040241B1 RID: 147889
		private bool NeedInterrupt = true;
	}
}
