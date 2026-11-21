using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200272A RID: 10026
[NullableContext(1)]
[Nullable(0)]
public class EntityHandle
{
	// Token: 0x06019250 RID: 102992 RVA: 0x007AA66E File Offset: 0x007A886E
	public EntityHandle(WorldEntity Entity)
	{
		this.Entity = Entity;
		this.Id = Entity.Id;
		this.Index = Entity.Index;
	}

	// Token: 0x06019251 RID: 102993 RVA: 0x007AA6A8 File Offset: 0x007A88A8
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

	// Token: 0x06019252 RID: 102994 RVA: 0x007AA794 File Offset: 0x007A8994
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

	// Token: 0x06019253 RID: 102995 RVA: 0x007AA8F0 File Offset: 0x007A8AF0
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

	// Token: 0x170027F7 RID: 10231
	// (get) Token: 0x06019254 RID: 102996 RVA: 0x007AA989 File Offset: 0x007A8B89
	public bool Valid
	{
		get
		{
			return CharacterModel.Instance.IsValid(this.Id);
		}
	}

	// Token: 0x170027F8 RID: 10232
	// (get) Token: 0x06019255 RID: 102997 RVA: 0x007AA99B File Offset: 0x007A8B9B
	public bool IsInit
	{
		get
		{
			return this.Valid && this.Entity.IsInit;
		}
	}

	// Token: 0x170027F9 RID: 10233
	// (get) Token: 0x06019256 RID: 102998 RVA: 0x007AA9B2 File Offset: 0x007A8BB2
	public bool AllowDestroy
	{
		get
		{
			return this.HoldEntityMap.Count == 0;
		}
	}

	// Token: 0x06019257 RID: 102999 RVA: 0x007AA9C2 File Offset: 0x007A8BC2
	[NullableContext(2)]
	public static bool operator !([NotNullWhen(false)] EntityHandle handle)
	{
		return handle == null || !handle.Valid;
	}

	// Token: 0x0400DBB8 RID: 56248
	[Nullable(2)]
	public WorldEntity Entity;

	// Token: 0x0400DBB9 RID: 56249
	public readonly int Id;

	// Token: 0x0400DBBA RID: 56250
	public long CreatureDataId;

	// Token: 0x0400DBBB RID: 56251
	public int PbDataId;

	// Token: 0x0400DBBC RID: 56252
	public EntityConfigType ConfigType;

	// Token: 0x0400DBBD RID: 56253
	public int EntityType;

	// Token: 0x0400DBBE RID: 56254
	public readonly int Index;

	// Token: 0x0400DBBF RID: 56255
	public ResourceSystem.EResourceLoadPriority Priority = ResourceSystem.EResourceLoadPriority.Default;

	// Token: 0x0400DBC0 RID: 56256
	public bool PendingRemoving;

	// Token: 0x0400DBC1 RID: 56257
	public bool HasSendingRequest;

	// Token: 0x0400DBC2 RID: 56258
	public readonly Dictionary<string, int> HoldEntityMap = new Dictionary<string, int>();
}
