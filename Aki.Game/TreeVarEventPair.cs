using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Monster.Common;
using CSharpScript.Game.Module.InstanceDungeon;
using UnrealEngine;

// Token: 0x020000EC RID: 236
[NullableContext(1)]
[Nullable(0)]
public class TreeVarEventPair : LevelVarEventPair
{
	// Token: 0x06000D8F RID: 3471 RVA: 0x0004B884 File Offset: 0x00049A84
	public unsafe override bool Init(SAiLevelVar levelVar, UKuroBooleanEventBinder boolEventBinder)
	{
		base.Init(levelVar, boolEventBinder);
		EAiLevelVarSource eaiLevelVarSource = levelVar.VarSource;
		if (eaiLevelVarSource != EAiLevelVarSource.Quest)
		{
			if (eaiLevelVarSource != EAiLevelVarSource.LevelPlay)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AI;
				ELogAuthor author = ELogAuthor.CH;
				string message = "添加监听的变量来源非树";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", levelVar.VarName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Source", eaiLevelVarSource);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (!this.ParseLevelPlayerValue(true))
			{
				return false;
			}
		}
		else if (!this.ParseQuestTreeValue(true))
		{
			return false;
		}
		this.IsInit = true;
		return true;
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x0004B92C File Offset: 0x00049B2C
	public unsafe override bool Init(SAiLevelVar levelVar, UKuroIntEventBinder intEventBinder)
	{
		base.Init(levelVar, intEventBinder);
		EAiLevelVarSource eaiLevelVarSource = levelVar.VarSource;
		if (eaiLevelVarSource != EAiLevelVarSource.Quest)
		{
			if (eaiLevelVarSource != EAiLevelVarSource.LevelPlay)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AI;
				ELogAuthor author = ELogAuthor.CH;
				string message = "添加监听的变量来源非树";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", levelVar.VarName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Source", eaiLevelVarSource);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (!this.ParseLevelPlayerValue(true))
			{
				return false;
			}
		}
		else if (!this.ParseQuestTreeValue(true))
		{
			return false;
		}
		this.IsInit = true;
		return true;
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x0004B9D4 File Offset: 0x00049BD4
	public unsafe void OnReceiveTreeVar()
	{
		if (!this.IsInit)
		{
			return;
		}
		EAiLevelVarSource eaiLevelVarSource = this.LevelVar.VarSource;
		if (eaiLevelVarSource == EAiLevelVarSource.Quest)
		{
			this.ParseQuestTreeValue(false);
			return;
		}
		if (eaiLevelVarSource == EAiLevelVarSource.LevelPlay)
		{
			this.ParseLevelPlayerValue(false);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.AI;
		ELogAuthor author = ELogAuthor.CH;
		string message = "添加监听的变量来源非树";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", this.LevelVar.VarName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Source", eaiLevelVarSource);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x0004BA78 File Offset: 0x00049C78
	private unsafe bool ParseQuestTreeValue(bool isInit = true)
	{
		Quest quest = QuestNewModel.Instance.GetQuest(this.LevelVar.Id);
		BaseBehaviorTree baseBehaviorTree = (quest != null) ? quest.Tree : null;
		if (baseBehaviorTree == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.CH;
			string message = "添加监听的变量来源树未找到";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", this.LevelVar.VarName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("QuestId", this.LevelVar.Id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		VarDefinePb treeVarByKey = baseBehaviorTree.GetTreeVarByKey(this.LevelVar.VarName);
		this.TreeIncId = new long?(baseBehaviorTree.TreeIncId);
		return base.ParseValue(treeVarByKey, isInit);
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x0004BB44 File Offset: 0x00049D44
	private unsafe bool ParseLevelPlayerValue(bool isInit = true)
	{
		int id = this.LevelVar.Id;
		global::LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo(id);
		BaseBehaviorTree baseBehaviorTree = (levelPlayInfo != null) ? levelPlayInfo.Tree : null;
		if (baseBehaviorTree == null)
		{
			InstanceDungeonInfo instanceDungeonInfo = InstanceDungeonModel.Instance.GetInstanceDungeonInfo();
			if (instanceDungeonInfo != null)
			{
				int? treeConfigId = instanceDungeonInfo.TreeConfigId;
				int num = id;
				if (treeConfigId.GetValueOrDefault() == num & treeConfigId != null)
				{
					baseBehaviorTree = instanceDungeonInfo.Tree;
				}
			}
		}
		if (baseBehaviorTree == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.CH;
			string message = "添加监听的变量来源树未找到";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", this.LevelVar.VarName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("QuestId", this.LevelVar.Id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		VarDefinePb treeVarByKey = baseBehaviorTree.GetTreeVarByKey(this.LevelVar.VarName);
		this.TreeIncId = new long?(baseBehaviorTree.TreeIncId);
		return base.ParseValue(treeVarByKey, isInit);
	}

	// Token: 0x04000AF0 RID: 2800
	public long? TreeIncId;
}
