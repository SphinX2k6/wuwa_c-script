using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003233 RID: 12851
[NullableContext(1)]
[Nullable(0)]
public class RoleForbidMovementHelper
{
	// Token: 0x0601BB67 RID: 113511 RVA: 0x007A0C64 File Offset: 0x0079EE64
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

	// Token: 0x0601BB68 RID: 113512 RVA: 0x007A0D0C File Offset: 0x0079EF0C
	public void Awake()
	{
		foreach (KeyValuePair<int, LimitTagHandler> keyValuePair in this.Handlers)
		{
			bool gameplayTagExist = this.TagComp.HasTag(keyValuePair.Key);
			this.TagCallback(keyValuePair.Key, gameplayTagExist);
		}
	}

	// Token: 0x0601BB69 RID: 113513 RVA: 0x007A0D7C File Offset: 0x0079EF7C
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

	// Token: 0x0601BB6A RID: 113514 RVA: 0x007A0DCC File Offset: 0x0079EFCC
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

	// Token: 0x0601BB6B RID: 113515 RVA: 0x007A0F58 File Offset: 0x0079F158
	public void CreateTagHandler(int tagId, int priority, Action<bool> callBack)
	{
		bool tagExist = this.TagComp.HasTag(tagId);
		this.Handlers[tagId] = new LimitTagHandler(tagId, priority, tagExist, callBack);
		this.TagListeners.Add(this.TagComp.ListenForTagAddOrRemove(new int?(tagId), new BaseTagComponent.TTagSwitchedCallback(this.TagCallback), null));
	}

	// Token: 0x0601BB6C RID: 113516 RVA: 0x007A0FB0 File Offset: 0x0079F1B0
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

	// Token: 0x0400DA52 RID: 55890
	[Nullable(2)]
	public BaseTagComponent TagComp;

	// Token: 0x0400DA53 RID: 55891
	private readonly List<ITagTask> TagListeners = new List<ITagTask>();

	// Token: 0x0400DA54 RID: 55892
	public List<LimitTagHandler> CurrentActiveHandlers = new List<LimitTagHandler>();

	// Token: 0x0400DA55 RID: 55893
	public Dictionary<int, LimitTagHandler> Handlers = new Dictionary<int, LimitTagHandler>();
}
