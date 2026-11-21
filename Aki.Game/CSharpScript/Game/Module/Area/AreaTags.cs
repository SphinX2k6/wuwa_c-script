using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Area
{
	// Token: 0x02004E88 RID: 20104
	public class AreaTags
	{
		// Token: 0x060329FD RID: 207357 RVA: 0x00E34805 File Offset: 0x00E32A05
		public void Init()
		{
			this.AddEventListener();
		}

		// Token: 0x060329FE RID: 207358 RVA: 0x00E3480D File Offset: 0x00E32A0D
		public void Destroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x060329FF RID: 207359 RVA: 0x00E34818 File Offset: 0x00E32A18
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			EventSystem.Instance.Add(EEventName.ChangeModeFinish, new Action(this.OnChangeModeFinish));
		}

		// Token: 0x06032A00 RID: 207360 RVA: 0x00E3487C File Offset: 0x00E32A7C
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
			EventSystem.Instance.Remove(EEventName.ChangeModeFinish, new Action(this.OnChangeModeFinish));
		}

		// Token: 0x06032A01 RID: 207361 RVA: 0x00E348E0 File Offset: 0x00E32AE0
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

		// Token: 0x06032A02 RID: 207362 RVA: 0x00E3496C File Offset: 0x00E32B6C
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

		// Token: 0x06032A03 RID: 207363 RVA: 0x00E349F8 File Offset: 0x00E32BF8
		private void OnChangeModeFinish()
		{
			if (AreaModel.Instance.AreaInfo == null)
			{
				return;
			}
			this.OnChangeArea(null, new int?(AreaModel.Instance.AreaInfo.Value.AreaId));
		}

		// Token: 0x06032A04 RID: 207364 RVA: 0x00E34A48 File Offset: 0x00E32C48
		private void OnChangeAreaEvent(int? preAreaId, int curAreaId)
		{
			this.OnChangeArea(preAreaId, new int?(curAreaId));
		}

		// Token: 0x06032A05 RID: 207365 RVA: 0x00E34A58 File Offset: 0x00E32C58
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

		// Token: 0x06032A06 RID: 207366 RVA: 0x00E34C18 File Offset: 0x00E32E18
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
