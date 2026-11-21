using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02004ED9 RID: 20185
	[NullableContext(1)]
	[Nullable(0)]
	public class GuQinActivityTabData
	{
		// Token: 0x06032BE1 RID: 207841 RVA: 0x00E40052 File Offset: 0x00E3E252
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

		// Token: 0x06032BE2 RID: 207842 RVA: 0x00E4008C File Offset: 0x00E3E28C
		public string GetLockTip()
		{
			return this.TaskList[0].GetLockTip();
		}

		// Token: 0x06032BE3 RID: 207843 RVA: 0x00E400A0 File Offset: 0x00E3E2A0
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

		// Token: 0x0401AF2C RID: 110380
		public List<GuQinActivityTaskData> TaskList = new List<GuQinActivityTaskData>();
	}
}
