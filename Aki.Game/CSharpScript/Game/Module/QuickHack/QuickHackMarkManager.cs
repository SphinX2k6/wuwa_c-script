using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F6B RID: 20331
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackMarkManager
	{
		// Token: 0x06034150 RID: 213328 RVA: 0x00C37394 File Offset: 0x00C35594
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

		// Token: 0x06034151 RID: 213329 RVA: 0x00C373E3 File Offset: 0x00C355E3
		public IEnumerable<QuickHackMarkInstance> GetMarks()
		{
			return this.EntityMarksMap.Values;
		}

		// Token: 0x06034152 RID: 213330 RVA: 0x00C373F0 File Offset: 0x00C355F0
		public void Clear()
		{
			foreach (QuickHackMarkInstance quickHackMarkInstance in this.EntityMarksMap.Values)
			{
				quickHackMarkInstance.ClearMark();
			}
			this.EntityMarksMap.Clear();
		}

		// Token: 0x06034153 RID: 213331 RVA: 0x00C37450 File Offset: 0x00C35650
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

		// Token: 0x0401BABA RID: 113338
		private int MarkId;

		// Token: 0x0401BABB RID: 113339
		private readonly Dictionary<int, QuickHackMarkInstance> EntityMarksMap = new Dictionary<int, QuickHackMarkInstance>();
	}
}
