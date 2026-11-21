using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.SensoryInfo;

namespace CSharpScript.Game.NewWorld.Pawn.Controllers
{
	// Token: 0x020061E9 RID: 25065
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SensoryInfoController
	{
		// Token: 0x0603C2BC RID: 246460 RVA: 0x01121C80 File Offset: 0x0111FE80
		public void Tick(float delta)
		{
			if ((this.SensoryInfoType & 2) != 0)
			{
				foreach (KeyValuePair<int, BaseSensoryInfo> keyValuePair in this.SensoryList)
				{
					if (keyValuePair.Value.CheckInRange())
					{
						keyValuePair.Value.Tick(delta);
					}
				}
			}
		}

		// Token: 0x0603C2BD RID: 246461 RVA: 0x01121CF4 File Offset: 0x0111FEF4
		public void HandleEntities(EntityHandle[] handles, Vector actorLocation, int curEntityId)
		{
			foreach (KeyValuePair<int, BaseSensoryInfo> keyValuePair in this.SensoryList)
			{
				keyValuePair.Value.ClearCacheList();
			}
			foreach (EntityHandle entityHandle in handles)
			{
				int id = entityHandle.Id;
				WorldEntity entity = entityHandle.Entity;
				BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
				if (entityHandle != null)
				{
					WorldEntity entity2 = entityHandle.Entity;
					if (entity2 != null && entity2.Active && baseActorComponent != null && id != curEntityId)
					{
						double num = Vector.Distance(baseActorComponent.ActorLocationProxy, actorLocation);
						foreach (KeyValuePair<int, BaseSensoryInfo> keyValuePair2 in this.SensoryList)
						{
							if (num <= keyValuePair2.Value.SensoryRange && keyValuePair2.Value.CheckEntity(entityHandle.Entity))
							{
								keyValuePair2.Value.EnterRange(entityHandle.Entity);
							}
						}
					}
				}
			}
			foreach (KeyValuePair<int, BaseSensoryInfo> keyValuePair3 in this.SensoryList)
			{
				keyValuePair3.Value.ExitRange();
			}
		}

		// Token: 0x0603C2BE RID: 246462 RVA: 0x01121E7C File Offset: 0x0112007C
		public int AddSensoryInfo(BaseSensoryInfo sensoryParam)
		{
			this.SensoryInfoType |= (int)sensoryParam.SensoryInfoType;
			this.MaxSensoryRange = Math.Max(this.MaxSensoryRange, sensoryParam.SensoryRange);
			int num = this.Uid + 1;
			this.Uid = num;
			int num2 = num;
			this.SensoryList[num2] = sensoryParam;
			return num2;
		}

		// Token: 0x0603C2BF RID: 246463 RVA: 0x01121ED3 File Offset: 0x011200D3
		public bool RemoveSensoryInfo(int key)
		{
			if (!this.SensoryList.ContainsKey(key))
			{
				return false;
			}
			this.SensoryList.Remove(key);
			this.UpdateInfoType();
			this.UpdateSensoryRange();
			return true;
		}

		// Token: 0x0603C2C0 RID: 246464 RVA: 0x01121F00 File Offset: 0x01120100
		public void UpdateInfoType()
		{
			this.SensoryInfoType = 0;
			foreach (KeyValuePair<int, BaseSensoryInfo> keyValuePair in this.SensoryList)
			{
				this.SensoryInfoType |= (int)keyValuePair.Value.SensoryInfoType;
			}
		}

		// Token: 0x0603C2C1 RID: 246465 RVA: 0x01121F6C File Offset: 0x0112016C
		public void UpdateSensoryRange()
		{
			this.MaxSensoryRange = 0.0;
			foreach (KeyValuePair<int, BaseSensoryInfo> keyValuePair in this.SensoryList)
			{
				this.MaxSensoryRange = Math.Max(this.MaxSensoryRange, keyValuePair.Value.SensoryRange);
			}
		}

		// Token: 0x0603C2C2 RID: 246466 RVA: 0x01121FE4 File Offset: 0x011201E4
		public void Clear()
		{
			this.Uid = 0;
			this.SensoryInfoType = 0;
			this.MaxSensoryRange = 0.0;
			foreach (KeyValuePair<int, BaseSensoryInfo> keyValuePair in this.SensoryList)
			{
				keyValuePair.Value.Clear();
			}
			this.SensoryList.Clear();
		}

		// Token: 0x0401FD90 RID: 130448
		private int Uid;

		// Token: 0x0401FD91 RID: 130449
		public int SensoryInfoType;

		// Token: 0x0401FD92 RID: 130450
		public double MaxSensoryRange;

		// Token: 0x0401FD93 RID: 130451
		private readonly Dictionary<int, BaseSensoryInfo> SensoryList = new Dictionary<int, BaseSensoryInfo>();
	}
}
