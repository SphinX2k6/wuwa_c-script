using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F34 RID: 16180
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackMarkManager
	{
		// Token: 0x06028FBE RID: 167870 RVA: 0x00B80B34 File Offset: 0x00B7ED34
		public void StartMark(EntityHandle entityHandle, double uploadTime, double duration, string iconPath)
		{
			int num = this.MarkId + 1;
			this.MarkId = num;
			int num2 = num;
			QuickHackMarkInstance quickHackMarkInstance = new QuickHackMarkInstance();
			quickHackMarkInstance.StartMark(num2, entityHandle, uploadTime, duration, iconPath);
			this.EntityMarksMap[num2] = quickHackMarkInstance;
			EventSystem.Instance.Emit<QuickHackMarkInstance>(EEventName.OnQuickHackStartMark, quickHackMarkInstance);
		}

		// Token: 0x06028FBF RID: 167871 RVA: 0x00B80B83 File Offset: 0x00B7ED83
		public IEnumerable<QuickHackMarkInstance> GetMarks()
		{
			return this.EntityMarksMap.Values;
		}

		// Token: 0x06028FC0 RID: 167872 RVA: 0x00B80B90 File Offset: 0x00B7ED90
		public void Clear()
		{
			foreach (QuickHackMarkInstance quickHackMarkInstance in this.EntityMarksMap.Values)
			{
				quickHackMarkInstance.ClearMark();
			}
			this.EntityMarksMap.Clear();
		}

		// Token: 0x06028FC1 RID: 167873 RVA: 0x00B80BF0 File Offset: 0x00B7EDF0
		public void UpdateMarks()
		{
			if (this.EntityMarksMap.Count <= 0)
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, QuickHackMarkInstance> keyValuePair in this.EntityMarksMap)
			{
				int num;
				QuickHackMarkInstance quickHackMarkInstance;
				keyValuePair.Deconstruct(out num, out quickHackMarkInstance);
				int item = num;
				QuickHackMarkInstance quickHackMarkInstance2 = quickHackMarkInstance;
				quickHackMarkInstance2.UpdateMark();
				if (quickHackMarkInstance2.IsFinish())
				{
					list.Add(item);
				}
			}
			foreach (int key in list)
			{
				this.EntityMarksMap.Remove(key);
			}
		}

		// Token: 0x0401648F RID: 91279
		private int MarkId;

		// Token: 0x04016490 RID: 91280
		private readonly Dictionary<int, QuickHackMarkInstance> EntityMarksMap = new Dictionary<int, QuickHackMarkInstance>();
	}
}
