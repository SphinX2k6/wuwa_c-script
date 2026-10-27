using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Area
{
	// Token: 0x02005EA3 RID: 24227
	public class AreaTags
	{
		// Token: 0x0603DA6D RID: 252525 RVA: 0x00EE32B9 File Offset: 0x00EE14B9
		public void Init()
		{
			this.AddEventListener();
		}

		// Token: 0x0603DA6E RID: 252526 RVA: 0x00EE32C1 File Offset: 0x00EE14C1
		public void Destroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x0603DA6F RID: 252527 RVA: 0x00EE32CC File Offset: 0x00EE14CC
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			EventSystem.Instance.Add(EEventName.ChangeModeFinish, new Action(this.OnChangeModeFinish));
		}

		// Token: 0x0603DA70 RID: 252528 RVA: 0x00EE3330 File Offset: 0x00EE1530
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
			EventSystem.Instance.Remove(EEventName.ChangeModeFinish, new Action(this.OnChangeModeFinish));
		}

		// Token: 0x0603DA71 RID: 252529 RVA: 0x00EE3394 File Offset: 0x00EE1594
		private void OnWorldDone()
		{
			if (!EventSystem.Instance.Has<int?, int>(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeAreaEvent)))
			{
				EventSystem.Instance.Add<int?, int>(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeAreaEvent));
			}
			if (AreaModel.Instance.AreaInfo == null)
			{
				return;
			}
			this.OnChangeArea(null, new int?(AreaModel.Instance.AreaInfo.Value.AreaId));
		}

		// Token: 0x0603DA72 RID: 252530 RVA: 0x00EE3420 File Offset: 0x00EE1620
		private void OnClearWorld()
		{
			if (EventSystem.Instance.Has<int?, int>(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeAreaEvent)))
			{
				EventSystem.Instance.Remove(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeAreaEvent));
			}
			if (AreaModel.Instance.AreaInfo == null)
			{
				return;
			}
			this.OnChangeArea(new int?(AreaModel.Instance.AreaInfo.Value.AreaId), null);
		}

		// Token: 0x0603DA73 RID: 252531 RVA: 0x00EE34AC File Offset: 0x00EE16AC
		private void OnChangeModeFinish()
		{
			if (AreaModel.Instance.AreaInfo == null)
			{
				return;
			}
			this.OnChangeArea(null, new int?(AreaModel.Instance.AreaInfo.Value.AreaId));
		}

		// Token: 0x0603DA74 RID: 252532 RVA: 0x00EE34FC File Offset: 0x00EE16FC
		private void OnChangeAreaEvent(int? preAreaId, int curAreaId)
		{
			this.OnChangeArea(preAreaId, new int?(curAreaId));
		}

		// Token: 0x0603DA75 RID: 252533 RVA: 0x00EE350C File Offset: 0x00EE170C
		private void OnChangeArea(int? preAreaId, int? curAreaId)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			int num = curAreaId.GetValueOrDefault();
			HashSet<int> hashSet = new HashSet<int>();
			while (num != 0)
			{
				hashSet.Add(num);
				Area? areaInfo = AreaConfig.Instance.GetAreaInfo(num);
				if (areaInfo != null && areaInfo.GetValueOrDefault().EnterAreaTagsLength > 0)
				{
					foreach (DicIntInt dicIntInt in areaInfo.Value.EnterAreaTagsIter())
					{
						if (!dictionary.ContainsKey(dicIntInt.Key))
						{
							dictionary.Add(dicIntInt.Key, dicIntInt.Value);
						}
					}
				}
				num = ((areaInfo != null) ? areaInfo.GetValueOrDefault().Father : 0);
			}
			num = preAreaId.GetValueOrDefault();
			while (num != 0 && !hashSet.Contains(num))
			{
				Area? areaInfo2 = AreaConfig.Instance.GetAreaInfo(num);
				if (areaInfo2 != null && areaInfo2.GetValueOrDefault().LeaveAreaTagsLength > 0)
				{
					foreach (DicIntInt dicIntInt2 in areaInfo2.Value.LeaveAreaTagsIter())
					{
						if (!dictionary.ContainsKey(dicIntInt2.Key))
						{
							dictionary.Add(dicIntInt2.Key, dicIntInt2.Value);
						}
					}
				}
				num = ((areaInfo2 != null) ? areaInfo2.GetValueOrDefault().Father : 0);
			}
			this.ApplyAreaTagsModifyInfo(dictionary);
		}

		// Token: 0x0603DA76 RID: 252534 RVA: 0x00EE36CC File Offset: 0x00EE18CC
		[NullableContext(1)]
		private void ApplyAreaTagsModifyInfo(Dictionary<int, int> tagsToModify)
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			bool flag = FormationDataController.Instance.IsPlayerExist(playerId);
			foreach (KeyValuePair<int, int> keyValuePair in tagsToModify)
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int num3 = num;
				int num4 = num2;
				if (num4 == 0)
				{
					if (flag && FormationDataController.Instance.HasPlayerTag(playerId, num3, true))
					{
						FormationDataController.Instance.RemovePlayerTag(playerId, new int?(num3));
					}
				}
				else if (num4 == 1 && flag && !FormationDataController.Instance.HasPlayerTag(playerId, num3, true))
				{
					FormationDataController.Instance.AddPlayerTag(playerId, new int?(num3));
				}
			}
		}
	}
}
