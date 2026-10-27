using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005EF2 RID: 24306
	[NullableContext(1)]
	[Nullable(0)]
	public class GuQinActivityTabData
	{
		// Token: 0x0603DC46 RID: 252998 RVA: 0x00EEE38E File Offset: 0x00EEC58E
		public EGuQinActivityTabStatus GetStatus()
		{
			if (this.TaskList[0].GetStatus() == EGuQinActivityTaskStatus.Lock)
			{
				return EGuQinActivityTabStatus.Lock;
			}
			if (this.TaskList[this.TaskList.Count - 1].GetStatus() == EGuQinActivityTaskStatus.Completed)
			{
				return EGuQinActivityTabStatus.Completed;
			}
			return EGuQinActivityTabStatus.Progressing;
		}

		// Token: 0x0603DC47 RID: 252999 RVA: 0x00EEE3C8 File Offset: 0x00EEC5C8
		public string GetLockTip()
		{
			return this.TaskList[0].GetLockTip();
		}

		// Token: 0x0603DC48 RID: 253000 RVA: 0x00EEE3DC File Offset: 0x00EEC5DC
		public bool GetIsRedDot()
		{
			using (List<GuQinActivityTaskData>.Enumerator enumerator = this.TaskList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetIsRedDot())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0402045A RID: 132186
		public List<GuQinActivityTaskData> TaskList = new List<GuQinActivityTaskData>();
	}
}
