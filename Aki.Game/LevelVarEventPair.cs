using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Monster.Common;
using UnrealEngine;

// Token: 0x020000EA RID: 234
public class LevelVarEventPair
{
	// Token: 0x1700025D RID: 605
	// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0004A6BE File Offset: 0x000488BE
	// (set) Token: 0x06000D7D RID: 3453 RVA: 0x0004A65C File Offset: 0x0004885C
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

	// Token: 0x06000D7F RID: 3455 RVA: 0x0004A6C6 File Offset: 0x000488C6
	[NullableContext(1)]
	public virtual bool Init(SAiLevelVar levelVar, UKuroBooleanEventBinder boolEventBinder)
	{
		this.LevelVar = levelVar;
		this.BoolEventBinder = boolEventBinder;
		return true;
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x0004A6D7 File Offset: 0x000488D7
	[NullableContext(1)]
	public virtual bool Init(SAiLevelVar levelVar, UKuroIntEventBinder intEventBinder)
	{
		this.LevelVar = levelVar;
		this.IntEventBinder = intEventBinder;
		return true;
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x0004A6E8 File Offset: 0x000488E8
	public virtual void Clear()
	{
		this.LevelVar = null;
		this.BoolEventBinder = null;
		this.IntEventBinder = null;
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x0004A700 File Offset: 0x00048900
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

	// Token: 0x04000AE2 RID: 2786
	[Nullable(2)]
	public SAiLevelVar LevelVar;

	// Token: 0x04000AE3 RID: 2787
	[Nullable(2)]
	public UKuroBooleanEventBinder BoolEventBinder;

	// Token: 0x04000AE4 RID: 2788
	[Nullable(2)]
	public UKuroIntEventBinder IntEventBinder;

	// Token: 0x04000AE5 RID: 2789
	protected OneOf<bool, int> CurrentValueInternal;

	// Token: 0x04000AE6 RID: 2790
	protected bool IsInit;
}
