using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BCD RID: 15309
	[NullableContext(1)]
	[Nullable(0)]
	public class TagChangeNextTickTask
	{
		// Token: 0x060274B5 RID: 160949 RVA: 0x00B059C0 File Offset: 0x00B03BC0
		public void TagChangeWaitNextTick(int gameplayTagId, bool bTagExist, Action<Dictionary<int, bool>> callback)
		{
			this.TagChangeMap[gameplayTagId] = bTagExist;
			this.CallbackList.Add(callback);
			if (this.TagChangeWaitTimerId != null)
			{
				return;
			}
			this.TagChangeWaitTimerId = TimerSystem.Instance.Next(new TTimerAction(this.OnTagChangeWait), null, null);
		}

		// Token: 0x060274B6 RID: 160950 RVA: 0x00B05A10 File Offset: 0x00B03C10
		public void Clear()
		{
			if (this.TagChangeWaitTimerId != null && TimerSystem.Instance.Has(this.TagChangeWaitTimerId))
			{
				TimerSystem.Instance.Remove(this.TagChangeWaitTimerId);
			}
			this.TagChangeWaitTimerId = null;
			this.CallbackList.Clear();
			this.TagChangeMap.Clear();
			this.CallbackList = null;
		}

		// Token: 0x060274B7 RID: 160951 RVA: 0x00B05A6C File Offset: 0x00B03C6C
		private void OnTagChangeWait(float _)
		{
			this.TagChangeWaitTimerId = null;
			if (this.CallbackList.Count > 0)
			{
				foreach (Action<Dictionary<int, bool>> action in this.CallbackList)
				{
					action(this.TagChangeMap);
				}
			}
			this.CallbackList.Clear();
			this.TagChangeMap.Clear();
		}

		// Token: 0x040156F7 RID: 87799
		private readonly Dictionary<int, bool> TagChangeMap = new Dictionary<int, bool>();

		// Token: 0x040156F8 RID: 87800
		[Nullable(2)]
		private TimerHandle TagChangeWaitTimerId;

		// Token: 0x040156F9 RID: 87801
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private List<Action<Dictionary<int, bool>>> CallbackList = new List<Action<Dictionary<int, bool>>>();
	}
}
