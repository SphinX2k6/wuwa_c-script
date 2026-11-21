using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Monster.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020000EE RID: 238
[NullableContext(1)]
[Nullable(0)]
public class AiLevelVarEvent
{
	// Token: 0x06000D99 RID: 3481 RVA: 0x0004BE88 File Offset: 0x0004A088
	public void AddLevelVarEvent(SAiLevelVar levelVar, UKuroBooleanEventBinder boolEventBinder)
	{
		switch (levelVar.VarSource)
		{
		case EAiLevelVarSource.Global:
		{
			PlayerVarEventPair playerVarEventPair = new PlayerVarEventPair();
			if (playerVarEventPair.Init(levelVar, boolEventBinder))
			{
				this.PlayerVarEventPairs.Add(playerVarEventPair);
			}
			break;
		}
		case EAiLevelVarSource.SelfEntity:
		case EAiLevelVarSource.OtherEntity:
		{
			EntityVarEventPair entityVarEventPair = new EntityVarEventPair();
			if (entityVarEventPair.Init(levelVar, boolEventBinder))
			{
				this.EntityVarEventPairs.Add(entityVarEventPair);
			}
			break;
		}
		case EAiLevelVarSource.Quest:
		case EAiLevelVarSource.LevelPlay:
		{
			TreeVarEventPair treeVarEventPair = new TreeVarEventPair();
			if (treeVarEventPair.Init(levelVar, boolEventBinder))
			{
				this.TreeVarEventPairs.Add(treeVarEventPair);
			}
			break;
		}
		}
		if (this.TreeVarEventPairs.Count > 0 && !EventSystem.Instance.Has(EEventName.GeneralLogicTreeViewForceRefresh, new Action<long>(this.OnReceiveTreeVar)))
		{
			EventSystem.Instance.Add(EEventName.GeneralLogicTreeViewForceRefresh, new Action<long>(this.OnReceiveTreeVar));
		}
		if (this.TreeVarEventPairs.Count > 0 && !EventSystem.Instance.Has(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar)))
		{
			EventSystem.Instance.Add<IReadOnlyDictionary<string, VarDefinePb>>(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar));
		}
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x0004BFA4 File Offset: 0x0004A1A4
	public void AddLevelVarEvent(SAiLevelVar levelVar, UKuroIntEventBinder intEventBinder)
	{
		switch (levelVar.VarSource)
		{
		case EAiLevelVarSource.Global:
		{
			PlayerVarEventPair playerVarEventPair = new PlayerVarEventPair();
			if (playerVarEventPair.Init(levelVar, intEventBinder))
			{
				this.PlayerVarEventPairs.Add(playerVarEventPair);
			}
			break;
		}
		case EAiLevelVarSource.SelfEntity:
		case EAiLevelVarSource.OtherEntity:
		{
			EntityVarEventPair entityVarEventPair = new EntityVarEventPair();
			if (entityVarEventPair.Init(levelVar, intEventBinder))
			{
				this.EntityVarEventPairs.Add(entityVarEventPair);
			}
			break;
		}
		case EAiLevelVarSource.Quest:
		case EAiLevelVarSource.LevelPlay:
		{
			TreeVarEventPair treeVarEventPair = new TreeVarEventPair();
			if (treeVarEventPair.Init(levelVar, intEventBinder))
			{
				this.TreeVarEventPairs.Add(treeVarEventPair);
			}
			break;
		}
		}
		if (this.TreeVarEventPairs.Count > 0 && !EventSystem.Instance.Has(EEventName.GeneralLogicTreeViewForceRefresh, new Action<long>(this.OnReceiveTreeVar)))
		{
			EventSystem.Instance.Add(EEventName.GeneralLogicTreeViewForceRefresh, new Action<long>(this.OnReceiveTreeVar));
		}
		if (this.TreeVarEventPairs.Count > 0 && !EventSystem.Instance.Has(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar)))
		{
			EventSystem.Instance.Add<IReadOnlyDictionary<string, VarDefinePb>>(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar));
		}
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x0004C0C0 File Offset: 0x0004A2C0
	public bool RemoveLevelVarEvent(UKuroBooleanEventBinder boolEventBinder)
	{
		int num = 0;
		foreach (EntityVarEventPair entityVarEventPair in this.EntityVarEventPairs)
		{
			if (entityVarEventPair.BoolEventBinder == boolEventBinder)
			{
				entityVarEventPair.Clear();
				break;
			}
			num++;
		}
		if (num < this.EntityVarEventPairs.Count)
		{
			this.EntityVarEventPairs.RemoveRange(num, this.EntityVarEventPairs.Count - num);
			return true;
		}
		num = 0;
		foreach (TreeVarEventPair treeVarEventPair in this.TreeVarEventPairs)
		{
			if (treeVarEventPair.BoolEventBinder == boolEventBinder)
			{
				treeVarEventPair.Clear();
				break;
			}
			num++;
		}
		if (num < this.TreeVarEventPairs.Count)
		{
			this.TreeVarEventPairs.RemoveRange(num, this.TreeVarEventPairs.Count - num);
			if (this.TreeVarEventPairs.Count == 0 && EventSystem.Instance.Has(EEventName.GeneralLogicTreeViewForceRefresh, new Action<long>(this.OnReceiveTreeVar)))
			{
				EventSystem.Instance.Remove(EEventName.GeneralLogicTreeViewForceRefresh, new Action<long>(this.OnReceiveTreeVar));
			}
			return true;
		}
		num = 0;
		foreach (PlayerVarEventPair playerVarEventPair in this.PlayerVarEventPairs)
		{
			if (playerVarEventPair.BoolEventBinder == boolEventBinder)
			{
				playerVarEventPair.Clear();
				break;
			}
			num++;
		}
		if (num < this.PlayerVarEventPairs.Count)
		{
			this.PlayerVarEventPairs.RemoveRange(num, this.PlayerVarEventPairs.Count - num);
			if (this.PlayerVarEventPairs.Count == 0 && EventSystem.Instance.Has(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar)))
			{
				EventSystem.Instance.Remove(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar));
			}
			return true;
		}
		return false;
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x0004C2D8 File Offset: 0x0004A4D8
	public bool RemoveLevelVarEvent(UKuroIntEventBinder intEventBinder)
	{
		int num = 0;
		foreach (EntityVarEventPair entityVarEventPair in this.EntityVarEventPairs)
		{
			if (entityVarEventPair.IntEventBinder == intEventBinder)
			{
				entityVarEventPair.Clear();
				break;
			}
			num++;
		}
		if (num < this.EntityVarEventPairs.Count)
		{
			this.EntityVarEventPairs.RemoveRange(num, this.EntityVarEventPairs.Count - num);
			return true;
		}
		num = 0;
		foreach (TreeVarEventPair treeVarEventPair in this.TreeVarEventPairs)
		{
			if (treeVarEventPair.IntEventBinder == intEventBinder)
			{
				treeVarEventPair.Clear();
				break;
			}
			num++;
		}
		if (num < this.TreeVarEventPairs.Count)
		{
			this.TreeVarEventPairs.RemoveRange(num, this.TreeVarEventPairs.Count - num);
			if (this.TreeVarEventPairs.Count == 0 && EventSystem.Instance.Has(EEventName.GeneralLogicTreeViewForceRefresh, new Action<long>(this.OnReceiveTreeVar)))
			{
				EventSystem.Instance.Remove(EEventName.GeneralLogicTreeViewForceRefresh, new Action<long>(this.OnReceiveTreeVar));
			}
			return true;
		}
		num = 0;
		foreach (PlayerVarEventPair playerVarEventPair in this.PlayerVarEventPairs)
		{
			if (playerVarEventPair.IntEventBinder == intEventBinder)
			{
				playerVarEventPair.Clear();
				break;
			}
			num++;
		}
		if (num < this.PlayerVarEventPairs.Count)
		{
			this.PlayerVarEventPairs.RemoveRange(num, this.PlayerVarEventPairs.Count - num);
			if (this.PlayerVarEventPairs.Count == 0 && EventSystem.Instance.Has(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar)))
			{
				EventSystem.Instance.Remove(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar));
			}
			return true;
		}
		return false;
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x0004C4F0 File Offset: 0x0004A6F0
	private void OnReceiveTreeVar(long treeId)
	{
		foreach (TreeVarEventPair treeVarEventPair in this.TreeVarEventPairs)
		{
			long? treeIncId = treeVarEventPair.TreeIncId;
			if (treeIncId.GetValueOrDefault() == treeId & treeIncId != null)
			{
				treeVarEventPair.OnReceiveTreeVar();
			}
		}
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x0004C560 File Offset: 0x0004A760
	private void OnReceivePlayerVar(IReadOnlyDictionary<string, VarDefinePb> varInfos)
	{
		foreach (PlayerVarEventPair playerVarEventPair in this.PlayerVarEventPairs)
		{
			playerVarEventPair.OnReceivePlayerVar();
		}
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x0004C5B0 File Offset: 0x0004A7B0
	public void Clear()
	{
		foreach (EntityVarEventPair entityVarEventPair in this.EntityVarEventPairs)
		{
			entityVarEventPair.Clear();
		}
		this.EntityVarEventPairs.Clear();
		foreach (TreeVarEventPair treeVarEventPair in this.TreeVarEventPairs)
		{
			treeVarEventPair.Clear();
		}
		this.TreeVarEventPairs.Clear();
		foreach (PlayerVarEventPair playerVarEventPair in this.PlayerVarEventPairs)
		{
			playerVarEventPair.Clear();
		}
		this.PlayerVarEventPairs.Clear();
		if (EventSystem.Instance.Has(EEventName.GeneralLogicTreeViewForceRefresh, new Action<long>(this.OnReceiveTreeVar)))
		{
			EventSystem.Instance.Remove(EEventName.GeneralLogicTreeViewForceRefresh, new Action<long>(this.OnReceiveTreeVar));
		}
		if (EventSystem.Instance.Has(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar)))
		{
			EventSystem.Instance.Remove(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar));
		}
	}

	// Token: 0x04000AF1 RID: 2801
	private readonly List<EntityVarEventPair> EntityVarEventPairs = new List<EntityVarEventPair>();

	// Token: 0x04000AF2 RID: 2802
	private readonly List<TreeVarEventPair> TreeVarEventPairs = new List<TreeVarEventPair>();

	// Token: 0x04000AF3 RID: 2803
	private readonly List<PlayerVarEventPair> PlayerVarEventPairs = new List<PlayerVarEventPair>();
}
