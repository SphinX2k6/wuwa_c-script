using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;

// Token: 0x02001D55 RID: 7509
[NullableContext(1)]
[Nullable(0)]
public class BehaviorTreeUpdateDelegateProxy
{
	// Token: 0x0600E416 RID: 58390 RVA: 0x0035956C File Offset: 0x0035776C
	public void Init()
	{
		this.Clear();
	}

	// Token: 0x0600E417 RID: 58391 RVA: 0x00359574 File Offset: 0x00357774
	public void Clear()
	{
		this.TempTreeVarDelegateMap.Clear();
		this.BehaviorTreeVarMap.Clear();
	}

	// Token: 0x0600E418 RID: 58392 RVA: 0x0035958C File Offset: 0x0035778C
	public void SetBehaviorTreeVarRelation(Dictionary<string, string> varType2VarNameMap)
	{
		this.BehaviorTreeVarMap.Clear();
		InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
		foreach (KeyValuePair<string, string> keyValuePair in varType2VarNameMap)
		{
			string text;
			string text2;
			keyValuePair.Deconstruct(out text, out text2);
			string key = text;
			string text3 = text2;
			this.BehaviorTreeVarMap[key] = text3;
			HashSet<TTreeVarUpdateDelegate> hashSet;
			if (this.TempTreeVarDelegateMap.TryGetValue(key, out hashSet) && instanceDungeonInfo != null && instanceDungeonInfo.Tree != null)
			{
				foreach (TTreeVarUpdateDelegate ttreeVarUpdateDelegate in hashSet)
				{
					instanceDungeonInfo.Tree.AddTreeVarUpdateDelegate(text3, ttreeVarUpdateDelegate);
					ttreeVarUpdateDelegate(null, instanceDungeonInfo.Tree.GetTreeVarByKey(text3));
				}
				this.TempTreeVarDelegateMap.Remove(key);
			}
		}
	}

	// Token: 0x0600E419 RID: 58393 RVA: 0x00359694 File Offset: 0x00357894
	[return: Nullable(2)]
	public VarDefinePb GetBehaviorTreeVar(string varType)
	{
		string key;
		if (!this.BehaviorTreeVarMap.TryGetValue(varType, out key))
		{
			return null;
		}
		InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
		if (instanceDungeonInfo == null)
		{
			return null;
		}
		BaseBehaviorTree tree = instanceDungeonInfo.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetTreeVarByKey(key);
	}

	// Token: 0x0600E41A RID: 58394 RVA: 0x003596D4 File Offset: 0x003578D4
	public long GetBehaviorTreeVarToNumber(string varType)
	{
		VarDefinePb behaviorTreeVar = this.GetBehaviorTreeVar(varType);
		if (behaviorTreeVar == null)
		{
			return 0L;
		}
		return behaviorTreeVar.Int;
	}

	// Token: 0x0600E41B RID: 58395 RVA: 0x003596EC File Offset: 0x003578EC
	public void AddTreeVarUpdateDelegate(string varType, TTreeVarUpdateDelegate @delegate)
	{
		InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
		if (instanceDungeonInfo == null || instanceDungeonInfo.Tree == null)
		{
			return;
		}
		string key;
		if (this.BehaviorTreeVarMap.TryGetValue(varType, out key))
		{
			instanceDungeonInfo.Tree.AddTreeVarUpdateDelegate(key, @delegate);
			return;
		}
		this.SaveTempTreeVarDelegate(varType, @delegate);
	}

	// Token: 0x0600E41C RID: 58396 RVA: 0x00359738 File Offset: 0x00357938
	public void RemoveTreeVarUpdateDelegate(string varType, TTreeVarUpdateDelegate @delegate)
	{
		InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
		if (instanceDungeonInfo == null || instanceDungeonInfo.Tree == null)
		{
			return;
		}
		string key;
		if (this.BehaviorTreeVarMap.TryGetValue(varType, out key))
		{
			instanceDungeonInfo.Tree.RemoveTreeVarUpdateDelegate(key, @delegate);
			return;
		}
		this.RemoveTempTreeVarDelegate(varType, @delegate);
	}

	// Token: 0x0600E41D RID: 58397 RVA: 0x00359784 File Offset: 0x00357984
	private void SaveTempTreeVarDelegate(string varType, TTreeVarUpdateDelegate @delegate)
	{
		HashSet<TTreeVarUpdateDelegate> hashSet;
		if (!this.TempTreeVarDelegateMap.TryGetValue(varType, out hashSet))
		{
			hashSet = (this.TempTreeVarDelegateMap[varType] = new HashSet<TTreeVarUpdateDelegate>());
		}
		hashSet.Add(@delegate);
	}

	// Token: 0x0600E41E RID: 58398 RVA: 0x003597BC File Offset: 0x003579BC
	private void RemoveTempTreeVarDelegate(string varType, TTreeVarUpdateDelegate @delegate)
	{
		HashSet<TTreeVarUpdateDelegate> hashSet;
		if (this.TempTreeVarDelegateMap.TryGetValue(varType, out hashSet))
		{
			hashSet.Remove(@delegate);
		}
	}

	// Token: 0x04006929 RID: 26921
	private readonly Dictionary<string, string> BehaviorTreeVarMap = new Dictionary<string, string>();

	// Token: 0x0400692A RID: 26922
	private readonly Dictionary<string, HashSet<TTreeVarUpdateDelegate>> TempTreeVarDelegateMap = new Dictionary<string, HashSet<TTreeVarUpdateDelegate>>();
}
