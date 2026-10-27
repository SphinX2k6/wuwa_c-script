using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020031BB RID: 12731
[NullableContext(1)]
[Nullable(0)]
public class EntityHandle
{
	// Token: 0x0601B71C RID: 112412 RVA: 0x00782462 File Offset: 0x00780662
	public EntityHandle(WorldEntity Entity)
	{
		this.Entity = Entity;
		this.Id = Entity.Id;
		this.Index = Entity.Index;
	}

	// Token: 0x0601B71D RID: 112413 RVA: 0x0078249C File Offset: 0x0078069C
	public unsafe bool AddHoldEntity(string reason)
	{
		int num;
		if (!this.HoldEntityMap.TryGetValue(reason, out num))
		{
			num = 1;
		}
		else
		{
			num++;
		}
		if (CreatureController.Instance.CheckEnableEntityLog(new OneOf<EEntityType, EntityHandle>?((EEntityType)this.EntityType)))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Engine;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "AddHoldEntity";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Count", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		this.HoldEntityMap[reason] = num;
		return true;
	}

	// Token: 0x0601B71E RID: 112414 RVA: 0x00782588 File Offset: 0x00780788
	public unsafe bool RemoveHoldEntity(string reason)
	{
		int num;
		if (!this.HoldEntityMap.TryGetValue(reason, out num))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Engine;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "reason不存在，RemoveHoldEntity失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", this.Id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		num--;
		if (num <= 0)
		{
			this.HoldEntityMap.Remove(reason);
		}
		else
		{
			this.HoldEntityMap[reason] = num;
		}
		if (CreatureController.Instance.CheckEnableEntityLog(new OneOf<EEntityType, EntityHandle>?((EEntityType)this.EntityType)))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Engine;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "RemoveHoldEntity";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("EntityId", this.Id);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		return true;
	}

	// Token: 0x0601B71F RID: 112415 RVA: 0x007826E4 File Offset: 0x007808E4
	public unsafe void ClearHoldEntity()
	{
		if (CreatureController.Instance.CheckEnableEntityLog(new OneOf<EEntityType, EntityHandle>?((EEntityType)this.EntityType)))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Engine;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "ClearHoldEntity";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", this.Id);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.HoldEntityMap.Clear();
	}

	// Token: 0x170025F9 RID: 9721
	// (get) Token: 0x0601B720 RID: 112416 RVA: 0x0078277D File Offset: 0x0078097D
	public bool Valid
	{
		get
		{
			return CharacterModel.Instance.IsValid(this.Id);
		}
	}

	// Token: 0x170025FA RID: 9722
	// (get) Token: 0x0601B721 RID: 112417 RVA: 0x0078278F File Offset: 0x0078098F
	public bool IsInit
	{
		get
		{
			return this.Valid && this.Entity.IsInit;
		}
	}

	// Token: 0x170025FB RID: 9723
	// (get) Token: 0x0601B722 RID: 112418 RVA: 0x007827A6 File Offset: 0x007809A6
	public bool AllowDestroy
	{
		get
		{
			return this.HoldEntityMap.Count == 0;
		}
	}

	// Token: 0x0601B723 RID: 112419 RVA: 0x007827B6 File Offset: 0x007809B6
	[NullableContext(2)]
	public static bool operator !([NotNullWhen(false)] EntityHandle handle)
	{
		return handle == null || !handle.Valid;
	}

	// Token: 0x0400D731 RID: 55089
	[Nullable(2)]
	public WorldEntity Entity;

	// Token: 0x0400D732 RID: 55090
	public readonly int Id;

	// Token: 0x0400D733 RID: 55091
	public long CreatureDataId;

	// Token: 0x0400D734 RID: 55092
	public int PbDataId;

	// Token: 0x0400D735 RID: 55093
	public EntityConfigType ConfigType;

	// Token: 0x0400D736 RID: 55094
	public int EntityType;

	// Token: 0x0400D737 RID: 55095
	public readonly int Index;

	// Token: 0x0400D738 RID: 55096
	public ResourceSystem.EResourceLoadPriority Priority = ResourceSystem.EResourceLoadPriority.Default;

	// Token: 0x0400D739 RID: 55097
	public bool PendingRemoving;

	// Token: 0x0400D73A RID: 55098
	public bool HasSendingRequest;

	// Token: 0x0400D73B RID: 55099
	public readonly Dictionary<string, int> HoldEntityMap = new Dictionary<string, int>();
}
