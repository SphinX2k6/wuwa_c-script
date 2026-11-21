using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;

// Token: 0x02001217 RID: 4631
[NullableContext(1)]
[Nullable(0)]
public class BehaviorTreeUpdateDelegateProxy
{
	// Token: 0x0600B833 RID: 47155 RVA: 0x00365040 File Offset: 0x00363240
	public void Init()
	{
		this.Clear();
	}

	// Token: 0x0600B834 RID: 47156 RVA: 0x00365048 File Offset: 0x00363248
	public void Clear()
	{
		this.TempTreeVarDelegateMap.Clear();
		this.BehaviorTreeVarMap.Clear();
	}

	// Token: 0x0600B835 RID: 47157 RVA: 0x00365060 File Offset: 0x00363260
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

	// Token: 0x0600B836 RID: 47158 RVA: 0x00365168 File Offset: 0x00363368
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

	// Token: 0x0600B837 RID: 47159 RVA: 0x003651A8 File Offset: 0x003633A8
	public long GetBehaviorTreeVarToNumber(string varType)
	{
		VarDefinePb behaviorTreeVar = this.GetBehaviorTreeVar(varType);
		if (behaviorTreeVar == null)
		{
			return 0L;
		}
		return behaviorTreeVar.Int;
	}

	// Token: 0x0600B838 RID: 47160 RVA: 0x003651C0 File Offset: 0x003633C0
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

	// Token: 0x0600B839 RID: 47161 RVA: 0x0036520C File Offset: 0x0036340C
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

	// Token: 0x0600B83A RID: 47162 RVA: 0x00365258 File Offset: 0x00363458
	private void SaveTempTreeVarDelegate(string varType, TTreeVarUpdateDelegate @delegate)
	{
		HashSet<TTreeVarUpdateDelegate> hashSet;
		if (!this.TempTreeVarDelegateMap.TryGetValue(varType, out hashSet))
		{
			hashSet = (this.TempTreeVarDelegateMap[varType] = new HashSet<TTreeVarUpdateDelegate>());
		}
		hashSet.Add(@delegate);
	}

	// Token: 0x0600B83B RID: 47163 RVA: 0x00365290 File Offset: 0x00363490
	private void RemoveTempTreeVarDelegate(string varType, TTreeVarUpdateDelegate @delegate)
	{
		HashSet<TTreeVarUpdateDelegate> hashSet;
		if (this.TempTreeVarDelegateMap.TryGetValue(varType, out hashSet))
		{
			hashSet.Remove(@delegate);
		}
	}

	// Token: 0x04006A09 RID: 27145
	private readonly Dictionary<string, string> BehaviorTreeVarMap = new Dictionary<string, string>();

	// Token: 0x04006A0A RID: 27146
	private readonly Dictionary<string, HashSet<TTreeVarUpdateDelegate>> TempTreeVarDelegateMap = new Dictionary<string, HashSet<TTreeVarUpdateDelegate>>();
}
