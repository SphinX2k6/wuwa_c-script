using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Monster.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020000EB RID: 235
[NullableContext(1)]
[Nullable(0)]
public class EntityVarEventPair : LevelVarEventPair
{
	// Token: 0x06000D84 RID: 3460 RVA: 0x0004A8E0 File Offset: 0x00048AE0
	public unsafe override bool Init(SAiLevelVar levelVar, UKuroBooleanEventBinder boolEventBinder)
	{
		base.Init(levelVar, boolEventBinder);
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(levelVar.Id);
		if (((entityByPbDataId != null) ? entityByPbDataId.Entity : null) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.CH;
			string message = "添加监听的变量来源实体未找到";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", levelVar.VarName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", levelVar.Id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		CreatureDataComponent component = entityByPbDataId.Entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "未找到对应实体的CreatureDataComponent";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Key", levelVar.VarName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", levelVar.Id);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return false;
		}
		VarDefinePb entityVar = component.GetEntityVar(levelVar.VarName);
		if (entityVar == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.AI;
			ELogAuthor author3 = ELogAuthor.CH;
			string message3 = "添加监听的变量未找到";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Key", levelVar.VarName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("EntityId", levelVar.Id);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return false;
		}
		base.ParseValue(entityVar, true);
		this.Entity = entityByPbDataId.Entity;
		EventSystem.Instance.AddWithTarget(this.Entity, EEventName.EntityVarUpdate, new Action<string, VarDefinePb>(this.OnReceiveEntityVar));
		this.IsInit = true;
		return true;
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x0004AAA0 File Offset: 0x00048CA0
	public unsafe override bool Init(SAiLevelVar levelVar, UKuroIntEventBinder intEventBinder)
	{
		base.Init(levelVar, intEventBinder);
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(levelVar.Id);
		if (((entityByPbDataId != null) ? entityByPbDataId.Entity : null) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.CH;
			string message = "添加监听的变量来源实体未找到";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Key", levelVar.VarName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", levelVar.Id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		CreatureDataComponent component = entityByPbDataId.Entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "未找到对应实体的CreatureDataComponent";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Key", levelVar.VarName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityId", levelVar.Id);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return false;
		}
		VarDefinePb entityVar = component.GetEntityVar(levelVar.VarName);
		if (entityVar == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.AI;
			ELogAuthor author3 = ELogAuthor.CH;
			string message3 = "添加监听的变量未找到";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Key", levelVar.VarName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("EntityId", levelVar.Id);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			return false;
		}
		base.ParseValue(entityVar, true);
		this.Entity = entityByPbDataId.Entity;
		EventSystem.Instance.AddWithTarget(this.Entity, EEventName.EntityVarUpdate, new Action<string, VarDefinePb>(this.OnReceiveEntityVar));
		this.IsInit = true;
		return true;
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x0004AC60 File Offset: 0x00048E60
	public override void Clear()
	{
		base.Clear();
		if (this.Entity != null && EventSystem.Instance.HasWithTarget(this.Entity, EEventName.EntityVarUpdate, new Action<string, VarDefinePb>(this.OnReceiveEntityVar)))
		{
			EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.EntityVarUpdate, new Action<string, VarDefinePb>(this.OnReceiveEntityVar));
		}
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x0004ACC0 File Offset: 0x00048EC0
	private void OnReceiveEntityVar(string name, VarDefinePb variable)
	{
		if (name != this.LevelVar.VarName)
		{
			return;
		}
		base.ParseValue(variable, false);
	}

	// Token: 0x04000AE7 RID: 2791
	[Nullable(2)]
	private Entity Entity;
}
