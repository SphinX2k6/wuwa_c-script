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
	// Token: 0x06000D89 RID: 3465 RVA: 0x0004ACE8 File Offset: 0x00048EE8
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

	// Token: 0x06000D8A RID: 3466 RVA: 0x0004AD90 File Offset: 0x00048F90
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

	// Token: 0x06000D8B RID: 3467 RVA: 0x0004AE38 File Offset: 0x00049038
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

	// Token: 0x06000D8C RID: 3468 RVA: 0x0004AEDC File Offset: 0x000490DC
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

	// Token: 0x06000D8D RID: 3469 RVA: 0x0004AFA8 File Offset: 0x000491A8
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

	// Token: 0x04000AE8 RID: 2792
	public long? TreeIncId;
}
