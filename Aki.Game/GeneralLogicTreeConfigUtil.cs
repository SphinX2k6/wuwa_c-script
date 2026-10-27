using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Aki.TDConfigMgr.Quest;
using UnrealEngine;

// Token: 0x02001D90 RID: 7568
[NullableContext(1)]
[Nullable(0)]
public class GeneralLogicTreeConfigUtil : Singleton
{
	// Token: 0x0600E561 RID: 58721 RVA: 0x003606F0 File Offset: 0x0035E8F0
	public void InitConfig(string dir, Action<string> singleFileLoaded)
	{
		foreach (string text in UKuroStaticLibrary.GetFilesRecursive(dir, "*.json", true, false))
		{
			if (UBlueprintPathsLibrary.FileExists(text))
			{
				string text2 = "";
				UKuroStaticLibrary.LoadFileToString(ref text2, text);
				if (!string.IsNullOrEmpty(text2))
				{
					singleFileLoaded(text2);
				}
			}
		}
	}

	// Token: 0x0600E562 RID: 58722 RVA: 0x00360764 File Offset: 0x0035E964
	public void BuildConfigIdIndex(string dir, string arrayPropertyName, Dictionary<int, string> idToFilePath)
	{
		foreach (string text in UKuroStaticLibrary.GetFilesRecursive(dir, "*.json", true, false))
		{
			if (UBlueprintPathsLibrary.FileExists(text))
			{
				string text2 = "";
				UKuroStaticLibrary.LoadFileToString(ref text2, text);
				if (!string.IsNullOrEmpty(text2))
				{
					try
					{
						using (JsonDocument jsonDocument = JsonDocument.Parse(text2, default(JsonDocumentOptions)))
						{
							JsonElement jsonElement;
							if (jsonDocument.RootElement.TryGetProperty(arrayPropertyName, out jsonElement))
							{
								foreach (JsonElement jsonElement2 in jsonElement.EnumerateArray())
								{
									JsonElement jsonElement3;
									int key;
									if (jsonElement2.TryGetProperty("Id", out jsonElement3) && jsonElement3.TryGetInt32(out key))
									{
										idToFilePath[key] = text;
									}
								}
							}
						}
					}
					catch (Exception error)
					{
						Log.Instance.ErrorWithStack(ELogModule.Level, ELogAuthor.YSQ, "[GeneralLogicTreeConfigUtil.BuildConfigIdIndex] 解析配置文件失败", error, default(ReadOnlySpan<ValueTuple<string, object>>));
					}
				}
			}
		}
	}

	// Token: 0x0600E563 RID: 58723 RVA: 0x003608B8 File Offset: 0x0035EAB8
	public bool LoadSingleFile(string filePath, Action<string> singleFileLoaded)
	{
		if (!UBlueprintPathsLibrary.FileExists(filePath))
		{
			return false;
		}
		string text = "";
		UKuroStaticLibrary.LoadFileToString(ref text, filePath);
		if (string.IsNullOrEmpty(text))
		{
			return false;
		}
		singleFileLoaded(text);
		return true;
	}

	// Token: 0x0600E564 RID: 58724 RVA: 0x003608F0 File Offset: 0x0035EAF0
	public void InitBehaviorNodeConfig(Dictionary<int, Dictionary<int, IBtNode>> nodeConfig, int questId, IBehaviorTree tree)
	{
		Dictionary<int, IBtNode> dictionary;
		if (!nodeConfig.TryGetValue(questId, out dictionary))
		{
			dictionary = (nodeConfig[questId] = new Dictionary<int, IBtNode>());
		}
		Dictionary<int, IBtNode> dictionary2 = Aki.TDConfigMgr.Quest.Quest.FlatBehaviorTree(tree);
		dictionary.Clear();
		foreach (KeyValuePair<int, IBtNode> keyValuePair in dictionary2)
		{
			int num;
			IBtNode btNode;
			keyValuePair.Deconstruct(out num, out btNode);
			int key = num;
			IBtNode btNode2 = btNode;
			bool flag;
			if (GeneralLogicTreeConfigUtil.configNodesFilter.TryGetValue(btNode2.Type, out flag) && flag)
			{
				dictionary[key] = btNode2;
			}
		}
	}

	// Token: 0x0600E565 RID: 58725 RVA: 0x00360990 File Offset: 0x0035EB90
	public bool IsAlwaysFalseChildNode(long treeIncId, int? parentNodeId)
	{
		if (parentNodeId == null || parentNodeId.Value == 0)
		{
			return false;
		}
		BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
		if (behaviorTree == null)
		{
			return false;
		}
		IBtNode nodeConfig = behaviorTree.GetNodeConfig(parentNodeId.Value);
		return nodeConfig != null && (nodeConfig.Type == EBtNode.AlwaysFalse || this.IsAlwaysFalseChildNode(treeIncId, nodeConfig.ParentNodeId));
	}

	// Token: 0x17001254 RID: 4692
	// (get) Token: 0x0600E566 RID: 58726 RVA: 0x003609F3 File Offset: 0x0035EBF3
	public static GeneralLogicTreeConfigUtil Instance
	{
		get
		{
			if (GeneralLogicTreeConfigUtil._instance == null)
			{
				GeneralLogicTreeConfigUtil._instance = new GeneralLogicTreeConfigUtil();
				GeneralLogicTreeConfigUtil._instance.OnInit();
			}
			return GeneralLogicTreeConfigUtil._instance;
		}
	}

	// Token: 0x0600E567 RID: 58727 RVA: 0x00360A16 File Offset: 0x0035EC16
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E568 RID: 58728 RVA: 0x00360A18 File Offset: 0x0035EC18
	public static void ResetStaticDefaultValue()
	{
		GeneralLogicTreeConfigUtil instance = GeneralLogicTreeConfigUtil._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		GeneralLogicTreeConfigUtil._instance = null;
	}

	// Token: 0x0600E569 RID: 58729 RVA: 0x00360A34 File Offset: 0x0035EC34
	static GeneralLogicTreeConfigUtil()
	{
		Dictionary<EBtNode, bool> dictionary = new Dictionary<EBtNode, bool>();
		dictionary[EBtNode.Action] = true;
		dictionary[EBtNode.ActionWithResult] = true;
		dictionary[EBtNode.ChildQuest] = true;
		dictionary[EBtNode.QuestFailed] = true;
		dictionary[EBtNode.ParallelSelect] = true;
		dictionary[EBtNode.Start] = false;
		dictionary[EBtNode.QuestSucceed] = true;
		dictionary[EBtNode.AlwaysTrue] = true;
		dictionary[EBtNode.AlwaysFalse] = true;
		dictionary[EBtNode.Sequence] = true;
		dictionary[EBtNode.Select] = true;
		dictionary[EBtNode.Condition] = true;
		dictionary[EBtNode.ConditionSelector] = true;
		dictionary[EBtNode.Repeater] = true;
		GeneralLogicTreeConfigUtil.configNodesFilter = dictionary;
		StaticVariableRegister.RegisterAndExecute(new Action(GeneralLogicTreeConfigUtil.CreateStaticDefaultValue), new Action(GeneralLogicTreeConfigUtil.ResetStaticDefaultValue));
	}

	// Token: 0x04006A44 RID: 27204
	[StaticVariableRuleIgnore]
	private static readonly IReadOnlyDictionary<EBtNode, bool> configNodesFilter;

	// Token: 0x04006A45 RID: 27205
	[Nullable(2)]
	private static GeneralLogicTreeConfigUtil _instance;
}
