using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020027A2 RID: 10146
[NullableContext(1)]
[Nullable(0)]
public class RoleForbidMovementHelper
{
	// Token: 0x060196EC RID: 104172 RVA: 0x007C9570 File Offset: 0x007C7770
	public void RegisterMutuallyTags(List<int> mutuallyTags)
	{
		foreach (int key in mutuallyTags)
		{
			LimitTagHandler limitTagHandler;
			if (this.Handlers.TryGetValue(key, out limitTagHandler))
			{
				foreach (int num in mutuallyTags)
				{
					if (num != limitTagHandler.TagId)
					{
						limitTagHandler.MutuallyTags.Add(num);
					}
				}
			}
		}
	}

	// Token: 0x060196ED RID: 104173 RVA: 0x007C9618 File Offset: 0x007C7818
	public void Awake()
	{
		foreach (KeyValuePair<int, LimitTagHandler> keyValuePair in this.Handlers)
		{
			bool gameplayTagExist = this.TagComp.HasTag(keyValuePair.Key);
			this.TagCallback(keyValuePair.Key, gameplayTagExist);
		}
	}

	// Token: 0x060196EE RID: 104174 RVA: 0x007C9688 File Offset: 0x007C7888
	public void ActiveHandler(LimitTagHandler activeHandler, bool active)
	{
		activeHandler.Active = active;
		activeHandler.CallBack(active);
		if (active)
		{
			this.CurrentActiveHandlers.Add(activeHandler);
			return;
		}
		int num = this.CurrentActiveHandlers.IndexOf(activeHandler);
		if (num < 0)
		{
			return;
		}
		this.CurrentActiveHandlers.RemoveAt(num);
	}

	// Token: 0x060196EF RID: 104175 RVA: 0x007C96D8 File Offset: 0x007C78D8
	private void TagCallback(int addOrRemoveTagId, bool gameplayTagExist)
	{
		LimitTagHandler valueOrDefault = this.Handlers.GetValueOrDefault(addOrRemoveTagId);
		if (valueOrDefault == null)
		{
			return;
		}
		valueOrDefault.TagExist = gameplayTagExist;
		if (valueOrDefault != null && valueOrDefault.TagExist && valueOrDefault.Active)
		{
			return;
		}
		if (valueOrDefault != null && !valueOrDefault.TagExist && !valueOrDefault.Active)
		{
			return;
		}
		if (!gameplayTagExist)
		{
			this.ActiveHandler(valueOrDefault, false);
			LimitTagHandler limitTagHandler = null;
			foreach (int key in valueOrDefault.MutuallyTags)
			{
				LimitTagHandler valueOrDefault2 = this.Handlers.GetValueOrDefault(key);
				if (valueOrDefault2 != null && valueOrDefault2.Priority <= valueOrDefault.Priority && valueOrDefault2.TagExist)
				{
					limitTagHandler = valueOrDefault2;
					break;
				}
			}
			if (limitTagHandler != null)
			{
				this.ActiveHandler(limitTagHandler, true);
			}
			return;
		}
		LimitTagHandler limitTagHandler2 = null;
		LimitTagHandler limitTagHandler3 = null;
		foreach (int key2 in valueOrDefault.MutuallyTags)
		{
			LimitTagHandler valueOrDefault3 = this.Handlers.GetValueOrDefault(key2);
			if (valueOrDefault3 != null)
			{
				if (valueOrDefault3.Priority > valueOrDefault.Priority && valueOrDefault3.Active)
				{
					limitTagHandler2 = valueOrDefault3;
					break;
				}
				if (valueOrDefault3.Priority <= valueOrDefault.Priority && valueOrDefault3.Active)
				{
					limitTagHandler3 = valueOrDefault3;
					break;
				}
			}
		}
		if (limitTagHandler2 != null)
		{
			return;
		}
		if (limitTagHandler3 != null)
		{
			this.ActiveHandler(limitTagHandler3, false);
			this.ActiveHandler(valueOrDefault, true);
			return;
		}
		this.ActiveHandler(valueOrDefault, true);
	}

	// Token: 0x060196F0 RID: 104176 RVA: 0x007C9864 File Offset: 0x007C7A64
	public void CreateTagHandler(int tagId, int priority, Action<bool> callBack)
	{
		bool tagExist = this.TagComp.HasTag(tagId);
		this.Handlers[tagId] = new LimitTagHandler(tagId, priority, tagExist, callBack);
		this.TagListeners.Add(this.TagComp.ListenForTagAddOrRemove(new int?(tagId), new BaseTagComponent.TTagSwitchedCallback(this.TagCallback), null));
	}

	// Token: 0x060196F1 RID: 104177 RVA: 0x007C98BC File Offset: 0x007C7ABC
	public void Clear()
	{
		this.CurrentActiveHandlers.Clear();
		this.Handlers.Clear();
		foreach (ITagTask tagTask in this.TagListeners)
		{
			tagTask.EndTask();
		}
		this.TagListeners.Clear();
	}

	// Token: 0x0400DEF1 RID: 57073
	[Nullable(2)]
	public BaseTagComponent TagComp;

	// Token: 0x0400DEF2 RID: 57074
	private readonly List<ITagTask> TagListeners = new List<ITagTask>();

	// Token: 0x0400DEF3 RID: 57075
	public List<LimitTagHandler> CurrentActiveHandlers = new List<LimitTagHandler>();

	// Token: 0x0400DEF4 RID: 57076
	public Dictionary<int, LimitTagHandler> Handlers = new Dictionary<int, LimitTagHandler>();
}
