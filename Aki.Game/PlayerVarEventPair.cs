using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Monster.Common;
using UnrealEngine;

// Token: 0x020000ED RID: 237
[NullableContext(1)]
[Nullable(0)]
public class PlayerVarEventPair : LevelVarEventPair
{
	// Token: 0x06000D95 RID: 3477 RVA: 0x0004BC58 File Offset: 0x00049E58
	public unsafe override bool Init(SAiLevelVar levelVar, UKuroBooleanEventBinder boolEventBinder)
	{
		base.Init(levelVar, boolEventBinder);
		OneOf<bool, string, double> worldState = WorldModel.Instance.GetWorldState(levelVar.VarName);
		if (!worldState.HasValue || worldState.IsT2)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.CH;
			string message = "添加监听的玩家变量类型不正确或未找到";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", levelVar.VarName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Value", worldState);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (worldState.IsT1)
		{
			base.CurrentValue = new OneOf<bool, int>(worldState.AsT1);
		}
		else if (worldState.IsT3)
		{
			base.CurrentValue = new OneOf<bool, int>((int)worldState.AsT3);
		}
		this.IsInit = true;
		return true;
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x0004BD34 File Offset: 0x00049F34
	public unsafe override bool Init(SAiLevelVar levelVar, UKuroIntEventBinder intEventBinder)
	{
		base.Init(levelVar, intEventBinder);
		OneOf<bool, string, double> worldState = WorldModel.Instance.GetWorldState(levelVar.VarName);
		if (!worldState.HasValue || worldState.IsT2)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.CH;
			string message = "添加监听的玩家变量类型不正确或未找到";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", levelVar.VarName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Value", worldState);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (worldState.IsT1)
		{
			base.CurrentValue = new OneOf<bool, int>(worldState.AsT1);
		}
		else if (worldState.IsT3)
		{
			base.CurrentValue = new OneOf<bool, int>((int)worldState.AsT3);
		}
		this.IsInit = true;
		return true;
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x0004BE10 File Offset: 0x0004A010
	public void OnReceivePlayerVar()
	{
		if (!this.IsInit)
		{
			return;
		}
		OneOf<bool, string, double> worldState = WorldModel.Instance.GetWorldState(this.LevelVar.VarName);
		if (worldState.HasValue)
		{
			if (worldState.IsT3)
			{
				base.CurrentValue = new OneOf<bool, int>((int)worldState.AsT3);
				return;
			}
			if (worldState.IsT1)
			{
				base.CurrentValue = new OneOf<bool, int>(worldState.AsT1);
			}
		}
	}
}
