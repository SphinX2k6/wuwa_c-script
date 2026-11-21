using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Aki.TDConfigMgr.Quest;
using UnrealEngine;

// Token: 0x02001252 RID: 4690
[NullableContext(1)]
[Nullable(0)]
public class GeneralLogicTreeConfigUtil : Singleton
{
	// Token: 0x0600B97F RID: 47487 RVA: 0x0036C344 File Offset: 0x0036A544
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

	// Token: 0x0600B980 RID: 47488 RVA: 0x0036C3C0 File Offset: 0x0036A5C0
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

	// Token: 0x0600B981 RID: 47489 RVA: 0x0036C518 File Offset: 0x0036A718
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

	// Token: 0x0600B982 RID: 47490 RVA: 0x0036C550 File Offset: 0x0036A750
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

	// Token: 0x0600B983 RID: 47491 RVA: 0x0036C5F0 File Offset: 0x0036A7F0
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

	// Token: 0x1700127E RID: 4734
	// (get) Token: 0x0600B984 RID: 47492 RVA: 0x0036C653 File Offset: 0x0036A853
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

	// Token: 0x0600B985 RID: 47493 RVA: 0x0036C676 File Offset: 0x0036A876
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B986 RID: 47494 RVA: 0x0036C678 File Offset: 0x0036A878
	public static void ResetStaticDefaultValue()
	{
		GeneralLogicTreeConfigUtil instance = GeneralLogicTreeConfigUtil._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		GeneralLogicTreeConfigUtil._instance = null;
	}

	// Token: 0x0600B987 RID: 47495 RVA: 0x0036C694 File Offset: 0x0036A894
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

	// Token: 0x04006B25 RID: 27429
	[StaticVariableRuleIgnore]
	private static readonly IReadOnlyDictionary<EBtNode, bool> configNodesFilter;

	// Token: 0x04006B26 RID: 27430
	[Nullable(2)]
	private static GeneralLogicTreeConfigUtil _instance;
}
