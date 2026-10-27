using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.SensoryInfo;

namespace CSharpScript.Game.NewWorld.Pawn.Controllers
{
	// Token: 0x02007068 RID: 28776
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SensoryInfoController
	{
		// Token: 0x060460C0 RID: 286912 RVA: 0x01177FB8 File Offset: 0x011761B8
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

		// Token: 0x060460C1 RID: 286913 RVA: 0x0117802C File Offset: 0x0117622C
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

		// Token: 0x060460C2 RID: 286914 RVA: 0x011781B4 File Offset: 0x011763B4
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

		// Token: 0x060460C3 RID: 286915 RVA: 0x0117820B File Offset: 0x0117640B
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

		// Token: 0x060460C4 RID: 286916 RVA: 0x01178238 File Offset: 0x01176438
		public void UpdateInfoType()
		{
			this.SensoryInfoType = 0;
			foreach (KeyValuePair<int, BaseSensoryInfo> keyValuePair in this.SensoryList)
			{
				this.SensoryInfoType |= (int)keyValuePair.Value.SensoryInfoType;
			}
		}

		// Token: 0x060460C5 RID: 286917 RVA: 0x011782A4 File Offset: 0x011764A4
		public void UpdateSensoryRange()
		{
			this.MaxSensoryRange = 0.0;
			foreach (KeyValuePair<int, BaseSensoryInfo> keyValuePair in this.SensoryList)
			{
				this.MaxSensoryRange = Math.Max(this.MaxSensoryRange, keyValuePair.Value.SensoryRange);
			}
		}

		// Token: 0x060460C6 RID: 286918 RVA: 0x0117831C File Offset: 0x0117651C
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

		// Token: 0x04024AD5 RID: 150229
		private int Uid;

		// Token: 0x04024AD6 RID: 150230
		public int SensoryInfoType;

		// Token: 0x04024AD7 RID: 150231
		public double MaxSensoryRange;

		// Token: 0x04024AD8 RID: 150232
		private readonly Dictionary<int, BaseSensoryInfo> SensoryList = new Dictionary<int, BaseSensoryInfo>();
	}
}
