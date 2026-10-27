using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048D3 RID: 18643
	[NullableContext(1)]
	[Nullable(0)]
	public class RangeCheck
	{
		// Token: 0x06030B93 RID: 199571 RVA: 0x00B508CE File Offset: 0x00B4EACE
		public RangeCheck()
		{
			this.RangeMap = new Dictionary<int, SRangeContainer>();
		}

		// Token: 0x06030B94 RID: 199572 RVA: 0x00B508E1 File Offset: 0x00B4EAE1
		public bool OnInit()
		{
			return true;
		}

		// Token: 0x06030B95 RID: 199573 RVA: 0x00B508E4 File Offset: 0x00B4EAE4
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

		// Token: 0x06030B96 RID: 199574 RVA: 0x00B50954 File Offset: 0x00B4EB54
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

		// Token: 0x06030B97 RID: 199575 RVA: 0x00B509AC File Offset: 0x00B4EBAC
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

		// Token: 0x06030B98 RID: 199576 RVA: 0x00B509E8 File Offset: 0x00B4EBE8
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

		// Token: 0x06030B99 RID: 199577 RVA: 0x00B50A74 File Offset: 0x00B4EC74
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

		// Token: 0x06030B9A RID: 199578 RVA: 0x00B50B0C File Offset: 0x00B4ED0C
		public void Remove(int entityId)
		{
			if (this.RangeMap == null || !this.RangeMap.ContainsKey(entityId))
			{
				return;
			}
			this.RangeMap.Remove(entityId);
		}

		// Token: 0x06030B9B RID: 199579 RVA: 0x00B50B34 File Offset: 0x00B4ED34
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

		// Token: 0x06030B9C RID: 199580 RVA: 0x00B50BB8 File Offset: 0x00B4EDB8
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

		// Token: 0x0401A2CB RID: 107211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, SRangeContainer> RangeMap;

		// Token: 0x0401A2CC RID: 107212
		[Nullable(2)]
		public Vector PlayerPosition;
	}
}
