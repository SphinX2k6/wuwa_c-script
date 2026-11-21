using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Monster.Common;
using UnrealEngine;

// Token: 0x020000EA RID: 234
public class LevelVarEventPair
{
	// Token: 0x17000260 RID: 608
	// (get) Token: 0x06000D84 RID: 3460 RVA: 0x0004B25A File Offset: 0x0004945A
	// (set) Token: 0x06000D83 RID: 3459 RVA: 0x0004B1F8 File Offset: 0x000493F8
	protected OneOf<bool, int> CurrentValue
	{
		get
		{
			return this.CurrentValueInternal;
		}
		set
		{
			if (this.CurrentValueInternal.Equals(value))
			{
				return;
			}
			this.CurrentValueInternal = value;
			if (this.BoolEventBinder != null)
			{
				this.BoolEventBinder.Callback.Broadcast(value.AsT1);
				return;
			}
			if (this.IntEventBinder != null)
			{
				this.IntEventBinder.Callback.Broadcast(value.AsT2);
			}
		}
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x0004B262 File Offset: 0x00049462
	[NullableContext(1)]
	public virtual bool Init(SAiLevelVar levelVar, UKuroBooleanEventBinder boolEventBinder)
	{
		this.LevelVar = levelVar;
		this.BoolEventBinder = boolEventBinder;
		return true;
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x0004B273 File Offset: 0x00049473
	[NullableContext(1)]
	public virtual bool Init(SAiLevelVar levelVar, UKuroIntEventBinder intEventBinder)
	{
		this.LevelVar = levelVar;
		this.IntEventBinder = intEventBinder;
		return true;
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x0004B284 File Offset: 0x00049484
	public virtual void Clear()
	{
		this.LevelVar = null;
		this.BoolEventBinder = null;
		this.IntEventBinder = null;
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x0004B29C File Offset: 0x0004949C
	[NullableContext(2)]
	protected unsafe bool ParseValue(VarDefinePb treeValue, bool isInit = true)
	{
		if (treeValue == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.CH;
			string message = "添加监听的变量未找到";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", this.LevelVar.VarName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("QuestId", this.LevelVar.Id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (this.BoolEventBinder != null)
		{
			if (!treeValue.HasBoolean)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.AI;
				ELogAuthor author2 = ELogAuthor.CH;
				string message2 = "添加监听的变量类型不正确";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Key", this.LevelVar.VarName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("QuestId", this.LevelVar.Id);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			bool value = Convert.ToBoolean(treeValue.Boolean);
			if (isInit)
			{
				this.CurrentValueInternal = value;
			}
			else
			{
				this.CurrentValue = new OneOf<bool, int>(value);
			}
			return true;
		}
		else
		{
			if (this.IntEventBinder == null)
			{
				return false;
			}
			if (!treeValue.HasInt)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.AI;
				ELogAuthor author3 = ELogAuthor.CH;
				string message3 = "添加监听的变量类型不正确";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Key", this.LevelVar.VarName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("QuestId", this.LevelVar.Id);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				return false;
			}
			long @int = treeValue.Int;
			if (isInit)
			{
				this.CurrentValueInternal = (int)@int;
			}
			else
			{
				this.CurrentValue = new OneOf<bool, int>((int)@int);
			}
			return true;
		}
	}

	// Token: 0x04000AEA RID: 2794
	[Nullable(2)]
	public SAiLevelVar LevelVar;

	// Token: 0x04000AEB RID: 2795
	[Nullable(2)]
	public UKuroBooleanEventBinder BoolEventBinder;

	// Token: 0x04000AEC RID: 2796
	[Nullable(2)]
	public UKuroIntEventBinder IntEventBinder;

	// Token: 0x04000AED RID: 2797
	protected OneOf<bool, int> CurrentValueInternal;

	// Token: 0x04000AEE RID: 2798
	protected bool IsInit;
}
