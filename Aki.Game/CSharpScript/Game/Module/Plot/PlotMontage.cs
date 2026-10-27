using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02005000 RID: 20480
	public class PlotMontage
	{
		// Token: 0x06034665 RID: 214629 RVA: 0x00C51EC4 File Offset: 0x00C500C4
		[NullableContext(2)]
		public void StartPlayMontage(PlayMontage inMontageData)
		{
			if (inMontageData == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(inMontageData.ActionMontage.Path) || inMontageData.ActionMontage.Path == "Empty")
			{
				return;
			}
			EntityHandle entityHandle = (inMontageData.EntityId == 0) ? PlotModel.Instance.CurrentInteractEntity : CreatureModel.Instance.GetEntityByPbDataId(inMontageData.EntityId);
			if (entityHandle == null || !entityHandle.IsInit)
			{
				return;
			}
			WorldEntity entity = entityHandle.Entity;
			BasePerformComponent basePerformComponent = (entity != null) ? entity.GetComponent<BasePerformComponent>() : null;
			if (basePerformComponent == null)
			{
				return;
			}
			basePerformComponent.OnNpcInPlot(true);
			basePerformComponent.PlayPerformMontage(EPerformMode.Plot, new IPlayMontageParam
			{
				MontagePath = inMontageData.ActionMontage.Path,
				IsLoop = new bool?(false)
			}, null, null, false);
			this.EntitySet.Add(entityHandle);
		}

		// Token: 0x06034666 RID: 214630 RVA: 0x00C51F90 File Offset: 0x00C50190
		public void StopAllMontage()
		{
			foreach (EntityHandle entityHandle in this.EntitySet)
			{
				if (entityHandle.Valid)
				{
					WorldEntity entity = entityHandle.Entity;
					CommonNpcPerformComponent commonNpcPerformComponent = (entity != null) ? entity.GetComponent<CommonNpcPerformComponent>() : null;
					if (commonNpcPerformComponent == null)
					{
						return;
					}
					commonNpcPerformComponent.StopPerformMontage(EPerformMode.Plot, new IStopMontageParam
					{
						Method = new EStopMethod?(EStopMethod.BlendOut)
					}, null, null);
					commonNpcPerformComponent.OnNpcInPlot(false);
				}
			}
			this.EntitySet.Clear();
		}

		// Token: 0x0401BE7A RID: 114298
		[Nullable(1)]
		private readonly HashSet<EntityHandle> EntitySet = new HashSet<EntityHandle>();
	}
}
