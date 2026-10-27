using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004C1C RID: 19484
	[NullableContext(1)]
	[Nullable(0)]
	public class TagChangeNextTickTask
	{
		// Token: 0x06032702 RID: 206594 RVA: 0x00BC0D34 File Offset: 0x00BBEF34
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

		// Token: 0x06032703 RID: 206595 RVA: 0x00BC0D84 File Offset: 0x00BBEF84
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

		// Token: 0x06032704 RID: 206596 RVA: 0x00BC0DE0 File Offset: 0x00BBEFE0
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

		// Token: 0x0401AD9A RID: 109978
		private readonly Dictionary<int, bool> TagChangeMap = new Dictionary<int, bool>();

		// Token: 0x0401AD9B RID: 109979
		[Nullable(2)]
		private TimerHandle TagChangeWaitTimerId;

		// Token: 0x0401AD9C RID: 109980
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private List<Action<Dictionary<int, bool>>> CallbackList = new List<Action<Dictionary<int, bool>>>();
	}
}
