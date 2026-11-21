using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x0200384A RID: 14410
	[NullableContext(1)]
	[Nullable(0)]
	public class RangeCheck
	{
		// Token: 0x060256BF RID: 153279 RVA: 0x00A8B6D6 File Offset: 0x00A898D6
		public RangeCheck()
		{
			this.RangeMap = new Dictionary<int, SRangeContainer>();
		}

		// Token: 0x060256C0 RID: 153280 RVA: 0x00A8B6E9 File Offset: 0x00A898E9
		public bool OnInit()
		{
			return true;
		}

		// Token: 0x060256C1 RID: 153281 RVA: 0x00A8B6EC File Offset: 0x00A898EC
		public bool OnClear()
		{
			if (this.RangeMap != null)
			{
				foreach (SRangeContainer srangeContainer in this.RangeMap.Values)
				{
					srangeContainer.Clear();
				}
				this.RangeMap.Clear();
			}
			this.RangeMap = null;
			return true;
		}

		// Token: 0x060256C2 RID: 153282 RVA: 0x00A8B75C File Offset: 0x00A8995C
		[NullableContext(2)]
		public SRangeContainer GetOrAdd(int entityId)
		{
			if (this.RangeMap == null)
			{
				this.MakeRange(entityId);
				SRangeContainer result;
				this.RangeMap.TryGetValue(entityId, out result);
				return result;
			}
			SRangeContainer result2;
			if (!this.RangeMap.TryGetValue(entityId, out result2))
			{
				this.MakeRange(entityId);
				this.RangeMap.TryGetValue(entityId, out result2);
			}
			return result2;
		}

		// Token: 0x060256C3 RID: 153283 RVA: 0x00A8B7B4 File Offset: 0x00A899B4
		public bool MakeRange(int entityId)
		{
			if (this.RangeMap == null)
			{
				this.RangeMap = new Dictionary<int, SRangeContainer>();
			}
			SRangeContainer srangeContainer = new SRangeContainer();
			srangeContainer.MakeRange(entityId);
			this.RangeMap[entityId] = srangeContainer;
			return true;
		}

		// Token: 0x060256C4 RID: 153284 RVA: 0x00A8B7F0 File Offset: 0x00A899F0
		public int[] MapCheckReached()
		{
			List<int> list = new List<int>();
			if (this.RangeMap == null)
			{
				return list.ToArray();
			}
			foreach (KeyValuePair<int, SRangeContainer> keyValuePair in this.RangeMap)
			{
				int num;
				SRangeContainer srangeContainer;
				keyValuePair.Deconstruct(out num, out srangeContainer);
				int num2 = num;
				if (this.CheckReached(new int?(num2)))
				{
					list.Add(num2);
				}
			}
			return list.ToArray();
		}

		// Token: 0x060256C5 RID: 153285 RVA: 0x00A8B87C File Offset: 0x00A89A7C
		public bool CheckReached(int? entityId)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity != null && entityId != null)
			{
				int? num = entityId;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					WorldEntity entity = getCurrentEntity.Entity;
					Vector playerPosition;
					if (entity == null)
					{
						playerPosition = null;
					}
					else
					{
						BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
						playerPosition = ((component != null) ? component.ActorLocationProxy : null);
					}
					this.PlayerPosition = playerPosition;
					SRangeContainer srangeContainer;
					return this.PlayerPosition != null && this.RangeMap != null && this.RangeMap.TryGetValue(entityId.Value, out srangeContainer) && srangeContainer.CheckPositionReached(this.PlayerPosition);
				}
			}
			return false;
		}

		// Token: 0x060256C6 RID: 153286 RVA: 0x00A8B914 File Offset: 0x00A89B14
		public void Remove(int entityId)
		{
			if (this.RangeMap == null || !this.RangeMap.ContainsKey(entityId))
			{
				return;
			}
			this.RangeMap.Remove(entityId);
		}

		// Token: 0x060256C7 RID: 153287 RVA: 0x00A8B93C File Offset: 0x00A89B3C
		public int? MapCheckReachedPosition(Vector itemPosition)
		{
			int? result = null;
			if (this.RangeMap == null)
			{
				return result;
			}
			foreach (KeyValuePair<int, SRangeContainer> keyValuePair in this.RangeMap)
			{
				int num;
				SRangeContainer srangeContainer;
				keyValuePair.Deconstruct(out num, out srangeContainer);
				int value = num;
				if (this.CheckReachedPosition(new int?(value), itemPosition))
				{
					result = new int?(value);
				}
			}
			return result;
		}

		// Token: 0x060256C8 RID: 153288 RVA: 0x00A8B9C0 File Offset: 0x00A89BC0
		public bool CheckReachedPosition(int? entityId, Vector itemPosition)
		{
			if (entityId != null)
			{
				int? num = entityId;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null) && this.RangeMap != null)
				{
					SRangeContainer srangeContainer;
					return this.RangeMap.TryGetValue(entityId.Value, out srangeContainer) && srangeContainer.CheckPositionReached(itemPosition);
				}
			}
			return false;
		}

		// Token: 0x04014B3E RID: 84798
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, SRangeContainer> RangeMap;

		// Token: 0x04014B3F RID: 84799
		[Nullable(2)]
		public Vector PlayerPosition;
	}
}
